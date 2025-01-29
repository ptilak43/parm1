Imports System.Data.OleDb
Public Class Stock
    Dim cpyupdate As Integer
    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSetting(Me)
        LoadData()
    End Sub
    Private Sub LoadData()
        txtstaffid.Text = ""
        txtname.Text = ""
        cmdsex.Text = ""
        txtphone.Text = ""
        txtaddress.Text = ""

        Connectdb()
        sqL = "SELECT * FROM tbl_cat"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        cmdsex.Items.Clear()
        Do While dr.Read = True
            cmdsex.Items.Add(dr(0))
        Loop
        cmd.Dispose()

        sqL = "SELECT * FROM stock"
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
        Loop
        cmd.Dispose()

        sqL = "SELECT max(s_id) FROM stock"
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



    Public Function ValidateForm() As Boolean
        If txtstaffid.Text = "" Or txtname.Text = "" Or txtphone.Text = "" Or Txtaddress.Text = "" Or cmdsex.Text = "" Then
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

        Dim arrImage() As Byte
        Dim strImage As String
        Dim myMs As New IO.MemoryStream
        '
        If Not IsNothing(Me.staffpic.Image) Then
            Me.staffpic.Image.Save(myMs, Me.staffpic.Image.RawFormat)
            arrImage = myMs.GetBuffer
            strImage = "?"
        Else
            arrImage = Nothing
            strImage = "NULL"
        End If
        

        Connectdb()
        sqL = "INSERT INTO stock VALUES( '" & txtstaffid.Text & "','" & txtname.Text & "', '" & cmdsex.Text & "', '" & txtphone.Text & "', '" & Txtaddress.Text & "'," & strImage & ")"
        cmd = New OleDbCommand(sqL, conn)

        If strImage = "?" Then
            cmd.Parameters.Add(strImage, OleDbType.Binary).Value = arrImage
        End If

        Dim i As Integer
        i = cmd.ExecuteNonQuery()
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
        sqL = "update stock set s_name= '" & txtname.Text & "', cat_name='" & cmdsex.Text & "', price='" & txtphone.Text & "', avl_qty='" & Txtaddress.Text & "' where s_id=" & cpyupdate
        cmd = New OleDbCommand(sqL, conn)
        Dim i As Integer
        i = cmd.ExecuteNonQuery
        cmd.Dispose()
        conn.Close()
        LoadData()
        cpyupdate = 0
        MessageBox.Show("Record Updated")
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            txtstaffid.Text = row.Cells(0).Value.ToString
            txtname.Text = row.Cells(1).Value.ToString
            cmdsex.Text = row.Cells(2).Value.ToString
            txtphone.Text = row.Cells(3).Value.ToString
            Txtaddress.Text = row.Cells(4).Value.ToString
            cpyupdate = Val(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ValidateForm() = False Then
            Exit Sub
        End If
        Connectdb()
        sqL = "DELETE * FROM stock WHERE s_id = " & cpyupdate
        cmd = New OleDbCommand(sqL, conn)
        dr = cmd.ExecuteReader()
        cmd.Dispose()
        conn.Close()
        LoadData()
        MessageBox.Show("Record Deleted")
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Staff Image"
                .Filter = "Image file (*.jpg)|*.jpg|(*.jpeg)|*.jpeg"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.staffpic.Image = System.Drawing.Bitmap.FromFile(.FileName)
                Else
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
End Class