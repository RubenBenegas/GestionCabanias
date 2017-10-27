Public Class lstHuesped

    Dim huesped As New Huespedes
    Private Sub lstHuesped_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        huesped.TraerTabHuespedes(dgvHuesped)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Editar()

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

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmHuesped.modificar = False
        frmHuesped.idHuesped = 0
        frmHuesped.ShowDialog()
    End Sub



    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()

    End Sub

    Private Sub btnAgregar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.MouseHover
        btnAgregar.Size = New Size(94, 34)
        btnAgregar.ForeColor = Color.Black
        btnAgregar.Cursor = Cursors.Hand

    End Sub

    Private Sub btnAgregar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.MouseLeave
        btnAgregar.Size = New Size(90, 30)
        btnAgregar.ForeColor = Color.White
        btnAgregar.Cursor = Cursors.Arrow
    End Sub




    
    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmHuesped.modificar = False
        RectangleShape1.Size = New Size(90, 30)
        RectangleShape1.BackgroundImage = My.Resources.boton1
        frmHuesped.idHuesped = 0
        frmHuesped.ShowDialog()
    End Sub

    Private Sub RectangleShape1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.MouseHover
        RectangleShape1.Size = New Size(94, 34)
        RectangleShape1.BackgroundImage = My.Resources.boton2
        RectangleShape1.Cursor = Cursors.Hand
    End Sub

    Private Sub RectangleShape1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.MouseLeave
        RectangleShape1.Size = New Size(90, 30)
        RectangleShape1.BackgroundImage = My.Resources.boton1
        RectangleShape1.Cursor = Cursors.Hand
    End Sub
End Class
