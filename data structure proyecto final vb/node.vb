Namespace data_structure_proyecto_final_vb
    Friend Class node
        Public Property Value As Integer
        Public Property [Next] As node

        Public Sub New()
            Value = 0
            [Next] = Nothing
        End Sub

        Public Sub New(value As Integer)
            Me.Value = value
            [Next] = Nothing
        End Sub
    End Class
End Namespace
