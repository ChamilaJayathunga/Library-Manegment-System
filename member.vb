Public Class member

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MEMBERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MEMBERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.MEMTELE' table. You can move, or remove it, as needed.
        Me.MEMTELETableAdapter.Fill(Me.LibraryDataSet.MEMTELE)
        'TODO: This line of code loads data into the 'LibraryDataSet.MEMEMAIL' table. You can move, or remove it, as needed.
        Me.MEMEMAILTableAdapter.Fill(Me.LibraryDataSet.MEMEMAIL)
        'TODO: This line of code loads data into the 'LibraryDataSet.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.LibraryDataSet.MEMBER)

    End Sub

    Private Sub Men_noTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Men_noTextBox.TextChanged
        Mem_noTextBox.Text = Men_noTextBox.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.MEMBERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)
    End Sub

End Class