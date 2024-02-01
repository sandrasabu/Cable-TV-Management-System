Imports System.Data.SqlClient

Public Class totalstb
    Dim cnn As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        status = ""
        customerslist.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub totalstb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New SqlConnection("data source=DESKTOP-S69HVOU;initial catalog=PROJECT;integrated security=true")
        cnn.Open()
        cmd = New SqlCommand("select count(*) from customerlist", cnn)
        Label2.Text = cmd.ExecuteScalar
        status = ""
    End Sub
End Class