Module Module1
    Public Const tcDolar = 7.69
    Public Const tcPM = 0.38
    Public Const tcEuro = 7.89
    Public Const tcColonCr = 0.012

    Public Const comisionCompra = 2.5 / 100
    Public Const comisionVenta = 3 / 100

    Public total_parcial = 0
    Public total

    Sub limpiar()
        Form1.TxtCompra.Clear()
        Form1.TxtVenta.Clear()
        Form1.CbCompra.Checked = False
        Form1.CbVenta.Checked = False

        Form2.Label1.Text = "Limpio"
    End Sub

    Function calcularCompra(ByVal cantidadcompra As Double, ByVal tipocompra As Double) As Double
        If cantidadcompra > 0 Then
            total_parcial = cantidadcompra / tipocompra
            total = total_parcial * comisionCompra + total_parcial
        End If
        Return Math.Round(total, 2)
    End Function


    Function calcularVenta(ByVal cantidadventa As Double, ByVal tipoventa As Double) As Double
        If cantidadventa > 0 Then
            total_parcial = cantidadventa * tipoventa
            total = total_parcial * comisionVenta + total_parcial
        End If
        Return Math.Round(total, 2)
    End Function



End Module
