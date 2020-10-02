Public Class frmBuscarClientes
    Dim objConexion As New db_conexion
    Public _idC As Integer

    Private Sub btnSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCliente.Click
        seleccionarCliente()
    End Sub

    Private Sub frmBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarCliente.DataSource = objConexion.obtenerDatos().Tables("clientes").DefaultView
    End Sub

    Private Sub txtBuscarCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarCliente.KeyUp
        filtrarDatosClientes(txtBuscarCliente.Text)
        If e.KeyCode = 13 Then
            seleccionarCliente()
        End If
    End Sub
    Private Sub seleccionarCliente()
        _idC = grdBuscarCliente.CurrentRow.Cells("idCliente").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatosClientes(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarCliente.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or  nombre like '%" & valor & "%'"
        grdBuscarCliente.DataSource = bs
    End Sub

    Private Sub btnCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnCancelarCliente.Click
        _idC = 0
        Close()
    End Sub
End Class