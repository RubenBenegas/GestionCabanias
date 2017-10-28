Public Class LstProveedor
    Dim Proveedor As New Proveedor
    Private Sub LstProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Proveedor.traerProveedor(dgvProveedores)

    End Sub

    Private Sub Editar()
        FrmProveedor.modificar = True

        If dgvProveedores.Rows.Count <> 0 Then
            FrmProveedor.idProveedor = dgvProveedores.Item("id", dgvProveedores.CurrentRow.Index).Value
            FrmProveedor.ShowDialog()
        Else
            MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub


    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Editar()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        If dgvProveedores.Rows.Count <> 0 Then
            Proveedor.id = dgvProveedores.Item("id", dgvProveedores.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If Proveedor.ProveedorEliminar(Proveedor.id) Then
                    MessageBox.Show("El producto se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Proveedor.traerProveedor(dgvProveedores)
                Else
                    MessageBox.Show("El producto no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cerrar.Click
        Close()

    End Sub



    Private Sub dgvProveedores_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellDoubleClick
        Editar()

    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        FrmProveedor.modificar = False
        FrmProveedor.idProveedor = 0
        FrmProveedor.ShowDialog()
    End Sub
End Class