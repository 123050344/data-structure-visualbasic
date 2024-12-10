<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphsForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNode = New TextBox()
        btnAddNode = New Button()
        btnRemoveNode = New Button()
        txtWeight = New TextBox()
        txtTo = New TextBox()
        txtFrom = New TextBox()
        btnAddEdge = New Button()
        btnRemoveEdge = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtStartNode = New TextBox()
        btnShowDFSRecursive = New Button()
        btnShowDFS = New Button()
        btnShowBFS = New Button()
        Label8 = New Label()
        btnRemoveAll = New Button()
        txtGraphRepresentation = New TextBox()
        chkDirected = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(184, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "nodes"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 1
        Label2.Text = "node name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(184, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 2
        Label3.Text = "edges"
        ' 
        ' txtNode
        ' 
        txtNode.Location = New Point(115, 76)
        txtNode.Name = "txtNode"
        txtNode.Size = New Size(185, 23)
        txtNode.TabIndex = 3
        ' 
        ' btnAddNode
        ' 
        btnAddNode.Location = New Point(50, 118)
        btnAddNode.Name = "btnAddNode"
        btnAddNode.Size = New Size(110, 29)
        btnAddNode.TabIndex = 4
        btnAddNode.Text = "Add Node"
        btnAddNode.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveNode
        ' 
        btnRemoveNode.Location = New Point(239, 118)
        btnRemoveNode.Name = "btnRemoveNode"
        btnRemoveNode.Size = New Size(110, 29)
        btnRemoveNode.TabIndex = 5
        btnRemoveNode.Text = "Remove Node"
        btnRemoveNode.UseVisualStyleBackColor = True
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(115, 280)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(185, 23)
        txtWeight.TabIndex = 6
        ' 
        ' txtTo
        ' 
        txtTo.Location = New Point(115, 251)
        txtTo.Name = "txtTo"
        txtTo.Size = New Size(185, 23)
        txtTo.TabIndex = 7
        ' 
        ' txtFrom
        ' 
        txtFrom.Location = New Point(115, 222)
        txtFrom.Name = "txtFrom"
        txtFrom.Size = New Size(185, 23)
        txtFrom.TabIndex = 8
        ' 
        ' btnAddEdge
        ' 
        btnAddEdge.Location = New Point(320, 230)
        btnAddEdge.Name = "btnAddEdge"
        btnAddEdge.Size = New Size(110, 29)
        btnAddEdge.TabIndex = 9
        btnAddEdge.Text = "Add Edge"
        btnAddEdge.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveEdge
        ' 
        btnRemoveEdge.Location = New Point(320, 265)
        btnRemoveEdge.Name = "btnRemoveEdge"
        btnRemoveEdge.Size = New Size(110, 29)
        btnRemoveEdge.TabIndex = 10
        btnRemoveEdge.Text = "Remove Edge"
        btnRemoveEdge.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 283)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 11
        Label4.Text = "weight"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(60, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 15)
        Label5.TabIndex = 12
        Label5.Text = "node to"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(50, 225)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 15)
        Label6.TabIndex = 13
        Label6.Text = "node from"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(184, 353)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 15)
        Label7.TabIndex = 14
        Label7.Text = "Traversals"
        ' 
        ' txtStartNode
        ' 
        txtStartNode.Location = New Point(115, 371)
        txtStartNode.Name = "txtStartNode"
        txtStartNode.Size = New Size(185, 23)
        txtStartNode.TabIndex = 15
        ' 
        ' btnShowDFSRecursive
        ' 
        btnShowDFSRecursive.Location = New Point(263, 403)
        btnShowDFSRecursive.Name = "btnShowDFSRecursive"
        btnShowDFSRecursive.Size = New Size(110, 41)
        btnShowDFSRecursive.TabIndex = 16
        btnShowDFSRecursive.Text = "Show DFS Recursive"
        btnShowDFSRecursive.UseVisualStyleBackColor = True
        ' 
        ' btnShowDFS
        ' 
        btnShowDFS.Location = New Point(147, 409)
        btnShowDFS.Name = "btnShowDFS"
        btnShowDFS.Size = New Size(110, 29)
        btnShowDFS.TabIndex = 17
        btnShowDFS.Text = "Show DFS"
        btnShowDFS.UseVisualStyleBackColor = True
        ' 
        ' btnShowBFS
        ' 
        btnShowBFS.Location = New Point(31, 409)
        btnShowBFS.Name = "btnShowBFS"
        btnShowBFS.Size = New Size(110, 29)
        btnShowBFS.TabIndex = 18
        btnShowBFS.Text = "Show BFS"
        btnShowBFS.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(53, 374)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 15)
        Label8.TabIndex = 19
        Label8.Text = "node start"
        ' 
        ' btnRemoveAll
        ' 
        btnRemoveAll.Location = New Point(444, 70)
        btnRemoveAll.Name = "btnRemoveAll"
        btnRemoveAll.Size = New Size(110, 29)
        btnRemoveAll.TabIndex = 20
        btnRemoveAll.Text = "Remove All"
        btnRemoveAll.UseVisualStyleBackColor = True
        ' 
        ' txtGraphRepresentation
        ' 
        txtGraphRepresentation.Location = New Point(475, 118)
        txtGraphRepresentation.Multiline = True
        txtGraphRepresentation.Name = "txtGraphRepresentation"
        txtGraphRepresentation.Size = New Size(275, 294)
        txtGraphRepresentation.TabIndex = 21
        ' 
        ' chkDirected
        ' 
        chkDirected.AutoSize = True
        chkDirected.Location = New Point(156, 309)
        chkDirected.Name = "chkDirected"
        chkDirected.Size = New Size(70, 19)
        chkDirected.TabIndex = 22
        chkDirected.Text = "Directed"
        chkDirected.UseVisualStyleBackColor = True
        ' 
        ' GraphsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(chkDirected)
        Controls.Add(txtGraphRepresentation)
        Controls.Add(btnRemoveAll)
        Controls.Add(Label8)
        Controls.Add(btnShowBFS)
        Controls.Add(btnShowDFS)
        Controls.Add(btnShowDFSRecursive)
        Controls.Add(txtStartNode)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnRemoveEdge)
        Controls.Add(btnAddEdge)
        Controls.Add(txtFrom)
        Controls.Add(txtTo)
        Controls.Add(txtWeight)
        Controls.Add(btnRemoveNode)
        Controls.Add(btnAddNode)
        Controls.Add(txtNode)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "GraphsForm"
        Text = "GraphsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNode As TextBox
    Friend WithEvents btnAddNode As Button
    Friend WithEvents btnRemoveNode As Button
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents btnAddEdge As Button
    Friend WithEvents btnRemoveEdge As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStartNode As TextBox
    Friend WithEvents btnShowDFSRecursive As Button
    Friend WithEvents btnShowDFS As Button
    Friend WithEvents btnShowBFS As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnRemoveAll As Button
    Friend WithEvents txtGraphRepresentation As TextBox
    Friend WithEvents chkDirected As CheckBox
End Class
