Option Strict On
''' <summary>
''' Original Author:    Fabian Narvaez
''' Original Date:      March 15, 2020
''' Last Modified By:   Fabian Narvaez
''' Last Modified Date: March 15, 2020
''' Project Name:       Car Class
''' Description:
'''     In this file I will create a class for my Lab 4 Car invetory. I will declare all the attributes and functions to instantiate 
'''     the objects create from the user.
'''     </summary>
Public Class Car
#Region "Variables Declarations"

    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carIsNew As Boolean = False


#End Region
#Region "constructors"
    ''' <summary>
    ''' default constructor just increments the car count
    ''' </summary>
    Friend Sub New()
        carCount += 1
        carIdentificationNumber = carCount
    End Sub
    ''' <summary>
    '''  parametrized constructor: sets all private variables based on arguments passed in
    ''' </summary>
    ''' <param name="makeValue"> a car's manufactureres</param>
    ''' <param name="modelValue"> a car's model</param>
    ''' <param name="yearValue"> a car's year of manufacture</param>
    ''' <param name="priceValue"> </param>
    ''' <param name="newValue"></param>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, newValue As Boolean)
        Me.New()
        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carIsNew = newValue

    End Sub
#End Region
#Region "Property Procedures"

    ''' <summary>
    ''' return the number of car objects
    ''' </summary>
    ''' <returns>the number of cars objects</returns>
    Private ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property
    ''' <summary>
    ''' returns a car's unique identificacion number
    ''' </summary>
    ''' <returns> integer specifying this car </returns>
    Public ReadOnly Property Id() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property IsNew() As Boolean
        Get
            Return carIsNew
        End Get
        Set(value As Boolean)
            carIsNew = value
        End Set
    End Property
#End Region
#Region "Methods"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCarData() As String
        If carIsNew = True Then
            Return "New " & carYear & " " & carMake & " " & carModel & " " & "for " & carPrice.ToString("c")
        Else
            Return "Used " & carYear & " " & carMake & " " & carModel & " " & "for " & carPrice.ToString("c")
        End If
    End Function
#End Region
End Class
