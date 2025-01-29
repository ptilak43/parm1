Imports System.Data.OleDb
Public Class View_stock

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub View_stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSetting(Me)
        LoadData()
    End Sub
    Private Sub LoadData()

        Connectdb()
        sqL = "SELECT * FROM stock"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
        Loop
        cmd.Dispose()

        sqL = "SELECT * FROM tbl_cat"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        ComboBox1.Items.Clear()
        Do While dr.Read = True
            ComboBox1.Items.Add(dr(0))
        Loop
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Connectdb()
        sqL = "SELECT * FROM stock where Cat_name='" & ComboBox1.Text & "'"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
        Loop
        cmd.Dispose()
        conn.Close()
    End Sub
End Class