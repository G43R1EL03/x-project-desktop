<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuReportes
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventarioGlobalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelTablaReportes = New System.Windows.Forms.Panel()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.panelTablaReportes.SuspendLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioGlobalToolStripMenuItem, Me.ReporteDeClientesToolStripMenuItem, Me.ReporteDeVentasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventarioGlobalToolStripMenuItem
        '
        Me.InventarioGlobalToolStripMenuItem.Name = "InventarioGlobalToolStripMenuItem"
        Me.InventarioGlobalToolStripMenuItem.Size = New System.Drawing.Size(169, 20)
        Me.InventarioGlobalToolStripMenuItem.Text = "Reporte de Inventario Global"
        '
        'ReporteDeClientesToolStripMenuItem
        '
        Me.ReporteDeClientesToolStripMenuItem.Name = "ReporteDeClientesToolStripMenuItem"
        Me.ReporteDeClientesToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.ReporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes"
        '
        'ReporteDeVentasToolStripMenuItem
        '
        Me.ReporteDeVentasToolStripMenuItem.Name = "ReporteDeVentasToolStripMenuItem"
        Me.ReporteDeVentasToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ReporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas"
        '
        'panelTablaReportes
        '
        Me.panelTablaReportes.Controls.Add(Me.dgvInventario)
        Me.panelTablaReportes.Location = New System.Drawing.Point(0, 44)
        Me.panelTablaReportes.Name = "panelTablaReportes"
        Me.panelTablaReportes.Size = New System.Drawing.Size(800, 405)
        Me.panelTablaReportes.TabIndex = 2
        '
        'dgvInventario
        '
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(12, 11)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.Size = New System.Drawing.Size(776, 383)
        Me.dgvInventario.TabIndex = 0
        '
        'frmMenuReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelTablaReportes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuReportes"
        Me.Text = "frmReportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelTablaReportes.ResumeLayout(False)
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarioGlobalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelTablaReportes As Panel
    Friend WithEvents dgvInventario As DataGridView
End Class
