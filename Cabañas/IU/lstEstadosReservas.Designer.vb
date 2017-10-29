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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lstEstadosReservas))
        Me.dgvEstadoReservas = New System.Windows.Forms.DataGridView
        Me.rbEnEspera = New System.Windows.Forms.RadioButton
        Me.rbSeniada = New System.Windows.Forms.RadioButton
        Me.rbCancelada = New System.Windows.Forms.RadioButton
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.rdEnCurso = New System.Windows.Forms.RadioButton
        Me.btnTodos = New System.Windows.Forms.Button
        Me.rdSinSenia = New System.Windows.Forms.RadioButton
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape1 = New Cabañas.BotonCerrar
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
        Me.dgvEstadoReservas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEstadoReservas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEstadoReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstadoReservas.Location = New System.Drawing.Point(13, 44)
        Me.dgvEstadoReservas.MultiSelect = False
        Me.dgvEstadoReservas.Name = "dgvEstadoReservas"
        Me.dgvEstadoReservas.ReadOnly = True
        Me.dgvEstadoReservas.RowHeadersVisible = False
        Me.dgvEstadoReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstadoReservas.Size = New System.Drawing.Size(1032, 258)
        Me.dgvEstadoReservas.TabIndex = 0
        '
        'rbEnEspera
        '
        Me.rbEnEspera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbEnEspera.AutoSize = True
        Me.rbEnEspera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEnEspera.Location = New System.Drawing.Point(146, 15)
        Me.rbEnEspera.Name = "rbEnEspera"
        Me.rbEnEspera.Size = New System.Drawing.Size(82, 17)
        Me.rbEnEspera.TabIndex = 2
        Me.rbEnEspera.TabStop = True
        Me.rbEnEspera.Text = "En espera"
        Me.rbEnEspera.UseVisualStyleBackColor = True
        '
        'rbSeniada
        '
        Me.rbSeniada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbSeniada.AutoSize = True
        Me.rbSeniada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSeniada.Location = New System.Drawing.Point(312, 15)
        Me.rbSeniada.Name = "rbSeniada"
        Me.rbSeniada.Size = New System.Drawing.Size(68, 17)
        Me.rbSeniada.TabIndex = 3
        Me.rbSeniada.TabStop = True
        Me.rbSeniada.Text = "Señada"
        Me.rbSeniada.UseVisualStyleBackColor = True
        '
        'rbCancelada
        '
        Me.rbCancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbCancelada.AutoSize = True
        Me.rbCancelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCancelada.Location = New System.Drawing.Point(461, 15)
        Me.rbCancelada.Name = "rbCancelada"
        Me.rbCancelada.Size = New System.Drawing.Size(85, 17)
        Me.rbCancelada.TabIndex = 4
        Me.rbCancelada.TabStop = True
        Me.rbCancelada.Text = "Cancelada"
        Me.rbCancelada.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(12, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 30)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'rdEnCurso
        '
        Me.rdEnCurso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdEnCurso.AutoSize = True
        Me.rdEnCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdEnCurso.Location = New System.Drawing.Point(380, 15)
        Me.rdEnCurso.Name = "rdEnCurso"
        Me.rdEnCurso.Size = New System.Drawing.Size(75, 17)
        Me.rdEnCurso.TabIndex = 6
        Me.rdEnCurso.TabStop = True
        Me.rdEnCurso.Text = "En curso"
        Me.rdEnCurso.UseVisualStyleBackColor = True
        '
        'btnTodos
        '
        Me.btnTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodos.ForeColor = System.Drawing.Color.White
        Me.btnTodos.Location = New System.Drawing.Point(93, 8)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(47, 30)
        Me.btnTodos.TabIndex = 8
        Me.btnTodos.Text = "X"
        Me.btnTodos.UseVisualStyleBackColor = False
        '
        'rdSinSenia
        '
        Me.rdSinSenia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdSinSenia.AutoSize = True
        Me.rdSinSenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSinSenia.Location = New System.Drawing.Point(234, 15)
        Me.rdSinSenia.Name = "rdSinSenia"
        Me.rdSinSenia.Size = New System.Drawing.Size(74, 17)
        Me.rdSinSenia.TabIndex = 9
        Me.rdSinSenia.TabStop = True
        Me.rdSinSenia.Text = "Sin seña"
        Me.rdSinSenia.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1056, 343)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = CType(resources.GetObject("RectangleShape1.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.CornerRadius = 17
        Me.RectangleShape1.Location = New System.Drawing.Point(913, 304)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(122, 35)
        '
        'lstEstadosReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1056, 343)
        Me.Controls.Add(Me.rdSinSenia)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.rdEnCurso)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.rbCancelada)
        Me.Controls.Add(Me.rbSeniada)
        Me.Controls.Add(Me.rbEnEspera)
        Me.Controls.Add(Me.dgvEstadoReservas)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "lstEstadosReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lstEstadosReservas"
        CType(Me.dgvEstadoReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEstadoReservas As System.Windows.Forms.DataGridView
    Friend WithEvents rbEnEspera As System.Windows.Forms.RadioButton
    Friend WithEvents rbSeniada As System.Windows.Forms.RadioButton
    Friend WithEvents rbCancelada As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents rdEnCurso As System.Windows.Forms.RadioButton
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents rdSinSenia As System.Windows.Forms.RadioButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Cabañas.BotonCerrar
End Class
