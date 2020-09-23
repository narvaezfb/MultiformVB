<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTextEditor
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
        Me.components = New System.ComponentModel.Container()
        Me.opdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbEditor = New System.Windows.Forms.TextBox()
        Me.sfdSaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'tbEditor
        '
        Me.tbEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEditor.Location = New System.Drawing.Point(0, 0)
        Me.tbEditor.Multiline = True
        Me.tbEditor.Name = "tbEditor"
        Me.tbEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbEditor.Size = New System.Drawing.Size(764, 480)
        Me.tbEditor.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.tbEditor, "Type any text")
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 480)
        Me.Controls.Add(Me.tbEditor)
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fabian's Text Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents opdOpen As OpenFileDialog
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents tbEditor As TextBox
    Friend WithEvents sfdSaveAs As SaveFileDialog
End Class
