Imports System
Imports System.Linq
Imports System.Windows.Forms

Namespace Data_Structure_Final_Project
    Partial Public Class AlgorithmsForm
        Inherits ZBase

        Private numbers As Integer()
        Private cmbAlgoritms As ComboBox
        Private lstNumbersSort As ListBox
        Private BubbleSort As New BubbleSort()
        Private GnomeSort As New GnomeSort()
        Private CombSort As New CombSort()
        Private CocktailSort As New CocktailSort()
        Private HeapSort As New HeapSort()
        Private InsertionSort As New InsertionSort()
        Private ShellSort As New ShellSort()
        Private SelectionSort As New SelectionSort()
        Private CountingSort As New CountingSort()
        Private BucketSort As New BucketSort()
        Private MergeAlgorithms As New MergeAlgorithms()
        Private QuickSort As New QuickSort()

        Public Sub New()
            Throw New NotImplementedException()
            numbers = New Integer() {}
            cmbAlgoritms.Items.AddRange(New String() {"Gnome Sort", "Heap Sort", "Pigeonhole Sort", "Bubble Sort", "Cocktail Sort", "Insertion Sort", "Shell Sort", "Selection Sort", "Quick Sort", "Merge Sort", "Direct Merge", "Natural Merge", "Comb Sort", "Counting Sort", "Bucket Sort"})
            cmbAlgoritms.SelectedIndex = 0
        End Sub

        Private Sub btnSetNumbers_Click(sender As Object, e As EventArgs)
            Dim random As New Random()
            numbers = Enumerable.Range(0, 10).Select(Function(_i) random.Next(1, 100)).ToArray()
            DisplayNumbers(numbers)
        End Sub

        Private Async Sub btnSort_Click(sender As Object, e As EventArgs)
            If numbers Is Nothing OrElse numbers.Length = 0 Then
                MessageBox.Show("Por favor, genera los números primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim selectedMethod As String = cmbAlgoritms.SelectedItem.ToString()

            Select Case selectedMethod
                Case "Bubble Sort"
                    Await BubbleSort.Sort(numbers, AddressOf DisplayNumbers)
                Case "Gnome Sort"
                    Await GnomeSort.Sort(numbers, AddressOf DisplayNumbers)
                Case "Comb Sort"
                    Await CombSort.Sort(numbers, AddressOf DisplayNumbers)
                Case "Cocktail Sort"
                    Await CocktailSort.Sort(numbers, AddressOf DisplayNumbers)
                Case "Heap Sort"
                    Await HeapSort.Sort(numbers, AddressOf DisplayNumbers)
                Case "Insertion Sort"
                    Await InsertionSort.Sort(numbers, AddressOf DisplayNumbers)
                Case "Shell Sort"
                    Await ShellSort.Sort(numbers, AddressOf DisplayNumbers)
                Case "Selection Sort"
                    Await SelectionSort.Sort(numbers, AddressOf DisplayNumbers)
                Case "Counting Sort"
                    Await CountingSort.Sort(numbers, AddressOf DisplayNumbersMerge)
                Case "Bucket Sort"
                    Await BucketSort.Sort(numbers, AddressOf DisplayNumbersMerge)
                Case "Merge Sort"
                    Await MergeAlgorithms.MergeSort(numbers, 0, numbers.Length - 1, AddressOf DisplayNumbersMerge)
                Case "Natural Merge"
                    Await MergeAlgorithms.NaturalMerge(numbers, AddressOf DisplayNumbersMerge)
                Case "Direct Merge"
                    Await MergeAlgorithms.DirectMerge(numbers, AddressOf DisplayNumbersMerge)
                Case "Quick Sort"
                    Await QuickSort.Sort(numbers, 0, numbers.Length - 1, AddressOf DisplayNumbers)
                Case Else
                    MessageBox.Show("Método de ordenamiento no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
            End Select

            MessageBox.Show("¡Ordenamiento completado!", selectedMethod, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub DisplayNumbers(array As Integer(), Optional currentIndex As Integer = -1, Optional compareIndex As Integer = -1)
            lstNumbersSort.Items.Clear()
            For i As Integer = 0 To array.Length - 1
                Dim itemText As String = array(i).ToString()
                If i = currentIndex OrElse i = compareIndex Then
                    itemText = $"[{itemText}]"
                End If
                lstNumbersSort.Items.Add(itemText)
            Next
        End Sub

        Private Sub DisplayNumbersMerge(array As Integer(), message As String)
            lstNumbersSort.Items.Add(message)
            lstNumbersSort.Items.Add($"[{String.Join(", ", array)}]")
            lstNumbersSort.Items.Add("") ' Línea en blanco para separar pasos
        End Sub
    End Class
End Namespace