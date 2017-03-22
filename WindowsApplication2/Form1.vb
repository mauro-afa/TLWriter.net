Imports System.IO
Imports WindowsApplication2.Common
Imports System.Data.SqlClient

Public Class Form1


    Dim newTestSuite = 0, tcounter = 0
    Dim data As New DataTable
    Dim bs As New BindingSource
    Dim scn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mauricio\Documents\Visual Studio 2015\Projects\WindowsApplication2\WindowsApplication2\Database1.mdf;Integrated Security=True")
    Dim adapter As New SqlDataAdapter()
    Dim scmd As New SqlCommand
    Dim sdr As SqlDataReader
    Dim Collection(200), part2(4) As String
    Dim LVitem As New ListViewItem
    Dim fileInfo As New Common

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Button1.Text = "Create"
        Collection(0) = "DODO 4266 - CRIND SAF;Chevron Canada;09/10/1991;20/02/2017"
        Collection(1) = "DODO 4201 - Feature Regression;Chevron Canada;09/11/1991;23/02/2017"
        DataGridView1.AutoGenerateColumns = True

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



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim importance, execution As Integer
        data.Clear()

        If ComboBox3.SelectedItem = "Low" Then

            importance = 1

        ElseIf ComboBox3.SelectedItem = "Medium" Then

            importance = 2

        ElseIf ComboBox3.SelectedItem = "High" Then

            importance = 3

        End If

        If ComboBox4.SelectedItem = "Manual" Then

            execution = 1

        ElseIf ComboBox4.SelectedItem = "Automated" Then

            execution = 2
        End If

        scn.Open()
        scmd.Connection = scn
        tcounter = tcounter + 1

        If (newTestSuite = 0) Then

            newTestSuite = 1
            scmd.CommandText = "INSERT INTO TestSuites (Name, Network, Version, UploadDate) VALUES('" & TextBox7.Text & "','" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "','')"
            scmd.ExecuteNonQuery()


        End If

        scmd.CommandText = "SELECT id FROM TestSuites where Name = '" & TextBox7.Text & "'"
        Dim testSuiteID = scmd.ExecuteScalar
        scmd.CommandText = "INSERT INTO TestCases (TCID, TSID, TestCaseID, TestObjective, Preconditions, Actions, Expec_res, Keyword, Exec_type, Importance, Stat) VALUES('" & tcounter & "', '" & testSuiteID & "','" & TextBox6.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', 'Keyword', '" & importance & "', '" & execution & "', '1')"
        scmd.ExecuteNonQuery()
        scn.Close()
        adapter.SelectCommand = New SqlCommand("SELECT * FROM TestCases where TSID = '" & testSuiteID & "'", scn)
        adapter.Fill(data)
        DataGridView1.DataSource = data
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim dgvr As New DataGridViewRow
        Dim rowIndex
        Dim selectionString(100) As String

        rowIndex = DataGridView1.CurrentCell.RowIndex

        dgvr = DataGridView1.Rows(rowIndex)
        selectionString(0) = dgvr.Cells(0).Value.ToString
        selectionString(1) = dgvr.Cells(1).Value.ToString
        selectionString(2) = dgvr.Cells(2).Value.ToString
        selectionString(3) = dgvr.Cells(3).Value.ToString
        selectionString(4) = dgvr.Cells(4).Value.ToString
        selectionString(5) = dgvr.Cells(5).Value.ToString
        selectionString(6) = dgvr.Cells(6).Value.ToString
        selectionString(7) = dgvr.Cells(7).Value.ToString
        selectionString(8) = dgvr.Cells(8).Value.ToString
        selectionString(9) = dgvr.Cells(9).Value.ToString
        selectionString(10) = dgvr.Cells(10).Value.ToString

        TextBox2.Text = selectionString(1)

    End Sub
End Class
