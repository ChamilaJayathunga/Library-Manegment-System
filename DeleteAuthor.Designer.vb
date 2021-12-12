<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteAuthor
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
        Dim A_nameLabel As System.Windows.Forms.Label
        Dim Aut_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteAuthor))
        Me.Aut_idTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet = New WindowsApplication1.LibraryDataSet()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_nameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AuthorTableAdapter = New WindowsApplication1.LibraryDataSetTableAdapters.AuthorTableAdapter()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AuthorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TableAdapterManager = New WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager()
        A_nameLabel = New System.Windows.Forms.Label()
        Aut_idLabel = New System.Windows.Forms.Label()
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AuthorBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'A_nameLabel
        '
        A_nameLabel.AutoSize = True
        A_nameLabel.Location = New System.Drawing.Point(276, 357)
        A_nameLabel.Name = "A_nameLabel"
        A_nameLabel.Size = New System.Drawing.Size(39, 13)
        A_nameLabel.TabIndex = 61
        A_nameLabel.Text = " name:"
        '
        'Aut_idLabel
        '
        Aut_idLabel.AutoSize = True
        Aut_idLabel.Location = New System.Drawing.Point(276, 296)
        Aut_idLabel.Name = "Aut_idLabel"
        Aut_idLabel.Size = New System.Drawing.Size(37, 13)
        Aut_idLabel.TabIndex = 60
        Aut_idLabel.Text = "Aut id:"
        '
        'Aut_idTextBox
        '
        Me.Aut_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "Aut_id", True))
        Me.Aut_idTextBox.Location = New System.Drawing.Point(365, 289)
        Me.Aut_idTextBox.Name = "Aut_idTextBox"
        Me.Aut_idTextBox.Size = New System.Drawing.Size(258, 20)
        Me.Aut_idTextBox.TabIndex = 62
        '
        'AuthorBindingSource
        '
        Me.AuthorBindingSource.DataMember = "Author"
        Me.AuthorBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Aut_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Aut_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'AuthorDataGridView
        '
        Me.AuthorDataGridView.AutoGenerateColumns = False
        Me.AuthorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuthorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.AuthorDataGridView.DataSource = Me.AuthorBindingSource
        Me.AuthorDataGridView.Location = New System.Drawing.Point(647, 289)
        Me.AuthorDataGridView.Name = "AuthorDataGridView"
        Me.AuthorDataGridView.Size = New System.Drawing.Size(242, 219)
        Me.AuthorDataGridView.TabIndex = 64
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "a_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "a_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'A_nameTextBox
        '
        Me.A_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "a_name", True))
        Me.A_nameTextBox.Location = New System.Drawing.Point(365, 350)
        Me.A_nameTextBox.Name = "A_nameTextBox"
        Me.A_nameTextBox.Size = New System.Drawing.Size(258, 20)
        Me.A_nameTextBox.TabIndex = 63
        '
        'AuthorBindingNavigatorSaveItem
        '
        Me.AuthorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AuthorBindingNavigatorSaveItem.Image = CType(resources.GetObject("AuthorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AuthorBindingNavigatorSaveItem.Name = "AuthorBindingNavigatorSaveItem"
        Me.AuthorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AuthorBindingNavigatorSaveItem.Text = "Save Data"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(435, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 43)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Delete Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(175, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(845, 79)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "School Library Management System"
        '
        'AuthorTableAdapter
        '
        Me.AuthorTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'AuthorBindingNavigator
        '
        Me.AuthorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AuthorBindingNavigator.BindingSource = Me.AuthorBindingSource
        Me.AuthorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AuthorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AuthorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AuthorBindingNavigatorSaveItem})
        Me.AuthorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AuthorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AuthorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AuthorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AuthorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AuthorBindingNavigator.Name = "AuthorBindingNavigator"
        Me.AuthorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AuthorBindingNavigator.Size = New System.Drawing.Size(1080, 25)
        Me.AuthorBindingNavigator.TabIndex = 59
        Me.AuthorBindingNavigator.Text = "BindingNavigator1"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuthorTableAdapter = Me.AuthorTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKTableAdapter = Nothing
        Me.TableAdapterManager.BORROWTableAdapter = Nothing
        Me.TableAdapterManager.MEMBERTableAdapter = Nothing
        Me.TableAdapterManager.MEMEMAILTableAdapter = Nothing
        Me.TableAdapterManager.MEMTELETableAdapter = Nothing
        Me.TableAdapterManager.PUBLISHERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DeleteAuthor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C__Data_Users_DefApps_AppData_INTERNETEXPLORER_Temp_Saved_Images_librarymanagementsystem_140129095912_phpapp01_thumbnail_4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1080, 477)
        Me.Controls.Add(Me.Aut_idTextBox)
        Me.Controls.Add(Me.AuthorDataGridView)
        Me.Controls.Add(Me.A_nameTextBox)
        Me.Controls.Add(A_nameLabel)
        Me.Controls.Add(Aut_idLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AuthorBindingNavigator)
        Me.Name = "DeleteAuthor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AuthorBindingNavigator.ResumeLayout(False)
        Me.AuthorBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Aut_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryDataSet As WindowsApplication1.LibraryDataSet
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AuthorTableAdapter As WindowsApplication1.LibraryDataSetTableAdapters.AuthorTableAdapter
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AuthorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents TableAdapterManager As WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager
End Class
