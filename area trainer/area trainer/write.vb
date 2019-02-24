Imports System.IO
Imports System.Data

Public Class write

    Private Sub write_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' run()
    End Sub


    Function getTable()


        Dim table As New DataTable
        table.Columns.Add("Username", GetType(String))
        table.Columns.Add("Password", GetType(String))
        table.Columns.Add("Times Played", GetType(Integer))
        table.Columns.Add("High Score", GetType(Integer))
        table.Columns.Add("Total Score", GetType(Integer))
        table.Columns.Add("Average Score", GetType(Double))
        table.Rows.Add("Ereife", "ok", 2, 5, 7, 8)

        Return table
    End Function

    Sub run()


        Dim lol As New DataTable
        lol = getTable()
        Dim dr() As System.Data.DataRow = lol.Select("Username='" & "Ereife" & "'")
        Dim headers() As String = {"Username", "Password", "Times played", "High score", "Total Score" _
                                  , "Average score"}
        lol.Rows.RemoveAt(lol.Rows.Count - 1)


        tocsv(lol)

        Console.WriteLine(lol)

    End Sub


    Sub tocsv(ByRef table As DataTable)
        Dim csv As String = String.Empty
        Me.DataGridView1.DataSource = table
        For Each colum As DataGridViewColumn In DataGridView1.Columns
            csv += colum.HeaderText & ","c
        Next
        csv += vbCr + vbLf


        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                csv += cell.Value.ToString().Replace(",", ";") & ","c
            Next
            csv += vbCr + vbLf
        Next

        MessageBox.Show(csv)
        File.WriteAllText("N:\hmm.csv", csv)

    End Sub
End Class