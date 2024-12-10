Imports System
Imports System.Windows.Forms
Imports data_structure_proyecto_final_vb.Data_Structure_Final_Project
Imports data_structure_proyecto_final_vb.Data_Structure_Final_Project.Lists

Public Class ListsForm
    Inherits ZBase

    Private linkedList As LinkedList
    Private doublyLinkedList As DoublyLinkedList
    Private circularLinkedList As CircularLinkedList
    Private doublyCircularLinkedList As DoublyCircularLinkedList

    Public Sub New()
        InitializeComponent()
        linkedList = New LinkedList()
        doublyLinkedList = New DoublyLinkedList()
        circularLinkedList = New CircularLinkedList()
        doublyCircularLinkedList = New DoublyCircularLinkedList()

        cmbListType.Items.Add("Simple Linked List")
        cmbListType.Items.Add("Doubly Linked List")
        cmbListType.Items.Add("Circular Linked List")
        cmbListType.Items.Add("Doubly Circular Linked List")
        cmbListType.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim value As Integer
        If Integer.TryParse(txtValue.Text, value) Then
            Dim selectedList As String = cmbListType.SelectedItem.ToString()
            Select Case selectedList
                Case "Simple Linked List"
                    linkedList.Add(New Node(value))
                    UpdateListBox(lstSimpleLinkedList, linkedList.GetHead())
                Case "Doubly Linked List"
                    doublyLinkedList.Add(New DoublyNode(value))
                    UpdateListBox(lstSimpleLinkedList, doublyLinkedList.GetHead())
                Case "Circular Linked List"
                    circularLinkedList.Add(New Node(value))
                    UpdateListBox(lstSimpleLinkedList, circularLinkedList.GetHead())
                Case "Doubly Circular Linked List"
                    doublyCircularLinkedList.Add(New DoublyNode(value))
                    UpdateListBox(lstSimpleLinkedList, doublyCircularLinkedList.GetHead())
            End Select

            txtValue.Clear()
            txtValue.Focus()
        Else
            MessageBox.Show("Please enter a valid integer value.")
        End If
    End Sub

    Private Sub UpdateListBox(listBox As ListBox, head As Object)
        listBox.Items.Clear()

        If TypeOf head Is Node Then
            Dim headNode As Node = CType(head, Node)
            Dim current As Node = headNode

            Do
                listBox.Items.Add(current.Value)
                current = current.Next
            Loop While current IsNot Nothing AndAlso current IsNot headNode

        ElseIf TypeOf head Is DoublyNode Then
            Dim headDoubleNode As DoublyNode = CType(head, DoublyNode)
            Dim current As DoublyNode = headDoubleNode

            Do
                listBox.Items.Add(current.Value)
                current = current.Next
            Loop While current IsNot Nothing AndAlso current IsNot headDoubleNode
        End If
    End Sub

    Private Sub cmbListType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbListType.SelectedIndexChanged
        lstSimpleLinkedList.Items.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim value As Integer
        If Integer.TryParse(txtValue.Text, value) Then
            Dim selectedList As String = cmbListType.SelectedItem.ToString()
            Select Case selectedList
                Case "Simple Linked List"
                    linkedList.Remove(value)
                    UpdateListBox(lstSimpleLinkedList, linkedList.GetHead())
                Case "Doubly Linked List"
                    doublyLinkedList.Remove(value)
                    UpdateListBox(lstSimpleLinkedList, doublyLinkedList.GetHead())
                Case "Circular Linked List"
                    circularLinkedList.Remove(value)
                    UpdateListBox(lstSimpleLinkedList, circularLinkedList.GetHead())
                Case "Doubly Circular Linked List"
                    doublyCircularLinkedList.Remove(value)
                    UpdateListBox(lstSimpleLinkedList, doublyCircularLinkedList.GetHead())
            End Select

            txtValue.Clear()
            txtValue.Focus()
        Else
            MessageBox.Show("Please enter a valid integer value.")
        End If
    End Sub

    Private Sub btnContains_Click(sender As Object, e As EventArgs) Handles btnContains.Click
        Dim value As Integer
        If Integer.TryParse(txtValue.Text, value) Then
            Dim selectedList As String = cmbListType.SelectedItem.ToString()
            Dim contains As Boolean = False
            Select Case selectedList
                Case "Simple Linked List"
                    contains = linkedList.Contains(value)
                Case "Doubly Linked List"
                    contains = doublyLinkedList.Contains(value)
                Case "Circular Linked List"
                    contains = circularLinkedList.Contains(value)
                Case "Doubly Circular Linked List"
                    contains = doublyCircularLinkedList.Contains(value)
            End Select

            MessageBox.Show(If(contains, "The list contains the value.", "The list does not contain the value."))
        Else
            MessageBox.Show("Please enter a valid integer value.")
        End If
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim selectedList As String = cmbListType.SelectedItem.ToString()
        Dim count As Integer = 0
        Select Case selectedList
            Case "Simple Linked List"
                count = linkedList.Count()
            Case "Doubly Linked List"
                count = doublyLinkedList.Count()
            Case "Circular Linked List"
                count = circularLinkedList.Count()
            Case "Doubly Circular Linked List"
                count = doublyCircularLinkedList.Count()
        End Select
        MessageBox.Show($"The list has {count} elements.")
    End Sub
End Class