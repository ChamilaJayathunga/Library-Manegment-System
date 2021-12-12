<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class publisher
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
        Dim Pub_idLabel As System.Windows.Forms.Label
        Dim Pub_nameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(publisher))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LibraryDataSet = New WindowsApplication1.LibraryDataSet()
        Me.PUBLISHERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PUBLISHERTableAdapter = New WindowsApplication1.LibraryDataSetTableAdapters.PUBLISHERTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.PUBLISHERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PUBLISHERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Pub_idTextBox = New System.Windows.Forms.TextBox()
        Me.Pub_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PUBLISHERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Pub_idLabel = New System.Windows.Forms.Label()
        Pub_nameLabel = New System.Windows.Forms.Label()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUBLISHERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUBLISHERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PUBLISHERBindingNavigator.SuspendLayout()
        CType(Me.PUBLISHERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pub_idLabel
        '
        Pub_idLabel.AutoSize = True
        Pub_idLabel.Location = New System.Drawing.Point(383, 206)
        Pub_idLabel.Name = "Pub_idLabel"
        Pub_idLabel.Size = New System.Drawing.Size(39, 13)
        Pub_idLabel.TabIndex = 48
        Pub_idLabel.Text = "pub id:"
        '
        'Pub_nameLabel
        '
        Pub_nameLabel.AutoSize = True
        Pub_nameLabel.Location = New System.Drawing.Point(383, 249)
        Pub_nameLabel.Name = "Pub_nameLabel"
        Pub_nameLabel.Size = New System.Drawing.Size(57, 13)
        Pub_nameLabel.TabIndex = 49
        Pub_nameLabel.Text = "pub name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(476, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 43)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Publisher"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(139, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(845, 79)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "School Library Management System"
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PUBLISHERBindingSource
        '
        Me.PUBLISHERBindingSource.DataMember = "PUBLISHER"
        Me.PUBLISHERBindingSource.DataSource = Me.LibraryDataSet
        '
        'PUBLISHERTableAdapter
        '
        Me.PUBLISHERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuthorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKTableAdapter = Nothing
        Me.TableAdapterManager.BORROWTableAdapter = Nothing
        Me.TableAdapterManager.MEMBERTableAdapter = Nothing
        Me.TableAdapterManager.MEMEMAILTableAdapter = Nothing
        Me.TableAdapterManager.MEMTELETableAdapter = Nothing
        Me.TableAdapterManager.PUBLISHERTableAdapter = Me.PUBLISHERTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PUBLISHERBindingNavigator
        '
        Me.PUBLISHERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PUBLISHERBindingNavigator.BindingSource = Me.PUBLISHERBindingSource
        Me.PUBLISHERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PUBLISHERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PUBLISHERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PUBLISHERBindingNavigatorSaveItem})
        Me.PUBLISHERBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PUBLISHERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PUBLISHERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PUBLISHERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PUBLISHERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PUBLISHERBindingNavigator.Name = "PUBLISHERBindingNavigator"
        Me.PUBLISHERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PUBLISHERBindingNavigator.Size = New System.Drawing.Size(1043, 25)
        Me.PUBLISHERBindingNavigator.TabIndex = 48
        Me.PUBLISHERBindingNavigator.Text = "BindingNavigator1"
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
        'PUBLISHERBindingNavigatorSaveItem
        '
        Me.PUBLISHERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PUBLISHERBindingNavigatorSaveItem.Image = CType(resources.GetObject("PUBLISHERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PUBLISHERBindingNavigatorSaveItem.Name = "PUBLISHERBindingNavigatorSaveItem"
        Me.PUBLISHERBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PUBLISHERBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Pub_idTextBox
        '
        Me.Pub_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PUBLISHERBindingSource, "pub_id", True))
        Me.Pub_idTextBox.Location = New System.Drawing.Point(446, 203)
        Me.Pub_idTextBox.MaxLength = 4
        Me.Pub_idTextBox.Name = "Pub_idTextBox"
        Me.Pub_idTextBox.Size = New System.Drawing.Size(204, 20)
        Me.Pub_idTextBox.TabIndex = 49
        '
        'Pub_nameTextBox
        '
        Me.Pub_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PUBLISHERBindingSource, "pub_name", True))
        Me.Pub_nameTextBox.Location = New System.Drawing.Point(446, 249)
        Me.Pub_nameTextBox.MaxLength = 100
        Me.Pub_nameTextBox.Name = "Pub_nameTextBox"
        Me.Pub_nameTextBox.Size = New System.Drawing.Size(204, 20)
        Me.Pub_nameTextBox.TabIndex = 50
        '
        'PUBLISHERDataGridView
        '
        Me.PUBLISHERDataGridView.AutoGenerateColumns = False
        Me.PUBLISHERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PUBLISHERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.PUBLISHERDataGridView.DataSource = Me.PUBLISHERBindingSource
        Me.PUBLISHERDataGridView.Location = New System.Drawing.Point(683, 153)
        Me.PUBLISHERDataGridView.Name = "PUBLISHERDataGridView"
        Me.PUBLISHERDataGridView.Size = New System.Drawing.Size(243, 220)
        Me.PUBLISHERDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "pub_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "pub_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "pub_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "pub_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'publisher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C__Data_Users_DefApps_AppData_INTERNETEXPLORER_Temp_Saved_Images_650_REL_graphic_568x233_workforcetools_0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1043, 417)
        Me.Controls.Add(Me.PUBLISHERDataGridView)
        Me.Controls.Add(Pub_nameLabel)
        Me.Controls.Add(Me.Pub_nameTextBox)
        Me.Controls.Add(Pub_idLabel)
        Me.Controls.Add(Me.Pub_idTextBox)
        Me.Controls.Add(Me.PUBLISHERBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Name = "publisher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUBLISHERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUBLISHERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PUBLISHERBindingNavigator.ResumeLayout(False)
        Me.PUBLISHERBindingNavigator.PerformLayout()
        CType(Me.PUBLISHERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibraryDataSet As WindowsApplication1.LibraryDataSet
    Friend WithEvents PUBLISHERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PUBLISHERTableAdapter As WindowsApplication1.LibraryDataSetTableAdapters.PUBLISHERTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PUBLISHERBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PUBLISHERBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Pub_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pub_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PUBLISHERDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
