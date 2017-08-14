<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.CabañasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HuespedesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TipoCabaniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.SalirToolStripMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1362, 23)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CabañasToolStripMenuItem, Me.HuespedesToolStripMenuItem, Me.PersonalToolStripMenuItem, Me.InsumosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.TipoCabaniaToolStripMenuItem, Me.ReservasToolStripMenuItem})
        Me.FileMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FileMenu.ForeColor = System.Drawing.Color.Black
        Me.FileMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(84, 19)
        Me.FileMenu.Text = "Formularios"
        '
        'CabañasToolStripMenuItem
        '
        Me.CabañasToolStripMenuItem.AutoSize = False
        Me.CabañasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CabañasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CabañasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CabañasToolStripMenuItem.Name = "CabañasToolStripMenuItem"
        Me.CabañasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CabañasToolStripMenuItem.Text = "Cabañas"
        '
        'HuespedesToolStripMenuItem
        '
        Me.HuespedesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HuespedesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HuespedesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HuespedesToolStripMenuItem.Name = "HuespedesToolStripMenuItem"
        Me.HuespedesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HuespedesToolStripMenuItem.Text = "Huespedes"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PersonalToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PersonalToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'InsumosToolStripMenuItem
        '
        Me.InsumosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.InsumosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.InsumosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        Me.InsumosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InsumosToolStripMenuItem.Text = "Gastos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProveedoresToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'TipoCabaniaToolStripMenuItem
        '
        Me.TipoCabaniaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TipoCabaniaToolStripMenuItem.Name = "TipoCabaniaToolStripMenuItem"
        Me.TipoCabaniaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TipoCabaniaToolStripMenuItem.Text = "TipoCabania"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(43, 19)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Cabañas.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents HuespedesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CabañasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoCabaniaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
