Imports System
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Data_Structure_Final_Project
    Friend Class MergeAlgorithms
        Public Shared Async Function MergeSort(array As Integer(), left As Integer, right As Integer, displayCallback As Action(Of Integer(), String)) As Task
            If left < right Then
                Dim middle As Integer = (left + right) \ 2

                ' Mostrar división
                displayCallback(array.Skip(left).Take(right - left + 1).ToArray(), $"División: {left} - {right}")

                ' Dividir de manera recursiva
                Await MergeSort(array, left, middle, displayCallback)
                Await MergeSort(array, middle + 1, right, displayCallback)

                ' Combinar los subarreglos
                Await Merge(array, left, middle, right, displayCallback)
            End If
        End Function

        Private Shared Async Function Merge(array As Integer(), left As Integer, middle As Integer, right As Integer, displayCallback As Action(Of Integer(), String)) As Task
            ' Crear copias de las mitades
            Dim leftArray As Integer() = array.Skip(left).Take(middle - left + 1).ToArray()
            Dim rightArray As Integer() = array.Skip(middle + 1).Take(right - middle).ToArray()

            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim k As Integer = left

            ' Combinar elementos en orden
            While i < leftArray.Length AndAlso j < rightArray.Length
                If leftArray(i) <= rightArray(j) Then
                    array(k) = leftArray(i)
                    i += 1
                Else
                    array(k) = rightArray(j)
                    j += 1
                End If
                k += 1
                Await Task.Delay(50) ' Pausa para simular paso visual
                displayCallback(array, "Actualizando mezcla...")
            End While

            ' Copiar elementos restantes
            While i < leftArray.Length
                array(k) = leftArray(i)
                i += 1
                k += 1
                Await Task.Delay(50)
                displayCallback(array, "Agregando elementos restantes de la izquierda...")
            End While

            While j < rightArray.Length
                array(k) = rightArray(j)
                j += 1
                k += 1
                Await Task.Delay(50)
                displayCallback(array, "Agregando elementos restantes de la derecha...")
            End While

            displayCallback(array.Skip(left).Take(right - left + 1).ToArray(), $"Merge completado: {left} - {right}")
        End Function

        Public Shared Async Function DirectMerge(array As Integer(), displayCallback As Action(Of Integer(), String)) As Task
            Dim n As Integer = array.Length ' Obtener el tamaño del arreglo
            Dim temp As Integer() = New Integer(n - 1) {}

            For width As Integer = 1 To n - 1 Step width * 2
                displayCallback(array.ToArray(), "División con width = " & width)

                ' Iterar sobre los subarreglos de tamaño 2*width
                For i As Integer = 0 To n - 1 Step 2 * width
                    Dim left As Integer = i ' Índice inicial del subarreglo izquierdo
                    Dim middle As Integer = Math.Min(i + width, n) ' Índice del último elemento del subarreglo izquierdo
                    Dim right As Integer = Math.Min(i + 2 * width, n) ' Índice del último elemento del subarreglo derecho

                    Dim l As Integer = left
                    Dim r As Integer = middle
                    Dim k As Integer = left

                    ' Fusionar los subarreglos izquierdo y derecho en el arreglo temporal
                    While l < middle AndAlso r < right
                        If array(l) <= array(r) Then
                            temp(k) = array(l)
                            l += 1
                        Else
                            temp(k) = array(r)
                            r += 1
                        End If
                        k += 1
                    End While

                    While l < middle
                        temp(k) = array(l)
                        l += 1
                        k += 1
                    End While

                    While r < right
                        temp(k) = array(r)
                        r += 1
                        k += 1
                    End While

                    ' Copiar el arreglo temporal de vuelta al arreglo original
                    array.Copy(temp, left, array, left, right - left)
                Next

                displayCallback(array.ToArray(), "Mezcla después de width = " & width)
                Await Task.Delay(200) ' Pausa para simular paso visual
            Next
        End Function

        ' Natural Merge Sort
        Public Shared Async Function NaturalMerge(array As Integer(), displayCallback As Action(Of Integer(), String)) As Task
            Dim ordenado As Boolean = False
            Dim temp As Integer() = New Integer(array.Length - 1) {}

            While Not ordenado
                ordenado = True
                Dim i As Integer = 0
                displayCallback(array, "División en sub-secuencias")

                While i < array.Length
                    Dim start As Integer = i

                    ' Encuentra el final de la primera secuencia ordenada
                    While i < array.Length - 1 AndAlso array(i) <= array(i + 1)
                        i += 1
                    End While
                    i += 1

                    Dim j As Integer = i

                    ' Encuentra el final de la segunda secuencia ordenada
                    While i < array.Length - 1 AndAlso array(i) <= array(i + 1)
                        i += 1
                    End While
                    i += 1

                    If j < array.Length Then
                        MergeNatural(array, start, j, Math.Min(i, array.Length), temp)
                        ordenado = False
                    End If
                End While

                array.Copy(temp, 0, array, 0, array.Length)

                displayCallback(array, "Mezcla completa")
                Await Task.Delay(200) ' Pausa para simular paso visual
            End While
        End Function

        ' Merge Natural Helper
        Private Shared Sub MergeNatural(array As Integer(), left As Integer, middle As Integer, right As Integer, temp As Integer())
            Dim i As Integer = left
            Dim j As Integer = middle
            Dim k As Integer = left
            While i < middle AndAlso j < right
                If array(i) <= array(j) Then
                    temp(k) = array(i)
                    i += 1
                Else
                    temp(k) = array(j)
                    j += 1
                End If
                k += 1
            End While

            While i < middle
                temp(k) = array(i)
                i += 1
                k += 1
            End While

            While j < right
                temp(k) = array(j)
                j += 1
                k += 1
            End While
        End Sub
    End Class
End Namespace

