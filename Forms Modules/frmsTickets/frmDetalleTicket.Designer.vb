<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalleTicket
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
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlOrdenCompra = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblOrdenCompra = New System.Windows.Forms.Label()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.pnlDetalle.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicket.Location = New System.Drawing.Point(109, 106)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(0, 20)
        Me.lblTicket.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 162)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Detalles"
        '
        'pnlOrdenCompra
        '
        Me.pnlOrdenCompra.AutoSize = True
        Me.pnlOrdenCompra.Location = New System.Drawing.Point(547, 162)
        Me.pnlOrdenCompra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pnlOrdenCompra.Name = "pnlOrdenCompra"
        Me.pnlOrdenCompra.Size = New System.Drawing.Size(90, 13)
        Me.pnlOrdenCompra.TabIndex = 2
        Me.pnlOrdenCompra.Text = "Orden de Compra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ticket"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "#12345"
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.lblDetalle)
        Me.pnlDetalle.Location = New System.Drawing.Point(239, 192)
        Me.pnlDetalle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(150, 81)
        Me.pnlDetalle.TabIndex = 5
        '
        'lblDetalle
        '
        Me.lblDetalle.Location = New System.Drawing.Point(10, 10)
        Me.lblDetalle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(130, 64)
        Me.lblDetalle.TabIndex = 7
        Me.lblDetalle.Text = "Lorfmepoeforwfmporfroperogerpogerpogerpogeporgpoergpergkregpoerkgpoerkgpkerogerkg" &
    "frfrfrefefefefefefefefeefef"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblOrdenCompra)
        Me.Panel2.Location = New System.Drawing.Point(549, 192)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(150, 81)
        Me.Panel2.TabIndex = 6
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Location = New System.Drawing.Point(10, 8)
        Me.lblOrdenCompra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(130, 64)
        Me.lblOrdenCompra.TabIndex = 8
        Me.lblOrdenCompra.Text = "Lorfmepoeforwfmporfroperogerpogerpogerpogeporgpoergpergkregpoerkgpoerkgpkerogerkg" &
    "frfrfrefefefefefefefefeefef"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnVolver.IconColor = System.Drawing.Color.Black
        Me.btnVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVolver.IconSize = 30
        Me.btnVolver.Location = New System.Drawing.Point(19, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(135, 48)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmDetalleTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlDetalle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlOrdenCompra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTicket)
        Me.Name = "frmDetalleTicket"
        Me.Text = "frmDetalleTicket"
        Me.pnlDetalle.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTicket As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlOrdenCompra As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlDetalle As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblOrdenCompra As Label
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
End Class
