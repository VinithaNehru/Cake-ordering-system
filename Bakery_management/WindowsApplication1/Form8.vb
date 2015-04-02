Public Class Form8

    Public cp, sp, profit As Double
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cp = 50000
        TextBox1.Text = cp
        sp = 82550
        TextBox2.Text = sp
        profit = (sp - cp)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = profit
    End Sub
End Class