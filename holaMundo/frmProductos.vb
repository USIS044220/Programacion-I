Public Class frmProductos
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("productos")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProducto")}

        cboCategoriaProductos.DataSource = objConexion.obtenerDatos().Tables("categorias").DefaultView()
        cboCategoriaProductos.DisplayMember = "categoria"
        cboCategoriaProductos.ValueMember = "categorias.idCategoria"

        cboCategoriaProductos.AutoCompleteMode = AutoCompleteMode.Suggest
        cboCategoriaProductos.AutoCompleteSource = AutoCompleteSource.ListItems
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Producto

            cboCategoriaProductos.SelectedValue = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtCodigoProducto.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtDescripcionProducto.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtMarcaProducto.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtMedidasProducto.Text = dataTable.Rows(posicion).ItemArray(5).ToString()

            lblRegistrosProducto.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProductos()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosProductos()
        txtCodigoProducto.Text = ""
        txtDescripcionProducto.Text = ""
        txtMarcaProducto.Text = ""
        txtMedidasProducto.Text = ""
    End Sub

    Private Sub btnPrimeroProducto_Click(sender As Object, e As EventArgs) Handles btnPrimeroProducto.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorProducto_Click(sender As Object, e As EventArgs) Handles btnAnteriorProducto.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteProducto_Click(sender As Object, e As EventArgs) Handles btnSiguienteProducto.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimoProducto_Click(sender As Object, e As EventArgs) Handles btnUltimoProducto.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarProducto.Enabled = estado
        btnBuscarProducto.Enabled = estado
    End Sub
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        If btnAgregarProducto.Text = "Nuevo" Then 'Nuevo
            btnAgregarProducto.Text = "Guardar"
            btnModificarProducto.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosProductos()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosProductos(New String() {
                Me.Tag, cboCategoriaProductos.SelectedValue, txtCodigoProducto.Text, txtDescripcionProducto.Text, txtMarcaProducto.Text, txtMedidasProducto.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Productos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarProducto.Text = "Nuevo"
                btnModificarProducto.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        If btnModificarProducto.Text = "Modificar" Then 'Modificar
            btnAgregarProducto.Text = "Guardar"
            btnModificarProducto.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarProducto.Text = "Nuevo"
            btnModificarProducto.Text = "Modificar"
        End If
    End Sub
    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If MessageBox.Show("Esta seguro de eliminar " & txtDescripcionProducto.Text, "Registro de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim msg = objConexion.mantenimientoDatosProductos(New String() {Me.Tag}, "eliminar")
            If msg IsNot "error" Then
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Dim objBuscarProducto As New frmBuscarProductos
        objBuscarProducto.ShowDialog()
        If objBuscarProducto._idP > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarProducto._idP))
            mostrarDatos()
        End If
    End Sub
End Class