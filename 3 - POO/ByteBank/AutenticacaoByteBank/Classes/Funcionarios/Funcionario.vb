Namespace Classes.Funcionarios

    Public MustInherit Class Funcionario
        Public Property Nome As String

        Private m_Salario As Double
        Public Property Salario As String
            Get
                Return m_Salario
            End Get
            Protected Set(value As String)
                m_Salario = value
            End Set
        End Property

        Private ReadOnly m_Cpf As String
        Public ReadOnly Property Cpf As String
            Get
                Return m_Cpf
            End Get
        End Property

        Private Shared m_TotalDeFuncionarios As Integer
        Public Shared ReadOnly Property TotalDeFuncionarios() As Integer
            Get
                Return m_TotalDeFuncionarios
            End Get
        End Property

        Public Sub New(_cpf As String, _salario As Double)
            m_TotalDeFuncionarios += 1
            m_Cpf = _cpf
            m_Salario = _salario
        End Sub

        Public MustOverride Function GetBonificacao() As Double

        Public MustOverride Sub AumentarSalario()

    End Class

End Namespace
