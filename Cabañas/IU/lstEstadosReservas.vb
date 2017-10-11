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

End Class
