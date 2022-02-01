Public Class Form1

    Const PrecioArroz As Double = 2.0
    Const PrecioFrijol As Double = 1.75
    Const PrecioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim PagosinIva As Double = 0
    Dim ValorIVA As Double = 0
    Dim PagoconIVA As Double = 0
    Dim Descuento As Double = 0
    Dim PagoFinal As Double = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PagosinIva = (Val(TxtArroz.Text) * PrecioArroz) + (Val(TxtFrijol.Text) * PrecioFrijol) + (Val(TxtAzucar.Text) * PrecioAzucar)
        ValorIVA = PagosinIva * IVA
        PagoconIVA = PagosinIva + ValorIVA
        Descuento = PagoconIVA * 0.025
        PagoFinal = PagoconIVA - Descuento

        LabelR1.Text = PagosinIva
        LabelR2.Text = ValorIVA
        LabelR3.Text = PagoconIVA
        LabelR4.Text = Descuento
        LabelR5.Text = PagoFinal
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtArroz.Text = ""
        TxtFrijol.Text = ""
        TxtAzucar.Text = ""


        LabelR1.Text = ""
        LabelR2.Text = ""
        LabelR3.Text = ""
        LabelR4.Text = ""
        LabelR5.Text = ""

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub

    Private Sub TxtArroz_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtArroz.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TxtFrijol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFrijol.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtAzucar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAzucar.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
