<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoProceso
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.lblTiempoEjecucion = New System.Windows.Forms.Label()
        Me.lblMemoriaOcupada = New System.Windows.Forms.Label()
        Me.lblTamaño = New System.Windows.Forms.Label()
        Me.lblEstadoT = New System.Windows.Forms.Label()
        Me.lblTiempoInicioT = New System.Windows.Forms.Label()
        Me.lblTiempoEjecucionT = New System.Windows.Forms.Label()
        Me.lblTiempoFinalizacionT = New System.Windows.Forms.Label()
        Me.lblTiempoActualT = New System.Windows.Forms.Label()
        Me.lblMemoriaOcupadaT = New System.Windows.Forms.Label()
        Me.lblTamañoT = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.lblDireccionMemoria = New System.Windows.Forms.Label()
        Me.lblParticionAsignadaT = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Purple
        Me.lblNombre.Location = New System.Drawing.Point(21, 27)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(103, 42)
        Me.lblNombre.TabIndex = 27
        Me.lblNombre.Text = "Task 1"
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Black
        Me.lblEstado.Location = New System.Drawing.Point(3, 27)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(122, 30)
        Me.lblEstado.TabIndex = 28
        Me.lblEstado.Text = "-"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraInicio.AutoSize = True
        Me.lblHoraInicio.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraInicio.Location = New System.Drawing.Point(259, 27)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(122, 30)
        Me.lblHoraInicio.TabIndex = 29
        Me.lblHoraInicio.Text = "00:00:00"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDuracion
        '
        Me.lblDuracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(3, 27)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(122, 30)
        Me.lblDuracion.TabIndex = 30
        Me.lblDuracion.Text = "0 seg."
        Me.lblDuracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraFin.AutoSize = True
        Me.lblHoraFin.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraFin.Location = New System.Drawing.Point(387, 27)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(122, 30)
        Me.lblHoraFin.TabIndex = 32
        Me.lblHoraFin.Text = "00:00:00"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTiempoEjecucion
        '
        Me.lblTiempoEjecucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTiempoEjecucion.AutoSize = True
        Me.lblTiempoEjecucion.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoEjecucion.Location = New System.Drawing.Point(131, 27)
        Me.lblTiempoEjecucion.Name = "lblTiempoEjecucion"
        Me.lblTiempoEjecucion.Size = New System.Drawing.Size(122, 30)
        Me.lblTiempoEjecucion.TabIndex = 33
        Me.lblTiempoEjecucion.Text = "0 seg."
        Me.lblTiempoEjecucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMemoriaOcupada
        '
        Me.lblMemoriaOcupada.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMemoriaOcupada.AutoSize = True
        Me.lblMemoriaOcupada.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemoriaOcupada.Location = New System.Drawing.Point(387, 27)
        Me.lblMemoriaOcupada.Name = "lblMemoriaOcupada"
        Me.lblMemoriaOcupada.Size = New System.Drawing.Size(122, 30)
        Me.lblMemoriaOcupada.TabIndex = 35
        Me.lblMemoriaOcupada.Text = "0%"
        Me.lblMemoriaOcupada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTamaño
        '
        Me.lblTamaño.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTamaño.AutoSize = True
        Me.lblTamaño.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamaño.Location = New System.Drawing.Point(131, 27)
        Me.lblTamaño.Name = "lblTamaño"
        Me.lblTamaño.Size = New System.Drawing.Size(122, 30)
        Me.lblTamaño.TabIndex = 36
        Me.lblTamaño.Text = "0kb"
        Me.lblTamaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEstadoT
        '
        Me.lblEstadoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstadoT.AutoSize = True
        Me.lblEstadoT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoT.ForeColor = System.Drawing.Color.DimGray
        Me.lblEstadoT.Location = New System.Drawing.Point(3, 3)
        Me.lblEstadoT.Name = "lblEstadoT"
        Me.lblEstadoT.Size = New System.Drawing.Size(122, 15)
        Me.lblEstadoT.TabIndex = 28
        Me.lblEstadoT.Text = "Estado"
        Me.lblEstadoT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTiempoInicioT
        '
        Me.lblTiempoInicioT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTiempoInicioT.AutoSize = True
        Me.lblTiempoInicioT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoInicioT.ForeColor = System.Drawing.Color.DimGray
        Me.lblTiempoInicioT.Location = New System.Drawing.Point(259, 3)
        Me.lblTiempoInicioT.Name = "lblTiempoInicioT"
        Me.lblTiempoInicioT.Size = New System.Drawing.Size(122, 15)
        Me.lblTiempoInicioT.TabIndex = 29
        Me.lblTiempoInicioT.Text = "Hora Inicio"
        Me.lblTiempoInicioT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTiempoEjecucionT
        '
        Me.lblTiempoEjecucionT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTiempoEjecucionT.AutoSize = True
        Me.lblTiempoEjecucionT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoEjecucionT.ForeColor = System.Drawing.Color.DimGray
        Me.lblTiempoEjecucionT.Location = New System.Drawing.Point(3, 3)
        Me.lblTiempoEjecucionT.Name = "lblTiempoEjecucionT"
        Me.lblTiempoEjecucionT.Size = New System.Drawing.Size(122, 15)
        Me.lblTiempoEjecucionT.TabIndex = 30
        Me.lblTiempoEjecucionT.Text = "Duracion"
        Me.lblTiempoEjecucionT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTiempoFinalizacionT
        '
        Me.lblTiempoFinalizacionT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTiempoFinalizacionT.AutoSize = True
        Me.lblTiempoFinalizacionT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoFinalizacionT.ForeColor = System.Drawing.Color.DimGray
        Me.lblTiempoFinalizacionT.Location = New System.Drawing.Point(387, 3)
        Me.lblTiempoFinalizacionT.Name = "lblTiempoFinalizacionT"
        Me.lblTiempoFinalizacionT.Size = New System.Drawing.Size(122, 15)
        Me.lblTiempoFinalizacionT.TabIndex = 32
        Me.lblTiempoFinalizacionT.Text = "Hora Fin"
        Me.lblTiempoFinalizacionT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTiempoActualT
        '
        Me.lblTiempoActualT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTiempoActualT.AutoSize = True
        Me.lblTiempoActualT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoActualT.ForeColor = System.Drawing.Color.DimGray
        Me.lblTiempoActualT.Location = New System.Drawing.Point(131, 3)
        Me.lblTiempoActualT.Name = "lblTiempoActualT"
        Me.lblTiempoActualT.Size = New System.Drawing.Size(122, 15)
        Me.lblTiempoActualT.TabIndex = 33
        Me.lblTiempoActualT.Text = "T. Ejecución"
        Me.lblTiempoActualT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMemoriaOcupadaT
        '
        Me.lblMemoriaOcupadaT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMemoriaOcupadaT.AutoSize = True
        Me.lblMemoriaOcupadaT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemoriaOcupadaT.ForeColor = System.Drawing.Color.DimGray
        Me.lblMemoriaOcupadaT.Location = New System.Drawing.Point(387, 3)
        Me.lblMemoriaOcupadaT.Name = "lblMemoriaOcupadaT"
        Me.lblMemoriaOcupadaT.Size = New System.Drawing.Size(122, 15)
        Me.lblMemoriaOcupadaT.TabIndex = 35
        Me.lblMemoriaOcupadaT.Text = "Memoria"
        Me.lblMemoriaOcupadaT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTamañoT
        '
        Me.lblTamañoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTamañoT.AutoSize = True
        Me.lblTamañoT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamañoT.ForeColor = System.Drawing.Color.DimGray
        Me.lblTamañoT.Location = New System.Drawing.Point(131, 3)
        Me.lblTamañoT.Name = "lblTamañoT"
        Me.lblTamañoT.Size = New System.Drawing.Size(122, 15)
        Me.lblTamañoT.TabIndex = 36
        Me.lblTamañoT.Text = "Tamaño"
        Me.lblTamañoT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.Purple
        Me.lblCerrar.Location = New System.Drawing.Point(521, 9)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(23, 30)
        Me.lblCerrar.TabIndex = 27
        Me.lblCerrar.Text = "x"
        '
        'lblDireccionMemoria
        '
        Me.lblDireccionMemoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDireccionMemoria.AutoSize = True
        Me.lblDireccionMemoria.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionMemoria.Location = New System.Drawing.Point(259, 27)
        Me.lblDireccionMemoria.Name = "lblDireccionMemoria"
        Me.lblDireccionMemoria.Size = New System.Drawing.Size(122, 30)
        Me.lblDireccionMemoria.TabIndex = 34
        Me.lblDireccionMemoria.Text = "000"
        Me.lblDireccionMemoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParticionAsignadaT
        '
        Me.lblParticionAsignadaT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblParticionAsignadaT.AutoSize = True
        Me.lblParticionAsignadaT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParticionAsignadaT.ForeColor = System.Drawing.Color.DimGray
        Me.lblParticionAsignadaT.Location = New System.Drawing.Point(259, 3)
        Me.lblParticionAsignadaT.Name = "lblParticionAsignadaT"
        Me.lblParticionAsignadaT.Size = New System.Drawing.Size(122, 15)
        Me.lblParticionAsignadaT.TabIndex = 34
        Me.lblParticionAsignadaT.Text = "Dirección"
        Me.lblParticionAsignadaT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEstadoT, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTamaño, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMemoriaOcupada, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMemoriaOcupadaT, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDireccionMemoria, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParticionAsignadaT, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTamañoT, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEstado, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 100)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.92064!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.07936!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(512, 63)
        Me.TableLayoutPanel1.TabIndex = 37
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblTiempoEjecucionT, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTiempoActualT, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblHoraFin, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblHoraInicio, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDuracion, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTiempoInicioT, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTiempoFinalizacionT, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTiempoEjecucion, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(23, 180)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.37459!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.62541!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(512, 63)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'InfoProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(552, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.lblNombre)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "InfoProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblHoraInicio As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblHoraFin As Label
    Friend WithEvents lblTiempoEjecucion As Label
    Friend WithEvents lblMemoriaOcupada As Label
    Friend WithEvents lblTamaño As Label
    Friend WithEvents lblEstadoT As Label
    Friend WithEvents lblTiempoInicioT As Label
    Friend WithEvents lblTiempoEjecucionT As Label
    Friend WithEvents lblTiempoFinalizacionT As Label
    Friend WithEvents lblTiempoActualT As Label
    Friend WithEvents lblMemoriaOcupadaT As Label
    Friend WithEvents lblTamañoT As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents lblDireccionMemoria As Label
    Friend WithEvents lblParticionAsignadaT As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
