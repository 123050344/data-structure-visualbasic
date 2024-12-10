<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListsForm
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
        cmbListType = New ComboBox()
        txtValue = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnAdd = New Button()
        btnRemove = New Button()
        btnContains = New Button()
        btnCount = New Button()
        lstSimpleLinkedList = New ListBox()
        SuspendLayout()
        ' 
        ' cmbListType
        ' 
        cmbListType.FormattingEnabled = True
        cmbListType.Items.AddRange(New Object() {"Simple Linked List", "Doubly Linked List", "Circular Linked List", "Doubly Circular Linked List"})
        cmbListType.Location = New Point(322, 60)
        cmbListType.Name = "cmbListType"
        cmbListType.Size = New Size(231, 23)
        cmbListType.TabIndex = 0
        ' 
        ' txtValue
        ' 
        txtValue.Location = New Point(91, 61)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(155, 23)
        txtValue.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(91, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 2
        Label1.Text = "Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(322, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 15)
        Label2.TabIndex = 3
        Label2.Text = "Select type of list:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(91, 123)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(131, 59)
        btnAdd.TabIndex = 4
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(91, 198)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(131, 59)
        btnRemove.TabIndex = 5
        btnRemove.Text = "REMOVE"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnContains
        ' 
        btnContains.Location = New Point(91, 274)
        btnContains.Name = "btnContains"
        btnContains.Size = New Size(131, 59)
        btnContains.TabIndex = 6
        btnContains.Text = "CONTAINS"
        btnContains.UseVisualStyleBackColor = True
        ' 
        ' btnCount
        ' 
        btnCount.Location = New Point(91, 348)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(131, 59)
        btnCount.TabIndex = 7
        btnCount.Text = "COUNT"
        btnCount.UseVisualStyleBackColor = True
        ' 
        ' lstSimpleLinkedList
        ' 
        lstSimpleLinkedList.FormattingEnabled = True
        lstSimpleLinkedList.ItemHeight = 15
        lstSimpleLinkedList.Location = New Point(336, 151)
        lstSimpleLinkedList.Name = "lstSimpleLinkedList"
        lstSimpleLinkedList.Size = New Size(190, 214)
        lstSimpleLinkedList.TabIndex = 8
        ' 
        ' ListsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(lstSimpleLinkedList)
        Controls.Add(btnCount)
        Controls.Add(btnContains)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtValue)
        Controls.Add(cmbListType)
        Name = "ListsForm"
        Text = "ListsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbListType As ComboBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnContains As Button
    Friend WithEvents btnCount As Button
    Friend WithEvents lstSimpleLinkedList As ListBox
End Class
