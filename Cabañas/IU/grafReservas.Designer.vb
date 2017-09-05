<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grafReservas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grafReservas))
        Me.flpContenedor = New System.Windows.Forms.FlowLayoutPanel
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'flpContenedor
        '
        Me.flpContenedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpContenedor.AutoScroll = True
        Me.flpContenedor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpContenedor.Location = New System.Drawing.Point(12, 12)
        Me.flpContenedor.Name = "flpContenedor"
        Me.flpContenedor.Size = New System.Drawing.Size(595, 458)
        Me.flpContenedor.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(15, 485)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(149, 34)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar nueva reserva"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'grafReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 531)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.flpContenedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "grafReservas"
        Me.Text = "grafReservas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flpContenedor As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
