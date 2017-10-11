Public Class lstEstadosReservas
    Dim Reservas As New Reservas
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub lstEstadosReservas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Reservas.TraerTabReservas(dgvEstadoReservas)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub rbEnEspera_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEnEspera.CheckedChanged

    End Sub

    Private Sub rbSeñada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSeñada.CheckedChanged

    End Sub

    Private Sub rbCancelada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCancelada.CheckedChanged

    End Sub
End Class