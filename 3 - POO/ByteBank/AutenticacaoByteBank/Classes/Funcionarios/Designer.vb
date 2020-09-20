Namespace Classes.Funcionarios
    Public Class Designer
        Inherits Funcionario

        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub

        Public Overrides Function GetBonificacao() As Double
            Return (Salario * 0.17)
        End Function

        Public Overrides Sub AumentarSalario()
            Salario *= 1.11
        End Sub
    End Class
End Namespace
