<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.pnlPrincipal = New System.Windows.Forms.Panel
        Me.pnlActividades = New System.Windows.Forms.Panel
        Me.pnlTrabajadores = New System.Windows.Forms.Panel
        Me.pnlCabecera = New System.Windows.Forms.Panel
        Me.pnlDias = New System.Windows.Forms.Panel
        Me.pnlCruce = New System.Windows.Forms.Panel
        Me.lblTrabajadoresDias = New System.Windows.Forms.Label
        Me.TableLayoutPanel54 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel83 = New System.Windows.Forms.TableLayoutPanel
        Me.calFechas = New System.Windows.Forms.MonthCalendar
        Me.Label6 = New System.Windows.Forms.Label
        Me.cklbGrupos = New System.Windows.Forms.CheckedListBox
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.imlIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.pnlCruce.SuspendLayout()
        Me.TableLayoutPanel83.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.pnlActividades)
        Me.pnlPrincipal.Controls.Add(Me.pnlTrabajadores)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 50)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnlPrincipal.Size = New System.Drawing.Size(934, 552)
        Me.pnlPrincipal.TabIndex = 1
        '
        'pnlActividades
        '
        Me.pnlActividades.AutoScroll = True
        Me.pnlActividades.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pnlActividades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlActividades.Location = New System.Drawing.Point(200, 0)
        Me.pnlActividades.Name = "pnlActividades"
        Me.pnlActividades.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnlActividades.Size = New System.Drawing.Size(734, 552)
        Me.pnlActividades.TabIndex = 1
        '
        'pnlTrabajadores
        '
        Me.pnlTrabajadores.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pnlTrabajadores.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTrabajadores.Location = New System.Drawing.Point(0, 0)
        Me.pnlTrabajadores.Name = "pnlTrabajadores"
        Me.pnlTrabajadores.Size = New System.Drawing.Size(200, 552)
        Me.pnlTrabajadores.TabIndex = 2
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.pnlDias)
        Me.pnlCabecera.Controls.Add(Me.pnlCruce)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnlCabecera.Size = New System.Drawing.Size(934, 50)
        Me.pnlCabecera.TabIndex = 2
        '
        'pnlDias
        '
        Me.pnlDias.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.pnlDias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDias.Location = New System.Drawing.Point(200, 0)
        Me.pnlDias.Name = "pnlDias"
        Me.pnlDias.Size = New System.Drawing.Size(734, 50)
        Me.pnlDias.TabIndex = 4
        '
        'pnlCruce
        '
        Me.pnlCruce.Controls.Add(Me.lblTrabajadoresDias)
        Me.pnlCruce.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCruce.Location = New System.Drawing.Point(0, 0)
        Me.pnlCruce.Name = "pnlCruce"
        Me.pnlCruce.Size = New System.Drawing.Size(200, 50)
        Me.pnlCruce.TabIndex = 3
        '
        'lblTrabajadoresDias
        '
        Me.lblTrabajadoresDias.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblTrabajadoresDias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTrabajadoresDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrabajadoresDias.ForeColor = System.Drawing.Color.White
        Me.lblTrabajadoresDias.Location = New System.Drawing.Point(0, 0)
        Me.lblTrabajadoresDias.Name = "lblTrabajadoresDias"
        Me.lblTrabajadoresDias.Size = New System.Drawing.Size(200, 50)
        Me.lblTrabajadoresDias.TabIndex = 0
        Me.lblTrabajadoresDias.Text = "Trabajadores \ Días"
        Me.lblTrabajadoresDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel54
        '
        Me.TableLayoutPanel54.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TableLayoutPanel54.ColumnCount = 12
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel54.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel54.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel54.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel54.Name = "TableLayoutPanel54"
        Me.TableLayoutPanel54.RowCount = 1
        Me.TableLayoutPanel54.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel54.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel54.TabIndex = 0
        '
        'TableLayoutPanel83
        '
        Me.TableLayoutPanel83.ColumnCount = 3
        Me.TableLayoutPanel83.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel83.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel83.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel83.Controls.Add(Me.calFechas, 0, 3)
        Me.TableLayoutPanel83.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel83.Controls.Add(Me.cklbGrupos, 0, 1)
        Me.TableLayoutPanel83.Controls.Add(Me.btnConsultar, 0, 5)
        Me.TableLayoutPanel83.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel83.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel83.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel83.Name = "TableLayoutPanel83"
        Me.TableLayoutPanel83.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel83.RowCount = 7
        Me.TableLayoutPanel83.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel83.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel83.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel83.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel83.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel83.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel83.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel83.Size = New System.Drawing.Size(254, 602)
        Me.TableLayoutPanel83.TabIndex = 0
        '
        'calFechas
        '
        Me.TableLayoutPanel83.SetColumnSpan(Me.calFechas, 3)
        Me.calFechas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.calFechas.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.calFechas.Location = New System.Drawing.Point(0, 165)
        Me.calFechas.Margin = New System.Windows.Forms.Padding(0)
        Me.calFechas.MaxSelectionCount = 365
        Me.calFechas.Name = "calFechas"
        Me.calFechas.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Grupos:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cklbGrupos
        '
        Me.cklbGrupos.CheckOnClick = True
        Me.TableLayoutPanel83.SetColumnSpan(Me.cklbGrupos, 3)
        Me.cklbGrupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cklbGrupos.FormattingEnabled = True
        Me.cklbGrupos.IntegralHeight = False
        Me.cklbGrupos.Location = New System.Drawing.Point(3, 28)
        Me.cklbGrupos.MultiColumn = True
        Me.cklbGrupos.Name = "cklbGrupos"
        Me.cklbGrupos.Size = New System.Drawing.Size(248, 114)
        Me.cklbGrupos.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = CType(resources.GetObject("btnConsultar.BackgroundImage"), System.Drawing.Image)
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConsultar.FlatAppearance.BorderSize = 0
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Location = New System.Drawing.Point(3, 340)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(44, 44)
        Me.btnConsultar.TabIndex = 5
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel83.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Rango de fechas:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imlIconos
        '
        Me.imlIconos.ImageStream = CType(resources.GetObject("imlIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imlIconos.Images.SetKeyName(0, "editar")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel83)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlPrincipal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlCabecera)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1192, 602)
        Me.SplitContainer1.SplitterDistance = 254
        Me.SplitContainer1.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 608)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form2"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planificación de Horas - Empresa: ELISE S.A.C."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCruce.ResumeLayout(False)
        Me.TableLayoutPanel83.ResumeLayout(False)
        Me.TableLayoutPanel83.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pnlActividades As System.Windows.Forms.Panel
    Friend WithEvents pnlTrabajadores As System.Windows.Forms.Panel
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents pnlDias As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel54 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel83 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cklbGrupos As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlCruce As System.Windows.Forms.Panel
    Friend WithEvents lblTrabajadoresDias As System.Windows.Forms.Label
    Friend WithEvents imlIconos As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents calFechas As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
