Public Class Form1

    ' book is a new book object to add to the list of books kept in inventory.  
    Dim book As bookInventoryObj
    'book inventory inherits authors
    Dim authors As Author
    
    '' this bookInventory will store the book objects as objects that have been created. 
    'this should allow to easily access it's properties to search by string for title or author. 
    Private bookInventory As List(Of bookInventoryObj) = New List(Of bookInventoryObj)



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' fill will test data on load.
        Dim testbook As New bookInventoryObj("RR", "Tolken", "LOTR", bookInventoryObj.bindingType.hardcover, 2)
        ListBox1.Items.Add(testbook)
        Dim testBook2 As New bookInventoryObj("Tony", "Robbins", "Awaken the Giant Within", bookInventoryObj.bindingType.Paperback, 1)
        ListBox1.Items.Add(testBook2)

        ' also add it to the newly created inventory list of objects. 
        bookInventory.Add(testbook)
        bookInventory.Add(testBook2)

    End Sub


    ' add a book to the inventory. list 
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Try
            'use the bookinventory class to construct the book. keep in mind this inherits author 
            Dim auth As New Author

            'TODO VALIDATION THAT THERE IS TEXT DATA IN ALL TEXT BOXES. FOR NOW ALL IS IN ONE TRY CATCH STATEMENT. 
            'VERIFY EACH TEXT BOX ENTRY TO LET USET KNOW WHAT INFORMATION IS MISISNG. 
            auth.authorFirstName = authorFirstNametxtBox.Text
            auth.authorLastName = authorLastNametxtBox.Text
            ' set author name equal to text box. 
            'Dim firstname As String = authorFirstNametxtBox.Text
            'Dim lastname As String = authorLastNametxtBox.Text


            ' use this function to get the binding type that uses enumeration
            getBindingType(paperType_CheckBox, hardcover_TypeCheckBox)
            MessageBox.Show("Here is the text in the book title textbox:" + bookTitletxtBox.Text)
            'get the title of the book 
            Dim titleOfBook As String = bookTitletxtBox.Text
            ' quantity is setup to me taken in as an integer. This will later be converted to a string.
            Dim quantity As Integer = CInt(quantityTxtBox.Text)
            ' next is constructing the book and adding it to the list with the to string override method. 
            Dim book As New bookInventoryObj(auth.authorFirstName, auth.authorLastName, titleOfBook, getBindingType(paperType_CheckBox, hardcover_TypeCheckBox), quantity)

            'trying to add the new book object built to the list box. 
            ListBox1.Items.Add(book.ToString)

            'also the inventory 
            bookInventory.Add(book)

            ' basic error message. TODO WRITE A FUNCTION TO THECK EACH TEXT BOX FOR SPECIFIC RESONPSES. tHEN ALLOW THIS CATCH BLOCK FOR ANY OTHER UNKONW ERRORS. 
        Catch _missingInfo As Exception
            MessageBox.Show("Please make sure you have entered all author data", "Missing User input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    ' need to pass checkboxes in in proper order paperback checkbox first
    Public Function getBindingType(checkbox As CheckBox, checkbox2 As CheckBox) As bookInventoryObj.bindingType
        Try
            If checkbox.Checked = True Then
                Return bookInventoryObj.bindingType.Paperback
            ElseIf checkbox2.Checked = True Then
                Return bookInventoryObj.bindingType.hardcover
            End If

            ' if not checkbox is selected it will throw a null reference exception. Catch it here. 
        Catch noboxChecked As Exception
            MessageBox.Show("Please select a binding type. " + vbNewLine + "Paperback or Hardcover")
        End Try
    End Function

    ' work on this later. 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        

        ''ahhhhhh need to get the selected item and compare the two and see if they are the same. 
        Try
            Dim phrase As String = searchStringtxtBox.Text

            'Dim selectedItem As Object = CType(ListBox1.SelectedItem, bookInventoryObj)
            For Each obj As Object In bookInventory


                If obj.ToString.Contains(phrase) Then
                    MessageBox.Show("yes!, " + obj.ToString + "is in the inventory ")
                Else
                    MessageBox.Show("No" + phrase + "is not in the inventory")
                End If

                'get the quantity, and adjust it by one. 

            Next

            'todo figure out how to search through a list box and checks its contents. May need to search the array list instead. 
            '  For Each item As String In ListBox1

            '            If ListBox1.Contains() Then
            ' add that item to an array list 
            MessageBox.Show("here is what you were looking for:" + phrase)


        Catch ex As Exception
            ' not sure what other exceptions may be throw here 
            MessageBox.Show("unknown Error : " + ex.Message)
        End Try
        'Next
    End Sub

    'use this function to check and see if the book inventory contains the user's search string 
    'Private Function searchFunction() As bookInventoryObj





    'End Function

    Private Sub authorFirstNametxtBox_Click(sender As Object, e As EventArgs) Handles authorFirstNametxtBox.Click
        authorFirstNametxtBox.Clear()

    End Sub

    Private Sub authorLastNametxtBox_Click(sender As Object, e As EventArgs) Handles authorLastNametxtBox.Click
        authorLastNametxtBox.Clear()
    End Sub

    Private Sub sellBookButton_Click(sender As Object, e As EventArgs) Handles sellBookButton.Click
        Try
            ' this selected index will tell us if there is a valid selection. 
            Dim selectedobj As bookInventoryObj = CType(ListBox1.SelectedItem, bookInventoryObj)
            Dim selectedIndex As Integer = ListBox1.SelectedIndex



            If selectedIndex = -1 Then
                MessageBox.Show("Please select an item from the list box")
            Else : adjustQuantity(selectedobj, bookInventory)
            End If

        Catch ex As InvalidCastException
            MessageBox.Show("Error Message: Unknown error 1:" + ex.Message, "Error : 1", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub searchStringtxtBox_Click(sender As Object, e As EventArgs) Handles searchStringtxtBox.Click
        searchStringtxtBox.Clear()
    End Sub

    ' in order to adjust the quantity i will need to pass the list of bookObjects into this sub method to try and access the quantity to be able to adjust it. 
    Private Sub adjustQuantity(selectedObject As bookInventoryObj, listofInventory As List(Of bookInventoryObj))
        'get the book quantity, and remove one book, 
        Dim quantity As Integer
        'For Each obj As bookInventoryObj In bookInventory
        quantity = selectedObject.Quantity
        MessageBox.Show("Here is the quantity property" + quantity.ToString)
        'Next

        ' now that i have gotten the quantity property i need to check to see if it is 1. 
        Try
            If quantity = 0 Then
                ListBox1.Items.Remove(selectedObject)
            Else
                quantity = quantity - 1
            End If
            ' this adjusts the quantity but not the list of the inventory. ??? GOT THIS FAR BUT MOVING ONTO FINAL PROJECT. 
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ' If the quantity is 1 remove the object from the inventory as well as the arraylist. 




    End Sub

End Class
