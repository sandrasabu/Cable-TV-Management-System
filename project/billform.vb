Imports System.Data.SqlClient
Public Class billform
    Dim cnn As New SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim status As String
    Private Sub billform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New SqlConnection("data source=DESKTOP-S69HVOU;initial catalog=PROJECT;integrated security=true")
        cnn.Open()
        Label7.Text = Now
        TextBox2.Text = AutoBillNo()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        cmd = New SqlCommand("insert into Billtable values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Value & "')", cnn)


        cmd.ExecuteNonQuery()
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox2.Text = AutoBillNo()
        TextBox3.Text = " "

        'cmd = New SqlCommand("select * from Billtable where name='" & Name & "'", cnn)
        'dr = cmd.ExecuteReader
        'While dr.Read
        '    TextBox1.Text = dr.Item(0)
        '    TextBox2.Text = dr.Item(0)
        '    TextBox3.Text = dr.Item(0)
        '    status = dr.Item(3)
        'End While
        'dr.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Public Function AutoBillNo() As Integer
        cmd = New SqlCommand("select isnull(max(billno)+1,1) from billtable", cnn)
        Return cmd.ExecuteScalar


    End Function
End Class