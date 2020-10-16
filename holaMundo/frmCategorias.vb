Public Class frmCategorias
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("categorias")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idCategoria")}

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Categoria 
            txtDescripcionCategoria.Text = dataTable.Rows(posicion).ItemArray(1).ToString()

            lblRegistrosCategoria.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosCategoria()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosCategoria()
        txtDescripcionCategoria.Text = ""
    End Sub
    Private Sub btnPrimeroCategoria_Click(sender As Object, e As EventArgs) Handles btnPrimeroCategoria.Click
        posicion = 0
        mostrarDatos()
    End Sub
    Private Sub btnAnteriorCategoria_Click(sender As Object, e As EventArgs) Handles btnAnteriorCategoria.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSiguienteCategoria_Click(sender As Object, e As EventArgs) Handles btnSiguienteCategoria.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimoCategoria_Click(sender As Object, e As EventArgs) Handles btnUltimoCategoria.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarCategoria.Enabled = estado
        btnBuscarCategoria.Enabled = estado
    End Sub
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        If btnAgregarCategoria.Text = "Nuevo" Then 'Nuevo
            btnAgregarCategoria.Text = "Guardar"
            btnModificarCategoria.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosCategoria()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosCategoria(New String() {
                Me.Tag, txtDescripcionCategoria.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Categorias",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarCategoria.Text = "Nuevo"
                btnModificarCategoria.Text = "Modificar"
            End If
        End If
    End Sub
    Private Sub btnModificarCategoria_Click(sender As Object, e As EventArgs) Handles btnModificarCategoria.Click
        If btnModificarCategoria.Text = "Modificar" Then 'Modificar
            btnAgregarCategoria.Text = "Guardar"
            btnModificarCategoria.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarCategoria.Text = "Nuevo"
            btnModificarCategoria.Text = "Modificar"
        End If
    End Sub
    Private Sub btnEliminarCategoria_Click(sender As Object, e As EventArgs) Handles btnEliminarCategoria.Click
        If MessageBox.Show("Esta seguro de eliminar " & txtDescripcionCategoria.Text, "Registro de Categorias", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim msg = objConexion.mantenimientoDatosCategoria(New String() {Me.Tag}, "eliminar")
            If msg = "error" Then
                MessageBox.Show("No se pudo eliminar la categoria porque hay productos que depende de esta categoria", "Registro de Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub
    Private Sub btnBuscarCategoria_Click(sender As Object, e As EventArgs) Handles btnBuscarCategoria.Click
        Dim objBuscarCategoria As New frmBuscarCategorias
        objBuscarCategoria.ShowDialog()
        If objBuscarCategoria._idC > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarCategoria._idC))
            mostrarDatos()
        End If
    End Sub
End Class