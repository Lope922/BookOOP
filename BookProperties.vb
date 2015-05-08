Public Class BookProperties

    ' this is junk now 


    '' represents a particular title stocked in a bookstore. 
    '' this object stores an author, title, binding (type hardcover
    '' or paperback) , price, quantity) 

    '' will need to experiment with hashtables in the console or something to see how i can manipulate the inventory keys and values key = book title , quantity = value
    '   Public bookstoreInverntory As Hashtable    '' will need to be able to modify certain book properties. 

    '   Dim firstname As String

    '   Dim lastName As String

    '   'Public Author As String

    '   '' author should be a first name and last name value that utilizes structure 

    '   '' see coffee shop program.  


    '   Public Property createBookAuthor(firstname As String, lastname As String) As String
    '       Get

    '           Return firstname + lastname
    '       End Get
    '       Set(value As String)
    '           value = firstname + "" + lastname
    '       End Set
    '   End Property

    '   Public title As String

    '   Public Property createBookTitle() As String
    '       Get
    '           Return title
    '       End Get
    '       Set(value As String)
    '           value = title
    '       End Set
    '   End Property

    '   Public coverType As String
    '   Public Property createCoverType() As String
    '       Get
    '           Return coverType
    '       End Get
    '       Set(value As String)
    '           value = coverType
    '       End Set
    '   End Property

    '   Public quantity As Integer

    '   Public Property generateInstanceOfQuantity() As Integer
    '       Get
    '           Return quantity
    '       End Get
    '       Set(value As Integer)
    '           value = quantity
    '       End Set
    '   End Property
    '   Sub New(Author As String, title As String, coverType As String, quantity As Integer)
    '       'Dim bookObjBuilt As New BookProperties
    '   End Sub

    'Public Function(Author As String, title As String, coverType As String, quantity As Integer) As String bookconstructor

    '       ' New book info assembler. 
    '       Dim bookStringForListBox As String
    '       bookStringForListBox = ("Author: " + Author + " Book title: " + title + " Cover type: " + coverType + " Quantity: " + quantity.ToString)
    '       Return bookStringForListBox
    '   End Function

    '   Public Function bookconstructor(author As String, title As String, coverType As String) As String

    '       ' New book info assembler. 
    '       Dim bookStringForListBox As String
    '       bookStringForListBox = ("Author: " + createBookAuthor(firstname, lastName) + " Book title: " + createBookTitle() + " Cover type: " + createCoverType())
    '       Return bookStringForListBox
    '   End Function


    '   '' todo create a sub method here to check the status of the checkboxes and return value using true or false statements. Maybe tied into enumertion ? to experiment with enumeration. 
    '   Public Sub getCoverType(hardcover As ComboBox, paperback As ComboBox)
    '       ' check both checkboxes and see which check box is checked. 
    '       ' If hardcover.checked
    '       '    then Then
    '       'End If

    '   End Sub
End Class
