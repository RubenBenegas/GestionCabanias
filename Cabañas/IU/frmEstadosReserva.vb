Public Class frmEstadosReserva


    Private Sub rdEspera_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdEspera.CheckedChanged
        dtpFechaCancelacion.Visible = False
        txtDescripcion.Visible = False
    End Sub

    Private Sub rdSeniada_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdSeniada.CheckedChanged
        dtpFechaCancelacion.Visible = False
        txtDescripcion.Visible = False
    End Sub

    Private Sub rdEnCurso_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdEnCurso.CheckedChanged
        dtpFechaCancelacion.Visible = False
        txtDescripcion.Visible = False
    End Sub

    Private Sub rdCancelada_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdCancelada.CheckedChanged
        dtpFechaCancelacion.Visible = True
        txtDescripcion.Visible = True
    End Sub


    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If rdCancelada.Checked = True Then
            frmReservas.idEstado = 4
        ElseIf rdEspera.Checked = True Then
            frmReservas.idEstado = 1
        ElseIf rdSeniada.Checked = True Then
            frmReservas.idEstado = 2
        Else
            frmReservas.idEstado = 3

        End If

        Me.Close()

    End Sub

    
    Private Sub frmEstadosReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmReservas.modificar = True Then
            If frmReservas.idEstado = 1 Then
                rdEspera.Checked = True
            End If
            If frmReservas.idEstado = 2 Then
                rdSeniada.Checked = True
            End If
            If frmReservas.idEstado = 3 Then
                rdEnCurso.Checked = True
            End If
            If frmReservas.idEstado = 4 Then
                rdCancelada.Checked = True
            End If
        Else
            rdEspera.Checked = True
        End If

    End Sub
End Class