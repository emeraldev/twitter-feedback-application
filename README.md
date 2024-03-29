# Educational Tweet Synthesiser
# About
Social Media has been recognised as a supportive tool in Education, creating benefits that supplement student collaboration, class interactions and communication between instructors and students. Active informal interactions and feedback between instructors and students outside class is one of the main reasons behind Social Media pedagogy. With many innovative usage methods of Social Media in Education this creates new opportunities, one being automatic feedback for students. Despite the prevalence of traditional email methods of providing feedback to students, many studies show that they do not check their emails as frequent as they check their Social Media accounts. 

This application generates feedback messages and tweets using a Context-free Grammars (CFG). Our design takes a class list of students and their mark sheets and automatically composes tweets (using the CFG rules) about statistical "fun facts" about programming problems, exercises, class performances, and private messages about individual student performances. These tweets and messages are then pushed to Twitter using Twitter's Application Programming Interface (API).

# How it Works
This tool, developed using the .Net framework. The tool is divided into four sections for each category of the tweet categories namely exercises/solutions, student performance, attendance and schedule. With an exercise tweet, we first select a programming category and topic for the desired tweets. For instance, the category would be algorithm design and the topic if-statements. With those selections a problem exercise and solution is automatically generated. This generates procedural practice algorithms and programs in Python.

The problem and solution are then passed through the tweet synthesizer to post a broadcast exercise tweet with a problem and solution at an interval. The Tweet Synthesiser generated 500 tweet exercises and 500 tweet solutions for their corresponding questions in a minute of execution. A five second interval is placed between the posting of each of tweet to avoid flooding the Twitter API.

Performance and attendance tweets work similarly, we select a class list with the fields (student_id,twitter_handle,moduleandmarks/attendance) as a CSV file. With that information, we compose custom tweet messages depending on their performance average and class attendance, that are sent directly to students. We generate schedule/deadline tweets from a digital study-guide by adding important events or dates. 

Publication: https://bit.ly/2kBVUCA
