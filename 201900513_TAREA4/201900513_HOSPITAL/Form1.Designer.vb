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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiasH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Habnoprivada = New System.Windows.Forms.RadioButton()
        Me.Habsemiprivada = New System.Windows.Forms.RadioButton()
        Me.Habprivada = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tdebito = New System.Windows.Forms.RadioButton()
        Me.tcredito = New System.Windows.Forms.RadioButton()
        Me.cheque = New System.Windows.Forms.RadioButton()
        Me.efectivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.maternidad = New System.Windows.Forms.CheckBox()
        Me.operacion = New System.Windows.Forms.CheckBox()
        Me.encamamiento = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem, Me.MostrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1065, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.CalcularToolStripMenuItem.Text = "calcular"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasToolStripMenuItem, Me.VectoresToolStripMenuItem})
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.LimpiarToolStripMenuItem.Text = "limpiar"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EntradasToolStripMenuItem.Text = "entradas"
        '
        'VectoresToolStripMenuItem
        '
        Me.VectoresToolStripMenuItem.Name = "VectoresToolStripMenuItem"
        Me.VectoresToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.VectoresToolStripMenuItem.Text = "vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SalirToolStripMenuItem.Text = "salir"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MostrarToolStripMenuItem.Text = "mostrar"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 306)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1053, 151)
        Me.DataGridView1.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nit"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Dias"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Honorarios"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Habitacion"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Servicios"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.HeaderText = "PagoParcial"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Descuento"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Recargo"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Total"
        Me.Column10.Name = "Column10"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDiasH)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNit)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 167)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dias Hospitalizados"
        '
        'txtDiasH
        '
        Me.txtDiasH.Location = New System.Drawing.Point(113, 127)
        Me.txtDiasH.Name = "txtDiasH"
        Me.txtDiasH.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasH.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(113, 85)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(100, 20)
        Me.txtNit.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(113, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Habnoprivada)
        Me.GroupBox2.Controls.Add(Me.Habsemiprivada)
        Me.GroupBox2.Controls.Add(Me.Habprivada)
        Me.GroupBox2.Location = New System.Drawing.Point(417, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 167)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Habitacion"
        '
        'Habnoprivada
        '
        Me.Habnoprivada.AutoSize = True
        Me.Habnoprivada.Location = New System.Drawing.Point(63, 119)
        Me.Habnoprivada.Name = "Habnoprivada"
        Me.Habnoprivada.Size = New System.Drawing.Size(75, 17)
        Me.Habnoprivada.TabIndex = 2
        Me.Habnoprivada.TabStop = True
        Me.Habnoprivada.Text = "no privada"
        Me.Habnoprivada.UseVisualStyleBackColor = True
        '
        'Habsemiprivada
        '
        Me.Habsemiprivada.AutoSize = True
        Me.Habsemiprivada.Location = New System.Drawing.Point(63, 85)
        Me.Habsemiprivada.Name = "Habsemiprivada"
        Me.Habsemiprivada.Size = New System.Drawing.Size(81, 17)
        Me.Habsemiprivada.TabIndex = 1
        Me.Habsemiprivada.TabStop = True
        Me.Habsemiprivada.Text = "semiprivada"
        Me.Habsemiprivada.UseVisualStyleBackColor = True
        '
        'Habprivada
        '
        Me.Habprivada.AutoSize = True
        Me.Habprivada.Location = New System.Drawing.Point(63, 52)
        Me.Habprivada.Name = "Habprivada"
        Me.Habprivada.Size = New System.Drawing.Size(60, 17)
        Me.Habprivada.TabIndex = 0
        Me.Habprivada.TabStop = True
        Me.Habprivada.Text = "privada"
        Me.Habprivada.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.tdebito)
        Me.GroupBox3.Controls.Add(Me.tcredito)
        Me.GroupBox3.Controls.Add(Me.cheque)
        Me.GroupBox3.Controls.Add(Me.efectivo)
        Me.GroupBox3.Location = New System.Drawing.Point(205, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(374, 100)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pago"
        '
        'tdebito
        '
        Me.tdebito.AutoSize = True
        Me.tdebito.Location = New System.Drawing.Point(272, 45)
        Me.tdebito.Name = "tdebito"
        Me.tdebito.Size = New System.Drawing.Size(66, 17)
        Me.tdebito.TabIndex = 3
        Me.tdebito.TabStop = True
        Me.tdebito.Text = "T.Debito"
        Me.tdebito.UseVisualStyleBackColor = True
        '
        'tcredito
        '
        Me.tcredito.AutoSize = True
        Me.tcredito.Location = New System.Drawing.Point(187, 45)
        Me.tcredito.Name = "tcredito"
        Me.tcredito.Size = New System.Drawing.Size(68, 17)
        Me.tcredito.TabIndex = 2
        Me.tcredito.TabStop = True
        Me.tcredito.Text = "T.Credito"
        Me.tcredito.UseVisualStyleBackColor = True
        '
        'cheque
        '
        Me.cheque.AutoSize = True
        Me.cheque.Location = New System.Drawing.Point(105, 45)
        Me.cheque.Name = "cheque"
        Me.cheque.Size = New System.Drawing.Size(62, 17)
        Me.cheque.TabIndex = 1
        Me.cheque.TabStop = True
        Me.cheque.Text = "Cheque"
        Me.cheque.UseVisualStyleBackColor = True
        '
        'efectivo
        '
        Me.efectivo.AutoSize = True
        Me.efectivo.Location = New System.Drawing.Point(25, 45)
        Me.efectivo.Name = "efectivo"
        Me.efectivo.Size = New System.Drawing.Size(64, 17)
        Me.efectivo.TabIndex = 0
        Me.efectivo.TabStop = True
        Me.efectivo.Text = "Efectivo"
        Me.efectivo.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.maternidad)
        Me.GroupBox4.Controls.Add(Me.operacion)
        Me.GroupBox4.Controls.Add(Me.encamamiento)
        Me.GroupBox4.Location = New System.Drawing.Point(701, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 167)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Servicio"
        '
        'maternidad
        '
        Me.maternidad.AutoSize = True
        Me.maternidad.Location = New System.Drawing.Point(57, 120)
        Me.maternidad.Name = "maternidad"
        Me.maternidad.Size = New System.Drawing.Size(79, 17)
        Me.maternidad.TabIndex = 2
        Me.maternidad.Text = "Maternidad"
        Me.maternidad.UseVisualStyleBackColor = True
        '
        'operacion
        '
        Me.operacion.AutoSize = True
        Me.operacion.Location = New System.Drawing.Point(57, 84)
        Me.operacion.Name = "operacion"
        Me.operacion.Size = New System.Drawing.Size(75, 17)
        Me.operacion.TabIndex = 1
        Me.operacion.Text = "Operacion"
        Me.operacion.UseVisualStyleBackColor = True
        '
        'encamamiento
        '
        Me.encamamiento.AutoSize = True
        Me.encamamiento.Location = New System.Drawing.Point(57, 46)
        Me.encamamiento.Name = "encamamiento"
        Me.encamamiento.Size = New System.Drawing.Size(96, 17)
        Me.encamamiento.TabIndex = 0
        Me.encamamiento.Text = "Encamamiento"
        Me.encamamiento.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.R__3_
        Me.ClientSize = New System.Drawing.Size(1065, 522)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "ds"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNit As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDiasH As System.Windows.Forms.TextBox
    Friend WithEvents Habnoprivada As System.Windows.Forms.RadioButton
    Friend WithEvents Habsemiprivada As System.Windows.Forms.RadioButton
    Friend WithEvents Habprivada As System.Windows.Forms.RadioButton
    Friend WithEvents tdebito As System.Windows.Forms.RadioButton
    Friend WithEvents tcredito As System.Windows.Forms.RadioButton
    Friend WithEvents cheque As System.Windows.Forms.RadioButton
    Friend WithEvents efectivo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents maternidad As System.Windows.Forms.CheckBox
    Friend WithEvents operacion As System.Windows.Forms.CheckBox
    Friend WithEvents encamamiento As System.Windows.Forms.CheckBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
