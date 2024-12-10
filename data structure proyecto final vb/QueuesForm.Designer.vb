<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueuesForm
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label2 = New Label()
        Label1 = New Label()
        lstQueues = New ListBox()
        btnQueueSize = New Button()
        btnQueuePeek = New Button()
        btnDequeue = New Button()
        btnEnqueue = New Button()
        cmbQueueType = New ComboBox()
        txtQueueValue = New TextBox()
        TabPage2 = New TabPage()
        Label4 = New Label()
        Label3 = New Label()
        lstDoubleQueues = New ListBox()
        txtDQValue = New TextBox()
        btnDeleteRear = New Button()
        btnDoubleQSize = New Button()
        btnGetRear = New Button()
        btnGetFront = New Button()
        Button7 = New Button()
        btnDeleteFront = New Button()
        btnInsertRear = New Button()
        cmbDQType = New ComboBox()
        TabPage3 = New TabPage()
        cmbTypeOfPQ = New ComboBox()
        txtValuePQ = New TextBox()
        txtPriority = New TextBox()
        btnEnqueuePQ = New Button()
        btnPeekPQ = New Button()
        btnDequeuePQ = New Button()
        btnSizePQ = New Button()
        lstPQ = New ListBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 435)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(lstQueues)
        TabPage1.Controls.Add(btnQueueSize)
        TabPage1.Controls.Add(btnQueuePeek)
        TabPage1.Controls.Add(btnDequeue)
        TabPage1.Controls.Add(btnEnqueue)
        TabPage1.Controls.Add(cmbQueueType)
        TabPage1.Controls.Add(txtQueueValue)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 407)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Queues"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(333, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 15)
        Label2.TabIndex = 8
        Label2.Text = "Selecciona un tipo de cola"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(106, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 7
        Label1.Text = "Number"
        ' 
        ' lstQueues
        ' 
        lstQueues.FormattingEnabled = True
        lstQueues.ItemHeight = 15
        lstQueues.Location = New Point(280, 194)
        lstQueues.Name = "lstQueues"
        lstQueues.Size = New Size(212, 184)
        lstQueues.TabIndex = 6
        ' 
        ' btnQueueSize
        ' 
        btnQueueSize.Location = New Point(584, 120)
        btnQueueSize.Name = "btnQueueSize"
        btnQueueSize.Size = New Size(121, 50)
        btnQueueSize.TabIndex = 5
        btnQueueSize.Text = "Size"
        btnQueueSize.UseVisualStyleBackColor = True
        ' 
        ' btnQueuePeek
        ' 
        btnQueuePeek.Location = New Point(407, 120)
        btnQueuePeek.Name = "btnQueuePeek"
        btnQueuePeek.Size = New Size(121, 50)
        btnQueuePeek.TabIndex = 4
        btnQueuePeek.Text = "Peek"
        btnQueuePeek.UseVisualStyleBackColor = True
        ' 
        ' btnDequeue
        ' 
        btnDequeue.Location = New Point(229, 120)
        btnDequeue.Name = "btnDequeue"
        btnDequeue.Size = New Size(121, 50)
        btnDequeue.TabIndex = 3
        btnDequeue.Text = "Dequeue"
        btnDequeue.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueue
        ' 
        btnEnqueue.Location = New Point(51, 120)
        btnEnqueue.Name = "btnEnqueue"
        btnEnqueue.Size = New Size(121, 50)
        btnEnqueue.TabIndex = 2
        btnEnqueue.Text = "Enqueue"
        btnEnqueue.UseVisualStyleBackColor = True
        ' 
        ' cmbQueueType
        ' 
        cmbQueueType.FormattingEnabled = True
        cmbQueueType.Location = New Point(333, 55)
        cmbQueueType.Name = "cmbQueueType"
        cmbQueueType.Size = New Size(233, 23)
        cmbQueueType.TabIndex = 1
        ' 
        ' txtQueueValue
        ' 
        txtQueueValue.Location = New Point(106, 55)
        txtQueueValue.Name = "txtQueueValue"
        txtQueueValue.Size = New Size(141, 23)
        txtQueueValue.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(lstDoubleQueues)
        TabPage2.Controls.Add(txtDQValue)
        TabPage2.Controls.Add(btnDeleteRear)
        TabPage2.Controls.Add(btnDoubleQSize)
        TabPage2.Controls.Add(btnGetRear)
        TabPage2.Controls.Add(btnGetFront)
        TabPage2.Controls.Add(Button7)
        TabPage2.Controls.Add(btnDeleteFront)
        TabPage2.Controls.Add(btnInsertRear)
        TabPage2.Controls.Add(cmbDQType)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 407)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Double Queues"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(369, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 15)
        Label4.TabIndex = 11
        Label4.Text = "Selecciona un tipo de cola doble"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(141, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 10
        Label3.Text = "Number"
        ' 
        ' lstDoubleQueues
        ' 
        lstDoubleQueues.FormattingEnabled = True
        lstDoubleQueues.ItemHeight = 15
        lstDoubleQueues.Location = New Point(255, 247)
        lstDoubleQueues.Name = "lstDoubleQueues"
        lstDoubleQueues.Size = New Size(232, 154)
        lstDoubleQueues.TabIndex = 9
        ' 
        ' txtDQValue
        ' 
        txtDQValue.Location = New Point(141, 42)
        txtDQValue.Name = "txtDQValue"
        txtDQValue.Size = New Size(157, 23)
        txtDQValue.TabIndex = 8
        ' 
        ' btnDeleteRear
        ' 
        btnDeleteRear.Location = New Point(557, 101)
        btnDeleteRear.Name = "btnDeleteRear"
        btnDeleteRear.Size = New Size(121, 47)
        btnDeleteRear.TabIndex = 7
        btnDeleteRear.Text = "Delete"
        btnDeleteRear.UseVisualStyleBackColor = True
        ' 
        ' btnDoubleQSize
        ' 
        btnDoubleQSize.Location = New Point(481, 175)
        btnDoubleQSize.Name = "btnDoubleQSize"
        btnDoubleQSize.Size = New Size(121, 47)
        btnDoubleQSize.TabIndex = 6
        btnDoubleQSize.Text = "Size"
        btnDoubleQSize.UseVisualStyleBackColor = True
        ' 
        ' btnGetRear
        ' 
        btnGetRear.Location = New Point(317, 175)
        btnGetRear.Name = "btnGetRear"
        btnGetRear.Size = New Size(121, 47)
        btnGetRear.TabIndex = 5
        btnGetRear.Text = "Get"
        btnGetRear.UseVisualStyleBackColor = True
        ' 
        ' btnGetFront
        ' 
        btnGetFront.Location = New Point(153, 175)
        btnGetFront.Name = "btnGetFront"
        btnGetFront.Size = New Size(121, 47)
        btnGetFront.TabIndex = 4
        btnGetFront.Text = "Get Front"
        btnGetFront.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(236, 101)
        Button7.Name = "Button7"
        Button7.Size = New Size(121, 47)
        Button7.TabIndex = 3
        Button7.Text = "Button7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteFront
        ' 
        btnDeleteFront.Location = New Point(393, 101)
        btnDeleteFront.Name = "btnDeleteFront"
        btnDeleteFront.Size = New Size(121, 47)
        btnDeleteFront.TabIndex = 2
        btnDeleteFront.Text = "Delete Front"
        btnDeleteFront.UseVisualStyleBackColor = True
        ' 
        ' btnInsertRear
        ' 
        btnInsertRear.Location = New Point(70, 101)
        btnInsertRear.Name = "btnInsertRear"
        btnInsertRear.Size = New Size(121, 47)
        btnInsertRear.TabIndex = 1
        btnInsertRear.Text = "insert"
        btnInsertRear.UseVisualStyleBackColor = True
        ' 
        ' cmbDQType
        ' 
        cmbDQType.FormattingEnabled = True
        cmbDQType.Location = New Point(369, 42)
        cmbDQType.Name = "cmbDQType"
        cmbDQType.Size = New Size(179, 23)
        cmbDQType.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Label7)
        TabPage3.Controls.Add(Label6)
        TabPage3.Controls.Add(Label5)
        TabPage3.Controls.Add(lstPQ)
        TabPage3.Controls.Add(btnSizePQ)
        TabPage3.Controls.Add(btnDequeuePQ)
        TabPage3.Controls.Add(btnPeekPQ)
        TabPage3.Controls.Add(btnEnqueuePQ)
        TabPage3.Controls.Add(txtPriority)
        TabPage3.Controls.Add(txtValuePQ)
        TabPage3.Controls.Add(cmbTypeOfPQ)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(768, 407)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Priority Queues"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' cmbTypeOfPQ
        ' 
        cmbTypeOfPQ.FormattingEnabled = True
        cmbTypeOfPQ.Location = New Point(277, 116)
        cmbTypeOfPQ.Name = "cmbTypeOfPQ"
        cmbTypeOfPQ.Size = New Size(173, 23)
        cmbTypeOfPQ.TabIndex = 0
        ' 
        ' txtValuePQ
        ' 
        txtValuePQ.Location = New Point(138, 40)
        txtValuePQ.Name = "txtValuePQ"
        txtValuePQ.Size = New Size(183, 23)
        txtValuePQ.TabIndex = 1
        ' 
        ' txtPriority
        ' 
        txtPriority.Location = New Point(416, 40)
        txtPriority.Name = "txtPriority"
        txtPriority.Size = New Size(183, 23)
        txtPriority.TabIndex = 2
        ' 
        ' btnEnqueuePQ
        ' 
        btnEnqueuePQ.Location = New Point(66, 163)
        btnEnqueuePQ.Name = "btnEnqueuePQ"
        btnEnqueuePQ.Size = New Size(129, 45)
        btnEnqueuePQ.TabIndex = 3
        btnEnqueuePQ.Text = "Enqueue"
        btnEnqueuePQ.UseVisualStyleBackColor = True
        ' 
        ' btnPeekPQ
        ' 
        btnPeekPQ.Location = New Point(405, 163)
        btnPeekPQ.Name = "btnPeekPQ"
        btnPeekPQ.Size = New Size(129, 45)
        btnPeekPQ.TabIndex = 4
        btnPeekPQ.Text = "Peek"
        btnPeekPQ.UseVisualStyleBackColor = True
        ' 
        ' btnDequeuePQ
        ' 
        btnDequeuePQ.Location = New Point(237, 163)
        btnDequeuePQ.Name = "btnDequeuePQ"
        btnDequeuePQ.Size = New Size(129, 45)
        btnDequeuePQ.TabIndex = 5
        btnDequeuePQ.Text = "Dequeue"
        btnDequeuePQ.UseVisualStyleBackColor = True
        ' 
        ' btnSizePQ
        ' 
        btnSizePQ.Location = New Point(578, 163)
        btnSizePQ.Name = "btnSizePQ"
        btnSizePQ.Size = New Size(129, 45)
        btnSizePQ.TabIndex = 6
        btnSizePQ.Text = "Size"
        btnSizePQ.UseVisualStyleBackColor = True
        ' 
        ' lstPQ
        ' 
        lstPQ.FormattingEnabled = True
        lstPQ.ItemHeight = 15
        lstPQ.Location = New Point(277, 225)
        lstPQ.Name = "lstPQ"
        lstPQ.Size = New Size(173, 169)
        lstPQ.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(138, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 15)
        Label5.TabIndex = 8
        Label5.Text = "Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(416, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 9
        Label6.Text = "Priority"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(265, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(196, 15)
        Label7.TabIndex = 10
        Label7.Text = "Selecciona un tipo de cola prioridad"
        ' 
        ' QueuesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "QueuesForm"
        Text = "QueuesForm"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstQueues As ListBox
    Friend WithEvents btnQueueSize As Button
    Friend WithEvents btnQueuePeek As Button
    Friend WithEvents btnDequeue As Button
    Friend WithEvents btnEnqueue As Button
    Friend WithEvents cmbQueueType As ComboBox
    Friend WithEvents txtQueueValue As TextBox
    Friend WithEvents txtDQValue As TextBox
    Friend WithEvents btnDeleteRear As Button
    Friend WithEvents btnDoubleQSize As Button
    Friend WithEvents btnGetRear As Button
    Friend WithEvents btnGetFront As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnDeleteFront As Button
    Friend WithEvents btnInsertRear As Button
    Friend WithEvents cmbDQType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstDoubleQueues As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstPQ As ListBox
    Friend WithEvents btnSizePQ As Button
    Friend WithEvents btnDequeuePQ As Button
    Friend WithEvents btnPeekPQ As Button
    Friend WithEvents btnEnqueuePQ As Button
    Friend WithEvents txtPriority As TextBox
    Friend WithEvents txtValuePQ As TextBox
    Friend WithEvents cmbTypeOfPQ As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
