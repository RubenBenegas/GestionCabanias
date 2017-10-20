Public Class lstCancelaciones


    Dim cancelacion As New Cancelaciones
    Private Sub lstCancelaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cancelacion.TraerTabCancelaciones(DataGridView1)
    End Sub
End Class