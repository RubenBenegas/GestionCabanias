Public Class lstHuesped

    Dim huesped As New Huespedes
    Private Sub lstHuesped_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        huesped.TraerTabHuespedes(dgvHuesped)
    End Sub



    Private Sub dgvHuesped_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHuesped.CellDoubleClick

        Editar()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If dgvHuesped.Rows.Count <> 0 Then
            huesped.id = dgvHuesped.Item("id", dgvHuesped.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If huesped.BorraHuesped(huesped.id) Then
                    MessageBox.Show("El huesped se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    huesped.TraerTabHuespedes(dgvHuesped)
                Else
                    MessageBox.Show("El huesped no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub Editar()
        frmHuesped.modificar = True
        If dgvHuesped.Rows.Count <> 0 Then
            frmHuesped.idHuesped = dgvHuesped.Item("id", dgvHuesped.CurrentRow.Index).Value
            frmHuesped.ShowDialog()
            'Else          
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()

    End Sub



    Private Sub RectangleShape1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmHuesped.modificar = False
        frmHuesped.idHuesped = 0
        frmHuesped.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Editar()
    End Sub

End Class
