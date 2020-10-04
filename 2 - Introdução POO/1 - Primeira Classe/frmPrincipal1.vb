Public Class FrmPrincipal1
    Private Sub BtnAcao_Click(sender As Object, e As EventArgs) Handles btnAcao.Click
        Dim saldo = Val(TxtSaldo.Text)
        Dim incremento = Val(TxtIncremento.Text)
        Dim cc As New ContaCorrente With {
            .Titular = "Annie",
            .Conta = 31415,
            .Agencia = 870,
            .Saldo = saldo
        }
        MsgBox("Titular: " + cc.Titular + vbCrLf _
               + "Conta: " + cc.Conta.ToString + vbCrLf _
               + "Agencia: " + cc.Agencia.ToString + vbCrLf _
               + "Saldo: " + cc.Saldo.ToString)
        cc.Saldo += incremento
        MsgBox("Titular: " + cc.Titular + vbCrLf _
               + "Conta: " + cc.Conta.ToString + vbCrLf _
               + "Agencia: " + cc.Agencia.ToString + vbCrLf _
               + "Saldo: " + cc.Saldo.ToString)
    End Sub

    Private Sub BtnAcao2_Click(sender As Object, e As EventArgs) Handles BtnAcao2.Click
        Dim cc As New ContaCorrente
        MsgBox("Titular: " + cc.Titular + vbCrLf _
               + "Conta: " + cc.Conta.ToString + vbCrLf _
               + "Agencia: " + cc.Agencia.ToString + vbCrLf _
               + "Saldo: " + cc.Saldo.ToString)
    End Sub

    Private Sub BtnRef_Click(sender As Object, e As EventArgs) Handles BtnRefVal.Click

        'Tipo valor
        Dim idade As Integer = 6
        Dim idade2 As Integer

        idade2 = idade
        MsgBox("Valor idade: " + idade.ToString + vbCrLf +
               "Valor idade2: " + idade2.ToString)

        idade = 30
        MsgBox("Valor idade: " + idade.ToString + vbCrLf +
               "Valor idade2: " + idade2.ToString)

        'Tipo referencia
        Dim cc As New ContaCorrente With {
            .Titular = "Annie",
            .Saldo = 100
        }
        Dim cc2 As New ContaCorrente With {
            .Titular = "Kafka",
            .Saldo = 50
        }
        MsgBox("Saldo cc: " + cc.Saldo.ToString + vbCrLf +
               "Saldo cc2: " + cc2.Saldo.ToString)

        cc2 = cc

        MsgBox("Saldo cc: " + cc.Saldo.ToString + vbCrLf +
               "Saldo cc2: " + cc2.Saldo.ToString)


    End Sub
End Class
