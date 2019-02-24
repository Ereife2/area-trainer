<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AnswerONE = New System.Windows.Forms.Button()
        Me.AnswerTwo = New System.Windows.Forms.Button()
        Me.AnswerThree = New System.Windows.Forms.Button()
        Me.Score = New System.Windows.Forms.Label()
        Me.quit = New System.Windows.Forms.Button()
        Me.HighScore = New System.Windows.Forms.Label()
        Me.width = New System.Windows.Forms.Label()
        Me.Height = New System.Windows.Forms.Label()
        Me.altwidth = New System.Windows.Forms.Label()
        Me.AltHeight = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.countdown = New System.Windows.Forms.ProgressBar()
        Me.Start = New System.Windows.Forms.Button()
        Me.radius = New System.Windows.Forms.Label()
        Me.statistics = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AnswerONE
        '
        Me.AnswerONE.Location = New System.Drawing.Point(170, 385)
        Me.AnswerONE.Name = "AnswerONE"
        Me.AnswerONE.Size = New System.Drawing.Size(153, 68)
        Me.AnswerONE.TabIndex = 2
        Me.AnswerONE.Text = "0"
        Me.AnswerONE.UseVisualStyleBackColor = True
        '
        'AnswerTwo
        '
        Me.AnswerTwo.Location = New System.Drawing.Point(329, 385)
        Me.AnswerTwo.Name = "AnswerTwo"
        Me.AnswerTwo.Size = New System.Drawing.Size(153, 68)
        Me.AnswerTwo.TabIndex = 3
        Me.AnswerTwo.Text = "0"
        Me.AnswerTwo.UseVisualStyleBackColor = True
        '
        'AnswerThree
        '
        Me.AnswerThree.Location = New System.Drawing.Point(488, 385)
        Me.AnswerThree.Name = "AnswerThree"
        Me.AnswerThree.Size = New System.Drawing.Size(153, 68)
        Me.AnswerThree.TabIndex = 4
        Me.AnswerThree.Text = "0"
        Me.AnswerThree.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Location = New System.Drawing.Point(13, 13)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(44, 13)
        Me.Score.TabIndex = 5
        Me.Score.Text = "Score:0"
        '
        'quit
        '
        Me.quit.Location = New System.Drawing.Point(733, 353)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(75, 23)
        Me.quit.TabIndex = 6
        Me.quit.Text = "EXIT"
        Me.quit.UseVisualStyleBackColor = True
        '
        'HighScore
        '
        Me.HighScore.AutoSize = True
        Me.HighScore.Location = New System.Drawing.Point(711, 9)
        Me.HighScore.Name = "HighScore"
        Me.HighScore.Size = New System.Drawing.Size(75, 13)
        Me.HighScore.TabIndex = 7
        Me.HighScore.Text = "High Score : 0"
        '
        'width
        '
        Me.width.AutoSize = True
        Me.width.Location = New System.Drawing.Point(381, 360)
        Me.width.Name = "width"
        Me.width.Size = New System.Drawing.Size(0, 13)
        Me.width.TabIndex = 9
        '
        'Height
        '
        Me.Height.AutoSize = True
        Me.Height.Location = New System.Drawing.Point(582, 212)
        Me.Height.Name = "Height"
        Me.Height.Size = New System.Drawing.Size(0, 13)
        Me.Height.TabIndex = 10
        '
        'altwidth
        '
        Me.altwidth.AutoSize = True
        Me.altwidth.Location = New System.Drawing.Point(384, 74)
        Me.altwidth.Name = "altwidth"
        Me.altwidth.Size = New System.Drawing.Size(0, 13)
        Me.altwidth.TabIndex = 11
        '
        'AltHeight
        '
        Me.AltHeight.AutoSize = True
        Me.AltHeight.Location = New System.Drawing.Point(170, 212)
        Me.AltHeight.Name = "AltHeight"
        Me.AltHeight.Size = New System.Drawing.Size(0, 13)
        Me.AltHeight.TabIndex = 12
        '
        'timer
        '
        '
        'countdown
        '
        Me.countdown.Location = New System.Drawing.Point(225, 13)
        Me.countdown.Name = "countdown"
        Me.countdown.Size = New System.Drawing.Size(350, 27)
        Me.countdown.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.countdown.TabIndex = 13
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Start.Location = New System.Drawing.Point(225, 93)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(350, 267)
        Me.Start.TabIndex = 14
        Me.Start.Text = "START GAME"
        Me.Start.UseVisualStyleBackColor = False
        '
        'radius
        '
        Me.radius.AutoSize = True
        Me.radius.Location = New System.Drawing.Point(403, 233)
        Me.radius.Name = "radius"
        Me.radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radius.Size = New System.Drawing.Size(0, 13)
        Me.radius.TabIndex = 16
        '
        'statistics
        '
        Me.statistics.Location = New System.Drawing.Point(733, 324)
        Me.statistics.Name = "statistics"
        Me.statistics.Size = New System.Drawing.Size(75, 23)
        Me.statistics.TabIndex = 17
        Me.statistics.Text = "STATS"
        Me.statistics.UseVisualStyleBackColor = True
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 485)
        Me.Controls.Add(Me.statistics)
        Me.Controls.Add(Me.radius)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.countdown)
        Me.Controls.Add(Me.AltHeight)
        Me.Controls.Add(Me.altwidth)
        Me.Controls.Add(Me.Height)
        Me.Controls.Add(Me.width)
        Me.Controls.Add(Me.HighScore)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.AnswerThree)
        Me.Controls.Add(Me.AnswerTwo)
        Me.Controls.Add(Me.AnswerONE)
        Me.Name = "Game"
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AnswerONE As System.Windows.Forms.Button
    Friend WithEvents AnswerTwo As System.Windows.Forms.Button
    Friend WithEvents AnswerThree As System.Windows.Forms.Button
    Friend WithEvents Score As System.Windows.Forms.Label
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents HighScore As Label
    Friend WithEvents width As Label
    Friend WithEvents Height As Label
    Friend WithEvents altwidth As Label
    Friend WithEvents AltHeight As Label
    Friend WithEvents timer As Timer
    Friend WithEvents countdown As ProgressBar
    Friend WithEvents Start As Button
    Friend WithEvents radius As Label
    Friend WithEvents statistics As Button
End Class
