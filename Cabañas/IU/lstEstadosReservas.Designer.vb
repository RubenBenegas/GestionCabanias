<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstEstadosReservas
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
        Me.dgvEstadoReservas = New System.Windows.Forms.DataGridView
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.rbEnEspera = New System.Windows.Forms.RadioButton
        Me.rbSeñada = New System.Windows.Forms.RadioButton
        Me.rbCancelada = New System.Windows.Forms.RadioButton
        CType(Me.dgvEstadoReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEstadoReservas
        '
        Me.dgvEstadoReservas.AllowUserToAddRows = False
        Me.dgvEstadoReservas.AllowUserToDeleteRows = False
        Me.dgvEstadoReservas.AllowUserToOrderColumns = True
        Me.dgvEstadoReservas.AllowUserToResizeColumns = False
        Me.dgvEstadoReservas.AllowUserToResizeRows = False
        Me.dgvEstadoReservas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEstadoReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstadoReservas.Location = New System.Drawing.Point(12, 12)
        Me.dgvEstadoReservas.MultiSelect = False
        Me.dgvEstadoReservas.Name = "dgvEstadoReservas"
        Me.dgvEstadoReservas.ReadOnly = True
        Me.dgvEstadoReservas.RowHeadersVisible = False
        Me.dgvEstadoReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstadoReservas.Size = New System.Drawing.Size(640, 280)
        Me.dgvEstadoReservas.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(577, 308)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'rbEnEspera
        '
        Me.rbEnEspera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbEnEspera.AutoSize = True
        Me.rbEnEspera.Location = New System.Drawing.Point(12, 311)
        Me.rbEnEspera.Name = "rbEnEspera"
        Me.rbEnEspera.Size = New System.Drawing.Size(73, 17)
        Me.rbEnEspera.TabIndex = 2
        Me.rbEnEspera.TabStop = True
        Me.rbEnEspera.Text = "En espera"
        Me.rbEnEspera.UseVisualStyleBackColor = True
        '
        'rbSeñada
        '
        Me.rbSeñada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbSeñada.AutoSize = True
        Me.rbSeñada.Location = New System.Drawing.Point(156, 311)
        Me.rbSeñada.Name = "rbSeñada"
        Me.rbSeñada.Size = New System.Drawing.Size(62, 17)
        Me.rbSeñada.TabIndex = 3
        Me.rbSeñada.TabStop = True
        Me.rbSeñada.Text = "Señada"
        Me.rbSeñada.UseVisualStyleBackColor = True
        '
        'rbCancelada
        '
        Me.rbCancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbCancelada.AutoSize = True
        Me.rbCancelada.Location = New System.Drawing.Point(306, 311)
        Me.rbCancelada.Name = "rbCancelada"
        Me.rbCancelada.Size = New System.Drawing.Size(76, 17)
        Me.rbCancelada.TabIndex = 4
        Me.rbCancelada.TabStop = True
        Me.rbCancelada.Text = "Cancelada"
        Me.rbCancelada.UseVisualStyleBackColor = True
        '
        'lstEstadosReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(664, 343)
        Me.Controls.Add(Me.rbCancelada)
        Me.Controls.Add(Me.rbSeñada)
        Me.Controls.Add(Me.rbEnEspera)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dgvEstadoReservas)
        Me.Name = "lstEstadosReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lstEstadosReservas"
        CType(Me.dgvEstadoReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEstadoReservas As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents rbEnEspera As System.Windows.Forms.RadioButton
    Friend WithEvents rbSeñada As System.Windows.Forms.RadioButton
    Friend WithEvents rbCancelada As System.Windows.Forms.RadioButton
End Class
