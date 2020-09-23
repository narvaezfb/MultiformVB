' Author:  Fabian Narvaez
' Created:  April 11, 2020
' Modified: April 11, 2020
' Description:
'   A container form for 2 applications developed in the course of NETD 2202 in Winter 2020.
'   Thus far, it includes:
'   Car List Application
'   Fabian's Text editor

Option Strict On
Imports System.IO
Public Class frmMain
    Dim filePath As String = String.Empty

    ''' <summary>
    ''' This event will open a new instance of the form Car Inventory List
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowNewCarList(sender As Object, e As EventArgs) Handles btnToolStripNewCarList.Click, mnuWindowsOpenCarList.Click
        For Each form As Form In Application.OpenForms
            If TypeOf form Is frmCarInventory Then
                form.Activate()
                Return
            End If
        Next
        Dim myCarlist As New frmCarInventory   ' Create a new instance of the Car List form
        myCarlist.MdiParent = Me               ' Set the new instance to be an MdiChild
        myCarlist.Show()                       ' Display the instance of the Car List form


    End Sub
    ''' <summary>
    ''' This event will open a new instance of the form Fabian's Text Editor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowNewTextEditor(sender As Object, e As EventArgs) Handles btnToolStripNewFile.Click, mnuWindowsTextEditor.Click

        Dim myTextEditor As New frmTextEditor  ' Create a new instance of the Text Editor form

        myTextEditor.MdiParent = Me            ' Set the new instance to be an MdiChild
        myTextEditor.Show()                    ' Display the instance of the text editor form

    End Sub
    ''' <summary>
    ''' This event will open a new instance of the form Average Units Shipped
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowNewAverageUnitsShipped(sender As Object, e As EventArgs) Handles mnuWindowsAverageUnitsShip.Click, btnToolStripAverageUnitsShipped.Click


        Dim myaverageUnitsShipped As New frmAverageUnitsShipped  ' Create a new instance of the Average Units Shipped form
        myaverageUnitsShipped.MdiParent = Me                     ' Set the new instance to be an MdiChild
        myaverageUnitsShipped.Show()                             ' Display the instance of the Average Units Shipped form

    End Sub
    ''' <summary>
    ''' If a text editor form is active, open a file to the text editor 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click, btnToolStripOpenFile.Click



        Dim myTextEditor As New frmTextEditor  ' Create a new instance of the Text Editor form
        myTextEditor.MdiParent = Me            ' Set the new instance to be an MdiChild


        Dim openFile As FileStream
        Dim fileReader As StreamReader

        If OpnFileDialog0.ShowDialog = DialogResult.OK Then
            filePath = OpnFileDialog0.FileName
            openFile = New FileStream(filePath, FileMode.Open, FileAccess.Read)
            fileReader = New StreamReader(openFile)
            myTextEditor.Show()
            myTextEditor.tbEditor.Text = fileReader.ReadToEnd
            fileReader.Close()
            CType(ActiveMdiChild, frmTextEditor).UpdateFormName()

        End If



    End Sub
    ''' <summary>
    ''' This event will allow the main form to open a new text editor file 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click

        '

        Dim myTextEditor As New frmTextEditor  ' Create a new instance of the Text Editor form
        myTextEditor.MdiParent = Me            ' Set the new instance to be an MdiChild
        myTextEditor.Show()                    ' Display the instance of the text editor form

        ' This will perform newfile method and clear the file as a new file
        CType(ActiveMdiChild, frmTextEditor).NewFile()


    End Sub
    ''' <summary>
    ''' If a text editor form is active, save as  the current file text 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click

        ' This operation can only be performed on text editors forms
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            CType(ActiveMdiChild, frmTextEditor).SaveFileAs()
        Else
            MessageBox.Show("You must be in text editor application to make this operation", "Operation Denied")

        End If
    End Sub
    ''' <summary>
    ''' If a text editor form is active, save the current file text 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click, btnToolStripSaveFile.Click
        ' This operation can only be performed on text editors forms
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            CType(ActiveMdiChild, frmTextEditor).SaveFile()
        Else
            MessageBox.Show("You must be in text editor application to make this operation", "Operation Denied")

        End If
    End Sub
    ''' <summary>
    ''' If a text editor form is active, copy the current file text to the clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        ' This operation can only be performed on text editors forms
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            CType(ActiveMdiChild, frmTextEditor).CopyText()
        Else
            MessageBox.Show("You must be in text editor application to make this operation", "Operation Denied")

        End If
    End Sub
    ''' <summary>
    ''' If a text editor form is active, cut the text selected and delete it 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        ' This operation can only be performed on text editors forms
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            CType(ActiveMdiChild, frmTextEditor).CutText()
        Else
            MessageBox.Show("You must be in text editor application to make this operation", "Operation Denied")
        End If
    End Sub
    ''' <summary>
    ''' If a text editor form is active, attempts to paste into it from the clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click

        ' This operation can only be performed on text editors forms
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            CType(ActiveMdiChild, frmTextEditor).PasteText()
        Else
            MessageBox.Show("You must be in text editor application to make this operation", "Operation Denied")

        End If
    End Sub
    ''' <summary>
    ''' Close the entire form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Close the entire application
        Me.Close()

    End Sub
    ''' <summary>
    ''' Close the mdiChilds if there are otherwise ask the user to close the entire form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click

        'If the are mdichild forms close the current form
        If MdiChildren.Count > 0 Then
            ActiveMdiChild.Close()
        Else
            'otherwise close the entire application asking the user whether wants or not
            If MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo) =
                DialogResult.Yes Then

                Me.Close()
            End If
        End If

    End Sub
    ''' <summary>
    ''' Cascade all child windows
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowsCascade.Click

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub
    ''' <summary>
    ''' Tile all child windows horizontally
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowsTileHorizontal.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub
    ''' <summary>
    ''' Tile all child windows vertically
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowsTileVertical.Click

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub


End Class
