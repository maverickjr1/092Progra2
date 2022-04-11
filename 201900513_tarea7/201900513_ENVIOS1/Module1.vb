Module Module1

    Public contador = 0

    Public Registro(9)
    Public Nombre(9)
    Public Valor(9)
    Public Tipo(9)
    Public Modo(9)
    Public PagoParcial(9)
    Public Impuesto(9)
    Public total(9)

    Public Const PCamion = 50
    Public Const PMoto = 15

    Public pago As Double


    Public Const pDoc = 0.015
    Public Const pRopa = 0.06
    Public Const pArt_Pedecederos = 0.055
    Public Const pArt_Plastico = 0.045
    Public Const pLociones = 0.02




    Sub limpiar()
        Form1.cbxtipopaq.SelectedText = "Elija Tipo"
        Form1.cbxmodoenv.SelectedText = "Elija Modo"
        Form1.txtnombre.Clear()
        Form1.txtpesopaquete.Clear()
        Form1.txtvalorpaquete.Clear()
    End Sub

    Sub vector()
        Form1.DataGridView1.Rows.Clear()
    End Sub

End Module
