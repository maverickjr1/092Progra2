Public Class Form1

   
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir", vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiar()

    End Sub

    Private Sub VectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VectoresToolStripMenuItem.Click
        vector()

    End Sub

    Private Sub txtvalorpaquete_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalorpaquete.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpesopaquete_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpesopaquete.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If cbxmodoenv.SelectedIndex = -1 Then
            MsgBox("Seleccione Modo de Envio")
            Exit Sub
        End If

        If cbxtipopaq.SelectedIndex = -1 Then
            MsgBox("Seleccione Tipo de Paquete")
            Exit Sub
        End If

        If txtnombre.Text = "" Then
            MsgBox("Error Campo Nombre")
            Exit Sub
        End If

        If txtpesopaquete.Text = "" Then
            MsgBox("Error Campo Peso de Paquete")
            Exit Sub
        End If

        If txtvalorpaquete.Text = "" Then
            MsgBox("Error Campo Valor de Paquete")
            Exit Sub
        End If



        If contador < 10 Then

            Registro(contador) = contador + 1
            Modo(contador) = cbxmodoenv.SelectedItem
            Tipo(contador) = cbxtipopaq.SelectedItem
            Nombre(contador) = txtnombre.Text
            Valor(contador) = txtvalorpaquete.Text


            If cbxtipopaq.SelectedIndex = 0 Then
                If cbxmodoenv.SelectedIndex = 0 Then
                    PagoParcial(contador) = PCamion + Valor(contador)
                    pago = PagoParcial(contador) * pDoc
                Else
                    PagoParcial(contador) = PMoto + Valor(contador)
                    pago = PagoParcial(contador) * pDoc
                End If
                
            ElseIf cbxtipopaq.SelectedIndex = 1 Then
                If cbxmodoenv.SelectedIndex = 0 Then
                    PagoParcial(contador) = PCamion + Valor(contador)
                    pago = PagoParcial(contador) * pRopa
                Else
                    PagoParcial(contador) = PMoto + Valor(contador)
                    pago = PagoParcial(contador) * pRopa
                End If

            ElseIf cbxtipopaq.SelectedIndex = 2 Then
                If cbxmodoenv.SelectedIndex = 0 Then
                    PagoParcial(contador) = PCamion + Valor(contador)
                    pago = PagoParcial(contador) * pArt_Pedecederos
                Else
                    PagoParcial(contador) = PMoto + Valor(contador)
                    pago = PagoParcial(contador) * pArt_Pedecederos
                End If

            ElseIf cbxtipopaq.SelectedIndex = 3 Then
                If cbxmodoenv.SelectedIndex = 0 Then
                    PagoParcial(contador) = PCamion + Valor(contador)
                    pago = PagoParcial(contador) * pArt_Plastico
                Else
                    PagoParcial(contador) = PMoto + Valor(contador)
                    pago = PagoParcial(contador) * pArt_Plastico
                End If

            Else
                If cbxmodoenv.SelectedIndex = 4 Then
                    PagoParcial(contador) = PCamion + Valor(contador)
                    pago = PagoParcial(contador) * pLociones
                Else
                    PagoParcial(contador) = PMoto + Valor(contador)
                    pago = PagoParcial(contador) * pLociones
                End If
            End If



            If txtpesopaquete.Text > 5 Then
                Impuesto(contador) = 0
            ElseIf txtpesopaquete.Text < 6 Then
                Impuesto(contador) = pago
            End If



            total(contador) = PagoParcial(contador) + Impuesto(contador)


            DataGridView1.Rows.Add(Registro(contador), Nombre(contador), Valor(contador), Tipo(contador), Modo(contador), PagoParcial(contador), Impuesto(contador), total(contador))
            contador = contador + 1
        Else
            MessageBox.Show("Ya se llego al limite")

        End If
    End Sub


 
End Class
