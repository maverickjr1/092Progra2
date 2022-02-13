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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbVenta = New System.Windows.Forms.CheckBox()
        Me.CbCompra = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtVenta = New System.Windows.Forms.TextBox()
        Me.TxtCompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.compraColon = New System.Windows.Forms.RadioButton()
        Me.compraEuro = New System.Windows.Forms.RadioButton()
        Me.compraPM = New System.Windows.Forms.RadioButton()
        Me.compraDollar = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ventaColon = New System.Windows.Forms.RadioButton()
        Me.ventaEuro = New System.Windows.Forms.RadioButton()
        Me.VentaPM = New System.Windows.Forms.RadioButton()
        Me.ventaDollar = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Controls.Add(Me.CbVenta)
        Me.GroupBox1.Controls.Add(Me.CbCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "transacciones"
        '
        'CbVenta
        '
        Me.CbVenta.AutoSize = True
        Me.CbVenta.Location = New System.Drawing.Point(20, 70)
        Me.CbVenta.Name = "CbVenta"
        Me.CbVenta.Size = New System.Drawing.Size(53, 17)
        Me.CbVenta.TabIndex = 1
        Me.CbVenta.Text = "venta"
        Me.CbVenta.UseVisualStyleBackColor = True
        '
        'CbCompra
        '
        Me.CbCompra.AutoSize = True
        Me.CbCompra.Location = New System.Drawing.Point(20, 35)
        Me.CbCompra.Name = "CbCompra"
        Me.CbCompra.Size = New System.Drawing.Size(61, 17)
        Me.CbCompra.TabIndex = 0
        Me.CbCompra.Text = "compra"
        Me.CbCompra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.TxtVenta)
        Me.GroupBox2.Controls.Add(Me.TxtCompra)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(233, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 137)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese Cantidad"
        '
        'TxtVenta
        '
        Me.TxtVenta.Enabled = False
        Me.TxtVenta.Location = New System.Drawing.Point(94, 91)
        Me.TxtVenta.Name = "TxtVenta"
        Me.TxtVenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtVenta.TabIndex = 3
        '
        'TxtCompra
        '
        Me.TxtCompra.Enabled = False
        Me.TxtCompra.Location = New System.Drawing.Point(94, 40)
        Me.TxtCompra.Name = "TxtCompra"
        Me.TxtCompra.Size = New System.Drawing.Size(100, 20)
        Me.TxtCompra.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "compra"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.compraColon)
        Me.GroupBox3.Controls.Add(Me.compraEuro)
        Me.GroupBox3.Controls.Add(Me.compraPM)
        Me.GroupBox3.Controls.Add(Me.compraDollar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 196)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compra"
        '
        'compraColon
        '
        Me.compraColon.AutoSize = True
        Me.compraColon.Location = New System.Drawing.Point(30, 132)
        Me.compraColon.Name = "compraColon"
        Me.compraColon.Size = New System.Drawing.Size(65, 17)
        Me.compraColon.TabIndex = 3
        Me.compraColon.TabStop = True
        Me.compraColon.Text = "Colon Cr"
        Me.compraColon.UseVisualStyleBackColor = True
        '
        'compraEuro
        '
        Me.compraEuro.AutoSize = True
        Me.compraEuro.Location = New System.Drawing.Point(30, 97)
        Me.compraEuro.Name = "compraEuro"
        Me.compraEuro.Size = New System.Drawing.Size(47, 17)
        Me.compraEuro.TabIndex = 2
        Me.compraEuro.TabStop = True
        Me.compraEuro.Text = "Euro"
        Me.compraEuro.UseVisualStyleBackColor = True
        '
        'compraPM
        '
        Me.compraPM.AutoSize = True
        Me.compraPM.Location = New System.Drawing.Point(30, 63)
        Me.compraPM.Name = "compraPM"
        Me.compraPM.Size = New System.Drawing.Size(98, 17)
        Me.compraPM.TabIndex = 1
        Me.compraPM.TabStop = True
        Me.compraPM.Text = "Peso Mexicano"
        Me.compraPM.UseVisualStyleBackColor = True
        '
        'compraDollar
        '
        Me.compraDollar.AutoSize = True
        Me.compraDollar.Location = New System.Drawing.Point(30, 30)
        Me.compraDollar.Name = "compraDollar"
        Me.compraDollar.Size = New System.Drawing.Size(52, 17)
        Me.compraDollar.TabIndex = 0
        Me.compraDollar.TabStop = True
        Me.compraDollar.Text = "Dollar"
        Me.compraDollar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox4.Controls.Add(Me.ventaColon)
        Me.GroupBox4.Controls.Add(Me.ventaEuro)
        Me.GroupBox4.Controls.Add(Me.VentaPM)
        Me.GroupBox4.Controls.Add(Me.ventaDollar)
        Me.GroupBox4.Location = New System.Drawing.Point(251, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 196)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Venta"
        '
        'ventaColon
        '
        Me.ventaColon.AutoSize = True
        Me.ventaColon.Location = New System.Drawing.Point(30, 132)
        Me.ventaColon.Name = "ventaColon"
        Me.ventaColon.Size = New System.Drawing.Size(65, 17)
        Me.ventaColon.TabIndex = 3
        Me.ventaColon.TabStop = True
        Me.ventaColon.Text = "Colon Cr"
        Me.ventaColon.UseVisualStyleBackColor = True
        '
        'ventaEuro
        '
        Me.ventaEuro.AutoSize = True
        Me.ventaEuro.Location = New System.Drawing.Point(30, 97)
        Me.ventaEuro.Name = "ventaEuro"
        Me.ventaEuro.Size = New System.Drawing.Size(47, 17)
        Me.ventaEuro.TabIndex = 2
        Me.ventaEuro.TabStop = True
        Me.ventaEuro.Text = "Euro"
        Me.ventaEuro.UseVisualStyleBackColor = True
        '
        'VentaPM
        '
        Me.VentaPM.AutoSize = True
        Me.VentaPM.Location = New System.Drawing.Point(30, 63)
        Me.VentaPM.Name = "VentaPM"
        Me.VentaPM.Size = New System.Drawing.Size(98, 17)
        Me.VentaPM.TabIndex = 1
        Me.VentaPM.TabStop = True
        Me.VentaPM.Text = "Peso Mexicano"
        Me.VentaPM.UseVisualStyleBackColor = True
        '
        'ventaDollar
        '
        Me.ventaDollar.AutoSize = True
        Me.ventaDollar.Location = New System.Drawing.Point(30, 30)
        Me.ventaDollar.Name = "ventaDollar"
        Me.ventaDollar.Size = New System.Drawing.Size(52, 17)
        Me.ventaDollar.TabIndex = 0
        Me.ventaDollar.TabStop = True
        Me.ventaDollar.Text = "Dollar"
        Me.ventaDollar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(531, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(531, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(531, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.OIP__1_1
        Me.ClientSize = New System.Drawing.Size(613, 496)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CbVenta As System.Windows.Forms.CheckBox
    Friend WithEvents CbCompra As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtVenta As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents compraColon As System.Windows.Forms.RadioButton
    Friend WithEvents compraEuro As System.Windows.Forms.RadioButton
    Friend WithEvents compraPM As System.Windows.Forms.RadioButton
    Friend WithEvents compraDollar As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ventaColon As System.Windows.Forms.RadioButton
    Friend WithEvents ventaEuro As System.Windows.Forms.RadioButton
    Friend WithEvents VentaPM As System.Windows.Forms.RadioButton
    Friend WithEvents ventaDollar As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
