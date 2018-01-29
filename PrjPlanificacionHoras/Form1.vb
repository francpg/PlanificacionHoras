Public Class Form1
    Dim dtTecnicos As DataTable
    Dim dtGrupos As DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SP_OBTENER_GRUPOS()
        SP_OBTENER_TECNICOS()
    End Sub

    Private Sub tlpActividades_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlpActividades.LocationChanged
        Try
            tlpDias.SetBounds(tlpActividades.Location.X, tlpDias.Location.Y, tlpDias.Width, tlpDias.Height)
        Catch ex As Exception

        End Try

        Try
            tlpTecnicos.SetBounds(tlpTecnicos.Location.X, tlpActividades.Location.Y, tlpTecnicos.Width, tlpTecnicos.Height)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SP_OBTENER_TECNICOS()
        dtTecnicos = New DataTable()
        dtTecnicos.Columns.Add("T_GRUPO")
        dtTecnicos.Columns.Add("T_ID")
        dtTecnicos.Columns.Add("T_NOMBRE")

        Dim nuevaFila As DataRow
        Dim i As Integer = 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 1
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JUNIOR U."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 1
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "MARTIN  G"
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 1
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JOSE A."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "FREDDY L"
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "ANTHONY T."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "BRAULIO R."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "LUIS T."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "CRISTIAN J."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "RONALD C."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "SIMEON C."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "BARRETO"
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "DAVID V."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "PATRICIA S."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "ANIBAL"
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JHON H."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JOEL ."
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JHON SAT"
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JULIO "
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "CAROLINA"
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTecnicos.NewRow()
        nuevaFila.Item("T_GRUPO") = 5
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "NEYSER"
        dtTecnicos.Rows.Add(nuevaFila)
        i += 1
        
    End Sub

    Private Sub SP_OBTENER_GRUPOS()
        dtGrupos = New DataTable()
        dtGrupos.Columns.Add("GRUPO_ID")
        dtGrupos.Columns.Add("GRUPO_NOMBRE")
        dtGrupos.Columns.Add("GRUPO_COLOR")

        Dim nuevaFila As DataRow

        nuevaFila = dtGrupos.NewRow()
        nuevaFila.Item("GRUPO_ID") = 1
        nuevaFila.Item("GRUPO_NOMBRE") = "GRUPO 1"
        nuevaFila.Item("GRUPO_COLOR") = "34;139;230"
        dtGrupos.Rows.Add(nuevaFila)

        nuevaFila = dtGrupos.NewRow()
        nuevaFila.Item("GRUPO_ID") = 2
        nuevaFila.Item("GRUPO_NOMBRE") = "GRUPO 2"
        nuevaFila.Item("GRUPO_COLOR") = "130;201;30"
        dtGrupos.Rows.Add(nuevaFila)

        nuevaFila = dtGrupos.NewRow()
        nuevaFila.Item("GRUPO_ID") = 3
        nuevaFila.Item("GRUPO_NOMBRE") = "GRUPO 3"
        nuevaFila.Item("GRUPO_COLOR") = "250;82;82"
        dtGrupos.Rows.Add(nuevaFila)

        nuevaFila = dtGrupos.NewRow()
        nuevaFila.Item("GRUPO_ID") = 4
        nuevaFila.Item("GRUPO_NOMBRE") = "GRUPO 4"
        nuevaFila.Item("GRUPO_COLOR") = "21;170;191"
        dtGrupos.Rows.Add(nuevaFila)

        nuevaFila = dtGrupos.NewRow()
        nuevaFila.Item("GRUPO_ID") = 5
        nuevaFila.Item("GRUPO_NOMBRE") = "GRUPO 5"
        nuevaFila.Item("GRUPO_COLOR") = "250;176;5"
        dtGrupos.Rows.Add(nuevaFila)
    End Sub

    
End Class
