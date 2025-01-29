Imports System.Data.OleDb
Public Class Login
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Connectdb()
            sqL = "SELECT * FROM tbl_user WHERE username1 = '" & TextBox1.Text & "' AND password1 ='" & TextBox2.Text & "'"
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                Mdimain.Show()
                Me.Hide()

                'MsgBox("Welcome", MsgBoxStyle.Information, "Login Report")
            Else
                MsgBox("Incorrect Username or Password", MsgBoxStyle.Exclamation, "Login")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frm_clr = Me.BackColor
        loadSetting(Me)
    End Sub

End Class
