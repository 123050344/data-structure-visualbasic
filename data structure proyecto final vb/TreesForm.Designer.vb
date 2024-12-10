<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreesForm
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
        panelTree = New Panel()
        txtNodeValue = New TextBox()
        btnInsertNode = New Button()
        btnDelete = New Button()
        btnPreOrder = New Button()
        btnPostOrder = New Button()
        btnInOrder = New Button()
        btnSearch = New Button()
        btnClear = New Button()
        txtOutput = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' panelTree
        ' 
        panelTree.Location = New Point(78, 233)
        panelTree.Name = "panelTree"
        panelTree.Size = New Size(642, 195)
        panelTree.TabIndex = 0
        ' 
        ' txtNodeValue
        ' 
        txtNodeValue.Location = New Point(78, 42)
        txtNodeValue.Name = "txtNodeValue"
        txtNodeValue.Size = New Size(216, 23)
        txtNodeValue.TabIndex = 1
        ' 
        ' btnInsertNode
        ' 
        btnInsertNode.Location = New Point(327, 12)
        btnInsertNode.Name = "btnInsertNode"
        btnInsertNode.Size = New Size(115, 53)
        btnInsertNode.TabIndex = 2
        btnInsertNode.Text = "insert"
        btnInsertNode.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(468, 12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(115, 53)
        btnDelete.TabIndex = 3
        btnDelete.Text = "delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnPreOrder
        ' 
        btnPreOrder.Location = New Point(78, 99)
        btnPreOrder.Name = "btnPreOrder"
        btnPreOrder.Size = New Size(115, 53)
        btnPreOrder.TabIndex = 4
        btnPreOrder.Text = "PreOrder"
        btnPreOrder.UseVisualStyleBackColor = True
        ' 
        ' btnPostOrder
        ' 
        btnPostOrder.Location = New Point(381, 99)
        btnPostOrder.Name = "btnPostOrder"
        btnPostOrder.Size = New Size(115, 53)
        btnPostOrder.TabIndex = 5
        btnPostOrder.Text = "PostOrder"
        btnPostOrder.UseVisualStyleBackColor = True
        ' 
        ' btnInOrder
        ' 
        btnInOrder.Location = New Point(232, 99)
        btnInOrder.Name = "btnInOrder"
        btnInOrder.Size = New Size(115, 53)
        btnInOrder.TabIndex = 6
        btnInOrder.Text = "InOrder"
        btnInOrder.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(605, 12)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(115, 53)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(529, 99)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(115, 53)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(78, 182)
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(364, 23)
        txtOutput.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(78, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 10
        Label1.Text = "Node value"
        ' 
        ' TreesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtOutput)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(btnInOrder)
        Controls.Add(btnPostOrder)
        Controls.Add(btnPreOrder)
        Controls.Add(btnDelete)
        Controls.Add(btnInsertNode)
        Controls.Add(txtNodeValue)
        Controls.Add(panelTree)
        Name = "TreesForm"
        Text = "TreesForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panelTree As Panel
    Friend WithEvents txtNodeValue As TextBox
    Friend WithEvents btnInsertNode As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPreOrder As Button
    Friend WithEvents btnPostOrder As Button
    Friend WithEvents btnInOrder As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label1 As Label
End Class
