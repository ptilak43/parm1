Public Class Employee_Report

    Private Sub Employee_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.staff' table. You can move, or remove it, as needed.
        Me.staffTableAdapter.Fill(Me.DatabaseDataSet.staff)

        ' Me.ReportViewer1.RefreshReport()
    End Sub
End Class