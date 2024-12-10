<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlgorithmsForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cmbAlgoritms = New ComboBox()
        btnSetNumbers = New Button()
        btnSort = New Button()
        lstNumbersSort = New ListBox()
        SuspendLayout()
        ' 
        ' cmbAlgoritms
        ' 
        cmbAlgoritms.FormattingEnabled = True
        cmbAlgoritms.Location = New Point(58, 66)
        cmbAlgoritms.Name = "cmbAlgoritms"
        cmbAlgoritms.Size = New Size(236, 23)
        cmbAlgoritms.TabIndex = 0
        ' 
        ' btnSetNumbers
        ' 
        btnSetNumbers.Location = New Point(344, 45)
        btnSetNumbers.Name = "btnSetNumbers"
        btnSetNumbers.Size = New Size(168, 63)
        btnSetNumbers.TabIndex = 1
        btnSetNumbers.Text = "Generate number"
        btnSetNumbers.UseVisualStyleBackColor = True
        ' 
        ' btnSort
        ' 
        btnSort.Location = New Point(543, 45)
        btnSort.Name = "btnSort"
        btnSort.Size = New Size(168, 63)
        btnSort.TabIndex = 2
        btnSort.Text = "Sort"
        btnSort.UseVisualStyleBackColor = True
        ' 
        ' lstNumbersSort
        ' 
        lstNumbersSort.FormattingEnabled = True
        lstNumbersSort.ItemHeight = 15
        lstNumbersSort.Location = New Point(58, 149)
        lstNumbersSort.Name = "lstNumbersSort"
        lstNumbersSort.Size = New Size(343, 244)
        lstNumbersSort.TabIndex = 3
        ' 
        ' AlgorithmsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstNumbersSort)
        Controls.Add(btnSort)
        Controls.Add(btnSetNumbers)
        Controls.Add(cmbAlgoritms)
        Name = "AlgorithmsForm"
        Text = "AlgorithmsForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbAlgoritms As ComboBox
    Friend WithEvents btnSetNumbers As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents lstNumbersSort As ListBox
End Class
