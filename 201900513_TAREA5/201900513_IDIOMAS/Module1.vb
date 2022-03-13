Module Module1
    Public Matriz(10, 8)

    Public indice = 0


    Sub Limpiar_Entradas()
        'Form1.ListBox1.Items.Clear()
        'Form1.ListBox2.Items.Clear()
        'Form1.ListBox3.Items.Clear()
        Form1.DataGridView1.Rows.Clear()
        Form1.Nombre.Clear()
        Form1.carné.Clear()
        Form1.Horas.Clear()

        Form1.Cheque.Checked = False
        Form1.Efectivo.Checked = False




    End Sub

End Module
