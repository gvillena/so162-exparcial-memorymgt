Public Class InfoProceso

    Public Sub Inicializar(proceso As Proceso, tamañoMemoria As Integer)

        lblNombre.Text = "Task " + proceso.Nombre.Substring(1)
        lblEstado.Text = proceso.Estado.ToString()
        lblTamaño.Text = String.Format("{0}kb", proceso.Tamaño)
        lblMemoriaOcupada.Text = String.Format("{0:##0}%", (proceso.Tamaño * 100) / tamañoMemoria)
        lblDireccionMemoria.Text = String.Format("{0:000}", proceso.DireccionMemoria)
        lblDuracion.Text = String.Format("{0} seg.", proceso.Duracion)

        If proceso.Estado = EstadoProceso.Asignado Then
            lblHoraInicio.Text = proceso.HoraInicio.ToString("hh:mm:ss")
            lblTiempoEjecucion.Text = String.Format("{0} seg.", Date.Now.Subtract(proceso.HoraInicio).Seconds)
            lblHoraFin.Text = "00:00:00"
        End If

        If proceso.Estado = EstadoProceso.Terminado Then
            lblHoraInicio.Text = proceso.HoraInicio.ToString("hh:mm:ss")
            lblTiempoEjecucion.Text = String.Format("{0} seg.", proceso.HoraFin.Subtract(proceso.HoraInicio).Seconds)
            lblHoraFin.Text = proceso.HoraFin.ToString("hh:mm:ss")
        End If

    End Sub

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        Me.Close()
    End Sub
End Class