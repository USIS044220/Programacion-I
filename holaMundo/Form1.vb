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
End Class
