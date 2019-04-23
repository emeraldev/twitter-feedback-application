Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Public Class Post_to_Twitter

    Public Shared Sub postToTwitter(ByVal tweet As String)
        Dim twitterURL As String = "https://api.twitter.com/1.1/statuses/update.json"
        Dim timeSpan As System.TimeSpan = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc))
        Dim oauth_timestamp As String = Convert.ToInt64(timeSpan.TotalSeconds).ToString()
        Dim baseFormat As String = "oauth_consumer_key={0}&oauth_nonce={1}&oauth_signature_method={2}" & "&oauth_timestamp={3}&oauth_token={4}&oauth_version={5}&status={6}"
        Dim baseString As String = String.Format(baseFormat, Twitter_Oauth.oauth_consumer_key, Twitter_Oauth.oauth_nonce, Twitter_Oauth.oauth_signature_method, oauth_timestamp, Twitter_Oauth.oauth_token, Twitter_Oauth.oauth_version, Uri.EscapeDataString(tweet))
        Dim oauth_signature As String = Nothing

        Using hasher As HMACSHA1 = New HMACSHA1(ASCIIEncoding.ASCII.GetBytes(Uri.EscapeDataString(Twitter_Oauth.oauth_consumer_secret) & "&" + Uri.EscapeDataString(Twitter_Oauth.oauth_token_secret)))
            oauth_signature = Convert.ToBase64String(hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes("POST&" & Uri.EscapeDataString(twitterURL) & "&" + Uri.EscapeDataString(baseString))))
        End Using

        Dim authorizationFormat As String = "OAuth oauth_consumer_key=""{0}"", oauth_nonce=""{1}"", " & "oauth_signature=""{2}"", oauth_signature_method=""{3}"", " & "oauth_timestamp=""{4}"", oauth_token=""{5}"", " & "oauth_version=""{6}"""
        Dim authorizationHeader As String = String.Format(authorizationFormat, Uri.EscapeDataString(Twitter_Oauth.oauth_consumer_key), Uri.EscapeDataString(Twitter_Oauth.oauth_nonce), Uri.EscapeDataString(oauth_signature), Uri.EscapeDataString(Twitter_Oauth.oauth_signature_method), Uri.EscapeDataString(oauth_timestamp), Uri.EscapeDataString(Twitter_Oauth.oauth_token), Uri.EscapeDataString(Twitter_Oauth.oauth_version))
        Dim objHttpWebRequest As HttpWebRequest = CType(WebRequest.Create(twitterURL), HttpWebRequest)
        objHttpWebRequest.Headers.Add("Authorization", authorizationHeader)
        objHttpWebRequest.Method = "POST"
        objHttpWebRequest.ContentType = "application/x-www-form-urlencoded"

        Using objStream As Stream = objHttpWebRequest.GetRequestStream()
            Dim content As Byte() = ASCIIEncoding.ASCII.GetBytes("status=" & Uri.EscapeDataString(tweet))
            objStream.Write(content, 0, content.Length)
        End Using

        Dim responseResult = ""

        Try
            Dim objWebResponse As WebResponse = objHttpWebRequest.GetResponse()
            Dim objStreamReader As StreamReader = New StreamReader(objWebResponse.GetResponseStream())
            responseResult = objStreamReader.ReadToEnd().ToString()
        Catch ex As Exception
            responseResult = "Twitter Post Error: " & ex.Message.ToString() & ", authHeader: " & authorizationHeader
        End Try
    End Sub

    Public Shared Sub sendDirectMessage(ByVal recipient As String, ByVal message As String)
        Dim messageRequest As HttpWebRequest = CType(WebRequest.Create("http://twitter.com/direct_messages/new.xml?user=" & recipient & "&text=" & message), HttpWebRequest)
        messageRequest.Method = "POST"
        messageRequest.Credentials = New NetworkCredential(Twitter_Oauth.username, Twitter_Oauth.password)
        messageRequest.ContentLength = 0
        messageRequest.ContentType = "application/x-www-form-urlencoded"
        Dim response As WebResponse = messageRequest.GetResponse()
    End Sub

End Class
