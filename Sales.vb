Imports System.Data.OleDb
Public Class Sales

    Private Sub LoadData()
        txtstaffid.Enabled = True
        txtname.Enabled = True
        TextBox3.Enabled = True
        TextBox3.Text = "1"
        txtstaffid.Text = "1"
        txtname.Text = ""
        cmdsex.Items.Clear()
        txtphone.Items.Clear()
        txtaddress.Text = "0"
        TextBox1.Text = "1"
        TextBox2.Text = "0"
        TextBox4.Text = "0"
        TextBox5.Text = "0"
        DataGridView1.Rows.Clear()

        Connectdb()

        sqL = "SELECT * FROM tbl_cat"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        txtphone.Items.Clear()
        Do While dr.Read = True
            txtphone.Items.Add(dr(0))
        Loop
        cmd.Dispose()

        sqL = "SELECT max(s_id) FROM tbl_sales"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        If dr.Read = False Then
            txtstaffid.Text = "1"
        Else
            txtstaffid.Text = Val(dr(0)) + 1
        End If
        cmd.Dispose()

        sqL = "SELECT max(bill_no) FROM tbl_sales"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        If dr.Read = False Then
            TextBox3.Text = "1"
        Else
            TextBox3.Text = Val(dr(0)) + 1
        End If
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub txtphone_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.SelectedIndexChanged
        Connectdb()

        sqL = "SELECT * FROM stock where cat_name='" & txtphone.Text & "'"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        cmdsex.Items.Clear()
        Do While dr.Read = True
            cmdsex.Items.Add(dr(1))
        Loop
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub cmdsex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsex.SelectedIndexChanged

        Connectdb()

        sqL = "SELECT * FROM stock where s_name='" & cmdsex.Text & "'"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            txtaddress.Text = dr(3)
            TextBox4.Text = dr(4)
        End If
        cmd.Dispose()

        calc_Amt()

        Dim arrImage() As Byte
        Dim myMS As New IO.MemoryStream
        Dim da As New OleDbDataAdapter(("select * from stock where s_name ='" & cmdsex.Text & "'"), conn)

        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            If Not IsDBNull(dt.Rows(0).Item("pics")) Then
                arrImage = dt.Rows(0).Item("pics")
                For Each ar As Byte In arrImage
                    myMS.WriteByte(ar)
                Next
                Me.staffpic.Image = System.Drawing.Image.FromStream(myMS)
            End If
        End If

        conn.Close()

    End Sub
    Private Sub calc_Amt()
        TextBox2.Text = Val(TextBox1.Text) * Val(txtaddress.Text)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        calc_Amt()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ValidateForm() = False Then
            Exit Sub
        End If



        Connectdb()
        sqL = "INSERT INTO tbl_sales VALUES( '" & Val(txtstaffid.Text) & "','" & dateofbirth.Value & "','" & txtname.Text & "','" & Val(TextBox3.Text) & "', '" & cmdsex.Text & "','" & txtphone.Text & "', '" & Val(txtaddress.Text) & "', '" & Val(TextBox1.Text) & "', '" & Val(TextBox2.Text) & "')"
        cmd = New OleDbCommand(sqL, conn)
        Dim i As Integer
        i = cmd.ExecuteNonQuery
        cmd.Dispose()

        TextBox4.Text = Val(TextBox4.Text) - Val(TextBox1.Text)

        sqL = "update stock set avl_qty='" & TextBox4.Text & "' where s_name='" & cmdsex.Text & "'"
        cmd = New OleDbCommand(sqL, conn)
        i = cmd.ExecuteNonQuery

        sqL = "SELECT * FROM tbl_sales where bill_no=" & Val(TextBox3.Text)
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(4), dr(5), dr(6), dr(7), dr(8))
        Loop
        cmd.Dispose()



        conn.Close()

        TextBox5.Text = Format(Val(TextBox5.Text) + Val(TextBox2.Text), "0.00")
        txtstaffid.Enabled = False
        txtname.Enabled = False
        TextBox3.Enabled = False
    End Sub
    Public Function ValidateForm() As Boolean
        If txtstaffid.Text = "" Or txtname.Text = "" Or txtphone.Text = "" Or txtaddress.Text = "" Or cmdsex.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Plz Fill All Boxes")
            ValidateForm = False
        Else
            ValidateForm = True
        End If
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LoadData()
    End Sub

    Private Sub Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSetting(Me)
        LoadData()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class