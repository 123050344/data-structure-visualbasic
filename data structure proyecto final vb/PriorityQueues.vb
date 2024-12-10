Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace data_structure_proyecto_final_vb
    Friend Class PriorityQueues
        Public Class VectorOfVectors_PQ(Of T)
            Public _queue As T()()
            Public _maxPriority As Integer

            ' Constructor, initialize with max priority level
            Public Sub New(maxPriority As Integer)
                _maxPriority = maxPriority
                _queue = New T(maxPriority)() {}
                For i As Integer = 0 To maxPriority
                    _queue(i) = New T(0) {}
                Next
            End Sub

            ' Enqueue an item with a specified priority
            Public Sub Enqueue(item As T, priority As Integer)
                If priority < 0 OrElse priority > _maxPriority Then
                    MessageBox.Show("Priority out of range.")
                    Return
                End If

                ' Resize the array at the given priority index to accommodate the new item
                Array.Resize(Of T)(Ref_queue(priority), _queue(priority).Length + 1)
                _queue(priority)(_queue(priority).Length - 1) = item
            End Sub

            Private Function Ref() As T()
                Throw New NotImplementedException()
            End Function

            ' Dequeue the item with the highest priority (largest priority value)
            Public Function Dequeue() As T
                For i As Integer = _maxPriority To 0 Step -1
                    If _queue(i).Length > 0 Then
                        Dim item As T = _queue(i)(0)
                        ' Shift all items down in the array (like removing the first element)
                        For j As Integer = 0 To _queue(i).Length - 2
                            _queue(i)(j) = _queue(i)(j + 1)
                        Next
                        Array.Resize(Of T)(Ref_queue(i), _queue(i).Length - 1) ' Remove last item (after shift)
                        Return item
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            Private Function Ref_queue(i As Integer) As T()
                Throw New NotImplementedException()
            End Function

            ' Peek the item with the highest priority (without removing it)
            Public Function Peek() As T
                For i As Integer = _maxPriority To 0 Step -1
                    If _queue(i).Length > 0 Then
                        Return _queue(i)(0)
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Check if the priority queue is empty
            Public Function IsEmpty() As Boolean
                For i As Integer = 0 To _maxPriority
                    If _queue(i).Length > 0 Then
                        Return False
                    End If
                Next
                Return True
            End Function

            ' Return the number of elements in the priority queue
            Public Function Size() As Integer
                Dim size As Integer = 0
                For i As Integer = 0 To _maxPriority
                    size += _queue(i).Length
                Next
                Return size
            End Function

            Public Function ToList() As List(Of String)
                Dim result As New List(Of String)()
                For i As Integer = _queue.Length - 1 To 0 Step -1
                    For Each item As T In _queue(i)
                        result.Add($"Priority {i}: {item}")
                    Next
                Next
                Return result
            End Function
        End Class

        Public Class VectorOfLists_PQ(Of T)
            Private _priorityLists As List(Of T)()
            Private _maxPriority As Integer

            ' Constructor
            Public Sub New(maxPriority As Integer)
                If maxPriority < 0 Then
                    Throw New ArgumentException("Max priority must be non-negative.")
                End If

                _maxPriority = maxPriority
                _priorityLists = New List(Of T)(maxPriority + 1) {}

                For i As Integer = 0 To maxPriority
                    _priorityLists(i) = New List(Of T)()
                Next
            End Sub

            ' Add an item with specified priority
            Public Sub Enqueue(item As T, priority As Integer)
                If priority < 0 OrElse priority > _maxPriority Then
                    MessageBox.Show("Priority out of range.")
                    Return
                End If

                ' Add item to the appropriate priority list
                _priorityLists(priority).Add(item)
            End Sub

            ' Remove and return the highest priority item
            Public Function Dequeue() As T
                For i As Integer = _maxPriority To 0 Step -1
                    If _priorityLists(i).Count > 0 Then
                        Dim item As T = _priorityLists(i)(0)
                        _priorityLists(i).RemoveAt(0)
                        Return item
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' View the highest priority item without removing it
            Public Function Peek() As T
                For i As Integer = _maxPriority To 0 Step -1
                    If _priorityLists(i).Count > 0 Then
                        Return _priorityLists(i)(0)
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Check if the queue is empty
            Public Function IsEmpty() As Boolean
                For i As Integer = 0 To _maxPriority
                    If _priorityLists(i).Count > 0 Then
                        Return False
                    End If
                Next
                Return True
            End Function

            ' Get the total number of items in the queue
            Public Function Size() As Integer
                Dim totalSize As Integer = 0
                For i As Integer = 0 To _maxPriority
                    totalSize += _priorityLists(i).Count
                Next
                Return totalSize
            End Function

            ' Optional: Clear the entire queue
            Public Sub Clear()
                For i As Integer = 0 To _maxPriority
                    _priorityLists(i).Clear()
                Next
            End Sub

            Public Function ToList() As List(Of String)
                Dim result As New List(Of String)()
                For i As Integer = _priorityLists.Length - 1 To 0 Step -1
                    For Each item As T In _priorityLists(i)
                        result.Add($"Priority {i}: {item}")
                    Next
                Next
                Return result
            End Function
        End Class

        Public Class ListOfLists_PQ(Of T)
            Private _queue As List(Of List(Of T))
            Private _maxPriority As Integer

            ' Constructor, initialize with max priority level.
            Public Sub New(maxPriority As Integer)
                _maxPriority = maxPriority
                _queue = New List(Of List(Of T))(maxPriority + 1)
                For i As Integer = 0 To maxPriority
                    _queue.Add(New List(Of T)())
                Next
            End Sub

            ' Enqueue an item with a specified priority
            Public Sub Enqueue(item As T, priority As Integer)
                If priority < 0 OrElse priority > _maxPriority Then
                    MessageBox.Show("Priority out of range.")
                    Return
                End If

                _queue(priority).Add(item)
            End Sub

            ' Dequeue the item with the highest priority (largest priority value)
            Public Function Dequeue() As T
                For i As Integer = _maxPriority To 0 Step -1
                    If _queue(i).Count > 0 Then
                        Dim item As T = _queue(i)(0)
                        _queue(i).RemoveAt(0)
                        Return item
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Peek the item with the highest priority (without removing it)
            Public Function Peek() As T
                For i As Integer = _maxPriority To 0 Step -1
                    If _queue(i).Count > 0 Then
                        Return _queue(i)(0)
                    End If
                Next

                Throw New InvalidOperationException("Queue is empty.")
            End Function

            ' Check if the priority queue is empty
            Public Function IsEmpty() As Boolean
                For i As Integer = 0 To _maxPriority
                    If _queue(i).Count > 0 Then
                        Return False
                    End If
                Next
                Return True
            End Function

            ' Return the number of elements in the priority queue
            Public Function Size() As Integer
                Dim size As Integer = 0
                For i As Integer = 0 To _maxPriority
                    size += _queue(i).Count
                Next
                Return size
            End Function

            Public Function ToList() As List(Of String)
                Dim result As New List(Of String)()
                For i As Integer = _queue.Count - 1 To 0 Step -1
                    For Each item As T In _queue(i)
                        result.Add($"Priority {i}: {item}")
                    Next
                Next
                Return result
            End Function
        End Class

        Public Class ListOfVectors_PQ(Of T)
            Private _queue As List(Of T())
            Private _maxPriority As Integer

            Public Sub New(maxPriority As Integer)
                _maxPriority = maxPriority
                _queue = New List(Of T())(maxPriority + 1)
                For i As Integer = 0 To maxPriority
                    _queue.Add(New T(0) {})
                Next
            End Sub

            Public Sub Enqueue(item As T, priority As Integer)
                If priority < 0 OrElse priority > _maxPriority Then
                    MessageBox.Show("Priority out of range.")
                    Return
                End If

                Dim currentArray As T() = _queue(priority)
                Array.Resize(Of T)(Ref currentArray, currentArray.Length + 1)
                currentArray(currentArray.Length - 1) = item
                _queue(priority) = currentArray
            End Sub

            Private Function Ref() As T()
                Throw New NotImplementedException()
            End Function

            Public Function Dequeue() As T
                For i As Integer = _maxPriority To 0 Step -1
                    If _queue(i).Length > 0 Then
                        Dim item As T = _queue(i)(0)
                        Dim currentArray As T() = _queue(i)
                        Dim newArray As T() = New T(currentArray.Length - 1) {}
                        Array.Copy(currentArray, 1, newArray, 0, newArray.Length)
                        _queue(i) = newArray
                        Return item
                    End If
                Next
                Throw New InvalidOperationException("Queue is empty.")
            End Function

            Public Function Peek() As T
                For i As Integer = _maxPriority To 0 Step -1
                    If _queue(i).Length > 0 Then
                        Return _queue(i)(0)
                    End If
                Next
                Throw New InvalidOperationException("Queue is empty.")
            End Function

            Public Function IsEmpty() As Boolean
                For i As Integer = 0 To _maxPriority
                    If _queue(i).Length > 0 Then
                        Return False
                    End If
                Next
                Return True
            End Function

            Public Function Size() As Integer
                Dim size As Integer = 0
                For i As Integer = 0 To _maxPriority
                    size += _queue(i).Length
                Next
                Return size
            End Function

            Public Function ToList() As List(Of String)
                Dim result As New List(Of String)()
                For i As Integer = _queue.Count - 1 To 0 Step -1
                    For Each item As T In _queue(i)
                        result.Add($"Priority {i}: {item}")
                    Next
                Next
                Return result
            End Function
        End Class
    End Class
End Namespace
