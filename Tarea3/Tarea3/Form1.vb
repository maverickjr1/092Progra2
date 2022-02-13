Public Class Form1

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbCompra.CheckedChanged
        If CbCompra.Checked = True Then
            TxtCompra.Enabled = True
        Else
            TxtCompra.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbVenta.CheckedChanged
        If CbVenta.Checked = True Then
            TxtVenta.Enabled = True
        Else
            TxtVenta.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
