<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAverageUnitsShipped))
        Me.lblDayNumber = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblAverageEmployee1 = New System.Windows.Forms.Label()
        Me.lblAverageEmployee3 = New System.Windows.Forms.Label()
        Me.lblOverallAverage = New System.Windows.Forms.Label()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAverageEmployee2 = New System.Windows.Forms.Label()
        Me.txtBigDisplayEmployee1 = New System.Windows.Forms.TextBox()
        Me.txtBigDisplayEmployee2 = New System.Windows.Forms.TextBox()
        Me.txtBigDisplayEmployee3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblDayNumber
        '
        resources.ApplyResources(Me.lblDayNumber, "lblDayNumber")
        Me.lblDayNumber.Name = "lblDayNumber"
        Me.ToolTip1.SetToolTip(Me.lblDayNumber, resources.GetString("lblDayNumber.ToolTip"))
        '
        'lblUnits
        '
        resources.ApplyResources(Me.lblUnits, "lblUnits")
        Me.lblUnits.Name = "lblUnits"
        '
        'lblEmployee1
        '
        resources.ApplyResources(Me.lblEmployee1, "lblEmployee1")
        Me.lblEmployee1.Name = "lblEmployee1"
        '
        'lblEmployee2
        '
        resources.ApplyResources(Me.lblEmployee2, "lblEmployee2")
        Me.lblEmployee2.Name = "lblEmployee2"
        '
        'lblEmployee3
        '
        resources.ApplyResources(Me.lblEmployee3, "lblEmployee3")
        Me.lblEmployee3.Name = "lblEmployee3"
        '
        'lblAverageEmployee1
        '
        Me.lblAverageEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblAverageEmployee1, "lblAverageEmployee1")
        Me.lblAverageEmployee1.Name = "lblAverageEmployee1"
        Me.ToolTip1.SetToolTip(Me.lblAverageEmployee1, resources.GetString("lblAverageEmployee1.ToolTip"))
        '
        'lblAverageEmployee3
        '
        Me.lblAverageEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblAverageEmployee3, "lblAverageEmployee3")
        Me.lblAverageEmployee3.Name = "lblAverageEmployee3"
        Me.ToolTip1.SetToolTip(Me.lblAverageEmployee3, resources.GetString("lblAverageEmployee3.ToolTip"))
        '
        'lblOverallAverage
        '
        Me.lblOverallAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblOverallAverage, "lblOverallAverage")
        Me.lblOverallAverage.Name = "lblOverallAverage"
        Me.ToolTip1.SetToolTip(Me.lblOverallAverage, resources.GetString("lblOverallAverage.ToolTip"))
        '
        'tbxInput
        '
        resources.ApplyResources(Me.tbxInput, "tbxInput")
        Me.tbxInput.Name = "tbxInput"
        Me.ToolTip1.SetToolTip(Me.tbxInput, resources.GetString("tbxInput.ToolTip"))
        '
        'btnEnter
        '
        resources.ApplyResources(Me.btnEnter, "btnEnter")
        Me.btnEnter.Name = "btnEnter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, resources.GetString("btnEnter.ToolTip"))
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.BtnReset, "BtnReset")
        Me.BtnReset.Name = "BtnReset"
        Me.ToolTip1.SetToolTip(Me.BtnReset, resources.GetString("BtnReset.ToolTip"))
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        Me.ToolTip1.SetToolTip(Me.btnExit, resources.GetString("btnExit.ToolTip"))
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAverageEmployee2
        '
        Me.lblAverageEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblAverageEmployee2, "lblAverageEmployee2")
        Me.lblAverageEmployee2.Name = "lblAverageEmployee2"
        Me.ToolTip1.SetToolTip(Me.lblAverageEmployee2, resources.GetString("lblAverageEmployee2.ToolTip"))
        '
        'txtBigDisplayEmployee1
        '
        Me.txtBigDisplayEmployee1.BackColor = System.Drawing.SystemColors.ControlLightLight
        resources.ApplyResources(Me.txtBigDisplayEmployee1, "txtBigDisplayEmployee1")
        Me.txtBigDisplayEmployee1.Name = "txtBigDisplayEmployee1"
        Me.txtBigDisplayEmployee1.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.txtBigDisplayEmployee1, resources.GetString("txtBigDisplayEmployee1.ToolTip"))
        '
        'txtBigDisplayEmployee2
        '
        Me.txtBigDisplayEmployee2.BackColor = System.Drawing.SystemColors.ControlLightLight
        resources.ApplyResources(Me.txtBigDisplayEmployee2, "txtBigDisplayEmployee2")
        Me.txtBigDisplayEmployee2.Name = "txtBigDisplayEmployee2"
        Me.txtBigDisplayEmployee2.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.txtBigDisplayEmployee2, resources.GetString("txtBigDisplayEmployee2.ToolTip"))
        '
        'txtBigDisplayEmployee3
        '
        Me.txtBigDisplayEmployee3.BackColor = System.Drawing.SystemColors.ControlLightLight
        resources.ApplyResources(Me.txtBigDisplayEmployee3, "txtBigDisplayEmployee3")
        Me.txtBigDisplayEmployee3.Name = "txtBigDisplayEmployee3"
        Me.txtBigDisplayEmployee3.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.txtBigDisplayEmployee3, resources.GetString("txtBigDisplayEmployee3.ToolTip"))
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnReset
        Me.Controls.Add(Me.txtBigDisplayEmployee3)
        Me.Controls.Add(Me.txtBigDisplayEmployee2)
        Me.Controls.Add(Me.txtBigDisplayEmployee1)
        Me.Controls.Add(Me.lblAverageEmployee2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.lblOverallAverage)
        Me.Controls.Add(Me.lblAverageEmployee3)
        Me.Controls.Add(Me.lblAverageEmployee1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDayNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDayNumber As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblAverageEmployee1 As Label
    Friend WithEvents lblAverageEmployee3 As Label
    Friend WithEvents lblOverallAverage As Label
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblAverageEmployee2 As Label
    Friend WithEvents txtBigDisplayEmployee1 As TextBox
    Friend WithEvents txtBigDisplayEmployee2 As TextBox
    Friend WithEvents txtBigDisplayEmployee3 As TextBox
End Class
