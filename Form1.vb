﻿Public Class Form1

    ' book is a new book object to add to the list of books kept in inventory.  
    Dim book As bookInventoryObj
    'book inventory inherits authors
    Dim authors As Author
    'Public Sub New(firstname As String, lastname As String, Title As String, binding As bindingType, quantity As Integer)
    '    authorFirstName = firstname
    '    authorLastName = lastname
    '    titleOfbookFromUser = Title
    '    coverType = binding
    '    OnHand = quantity
    'End Sub

    '' this bookInventory will store the book objects as objects that have been created. 
    'this should allow to easily access it's properties to search by string for title or author. 
    Private bookInventory As List(Of bookInventoryObj) = New List(Of bookInventoryObj)



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' fill will test data on load.
        Dim testbook As New bookInventoryObj("RR", "Tolken", "LOTR", bookInventoryObj.bindingType.hardcover, 2)
        ListBox1.Items.Add(testbook)
        Dim testBook2 As New bookInventoryObj("Tony", "Robbins", "Awaken the Giant Within", bookInventoryObj.bindingType.Paperback, 1)
        ListBox1.Items.Add(testBook2)
        bookInventory.Add(testbook)
        bookInventory.Add(testBook2)

    End Sub


    ' add a book to the inventory. list 
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Try
            'use the bookinventory class to construct the book. keep in mind this inherits author 
            Dim auth As Author

            'TODO VALIDATION THAT THERE IS TEXT DATA IN ALL TEXT BOXES. FOR NOW ALL IS IN ONE TRY CATCH STATEMENT. 
            'VERIFY EACH TEXT BOX ENTRY TO LET USET KNOW WHAT INFORMATION IS MISISNG. 

            ' set author name equal to text box. 
            Dim firstname As String = authorFirstNametxtBox.Text
            Dim lastname As String = authorLastNametxtBox.Text


            ' use this function to get the binding type that uses enumeration
            getBindingType(paperType_CheckBox, hardcover_TypeCheckBox)
            MessageBox.Show("Here is the text in the book title textbox:" + bookTitletxtBox.Text)
            'get the title of the book 
            Dim titleOfBook As String = bookTitletxtBox.Text
            ' quantity is setup to me taken in as an integer. This will later be converted to a string.
            Dim quantity As Integer = CInt(quantityTxtBox.Text)
            ' next is constructing the book and adding it to the list with the to string override method. 
            Dim book As New bookInventoryObj(firstname, lastname, titleOfBook, getBindingType(paperType_CheckBox, hardcover_TypeCheckBox), quantity)
            'trying to add the new book object built to the list box. 
            ListBox1.Items.Add(book.ToString)

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
        Dim phrase As String = searchStringtxtBox.Text


        ''ahhhhhh need to get the selected item and compare the two and see if they are the same. 
        Try
            Dim selectedItem As Object = CType(ListBox1.SelectedItem, bookInventoryObj)

        For selectedItem in ArrayList 
                'get the quantity, and adjust it by one. 



                'todo figure out how to search through a list box and checks its contents. May need to search the array list instead. 
                '  For Each item As String In ListBox1

                '            If ListBox1.Contains() Then
                ' add that item to an array list 
                MessageBox.Show("here is what you were looking for:" + phrase)
                '    ListBox1.SelectedItem.ToString()
                'End If

                'For Each item In ListBox1
        Catch ex As Exception
            MessageBox.Show("Please select an item from the list box. Or problem getting listbox item. ")
        End Try
        'Next
    End Sub

    'use this function to check and see if the book inventory contains the user's search string 
    Private Function searchFunction() As bookInventoryObj





    End Function

    Private Sub authorFirstNametxtBox_Click(sender As Object, e As EventArgs) Handles authorFirstNametxtBox.Click
        authorFirstNametxtBox.Clear()

    End Sub

    Private Sub authorLastNametxtBox_Click(sender As Object, e As EventArgs) Handles authorLastNametxtBox.Click
        authorLastNametxtBox.Clear()
    End Sub
End Class
