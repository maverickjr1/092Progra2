Public Class Form1


    
    Private Sub VectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VectoresToolStripMenuItem.Click
        Limpiar_Vectores()


    End Sub

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click
        If index < 7 Then


            paciente(index) = txtNombre.Text
            nit(index) = txtNit.Text
            dias_hos(index) = txtDiasH.Text
            honorarios(index) = 0

            If Habprivada.Checked Then
                habitacion(index) = "privada"
            ElseIf Habsemiprivada.Checked Then
                habitacion(index) = "Semiprivada"
            Else
                habitacion(index) = "No_privada"
            End If


            If Habprivada.Checked AndAlso encamamiento.Checked AndAlso operacion.Checked AndAlso maternidad.Checked Then
                servicios(index) = (priv_encamamiento + priv_operacion + priv_maternidad)
            ElseIf Habsemiprivada.Checked AndAlso encamamiento.Checked AndAlso operacion.Checked AndAlso maternidad.Checked Then
                servicios(index) = (semipriv_encamamiento + semipriv_operacion + semipriv_maternidad)
            ElseIf Habnoprivada.Checked AndAlso encamamiento.Checked AndAlso operacion.Checked AndAlso maternidad.Checked Then
                servicios(index) = (nopriv_encamamiento + nopriv_operacion + nopriv_maternidad)
            End If

            If Habprivada.Checked AndAlso operacion.Checked AndAlso maternidad.Checked Then
                servicios(index) = priv_operacion + priv_maternidad
            ElseIf Habsemiprivada.Checked AndAlso operacion.Checked AndAlso maternidad.Checked Then
                servicios(index) = semipriv_operacion + semipriv_maternidad
            ElseIf Habnoprivada.Checked AndAlso operacion.Checked AndAlso maternidad.Checked Then
                servicios(index) = nopriv_operacion + nopriv_maternidad
            End If

            If Habprivada.Checked AndAlso encamamiento.Checked AndAlso operacion.Checked Then
                servicios(index) = priv_encamamiento + priv_operacion
            ElseIf Habsemiprivada.Checked AndAlso encamamiento.Checked AndAlso operacion.Checked Then
                servicios(index) = semipriv_encamamiento + semipriv_operacion
            ElseIf Habnoprivada.Checked AndAlso encamamiento.Checked AndAlso operacion.Checked Then
                servicios(index) = nopriv_encamamiento + nopriv_operacion
            End If

            If Habprivada.Checked AndAlso encamamiento.Checked AndAlso maternidad.Checked Then
                servicios(index) = priv_encamamiento + priv_maternidad
            ElseIf Habsemiprivada.Checked AndAlso encamamiento.Checked AndAlso maternidad.Checked Then
                servicios(index) = semipriv_encamamiento + semipriv_maternidad
            ElseIf Habnoprivada.Checked AndAlso encamamiento.Checked AndAlso maternidad.Checked Then
                servicios(index) = nopriv_encamamiento + nopriv_maternidad
            End If

            If Habprivada.Checked And encamamiento.Checked Then
                servicios(index) = dias_hos(index) * priv_encamamiento
            ElseIf Habsemiprivada.Checked And encamamiento.Checked Then
                servicios(index) = dias_hos(index) * semipriv_encamamiento
            ElseIf Habnoprivada.Checked And encamamiento.Checked Then
                servicios(index) = dias_hos(index) * nopriv_encamamiento
            End If

            If Habprivada.Checked And maternidad.Checked Then
                servicios(index) = dias_hos(index) * priv_maternidad
            ElseIf Habsemiprivada.Checked And maternidad.Checked Then
                servicios(index) = dias_hos(index) * semipriv_maternidad
            ElseIf Habnoprivada.Checked And maternidad.Checked Then
                servicios(index) = dias_hos(index) * nopriv_maternidad
            End If

            If Habprivada.Checked And operacion.Checked Then
                servicios(index) = dias_hos(index) * priv_operacion
            ElseIf Habsemiprivada.Checked And operacion.Checked Then
                servicios(index) = dias_hos(index) * semipriv_operacion
            ElseIf Habnoprivada.Checked And operacion.Checked Then
                servicios(index) = dias_hos(index) * nopriv_operacion
            End If




            If efectivo.Checked Then
                pago(index) = Pago_efectivo_cheque
                descuento(index) = pago(index) * Pago_efectivo_cheque * -1

            ElseIf cheque.Checked Then
                pago(index) = Pago_efectivo_cheque
                descuento(index) = pago(index) * Pago_efectivo_cheque * -1
            ElseIf tcredito.Checked Then
                pago(index) = Pago_TCredito
                recargo(index) = pago(index) * Pago_TCredito
            ElseIf tdebito.Checked Then
                pago(index) = Pago_TDebito
                descuento(index) = pago(index) * Pago_TDebito * -1
            Else
                MsgBox("no selecciono metodo de pago")
            End If




            pago(index) = servicios(index)
            'descuento(index) = pago(index) * 0.05 * -1

            'recargo(index) = pago(index) * Pago_TCredito

            total(index) = pago(index) + descuento(index) + recargo(index)

            'ListBox1.Items.Add(pago(index))
            'ListBox1.Items.Add(descuento(index))
            'ListBox1.Items.Add(recargo(index))

            DataGridView1.Rows.Add(paciente(index), nit(index), dias_hos(index), honorarios(index), habitacion(index), servicios(index), pago(index), descuento(index), recargo(index), total(index))

            index = index + 1

        End If


    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        For contador = 0 To index - 1
            MsgBox("El pago es: " & pago(contador) & ", El recargo es: " & Str(recargo(contador)))
        Next
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        Limpiar_Entradas()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir") Then
            Close()
        End If

    End Sub

    
    Private Sub txtNit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasH.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
