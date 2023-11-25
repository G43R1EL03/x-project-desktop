<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pan = New System.Windows.Forms.Panel()
        Me.panelSplitButonOpciones = New System.Windows.Forms.Panel()
        Me.btnMarca = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnRealizarCompra = New System.Windows.Forms.Button()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.panelTodo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan.SuspendLayout()
        Me.panelSplitButonOpciones.SuspendLayout()
        Me.panelTodo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventario"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(20, 20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(15, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1330, 709)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1322, 676)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregar.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(300, 35)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 15)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 41)
        Me.TextBox1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 5)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1276, 498)
        Me.DataGridView1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(1272, 597)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entradas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pan
        '
        Me.pan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pan.Controls.Add(Me.Panel7)
        Me.pan.Controls.Add(Me.Panel6)
        Me.pan.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan.Location = New System.Drawing.Point(0, 0)
        Me.pan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(1314, 77)
        Me.pan.TabIndex = 4
        '
        'panelSplitButonOpciones
        '
        Me.panelSplitButonOpciones.Controls.Add(Me.btnRealizarCompra)
        Me.panelSplitButonOpciones.Controls.Add(Me.btnCategoria)
        Me.panelSplitButonOpciones.Controls.Add(Me.btnProducto)
        Me.panelSplitButonOpciones.Controls.Add(Me.btnMarca)
        Me.panelSplitButonOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSplitButonOpciones.Location = New System.Drawing.Point(0, 35)
        Me.panelSplitButonOpciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelSplitButonOpciones.Name = "panelSplitButonOpciones"
        Me.panelSplitButonOpciones.Size = New System.Drawing.Size(300, 186)
        Me.panelSplitButonOpciones.TabIndex = 5
        '
        'btnMarca
        '
        Me.btnMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMarca.Location = New System.Drawing.Point(0, 0)
        Me.btnMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(300, 35)
        Me.btnMarca.TabIndex = 0
        Me.btnMarca.Text = "Marca"
        Me.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarca.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(141, 15)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 43)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Reporte"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnRealizarCompra
        '
        Me.btnRealizarCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRealizarCompra.Location = New System.Drawing.Point(0, 105)
        Me.btnRealizarCompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRealizarCompra.Name = "btnRealizarCompra"
        Me.btnRealizarCompra.Size = New System.Drawing.Size(300, 35)
        Me.btnRealizarCompra.TabIndex = 6
        Me.btnRealizarCompra.Text = "Realizar compra"
        Me.btnRealizarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealizarCompra.UseVisualStyleBackColor = True
        '
        'btnCategoria
        '
        Me.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCategoria.Location = New System.Drawing.Point(0, 70)
        Me.btnCategoria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(300, 35)
        Me.btnCategoria.TabIndex = 7
        Me.btnCategoria.Text = "Categoría"
        Me.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategoria.UseVisualStyleBackColor = True
        '
        'btnProducto
        '
        Me.btnProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducto.Location = New System.Drawing.Point(0, 35)
        Me.btnProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(300, 35)
        Me.btnProducto.TabIndex = 8
        Me.btnProducto.Text = "Producto"
        Me.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'panelTodo
        '
        Me.panelTodo.Controls.Add(Me.TabControl1)
        Me.panelTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTodo.Location = New System.Drawing.Point(0, 0)
        Me.panelTodo.Margin = New System.Windows.Forms.Padding(75, 77, 75, 77)
        Me.panelTodo.Name = "panelTodo"
        Me.panelTodo.Padding = New System.Windows.Forms.Padding(20)
        Me.panelTodo.Size = New System.Drawing.Size(1370, 749)
        Me.panelTodo.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(4, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1314, 66)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.pan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 71)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1314, 600)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lime
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 66)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.panelSplitButonOpciones)
        Me.Panel4.Controls.Add(Me.btnAgregar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1014, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 66)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 77)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(15, 0, 15, 15)
        Me.Panel5.Size = New System.Drawing.Size(1314, 523)
        Me.Panel5.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Yellow
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.Button4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(30, 5, 4, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(30, 31, 30, 31)
        Me.Panel6.Size = New System.Drawing.Size(300, 77)
        Me.Panel6.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Blue
        Me.Panel7.Controls.Add(Me.TextBox1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(1014, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(300, 77)
        Me.Panel7.TabIndex = 8
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelTodo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInventario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan.ResumeLayout(False)
        Me.panelSplitButonOpciones.ResumeLayout(False)
        Me.panelTodo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents pan As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents panelSplitButonOpciones As Panel
    Friend WithEvents btnMarca As Button
    Friend WithEvents btnRealizarCompra As Button
    Friend WithEvents btnCategoria As Button
    Friend WithEvents btnProducto As Button
    Friend WithEvents panelTodo As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
End Class
