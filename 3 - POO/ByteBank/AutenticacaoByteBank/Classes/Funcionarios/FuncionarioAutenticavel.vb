Namespace Classes.Funcionarios
    Public MustInherit Class FuncionarioAutenticavel
        Inherits Funcionario
        Implements IAutentica
        Public Property Senha As String

        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub

        Public Function Autenticar(senhaTentativa As String) As Boolean Implements IAutentica.Autenticar

            If senhaTentativa.Length < 5 Then
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