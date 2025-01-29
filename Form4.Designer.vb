<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        Me.stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.stockTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.stockTableAdapter()
        Me.StockBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New WindowsApplication1.DataDataSet()
        Me.StockBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter1 = New WindowsApplication1.DataDataSetTableAdapters.stockTableAdapter()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ooo"
        ReportDataSource1.Value = Me.stockBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report10.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(540, 262)
        Me.ReportViewer1.TabIndex = 0
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'stockBindingSource
        '
        Me.stockBindingSource.DataMember = "stock"
        Me.stockBindingSource.DataSource = Me.DatabaseDataSet
        '
        'stockTableAdapter
        '
        Me.stockTableAdapter.ClearBeforeFill = True
        '
        'StockBindingSource1
        '
        Me.StockBindingSource1.DataMember = "stock"
        Me.StockBindingSource1.DataSource = Me.DatabaseDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "DataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource2
        '
        Me.StockBindingSource2.DataMember = "stock"
        Me.StockBindingSource2.DataSource = Me.DataDataSet
        '
        'StockTableAdapter1
        '
        Me.StockTableAdapter1.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents stockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet As WindowsApplication1.DatabaseDataSet
    Friend WithEvents stockTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataDataSet As WindowsApplication1.DataDataSet
    Friend WithEvents StockBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter1 As WindowsApplication1.DataDataSetTableAdapters.stockTableAdapter
End Class
