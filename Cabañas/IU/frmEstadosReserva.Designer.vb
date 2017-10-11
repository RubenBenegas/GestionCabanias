<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadosReserva
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
        Me.dtpFechaCancelacion = New System.Windows.Forms.DateTimePicker
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.rdCancelada = New System.Windows.Forms.RadioButton
        Me.rdSeniada = New System.Windows.Forms.RadioButton
        Me.rdEspera = New System.Windows.Forms.RadioButton
        Me.Cancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.rdEnCurso = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'dtpFechaCancelacion
        '
        Me.dtpFechaCancelacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCancelacion.Location = New System.Drawing.Point(163, 14)
        Me.dtpFechaCancelacion.Name = "dtpFechaCancelacion"
        Me.dtpFechaCancelacion.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaCancelacion.TabIndex = 9
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(163, 43)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(155, 118)
        Me.txtDescripcion.TabIndex = 8
        '
        'rdCancelada
        '
        Me.rdCancelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCancelada.Location = New System.Drawing.Point(29, 145)
        Me.rdCancelada.Name = "rdCancelada"
        Me.rdCancelada.Size = New System.Drawing.Size(111, 40)
        Me.rdCancelada.TabIndex = 7
        Me.rdCancelada.TabStop = True
        Me.rdCancelada.Text = "Cancelada"
        Me.rdCancelada.UseVisualStyleBackColor = True
        '
        'rdSeniada
        '
        Me.rdSeniada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSeniada.Location = New System.Drawing.Point(29, 58)
        Me.rdSeniada.Name = "rdSeniada"
        Me.rdSeniada.Size = New System.Drawing.Size(100, 40)
        Me.rdSeniada.TabIndex = 6
        Me.rdSeniada.TabStop = True
        Me.rdSeniada.Text = "Señada"
        Me.rdSeniada.UseVisualStyleBackColor = True
        '
        'rdEspera
        '
        Me.rdEspera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdEspera.Location = New System.Drawing.Point(29, 12)
        Me.rdEspera.Name = "rdEspera"
        Me.rdEspera.Size = New System.Drawing.Size(100, 40)
        Me.rdEspera.TabIndex = 5
        Me.rdEspera.TabStop = True
        Me.rdEspera.Text = "En espera"
        Me.rdEspera.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(243, 176)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 10
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(142, 176)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'rdEnCurso
        '
        Me.rdEnCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdEnCurso.Location = New System.Drawing.Point(29, 99)
        Me.rdEnCurso.Name = "rdEnCurso"
        Me.rdEnCurso.Size = New System.Drawing.Size(100, 40)
        Me.rdEnCurso.TabIndex = 12
        Me.rdEnCurso.TabStop = True
        Me.rdEnCurso.Text = "En curso"
        Me.rdEnCurso.UseVisualStyleBackColor = True
        '
        'frmEstadosReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 213)
        Me.Controls.Add(Me.rdEnCurso)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.dtpFechaCancelacion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.rdCancelada)
        Me.Controls.Add(Me.rdSeniada)
        Me.Controls.Add(Me.rdEspera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEstadosReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EstadosReserva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaCancelacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents rdCancelada As System.Windows.Forms.RadioButton
    Friend WithEvents rdSeniada As System.Windows.Forms.RadioButton
    Friend WithEvents rdEspera As System.Windows.Forms.RadioButton
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents rdEnCurso As System.Windows.Forms.RadioButton
End Class
