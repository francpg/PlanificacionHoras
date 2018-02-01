Public Class FRMCL_PlanificacionHoras_PF
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
    Private Const anchoHora As Integer = 54
    Private Const alturaTrabajador As Integer = 84

    Private u As New Utiles
    Private listaDias As List(Of Dia)
    Private listaTrabajadores As List(Of Trabajador)

    Private Sub FRMCL_PlanificacionHoras_PF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        dtActividades.Columns.Add("ACTIV_DETALLE", System.Type.GetType("System.String"))
        dtActividades.Columns.Add("ACTIV_TERMINADA", System.Type.GetType("System.Int32"))

        Dim filaNueva As DataRow

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 1
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 9
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 1
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 9
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 1
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 3
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 1
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 2
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 3
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(2)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 3
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 3
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(4)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "ENCONTRAR 2018ENEOPV-5"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 4
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 4
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 2
        filaNueva.Item("ACTIV_HORAS") = 5
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 4
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 5
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(3)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 6
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 2
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 7
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 3
        filaNueva.Item("ACTIV_FECHA") = Today
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 4
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 8
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 4
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(3)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 3
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

        filaNueva = dtActividades.NewRow
        filaNueva.Item("ID_TRABAJADOR") = 9
        filaNueva.Item("ID_REF") = 12345
        filaNueva.Item("ACTIV_TIPO") = 1
        filaNueva.Item("ACTIV_FECHA") = Today.AddDays(1)
        filaNueva.Item("ACTIV_NRO_ORDEN") = 1
        filaNueva.Item("ACTIV_HORAS") = 6
        filaNueva.Item("ACTIV_TITULO") = "PRUEBA"
        filaNueva.Item("ACTIV_DETALLE") = "Estoy probando."
        filaNueva.Item("ACTIV_TERMINADA") = 0
        dtActividades.Rows.Add(filaNueva)

    End Sub

    Private Sub SP_GENERAR_DIAS()
        Try
            Dim rangoDias As System.TimeSpan = fechaFin - fechaInicio

            Dim fecha As Date = fechaInicio

            listaDias = New List(Of Dia)
            tlpDias = New TableLayoutPanel
            tlpDias.RowStyles.Add(New RowStyle(SizeType.Absolute, 50))

            For i As Integer = 0 To rangoDias.Days
                tlpDias.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, horasMostradas * anchoHora))
                Dim btnDia As New Dia(fecha, Me.lblTrabajadoresDias.BackColor, Me.lblTrabajadoresDias.ForeColor, Me.lblTrabajadoresDias.Font)

                listaDias.Add(btnDia)
                tlpDias.Controls.Add(btnDia, i, 0)
                fecha = fecha.AddDays(1)
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

            listaTrabajadores = New List(Of Trabajador)

            tlpTrabajadores = New TableLayoutPanel
            tlpTrabajadores.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, pnlTrabajadores.Width))

            For i As Integer = 0 To dtTrabsEnLista.Rows.Count - 1
                tlpTrabajadores.RowStyles.Add(New RowStyle(SizeType.Absolute, alturaTrabajador))
                Dim btnTrabajador As New Trabajador(dtTrabsEnLista.Rows.Item(i).Item("T_ID"), _
                                                    dtTrabsEnLista.Rows.Item(i).Item("T_NOMBRE"), _
                                                    dtTrabsEnLista.Rows.Item(i).Item("T_GRUPO"), _
                                                    SF_OBTENER_COLOR_GRUPO(dtTrabsEnLista.Rows.Item(i).Item("T_GRUPO")), _
                                                    lblTrabajadoresDias.Font)
                listaTrabajadores.Add(btnTrabajador)
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
                    Dim tlpDXT As New DiaTrabajador(listaTrabajadores.Item(i).id, _
                                                    listaDias.Item(j).fecha, _
                                                    horasMostradas, _
                                                    False, _
                                                    u.SF_ACLARAR_COLOR(listaTrabajadores.Item(i).color, 30))
                    listaTrabajadores.Item(i).listaDias.Add(tlpDXT)

                    AddHandler tlpDXT.Paint, AddressOf SP_PINTAR_BORDE_DERECHA
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
                Dim nroOrden As Integer = activ.Item("ACTIV_NRO_ORDEN")
                Dim horas As Integer = activ.Item("ACTIV_HORAS")
                Dim titulo As String = activ.Item("ACTIV_TITULO")
                Dim detalle As String = activ.Item("ACTIV_DETALLE")
                Dim tipo As Integer = activ.Item("ACTIV_TIPO")
                Dim idRef As Integer = 12345
                Dim terminada As Boolean = activ.Item("ACTIV_TERMINADA")

                Dim colorActiv As Color

                Select Case tipo
                    Case 1 : colorActiv = Color.FromArgb(255, 236, 153) 'BAJA POTENCIA
                    Case 2 : colorActiv = Color.FromArgb(216, 245, 162) 'TRAFO
                    Case 3 : colorActiv = Color.FromArgb(165, 216, 255) 'ALTA POTENCIA
                    Case 4 : colorActiv = Color.FromArgb(255, 216, 168) 'SOLUCIONES
                End Select

                If fecha < fechaInicio Or fecha > fechaFin Then Continue For

                Dim col As Integer = (fecha - fechaInicio).TotalDays
                Dim fil As Integer = SF_OBTENER_INDICE_TRABAJADOR(idT)

                If fil = -1 Then Continue For

                Dim tlpDXT As DiaTrabajador = tlpActividades.GetControlFromPosition(col, fil)

                Dim tlpActiv As New Actividad(idT, fecha, nroOrden, tipo, idRef, horas, titulo, detalle, terminada, colorActiv, imlIconos.Images.Item("editar"))
                AddHandler tlpActiv.btnEditar.Click, AddressOf SP_EDITAR_ACTIVIDAD

                tlpDXT.listaActividades.Add(tlpActiv)

                tlpDXT.Controls.Add(tlpActiv, tlpDXT.horasOcupadas, 0)
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

    Private Function SF_OBTENER_INDICE_DIA(ByVal fecha As Date) As Integer
        For i As Integer = 0 To listaDias.Count - 1
            If listaDias.Item(i).fecha = fecha Then
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
            Dim tlpDXT As DiaTrabajador = TryCast(btnAgregar.Parent, DiaTrabajador)

            Dim t As Trabajador = listaTrabajadores(SF_OBTENER_INDICE_TRABAJADOR(tlpDXT.idTrabajador))

            Dim objFrm As New FRMAR_Actividad_PF
            objFrm.txtTrabajador.Text = t.nombre
            objFrm.dtpFecha.Value = tlpDXT.fecha

            Dim DR As DialogResult = objFrm.ShowDialog()

            If DR = Windows.Forms.DialogResult.Cancel Then Exit Sub

            Dim filaNueva As DataRow

            filaNueva = dtActividades.NewRow
            filaNueva.Item("ID_TRABAJADOR") = tlpDXT.idTrabajador
            filaNueva.Item("ACTIV_FECHA") = tlpDXT.fecha
            filaNueva.Item("ACTIV_NRO_ORDEN") = tlpDXT.cantActivs
            filaNueva.Item("ACTIV_TIPO") = objFrm.cboTipo.SelectedValue
            filaNueva.Item("ID_REF") = "12345"
            filaNueva.Item("ACTIV_HORAS") = objFrm.nudHoras.Value
            filaNueva.Item("ACTIV_TITULO") = objFrm.txtTitulo.Text
            filaNueva.Item("ACTIV_DETALLE") = objFrm.txtDetalle.Text
            filaNueva.Item("ACTIV_TERMINADA") = objFrm.ckbTerminada.Checked
            dtActividades.Rows.Add(filaNueva)

            tlpDXT.Controls.Clear()

            Dim DV As DataView = dtActividades.DefaultView
            Dim filtro As String = "ID_TRABAJADOR = " & tlpDXT.idTrabajador & " AND " & _
                                   "ACTIV_FECHA = '" & tlpDXT.fecha.ToShortDateString & "'"
            DV.RowFilter = filtro

            For Each activ As DataRow In DV.ToTable.Rows
                Dim idT As Integer = activ.Item("ID_TRABAJADOR")
                Dim fecha As Date = activ.Item("ACTIV_FECHA")
                Dim nroOrden As Integer = activ.Item("ACTIV_NRO_ORDEN")
                Dim horas As Integer = activ.Item("ACTIV_HORAS")
                Dim titulo As String = activ.Item("ACTIV_TITULO")
                Dim detalle As String = activ.Item("ACTIV_DETALLE")
                Dim tipo As Integer = activ.Item("ACTIV_TIPO")
                Dim idRef As Integer = 12345
                Dim terminada As Boolean = activ.Item("ACTIV_TERMINADA")

                Dim colorActiv As Color

                Select Case tipo
                    Case 1 : colorActiv = Color.FromArgb(255, 236, 153) 'BAJA POTENCIA
                    Case 2 : colorActiv = Color.FromArgb(216, 245, 162) 'TRAFO
                    Case 3 : colorActiv = Color.FromArgb(165, 216, 255) 'ALTA POTENCIA
                    Case 4 : colorActiv = Color.FromArgb(255, 216, 168) 'SOLUCIONES
                End Select

                If fecha < fechaInicio Or fecha > fechaFin Then Continue For

                Dim tlpActiv As New Actividad(idT, fecha, nroOrden, tipo, idRef, horas, titulo, detalle, terminada, colorActiv, imlIconos.Images.Item("editar"))
                AddHandler tlpActiv.btnEditar.Click, AddressOf SP_EDITAR_ACTIVIDAD

                tlpDXT.listaActividades.Add(tlpActiv)
                tlpDXT.Controls.Add(tlpActiv, tlpDXT.horasOcupadas, 0)
                tlpDXT.SetColumnSpan(tlpActiv, horas)
            Next

            Dim horasOcupadas As Integer = 0

            For Each ctrl As Control In tlpDXT.Controls
                horasOcupadas += tlpDXT.GetColumnSpan(ctrl)
            Next

            If horasOcupadas >= horasMostradas Then Exit Sub

            Dim colorLetra As Color

            If horasOcupadas >= horasRegulares Then
                colorLetra = u.SF_ACLARAR_COLOR(tlpDXT.BackColor, 15)
            Else
                colorLetra = u.SF_ACLARAR_COLOR(tlpDXT.BackColor, 65)
            End If

            btnAgregar = New Button
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

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Mensaje del Sistema")
        End Try

    End Sub

    Private Sub SP_EDITAR_ACTIVIDAD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim btnEditar As Button = TryCast(sender, Button)
            Dim tlpActiv As Actividad = TryCast(btnEditar.Parent, Actividad)

            Dim t As Trabajador = listaTrabajadores(SF_OBTENER_INDICE_TRABAJADOR(tlpActiv.idT))

            Dim objFrm As New FRMAR_Actividad_PF

            objFrm.txtTrabajador.Text = t.nombre
            objFrm.dtpFecha.Value = tlpActiv.fecha
            objFrm.txtReferencia.Text = "SE OBTENDRÁ DE: " & tlpActiv.idRef
            objFrm.cboTipo.SelectedValue = tlpActiv.tipo
            objFrm.nudHoras.Value = tlpActiv.horas
            objFrm.txtTitulo.Text = tlpActiv.titulo
            objFrm.txtDetalle.Text = tlpActiv.detalle
            objFrm.ckbTerminada.Checked = tlpActiv.terminada

            Dim DR As DialogResult = objFrm.ShowDialog()

            If DR = Windows.Forms.DialogResult.Cancel Then Exit Sub

            Dim filaEditar As DataRow

            For Each fila As DataRow In dtActividades.Rows
                If fila.Item("ID_TRABAJADOR") = tlpActiv.idT And _
                   fila.Item("ACTIV_FECHA") = tlpActiv.fecha And _
                   fila.Item("ACTIV_NRO_ORDEN") = tlpActiv.nroOrden Then
                    filaEditar = fila
                End If
            Next

            If Not filaEditar Is Nothing Then
                filaEditar.Item("ID_TRABAJADOR") = tlpActiv.idT
                filaEditar.Item("ACTIV_FECHA") = tlpActiv.fecha
                filaEditar.Item("ACTIV_NRO_ORDEN") = tlpActiv.nroOrden
                filaEditar.Item("ID_REF") = "12345"
                filaEditar.Item("ACTIV_TIPO") = objFrm.cboTipo.SelectedValue
                filaEditar.Item("ACTIV_HORAS") = objFrm.nudHoras.Value
                filaEditar.Item("ACTIV_TITULO") = objFrm.txtTitulo.Text
                filaEditar.Item("ACTIV_DETALLE") = objFrm.txtDetalle.Text
                filaEditar.Item("ACTIV_TERMINADA") = objFrm.ckbTerminada.Checked
            End If

            SP_GENERAR_DIASXTRABAJADOR()
            SP_GENERAR_ACTIVIDADES()
            SP_GENERAR_BOTONES_AGREGAR()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Mensaje del Sistema")
        End Try

    End Sub

    Private Class Dia
        Inherits System.Windows.Forms.Button

        Private _fecha As Date
        Public Property fecha() As Date
            Get
                Return _fecha
            End Get
            Set(ByVal value As Date)
                _fecha = value
            End Set
        End Property

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal fecha As Date, ByVal colorFondo As Color, ByVal colorLetra As Color, ByVal fuente As Font)
            Me._fecha = fecha
            Me.Text = fecha.ToString("dddd").ToUpper & vbNewLine & fecha.ToString("dd/MM/yyyy")
            Me.Margin = New Padding(0)
            Me.TextAlign = ContentAlignment.MiddleCenter
            Me.Dock = DockStyle.Fill
            Me.BackColor = colorFondo
            Me.ForeColor = colorLetra
            Me.Font = fuente
            Me.FlatStyle = FlatStyle.Flat
            Me.FlatAppearance.BorderSize = 0
        End Sub
    End Class

    Private Class Trabajador
        Inherits System.Windows.Forms.Button

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
            MyBase.New()
        End Sub

        Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal idGrupo As Integer, ByVal color As Color, ByVal fuente As Font)
            MyBase.New()
            Me._id = id
            Me._nombre = nombre
            Me._idGrupo = idGrupo
            Me._color = color
            Me._listaDias = New List(Of DiaTrabajador)
            Me.Text = nombre
            Me.Margin = New Padding(0)
            Me.TextAlign = ContentAlignment.MiddleCenter
            Me.Dock = DockStyle.Fill
            Me.BackColor = color
            Me.ForeColor = color.White
            Me.Font = fuente
            Me.FlatStyle = FlatStyle.Flat
            Me.FlatAppearance.BorderSize = 0
        End Sub

    End Class

    Private Class DiaTrabajador
        Inherits TableLayoutPanel

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

        Private _terminada As Boolean
        Public Property terminada() As Boolean
            Get
                Return _terminada
            End Get
            Set(ByVal value As Boolean)
                _terminada = value
            End Set
        End Property

        Private _listaActividades As List(Of Actividad)
        Public Property listaActividades() As List(Of Actividad)
            Get
                Return _listaActividades
            End Get
            Set(ByVal value As List(Of Actividad))
                _listaActividades = value
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
            MyBase.New()
        End Sub

        Public Sub New(ByVal idTrabajador As Integer, ByVal fecha As Date, ByVal horas As Integer, ByVal terminada As Boolean, ByVal color As Color)
            MyBase.New()

            _idTrabajador = idTrabajador
            _fecha = fecha
            _horas = horas
            _terminada = terminada
            _color = color
            _listaActividades = New List(Of Actividad)

            For i As Integer = 0 To horas - 1
                Me.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, anchoHora))
            Next

            Me.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            Me.Dock = DockStyle.Fill
            Me.Margin = New Padding(0)
            Me.BackColor = color

        End Sub

        Public Function horasRestantes() As Integer
            Dim restante As Integer = horas
            For Each ctrl As Control In Me.Controls
                If ctrl.GetType.ToString <> "System.Windows.Forms.Button" Then
                    Dim activ As Actividad = TryCast(ctrl, Actividad)
                    restante -= activ.horas
                End If
            Next

            Return restante
        End Function

        Public Function horasOcupadas() As Integer
            Dim ocupadas As Integer = 0
            For Each ctrl As Control In Me.Controls
                If ctrl.GetType.ToString <> "System.Windows.Forms.Button" Then
                    Dim activ As Actividad = TryCast(ctrl, Actividad)
                    ocupadas += activ.horas
                End If
            Next

            Return ocupadas
        End Function

        Public Function cantActivs() As Integer
            Dim cant As Integer = 0
            For Each ctrl As Control In Me.Controls
                If ctrl.GetType.ToString <> "System.Windows.Forms.Button" Then
                    cant += 1
                End If
            Next
            Return cant
        End Function
    End Class

    Private Class Actividad
        Inherits TableLayoutPanel

        Private u As New Utiles

        Private _btnEditar As Button
        Public Property btnEditar() As Button
            Get
                Return _btnEditar
            End Get
            Set(ByVal value As Button)
                _btnEditar = value
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

        Private _nroOrden As Integer
        Public Property nroOrden() As Integer
            Get
                Return _nroOrden
            End Get
            Set(ByVal value As Integer)
                _nroOrden = value
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

        Private _idRef As Integer
        Public Property idRef() As Integer
            Get
                Return _idRef
            End Get
            Set(ByVal value As Integer)
                _idRef = value
            End Set
        End Property

        Private _detalle As String
        Public Property detalle() As String
            Get
                Return _detalle
            End Get
            Set(ByVal value As String)
                _detalle = value
            End Set
        End Property

        Private _terminada As Boolean
        Public Property terminada() As Boolean
            Get
                Return _terminada
            End Get
            Set(ByVal value As Boolean)
                _terminada = value
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
            MyBase.New()
        End Sub

        Public Sub New(ByVal idT As Integer, ByVal fecha As Date, ByVal nroOrden As Integer, ByVal tipo As Integer, ByVal idRef As Integer, ByVal horas As Integer, ByVal titulo As String, ByVal detalle As String, ByVal terminada As Boolean, ByVal color As Color, ByVal imgEditar As Image)
            MyBase.New()
            _idT = idT
            _fecha = fecha
            _nroOrden = nroOrden
            _tipo = tipo
            _idRef = idRef
            _horas = horas
            _titulo = titulo
            _detalle = detalle
            _terminada = terminada
            _color = color

            Me.BackColor = color
            Me.Margin = New Padding(3)
            Me.Dock = DockStyle.Fill
            Me.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25))
            Me.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
            Me.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25))
            Me.RowStyles.Add(New RowStyle(SizeType.Absolute, 23))
            Me.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            Me.RowStyles.Add(New RowStyle(SizeType.Absolute, 23))

            Dim lblRef As New Label
            With lblRef
                .Text = "SE OBTENDRÁ"
                .Margin = New Padding(0)
                .Padding = New Padding(0, 5, 0, 5)
                .Dock = DockStyle.Fill
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = color.White
                .BackColor = u.SF_OSCURECER_COLOR(Me.BackColor, 30)
            End With
            Me.Controls.Add(lblRef, 0, 0)
            Me.SetColumnSpan(lblRef, 3)

            Dim lblTitulo As New Label
            With lblTitulo
                .Text = titulo
                .Margin = New Padding(0)
                .Dock = DockStyle.Fill
                .TextAlign = ContentAlignment.MiddleCenter
                .BackColor = u.SF_ACLARAR_COLOR(Me.BackColor, 60)
                .ForeColor = u.SF_OSCURECER_COLOR(Me.BackColor, 60)
            End With
            Me.Controls.Add(lblTitulo, 0, 1)
            Me.SetColumnSpan(lblTitulo, 3)

            Dim lblHoras As New Label
            With lblHoras
                .Text = horas & "h"
                .Margin = New Padding(0)
                .Padding = New Padding(0)
                .Dock = DockStyle.Bottom
                .TextAlign = ContentAlignment.MiddleLeft
                .ForeColor = u.SF_OSCURECER_COLOR(Me.BackColor, 60)
            End With
            Me.Controls.Add(lblHoras, 0, 2)
            Me.SetColumnSpan(lblHoras, 1)

            Dim lblTerminada As New Label
            With lblTerminada
                .Text = IIf(terminada, "TERMINADA", "")
                .Margin = New Padding(0)
                .Padding = New Padding(0, 5, 0, 5)
                .Dock = DockStyle.Bottom
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = u.SF_OSCURECER_COLOR(Me.BackColor, 60)
            End With
            Me.Controls.Add(lblTerminada, 1, 2)
            Me.SetColumnSpan(lblTerminada, 1)

            _btnEditar = New Button
            With _btnEditar
                .Text = ""
                .Margin = New Padding(0)
                .Dock = DockStyle.Fill
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .BackgroundImage = imgEditar
                .BackgroundImageLayout = ImageLayout.Center
                .Cursor = Cursors.Hand
            End With

            Me.Controls.Add(btnEditar, 2, 2)
            Me.SetColumnSpan(btnEditar, 1)
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

    Private Sub SP_PINTAR_BORDE_DERECHA(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim tlpDXT As DiaTrabajador = TryCast(sender, DiaTrabajador)
        ControlPaint.DrawBorder(e.Graphics, _
                                tlpDXT.ClientRectangle, _
                                Color.White, _
                                0, _
                                ButtonBorderStyle.None, _
                                Color.White, _
                                0, _
                                ButtonBorderStyle.None, _
                                Color.FromArgb(95, 134, 142, 150), _
                                1, _
                                ButtonBorderStyle.Solid, _
                                Color.White, _
                                0, _
                                ButtonBorderStyle.None)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text.Equals("") Then Exit Sub

        For Each t As Trabajador In listaTrabajadores
            For Each d As DiaTrabajador In t.listaDias
                For Each a As Actividad In d.listaActividades
                    For Each ctrl As Control In a.Controls
                        If ctrl.GetType().ToString = "System.Windows.Forms.Label" Then
                            Dim lblAux As Label = TryCast(ctrl, Label)
                            If lblAux.Text.ToUpper Like "*" & txtBuscar.Text.ToUpper & "*" Then
                                pnlActividades.VerticalScroll.Value = SF_OBTENER_INDICE_TRABAJADOR(t.id) * alturaTrabajador
                                pnlActividades.HorizontalScroll.Value = SF_OBTENER_INDICE_DIA(d.fecha) * horasMostradas * anchoHora
                                pnlActividades.AutoScroll = True 'para que se actualizen los scroll.
                                Exit Sub
                            End If
                        End If
                    Next
                Next
            Next
        Next

        MsgBox("No se encontró el texto ingresado.", MsgBoxStyle.Information, "Mensaje del Sistema")
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub
End Class


