Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class Tweet_Generator
    Public Shared rng As New Random

    Public Shared Function loadProblemsAndSolutions() As Generic.List(Of Problems_and_Solutions)
        Dim All_PS As New Generic.List(Of Problems_and_Solutions)

        Dim problem_file As String = File.ReadAllText("C:\result\question_bank\q2.txt")

        Dim problems As New ArrayList
        problems.AddRange(problem_file.Split("***"))

        Dim sol_file As String = File.ReadAllText("C:\result\question_bank\a2.txt")

        Dim solutions As New ArrayList
        solutions.AddRange(sol_file.Split("***"))

        For i As Integer = 0 To problems.Count - 1
            Dim aPandS As New Problems_and_Solutions
            With aPandS
                .problem = problems(i).ToString.Trim
                .solution = solutions(i).ToString.Trim
            End With
            If Not (aPandS.problem.ToString.Trim = "") Then All_PS.Add(aPandS)
        Next

        Return All_PS

    End Function

    Public Shared Function GenerateExerciseTweets(handle As String, topic As String, category As String) As Generic.List(Of Exercise_Tweet)


        Dim AllPS As Generic.List(Of Problems_and_Solutions) = Tweet_Generator.loadProblemsAndSolutions()
        Dim AllTweets As New Generic.List(Of Exercise_Tweet)


        Dim tweet As String = ""

        Dim problem_templates As ArrayList = ReadLinesFromFile("C:\result\templates\problem.txt")
        Dim solution_templates As ArrayList = ReadLinesFromFile("C:\result\templates\solution.txt")



        Dim rand_tem As Integer
        rand_tem = rng.Next(0, problem_templates.Count)

        Dim problem_tweet_temp As String = problem_templates(4)
        Dim solution_tweet_temp As String = solution_templates(0)


        'create tweet
        '"@[handle], check out this exercise: [problem_no]: [problem_text]. This problem is on [topic] and the solution is tweeted with #[solution_tag] #DEV1A_DailyExercises. 
        '"@[handle], check out the solution to [problem_no]: [solution_text] #[solution_tag] #DEV1A_DailyExercises.
        Dim count As Integer = 1
        For Each PS In AllPS
            Dim problem_tweet As String = ""
            Dim sol_tweet As String = ""

            'generate problem tweets
            problem_tweet = problem_tweet_temp.Replace("[handle]", handle)
            problem_tweet = problem_tweet.Replace("[problem_no]", count)
            problem_tweet = problem_tweet.Replace("[category]", category)
            problem_tweet = problem_tweet.Replace("[problem_text]", PS.problem)
            problem_tweet = problem_tweet.Replace("[topic]", topic)
            problem_tweet = problem_tweet.Replace("[solution_tag]", "SolutionToProblem" & count)

            'generate solution tweets
            sol_tweet = solution_tweet_temp.Replace("[handle]", handle)
            sol_tweet = sol_tweet.Replace("[problem_no]", count)
            sol_tweet = sol_tweet.Replace("[category]", category)
            sol_tweet = sol_tweet.Replace("[solution_text]", PS.solution)
            sol_tweet = sol_tweet.Replace("[solution_tag]", "SolutionToProblem" & count)

            'add up
            Dim aTweet As New Exercise_Tweet
            aTweet.problem_tweet = problem_tweet
            aTweet.solution_tweet = sol_tweet

            AllTweets.Add(aTweet)


        Next

        Return AllTweets

    End Function


    Public Shared Function ReadLinesFromFile(filename As String) As ArrayList
        Dim lines As New ArrayList

        Dim fields As String()
        Dim delimiter As String = ","
        Using parser As New TextFieldParser(filename)
            parser.SetDelimiters(delimiter)
            While Not parser.EndOfData
                ' Read in the fields for the current line
                fields = parser.ReadFields()
                ' Add code here to use data in fields variable.
                For Each s As String In fields
                    lines.Add(s)
                Next
            End While
        End Using

        Return lines
    End Function

    Public Shared Function ReadExcelFromFile() As Generic.List(Of Student)

        Dim filename As String = "C:\‪C:\result\csv\marks.csv"
        Dim fields As String()
        Dim delimiter As String = ","
        Using parser As New TextFieldParser(filename)
            parser.SetDelimiters(delimiter)
            While Not parser.EndOfData
                ' Read in the fields for the current line
                fields = parser.ReadFields()
                ' Add code here to use data in fields variable.

            End While
        End Using

        Return Nothing
    End Function

    Public Shared Function loadSchedule() As Generic.List(Of Schedule)
        Dim All_EVENTS As New Generic.List(Of Schedule)

        Dim eventsfile As String = File.ReadAllText("C:\result\events\schedule_events.txt")

        Dim events As New ArrayList
        events.AddRange(eventsfile.Split(","))

        For i As Integer = 0 To events.Count - 1
            Dim schedule As New Schedule
            With schedule
                .events = events(i).ToString.Trim
            End With
            If Not (schedule.events.ToString.Trim = "") Then All_EVENTS.Add(schedule)
        Next

        Return All_EVENTS

    End Function

    Public Shared Function GenerateScheduleTweet() As Generic.List(Of Event_Tweet)

        Dim AllEvents As Generic.List(Of Schedule) = Tweet_Generator.loadSchedule()
        Dim AllTweets As New Generic.List(Of Event_Tweet)

        Dim schedule_templates As ArrayList = ReadLinesFromFile("C:\result\templates\schedule.txt")

        Dim schedule_tweet_temp As String = schedule_templates(0)

        For Each EV In AllEvents
            Dim schedule_tweet As String = ""

            'generate problem tweets
            schedule_tweet = schedule_tweet_temp.Replace("[event]", EV.events)
            'schedule_tweet = schedule_tweet.Replace("[date]", "20/05/2019")
            schedule_tweet = schedule_tweet.Replace("[event_tag]", "DSW1A_Schedule")

            'add up
            Dim aTweet As New Event_Tweet
            aTweet.event_tweet = schedule_tweet

            AllTweets.Add(aTweet)

        Next
        Return AllTweets

    End Function

End Class
