Imports System.Data.SqlClient
Public Class customerdetails
    Dim cnn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim status As String
    Dim ST

    Private Sub customerdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New SqlConnection("data source=DESKTOP-S69HVOU;initial catalog=PROJECT; integrated security=true")
        cnn.Open()
        cmd = New SqlCommand("select * from customerlist where id='" & id & "'", cnn)
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox1.Text = dr.Item(0)
            TextBox2.Text = dr.Item(1)
            TextBox3.Text = dr.Item(2)
            TextBox4.Text = dr.Item(3)
            TextBox5.Text = dr.Item(4)
            TextBox6.Text = dr.Item(5)
            status = dr.Item(6)
        End While
        dr.Close()
        If status = "Active" Then
            Button1.Text = "Deactive"
            ST = "DEACTIVE"
        Else
            Button1.Text = "Active"
            ST = "Active"
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(ST)
        cmd = New SqlCommand("update customerlist set status='" & ST & "' where id='" & TextBox2.Text & "'", cnn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Updated")

        If Button1.Text = "Active" Then
            Timer1.Enabled = True
            Button1.Text = "Deactive"
            Timer1.Enabled = False
        Else
            If Button1.Text = "Deactive" Then
                Timer1.Enabled = True
                Button1.Text = "Active"
                Timer1.Enabled = False
            End If
        End If
        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmd = New SqlCommand("delete from customerlist where id='" & TextBox2.Text & "'", cnn)
        cmd.ExecuteNonQuery()
        MsgBox("Deleted successfully")
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox1.Focus()


    End Sub
End Class