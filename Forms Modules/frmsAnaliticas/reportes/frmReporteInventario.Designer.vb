Imports FontAwesome.Sharp

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteInventario))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxMarcas = New System.Windows.Forms.ComboBox()
        Me.cboxCategorias = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.dgvInventarioReporte = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCantCategorias = New System.Windows.Forms.Label()
        Me.lblCantMarcas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCantProductos = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AnaliticaReporteInventarioDAOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvInventarioReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnaliticaReporteInventarioDAOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'cboxMarcas
        '
        resources.ApplyResources(Me.cboxMarcas, "cboxMarcas")
        Me.cboxMarcas.FormattingEnabled = True
        Me.cboxMarcas.Name = "cboxMarcas"
        '
        'cboxCategorias
        '
        resources.ApplyResources(Me.cboxCategorias, "cboxCategorias")
        Me.cboxCategorias.FormattingEnabled = True
        Me.cboxCategorias.Name = "cboxCategorias"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(231, Byte), Integer))
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(231, Byte), Integer))
        resources.ApplyResources(Me.btnExportarExcel, "btnExportarExcel")
        Me.btnExportarExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.UseVisualStyleBackColor = False
        '
        'dgvInventarioReporte
        '
        Me.dgvInventarioReporte.AllowUserToAddRows = False
        Me.dgvInventarioReporte.AllowUserToDeleteRows = False
        Me.dgvInventarioReporte.AllowUserToResizeColumns = False
        Me.dgvInventarioReporte.AllowUserToResizeRows = False
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventarioReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvInventarioReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventarioReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvInventarioReporte.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dgvInventarioReporte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInventarioReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvInventarioReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventarioReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvInventarioReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventarioReporte.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvInventarioReporte.EnableHeadersVisualStyles = False
        resources.ApplyResources(Me.dgvInventarioReporte, "dgvInventarioReporte")
        Me.dgvInventarioReporte.Name = "dgvInventarioReporte"
        Me.dgvInventarioReporte.ReadOnly = True
        Me.dgvInventarioReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventarioReporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvInventarioReporte.RowHeadersVisible = False
        Me.dgvInventarioReporte.TabStop = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label8.Name = "Label8"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'lblCantCategorias
        '
        resources.ApplyResources(Me.lblCantCategorias, "lblCantCategorias")
        Me.lblCantCategorias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblCantCategorias.Name = "lblCantCategorias"
        '
        'lblCantMarcas
        '
        resources.ApplyResources(Me.lblCantMarcas, "lblCantMarcas")
        Me.lblCantMarcas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblCantMarcas.Name = "lblCantMarcas"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'lblCantProductos
        '
        resources.ApplyResources(Me.lblCantProductos, "lblCantProductos")
        Me.lblCantProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblCantProductos.Name = "lblCantProductos"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label6.Name = "Label6"
        '
        'AnaliticaReporteInventarioDAOBindingSource
        '
        Me.AnaliticaReporteInventarioDAOBindingSource.DataSource = GetType(x_project_desktop.analiticaReporteInventarioDAO)
        '
        'frmReporteInventario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.lblCantCategorias)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCantMarcas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCantProductos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvInventarioReporte)
        Me.Controls.Add(Me.cboxCategorias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboxMarcas)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmReporteInventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInventarioReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnaliticaReporteInventarioDAOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cboxMarcas As ComboBox
    Friend WithEvents cboxCategorias As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExportarExcel As Button
    Friend WithEvents AnaliticaReporteInventarioDAOBindingSource As BindingSource
    Friend WithEvents dgvInventarioReporte As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCantCategorias As Label
    Friend WithEvents lblCantMarcas As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCantProductos As Label
    Friend WithEvents Label6 As Label
End Class
