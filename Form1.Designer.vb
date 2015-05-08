<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.authorFirstNametxtBox = New System.Windows.Forms.TextBox()
        Me.bookTitletxtBox = New System.Windows.Forms.TextBox()
        Me.paperType_CheckBox = New System.Windows.Forms.CheckBox()
        Me.hardcover_TypeCheckBox = New System.Windows.Forms.CheckBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.quantityTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.authorLastNametxtBox = New System.Windows.Forms.TextBox()
        Me.sellBookButton = New System.Windows.Forms.Button()
        Me.searchStringtxtBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Title"
        '
        'authorFirstNametxtBox
        '
        Me.authorFirstNametxtBox.Location = New System.Drawing.Point(66, 23)
        Me.authorFirstNametxtBox.Name = "authorFirstNametxtBox"
        Me.authorFirstNametxtBox.Size = New System.Drawing.Size(100, 20)
        Me.authorFirstNametxtBox.TabIndex = 2
        Me.authorFirstNametxtBox.Text = "First Name"
        '
        'bookTitletxtBox
        '
        Me.bookTitletxtBox.Location = New System.Drawing.Point(66, 87)
        Me.bookTitletxtBox.Name = "bookTitletxtBox"
        Me.bookTitletxtBox.Size = New System.Drawing.Size(100, 20)
        Me.bookTitletxtBox.TabIndex = 3
        '
        'paperType_CheckBox
        '
        Me.paperType_CheckBox.AutoSize = True
        Me.paperType_CheckBox.Location = New System.Drawing.Point(49, 129)
        Me.paperType_CheckBox.Name = "paperType_CheckBox"
        Me.paperType_CheckBox.Size = New System.Drawing.Size(78, 17)
        Me.paperType_CheckBox.TabIndex = 4
        Me.paperType_CheckBox.Text = "Paperback"
        Me.paperType_CheckBox.UseVisualStyleBackColor = True
        '
        'hardcover_TypeCheckBox
        '
        Me.hardcover_TypeCheckBox.AutoSize = True
        Me.hardcover_TypeCheckBox.Location = New System.Drawing.Point(153, 129)
        Me.hardcover_TypeCheckBox.Name = "hardcover_TypeCheckBox"
        Me.hardcover_TypeCheckBox.Size = New System.Drawing.Size(76, 17)
        Me.hardcover_TypeCheckBox.TabIndex = 5
        Me.hardcover_TypeCheckBox.Text = "Hardcover"
        Me.hardcover_TypeCheckBox.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(91, 208)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 6
        Me.addButton.Text = "Add "
        Me.addButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(258, 36)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(523, 173)
        Me.ListBox1.TabIndex = 7
        '
        'quantityTxtBox
        '
        Me.quantityTxtBox.Location = New System.Drawing.Point(97, 167)
        Me.quantityTxtBox.Name = "quantityTxtBox"
        Me.quantityTxtBox.Size = New System.Drawing.Size(37, 20)
        Me.quantityTxtBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantity"
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(238, 257)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(56, 23)
        Me.searchButton.TabIndex = 10
        Me.searchButton.Text = "Search For book "
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'authorLastNametxtBox
        '
        Me.authorLastNametxtBox.Location = New System.Drawing.Point(66, 49)
        Me.authorLastNametxtBox.Name = "authorLastNametxtBox"
        Me.authorLastNametxtBox.Size = New System.Drawing.Size(100, 20)
        Me.authorLastNametxtBox.TabIndex = 11
        Me.authorLastNametxtBox.Text = "Last Name"
        '
        'sellBookButton
        '
        Me.sellBookButton.Location = New System.Drawing.Point(91, 247)
        Me.sellBookButton.Name = "sellBookButton"
        Me.sellBookButton.Size = New System.Drawing.Size(75, 23)
        Me.sellBookButton.TabIndex = 12
        Me.sellBookButton.Text = "Sell book"
        Me.sellBookButton.UseVisualStyleBackColor = True
        '
        'searchStringtxtBox
        '
        Me.searchStringtxtBox.Location = New System.Drawing.Point(319, 260)
        Me.searchStringtxtBox.Name = "searchStringtxtBox"
        Me.searchStringtxtBox.Size = New System.Drawing.Size(143, 20)
        Me.searchStringtxtBox.TabIndex = 13
        Me.searchStringtxtBox.Text = "Author Or Title Search"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 292)
        Me.Controls.Add(Me.searchStringtxtBox)
        Me.Controls.Add(Me.sellBookButton)
        Me.Controls.Add(Me.authorLastNametxtBox)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.quantityTxtBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.hardcover_TypeCheckBox)
        Me.Controls.Add(Me.paperType_CheckBox)
        Me.Controls.Add(Me.bookTitletxtBox)
        Me.Controls.Add(Me.authorFirstNametxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents authorFirstNametxtBox As System.Windows.Forms.TextBox
    Friend WithEvents bookTitletxtBox As System.Windows.Forms.TextBox
    Friend WithEvents paperType_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents hardcover_TypeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents quantityTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents authorLastNametxtBox As System.Windows.Forms.TextBox
    Friend WithEvents sellBookButton As System.Windows.Forms.Button
    Friend WithEvents searchStringtxtBox As System.Windows.Forms.TextBox

End Class
