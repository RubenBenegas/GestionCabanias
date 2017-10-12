Public Class frmCancelaciones
    Private idCancelacion_ As Integer
    Public Property idCancelacion() As Integer
        Get
            Return idCancelacion_
        End Get
        Set(ByVal value As Integer)
            idCancelacion_ = value
        End Set
    End Property


    Private modificar_ As Integer
    Public Property modificar() As Integer
        Get
            Return modificar_
        End Get
        Set(ByVal value As Integer)
            modificar_ = value
        End Set
    End Property


    Private idReserva_ As Integer
    Public Property idReserva() As Integer
        Get
            Return idReserva_
        End Get
        Set(ByVal value As Integer)
            idReserva_ = value
        End Set
    End Property


    Dim cancelacion As New Cancelaciones
    Private Sub frmCancelaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If modificar = True Then
            Me.Text = "Modificar cancelacion"

            cancelacion = cancelacion.RecuperarCancelacion(idReserva)

            txtId.Text = cancelacion.Id
            dtpFechaCancelacion.Value = cancelacion.fCancelacion
            txtDescripcion.Text = cancelacion.Descripcion
            idReserva = cancelacion.IdReserva



            dtpFechaCancelacion.Enabled = False
            txtDescripcion.Enabled = False



            btnAceptar.Visible = False
            btnCancelar.Visible = False
            btnAceptarModificar.Visible = True
        Else
            Me.Text = "Agregar Huesped"

            txtId.Text = Nothing
            dtpFechaCancelacion.Value = Today
            txtDescripcion.Text = Nothing
            idReserva = idReserva


            dtpFechaCancelacion.Enabled = True
            txtDescripcion.Enabled = True

            btnAceptar.Visible = True
            btnCancelar.Visible = True
            btnAceptarModificar.Visible = False



        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        cancelacion.fCancelacion = dtpFechaCancelacion.Value
        cancelacion.Descripcion = txtDescripcion.Text
        cancelacion.IdReserva = idReserva
        If modificar = True Then
            If cancelacion.ModificarCancelacion(cancelacion) = True Then
                MsgBox("La cancelacion ha sido correctamente modificada.")

            Else
                MsgBox("Error al modificar la cancelacion." + Chr(13) + "Intentelo de nuevo.")
            End If
        Else
            If cancelacion.InsertarCancelacion(cancelacion) = True Then
                MsgBox("La cancelacion ha sido correctamente insertada.")

            Else
                MsgBox("Error al insertar la cancelacion." + Chr(13) + "Intentelo de nuevo.")
            End If
        End If
        Close()
    End Sub

    Private Sub btnAceptarModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarModificar.Click
        Close()

    End Sub
End Class