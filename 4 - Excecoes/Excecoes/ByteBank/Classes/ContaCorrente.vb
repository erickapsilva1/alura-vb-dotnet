Namespace Classes
    Public Class ContaCorrente

#Region "Propriedades"
        Public Property titular As Cliente

        Public ReadOnly Property Numero As Integer

        Private m_NumeroTransferenciasErradas As Integer
        Public Property NumeroTransferenciasErradas As Integer
            Get
                Return m_NumeroTransferenciasErradas
            End Get
            Private Set(value As Integer)
                m_NumeroTransferenciasErradas = value
            End Set
        End Property


        Private m_NumeroSaquesErrados As Integer
        Public Property NumeroSaquesErrados As Integer
            Get
                Return m_NumeroSaquesErrados
            End Get
            Private Set(value As Integer)
                m_NumeroSaquesErrados = value
            End Set
        End Property


        Private Shared m_TaxaManutencaoCC As Integer
        Public Shared ReadOnly Property TaxaManutencaoCC As Integer
            Get
                Return m_TaxaManutencaoCC
            End Get
        End Property

        Private Shared m_TotalContasCriadas As Integer
        Public Shared ReadOnly Property TotalContasCriadas As Integer
            Get
                Return m_TotalContasCriadas
            End Get
        End Property

        Public ReadOnly Property Agencia As Integer

        Private m_saldo As Double = 100
        Public Property Saldo As Double
            Get
                Return m_saldo
            End Get
            Private Set(value As Double)
                If value <= 0 Then
                    m_saldo = 0
                Else
                    m_saldo = value
                End If
            End Set
        End Property
#End Region

#Region "Construtores"
        Public Sub New(CodigoDaAgencia As Integer, NumeroDaConta As Integer)

            Dim vParametro As String
            If CodigoDaAgencia <= 0 Then
                vParametro = NameOf(CodigoDaAgencia)
                Throw New ArgumentException("Agencia ou Numero não pode ser zero ou inferior.", vParametro)
            ElseIf NumeroDaConta <= 0 Then
                vParametro = NameOf(NumeroDaConta)
                Throw New ArgumentException("Agencia ou Numero não pode ser zero ou inferior.", vParametro)
            End If

            Agencia = CodigoDaAgencia
            Numero = NumeroDaConta
            'm_TaxaManutencaoCC += 30 / TotalContasCriadas
            m_TotalContasCriadas += 1

        End Sub
#End Region

#Region "Métodos"
        Public Sub Sacar(ValorSacar As Double)

            If ValorSacar < 0 Then
                NumeroSaquesErrados += 1
                Throw New ArgumentException("Valor sacado é negativo." + ValorSacar.ToString, NameOf(ValorSacar))
            End If

            If m_saldo >= ValorSacar Then
                m_saldo -= ValorSacar
            Else
                NumeroSaquesErrados += 1
                Throw New ValorSacadoMenorSaldoException(ValorSacar, Saldo, "Valor sacado maior do que o saldo da conta")
            End If
        End Sub

        Public Sub Depositar(ValorDepositar As Double)
            m_saldo += ValorDepositar
        End Sub

        Public Sub Transferir(ValorTransferencia As Double, ContaDestino As ContaCorrente)

            Try
                Sacar(ValorTransferencia)

            Catch ex As ValorSacadoMenorSaldoException
                m_NumeroTransferenciasErradas += 1
                Throw New OperacaoFinanceiraException("Operação inválida", ex)

            Catch ex As ArgumentException
                m_NumeroTransferenciasErradas += 1
                Throw

            End Try

            ContaDestino.Depositar(ValorTransferencia)

        End Sub

#End Region

    End Class
End Namespace
