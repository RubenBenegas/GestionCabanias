Public Class frmEstadosReserva


    Private idCancelacion_ As Integer
    Public Property idCancelacion() As Integer
        Get
            Return idCancelacion_
        End Get
        Set(ByVal value As Integer)
            idCancelacion_ = value
        End Set
    End Property


    Private modifica_ As Boolean
    Public Property modifica() As Boolean
        Get
            Return modifica_
        End Get
        Set(ByVal value As Boolean)
            modifica_ = value
        End Set
    End Property


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

    Dim cancelacion As New Cancelaciones

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If rdCancelada.Checked = True Then
            frmReservas.idEstado = 4

            cancelacion.fCancelacion = dtpFechaCancelacion.Value
            cancelacion.Descripcion = txtDescripcion.Text
            cancelacion.IdReserva = frmReservas.txtId.Text


            'If frmReservas.modificar = True Then
            '    If cancelacion.ModificarCancelacion(cancelacion) = True Then
            '        MsgBox("La cancelacion ha sido correctamente modificada.")

            '    Else
            '        MsgBox("Error al modificar la cancelacion." + Chr(13) + "Intentelo de nuevo.")
            '    End If
            'Else
            If cancelacion.InsertarCancelacion(cancelacion) = True Then
                MsgBox("La cancelacion ha sido correctamente insertada.")

                '        Else
                '            MsgBox("Error al insertar cancelacion." + Chr(13) + "Intentelo de nuevo.")
                '        End If
            End If
            Close()
            'Else
            '    MsgBox("Completar los campos obligatorios.", MsgBoxStyle.Information, "Importante")
            'End If





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

            rdCancelada.Visible = True
            
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
                'cancelacion.RecuperarCancelacion(frmReservas.idReserva)
                'Dim fecha As Date

                ''dtpFechaCancelacion.Value = cancelacion.fCancelacion
                'TextBox1.Text = cancelacion.fCancelacion.ToString
                'txtDescripcion.Text = cancelacion.Descripcion
            Else
                rdEspera.Checked = True
            End If

        End If











        If frmReservas.modificar = False Then
            
            rdCancelada.Visible = False
            dtpFechaCancelacion.Visible = False
            txtDescripcion.Visible = False
        End If

    End Sub
End Class