Module Module1
    Public index = 0

    Public paciente(5)
    Public nit(5)
    Public dias_hos(5)
    Public honorarios(5)
    Public habitacion(5)
    Public servicios(5)



    Public pago(5)
    Public descuento(5)
    Public recargo(5)
    Public total(5)

    Public Privada As Double
    Public Semiprivada As Double
    Public No_privada As Double


    Public Const priv_encamamiento = 350
    Public Const priv_operacion = 550
    Public Const priv_maternidad = 450
    Public Const semipriv_encamamiento = 250
    Public Const semipriv_operacion = 400
    Public Const semipriv_maternidad = 350
    Public Const nopriv_encamamiento = 150
    Public Const nopriv_operacion = 300
    Public Const nopriv_maternidad = 250

    Public Const Pago_efectivo_cheque = 0.15
    Public Const Pago_TCredito = 0.05
    Public Const Pago_TDebito = 0.08
    Public Const sub_total = 0





    Sub Limpiar_Vectores()
        ReDim pago(5)
        ReDim descuento(5)
        ReDim recargo(5)

        index = 0

    End Sub

    Sub Limpiar_Entradas()
        'Form1.ListBox1.Items.Clear()
        'Form1.ListBox2.Items.Clear()
        'Form1.ListBox3.Items.Clear()
        Form1.DataGridView1.Rows.Clear()
        Form1.txtNombre.Clear()
        Form1.txtNit.Clear()
        Form1.txtDiasH.Clear()

        Form1.Habprivada.Checked = False
        Form1.Habsemiprivada.Checked = False
        Form1.Habnoprivada.Checked = False

        Form1.encamamiento.Checked = False
        Form1.operacion.Checked = False
        Form1.maternidad.Checked = False


        index = 0
    End Sub
    

End Module
