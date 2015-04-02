Imports System.Data.OleDb
Public Class Form4
    Dim con As OleDbConnection
    Public cost, flour, bk, egg, yeast, sugar As Double
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles address.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.cakename = "BlackForest" Then
            flour = 1
            bk = 0.5
            yeast = 0.01
            egg = 4
            sugar = 0.5
            cost = 550
        ElseIf Form2.cakename = "Strawberry" Then
            flour = 1
            bk = 0.5
            yeast = 0.01
            egg = 4
            sugar = 0.5
            cost = 450
        ElseIf Form2.cakename = "Vanilla" Then
            flour = 1
            bk = 0.5
            yeast = 0.01
            egg = 4
            sugar = 0.5
            cost = 600
        ElseIf Form2.cakename = "BlackCurrent" Then
            flour = 1
            bk = 0.5
            yeast = 0.01
            egg = 4
            sugar = 0.5
            cost = 500
        ElseIf Form2.cakename = "Pistachio" Then
            flour = 1
            bk = 0.5
            yeast = 0.01
            egg = 4
            sugar = 0.5
            cost = 350
        ElseIf Form2.cakename = "Pineapple" Then
            flour = 1
            bk = 0.5
            yeast = 0.01
            egg = 4
            sugar = 0.5
            cost = 400
        End If
        flour = flour * Val(Form3.ComboBox1.SelectedItem)
        bk = bk * Val(Form3.ComboBox1.SelectedItem)
        yeast = yeast * Val(Form3.ComboBox1.SelectedItem)
        egg = egg * Val(Form3.ComboBox1.SelectedItem)
        sugar = sugar * Val(Form3.ComboBox1.SelectedItem)
        amt.Text = Val(Form3.ComboBox1.SelectedItem) * cost
        cname.Text = Form3.cname.Text
        item.Text = Form3.Label1.Text
        address.Text = Form3.address.Text
        contact.Text = Form3.contact.Text
        deldate.Text = Form3.DateTimePicker1.Value.Date
        qty.Text = Form3.ComboBox1.SelectedItem

        ivnflour -= flour
        ivnbk -= bk
        ivnegg -= egg
        ivnyeast -= yeast
        ivnsugar -= sugar
        'con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Bakery management1.mdb")
        'Try
        '    con.Open()
        '    Dim q As String = "insert into users values('" + cname.Text + "','" + address.Text + "','" + item.Text + "','" + contact.Text + "','" + Form3.email.Text + "'," + deldate.Text + "," + amt.Text + ")"
        '    Dim query As New OleDbCommand(q, con)
        '    MsgBox(q)
        '    query.ExecuteNonQuery()
        '    con.Close()
        'Catch ex As Exception

        'End Try
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Bakery management1.mdb")
        'Try
        '    con.Open()
        '    Dim query As New OleDbCommand("update ingredients set Flour=" & ivnflour & ", [Baking Powder]=" & ivnbk & ", [Yeast]=" & ivnyeast & ", Eggs=" & ivnegg & ", Sugar=" & ivnsugar & " where ID=1", con)
        '    Dim a = "update ingredients set Flour=" & ivnflour & ", [Baking Powder]=" & ivnbk & ", [Yeast]=" & ivnyeast & ", Eggs=" & ivnegg & ", Sugar=" & ivnsugar & ""
        '    MsgBox(a)
        '    query.ExecuteNonQuery()
        '    con.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Bakery management1.mdb")
        Try
            con.Open()
            orderno = orderno + 1
            Dim q As String = "insert into users(c_name, address, [cake name], contact, email_id, [delivery date], quantity, amount) values(  '" & cname.Text & "','" & address.Text & "','" & item.Text & "','" & contact.Text & "','" & Form3.email.Text & "',#" & deldate.Text & "#," & Val(qty.Text) & "," & Val(amt.Text) & ")"
            Dim query As New OleDbCommand(q, con)
            MsgBox("Order successful")
            Dim i As Integer = query.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted")
        End Try

        Try
            con.Open()
            Dim query As New OleDbCommand("update ingredients set Flour=" & ivnflour & ", [Baking Powder]=" & ivnbk & ", [Yeast]=" & ivnyeast & ", Eggs=" & ivnegg & ", Sugar=" & ivnsugar & " where ID=1", con)
            Dim a = "update ingredients set Flour=" & ivnflour & ", [Baking Powder]=" & ivnbk & ", [Yeast]=" & ivnyeast & ", Eggs=" & ivnegg & ", Sugar=" & ivnsugar & ""
            query.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form3.Close()
        Form2.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub
End Class