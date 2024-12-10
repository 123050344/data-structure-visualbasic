<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        lBoxOptions = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(265, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 45)
        Label1.TabIndex = 0
        Label1.Text = "PROYECTO FINAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(285, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(233, 30)
        Label2.TabIndex = 1
        Label2.Text = "Selecciona una opcion"
        ' 
        ' lBoxOptions
        ' 
        lBoxOptions.FormattingEnabled = True
        lBoxOptions.ItemHeight = 15
        lBoxOptions.Items.AddRange(New Object() {"Lista", "pila", "cola", "Arbol binario", "Grafo", "Algoritmos"})
        lBoxOptions.Location = New Point(330, 153)
        lBoxOptions.Name = "lBoxOptions"
        lBoxOptions.Size = New Size(129, 109)
        lBoxOptions.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(lBoxOptions)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lBoxOptions As ListBox

End Class
