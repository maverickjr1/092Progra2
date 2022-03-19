Public Class Form1

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click
        If cbxTamaño.SelectedIndex = -1 Or cbxMaterial.SelectedIndex = -1 Then
            MsgBox("Seleccione Todos los Datos")
            Exit Sub
        End If

        If contador < 8 Then

            Num_Venta(contador) = contador + 1
            Tamaño(contador) = cbxTamaño.SelectedItem
            Material(contador) = cbxMaterial.SelectedItem

            If cbxTamaño.SelectedIndex = 0 Then
                Mano_obra(contador) = Val(psofa)
                If cbxMaterial.SelectedIndex = 0 Then
                    PrecioCosto(contador) = Mano_obra(contador) + pcuero * 8
                    PrecioVenta(contador) = PrecioCosto(contador) * 1.65
                ElseIf cbxMaterial.SelectedIndex = 1 Then
                    PrecioCosto(contador) = Mano_obra(contador) + pcuerina * 8
                    PrecioVenta(contador) = PrecioCosto(contador) * 1.65
                End If

            ElseIf cbxTamaño.SelectedIndex = 1 Then
                Mano_obra(contador) = pindividual
                If cbxMaterial.SelectedIndex = 0 Then
                    PrecioCosto(contador) = Mano_obra(contador) + pcuero * 3.5
                    PrecioVenta(contador) = PrecioCosto(contador) * 1.65
                ElseIf cbxMaterial.SelectedIndex = 1 Then
                    PrecioCosto(contador) = Mano_obra(contador) + pcuerina * 3.5
                    PrecioVenta(contador) = PrecioCosto(contador) * 1.65
                End If

            Else
                Mano_obra(contador) = pdoble
                If cbxMaterial.SelectedIndex = 0 Then
                    PrecioCosto(contador) = Mano_obra(contador) + pcuero * 6
                    PrecioVenta(contador) = PrecioCosto(contador) * 1.65
                ElseIf cbxMaterial.SelectedIndex = 1 Then
                    PrecioCosto(contador) = Mano_obra(contador) + pcuerina * 6
                    PrecioVenta(contador) = PrecioCosto(contador) * 1.65
                End If
            End If



            DataGridView1.Rows.Add(Num_Venta(contador), Tamaño(contador), Material(contador), Mano_obra(contador), PrecioCosto(contador), PrecioVenta(contador))
                contador = contador + 1
            Else
                MessageBox.Show("Ya se llego al limite")
            End If

    End Sub

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
End Class
