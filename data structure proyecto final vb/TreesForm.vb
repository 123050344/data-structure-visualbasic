Imports System.Drawing
Imports data_structure_proyecto_final_vb.Data_Structure_Final_Project

Public Class TreesForm
    Inherits Form

    Private root As BinaryTree.Node

    Public Sub New()
        InitializeComponent()
        root = New BinaryTree.Node()
    End Sub

    Private Sub DrawTree()
        ' Este método será usado para dibujar el árbol en un control como un Panel
        Using g As Graphics = panelTree.CreateGraphics()
            g.Clear(Color.White) ' Limpia el panel antes de dibujar

            If root IsNot Nothing AndAlso root.Value IsNot Nothing Then
                DrawNode(g, root, panelTree.Width \ 2, 20, 100) ' Comienza a dibujar desde el centro del Panel
            End If
        End Using
    End Sub

    Private Sub DrawNode(g As Graphics, node As BinaryTree.Node, x As Integer, y As Integer, xOffset As Integer)
        If node Is Nothing Then Return

        ' Limitar la posición dentro del Panel
        Dim panelWidth As Integer = panelTree.Width
        Dim panelHeight As Integer = panelTree.Height

        ' Asegurar que las coordenadas x, y no se salgan del área del Panel
        x = Math.Max(30, Math.Min(panelWidth - 30, x))   ' Limita x entre 30 y panelWidth - 30
        y = Math.Max(30, Math.Min(panelHeight - 30, y))  ' Limita y entre 30 y panelHeight - 30

' Dibuja el nodo
g.FillEllipse(Brushes.LightBlue, x - 15, y - 15, 30, 30)
        g.DrawString(node.Value.ToString(), Me.Font, Brushes.Black, x - 10, y - 10)

' Dibuja las aristas
        If node.Left IsNot Nothing Then
            Dim leftX As Integer = x - xOffset
            Dim leftY As Integer = y + 60
g.DrawLine(Pens.Black, x, y, leftX, leftY)
            DrawNode(g, node.Left, leftX, leftY, xOffset \ 2)
End If

        If node.Right IsNot Nothing Then
            Dim rightX As Integer = x + xOffset
            Dim rightY As Integer = y + 60
            g.DrawLine(Pens.Black, x, y, rightX, rightY)
            DrawNode(g, node.Right, rightX, rightY, xOffset \ 2)
        End If
    End Sub

    Private Sub btnInsertNode_Click(sender As Object, e As EventArgs) Handles btnInsertNode.Click
        Dim value As Integer
        If Integer.TryParse(txtNodeValue.Text, value) Then
            root.Insert(value)
            DrawTree()
            txtNodeValue.Clear()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim value As Integer
        If Integer.TryParse(txtNodeValue.Text, value) Then
            root = root.Delete(root, value) ' Elimina el nodo
            DrawTree()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim value As Integer
        If Integer.TryParse(txtNodeValue.Text, value) Then
            Dim foundNode As BinaryTree.Node = root.Search(value)
            MessageBox.Show(root.GetNodeInfo(foundNode, "Found"))
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        root = New BinaryTree.Node() ' Establece la raíz a null, eliminando todo el árbol
        DrawTree()
    End Sub

    Private Sub btnPreOrder_Click(sender As Object, e As EventArgs) Handles btnPreOrder.Click
        Dim result As String = PreOrderTraversal(root)
        txtOutput.Text = result
    End Sub

    Private Function PreOrderTraversal(node As BinaryTree.Node) As String
        If node Is Nothing Then Return ""
        Return node.Value.ToString() & ", " & PreOrderTraversal(node.Left) & PreOrderTraversal(node.Right)
    End Function

    Private Sub btnInOrder_Click(sender As Object, e As EventArgs) Handles btnInOrder.Click
        Dim result As String = InOrderTraversal(root)
        txtOutput.Text = result
    End Sub

    Private Function InOrderTraversal(node As BinaryTree.Node) As String
        If node Is Nothing Then Return ""
        Return InOrderTraversal(node.Left) & node.Value.ToString() & ", " & InOrderTraversal(node.Right)
    End Function

    Private Sub btnPostOrder_Click(sender As Object, e As EventArgs) Handles btnPostOrder.Click
        Dim result As String = PostOrderTraversal(root)
        txtOutput.Text = result
    End Sub

    Private Function PostOrderTraversal(node As BinaryTree.Node) As String
        If node Is Nothing Then Return ""
        Return PostOrderTraversal(node.Left) & PostOrderTraversal(node.Right) & node.Value.ToString() & ", "
    End Function
End Class