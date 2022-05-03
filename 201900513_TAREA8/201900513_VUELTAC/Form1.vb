Public Class Form1

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKm.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEtapa.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        salir()

    End Sub

    Private Sub VectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiar_Vectores()

    End Sub

    Private Sub EntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiar_entradas()

    End Sub
   
    Private Sub txtConsultar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConsultar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        If (fila < 13) Then

            No_Etapa(fila) = txtEtapa.Text
            Equipo(fila) = cbxEquipo.Text
            Nacionalidad(fila) = cbxNacion.Text


            If cbxEquipo.SelectedIndex = 1 Then
                If (Tiempo(fila)) <= 84 Then
                    Total(fila) = (Tiempo(fila)) - tipoMov85
                End If
            ElseIf cbxEquipo.SelectedIndex = 3 Then
                If (Tiempo(fila)) <= 84 Then
                    Total(fila) = (Tiempo(fila)) - tipoproteam85
                End If
            End If


            Km(fila) = Val(txtKm.Text)
            Tiempo(fila) = Val(txtTiempo.Text)


            If (Tiempo(fila)) > 120 <= 140 Then
                Total(fila) = (Tiempo(fila)) + tipo120
            ElseIf (Tiempo(fila)) > 140 <= 160 Then
                Total(fila) = (Tiempo(fila)) + tipo140
            ElseIf (Tiempo(fila)) > 160 Then
                Total(fila) = (Tiempo(fila)) + tipo160
            End If


            fila = fila + 1

            limpiar_entradas()
        End If
            If (fila = 12) Then
                MsgBox("vectores llenos")
            End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = True

        I = 0
        While (I < 13) And (existe)
            If (No_Etapa(I) = Val(txtConsultar.Text)) Then
                existe = False
            Else
                I = I + 1
            End If
        End While
        If (existe) Then
            MsgBox("No.Etapa no encontrada")
            txtConsultar.Focus()
        Else
            MsgBox("Registro Encontrado exitosamente")

            txtEtapa.Text = No_Etapa(I)
            cbxEquipo.Text = Equipo(I)
            cbxNacion.Text = Nacionalidad(I)

            txtKm.Text = Km(I)
            txtTiempo.Text = Tiempo(I)

            DataGridView1.Rows.Clear()

            DataGridView1.Rows.Add(Str(No_Etapa(I)), Equipo(I), Str(Km(I)), Str(Tiempo(I)), Nacionalidad(I), Total(I))

            fila = I
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        If (fila < 13) Then

            No_Etapa(fila) = txtEtapa.Text
            Equipo(fila) = cbxEquipo.Text
            Nacionalidad(fila) = cbxNacion.Text

            If cbxEquipo.SelectedIndex = 1 Then
                If (Tiempo(fila)) <= 84 Then
                    Total(fila) = (Tiempo(fila)) - tipoMov85
                End If
            ElseIf cbxEquipo.SelectedIndex = 3 Then
                If (Tiempo(fila)) <= 84 Then
                    Total(fila) = (Tiempo(fila)) - tipoproteam85
                End If
            End If


            Km(fila) = Val(txtKm.Text)
            Tiempo(fila) = Val(txtTiempo.Text)


            If (Tiempo(fila)) > 120 <= 140 Then
                Total(fila) = (Tiempo(fila)) + tipo120
            ElseIf (Tiempo(fila)) > 140 <= 160 Then
                Total(fila) = (Tiempo(fila)) + tipo140
            ElseIf (Tiempo(fila)) > 160 Then
                Total(fila) = (Tiempo(fila)) + tipo160
            End If


            fila = fila + 1

            limpiar_entradas()
        End If

        If (fila = 12) Then
            MsgBox("vectores llenos")
        End If

        txtEtapa.Text = No_Etapa(fila)
        cbxEquipo.Text = Equipo(fila)
        cbxNacion.Text = Nacionalidad(fila)

        txtKm.Text = Km(fila)
        txtTiempo.Text = Tiempo(fila)

        MsgBox("Registro actualizado correctamente en los vectores")
        fila = 12
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenarToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As String
        Dim temp5 As String
        Dim temp6 As Double


        For i = 0 To 10
            For j = i + 1 To 11
                'este if es para saber si hay dato para comparar en la siguiente casilla, de lo contrario se sale del ciclo
                If (No_Etapa(j) <> Nothing) Then
                    If (No_Etapa(i) > No_Etapa(j)) Then
                        temp1 = No_Etapa(i)
                        No_Etapa(i) = No_Etapa(j)
                        No_Etapa(j) = temp1

                        temp2 = Equipo(i)
                        Equipo(i) = Equipo(j)
                        Equipo(j) = temp2

                        temp3 = Km(i)
                        Km(i) = Km(j)
                        Km(j) = temp3

                        temp4 = Tiempo(i)
                        Tiempo(i) = Tiempo(j)
                        Tiempo(j) = temp4

                        temp5 = Nacionalidad(i)
                        Nacionalidad(i) = Nacionalidad(j)
                        Nacionalidad(j) = temp5

                        temp6 = Total(i)
                        Total(i) = Total(j)
                        Total(j) = temp6
                    End If
                Else
                    Exit For
                End If
            Next j

        Next i
    End Sub


End Class
