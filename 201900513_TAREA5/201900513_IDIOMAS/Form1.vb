Public Class Form1

    Private _format As Object

    Private Property format(ByVal p1 As Date, ByVal p2 As String, ByVal p3 As Object, ByVal p4 As Object) As Object
        Get
            Return _format
        End Get
        Set(ByVal value As Object)
            _format = value
        End Set
    End Property

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click
        If carné.Text = "" Then
            MsgBox("Error Campo Carne")
            Exit Sub
        End If

        If Cheque.Checked = False And Efectivo.Checked = False Then
            MsgBox("Error Metodo de pago ")
            Exit Sub
        End If

        If Idiomas.SelectedIndex = -1 Then
            MsgBox("Error Campo Idioma")
            Exit Sub
        End If

        If Dias.SelectedIndex = -1 Then
            MsgBox("Error Campo Dias")
            Exit Sub
        End If

        If Nombre.Text = "" Then
            MsgBox("Error Campo Nombre")
            Exit Sub
        End If

        If Horas.Text = "" Then
            MsgBox("Error Campo Horas")
            Exit Sub
        End If

        If indice < 8 Then
            Matriz(0, indice) = carné.Text
            Matriz(1, indice) = Nombre.Text
            Matriz(2, indice) = Idiomas.SelectedItem
            Matriz(3, indice) = datefecha.Value
            Matriz(4, indice) = Dias.SelectedItem
            Matriz(5, indice) = Horas.Text


            If Dias.SelectedIndex = 0 Then

                If Idiomas.SelectedIndex = 0 Then
                    Matriz(7, indice) = Matriz(5, indice) * 150
                ElseIf Idiomas.SelectedIndex = 1 Then
                    Matriz(7, indice) = Matriz(5, indice) * 125
                Else
                    Matriz(7, indice) = Matriz(5, indice) * 80
                End If
            ElseIf Dias.SelectedIndex = 1 Then
                If Idiomas.SelectedIndex = 0 Then
                    Matriz(7, indice) = Matriz(5, indice) * 150
                ElseIf Idiomas.SelectedIndex = 1 Then
                    Matriz(7, indice) = Matriz(5, indice) * 125
                Else
                    Matriz(7, indice) = Matriz(5, indice) * 80
                End If
            Else
                If Idiomas.SelectedIndex = 0 Then
                    Matriz(7, indice) = 2 * Matriz(5, indice) * 150
                ElseIf Idiomas.SelectedIndex = 1 Then
                    Matriz(7, indice) = 2 * Matriz(5, indice) * 125
                Else
                    Matriz(7, indice) = 2 * Matriz(5, indice) * 80
                End If
            End If


            If Cheque.Checked Then
                Matriz(6, indice) = "Cheque"
                Matriz(8, indice) = Matriz(7, indice) * -1 * 0.015
            ElseIf Efectivo.Checked Then
                Matriz(6, indice) = "Efectivo"
                Matriz(8, indice) = Matriz(7, indice) * -1 * 0.02
            End If



            If Dias.SelectedIndex = 2 Then
                Matriz(9, indice) = Matriz(7, indice) * -1 * 0.05
            End If


            Matriz(10, indice) = Matriz(7, indice) + Matriz(8, indice) + Matriz(9, indice)



            DataGridView1.Rows.Add(indice + 1, Matriz(0, indice), Matriz(1, indice), Matriz(2, indice), Matriz(3, indice), Matriz(4, indice), Matriz(5, indice), Matriz(6, indice), Matriz(7, indice), Matriz(8, indice), Matriz(9, indice), Matriz(10, indice))
            indice = indice + 1
        Else
            MessageBox.Show("Ya se llego al limite")
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir", vbYesNo) = vbYes Then
            End
        End If

    End Sub

  

    Private Sub carné_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles carné.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        Limpiar_Entradas()
    End Sub
End Class
