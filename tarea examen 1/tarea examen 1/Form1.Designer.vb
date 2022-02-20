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
        Me.LARGE = New System.Windows.Forms.RadioButton()
        Me.MEDIUM = New System.Windows.Forms.RadioButton()
        Me.SMALL = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LONA = New System.Windows.Forms.RadioButton()
        Me.SEDA = New System.Windows.Forms.RadioButton()
        Me.ALGODON = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.LIMPIAR = New System.Windows.Forms.Button()
        Me.CALCULAR = New System.Windows.Forms.Button()
        Me.TXTCANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.LARGE)
        Me.GroupBox1.Controls.Add(Me.MEDIUM)
        Me.GroupBox1.Controls.Add(Me.SMALL)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO"
        '
        'LARGE
        '
        Me.LARGE.AutoSize = True
        Me.LARGE.Location = New System.Drawing.Point(38, 114)
        Me.LARGE.Name = "LARGE"
        Me.LARGE.Size = New System.Drawing.Size(61, 17)
        Me.LARGE.TabIndex = 2
        Me.LARGE.Text = "LARGE"
        Me.LARGE.UseVisualStyleBackColor = True
        '
        'MEDIUM
        '
        Me.MEDIUM.AutoSize = True
        Me.MEDIUM.Location = New System.Drawing.Point(38, 70)
        Me.MEDIUM.Name = "MEDIUM"
        Me.MEDIUM.Size = New System.Drawing.Size(69, 17)
        Me.MEDIUM.TabIndex = 1
        Me.MEDIUM.Text = "MEDIUM"
        Me.MEDIUM.UseVisualStyleBackColor = True
        '
        'SMALL
        '
        Me.SMALL.AutoSize = True
        Me.SMALL.Location = New System.Drawing.Point(38, 30)
        Me.SMALL.Name = "SMALL"
        Me.SMALL.Size = New System.Drawing.Size(60, 17)
        Me.SMALL.TabIndex = 0
        Me.SMALL.Text = "SMALL"
        Me.SMALL.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.LONA)
        Me.GroupBox2.Controls.Add(Me.SEDA)
        Me.GroupBox2.Controls.Add(Me.ALGODON)
        Me.GroupBox2.Location = New System.Drawing.Point(342, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 168)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MATERIAL"
        '
        'LONA
        '
        Me.LONA.AutoSize = True
        Me.LONA.Location = New System.Drawing.Point(57, 114)
        Me.LONA.Name = "LONA"
        Me.LONA.Size = New System.Drawing.Size(54, 17)
        Me.LONA.TabIndex = 2
        Me.LONA.Text = "LONA"
        Me.LONA.UseVisualStyleBackColor = True
        '
        'SEDA
        '
        Me.SEDA.AutoSize = True
        Me.SEDA.Location = New System.Drawing.Point(57, 70)
        Me.SEDA.Name = "SEDA"
        Me.SEDA.Size = New System.Drawing.Size(54, 17)
        Me.SEDA.TabIndex = 1
        Me.SEDA.Text = "SEDA"
        Me.SEDA.UseVisualStyleBackColor = True
        '
        'ALGODON
        '
        Me.ALGODON.AutoSize = True
        Me.ALGODON.Location = New System.Drawing.Point(57, 30)
        Me.ALGODON.Name = "ALGODON"
        Me.ALGODON.Size = New System.Drawing.Size(78, 17)
        Me.ALGODON.TabIndex = 0
        Me.ALGODON.Text = "ALGODON"
        Me.ALGODON.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.SALIR)
        Me.GroupBox3.Controls.Add(Me.LIMPIAR)
        Me.GroupBox3.Controls.Add(Me.CALCULAR)
        Me.GroupBox3.Location = New System.Drawing.Point(132, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(345, 118)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OPCIONES"
        '
        'SALIR
        '
        Me.SALIR.Location = New System.Drawing.Point(246, 59)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(75, 23)
        Me.SALIR.TabIndex = 2
        Me.SALIR.Text = "SALIR"
        Me.SALIR.UseVisualStyleBackColor = True
        '
        'LIMPIAR
        '
        Me.LIMPIAR.Location = New System.Drawing.Point(147, 59)
        Me.LIMPIAR.Name = "LIMPIAR"
        Me.LIMPIAR.Size = New System.Drawing.Size(75, 23)
        Me.LIMPIAR.TabIndex = 1
        Me.LIMPIAR.Text = "LIMPIAR"
        Me.LIMPIAR.UseVisualStyleBackColor = True
        '
        'CALCULAR
        '
        Me.CALCULAR.Location = New System.Drawing.Point(43, 59)
        Me.CALCULAR.Name = "CALCULAR"
        Me.CALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.CALCULAR.TabIndex = 0
        Me.CALCULAR.Text = "CALCULAR"
        Me.CALCULAR.UseVisualStyleBackColor = True
        '
        'TXTCANTIDAD
        '
        Me.TXTCANTIDAD.Location = New System.Drawing.Point(165, 28)
        Me.TXTCANTIDAD.Name = "TXTCANTIDAD"
        Me.TXTCANTIDAD.Size = New System.Drawing.Size(239, 20)
        Me.TXTCANTIDAD.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "INGRESE CANTIDAD"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TXTCANTIDAD)
        Me.GroupBox4.Location = New System.Drawing.Point(61, 216)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(452, 64)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CANTIDAD"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.OIP__1_
        Me.ClientSize = New System.Drawing.Size(603, 485)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "Form1"
        Me.Text = "DATOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LARGE As System.Windows.Forms.RadioButton
    Friend WithEvents MEDIUM As System.Windows.Forms.RadioButton
    Friend WithEvents SMALL As System.Windows.Forms.RadioButton
    Friend WithEvents LONA As System.Windows.Forms.RadioButton
    Friend WithEvents SEDA As System.Windows.Forms.RadioButton
    Friend WithEvents ALGODON As System.Windows.Forms.RadioButton
    Friend WithEvents SALIR As System.Windows.Forms.Button
    Friend WithEvents LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents CALCULAR As System.Windows.Forms.Button
    Friend WithEvents TXTCANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
