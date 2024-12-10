Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace data_structure_proyecto_final_vb
    Friend Class Graphs

    End Class
    Public Class GraphNode
        Public Property Name As String
        Public Property Neighbors As List(Of Edge)

        Public Sub New(name As String)
            Me.Name = name
            Me.Neighbors = New List(Of Edge)()
        End Sub
    End Class

    Public Class Edge
        Public Property [To] As GraphNode
        Public Property Weight As Integer

        Public Sub New([to] As GraphNode, weight As Integer)
            Me.To = [to]
            Me.Weight = weight
        End Sub

        Public Sub New([to] As GraphNode)
            Me.To = [to]
        End Sub
    End Class

    Public Class Graph
        Public Property Nodes As List(Of GraphNode)
        Public Property AdjacencyList As List(Of List(Of Edge))

        Public Sub New()
            Nodes = New List(Of GraphNode)()
            AdjacencyList = New List(Of List(Of Edge))()
        End Sub

        Public Sub AddNode(newNode As GraphNode)
            Nodes.Add(newNode)
            AdjacencyList.Add(New List(Of Edge)())
        End Sub

        Public Sub AddEdge(fromNode As GraphNode, toNode As GraphNode)
            If Nodes.Contains(fromNode) AndAlso Nodes.Contains(toNode) Then
                Dim newEdge As New Edge(toNode)
                fromNode.Neighbors.Add(newEdge)
                AdjacencyList(Nodes.IndexOf(fromNode)).Add(newEdge)
            End If
        End Sub

        Public Sub Clear()
            Nodes.Clear()
            AdjacencyList.Clear()
        End Sub

        ' Método para agregar un borde con peso
        Public Sub AddEdge(fromNode As GraphNode, toNode As GraphNode, weight As Integer)
            If Nodes.Contains(fromNode) AndAlso Nodes.Contains(toNode) Then
                Dim newEdge As New Edge(toNode, weight)
                fromNode.Neighbors.Add(newEdge)
                AdjacencyList(Nodes.IndexOf(fromNode)).Add(newEdge)
            End If
        End Sub

        ' Método para agregar un borde no dirigido con peso
        Public Sub AddNoDirectedEdge(node1 As GraphNode, node2 As GraphNode, weight As Integer)
            AddEdge(node1, node2, weight)
            AddEdge(node2, node1, weight)
        End Sub

        ' Sobrecarga del método para agregar un borde no dirigido sin peso
        Public Sub AddNoDirectedEdge(node1 As GraphNode, node2 As GraphNode)
            AddEdge(node1, node2)
            AddEdge(node2, node1)
        End Sub

        Public Sub RemoveNode(nodeToRemove As GraphNode)
            If Nodes.Contains(nodeToRemove) Then
                Dim index As Integer = Nodes.IndexOf(nodeToRemove)
                Nodes.RemoveAt(index)
                AdjacencyList.RemoveAt(index)

                ' Eliminar bordes hacia este nodo
                For Each node In Nodes
                    node.Neighbors.RemoveAll(Function(edge) edge.To Is nodeToRemove)
                Next

                ' Eliminar bordes en la lista de adyacencia
                For Each adjList In AdjacencyList
                    adjList.RemoveAll(Function(edge) edge.To Is nodeToRemove)
                Next
            End If
        End Sub

        ' Método para eliminar un borde no dirigido
        Public Sub RemoveNoDirectedEdge(node1 As GraphNode, node2 As GraphNode)
            RemoveEdge(node1, node2)
            RemoveEdge(node2, node1)
        End Sub

        Public Sub RemoveEdge(fromNode As GraphNode, toNode As GraphNode)
            If Nodes.Contains(fromNode) AndAlso Nodes.Contains(toNode) Then
                Dim edgeToRemove As Edge = fromNode.Neighbors.Find(Function(e) e.To Is toNode)
                If edgeToRemove IsNot Nothing Then
                    fromNode.Neighbors.Remove(edgeToRemove)
                    AdjacencyList(Nodes.IndexOf(fromNode)).Remove(edgeToRemove)
                End If
            End If
        End Sub

        Public Sub RemoveGraph()
            Nodes.Clear()
            AdjacencyList.Clear()
        End Sub

        Public Function ShowAdjacencyList() As String
            Dim sb As New StringBuilder()

            For i As Integer = 0 To Nodes.Count - 1
                sb.Append(Nodes(i).Name & ": ")
                For Each edge In AdjacencyList(i)
                    sb.Append(edge.To.Name & ", ")
                Next
                sb.AppendLine()
            Next

            Return sb.ToString()
        End Function

        ' Método para mostrar la lista de adyacencia con pesos
        Public Function ShowAdjacencyListWithWeights() As String
            Dim sb As New StringBuilder()

            For i As Integer = 0 To Nodes.Count - 1
                sb.Append(Nodes(i).Name & ": ")
                For Each edge In AdjacencyList(i)
                    sb.Append(edge.To.Name & " (" & edge.Weight & "), ")
                Next
                sb.AppendLine()
            Next

            Return sb.ToString()
        End Function

        Public Function DFS(startNode As GraphNode) As String
            If startNode Is Nothing OrElse Not Nodes.Contains(startNode) Then Return String.Empty

            Dim visited As New List(Of GraphNode)()  ' Lista de nodos visitados
            Dim result As New StringBuilder()  ' Para acumular el resultado

            DFSRecursive(startNode, visited, result)

            Return result.ToString()
        End Function

        Private Sub DFSRecursive(currentNode As GraphNode, visited As List(Of GraphNode), result As StringBuilder)
            ' Marcar el nodo como visitado
            visited.Add(currentNode)

            ' Agregar el nodo actual al resultado
            If result.Length > 0 Then
                result.Append(" → ")  ' Añadir flecha entre nodos
            End If
            result.Append(currentNode.Name)

            ' Recorrer los nodos adyacentes
            For Each edge In currentNode.Neighbors
                Dim adjacentNode As GraphNode = edge.To
                If Not visited.Contains(adjacentNode) Then
                    DFSRecursive(adjacentNode, visited, result)  ' Llamada recursiva
                End If
            Next
        End Sub

        Public Function DFSIterative(startNode As GraphNode) As String
            If startNode Is Nothing OrElse Not Nodes.Contains(startNode) Then Return String.Empty

            Dim visited As New List(Of GraphNode)()  ' Lista de nodos visitados
            Dim stack As New Stack(Of GraphNode)()  ' Pila para el recorrido
            Dim result As New StringBuilder()  ' Para acumular el resultado

            stack.Push(startNode)  ' Agregar el nodo de inicio a la pila

            While stack.Count > 0
                Dim currentNode As GraphNode = stack.Pop()  ' Obtener el nodo en la cima de la pila

                If Not visited.Contains(currentNode) Then
                    ' Agregar el nodo actual al resultado
                    If result.Length > 0 Then
                        result.Append(" → ")  ' Añadir flecha entre nodos
                    End If
                    result.Append(currentNode.Name)

                    visited.Add(currentNode)  ' Marcar el nodo como visitado

                    Dim reversedEdges = currentNode.Neighbors.OrderByDescending(Function(e) e.To.Name).ToList()

                    ' Apilar los nodos adyacentes no visitados
                    For Each edge In reversedEdges
                        Dim adjacentNode As GraphNode = edge.To
                        If Not visited.Contains(adjacentNode) Then
                            stack.Push(adjacentNode)  ' Agregar a la pila si no ha sido visitado
                        End If
                    Next
                End If
            End While

            Return result.ToString()
        End Function

        Public Function BFS(startNode As GraphNode) As String
            If startNode Is Nothing OrElse Not Nodes.Contains(startNode) Then Return String.Empty

            Dim visited As New List(Of GraphNode)()  ' Lista de nodos visitados
            Dim queue As New Queue(Of GraphNode)()  ' Cola para el recorrido
            Dim result As New StringBuilder()  ' Para acumular el resultado

            queue.Enqueue(startNode)  ' Agregar el nodo de inicio a la cola

            While queue.Count > 0
                Dim currentNode As GraphNode = queue.Dequeue()  ' Obtener el nodo al frente de la cola

                If Not visited.Contains(currentNode) Then
                    ' Agregar el nodo actual al resultado
                    If result.Length > 0 Then
                        result.Append(" → ")  ' Añadir flecha entre nodos
                    End If
                    result.Append(currentNode.Name)

                    visited.Add(currentNode)  ' Marcar el nodo como visitado

                    ' Encolar los nodos adyacentes no visitados
                    For Each edge In currentNode.Neighbors
                        Dim adjacentNode As GraphNode = edge.To
                        If Not visited.Contains(adjacentNode) AndAlso Not queue.Contains(adjacentNode) Then
                            queue.Enqueue(adjacentNode)  ' Agregar a la cola si no ha sido visitado
                        End If
                    Next
                End If
            End While

            Return result.ToString()
        End Function
    End Class
End Namespace
