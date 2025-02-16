﻿Imports System
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class BubbleSort
        Public Shared Async Function Sort(arr As Integer(), displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            Dim n As Integer = arr.Length
            Dim i As Integer, j As Integer, temp As Integer
            Dim swapped As Boolean

            ' Recorre el arreglo para realizar las comparaciones e intercambios
            For i = 0 To n - 2
                swapped = False

                For j = 0 To n - i - 2
                    ' Incrementa el contador de comparaciones

                    ' Mostrar los números que se están comparando
                    displayCallback(arr, j, j + 1)

                    ' Esperar para mostrar la comparación
                    Await Task.Delay(400)

                    If arr(j) > arr(j + 1) Then
                        ' Intercambiar los elementos
                        temp = arr(j)
                        arr(j) = arr(j + 1)
                        arr(j + 1) = temp

                        swapped = True ' Incrementa el contador de intercambios

                        ' Mostrar los números después de intercambiarlos
                        displayCallback(arr, j, j + 1)
                        Await Task.Delay(400)
                    End If
                Next

                ' Si no se hicieron intercambios, el arreglo está ordenado
                If Not swapped Then
                    Exit For
                End If
            Next
        End Function
    End Class
End Namespace
