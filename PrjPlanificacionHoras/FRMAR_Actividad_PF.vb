Public Class FRMAR_Actividad_PF

    Private dtTipo As DataTable

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        SP_OBTENER_TIPO()
        SP_LLENAR_TIPO()
    End Sub

    Private Sub FRMAR_Actividad_PF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SP_OBTENER_TIPO()
        dtTipo = New DataTable
        dtTipo.Columns.Add("NUMERO")
        dtTipo.Columns.Add("DESCRIPCION")
        dtTipo.Columns.Add("COLOR")

        Dim nuevaFila As DataRow

        nuevaFila = dtTipo.NewRow
        nuevaFila.Item("NUMERO") = 0
        nuevaFila.Item("DESCRIPCION") = "--SELECCIONE--"
        nuevaFila.Item("COLOR") = ""
        dtTipo.Rows.Add(nuevaFila)

        nuevaFila = dtTipo.NewRow
        nuevaFila.Item("NUMERO") = 1
        nuevaFila.Item("DESCRIPCION") = "BAJA POTENCIA"
        nuevaFila.Item("COLOR") = "255;236;153"
        dtTipo.Rows.Add(nuevaFila)

        nuevaFila = dtTipo.NewRow
        nuevaFila.Item("NUMERO") = 2
        nuevaFila.Item("DESCRIPCION") = "TRAFO"
        nuevaFila.Item("COLOR") = "216;245;162"
        dtTipo.Rows.Add(nuevaFila)

        nuevaFila = dtTipo.NewRow
        nuevaFila.Item("NUMERO") = 3
        nuevaFila.Item("DESCRIPCION") = "ALTA POTENCIA"
        nuevaFila.Item("COLOR") = "165;216;255"
        dtTipo.Rows.Add(nuevaFila)

        nuevaFila = dtTipo.NewRow
        nuevaFila.Item("NUMERO") = 4
        nuevaFila.Item("DESCRIPCION") = "SOLUCIONES"
        nuevaFila.Item("COLOR") = "255;216;168"
        dtTipo.Rows.Add(nuevaFila)
    End Sub

    Private Sub SP_LLENAR_TIPO()
        cboTipo.DataSource = Nothing

        cboTipo.DataSource = dtTipo
        cboTipo.DisplayMember = "DESCRIPCION"
        cboTipo.ValueMember = "NUMERO"
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        
    End Sub

    Private Sub cboTipo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectionChangeCommitted
        Dim ref As String = ""
        Dim titulo As String = ""
        Select Case cboTipo.SelectedValue
            Case 1 : ref = "2017NOVOFR-67" : titulo = "PRUEBA BAJA POTENCIA"
            Case 2 : ref = "2017NOVOFR-29" : titulo = "PRUEBA TRAFO"
            Case 3 : ref = "2017NOVOFR-65" : titulo = "PRUEBA ALTA POTENCIA"
            Case 4 : ref = "2017SEPOPV-89" : titulo = "PRUEBA SOLUCIONES"
            Case Else : ref = ""
        End Select
        txtReferencia.Text = ref
        txtTitulo.Text = titulo
    End Sub
End Class