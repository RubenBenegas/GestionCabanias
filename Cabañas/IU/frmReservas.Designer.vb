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
        Me.chkSinSenia = New System.Windows.Forms.CheckBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtIdHuesped = New System.Windows.Forms.TextBox
        Me.btnBuscarHuesped = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.cmbIdCabania = New System.Windows.Forms.ComboBox
        Me.txtNombreHuesped = New System.Windows.Forms.TextBox
        Me.dgvServiciosAdicionales = New System.Windows.Forms.DataGridView
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.lblServiciosAdicionales = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
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
        Me.lblIdHuesped.Location = New System.Drawing.Point(12, 43)
        Me.lblIdHuesped.Name = "lblIdHuesped"
        Me.lblIdHuesped.Size = New System.Drawing.Size(65, 13)
        Me.lblIdHuesped.TabIndex = 1
        Me.lblIdHuesped.Text = "Id Huesped:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(12, 77)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(78, 13)
        Me.lblFechaIngreso.TabIndex = 2
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'lblFechaSalidad
        '
        Me.lblFechaSalidad.AutoSize = True
        Me.lblFechaSalidad.Location = New System.Drawing.Point(12, 110)
        Me.lblFechaSalidad.Name = "lblFechaSalidad"
        Me.lblFechaSalidad.Size = New System.Drawing.Size(72, 13)
        Me.lblFechaSalidad.TabIndex = 3
        Me.lblFechaSalidad.Text = "Fecha Salida:"
        '
        'lblIdIdCabania
        '
        Me.lblIdIdCabania.AutoSize = True
        Me.lblIdIdCabania.Location = New System.Drawing.Point(12, 143)
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
        '
        'txtSenia
        '
        Me.txtSenia.Location = New System.Drawing.Point(381, 68)
        Me.txtSenia.Name = "txtSenia"
        Me.txtSenia.Size = New System.Drawing.Size(100, 20)
        Me.txtSenia.TabIndex = 5
        '
        'chkSinSenia
        '
        Me.chkSinSenia.AutoSize = True
        Me.chkSinSenia.Location = New System.Drawing.Point(381, 39)
        Me.chkSinSenia.Name = "chkSinSenia"
        Me.chkSinSenia.Size = New System.Drawing.Size(69, 17)
        Me.chkSinSenia.TabIndex = 6
        Me.chkSinSenia.Text = "Sin Seña"
        Me.chkSinSenia.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(214, 412)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(320, 412)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdHuesped
        '
        Me.txtIdHuesped.Enabled = False
        Me.txtIdHuesped.Location = New System.Drawing.Point(108, 40)
        Me.txtIdHuesped.Name = "txtIdHuesped"
        Me.txtIdHuesped.Size = New System.Drawing.Size(100, 20)
        Me.txtIdHuesped.TabIndex = 24
        '
        'btnBuscarHuesped
        '
        Me.btnBuscarHuesped.Location = New System.Drawing.Point(214, 38)
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(108, 77)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(108, 110)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(381, 99)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker3.TabIndex = 7
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(381, 132)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker4.TabIndex = 8
        '
        'cmbIdCabania
        '
        Me.cmbIdCabania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdCabania.FormattingEnabled = True
        Me.cmbIdCabania.Location = New System.Drawing.Point(108, 140)
        Me.cmbIdCabania.Name = "cmbIdCabania"
        Me.cmbIdCabania.Size = New System.Drawing.Size(100, 21)
        Me.cmbIdCabania.TabIndex = 3
        '
        'txtNombreHuesped
        '
        Me.txtNombreHuesped.Enabled = False
        Me.txtNombreHuesped.Location = New System.Drawing.Point(108, 40)
        Me.txtNombreHuesped.Name = "txtNombreHuesped"
        Me.txtNombreHuesped.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreHuesped.TabIndex = 0
        '
        'dgvServiciosAdicionales
        '
        Me.dgvServiciosAdicionales.AllowUserToAddRows = False
        Me.dgvServiciosAdicionales.AllowUserToDeleteRows = False
        Me.dgvServiciosAdicionales.AllowUserToResizeColumns = False
        Me.dgvServiciosAdicionales.AllowUserToResizeRows = False
        Me.dgvServiciosAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiciosAdicionales.Location = New System.Drawing.Point(12, 200)
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
        Me.btnAgregar.Location = New System.Drawing.Point(422, 200)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(422, 236)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 28
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblServiciosAdicionales
        '
        Me.lblServiciosAdicionales.AutoSize = True
        Me.lblServiciosAdicionales.Location = New System.Drawing.Point(12, 176)
        Me.lblServiciosAdicionales.Name = "lblServiciosAdicionales"
        Me.lblServiciosAdicionales.Size = New System.Drawing.Size(110, 13)
        Me.lblServiciosAdicionales.TabIndex = 29
        Me.lblServiciosAdicionales.Text = "Servicios Adicionales:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(417, 412)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        Me.btnSalir.Visible = False
        '
        'frmReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 447)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblServiciosAdicionales)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvServiciosAdicionales)
        Me.Controls.Add(Me.txtNombreHuesped)
        Me.Controls.Add(Me.cmbIdCabania)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnBuscarHuesped)
        Me.Controls.Add(Me.txtIdHuesped)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.chkSinSenia)
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
    Friend WithEvents chkSinSenia As System.Windows.Forms.CheckBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtIdHuesped As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarHuesped As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbIdCabania As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombreHuesped As System.Windows.Forms.TextBox
    Friend WithEvents lblServiciosAdicionales As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvServiciosAdicionales As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
