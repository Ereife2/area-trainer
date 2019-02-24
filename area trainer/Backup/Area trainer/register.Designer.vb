<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.pass1 = New System.Windows.Forms.TextBox
        Me.pass2 = New System.Windows.Forms.TextBox
        Me.uname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.sign = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.problems = New System.Windows.Forms.Label
        Me.issues = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'pass1
        '
        Me.pass1.Location = New System.Drawing.Point(89, 99)
        Me.pass1.Name = "pass1"
        Me.pass1.Size = New System.Drawing.Size(100, 20)
        Me.pass1.TabIndex = 1
        '
        'pass2
        '
        Me.pass2.Location = New System.Drawing.Point(89, 138)
        Me.pass2.Name = "pass2"
        Me.pass2.Size = New System.Drawing.Size(100, 20)
        Me.pass2.TabIndex = 2
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(89, 45)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(100, 20)
        Me.uname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter a username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter a password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter your password again"
        '
        'sign
        '
        Me.sign.Location = New System.Drawing.Point(101, 299)
        Me.sign.Name = "sign"
        Me.sign.Size = New System.Drawing.Size(75, 23)
        Me.sign.TabIndex = 3
        Me.sign.Text = "Sign up"
        Me.sign.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(86, 283)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(132, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Already have an account?"
        '
        'problems
        '
        Me.problems.AutoSize = True
        Me.problems.Location = New System.Drawing.Point(218, 83)
        Me.problems.Name = "problems"
        Me.problems.Size = New System.Drawing.Size(0, 13)
        Me.problems.TabIndex = 7
        '
        'issues
        '
        Me.issues.AutoSize = True
        Me.issues.Location = New System.Drawing.Point(89, 165)
        Me.issues.Name = "issues"
        Me.issues.Size = New System.Drawing.Size(0, 13)
        Me.issues.TabIndex = 8
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 345)
        Me.Controls.Add(Me.issues)
        Me.Controls.Add(Me.problems)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.sign)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.pass2)
        Me.Controls.Add(Me.pass1)
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "REGISTER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pass1 As System.Windows.Forms.TextBox
    Friend WithEvents pass2 As System.Windows.Forms.TextBox
    Friend WithEvents uname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sign As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents problems As System.Windows.Forms.Label
    Friend WithEvents issues As System.Windows.Forms.Label
End Class
