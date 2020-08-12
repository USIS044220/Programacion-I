Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla, i As Int64
        ntabla = txtntabla.Text
        i = 1

        lstTablas.Items.Clear()
        Do While i <= 10
            lstTablas.Items.Add(ntabla.ToString() + "X" + i.ToString() + "=" + (ntabla * i).ToString())
            i = i + 1
        Loop

    End Sub
End Class
