Public Class lstPagos
    Dim Pago As New Pagos

    Private Sub lstPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pago.PagosTraerTab(dgvPagos)
    End Sub


    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Editar()
    End Sub

    Private Sub dgvPagos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagos.CellContentClick
        Editar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgvPagos.Rows.Count <> 0 Then
            Pago.Id = dgvPagos.Item("id", dgvPagos.CurrentRow.Index).Value
            Dim mensaje As DialogResult = MsgBox("Està seguro que quiere borrar ...", MsgBoxStyle.OkCancel, "Advertencia")
            If mensaje = Windows.Forms.DialogResult.OK Then
                If Pago.PagosBorrar(Pago.Id) Then
                    MessageBox.Show("El cliente se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Pago.PagosTraerTab(dgvPagos)
                Else
                    MessageBox.Show("El cliente NO se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If
    End Sub
    Private Sub Editar()
        frmPersonal.Modificar = True
        If dgvPagos.Rows.Count <> 0 Then
            frmPersonal.IdPersonal = dgvPagos.Item("id", dgvPagos.CurrentRow.Index).Value
            frmPersonal.ShowDialog()
            'Else
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmPagos.modificar = False
        frmPagos.IdPago = 0
        frmPagos.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class



