Module Module1

    Public No_Placa(7) As String
    Public Tipo(7) As String
    Public Cobro(7) As String
    Public Kil_ini(7) As String
    Public Kil_fin(7) As String
    Public Total(7) As String

    Public Const tipo1 = 500
    Public Const tipo2 = 400
    Public Const tipo3 = 300
    Public Const tipo4 = 200



    Public fila As Byte = 0
    Public I As Byte


    Sub salir()

        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else

            limpiar_entradas()
        End If
    End Sub
    Sub limpiar_entradas()
        'procedimiento que limpia o inicializa los objetos donde se ingresan datos
        Form1.txtInicial.Clear()
        Form1.txtFinal.Clear()
        Form1.txtPlaca.Clear()
        Form1.txtConsultar.Clear()
        Form1.cbxTipo.Text = "Seleccione tipo"
        Form1.DataGridView1.Rows.Clear()

    End Sub
    Sub mostrar()
        Form1.DataGridView1.Rows.Clear()

        For I = 0 To 6

            If (No_Placa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(No_Placa(I)), Tipo(I), Str(Cobro(I)), Str(Kil_ini(I)), Str(Kil_fin(I)), Total(I))
            Else
                Exit For
            End If
        Next I

    End Sub


End Module
