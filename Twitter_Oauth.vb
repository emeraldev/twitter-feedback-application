Imports System.Text

Public Class Twitter_Oauth

    Public Shared oauth_consumer_key As String = "YhXLUCrph8gujrNOdbFYAY68p"
    Public Shared oauth_consumer_secret As String = "kWkrTORMFdFH00rKIC5Oaw83SPPGHTQdqyc7Kw2krzqGcw97Si"
    Public Shared oauth_token As String = "1097515429734612992-s2EEYowoJPUOnmSrvxCQhzulSYfq5Y"
    Public Shared oauth_token_secret As String = "CoybL7HkdEWlFRiWAR4YcFGHcTgKnICHXCLJScI5D4TDs"
    Public Shared oauth_version As String = "1.0"
    Public Shared oauth_signature_method As String = "HMAC-SHA1"
    Public Shared oauth_nonce As String = Convert.ToBase64String(New ASCIIEncoding().GetBytes(DateTime.Now.Ticks.ToString()))
    Public Shared username As String = "201408408@student.uj.ac.za"
    Public Shared password As String = "@emeraldev"

End Class
