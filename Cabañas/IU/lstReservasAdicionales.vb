Public Class lstReservasAdicionales

    Private idReserva_ As Integer

    Public Property idReserva() As Integer
        Get
            Return idReserva_
        End Get
        Set(ByVal value As Integer)
            idReserva_ = value
        End Set
    End Property

    Dim adicionales As New Adicionales
    Dim reserva As New Reservas

    Private Sub lstReservasAdicionales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adicionales.BuscarAdicionales(dgvAdicionales)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        adicionales.Id = dgvAdicionales.Item("id", dgvAdicionales.CurrentRow.Index).Value
        reserva.ReservaAdicionalInsertar(idReserva, adicionales.Id)
        reserva.ReservasCargarAdicionales(idReserva, frmReservas.dgvServiciosAdicionales)
        'reserva.TituloActorInsertar(idTitulo, actor.id)
        'titulo.TituloCargarActores(idTitulo, frmTitulo.dgvActores)
    End Sub
End Class