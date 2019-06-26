Option Explicit On

Public Class frmTextoidInput


    '===========================================
    ' Buttons 
    '===========================================

    Private Sub CmdInputOkay_Click(sender As Object, e As EventArgs) Handles cmdInputOkay.Click
        If validateFields(cboVarCategory.Text, txtVarVar.Text, txtVarSample.Text) Then
            listAdd(cboVarCategory.Text, txtVarVar.Text, txtVarSample.Text)
        End If
    End Sub

    Private Sub CmdInputCancel_Click(sender As Object, e As EventArgs) Handles cmdInputCancel.Click
        Me.Hide()
    End Sub

    '===========================================
    ' Subs / Functions
    '===========================================

    Public Sub comboListAppend(ByRef addCat As String)
        Dim isListed As Boolean = False

        For Each item As String In cboVarCategory.Items
            If addCat.ToUpper() = item.ToUpper() Then
                isListed = True
            End If
        Next

        If isListed = False Then
            cboVarCategory.Items.Add(addCat)
        End If
    End Sub


    Private Function validateFields(ByVal addCat As String, ByVal addVar As String, ByVal addSample As String) As Boolean
        Dim valCat, valVar, valSample As Boolean
        valCat = False
        valVar = False
        valSample = False

        If addCat.Trim() <> "" Then
            cboVarCategory.BackColor = Color.White
            valCat = True
        Else
            cboVarCategory.BackColor = Color.Yellow
            valCat = False
        End If

        If addVar.Trim() <> "" Then
            txtVarVar.BackColor = Color.White
            valVar = True
        Else
            txtVarVar.BackColor = Color.Yellow
            valVar = False
        End If

        If addSample.Trim <> "" Then
            txtVarSample.BackColor = Color.White
            valSample = True
        Else
            txtVarSample.BackColor = Color.Yellow
            valSample = False
        End If

        If valCat And valVar And valSample Then
            Return True
        Else
            MessageBox.Show("Please populate missing fields.")
            Return False
        End If
    End Function

End Class