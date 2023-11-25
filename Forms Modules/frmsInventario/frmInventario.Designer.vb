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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pan = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelSplitButonInventario = New System.Windows.Forms.Panel()
        Me.btnRealizarCompra = New System.Windows.Forms.Button()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnMarca = New System.Windows.Forms.Button()
        Me.btnAgregarInventario = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.panelSplitButonEntradas = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnAgregarEntradas = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelTodo = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panelSplitButonInventario.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.panelSplitButonEntradas.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.panelTodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 14)
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
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1322, 676)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventario"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.pan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1322, 623)
        Me.Panel2.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 67)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(15, 0, 15, 15)
        Me.Panel5.Size = New System.Drawing.Size(1322, 556)
        Me.Panel5.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 1)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1282, 535)
        Me.DataGridView1.TabIndex = 2
        '
        'pan
        '
        Me.pan.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pan.Controls.Add(Me.Panel7)
        Me.pan.Controls.Add(Me.Panel6)
        Me.pan.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan.Location = New System.Drawing.Point(0, 0)
        Me.pan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(1322, 67)
        Me.pan.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel7.Controls.Add(Me.TextBox1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(1022, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(300, 67)
        Me.Panel7.TabIndex = 8
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.Button4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(30, 5, 4, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(30, 31, 30, 31)
        Me.Panel6.Size = New System.Drawing.Size(300, 67)
        Me.Panel6.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(20, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(141, 15)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 43)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Reporte"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1322, 53)
        Me.Panel1.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.panelSplitButonInventario)
        Me.Panel4.Controls.Add(Me.btnAgregarInventario)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1120, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(30, 10, 10, 10)
        Me.Panel4.Size = New System.Drawing.Size(202, 53)
        Me.Panel4.TabIndex = 1
        '
        'panelSplitButonInventario
        '
        Me.panelSplitButonInventario.Controls.Add(Me.btnRealizarCompra)
        Me.panelSplitButonInventario.Controls.Add(Me.btnCategoria)
        Me.panelSplitButonInventario.Controls.Add(Me.btnProducto)
        Me.panelSplitButonInventario.Controls.Add(Me.btnMarca)
        Me.panelSplitButonInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSplitButonInventario.Location = New System.Drawing.Point(30, 45)
        Me.panelSplitButonInventario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelSplitButonInventario.Name = "panelSplitButonInventario"
        Me.panelSplitButonInventario.Padding = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.panelSplitButonInventario.Size = New System.Drawing.Size(162, 141)
        Me.panelSplitButonInventario.TabIndex = 5
        '
        'btnRealizarCompra
        '
        Me.btnRealizarCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRealizarCompra.Location = New System.Drawing.Point(0, 105)
        Me.btnRealizarCompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRealizarCompra.Name = "btnRealizarCompra"
        Me.btnRealizarCompra.Size = New System.Drawing.Size(147, 35)
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
        Me.btnCategoria.Size = New System.Drawing.Size(147, 35)
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
        Me.btnProducto.Size = New System.Drawing.Size(147, 35)
        Me.btnProducto.TabIndex = 8
        Me.btnProducto.Text = "Producto"
        Me.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'btnMarca
        '
        Me.btnMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMarca.Location = New System.Drawing.Point(0, 0)
        Me.btnMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(147, 35)
        Me.btnMarca.TabIndex = 0
        Me.btnMarca.Text = "Marca"
        Me.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarca.UseVisualStyleBackColor = True
        '
        'btnAgregarInventario
        '
        Me.btnAgregarInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarInventario.Location = New System.Drawing.Point(30, 10)
        Me.btnAgregarInventario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarInventario.Name = "btnAgregarInventario"
        Me.btnAgregarInventario.Size = New System.Drawing.Size(162, 35)
        Me.btnAgregarInventario.TabIndex = 3
        Me.btnAgregarInventario.Text = "Agregar"
        Me.btnAgregarInventario.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 53)
        Me.Panel3.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Panel8)
        Me.TabPage2.Controls.Add(Me.Panel9)
        Me.TabPage2.Controls.Add(Me.Panel12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1322, 676)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entradas"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel8.Controls.Add(Me.DataGridView2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 120)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(15, 0, 15, 15)
        Me.Panel8.Size = New System.Drawing.Size(1322, 556)
        Me.Panel8.TabIndex = 8
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(20, 1)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1283, 535)
        Me.DataGridView2.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 53)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1322, 67)
        Me.Panel9.TabIndex = 7
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel10.Controls.Add(Me.TextBox2)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1022, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(300, 67)
        Me.Panel10.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(98, 15)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 41)
        Me.TextBox2.TabIndex = 4
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Button2)
        Me.Panel11.Controls.Add(Me.Button3)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(30, 5, 4, 5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(30, 31, 30, 31)
        Me.Panel11.Size = New System.Drawing.Size(300, 67)
        Me.Panel11.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(20, 15)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(141, 15)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 43)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Reporte"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Controls.Add(Me.Panel15)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1322, 53)
        Me.Panel12.TabIndex = 9
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.panelSplitButonEntradas)
        Me.Panel13.Controls.Add(Me.btnAgregarEntradas)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel13.Location = New System.Drawing.Point(1120, 0)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Padding = New System.Windows.Forms.Padding(30, 10, 10, 10)
        Me.Panel13.Size = New System.Drawing.Size(202, 53)
        Me.Panel13.TabIndex = 1
        '
        'panelSplitButonEntradas
        '
        Me.panelSplitButonEntradas.Controls.Add(Me.Button5)
        Me.panelSplitButonEntradas.Controls.Add(Me.Button6)
        Me.panelSplitButonEntradas.Controls.Add(Me.Button7)
        Me.panelSplitButonEntradas.Controls.Add(Me.Button8)
        Me.panelSplitButonEntradas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSplitButonEntradas.Location = New System.Drawing.Point(30, 45)
        Me.panelSplitButonEntradas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelSplitButonEntradas.Name = "panelSplitButonEntradas"
        Me.panelSplitButonEntradas.Padding = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.panelSplitButonEntradas.Size = New System.Drawing.Size(162, 141)
        Me.panelSplitButonEntradas.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.Location = New System.Drawing.Point(0, 105)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 35)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Realizar compra"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.Location = New System.Drawing.Point(0, 70)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(147, 35)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Categoría"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.Location = New System.Drawing.Point(0, 35)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(147, 35)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Producto"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.Location = New System.Drawing.Point(0, 0)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(147, 35)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Marca"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnAgregarEntradas
        '
        Me.btnAgregarEntradas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarEntradas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarEntradas.Location = New System.Drawing.Point(30, 10)
        Me.btnAgregarEntradas.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarEntradas.Name = "btnAgregarEntradas"
        Me.btnAgregarEntradas.Size = New System.Drawing.Size(162, 35)
        Me.btnAgregarEntradas.TabIndex = 3
        Me.btnAgregarEntradas.Text = "Agregar"
        Me.btnAgregarEntradas.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Label2)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(300, 53)
        Me.Panel15.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Entradas"
        '
        'panelTodo
        '
        Me.panelTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelTodo.Controls.Add(Me.TabControl1)
        Me.panelTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTodo.Location = New System.Drawing.Point(0, 0)
        Me.panelTodo.Margin = New System.Windows.Forms.Padding(75, 77, 75, 77)
        Me.panelTodo.Name = "panelTodo"
        Me.panelTodo.Padding = New System.Windows.Forms.Padding(20)
        Me.panelTodo.Size = New System.Drawing.Size(1370, 749)
        Me.panelTodo.TabIndex = 4
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.panelSplitButonInventario.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.panelSplitButonEntradas.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.panelTodo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarInventario As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents pan As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents panelSplitButonInventario As Panel
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
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents panelSplitButonEntradas As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btnAgregarEntradas As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label2 As Label
End Class
