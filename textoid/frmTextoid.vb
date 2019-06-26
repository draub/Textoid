Option Explicit On
Imports System.IO
Public Class frmTextoid
    Dim charCount, charCountSelected, charCountAlt, charCountSelectedAlt As Integer
    Dim isMultiPanel As Boolean = False
    Dim isTranslated As Boolean = False

    '===========================================
    ' Initialization, layout and resizing
    '===========================================
    Private Sub FrmTextoid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmTextoidLayout()
        loadXmlData()
    End Sub

    Private Sub frmTextoidLayout()
        If isMultiPanel = True Then
            With pnlMain
                .Top = 55
                .Left = 5
                .Width = (Me.Width - pnlVar.Width - 10) / 2
                .Height = Me.Height - 95
            End With

            With pnlAlt
                .Top = pnlMain.Top
                .Left = pnlMain.Width
                .Width = pnlMain.Width
                .Height = pnlMain.Height
                .Visible = True
            End With
        Else
            With pnlMain
                .Top = 55
                .Left = 5
                .Width = Me.Width - pnlVar.Width - 15
                .Height = Me.Height - 95
            End With

            With pnlAlt
                .Visible = False
            End With
        End If

        With pnlVar
            .Top = (Me.Height / 2) - (pnlVar.Height / 2)
            .Left = Me.Width - pnlVar.Width - 15
        End With
    End Sub

    Private Sub frmTextoid_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        frmTextoidLayout()
    End Sub


    '===========================================
    ' Menu Items
    '===========================================


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            If diaOpenFile.ShowDialog() = DialogResult.OK Then
                Using StreamReader As New StreamReader(diaOpenFile.FileName)
                    rtfMain.Text = StreamReader.ReadToEnd()
                End Using

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            If diaSaveFile.ShowDialog() = DialogResult.OK Then
                Using StreamWriter = File.CreateText(diaSaveFile.FileName)
                    StreamWriter.Write(rtfMain.Text)
                End Using

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutForm As New frmAbout
        aboutForm.Show()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        rtfMain.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        rtfMain.Redo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        rtfMain.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        rtfMain.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        rtfMain.Paste()
    End Sub

    '===========================================
    ' Text appearance and handling
    '===========================================


    Private Sub rtfMain_TextChanged(sender As Object, e As EventArgs) Handles rtfMain.TextChanged
        charCount = rtfMain.TextLength
        lblCharCount.Text = $"Total Characters:  {charCount}"

        rtfAlt.Text = rtfMain.Text

        If isMultiPanel = True Then
            If isTranslated = True Then
                translateToSample()
            End If
        End If

        If chkHighlight.Checked Then
            rtfMain.ForeColor = Color.SlateGray
            highLight()
        End If
    End Sub

    Private Sub RtfAlt_TextChanged(sender As Object, e As EventArgs) Handles rtfAlt.TextChanged
        charCountAlt = rtfAlt.TextLength
        lblCharCountAlt.Text = $"Total Characters:  {charCountAlt}"
    End Sub

    Private Sub rtfMain_SelectionChanged(sender As Object, e As EventArgs) Handles rtfMain.SelectionChanged
        charCountSelected = rtfMain.SelectedText.Length
        lblCharCountSelected.Text = $"Selected Characters:  {charCountSelected}"
    End Sub

    Private Sub rtfAlt_SelectionChanged(sender As Object, e As EventArgs) Handles rtfAlt.SelectionChanged
        charCountselectedAlt = rtfAlt.SelectedText.Length
        lblCarCountSelectedAlt.Text = $"Selected Characters:  {charCountselectedAlt}"
    End Sub

    '===========================================
    ' Buttons and checkboxes
    '===========================================

    Private Sub BtnVarAdd_Click(sender As Object, e As EventArgs) Handles btnVarAdd.Click
        frmTextoidInput.Show()
    End Sub

    Private Sub BtnVarDelete_Click(sender As Object, e As EventArgs) Handles btnVarDelete.Click
        listDelete()
    End Sub

    Private Sub ChkHighlight_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkHighlight.CheckedChanged
        If chkHighlight.Checked Then
            highLight()
        Else
            highLightClear()
            highlightOff()
        End If
    End Sub

    Private Sub ChkShowMulti_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowMulti.CheckedChanged
        If chkShowMulti.Checked Then
            isMultiPanel = True
            chkTranslate.Enabled = True
            If isTranslated = True Then
                translateToSample()
            End If
        Else
            isMultiPanel = False
            chkTranslate.Enabled = False
        End If

        frmTextoidLayout()
    End Sub

    Private Sub ChkTranslate_CheckedChanged(sender As Object, e As EventArgs) Handles chkTranslate.CheckedChanged
        If chkTranslate.Checked Then
            isTranslated = True
        Else
            isTranslated = False
            translateOff()
        End If
    End Sub
End Class
