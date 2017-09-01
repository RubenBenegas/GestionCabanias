Public Class frmReservas
    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
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

    Dim reserva As New Reservas
    Dim btnReserva As New BotonReservas

    Private Sub frmReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        reserva.CargarComboCabania(cmbIdCabania)
        If modificar = True Then

            reserva = reserva.RecuperarReserva(idReserva)

            txtId.Text = reserva.Id
            txtNombreHuesped.Text = reserva.NombreHuesped
            'txtNombreHuesped.Text = lstReservas.dgvReservas.Item("Huesped", lstReservas.dgvReservas.CurrentRow.Index).Value
            txtIdHuesped.Text = CStr(reserva.IdHuesped)
            DateTimePicker1.Value = reserva.fIngreso
            DateTimePicker2.Value = reserva.fSalida
            cmbIdCabania.SelectedValue = reserva.IdCabania
            txtNumeroPasajeros.Text = reserva.NroPasajeros
            txtSenia.Text = reserva.Senia
            chkSinSenia.Checked = reserva.SinSenia
            DateTimePicker3.Value = reserva.Checkin
            DateTimePicker4.Value = reserva.Checkout
            Me.Text = "Modificar Proveedor"
        Else
            txtId.Text = Nothing
            txtIdHuesped.Text = Nothing
            'txtNombreHuesped.Text = Nothing
            DateTimePicker1.Value = Today
            DateTimePicker2.Value = Today
            txtNumeroPasajeros.Text = Nothing
            txtSenia.Text = Nothing
            chkSinSenia.Checked = Nothing
            DateTimePicker3.Value = Today
            DateTimePicker4.Value = Today
            Me.Text = "Agregar Proveedor"
        End If
    End Sub

    Dim fun As New Validaciones
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If fun.validarCampos(Me, ErrorProvider1) = True Then

            reserva.IdHuesped = txtIdHuesped.Text
            reserva.fIngreso = DateTimePicker1.Value
            reserva.fSalida = DateTimePicker2.Value
            reserva.IdCabania = cmbIdCabania.SelectedValue
            reserva.NroPasajeros = txtNumeroPasajeros.Text
            reserva.SinSenia = chkSinSenia.Checked
            If chkSinSenia.Checked = True Then
                reserva.Senia = 0
            Else
                reserva.Senia = txtSenia.Text
            End If
            reserva.Checkin = DateTimePicker3.Value
            reserva.Checkout = DateTimePicker4.Value
            If modificar = True Then
                If reserva.ModificarReserva(reserva) = True Then
                    MsgBox("La reserva ha sido correctamente modificado.")
                    reserva.TraerTabReservas(lstReservas.dgvReservas)
                Else
                    MsgBox("Error al modificar la reserva." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If reserva.InsertarReserva(reserva) = True Then
                    MsgBox("La reserva ha sido correctamente insertada.")
                    reserva.TraerTabReservas(lstReservas.dgvReservas)
                Else
                    MsgBox("Error al insertar la reserva." + Chr(13) + "Intentelo de nuevo.")
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

    Private Sub btnBuscarHuesped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarHuesped.Click
        lstConsHuesped.ShowDialog()
    End Sub
End Class