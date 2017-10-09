Public Class frmEstadosReserva


    Private Sub rdEspera_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdEspera.CheckedChanged
        dtpFechaCancelacion.Visible = False
        txtDescripcion.Visible = False
    End Sub

    Private Sub rdSeniada_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdSeniada.CheckedChanged
        dtpFechaCancelacion.Visible = False
        txtDescripcion.Visible = False
    End Sub

    Private Sub rdCancelada_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdCancelada.CheckedChanged
        dtpFechaCancelacion.Visible = True
        txtDescripcion.Visible = True
    End Sub
End Class