Imports System.Data.SqlClient
Public Class deactivestb
    Dim cnn As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        customerslist.Show()
    End Sub

    Private Sub deactivestb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New SqlConnection("data source=DESKTOP-S69HVOU;initial catalog=PROJECT;integrated security=true")
        cnn.Open()
        cmd = New SqlCommand("select count(*) from customerlist where status='DEACTIVE'", cnn)
        Label2.Text = cmd.ExecuteScalar()
        status = "DEACTIVE"
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class