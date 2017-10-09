<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedor
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
        Me.Id = New System.Windows.Forms.Label
        Me.Tipo = New System.Windows.Forms.Label
        Me.Nombre = New System.Windows.Forms.Label
        Me.Telefono = New System.Windows.Forms.Label
        Me.Direccion = New System.Windows.Forms.Label
        Me.Aceptar = New System.Windows.Forms.Button
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtTipo = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.Cancelar = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.BackColor = System.Drawing.Color.Transparent
        Me.Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.Location = New System.Drawing.Point(12, 9)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(22, 13)
        Me.Id.TabIndex = 0
        Me.Id.Text = "Id:"
        '
        'Tipo
        '
        Me.Tipo.AutoSize = True
        Me.Tipo.BackColor = System.Drawing.Color.Transparent
        Me.Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.Location = New System.Drawing.Point(12, 35)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(36, 13)
        Me.Tipo.TabIndex = 1
        Me.Tipo.Text = "Tipo:"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.BackColor = System.Drawing.Color.Transparent
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(12, 61)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(54, 13)
        Me.Nombre.TabIndex = 2
        Me.Nombre.Text = "Nombre:"
        '
        'Telefono
        '
        Me.Telefono.AutoSize = True
        Me.Telefono.BackColor = System.Drawing.Color.Transparent
        Me.Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono.Location = New System.Drawing.Point(12, 87)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(61, 13)
        Me.Telefono.TabIndex = 3
        Me.Telefono.Text = "Telefono:"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.BackColor = System.Drawing.Color.Transparent
        Me.Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.Location = New System.Drawing.Point(12, 113)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(65, 13)
        Me.Direccion.TabIndex = 4
        Me.Direccion.Text = "Direccion:"
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(71, 140)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 5
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(93, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(39, 20)
        Me.txtId.TabIndex = 0
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(93, 32)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(114, 20)
        Me.txtTipo.TabIndex = 1
        Me.txtTipo.Tag = "*"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(93, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(145, 20)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Tag = "*"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(93, 84)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(103, 20)
        Me.txtTelefono.TabIndex = 3
        Me.txtTelefono.Tag = "*"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(93, 110)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(145, 20)
        Me.txtDireccion.TabIndex = 4
        Me.txtDireccion.Tag = "*"
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(163, 140)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 6
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(269, 175)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Tipo)
        Me.Controls.Add(Me.Id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProveedor"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Id As System.Windows.Forms.Label
    Friend WithEvents Tipo As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents Telefono As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.Label
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
