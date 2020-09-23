
Option Strict On
''' <summary>
''' Original Author:    Fabian Narvaez
''' Original Date:      March 15, 2020
''' Last Modified By:   Fabian Narvaez
''' Last Modified Date: March 15, 2020
''' Project Name:       Car Inventory Lab 4
''' Description:
'''     Application to keep a list of cars and display them with their respective characteristics, I will include the make, model
'''     year and price. i will also ask the user if the car is either new or not. I will make the respective validation 
'''     </summary>

Public Class frmCarInventory

#Region "Declarations"
    'declarations
    Dim isCarSelected As Boolean = False
    Dim selectedCar As Car                    'class car object
    Dim carList As New List(Of Car)
    Dim isAddingToListView As Boolean = False


#End Region
    ''' <summary>
    ''' btn Enter click -will validate the data entered into the controls is appropiate
    '''                 -if the validation is passed a car object will be created using the parameterized constructor
    '''                 -it will also show the object created in the car list collection. 
    '''                 -it will also check if the data is selected from the list car collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'check input validation 
        If IsValidInput() = True Then
            ' friendly message indicating that the value was succesfuly entered
            lblOutput.Text = "succesfull entry"

            If Not isCarSelected Then

                'create a new Car and add it to the list
                selectedCar = New Car(cmbMakes.Text, tbModel.Text, CInt(cmbYear.Text), CDec(tbPrice.Text), chBoxNew.Checked)
                carList.Add(selectedCar)

                ' Else if current Car exists, I will be editing 
            ElseIf selectedCar.Id.ToString.Trim.Length > 0 Then

                ' Update the existing car according on the entered values
                selectedCar.Make = cmbMakes.Text
                selectedCar.Model = tbModel.Text
                selectedCar.Year = CInt(cmbYear.Text)
                selectedCar.Price = CDec(tbPrice.Text)
                selectedCar.IsNew = chBoxNew.Checked

            End If


        End If
        PopulateList()



    End Sub
    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()
        'clear all the comboxes and textboxes
        cmbMakes.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        tbModel.Text = String.Empty
        tbPrice.Text = String.Empty
        chBoxNew.Checked = False
        lblOutput.Text = String.Empty
        'populate the list
        PopulateList()

        'the user is not selecting any car from the listview
        isCarSelected = False

        'focus in the first text box
        tbModel.Focus()

    End Sub
    ''' <summary>
    ''' IsValidInput will indicate if whether the values entered are the correct ones or not 
    ''' </summary>
    ''' <returns></returns>
    Private Function IsValidInput() As Boolean
        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty
        Dim price As Decimal = 0.0D

        'check if the make has been selected
        If cmbMakes.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's make." & vbCrLf

            'return value to false
            returnValue = False

        End If

        'check if the year has been selected
        If cmbYear.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's year." & vbCrLf

            'return value to false
            returnValue = False

        End If

        'check if the model has been entered
        If tbModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's model." & vbCrLf

            ' And, set the return value to false
            returnValue = False
        End If

        'check if the price is a number value
        If Not (Decimal.TryParse(tbPrice.Text, price) And price > 0) Then

            ' If not number value o less than 0
            outputMessage += "You must enter a number greater than 0" & vbCrLf
            ' And, set the return value to false
            returnValue = False
        End If

        'check if the price is entered
        If tbPrice.Text.Trim.Length = 0 Then

            outputMessage += "Please enter the car's price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        If returnValue = False Then
            lblOutput.Text = "ERRORS" & vbCrLf & outputMessage
        End If
        'return the boolean value 
        'true is it passed validation or false if it did not

        Return returnValue

    End Function
    ''' <summary>
    ''' this will clear the form 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub
    ''' <summary>
    ''' This event will close my application 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' This will stop the user of checking a box 
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' </summary>
    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        'if we are not adding cars to the list
        If Not isAddingToListView Then

            'keep the old value
            e.NewValue = e.CurrentValue

        End If

    End Sub
    ''' <summary>
    '''Event handler for the event that a character is selected in the ListView
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' </summary>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged

        If lvwCars.SelectedIndices.Count = 1 Then
            selectedCar = carList(lvwCars.SelectedIndices(0))
            isCarSelected = True

            cmbMakes.Text = selectedCar.Make
            tbModel.Text = selectedCar.Model
            cmbYear.Text = selectedCar.Year.ToString
            tbPrice.Text = selectedCar.Price.ToString
            chBoxNew.Checked = selectedCar.IsNew

            lblOutput.Text = selectedCar.GetCarData()

        Else
            isCarSelected = False

        End If

    End Sub
    ''' <summary>
    ''' This populates and clears the list of my form 
    ''' </summary>
    Sub PopulateList()

        lvwCars.Items.Clear()

        For index As Integer = 0 To carList.Count - 1

            'instatiatea new ListViewItems
            Dim carItem As New ListViewItem()

            'assign the values to the checked control, the same for subitems
            carItem.SubItems.Add(carList(index).Id.ToString)
            carItem.SubItems.Add(carList(index).Make)
            carItem.SubItems.Add(carList(index).Model)
            carItem.SubItems.Add(carList(index).Year.ToString)
            carItem.SubItems.Add(carList(index).Price.ToString & " $")
            carItem.Checked = carList(index).IsNew


            'I will indicate that I am adding cars to the list
            isAddingToListView = True

            'add the new instantiate and populate to my list created
            lvwCars.Items.Add(carItem)

            'i done adding list cars to the list view
            isAddingToListView = False

        Next


    End Sub


End Class
