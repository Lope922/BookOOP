Public Class Author
    ' every author needs to have a first name and a last name. Using this instance if they 
    'if there is more than one author they can enter the one author in author first name and 2nd author in last name.
    Private firstname As String
    Private lastname As String

    ' trying this out to initialize the author as a new author with a firstname and lastname  put together from to different variables 
    Dim bookAuthor As String

    Property authorFirstName() As String
        Get
            Return firstname
        End Get
        Set(value As String)
            firstname = value
        End Set
    End Property

    Property authorLastName() As String
        Get
            Return lastname
        End Get
        Set(value As String)
            lastname = value
        End Set
    End Property

    'Private Sub New(firstname As String, lastname As String)

    'End Sub
    
End Class
