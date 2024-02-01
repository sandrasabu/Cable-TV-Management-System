
Imports System.Data.SqlClient
Public Class Form2
    Dim cnn As New SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim dt As DataSet
    Dim i As Integer
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New SqlConnection("data source=DESKTOP-S69HVOU;initial catalog=PROJECT; integrated security=true")
        cnn.Open()
        cmd = New SqlCommand("select * from customerlist", cnn)
        da = New SqlDataAdapter(cmd)
        dt = New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.Tables(0)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class