Imports System.Data.OleDb
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Dim con As New OleDb.OleDbConnection
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Bakery management1.mdb")
        Try
            con.Open()
            Dim query As New OleDbCommand("Select * from ingredients where ID=1", con)
            Dim dr As OleDbDataReader = query.ExecuteReader()
            dr.Read()
            ivnflour = dr.GetInt32(0)
            ivnbk = dr.GetInt32(1)
            ivnyeast = dr.GetInt32(2)
            ivnegg = dr.GetInt32(3)
            ivnsugar = dr.GetInt32(4)
        Catch ex As Exception
            MsgBox("Successful")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt = InputBox("Password", "Enter the password")
        If (txt.Equals("vinitha")) Then
            Dim con As New OleDb.OleDbConnection
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Bakery management1.mdb")
            Try
                con.Open()
                Dim query As New OleDbCommand("Select * from ingredients where ID=1", con)
                Dim dr As OleDbDataReader = query.ExecuteReader()
                dr.Read()
                ivnflour = dr.GetInt32(0)
                ivnbk = dr.GetInt32(1)
                ivnyeast = dr.GetInt32(2)
                ivnegg = dr.GetInt32(3)
                ivnsugar = dr.GetInt32(4)
            Catch ex As Exception
                MsgBox("Successful")
            End Try
            If ivnflour <= 5 Or ivnbk <= 5 Or ivnyeast <= 5 Or ivnegg <= 5 Or ivnsugar <= 5 Then
                MsgBox("Your supplies are getting very low, please check and update supplies")
            End If
            Form5.Show()
        Else
            MsgBox("Incorrect password, please try again")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
