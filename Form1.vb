Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Public Class Main

    Shared random As New Random()
    Dim conn As OleDbConnection
    Dim dta As OleDbDataAdapter
    Dim dts As DataSet
    Dim excel As String
    Dim events_path As String = "C:\result\events\schedule_events.txt"

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles btn_per.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_upRegister.Click
        Dim register As DialogResult = open_register.ShowDialog()

        If register = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_upMarks.Click
        Try
            open_marks.ShowDialog()

            Using MyReader As New Microsoft.VisualBasic.
                            FileIO.TextFieldParser(open_marks.FileName)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Application.DoEvents()
                    Try
                        currentRow = MyReader.ReadFields()
                        With data_marks
                            .ColumnCount = 3
                            Dim row As String() = New String() {currentRow(0), currentRow(1)}
                            .Rows.Add(row)
                        End With

                    Catch ex As Microsoft.VisualBasic.
                                FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                        "is not valid and will be skipped.")
                    End Try
                End While
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub exercise_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_exercise.SelectedIndexChanged

    End Sub

    Private Sub btn_post_exe_Click(sender As Object, e As EventArgs) Handles btn_post_exe.Click
        'Post_to_Twitter.sendDirectMessage("@Sonny_Ish", "This is a test message")
        If String.IsNullOrEmpty(txt_exercise.Text) Then
            MessageBox.Show("Select a category!")
        ElseIf String.IsNullOrEmpty(txt_topic.Text) Then
            MessageBox.Show("Select a topic!")
        Else

            Dim twitter_handle As String = "code_instructor"
            Dim category As String = txt_exercise.Text
            Dim topic As String = txt_topic.Text

            Dim Alltweets As Generic.List(Of Exercise_Tweet) = Tweet_Generator.GenerateExerciseTweets(twitter_handle, topic, category) ' = "This is a post from Classroom #Testtweet"

            For Each t In Alltweets

                Dim countProblem As Integer
                countProblem = 0
                For Each c As Char In t.problem_tweet
                    countProblem += 1
                Next

                Dim countSolution As Integer
                countSolution = 0
                For Each c As Char In t.solution_tweet
                    countSolution += 1
                Next

                Dim pos As Integer = 180


                If (countProblem > 280) Then

                    Dim problem1 As String
                    While (t.problem_tweet.Chars(pos) <> " ")
                        pos -= 1
                    End While
                    problem1 = t.problem_tweet
                    t.problem_tweet = t.problem_tweet.Remove(pos)
                    problem1 = problem1.Remove(0, pos)

                    'MessageBox.Show(t.problem_tweet)
                    'MessageBox.Show(problem1)

                    Post_to_Twitter.postToTwitter(t.problem_tweet)
                    System.Threading.Thread.Sleep(1000)
                    Post_to_Twitter.postToTwitter(problem1)

                Else

                    Post_to_Twitter.postToTwitter(t.problem_tweet)

                End If

                System.Threading.Thread.Sleep(50000)

                If (countSolution > 280) Then

                    Dim solution1 As String
                    While (t.solution_tweet.Chars(pos) <> " ")
                        pos -= 1
                    End While
                    solution1 = t.problem_tweet
                    t.problem_tweet = t.problem_tweet.Remove(pos)
                    solution1 = solution1.Remove(0, pos)

                    'MessageBox.Show(t.problem_tweet)
                    'MessageBox.Show(problem1)

                    Post_to_Twitter.postToTwitter(t.solution_tweet)
                    System.Threading.Thread.Sleep(1000)
                    Post_to_Twitter.postToTwitter(solution1)

                Else

                    Post_to_Twitter.postToTwitter(t.solution_tweet)

                End If

                'MsgBox("Problelm count " + countProblem.ToString + " & Solution count " + countSolution.ToString + " ")
                'MsgBox(t.problem_tweet & vbCrLf & vbCrLf & t.solution_tweet)
            Next

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles txt_save_date.Click

        If String.IsNullOrEmpty(txt_event.Text) Then
            MessageBox.Show("Select an event!")
        ElseIf String.IsNullOrEmpty(txt_event_date.Text) Then
            MessageBox.Show("Select a topic!")
        Else
            Dim dates As String
            dates = txt_event_date.Value.ToString("dd/MM/yyyy")

            date_list.Items.Add(txt_event.Text & " scheduled for " & dates & ",")
            txt_event.Focus()
            Dim events As String = txt_event.Text & " scheduled for " & dates & ","
            Dim event_date As String = Convert.ToString(dates)

            Using SW As New IO.StreamWriter(events_path, True)
                SW.WriteLine(events)
            End Using
        End If

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lines() As String = IO.File.ReadAllLines(events_path)
        date_list.Items.AddRange(lines)

        'Dim colsexpected As Integer = 3
        'Dim reader As New StreamReader(fname, Encoding.Default)
        'Dim sline As String = ""
        'Do
        '    sline = reader.ReadLine
        '    If sline Is Nothing Then Exit Do
        '    Dim words() As String = sline.Split(",")
        '    data_marks.Rows.Add("")
        '    If words.Length = colsexpected Then
        '        For ix As Integer = 0 To 2
        '            data_marks.Rows(data_marks.Rows.Count - 1).Cells(ix).Value = words(ix)
        '        Next

        '        If Not IsNumeric(words(0)) Then data_marks.Rows(data_marks.Rows.Count - 1).Cells(0).Style.BackColor = Color.Yellow
        '        If Not IsNumeric(words(2)) Then data_marks.Rows(data_marks.Rows.Count - 1).Cells(2).Style.BackColor = Color.Yellow
        '    Else
        '        data_marks.Rows(data_marks.Rows.Count - 1).Cells(0).Value = "error"
        '        data_marks.Rows(data_marks.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Pink
        '    End If

        'Loop
        'reader.Close()

        Dim csvMarks As DataTable = Student.ConvertCSVToMarksTable()
        With csvMarks.Columns
            .Item(0).DataType = GetType(Int32)
            .Item(2).DataType = GetType(Int32)
        End With

        data_marks.DataSource = csvMarks

        Dim csvAttendance As DataTable = Student.ConvertCSVToAttendanceTable()
        With csvAttendance.Columns
            .Item(0).DataType = GetType(Int32)
            .Item(2).DataType = GetType(Int32)
            .Item(1).MaxLength = 200

        End With

        data_register.DataSource = csvAttendance

    End Sub

    Private Sub event_date_ValueChanged(sender As Object, e As EventArgs) Handles txt_event_date.ValueChanged

    End Sub

    Private Sub btn_upload_events_Click(sender As Object, e As EventArgs) Handles btn_upload_events.Click

        Dim Alltweets As Generic.List(Of Event_Tweet) = Tweet_Generator.GenerateScheduleTweet() ' = "This is a post from Classroom #Testtweet"

        For Each t In Alltweets

            MsgBox(t.event_tweet & vbCrLf & vbCrLf)

            Post_to_Twitter.postToTwitter(t.event_tweet)
        Next

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        System.IO.File.WriteAllText(events_path, "")
        date_list.Items.Clear()
    End Sub

End Class
