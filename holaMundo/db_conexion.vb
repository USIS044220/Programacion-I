Imports System.Data 'Importar las bibliotecas y clases necesarias para trabajar con ado.net
Imports System.Data.SqlClient 'Biblioteca de clases para SQl server y ado.net

Public Class db_conexion
    Dim miConexion As New SqlConnection 'Conectarse a la BD
    Dim miCommand As New SqlCommand 'Ejecutar consultas o sentencias SQL.
    Dim miAdapter As New SqlDataAdapter 'Es un intermediario entre la fuente de datos y la aplicacion... como un puente 
    Dim ds As New DataSet 'Representa una copia de la arquitectura (tablas, campos, indices, llaves, relaciones, datos, etc) de la BD en memoria

    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sistema.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion

        miConexion.Open()

        parametrizacion()
    End Sub

    Private Sub parametrizacion()
        miCommand.Parameters.Add("@id", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idContacto", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@cod", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@nom", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@dir", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@tel", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@ema", SqlDbType.Char).Value = ""
    End Sub
    Public Function obtenerDatos()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "select clientes.idCliente, clientes.codigo, clientes.nombre, clientes.direccion, contactos.telefono, contactos.email 
            from clientes inner join contactos on(contactos.idPersona=clientes.idCliente)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "clientes")

        'miCommand.CommandText = "select * from proveedores"
        'miAdapter.SelectCommand = miCommand
        'miAdapter.Fill(ds, "proveedores")

        'miCommand.CommandText = "select * from usuarios"
        'miAdapter.SelectCommand = miCommand
        'miAdapter.Fill(ds, "usuarios")

        'miCommand.CommandText = "select * from empleados"
        'miAdapter.SelectCommand = miCommand
        'miAdapter.Fill(ds, "empleados")

        Return ds
    End Function
    Public Function mantenimientoDatosCliente(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO clientes (codigo,nombre,direccion) VALUES(@cod,@nom,@dir)"
            Case "modificar"
                sql = "UPDATE clientes SET codigo=@cod,nombre=@nom,direccion=@dir WHERE idCliente=@id"
            Case "eliminar"
                sql = "DELETE FROM clientes WHERE idCliente=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@cod").Value = datos(1)
            miCommand.Parameters("@nom").Value = datos(2)
            miCommand.Parameters("@dir").Value = datos(3)
            miCommand.Parameters("@tel").Value = datos(4)
            miCommand.Parameters("@ema").Value = datos(5)
        Else 'Accion es eliminar
            mantenimientoDatosContacto(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                mantenimientoDatosContacto(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Private Sub mantenimientoDatosContacto(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                miCommand.Connection = miConexion
                miCommand.CommandText = "select MAX(idCliente) AS idCliente from clientes"
                datos(0) = miCommand.ExecuteScalar().ToString()

                sql = "INSERT INTO contactos (idPersona,telefono,email) VALUES(@id,@tel,@ema)"
            Case "modificar"
                sql = "UPDATE contactos SET telefono=@tel,email=@ema WHERE idPersona=@id"
            Case "eliminar"
                sql = "DELETE FROM contactos WHERE idPersona=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@tel").Value = datos(4)
            miCommand.Parameters("@ema").Value = datos(5)
        End If
        executeSql(sql)
    End Sub
    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function

End Class
