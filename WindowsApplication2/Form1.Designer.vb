<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestSuiteCreationButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DeleteTSButton = New System.Windows.Forms.Button()
        Me.EditTSButton = New System.Windows.Forms.Button()
        Me.UploadButton = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TestCasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChangeTSButton = New System.Windows.Forms.Button()
        Me.FinishButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelTC = New System.Windows.Forms.Button()
        Me.UpdateTC = New System.Windows.Forms.Button()
        Me.JiraLinkTB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TestCaseGrid = New System.Windows.Forms.DataGridView()
        Me.ExecCB = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ImportanceCB = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AddTC = New System.Windows.Forms.Button()
        Me.KeywordCL = New System.Windows.Forms.CheckedListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExpResTB = New System.Windows.Forms.TextBox()
        Me.ActionTB = New System.Windows.Forms.TextBox()
        Me.PreconTB = New System.Windows.Forms.TextBox()
        Me.ObjTB = New System.Windows.Forms.TextBox()
        Me.tsnTB = New System.Windows.Forms.TextBox()
        Me.TCIDBox = New System.Windows.Forms.TextBox()
        Me.VersionCB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NetworkCB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TestCaseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1225, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TestSuiteCreationButton
        '
        Me.TestSuiteCreationButton.Location = New System.Drawing.Point(3, 9)
        Me.TestSuiteCreationButton.Name = "TestSuiteCreationButton"
        Me.TestSuiteCreationButton.Size = New System.Drawing.Size(193, 45)
        Me.TestSuiteCreationButton.TabIndex = 0
        Me.TestSuiteCreationButton.Text = "Create test suite"
        Me.TestSuiteCreationButton.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DeleteTSButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EditTSButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UploadButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TestSuiteCreationButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1225, 523)
        Me.SplitContainer1.SplitterDistance = 306
        Me.SplitContainer1.TabIndex = 3
        '
        'DeleteTSButton
        '
        Me.DeleteTSButton.Location = New System.Drawing.Point(3, 191)
        Me.DeleteTSButton.Name = "DeleteTSButton"
        Me.DeleteTSButton.Size = New System.Drawing.Size(190, 45)
        Me.DeleteTSButton.TabIndex = 3
        Me.DeleteTSButton.Text = "Delete Test Suite"
        Me.DeleteTSButton.UseVisualStyleBackColor = True
        '
        'EditTSButton
        '
        Me.EditTSButton.Location = New System.Drawing.Point(3, 130)
        Me.EditTSButton.Name = "EditTSButton"
        Me.EditTSButton.Size = New System.Drawing.Size(190, 45)
        Me.EditTSButton.TabIndex = 2
        Me.EditTSButton.Text = "Edit Test Suite"
        Me.EditTSButton.UseVisualStyleBackColor = True
        '
        'UploadButton
        '
        Me.UploadButton.Location = New System.Drawing.Point(3, 69)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(190, 45)
        Me.UploadButton.TabIndex = 1
        Me.UploadButton.Text = "Upload Test Suite"
        Me.UploadButton.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.DataSource = Me.TestCasesBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(915, 523)
        Me.DataGridView2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(332, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Hey darling"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 523)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ChangeTSButton)
        Me.Panel2.Controls.Add(Me.FinishButton)
        Me.Panel2.Controls.Add(Me.DeleteButton)
        Me.Panel2.Controls.Add(Me.CancelTC)
        Me.Panel2.Controls.Add(Me.UpdateTC)
        Me.Panel2.Controls.Add(Me.JiraLinkTB)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TestCaseGrid)
        Me.Panel2.Controls.Add(Me.ExecCB)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.ImportanceCB)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.AddTC)
        Me.Panel2.Controls.Add(Me.KeywordCL)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ExpResTB)
        Me.Panel2.Controls.Add(Me.ActionTB)
        Me.Panel2.Controls.Add(Me.PreconTB)
        Me.Panel2.Controls.Add(Me.ObjTB)
        Me.Panel2.Controls.Add(Me.tsnTB)
        Me.Panel2.Controls.Add(Me.TCIDBox)
        Me.Panel2.Controls.Add(Me.VersionCB)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.NetworkCB)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1225, 523)
        Me.Panel2.TabIndex = 3
        '
        'ChangeTSButton
        '
        Me.ChangeTSButton.Location = New System.Drawing.Point(917, 90)
        Me.ChangeTSButton.Name = "ChangeTSButton"
        Me.ChangeTSButton.Size = New System.Drawing.Size(192, 23)
        Me.ChangeTSButton.TabIndex = 29
        Me.ChangeTSButton.Text = "Change test suite information"
        Me.ChangeTSButton.UseVisualStyleBackColor = True
        Me.ChangeTSButton.Visible = False
        '
        'FinishButton
        '
        Me.FinishButton.Location = New System.Drawing.Point(917, 276)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(137, 23)
        Me.FinishButton.TabIndex = 28
        Me.FinishButton.Text = "Finish"
        Me.FinishButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(472, 276)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(137, 23)
        Me.DeleteButton.TabIndex = 27
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        Me.DeleteButton.Visible = False
        '
        'CancelTC
        '
        Me.CancelTC.Location = New System.Drawing.Point(689, 276)
        Me.CancelTC.Name = "CancelTC"
        Me.CancelTC.Size = New System.Drawing.Size(137, 23)
        Me.CancelTC.TabIndex = 26
        Me.CancelTC.Text = "Cancel"
        Me.CancelTC.UseVisualStyleBackColor = True
        Me.CancelTC.Visible = False
        '
        'UpdateTC
        '
        Me.UpdateTC.Location = New System.Drawing.Point(255, 276)
        Me.UpdateTC.Name = "UpdateTC"
        Me.UpdateTC.Size = New System.Drawing.Size(137, 23)
        Me.UpdateTC.TabIndex = 25
        Me.UpdateTC.Text = "Update"
        Me.UpdateTC.UseVisualStyleBackColor = True
        Me.UpdateTC.Visible = False
        '
        'JiraLinkTB
        '
        Me.JiraLinkTB.Location = New System.Drawing.Point(555, 30)
        Me.JiraLinkTB.Name = "JiraLinkTB"
        Me.JiraLinkTB.Size = New System.Drawing.Size(325, 20)
        Me.JiraLinkTB.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(552, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Jira Link"
        '
        'TestCaseGrid
        '
        Me.TestCaseGrid.AllowUserToAddRows = False
        Me.TestCaseGrid.AllowUserToDeleteRows = False
        Me.TestCaseGrid.AllowUserToResizeColumns = False
        Me.TestCaseGrid.AllowUserToResizeRows = False
        Me.TestCaseGrid.AutoGenerateColumns = False
        Me.TestCaseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TestCaseGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.TestCaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestCaseGrid.DataSource = Me.TestCasesBindingSource
        Me.TestCaseGrid.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.TestCaseGrid.Location = New System.Drawing.Point(29, 314)
        Me.TestCaseGrid.Name = "TestCaseGrid"
        Me.TestCaseGrid.RowHeadersVisible = False
        Me.TestCaseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TestCaseGrid.Size = New System.Drawing.Size(1155, 182)
        Me.TestCaseGrid.TabIndex = 22
        '
        'ExecCB
        '
        Me.ExecCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ExecCB.FormattingEnabled = True
        Me.ExecCB.Items.AddRange(New Object() {"Manual", "Automated"})
        Me.ExecCB.Location = New System.Drawing.Point(470, 91)
        Me.ExecCB.Name = "ExecCB"
        Me.ExecCB.Size = New System.Drawing.Size(127, 21)
        Me.ExecCB.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(467, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Execution"
        '
        'ImportanceCB
        '
        Me.ImportanceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImportanceCB.FormattingEnabled = True
        Me.ImportanceCB.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.ImportanceCB.Location = New System.Drawing.Point(689, 91)
        Me.ImportanceCB.Name = "ImportanceCB"
        Me.ImportanceCB.Size = New System.Drawing.Size(127, 21)
        Me.ImportanceCB.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(686, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Importance"
        '
        'AddTC
        '
        Me.AddTC.Location = New System.Drawing.Point(29, 276)
        Me.AddTC.Name = "AddTC"
        Me.AddTC.Size = New System.Drawing.Size(137, 23)
        Me.AddTC.TabIndex = 17
        Me.AddTC.Text = "Add test case"
        Me.AddTC.UseVisualStyleBackColor = True
        '
        'KeywordCL
        '
        Me.KeywordCL.FormattingEnabled = True
        Me.KeywordCL.Items.AddRange(New Object() {"1GENAC", "2 Wire Over IP", "7-ELEVEN", "7-ELEVEN-Conoco", "7ELEVEN-EXXON", "ADD2REGRESSION", "APPLAUSE", "BP", "CHEVRON", "CHEVRON CA", "CITGO", "CONCORD", "CONTROL CENTER", "CORE", "DASHBOARD", "DEFECT", "Dual Tank Monitor", "EMV", "EXCEPTION", "EXXON", "FDC", "FUNCTIONAL", "HPSC", "HPSD", "HPSD-Generic_brand", "Incomm", "IOL", "Kris Sprint 13 Test Cases", "MARATHON", "NBS", "P66", "PADSS", "PADSS-Lite", "REGRESSION", "SANITY CHECK", "SHELL", "SITE SERVER", "SMOKE TEST", "WORLDPAY"})
        Me.KeywordCL.Location = New System.Drawing.Point(917, 148)
        Me.KeywordCL.Name = "KeywordCL"
        Me.KeywordCL.Size = New System.Drawing.Size(192, 124)
        Me.KeywordCL.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(689, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Expected results"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(467, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Actions"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(250, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Preconditions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Objective"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Test Suite Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Test case ID"
        '
        'ExpResTB
        '
        Me.ExpResTB.Location = New System.Drawing.Point(689, 148)
        Me.ExpResTB.Multiline = True
        Me.ExpResTB.Name = "ExpResTB"
        Me.ExpResTB.Size = New System.Drawing.Size(191, 122)
        Me.ExpResTB.TabIndex = 7
        '
        'ActionTB
        '
        Me.ActionTB.Location = New System.Drawing.Point(470, 148)
        Me.ActionTB.Multiline = True
        Me.ActionTB.Name = "ActionTB"
        Me.ActionTB.Size = New System.Drawing.Size(191, 122)
        Me.ActionTB.TabIndex = 6
        '
        'PreconTB
        '
        Me.PreconTB.Location = New System.Drawing.Point(250, 148)
        Me.PreconTB.Multiline = True
        Me.PreconTB.Name = "PreconTB"
        Me.PreconTB.Size = New System.Drawing.Size(191, 122)
        Me.PreconTB.TabIndex = 5
        '
        'ObjTB
        '
        Me.ObjTB.Location = New System.Drawing.Point(29, 148)
        Me.ObjTB.Multiline = True
        Me.ObjTB.Name = "ObjTB"
        Me.ObjTB.Size = New System.Drawing.Size(191, 122)
        Me.ObjTB.TabIndex = 4
        '
        'tsnTB
        '
        Me.tsnTB.Location = New System.Drawing.Point(29, 29)
        Me.tsnTB.Name = "tsnTB"
        Me.tsnTB.Size = New System.Drawing.Size(498, 20)
        Me.tsnTB.TabIndex = 9
        '
        'TCIDBox
        '
        Me.TCIDBox.Location = New System.Drawing.Point(29, 90)
        Me.TCIDBox.Name = "TCIDBox"
        Me.TCIDBox.Size = New System.Drawing.Size(412, 20)
        Me.TCIDBox.TabIndex = 8
        '
        'VersionCB
        '
        Me.VersionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VersionCB.FormattingEnabled = True
        Me.VersionCB.Items.AddRange(New Object() {"v10", "v11.01", "v11.02", "v99.99"})
        Me.VersionCB.Location = New System.Drawing.Point(1037, 30)
        Me.VersionCB.Name = "VersionCB"
        Me.VersionCB.Size = New System.Drawing.Size(72, 21)
        Me.VersionCB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1034, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Version"
        '
        'NetworkCB
        '
        Me.NetworkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NetworkCB.FormattingEnabled = True
        Me.NetworkCB.Items.AddRange(New Object() {"Chevron", "Chevron Canada", "IOL", "NBS", "HPS-Dallas", "HPS-Chicago"})
        Me.NetworkCB.Location = New System.Drawing.Point(917, 29)
        Me.NetworkCB.Name = "NetworkCB"
        Me.NetworkCB.Size = New System.Drawing.Size(109, 21)
        Me.NetworkCB.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(914, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Network"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 547)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TestCaseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestSuiteCreationButton As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NetworkCB As ComboBox
    Friend WithEvents VersionCB As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents KeywordCL As CheckedListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tsnTB As TextBox
    Friend WithEvents TCIDBox As TextBox
    Friend WithEvents ExpResTB As TextBox
    Friend WithEvents ActionTB As TextBox
    Friend WithEvents PreconTB As TextBox
    Friend WithEvents ObjTB As TextBox
    Friend WithEvents AddTC As Button
    Friend WithEvents ExecCB As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ImportanceCB As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TestCaseGrid As DataGridView
    Friend WithEvents TestCasesBindingSource As BindingSource
    Friend WithEvents JiraLinkTB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CancelTC As Button
    Friend WithEvents UpdateTC As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents FinishButton As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DeleteTSButton As Button
    Friend WithEvents EditTSButton As Button
    Friend WithEvents UploadButton As Button
    Friend WithEvents ChangeTSButton As Button
End Class
