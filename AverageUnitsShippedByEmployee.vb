'Author : Fabian Narvaez
'Date: February 26,2020
'Last modified: February 23, 2020 
'Description :Lab 4: This application will calculate the average of 7 days of 3 employees. This form will ask for the shipments values of three
'employees and after that . It will calculate the overall average. Using two dimensional arrays we will calculate the four averages outputs
'This application will have input validation as well as range validation. The user will be able to reset the form and use it as many time as the user wants



Option Strict On
Public Class frmAverageUnitsShipped
    'variables

    Dim Day As Integer = 0
    Dim employee As Integer = 0
    Dim AverageEmployeeWeekly As Double
    Dim totalEmployeeShipment As Double
    Dim averageOverallEmployeeShipment As Double
    Dim totalOverallEmployeeShipment As Double

    'constants
    Const DaysInWeek As Integer = 7
    Const NumberOfEmployees = 3

    'two dimensional array
    Dim valueOfEmployees(NumberOfEmployees - 1, DaysInWeek - 1) As Double

    ' arrays for my textboxes and labels
    Dim outputLabelArray() As Label
    Dim outputTextboxArray() As TextBox
    Dim labelsEmployee() As Label


    ''' <summary>
    ''' This event will load arrays and controls of my form 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AverageUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'array for my text boxes
        outputTextboxArray = {txtBigDisplayEmployee1, txtBigDisplayEmployee2, txtBigDisplayEmployee3}
        'array fro my average label of each employee
        outputLabelArray = {lblAverageEmployee1, lblAverageEmployee2, lblAverageEmployee3}
        'array for bold the employee labels
        labelsEmployee = {lblEmployee1, lblEmployee2, lblEmployee3}

    End Sub
    ''' <summary>
    ''' This event will validate my users input, and after that it will calculate the average of three employees and finally the overall average of those 3
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click


        'if the value entered is double

        If Double.TryParse(tbxInput.Text, valueOfEmployees(employee, Day)) Then

            'if all values are in the valid range 

            If valueOfEmployees(employee, Day) >= 0 And valueOfEmployees(employee, Day) <= 5000 Then

                'display the values entered from the user in the 3 big textboxes
                outputTextboxArray(employee).Text &= valueOfEmployees(employee, Day) & vbCrLf
                'bold the employee label according to the number of employee
                labelsEmployee(employee).Font = New Font(labelsEmployee(employee).Font, FontStyle.Bold)
                'increase day by 1
                Day += 1
                'clear the text box input every time the user wants to enter a value
                tbxInput.Clear()

                'if day is equal to the 7 day of the employee
                If Day = DaysInWeek Then

                    totalEmployeeShipment = 0

                    'loop to sum all the values of the employee
                    For dayCounter As Integer = 0 To DaysInWeek - 1
                        totalEmployeeShipment += valueOfEmployees(employee, dayCounter)
                    Next

                    'display the average value of the employee
                    AverageEmployeeWeekly = totalEmployeeShipment / DaysInWeek
                    outputLabelArray(employee).Text = "Average : " & Math.Round(AverageEmployeeWeekly, 2)

                    'reset day to 0
                    Day = 0
                    'increase the employee number
                    employee += 1

                End If

                'increase day by 1
                lblDayNumber.Text = "Day " & (Day + 1)

                'when employee number 3 done with the values entered, lets continue with overall average of all the employees
                If employee = NumberOfEmployees Then

                    totalOverallEmployeeShipment = 0
                    'for each loop to acces to all the values in the two dimensional array
                    For Each dailyValues In valueOfEmployees
                        totalOverallEmployeeShipment += dailyValues
                    Next

                    'calculate and display the overall average of all employees 
                    averageOverallEmployeeShipment = totalOverallEmployeeShipment / valueOfEmployees.Length
                    lblOverallAverage.Text = " Overall Average: " & Math.Round(averageOverallEmployeeShipment, 2)

                    'day is equal to done
                    lblDayNumber.Text = "Done"
                    'disable controls
                    BtnReset.Focus()
                    btnEnter.Enabled = False
                    tbxInput.Enabled = False



                End If


            Else
                'else display a error message if the value is not within the range
                MessageBox.Show("The value" & tbxInput.Text & "must bee between 0 and 5000 inclusive ")
                tbxInput.Clear()
                tbxInput.Focus()

            End If
        Else
            'if double is not the value expected display an error message 
            MessageBox.Show("Value " & tbxInput.Text & " must be a numeric value")
            tbxInput.Clear()
            tbxInput.Focus()

        End If


    End Sub
    ''' <summary>
    ''' This button close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    ''' <summary>
    ''' This event will reset the form, it will clean all labels and textboxes 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        'clear all the labels 
        ClearAllLabels(outputLabelArray)
        lblOverallAverage.Text = String.Empty

        'clear all the text boxes
        ClearTextBoxes(outputTextboxArray)
        tbxInput.Text = ""

        'set the variables to 0 and day to day 1
        Day = 0
        employee = 0
        lblDayNumber.Text = "Day 1"

        'clear labels fontstyle
        Clearlabels(labelsEmployee)

        'enable all the controls
        btnEnter.Enabled = True
        tbxInput.Enabled = True

        'focus the input to user be ready for insert values
        tbxInput.Focus()


    End Sub
    ''' <summary>
    ''' This event will clear all the bold labels after the user reset the form 
    ''' </summary>
    ''' <param name="labelStyle"></param>
    Sub Clearlabels(labelStyle As Label())
        For Each labelclear As Label In labelStyle
            labelclear.Font = New Font(labelclear.Font, FontStyle.Regular)
        Next
    End Sub
    ''' <summary>
    ''' This procedure will clear all the textboxes of the array 
    ''' </summary>
    ''' <param name="TexboxArray"></param>
    Sub ClearTextBoxes(TexboxArray As TextBox())
        For Each textBoxClear In TexboxArray
            textBoxClear.Text = String.Empty
        Next
    End Sub
    ''' <summary>
    ''' This procedure will clear all the label of my array 
    ''' </summary>
    ''' <param name="LabelsArray"></param>
    Sub ClearAllLabels(LabelsArray As Label())
        For Each labelArray In LabelsArray
            labelArray.Text = String.Empty
        Next
    End Sub

End Class
