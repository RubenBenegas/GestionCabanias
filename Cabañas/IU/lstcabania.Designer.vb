<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstcabania
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lstcabania))
        Me.dgvCabanias = New System.Windows.Forms.DataGridView
        Me.BtnAlta = New System.Windows.Forms.Button
        Me.BtnModifica = New System.Windows.Forms.Button
        Me.BtnBaja = New System.Windows.Forms.Button
        Me.BtnCerrar = New System.Windows.Forms.Button
        CType(Me.dgvCabanias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCabanias
        '
        Me.dgvCabanias.AllowUserToAddRows = False
        Me.dgvCabanias.AllowUserToDeleteRows = False
        Me.dgvCabanias.AllowUserToResizeColumns = False
        Me.dgvCabanias.AllowUserToResizeRows = False
        Me.dgvCabanias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabanias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCabanias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCabanias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabanias.Location = New System.Drawing.Point(12, 12)
        Me.dgvCabanias.MultiSelect = False
        Me.dgvCabanias.Name = "dgvCabanias"
        Me.dgvCabanias.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCabanias.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCabanias.RowHeadersVisible = False
        Me.dgvCabanias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabanias.Size = New System.Drawing.Size(960, 410)
        Me.dgvCabanias.TabIndex = 0
        '
        'BtnAlta
        '
        Me.BtnAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlta.ForeColor = System.Drawing.Color.White
        Me.BtnAlta.Location = New System.Drawing.Point(12, 428)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(90, 30)
        Me.BtnAlta.TabIndex = 1
        Me.BtnAlta.Text = "Agregar"
        Me.BtnAlta.UseVisualStyleBackColor = False
        '
        'BtnModifica
        '
        Me.BtnModifica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnModifica.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifica.ForeColor = System.Drawing.Color.White
        Me.BtnModifica.Location = New System.Drawing.Point(108, 428)
        Me.BtnModifica.Name = "BtnModifica"
        Me.BtnModifica.Size = New System.Drawing.Size(90, 30)
        Me.BtnModifica.TabIndex = 2
        Me.BtnModifica.Text = "Modificar"
        Me.BtnModifica.UseVisualStyleBackColor = False
        '
        'BtnBaja
        '
        Me.BtnBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBaja.ForeColor = System.Drawing.Color.White
        Me.BtnBaja.Location = New System.Drawing.Point(204, 428)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(90, 30)
        Me.BtnBaja.TabIndex = 3
        Me.BtnBaja.Text = "Eliminar"
        Me.BtnBaja.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(822, 428)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(150, 30)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'lstcabania
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnBaja)
        Me.Controls.Add(Me.BtnModifica)
        Me.Controls.Add(Me.BtnAlta)
        Me.Controls.Add(Me.dgvCabanias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "lstcabania"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista cabañas"
        CType(Me.dgvCabanias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCabanias As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAlta As System.Windows.Forms.Button
    Friend WithEvents BtnModifica As System.Windows.Forms.Button
    Friend WithEvents BtnBaja As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
End Class
