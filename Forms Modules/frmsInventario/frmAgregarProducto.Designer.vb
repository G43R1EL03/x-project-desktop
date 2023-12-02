<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarProducto
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
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.ButtonChoose = New FontAwesome.Sharp.IconButton()
        Me.ButtonCancel = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtReorden = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BoxMarca = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BoxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelFrmAgregarProducto = New System.Windows.Forms.Panel()
        Me.btncancelar = New FontAwesome.Sharp.IconButton()
        Me.btnagregarimg = New FontAwesome.Sharp.IconButton()
        Me.btnsubirimg = New FontAwesome.Sharp.IconButton()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelFrmAgregarProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Producto"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 162
        Me.IconPictureBox1.Location = New System.Drawing.Point(70, 72)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(177, 162)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'ButtonChoose
        '
        Me.ButtonChoose.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonChoose.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.ButtonChoose.IconColor = System.Drawing.Color.Black
        Me.ButtonChoose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonChoose.IconSize = 35
        Me.ButtonChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonChoose.Location = New System.Drawing.Point(-149, 185)
        Me.ButtonChoose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonChoose.Name = "ButtonChoose"
        Me.ButtonChoose.Size = New System.Drawing.Size(87, 33)
        Me.ButtonChoose.TabIndex = 2
        Me.ButtonChoose.Text = "Choose"
        Me.ButtonChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonChoose.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.IconChar = FontAwesome.Sharp.IconChar.X
        Me.ButtonCancel.IconColor = System.Drawing.Color.Black
        Me.ButtonCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonCancel.IconSize = 25
        Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.Location = New System.Drawing.Point(-114, 222)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(87, 33)
        Me.ButtonCancel.TabIndex = 4
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtReorden)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BoxMarca)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BoxCategoria)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(284, 57)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 380)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(13, 343)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 35)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtReorden
        '
        Me.txtReorden.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtReorden.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtReorden.ForeColor = System.Drawing.Color.White
        Me.txtReorden.Location = New System.Drawing.Point(13, 307)
        Me.txtReorden.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReorden.Name = "txtReorden"
        Me.txtReorden.Size = New System.Drawing.Size(250, 23)
        Me.txtReorden.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 288)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "P.Reorden"
        '
        'BoxMarca
        '
        Me.BoxMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BoxMarca.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BoxMarca.ForeColor = System.Drawing.Color.White
        Me.BoxMarca.FormattingEnabled = True
        Me.BoxMarca.Location = New System.Drawing.Point(13, 252)
        Me.BoxMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.BoxMarca.Name = "BoxMarca"
        Me.BoxMarca.Size = New System.Drawing.Size(157, 24)
        Me.BoxMarca.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 233)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Marca"
        '
        'BoxCategoria
        '
        Me.BoxCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BoxCategoria.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BoxCategoria.ForeColor = System.Drawing.Color.White
        Me.BoxCategoria.FormattingEnabled = True
        Me.BoxCategoria.Location = New System.Drawing.Point(13, 201)
        Me.BoxCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.BoxCategoria.Name = "BoxCategoria"
        Me.BoxCategoria.Size = New System.Drawing.Size(157, 24)
        Me.BoxCategoria.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 181)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Categoría"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtCantidad.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(13, 142)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(250, 23)
        Me.txtCantidad.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad de Cajas"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtPrecio.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtPrecio.ForeColor = System.Drawing.Color.White
        Me.txtPrecio.Location = New System.Drawing.Point(13, 86)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(250, 23)
        Me.txtPrecio.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Precio Unitario"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(13, 34)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 23)
        Me.txtNombre.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(279, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Información General del Producto"
        '
        'panelFrmAgregarProducto
        '
        Me.panelFrmAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.panelFrmAgregarProducto.Controls.Add(Me.btncancelar)
        Me.panelFrmAgregarProducto.Controls.Add(Me.btnagregarimg)
        Me.panelFrmAgregarProducto.Controls.Add(Me.btnsubirimg)
        Me.panelFrmAgregarProducto.Controls.Add(Me.Panel1)
        Me.panelFrmAgregarProducto.Controls.Add(Me.Label2)
        Me.panelFrmAgregarProducto.Controls.Add(Me.Label1)
        Me.panelFrmAgregarProducto.Controls.Add(Me.IconPictureBox1)
        Me.panelFrmAgregarProducto.Controls.Add(Me.ButtonCancel)
        Me.panelFrmAgregarProducto.Controls.Add(Me.ButtonChoose)
        Me.panelFrmAgregarProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFrmAgregarProducto.Location = New System.Drawing.Point(0, 0)
        Me.panelFrmAgregarProducto.Name = "panelFrmAgregarProducto"
        Me.panelFrmAgregarProducto.Size = New System.Drawing.Size(935, 494)
        Me.panelFrmAgregarProducto.TabIndex = 7
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btncancelar.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btncancelar.IconColor = System.Drawing.Color.Black
        Me.btncancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btncancelar.IconSize = 38
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(117, 297)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(94, 43)
        Me.btncancelar.TabIndex = 35
        Me.btncancelar.Text = "Cancel"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnagregarimg
        '
        Me.btnagregarimg.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnagregarimg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarimg.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnagregarimg.IconColor = System.Drawing.Color.Black
        Me.btnagregarimg.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnagregarimg.IconSize = 38
        Me.btnagregarimg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregarimg.Location = New System.Drawing.Point(48, 246)
        Me.btnagregarimg.Name = "btnagregarimg"
        Me.btnagregarimg.Size = New System.Drawing.Size(106, 45)
        Me.btnagregarimg.TabIndex = 34
        Me.btnagregarimg.Text = "Choose"
        Me.btnagregarimg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnagregarimg.UseVisualStyleBackColor = False
        '
        'btnsubirimg
        '
        Me.btnsubirimg.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnsubirimg.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnsubirimg.IconColor = System.Drawing.Color.Black
        Me.btnsubirimg.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnsubirimg.IconSize = 38
        Me.btnsubirimg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsubirimg.Location = New System.Drawing.Point(171, 246)
        Me.btnsubirimg.Name = "btnsubirimg"
        Me.btnsubirimg.Size = New System.Drawing.Size(97, 45)
        Me.btnsubirimg.TabIndex = 33
        Me.btnsubirimg.Text = "Upload"
        Me.btnsubirimg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsubirimg.UseVisualStyleBackColor = False
        '
        'frmAgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 494)
        Me.Controls.Add(Me.panelFrmAgregarProducto)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAgregarProducto"
        Me.Text = "frmAgregarProducto"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelFrmAgregarProducto.ResumeLayout(False)
        Me.panelFrmAgregarProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ButtonChoose As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtReorden As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BoxMarca As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BoxCategoria As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents panelFrmAgregarProducto As Panel
    Friend WithEvents btncancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnagregarimg As FontAwesome.Sharp.IconButton
    Friend WithEvents btnsubirimg As FontAwesome.Sharp.IconButton
End Class
