Imports System.Data.OleDb
Public Class Add_new_emp

    Private Sub Add_new_emp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSetting(Me)
        LoadData()

        
    End Sub
    Private Sub LoadData()
        txtstaffid.Text = ""
        txtname.Text = ""
        dateofbirth.Value = Now.Date
        cmdsex.Text = "Male"
        txtphone.Text = ""
        txtaddress.Text = ""
        ComboBox1.Text = ""
        Connectdb()
        sqL = "SELECT * FROM staff"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
        Loop
        cmd.Dispose()
        sqL = "SELECT max(staffid) FROM staff"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        If dr.Read = False Then
            txtstaffid.Text = "1"
        Else
            txtstaffid.Text = Val(dr(0)) + 1
        End If
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ValidateForm() = False Then
            Exit Sub
        End If
        


        Connectdb()
        sqL = "INSERT INTO staff VALUES( '" & txtstaffid.Text & "','" & txtname.Text & "', '" & cmdsex.Text & "', '" & dateofbirth.Value & "' , '" & txtphone.Text & "', '" & txtaddress.Text & "', '" & ComboBox1.Text & "')"
        cmd = New OleDbCommand(sqL, conn)
        Dim i As Integer
        i = cmd.ExecuteNonQuery

        cmd.Dispose()
        conn.Close()


        LoadData()
        MessageBox.Show("Record Saved")
    End Sub
    
    Public Function ValidateForm() As Boolean
        If txtstaffid.Text = "" Or txtname.Text = "" Or txtphone.Text = "" Or txtaddress.Text = "" Or cmdsex.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Plz Fill All Boxes")
            ValidateForm = False
        Else
            ValidateForm = True
        End If
    End Function

    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click

    End Sub
End Class