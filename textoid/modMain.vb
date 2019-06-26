Option Explicit On
Imports System.IO
Imports System.Xml


Module modMain
    Public uiList As ListView = frmTextoid.listMain
    Public uiText As RichTextBox = frmTextoid.rtfMain
    Public uiTextAlt As RichTextBox = frmTextoid.rtfAlt
    Public softVersion As String = "0.1a"
    Public softVersionDate As String = "6/21/2019"
    Public xmlFileName As String = "variables.xml"


    '===========================================
    ' Highlighting Subs
    '===========================================

    Public Sub highLight()
        Dim iteration As Int32
        Dim listViewIndex As Int32 = uiList.Items.Count - 1
        Dim highlightText As String
        Dim rtfChoice As RichTextBox
        Dim cursorPos As Object

        Dim countNum, endNum, loopNum As Int32
        Dim highlightColorName As String = "Red"

        cursorPos = uiText.SelectionStart

        highLightClear()

        ' First Loop (Loop 0) is for rtfMain.   Second Loop (Loop 1) is for rtfAlt.
        For loopNum = 0 To 1
            If loopNum = 0 Then
                rtfChoice = uiText
            Else
                rtfChoice = uiTextAlt
            End If

            'Loop through all items in ListView box
            For iteration = 0 To listViewIndex

                If loopNum = 0 Then
                    highlightText = uiList.Items.Item(iteration).Text
                Else
                    highlightText = uiList.Items.Item(iteration).SubItems.Item(1).Text
                End If

                countNum = 0

                endNum = rtfChoice.Text.LastIndexOf(highlightText)

                'Loop through each found instance of word in rtf box
                While countNum < endNum
                    rtfChoice.Find(highlightText, countNum, rtfChoice.TextLength, RichTextBoxFinds.None)
                    rtfChoice.SelectionColor = Color.FromName(highlightColorName)
                    countNum = rtfChoice.Text.IndexOf(highlightText, countNum) + 1
                End While

            Next
        Next

        uiText.SelectionStart = cursorPos
    End Sub

    Public Sub highLightClear()
        uiText.ForeColor = Color.DarkSlateGray
        uiTextAlt.ForeColor = Color.DarkSlateGray
    End Sub

    Public Sub highlightOff()
        uiText.ForeColor = Color.Black
        uiTextAlt.ForeColor = Color.Black
    End Sub

    '===========================================
    ' Translate Subs
    '===========================================

    Public Sub translateToSample()
        Dim varText, sampleText As String
        Dim iteration As Int32
        Dim rtfIndex As Int32
        Dim listViewIndex As Int32 = uiList.Items.Count - 1

        For iteration = 0 To listViewIndex

            varText = uiList.Items.Item(iteration).Text
            sampleText = uiList.Items.Item(iteration).SubItems.Item(1).Text

            'find the variable text in rtfAlt
            rtfIndex = uiTextAlt.Find(varText)

            If rtfIndex <> -1 Then
                uiTextAlt.Select(rtfIndex, varText.Length)

                If uiTextAlt.SelectedText <> "" Then
                    uiTextAlt.SelectedText = sampleText
                End If

            End If
        Next


    End Sub


    Public Sub translateOff()
        Dim mainText As String = uiText.Text

        uiText.Text = ""
        uiText.Text = mainText
    End Sub


    '===========================================
    ' ListView Subs / Functions
    '===========================================

    Public Sub listAdd(ByVal addCat As String, ByVal addVar As String, ByVal addSample As String)
        Dim xCat As New ListViewGroup(addCat)
        Dim xItem As New ListViewItem(addVar)
        Dim xCatExists As Boolean

        xCatExists = uiList.Groups.Contains(xCat)

        'Only add category if it does NOT already exist
        If xCatExists = False Then
            uiList.Groups.Add(New ListViewGroup(addCat, addCat))
            frmTextoidInput.comboListAppend(addCat)
        End If

        With xItem
            .SubItems.Add(addSample)
            .Group = uiList.Groups(addCat)
        End With

        uiList.Items.Add(xItem)
        frmTextoidInput.comboListAppend(addCat)

    End Sub

    Public Sub listDelete()
        For Each item As ListViewItem In uiList.SelectedItems
            item.Remove()
        Next
    End Sub


    '===========================================
    ' ListView Subs / Functions
    '===========================================

    Public Sub loadXmlData()
        Dim groupText, varText, sampleText As String

        Dim xmlDoc As New Xml.XmlDocument
        Dim xmlDocNodeList As XmlNodeList
        Dim xmlDocNode As XmlNode

        xmlDoc.Load(xmlFileName)
        xmlDocNodeList = xmlDoc.GetElementsByTagName("item")

        For Each xmlDocNode In xmlDocNodeList
            groupText = xmlDocNode.Item("group").InnerText
            varText = xmlDocNode.Item("variable").InnerText
            sampleText = xmlDocNode.Item("sample").InnerText


            listAdd(groupText, varText, sampleText)
        Next
    End Sub

    '===========================================
    ' XML subs
    '===========================================

    Public Sub saveXmlData()
        Dim groupText, varText, sampleText As String

        Dim iteration As Int32
        Dim listViewIndex As Int32 = uiList.Items.Count - 1

        Dim xmlWriter As New XmlTextWriter(xmlFileName, System.Text.Encoding.UTF8)

        With xmlWriter
            .WriteStartDocument(True)
            .Formatting = Formatting.Indented
            .Indentation = 2
        End With

        xmlWriter.WriteStartElement("root")

        For iteration = 0 To listViewIndex
            groupText = uiList.Items.Item(iteration).Group.ToString()
            varText = uiList.Items.Item(iteration).Text
            sampleText = uiList.Items.Item(iteration).SubItems.Item(1).Text

            xmlWriter.WriteStartElement("item")

            xmlWriter.WriteStartElement("variable")
            xmlWriter.WriteString(varText)
            xmlWriter.WriteEndElement()

            xmlWriter.WriteStartElement("sample")
            xmlWriter.WriteString(sampleText)
            xmlWriter.WriteEndElement()

            xmlWriter.WriteStartElement("group")
            xmlWriter.WriteString(groupText)
            xmlWriter.WriteEndElement()

            xmlWriter.WriteEndElement()

        Next

        xmlWriter.WriteEndElement()
        xmlWriter.WriteEndDocument()
        xmlWriter.Close()

        MessageBox.Show("XML Save complete.")
    End Sub

End Module
