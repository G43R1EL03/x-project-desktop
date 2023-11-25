<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Marca
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(46, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 25)
        Label1.TabIndex = 0
        Label1.Text = "Agregar Marca"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Location = New Point(234, 65)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(554, 363)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(37, 46)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(164, 35)
        TextBox2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(362, 318)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 23)
        Button1.TabIndex = 6
        Button1.Text = "Agregar Marca"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(37, 203)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(332, 87)
        TextBox1.TabIndex = 5
        TextBox1.Text = "hola agrego cualquier producto por si acaso"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(314, 318)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(37, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 3
        Label4.Text = "Descripcion"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 2
        Label3.Text = "Categoria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Coca Cola", "Pepsi"})
        ComboBox1.Location = New Point(37, 130)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(24, 84)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(186, 112)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(24, 231)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "Importar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(135, 231)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 10
        Button3.Text = "Exportar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Agregar_Marca
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Agregar_Marca"
        Text = "Agregar_Marca"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
