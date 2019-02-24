Public Class Game





    Dim ShapeToDraw As Integer = 0 ' determines which shape is to be drawn in shape_paint subroutine
    Dim currentUser As user ' structure found in main page as global structure
    Dim timeLimit, TimeRemaining, correct As Integer ' thet timelimt for a question, and the time remaining on said question
    Dim ScoreInteger As Integer = 0 ' to store their score in the current session
    ' if it the firstime they are answering a question
    ' if they are quitting, so the exit button doesn't spam the data of the current session
    ' if they can press one of the answer buttons
    Dim firstime = True, canAnswer As Boolean = False



    Private Sub Game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load ' loaded as the page loads
        currentUser = Main_page.getUser() ' gets   Information of the current user

    End Sub

    Sub stat() Handles statistics.Click ' shows their statistics

        ' displays the users current stats
        MessageBox.Show("HighScore:" & currentUser.maxScore _
                        & vbNewLine & "Times PLayed: " & currentUser.timesPlayed _
                        & vbNewLine & "Total Score: " & currentUser.totalScore & vbNewLine &
                        "Average Score: " & currentUser.averageScore _
                        , "USER STATS", 0)
    End Sub


    Sub clear() ' clears the screen of any previous text from the previous question
        ShapeToDraw = 0
        Me.Invalidate() ' clears the drawing
        ' clears the labels
        Height.Text = Nothing
        width.Text = Nothing
        AltHeight.Text = Nothing
        altwidth.Text = Nothing
        radius.Text = Nothing

    End Sub

    Private Sub info() Handles Start.Click ' when they start the game
        Start.Hide()
        Randomize()
        ScoreInteger = 0 ' sets score to 0
        timer.Interval = 50
        HighScore.Text = "HighScore: " & currentUser.maxScore ' sets highscore to their highscore
        Score.Text = "Score: " & ScoreInteger
        timeLimit = 20000 ' sets starting time limit to 20 seconds
        ' shows a messagebox to show useful information
        MessageBox.Show("Value used for Pi is 3.14" & vbNewLine & "Time limit at start is 20 secs" & vbNewLine &
                        "Time decreases by 0.2s every question if correct the first time, 0.5s if correct the second, and a whole second if just wrong", "INFO", 0)
        game() ' starts a new question
    End Sub

    Private Sub game() ' generates every new question

        firstime = True ' first time on the new question, so they can earn maxiumum points
        clear() ' clears the screen of any previous elements
        Select Case Math.Ceiling(Rnd() * 4) ' selects a random shape to draw
            Case 1
                correct = Square()' stores which button is correct (1 or 2 or 3)
            Case 2
                correct = triangle()
            Case 3
                correct = circle()
            Case 4
                correct = trapezium()
            Case Else
                MessageBox.Show("ERROR 3241, REPORT IMMEDIATELY", "ERROR", 0)

        End Select
        If timeLimit <= 0 Then ' if they run out of time to answer questions (will typically be impssible at 1000, but some people are not actually people)
            canAnswer = False
            MessageBox.Show("GAMEOVER")
            saveAndExit()


        Else
            TimeRemaining = timeLimit ' sets the remaing time to the time left for a question
            countdown.Maximum = timeLimit ' sets the progress bar denominator to the whole time limit
            countdown.Value = TimeRemaining ' sets the numerator to time left

            timer.Interval = 50
            canAnswer = True
            timer.Start() ' stars the question timer

        End If
















    End Sub

    Function triangle() ' generates triangle questions
        Dim x As Integer = Math.Ceiling(Rnd() * 30) ' random height and width
        Dim y As Integer = Math.Ceiling(Rnd() * 30)


        ShapeToDraw = 1 ' sets the shape to draw to a triangle
        AltHeight.Text = x
        width.Text = y
        Me.Refresh()
        Return options(y * x * 0.5) ' sends the answer to options



    End Function

    Function trapezium() ' generates trapezium questions
        Dim x As Integer = Math.Ceiling(Rnd() * 30) ' random height, and two widths
        Dim y As Integer = Math.Ceiling(Rnd() * 30)
        Dim z As Integer = Math.Ceiling(Rnd() * 30)
        Height.Text = z
        width.Text = y
        altwidth.Text = x
        ShapeToDraw = 4 ' sets the shape to draw to a trapezium
        Me.Refresh() ' draws
        Return options(x * y * z * 0.5) ' sends the answer to options







    End Function


    Function Square() ' generates square questions
        Dim x As Integer = Math.Ceiling(Rnd() * 30) ' random x and y values (1-30)
        Dim y As Integer = Math.Ceiling(Rnd() * 30)
        ShapeToDraw = 2 ' sets the shape to draw to circle
        Height.Text = x
        width.Text = y
        Me.Refresh() ' draws the square
        Return options(x * y) ' sends the answer to options



    End Function



    Function circle() ' for generating questions for the circle shape
        Dim rad As Integer = Math.Ceiling(Rnd() * 30) ' sets the radius to a random number 1-30
        ShapeToDraw = 3 ' sets the shape to be drawn to a circle
        Me.Refresh() ' draws said circle
        radius.Text = rad ' sets the test of the radius label to the radius
        Return options(rad * 3.14 * rad) ' sends the answer to the options function

    End Function

    Function options(ByVal answer As Double) ' generates which option is correct, and randomises the other two
        Dim rand As New Random

        Select Case Math.Ceiling(Rnd() * 3)
            Case 1 ' the first one is the correct one
                AnswerONE.Text = answer
                AnswerTwo.Text = (answer) + rand.Next(10)
                AnswerThree.Text = (answer) + rand.Next(10)
                Return 1
            Case 2 ' the second one is correct
                AnswerONE.Text = answer + rand.Next(10)
                AnswerTwo.Text = (answer)
                AnswerThree.Text = (answer) + rand.Next(10)
                Return 2
            Case 3 ' the third one is the correct
                AnswerONE.Text = answer + rand.Next(10)
                AnswerTwo.Text = (answer) + rand.Next(10)
                AnswerThree.Text = (answer)
                Return 3
            Case Else
                MessageBox.Show("ERROR 2341, REPORT IMMEDIATELY", "ERROR", MessageBoxButtons.OK) ' ANYTHING ELSE IS AN error
                Return 0
        End Select

    End Function

    Private Sub retry() ' restarts a questions time
        TimeRemaining = timeLimit
        countdown.Maximum = timeLimit
        countdown.Value = TimeRemaining

        timer.Interval = 50
        canAnswer = True
        timer.Start()

    End Sub






    Private Sub checker(ByVal button As Integer) 'checks how many points to add if they pressed the correct button

        If firstime Then ' if is the firstime answering the question
            If button = correct Then
                MessageBox.Show("CORRECT, +2 points", "FIRST TRY", 0) ' adds two points if they get it right

                ScoreInteger += 2 ' adds two score
                Score.Text = "Score: " & ScoreInteger
                timeLimit -= 200 ' decreases the timelimit by 0.2 secs
                game() ' goes onto a new question
            Else
                MessageBox.Show("INCORRECT, ONTO THE SECOND TRY", "WRONG", 0)
                firstime = False ' it is now their seconds attemt
                retry() ' resets time limit
            End If


        Else
            If correct = button Then ' if they get it right the second time
                MessageBox.Show("CORRECT, +1 point", "SECOND TRY", 0)
                ScoreInteger += 1
                timeLimit -= 500 ' decreases timelimit by 0.5secs
                Score.Text = "Score: " & ScoreInteger
                game()
            Else
                Dim RESULT As DialogResult = MessageBox.Show("WRONG, WOULD YOU LIKE TO QUIT?", "WRONG TWICE", MessageBoxButtons.YesNo) ' asks if they want to continue
                If RESULT = DialogResult.No Then
                    timeLimit -= 1000 ' decreases time limit by a second
                    game() ' new question
                ElseIf RESULT = DialogResult.Yes Then
                    saveAndExit() ' saves and exits
                End If



            End If

        End If


    End Sub


    Private Sub AnswerONE_Click(sender As Object, e As EventArgs) Handles AnswerONE.Click
        If canAnswer = True Then
            timer.Stop() ' stops timer, and tells checker they answered option 1
            checker(1)
        End If
    End Sub

    Private Sub AnswerTwo_Click(sender As Object, e As EventArgs) Handles AnswerTwo.Click
        If canAnswer = True Then
            timer.Stop() ' stops timer, and tells checker they answered option 2
            checker(2)
        End If
    End Sub

    Private Sub AnswerThree_Click(sender As Object, e As EventArgs) Handles AnswerThree.Click
        If canAnswer = True Then
            timer.Stop() ' stops timer, and tells checker they answered option 3
            checker(3)
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        TimeRemaining -= 50
        If TimeRemaining >= 0 Then ' updates the timer
            countdown.Value = TimeRemaining
        Else ' when they run out of time
            timer.Stop()
            canAnswer = False
            If firstime Then
                MessageBox.Show("TIMES UP, RETRYING QUESTION", "TIME's UP", 0) 'retries the question
                firstime = False
                retry()
            Else
                Dim RES As DialogResult = MessageBox.Show("TIME'S UP, WOULD YOU LIKE TO QUIT", "TIMES UP", MessageBoxButtons.YesNo) ' asks if they want to continue, or save and quit
                If RES = DialogResult.Yes Then
                    saveAndExit()

                Else
                    game()
                End If


            End If



        End If
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Me.Close()

    End Sub

    Private Sub shape_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint ' decides which shape is to be drawn based on the question
        Select Case ShapeToDraw
            Case 0 ' zero it draws nothing

            Case 1 ' if one it draws a triangle (right angled)
                Dim gp As New Drawing2D.GraphicsPath
                gp.AddLine(225, 93, 575, 360)
                gp.AddLine(575, 360, 225, 360)
                gp.AddLine(225, 360, 225, 93)
                e.Graphics.FillPath(Brushes.Red, gp)

            Case 2 ' if two it draws a rectangle
                Dim gp As New Drawing2D.GraphicsPath
                gp.AddLine(225, 93, 575, 93)
                gp.AddLine(575, 93, 575, 360)
                gp.AddLine(575, 360, 225, 360)
                gp.AddLine(225, 360, 225, 93)

                e.Graphics.FillPath(Brushes.Red, gp)

            Case 3 ' if three it draws a circle

                e.Graphics.DrawEllipse(Pens.Red, 273, 93, 260, 260)
                e.Graphics.DrawLine(Pens.Red, 273, 223, 533, 223)
            Case 4 ' if four it draws a trapezium
                Dim gp As New Drawing2D.GraphicsPath
                gp.AddLine(225, 360, 575, 360)
                gp.AddLine(275, 93, 525, 93)
                gp.AddLine(225, 360, 275, 93)
                gp.AddLine(575, 360, 525, 93)

                e.Graphics.FillPath(Brushes.Red, gp)


            Case Else
                MessageBox.Show("ERROR 1432, REPORT IMMEDIATELY", "ERROR", MessageBoxButtons.OK) ' ANYTHING ELSE IS AN error

        End Select
    End Sub

    Private Sub saveAndExit() ' saves the session
        currentUser.timesPlayed += 1 ' adds a time played
        currentUser.totalScore += ScoreInteger ' adds to their total score
        currentUser.averageScore = currentUser.totalScore / currentUser.timesPlayed ' calculates new average score
        If ScoreInteger > currentUser.maxScore Then ' if the session score is higher than their high score, it is the new high score
            currentUser.maxScore = ScoreInteger
        End If
        save() ' saves
        Start.Show()

        clear()
        timer.Stop()
    End Sub

    Sub save() ' saves the current user to their file
        Dim write As New System.IO.StreamWriter(Main_page.folder & currentUser.username & ".txt", False) ' recreates the file (with the username as the file name)
        write.WriteLine(currentUser.password) ' password first line
        write.WriteLine(currentUser.maxScore) ' high score second line
        write.WriteLine(currentUser.totalScore) ' total third line
        write.WriteLine(currentUser.timesPlayed) ' times played 4th line
        write.WriteLine(currentUser.averageScore) '  average 5th line
        write.Close() ' saves the new file
    End Sub

    Private Sub gameClose(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing ' warns them if they just close they will lose their data
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you want to close" & vbNewLine & "All unsaved data will be lost", "ARE you sure", MessageBoxButtons.OKCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True

            Else
                Main_page.Show()
            End If


    End Sub

End Class