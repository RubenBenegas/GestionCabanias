<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCabania
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
        Me.txtIdCabania = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtAceptar = New System.Windows.Forms.Button
        Me.ButtCancelar = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbTipoCabania = New System.Windows.Forms.ComboBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.dgvCabaniaServicios = New System.Windows.Forms.DataGridView
        Me.Agregarbtn = New System.Windows.Forms.Button
        Me.Eliminarbtn = New System.Windows.Forms.Button
        Me.Servicios = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCabaniaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdCabania
        '
        Me.txtIdCabania.Enabled = False
        Me.txtIdCabania.Location = New System.Drawing.Point(131, 6)
        Me.txtIdCabania.Name = "txtIdCabania"
        Me.txtIdCabania.Size = New System.Drawing.Size(55, 20)
        Me.txtIdCabania.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo Cabaña:"
        '
        'ButtAceptar
        '
        Me.ButtAceptar.Location = New System.Drawing.Point(111, 428)
        Me.ButtAceptar.Name = "ButtAceptar"
        Me.ButtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtAceptar.TabIndex = 3
        Me.ButtAceptar.Text = "Aceptar"
        Me.ButtAceptar.UseVisualStyleBackColor = True
        '
        'ButtCancelar
        '
        Me.ButtCancelar.Location = New System.Drawing.Point(223, 428)
        Me.ButtCancelar.Name = "ButtCancelar"
        Me.ButtCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtCancelar.TabIndex = 4
        Me.ButtCancelar.Text = "Cancelar"
        Me.ButtCancelar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmbTipoCabania
        '
        Me.cmbTipoCabania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCabania.FormattingEnabled = True
        Me.cmbTipoCabania.Location = New System.Drawing.Point(131, 31)
        Me.cmbTipoCabania.Name = "cmbTipoCabania"
        Me.cmbTipoCabania.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoCabania.TabIndex = 8
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.Color.Transparent
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(12, 61)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(46, 13)
        Me.lblMonto.TabIndex = 9
        Me.lblMonto.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(131, 59)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 10
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 88)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(78, 13)
        Me.lblDescripcion.TabIndex = 11
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(131, 85)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(167, 91)
        Me.txtDescripcion.TabIndex = 12
        '
        'dgvCabaniaServicios
        '
        Me.dgvCabaniaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabaniaServicios.Location = New System.Drawing.Point(15, 231)
        Me.dgvCabaniaServicios.Name = "dgvCabaniaServicios"
        Me.dgvCabaniaServicios.Size = New System.Drawing.Size(340, 180)
        Me.dgvCabaniaServicios.TabIndex = 13
        '
        'Agregarbtn
        '
        Me.Agregarbtn.Location = New System.Drawing.Point(377, 245)
        Me.Agregarbtn.Name = "Agregarbtn"
        Me.Agregarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Agregarbtn.TabIndex = 14
        Me.Agregarbtn.Text = "Agregar"
        Me.Agregarbtn.UseVisualStyleBackColor = True
        '
        'Eliminarbtn
        '
        Me.Eliminarbtn.Location = New System.Drawing.Point(377, 297)
        Me.Eliminarbtn.Name = "Eliminarbtn"
        Me.Eliminarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Eliminarbtn.TabIndex = 15
        Me.Eliminarbtn.Text = "Eliminar"
        Me.Eliminarbtn.UseVisualStyleBackColor = True
        '
        'Servicios
        '
        Me.Servicios.AutoSize = True
        Me.Servicios.Location = New System.Drawing.Point(21, 202)
        Me.Servicios.Name = "Servicios"
        Me.Servicios.Size = New System.Drawing.Size(50, 13)
        Me.Servicios.TabIndex = 16
        Me.Servicios.Text = "Servicios"
        '
        'frmCabania
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(481, 463)
        Me.Controls.Add(Me.Servicios)
        Me.Controls.Add(Me.Eliminarbtn)
        Me.Controls.Add(Me.Agregarbtn)
        Me.Controls.Add(Me.dgvCabaniaServicios)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.cmbTipoCabania)
        Me.Controls.Add(Me.ButtCancelar)
        Me.Controls.Add(Me.ButtAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdCabania)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCabania"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CabaniaForm"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCabaniaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdCabania As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtAceptar As System.Windows.Forms.Button
    Friend WithEvents ButtCancelar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbTipoCabania As System.Windows.Forms.ComboBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Servicios As System.Windows.Forms.Label
    Friend WithEvents Eliminarbtn As System.Windows.Forms.Button
    Friend WithEvents Agregarbtn As System.Windows.Forms.Button
    Friend WithEvents dgvCabaniaServicios As System.Windows.Forms.DataGridView
End Class
