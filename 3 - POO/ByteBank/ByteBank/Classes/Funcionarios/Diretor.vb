Namespace Classes.Funcionarios
    Public Class Diretor
        Inherits Funcionario

        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub

        Public Overrides Function GetBonificacao() As Double
            Return (Salario * 0.5)
        End Function

        Public Overrides Sub AumentarSalario()
            Salario *= 1.15
        End Sub
    End Class
End Namespace
