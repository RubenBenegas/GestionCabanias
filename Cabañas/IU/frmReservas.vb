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

        ErrorProvider1.Clear()

        reserva.ReservasCargarAdicionales(idReserva, dgvServiciosAdicionales)

        reserva.CargarComboCabania(cmbIdCabania)
        If modificar = True Then

            reserva = reserva.RecuperarReserva(idReserva)

            txtId.Text = reserva.Id
            txtNombreHuesped.Text = reserva.NombreHuesped
            'txtNombreHuesped.Text = lstReservas.dgvReservas.Item("Huesped", lstReservas.dgvReservas.CurrentRow.Index).Value
            txtIdHuesped.Text = CStr(reserva.IdHuesped)
            dtpFechaIngreso.Value = reserva.fIngreso
            dtpFechaSalida.Value = reserva.fSalida
            cmbIdCabania.SelectedValue = reserva.IdCabania
            txtNumeroPasajeros.Text = reserva.NroPasajeros
            txtSenia.Text = reserva.Senia
            chkConSenia.Checked = reserva.ConSenia
            dtpCheckin.Value = reserva.Checkin
            dtpCheckout.Value = reserva.Checkout
            chkCancelada.Checked = reserva.Cancelada

            chkCancelada.Visible = True

            btnAgregar.Enabled = True
            btnBorrar.Enabled = True

            btnConsultarCostos.Visible = True

            lblFechaSenia.Visible = True
            dtpFechaPagoSenia.Visible = True
            lblImporteSenia.Visible = True
            txtSenia.Visible = True

            If reserva.Cancelada = True Then
                lblCostoEstadia.Visible = False
                txtCostoEstadia.Visible = False
                txtCostoEstadia.Text = 0
                lblCostoAdicionales.Visible = False
                txtCostoAdicionales.Visible = False
                txtCostoAdicionales.Text = 0
                lblCostoTotal.Visible = False
                txtCostoTotal.Visible = False
                txtCostoTotal.Text = 0
                lblFaltaPAgar.Visible = False
                txtFaltaDePagar.Visible = False
                txtFaltaDePagar.Text = 0
                lblReservaCancelada.Visible = True
                btnAgregar.Enabled = False
                btnBorrar.Enabled = False
                btnConsultarCostos.Visible = False
                lblFechaSenia.Visible = False
                dtpFechaPagoSenia.Visible = False
                lblImporteSenia.Visible = False
                txtSenia.Visible = False


                If DateDiff(DateInterval.Day, Today, reserva.fIngreso) > 14 Then
                    'MessageBox.Show(DateDiff(DateInterval.Day, Today, reserva.fIngreso))
                    lblReembolso.Visible = True
                    lblReembolso.ForeColor = Color.Green
                    lblReembolso.Text = "Reembolso de: "
                    txtReembolso.Visible = True
                    txtReembolso.Text = CStr(reserva.Senia / 2)
                Else
                    'MessageBox.Show(DateDiff(DateInterval.Day, Today, reserva.fIngreso))
                    lblReembolso.Visible = True
                    lblReembolso.ForeColor = Color.Red
                    lblReembolso.Text = "Sin reembolso"
                    txtReembolso.Text = 0
                    txtReembolso.Visible = False
                End If
            Else
                lblCostoEstadia.Visible = True
                txtCostoEstadia.Visible = True
                lblCostoAdicionales.Visible = True
                txtCostoAdicionales.Visible = True
                lblCostoTotal.Visible = True
                txtCostoTotal.Visible = True
                lblFaltaPAgar.Visible = True
                txtFaltaDePagar.Visible = True

                lblReservaCancelada.Visible = False
                lblReembolso.Visible = False
                txtReembolso.Text = 0
                txtReembolso.Visible = False

                btnConsultarCostos.Visible = True


                lblFechaSenia.Visible = True
                dtpFechaPagoSenia.Visible = True
                lblImporteSenia.Visible = True
                txtSenia.Visible = True
                'txtCostoEstadia.Text = reserva.ReservaCostoEstadia(idReserva)
                'If dgvServiciosAdicionales.Rows.Count <> 0 Then
                '    txtCostoAdicionales.Text = reserva.ReservaCostoAdicionales(idReserva)
                'Else
                '    txtCostoAdicionales.Text = 0
                'End If

                'txtCostoTotal.Text = CInt(txtCostoEstadia.Text) + CInt(txtCostoAdicionales.Text)
                'txtFaltaDePagar.Text = CInt(txtCostoTotal.Text) - CInt(txtSenia.Text)



            End If



            Me.Text = "Modificar reserva"
        Else
            txtId.Text = Nothing
            txtIdHuesped.Text = Nothing
            txtNombreHuesped.Text = Nothing
            dtpFechaIngreso.Value = Today
            dtpFechaSalida.Value = Today
            txtNumeroPasajeros.Text = Nothing
            txtSenia.Text = Nothing
            chkConSenia.Checked = Nothing
            dtpCheckin.Value = Today
            dtpCheckout.Value = Today

            lblCostoEstadia.Visible = True
            txtCostoEstadia.Visible = True
            txtCostoEstadia.Text = Nothing

            lblCostoAdicionales.Visible = True
            txtCostoAdicionales.Visible = True
            txtCostoAdicionales.Text = Nothing

            lblCostoTotal.Visible = True
            txtCostoTotal.Visible = True
            txtCostoTotal.Text = Nothing

            lblFaltaPAgar.Visible = True
            txtFaltaDePagar.Visible = True
            txtFaltaDePagar.Text = Nothing

            lblReembolso.Visible = False
            txtReembolso.Text = Nothing

            txtReembolso.Text = Nothing
            txtReembolso.Visible = False

            lblReservaCancelada.Visible = False

            reserva.Cancelada = False

            chkCancelada.Visible = False

            btnAgregar.Enabled = True
            btnBorrar.Enabled = True
            Me.Text = "Agregar reserva"
        End If
    End Sub

    Dim fun As New Validaciones
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If fun.validarCampos(Me, ErrorProvider1) = True Then

            reserva.IdHuesped = txtIdHuesped.Text
            reserva.fIngreso = dtpFechaIngreso.Value
            reserva.fSalida = dtpFechaSalida.Value
            reserva.IdCabania = cmbIdCabania.SelectedValue
            reserva.NroPasajeros = txtNumeroPasajeros.Text
            reserva.ConSenia = chkConSenia.Checked
            If reserva.ConSenia = True Then
                reserva.Senia = txtSenia.Text
            Else
                reserva.Senia = 0
            End If


            reserva.Checkin = dtpCheckin.Value
            reserva.Checkout = dtpCheckout.Value
            reserva.Cancelada = chkCancelada.Checked


            If modificar = True Then
                If reserva.ModificarReserva(reserva) = True Then
                    If reserva.Cancelada = True Then
                        If DateDiff(DateInterval.Day, Today, reserva.fIngreso) > 14 Then
                            'MessageBox.Show(DateDiff(DateInterval.Day, Today, reserva.fIngreso))
                            lblReembolso.ForeColor = Color.Green
                            lblReembolso.Text = "Reembolso de: " + CStr((reserva.Senia / 2))
                        Else
                            'MessageBox.Show(DateDiff(DateInterval.Day, Today, reserva.fIngreso))
                            lblReembolso.ForeColor = Color.Red
                            lblReembolso.Text = "Sin reembolso"
                        End If

                    End If

                    MsgBox("La reserva ha sido correctamente modificada.")
                    'reserva.TraerTabReservas(lstReservas.dgvReservas)
                    'grafReservas.ActualizarGrafico()
                Else
                    MsgBox("Error al modificar la reserva." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If reserva.InsertarReserva(reserva) = True Then
                    MsgBox("La reserva ha sido correctamente insertada.")
                    'reserva.TraerTabReservas(lstReservas.dgvReservas)
                    'grafReservas.ActualizarGrafico()
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

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtId.Text <> "" Then
            lstReservasAdicionales.idReserva = txtId.Text
            lstReservasAdicionales.ShowDialog()
        End If

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        Dim idAdicional As Integer = dgvServiciosAdicionales.Item("id", dgvServiciosAdicionales.CurrentRow.Index).Value
        reserva.ReservaAdicionalBorrar(idAdicional)
        reserva.ReservasCargarAdicionales(txtId.Text, dgvServiciosAdicionales)
    End Sub

    'ESTE BOTON SOLAMENTE SE UTILIZA CUANDO ACCEDEMOS DESDE EL HISTORIAL DE HUESPEDES
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Close()

        dtpFechaIngreso.Enabled = True
        dtpFechaSalida.Enabled = True
        dtpCheckin.Enabled = True
        dtpCheckout.Enabled = True
        btnAceptar.Visible = True
        btnCancelar.Visible = True
        btnAgregar.Visible = True
        btnBorrar.Visible = True
        cmbIdCabania.Enabled = True
        txtNumeroPasajeros.Enabled = True
        txtSenia.Enabled = True
        chkConSenia.Enabled = True

        btnSalir.Visible = False
    End Sub

    Private Sub btnConsultarCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCostos.Click
        Dim montoCabania As Decimal
        montoCabania = reserva.ReservaTraerMontoDeCabania(cmbIdCabania.SelectedValue)
        txtCostoEstadia.Text = DateDiff(DateInterval.Day, dtpFechaIngreso.Value, dtpFechaSalida.Value) * montoCabania


        If dgvServiciosAdicionales.Rows.Count = 0 Then
            txtCostoAdicionales.Text = 0
        Else
            txtCostoAdicionales.Text = reserva.ReservaCostoAdicionales(idReserva)
        End If

        If chkConSenia.Checked = True Then
            txtSenia.Text = CInt(txtCostoEstadia.Text) / 2
        Else
            txtSenia.Text = 0
        End If

        txtCostoTotal.Text = CDec(txtCostoEstadia.Text) + CDec(txtCostoAdicionales.Text)

        dtpFechaPagoSenia.Value = dtpFechaReserva.Value.Date.AddDays(3)
    End Sub
End Class