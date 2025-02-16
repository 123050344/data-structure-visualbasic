﻿Namespace data_structure_proyecto_final_vbata_Structure_Final_Project
    Friend Class DoublyNode
        Public Property Value As Integer
        Public Property [Next] As DoublyNode
        Public Property Prev As DoublyNode

        ' Constructor por defecto
        Public Sub New()
            Value = 0
            [Next] = Nothing
            Prev = Nothing
        End Sub

        ' Constructor con valor
        Public Sub New(value As Integer)
            Me.Value = value
            [Next] = Nothing
            Prev = Nothing
        End Sub
    End Class
End Namespace