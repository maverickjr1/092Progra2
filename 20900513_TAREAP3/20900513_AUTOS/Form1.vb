Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        salir()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_entradas()

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click
        If (fila < 8) Then

            No_Placa(fila) = txtPlaca.Text
            Tipo(fila) = cbxTipo.Text


            If cbxTipo.SelectedIndex = 0 Then
                Cobro(fila) = tipo1
            ElseIf cbxTipo.SelectedIndex = 1 Then
                Cobro(fila) = tipo2
            ElseIf cbxTipo.SelectedIndex = 2 Then
                Cobro(fila) = tipo3
            Else
                Cobro(fila) = tipo4
            End If

            Kil_ini(fila) = Val(txtInicial.Text)
            Kil_fin(fila) = Val(txtFinal.Text)


            If (Kil_fin(fila) - Kil_ini(fila)) <= 50.1 Then
                Total(fila) = (Kil_fin(fila) - Kil_ini(fila)) * 3
            ElseIf (Kil_fin(fila) - Kil_ini(fila)) >= 50.9 < 70.1 Then
                Total(fila) = (Kil_fin(fila) - Kil_ini(fila)) * 3
            Else
                Total(fila) = (Kil_fin(fila) - Kil_ini(fila)) * 3
            End If


            fila = fila + 1

            limpiar_entradas()
        End If
        If (fila = 7) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub txtInicial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInicial.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFinal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFinal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPlaca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlaca.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtConsultar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConsultar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = True

        I = 0
        While (I < 8) And (existe)
            If (No_Placa(I) = Val(txtConsultar.Text)) Then
                existe = False 'Instrucción que controla la segunda condición del while, cuando encuentra el dato
            Else
                I = I + 1
            End If
        End While
        If (existe) Then
            MsgBox("placas no encontradas")
            txtConsultar.Focus()
        Else
            MsgBox("Registro Encontrado exitosamente")

            txtPlaca.Text = No_Placa(I)
            cbxTipo.Text = Tipo(I)
            txtInicial.Text = Kil_ini(I)
            txtFinal.Text = Kil_fin(I)
            DataGridView1.Rows.Clear()

            DataGridView1.Rows.Add(No_Placa(I), Tipo(I), Cobro(I), Kil_ini(I), Kil_fin(I), Total(I))

            fila = I
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        If (fila < 8) Then

            No_Placa(fila) = txtPlaca.Text
            Tipo(fila) = cbxTipo.Text


            If cbxTipo.SelectedIndex = 0 Then
                Cobro(fila) = tipo1
            ElseIf cbxTipo.SelectedIndex = 1 Then
                Cobro(fila) = tipo2
            ElseIf cbxTipo.SelectedIndex = 2 Then
                Cobro(fila) = tipo3
            Else
                Cobro(fila) = tipo4
            End If

            Kil_ini(fila) = Val(txtInicial.Text)
            Kil_fin(fila) = Val(txtFinal.Text)


            If (Kil_fin(fila) - Kil_ini(fila)) <= 50.1 Then
                Total(fila) = (Kil_fin(fila) - Kil_ini(fila)) * 3
            ElseIf (Kil_fin(fila) - Kil_ini(fila)) >= 50.9 < 70.1 Then
                Total(fila) = (Kil_fin(fila) - Kil_ini(fila)) * 3
            Else
                Total(fila) = (Kil_fin(fila) - Kil_ini(fila)) * 3
            End If


            fila = fila + 1

            limpiar_entradas()
        End If
        If (fila = 7) Then
            MsgBox("vectores llenos")
        End If

        txtPlaca.Text = No_Placa(fila)
        cbxTipo.Text = Tipo(fila)
        txtInicial.Text = Kil_ini(fila)
        txtFinal.Text = Kil_fin(fila)

        MsgBox("Registro actualizado correctamente en los vectores")
        fila = 7
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        No_Placa(fila) = Nothing
        Tipo(fila) = Nothing
        Kil_ini(fila) = Nothing
        Kil_fin(fila) = Nothing
        Cobro(fila) = Nothing
        Total(fila) = Nothing

        For I = fila To 6
            No_Placa(I) = No_Placa(I + 1)
            Tipo(I) = Tipo(I + 1)
            Kil_ini(I) = Kil_ini(I + 1)
            Kil_fin(I) = Kil_fin(I + 1)
            Cobro(I) = Cobro(I + 1)
            Total(I) = Total(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")
        No_Placa(I) = Nothing
        Tipo(I) = Nothing
        Kil_ini(I) = Nothing
        Kil_fin(I) = Nothing
        Cobro(I) = Nothing
        Total(I) = Nothing

        fila = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub
End Class
