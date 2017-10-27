Public Class frmPagos


    Private idReserva_ As Integer
    Public Property IdReserva() As Integer
        Get
            Return idReserva_
        End Get
        Set(ByVal value As Integer)
            idReserva_ = value
        End Set
    End Property


    Private IdPago_ As Integer
    Public Property IdPago() As Integer
        Get
            Return IdPago_
        End Get
        Set(ByVal value As Integer)
            IdPago_ = value
        End Set
    End Property


    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property

    Dim pagos As New Pagos
    Dim reserva As New Reservas
    Private Sub frmPagos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ErrorProvider1.Clear()

        If modificar = True Then

            pagos = pagos.PagosRecuperar(IdPago)

            txtId.Text = pagos.Id
            txtMonto.Text = pagos.Monto
            dtpFecha.Value = pagos.Fecha
            txtDescripcion.Text = pagos.Descripcion
            IdReserva = pagos.IdReserva
            Me.Text = "Modificar pago"
        Else

            txtId.Text = Nothing
            txtMonto.Text = Nothing
            dtpFecha.Value = Today
            txtDescripcion.Text = Nothing
            IdReserva = frmReservas.txtId.Text
            reserva.IdEstado = 2
            Me.Text = "Agregar pago"
        End If
    End Sub

    Dim fun As New Validaciones

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If fun.validarCampos(Me, ErrorProvider1) = True Then
            pagos.Fecha = dtpFecha.Value
            pagos.Monto = txtMonto.Text
            pagos.Descripcion = txtDescripcion.Text
            pagos.IdReserva = IdReserva

            If modificar = True Then
                If pagos.PagosModificar(pagos) = True Then
                    reserva.ReservasActualizarEstado(3, IdReserva)
                    MsgBox("El pago ha sido correctamente modificado.")
                    pagos.PagosTraerTab(frmReservas.txtId.Text, lstPagos.dgvPagos)
                Else
                    MsgBox("Error al modificar el pago." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If pagos.PagosInsertar(pagos) = True Then
                    reserva.ReservasActualizarEstado(3, IdReserva)
                    MsgBox("El pago ha sido correctamente insertado.")
                    pagos.PagosTraerTab(frmReservas.txtId.Text, lstPagos.dgvPagos)
                Else
                    MsgBox("Error al insertar pago." + Chr(13) + "Intentelo de nuevo.")
                End If
            End If

            Close()
        Else

            MsgBox("Completar los campos obligatorios.", MsgBoxStyle.Information, "Importante")
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub



End Class