<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class book
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
        Dim Book_noLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim PagesLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim EdisionLabel As System.Windows.Forms.Label
        Dim Class_noLabel As System.Windows.Forms.Label
        Dim Pub_idLabel As System.Windows.Forms.Label
        Dim Date_publishedLabel As System.Windows.Forms.Label
        Dim Aut_idLabel As System.Windows.Forms.Label
        Dim B_nameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(book))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LibraryDataSet = New WindowsApplication1.LibraryDataSet()
        Me.BOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKTableAdapter = New WindowsApplication1.LibraryDataSetTableAdapters.BOOKTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.BOOKBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BOOKBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Book_noTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PagesTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.EdisionTextBox = New System.Windows.Forms.TextBox()
        Me.Class_noTextBox = New System.Windows.Forms.TextBox()
        Me.Pub_idTextBox = New System.Windows.Forms.TextBox()
        Me.Date_publishedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Aut_idTextBox = New System.Windows.Forms.TextBox()
        Me.B_nameTextBox = New System.Windows.Forms.TextBox()
        Me.BOOKDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Book_noLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        PagesLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        EdisionLabel = New System.Windows.Forms.Label()
        Class_noLabel = New System.Windows.Forms.Label()
        Pub_idLabel = New System.Windows.Forms.Label()
        Date_publishedLabel = New System.Windows.Forms.Label()
        Aut_idLabel = New System.Windows.Forms.Label()
        B_nameLabel = New System.Windows.Forms.Label()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BOOKBindingNavigator.SuspendLayout()
        CType(Me.BOOKDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Book_noLabel
        '
        Book_noLabel.AutoSize = True
        Book_noLabel.Location = New System.Drawing.Point(226, 180)
        Book_noLabel.Name = "Book_noLabel"
        Book_noLabel.Size = New System.Drawing.Size(49, 13)
        Book_noLabel.TabIndex = 5
        Book_noLabel.Text = "book no:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(226, 229)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(31, 13)
        DateLabel.TabIndex = 6
        DateLabel.Text = "date:"
        '
        'PagesLabel
        '
        PagesLabel.AutoSize = True
        PagesLabel.Location = New System.Drawing.Point(226, 255)
        PagesLabel.Name = "PagesLabel"
        PagesLabel.Size = New System.Drawing.Size(39, 13)
        PagesLabel.TabIndex = 7
        PagesLabel.Text = "pages:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(226, 284)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(33, 13)
        PriceLabel.TabIndex = 9
        PriceLabel.Text = "price:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(226, 310)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 11
        ISBNLabel.Text = "ISBN:"
        '
        'EdisionLabel
        '
        EdisionLabel.AutoSize = True
        EdisionLabel.Location = New System.Drawing.Point(226, 333)
        EdisionLabel.Name = "EdisionLabel"
        EdisionLabel.Size = New System.Drawing.Size(43, 13)
        EdisionLabel.TabIndex = 13
        EdisionLabel.Text = "edision:"
        '
        'Class_noLabel
        '
        Class_noLabel.AutoSize = True
        Class_noLabel.Location = New System.Drawing.Point(226, 359)
        Class_noLabel.Name = "Class_noLabel"
        Class_noLabel.Size = New System.Drawing.Size(49, 13)
        Class_noLabel.TabIndex = 15
        Class_noLabel.Text = "class no:"
        '
        'Pub_idLabel
        '
        Pub_idLabel.AutoSize = True
        Pub_idLabel.Location = New System.Drawing.Point(226, 385)
        Pub_idLabel.Name = "Pub_idLabel"
        Pub_idLabel.Size = New System.Drawing.Size(39, 13)
        Pub_idLabel.TabIndex = 17
        Pub_idLabel.Text = "pub id:"
        '
        'Date_publishedLabel
        '
        Date_publishedLabel.AutoSize = True
        Date_publishedLabel.Location = New System.Drawing.Point(226, 411)
        Date_publishedLabel.Name = "Date_publishedLabel"
        Date_publishedLabel.Size = New System.Drawing.Size(79, 13)
        Date_publishedLabel.TabIndex = 19
        Date_publishedLabel.Text = "date published:"
        '
        'Aut_idLabel
        '
        Aut_idLabel.AutoSize = True
        Aut_idLabel.Location = New System.Drawing.Point(226, 437)
        Aut_idLabel.Name = "Aut_idLabel"
        Aut_idLabel.Size = New System.Drawing.Size(37, 13)
        Aut_idLabel.TabIndex = 21
        Aut_idLabel.Text = "Aut id:"
        '
        'B_nameLabel
        '
        B_nameLabel.AutoSize = True
        B_nameLabel.Location = New System.Drawing.Point(226, 203)
        B_nameLabel.Name = "B_nameLabel"
        B_nameLabel.Size = New System.Drawing.Size(45, 13)
        B_nameLabel.TabIndex = 23
        B_nameLabel.Text = "b name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(28, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(845, 79)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "School Library Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Add New Book"
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKBindingSource
        '
        Me.BOOKBindingSource.DataMember = "BOOK"
        Me.BOOKBindingSource.DataSource = Me.LibraryDataSet
        '
        'BOOKTableAdapter
        '
        Me.BOOKTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuthorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKTableAdapter = Me.BOOKTableAdapter
        Me.TableAdapterManager.BORROWTableAdapter = Nothing
        Me.TableAdapterManager.MEMBERTableAdapter = Nothing
        Me.TableAdapterManager.MEMEMAILTableAdapter = Nothing
        Me.TableAdapterManager.MEMTELETableAdapter = Nothing
        Me.TableAdapterManager.PUBLISHERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BOOKBindingNavigator
        '
        Me.BOOKBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BOOKBindingNavigator.BindingSource = Me.BOOKBindingSource
        Me.BOOKBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BOOKBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BOOKBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BOOKBindingNavigatorSaveItem})
        Me.BOOKBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BOOKBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BOOKBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BOOKBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BOOKBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BOOKBindingNavigator.Name = "BOOKBindingNavigator"
        Me.BOOKBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BOOKBindingNavigator.Size = New System.Drawing.Size(1147, 25)
        Me.BOOKBindingNavigator.TabIndex = 5
        Me.BOOKBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BOOKBindingNavigatorSaveItem
        '
        Me.BOOKBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BOOKBindingNavigatorSaveItem.Image = CType(resources.GetObject("BOOKBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BOOKBindingNavigatorSaveItem.Name = "BOOKBindingNavigatorSaveItem"
        Me.BOOKBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BOOKBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Book_noTextBox
        '
        Me.Book_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "book_no", True))
        Me.Book_noTextBox.Location = New System.Drawing.Point(459, 177)
        Me.Book_noTextBox.MaxLength = 4
        Me.Book_noTextBox.Name = "Book_noTextBox"
        Me.Book_noTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Book_noTextBox.TabIndex = 6
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BOOKBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(459, 229)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(281, 20)
        Me.DateDateTimePicker.TabIndex = 7
        '
        'PagesTextBox
        '
        Me.PagesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "pages", True))
        Me.PagesTextBox.Location = New System.Drawing.Point(459, 255)
        Me.PagesTextBox.MaxLength = 2000
        Me.PagesTextBox.Name = "PagesTextBox"
        Me.PagesTextBox.Size = New System.Drawing.Size(281, 20)
        Me.PagesTextBox.TabIndex = 8
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(459, 281)
        Me.PriceTextBox.MaxLength = 1000
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(281, 20)
        Me.PriceTextBox.TabIndex = 10
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(459, 307)
        Me.ISBNTextBox.MaxLength = 20
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(281, 20)
        Me.ISBNTextBox.TabIndex = 12
        '
        'EdisionTextBox
        '
        Me.EdisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "edision", True))
        Me.EdisionTextBox.Location = New System.Drawing.Point(459, 333)
        Me.EdisionTextBox.MaxLength = 4
        Me.EdisionTextBox.Name = "EdisionTextBox"
        Me.EdisionTextBox.Size = New System.Drawing.Size(281, 20)
        Me.EdisionTextBox.TabIndex = 14
        '
        'Class_noTextBox
        '
        Me.Class_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "class_no", True))
        Me.Class_noTextBox.Location = New System.Drawing.Point(459, 359)
        Me.Class_noTextBox.MaxLength = 100
        Me.Class_noTextBox.Name = "Class_noTextBox"
        Me.Class_noTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Class_noTextBox.TabIndex = 16
        '
        'Pub_idTextBox
        '
        Me.Pub_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "pub_id", True))
        Me.Pub_idTextBox.Location = New System.Drawing.Point(459, 385)
        Me.Pub_idTextBox.MaxLength = 4
        Me.Pub_idTextBox.Name = "Pub_idTextBox"
        Me.Pub_idTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Pub_idTextBox.TabIndex = 18
        '
        'Date_publishedDateTimePicker
        '
        Me.Date_publishedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BOOKBindingSource, "date_published", True))
        Me.Date_publishedDateTimePicker.Location = New System.Drawing.Point(459, 411)
        Me.Date_publishedDateTimePicker.Name = "Date_publishedDateTimePicker"
        Me.Date_publishedDateTimePicker.Size = New System.Drawing.Size(281, 20)
        Me.Date_publishedDateTimePicker.TabIndex = 20
        '
        'Aut_idTextBox
        '
        Me.Aut_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "Aut_id", True))
        Me.Aut_idTextBox.Location = New System.Drawing.Point(459, 437)
        Me.Aut_idTextBox.MaxLength = 4
        Me.Aut_idTextBox.Name = "Aut_idTextBox"
        Me.Aut_idTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Aut_idTextBox.TabIndex = 22
        '
        'B_nameTextBox
        '
        Me.B_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "b_name", True))
        Me.B_nameTextBox.Location = New System.Drawing.Point(459, 203)
        Me.B_nameTextBox.MaxLength = 100
        Me.B_nameTextBox.Name = "B_nameTextBox"
        Me.B_nameTextBox.Size = New System.Drawing.Size(281, 20)
        Me.B_nameTextBox.TabIndex = 24
        '
        'BOOKDataGridView
        '
        Me.BOOKDataGridView.AutoGenerateColumns = False
        Me.BOOKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BOOKDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.BOOKDataGridView.DataSource = Me.BOOKBindingSource
        Me.BOOKDataGridView.Location = New System.Drawing.Point(746, 177)
        Me.BOOKDataGridView.Name = "BOOKDataGridView"
        Me.BOOKDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.BOOKDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "book_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "book_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "pages"
        Me.DataGridViewTextBoxColumn3.HeaderText = "pages"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ISBN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "edision"
        Me.DataGridViewTextBoxColumn6.HeaderText = "edision"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "class_no"
        Me.DataGridViewTextBoxColumn7.HeaderText = "class_no"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "pub_id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "pub_id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "date_published"
        Me.DataGridViewTextBoxColumn9.HeaderText = "date_published"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Aut_id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Aut_id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "b_name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "b_name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C__Data_Users_DefApps_AppData_INTERNETEXPLORER_Temp_Saved_Images_Library1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1147, 631)
        Me.Controls.Add(Me.BOOKDataGridView)
        Me.Controls.Add(B_nameLabel)
        Me.Controls.Add(Me.B_nameTextBox)
        Me.Controls.Add(Aut_idLabel)
        Me.Controls.Add(Me.Aut_idTextBox)
        Me.Controls.Add(Date_publishedLabel)
        Me.Controls.Add(Me.Date_publishedDateTimePicker)
        Me.Controls.Add(Pub_idLabel)
        Me.Controls.Add(Me.Pub_idTextBox)
        Me.Controls.Add(Class_noLabel)
        Me.Controls.Add(Me.Class_noTextBox)
        Me.Controls.Add(EdisionLabel)
        Me.Controls.Add(Me.EdisionTextBox)
        Me.Controls.Add(ISBNLabel)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(PagesLabel)
        Me.Controls.Add(Me.PagesTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Book_noLabel)
        Me.Controls.Add(Me.Book_noTextBox)
        Me.Controls.Add(Me.BOOKBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BOOKBindingNavigator.ResumeLayout(False)
        Me.BOOKBindingNavigator.PerformLayout()
        CType(Me.BOOKDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibraryDataSet As WindowsApplication1.LibraryDataSet
    Friend WithEvents BOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKTableAdapter As WindowsApplication1.LibraryDataSetTableAdapters.BOOKTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BOOKBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BOOKBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Book_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PagesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EdisionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Class_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pub_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_publishedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Aut_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BOOKDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
