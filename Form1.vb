Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet2.stock' table. You can move, or remove it, as needed.
        Me.stockTableAdapter.Fill(Me.DataDataSet2.stock)

        Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(488, 262)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
End Class