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
        Controls.Add(Panel1)

    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
