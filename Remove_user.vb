Imports System.Data.OleDb

Public Class Remove_user
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("Please Select a username.")
            Exit Sub
        End If
        DelData()
        LoadData()
        MessageBox.Show("Record Deleted")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub Add_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSetting(Me)
        'TODO: This line of code loads data into the 'DataDataSet1.tbl_user' table. You can move, or remove it, as needed.
        'Me.Tbl_userTableAdapter1.Fill(Me.DataDataSet1.tbl_user)
        'TODO: This line of code loads data into the 'DataDataSet.tbl_user' table. You can move, or remove it, as needed.
        'Me.Tbl_userTableAdapter.Fill(Me.DataDataSet.tbl_user)
        LoadData()

    End Sub
  
    
    Private Sub DelData()

        Connectdb()
        sqL = "DELETE * FROM tbl_user WHERE username1 = '" & ComboBox1.Text & "'"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        cmd.Dispose()
        conn.Close()

    End Sub
    Private Sub LoadData()

        Connectdb()
        sqL = "SELECT * FROM tbl_user"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        ComboBox1.Items.Clear()
        Do While dr.Read = True
            ComboBox1.Items.Add(dr(0))
            DataGridView1.Rows.Add(dr(0), dr(1))
        Loop

    End Sub
   
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class