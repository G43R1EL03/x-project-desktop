<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTickets
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_ticket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asesor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tickets pendientes"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ticket, Me.Usuario, Me.Asunto, Me.Asesor, Me.Prioridad, Me.Estatus, Me.Fecha, Me.Accion})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(860, 304)
        Me.DataGridView1.TabIndex = 1
        '
        'ID_ticket
        '
        Me.ID_ticket.HeaderText = "ID"
        Me.ID_ticket.Name = "ID_ticket"
        Me.ID_ticket.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Asunto
        '
        Me.Asunto.HeaderText = "Asunto"
        Me.Asunto.Name = "Asunto"
        Me.Asunto.ReadOnly = True
        '
        'Asesor
        '
        Me.Asesor.HeaderText = "Asesor"
        Me.Asesor.Name = "Asesor"
        Me.Asesor.ReadOnly = True
        '
        'Prioridad
        '
        Me.Prioridad.HeaderText = "Prioridad"
        Me.Prioridad.Name = "Prioridad"
        '
        'Estatus
        '
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Accion
        '
        Me.Accion.HeaderText = "Acción"
        Me.Accion.Name = "Accion"
        Me.Accion.Text = "----->"
        Me.Accion.UseColumnTextForButtonValue = True
        '
        'frmTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTickets"
        Me.Text = "Tickets"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID_ticket As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Asunto As DataGridViewTextBoxColumn
    Friend WithEvents Asesor As DataGridViewTextBoxColumn
    Friend WithEvents Prioridad As DataGridViewTextBoxColumn
    Friend WithEvents Estatus As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewButtonColumn
End Class
