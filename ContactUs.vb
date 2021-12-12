Public Class ContactUs

    Private Sub MEMTELEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMTELEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MEMTELEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.MEMTELE' table. You can move, or remove it, as needed.
        Me.MEMTELETableAdapter.Fill(Me.LibraryDataSet.MEMTELE)

    End Sub
End Class