Public Class Form2
    Private fechaInicio As Date
    Private fechaFin As Date
    Private dtTrabajadores As DataTable
    Private dtTrabsEnLista As DataTable
    Private dtGrupos As DataTable
    Private dtActividades As DataTable
    Private tlpDias As TableLayoutPanel
    Private tlpTrabajadores As TableLayoutPanel
    Private tlpActividades As TableLayoutPanel
    Private Const horasMostradas As Integer = 10
    Private Const horasRegulares As Integer = 9
    Private Const anchoHora As Integer = 36
    Private Const alturaTrabajador As Integer = 84
    Private u As New Utiles

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        calFechas.SetSelectionRange(Today, Today.AddDays(7))

        SP_OBTENER_GRUPOS()
        SP_OBTENER_TRABAJADORES()
        SP_OBTENER_ACTIVIDADES()
        SP_LLENAR_CKLBGRUPOS()

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            fechaInicio = calFechas.SelectionRange.Start
            fechaFin = calFechas.SelectionRange.End
            SP_OBTENER_TRABAJADORES()
            SP_OBTENER_ACTIVIDADES()

            SP_GENERAR_DIAS()
            SP_GENERAR_TRABAJADORES()
            SP_GENERAR_DIASXTRABAJADOR()
            SP_GENERAR_ACTIVIDADES()
            SP_GENERAR_BOTONES_AGREGAR()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SP_LLENAR_CKLBGRUPOS()
        cklbGrupos.Items.Clear()
        cklbGrupos.Items.Add("TODOS", True)
        For Each fila As DataRow In dtGrupos.Rows
            cklbGrupos.Items.Add(fila.Item("GRUPO_NOMBRE"), True)
        Next
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
        nuevaFila.Item("GRUPO_COLOR") = "64;192;87"
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

    Private Sub SP_OBTENER_TRABAJADORES()
        dtTrabajadores = New DataTable()
        dtTrabajadores.Columns.Add("T_GRUPO")
        dtTrabajadores.Columns.Add("T_ID")
        dtTrabajadores.Columns.Add("T_NOMBRE")

        Dim nuevaFila As DataRow
        Dim i As Integer = 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 1
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JUNIOR U."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 1
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "MARTIN  G"
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 1
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JOSE A."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "FREDDY L"
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "ANTHONY T."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "BRAULIO R."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "LUIS T."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 2
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "CRISTIAN J."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "RONALD C."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "SIMEON C."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "BARRETO"
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "DAVID V."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 3
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "PATRICIA S."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "ANIBAL"
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JHON H."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JOEL ."
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JHON SAT"
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "JULIO "
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 4
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "CAROLINA"
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

        nuevaFila = dtTrabajadores.NewRow()
        nuevaFila.Item("T_GRUPO") = 5
        nuevaFila.Item("T_ID") = i
        nuevaFila.Item("T_NOMBRE") = "NEYSER"
        dtTrabajadores.Rows.Add(nuevaFila)
        i += 1

    End Sub

    Private Sub SP_OBTENER_ACTIVIDADES()
        dtActividades = New DataTable
        dtActividades.Columns.Add("ID_TRABAJADOR", System.Type.GetType("System.Int32"))
        dtActividades.Columns.Add("ID_REF", System.Type.GetType("System.Int32"))
        dtActividades.Columns.Add("ACTIV_TIPO", System.Type.GetType("System.String"))
        dtActividades.Columns.Add("ACTIV_FECHA", System.Type.GetType("System.DateTime"))
        dtActividades.Columns.Add("ACTIV_NRO_ORDEN", System.Type.GetType("System.Int32"))
        dtActividades.Columns.Add("ACTIV_HORAS", System.Type.GetType("System.Double"))
        dtActividades.Columns.Add("ACTIV_TITULO", System.Type.GetType("System.String"))
        dtActividades.Columns.Add("ACTIV_DESCRIPCION", System.Type.GetType("System.String"))

        Dim filaNueva As DataRow

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 1
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 9
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 1
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 9
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 1
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 3
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 1
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 3
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 3
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(4)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 4
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 4
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 4
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 5
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(3)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 6
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 7
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 3
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 8
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(3)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 9
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
        dtActividades.Rows.Add(filaNueva)

    End Sub

    Private Sub SP_GENERAR_DIAS()
        Try
            Dim rangoDias As System.TimeSpan = fechaFin - fechaInicio

            Dim dia As Date = fechaInicio

            tlpDias = New TableLayoutPanel
            tlpDias.RowStyles.Add(New RowStyle(SizeType.Absolute, 50))

            For i As Integer = 0 To rangoDias.Days
                tlpDias.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, horasMostradas * anchoHora))
                Dim btnDia As New Button

                With btnDia
                    .Text = dia.ToString("dddd").ToUpper & vbNewLine & dia.ToString("dd/MM/yyyy")
                    .Margin = New Padding(0)
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Dock = DockStyle.Fill
                    .BackColor = Me.lblTrabajadoresDias.BackColor
                    .ForeColor = Me.lblTrabajadoresDias.ForeColor
                    .Font = Me.lblTrabajadoresDias.Font
                    .FlatStyle = FlatStyle.Flat
                    .FlatAppearance.BorderSize = 0
                End With

                tlpDias.Controls.Add(btnDia, i, 0)
                dia = dia.AddDays(1)
            Next
            tlpDias.SetBounds(0, 0, anchoHora * horasMostradas * (rangoDias.Days + 1), 50)

            pnlDias.Controls.Clear()
            pnlDias.Controls.Add(tlpDias)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SP_GENERAR_TRABAJADORES()
        Try
            Dim DV As DataView = dtTrabajadores.DefaultView
            Dim filtro As String = ""

            If cklbGrupos.CheckedIndices.Count > 0 Then
                For Each grupo As Integer In cklbGrupos.CheckedIndices
                    If filtro = "" Then
                        filtro = "T_GRUPO IN (" & grupo
                    Else
                        filtro &= "," & grupo
                    End If
                Next
                filtro &= ")"
            End If

            DV.RowFilter = filtro
            dtTrabsEnLista = DV.ToTable

            tlpTrabajadores = New TableLayoutPanel
            tlpTrabajadores.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, pnlTrabajadores.Width))

            For i As Integer = 0 To dtTrabsEnLista.Rows.Count - 1
                tlpTrabajadores.RowStyles.Add(New RowStyle(SizeType.Absolute, alturaTrabajador))
                Dim btnTrabajador As New Button
                With btnTrabajador
                    .Text = dtTrabsEnLista.Rows.Item(i).Item("T_NOMBRE")
                    .Margin = New Padding(0)
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Dock = DockStyle.Fill
                    .BackColor = SF_OBTENER_COLOR_GRUPO(dtTrabsEnLista.Rows.Item(i).Item("T_GRUPO"))
                    .ForeColor = Color.White
                    .Font = lblTrabajadoresDias.Font
                    .FlatStyle = FlatStyle.Flat
                    .FlatAppearance.BorderSize = 0
                End With
                tlpTrabajadores.Controls.Add(btnTrabajador, 0, i)
            Next

            tlpTrabajadores.SetBounds(0, 0, pnlTrabajadores.Width, alturaTrabajador * dtTrabsEnLista.Rows.Count)

            pnlTrabajadores.Controls.Clear()
            pnlTrabajadores.Controls.Add(tlpTrabajadores)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SP_GENERAR_DIASXTRABAJADOR()
        Try
            tlpActividades = New TableLayoutPanel

            For i As Integer = 0 To tlpDias.ColumnStyles.Count - 1
                tlpActividades.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, anchoHora * horasMostradas))
            Next

            For i As Integer = 0 To tlpTrabajadores.RowStyles.Count - 1
                tlpActividades.RowStyles.Add(New RowStyle(SizeType.Absolute, alturaTrabajador))

                For j As Integer = 0 To tlpActividades.ColumnStyles.Count - 1
                    Dim tlpDXT As New TableLayoutPanel
                    For k As Integer = 0 To horasMostradas - 1
                        tlpDXT.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, anchoHora))
                    Next
                    With tlpDXT
                        .RowStyles.Add(New RowStyle(SizeType.Percent, 100))
                        .Dock = DockStyle.Fill
                        .Margin = New Padding(0)
                        .BackColor = u.SF_ACLARAR_COLOR(TryCast(tlpTrabajadores.GetControlFromPosition(0, i), Button).BackColor, 30)
                    End With

                    tlpActividades.Controls.Add(tlpDXT, j, i)
                Next


            Next

            tlpActividades.SetBounds(0, 0, tlpDias.Width, tlpTrabajadores.Height)

            pnlActividades.Controls.Clear()
            pnlActividades.Controls.Add(tlpActividades)

            AddHandler tlpActividades.LocationChanged, AddressOf tlpActividades_LocationChanged
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SP_GENERAR_ACTIVIDADES()
        Try
            For Each activ As DataRow In dtActividades.Rows
                Dim idT As Integer = activ.Item("ID_TRABAJADOR")
                Dim fecha As Date = activ.Item("ACTIV_FECHA")
                Dim horas As Integer = activ.Item("ACTIV_HORAS")
                Dim titulo As String = activ.Item("ACTIV_TITULO")
                Dim tipo As Integer = activ.Item("ACTIV_TIPO")
                Dim ref As String = ""
                Dim colorActiv As Color

                Select Case tipo
                    Case 1 : ref = "2017NOVOFR-67" : colorActiv = Color.FromArgb(255, 236, 153) 'BAJA POTENCIA
                    Case 2 : ref = "2017NOVOFR-29" : colorActiv = Color.FromArgb(216, 245, 162) 'TRAFO
                    Case 3 : ref = "2017NOVOFR-65" : colorActiv = Color.FromArgb(165, 216, 255) 'ALTA POTENCIA
                    Case 4 : ref = "2017SEPOPV-89" : colorActiv = Color.FromArgb(255, 216, 168) 'SOLUCIONES
                End Select

                If fecha < fechaInicio Or fecha > fechaFin Then Continue For

                Dim col As Integer = (fecha - fechaInicio).TotalDays
                Dim fil As Integer = SF_OBTENER_INDICE_TRABAJADOR(idT)

                If fil = -1 Then Continue For

                Dim tlpDXT As TableLayoutPanel = tlpActividades.GetControlFromPosition(col, fil)

                Dim horasOcupadas As Integer = 0
                For Each ctrl As Control In tlpDXT.Controls
                    horasOcupadas += tlpDXT.GetColumnSpan(ctrl)
                Next

                Dim tlpActiv As New TableLayoutPanel
                With tlpActiv
                    .BackColor = colorActiv
                    .Margin = New Padding(3)
                    .Dock = DockStyle.Fill
                    .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25))
                    .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
                    .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25))
                    .RowStyles.Add(New RowStyle(SizeType.Absolute, 23))
                    .RowStyles.Add(New RowStyle(SizeType.Percent, 100))
                    .RowStyles.Add(New RowStyle(SizeType.Absolute, 23))
                End With

                Dim lblRef As New Label
                With lblRef
                    .Text = ref
                    .Margin = New Padding(0)
                    .Dock = DockStyle.Fill
                    .TextAlign = ContentAlignment.MiddleCenter
                    .ForeColor = lblTrabajadoresDias.ForeColor
                    .BackColor = u.SF_OSCURECER_COLOR(tlpActiv.BackColor, 30)
                End With
                tlpActiv.Controls.Add(lblRef, 0, 0)
                tlpActiv.SetColumnSpan(lblRef, 3)

                Dim lblTitulo As New Label
                With lblTitulo
                    .Text = titulo
                    .Margin = New Padding(0)
                    .Dock = DockStyle.Fill
                    .TextAlign = ContentAlignment.MiddleCenter
                    .BackColor = u.SF_ACLARAR_COLOR(tlpActiv.BackColor, 60)
                    .ForeColor = u.SF_OSCURECER_COLOR(tlpActiv.BackColor, 60)
                End With
                tlpActiv.Controls.Add(lblTitulo, 0, 1)
                tlpActiv.SetColumnSpan(lblTitulo, 3)

                Dim lblHoras As New Label
                With lblHoras
                    .Text = horas & "h"
                    .Margin = New Padding(3)
                    .Dock = DockStyle.Bottom
                    .TextAlign = ContentAlignment.MiddleLeft
                    .ForeColor = u.SF_OSCURECER_COLOR(tlpActiv.BackColor, 60)
                End With
                tlpActiv.Controls.Add(lblHoras, 0, 2)
                tlpActiv.SetColumnSpan(lblHoras, 1)

                Dim btnEditar As New Button
                With btnEditar
                    .Text = ""
                    .Margin = New Padding(0)
                    .Dock = DockStyle.Fill
                    .FlatStyle = FlatStyle.Flat
                    .FlatAppearance.BorderSize = 0
                    .BackgroundImage = imlIconos.Images.Item("editar")
                    .BackgroundImageLayout = ImageLayout.Center
                    .Cursor = Cursors.Hand
                End With
                tlpActiv.Controls.Add(btnEditar, 2, 2)
                tlpActiv.SetColumnSpan(btnEditar, 1)

                tlpDXT.Controls.Add(tlpActiv, horasOcupadas, 0)
                tlpDXT.SetColumnSpan(tlpActiv, horas)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SP_GENERAR_BOTONES_AGREGAR()
        Try
            For i As Integer = 0 To tlpActividades.ColumnStyles.Count - 1
                For j As Integer = 0 To tlpActividades.RowStyles.Count - 1
                    Dim tlpDXT As TableLayoutPanel = tlpActividades.GetControlFromPosition(i, j)
                    Dim horasOcupadas As Integer = 0

                    For Each ctrl As Control In tlpDXT.Controls
                        horasOcupadas += tlpDXT.GetColumnSpan(ctrl)
                    Next

                    If horasOcupadas >= horasMostradas Then Continue For

                    Dim colorLetra As Color

                    If horasOcupadas >= horasRegulares Then
                        colorLetra = u.SF_ACLARAR_COLOR(tlpDXT.BackColor, 15)
                    Else
                        colorLetra = u.SF_ACLARAR_COLOR(tlpDXT.BackColor, 65)
                    End If

                    Dim btnAgregar As New Button
                    With btnAgregar
                        .Text = "+"
                        .Font = New Font(lblTrabajadoresDias.Font.FontFamily, 24, FontStyle.Regular)
                        .Margin = New Padding(3)
                        .TextAlign = ContentAlignment.MiddleCenter
                        .Dock = DockStyle.Fill
                        .BackColor = Color.Transparent
                        .ForeColor = colorLetra
                        .FlatStyle = FlatStyle.Flat
                        .FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 250, 250, 250)
                        .FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)
                        .FlatAppearance.BorderSize = 0
                        .Cursor = Cursors.Hand
                    End With

                    AddHandler btnAgregar.Click, AddressOf SP_AGREGAR_ACTIVIDAD

                    tlpDXT.Controls.Add(btnAgregar, horasOcupadas, 0)
                    tlpDXT.SetColumnSpan(btnAgregar, horasMostradas - horasOcupadas)
                Next

            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function SF_OBTENER_INDICE_TRABAJADOR(ByVal T_ID As Integer) As Integer
        For i As Integer = 0 To dtTrabsEnLista.Rows.Count - 1
            If dtTrabsEnLista.Rows.Item(i).Item("T_ID") = T_ID Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Function SF_OBTENER_COLOR_GRUPO(ByVal GRUPO_ID As Integer) As Color
        For Each fila As DataRow In dtGrupos.Rows
            If fila.Item("GRUPO_ID") = GRUPO_ID Then
                Dim colors() As String = fila.Item("GRUPO_COLOR").ToString.Split(";")
                Dim color As Color = color.FromArgb(colors(0), colors(1), colors(2))
                Return color
            End If
        Next
    End Function

    Private Sub tlpActividades_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            tlpDias.SetBounds(tlpActividades.Location.X, tlpDias.Location.Y, tlpDias.Width, tlpDias.Height)
        Catch ex As Exception

        End Try

        Try
            tlpTrabajadores.SetBounds(tlpTrabajadores.Location.X, tlpActividades.Location.Y, tlpTrabajadores.Width, tlpTrabajadores.Height)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cklbGrupos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cklbGrupos.SelectedIndexChanged
        If cklbGrupos.SelectedItem = "TODOS" Then
            Dim flag As Boolean = False
            For Each item As String In cklbGrupos.CheckedItems
                If item = "TODOS" Then
                    flag = True
                End If
            Next
            For i As Integer = 1 To cklbGrupos.Items.Count - 1
                cklbGrupos.SetItemChecked(i, flag)
            Next
        End If
    End Sub

    Private Sub SP_AGREGAR_ACTIVIDAD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim btnAgregar As Button = TryCast(sender, Button)
            Dim tlpDXT As TableLayoutPanel = TryCast(btnAgregar.Parent, TableLayoutPanel)
            Dim tlpActividades As TableLayoutPanel = TryCast(tlpDXT.Parent, TableLayoutPanel)
            Dim col As Integer = tlpActividades.GetPositionFromControl(tlpDXT).Column
            Dim fil As Integer = tlpActividades.GetPositionFromControl(tlpDXT).Row
            Dim dia As Date = fechaInicio.AddDays(col)

            Dim filaNueva As DataRow

            filaNueva = dtActividades.NewRow
            filaNueva.Item("ID_TRABAJADOR") = dtTrabsEnLista.Rows.Item(fil).Item("T_ID")
            filaNueva.Item("ID_REF") = 12345
            filaNueva.Item("ACTIV_TIPO") = 1
            filaNueva.Item("ACTIV_FECHA") = dia
            filaNueva.Item("ACTIV_NRO_ORDEN") = 3
            filaNueva.Item("ACTIV_HORAS") = 9
            filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
            filaNueva.Item("ACTIV_DESCRIPCION") = "Estoy probando."
            dtActividades.Rows.Add(filaNueva)

            MsgBox(dtTrabsEnLista.Rows.Item(fil).Item("T_NOMBRE") & " " & dia.ToShortDateString)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Class Trabajador

        Private _btnTrabajador As Button
        Public Property btnTrabajador() As Button
            Get
                Return _btnTrabajador
            End Get
            Set(ByVal value As Button)
                _btnTrabajador = value
            End Set
        End Property

        Private _id As Integer
        Public Property id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Private _nombre As String
        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Private _idGrupo As Integer
        Public Property idGrupo() As Integer
            Get
                Return _idGrupo
            End Get
            Set(ByVal value As Integer)
                _idGrupo = value
            End Set
        End Property

        Private _color As Color
        Public Property color() As Color
            Get
                Return _color
            End Get
            Set(ByVal value As Color)
                _color = value
            End Set
        End Property

        Private _listaDias As List(Of DiaTrabajador)
        Public Property listaDias() As List(Of DiaTrabajador)
            Get
                Return _listaDias
            End Get
            Set(ByVal value As List(Of DiaTrabajador))
                _listaDias = value
            End Set
        End Property

        Public Sub New()

        End Sub

        Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal idGrupo As Integer, ByVal color As Color, ByVal fuente As Font)
            _btnTrabajador = New Button
            _id = id
            _nombre = nombre
            _idGrupo = idGrupo
            _color = color
            _listaDias = New List(Of DiaTrabajador)

            With _btnTrabajador
                .Text = nombre
                .Margin = New Padding(0)
                .TextAlign = ContentAlignment.MiddleCenter
                .Dock = DockStyle.Fill
                .BackColor = color
                .ForeColor = color.White
                .Font = fuente
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
            End With
        End Sub

    End Class

    Private Class DiaTrabajador
        Private _tlpDXT As TableLayoutPanel
        Public Property tlpDXT() As TableLayoutPanel
            Get
                Return _tlpDXT
            End Get
            Set(ByVal value As TableLayoutPanel)
                _tlpDXT = value
            End Set
        End Property

        Private _idTrabajador As Integer
        Public Property idTrabajador() As Integer
            Get
                Return _idTrabajador
            End Get
            Set(ByVal value As Integer)
                _idTrabajador = value
            End Set
        End Property

        Private _fecha As Date
        Public Property fecha() As Date
            Get
                Return _fecha
            End Get
            Set(ByVal value As Date)
                _fecha = value
            End Set
        End Property

        Private _horas As Integer
        Public Property horas() As Integer
            Get
                Return _horas
            End Get
            Set(ByVal value As Integer)
                _horas = value
            End Set
        End Property

        Private _color As Color
        Public Property color() As Color
            Get
                Return _color
            End Get
            Set(ByVal value As Color)
                _color = value
            End Set
        End Property

        Public Sub New()

        End Sub

        Public Sub New(ByVal idTrabajador As Integer, ByVal fecha As Date, ByVal horas As Integer, ByVal color As Color)
            _idTrabajador = idTrabajador
            _fecha = fecha
            _horas = horas
            _color = color

            For i As Integer = 0 To horas - 1
                tlpDXT.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, anchoHora))
            Next
            With tlpDXT
                .RowStyles.Add(New RowStyle(SizeType.Percent, 100))
                .Dock = DockStyle.Fill
                .Margin = New Padding(0)
                .BackColor = color
            End With
        End Sub

        Public Function horasRestantes() As Integer
            Dim restante As Integer = horas
            For Each ctrl As Control In tlpDXT.Controls
                restante -= tlpDXT.GetColumnSpan(ctrl)
            Next

            Return restante
        End Function

    End Class

    Private Class Actividad

        Private u As Utiles
        Private _tlpActiv As TableLayoutPanel
        Public Property tlpActiv() As TableLayoutPanel
            Get
                Return _tlpActiv
            End Get
            Set(ByVal value As TableLayoutPanel)
                _tlpActiv = value
            End Set
        End Property

        Private _idT As Integer
        Public Property idT() As Integer
            Get
                Return _idT
            End Get
            Set(ByVal value As Integer)
                _idT = value
            End Set
        End Property

        Private _fecha As Date
        Public Property fecha() As Date
            Get
                Return _fecha
            End Get
            Set(ByVal value As Date)
                _fecha = value
            End Set
        End Property

        Private _horas As Integer
        Public Property horas() As Integer
            Get
                Return _horas
            End Get
            Set(ByVal value As Integer)
                _horas = value
            End Set
        End Property

        Private _titulo As String
        Public Property titulo() As String
            Get
                Return _titulo
            End Get
            Set(ByVal value As String)
                _titulo = value
            End Set
        End Property

        Private _tipo As Integer
        Public Property tipo() As Integer
            Get
                Return _tipo
            End Get
            Set(ByVal value As Integer)
                _tipo = value
            End Set
        End Property

        Private _ref As String
        Public Property ref() As String
            Get
                Return _ref
            End Get
            Set(ByVal value As String)
                _ref = value
            End Set
        End Property

        Private _color As Color
        Public Property color() As Color
            Get
                Return _color
            End Get
            Set(ByVal value As Color)
                _color = value
            End Set
        End Property

        Public Sub New()

        End Sub

        Public Sub New(ByVal idT As Integer, ByVal fecha As Date, ByVal horas As Integer, ByVal titulo As String, ByVal ref As String, ByVal color As Color, ByVal imgEditar As Image)
            _idT = idT
            _fecha = fecha
            _horas = horas
            _titulo = titulo
            _ref = ref
            _color = color

            tlpActiv = New TableLayoutPanel
            With tlpActiv
                .BackColor = color
                .Margin = New Padding(3)
                .Dock = DockStyle.Fill
                .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25))
                .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
                .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25))
                .RowStyles.Add(New RowStyle(SizeType.Absolute, 23))
                .RowStyles.Add(New RowStyle(SizeType.Percent, 100))
                .RowStyles.Add(New RowStyle(SizeType.Absolute, 23))
            End With

            Dim lblRef As New Label
            With lblRef
                .Text = ref
                .Margin = New Padding(0)
                .Dock = DockStyle.Fill
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = color.White
                .BackColor = u.SF_OSCURECER_COLOR(tlpActiv.BackColor, 30)
            End With
            tlpActiv.Controls.Add(lblRef, 0, 0)
            tlpActiv.SetColumnSpan(lblRef, 3)

            Dim lblTitulo As New Label
            With lblTitulo
                .Text = titulo
                .Margin = New Padding(0)
                .Dock = DockStyle.Fill
                .TextAlign = ContentAlignment.MiddleCenter
                .BackColor = u.SF_ACLARAR_COLOR(tlpActiv.BackColor, 60)
                .ForeColor = u.SF_OSCURECER_COLOR(tlpActiv.BackColor, 60)
            End With
            tlpActiv.Controls.Add(lblTitulo, 0, 1)
            tlpActiv.SetColumnSpan(lblTitulo, 3)

            Dim lblHoras As New Label
            With lblHoras
                .Text = horas & "h"
                .Margin = New Padding(3)
                .Dock = DockStyle.Bottom
                .TextAlign = ContentAlignment.MiddleLeft
                .ForeColor = u.SF_OSCURECER_COLOR(tlpActiv.BackColor, 60)
            End With
            tlpActiv.Controls.Add(lblHoras, 0, 2)
            tlpActiv.SetColumnSpan(lblHoras, 1)

            Dim btnEditar As New Button
            With btnEditar
                .Text = ""
                .Margin = New Padding(0)
                .Dock = DockStyle.Fill
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .BackgroundImage = imgEditar
                .BackgroundImageLayout = ImageLayout.Center
                .Cursor = Cursors.Hand
            End With
            tlpActiv.Controls.Add(btnEditar, 2, 2)
            tlpActiv.SetColumnSpan(btnEditar, 1)
        End Sub
    End Class

    Private Class Utiles
        Public Function SF_ACLARAR_COLOR(ByVal color As Color, ByVal porcentaje As Integer)
            Dim r As Integer = color.R
            Dim g As Integer = color.G
            Dim b As Integer = color.B

            Dim min As Integer = Math.Min(Math.Min(r, g), b)
            Dim sumar As Integer = (255 - min) * porcentaje / 100

            r += sumar
            g += sumar
            b += sumar

            Dim colorNuevo As Color = color.FromArgb(IIf(r > 255, 255, r), IIf(g > 255, 255, g), IIf(b > 255, 255, b))
            Return colorNuevo
        End Function

        Public Function SF_OSCURECER_COLOR(ByVal color As Color, ByVal porcentaje As Integer)
            Dim r As Integer = color.R
            Dim g As Integer = color.G
            Dim b As Integer = color.B

            Dim max As Integer = Math.Max(Math.Max(r, g), b)
            Dim restar As Integer = (max) * porcentaje / 100

            r -= restar
            g -= restar
            b -= restar

            Dim colorNuevo As Color = color.FromArgb(IIf(r < 0, 0, r), IIf(g < 0, 0, g), IIf(b < 0, 0, b))
            Return colorNuevo
        End Function
    End Class
End Class


