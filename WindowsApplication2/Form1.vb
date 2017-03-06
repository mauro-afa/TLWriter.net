Imports System.IO
Imports WindowsApplication2.Common
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Collection(200), part2(4) As String
        Dim LVitem As New ListViewItem
        Dim fileInfo As New Common
        Button1.Text = "Create"
        Collection(0) = "DODO 4266 - CRIND SAF;Chevron Canada;09/10/1991;20/02/2017"
        Collection(1) = "DODO 4201 - Feature Regression;Chevron Canada;09/11/1991;23/02/2017"

        For Each part As String In Collection
            If (part = "") Then
                Exit For
            End If


            part2 = Split(part, ";")
            LVitem = ListView1.Items.Add(part2(0))
            LVitem.SubItems.Add(part2(1))
            LVitem.SubItems.Add(part2(2))
            LVitem.SubItems.Add(part2(3))

        Next

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Controls.Clear()
        Controls.Add(MenuStrip1)
        Controls.Add(Panel2)

    End Sub


    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown

        If e.KeyCode = Keys.Enter Then

            TextBox3.SelectionStart = TextBox3.Text.Length
            TextBox3.Text = "1- " + TextBox3.Text

        End If


    End Sub
End Class
