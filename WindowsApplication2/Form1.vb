Imports System.IO
Imports WindowsApplication2.Common
Imports System.Data.SqlClient

Public Class Form1

    Dim answer
    Dim testSuiteID
    Dim dgvr As New DataGridViewRow
    Dim rowIndex
    Dim selectionString(100), splitKey(20) As String
    Dim translateResult() As String
    Dim translate As New Common
    Dim newTestSuite = 0, tcounter = 0, counter = 0
    Dim data, TCData As New DataTable
    Dim bs As New BindingSource
    Dim scn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mauricio\Documents\Visual Studio 2015\Projects\WindowsApplication2\WindowsApplication2\Database1.mdf;Integrated Security=True")
    Dim adapter As New SqlDataAdapter()
    Dim scmd As New SqlCommand
    Dim sdr As SqlDataReader
    Dim Keywords As String
    Dim LVitem As New ListViewItem
    Dim fileInfo As New Common
    Dim checkitems As Object

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        TestCaseGrid.AutoGenerateColumns = True
        DataGridView2.AutoGenerateColumns = True
        adapter.SelectCommand = New SqlCommand("SELECT * FROM TestSuites", scn)
        adapter.Fill(TCData)
        DataGridView2.DataSource = TCData

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TestSuiteCreationButton.Click
        Controls.Clear()
        Controls.Add(MenuStrip1)
        Controls.Add(Panel2)


    End Sub

    Private Sub CancelTC_Click(sender As Object, e As EventArgs) Handles CancelTC.Click

        UpdateTC.Visible = False
        CancelTC.Visible = False
        DeleteButton.Visible = False

        ObjTB.Clear()
        PreconTB.Clear()
        ActionTB.Clear()
        ExpResTB.Clear()
        TCIDBox.Clear()
        ExecCB.Text = ""
        ImportanceCB.Text = ""
        For Each checkitems In KeywordCL.CheckedIndices

            KeywordCL.SetItemCheckState(checkitems, CheckState.Unchecked)
        Next

    End Sub

    Private Sub UpdateTC_Click(sender As Object, e As EventArgs) Handles UpdateTC.Click


        answer = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Check")
        If answer = DialogResult.Yes Then

            translateResult = translate.translateStep(ExecCB.SelectedItem, ImportanceCB.SelectedItem)
            data.Clear()
            scn.Open()
            scmd.Connection = scn
            scmd.CommandText = "UPDATE TestCases SET TestCaseID = '" & TCIDBox.Text & "', TestObjective = '" & ObjTB.Text & "', Preconditions = '" & PreconTB.Text & "', Actions= '" & ActionTB.Text & "', Expec_res = '" & ExpResTB.Text & "', Exec_type = '" & translateResult(0) & "', Importance = '" & translateResult(1) & "' WHERE TCID = '" & selectionString(0) & "' AND TSID = '" & testSuiteID & "'"
            scmd.ExecuteNonQuery()
            scn.Close()
            adapter.SelectCommand = New SqlCommand("SELECT TCID, TestCaseID, TestObjective, Preconditions, Actions, Expec_res, Keyword, Exec_type, Importance FROM TestCases where TSID = '" & testSuiteID & "'", scn)
            adapter.Fill(data)
            TestCaseGrid.DataSource = data
            ObjTB.Clear()
            PreconTB.Clear()
            ActionTB.Clear()
            ExpResTB.Clear()
            TCIDBox.Clear()
            ExecCB.Text = ""
            ImportanceCB.Text = ""
            For Each checkitems In KeywordCL.CheckedIndices

                KeywordCL.SetItemCheckState(checkitems, CheckState.Unchecked)
            Next

        Else answer = MsgBoxResult.No
        End If



    End Sub

    Private Sub FinishButton_Click(sender As Object, e As EventArgs) Handles FinishButton.Click

        answer = MsgBox("Would you like to upload the Test Suite now?", MsgBoxStyle.YesNo, "Check")
        If answer = DialogResult.No Then

            Controls.Clear()
            Controls.Add(MenuStrip1)
            Controls.Add(SplitContainer1)

        Else answer = MsgBoxResult.Yes

            'Do the upload things.

        End If

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        answer = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Check")
        If answer = DialogResult.Yes Then
            data.Clear()
            scn.Open()
            scmd.Connection = scn
            scmd.CommandText = "DELETE FROM TestCases WHERE TCID = '" & selectionString(0) & "' AND TSID = '" & testSuiteID & "'"
            scmd.ExecuteNonQuery()
            scmd.CommandText = "exec FixTCIDNumber 1, '" & testSuiteID & "'"
            scmd.ExecuteNonQuery()
            scn.Close()
            tcounter = tcounter - 1
            adapter.SelectCommand = New SqlCommand("SELECT TCID, TestCaseID, TestObjective, Preconditions, Actions, Expec_res, Keyword, Exec_type, Importance FROM TestCases where TSID = '" & testSuiteID & "'", scn)
            adapter.Fill(data)
            TestCaseGrid.DataSource = data
            ObjTB.Clear()
            PreconTB.Clear()
            ActionTB.Clear()
            ExpResTB.Clear()
            TCIDBox.Clear()
            ExecCB.Text = ""
            ImportanceCB.Text = ""
            For Each checkitems In KeywordCL.CheckedIndices

                KeywordCL.SetItemCheckState(checkitems, CheckState.Unchecked)
            Next
        Else answer = MsgBoxResult.No
        End If

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

        For Each checkitems In KeywordCL.CheckedItems

            Keywords = Keywords + checkitems.ToString + ";"

        Next

        scmd.CommandText = "SELECT id FROM TestSuites where Name = '" & tsnTB.Text & "'"
        testSuiteID = scmd.ExecuteScalar
        scmd.CommandText = "INSERT INTO TestCases (TCID, TSID, TestCaseID, TestObjective, Preconditions, Actions, Expec_res, Keyword, Exec_type, Importance, Stat) VALUES('" & tcounter & "', '" & testSuiteID & "','" & TCIDBox.Text & "','" & ObjTB.Text & "','" & PreconTB.Text & "', '" & ActionTB.Text & "', '" & ExpResTB.Text & "', '" & Keywords & "', '" & translateResult(0) & "', '" & translateResult(1) & "', '1')"
        scmd.ExecuteNonQuery()
        scn.Close()
        adapter.SelectCommand = New SqlCommand("SELECT TCID, TestCaseID, TestObjective, Preconditions, Actions, Expec_res, Keyword, Exec_type, Importance FROM TestCases where TSID = '" & testSuiteID & "'", scn)
        adapter.Fill(data)
        TestCaseGrid.DataSource = data
        ObjTB.Clear()
        PreconTB.Clear()
        ActionTB.Clear()
        ExpResTB.Clear()
        TCIDBox.Clear()
        ExecCB.Text = ""
        ImportanceCB.Text = ""
        For Each checkitems In KeywordCL.CheckedIndices

            KeywordCL.SetItemCheckState(checkitems, CheckState.Unchecked)
        Next

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TestCaseGrid.CellClick



        UpdateTC.Visible = True
        CancelTC.Visible = True
        DeleteButton.Visible = True

        rowIndex = TestCaseGrid.CurrentCell.RowIndex

        dgvr = TestCaseGrid.Rows(rowIndex)
        selectionString(0) = dgvr.Cells(0).Value.ToString
        selectionString(1) = dgvr.Cells(1).Value.ToString
        selectionString(2) = dgvr.Cells(2).Value.ToString
        selectionString(3) = dgvr.Cells(3).Value.ToString
        selectionString(4) = dgvr.Cells(4).Value.ToString
        selectionString(5) = dgvr.Cells(5).Value.ToString
        selectionString(6) = dgvr.Cells(6).Value.ToString
        For Each word In Split(selectionString(6), ";")

            If (word <> "                                                                    ") Then
                splitKey(counter) = word
                MsgBox(splitKey(counter))
                counter = counter + 1
            End If

        Next
        counter = 0
        selectionString(7) = dgvr.Cells(7).Value.ToString
        selectionString(8) = dgvr.Cells(8).Value.ToString

        translateResult = translate.translateStep(selectionString(7), selectionString(8))

        TCIDBox.Text = selectionString(1)
        ObjTB.Text = selectionString(2)
        PreconTB.Text = selectionString(3)
        ActionTB.Text = selectionString(4)
        ExpResTB.Text = selectionString(5)
        ExecCB.Text = translateResult(0)
        ImportanceCB.Text = translateResult(1)
        For Each key In splitKey

            KeywordCL.SetItemChecked()

        Next


    End Sub
End Class
