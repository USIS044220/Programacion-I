Public Class frmProveedores
    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_sistemaDataSet)

    End Sub

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.Db_sistemaDataSet.proveedores)

    End Sub
End Class