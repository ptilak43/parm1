<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.tbl_CatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New BloodBank.DatabaseDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet3 = New BloodBank.DataSet3()
        Me.tbl_userTableAdapter = New BloodBank.DataSet3TableAdapters.tbl_userTableAdapter()
        Me.tbl_CatTableAdapter = New BloodBank.DatabaseDataSetTableAdapters.tbl_CatTableAdapter()
        Me.DatabaseDataSet1 = New BloodBank.DatabaseDataSet1()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New BloodBank.DatabaseDataSet1TableAdapters.staffTableAdapter()
        CType(Me.tbl_CatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_CatBindingSource
        '
        Me.tbl_CatBindingSource.DataMember = "tbl_Cat"
        Me.tbl_CatBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ccc"
        ReportDataSource1.Value = Me.StaffBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BloodBank.Report7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(530, 262)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbl_userBindingSource
        '
        Me.tbl_userBindingSource.DataMember = "tbl_user"
        Me.tbl_userBindingSource.DataSource = Me.DataSet3
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_userTableAdapter
        '
        Me.tbl_userTableAdapter.ClearBeforeFill = True
        '
        'tbl_CatTableAdapter
        '
        Me.tbl_CatTableAdapter.ClearBeforeFill = True
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "DatabaseDataSet1"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.DatabaseDataSet1
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.tbl_CatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_userBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet3 As BloodBank.DataSet3
    Friend WithEvents tbl_userTableAdapter As BloodBank.DataSet3TableAdapters.tbl_userTableAdapter
    Friend WithEvents tbl_CatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet As BloodBank.DatabaseDataSet
    Friend WithEvents tbl_CatTableAdapter As BloodBank.DatabaseDataSetTableAdapters.tbl_CatTableAdapter
    Friend WithEvents DatabaseDataSet1 As BloodBank.DatabaseDataSet1
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As BloodBank.DatabaseDataSet1TableAdapters.staffTableAdapter
End Class
