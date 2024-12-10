Imports System
Imports System.Windows.Forms
Imports data_structure_proyecto_final_vb.data_structure_proyecto_final_vb.DoubleQueues
Imports data_structure_proyecto_final_vb.data_structure_proyecto_final_vb.PriorityQueues
Imports data_structure_proyecto_final_vb.data_structure_proyecto_final_vb.Queues

Namespace Data_Structure_Final_Project
    Partial Public Class QueuesForm
        Inherits Form

        Private staticQueue As StaticQueue
        Private dynamicQueue As DynamicQueue
        Private circularQueue As CircularQueue
        Private doubleEndedStaticQueue As DoubleEndedStaticQueue
        Private doubleEndedDynamicQueue As DoubleEndedDynamicQueue
        Private vectorOfVectorsPQ As VectorOfVectors_PQ(Of Integer)
        Private vectorOfListsPQ As VectorOfLists_PQ(Of Integer)
        Private listOfListsPQ As ListOfLists_PQ(Of Integer)
        Private listOfVectorsPQ As ListOfVectors_PQ(Of Integer)
        Private cmbQueueType As Object
        Private txtQueueValue As Object
        Private cmbDQType As Object
        Private lstDoubleQueues As Object
        Private cmbTypeOfPQ As Object

        Public Sub New()
            InitializeComponent()

            ' Inicializar las estructuras de datos
            staticQueue = New StaticQueue(5)
            dynamicQueue = New DynamicQueue(5)
            circularQueue = New CircularQueue(5)
            doubleEndedStaticQueue = New DoubleEndedStaticQueue(5)
            doubleEndedDynamicQueue = New DoubleEndedDynamicQueue()

            ' Inicializar combobox
            cmbQueueType.SelectedIndex = 0
            cmbDQType.SelectedIndex = 0
            cmbTypeOfPQ.SelectedIndex = 0
        End Sub

        Private Sub InitializeComponent()
            ' Código para inicializar controles del formulario
        End Sub

        Private Sub btnEnqueue_Click(sender As Object, e As EventArgs) Handles btnEnqueue.Click
            Dim value As Integer
            If Integer.TryParse(txtQueueValue.Text, value) Then
                Dim selectedList As String = cmbQueueType.SelectedItem?.ToString()
                Select Case selectedList
                    Case "Static"
                        staticQueue.Enqueue(value)
                        UpdateQueueDisplay(staticQueue, lstQueues)
                    Case "Dynamic"
                        dynamicQueue.Enqueue(value)
                        UpdateQueueDisplay(dynamicQueue, lstQueues)
                    Case "Circular"
                        circularQueue.Enqueue(value)
                        UpdateQueueDisplay(circularQueue, lstQueues)
                    Case Else
                        MessageBox.Show("Please select a queue type.")
                End Select

                txtQueueValue.Clear()
                txtQueueValue.Focus()
            Else
                MessageBox.Show("Please enter a valid integer value.")
            End If
        End Sub

        Private Function lstQueues() As ListBox
            Throw New NotImplementedException()
        End Function

        Private Sub UpdateQueueDisplay(queue As Object, listBox As ListBox)
            listBox.Items.Clear()

            If TypeOf queue Is StaticQueue Then
                Dim staticQueue As StaticQueue = DirectCast(queue, StaticQueue)
                For Each value In staticQueue.GetQueueElements()
                    listBox.Items.Add(value)
                Next
            ElseIf TypeOf queue Is DynamicQueue Then
                Dim dynamicQueue As DynamicQueue = DirectCast(queue, DynamicQueue)
                For Each value In dynamicQueue.GetQueueElements()
                    listBox.Items.Add(value)
                Next
            ElseIf TypeOf queue Is CircularQueue Then
                Dim circularQueue As CircularQueue = DirectCast(queue, CircularQueue)
                For Each value In circularQueue.GetQueueElements()
                    listBox.Items.Add(value)
                Next
            End If
        End Sub

        Private Sub btnDeleteFront_Click(sender As Object, e As EventArgs) Handles btnDeleteFront.Click
            Dim selectedList As String = cmbDQType.SelectedItem?.ToString()
            Select Case selectedList
                Case "Static"
                    If Not doubleEndedStaticQueue.IsEmpty() Then
                        MessageBox.Show("Deleted: " & doubleEndedStaticQueue.DeleteFront())
                        UpdateDoubleQueueDisplay(doubleEndedStaticQueue)
                    End If
                Case "Dynamic"
                    If Not doubleEndedDynamicQueue.IsEmpty() Then
                        MessageBox.Show("Deleted: " & doubleEndedDynamicQueue.DeleteFront())
                        UpdateDoubleQueueDisplay(doubleEndedDynamicQueue)
                    End If
                Case Else
                    MessageBox.Show("Please select a double queue type.")
            End Select
        End Sub

        Private Sub UpdateDoubleQueueDisplay(queue As Object)
            lstDoubleQueues.Items.Clear()

            If TypeOf queue Is DoubleEndedStaticQueue Then
                Dim staticQueue As DoubleEndedStaticQueue = DirectCast(queue, DoubleEndedStaticQueue)
                For Each value In staticQueue.GetQueueElements()
                    lstDoubleQueues.Items.Add(value)
                Next
            ElseIf TypeOf queue Is DoubleEndedDynamicQueue Then
                Dim dynamicQueue As DoubleEndedDynamicQueue = DirectCast(queue, DoubleEndedDynamicQueue)
                For Each value In dynamicQueue.GetQueueElements()
                    lstDoubleQueues.Items.Add(value)
                Next
            End If
        End Sub
    End Class
End Namespace