Imports System
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class ShellSort
        Public Shared Async Function Sort(array As Integer(), displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            Dim n As Integer = array.Length

            ' Empezar con un intervalo grande y reducirlo en cada iteración
            For gap As Integer = n \ 2 To 1 Step -gap \ 2
                ' Ordenar los subarreglos con el intervalo actual
                For i As Integer = gap To n - 1
                    Dim temp As Integer = array(i)
                    Dim j As Integer

                    ' Mostrar el elemento actual y el elemento con el que se compara
                    displayCallback(array, i, i - gap)
                    Await Task.Delay(500) ' Pausa para visualizar la comparación

                    ' Desplazar los elementos del subarreglo hacia la derecha
                    For j = i To gap Step -gap
                        If array(j - gap) > temp Then
                            array(j) = array(j - gap)

                            ' Mostrar el movimiento de los elementos
                            displayCallback(array, j, j - gap)
                            Await Task.Delay(500) ' Pausa para visualizar el movimiento
                        Else
                            Exit For
                        End If
                    Next

                    ' Insertar el elemento en su posición correcta
                    array(j) = temp

                    ' Visualizar la inserción del elemento
                    displayCallback(array, j, i)
                    Await Task.Delay(500) ' Pausa para visualizar la inserción
                Next
            Next

            displayCallback(array, -1, -1) ' Visualización final
        End Function
    End Class
End Namespace
