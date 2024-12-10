Imports System
Imports System.Windows.Forms

Namespace Data_Structure_Final_Project
    Public Class ZBase
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ' Aquí va la lógica común, como eventos, métodos, etc.
        End Sub

        Private Sub InitializeComponent()
            Throw New NotImplementedException()
        End Sub

        Protected Sub AnyFormClosed(sender As Object, e As FormClosedEventArgs)
            If TypeOf sender Is Form Then
                Dim form As Form = CType(sender, Form)
                If Not (TypeOf form Is Form1) Then
                    Dim mainForm As Form1 = TryCast(Application.OpenForms("Form1"), Form1)
                    If mainForm IsNot Nothing Then
                        mainForm.Show()
                    End If
                End If
            End If
        End Sub
    End Class
End Namespace