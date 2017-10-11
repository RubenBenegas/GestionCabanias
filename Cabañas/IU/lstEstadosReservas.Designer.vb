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
        Me.rbSeniada = New System.Windows.Forms.RadioButton
        Me.rbCancelada = New System.Windows.Forms.RadioButton
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.rdEnCurso = New System.Windows.Forms.RadioButton
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
        Me.dgvEstadoReservas.Size = New System.Drawing.Size(1032, 280)
        Me.dgvEstadoReservas.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(969, 308)
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
        Me.rbEnEspera.Location = New System.Drawing.Point(93, 314)
        Me.rbEnEspera.Name = "rbEnEspera"
        Me.rbEnEspera.Size = New System.Drawing.Size(73, 17)
        Me.rbEnEspera.TabIndex = 2
        Me.rbEnEspera.TabStop = True
        Me.rbEnEspera.Text = "En espera"
        Me.rbEnEspera.UseVisualStyleBackColor = True
        '
        'rbSeniada
        '
        Me.rbSeniada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbSeniada.AutoSize = True
        Me.rbSeniada.Location = New System.Drawing.Point(172, 314)
        Me.rbSeniada.Name = "rbSeniada"
        Me.rbSeniada.Size = New System.Drawing.Size(62, 17)
        Me.rbSeniada.TabIndex = 3
        Me.rbSeniada.TabStop = True
        Me.rbSeniada.Text = "Señada"
        Me.rbSeniada.UseVisualStyleBackColor = True
        '
        'rbCancelada
        '
        Me.rbCancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbCancelada.AutoSize = True
        Me.rbCancelada.Location = New System.Drawing.Point(313, 314)
        Me.rbCancelada.Name = "rbCancelada"
        Me.rbCancelada.Size = New System.Drawing.Size(76, 17)
        Me.rbCancelada.TabIndex = 4
        Me.rbCancelada.TabStop = True
        Me.rbCancelada.Text = "Cancelada"
        Me.rbCancelada.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Location = New System.Drawing.Point(12, 308)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'rdEnCurso
        '
        Me.rdEnCurso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdEnCurso.AutoSize = True
        Me.rdEnCurso.Location = New System.Drawing.Point(240, 314)
        Me.rdEnCurso.Name = "rdEnCurso"
        Me.rdEnCurso.Size = New System.Drawing.Size(67, 17)
        Me.rdEnCurso.TabIndex = 6
        Me.rdEnCurso.TabStop = True
        Me.rdEnCurso.Text = "En curso"
        Me.rdEnCurso.UseVisualStyleBackColor = True
        '
        'lstEstadosReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1056, 343)
        Me.Controls.Add(Me.rdEnCurso)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.rbCancelada)
        Me.Controls.Add(Me.rbSeniada)
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
    Friend WithEvents rbSeniada As System.Windows.Forms.RadioButton
    Friend WithEvents rbCancelada As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents rdEnCurso As System.Windows.Forms.RadioButton
End Class
