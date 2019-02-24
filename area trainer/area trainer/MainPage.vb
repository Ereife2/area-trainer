Imports System.Data
Imports System.IO

' structure to group all info about the current user together, and increase readability
Structure user
    Dim username As String
    Dim password As String
    Dim maxScore As Integer
    Dim totalScore As Integer
    Dim timesPlayed As Integer
    Dim averageScore As Double
End Structure


Public Class Main_page



    Public folder As String = "N:\AreaTrainer_Ereife\"
    Dim currentUser As user






    ' in order to give th edetails of the current user to the game window
    ReadOnly Property getUser()
        Get
            Return currentUser
        End Get

    End Property

    Private Sub Main_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightBlue ' set the back color to blue
        Password.PasswordChar() = "*" ' obscures the characters entered in the password field
        ' checks if the n drive exists(for school computers)
        If Directory.Exists("N:\") Then
            folder = "N:\AreaTrainer_Ereife\"
        Else
            folder = "C:\AreaTrainer_Ereife\" ' if it doesn't, the files will save on the c drive which all computers have
        End If

        If Not Directory.Exists(folder) Then ' if the file folder doesn't exist, it creates it to store all the people
            Directory.CreateDirectory(folder) ' typically created for the first time open
        End If



    End Sub







    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click ' when the login button is clicked




        If Username.Text.Length > 0 Then
            If File.Exists(folder & Username.Text & ".txt") Then ' if the file exists, the username is valid as files are named the username
                Dim read As New StreamReader(folder & Username.Text & ".txt")
                Dim temp() As String = read.ReadToEnd.Split(vbNewLine)
                read.Close()

                If (temp(0) = Password.Text) Then ' first line of the file is the password of the account
                    currentUser.username = Username.Text ' reads in username
                    currentUser.password = Password.Text ' reads in password
                    currentUser.maxScore = temp(1) ' this is their max score
                    currentUser.totalScore = temp(2) ' this is their total score
                    currentUser.timesPlayed = temp(3) ' this is their amount of times played
                    currentUser.averageScore = temp(4) ' this is their average score
                    MessageBox.Show("ACCESS GRANTED", "VALID", MessageBoxButtons.OK) ' informs them they are logging in 
                    Game.Show() ' opens the game window and closes the login window
                    Me.Close()


                Else
                    MessageBox.Show("Incorrect Password", "ACCESS DENIED", MessageBoxButtons.OK) ' the password is the first line in the username file
                End If



            Else
                MessageBox.Show("USERNAME DOES NOT EXIST" & vbNewLine & "PLEASE REGISTER",
                                "INVALID", MessageBoxButtons.OK) ' file does not exist, so username does not exist
            End If
        Else
            MessageBox.Show("PLEASE ENTER A USERNAME", "INVALID", MessageBoxButtons.OK) ' they did not enter a username
        End If
    End Sub



    Private Sub reg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg.Click ' switches to the registration windows
        register.Show()
        Me.Close()
    End Sub

End Class
