<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StacksForm
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
        txtStackValue = New TextBox()
        Label1 = New Label()
        cmbStackType = New ComboBox()
        lstStaticStack = New ListBox()
        btnPush = New Button()
        btnPeek = New Button()
        btnPop = New Button()
        Size = New Button()
        SuspendLayout()
        ' 
        ' txtStackValue
        ' 
        txtStackValue.Location = New Point(222, 46)
        txtStackValue.Name = "txtStackValue"
        txtStackValue.Size = New Size(150, 23)
        txtStackValue.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(162, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 1
        Label1.Text = "Number:"
        ' 
        ' cmbStackType
        ' 
        cmbStackType.FormattingEnabled = True
        cmbStackType.Location = New Point(425, 46)
        cmbStackType.Name = "cmbStackType"
        cmbStackType.Size = New Size(187, 23)
        cmbStackType.TabIndex = 2
        ' 
        ' lstStaticStack
        ' 
        lstStaticStack.FormattingEnabled = True
        lstStaticStack.ItemHeight = 15
        lstStaticStack.Location = New Point(297, 213)
        lstStaticStack.Name = "lstStaticStack"
        lstStaticStack.Size = New Size(178, 199)
        lstStaticStack.TabIndex = 3
        ' 
        ' btnPush
        ' 
        btnPush.Location = New Point(87, 107)
        btnPush.Name = "btnPush"
        btnPush.Size = New Size(118, 55)
        btnPush.TabIndex = 4
        btnPush.Text = "Push"
        btnPush.UseVisualStyleBackColor = True
        ' 
        ' btnPeek
        ' 
        btnPeek.Location = New Point(403, 107)
        btnPeek.Name = "btnPeek"
        btnPeek.Size = New Size(118, 55)
        btnPeek.TabIndex = 5
        btnPeek.Text = "Peek"
        btnPeek.UseVisualStyleBackColor = True
        ' 
        ' btnPop
        ' 
        btnPop.Location = New Point(249, 107)
        btnPop.Name = "btnPop"
        btnPop.Size = New Size(118, 55)
        btnPop.TabIndex = 6
        btnPop.Text = "Pop"
        btnPop.UseVisualStyleBackColor = True
        ' 
        ' Size
        ' 
        Size.Location = New Point(557, 107)
        Size.Name = "Size"
        Size.Size = New Size(118, 55)
        Size.TabIndex = 7
        Size.Text = "btnSize"
        Size.UseVisualStyleBackColor = True
        ' 
        ' StacksForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(Size)
        Controls.Add(btnPop)
        Controls.Add(btnPeek)
        Controls.Add(btnPush)
        Controls.Add(lstStaticStack)
        Controls.Add(cmbStackType)
        Controls.Add(Label1)
        Controls.Add(txtStackValue)
        Name = "StacksForm"
        Text = "StacksForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtStackValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStackType As ComboBox
    Friend WithEvents lstStaticStack As ListBox
    Friend WithEvents btnPush As Button
    Friend WithEvents btnPeek As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents Size As Button
End Class
