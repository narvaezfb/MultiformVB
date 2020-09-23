<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.tlStrip = New System.Windows.Forms.ToolStrip()
        Me.btnToolStripNewFile = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripOpenFile = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripSaveFile = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripNewCarList = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripAverageUnitsShipped = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuWindowsOpenCarList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsTextEditor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsAverageUnitsShip = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpnFileDialog0 = New System.Windows.Forms.OpenFileDialog()
        Me.tlStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlStrip
        '
        Me.tlStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToolStripNewFile, Me.btnToolStripOpenFile, Me.btnToolStripSaveFile, Me.btnToolStripNewCarList, Me.btnToolStripAverageUnitsShipped})
        Me.tlStrip.Location = New System.Drawing.Point(0, 28)
        Me.tlStrip.Name = "tlStrip"
        Me.tlStrip.Size = New System.Drawing.Size(1203, 27)
        Me.tlStrip.TabIndex = 6
        Me.tlStrip.Text = "ToolStrip1"
        '
        'btnToolStripNewFile
        '
        Me.btnToolStripNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNewFile.Image = Global.Lab6_Multiform.My.Resources.Resources.índice
        Me.btnToolStripNewFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNewFile.Name = "btnToolStripNewFile"
        Me.btnToolStripNewFile.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripNewFile.Text = "New File"
        '
        'btnToolStripOpenFile
        '
        Me.btnToolStripOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripOpenFile.Image = Global.Lab6_Multiform.My.Resources.Resources.folder_open
        Me.btnToolStripOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripOpenFile.Name = "btnToolStripOpenFile"
        Me.btnToolStripOpenFile.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripOpenFile.Text = "Open File"
        '
        'btnToolStripSaveFile
        '
        Me.btnToolStripSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripSaveFile.Image = Global.Lab6_Multiform.My.Resources.Resources.save
        Me.btnToolStripSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripSaveFile.Name = "btnToolStripSaveFile"
        Me.btnToolStripSaveFile.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripSaveFile.Text = "Save File"
        '
        'btnToolStripNewCarList
        '
        Me.btnToolStripNewCarList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNewCarList.Image = Global.Lab6_Multiform.My.Resources.Resources.images
        Me.btnToolStripNewCarList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNewCarList.Name = "btnToolStripNewCarList"
        Me.btnToolStripNewCarList.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripNewCarList.Text = "New Car List"
        '
        'btnToolStripAverageUnitsShipped
        '
        Me.btnToolStripAverageUnitsShipped.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripAverageUnitsShipped.Image = Global.Lab6_Multiform.My.Resources.Resources.average2
        Me.btnToolStripAverageUnitsShipped.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripAverageUnitsShipped.Name = "btnToolStripAverageUnitsShipped"
        Me.btnToolStripAverageUnitsShipped.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripAverageUnitsShipped.Text = "Open a new Average Units Ship"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuWindows, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1203, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileClose, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "File options"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Image = Global.Lab6_Multiform.My.Resources.Resources.índice
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(224, 26)
        Me.mnuFileNew.Text = "&New"
        Me.mnuFileNew.ToolTipText = "Create  a new file"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Image = Global.Lab6_Multiform.My.Resources.Resources.folder_open
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(224, 26)
        Me.mnuFileOpen.Text = "&Open"
        Me.mnuFileOpen.ToolTipText = "Open a file"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Image = Global.Lab6_Multiform.My.Resources.Resources.save
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(224, 26)
        Me.mnuFileSave.Text = "&Save"
        Me.mnuFileSave.ToolTipText = "Save a file"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(224, 26)
        Me.mnuFileSaveAs.Text = "Save &As"
        Me.mnuFileSaveAs.ToolTipText = "Save file as"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Image = Global.Lab6_Multiform.My.Resources.Resources.close
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(224, 26)
        Me.mnuFileClose.Text = "&Close"
        Me.mnuFileClose.ToolTipText = "Close the current window"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Image = Global.Lab6_Multiform.My.Resources.Resources._exit
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(224, 26)
        Me.mnuFileExit.Text = "E&xit"
        Me.mnuFileExit.ToolTipText = "Exit the application"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditCut, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(49, 24)
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.ToolTipText = "Edit options"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Image = Global.Lab6_Multiform.My.Resources.Resources.copy
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(177, 26)
        Me.mnuEditCopy.Text = "&Copy"
        Me.mnuEditCopy.ToolTipText = "Copy the text selected"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Image = Global.Lab6_Multiform.My.Resources.Resources.cut
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(177, 26)
        Me.mnuEditCut.Text = "C&ut"
        Me.mnuEditCut.ToolTipText = "Cut the text selected"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Image = Global.Lab6_Multiform.My.Resources.Resources.paste
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(177, 26)
        Me.mnuEditPaste.Text = "&Paste"
        Me.mnuEditPaste.ToolTipText = "Paste selected"
        '
        'mnuWindows
        '
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowsCascade, Me.mnuWindowsTileHorizontal, Me.mnuWindowsTileVertical, Me.ToolStripSeparator1, Me.mnuWindowsOpenCarList, Me.mnuWindowsTextEditor, Me.mnuWindowsAverageUnitsShip})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(84, 24)
        Me.mnuWindows.Text = "&Windows"
        Me.mnuWindows.ToolTipText = "Windows menu"
        '
        'mnuWindowsCascade
        '
        Me.mnuWindowsCascade.Name = "mnuWindowsCascade"
        Me.mnuWindowsCascade.Size = New System.Drawing.Size(217, 26)
        Me.mnuWindowsCascade.Text = "&Cascade"
        Me.mnuWindowsCascade.ToolTipText = "Cascade layout"
        '
        'mnuWindowsTileHorizontal
        '
        Me.mnuWindowsTileHorizontal.Name = "mnuWindowsTileHorizontal"
        Me.mnuWindowsTileHorizontal.Size = New System.Drawing.Size(217, 26)
        Me.mnuWindowsTileHorizontal.Text = "Tile &Horizontal"
        Me.mnuWindowsTileHorizontal.ToolTipText = "Horizontal layout"
        '
        'mnuWindowsTileVertical
        '
        Me.mnuWindowsTileVertical.Name = "mnuWindowsTileVertical"
        Me.mnuWindowsTileVertical.Size = New System.Drawing.Size(217, 26)
        Me.mnuWindowsTileVertical.Text = "Tile &Vertical"
        Me.mnuWindowsTileVertical.ToolTipText = "Vertical layout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'mnuWindowsOpenCarList
        '
        Me.mnuWindowsOpenCarList.Name = "mnuWindowsOpenCarList"
        Me.mnuWindowsOpenCarList.Size = New System.Drawing.Size(217, 26)
        Me.mnuWindowsOpenCarList.Text = "Open &Car List"
        Me.mnuWindowsOpenCarList.ToolTipText = "Open  a new car list"
        '
        'mnuWindowsTextEditor
        '
        Me.mnuWindowsTextEditor.Name = "mnuWindowsTextEditor"
        Me.mnuWindowsTextEditor.Size = New System.Drawing.Size(217, 26)
        Me.mnuWindowsTextEditor.Text = "New &Text Editor"
        Me.mnuWindowsTextEditor.ToolTipText = "Open a new text editor"
        '
        'mnuWindowsAverageUnitsShip
        '
        Me.mnuWindowsAverageUnitsShip.Name = "mnuWindowsAverageUnitsShip"
        Me.mnuWindowsAverageUnitsShip.Size = New System.Drawing.Size(217, 26)
        Me.mnuWindowsAverageUnitsShip.Text = "&Average Units Ship"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(55, 24)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "Help options"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mnuHelpAbout.Size = New System.Drawing.Size(190, 26)
        Me.mnuHelpAbout.Text = "About"
        Me.mnuHelpAbout.ToolTipText = "about the application"
        '
        'OpnFileDialog0
        '
        Me.OpnFileDialog0.FileName = "OpenFileDialog"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 680)
        Me.Controls.Add(Me.tlStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fabian's Multi Text Editor"
        Me.tlStrip.ResumeLayout(False)
        Me.tlStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlStrip As ToolStrip
    Friend WithEvents btnToolStripNewFile As ToolStripButton
    Friend WithEvents btnToolStripOpenFile As ToolStripButton
    Friend WithEvents btnToolStripSaveFile As ToolStripButton
    Friend WithEvents btnToolStripNewCarList As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuWindows As ToolStripMenuItem
    Friend WithEvents mnuWindowsCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowsTileHorizontal As ToolStripMenuItem
    Friend WithEvents mnuWindowsTileVertical As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuWindowsOpenCarList As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuWindowsTextEditor As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents mnuWindowsAverageUnitsShip As ToolStripMenuItem
    Friend WithEvents btnToolStripAverageUnitsShipped As ToolStripButton
    Friend WithEvents OpnFileDialog0 As OpenFileDialog
End Class
