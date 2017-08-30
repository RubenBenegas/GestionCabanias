Public Class lstServicios

    Dim servicio As New Servicios
    Private Sub lstServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        servicio.ServicioTraerTab(dgvServicios)


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Editar()

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmServicios.modificar = False
        frmServicios.idServicio = 0
        frmServicios.ShowDialog()
    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgvServicios.Rows.Count <> 0 Then
            servicio.Id = dgvServicios.Item("Id", dgvServicios.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If servicio.ServicioBorrar(servicio.Id) Then
                    MessageBox.Show("El servicio se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    servicio.ServicioTraerTab(dgvServicios)
                Else
                    MessageBox.Show("El servicio no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If


        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()

    End Sub

    Private Sub Editar()
        frmServicios.modificar = True
        If dgvServicios.Rows.Count <> 0 Then
            frmServicios.idServicio = dgvServicios.Item("Id", dgvServicios.CurrentRow.Index).Value
            frmServicios.ShowDialog()

              End If

    End Sub


    Private Sub dgvServicios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicios.CellDoubleClick
        Editar()
    End Sub
End Class