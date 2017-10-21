Public Class lstCancelaciones


    Dim cancelacion As New Cancelaciones
    Private Sub lstCancelaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cancelacion.TraerTabCancelaciones(DataGridView1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class