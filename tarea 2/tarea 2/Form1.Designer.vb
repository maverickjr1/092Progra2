<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtAzucar = New System.Windows.Forms.TextBox()
        Me.TxtFrijol = New System.Windows.Forms.TextBox()
        Me.TxtArroz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelR5 = New System.Windows.Forms.Label()
        Me.LabelR4 = New System.Windows.Forms.Label()
        Me.LabelR3 = New System.Windows.Forms.Label()
        Me.LabelR2 = New System.Windows.Forms.Label()
        Me.LabelR1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Resultados = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Resultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(231, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(430, 42)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 2
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TxtAzucar)
        Me.GroupBox1.Controls.Add(Me.TxtFrijol)
        Me.GroupBox1.Controls.Add(Me.TxtArroz)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 170)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Ingreso"
        '
        'TxtAzucar
        '
        Me.TxtAzucar.Location = New System.Drawing.Point(106, 114)
        Me.TxtAzucar.Name = "TxtAzucar"
        Me.TxtAzucar.Size = New System.Drawing.Size(100, 20)
        Me.TxtAzucar.TabIndex = 5
        Me.TxtAzucar.Text = "0"
        '
        'TxtFrijol
        '
        Me.TxtFrijol.Location = New System.Drawing.Point(106, 74)
        Me.TxtFrijol.Name = "TxtFrijol"
        Me.TxtFrijol.Size = New System.Drawing.Size(100, 20)
        Me.TxtFrijol.TabIndex = 4
        Me.TxtFrijol.Text = "0"
        '
        'TxtArroz
        '
        Me.TxtArroz.Location = New System.Drawing.Point(106, 29)
        Me.TxtArroz.Name = "TxtArroz"
        Me.TxtArroz.Size = New System.Drawing.Size(100, 20)
        Me.TxtArroz.TabIndex = 3
        Me.TxtArroz.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libras de Azucar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Libras de Frijol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Libras de Arroz"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pago antes del IVA"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.LabelR5)
        Me.GroupBox2.Controls.Add(Me.LabelR4)
        Me.GroupBox2.Controls.Add(Me.LabelR3)
        Me.GroupBox2.Controls.Add(Me.LabelR2)
        Me.GroupBox2.Controls.Add(Me.LabelR1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 144)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'LabelR5
        '
        Me.LabelR5.AutoSize = True
        Me.LabelR5.Location = New System.Drawing.Point(329, 95)
        Me.LabelR5.Name = "LabelR5"
        Me.LabelR5.Size = New System.Drawing.Size(22, 13)
        Me.LabelR5.TabIndex = 14
        Me.LabelR5.Text = "0,0"
        '
        'LabelR4
        '
        Me.LabelR4.AutoSize = True
        Me.LabelR4.Location = New System.Drawing.Point(329, 51)
        Me.LabelR4.Name = "LabelR4"
        Me.LabelR4.Size = New System.Drawing.Size(22, 13)
        Me.LabelR4.TabIndex = 13
        Me.LabelR4.Text = "0,0"
        '
        'LabelR3
        '
        Me.LabelR3.AutoSize = True
        Me.LabelR3.Location = New System.Drawing.Point(131, 112)
        Me.LabelR3.Name = "LabelR3"
        Me.LabelR3.Size = New System.Drawing.Size(22, 13)
        Me.LabelR3.TabIndex = 12
        Me.LabelR3.Text = "0,0"
        '
        'LabelR2
        '
        Me.LabelR2.AutoSize = True
        Me.LabelR2.Location = New System.Drawing.Point(131, 75)
        Me.LabelR2.Name = "LabelR2"
        Me.LabelR2.Size = New System.Drawing.Size(22, 13)
        Me.LabelR2.TabIndex = 11
        Me.LabelR2.Text = "0,0"
        '
        'LabelR1
        '
        Me.LabelR1.AutoSize = True
        Me.LabelR1.Location = New System.Drawing.Point(131, 34)
        Me.LabelR1.Name = "LabelR1"
        Me.LabelR1.Size = New System.Drawing.Size(22, 13)
        Me.LabelR1.TabIndex = 10
        Me.LabelR1.Text = "0,0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(237, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Pago Final"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(237, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pago con el IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Valor del IVA"
        '
        'Resultados
        '
        Me.Resultados.Controls.Add(Me.Button1)
        Me.Resultados.Controls.Add(Me.Button2)
        Me.Resultados.Controls.Add(Me.Salir)
        Me.Resultados.Location = New System.Drawing.Point(50, 354)
        Me.Resultados.Name = "Resultados"
        Me.Resultados.Size = New System.Drawing.Size(530, 100)
        Me.Resultados.TabIndex = 6
        Me.Resultados.TabStop = False
        Me.Resultados.Text = "opciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(603, 464)
        Me.Controls.Add(Me.Resultados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Resultados.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAzucar As System.Windows.Forms.TextBox
    Friend WithEvents TxtFrijol As System.Windows.Forms.TextBox
    Friend WithEvents TxtArroz As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelR5 As System.Windows.Forms.Label
    Friend WithEvents LabelR4 As System.Windows.Forms.Label
    Friend WithEvents LabelR3 As System.Windows.Forms.Label
    Friend WithEvents LabelR2 As System.Windows.Forms.Label
    Friend WithEvents LabelR1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Resultados As System.Windows.Forms.GroupBox

End Class
