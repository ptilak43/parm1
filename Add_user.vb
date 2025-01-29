Imports System.Data.OleDb

Public Class Add_user

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ValidateForm() = False Then
            Exit Sub
        End If
        If ValidateUser() = False Then
            Exit Sub
        End If
        AddData()
        LoadData()
        MessageBox.Show("Record Saved")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub Add_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet1.tbl_user' table. You can move, or remove it, as needed.
        'Me.Tbl_userTableAdapter1.Fill(Me.DataDataSet1.tbl_user)
        'TODO: This line of code loads data into the 'DataDataSet.tbl_user' table. You can move, or remove it, as needed.
        'Me.Tbl_userTableAdapter.Fill(Me.DataDataSet.tbl_user)
        LoadData()
        loadSetting(Me)

    End Sub
    Public Function ValidateForm() As Boolean
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Plz Fill All Boxes")
            ValidateForm = False
        Else
            ValidateForm = True
        End If
    End Function
    Public Function ValidateUser() As Boolean
        Connectdb()
        sqL = "SELECT * FROM tbl_user where username1='" & TextBox1.Text & "'"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            MessageBox.Show("UserName Already Exists. Please Enter Diffrent User Name")
            ValidateUser = False
        Else
            ValidateUser = True
        End If
    End Function
    Private Sub AddData()

        Connectdb()
        sqL = "INSERT INTO tbl_user VALUES( '" & TextBox1.Text & "', '" & TextBox2.Text & "')"
        cmd = New OleDbCommand(sqL, conn)
        Dim i As Integer
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
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(0), dr(1))
        Loop
        
    End Sub
End Class