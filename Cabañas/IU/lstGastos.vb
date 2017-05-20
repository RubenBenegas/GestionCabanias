Public Class lstGastos
    Dim Gastos As New Gastos


    Private Sub lstGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Gastos.verTodos(dgvGastos)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmGastos.modificar = False
        frmGastos.IdGasto = 0
        frmGastos.ShowDialog()
    End Sub

    Private Sub Editar()
        frmGastos.modificar = True
        If dgvGastos.Rows.Count <> 0 Then
            frmGastos.IdGasto = dgvGastos.Item("Id", dgvGastos.CurrentRow.Index).Value
            frmGastos.ShowDialog()
            'Else
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Editar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If dgvGastos.Rows.Count <> 0 Then
            Gastos.id = dgvGastos.Item("Id", dgvGastos.CurrentRow.Index).Value
            Dim mensaje As DialogResult = MessageBox.Show("¿Está seguro que quiere borrar?", "Advertencia", MessageBoxButtons.OKCancel)
            If mensaje = Windows.Forms.DialogResult.OK Then
                If Gastos.BorrarGasto(Gastos.id) Then
                    MessageBox.Show("El gasto se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Gastos.verTodos(dgvGastos)
                End If
            End If
            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub


    Private Sub dgvGasto_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGastos.CellDoubleClick
        Editar()

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()

    End Sub
End Class