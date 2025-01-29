Imports System.Data.OleDb
Public Class User_list_view

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub User_list_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSetting(Me)
        Connectdb()
        sqL = "SELECT * FROM tbl_user"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()

        Do While dr.Read = True

            DataGridView1.Rows.Add(dr(0), dr(1))
        Loop

    End Sub
End Class