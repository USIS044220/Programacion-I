Public Class frmClientes
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("clientes")

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        txtCodigoCliente.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
        txtNombreCliente.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
        txtDireccionCliente.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
        txtTelefonoCliente.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
        txtEmailCliente.Text = dataTable.Rows(posicion).ItemArray(5).ToString()

        lblRegistrosCliente.Text = posicion + 1 & " de " & dataTable.Rows.Count

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
        If btnAgregarCliente.Text = "Nuevo" Then
            btnAgregarCliente.Text = "Guardar"
            btnModificarCliente.Text = "Cancelar"

            HabDescontroles(False)
        Else

            HabDescontroles(True)
            btnAgregarCliente.Text = "Nuevo"
            btnModificarCliente.Text = "Modificar"
        End If
    End Sub

    Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = estado
        grbNavegacion.Enabled = estado
        btnEliminarCliente.Enabled = estado
        btnBuscarCliente.Enabled = estado
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        If btnModificarCliente.Text = "Modificar" Then
            btnAgregarCliente.Text = "Guardar"
            btnModificarCliente.Text = "Cancelar"

            HabDescontroles(False)
        Else

            HabDescontroles(True)
            btnAgregarCliente.Text = "Nuevo"
            btnModificarCliente.Text = "Modificar"
        End If
    End Sub
End Class