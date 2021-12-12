Public Class book

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BOOKBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BOOKBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.BOOK' table. You can move, or remove it, as needed.
        Me.BOOKTableAdapter.Fill(Me.LibraryDataSet.BOOK)

    End Sub
End Class