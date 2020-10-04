Public Class ContaCorrente
    Public Titular As String = "Não definido"
    Public Agencia As Integer = -1
    Public Conta As Integer = -1
    Public Saldo As Double = 100
    Public Extrato As String = ""

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

End Class
