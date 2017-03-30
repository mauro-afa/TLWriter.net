Imports System.IO
Imports WindowsApplication2.Common
Imports System.Data.SqlClient

Public Class Form1

    Dim translateResult() As String
    Dim translate As New Common
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

    Private Sub CancelTC_Click(sender As Object, e As EventArgs) Handles CancelTC.Click

        UpdateTC.Visible = False
        CancelTC.Visible = False

        ObjTB.Clear()
        PreconTB.Clear()
        ActionTB.Clear()
        ExpResTB.Clear()
        TCIDBox.Clear()
        ExecCB.Text = ""
        ImportanceCB.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddTC.Click


        data.Clear()

        translateResult = translate.translateStep(ExecCB.SelectedItem, ImportanceCB.SelectedItem)

        scn.Open()
        scmd.Connection = scn
        tcounter = tcounter + 1

        If (newTestSuite = 0) Then

            newTestSuite = 1
            scmd.CommandText = "INSERT INTO TestSuites (Name, Network, Version, UploadDate) VALUES('" & tsnTB.Text & "','" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "','')"
            scmd.ExecuteNonQuery()


        End If

        scmd.CommandText = "SELECT id FROM TestSuites where Name = '" & tsnTB.Text & "'"
        Dim testSuiteID = scmd.ExecuteScalar
        scmd.CommandText = "INSERT INTO TestCases (TCID, TSID, TestCaseID, TestObjective, Preconditions, Actions, Expec_res, Keyword, Exec_type, Importance, Stat) VALUES('" & tcounter & "', '" & testSuiteID & "','" & TCIDBox.Text & "','" & ObjTB.Text & "','" & PreconTB.Text & "', '" & ActionTB.Text & "', '" & ExpResTB.Text & "', 'Keyword', '" & translateResult(0) & "', '" & translateResult(1) & "', '1')"
        scmd.ExecuteNonQuery()
        scn.Close()
        adapter.SelectCommand = New SqlCommand("SELECT TestCaseID, TestObjective, Preconditions, Actions, Expec_res, Keyword, Exec_type, Importance FROM TestCases where TSID = '" & testSuiteID & "'", scn)
        adapter.Fill(data)
        DataGridView1.DataSource = data
        ObjTB.Clear()
        PreconTB.Clear()
        ActionTB.Clear()
        ExpResTB.Clear()
        TCIDBox.Clear()
        ExecCB.Text = ""
        ImportanceCB.Text = ""

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim dgvr As New DataGridViewRow
        Dim rowIndex
        Dim selectionString(100) As String

        UpdateTC.Visible = True
        CancelTC.Visible = True

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

        translateResult = translate.translateStep(selectionString(6), selectionString(7))

        TCIDBox.Text = selectionString(0)
        ObjTB.Text = selectionString(1)
        PreconTB.Text = selectionString(2)
        ActionTB.Text = selectionString(3)
        ExpResTB.Text = selectionString(4)
        ExecCB.Text = translateResult(0)
        ImportanceCB.Text = translateResult(1)


    End Sub
End Class
