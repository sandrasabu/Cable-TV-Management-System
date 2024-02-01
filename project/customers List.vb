Imports System.Data.SqlClient
Public Class customerslist
    Dim cnn As New SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim dt As DataSet
    Dim i As Integer
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New SqlConnection("data source=DESKTOP-S69HVOU;initial catalog=PROJECT; integrated security=true")
        cnn.Open()
        If status = "" Then
            cmd = New SqlCommand("select * from customerlist ", cnn)
        Else
            cmd = New SqlCommand("select * from customerlist where status='" & status & "' ", cnn)
        End If
        status = " "
        da = New SqlDataAdapter(cmd)
        dt = New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.Tables(0)
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub
End Class