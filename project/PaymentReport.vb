Public Class PaymentReport

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.ReportSource = "C:\Users\Sandra\Documents\Visual Studio 2010\Projects\mainform\mainform\crystalreport2.rpt"
        CrystalReportViewer1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CrystalReportViewer1.SelectionFormula = "{billtable.Name}='" & TextBox1.Text & "'"
        CrystalReportViewer1.ReportSource = "C:\Users\Sandra\Documents\Visual Studio 2010\Projects\mainform\mainform\crystalreport2.rpt"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.Show()
    End Sub

    Private Sub PaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class