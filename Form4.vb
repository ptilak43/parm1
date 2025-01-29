Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter1.Fill(Me.DataDataSet.stock)
        'TODO: This line of code loads data into the 'DatabaseDataSet.stock' table. You can move, or remove it, as needed.
        Me.stockTableAdapter.Fill(Me.DatabaseDataSet.stock)
        'TODO: This line of code loads data into the 'DataDataSet.staff' table. You can move, or remove it, as needed.
       

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class