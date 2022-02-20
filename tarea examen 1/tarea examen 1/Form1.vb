Public Class Form1

    Private Sub TXTCANTIDAD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCANTIDAD.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CALCULAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULAR.Click
        If SMALL.Checked = False AndAlso MEDIUM.Checked = False AndAlso LARGE.Checked = False Then
            MsgBox("No has elegido tamaño")
        End If

        If ALGODON.Checked = False AndAlso SEDA.Checked = False AndAlso LONA.Checked = False Then
            MsgBox("No has elegido material")
        End If

        If TXTCANTIDAD.Text = "" Then
            MsgBox("Ingrese Cantidad")
        End If

        Dim tamaño As String
        Dim material As String

        If SMALL.Checked Then
            tamaño = "Small"
        ElseIf MEDIUM.Checked Then
            tamaño = "Medium"
        Else
            tamaño = "Large"
        End If

        If SEDA.Checked Then
            material = "Seda"
        ElseIf ALGODON.Checked Then
            material = "Algodon"
        Else
            material = "Lona"
        End If

        total(material, tamaño, Val(TXTCANTIDAD.Text))

        Me.Hide()
        Form2.Show()

    End Sub
  
    Private Sub LIMPIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIAR.Click
        TXTCANTIDAD.Clear()
        SMALL.Checked = False
        MEDIUM.Checked = False
        LARGE.Checked = False
        ALGODON.Checked = False
        SEDA.Checked = False
        LONA.Checked = False

    End Sub

    Private Sub SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIR.Click
        If MsgBox("desea salir") Then
            Close()
        End If

    End Sub


End Class
