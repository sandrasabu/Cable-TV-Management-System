Imports System.Data.SqlClient

Public Class active_STB
    Dim cnn As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub active_STB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New SqlConnection("data source=DESKTOP-S69HVOU;initial catalog=PROJECT;integrated security=true")
        cnn.Open()
        cmd = New SqlCommand("select count(*) from customerlist where status='ACTIVE' ", cnn)
        Label2.Text = cmd.ExecuteScalar()
        status = "ACTIVE"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        customerslist.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class