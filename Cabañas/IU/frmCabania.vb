Public Class frmCabania

    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property


    Private idCabania_ As Integer
    Public Property idCabania() As Integer
        Get
            Return idCabania_
        End Get
        Set(ByVal value As Integer)
            idCabania_ = value
        End Set
    End Property


    Dim cabania As New Cabanias

    Private Sub CabaniaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        cabania.CargarComboCabaniaTipo(cmbTipoCabania)
        cabania.CabaniaServCarga(idCabania, dgvCabaniaServicios)


        If modificar = True Then

            Me.Text = "Modificar Cabaña"

            cabania = cabania.RecuperarCabania(idCabania)

            txtIdCabania.Text = cabania.idCabania
            cmbTipoCabania.SelectedValue = cabania.idTipo
            txtMonto.Text = cabania.monto
            txtDescripcion.Text = cabania.descripcion


        Else

            Me.Text = "Agregar Cabaña"

            txtIdCabania.Text = Nothing
            txtMonto.Text = Nothing
            txtDescripcion.Text = Nothing

        End If

    End Sub

    Dim fun As New Validaciones
    Private Sub ButtAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtAceptar.Click

        If fun.validarCampos(Me, ErrorProvider1) = True Then


            cabania.idTipo = cmbTipoCabania.SelectedValue
            cabania.descripcion = txtDescripcion.Text


            If modificar = True Then
                If cabania.ModificarCabania(cabania) = True Then
                    MsgBox("La cabaña ha sido correctamente modificada.")
                    cabania.TraerTabCabania(lstcabania.dgvCabanias)
                Else
                    MsgBox("Error al modificar la cabaña." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If cabania.InsertarCabania(cabania) = True Then
                    MsgBox("La cabaña ha sido correctamente insertada.")
                    cabania.TraerTabCabania(lstcabania.dgvCabanias)
                Else
                    MsgBox("Error al insertar cabaña." + Chr(13) + "Intentelo de nuevo.")
                End If
            End If
            Close()

        Else

            MsgBox("Completar los campos obligatorios.", MsgBoxStyle.Information, "Importante")
        End If

    End Sub


    Private Sub ButtCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtCancelar.Click
        Close()

    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = "," Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub

    
    Private Sub cmbTipoCabania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoCabania.SelectedIndexChanged
        ' txtMonto.Text = 
    End Sub

    Private Sub Agregarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregarbtn.Click

        lstCabaniaServicios.idCabaniaServ = txtIdCabania.Text
        lstCabaniaServicios.ShowDialog()

    End Sub

    Private Sub Eliminarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminarbtn.Click

        Dim idCabaniaServ As Integer = dgvCabaniaServicios.Item("id", dgvCabaniaServicios.CurrentRow.Index).Value
        cabania.CabaniaServBorrar(idCabaniaServ)
        cabania.CabaniaServCargar(idCabania, dgvCabaniaServicios)

    End Sub
End Class

