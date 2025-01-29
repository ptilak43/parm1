<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_Report
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
        'Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        '  Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.brith_entry_detailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.brith_and_death_managerDataSet = New WindowsApplication1.brith_and_death_managerDataSet()
        Me.brith_entry_detailTableAdapter = New WindowsApplication1.brith_and_death_managerDataSetTableAdapters.brith_entry_detailTableAdapter()
        Me.stockTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.stockTableAdapter()
        CType(Me.stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brith_entry_detailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brith_and_death_managerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stockBindingSource
        '
        Me.stockBindingSource.DataMember = "stock"
        Me.stockBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        
        '
        'brith_entry_detailBindingSource
        '
        Me.brith_entry_detailBindingSource.DataMember = "brith_entry_detail"
        Me.brith_entry_detailBindingSource.DataSource = Me.brith_and_death_managerDataSet
        '
        'brith_and_death_managerDataSet
        '
        Me.brith_and_death_managerDataSet.DataSetName = "brith_and_death_managerDataSet"
        Me.brith_and_death_managerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'brith_entry_detailTableAdapter
        '
        Me.brith_entry_detailTableAdapter.ClearBeforeFill = True
        '
        'stockTableAdapter
        '
        Me.stockTableAdapter.ClearBeforeFill = True
        '
        'Stock_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 293)
        'Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Stock_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brith_entry_detailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brith_and_death_managerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    ' Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents brith_entry_detailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents brith_and_death_managerDataSet As WindowsApplication1.brith_and_death_managerDataSet
    Friend WithEvents brith_entry_detailTableAdapter As WindowsApplication1.brith_and_death_managerDataSetTableAdapters.brith_entry_detailTableAdapter
    Friend WithEvents stockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet As WindowsApplication1.DatabaseDataSet
    Friend WithEvents stockTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.stockTableAdapter
End Class
