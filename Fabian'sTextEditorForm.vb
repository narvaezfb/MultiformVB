' Name: Fabian Narvaez
' File Name: Lab 5 
' Date: 2020-04-05
' Description: This is my form text editor, It has the option to new, open, save and save as files. It also
' has the option to copy, paste, and cut text. It also has a briefly description of the form in the help option.

Option Strict On
'Import System IO in order to work with streams 
Imports System.IO


Public Class frmTextEditor

    'Declarations
    Dim isFileOpen As Boolean = False ' for the status of the file open
    Dim filePath As String = String.Empty ' file path 
    Dim isFileSave As Boolean = False ' for the status of the file save
    ''' <summary>
    ''' It will tell about the Fabian Text Editor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs)

        MessageBox.Show("Fabian Text Editor" & vbCrLf & vbCrLf & "By Fabian Narvaez" & vbCrLf & vbCrLf & "April 1, 2020")
    End Sub
    ''' <summary>
    ''' Close the application 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs)

        'close the application
        Me.Close()

    End Sub

    Friend Sub NewFile()

        'clear the text box 
        tbEditor.Clear()
        'file open is false
        isFileOpen = False
        'is file saved
        isFileSave = False
        'file path empty
        filePath = String.Empty
        'update the name of the file
        UpdateFormName()

    End Sub

    Friend Sub OpenFile()

        'Declarations for my stream readers 
        Dim openFile As FileStream
        Dim fileReader As StreamReader

        'if the user opens the file dialog
        If opdOpen.ShowDialog = DialogResult.OK Then

            'set file path equal to the file name and is file open equal true
            filePath = opdOpen.FileName
            isFileOpen = True

            'update the form name
            UpdateFormName()

            'create the new file object
            openFile = New FileStream(filePath, FileMode.Open, FileAccess.Read)

            'create the new object stream reader
            fileReader = New StreamReader(openFile)
            tbEditor.Text = fileReader.ReadToEnd

            'close the file reader
            fileReader.Close()
        End If


    End Sub

    Friend Sub SaveFileAs()

        'filtering in order to my files save as txt documents
        sfdSaveAs.Filter = "Text Documents|*.txt|Word Document|*.docx|All Files|*.*"
        sfdSaveAs.Title = "Save a Text File"

        'if the user selects a file
        If sfdSaveAs.ShowDialog() = DialogResult.OK Then
            'set the new file path and the new name for the form
            filePath = sfdSaveAs.FileName
            UpdateFormName()

            'is file save equal to true
            isFileSave = True
            'call the method to save the file
            SaveFileMethod(filePath)
        End If
    End Sub
    Friend Sub SaveFile()

        ' if the file is empty save as new file
        If filePath = String.Empty Then

            'filtering in order to my files save as txt documents
            sfdSaveAs.Filter = "Text Documents|*.txt|Word Document|*.docx|All Files|*.*"
            sfdSaveAs.Title = "Save a Text File"

            'if the user selects a file
            If sfdSaveAs.ShowDialog() = DialogResult.OK Then
                'set the new file path and the new name for the form
                filePath = sfdSaveAs.FileName
                UpdateFormName()

                'is file save equal to true
                isFileSave = True
                'call the method to save the file
                SaveFileMethod(filePath)
            End If

        Else

            'otherwise save in the same file
            SaveFileMethod(filePath)
        End If
    End Sub

    Friend Sub CopyText()

        'if there is something seletecd
        If tbEditor.SelectionLength > 0 Then

            'copy the the text selected
            My.Computer.Clipboard.SetText(tbEditor.SelectedText)
        Else
            'othewrwise indicate to the user that there is not anything seleted
            MessageBox.Show("There is nothing selected")

        End If

    End Sub

    Friend Sub PasteText()

        'if the user has selected text 
        If Clipboard.ContainsText Then

            'paste the text  selected
            tbEditor.Paste(Clipboard.GetText)
        Else
            'otherwise indicate the user that there is not anything to paste
            MessageBox.Show("There is nothing to paste")

        End If

    End Sub

    Friend Sub CutText()

        'if the user selects text 
        If Clipboard.ContainsText Then

            'Clear the text selected
            tbEditor.SelectedText = String.Empty

        End If
    End Sub
#Region "Methods"
    ''' <summary>
    ''' This method will help saving the files for both save and save as 
    ''' </summary>
    ''' <param name="path"></param>
    Friend Sub SaveFileMethod(path As String)
        'use the stream writers
        Dim saveFile As FileStream
        Dim fileWriter As StreamWriter

        'create a new file stream
        saveFile = New FileStream(path, FileMode.Create, FileAccess.Write)
        'create a new stream writer and set the name of the file to save
        fileWriter = New StreamWriter(saveFile)

        fileWriter.Write(tbEditor.Text)
        'close the stream writer
        fileWriter.Close()

    End Sub
    ''' <summary>
    ''' This method will allow to change the name of my form depending what is the user opening or saving
    ''' </summary>
    Friend Sub UpdateFormName()

        'declaring the name of my form
        Me.Text = "Fabian's Text Editor"

        'if file path is not empty
        If Not filePath = String.Empty Then

            'set my form's name plus the file path 
            Me.Text &= " - " & filePath

        End If
    End Sub
    ''' <summary>
    ''' This method will allow me to ask the user to save before the current file is closed
    ''' </summary>
    Friend Sub ConfirmClose()

        'create a new dialog
        Dim dialog As DialogResult
        'show the message to the user asking if whether the user wants to save the file or not
        dialog = MessageBox.Show("Do you want to save before the current file is closed ? ", "save", MessageBoxButtons.YesNo)

        'if the user click yes then save the file
        If dialog = DialogResult.Yes Then
            'if the file path is empty then create a new save file
            If filePath = String.Empty Then

                sfdSaveAs.Filter = "Text Documents|*.txt|Word Document|*.docx|All Files|*.*"
                sfdSaveAs.Title = "Save a Text File"

                'if the user selects a file
                If sfdSaveAs.ShowDialog() = DialogResult.OK Then
                    'set the new file path and the new name for the form
                    filePath = sfdSaveAs.FileName
                    UpdateFormName()

                    'is file save equal to true
                    isFileSave = True
                    'call the method to save the file
                    SaveFileMethod(filePath)
                End If

                'otherwise save in the same path
            Else

                SaveFileMethod(filePath)
            End If

        End If


    End Sub



#End Region

End Class
'end of program
