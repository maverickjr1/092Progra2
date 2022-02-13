Public Class Form2

    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
      
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.compraDollar.Checked Then
            Label1.Text = "la cantidad de tu compra es: " + Str(calcularCompra(Form1.TxtCompra.Text, tcDolar))
        ElseIf Form1.compraPM.Checked Then
            Label1.Text = "la cantidad de tu compra es: " + Str(calcularCompra(Form1.TxtCompra.Text, tcPM))
        ElseIf Form1.compraEuro.Checked Then
            Label1.Text = "la cantidad de tu compra es: " + Str(calcularCompra(Form1.TxtCompra.Text, tcEuro))
        ElseIf Form1.compraColon.Checked Then
            Label1.Text = "la cantidad de tu compra es: " + Str(calcularCompra(Form1.TxtCompra.Text, tcColonCr))
        Else
            total = 0
        End If

        If Form1.ventaDollar.Checked Then
            Label2.Text = "la cantidad de tu venta es: " + Str(calcularVenta(Form1.TxtVenta.Text, tcDolar))
        ElseIf Form1.VentaPM.Checked Then
            Label2.Text = "la cantidad de tu venta " + Str(calcularVenta(Form1.TxtVenta.Text, tcPM))
        ElseIf Form1.ventaEuro.Checked Then
            Label2.Text = "la cantidad de tu venta " + Str(calcularVenta(Form1.TxtVenta.Text, tcEuro))
        ElseIf Form1.ventaColon.Checked Then
            Label2.Text = "la cantidad de tu venta " + Str(calcularVenta(Form1.TxtVenta.Text, tcColonCr))
        Else
            total = 0
        End If

    End Sub
End Class