Imports System.Security.Cryptography.Xm

Public Class Form1
    Inherits ZBase

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub lBoxOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lBoxOptions.SelectedIndexChanged
        Select Case lBoxOptions.SelectedIndex
            Case 0
                Dim listsForm As New ListsForm()
                listsForm.Show()
                Me.Hide()
            Case 1
                Dim stacksForm As New StacksForm()
                stacksForm.Show()
                Me.Hide()
            Case 2
                Dim queuesForm As New QueuesForm()
                queuesForm.Show()
                Me.Hide()
            Case 3
                Dim treesForm As New TreesForm()
                treesForm.Show()
                Me.Hide()
            Case 4
                Dim graphsForm As New GraphsForm()
                graphsForm.Show()
                Me.Hide()
            Case 5
                Dim algorithmsForm As New AlgorithmsForm()
                algorithmsForm.Show()
                Me.Hide()
        End Select
    End Sub
End Class

