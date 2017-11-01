<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelaciones
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
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.lblId = New System.Windows.Forms.Label
        Me.lblFechaCancelacion = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.dtpFechaCancelacion = New System.Windows.Forms.DateTimePicker
        Me.btnAceptarModificar = New System.Windows.Forms.Button
        Me.lblReembolso = New System.Windows.Forms.Label
        Me.txtReembolso = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(101, 229)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(200, 229)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(12, 9)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(19, 13)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "Id:"
        '
        'lblFechaCancelacion
        '
        Me.lblFechaCancelacion.AutoSize = True
        Me.lblFechaCancelacion.Location = New System.Drawing.Point(12, 48)
        Me.lblFechaCancelacion.Name = "lblFechaCancelacion"
        Me.lblFechaCancelacion.Size = New System.Drawing.Size(102, 13)
        Me.lblFechaCancelacion.TabIndex = 3
        Me.lblFechaCancelacion.Text = "Fecha Cancelacion:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 75)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(138, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(53, 20)
        Me.txtId.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(138, 72)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(188, 97)
        Me.txtDescripcion.TabIndex = 6
        '
        'dtpFechaCancelacion
        '
        Me.dtpFechaCancelacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCancelacion.Location = New System.Drawing.Point(139, 42)
        Me.dtpFechaCancelacion.Name = "dtpFechaCancelacion"
        Me.dtpFechaCancelacion.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaCancelacion.TabIndex = 7
        '
        'btnAceptarModificar
        '
        Me.btnAceptarModificar.Location = New System.Drawing.Point(154, 229)
        Me.btnAceptarModificar.Name = "btnAceptarModificar"
        Me.btnAceptarModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarModificar.TabIndex = 8
        Me.btnAceptarModificar.Text = "Aceptar"
        Me.btnAceptarModificar.UseVisualStyleBackColor = True
        '
        'lblReembolso
        '
        Me.lblReembolso.AutoSize = True
        Me.lblReembolso.Location = New System.Drawing.Point(12, 185)
        Me.lblReembolso.Name = "lblReembolso"
        Me.lblReembolso.Size = New System.Drawing.Size(63, 13)
        Me.lblReembolso.TabIndex = 9
        Me.lblReembolso.Text = "Reembolso:"
        '
        'txtReembolso
        '
        Me.txtReembolso.Location = New System.Drawing.Point(139, 182)
        Me.txtReembolso.Name = "txtReembolso"
        Me.txtReembolso.Size = New System.Drawing.Size(100, 20)
        Me.txtReembolso.TabIndex = 10
        '
        'frmCancelaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 264)
        Me.Controls.Add(Me.txtReembolso)
        Me.Controls.Add(Me.lblReembolso)
        Me.Controls.Add(Me.btnAceptarModificar)
        Me.Controls.Add(Me.dtpFechaCancelacion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFechaCancelacion)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCancelaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCancelaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblFechaCancelacion As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaCancelacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAceptarModificar As System.Windows.Forms.Button
    Friend WithEvents lblReembolso As System.Windows.Forms.Label
    Friend WithEvents txtReembolso As System.Windows.Forms.TextBox
End Class
