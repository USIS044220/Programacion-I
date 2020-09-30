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
    End Sub

    Public Function obtenerDatos()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "select * from clientes"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "clientes")

        Return ds
    End Function
    Public Function mantenimientoDatosCliente(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO clientes (codigo,nombre,direccion,telefono,email) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "')"
            Case "modificar"
                sql = "UPDATE clientes SET codigo='" + datos(1) + "',nombre='" + datos(2) + "',direccion='" + datos(3) + "',telefono='" + datos(4) + "',email='" + datos(5) + "' WHERE idCliente='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM clientes WHERE idCliente='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, por favor intentelo de nuevo."
        End If

        Return msg
    End Function
    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function

End Class
