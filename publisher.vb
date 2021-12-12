Public Class publisher

    Private Sub PUBLISHERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PUBLISHERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PUBLISHERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub publisher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.PUBLISHER' table. You can move, or remove it, as needed.
        Me.PUBLISHERTableAdapter.Fill(Me.LibraryDataSet.PUBLISHER)

    End Sub
End Class