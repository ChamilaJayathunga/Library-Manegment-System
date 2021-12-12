<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ac
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
        Me.LibraryDataSet = New WindowsApplication1.LibraryDataSet()
        Me.MEMTELEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMTELETableAdapter = New WindowsApplication1.LibraryDataSetTableAdapters.MEMTELETableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMTELEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEMTELEBindingSource
        '
        Me.MEMTELEBindingSource.DataMember = "MEMTELE"
        Me.MEMTELEBindingSource.DataSource = Me.LibraryDataSet
        '
        'MEMTELETableAdapter
        '
        Me.MEMTELETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuthorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKTableAdapter = Nothing
        Me.TableAdapterManager.BORROWTableAdapter = Nothing
        Me.TableAdapterManager.MEMBERTableAdapter = Nothing
        Me.TableAdapterManager.MEMEMAILTableAdapter = Nothing
        Me.TableAdapterManager.MEMTELETableAdapter = Me.MEMTELETableAdapter
        Me.TableAdapterManager.PUBLISHERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(364, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 43)
        Me.Label1.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 43)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Activate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(107, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(845, 79)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "School Library Management System"
        '
        'Ac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.C__Data_Users_DefApps_AppData_INTERNETEXPLORER_Temp_Saved_Images_library_management_system_c_project2
        Me.ClientSize = New System.Drawing.Size(913, 462)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ac"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMTELEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LibraryDataSet As WindowsApplication1.LibraryDataSet
    Friend WithEvents MEMTELEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEMTELETableAdapter As WindowsApplication1.LibraryDataSetTableAdapters.MEMTELETableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
