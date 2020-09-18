Imports _2___ByteBank.ByteBank
Public Class ContaCorrente

#Region "Propriedades"

    Private m_Titular As Cliente
    Public Property Titular As Cliente
        Get
            Return m_Titular
        End Get
        Set(value As Cliente)
            m_Titular = value
        End Set
    End Property

    Private m_Saldo As Double
    Public Property Saldo As Double
        Get
            Return m_Saldo
        End Get
        Set(SaldoInicial As Double)
            If SaldoInicial >= 0 Then
                m_Saldo = SaldoInicial
            Else
                m_Saldo = 0
            End If
        End Set
    End Property

    Public Property Agencia As Integer

    Private m_Conta As Integer
    Public Property Conta As Integer
        Get
            Return m_Conta
        End Get
        Set(value As Integer)
            m_Conta = value
        End Set
    End Property

    Public m_Extrato As String
    Public Property Extrato As String
        Get
            Return m_Extrato
        End Get
        Set(value As String)
            m_Extrato = value
        End Set
    End Property

#End Region

#Region "Métodos"
    Public Function Sacar(ValorSacar As Double) As Boolean
        If Saldo >= ValorSacar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Depositar(ValorDepositar As Double)
        Saldo += ValorDepositar
    End Sub

    Public Function Transferir(ValorTransferir As Double, ByRef ContaDestino As ContaCorrente) As Boolean
        If Sacar(ValorTransferir) Then
            Saldo -= ValorTransferir
            ContaDestino.Depositar(ValorTransferir)
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class
