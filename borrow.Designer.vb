<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrow
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
        Dim Date_borrowLabel As System.Windows.Forms.Label
        Dim Date_retLabel As System.Windows.Forms.Label
        Dim Mem_noLabel As System.Windows.Forms.Label
        Dim Book_noLabel As System.Windows.Forms.Label
        Dim FineLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(borrow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LibraryDataSet = New WindowsApplication1.LibraryDataSet()
        Me.BORROWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BORROWTableAdapter = New WindowsApplication1.LibraryDataSetTableAdapters.BORROWTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.BORROWBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BORROWBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Date_borrowDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_retDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Mem_noTextBox = New System.Windows.Forms.TextBox()
        Me.Book_noTextBox = New System.Windows.Forms.TextBox()
        Me.FineTextBox = New System.Windows.Forms.TextBox()
        Me.BORROWDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Date_borrowLabel = New System.Windows.Forms.Label()
        Date_retLabel = New System.Windows.Forms.Label()
        Mem_noLabel = New System.Windows.Forms.Label()
        Book_noLabel = New System.Windows.Forms.Label()
        FineLabel = New System.Windows.Forms.Label()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BORROWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BORROWBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BORROWBindingNavigator.SuspendLayout()
        CType(Me.BORROWDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Date_borrowLabel
        '
        Date_borrowLabel.AutoSize = True
        Date_borrowLabel.Location = New System.Drawing.Point(242, 222)
        Date_borrowLabel.Name = "Date_borrowLabel"
        Date_borrowLabel.Size = New System.Drawing.Size(68, 13)
        Date_borrowLabel.TabIndex = 34
        Date_borrowLabel.Text = "Date borrow:"
        '
        'Date_retLabel
        '
        Date_retLabel.AutoSize = True
        Date_retLabel.Location = New System.Drawing.Point(242, 196)
        Date_retLabel.Name = "Date_retLabel"
        Date_retLabel.Size = New System.Drawing.Size(48, 13)
        Date_retLabel.TabIndex = 35
        Date_retLabel.Text = "Date ret:"
        '
        'Mem_noLabel
        '
        Mem_noLabel.AutoSize = True
        Mem_noLabel.Location = New System.Drawing.Point(243, 274)
        Mem_noLabel.Name = "Mem_noLabel"
        Mem_noLabel.Size = New System.Drawing.Size(47, 13)
        Mem_noLabel.TabIndex = 36
        Mem_noLabel.Text = "mem no:"
        '
        'Book_noLabel
        '
        Book_noLabel.AutoSize = True
        Book_noLabel.Location = New System.Drawing.Point(242, 300)
        Book_noLabel.Name = "Book_noLabel"
        Book_noLabel.Size = New System.Drawing.Size(49, 13)
        Book_noLabel.TabIndex = 37
        Book_noLabel.Text = "book no:"
        '
        'FineLabel
        '
        FineLabel.AutoSize = True
        FineLabel.Location = New System.Drawing.Point(242, 248)
        FineLabel.Name = "FineLabel"
        FineLabel.Size = New System.Drawing.Size(27, 13)
        FineLabel.TabIndex = 38
        FineLabel.Text = "fine:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 43)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Borrow Book"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(27, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(845, 79)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "School Library Management System"
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BORROWBindingSource
        '
        Me.BORROWBindingSource.DataMember = "BORROW"
        Me.BORROWBindingSource.DataSource = Me.LibraryDataSet
        '
        'BORROWTableAdapter
        '
        Me.BORROWTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuthorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKTableAdapter = Nothing
        Me.TableAdapterManager.BORROWTableAdapter = Me.BORROWTableAdapter
        Me.TableAdapterManager.MEMBERTableAdapter = Nothing
        Me.TableAdapterManager.MEMEMAILTableAdapter = Nothing
        Me.TableAdapterManager.MEMTELETableAdapter = Nothing
        Me.TableAdapterManager.PUBLISHERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BORROWBindingNavigator
        '
        Me.BORROWBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BORROWBindingNavigator.BindingSource = Me.BORROWBindingSource
        Me.BORROWBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BORROWBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BORROWBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BORROWBindingNavigatorSaveItem})
        Me.BORROWBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BORROWBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BORROWBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BORROWBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BORROWBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BORROWBindingNavigator.Name = "BORROWBindingNavigator"
        Me.BORROWBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BORROWBindingNavigator.Size = New System.Drawing.Size(1112, 25)
        Me.BORROWBindingNavigator.TabIndex = 34
        Me.BORROWBindingNavigator.Text = "BindingNavigator1"
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
        'BORROWBindingNavigatorSaveItem
        '
        Me.BORROWBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BORROWBindingNavigatorSaveItem.Image = CType(resources.GetObject("BORROWBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BORROWBindingNavigatorSaveItem.Name = "BORROWBindingNavigatorSaveItem"
        Me.BORROWBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BORROWBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Date_borrowDateTimePicker
        '
        Me.Date_borrowDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BORROWBindingSource, "Date_borrow", True))
        Me.Date_borrowDateTimePicker.Location = New System.Drawing.Point(468, 215)
        Me.Date_borrowDateTimePicker.Name = "Date_borrowDateTimePicker"
        Me.Date_borrowDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_borrowDateTimePicker.TabIndex = 35
        '
        'Date_retDateTimePicker
        '
        Me.Date_retDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BORROWBindingSource, "Date_ret", True))
        Me.Date_retDateTimePicker.Location = New System.Drawing.Point(468, 189)
        Me.Date_retDateTimePicker.Name = "Date_retDateTimePicker"
        Me.Date_retDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_retDateTimePicker.TabIndex = 36
        '
        'Mem_noTextBox
        '
        Me.Mem_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BORROWBindingSource, "mem_no", True))
        Me.Mem_noTextBox.Location = New System.Drawing.Point(468, 267)
        Me.Mem_noTextBox.MaxLength = 4
        Me.Mem_noTextBox.Name = "Mem_noTextBox"
        Me.Mem_noTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mem_noTextBox.TabIndex = 37
        '
        'Book_noTextBox
        '
        Me.Book_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BORROWBindingSource, "book_no", True))
        Me.Book_noTextBox.Location = New System.Drawing.Point(468, 293)
        Me.Book_noTextBox.MaxLength = 4
        Me.Book_noTextBox.Name = "Book_noTextBox"
        Me.Book_noTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Book_noTextBox.TabIndex = 38
        '
        'FineTextBox
        '
        Me.FineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BORROWBindingSource, "fine", True))
        Me.FineTextBox.Location = New System.Drawing.Point(468, 241)
        Me.FineTextBox.MaxLength = 5
        Me.FineTextBox.Name = "FineTextBox"
        Me.FineTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FineTextBox.TabIndex = 39
        '
        'BORROWDataGridView
        '
        Me.BORROWDataGridView.AutoGenerateColumns = False
        Me.BORROWDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BORROWDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.BORROWDataGridView.DataSource = Me.BORROWBindingSource
        Me.BORROWDataGridView.Location = New System.Drawing.Point(674, 189)
        Me.BORROWDataGridView.Name = "BORROWDataGridView"
        Me.BORROWDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.BORROWDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Date_borrow"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date_borrow"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date_ret"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date_ret"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "mem_no"
        Me.DataGridViewTextBoxColumn3.HeaderText = "mem_no"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "book_no"
        Me.DataGridViewTextBoxColumn4.HeaderText = "book_no"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fine"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fine"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C__Data_Users_DefApps_AppData_INTERNETEXPLORER_Temp_Saved_Images_library_lending
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1112, 454)
        Me.Controls.Add(Me.BORROWDataGridView)
        Me.Controls.Add(FineLabel)
        Me.Controls.Add(Me.FineTextBox)
        Me.Controls.Add(Book_noLabel)
        Me.Controls.Add(Me.Book_noTextBox)
        Me.Controls.Add(Mem_noLabel)
        Me.Controls.Add(Me.Mem_noTextBox)
        Me.Controls.Add(Date_retLabel)
        Me.Controls.Add(Me.Date_retDateTimePicker)
        Me.Controls.Add(Date_borrowLabel)
        Me.Controls.Add(Me.Date_borrowDateTimePicker)
        Me.Controls.Add(Me.BORROWBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "borrow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BORROWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BORROWBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BORROWBindingNavigator.ResumeLayout(False)
        Me.BORROWBindingNavigator.PerformLayout()
        CType(Me.BORROWDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibraryDataSet As WindowsApplication1.LibraryDataSet
    Friend WithEvents BORROWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BORROWTableAdapter As WindowsApplication1.LibraryDataSetTableAdapters.BORROWTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BORROWBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BORROWBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Date_borrowDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_retDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Mem_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Book_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BORROWDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
