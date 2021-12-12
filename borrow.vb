Public Class borrow

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub borrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.BORROW' table. You can move, or remove it, as needed.
        Me.BORROWTableAdapter.Fill(Me.LibraryDataSet.BORROW)

    End Sub

    Private Sub BORROWBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BORROWBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BORROWBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub
End Class