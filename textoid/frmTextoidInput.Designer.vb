<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTextoidInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTextoidInput))
        Me.cmdInputOkay = New System.Windows.Forms.Button()
        Me.cmdInputCancel = New System.Windows.Forms.Button()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cboVarCategory = New System.Windows.Forms.ComboBox()
        Me.lblTagExample = New System.Windows.Forms.Label()
        Me.lblTagTag = New System.Windows.Forms.Label()
        Me.txtVarSample = New System.Windows.Forms.TextBox()
        Me.txtVarVar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdInputOkay
        '
        resources.ApplyResources(Me.cmdInputOkay, "cmdInputOkay")
        Me.cmdInputOkay.BackColor = System.Drawing.Color.White
        Me.cmdInputOkay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdInputOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdInputOkay.Name = "cmdInputOkay"
        Me.cmdInputOkay.UseVisualStyleBackColor = False
        '
        'cmdInputCancel
        '
        resources.ApplyResources(Me.cmdInputCancel, "cmdInputCancel")
        Me.cmdInputCancel.BackColor = System.Drawing.Color.White
        Me.cmdInputCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdInputCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdInputCancel.Name = "cmdInputCancel"
        Me.cmdInputCancel.UseVisualStyleBackColor = False
        '
        'lblCategory
        '
        resources.ApplyResources(Me.lblCategory, "lblCategory")
        Me.lblCategory.ForeColor = System.Drawing.Color.Black
        Me.lblCategory.Name = "lblCategory"
        '
        'cboVarCategory
        '
        resources.ApplyResources(Me.cboVarCategory, "cboVarCategory")
        Me.cboVarCategory.FormattingEnabled = True
        Me.cboVarCategory.Name = "cboVarCategory"
        '
        'lblTagExample
        '
        resources.ApplyResources(Me.lblTagExample, "lblTagExample")
        Me.lblTagExample.ForeColor = System.Drawing.Color.Black
        Me.lblTagExample.Name = "lblTagExample"
        '
        'lblTagTag
        '
        resources.ApplyResources(Me.lblTagTag, "lblTagTag")
        Me.lblTagTag.ForeColor = System.Drawing.Color.Black
        Me.lblTagTag.Name = "lblTagTag"
        '
        'txtVarSample
        '
        resources.ApplyResources(Me.txtVarSample, "txtVarSample")
        Me.txtVarSample.Name = "txtVarSample"
        '
        'txtVarVar
        '
        resources.ApplyResources(Me.txtVarVar, "txtVarVar")
        Me.txtVarVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVarVar.Name = "txtVarVar"
        '
        'frmTextoidInput
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cboVarCategory)
        Me.Controls.Add(Me.lblTagExample)
        Me.Controls.Add(Me.lblTagTag)
        Me.Controls.Add(Me.txtVarSample)
        Me.Controls.Add(Me.txtVarVar)
        Me.Controls.Add(Me.cmdInputCancel)
        Me.Controls.Add(Me.cmdInputOkay)
        Me.Name = "frmTextoidInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdInputOkay As Button
    Friend WithEvents cmdInputCancel As Button
    Friend WithEvents lblCategory As Label
    Friend WithEvents cboVarCategory As ComboBox
    Friend WithEvents lblTagExample As Label
    Friend WithEvents lblTagTag As Label
    Friend WithEvents txtVarSample As TextBox
    Friend WithEvents txtVarVar As TextBox
End Class
