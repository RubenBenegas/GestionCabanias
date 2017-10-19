Public Class frmPagos


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
    Private Sub frmPagos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ErrorProvider1.Clear()

        If modificar = True Then

            pagos = pagos.PagosRecuperar(IdPago)

            txtId.Text = pagos.Id
            txtMonto.Text = pagos.Monto
            dtpFecha.Value = pagos.Fecha
            txtIdReserva.Text = pagos.IdReserva
            Me.Text = "Modificar pago"
        Else

            txtId.Text = Nothing
            txtMonto.Text = Nothing
            dtpFecha.Value = Today
            txtIdReserva.Text = Nothing
            Me.Text = "Agregar pago"
        End If
    End Sub

    Dim fun As New Validaciones

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If fun.validarCampos(Me, ErrorProvider1) = True Then
            pagos.Fecha = dtpFecha.Value
            pagos.Monto = txtMonto.Text
            pagos.IdReserva = txtIdReserva.Text

            If modificar = True Then
                If pagos.PagosModificar(pagos) = True Then
                    MsgBox("El pago ha sido correctamente modificado.")
                    pagos.PagosTraerTab(lstPagos.dgvPagos)
                Else
                    MsgBox("Error al modificar el pago." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If pagos.PagosInsertar(pagos) = True Then
                    MsgBox("El pago ha sido correctamente insertado.")
                    pagos.PagosTraerTab(lstPagos.dgvPagos)
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

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        lstPagosReservas.ShowDialog()
    End Sub
End Class