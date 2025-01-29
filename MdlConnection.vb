Imports System.Data.OleDb
Module MdlConnection
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public sqL As String
    Public frm_clr As Color
    Public Sub loadSetting(ByVal frm As Form)
        frm.BackColor = frm_clr
    End Sub
    Public Sub Connectdb()
        Try
            'conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\beer.mdb")
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath() & "\Database.mdb;")

            'conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Database\phone.mdb;Jet OLEDB:Database Password = escobar;")
            conn.Open()
        Catch ex As Exception
            MsgBox("Failed in Connecting to database")
        End Try
    End Sub

    
End Module
