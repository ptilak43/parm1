Public Class Sales_report

    Private Sub Sales_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.tbl_sales' table. You can move, or remove it, as needed.
        Me.tbl_salesTableAdapter.Fill(Me.DatabaseDataSet.tbl_sales)

        '  Me.ReportViewer1.RefreshReport()
    End Sub
End Class