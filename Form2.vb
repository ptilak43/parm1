Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.staff' table. You can move, or remove it, as needed.
        Me.staffTableAdapter.Fill(Me.DataSet2.staff)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class