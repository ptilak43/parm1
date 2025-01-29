Public Class Purchasereport

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.tbl_purchase' table. You can move, or remove it, as needed.
        Me.tbl_purchaseTableAdapter.Fill(Me.DatabaseDataSet.tbl_purchase)
        'TODO: This line of code loads data into the 'DatabaseDataSet.tbl_purchase' table. You can move, or remove it, as needed.
        Me.tbl_purchaseTableAdapter.Fill(Me.DatabaseDataSet.tbl_purchase)

        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class