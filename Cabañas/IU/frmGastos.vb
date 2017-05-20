﻿Public Class frmGastos
    Private idGasto_ As Integer
    Private modificar_ As Boolean
    Dim Gasto As New Gastos
    Public Property IdGasto() As Integer
        Get
            Return idGasto_
        End Get
        Set(ByVal value As Integer)
            idGasto_ = value
        End Set

    End Property
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property

    Private Sub FrmGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Gasto.CargarComboCategoria(cmbCategoria)

        If modificar = True Then
            Gasto = Gasto.RecuperarGasto(IdGasto)
            txtId.Text = Gasto.id
            txtDescripcion.Text = Gasto.descripcion
            cmbCategoria.SelectedValue = Gasto.idCategoria
            txtMUnitario.Text = Gasto.MUnitario
            txtCantidad.Text = Gasto.Cantidad
            TxtTotal.Text = CDec(txtMUnitario.Text) * CInt(txtCantidad.Text)
            Me.Text = "Modificar gasto"
        Else
            txtId.Text = Nothing
            txtDescripcion.Text = Nothing
            txtMUnitario.Text = Nothing
            txtCantidad.Text = Nothing
            TxtTotal.Text = Nothing
            Me.Text = "Agregar gasto"
        End If

    End Sub

    Dim fun As New Validaciones
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If fun.validarCampos(Me, ErrorProvider1) = True Then
            Gasto.descripcion = txtDescripcion.Text
            Gasto.idCategoria = cmbCategoria.SelectedValue
            Gasto.MUnitario = txtMUnitario.Text
            Gasto.Cantidad = txtCantidad.Text
            Gasto.Total = CDec(txtMUnitario.Text) * CDec(txtCantidad.Text)
            If modificar = True Then
                If Gasto.ModificarGasto(Gasto) = True Then
                    MsgBox("El gasto ha sido correctamente modificado.")
                    Gasto.verTodos(lstGastos.dgvGastos)
                Else
                    MsgBox("Error al modificar el gasto." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If Gasto.InsertarGasto(Gasto) = True Then
                    MsgBox("El gasto ha sido correctamente insertado.")
                    Gasto.verTodos(lstGastos.dgvGastos)
                Else
                    MsgBox("Error al insertar gasto." + Chr(13) + "Intentelo de nuevo.")
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



    Private Sub txtMUnitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMUnitario.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub


    Private Sub txtMUnitario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMUnitario.LostFocus

        txtMUnitario.Text = fun.validarImporte(txtMUnitario.Text)

    End Sub


    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub
End Class
