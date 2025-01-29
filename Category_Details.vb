Imports System.Data.OleDb
Public Class Category_Details
    Dim cpyupdate As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSetting(Me)
        LoadData()
    End Sub

    Private Sub LoadData()
        TextBox1.Text = ""
        Connectdb()
        sqL = "SELECT * FROM tbl_cat"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(0))
        Loop
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Me.Dispose()
    End Sub



    Public Function ValidateForm() As Boolean
        If TextBox1.Text = "" Then
            MessageBox.Show("Plz Fill All Boxes")
            ValidateForm = False
        Else
            ValidateForm = True
        End If
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ValidateForm() = False Then
            Exit Sub
        End If

        Connectdb()
        sqL = "INSERT INTO tbl_cat VALUES( '" & TextBox1.Text & "')"
        cmd = New OleDbCommand(sqL, conn)
        Dim i As Integer
        i = cmd.ExecuteNonQuery
        cmd.Dispose()
        conn.Close()
        LoadData()
        MessageBox.Show("Record Saved")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ValidateForm() = False Then
            Exit Sub
        End If

        Connectdb()
        sqL = "update tbl_cat set cat_name='" & TextBox1.Text & "' where cat_name='" & cpyupdate & "'"
        cmd = New OleDbCommand(sqL, conn)
        Dim i As Integer
        i = cmd.ExecuteNonQuery
        cmd.Dispose()
        conn.Close()
        LoadData()
        cpyupdate = ""
        MessageBox.Show("Record Updated")
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells(0).Value.ToString
            cpyupdate = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
      
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ValidateForm() = False Then
            Exit Sub
        End If
        Connectdb()
        sqL = "DELETE * FROM tbl_cat WHERE cat_name = '" & cpyupdate & "'"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        cmd.Dispose()
        conn.Close()
        LoadData()
        MessageBox.Show("Record Deleted")
    End Sub
End Class