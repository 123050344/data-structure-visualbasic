Imports System
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class SelectionSort
        Public Shared Async Function Sort(array As Integer(), displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            Dim n As Integer = array.Length

            For i As Integer = 0 To n - 2
                Dim minIndex As Integer = i

                ' Visualizar el inicio de una nueva iteración con el índice mínimo actual
                displayCallback(array, i, minIndex)
                Await Task.Delay(500) ' Pausa para visualizar

                For j As Integer = i + 1 To n - 1
                    ' Mostrar comparación entre el elemento actual y el mínimo
                    displayCallback(array, j, minIndex)
                    Await Task.Delay(500) ' Pausa para visualizar la comparación

                    If array(j) < array(minIndex) Then
                        minIndex = j

                        ' Visualizar el nuevo índice mínimo
                        displayCallback(array, j, minIndex)
                        Await Task.Delay(500) ' Pausa para visualizar el cambio del índice mínimo
                    End If
                Next

                ' Intercambiar el elemento mínimo con el elemento actual
                If minIndex <> i Then
                    Dim temp As Integer = array(i)
                    array(i) = array(minIndex)
                    array(minIndex) = temp

                    ' Visualizar el intercambio
                    displayCallback(array, i, minIndex)
                    Await Task.Delay(500) ' Pausa para observar el intercambio
                End If
            Next

            displayCallback(array, -1, -1) ' Visualización final
        End Function
    End Class
End Namespace

