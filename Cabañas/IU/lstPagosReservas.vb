Public Class lstPagosReservas

    Dim reserva As New Reservas
    Private Sub lstPagosReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reserva.ReservasTraerSinSenia(dgvPagosReservas)
    End Sub
End Class