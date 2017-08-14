Public Class lstReservas
    Dim reservas As New Reservas
    Private Sub lstReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reservas.TraerTabReservas(dgvReservas)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        frmReservas.modificar = False
        frmReservas.idReserva = 0
        frmReservas.ShowDialog()

    End Sub

    Private Sub Editar()
        frmReservas.modificar = True

        If dgvReservas.Rows.Count <> 0 Then
            frmReservas.idReserva = dgvReservas.Item("id", dgvReservas.CurrentRow.Index).Value
            frmReservas.ShowDialog()
        Else
            MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub


    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Editar()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        If dgvReservas.Rows.Count <> 0 Then
            reservas.Id = dgvReservas.Item("id", dgvReservas.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If reservas.BorraReserva(reservas.Id) Then
                    MessageBox.Show("La reserva se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    reservas.TraerTabReservas(dgvReservas)
                Else
                    MessageBox.Show("La reserva no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cerrar.Click
        Close()

    End Sub



    Private Sub dgvReservas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReservas.CellDoubleClick
        Editar()

    End Sub
End Class