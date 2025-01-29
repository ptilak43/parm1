Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DatabaseDataSet1.staff)
        'TODO: This line of code loads data into the 'DatabaseDataSet.tbl_Cat' table. You can move, or remove it, as needed.
        Me.tbl_CatTableAdapter.Fill(Me.DatabaseDataSet.tbl_Cat)
        'TODO: This line of code loads data into the 'DataSet3.tbl_user' table. You can move, or remove it, as needed.
        Me.tbl_userTableAdapter.Fill(Me.DataSet3.tbl_user)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class