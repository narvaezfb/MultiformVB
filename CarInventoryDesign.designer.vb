<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNewCheck = New System.Windows.Forms.Label()
        Me.cmbMakes = New System.Windows.Forms.ComboBox()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.chBoxNew = New System.Windows.Forms.CheckBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.BackColor = System.Drawing.Color.Transparent
        Me.lblMake.Location = New System.Drawing.Point(61, 17)
        Me.lblMake.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(64, 17)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.BackColor = System.Drawing.Color.Transparent
        Me.lblModel.Location = New System.Drawing.Point(61, 47)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(64, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(61, 79)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(64, 17)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Location = New System.Drawing.Point(61, 110)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(64, 17)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNewCheck
        '
        Me.lblNewCheck.BackColor = System.Drawing.Color.Transparent
        Me.lblNewCheck.Location = New System.Drawing.Point(61, 150)
        Me.lblNewCheck.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewCheck.Name = "lblNewCheck"
        Me.lblNewCheck.Size = New System.Drawing.Size(64, 17)
        Me.lblNewCheck.TabIndex = 8
        Me.lblNewCheck.Text = "&New:"
        Me.lblNewCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMakes
        '
        Me.cmbMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMakes.FormattingEnabled = True
        Me.cmbMakes.Items.AddRange(New Object() {"Acura", "Alfa Romeo", "Audi", "BMW", "Bentley", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Fiat", "Ford", "GMC", "Genesis", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Mazda", "Mercedes-Benz", "Mercury", "Mini", "Mitsubishi", "Nissan", "Polestar", "Pontiac", "Porsche", "Ram", "Rivian", "Rolls-Royce", "Saab", "Saturn", "Scion", "Smart", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo"})
        Me.cmbMakes.Location = New System.Drawing.Point(147, 17)
        Me.cmbMakes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbMakes.Name = "cmbMakes"
        Me.cmbMakes.Size = New System.Drawing.Size(137, 24)
        Me.cmbMakes.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbMakes, "Select the make or manufacter ")
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(147, 47)
        Me.tbModel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(137, 23)
        Me.tbModel.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbModel, "Select the model of the Car")
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(147, 110)
        Me.tbPrice.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(137, 23)
        Me.tbPrice.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.tbPrice, "Enter the price of the Car")
        '
        'chBoxNew
        '
        Me.chBoxNew.AutoSize = True
        Me.chBoxNew.Location = New System.Drawing.Point(147, 150)
        Me.chBoxNew.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chBoxNew.Name = "chBoxNew"
        Me.chBoxNew.Size = New System.Drawing.Size(18, 17)
        Me.chBoxNew.TabIndex = 9
        Me.chBoxNew.UseVisualStyleBackColor = True
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.HideSelection = False
        Me.lvwCars.Location = New System.Drawing.Point(15, 176)
        Me.lvwCars.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(529, 286)
        Me.lvwCars.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.lvwCars, "List View of the Cars entered from the user")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New?"
        '
        'colId
        '
        Me.colId.Text = "ID"
        Me.colId.Width = 30
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 80
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 80
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 50
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 80
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.MintCream
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(15, 466)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(531, 77)
        Me.lblOutput.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.lblOutput, "Result of the inputs")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(218, 556)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(83, 33)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Press Enter to add the new Car to the list view")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(332, 556)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 33)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Press Enter to Reset")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(447, 556)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 33)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Press Exit to close the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", ""})
        Me.cmbYear.Location = New System.Drawing.Point(147, 79)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(137, 24)
        Me.cmbYear.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cmbYear, "Select the Year of the Car")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(558, 610)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.chBoxNew)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMakes)
        Me.Controls.Add(Me.lblNewCheck)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Font = New System.Drawing.Font("Century", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNewCheck As Label
    Friend WithEvents cmbMakes As ComboBox
    Friend WithEvents tbModel As TextBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents chBoxNew As CheckBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents cmbYear As ComboBox
End Class
