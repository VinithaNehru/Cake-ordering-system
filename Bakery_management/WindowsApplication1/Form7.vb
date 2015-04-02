Public Class Form7

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bakery_management1DataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_management1DataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Bakery_management1DataSet.users)

    End Sub
End Class