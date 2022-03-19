Module Module1
    Public contador = 0

    Public Num_Venta(7)
    Public Tamaño(7)
    Public Material(7)
    Public Mano_obra(7)
    Public PrecioCosto(7)
    Public PrecioVenta(7)


    Public Const psofa = 250.99
    Public Const pindividual = 150.99
    Public Const pdoble = 200.99

    Public Const pcuero = 75
    Public Const pcuerina = 45.99


    Sub limpiar()
        Form1.cbxTamaño.SelectedText = "Seleccione Tamaño"
        Form1.cbxMaterial.SelectedText = "Seleccione Material"


    End Sub

    Sub vector()
        Form1.DataGridView1.Rows.Clear()

    End Sub
End Module
