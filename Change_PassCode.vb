Imports System.Data.OleDb
Public Class Change_PassCode

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("Please Select a username.")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("Password Can`t be Blank")
            Exit Sub
        End If
        ChangeData()
        LoadData()
        MessageBox.Show("Record Updated")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Me.Dispose()
    End Sub




    Private Sub ChangeData()
        Dim i As Integer
        Connectdb()
        sqL = "UPDATE tbl_user SET password1='" & TextBox2.Text & "' where username1='" & ComboBox1.Text & "'"


        cmd = New OleDbCommand(sqL, conn)
        i = cmd.ExecuteNonQuery
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

    Private Sub Change_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSetting(Me)
        LoadData()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TbluserBindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TbluserBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class