Public Class bookInventoryObj


    Inherits Author
    'use the book author 





    Dim bookAuthors As String

    ' string variable to store the book title 
    Dim titleOfbookFromUser As String

    'get the book title 
    Public Property Title() As String
        Get
            Return titleOfbookFromUser
        End Get
        Set(value As String)
            titleOfbookFromUser = value
        End Set
    End Property

    'use enumeration for book covertypes 

    ' this is set to private because we don't want other parts of the program to interfere with enum setup.
    Private binding As bindingType

    Public Property coverType() As bindingType
        Get
            Return binding

        End Get
        Set(value As bindingType)
            binding = value
        End Set
    End Property


    Public Enum bindingType ' need to declare prior see console inheritance example for enumeration as well as how to do this.

        Paperback = 1

        hardcover = 2
    End Enum


    'get the book quantity 
    Dim OnHand As Integer
    Public Property Quantity() As Integer
        Get
            Return OnHand
        End Get

        Set(value As Integer)
            OnHand = value
        End Set
    End Property

    Public Sub New(firstname As String, lastname As String, Title As String, binding As bindingType, quantity As Integer)
        authorFirstName = firstname
        authorLastName = lastname
        titleOfbookFromUser = Title
        coverType = binding
        OnHand = quantity
    End Sub

    Public Overrides Function ToString() As String
        Return ("Author(s): " + authorFirstName + "  " + authorLastName + " Title: " + Title + " Cover type: " + coverType.ToString + " Quantity:" + Quantity.ToString)
    End Function

End Class
