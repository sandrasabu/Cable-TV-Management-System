Imports System.Data.SqlClient
Public Class LoginForm1
    Dim cnn As New SqlConnection
    Dim cmd As SqlCommand
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        cmd = New SqlCommand("select count (*) from LOGINTABLE where username ='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", cnn)
        If cmd.ExecuteScalar > 0 Then
            Timer1.Enabled = True
            TextBox1.Text = " "
            TextBox2.Text = " "
        Else

            MsgBox("username/password invalid")
            TextBox1.Text = " "
            TextBox2.Text = " "

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub PasswordLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Enabled = False
            Me.Hide()
            FrmDashboard.Show()

        End If
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New SqlConnection("data source=DESKTOP-S69HVOU;initial catalog=PROJECT;integrated security=true")
        cnn.Open()
        
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged



    End Sub
End Class
