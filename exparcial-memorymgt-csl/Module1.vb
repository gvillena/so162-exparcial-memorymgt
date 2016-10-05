Imports System.Linq.Expressions
Imports System.Text
Imports exparcial_memorymgt_csl.ArrayPrinter

Module Module1


    Private Algoritmo As AlgoritmoAsignacion
    Private TamañoMemoria As Integer
    Private ListaProcesos As List(Of Proceso)
    Private ListaParticiones As List(Of Particion)
    Private ParticionesLibres As List(Of Particion)
    Private ParticionesOcupadas As List(Of Particion)
    Private TiempoSimulacion As Integer


    Sub Main()

        If My.Application.CommandLineArgs.Count = 0 Then
            Console.WriteLine()
            Console.WriteLine("------------------------------------------------------------------------")
            Console.WriteLine("Examen Parcial")
            Console.WriteLine("Sistemas Operativos 2016-2")
            Console.WriteLine("so162-exprcl-cli@v.0.1")
            Console.WriteLine("------------------------------------------------------------------------")
            Console.WriteLine()
            Console.WriteLine("Utilice esta herramienta y sus comandos para realizar su examen parcial.")
            Console.WriteLine()
            Console.WriteLine("Lista de Comandos Disponibles")
            Console.WriteLine()
            Console.WriteLine("  info       Muestra la descripcion y preguntas del examen")
            Console.WriteLine("  start      Ejecuta la simulacion de asignación de memoria")
            Console.WriteLine()
            Console.WriteLine("USO: exprcl <comando>")
            Console.WriteLine()
            Console.WriteLine("------------------------------------------------------------------------")
            Exit Sub
        End If

        Select Case My.Application.CommandLineArgs.Item(0)
            Case "info"
                caso01()
            Case "start"
                caso01_start()
            Case Else
                Console.WriteLine("No se reconoce el comando ""{0}""", My.Application.CommandLineArgs.Item(0))
        End Select

    End Sub


    Sub caso01()

        Dim sb As New StringBuilder()
        Dim arrlst As New ArrayList()

        TamañoMemoria = 250
        TiempoSimulacion = 5

        ListaParticiones = New List(Of Particion)
        ListaParticiones.Add(New Particion(1, 0, 30, EstadoParticion.Libre))  ' P1 ~ 50kb
        ListaParticiones.Add(New Particion(2, 30, 115, EstadoParticion.Libre)) ' P2 ~ 20kb
        ListaParticiones.Add(New Particion(3, 145, 20, EstadoParticion.Libre)) ' P3 ~ 10kb
        ListaParticiones.Add(New Particion(4, 165, 85, EstadoParticion.Libre)) ' P4 ~ 15kb

        ParticionesLibres = New List(Of Particion)(ListaParticiones.ToArray)
        ParticionesOcupadas = New List(Of Particion)

        ListaProcesos = New List(Of Proceso)
        ListaProcesos.Add(New Proceso("J1", 35, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J2", 10, EstadoProceso.Espera, 3)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J3", 90, EstadoProceso.Espera, 1)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J4", 70, EstadoProceso.Espera, 2)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J5", 95, EstadoProceso.Espera, 3)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J6", 42, EstadoProceso.Espera, 1)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J7", 80, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J8", 110, EstadoProceso.Espera, 3)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J9", 35, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J10", 26, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J11", 44, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J12", 75, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J13", 40, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J14", 110, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J15", 16, EstadoProceso.Espera, 3)) ' J1 ~ 10kb

        Console.WriteLine()
        Console.WriteLine("----------------------------------------------------------------")
        Console.WriteLine("Examen Parcial")
        Console.WriteLine("Sistemas Operativos 2016-2")
        Console.WriteLine("----------------------------------------------------------------")
        Console.WriteLine()
        Console.WriteLine("Dada la siguiente configuración de memoria y lista de trabajos: ")
        Console.WriteLine()
        ' Mostrando datos 
        Console.WriteLine(" -----------------------------")
        Console.WriteLine(" T. Memoria       :     250kb")
        Console.WriteLine(" E. Particion     :   P. Fija")
        Console.WriteLine(" T. Simulacion    :    10 seg.")
        Console.WriteLine(" -----------------------------")
        Console.WriteLine()

        For Each p As Particion In ListaParticiones
            arrlst.Add(Tuple.Create(String.Format("P{0}", p.Numero), String.Format("{0:00000}", p.Direccion), String.Format("{0}kb", p.Tamaño)))
        Next
        Console.WriteLine(" MEMORIA ")
        Console.WriteLine()
        Console.WriteLine(arrlst.ToArray().ToStringTable({"N", "Direccion", "Tamaño"}, Function(a) a.Item1, Function(a) a.Item2, Function(a) a.Item3))
        Console.WriteLine()

        arrlst.Clear()

        For Each p As Proceso In ListaProcesos
            arrlst.Add(Tuple.Create(p.Nombre, String.Format("{0}kb", p.Tamaño), String.Format("{0} seg.", p.Duracion)))
        Next
        Console.WriteLine()
        Console.WriteLine(" TRABAJOS ")
        Console.WriteLine(arrlst.ToArray().ToStringTable({"N", "Tamaño", "Duracion"}, Function(a) a.Item1, Function(a) a.Item2, Function(a) a.Item3))
        Console.WriteLine()

        Console.WriteLine("Realice la asignacion de memoria (comando 'start') y responda las siguientes preguntas para cada algoritmo de asignacion ('Primer Ajuste' y 'Mejor Ajuste').")
        Console.WriteLine()
        Console.WriteLine("  1. Numero de Trabajos Asignados.")
        Console.WriteLine("  2. Numero de Trabajos No Asignados.")
        Console.WriteLine("  3. Numero de Trabajos en Memoria Promedio.")
        Console.WriteLine("  4. Utilizacion de Memoria Promedio")
        Console.WriteLine("  5. Utilizacion de Memoria Maximo")
        Console.WriteLine("  6. Utilizacion de Memoria Minimo")
        Console.WriteLine("  7. Memoria No Utilizada Promedio")
        Console.WriteLine("  8. Memoria No Utilizada Maximo")
        Console.WriteLine("  9. Memoria No Utilizada Minimo")
        Console.WriteLine("  10. Utilizacion de Memoria Promedio por cada Particion")
        Console.WriteLine("  11. Fragmentacion Interna Promedio por cada Particion")
        Console.WriteLine("  12. Particion que registro mayor fragmentacion interna")
        Console.WriteLine("  13. Particion que registro menor fragmentacion interna")
        Console.WriteLine("  14. Particion Mas Utilizada")
        Console.WriteLine("  15. Particion Menos Utilizada")
        Console.WriteLine()
        Console.WriteLine("Por ultimo, indique cual de ambos algoritmos es el mas adecuado.")
        Console.WriteLine()
        Console.WriteLine("Las respuestas deberan ser enviadas en un documento en word con sus nombres y apellidos.")
        Console.WriteLine()
        Console.WriteLine("¡Mucha Suerte!")

    End Sub

    Sub caso01_start()

        Dim sb As New StringBuilder()
        Dim arrlst As New ArrayList()

        TamañoMemoria = 250
        TiempoSimulacion = 5

        ListaParticiones = New List(Of Particion)
        ListaParticiones.Add(New Particion(1, 0, 30, EstadoParticion.Libre))  ' P1 ~ 50kb
        ListaParticiones.Add(New Particion(2, 30, 115, EstadoParticion.Libre)) ' P2 ~ 20kb
        ListaParticiones.Add(New Particion(3, 145, 20, EstadoParticion.Libre)) ' P3 ~ 10kb
        ListaParticiones.Add(New Particion(4, 165, 85, EstadoParticion.Libre)) ' P4 ~ 15kb

        ParticionesLibres = New List(Of Particion)(ListaParticiones.ToArray)
        ParticionesOcupadas = New List(Of Particion)

        ListaProcesos = New List(Of Proceso)
        ListaProcesos.Add(New Proceso("J1", 35, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J2", 10, EstadoProceso.Espera, 3)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J3", 90, EstadoProceso.Espera, 1)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J4", 70, EstadoProceso.Espera, 2)) ' J2 ~ 20kb
        ListaProcesos.Add(New Proceso("J5", 95, EstadoProceso.Espera, 3)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J6", 42, EstadoProceso.Espera, 1)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J7", 80, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J8", 110, EstadoProceso.Espera, 3)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J9", 35, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J10", 26, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J11", 44, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J12", 75, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J13", 40, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J14", 110, EstadoProceso.Espera, 2)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J15", 16, EstadoProceso.Espera, 3)) ' J1 ~ 10kb




        Console.WriteLine()
        Console.WriteLine("--------------------------")
        Console.WriteLine("Examen Parcial")
        Console.WriteLine("Sistemas Operativos 2016-2")
        Console.WriteLine("--------------------------")
        Console.WriteLine()


        Console.WriteLine("Algoritmos de asignacion")
        Console.WriteLine()
        Console.WriteLine(" (1) Primer Ajuste")
        Console.WriteLine(" (2) Mejor Ajuste")
        Console.WriteLine()
        Console.WriteLine("Seleccione una opcion: ")
        Select Case Console.ReadLine()
            Case "1"
                Algoritmo = AlgoritmoAsignacion.PrimerAjuste
            Case "2"
                Algoritmo = AlgoritmoAsignacion.MejorAjuste
            Case Else
                Console.WriteLine("Opcion no valida... :(")
                Exit Sub
        End Select
        Console.WriteLine()
        Console.WriteLine("Presione una tecla para iniciar la simulación...")
        Console.ReadKey()
        Console.WriteLine()

        Dim tbl As ArrayList = New ArrayList()
        Dim nomproc As String = ""
        Dim tamproc As String = ""
        sb.AppendLine("  " + New String("-", 56) + "")
        sb.AppendLine(" | T: 00:00" + New String(" ", 47) + "|")
        sb.AppendLine(" |" + New String("-", 56) + "|")
        For Each p As Particion In ListaParticiones

            If p.Proceso IsNot Nothing Then
                nomproc = p.Proceso.Nombre
                tamproc = p.Proceso.Tamaño.ToString()
            Else
                nomproc = "Ninguno"
                tamproc = "0"
            End If

            tbl.Add(Tuple.Create(
                    String.Format("P{0}", p.Numero),
                    String.Format("{0:000000}", p.Direccion),
                    String.Format("{0}kb", p.Tamaño),
                    nomproc,
                    String.Format("{0}kb", tamproc),
                    p.Estado.ToString()))
        Next
        sb.AppendLine(tbl.ToArray().ToStringTable({"N", "Direccion", "Tamaño", "N. Proc.", "T. Proc.", "Estado"}, Function(a) a.Item1, Function(a) a.Item2, Function(a) a.Item3, Function(a) a.Item4, Function(a) a.Item5, Function(a) a.Item6))
        Console.WriteLine(sb.ToString)



        For index = 1 To 10

            sb.Clear()

            sb.AppendLine("  " + New String("-", 57) + "")
            sb.AppendLine(" | T: 00:" + index.ToString("00") + New String(" ", 48) + "|")
            sb.AppendLine(" |" + New String("-", 57) + "|")
            ' Actualizando tiempos 
            For Each p As Proceso In ListaProcesos

                If p.Estado = EstadoProceso.Asignado Then
                    If p.TimeLeft.Ticks > 0 Then
                        p.TimeLeft = p.TimeLeft.Subtract(New TimeSpan(1))
                    Else
                        TerminarProceso(p.Nombre)
                    End If
                End If
            Next

            AsignarEspacio()
            Dim memutil As Integer = 0
            Dim memnoutil As Integer = 0
            Dim prt As List(Of Particion) = New List(Of Particion)
            prt.AddRange(ParticionesLibres.ToArray)
            prt.AddRange(ParticionesOcupadas.ToArray)
            prt.Sort(Function(x, y) x.Direccion.CompareTo(y.Direccion))
            tbl.Clear()
            For Each p As Particion In prt

                If p.Proceso IsNot Nothing Then
                    nomproc = p.Proceso.Nombre
                    tamproc = p.Proceso.Tamaño.ToString()
                    memutil += p.Proceso.Tamaño()
                Else
                    nomproc = "Ninguno"
                    tamproc = "0"
                End If

                tbl.Add(Tuple.Create(
                    String.Format("P{0}", p.Numero),
                    String.Format("{0:00000}", p.Direccion),
                    String.Format("{0}kb", p.Tamaño),
                    nomproc,
                    String.Format("{0}kb", tamproc),
                    p.Estado.ToString()))

            Next


            sb.AppendLine(tbl.ToArray().ToStringTable({"N", "Direccion", "Tamaño", "N. Proc.", "T. Proc.", "Estado"}, Function(a) a.Item1, Function(a) a.Item2, Function(a) a.Item3, Function(a) a.Item4, Function(a) a.Item5, Function(a) a.Item6))
            Console.WriteLine(sb.ToString)
            'Console.WriteLine("Memutilizada: {0}kb", memutil)
            'Console.WriteLine("Memnoutilizada: {0}kb", (250 - memutil))
            Console.WriteLine()

        Next

    End Sub


#Region "TablePrint"

    <System.Runtime.CompilerServices.Extension>
    Public Function ToStringTable(Of T)(values As IEnumerable(Of T), columnHeaders As String(), ParamArray valueSelectors As Func(Of T, Object)()) As String
        Return ToStringTable(values.ToArray(), columnHeaders, valueSelectors)
    End Function

    <System.Runtime.CompilerServices.Extension>
    Public Function ToStringTable(Of T)(values As T(), columnHeaders As String(), ParamArray valueSelectors As Func(Of T, Object)()) As String
        Debug.Assert(columnHeaders.Length = valueSelectors.Length)

        Dim arrValues = New String(values.Length, valueSelectors.Length - 1) {}

        ' Fill headers
        For colIndex As Integer = 0 To arrValues.GetLength(1) - 1
            arrValues(0, colIndex) = columnHeaders(colIndex)
        Next

        ' Fill table rows
        For rowIndex As Integer = 1 To arrValues.GetLength(0) - 1
            For colIndex As Integer = 0 To arrValues.GetLength(1) - 1
                arrValues(rowIndex, colIndex) = valueSelectors(colIndex).Invoke(values(rowIndex - 1)).ToString()
            Next
        Next

        Return ToStringTable(arrValues)
    End Function


    <System.Runtime.CompilerServices.Extension>
    Public Function Append(Of T)(source As IEnumerable(Of T), ParamArray item As T()) As IEnumerable(Of T)
        Return source.Concat(item)
    End Function

    <System.Runtime.CompilerServices.Extension>
    Public Function ToStringTable(arrValues As String(,)) As String
        Dim maxColumnsWidth As Integer() = GetMaxColumnsWidth(arrValues)
        Dim headerSpliter = New String("-"c, maxColumnsWidth.Sum(Function(i) i + 3) - 1)

        Dim sb = New StringBuilder()
        For rowIndex As Integer = 0 To arrValues.GetLength(0) - 1
            For colIndex As Integer = 0 To arrValues.GetLength(1) - 1
                ' Print cell
                Dim cell As String = arrValues(rowIndex, colIndex)
                cell = cell.PadRight(maxColumnsWidth(colIndex))
                sb.Append(" | ")
                sb.Append(cell)
            Next

            ' Print end of line
            sb.Append(" | ")
            sb.AppendLine()

            ' Print splitter
            If rowIndex = 0 Then
                sb.AppendFormat(" |{0}| ", headerSpliter)
                sb.AppendLine()
            End If
        Next
        sb.AppendFormat("  {0}  ", headerSpliter)
        sb.AppendLine()
        Return sb.ToString()
    End Function

    Private Function GetMaxColumnsWidth(arrValues As String(,)) As Integer()
        Dim maxColumnsWidth = New Integer(arrValues.GetLength(1) - 1) {}
        For colIndex As Integer = 0 To arrValues.GetLength(1) - 1
            For rowIndex As Integer = 0 To arrValues.GetLength(0) - 1
                Dim newLength As Integer = arrValues(rowIndex, colIndex).Length
                Dim oldLength As Integer = maxColumnsWidth(colIndex)

                If newLength > oldLength Then
                    maxColumnsWidth(colIndex) = newLength
                End If
            Next
        Next

        Return maxColumnsWidth
    End Function

#End Region

    Private Sub AsignarEspacio()

        ' Verificar si existen procesos en la lista de procesos
        If ListaProcesos.Count = 0 Then Exit Sub

        ' Declarando Variables
        Dim index As Integer = -1
        Dim msj As String = String.Empty

        ' Recorrer cada proceso
        For Each proceso As Proceso In ListaProcesos

            If Not proceso.Estado = EstadoProceso.Espera Then Continue For

            index = BuscarParticionLibre(proceso.Tamaño)
            If index = -1 Then Continue For

            Dim ptOcupada As New Particion
            With ptOcupada
                .Numero = ParticionesLibres.Item(index).Numero
                .Direccion = ParticionesLibres.Item(index).Direccion
                .Tamaño = ParticionesLibres.Item(index).Tamaño
                .Proceso = proceso
                .Estado = EstadoParticion.Ocupada
            End With

            ParticionesOcupadas.Add(ptOcupada)
            ParticionesLibres.RemoveAt(index)
            ListaProcesos.Item(ListaProcesos.IndexOf(proceso)).Estado = EstadoProceso.Asignado
            ListaProcesos.Item(ListaProcesos.IndexOf(proceso)).DireccionMemoria = ptOcupada.Direccion

        Next

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

        ' Creando nueva particion libre
        Dim ptLibre As New Particion
        With ptLibre
            .Numero = ptOcupada.Numero
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

        '' Declarando Variables
        'Dim ptLibreAnterior As Particion = Nothing
        'Dim ptLibrePosterior As Particion = Nothing

        '' Buscando particion libre anterior
        'For Each p As Particion In ParticionesLibres

        '    ' Verificando si la particion es adyacente
        '    If (p.Direccion + p.Tamaño) = ptLibre.Direccion Then

        '        ' Asignando particion 
        '        ptLibreAnterior = p

        '        ' Saliendo de bucle for
        '        Exit For

        '    End If
        'Next

        '' Verificando si se encontro particion libre anterior 
        'If ptLibreAnterior IsNot Nothing Then

        '    ' Redimensionando particion libre 
        '    ptLibre.Direccion = ptLibreAnterior.Direccion
        '    ptLibre.Tamaño = ptLibre.Tamaño + ptLibreAnterior.Tamaño

        '    ' Eliminando particion libre anterior
        '    ParticionesLibres.Remove(ptLibreAnterior)

        'End If

        '' Buscando particion libre posterior
        'For Each p As Particion In ParticionesLibres

        '    ' Verificando si la particion es adyacente
        '    If (ptLibre.Direccion + ptLibre.Tamaño) = p.Direccion Then

        '        ' Asignando particion 
        '        ptLibrePosterior = p

        '        ' Saliendo de bucle for
        '        Exit For

        '    End If
        'Next

        '' Verificando si se encontro particion libre posterior
        'If ptLibrePosterior IsNot Nothing Then

        '    ' Redimensionando particion libre 
        '    ptLibre.Tamaño = ptLibre.Tamaño + ptLibrePosterior.Tamaño

        '    ' Eliminando particion libre posterior
        '    ParticionesLibres.Remove(ptLibrePosterior)

        'End If

        ' Agregando particion a lista de particiones libres
        ParticionesLibres.Add(ptLibre)

        ' Asignar Espacio
        'AsignarEspacio()

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

        'If index = -1 Then Return index


        '' Obteniendo tamaño particion encontrada
        'Dim tamañoParticion As Integer = ParticionesLibres.Item(index).Tamaño

        '' Verificando si se requiere redimensionar y crear particiones
        'If tamañoParticion > tamañoProceso Then

        '    ' Obteniendo direccion inicial particion encontrada
        '    Dim direccionParticion As Integer = ParticionesLibres.Item(index).Direccion

        '    ' Creando nueva particion
        '    Dim nuevaParticion As Particion = New Particion()
        '    With nuevaParticion
        '        .Direccion = direccionParticion + tamañoProceso
        '        .Tamaño = tamañoParticion - tamañoProceso
        '    End With

        '    ' Redimensionando particion encontrada
        '    ParticionesLibres.Item(index).Tamaño = tamañoProceso

        '    ' Insertando nueva particion despues de la particion encontrada
        '    ParticionesLibres.Insert(index + 1, nuevaParticion)

        'End If

        ' Devolviendo indice encontrado
        Return index
    End Function







End Module

