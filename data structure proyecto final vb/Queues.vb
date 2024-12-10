Imports System.Windows.Forms

Namespace data_structure_proyecto_final_vb
    Friend Class Queues
        Public Class StaticQueue
            Private elements() As Integer ' Arreglo para almacenar elementos de la cola
            Private front As Integer ' Índice del primer elemento de la cola
            Private rear As Integer ' Índice del último elemento de la cola
            Private count As Integer ' Número de elementos en la cola

            Public ReadOnly Property Capacity As Integer ' Capacidad máxima de la cola

            Public Sub New(capacity As Integer)
                Me.Capacity = capacity
                elements = New Integer(capacity - 1) {} ' Definir el arreglo con el tamaño de la capacidad
                front = 0
                rear = -1
                count = 0
            End Sub

            ' Método para agregar un número a la cola
            Public Sub Enqueue(number As Integer)
                If count = Capacity Then
                    MessageBox.Show("The Queue is full.")
                    Return
                End If

                rear = (rear + 1) Mod Capacity
                elements(rear) = number
                count += 1
            End Sub

            ' Método para eliminar y devolver el número al frente de la cola
            Public Function Dequeue() As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Queue is empty.")
                    Return -1 ' Valor de error
                End If

                Dim number As Integer = elements(front)
                front = (front + 1) Mod Capacity
                count -= 1
                Return number
            End Function

            ' Método para ver el número al frente de la cola sin eliminarlo
            Public Function Peek() As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Queue is empty.")
                    Return -1 ' Valor de error
                End If

                Return elements(front)
            End Function

            ' Método para verificar si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return count = 0
            End Function

            ' Método para verificar si la cola está llena
            Public Function IsFull() As Boolean
                Return count = Capacity
            End Function

            ' Método para obtener el tamaño de la cola
            Public Function Size() As Integer
                Return count
            End Function

            Friend Function GetQueueElements() As IEnumerable(Of Object)
                Throw New NotImplementedException()
            End Function
        End Class

        Public Class DynamicQueue
            Private front As Node ' Nodo al frente de la cola
            Private rear As Node ' Nodo al final de la cola
            Private count As Integer ' Número de elementos en la cola

            Public ReadOnly Property Count As Integer
                Get
                    Return Count ' Retornar el valor del campo privado count
                End Get
            End Property

            Public Sub New(count As Integer)
                front = Nothing
                rear = Nothing
                count = 0
            End Sub

            Public Sub New(count As Integer)
                Me.New(count)
            End Sub

            ' Método para agregar un número a la cola
            Public Sub Enqueue(number As Integer, count As Integer)
                Dim newNode As New Node(number)

                If IsEmpty() Then
                    front = newNode
                    rear = newNode
                Else
                    rear.Next = newNode
                    rear = newNode
                End If

                count += 1
            End Sub

            ' Método para eliminar y devolver el número al frente de la cola
            Public Function Dequeue(count As Integer) As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Queue is empty.")
                    Return -1 ' Valor de error
                End If

                Dim data As Integer = front.Value
                front = front.Next

                If front Is Nothing Then
                    rear = Nothing ' La cola queda vacía
                End If

                count -= 1
                Return data
            End Function

            ' Método para ver el número al frente de la cola sin eliminarlo
            Public Function Peek() As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Queue is empty.")
                    Return -1 ' Valor de error
                End If

                Return front.Value
            End Function

            ' Método para verificar si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return front Is Nothing
            End Function

            Public Function GetCount(Count As Integer) As Integer
                Return Count
            End Function

            ' Método para obtener el tamaño de la cola
            Public Function Size(count As Integer) As Integer
                Return count
            End Function

            Friend Sub Enqueue(value As Integer)
                Throw New NotImplementedException()
            End Sub

            Friend Function GetQueueElements() As IEnumerable(Of Object)
                Throw New NotImplementedException()
            End Function

            Private Class Node
                Public Property Value As Integer
                Public Property [Next] As Node

                Public Sub New(value As Integer)
                    Me.Value = value
                    Me.Next = Nothing
                End Sub
            End Class
        End Class

        Public Class CircularQueue
            Private array() As Integer
            Private front As Integer
            Private rear As Integer
            Private count As Integer
            Public ReadOnly Property Capacity As Integer

            ' Constructor para inicializar la cola circular con un tamaño determinado
            Public Sub New(capacity As Integer)
                Me.Capacity = capacity
                array = New Integer(capacity - 1) {}
                front = 0
                rear = -1
                count = 0
            End Sub

            ' Método para agregar un elemento al final de la cola
            Public Sub Enqueue(value As Integer)
                If count = Capacity Then
                    MessageBox.Show("The Queue is full.")
                    Return
                End If

                rear = (rear + 1) Mod Capacity ' Mover el índice rear de forma circular
                array(rear) = value
                count += 1
            End Sub

            ' Método para eliminar un elemento del frente de la cola
            Public Function Dequeue() As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Queue is empty.")
                    Return -1 ' Valor de error
                End If

                Dim dequeuedValue As Integer = array(front)
                front = (front + 1) Mod Capacity ' Mover el índice front de forma circular
                count -= 1
                Return dequeuedValue
            End Function

            ' Método para ver el valor del frente de la cola sin eliminarlo
            Public Function Peek() As Integer
                If IsEmpty() Then
                    MessageBox.Show("The Queue is empty.")
                    Return -1 ' Valor de error
                End If

                Return array(front)
            End Function

            ' Método para obtener el número de elementos en la cola
            Public Function Size() As Integer
                Return count
            End Function

            ' Método para verificar si la cola está vacía
            Public Function IsEmpty() As Boolean
                Return count = 0
            End Function

            ' Método para verificar si la cola está llena
            Public Function IsFull() As Boolean
                Return count = Capacity
            End Function

            Friend Function GetQueueElements() As IEnumerable(Of Object)
                Throw New NotImplementedException()
            End Function
        End Class
    End Class
End Namespace
