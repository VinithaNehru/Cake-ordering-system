Public Class Form9

    Private Sub IngredientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IngredientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IngredientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bakery_management1DataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_management1DataSet.ingredients' table. You can move, or remove it, as needed.
        Me.IngredientsTableAdapter.Fill(Me.Bakery_management1DataSet.ingredients)

    End Sub
End Class