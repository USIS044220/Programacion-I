Public Class frmClientes
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("clientes")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idCliente")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Cliente
            txtCodigoCliente.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtNombreCliente.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtDireccionCliente.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtTelefonoCliente.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtEmailCliente.Text = dataTable.Rows(posicion).ItemArray(5).ToString()

            lblRegistrosCliente.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosCliente()
            MessageBox.Show("No hay registros que mostrar", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimeroCliente_Click(sender As Object, e As EventArgs) Handles btnPrimeroCliente.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteCliente_Click(sender As Object, e As EventArgs) Handles btnSiguienteCliente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnAnteriorCliente_Click(sender As Object, e As EventArgs) Handles btnAnteriorCliente.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnUltimoCliente_Click(sender As Object, e As EventArgs) Handles btnUltimoCliente.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        If btnAgregarCliente.Text = "Nuevo" Then 'Nuevo
            btnAgregarCliente.Text = "Guardar"
            btnModificarCliente.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosCliente()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosCliente(New String() {
                Me.Tag, txtCodigoCliente.Text, txtNombreCliente.Text, txtDireccionCliente.Text, txtTelefonoCliente.Text, txtEmailCliente.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Clientes",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarCliente.Text = "Nuevo"
                btnModificarCliente.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarCliente.Enabled = estado
        btnBuscarCliente.Enabled = estado
    End Sub
    Private Sub limpiarDatosCliente()
        txtCodigoCliente.Text = ""
        txtNombreCliente.Text = ""
        txtDireccionCliente.Text = ""
        txtTelefonoCliente.Text = ""
        txtEmailCliente.Text = ""
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        If btnModificarCliente.Text = "Modificar" Then 'Modificar
            btnAgregarCliente.Text = "Guardar"
            btnModificarCliente.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarCliente.Text = "Nuevo"
            btnModificarCliente.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombreCliente.Text, "Registro de cliente",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosCliente(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim objBuscarCliente As New frmBuscarClientes
        objBuscarCliente.ShowDialog()
        If objBuscarCliente._idC > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarCliente._idC))
            mostrarDatos()
        End If
    End Sub
End Class