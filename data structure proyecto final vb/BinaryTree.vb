Imports System

Namespace Data_Structure_Final_Project
    Friend Class BinaryTree


        Public Class Node
            Public Property left As Node
            Public Property right As Node
            Public Property value As Integer?

            Public Sub New(value As Integer)
                Me.Value = value
                Me.left = Nothing
                Me.right = Nothing
            End Sub

            Public Sub New()
                Me.Value = Nothing
                Me.left = Nothing
                Me.right = Nothing
            End Sub

            Public Sub Insert(value As Integer)
                If Me.Value Is Nothing Then
                    Me.Value = value
                    Return
                End If

                If value < Me.Value Then
                    If left Is Nothing Then
                        left = New Node(value)
                    Else
                        left.Insert(value)
                    End If
                Else
                    If right Is Nothing Then
                        right = New Node(value)
                    Else
                        right.Insert(value)
                    End If
                End If
            End Sub

            Public Function Search(value As Integer) As Node
                If Me.Value Is Nothing Then
                    Return Nothing
                End If

                If Me.Value = value Then
                    Return Me
                End If

                If value < Me.Value Then
                    If left IsNot Nothing Then
                        Return left.Search(value)
                    Else
                        Return Nothing
                    End If
                Else
                    If right IsNot Nothing Then
                        Return right.Search(value)
                    Else
                        Return Nothing
                    End If
                End If
            End Function

            Public Function Delete(root As Node, value As Integer) As Node
                If root Is Nothing Then
                    Return Nothing
                End If

                If value < root.Value Then
                    root.left = Delete(root.left, value)
                ElseIf value > root.Value Then
                    root.right = Delete(root.right, value)
                Else
                    If root.left Is Nothing AndAlso root.right Is Nothing Then
                        Return Nothing
                    ElseIf root.left Is Nothing Then
                        Return root.right
                    ElseIf root.right Is Nothing Then
                        Return root.left
                    Else
                        Dim minNode As Node = FindMin(root.right)
                        root.Value = minNode.Value
                        root.right = Delete(root.right, CType(minNode.Value, Integer))
                    End If
                End If

                Return root
            End Function

            Private Function FindMin(node As Node) As Node
                While node.left IsNot Nothing
                    node = node.left
                End While
                Return node
            End Function

            Public Function GetNodeInfo(node As Node, action As String) As String
                If node Is Nothing Then
                    Return "Node with value not found."
                End If

                Dim height As Integer = GetNodeHeight(node)
                Dim isLeaf As Boolean = node.left Is Nothing AndAlso node.right Is Nothing
                Dim leafStatus As String = If(isLeaf, "is a leaf node", "is not a leaf node")

                Return $"The {action} Node with value {node.Value.ToString()} was found at the height {height} and {leafStatus}."
            End Function

            Public Function GetNodeHeight(node As Node) As Integer
                If Me Is Nothing Then
                    Return 0
                End If

                Dim height As Integer = 1
                If Value = node?.Value Then
                    Return height
                End If

                If node?.Value < Value Then
                    If left IsNot Nothing Then
                        If left.Value = node?.Value Then
                            Return height + 1
                        End If
                        Dim temp As Integer = left.GetNodeHeight(node)
                        Return height + temp
                    Else
                        Return 0
                    End If
                Else
                    If right IsNot Nothing Then
                        If right.Value = node?.Value Then
                            Return height + 1
                        End If
                        Return height + right.GetNodeHeight(node)
                    Else
                        Return 0
                    End If
                End If
            End Function

            Public Function CountNodes() As Integer
                Dim count As Integer = 1
                If left IsNot Nothing Then
                    count += left.CountNodes()
                End If
                If right IsNot Nothing Then
                    count += right.CountNodes()
                End If
                Return count
            End Function

            Public Function GetHeight() As Integer
                If Me Is Nothing Then
                    Return 0
                End If

                Dim leftHeight As Integer = If(left IsNot Nothing, left.GetHeight(), 0)
                Dim rightHeight As Integer = If(right IsNot Nothing, right.GetHeight(), 0)

                Return Math.Max(leftHeight, rightHeight) + 1
            End Function

            Public Sub TreeInfo()
                Dim heightt As Integer = GetHeight()
                Dim nodeCount As Integer = CountNodes()
                Dim height As Integer = heightt
                Dim levels As Integer = height

                MessageBox.Show($"Tree Information:{vbCrLf}Nodes: {nodeCount}{vbCrLf}Height: {height}{vbCrLf}Levels: {levels}")
            End Sub
        End Class
    End Class
End Namespace
