<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_page
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
        Me.Username = New System.Windows.Forms.TextBox
        Me.Password = New System.Windows.Forms.TextBox
        Me.Login = New System.Windows.Forms.Button
        Me.reg = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(116, 84)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(100, 20)
        Me.Username.TabIndex = 0
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(116, 126)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(100, 20)
        Me.Password.TabIndex = 1
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(116, 177)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(100, 23)
        Me.Login.TabIndex = 2
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'reg
        '
        Me.reg.Location = New System.Drawing.Point(116, 216)
        Me.reg.Name = "reg"
        Me.reg.Size = New System.Drawing.Size(100, 23)
        Me.reg.TabIndex = 3
        Me.reg.Text = "Register"
        Me.reg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(237, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 251)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.reg)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Name = "Main_page"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents reg As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
