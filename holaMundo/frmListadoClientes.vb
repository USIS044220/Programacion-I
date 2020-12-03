Public Class frmListadoClientes
    Private Sub frmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistemaDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.clientesTableAdapter.Fill(Me.db_sistemaDataSet.clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class