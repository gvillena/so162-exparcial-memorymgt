Imports System.Text

Public Class ParticionDinamica

#Region " Fields "

    ' Administrador de Memoria en Ejecucion
    Private Ejecucion As Boolean = False

    ' Algoritmo de Asignación
    Private Algoritmo As AlgoritmoAsignacion

    ' Tamaño de Memoria
    Private TamañoMemoria As Integer

    ' Lista de Procesos 
    Private ListaProcesos As List(Of Proceso)

    ' Lista de Particiones
    Private ListaParticiones As List(Of Particion)

    ' Lista de Particiones Libres
    Private ParticionesLibres As List(Of Particion)

    ' Lista de Particiones Ocupadas
    Private ParticionesOcupadas As List(Of Particion)

#End Region

#Region " Subs & Functions"

    Public Sub Inicializar(_tamañoMemoria As Integer, _listaParticiones As List(Of Particion), _algoritmo As AlgoritmoAsignacion)

        TamañoMemoria = _tamañoMemoria

        ' Inicializando Particiones 
        ListaParticiones = _listaParticiones

        ' Inicializando Particiones Libres
        ParticionesLibres = New List(Of Particion)
        For Each p As Particion In _listaParticiones
            ParticionesLibres.Add(p)
        Next

        ' Inicializando Particiones Ocupadas
        ParticionesOcupadas = New List(Of Particion)

        ' Actualizando Etiqueta de Particiones
        Dim sbParticiones As StringBuilder = New StringBuilder()
        For Each p As Particion In _listaParticiones
            sbParticiones.Append(String.Format("P{0}: {1}kb | ", p.Numero, p.Tamaño))
        Next
        lblParticiones.Text = sbParticiones.ToString(0, sbParticiones.Length - 2)

        ' Actualizando Etiqueta de Tamaño de Memoria
        lblMemoria.Text = String.Format("Memoria Ram ~ {0}kb", _tamañoMemoria)

        ' Estableciendo algoritmo de asignacion
        Algoritmo = _algoritmo

        ' Actualizando Etiqueta de Algoritmo de Asignacion
        Select Case Algoritmo
            Case AlgoritmoAsignacion.PrimerAjuste
                lblAlgoritmo.Text = "Algoritmo de Asignación -> Primer Ajuste"
            Case AlgoritmoAsignacion.MejorAjuste
                lblAlgoritmo.Text = "Algoritmo de Asignación -> Mejor Ajuste"
        End Select

    End Sub

    Private Sub AsignarEspacio()

        ' Verificar si se esta ejecutando el administrador de memoria 
        If Not Ejecucion Then Exit Sub

        ' Verificar si existen procesos en la lista de procesos
        If ListaProcesos.Count > 0 Then

            ' Declarando Variables
            Dim index As Integer = -1
            Dim msj As String = String.Empty

            ' Recorrer cada proceso
            For Each proceso As Proceso In ListaProcesos

                ' Si el proceso no esta en espera pasar al siguiente
                If Not proceso.Estado = EstadoProceso.Espera Then
                    Continue For
                End If

                ' Buscando indice de particion libre 
                index = BuscarParticionLibre(proceso.Tamaño)

                ' Si se encontro particion index (>=) a cero
                If index >= 0 Then

                    ' Creando nueva particion
                    Dim ptOcupada As New Particion
                    With ptOcupada
                        .Direccion = ParticionesLibres.Item(index).Direccion
                        .Tamaño = ParticionesLibres.Item(index).Tamaño
                        .Proceso = proceso
                        .Estado = EstadoParticion.Ocupada
                    End With

                    ' Agregando a lista de particiones ocupadas
                    ParticionesOcupadas.Add(ptOcupada)

                    ' Eliminando de lista de particiones libres
                    ParticionesLibres.RemoveAt(index)

                    ' Cambiando el estado del proceso a Asignado 
                    ListaProcesos.Item(ListaProcesos.IndexOf(proceso)).Estado = EstadoProceso.Asignado

                    ' Estableciendo la hora de inicio del proceso 
                    ListaProcesos.Item(ListaProcesos.IndexOf(proceso)).HoraInicio = DateTime.Now()

                    ' Estableciendo la hora de inicio del proceso 
                    ListaProcesos.Item(ListaProcesos.IndexOf(proceso)).DireccionMemoria = ptOcupada.Direccion

                    ' Mostrando mensaje en registro (log)
                    msj = String.Format("El proceso {0} de tamaño {1}kb ha sido asignado a la partición de memoria con dirección {2}", proceso.Nombre, proceso.Tamaño, ptOcupada.Direccion)
                Else ' de lo contrario
                    msj = String.Format("El proceso {0} de tamaño {1}kb no ha podido ser asignado debido a memoria insuficiente.", proceso.Nombre, proceso.Tamaño)
                End If

                ' Mostrando fecha y hora en registro (log)
                txtSalida.AppendText(String.Format("[{0}]", Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
                txtSalida.AppendText(vbCrLf + msj + vbCrLf + vbCrLf)
            Next

            ' Actualizando controles
            ActualizarDgvParticiones()
            ActualizaDgvProcesos()
        Else
            ' Si no hay procesos en cola mostrar en registro
            txtSalida.AppendText(String.Format("[{0}]", Date.Now.ToString("dd/MM/yyyy hh: mm:ss tt")))
            txtSalida.AppendText(vbCrLf + "No hay procesos en cola." + vbCrLf + vbCrLf)
        End If

    End Sub

    Private Sub TerminarProceso(nomProcSel As String)

        ' Declarando variables
        Dim ptOcupada As Particion = Nothing
        Dim idxProcSel As Integer = -1

        ' Buscando particion donde fue asignado el proceso a terminar
        For Each p As Particion In ParticionesOcupadas

            ' Verificando coincidencia para el nombre del proceso 
            If p.Proceso.Nombre = nomProcSel Then

                ' Asignando particion 
                ptOcupada = p

                ' Asignando indice proceso seleccionado
                idxProcSel = ListaProcesos.IndexOf(p.Proceso)

                ' Actualizando lista de procesos 
                ListaProcesos.Item(idxProcSel).Estado = EstadoProceso.Terminado

                ' Estableciendo Hora Fin
                ListaProcesos.Item(idxProcSel).HoraFin = Date.Now()

                ' Saliendo de bucle for
                Exit For

            End If
        Next

        ' Mostrando mensaje en registro (log)
        txtSalida.AppendText(String.Format("[{0}]", Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
        txtSalida.AppendText(vbCr + String.Format("El proceso {0} de tamaño {1}k ha sido terminado", ptOcupada.Proceso.Nombre, ptOcupada.Proceso.Tamaño))
        txtSalida.AppendText(vbCr + String.Format("La partición {0} con dirección {1} ha sido liberada.", ptOcupada.Numero, ptOcupada.Direccion))
        txtSalida.AppendText(vbCr + vbCr)


        ' Creando nueva particion libre
        Dim ptLibre As New Particion
        With ptLibre
            .Direccion = ptOcupada.Direccion
            .Tamaño = ptOcupada.Tamaño
            .Proceso = Nothing
            .Estado = EstadoParticion.Libre
        End With

        ' Eliminando particion de lista de particiones ocupadas
        ParticionesOcupadas.Remove(ptOcupada)

        ''''''''''''''''''''''''''''''''''
        '' Combinando particiones libres '
        ''''''''''''''''''''''''''''''''''

        ' Declarando Variables
        Dim ptLibreAnterior As Particion = Nothing
        Dim ptLibrePosterior As Particion = Nothing

        ' Buscando particion libre anterior
        For Each p As Particion In ParticionesLibres

            ' Verificando si la particion es adyacente
            If (p.Direccion + p.Tamaño) = ptLibre.Direccion Then

                ' Asignando particion 
                ptLibreAnterior = p

                ' Saliendo de bucle for
                Exit For

            End If
        Next

        ' Verificando si se encontro particion libre anterior 
        If ptLibreAnterior IsNot Nothing Then

            ' Redimensionando particion libre 
            ptLibre.Direccion = ptLibreAnterior.Direccion
            ptLibre.Tamaño = ptLibre.Tamaño + ptLibreAnterior.Tamaño

            ' Eliminando particion libre anterior
            ParticionesLibres.Remove(ptLibreAnterior)

        End If

        ' Buscando particion libre posterior
        For Each p As Particion In ParticionesLibres

            ' Verificando si la particion es adyacente
            If (ptLibre.Direccion + ptLibre.Tamaño) = p.Direccion Then

                ' Asignando particion 
                ptLibrePosterior = p

                ' Saliendo de bucle for
                Exit For

            End If
        Next

        ' Verificando si se encontro particion libre posterior
        If ptLibrePosterior IsNot Nothing Then

            ' Redimensionando particion libre 
            ptLibre.Tamaño = ptLibre.Tamaño + ptLibrePosterior.Tamaño

            ' Eliminando particion libre posterior
            ParticionesLibres.Remove(ptLibrePosterior)

        End If


        ' Agregando particion a lista de particiones libres
        ParticionesLibres.Add(ptLibre)

        ' Actualizando controles
        ActualizarDgvParticiones()

        ' Asignar Espacio
        AsignarEspacio()

    End Sub

    Private Function BuscarParticionLibre(tamañoProceso As Integer) As Integer

        ' Declarando variable index 
        Dim index As Integer = -1

        ' Realizando ordenamiento algoritmo primer ajuste
        If Algoritmo = AlgoritmoAsignacion.PrimerAjuste Then
            ParticionesLibres.Sort(Function(x, y) x.Direccion.CompareTo(y.Direccion))
        End If

        ' Realizando ordenamiento algoritmo mejor ajuste
        If Algoritmo = AlgoritmoAsignacion.MejorAjuste Then
            ParticionesLibres.Sort(Function(x, y) x.Tamaño.CompareTo(y.Tamaño))
        End If

        ' Recorriendo cada particion 
        For Each particion As Particion In ParticionesLibres

            ' Si el tamaño del proceso es mayor al de la particion
            If tamañoProceso > particion.Tamaño Then Continue For

            ' Devolviendo el indice de la particion libre encontrada 
            index = ParticionesLibres.IndexOf(particion)
            Exit For

        Next

        If index = -1 Then Return index


        ' Obteniendo tamaño particion encontrada
        Dim tamañoParticion As Integer = ParticionesLibres.Item(index).Tamaño

        ' Verificando si se requiere redimensionar y crear particiones
        If tamañoParticion > tamañoProceso Then

            ' Obteniendo direccion inicial particion encontrada
            Dim direccionParticion As Integer = ParticionesLibres.Item(index).Direccion

            ' Creando nueva particion
            Dim nuevaParticion As Particion = New Particion()
            With nuevaParticion
                .Direccion = direccionParticion + tamañoProceso
                .Tamaño = tamañoParticion - tamañoProceso
            End With

            ' Redimensionando particion encontrada
            ParticionesLibres.Item(index).Tamaño = tamañoProceso

            ' Insertando nueva particion despues de la particion encontrada
            ParticionesLibres.Insert(index + 1, nuevaParticion)

        End If

        ' Devolviendo indice encontrado
        Return index
    End Function

    Private Sub ActualizarDgvParticiones()

        ' Limpiar filas de control dgvParticiones
        dgvParticiones.Rows.Clear()

        ' Agregar particiones libres a control dgvParticiones
        For Each p As Particion In ParticionesLibres
            dgvParticiones.Rows.Add(New String() {p.Numero, p.Direccion, p.Tamaño, "-", "-", p.Estado.ToString})
        Next

        ' Agregar particiones ocupadas a control dgvParticiones
        For Each p As Particion In ParticionesOcupadas
            dgvParticiones.Rows.Add(New String() {p.Numero, p.Direccion, p.Tamaño, p.Proceso.Nombre, p.Proceso.Tamaño, p.Estado.ToString})
        Next

        ' Ordenar lista de particiones en control dgvParticiones
        dgvParticiones.Sort(dgvParticiones.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        Dim c As Integer = 1
        For Each row As DataGridViewRow In dgvParticiones.Rows
            row.Cells(0).Value = c
            c += 1
        Next

    End Sub

    Private Sub ActualizaDgvProcesos()
        dgvProcesos.Rows.Clear()
        For Each p As Proceso In ListaProcesos
            dgvProcesos.Rows.Add(New String() {p.Nombre, p.Tamaño, p.Estado.ToString})
        Next
    End Sub

#End Region

#Region " Windows Form Events "

    Private Sub ParticionFija_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Inicializando cola de procesos de prueba
        ListaProcesos = New List(Of Proceso)

        ' Agregando procesos de prueba
        ListaProcesos = New List(Of Proceso)
        ListaProcesos.Add(New Proceso("J1", 57, EstadoProceso.Espera, 5)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J2", 41, EstadoProceso.Espera, 4)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J3", 89, EstadoProceso.Espera, 8)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J4", 12, EstadoProceso.Espera, 2)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J5", 18, EstadoProceso.Espera, 6)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J6", 15, EstadoProceso.Espera, 3)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J7", 90, EstadoProceso.Espera, 6)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J8", 64, EstadoProceso.Espera, 3)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J9", 115, EstadoProceso.Espera, 7)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J10", 136, EstadoProceso.Espera, 9)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J11", 30, EstadoProceso.Espera, 8)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J12", 57, EstadoProceso.Espera, 6)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J13", 41, EstadoProceso.Espera, 3)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J14", 16, EstadoProceso.Espera, 2)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J15", 22, EstadoProceso.Espera, 7)) ' J1 ~ 10kb

        ' Actualizando DataGridView Particiones
        ActualizarDgvParticiones()

        ' Actualizando DataGridView Procesos
        ActualizaDgvProcesos()

        ' Inicializando Timer proceso
        trProcesos.Interval = 1000
        trProcesos.Start()

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Ejecucion = True
        btnEjecutar.Visible = False
        AsignarEspacio()
    End Sub

    Private Sub btnAgregarProceso_Click(sender As Object, e As EventArgs) Handles btnAgregarProceso.Click

        ' Declarando variables
        Dim tamañoProcesoStr As String = String.Empty
        Dim duracionProcesoStr As String = String.Empty
        Dim tamañoProceso As Integer = 0
        Dim duracionProceso As Integer = 0

        ' Obteniendo tamaño de proceso
        tamañoProcesoStr = InputBox("Ingrese tamaño de proceso...", "Nuevo Proceso", "")
        tamañoProceso = IIf(String.IsNullOrEmpty(tamañoProcesoStr), 0, CInt(tamañoProcesoStr))
        duracionProcesoStr = InputBox("Ingrese duración de proceso...", "Nuevo Proceso", "")
        duracionProceso = IIf(String.IsNullOrEmpty(duracionProcesoStr), 0, CInt(duracionProcesoStr))

        ' Verificando si el tamaño del proceso es mayor que cero
        If tamañoProceso > 0 AndAlso duracionProceso Then

            ' Declarando e Inicializando nuevo proceso
            Dim nuevoProceso As Proceso
            nuevoProceso = New Proceso("J" + CStr(ListaProcesos.Count + 1), tamañoProceso, EstadoProceso.Espera, duracionProceso)

            ' Agregando proceso a la lista de procesos
            ListaProcesos.Add(nuevoProceso)

            ' Realizando asignación 
            AsignarEspacio()

        Else ' de lo contrario
            MsgBox("El tamaño o tiempo del proceso no puede estar vacio y debe ser mayor de cero.")
        End If

    End Sub

    Private Sub btnTerminarProceso_Click(sender As Object, e As EventArgs) Handles btnTerminarProceso.Click

        ' Verificando si se ha seleccionado un proceso 
        If dgvProcesos.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un proceso...")
            Exit Sub
        End If

        ' Verificando si el proceso seleccionado esta asignado a alguna particion
        If Not dgvProcesos.SelectedRows(0).Cells(2).Value = "Asignado" Then
            MsgBox("Debe seleccionar un proceso que este asignado a alguna particion.")
            Exit Sub
        End If

        ' Obteniendo nombre de proceso seleccionado
        Dim nomProcSel As String = String.Empty
        nomProcSel = dgvProcesos.SelectedRows(0).Cells(0).Value

        ' Terminando Proceso
        TerminarProceso(nomProcSel)

    End Sub

    Private Sub trProcesos_Tick(sender As Object, e As EventArgs) Handles trProcesos.Tick

        ' Recorriendo lista de procesos
        For Each proceso As Proceso In ListaProcesos

            ' Verificando que el proceso se encuentre asignado 
            If proceso.Estado = EstadoProceso.Asignado Then

                ' Declarando variables
                Dim duracion As Integer = proceso.Duracion
                Dim horaInicio As DateTime = proceso.HoraInicio
                Dim horaActual As DateTime = Date.Now()
                Dim intervalo As Integer = horaActual.Subtract(horaInicio).Seconds

                ' Terminar proceso si alcanzo tiempo maximo de ejecucion 
                If (duracion - intervalo) <= 0 Then
                    TerminarProceso(proceso.Nombre)
                End If

            End If
        Next

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click

        ' Verificando si se ha seleccionado un proceso 
        If dgvProcesos.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un proceso...")
            Exit Sub
        End If

        ' Obteniendo nombre de proceso seleccionado
        Dim nomProcSel As String = String.Empty
        Dim procSel As Proceso = Nothing
        nomProcSel = dgvProcesos.SelectedRows(0).Cells(0).Value

        ' Recorriendo lista de procesos
        For Each proceso As Proceso In ListaProcesos
            If nomProcSel = proceso.Nombre Then
                procSel = proceso
            End If
        Next

        ' Mostrando informacion de proceso
        Dim infoProceso As InfoProceso = New InfoProceso()
        infoProceso.Inicializar(procSel, TamañoMemoria)
        infoProceso.ShowDialog()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub



#End Region


End Class