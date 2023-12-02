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
        Me.ButtonChoose = New FontAwesome.Sharp.IconButton()
        Me.ButtonCancel = New FontAwesome.Sharp.IconButton()
        Me.panelFrmAgregarProducto = New System.Windows.Forms.Panel()
        Me.BtnUpload = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BoxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BoxMarca = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReorden = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnChoose = New FontAwesome.Sharp.IconButton()
        Me.BtnCancel = New FontAwesome.Sharp.IconButton()
        Me.panelFrmAgregarProducto.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonChoose
        '
        Me.ButtonChoose.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonChoose.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.ButtonChoose.IconColor = System.Drawing.Color.Black
        Me.ButtonChoose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonChoose.IconSize = 35
        Me.ButtonChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonChoose.Location = New System.Drawing.Point(-224, 285)
        Me.ButtonChoose.Name = "ButtonChoose"
        Me.ButtonChoose.Size = New System.Drawing.Size(130, 51)
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
        Me.ButtonCancel.Location = New System.Drawing.Point(-171, 342)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(130, 51)
        Me.ButtonCancel.TabIndex = 4
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'panelFrmAgregarProducto
        '
        Me.panelFrmAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelFrmAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panelFrmAgregarProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelFrmAgregarProducto.Controls.Add(Me.BtnCancel)
        Me.panelFrmAgregarProducto.Controls.Add(Me.BtnChoose)
        Me.panelFrmAgregarProducto.Controls.Add(Me.Panel1)
        Me.panelFrmAgregarProducto.Controls.Add(Me.Label2)
        Me.panelFrmAgregarProducto.Controls.Add(Me.Label1)
        Me.panelFrmAgregarProducto.Controls.Add(Me.IconPictureBox1)
        Me.panelFrmAgregarProducto.Controls.Add(Me.ButtonCancel)
        Me.panelFrmAgregarProducto.Controls.Add(Me.ButtonChoose)
        Me.panelFrmAgregarProducto.Controls.Add(Me.BtnUpload)
        Me.panelFrmAgregarProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFrmAgregarProducto.Location = New System.Drawing.Point(0, 0)
        Me.panelFrmAgregarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelFrmAgregarProducto.Name = "panelFrmAgregarProducto"
        Me.panelFrmAgregarProducto.Size = New System.Drawing.Size(1827, 820)
        Me.panelFrmAgregarProducto.TabIndex = 7
        '
        'BtnUpload
        '
        Me.BtnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnUpload.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.BtnUpload.IconColor = System.Drawing.Color.Black
        Me.BtnUpload.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnUpload.IconSize = 35
        Me.BtnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpload.Location = New System.Drawing.Point(348, 329)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(130, 51)
        Me.BtnUpload.TabIndex = 3
        Me.BtnUpload.Text = "Upload"
        Me.BtnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpload.UseVisualStyleBackColor = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 249
        Me.IconPictureBox1.Location = New System.Drawing.Point(212, 74)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(266, 249)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(483, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(488, 36)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Información General del Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(20, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(373, 44)
        Me.txtNombre.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Precio Unitario"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtPrecio.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.Color.White
        Me.txtPrecio.Location = New System.Drawing.Point(20, 141)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(373, 44)
        Me.txtPrecio.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 27)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad de Cajas"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtCantidad.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(19, 239)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(373, 44)
        Me.txtCantidad.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 27)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Categoría"
        '
        'BoxCategoria
        '
        Me.BoxCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BoxCategoria.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxCategoria.ForeColor = System.Drawing.Color.White
        Me.BoxCategoria.FormattingEnabled = True
        Me.BoxCategoria.Location = New System.Drawing.Point(19, 330)
        Me.BoxCategoria.Name = "BoxCategoria"
        Me.BoxCategoria.Size = New System.Drawing.Size(234, 44)
        Me.BoxCategoria.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(14, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 27)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Marca"
        '
        'BoxMarca
        '
        Me.BoxMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BoxMarca.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxMarca.ForeColor = System.Drawing.Color.White
        Me.BoxMarca.FormattingEnabled = True
        Me.BoxMarca.Location = New System.Drawing.Point(20, 433)
        Me.BoxMarca.Name = "BoxMarca"
        Me.BoxMarca.Size = New System.Drawing.Size(234, 44)
        Me.BoxMarca.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 513)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 27)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "P.Reorden"
        '
        'txtReorden
        '
        Me.txtReorden.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtReorden.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReorden.ForeColor = System.Drawing.Color.White
        Me.txtReorden.Location = New System.Drawing.Point(19, 543)
        Me.txtReorden.Name = "txtReorden"
        Me.txtReorden.Size = New System.Drawing.Size(373, 44)
        Me.txtReorden.TabIndex = 18
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAgregar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(209, 613)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(158, 54)
        Me.BtnAgregar.TabIndex = 19
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnAgregar)
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
        Me.Panel1.Location = New System.Drawing.Point(483, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 692)
        Me.Panel1.TabIndex = 5
        '
        'BtnChoose
        '
        Me.BtnChoose.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnChoose.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.BtnChoose.IconColor = System.Drawing.Color.Black
        Me.BtnChoose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnChoose.IconSize = 35
        Me.BtnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChoose.Location = New System.Drawing.Point(212, 329)
        Me.BtnChoose.Name = "BtnChoose"
        Me.BtnChoose.Size = New System.Drawing.Size(130, 51)
        Me.BtnChoose.TabIndex = 7
        Me.BtnChoose.Text = "Choose"
        Me.BtnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnChoose.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.BtnCancel.IconColor = System.Drawing.Color.Black
        Me.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCancel.IconSize = 35
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(282, 386)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(130, 51)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'frmAgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1827, 820)
        Me.Controls.Add(Me.panelFrmAgregarProducto)
        Me.Name = "frmAgregarProducto"
        Me.Text = "frmAgregarProducto"
        Me.panelFrmAgregarProducto.ResumeLayout(False)
        Me.panelFrmAgregarProducto.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonChoose As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents panelFrmAgregarProducto As Panel
    Friend WithEvents BtnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnChoose As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAgregar As Button
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
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents BtnUpload As FontAwesome.Sharp.IconButton
End Class
