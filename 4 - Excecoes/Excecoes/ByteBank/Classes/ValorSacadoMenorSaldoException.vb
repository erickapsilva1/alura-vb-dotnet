Namespace Classes

    Public Class ValorSacadoMenorSaldoException
        Inherits OperacaoFinanceiraException

        Public ReadOnly Property ValorSacado As Double
        Public ReadOnly Property Saldo As Double

        Sub New()

        End Sub
        Sub New(Mensagem As String)
            MyBase.New(Mensagem)
        End Sub

        Sub New(Message As String, InnerException As Exception)
            MyBase.New(Message, InnerException)
        End Sub

        Sub New(_ValorSacado As Double, _Saldo As Double)
            ValorSacado = _ValorSacado
            Saldo = _Saldo
        End Sub
        Sub New(_ValorSacado As Double, _Saldo As Double, _Message As String)
            Me.New(_Message)
            ValorSacado = _ValorSacado
            Saldo = _Saldo
        End Sub

    End Class
End Namespace
