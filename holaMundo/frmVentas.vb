Public Class frmVentas
    Private Sub VentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_sistemaDataSet)

    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.FillPagos(Me.Db_sistemaDataSet.pagos)
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.tipofactura' Puede moverla o quitarla según sea necesario.
        Me.TipofacturaTableAdapter.FillTipoFactura(Me.Db_sistemaDataSet.tipofactura)
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Db_sistemaDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.dventasProductos' Puede moverla o quitarla según sea necesario.
        Me.DventasProductosTableAdapter.FillDventasProductos(Me.Db_sistemaDataSet.dventasProductos)
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.FillVentas(Me.Db_sistemaDataSet.ventas)

        totalizar()

    End Sub

    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = DventasProductosDataGridView.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double

            For i As Integer = 0 To nfilas
                fila = DventasProductosDataGridView.Rows(i)
                subtotal = Double.Parse(fila.Cells("cantidad").Value.ToString()) * Double.Parse(fila.Cells("precio").Value.ToString())

                fila.Cells("subtotal").Value = subtotal.ToString()
                sumas += subtotal
            Next
            iva = If(IdTipofacturaComboBox.SelectedValue = 4, sumas * 0.13, 0)
            total = sumas + iva

            lblRespuestaSuma.Text = "$ " + Math.Round(sumas, 2).ToString()
            lblRespuestaIva.Text = "$ " + Math.Round(iva, 2).ToString()
            lblRespuestaTotal.Text = "$ " + Math.Round(total, 2).ToString()

            lblnregistros.Text = (VentasBindingSource.Position + 1) & " de " & VentasBindingSource.Count
        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message)
        End Try
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        VentasBindingSource.MoveFirst()
        totalizar()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        VentasBindingSource.MovePrevious()
        totalizar()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        VentasBindingSource.MoveNext()
        totalizar()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        VentasBindingSource.MoveLast()
        totalizar()
    End Sub
End Class