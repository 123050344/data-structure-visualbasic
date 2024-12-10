Imports System

Namespace Data_Structure_Final_Project
    Friend Class Lists
        Public Class LinkedList
            Private head As Node

            Public Sub New()
                head = Nothing
            End Sub

            Public Sub Add(newNode As Node)
                If head Is Nothing Then
                    head = newNode
                    Return
                End If

                If newNode.Value < head.Value Then
                    newNode.NextNode = head
                    head = newNode
                    Return
                End If

                Dim current As Node = head
                While current.NextNode IsNot Nothing AndAlso current.NextNode.Value < newNode.Value
                    current = current.NextNode
                End While
                newNode.NextNode = current.NextNode
                current.NextNode = newNode
            End Sub

            Public Sub Remove(value As Integer)
                If head Is Nothing Then Return

                If head.Value = value Then
                    head = head.NextNode
                    Return
                End If

                Dim current As Node = head
                While current.NextNode IsNot Nothing
                    If current.NextNode.Value = value Then
                        current.NextNode = current.NextNode.NextNode
                        Return
                    End If
                    current = current.NextNode
                End While
            End Sub

            Public Function Contains(value As Integer) As Boolean
                Dim current As Node = head
                While current IsNot Nothing
                    If current.Value = value Then Return True
                    current = current.NextNode
                End While
                Return False
            End Function

            Public ReadOnly Property Count As Integer
                Get
                    Dim count As Integer = 0
                    Dim current As Node = head
                    While current IsNot Nothing
                        count += 1
                        current = current.NextNode
                    End While
                    Return count
                End Get
            End Property

            Public Overrides Function ToString() As String
                Dim result As String = ""
                Dim current As Node = head
                While current IsNot Nothing
                    result &= current.ToString() & " "
                    current = current.NextNode
                End While
                Return result
            End Function

            Public Function GetHead() As Node
                Return head
            End Function
        End Class

        Public Class DoublyLinkedList
            Private head As DoublyNode

            Public Sub New()
                head = Nothing
            End Sub

            Public Sub Add(newNode As DoublyNode)
                If head Is Nothing OrElse head.Value >= newNode.Value Then
                    newNode.NextNode = head
                    If head IsNot Nothing Then head.PrevNode = newNode
                    head = newNode
                Else
                    Dim current As DoublyNode = head
                    While current.NextNode IsNot Nothing AndAlso current.NextNode.Value < newNode.Value
                        current = current.NextNode
                    End While

                    newNode.NextNode = current.NextNode
                    If current.NextNode IsNot Nothing Then current.NextNode.PrevNode = newNode
                    current.NextNode = newNode
                    newNode.PrevNode = current
                End If
            End Sub

            Public Sub Remove(value As Integer)
                If head Is Nothing Then Return

                If head.Value = value Then
                    head = head.NextNode
                    If head IsNot Nothing Then head.PrevNode = Nothing
                    Return
                End If

                Dim current As DoublyNode = head
                While current.NextNode IsNot Nothing
                    If current.NextNode.Value = value Then
                        current.NextNode = current.NextNode.NextNode
                        If current.NextNode IsNot Nothing Then current.NextNode.PrevNode = current
                        Return
                    End If
                    current = current.NextNode
                End While
            End Sub

            Public ReadOnly Property Count As Integer
                Get
                    Dim count As Integer = 0
                    Dim current As DoublyNode = head
                    While current IsNot Nothing
                        count += 1
                        current = current.NextNode
                    End While
                    Return 0
                End Get
            End Property

            Public Function Contains(value As Integer) As Boolean
                Dim current As DoublyNode = head
                While current IsNot Nothing
                    If current.Value = value Then Return True
                    current = current.NextNode
                End While
                Return False
            End Function

            Public Function GetHead() As DoublyNode
                Return head
            End Function
        End Class
    End Class

    Public Class Node
        Public Sub New(value As Integer)
            Me.Value = value
        End Sub

        Public Property Value As Integer
        Public Property NextNode As Node

        Public Overrides Function ToString() As String
            Return Value.ToString()
        End Function

        Friend Function [Next]() As Node
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class DoublyNode
        Public Sub New(value As Integer)
            Me.Value = value
        End Sub

        Public Property Value As Integer
        Public Property NextNode As DoublyNode
        Public Property PrevNode As DoublyNode
        Public Property [Next] As DoublyNode

        Public Overrides Function ToString() As String
            Return Value.ToString()
        End Function
    End Class
End Namespace
