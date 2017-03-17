Imports System.IO
Imports WindowsApplication2.Common
Imports System.Data.SqlClient

Public Class Form1

    Dim data As New DataTable
    Dim adapter As New SqlDataAdapter
    Dim scn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mauricio\Documents\Visual Studio 2015\Projects\WindowsApplication2\WindowsApplication2\Database1.mdf;Integrated Security=True")
    Dim scmd As New SqlCommand
    Dim sdr As SqlDataReader
    Dim Collection(200), part2(4) As String
    Dim LVitem As New ListViewItem
    Dim fileInfo As New Common

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

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

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        scn.Open()
        scmd.Connection = scn
        scmd.CommandText = "INSERT INTO TestSuites (Name, Network, Version, Sprint, UploadDate) VALUES('Hey','Chevron-Canada','v11.02','83','')"
        scmd.ExecuteNonQuery()

        scmd.CommandText = "SELECT * FROM TestSuites"
        sdr = scmd.ExecuteReader
        data.Load(sdr)
        DataGridView1.DataSource = data
        scn.Close()
    End Sub
End Class
