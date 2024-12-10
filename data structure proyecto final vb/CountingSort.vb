Imports System
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class CountingSort
        Public Shared Async Function Sort(array As Integer(), displayCallback As Action(Of Integer(), String)) As Task
            Dim n As Integer = array.Length
            If n <= 1 Then Return

            ' Encontrar el valor mínimo y máximo en el arreglo
            Dim minValue As Integer = array.Min()
            Dim maxValue As Integer = array.Max()

            ' Crear el arreglo de conteo
            Dim countArray As Integer() = New Integer(maxValue - minValue) {}

            ' Contar las ocurrencias de cada número
            For i As Integer = 0 To n - 1
                countArray(array(i) - minValue) += 1
            Next

            ' Reconstruir el arreglo ordenado a partir del conteo
            Dim index As Integer = 0
            For i As Integer = 0 To countArray.Length - 1
                While countArray(i) > 0
                    array(index) = i + minValue
                    index += 1

                    ' Mostrar el arreglo en su estado actual
                    displayCallback(array, "Ordenando: ")
                    Await Task.Delay(500) ' Añadir una pequeña demora para visualizar los pasos

                    countArray(i) -= 1
                End While
            Next

            ' Mostrar el arreglo final ordenado
            displayCallback(array, "Arreglo ordenado: ")
        End Function
    End Class
End Namespace