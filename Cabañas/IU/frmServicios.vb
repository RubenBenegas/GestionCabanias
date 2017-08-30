Public Class frmServicios

    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property


    Private idServicio_ As Integer
    Public Property idServicio() As Integer
        Get
            Return idServicio_
        End Get
        Set(ByVal value As Integer)
            idServicio_ = value
        End Set
    End Property

    Dim servicio As New Servicios

    Private Sub frmServicios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If modificar = True Then

            Me.Text = "Modificar Servicio"

            servicio = servicio.RecuperarServicio(idServicio)

            txtIdServicio.Text = servicio.Id
            txtDescripcion.Text = servicio.Descripcion
            txtMonto.Text = servicio.Monto



        Else

            Me.Text = "Agregar Servicio"

            txtIdServicio.Text = Nothing
            txtDescripcion.Text = Nothing
            txtMonto.Text = Nothing


        End If

    End Sub

    Dim fun As New Validaciones
    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If fun.validarCampos(Me, ErrorProvider1) = True Then


            servicio.Descripcion = txtDescripcion.Text
            servicio.Monto = txtMonto.Text

            If modificar = True Then
                If servicio.ModificarServicio(servicio) = True Then
                    MsgBox("El servicio ha sido modificado.")
                    servicio.TraerTabServicio(lstServicios.dgvServicios)
                Else
                    MsgBox("Error al modificar el servicio." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If servicio.InsertarServicio(servicio) = True Then
                    MsgBox("El servicio ha sido correctamente insertado.")
                    servicio.TraerTabServicio(lstServicios.dgvServicios)
                Else
                    MsgBox("Error al insertar el servicio." + Chr(13) + "Intentelo de nuevo.")
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

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = "," Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub

End Class