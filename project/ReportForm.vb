Public Class ReportForm
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.ReportSource = "C:\Users\Sandra\Documents\Visual Studio 2010\Projects\mainform\mainform\crystalreport1.rpt"
        CrystalReportViewer1.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CrystalReportViewer1.SelectionFormula = "{Customerlist.Name}='" & TextBox1.Text & "'"
        CrystalReportViewer1.ReportSource = "C:\Users\Sandra\Documents\Visual Studio 2010\Projects\mainform\mainform\crystalreport1.rpt"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.Show()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class