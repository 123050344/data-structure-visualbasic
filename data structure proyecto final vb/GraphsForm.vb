Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports data_structure_proyecto_final_vb.data_structure_proyecto_final_vb

Public Class GraphsForm
    Inherits Form

    Private graph As Graph

    Public Sub New()
        InitializeComponent()
        graph = New Graph()
    End Sub

    Private Sub btnAddNode_Click(sender As Object, e As EventArgs) Handles btnAddNode.Click
        Dim nodeName As String = txtNode.Text.Trim()
        If Not String.IsNullOrEmpty(nodeName) Then
            ' Verificar si el nodo ya existe en el grafo
            If graph.Nodes.Any(Function(node) node.Name = nodeName) Then
                MessageBox.Show($"The node '{nodeName}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Si no existe, añadir el nodo
                Dim newNode As New GraphNode(nodeName)
                graph.AddNode(newNode)
                MessageBox.Show($"Node '{nodeName}' added.", "Success", MessageBoxButtons.OK)
                txtNode.Clear()

                Dim weightText As String = txtWeight.Text.Trim()
                If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, Nothing) Then
                    txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
                Else
                    txtGraphRepresentation.Text = graph.ShowAdjacencyList()
                End If
                txtFrom.Clear()
                txtTo.Clear()
            End If
        End If
    End Sub

    Private Sub btnAddEdge_Click(sender As Object, e As EventArgs) Handles btnAddEdge.Click
        Dim fromNodeName As String = txtFrom.Text.Trim()
        Dim toNodeName As String = txtTo.Text.Trim()
        Dim weightText As String = txtWeight.Text.Trim()

        Dim fromNode As GraphNode = graph.Nodes.Find(Function(n) n.Name = fromNodeName)
        Dim toNode As GraphNode = graph.Nodes.Find(Function(n) n.Name = toNodeName)

        If fromNode IsNot Nothing AndAlso toNode IsNot Nothing Then
            If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, Nothing) Then
                Dim weight As Integer = Integer.Parse(weightText)
                If chkDirected.Checked Then
                    graph.AddEdge(fromNode, toNode, weight)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.")
                Else
                    graph.AddNoDirectedEdge(fromNode, toNode, weight)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.")
                End If
                txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
            Else
                If chkDirected.Checked Then
                    graph.AddEdge(fromNode, toNode)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.")
                Else
                    graph.AddNoDirectedEdge(fromNode, toNode)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.")
                End If
                txtGraphRepresentation.Text = graph.ShowAdjacencyList()
            End If
            txtFrom.Clear()
            txtTo.Clear()
        Else
            MessageBox.Show("One or both nodes do not exist.")
        End If
    End Sub

    Private Sub btnRemoveNode_Click(sender As Object, e As EventArgs) Handles btnRemoveNode.Click
        Dim nodeName As String = txtNode.Text.Trim()
        Dim nodeToRemove As GraphNode = graph.Nodes.Find(Function(n) n.Name = nodeName)

        If nodeToRemove IsNot Nothing Then
            graph.RemoveNode(nodeToRemove)
            MessageBox.Show($"Node '{nodeName}' deleted.", "Success", MessageBoxButtons.OK)
            txtNode.Clear()

            Dim weightText As String = txtWeight.Text.Trim()
            If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, Nothing) Then
                txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
            Else
                txtGraphRepresentation.Text = graph.ShowAdjacencyList()
            End If
            txtFrom.Clear()
            txtTo.Clear()
        Else
            MessageBox.Show("Node not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnRemoveEdge_Click(sender As Object, e As EventArgs) Handles btnRemoveEdge.Click
        Dim fromNodeName As String = txtFrom.Text.Trim()
        Dim toNodeName As String = txtTo.Text.Trim()
        Dim isDirected As Boolean = chkDirected.Checked

        Dim fromNode As GraphNode = graph.Nodes.Find(Function(n) n.Name = fromNodeName)
        Dim toNode As GraphNode = graph.Nodes.Find(Function(n) n.Name = toNodeName)

        If fromNode IsNot Nothing AndAlso toNode IsNot Nothing Then
            If isDirected Then
                graph.RemoveEdge(fromNode, toNode)
                MessageBox.Show($"Directed edge removed from '{fromNodeName}' to '{toNodeName}'.", "Success", MessageBoxButtons.OK)
            Else
                graph.RemoveEdge(fromNode, toNode)
                graph.RemoveEdge(toNode, fromNode)
                MessageBox.Show($"Undirected edge removed between '{fromNodeName}' and '{toNodeName}'.", "Success", MessageBoxButtons.OK)
            End If

            Dim weightText As String = txtWeight.Text.Trim()
            If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, Nothing) Then
                txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
            Else
                txtGraphRepresentation.Text = graph.ShowAdjacencyList()
            End If

            txtFrom.Clear()
            txtTo.Clear()
        Else
            MessageBox.Show("One or both nodes do not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnShowDFS_Click(sender As Object, e As EventArgs) Handles btnShowDFS.Click
        txtGraphRepresentation.Clear()
        Dim startNodeName As String = txtStartNode.Text

        Dim startNode As GraphNode = graph.Nodes.FirstOrDefault(Function(n) n.Name = startNodeName)

        If startNode IsNot Nothing Then
            Dim result As String = graph.DFSIterative(startNode)
            txtGraphRepresentation.Text = result
        Else
            txtGraphRepresentation.Text = "Node not found."
        End If
    End Sub

    Private Sub btnShowBFS_Click(sender As Object, e As EventArgs) Handles btnShowBFS.Click
        txtGraphRepresentation.Clear()
        Dim startNodeName As String = txtStartNode.Text

        Dim startNode As GraphNode = graph.Nodes.FirstOrDefault(Function(n) n.Name = startNodeName)

        If startNode IsNot Nothing Then
            Dim result As String = graph.BFS(startNode)
            txtGraphRepresentation.Text = result
        Else
            txtGraphRepresentation.Text = "Node not found."
        End If
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove all nodes and edges?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            graph.RemoveGraph()
            MessageBox.Show("All nodes and edges removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtGraphRepresentation.Clear()
        End If
    End Sub
End Class