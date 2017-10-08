<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblId = New System.Windows.Forms.Label
        Me.lblIdHuesped = New System.Windows.Forms.Label
        Me.lblFechaIngreso = New System.Windows.Forms.Label
        Me.lblFechaSalidad = New System.Windows.Forms.Label
        Me.lblIdIdCabania = New System.Windows.Forms.Label
        Me.lblNroPasajeros = New System.Windows.Forms.Label
        Me.lblSenia = New System.Windows.Forms.Label
        Me.lblCheckIn = New System.Windows.Forms.Label
        Me.lblCheckOut = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtNumeroPasajeros = New System.Windows.Forms.TextBox
        Me.txtSenia = New System.Windows.Forms.TextBox
        Me.chkConSenia = New System.Windows.Forms.CheckBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtIdHuesped = New System.Windows.Forms.TextBox
        Me.btnBuscarHuesped = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker
        Me.dtpCheckin = New System.Windows.Forms.DateTimePicker
        Me.dtpCheckout = New System.Windows.Forms.DateTimePicker
        Me.cmbIdCabania = New System.Windows.Forms.ComboBox
        Me.txtNombreHuesped = New System.Windows.Forms.TextBox
        Me.dgvServiciosAdicionales = New System.Windows.Forms.DataGridView
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.lblServiciosAdicionales = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.txtCostoEstadia = New System.Windows.Forms.TextBox
        Me.txtCostoAdicionales = New System.Windows.Forms.TextBox
        Me.txtCostoTotal = New System.Windows.Forms.TextBox
        Me.lblCostoEstadia = New System.Windows.Forms.Label
        Me.lblCostoAdicionales = New System.Windows.Forms.Label
        Me.lblCostoTotal = New System.Windows.Forms.Label
        Me.chkCancelada = New System.Windows.Forms.CheckBox
        Me.lblReembolso = New System.Windows.Forms.Label
        Me.txtReembolso = New System.Windows.Forms.TextBox
        Me.lblReservaCancelada = New System.Windows.Forms.Label
        Me.btnConsultarCostos = New System.Windows.Forms.Button
        Me.dtpFechaReserva = New System.Windows.Forms.DateTimePicker
        Me.lblFechaReserva = New System.Windows.Forms.Label
        Me.lblImporteSenia = New System.Windows.Forms.Label
        Me.dtpFechaPagoSenia = New System.Windows.Forms.DateTimePicker
        Me.lblFechaSenia = New System.Windows.Forms.Label
        Me.txtFaltaDePagar = New System.Windows.Forms.TextBox
        Me.lblFaltaPAgar = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServiciosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(12, 9)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(19, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id:"
        '
        'lblIdHuesped
        '
        Me.lblIdHuesped.AutoSize = True
        Me.lblIdHuesped.Location = New System.Drawing.Point(12, 70)
        Me.lblIdHuesped.Name = "lblIdHuesped"
        Me.lblIdHuesped.Size = New System.Drawing.Size(65, 13)
        Me.lblIdHuesped.TabIndex = 1
        Me.lblIdHuesped.Text = "Id Huesped:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(12, 104)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(78, 13)
        Me.lblFechaIngreso.TabIndex = 2
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'lblFechaSalidad
        '
        Me.lblFechaSalidad.AutoSize = True
        Me.lblFechaSalidad.Location = New System.Drawing.Point(12, 137)
        Me.lblFechaSalidad.Name = "lblFechaSalidad"
        Me.lblFechaSalidad.Size = New System.Drawing.Size(72, 13)
        Me.lblFechaSalidad.TabIndex = 3
        Me.lblFechaSalidad.Text = "Fecha Salida:"
        '
        'lblIdIdCabania
        '
        Me.lblIdIdCabania.AutoSize = True
        Me.lblIdIdCabania.Location = New System.Drawing.Point(12, 170)
        Me.lblIdIdCabania.Name = "lblIdIdCabania"
        Me.lblIdIdCabania.Size = New System.Drawing.Size(59, 13)
        Me.lblIdIdCabania.TabIndex = 4
        Me.lblIdIdCabania.Text = "Id Cabaña:"
        '
        'lblNroPasajeros
        '
        Me.lblNroPasajeros.AutoSize = True
        Me.lblNroPasajeros.Location = New System.Drawing.Point(270, 9)
        Me.lblNroPasajeros.Name = "lblNroPasajeros"
        Me.lblNroPasajeros.Size = New System.Drawing.Size(96, 13)
        Me.lblNroPasajeros.TabIndex = 5
        Me.lblNroPasajeros.Text = "Numero Pasajeros:"
        '
        'lblSenia
        '
        Me.lblSenia.AutoSize = True
        Me.lblSenia.Location = New System.Drawing.Point(272, 40)
        Me.lblSenia.Name = "lblSenia"
        Me.lblSenia.Size = New System.Drawing.Size(35, 13)
        Me.lblSenia.TabIndex = 6
        Me.lblSenia.Text = "Seña:"
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Location = New System.Drawing.Point(272, 105)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(50, 13)
        Me.lblCheckIn.TabIndex = 8
        Me.lblCheckIn.Text = "CheckIn:"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Location = New System.Drawing.Point(270, 138)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(58, 13)
        Me.lblCheckOut.TabIndex = 9
        Me.lblCheckOut.Text = "CheckOut:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(108, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 10
        '
        'txtNumeroPasajeros
        '
        Me.txtNumeroPasajeros.Location = New System.Drawing.Point(381, 6)
        Me.txtNumeroPasajeros.Name = "txtNumeroPasajeros"
        Me.txtNumeroPasajeros.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPasajeros.TabIndex = 4
        Me.txtNumeroPasajeros.Tag = "*"
        '
        'txtSenia
        '
        Me.txtSenia.Enabled = False
        Me.txtSenia.Location = New System.Drawing.Point(15, 527)
        Me.txtSenia.Multiline = True
        Me.txtSenia.Name = "txtSenia"
        Me.txtSenia.Size = New System.Drawing.Size(100, 25)
        Me.txtSenia.TabIndex = 5
        Me.txtSenia.Tag = "*"
        '
        'chkConSenia
        '
        Me.chkConSenia.AutoSize = True
        Me.chkConSenia.Location = New System.Drawing.Point(381, 39)
        Me.chkConSenia.Name = "chkConSenia"
        Me.chkConSenia.Size = New System.Drawing.Size(73, 17)
        Me.chkConSenia.TabIndex = 6
        Me.chkConSenia.Text = "Con Seña"
        Me.chkConSenia.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(214, 583)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(320, 583)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdHuesped
        '
        Me.txtIdHuesped.Enabled = False
        Me.txtIdHuesped.Location = New System.Drawing.Point(108, 67)
        Me.txtIdHuesped.Name = "txtIdHuesped"
        Me.txtIdHuesped.Size = New System.Drawing.Size(100, 20)
        Me.txtIdHuesped.TabIndex = 24
        '
        'btnBuscarHuesped
        '
        Me.btnBuscarHuesped.Location = New System.Drawing.Point(214, 65)
        Me.btnBuscarHuesped.Name = "btnBuscarHuesped"
        Me.btnBuscarHuesped.Size = New System.Drawing.Size(34, 23)
        Me.btnBuscarHuesped.TabIndex = 25
        Me.btnBuscarHuesped.Text = "..."
        Me.btnBuscarHuesped.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(108, 104)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaIngreso.TabIndex = 1
        Me.dtpFechaIngreso.Tag = "*"
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSalida.Location = New System.Drawing.Point(108, 137)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaSalida.TabIndex = 2
        Me.dtpFechaSalida.Tag = "*"
        '
        'dtpCheckin
        '
        Me.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCheckin.Location = New System.Drawing.Point(381, 99)
        Me.dtpCheckin.Name = "dtpCheckin"
        Me.dtpCheckin.Size = New System.Drawing.Size(100, 20)
        Me.dtpCheckin.TabIndex = 7
        '
        'dtpCheckout
        '
        Me.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCheckout.Location = New System.Drawing.Point(381, 132)
        Me.dtpCheckout.Name = "dtpCheckout"
        Me.dtpCheckout.Size = New System.Drawing.Size(100, 20)
        Me.dtpCheckout.TabIndex = 8
        '
        'cmbIdCabania
        '
        Me.cmbIdCabania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdCabania.FormattingEnabled = True
        Me.cmbIdCabania.Location = New System.Drawing.Point(108, 167)
        Me.cmbIdCabania.Name = "cmbIdCabania"
        Me.cmbIdCabania.Size = New System.Drawing.Size(100, 21)
        Me.cmbIdCabania.TabIndex = 3
        '
        'txtNombreHuesped
        '
        Me.txtNombreHuesped.Enabled = False
        Me.txtNombreHuesped.Location = New System.Drawing.Point(108, 67)
        Me.txtNombreHuesped.Name = "txtNombreHuesped"
        Me.txtNombreHuesped.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreHuesped.TabIndex = 0
        Me.txtNombreHuesped.Tag = "*"
        '
        'dgvServiciosAdicionales
        '
        Me.dgvServiciosAdicionales.AllowUserToAddRows = False
        Me.dgvServiciosAdicionales.AllowUserToDeleteRows = False
        Me.dgvServiciosAdicionales.AllowUserToResizeColumns = False
        Me.dgvServiciosAdicionales.AllowUserToResizeRows = False
        Me.dgvServiciosAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiciosAdicionales.Location = New System.Drawing.Point(12, 226)
        Me.dgvServiciosAdicionales.MultiSelect = False
        Me.dgvServiciosAdicionales.Name = "dgvServiciosAdicionales"
        Me.dgvServiciosAdicionales.ReadOnly = True
        Me.dgvServiciosAdicionales.RowHeadersVisible = False
        Me.dgvServiciosAdicionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiciosAdicionales.Size = New System.Drawing.Size(401, 206)
        Me.dgvServiciosAdicionales.TabIndex = 26
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(422, 226)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(422, 262)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 28
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblServiciosAdicionales
        '
        Me.lblServiciosAdicionales.AutoSize = True
        Me.lblServiciosAdicionales.Location = New System.Drawing.Point(12, 202)
        Me.lblServiciosAdicionales.Name = "lblServiciosAdicionales"
        Me.lblServiciosAdicionales.Size = New System.Drawing.Size(110, 13)
        Me.lblServiciosAdicionales.TabIndex = 29
        Me.lblServiciosAdicionales.Text = "Servicios Adicionales:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(417, 583)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        Me.btnSalir.Visible = False
        '
        'txtCostoEstadia
        '
        Me.txtCostoEstadia.Enabled = False
        Me.txtCostoEstadia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoEstadia.Location = New System.Drawing.Point(15, 467)
        Me.txtCostoEstadia.Multiline = True
        Me.txtCostoEstadia.Name = "txtCostoEstadia"
        Me.txtCostoEstadia.Size = New System.Drawing.Size(100, 25)
        Me.txtCostoEstadia.TabIndex = 31
        Me.txtCostoEstadia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostoAdicionales
        '
        Me.txtCostoAdicionales.Enabled = False
        Me.txtCostoAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoAdicionales.Location = New System.Drawing.Point(121, 467)
        Me.txtCostoAdicionales.Multiline = True
        Me.txtCostoAdicionales.Name = "txtCostoAdicionales"
        Me.txtCostoAdicionales.Size = New System.Drawing.Size(100, 25)
        Me.txtCostoAdicionales.TabIndex = 32
        Me.txtCostoAdicionales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostoTotal
        '
        Me.txtCostoTotal.Enabled = False
        Me.txtCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotal.Location = New System.Drawing.Point(231, 467)
        Me.txtCostoTotal.Multiline = True
        Me.txtCostoTotal.Name = "txtCostoTotal"
        Me.txtCostoTotal.Size = New System.Drawing.Size(100, 25)
        Me.txtCostoTotal.TabIndex = 33
        Me.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCostoEstadia
        '
        Me.lblCostoEstadia.AutoSize = True
        Me.lblCostoEstadia.Location = New System.Drawing.Point(12, 449)
        Me.lblCostoEstadia.Name = "lblCostoEstadia"
        Me.lblCostoEstadia.Size = New System.Drawing.Size(89, 13)
        Me.lblCostoEstadia.TabIndex = 35
        Me.lblCostoEstadia.Text = "Costo de estadia:"
        '
        'lblCostoAdicionales
        '
        Me.lblCostoAdicionales.AutoSize = True
        Me.lblCostoAdicionales.Location = New System.Drawing.Point(118, 449)
        Me.lblCostoAdicionales.Name = "lblCostoAdicionales"
        Me.lblCostoAdicionales.Size = New System.Drawing.Size(108, 13)
        Me.lblCostoAdicionales.TabIndex = 36
        Me.lblCostoAdicionales.Text = "Costo de adicionales:"
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.AutoSize = True
        Me.lblCostoTotal.Location = New System.Drawing.Point(228, 449)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(64, 13)
        Me.lblCostoTotal.TabIndex = 37
        Me.lblCostoTotal.Text = "Costo Total:"
        '
        'chkCancelada
        '
        Me.chkCancelada.AutoSize = True
        Me.chkCancelada.Location = New System.Drawing.Point(381, 171)
        Me.chkCancelada.Name = "chkCancelada"
        Me.chkCancelada.Size = New System.Drawing.Size(106, 17)
        Me.chkCancelada.TabIndex = 39
        Me.chkCancelada.Text = "Cancelar reserva"
        Me.chkCancelada.UseVisualStyleBackColor = True
        '
        'lblReembolso
        '
        Me.lblReembolso.AutoSize = True
        Me.lblReembolso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReembolso.ForeColor = System.Drawing.Color.Red
        Me.lblReembolso.Location = New System.Drawing.Point(47, 532)
        Me.lblReembolso.Name = "lblReembolso"
        Me.lblReembolso.Size = New System.Drawing.Size(0, 25)
        Me.lblReembolso.TabIndex = 40
        '
        'txtReembolso
        '
        Me.txtReembolso.Enabled = False
        Me.txtReembolso.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReembolso.Location = New System.Drawing.Point(200, 526)
        Me.txtReembolso.Multiline = True
        Me.txtReembolso.Name = "txtReembolso"
        Me.txtReembolso.Size = New System.Drawing.Size(162, 30)
        Me.txtReembolso.TabIndex = 41
        '
        'lblReservaCancelada
        '
        Me.lblReservaCancelada.AutoSize = True
        Me.lblReservaCancelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservaCancelada.ForeColor = System.Drawing.Color.Red
        Me.lblReservaCancelada.Location = New System.Drawing.Point(46, 480)
        Me.lblReservaCancelada.Name = "lblReservaCancelada"
        Me.lblReservaCancelada.Size = New System.Drawing.Size(261, 31)
        Me.lblReservaCancelada.TabIndex = 42
        Me.lblReservaCancelada.Text = "Reserva Cancelada!"
        '
        'btnConsultarCostos
        '
        Me.btnConsultarCostos.Location = New System.Drawing.Point(372, 467)
        Me.btnConsultarCostos.Name = "btnConsultarCostos"
        Me.btnConsultarCostos.Size = New System.Drawing.Size(99, 23)
        Me.btnConsultarCostos.TabIndex = 43
        Me.btnConsultarCostos.Text = "Consultar costos"
        Me.btnConsultarCostos.UseVisualStyleBackColor = True
        '
        'dtpFechaReserva
        '
        Me.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReserva.Location = New System.Drawing.Point(108, 36)
        Me.dtpFechaReserva.Name = "dtpFechaReserva"
        Me.dtpFechaReserva.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaReserva.TabIndex = 44
        Me.dtpFechaReserva.Tag = "*"
        '
        'lblFechaReserva
        '
        Me.lblFechaReserva.AutoSize = True
        Me.lblFechaReserva.Location = New System.Drawing.Point(12, 36)
        Me.lblFechaReserva.Name = "lblFechaReserva"
        Me.lblFechaReserva.Size = New System.Drawing.Size(93, 13)
        Me.lblFechaReserva.TabIndex = 45
        Me.lblFechaReserva.Text = "Fecha de reserva:"
        '
        'lblImporteSenia
        '
        Me.lblImporteSenia.AutoSize = True
        Me.lblImporteSenia.Location = New System.Drawing.Point(12, 510)
        Me.lblImporteSenia.Name = "lblImporteSenia"
        Me.lblImporteSenia.Size = New System.Drawing.Size(86, 13)
        Me.lblImporteSenia.TabIndex = 46
        Me.lblImporteSenia.Text = "Importe de seña:"
        '
        'dtpFechaPagoSenia
        '
        Me.dtpFechaPagoSenia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPagoSenia.Location = New System.Drawing.Point(131, 527)
        Me.dtpFechaPagoSenia.Name = "dtpFechaPagoSenia"
        Me.dtpFechaPagoSenia.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaPagoSenia.TabIndex = 47
        Me.dtpFechaPagoSenia.Tag = "*"
        '
        'lblFechaSenia
        '
        Me.lblFechaSenia.AutoSize = True
        Me.lblFechaSenia.Location = New System.Drawing.Point(131, 510)
        Me.lblFechaSenia.Name = "lblFechaSenia"
        Me.lblFechaSenia.Size = New System.Drawing.Size(90, 13)
        Me.lblFechaSenia.TabIndex = 48
        Me.lblFechaSenia.Text = "Fecha pago seña"
        '
        'txtFaltaDePagar
        '
        Me.txtFaltaDePagar.Enabled = False
        Me.txtFaltaDePagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaltaDePagar.Location = New System.Drawing.Point(338, 661)
        Me.txtFaltaDePagar.Multiline = True
        Me.txtFaltaDePagar.Name = "txtFaltaDePagar"
        Me.txtFaltaDePagar.Size = New System.Drawing.Size(150, 25)
        Me.txtFaltaDePagar.TabIndex = 34
        '
        'lblFaltaPAgar
        '
        Me.lblFaltaPAgar.AutoSize = True
        Me.lblFaltaPAgar.Location = New System.Drawing.Point(335, 643)
        Me.lblFaltaPAgar.Name = "lblFaltaPAgar"
        Me.lblFaltaPAgar.Size = New System.Drawing.Size(78, 13)
        Me.lblFaltaPAgar.TabIndex = 38
        Me.lblFaltaPAgar.Text = "Falta de pagar:"
        '
        'frmReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 616)
        Me.Controls.Add(Me.dtpFechaPagoSenia)
        Me.Controls.Add(Me.lblFechaSenia)
        Me.Controls.Add(Me.lblImporteSenia)
        Me.Controls.Add(Me.dtpFechaReserva)
        Me.Controls.Add(Me.lblFechaReserva)
        Me.Controls.Add(Me.btnConsultarCostos)
        Me.Controls.Add(Me.lblReservaCancelada)
        Me.Controls.Add(Me.txtReembolso)
        Me.Controls.Add(Me.lblReembolso)
        Me.Controls.Add(Me.chkCancelada)
        Me.Controls.Add(Me.lblFaltaPAgar)
        Me.Controls.Add(Me.lblCostoTotal)
        Me.Controls.Add(Me.lblCostoAdicionales)
        Me.Controls.Add(Me.lblCostoEstadia)
        Me.Controls.Add(Me.txtFaltaDePagar)
        Me.Controls.Add(Me.txtCostoTotal)
        Me.Controls.Add(Me.txtCostoAdicionales)
        Me.Controls.Add(Me.txtCostoEstadia)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblServiciosAdicionales)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvServiciosAdicionales)
        Me.Controls.Add(Me.txtNombreHuesped)
        Me.Controls.Add(Me.cmbIdCabania)
        Me.Controls.Add(Me.dtpCheckout)
        Me.Controls.Add(Me.dtpCheckin)
        Me.Controls.Add(Me.dtpFechaSalida)
        Me.Controls.Add(Me.dtpFechaIngreso)
        Me.Controls.Add(Me.btnBuscarHuesped)
        Me.Controls.Add(Me.txtIdHuesped)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.chkConSenia)
        Me.Controls.Add(Me.txtSenia)
        Me.Controls.Add(Me.txtNumeroPasajeros)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.lblSenia)
        Me.Controls.Add(Me.lblNroPasajeros)
        Me.Controls.Add(Me.lblIdIdCabania)
        Me.Controls.Add(Me.lblFechaSalidad)
        Me.Controls.Add(Me.lblFechaIngreso)
        Me.Controls.Add(Me.lblIdHuesped)
        Me.Controls.Add(Me.lblId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReservas"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServiciosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblIdHuesped As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lblFechaSalidad As System.Windows.Forms.Label
    Friend WithEvents lblIdIdCabania As System.Windows.Forms.Label
    Friend WithEvents lblNroPasajeros As System.Windows.Forms.Label
    Friend WithEvents lblSenia As System.Windows.Forms.Label
    Friend WithEvents lblCheckIn As System.Windows.Forms.Label
    Friend WithEvents lblCheckOut As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroPasajeros As System.Windows.Forms.TextBox
    Friend WithEvents txtSenia As System.Windows.Forms.TextBox
    Friend WithEvents chkConSenia As System.Windows.Forms.CheckBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtIdHuesped As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarHuesped As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbIdCabania As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombreHuesped As System.Windows.Forms.TextBox
    Friend WithEvents lblServiciosAdicionales As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvServiciosAdicionales As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtCostoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoAdicionales As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoEstadia As System.Windows.Forms.TextBox
    Friend WithEvents lblCostoEstadia As System.Windows.Forms.Label
    Friend WithEvents lblCostoTotal As System.Windows.Forms.Label
    Friend WithEvents lblCostoAdicionales As System.Windows.Forms.Label
    Friend WithEvents chkCancelada As System.Windows.Forms.CheckBox
    Friend WithEvents lblReembolso As System.Windows.Forms.Label
    Friend WithEvents txtReembolso As System.Windows.Forms.TextBox
    Friend WithEvents lblReservaCancelada As System.Windows.Forms.Label
    Friend WithEvents btnConsultarCostos As System.Windows.Forms.Button
    Friend WithEvents dtpFechaReserva As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaReserva As System.Windows.Forms.Label
    Friend WithEvents lblImporteSenia As System.Windows.Forms.Label
    Friend WithEvents dtpFechaPagoSenia As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaSenia As System.Windows.Forms.Label
    Friend WithEvents lblFaltaPAgar As System.Windows.Forms.Label
    Friend WithEvents txtFaltaDePagar As System.Windows.Forms.TextBox
End Class
