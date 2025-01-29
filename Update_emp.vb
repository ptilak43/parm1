Imports System.Data.OleDb
Public Class Update_emp

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtstaffid.Items.Clear()
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            txtstaffid.Items.Add(dr(0))
        Loop
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
        sqL = "update staff set staffname= '" & txtname.Text & "', sex='" & cmdsex.Text & "', datebirth='" & dateofbirth.Value & "' , phone='" & txtphone.Text & "', address='" & txtaddress.Text & "', designation='" & ComboBox1.Text & "' where staffid=" & Val(txtstaffid.Text)
        cmd = New OleDbCommand(sqL, conn)
        Dim i As Integer
        i = cmd.ExecuteNonQuery

        cmd.Dispose()
        conn.Close()


        LoadData()
        MessageBox.Show("Record Updated")
    End Sub

    Public Function ValidateForm() As Boolean
        If txtstaffid.Text = "" Or txtname.Text = "" Or txtphone.Text = "" Or txtaddress.Text = "" Or cmdsex.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Plz Fill All Boxes")
            ValidateForm = False
        Else
            ValidateForm = True
        End If
    End Function

    Private Sub txtstaffid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstaffid.SelectedIndexChanged
        Connectdb()
        sqL = "SELECT * FROM staff where staffid=" & Val(txtstaffid.Text)
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            txtname.Text = dr(1)
            cmdsex.Text = dr(2)
            dateofbirth.Value = dr(3)
            txtphone.Text = dr(4)
            txtaddress.Text = dr(5)
            ComboBox1.Text = dr(6)
        Else
            MessageBox.Show("Plz select an ID")
        End If

        cmd.Dispose()
        conn.Close()
    End Sub
End Class