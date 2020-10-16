Public Class frmBuscarCategorias
    Dim objConexion As New db_conexion
    Public _idC As Integer
    Private Sub frmBuscarCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarCategoria.DataSource = objConexion.obtenerDatos().Tables("categorias").DefaultView
    End Sub
    Private Sub filtrarDatosCategorias(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarCategoria.DataSource
        bs.Filter = "categoria like '%" + valor + "%'"
        grdBuscarCategoria.DataSource = bs
    End Sub
    Private Sub seleccionarCategoria()
        _idC = grdBuscarCategoria.CurrentRow.Cells("idCategoria").Value.ToString()
        Close()
    End Sub
    Private Sub txtBuscarProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarCategoria.KeyUp
        filtrarDatosCategorias(txtBuscarCategoria.Text)
        If e.KeyCode = 13 Then
            seleccionarCategoria()
        End If
    End Sub

    Private Sub btnSeleccionarProductos_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCategoria.Click
        seleccionarCategoria()
    End Sub
End Class