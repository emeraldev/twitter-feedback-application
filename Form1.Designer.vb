<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_topic = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_post_exe = New System.Windows.Forms.Button()
        Me.txt_exercise = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_per = New System.Windows.Forms.GroupBox()
        Me.btn_saveMarks = New System.Windows.Forms.Button()
        Me.data_marks = New System.Windows.Forms.DataGridView()
        Me.btn_upMarks = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.open_marks = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_saveRegister = New System.Windows.Forms.Button()
        Me.data_register = New System.Windows.Forms.DataGridView()
        Me.btn_upRegister = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.group_datex = New System.Windows.Forms.GroupBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_upload_events = New System.Windows.Forms.Button()
        Me.txt_event = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_save_date = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.date_list = New System.Windows.Forms.ListBox()
        Me.txt_event_date = New System.Windows.Forms.DateTimePicker()
        Me.open_register = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Exercises = New System.Windows.Forms.TabPage()
        Me.Performance = New System.Windows.Forms.TabPage()
        Me.Attendance = New System.Windows.Forms.TabPage()
        Me.Schedule = New System.Windows.Forms.TabPage()
        Me.GroupBox1.SuspendLayout()
        Me.btn_per.SuspendLayout()
        CType(Me.data_marks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.data_register, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_datex.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Exercises.SuspendLayout()
        Me.Performance.SuspendLayout()
        Me.Attendance.SuspendLayout()
        Me.Schedule.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_topic)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_post_exe)
        Me.GroupBox1.Controls.Add(Me.txt_exercise)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_topic
        '
        Me.txt_topic.FormattingEnabled = True
        Me.txt_topic.Items.AddRange(New Object() {"If-Statements", "Loops"})
        Me.txt_topic.Location = New System.Drawing.Point(131, 55)
        Me.txt_topic.Name = "txt_topic"
        Me.txt_topic.Size = New System.Drawing.Size(253, 21)
        Me.txt_topic.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Select the Topic :"
        '
        'btn_post_exe
        '
        Me.btn_post_exe.Location = New System.Drawing.Point(245, 82)
        Me.btn_post_exe.Name = "btn_post_exe"
        Me.btn_post_exe.Size = New System.Drawing.Size(139, 40)
        Me.btn_post_exe.TabIndex = 2
        Me.btn_post_exe.Text = "Post"
        Me.btn_post_exe.UseVisualStyleBackColor = True
        '
        'txt_exercise
        '
        Me.txt_exercise.FormattingEnabled = True
        Me.txt_exercise.Items.AddRange(New Object() {"Python Programs", "Algorithm Design"})
        Me.txt_exercise.Location = New System.Drawing.Point(131, 28)
        Me.txt_exercise.Name = "txt_exercise"
        Me.txt_exercise.Size = New System.Drawing.Size(253, 21)
        Me.txt_exercise.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the Category :"
        '
        'btn_per
        '
        Me.btn_per.Controls.Add(Me.btn_saveMarks)
        Me.btn_per.Controls.Add(Me.data_marks)
        Me.btn_per.Controls.Add(Me.btn_upMarks)
        Me.btn_per.Controls.Add(Me.Label3)
        Me.btn_per.Controls.Add(Me.Label2)
        Me.btn_per.Location = New System.Drawing.Point(6, 0)
        Me.btn_per.Name = "btn_per"
        Me.btn_per.Size = New System.Drawing.Size(395, 296)
        Me.btn_per.TabIndex = 1
        Me.btn_per.TabStop = False
        '
        'btn_saveMarks
        '
        Me.btn_saveMarks.Location = New System.Drawing.Point(336, 383)
        Me.btn_saveMarks.Name = "btn_saveMarks"
        Me.btn_saveMarks.Size = New System.Drawing.Size(119, 35)
        Me.btn_saveMarks.TabIndex = 5
        Me.btn_saveMarks.Text = "Save"
        Me.btn_saveMarks.UseVisualStyleBackColor = True
        '
        'data_marks
        '
        Me.data_marks.BackgroundColor = System.Drawing.SystemColors.Window
        Me.data_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_marks.Location = New System.Drawing.Point(6, 60)
        Me.data_marks.Name = "data_marks"
        Me.data_marks.Size = New System.Drawing.Size(383, 230)
        Me.data_marks.TabIndex = 4
        '
        'btn_upMarks
        '
        Me.btn_upMarks.Location = New System.Drawing.Point(293, 19)
        Me.btn_upMarks.Name = "btn_upMarks"
        Me.btn_upMarks.Size = New System.Drawing.Size(93, 35)
        Me.btn_upMarks.TabIndex = 2
        Me.btn_upMarks.Text = "Upload"
        Me.btn_upMarks.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Columns: student_id, twitter_handle, module, marks (avg)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Upload Excel Spreadsheet of Student Marks"
        '
        'open_marks
        '
        Me.open_marks.FileName = "marks"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_saveRegister)
        Me.GroupBox2.Controls.Add(Me.data_register)
        Me.GroupBox2.Controls.Add(Me.btn_upRegister)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 296)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btn_saveRegister
        '
        Me.btn_saveRegister.Location = New System.Drawing.Point(339, 383)
        Me.btn_saveRegister.Name = "btn_saveRegister"
        Me.btn_saveRegister.Size = New System.Drawing.Size(119, 35)
        Me.btn_saveRegister.TabIndex = 6
        Me.btn_saveRegister.Text = "Save"
        Me.btn_saveRegister.UseVisualStyleBackColor = True
        '
        'data_register
        '
        Me.data_register.BackgroundColor = System.Drawing.SystemColors.Window
        Me.data_register.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_register.Location = New System.Drawing.Point(6, 60)
        Me.data_register.Name = "data_register"
        Me.data_register.Size = New System.Drawing.Size(386, 223)
        Me.data_register.TabIndex = 3
        '
        'btn_upRegister
        '
        Me.btn_upRegister.Location = New System.Drawing.Point(294, 19)
        Me.btn_upRegister.Name = "btn_upRegister"
        Me.btn_upRegister.Size = New System.Drawing.Size(98, 35)
        Me.btn_upRegister.TabIndex = 2
        Me.btn_upRegister.Text = "Upload"
        Me.btn_upRegister.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(282, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Columns: student_id, twitter_handle, attendance (average)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Upload Excel Spreadsheet of Attendance Register"
        '
        'group_datex
        '
        Me.group_datex.Controls.Add(Me.btn_delete)
        Me.group_datex.Controls.Add(Me.btn_upload_events)
        Me.group_datex.Controls.Add(Me.txt_event)
        Me.group_datex.Controls.Add(Me.Label6)
        Me.group_datex.Controls.Add(Me.txt_save_date)
        Me.group_datex.Controls.Add(Me.Button3)
        Me.group_datex.Controls.Add(Me.date_list)
        Me.group_datex.Controls.Add(Me.txt_event_date)
        Me.group_datex.Location = New System.Drawing.Point(6, 0)
        Me.group_datex.Name = "group_datex"
        Me.group_datex.Size = New System.Drawing.Size(395, 299)
        Me.group_datex.TabIndex = 3
        Me.group_datex.TabStop = False
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(159, 250)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(112, 34)
        Me.btn_delete.TabIndex = 8
        Me.btn_delete.Text = "Delete Schedule"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_upload_events
        '
        Me.btn_upload_events.Location = New System.Drawing.Point(277, 250)
        Me.btn_upload_events.Name = "btn_upload_events"
        Me.btn_upload_events.Size = New System.Drawing.Size(112, 34)
        Me.btn_upload_events.TabIndex = 7
        Me.btn_upload_events.Text = "Upload"
        Me.btn_upload_events.UseVisualStyleBackColor = True
        '
        'txt_event
        '
        Me.txt_event.FormattingEnabled = True
        Me.txt_event.Items.AddRange(New Object() {"Test 1", "Test 2", "Assignment 1", "Assignment 2", "Exercises", "Homework", "Semester Exam"})
        Me.txt_event.Location = New System.Drawing.Point(9, 32)
        Me.txt_event.Name = "txt_event"
        Me.txt_event.Size = New System.Drawing.Size(252, 21)
        Me.txt_event.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Select the event and select the date the press enter."
        '
        'txt_save_date
        '
        Me.txt_save_date.Location = New System.Drawing.Point(277, 32)
        Me.txt_save_date.Name = "txt_save_date"
        Me.txt_save_date.Size = New System.Drawing.Size(112, 46)
        Me.txt_save_date.TabIndex = 4
        Me.txt_save_date.Text = "Save"
        Me.txt_save_date.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(345, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 41)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Upload"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'date_list
        '
        Me.date_list.FormattingEnabled = True
        Me.date_list.Location = New System.Drawing.Point(7, 84)
        Me.date_list.Name = "date_list"
        Me.date_list.Size = New System.Drawing.Size(382, 160)
        Me.date_list.TabIndex = 2
        '
        'txt_event_date
        '
        Me.txt_event_date.Location = New System.Drawing.Point(9, 58)
        Me.txt_event_date.Name = "txt_event_date"
        Me.txt_event_date.Size = New System.Drawing.Size(252, 20)
        Me.txt_event_date.TabIndex = 1
        '
        'open_register
        '
        Me.open_register.FileName = "attendance"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Exercises)
        Me.TabControl1.Controls.Add(Me.Performance)
        Me.TabControl1.Controls.Add(Me.Attendance)
        Me.TabControl1.Controls.Add(Me.Schedule)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 328)
        Me.TabControl1.TabIndex = 4
        '
        'Exercises
        '
        Me.Exercises.Controls.Add(Me.GroupBox1)
        Me.Exercises.Location = New System.Drawing.Point(4, 22)
        Me.Exercises.Name = "Exercises"
        Me.Exercises.Padding = New System.Windows.Forms.Padding(3)
        Me.Exercises.Size = New System.Drawing.Size(407, 302)
        Me.Exercises.TabIndex = 0
        Me.Exercises.Text = "Exercises"
        Me.Exercises.UseVisualStyleBackColor = True
        '
        'Performance
        '
        Me.Performance.Controls.Add(Me.btn_per)
        Me.Performance.Location = New System.Drawing.Point(4, 22)
        Me.Performance.Name = "Performance"
        Me.Performance.Padding = New System.Windows.Forms.Padding(3)
        Me.Performance.Size = New System.Drawing.Size(407, 302)
        Me.Performance.TabIndex = 1
        Me.Performance.Text = "Performance"
        Me.Performance.UseVisualStyleBackColor = True
        '
        'Attendance
        '
        Me.Attendance.Controls.Add(Me.GroupBox2)
        Me.Attendance.Location = New System.Drawing.Point(4, 22)
        Me.Attendance.Name = "Attendance"
        Me.Attendance.Padding = New System.Windows.Forms.Padding(3)
        Me.Attendance.Size = New System.Drawing.Size(407, 302)
        Me.Attendance.TabIndex = 2
        Me.Attendance.Text = "Attendance"
        Me.Attendance.UseVisualStyleBackColor = True
        '
        'Schedule
        '
        Me.Schedule.Controls.Add(Me.group_datex)
        Me.Schedule.Location = New System.Drawing.Point(4, 22)
        Me.Schedule.Name = "Schedule"
        Me.Schedule.Padding = New System.Windows.Forms.Padding(3)
        Me.Schedule.Size = New System.Drawing.Size(407, 302)
        Me.Schedule.TabIndex = 3
        Me.Schedule.Text = "Schedule"
        Me.Schedule.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 347)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Setup for Educational Tweet Synthesizer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.btn_per.ResumeLayout(False)
        Me.btn_per.PerformLayout()
        CType(Me.data_marks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.data_register, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_datex.ResumeLayout(False)
        Me.group_datex.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Exercises.ResumeLayout(False)
        Me.Performance.ResumeLayout(False)
        Me.Attendance.ResumeLayout(False)
        Me.Schedule.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_exercise As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_per As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_post_exe As Button
    Friend WithEvents btn_upMarks As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents open_marks As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_upRegister As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents group_datex As GroupBox
    Friend WithEvents open_register As OpenFileDialog
    Friend WithEvents txt_event_date As DateTimePicker
    Friend WithEvents txt_save_date As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents date_list As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_event As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Exercises As TabPage
    Friend WithEvents Performance As TabPage
    Friend WithEvents Attendance As TabPage
    Friend WithEvents Schedule As TabPage
    Friend WithEvents data_register As DataGridView
    Friend WithEvents data_marks As DataGridView
    Friend WithEvents btn_saveMarks As Button
    Friend WithEvents btn_saveRegister As Button
    Friend WithEvents txt_topic As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_upload_events As Button
End Class
