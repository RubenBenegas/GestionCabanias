<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstReservasAdicionales
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
        Me.dgvAdicionales = New System.Windows.Forms.DataGridView
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        CType(Me.dgvAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAdicionales
        '
        Me.dgvAdicionales.AllowUserToAddRows = False
        Me.dgvAdicionales.AllowUserToDeleteRows = False
        Me.dgvAdicionales.AllowUserToResizeColumns = False
        Me.dgvAdicionales.AllowUserToResizeRows = False
        Me.dgvAdicionales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAdicionales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.dgvAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdicionales.Location = New System.Drawing.Point(12, 12)
        Me.dgvAdicionales.MultiSelect = False
        Me.dgvAdicionales.Name = "dgvAdicionales"
        Me.dgvAdicionales.ReadOnly = True
        Me.dgvAdicionales.RowHeadersVisible = False
        Me.dgvAdicionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdicionales.Size = New System.Drawing.Size(331, 413)
        Me.dgvAdicionales.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(176, 430)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 31)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(267, 430)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 31)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lstReservasAdicionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(356, 464)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvAdicionales)
        Me.Name = "lstReservasAdicionales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lstReservasAdicionales"
        CType(Me.dgvAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAdicionales As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
