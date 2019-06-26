<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTextoid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.menuTextoid = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportVariableListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtfMain = New System.Windows.Forms.RichTextBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tblPnlMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCharCountSelected = New System.Windows.Forms.Label()
        Me.lblCharCount = New System.Windows.Forms.Label()
        Me.diaOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.diaSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.pnlVar = New System.Windows.Forms.Panel()
        Me.chkTranslate = New System.Windows.Forms.CheckBox()
        Me.chkShowMulti = New System.Windows.Forms.CheckBox()
        Me.listMain = New System.Windows.Forms.ListView()
        Me.Variable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sample = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkHighlight = New System.Windows.Forms.CheckBox()
        Me.btnVarAdd = New System.Windows.Forms.Button()
        Me.btnVarDelete = New System.Windows.Forms.Button()
        Me.pnlAlt = New System.Windows.Forms.Panel()
        Me.tblPnlAlt = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCharCountAlt = New System.Windows.Forms.Label()
        Me.rtfAlt = New System.Windows.Forms.RichTextBox()
        Me.lblCarCountSelectedAlt = New System.Windows.Forms.Label()
        Me.menuTextoid.SuspendLayout
        Me.pnlMain.SuspendLayout
        Me.tblPnlMain.SuspendLayout
        Me.pnlVar.SuspendLayout
        Me.pnlAlt.SuspendLayout
        Me.tblPnlAlt.SuspendLayout
        Me.SuspendLayout
        '
        'menuTextoid
        '
        Me.menuTextoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuTextoid.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.menuTextoid.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuTextoid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuTextoid.Location = New System.Drawing.Point(0, 0)
        Me.menuTextoid.Name = "menuTextoid"
        Me.menuTextoid.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.menuTextoid.Size = New System.Drawing.Size(948, 31)
        Me.menuTextoid.TabIndex = 1
        Me.menuTextoid.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator2, Me.ExportVariableListToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(59, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(272, 34)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(272, 34)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(269, 6)
        '
        'ExportVariableListToolStripMenuItem
        '
        Me.ExportVariableListToolStripMenuItem.Name = "ExportVariableListToolStripMenuItem"
        Me.ExportVariableListToolStripMenuItem.Size = New System.Drawing.Size(272, 34)
        Me.ExportVariableListToolStripMenuItem.Text = "Save Variable List"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator1, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'rtfMain
        '
        Me.tblPnlMain.SetColumnSpan(Me.rtfMain, 2)
        Me.rtfMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfMain.Location = New System.Drawing.Point(3, 2)
        Me.rtfMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtfMain.Name = "rtfMain"
        Me.rtfMain.Size = New System.Drawing.Size(239, 547)
        Me.rtfMain.TabIndex = 7
        Me.rtfMain.Text = ""
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlMain.Controls.Add(Me.tblPnlMain)
        Me.pnlMain.Location = New System.Drawing.Point(37, 72)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(245, 701)
        Me.pnlMain.TabIndex = 5
        '
        'tblPnlMain
        '
        Me.tblPnlMain.ColumnCount = 2
        Me.tblPnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlMain.Controls.Add(Me.lblCharCountSelected, 0, 2)
        Me.tblPnlMain.Controls.Add(Me.rtfMain, 0, 0)
        Me.tblPnlMain.Controls.Add(Me.lblCharCount, 0, 1)
        Me.tblPnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPnlMain.Location = New System.Drawing.Point(0, 0)
        Me.tblPnlMain.Name = "tblPnlMain"
        Me.tblPnlMain.RowCount = 3
        Me.tblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblPnlMain.Size = New System.Drawing.Size(245, 701)
        Me.tblPnlMain.TabIndex = 8
        '
        'lblCharCountSelected
        '
        Me.lblCharCountSelected.AutoSize = True
        Me.lblCharCountSelected.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCharCountSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharCountSelected.Location = New System.Drawing.Point(3, 626)
        Me.lblCharCountSelected.Name = "lblCharCountSelected"
        Me.lblCharCountSelected.Size = New System.Drawing.Size(114, 75)
        Me.lblCharCountSelected.TabIndex = 12
        Me.lblCharCountSelected.Text = "Selected Characters:  0"
        '
        'lblCharCount
        '
        Me.lblCharCount.AutoSize = True
        Me.lblCharCount.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCharCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharCount.Location = New System.Drawing.Point(3, 551)
        Me.lblCharCount.Name = "lblCharCount"
        Me.lblCharCount.Size = New System.Drawing.Size(114, 75)
        Me.lblCharCount.TabIndex = 0
        Me.lblCharCount.Text = "Total Characters:  0"
        '
        'diaOpenFile
        '
        Me.diaOpenFile.Filter = "Text Files (*.txt)|*.txt"
        Me.diaOpenFile.Multiselect = True
        Me.diaOpenFile.RestoreDirectory = True
        '
        'pnlVar
        '
        Me.pnlVar.BackColor = System.Drawing.SystemColors.Control
        Me.pnlVar.Controls.Add(Me.chkTranslate)
        Me.pnlVar.Controls.Add(Me.chkShowMulti)
        Me.pnlVar.Controls.Add(Me.listMain)
        Me.pnlVar.Controls.Add(Me.chkHighlight)
        Me.pnlVar.Controls.Add(Me.btnVarAdd)
        Me.pnlVar.Controls.Add(Me.btnVarDelete)
        Me.pnlVar.Location = New System.Drawing.Point(602, 74)
        Me.pnlVar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlVar.Name = "pnlVar"
        Me.pnlVar.Size = New System.Drawing.Size(333, 581)
        Me.pnlVar.TabIndex = 12
        '
        'chkTranslate
        '
        Me.chkTranslate.AutoSize = True
        Me.chkTranslate.Location = New System.Drawing.Point(18, 549)
        Me.chkTranslate.Name = "chkTranslate"
        Me.chkTranslate.Size = New System.Drawing.Size(298, 29)
        Me.chkTranslate.TabIndex = 15
        Me.chkTranslate.Text = "Translate 'Variable to Sample'"
        Me.chkTranslate.UseVisualStyleBackColor = True
        '
        'chkShowMulti
        '
        Me.chkShowMulti.AutoSize = True
        Me.chkShowMulti.Location = New System.Drawing.Point(18, 502)
        Me.chkShowMulti.Name = "chkShowMulti"
        Me.chkShowMulti.Size = New System.Drawing.Size(302, 29)
        Me.chkShowMulti.TabIndex = 14
        Me.chkShowMulti.Text = "Show side by side comparison"
        Me.chkShowMulti.UseVisualStyleBackColor = True
        '
        'listMain
        '
        Me.listMain.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Variable, Me.Sample})
        Me.listMain.Cursor = System.Windows.Forms.Cursors.Cross
        Me.listMain.FullRowSelect = True
        Me.listMain.GridLines = True
        Me.listMain.HideSelection = False
        Me.listMain.HotTracking = True
        Me.listMain.HoverSelection = True
        Me.listMain.Location = New System.Drawing.Point(18, 3)
        Me.listMain.MultiSelect = False
        Me.listMain.Name = "listMain"
        Me.listMain.Size = New System.Drawing.Size(304, 368)
        Me.listMain.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.listMain.TabIndex = 11
        Me.listMain.UseCompatibleStateImageBehavior = False
        Me.listMain.View = System.Windows.Forms.View.Details
        '
        'Variable
        '
        Me.Variable.Text = "Variable"
        Me.Variable.Width = 150
        '
        'Sample
        '
        Me.Sample.Text = "Sample "
        Me.Sample.Width = 150
        '
        'chkHighlight
        '
        Me.chkHighlight.AutoSize = True
        Me.chkHighlight.Location = New System.Drawing.Point(18, 450)
        Me.chkHighlight.Name = "chkHighlight"
        Me.chkHighlight.Size = New System.Drawing.Size(312, 29)
        Me.chkHighlight.TabIndex = 10
        Me.chkHighlight.Text = "Highlight variables and samples"
        Me.chkHighlight.UseVisualStyleBackColor = True
        '
        'btnVarAdd
        '
        Me.btnVarAdd.BackColor = System.Drawing.Color.White
        Me.btnVarAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVarAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnVarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVarAdd.Location = New System.Drawing.Point(18, 378)
        Me.btnVarAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVarAdd.Name = "btnVarAdd"
        Me.btnVarAdd.Size = New System.Drawing.Size(138, 35)
        Me.btnVarAdd.TabIndex = 1
        Me.btnVarAdd.Text = "Add"
        Me.btnVarAdd.UseVisualStyleBackColor = False
        '
        'btnVarDelete
        '
        Me.btnVarDelete.BackColor = System.Drawing.Color.White
        Me.btnVarDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVarDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnVarDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVarDelete.Location = New System.Drawing.Point(184, 378)
        Me.btnVarDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVarDelete.Name = "btnVarDelete"
        Me.btnVarDelete.Size = New System.Drawing.Size(138, 35)
        Me.btnVarDelete.TabIndex = 5
        Me.btnVarDelete.Text = "Delete"
        Me.btnVarDelete.UseVisualStyleBackColor = False
        '
        'pnlAlt
        '
        Me.pnlAlt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlAlt.Controls.Add(Me.tblPnlAlt)
        Me.pnlAlt.Location = New System.Drawing.Point(326, 72)
        Me.pnlAlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlAlt.Name = "pnlAlt"
        Me.pnlAlt.Size = New System.Drawing.Size(259, 701)
        Me.pnlAlt.TabIndex = 8
        '
        'tblPnlAlt
        '
        Me.tblPnlAlt.ColumnCount = 2
        Me.tblPnlAlt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlAlt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlAlt.Controls.Add(Me.lblCharCountAlt, 0, 1)
        Me.tblPnlAlt.Controls.Add(Me.rtfAlt, 0, 0)
        Me.tblPnlAlt.Controls.Add(Me.lblCarCountSelectedAlt, 0, 2)
        Me.tblPnlAlt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPnlAlt.Location = New System.Drawing.Point(0, 0)
        Me.tblPnlAlt.Name = "tblPnlAlt"
        Me.tblPnlAlt.RowCount = 3
        Me.tblPnlAlt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPnlAlt.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblPnlAlt.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblPnlAlt.Size = New System.Drawing.Size(259, 701)
        Me.tblPnlAlt.TabIndex = 8
        '
        'lblCharCountAlt
        '
        Me.lblCharCountAlt.AutoSize = True
        Me.lblCharCountAlt.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCharCountAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharCountAlt.Location = New System.Drawing.Point(3, 551)
        Me.lblCharCountAlt.Name = "lblCharCountAlt"
        Me.lblCharCountAlt.Size = New System.Drawing.Size(119, 75)
        Me.lblCharCountAlt.TabIndex = 8
        Me.lblCharCountAlt.Text = "Total Characters:  0"
        '
        'rtfAlt
        '
        Me.tblPnlAlt.SetColumnSpan(Me.rtfAlt, 2)
        Me.rtfAlt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfAlt.Location = New System.Drawing.Point(3, 2)
        Me.rtfAlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtfAlt.Name = "rtfAlt"
        Me.rtfAlt.ReadOnly = True
        Me.rtfAlt.Size = New System.Drawing.Size(253, 547)
        Me.rtfAlt.TabIndex = 7
        Me.rtfAlt.Text = ""
        '
        'lblCarCountSelectedAlt
        '
        Me.lblCarCountSelectedAlt.AutoSize = True
        Me.lblCarCountSelectedAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarCountSelectedAlt.Location = New System.Drawing.Point(3, 626)
        Me.lblCarCountSelectedAlt.Name = "lblCarCountSelectedAlt"
        Me.lblCarCountSelectedAlt.Size = New System.Drawing.Size(119, 75)
        Me.lblCarCountSelectedAlt.TabIndex = 13
        Me.lblCarCountSelectedAlt.Text = "Selected Characters:  0"
        '
        'frmTextoid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(948, 796)
        Me.Controls.Add(Me.pnlAlt)
        Me.Controls.Add(Me.pnlVar)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.menuTextoid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.menuTextoid
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "frmTextoid"
        Me.Text = "Textoid"
        Me.menuTextoid.ResumeLayout(False)
        Me.menuTextoid.PerformLayout
        Me.pnlMain.ResumeLayout(False)
        Me.tblPnlMain.ResumeLayout(False)
        Me.tblPnlMain.PerformLayout
        Me.pnlVar.ResumeLayout(False)
        Me.pnlVar.PerformLayout
        Me.pnlAlt.ResumeLayout(False)
        Me.tblPnlAlt.ResumeLayout(False)
        Me.tblPnlAlt.PerformLayout
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub
    Friend WithEvents menuTextoid As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents rtfMain As RichTextBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblCharCount As Label
    Friend WithEvents diaOpenFile As OpenFileDialog
    Friend WithEvents diaSaveFile As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents lblCharCountSelected As Label
    Friend WithEvents pnlVar As Panel
    Friend WithEvents btnVarAdd As Button
    Friend WithEvents btnVarDelete As Button
    Friend WithEvents chkHighlight As CheckBox
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents listMain As ListView
    Friend WithEvents Variable As ColumnHeader
    Friend WithEvents Sample As ColumnHeader
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExportVariableListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlAlt As Panel
    Friend WithEvents rtfAlt As RichTextBox
    Friend WithEvents tblPnlMain As TableLayoutPanel
    Friend WithEvents tblPnlAlt As TableLayoutPanel
    Friend WithEvents lblCharCountAlt As Label
    Friend WithEvents lblCarCountSelectedAlt As Label
    Friend WithEvents chkTranslate As CheckBox
    Friend WithEvents chkShowMulti As CheckBox
End Class
