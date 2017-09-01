Imports System.Windows.Forms

Public Class frmPrincipal


    Private Sub HuespedesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuespedesToolStripMenuItem.Click

        lstHuesped.ShowDialog()

    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click

        lstPersonal.ShowDialog()

    End Sub

    Private Sub InsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsumosToolStripMenuItem.Click
        lstGastos.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click

        LstProveedor.ShowDialog()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        Dim respuesta As Integer

        respuesta = MsgBox("¿Seguro quieres salir?", MsgBoxStyle.YesNo, "Salir")

        If respuesta = vbYes Then
            Me.Close()
        End If

    End Sub

 
    Private Sub CabañasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CabañasToolStripMenuItem.Click

        lstcabania.ShowDialog()

    End Sub

    Private Sub TipoCabaniaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCabaniaToolStripMenuItem.Click
        lstTipoCabania.ShowDialog()

    End Sub

    Private Sub ReservasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasToolStripMenuItem.Click
        grafReservas.ShowDialog()
    End Sub

    Private Sub PruebaABMReservasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PruebaABMReservasToolStripMenuItem.Click
        lstReservas.ShowDialog()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiciosToolStripMenuItem.Click
        lstServicios.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        lstAdicional.ShowDialog()
    End Sub
End Class
