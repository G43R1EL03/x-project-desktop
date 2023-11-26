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
        Me.ButtonUpload = New FontAwesome.Sharp.IconButton()
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
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
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
        Me.IconPictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.ButtonChoose.Location = New System.Drawing.Point(12, 207)
        Me.ButtonChoose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonChoose.Name = "ButtonChoose"
        Me.ButtonChoose.Size = New System.Drawing.Size(87, 33)
        Me.ButtonChoose.TabIndex = 2
        Me.ButtonChoose.Text = "Choose"
        Me.ButtonChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonChoose.UseVisualStyleBackColor = True
        '
        'ButtonUpload
        '
        Me.ButtonUpload.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.ButtonUpload.IconColor = System.Drawing.Color.Black
        Me.ButtonUpload.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonUpload.IconSize = 35
        Me.ButtonUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUpload.Location = New System.Drawing.Point(103, 207)
        Me.ButtonUpload.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(87, 33)
        Me.ButtonUpload.TabIndex = 3
        Me.ButtonUpload.Text = "Upload"
        Me.ButtonUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonUpload.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.IconChar = FontAwesome.Sharp.IconChar.X
        Me.ButtonCancel.IconColor = System.Drawing.Color.Black
        Me.ButtonCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonCancel.IconSize = 25
        Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.Location = New System.Drawing.Point(47, 244)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Panel1.Location = New System.Drawing.Point(193, 62)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 400)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(134, 343)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 35)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtReorden
        '
        Me.txtReorden.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReorden.Location = New System.Drawing.Point(13, 307)
        Me.txtReorden.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtReorden.Name = "txtReorden"
        Me.txtReorden.Size = New System.Drawing.Size(250, 26)
        Me.txtReorden.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 288)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "P.Reorden"
        '
        'BoxMarca
        '
        Me.BoxMarca.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxMarca.FormattingEnabled = True
        Me.BoxMarca.Location = New System.Drawing.Point(13, 252)
        Me.BoxMarca.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BoxMarca.Name = "BoxMarca"
        Me.BoxMarca.Size = New System.Drawing.Size(157, 26)
        Me.BoxMarca.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 233)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Marca"
        '
        'BoxCategoria
        '
        Me.BoxCategoria.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxCategoria.FormattingEnabled = True
        Me.BoxCategoria.Location = New System.Drawing.Point(13, 201)
        Me.BoxCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BoxCategoria.Name = "BoxCategoria"
        Me.BoxCategoria.Size = New System.Drawing.Size(157, 26)
        Me.BoxCategoria.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 181)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Categoría"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(13, 142)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(250, 26)
        Me.txtCantidad.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad de Cajas"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(13, 86)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(250, 26)
        Me.txtPrecio.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Precio Unitario"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(13, 34)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 26)
        Me.txtNombre.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Información General del Producto"
        '
        'frmAgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 494)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonUpload)
        Me.Controls.Add(Me.ButtonChoose)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmAgregarProducto"
        Me.Text = "frmAgregarProducto"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ButtonChoose As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonUpload As FontAwesome.Sharp.IconButton
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
End Class
