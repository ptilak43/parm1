Public Class Stock_Report

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.stock' table. You can move, or remove it, as needed.
        Me.stockTableAdapter.Fill(Me.DatabaseDataSet.stock)
        'TODO: This line of code loads data into the 'brith_and_death_managerDataSet.brith_entry_detail' table. You can move, or remove it, as needed.
        Me.brith_entry_detailTableAdapter.Fill(Me.brith_and_death_managerDataSet.brith_entry_detail)

        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class