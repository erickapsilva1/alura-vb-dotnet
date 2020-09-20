Namespace Classes.Externos
    Public Class Representante
        Implements IAutentica
        Public Property Senha As String
        Public Function Autenticar(senhaTentativa As String) As Boolean Implements IAutentica.Autenticar

            If senhaTentativa.Length < 10 Then
                Return False
            End If

            If Senha = senhaTentativa Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
End Namespace