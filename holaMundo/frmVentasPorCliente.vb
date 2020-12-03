Public Class frmVentasPorCliente
    Private Sub frmVentasPorCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistemaDataSet.ventasPorCliente' Puede moverla o quitarla según sea necesario.
        Me.ventasPorClienteTableAdapter.FillVentasPorCliente(Me.db_sistemaDataSet.ventasPorCliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class