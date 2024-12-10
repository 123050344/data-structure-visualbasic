Imports System
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class PigeonHoleSort
        Public Shared Async Function Sort(array As Integer(), casillasDisplayCallback As Action(Of Integer(), String), sortedDisplayCallback As Action(Of Integer(), String)) As Task
            ' Paso 1: Encontrar el valor mínimo y máximo
            Dim min As Integer = array.Min()
            Dim max As Integer = array.Max()
            Dim range As Integer = max - min + 1

            ' Crear un arreglo de casillas
            Dim holes As Integer() = New Integer(range - 1) {}

            ' Paso 2: Asignar los elementos a las casillas
            For Each num As Integer In array
                holes(num - min) += 1  ' Incrementa el contador para la casilla correspondiente

                ' Mostrar cómo se va acomodando el número en su casilla
                casillasDisplayCallback(holes, $"Asignando {num} a la casilla {num - min}")
                Await Task.Delay(500) ' Pausa para mostrar el proceso
            Next

            ' Mostrar la distribución final de las casillas
            casillasDisplayCallback(holes, "Distribución final de las casillas: " & String.Join(", ", holes))

            ' Paso 3: Recoger los elementos de las casillas en orden
            Dim index As Integer = 0
            For i As Integer = 0 To range - 1
                While holes(i) > 0
                    array(index) = i + min
                    index += 1
                    holes(i) -= 1

                    ' Mostrar cómo se recogen los elementos y se van acomodando
                    sortedDisplayCallback(array, $"Recogiendo {i + min} de la casilla {i}...")
                    Await Task.Delay(500) ' Pausa para mostrar el proceso
                End While
            Next

            sortedDisplayCallback(array, "Ordenamiento completado")
        End Function
    End Class
End Namespace
