<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalitica
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.panelModulo5 = New System.Windows.Forms.Panel()
        Me.IconDropDownButton1 = New FontAwesome.Sharp.IconDropDownButton()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnaliticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.IconDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(128, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "Visualizar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel1.Text = "Visualizar"
        '
        'panelModulo5
        '
        Me.panelModulo5.Location = New System.Drawing.Point(1, 45)
        Me.panelModulo5.Name = "panelModulo5"
        Me.panelModulo5.Size = New System.Drawing.Size(798, 405)
        Me.panelModulo5.TabIndex = 1
        '
        'IconDropDownButton1
        '
        Me.IconDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IconDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem, Me.AnaliticasToolStripMenuItem})
        Me.IconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconDropDownButton1.IconColor = System.Drawing.Color.Black
        Me.IconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IconDropDownButton1.Name = "IconDropDownButton1"
        Me.IconDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.IconDropDownButton1.Text = "IconDropDownButton1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'AnaliticasToolStripMenuItem
        '
        Me.AnaliticasToolStripMenuItem.Name = "AnaliticasToolStripMenuItem"
        Me.AnaliticasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AnaliticasToolStripMenuItem.Text = "Analiticas"
        '
        'frmAnalitica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelModulo5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmAnalitica"
        Me.Text = "frmAnalitica"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents IconDropDownButton1 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnaliticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelModulo5 As Panel
End Class
