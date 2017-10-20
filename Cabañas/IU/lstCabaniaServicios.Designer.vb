<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstCabaniaServicios
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
        Me.Aceptarbtn = New System.Windows.Forms.Button
        Me.Cancelarbtn = New System.Windows.Forms.Button
        Me.dgvCabaniaServicios = New System.Windows.Forms.DataGridView
        CType(Me.dgvCabaniaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Aceptarbtn
        '
        Me.Aceptarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Aceptarbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Aceptarbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Aceptarbtn.Location = New System.Drawing.Point(148, 320)
        Me.Aceptarbtn.Name = "Aceptarbtn"
        Me.Aceptarbtn.Size = New System.Drawing.Size(90, 30)
        Me.Aceptarbtn.TabIndex = 1
        Me.Aceptarbtn.Text = "Aceptar"
        Me.Aceptarbtn.UseVisualStyleBackColor = False
        '
        'Cancelarbtn
        '
        Me.Cancelarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cancelarbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancelarbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cancelarbtn.Location = New System.Drawing.Point(244, 320)
        Me.Cancelarbtn.Name = "Cancelarbtn"
        Me.Cancelarbtn.Size = New System.Drawing.Size(90, 30)
        Me.Cancelarbtn.TabIndex = 2
        Me.Cancelarbtn.Text = "Cancelar"
        Me.Cancelarbtn.UseVisualStyleBackColor = False
        '
        'dgvCabaniaServicios
        '
        Me.dgvCabaniaServicios.AllowUserToAddRows = False
        Me.dgvCabaniaServicios.AllowUserToDeleteRows = False
        Me.dgvCabaniaServicios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.dgvCabaniaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabaniaServicios.Location = New System.Drawing.Point(12, 12)
        Me.dgvCabaniaServicios.MultiSelect = False
        Me.dgvCabaniaServicios.Name = "dgvCabaniaServicios"
        Me.dgvCabaniaServicios.ReadOnly = True
        Me.dgvCabaniaServicios.RowHeadersVisible = False
        Me.dgvCabaniaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabaniaServicios.Size = New System.Drawing.Size(342, 289)
        Me.dgvCabaniaServicios.TabIndex = 0
        '
        'lstCabaniaServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 362)
        Me.Controls.Add(Me.dgvCabaniaServicios)
        Me.Controls.Add(Me.Cancelarbtn)
        Me.Controls.Add(Me.Aceptarbtn)
        Me.Name = "lstCabaniaServicios"
        Me.Text = "CabaniaServicios"
        CType(Me.dgvCabaniaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Aceptarbtn As System.Windows.Forms.Button
    Friend WithEvents Cancelarbtn As System.Windows.Forms.Button
    Friend WithEvents dgvCabaniaServicios As System.Windows.Forms.DataGridView
End Class
