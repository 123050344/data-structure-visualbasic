Imports System.Windows.Forms
Imports data_structure_proyecto_final_vb.data_structure_proyecto_final_vbata_Structure_Final_Project

Namespace data_structure_proyecto_final_vb
    Friend Class DoubleQueues
        Friend Class DoubleEndedStaticQueue
            Private array() As Integer
            Private front As Integer
            Private rear As Integer
            Private size As Integer
            Private capacity As Integer

            Public Sub New(capacity As Integer)
                Me.capacity = capacity
                array = New Integer(capacity - 1) {}
                front = -1
                rear = -1
                size = 0
            End Sub

            ' Verifica si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return size = 0
            End Function

            ' Verifica si la cola está llena
            Public Function IsFull() As Boolean
                Return size = capacity
            End Function

            ' Inserta un elemento en el frente de la cola
            Public Sub InsertFront(value As Integer)
                If size = array.Length Then
                    MessageBox.Show("The Double Queue is full.")
                    Return
                End If

                ' Mover todos los elementos una posición hacia atrás
                For i As Integer = size - 1 To 0 Step -1
                    array(i + 1) = array(i)
                Next

                ' Insertar el valor al frente
                array(0) = value
                If front = -1 Then front = 0
                rear = (rear + 1) Mod array.Length
                size += 1
            End Sub

            ' Inserta un elemento en el final de la cola
            Public Sub InsertRear(value As Integer)
                If IsFull() Then
                    MessageBox.Show("The Double Queue is full.")
                    Return
                End If

                If rear = -1 Then
                    front = 0
                    rear = 0
                Else
                    rear = (rear + 1) Mod capacity
                End If

                array(rear) = value
                size += 1
            End Sub

            ' Elimina un elemento del frente de la cola
            Public Function DeleteFront() As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Double Queue is empty.")
                    Return -1
                End If

                Dim value As Integer = array(front)
                If front = rear Then
                    front = -1
                    rear = -1
                Else
                    front = (front + 1) Mod capacity
                End If

                size -= 1
                Return value
            End Function

            ' Elimina un elemento del final de la cola
            Public Function DeleteRear() As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Double Queue is empty.")
                    Return -1
                End If

                Dim value As Integer = array(rear)
                If front = rear Then
                    front = -1
                    rear = -1
                Else
                    rear = (rear - 1 + capacity) Mod capacity
                End If

                size -= 1
                Return value
            End Function

            ' Ver el valor en el frente sin eliminarlo
            Public Function GetFront() As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Double Queue is empty.")
                    Return -1
                End If
                Return array(front)
            End Function

            ' Ver el valor en el final sin eliminarlo
            Public Function GetRear() As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Double Queue is empty.")
                    Return -1
                End If
                Return array(rear)
            End Function

            ' Obtener el tamaño actual de la cola
            Public Function Size() As Integer
                Return Size
            End Function

            Public Function GetQueueElements() As List(Of Integer)
                Dim elements As New List(Of Integer)

                If front <> -1 Then
                    For i As Integer = front To rear
                        elements.Add(array(i))
                    Next
                End If

                Return elements
            End Function
        End Class

        Friend Class DoubleEndedDynamicQueue
            Private front As DoublyNode
            Private back As DoublyNode
            Private size As Integer

            Public Sub New()
                front = Nothing
                back = Nothing
                size = 0
            End Sub

            ' Agregar un elemento al frente de la cola
            Public Sub InsertFront(value As Integer)
                Dim newNode As New DoublyNode(value)

                If IsEmpty() Then
                    front = back = newNode
                Else
                    newNode.Next = front
                    front.Prev = newNode
                    front = newNode
                End If

                size += 1
            End Sub

            ' Agregar un elemento al final de la cola
            Public Sub InsertRear(value As Integer)
                Dim newNode As New DoublyNode(value)

                If IsEmpty() Then
                    front = back = newNode
                Else
                    newNode.Prev = back
                    back.Next = newNode
                    back = newNode
                End If

                size += 1
            End Sub

            ' Eliminar un elemento del frente de la cola
            Public Function DeleteFront() As Integer
                If IsEmpty() Then
                    Throw New InvalidOperationException("Queue is empty.")
                End If

                Dim frontValue As Integer = front.Value
                front = front.Next

                If front IsNot Nothing Then
                    front.Prev = Nothing
                Else
                    back = Nothing
                End If

                size -= 1
                Return frontValue
            End Function

            ' Eliminar un elemento del final de la cola
            Public Function DeleteRear() As Integer
                If IsEmpty() Then
                    Throw New InvalidOperationException("Queue is empty.")
                End If

                Dim backValue As Integer = back.Value
                back = back.Prev

                If back IsNot Nothing Then
                    back.Next = Nothing
                Else
                    front = Nothing
                End If

                size -= 1
                Return backValue
            End Function

            ' Ver el elemento del frente de la cola sin eliminarlo
            Public Function GetFront() As Integer
                If IsEmpty() Then
                    Throw New InvalidOperationException("Queue is empty.")
                End If

                Return front.Value
            End Function

            ' Ver el elemento del final de la cola sin eliminarlo
            Public Function GetRear() As Integer
                If IsEmpty() Then
                    Throw New InvalidOperationException("Queue is empty.")
                End If

                Return back.Value
            End Function

            ' Obtener el tamaño de la cola
            Public Function Size() As Integer
                Return Size
            End Function

            ' Verificar si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return size = 0
            End Function

            Public Function GetQueueElements() As List(Of Integer)
                Dim elements As New List(Of Integer)()
                Dim current As DoublyNode = front

                While current IsNot Nothing
                    elements.Add(current.Value)
                    current = current.Next
                End While

                Return elements
            End Function
        End Class
    End Class
End Namespace
