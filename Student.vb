Public Class Student

    Public student_id As String
    Public twitter_handle As String
    Public marks As Double
    Public attendance As Integer

    Public Shared Function ConvertCSVToMarksTable() As DataTable

        Dim path As String = "C:\result\csv\marks.csv"

        Dim dt As DataTable = New DataTable()
        Using con As OleDb.OleDbConnection = New OleDb.OleDbConnection()
            Try
                con.ConnectionString = String.Format("Provider={0};Data Source={1};Extended Properties=""Text;HDR=YES;FMT=Delimited""", "Microsoft.Jet.OLEDB.4.0", IO.Path.GetDirectoryName(path))
                Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM " & IO.Path.GetFileName(path), con)
                    Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        con.Open()
                        da.Fill(dt)
                        con.Close()
                    End Using
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            Finally
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End Using

        Return dt
    End Function

    Public Shared Function ConvertCSVToAttendanceTable() As DataTable

        Dim path As String = "C:\result\csv\attendance.csv"

        Dim dt As DataTable = New DataTable()
        Using con As OleDb.OleDbConnection = New OleDb.OleDbConnection()
            Try
                con.ConnectionString = String.Format("Provider={0};Data Source={1};Extended Properties=""Text;HDR=YES;FMT=Delimited""", "Microsoft.Jet.OLEDB.4.0", IO.Path.GetDirectoryName(path))
                Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM " & IO.Path.GetFileName(path), con)
                    Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        con.Open()
                        da.Fill(dt)
                        con.Close()
                    End Using
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            Finally
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End Using

        Return dt
    End Function

End Class
