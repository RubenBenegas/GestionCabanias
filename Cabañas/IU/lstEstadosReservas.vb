Public Class lstEstadosReservas


    Private idEstado_ As Integer
    Public Property idEstado() As Integer
        Get
            Return idEstado_
        End Get
        Set(ByVal value As Integer)
            idEstado_ = value
        End Set
    End Property

    Dim reservas As New Reservas
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub lstEstadosReservas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        reservas.TraerTabReservas(dgvEstadoReservas)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If rbEnEspera.Checked = True Then
            idEstado = 1
            reservas.ReservasFiltrarPorEstado(idEstado, dgvEstadoReservas)
        ElseIf rbSeniada.Checked = True Then
            idEstado = 2
            reservas.ReservasFiltrarPorEstado(idEstado, dgvEstadoReservas)
        ElseIf rdEnCurso.Checked = True Then
            idEstado = 3
            reservas.ReservasFiltrarPorEstado(idEstado, dgvEstadoReservas)
        Else
            idEstado = 4
            reservas.ReservasFiltrarPorEstado(idEstado, dgvEstadoReservas)
        End If



        'reservas.ReservasFiltrarPorEstado(idEstado, dgvEstadoReservas)
    End Sub


    Private Sub dgvEstadoReservas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEstadoReservas.CellDoubleClick
        Editar()

    End Sub


    Private Sub Editar()
        frmReservas.modificar = True

        If dgvEstadoReservas.Rows.Count <> 0 Then
            frmReservas.idReserva = dgvEstadoReservas.Item("id", dgvEstadoReservas.CurrentRow.Index).Value
            frmReservas.ShowDialog()
        Else
            MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub btnTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodos.Click
        reservas.TraerTabReservas(dgvEstadoReservas)
    End Sub
End Class
