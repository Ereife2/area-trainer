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
        Me.shape = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.AnswerONE = New System.Windows.Forms.Button
        Me.AnswerTwo = New System.Windows.Forms.Button
        Me.AnswerThree = New System.Windows.Forms.Button
        Me.Score = New System.Windows.Forms.Label
        Me.quit = New System.Windows.Forms.Button
        CType(Me.shape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shape
        '
        Me.shape.Location = New System.Drawing.Point(225, 93)
        Me.shape.Name = "shape"
        Me.shape.Size = New System.Drawing.Size(350, 267)
        Me.shape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shape.TabIndex = 0
        Me.shape.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 485)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.AnswerThree)
        Me.Controls.Add(Me.AnswerTwo)
        Me.Controls.Add(Me.AnswerONE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.shape)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.shape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents shape As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AnswerONE As System.Windows.Forms.Button
    Friend WithEvents AnswerTwo As System.Windows.Forms.Button
    Friend WithEvents AnswerThree As System.Windows.Forms.Button
    Friend WithEvents Score As System.Windows.Forms.Label
    Friend WithEvents quit As System.Windows.Forms.Button
End Class
