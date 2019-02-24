Public Class Game



    Private Sub Game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

 



    Private Sub square()
        'dimension variables of local scope

        Dim myGraphics As Graphics

        Dim myRectangle As Rectangle

        Dim myPen As New Pen(Color.Blue)

        'return the current form as a drawing surface

        myGraphics = Graphics.FromHwnd(ActiveForm().Handle)

        'create a rectangle based on x,y coordinates, width, & height

        myRectangle = New Rectangle(x:=190, y:=100, Width:=200, Height:=100)

        'draw rectangle from pen and rectangle objects

        myGraphics.DrawRectangle(pen:=myPen, rect:=myRectangle)

        'create a rectangle based on Point and Size objects


    End Sub

    



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Select Case Math.Floor(Rnd() * 3)
                Case 0
                    shape.ImageLocation() = "N:\\triangle.png"
                Case 1
                    shape.ImageLocation() = "N:\\square.png"
                Case 2
                    shape.ImageLocation() = "N:\\circle.png"

            End Select

        Catch ex As Exception
            MessageBox.Show("fail")
        End Try
     
    End Sub
End Class