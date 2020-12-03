Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim objClientes As New frmClientes
        objClientes.MdiParent = Me
        objClientes.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim objProductos As New frmProductos
        objProductos.MdiParent = Me
        objProductos.Show()
    End Sub
    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim objCategorias As New frmCategorias
        objCategorias.MdiParent = Me
        objCategorias.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim objProveedores As New frmProveedores
        objProveedores.MdiParent = Me
        objProveedores.Show()
    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem.Click
        Dim objFacturaVenta As New frmVentas
        objFacturaVenta.MdiParent = Me
        objFacturaVenta.Show()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Dim objListadoClientes As New frmListadoClientes
        objListadoClientes.MdiParent = Me
        objListadoClientes.Show()
    End Sub

    Private Sub ReporteVentasPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentasPorClienteToolStripMenuItem.Click
        Dim objVentasPorCliente As New frmVentasPorCliente
        objVentasPorCliente.MdiParent = Me
        objVentasPorCliente.Show()
    End Sub
End Class
