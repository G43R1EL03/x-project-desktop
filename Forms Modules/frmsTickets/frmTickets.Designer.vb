<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTickets
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
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.ID_ticket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cboFiltrarEstado = New System.Windows.Forms.ComboBox()
        Me.btnFiltrar = New FontAwesome.Sharp.IconButton()
        Me.btnLimpiarFiltro = New FontAwesome.Sharp.IconButton()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tickets"
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToAddRows = False
        Me.dgvTickets.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ticket, Me.Asunto, Me.Prioridad, Me.Estado, Me.Fecha, Me.Accion, Me.Eliminar})
        Me.dgvTickets.Location = New System.Drawing.Point(68, 102)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.Size = New System.Drawing.Size(692, 304)
        Me.dgvTickets.TabIndex = 1
        '
        'ID_ticket
        '
        Me.ID_ticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID_ticket.DataPropertyName = "id_tickets"
        Me.ID_ticket.HeaderText = "ID"
        Me.ID_ticket.Name = "ID_ticket"
        Me.ID_ticket.ReadOnly = True
        Me.ID_ticket.Width = 43
        '
        'Asunto
        '
        Me.Asunto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Asunto.DataPropertyName = "categoria"
        Me.Asunto.HeaderText = "Asunto"
        Me.Asunto.Name = "Asunto"
        Me.Asunto.ReadOnly = True
        Me.Asunto.Width = 65
        '
        'Prioridad
        '
        Me.Prioridad.DataPropertyName = "prioridad"
        Me.Prioridad.HeaderText = "Prioridad"
        Me.Prioridad.Name = "Prioridad"
        Me.Prioridad.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Estado.DataPropertyName = "estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 65
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecha.DataPropertyName = "fecha_cambio_estado"
        Me.Fecha.HeaderText = "Ultima Modificación"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 114
        '
        'Accion
        '
        Me.Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Accion.HeaderText = "Detalles"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        Me.Accion.Text = "----->"
        Me.Accion.UseColumnTextForButtonValue = True
        Me.Accion.Width = 51
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        Me.Eliminar.Width = 49
        '
        'cboFiltrarEstado
        '
        Me.cboFiltrarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltrarEstado.FormattingEnabled = True
        Me.cboFiltrarEstado.Location = New System.Drawing.Point(480, 63)
        Me.cboFiltrarEstado.Name = "cboFiltrarEstado"
        Me.cboFiltrarEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboFiltrarEstado.TabIndex = 2
        '
        'btnFiltrar
        '
        Me.btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter
        Me.btnFiltrar.IconColor = System.Drawing.Color.Black
        Me.btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFiltrar.Location = New System.Drawing.Point(624, 58)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(46, 31)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'btnLimpiarFiltro
        '
        Me.btnLimpiarFiltro.IconChar = FontAwesome.Sharp.IconChar.FilterCircleXmark
        Me.btnLimpiarFiltro.IconColor = System.Drawing.Color.Black
        Me.btnLimpiarFiltro.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLimpiarFiltro.Location = New System.Drawing.Point(676, 58)
        Me.btnLimpiarFiltro.Name = "btnLimpiarFiltro"
        Me.btnLimpiarFiltro.Size = New System.Drawing.Size(49, 31)
        Me.btnLimpiarFiltro.TabIndex = 5
        Me.btnLimpiarFiltro.UseVisualStyleBackColor = True
        '
        'frmTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 450)
        Me.Controls.Add(Me.btnLimpiarFiltro)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.cboFiltrarEstado)
        Me.Controls.Add(Me.dgvTickets)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTickets"
        Me.Text = "Tickets"
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTickets As DataGridView
    Friend WithEvents ID_ticket As DataGridViewTextBoxColumn
    Friend WithEvents Asunto As DataGridViewTextBoxColumn
    Friend WithEvents Prioridad As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewButtonColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents cboFiltrarEstado As ComboBox
    Friend WithEvents btnFiltrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLimpiarFiltro As FontAwesome.Sharp.IconButton
End Class
