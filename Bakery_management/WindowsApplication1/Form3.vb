Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form2.cakename
        If Form2.cakename = "BlackForest" Then
            Me.BackgroundImage = My.Resources.Black_Forest_Round_Shape_Cake
        ElseIf Form2.cakename = "Strawberry" Then
            Me.BackgroundImage = My.Resources.strawberry_cake
        ElseIf Form2.cakename = "BlackCurrent" Then
            Me.BackgroundImage = My.Resources.Black_Current
        ElseIf Form2.cakename = "Pistachio" Then
            Me.BackgroundImage = My.Resources.pistachio
        ElseIf Form2.cakename = "Pineapple" Then
            Me.BackgroundImage = My.Resources.Pinapple
        ElseIf Form2.cakename = "Vanilla" Then
            Me.BackgroundImage = My.Resources.Vanilla
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub
End Class