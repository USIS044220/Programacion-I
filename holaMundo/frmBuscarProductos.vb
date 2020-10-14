Public Class frmBuscarProductos
    Dim objConexion As New db_conexion
    Public _idP As Integer
    Private Sub frmBuscarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarProducto.DataSource = objConexion.obtenerDatos().Tables("productos").DefaultView
    End Sub
    Private Sub filtrarDatosProductos(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarProducto.DataSource
        bs.Filter = "categoria like '%" + valor + "%' or codigo like '%" & valor & "%' or  descripcion like '%" & valor & "%'"
        grdBuscarProducto.DataSource = bs
    End Sub
    Private Sub seleccionarProducto()
        _idP = grdBuscarProducto.CurrentRow.Cells("idProducto").Value.ToString()
        Close()
    End Sub
    Private Sub btnSeleccionarProductos_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProductos.Click
        seleccionarProducto()
    End Sub
    Private Sub txtBuscarProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarProducto.KeyUp
        filtrarDatosProductos(txtBuscarProducto.Text)
        If e.KeyCode = 13 Then
            seleccionarProducto()
        End If
    End Sub
End Class