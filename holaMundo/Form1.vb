Public Class Form1
    Dim objdirecciones = New direcciones()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDepto.Items.AddRange(objdirecciones.depto)
    End Sub

    Private Sub cboDepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepto.SelectedIndexChanged
        cboMun.Items.Clear()
        cboMun.Text = ""
        cboMun.Items.AddRange(objdirecciones.mun(cboDepto.SelectedIndex))
    End Sub
End Class

Class direcciones
    Public depto() As String = {"Seleccione un depto.", "Usulutan", "San Miguel", "La Union", "Morazan"}
    Public mun()() As String = {
        New String() {"Seleccione un depto."},
        New String() {"Seleccione un municipio", "Usulutan", "Jiquilisco", "Santa Elena", "Santa Maria"},    '0->Usulutan
        New String() {"Seleccione un municipio", "San Miguel", "El Transito", "San Rafael Ote", "San Jorge"},'1->San Miguel
        New String() {"Seleccione un municipio", "La Union", "SRL", "Anamoros", "Bolivar"},                  '2->La Union
        New String() {"Seleccione un municipio", "Arambala", "Perquin", "Corinto", "Cacaopera"},              '3->Morazan
        New String() {"Seleccione un municipio", "San Salvador"}
    }

End Class

