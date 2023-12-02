<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarMarca
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncancelar = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnagregarimg = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsubirimg = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(273, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 22)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Información General de la Marca"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btncancelar.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btncancelar.IconColor = System.Drawing.Color.Black
        Me.btncancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btncancelar.IconSize = 30
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(125, 333)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(83, 39)
        Me.btncancelar.TabIndex = 32
        Me.btncancelar.Text = "Cancel"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(277, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 226)
        Me.Panel1.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Agregar Marca"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(15, 118)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(369, 34)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(17, 41)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(367, 33)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'btnagregarimg
        '
        Me.btnagregarimg.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnagregarimg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarimg.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnagregarimg.IconColor = System.Drawing.Color.Black
        Me.btnagregarimg.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnagregarimg.IconSize = 30
        Me.btnagregarimg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregarimg.Location = New System.Drawing.Point(77, 274)
        Me.btnagregarimg.Name = "btnagregarimg"
        Me.btnagregarimg.Size = New System.Drawing.Size(89, 43)
        Me.btnagregarimg.TabIndex = 31
        Me.btnagregarimg.Text = "Choose"
        Me.btnagregarimg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnagregarimg.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Agregar Marca"
        '
        'btnsubirimg
        '
        Me.btnsubirimg.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnsubirimg.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnsubirimg.IconColor = System.Drawing.Color.Black
        Me.btnsubirimg.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnsubirimg.IconSize = 30
        Me.btnsubirimg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsubirimg.Location = New System.Drawing.Point(174, 274)
        Me.btnsubirimg.Name = "btnsubirimg"
        Me.btnsubirimg.Size = New System.Drawing.Size(80, 43)
        Me.btnsubirimg.TabIndex = 30
        Me.btnsubirimg.Text = "Upload"
        Me.btnsubirimg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsubirimg.UseVisualStyleBackColor = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 162
        Me.IconPictureBox1.Location = New System.Drawing.Point(77, 98)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(177, 162)
        Me.IconPictureBox1.TabIndex = 34
        Me.IconPictureBox1.TabStop = False
        '
        'frmAgregarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(919, 455)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnagregarimg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsubirimg)
        Me.Name = "frmAgregarMarca"
        Me.Text = "frmAgregarMarca"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btncancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnagregarimg As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsubirimg As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
