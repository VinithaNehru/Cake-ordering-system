Imports System.Data.OleDb
Public Class Form6
    Dim con As OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Bakery management1.mdb")
        Try
            con.Open()
            Dim query As New OleDbCommand("Select * from ingredients where ID=1", con)
            Dim dr As OleDbDataReader = query.ExecuteReader()
            dr.Read()
            upflour = dr.GetInt32(0)
            upbk = dr.GetInt32(1)
            upyeast = dr.GetInt32(2)
            upegg = dr.GetInt32(3)
            upsugar = dr.GetInt32(4)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        upflour += CInt(uflour.Text)
        upbk += CInt(ubk.Text)
        upegg += CInt(ueggs.Text)
        upyeast += CInt(uyeast.Text)
        upsugar += CInt(usugar.Text)
        Try
            con.Open()
            Dim query As New OleDbCommand("update ingredients set Flour=" & upflour & ", [Baking Powder]=" & upbk & ", [Yeast]=" & upyeast & ", Eggs=" & upegg & ", Sugar=" & upsugar & " where ID=1", con)
            Dim a = "update ingredients set Flour=" & upflour & ", [Baking Powder]=" & upbk & ", [Yeast]=" & upyeast & ", Eggs=" & upegg & ", Sugar=" & upsugar & ""
            MsgBox("Successfully updated")
            query.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Data updated")
        End Try
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
    End Sub
End Class