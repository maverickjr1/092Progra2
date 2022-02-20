Module Module1
    Public Const mano_obra_small = 65.5
    Public Const mano_obra_medium = 85.99
    Public Const mano_obra_large = 99.99

    Public Const PrecioyardaAlgodon = 15
    Public Const PrecioyardaSeda = 23.99
    Public Const PrecioyardaLona = 30.99

    Public Const cantidadyardaSmall = 2
    Public Const cantidadyardaMedium = 2.5
    Public Const cantidadyardaLarge = 3

    Public precioCosto = 0
    Public precioVenta = 0

    Public Sub total(ByVal material As String, ByVal tamaño As String, ByVal cantidad As Double)

        Select Case tamaño
            Case "Small"
                Select Case material
                    Case "Algodon"
                        precioCosto = cantidad * cantidadyardaSmall * PrecioyardaAlgodon + cantidad * mano_obra_small
                    Case "Seda"
                        precioCosto = cantidad * cantidadyardaSmall * PrecioyardaSeda + cantidad * mano_obra_small
                    Case "Lona"
                        precioCosto = cantidad * cantidadyardaSmall * PrecioyardaLona + cantidad * mano_obra_small
                End Select

            Case "Medium"
                Select Case material
                    Case "Algodon"
                        precioCosto = cantidad * cantidadyardaMedium * PrecioyardaAlgodon + cantidad * mano_obra_medium
                    Case "Seda"
                        precioCosto = cantidad * cantidadyardaMedium * PrecioyardaSeda + cantidad * mano_obra_medium
                    Case "Lona"
                        precioCosto = cantidad * cantidadyardaMedium * PrecioyardaLona + cantidad * mano_obra_medium
                End Select

            Case "Large"
                Select Case material
                    Case "Algodon"
                        precioCosto = cantidad * cantidadyardaLarge * PrecioyardaAlgodon + cantidad * mano_obra_large
                    Case "Seda"
                        precioCosto = cantidad * cantidadyardaLarge * PrecioyardaSeda + cantidad * mano_obra_large
                    Case "Lona"
                        precioCosto = cantidad * cantidadyardaLarge * PrecioyardaLona + cantidad * mano_obra_large
                End Select
        End Select

        precioVenta = precioCosto + 0.65 * precioCosto

    End Sub

End Module
