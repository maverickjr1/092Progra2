Module Module1

    Public No_Etapa(12) As String
    Public Equipo(12) As String
    Public Km(12) As String
    Public Tiempo(12) As String
    Public Nacionalidad(12) As String
    Public Total(12) As String

    Public Const tipo120 = 30
    Public Const tipo140 = 40
    Public Const tipo160 = 50
    Public Const tipoMov85 = 15
    Public Const tipoproteam85 = 10



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
        Form1.txtTiempo.Clear()
        Form1.txtKm.Clear()
        Form1.txtEtapa.Clear()
        Form1.txtConsultar.Clear()
        Form1.cbxEquipo.Text = "Seleccione Equipo"
        Form1.cbxNacion.Text = "Seleccione Nacionalidad"
    End Sub
    Sub limpiar_Vectores()
        Form1.txtcorred.Clear()
        Form1.txtrecorri.Clear()
        Form1.txttotal.Clear()


        Form1.DataGridView1.Rows.Clear()

        fila = 0

        For I = 0 To 11
            No_Etapa(I) = Nothing
            Equipo(I) = Nothing
            Km(I) = Nothing
            Tiempo(I) = Nothing
            Nacionalidad(I) = Nothing
            Total(I) = Nothing
        Next

    End Sub





    Sub mostrar()
        Form1.DataGridView1.Rows.Clear()

        For I = 0 To 11

            If (No_Etapa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(No_Etapa(I)), Equipo(I), Str(Km(I)), Str(Tiempo(I)), Nacionalidad(I), Total(I))
            Else
                Exit For
            End If
        Next I

    End Sub

End Module
