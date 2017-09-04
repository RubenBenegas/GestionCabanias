<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstAdicional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lstAdicional))
        Me.DgvAdicionales = New System.Windows.Forms.DataGridView
        Me.BtnCerrar = New System.Windows.Forms.Button
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.BtnModificar = New System.Windows.Forms.Button
        Me.BtnAgregar = New System.Windows.Forms.Button
        CType(Me.DgvAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvAdicionales
        '
        Me.DgvAdicionales.AllowUserToAddRows = False
        Me.DgvAdicionales.AllowUserToDeleteRows = False
        Me.DgvAdicionales.AllowUserToResizeColumns = False
        Me.DgvAdicionales.AllowUserToResizeRows = False
        Me.DgvAdicionales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAdicionales.Location = New System.Drawing.Point(10, 8)
        Me.DgvAdicionales.MultiSelect = False
        Me.DgvAdicionales.Name = "DgvAdicionales"
        Me.DgvAdicionales.ReadOnly = True
        Me.DgvAdicionales.RowHeadersVisible = False
        Me.DgvAdicionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAdicionales.Size = New System.Drawing.Size(960, 410)
        Me.DgvAdicionales.TabIndex = 0
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Location = New System.Drawing.Point(820, 424)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(150, 30)
        Me.BtnCerrar.TabIndex = 8
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.Location = New System.Drawing.Point(202, 424)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(90, 30)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnModificar.Location = New System.Drawing.Point(106, 424)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(90, 30)
        Me.BtnModificar.TabIndex = 6
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregar.Location = New System.Drawing.Point(10, 424)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(90, 30)
        Me.BtnAgregar.TabIndex = 5
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'lstAdicional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DgvAdicionales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lstAdicional"
        Me.Text = "lstAdicionales"
        CType(Me.DgvAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvAdicionales As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
End Class
