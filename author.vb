Public Class author

    Private Sub AuthorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuthorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AuthorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub author_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Author' table. You can move, or remove it, as needed.
        Me.AuthorTableAdapter.Fill(Me.LibraryDataSet.Author)

    End Sub
End Class