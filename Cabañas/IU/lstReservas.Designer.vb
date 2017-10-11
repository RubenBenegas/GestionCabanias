<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstReservas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lstReservas))
        Me.Cerrar = New System.Windows.Forms.Button
        Me.Eliminar = New System.Windows.Forms.Button
        Me.Modificar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.dgvReservas = New System.Windows.Forms.DataGridView
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cerrar
        '
        Me.Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cerrar.ForeColor = System.Drawing.Color.White
        Me.Cerrar.Location = New System.Drawing.Point(822, 428)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(150, 30)
        Me.Cerrar.TabIndex = 9
        Me.Cerrar.Text = "Cerrar"
        Me.Cerrar.UseVisualStyleBackColor = False
        '
        'Eliminar
        '
        Me.Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.ForeColor = System.Drawing.Color.White
        Me.Eliminar.Location = New System.Drawing.Point(204, 428)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(90, 30)
        Me.Eliminar.TabIndex = 8
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'Modificar
        '
        Me.Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.ForeColor = System.Drawing.Color.White
        Me.Modificar.Location = New System.Drawing.Point(108, 428)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(90, 30)
        Me.Modificar.TabIndex = 7
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(12, 428)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(90, 30)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvReservas
        '
        Me.dgvReservas.AllowUserToAddRows = False
        Me.dgvReservas.AllowUserToDeleteRows = False
        Me.dgvReservas.AllowUserToResizeColumns = False
        Me.dgvReservas.AllowUserToResizeRows = False
        Me.dgvReservas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReservas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservas.Location = New System.Drawing.Point(12, 12)
        Me.dgvReservas.MultiSelect = False
        Me.dgvReservas.Name = "dgvReservas"
        Me.dgvReservas.ReadOnly = True
        Me.dgvReservas.RowHeadersVisible = False
        Me.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservas.Size = New System.Drawing.Size(960, 410)
        Me.dgvReservas.TabIndex = 5
        '
        'lstReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvReservas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lstReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lstReservas"
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cerrar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvReservas As System.Windows.Forms.DataGridView
End Class
