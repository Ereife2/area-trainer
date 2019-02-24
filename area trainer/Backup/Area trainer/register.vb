Public Class register

    Private Sub register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Turquoise
        pass1.PasswordChar = "*" ' hides the password
        pass2.PasswordChar = "*"
    End Sub

    Function passChecker(ByVal passwords As String) ' ensures the password is strong enough
        Dim ret As String = ""
        Dim caps = 0, lows = 0, specials = 0, numbers As Integer = 0 ' counts the required parts of the password
        Dim special As String = "!£$%^&*()_-=|\¬`<>?,./:@~'#[]{}" ' these are the special characters, which aren't grouped in the ascoo table


        If passwords.Length < 8 Then
            ret += "PASSWORD IS TOO SHORT (MUST BE 8 CHARACTERS" + vbNewLine
        End If
        For Each letter As Char In passwords
            Dim temp As Integer = Asc(letter) ' stores the ascii value of the letters
            If special.Contains(letter) Then ' if the letter is a special character, the specials integer is incremented
                specials += 1
            End If
            If temp > 47 And temp < 58 Then ' these are the ascii values for numbers, so it is incremented
                numbers += 1
            End If
            If Asc(letter) > 64 And Asc(letter) < 91 Then ' capital letters
                caps += 1
            End If
            If Asc(letter) > 96 And Asc(letter) < 123 Then ' lowercase letters
                lows += 1
            End If
            If Asc(letter) = 32 Then ' spaces are not allowed in the password
                ret += "SPACES ARE NOT ALLOWED IN PASSWORD" + vbNewLine
            End If
        Next
        If caps < 1 Then ret += "PASSWORD MUST CONTAIN AT LEAST ONE CAPITAL LETTER" + vbNewLine ' if there isn't a capital letter

        If lows < 1 Then ret += "PASSWORD MUST CONTAIN AT LEAST ONE LOWERCASE LETTER" + vbNewLine ' if there isn't a lowercase letter

        If specials < 1 Then ret += "PASSWORD MUST CONTAIN AT LEAST ONE SPECIAL CHARACTER" + vbNewLine ' if there isn't a special character

        If numbers < 1 Then ret += "PASSWORD MUST CONTAIN AT LEAST ONE NUMBER" ' if there isn't a number
        If Not pass1.Text = pass2.Text Then
            issues.Text += "PASSWORDS MUST MATCH" ' the two passwords must match
        End If

        Return ret
    End Function


    Function nameCheck(ByRef name As String) ' checks if the name is valid
        If name.Length = 0 Then ' if they haven't entered a username
            MessageBox.Show("NAME IS TOO SHORT", "INVALID", MessageBoxButtons.OK)
            Return False
        End If
        If System.IO.File.Exists(Main_page.folder & name & ".txt") Then ' if the username already exists
            MessageBox.Show("NAME IS ALREADY IN USE", "INVALID", MessageBoxButtons.OK)
            Return False
        End If




        Return True
    End Function

    Sub createUSer() ' if all the checks are passed a new user is created
        Dim newUSer As New System.IO.StreamWriter(Main_page.folder + uname.Text + ".txt") ' creates a new text file and a write to write to it
        ' the username is the name of the text file
        newUSer.WriteLine(pass1.Text) ' the password is the first line
        For x = 1 To 4
            newUSer.WriteLine(0) ' fills the remaining four lines with 0s as it is a new user
        Next
        newUSer.Close() ' saves the file
        MessageBox.Show("NOW PLEASE SIGN IN", "REGISTRATION COMPLEte", MessageBoxButtons.OK)
    End Sub

    Private Sub sign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sign.Click
        If nameCheck(uname.Text) Then ' if the name is valid after being checksed
            If passChecker(pass1.Text) = "" Then ' if the password is strong enough after being checked
                createUSer()
                Main_page.Show()
                Me.Close()
            End If
        End If



    End Sub



  





    Private Sub pass1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass1.TextChanged
        issues.Text = passChecker(pass1.Text)
    End Sub



 
    Private Sub pass2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass2.TextChanged
        issues.Text = passChecker(pass1.Text)
    End Sub
End Class