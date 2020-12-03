<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasPorCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_sistemaDataSet = New holaMundo.db_sistemaDataSet()
        Me.ventasPorClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ventasPorClienteTableAdapter = New holaMundo.db_sistemaDataSetTableAdapters.ventasPorClienteTableAdapter()
        CType(Me.db_sistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ventasPorClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "dsVentasPorCliente"
        ReportDataSource2.Value = Me.ventasPorClienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "holaMundo.ventasPorCliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(740, 508)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_sistemaDataSet
        '
        Me.db_sistemaDataSet.DataSetName = "db_sistemaDataSet"
        Me.db_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ventasPorClienteBindingSource
        '
        Me.ventasPorClienteBindingSource.DataMember = "ventasPorCliente"
        Me.ventasPorClienteBindingSource.DataSource = Me.db_sistemaDataSet
        '
        'ventasPorClienteTableAdapter
        '
        Me.ventasPorClienteTableAdapter.ClearBeforeFill = True
        '
        'frmVentasPorCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 532)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmVentasPorCliente"
        Me.Text = "Ventas por Cliente"
        CType(Me.db_sistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ventasPorClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ventasPorClienteBindingSource As BindingSource
    Friend WithEvents db_sistemaDataSet As db_sistemaDataSet
    Friend WithEvents ventasPorClienteTableAdapter As db_sistemaDataSetTableAdapters.ventasPorClienteTableAdapter
End Class
