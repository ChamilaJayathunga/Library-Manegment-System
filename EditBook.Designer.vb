<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBook
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
        Dim B_nameLabel As System.Windows.Forms.Label
        Dim Aut_idLabel As System.Windows.Forms.Label
        Dim Pub_idLabel As System.Windows.Forms.Label
        Dim Date_publishedLabel As System.Windows.Forms.Label
        Dim Class_noLabel As System.Windows.Forms.Label
        Dim EdisionLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim PagesLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditBook))
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet = New WindowsApplication1.LibraryDataSet()
        Me.B_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Aut_idTextBox = New System.Windows.Forms.TextBox()
        Me.Date_publishedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Pub_idTextBox = New System.Windows.Forms.TextBox()
        Me.Class_noTextBox = New System.Windows.Forms.TextBox()
        Me.EdisionTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.PagesTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Book_noTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BOOKTableAdapter = New WindowsApplication1.LibraryDataSetTableAdapters.BOOKTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.BOOKBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BOOKBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Book_noLabel = New System.Windows.Forms.Label()
        B_nameLabel = New System.Windows.Forms.Label()
        Aut_idLabel = New System.Windows.Forms.Label()
        Pub_idLabel = New System.Windows.Forms.Label()
        Date_publishedLabel = New System.Windows.Forms.Label()
        Class_noLabel = New System.Windows.Forms.Label()
        EdisionLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        PagesLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.BOOKDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BOOKBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Book_noLabel
        '
        Book_noLabel.AutoSize = True
        Book_noLabel.Location = New System.Drawing.Point(309, 209)
        Book_noLabel.Name = "Book_noLabel"
        Book_noLabel.Size = New System.Drawing.Size(49, 13)
        Book_noLabel.TabIndex = 28
        Book_noLabel.Text = "book no:"
        '
        'B_nameLabel
        '
        B_nameLabel.AutoSize = True
        B_nameLabel.Location = New System.Drawing.Point(309, 232)
        B_nameLabel.Name = "B_nameLabel"
        B_nameLabel.Size = New System.Drawing.Size(45, 13)
        B_nameLabel.TabIndex = 49
        B_nameLabel.Text = "b name:"
        '
        'Aut_idLabel
        '
        Aut_idLabel.AutoSize = True
        Aut_idLabel.Location = New System.Drawing.Point(309, 466)
        Aut_idLabel.Name = "Aut_idLabel"
        Aut_idLabel.Size = New System.Drawing.Size(37, 13)
        Aut_idLabel.TabIndex = 47
        Aut_idLabel.Text = "Aut id:"
        '
        'Pub_idLabel
        '
        Pub_idLabel.AutoSize = True
        Pub_idLabel.Location = New System.Drawing.Point(309, 414)
        Pub_idLabel.Name = "Pub_idLabel"
        Pub_idLabel.Size = New System.Drawing.Size(39, 13)
        Pub_idLabel.TabIndex = 43
        Pub_idLabel.Text = "pub id:"
        '
        'Date_publishedLabel
        '
        Date_publishedLabel.AutoSize = True
        Date_publishedLabel.Location = New System.Drawing.Point(309, 440)
        Date_publishedLabel.Name = "Date_publishedLabel"
        Date_publishedLabel.Size = New System.Drawing.Size(79, 13)
        Date_publishedLabel.TabIndex = 45
        Date_publishedLabel.Text = "date published:"
        '
        'Class_noLabel
        '
        Class_noLabel.AutoSize = True
        Class_noLabel.Location = New System.Drawing.Point(309, 388)
        Class_noLabel.Name = "Class_noLabel"
        Class_noLabel.Size = New System.Drawing.Size(49, 13)
        Class_noLabel.TabIndex = 41
        Class_noLabel.Text = "class no:"
        '
        'EdisionLabel
        '
        EdisionLabel.AutoSize = True
        EdisionLabel.Location = New System.Drawing.Point(309, 362)
        EdisionLabel.Name = "EdisionLabel"
        EdisionLabel.Size = New System.Drawing.Size(43, 13)
        EdisionLabel.TabIndex = 39
        EdisionLabel.Text = "edision:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(309, 339)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 37
        ISBNLabel.Text = "ISBN:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(309, 313)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(33, 13)
        PriceLabel.TabIndex = 35
        PriceLabel.Text = "price:"
        '
        'PagesLabel
        '
        PagesLabel.AutoSize = True
        PagesLabel.Location = New System.Drawing.Point(309, 284)
        PagesLabel.Name = "PagesLabel"
        PagesLabel.Size = New System.Drawing.Size(39, 13)
        PagesLabel.TabIndex = 32
        PagesLabel.Text = "pages:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(309, 258)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(31, 13)
        DateLabel.TabIndex = 30
        DateLabel.Text = "date:"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "book_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "book_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'BOOKDataGridView
        '
        Me.BOOKDataGridView.AutoGenerateColumns = False
        Me.BOOKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BOOKDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.BOOKDataGridView.DataSource = Me.BOOKBindingSource
        Me.BOOKDataGridView.Location = New System.Drawing.Point(829, 206)
        Me.BOOKDataGridView.Name = "BOOKDataGridView"
        Me.BOOKDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.BOOKDataGridView.TabIndex = 51
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
        'BOOKBindingSource
        '
        Me.BOOKBindingSource.DataMember = "BOOK"
        Me.BOOKBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'B_nameTextBox
        '
        Me.B_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "b_name", True))
        Me.B_nameTextBox.Location = New System.Drawing.Point(542, 232)
        Me.B_nameTextBox.MaxLength = 100
        Me.B_nameTextBox.Name = "B_nameTextBox"
        Me.B_nameTextBox.Size = New System.Drawing.Size(281, 20)
        Me.B_nameTextBox.TabIndex = 50
        '
        'Aut_idTextBox
        '
        Me.Aut_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "Aut_id", True))
        Me.Aut_idTextBox.Location = New System.Drawing.Point(542, 466)
        Me.Aut_idTextBox.MaxLength = 4
        Me.Aut_idTextBox.Name = "Aut_idTextBox"
        Me.Aut_idTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Aut_idTextBox.TabIndex = 48
        '
        'Date_publishedDateTimePicker
        '
        Me.Date_publishedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BOOKBindingSource, "date_published", True))
        Me.Date_publishedDateTimePicker.Location = New System.Drawing.Point(542, 440)
        Me.Date_publishedDateTimePicker.Name = "Date_publishedDateTimePicker"
        Me.Date_publishedDateTimePicker.Size = New System.Drawing.Size(281, 20)
        Me.Date_publishedDateTimePicker.TabIndex = 46
        '
        'Pub_idTextBox
        '
        Me.Pub_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "pub_id", True))
        Me.Pub_idTextBox.Location = New System.Drawing.Point(542, 414)
        Me.Pub_idTextBox.MaxLength = 4
        Me.Pub_idTextBox.Name = "Pub_idTextBox"
        Me.Pub_idTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Pub_idTextBox.TabIndex = 44
        '
        'Class_noTextBox
        '
        Me.Class_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "class_no", True))
        Me.Class_noTextBox.Location = New System.Drawing.Point(542, 388)
        Me.Class_noTextBox.MaxLength = 100
        Me.Class_noTextBox.Name = "Class_noTextBox"
        Me.Class_noTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Class_noTextBox.TabIndex = 42
        '
        'EdisionTextBox
        '
        Me.EdisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "edision", True))
        Me.EdisionTextBox.Location = New System.Drawing.Point(542, 362)
        Me.EdisionTextBox.MaxLength = 4
        Me.EdisionTextBox.Name = "EdisionTextBox"
        Me.EdisionTextBox.Size = New System.Drawing.Size(281, 20)
        Me.EdisionTextBox.TabIndex = 40
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(542, 336)
        Me.ISBNTextBox.MaxLength = 20
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(281, 20)
        Me.ISBNTextBox.TabIndex = 38
        '
        'PagesTextBox
        '
        Me.PagesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "pages", True))
        Me.PagesTextBox.Location = New System.Drawing.Point(542, 284)
        Me.PagesTextBox.MaxLength = 2000
        Me.PagesTextBox.Name = "PagesTextBox"
        Me.PagesTextBox.Size = New System.Drawing.Size(281, 20)
        Me.PagesTextBox.TabIndex = 34
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BOOKBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(542, 258)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(281, 20)
        Me.DateDateTimePicker.TabIndex = 33
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(542, 310)
        Me.PriceTextBox.MaxLength = 1000
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(281, 20)
        Me.PriceTextBox.TabIndex = 36
        '
        'Book_noTextBox
        '
        Me.Book_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKBindingSource, "book_no", True))
        Me.Book_noTextBox.Location = New System.Drawing.Point(542, 206)
        Me.Book_noTextBox.MaxLength = 4
        Me.Book_noTextBox.Name = "Book_noTextBox"
        Me.Book_noTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Book_noTextBox.TabIndex = 31
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 43)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Edit Book"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(111, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(845, 79)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "School Library Management System"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BOOKBindingNavigator.Size = New System.Drawing.Size(1077, 25)
        Me.BOOKBindingNavigator.TabIndex = 29
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
        'BOOKBindingNavigatorSaveItem
        '
        Me.BOOKBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BOOKBindingNavigatorSaveItem.Image = CType(resources.GetObject("BOOKBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BOOKBindingNavigatorSaveItem.Name = "BOOKBindingNavigatorSaveItem"
        Me.BOOKBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BOOKBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EditBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C__Data_Users_DefApps_AppData_INTERNETEXPLORER_Temp_Saved_Images_Library1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1077, 467)
        Me.Controls.Add(Me.BOOKDataGridView)
        Me.Controls.Add(Me.B_nameTextBox)
        Me.Controls.Add(Me.Aut_idTextBox)
        Me.Controls.Add(Me.Date_publishedDateTimePicker)
        Me.Controls.Add(Me.Pub_idTextBox)
        Me.Controls.Add(Me.Class_noTextBox)
        Me.Controls.Add(Me.EdisionTextBox)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(Me.PagesTextBox)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Book_noLabel)
        Me.Controls.Add(Me.Book_noTextBox)
        Me.Controls.Add(B_nameLabel)
        Me.Controls.Add(Aut_idLabel)
        Me.Controls.Add(Pub_idLabel)
        Me.Controls.Add(Date_publishedLabel)
        Me.Controls.Add(Class_noLabel)
        Me.Controls.Add(EdisionLabel)
        Me.Controls.Add(ISBNLabel)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(PagesLabel)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BOOKBindingNavigator)
        Me.Name = "EditBook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BOOKDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BOOKBindingNavigator.ResumeLayout(False)
        Me.BOOKBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryDataSet As WindowsApplication1.LibraryDataSet
    Friend WithEvents B_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BOOKBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Aut_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_publishedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Pub_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Class_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EdisionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Book_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BOOKTableAdapter As WindowsApplication1.LibraryDataSetTableAdapters.BOOKTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BOOKBindingNavigator As System.Windows.Forms.BindingNavigator
End Class
