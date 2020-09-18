Public Class FrmPrincipal2
    Dim cc As New ContaCorrente()
    Dim cc2 As New ContaCorrente()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Conta da Annie
        With cc
            .Titular = "Annie"
            .Agencia = 456
            .Conta = 8443
        End With

        ' Conta do Kafka
        With cc2
            .Titular = "Kafka"
            .Agencia = 123
            .Conta = 4210
        End With

        TxtSaldoAnnie.Text = cc.Saldo
        TxtResultadoAnnie.Text = ""

        LblBemVindaAnnie.Text = "Bem-vinda " + cc.Titular _
                    + ". Conta: " + cc.Conta.ToString _
                    + " Agencia: " + cc.Agencia.ToString

        TxtSaldoKafka.Text = cc2.Saldo
        TxtResultadoKafka.Text = ""

        LblBemVindoKafka.Text = "Bem-vindo " + cc2.Titular _
                    + ". Conta: " + cc2.Conta.ToString _
                    + " Agencia: " + cc2.Agencia.ToString

    End Sub

    Private Sub BtnSacar_Click(sender As Object, e As EventArgs) Handles BtnSacarAnnie.Click

        Dim valorSaque = Val(TxtValorAnnie.Text)
        TxtResultadoAnnie.Text = ""
        TxtValorAnnie.Text = ""

        If cc.Sacar(valorSaque) Then
            cc.Saldo -= valorSaque
            TxtResultadoAnnie.Text = "Saque efetuado com sucesso"
            TxtSaldoAnnie.Text = cc.Saldo
            cc.Extrato += Now.ToString _
                + " Saque de " + valorSaque.ToString _
                + " Saldo " + cc.Saldo.ToString + vbCrLf
            TxtExtratoAnnie.Text = cc.Extrato
        Else
            TxtResultadoAnnie.Text = "Saque não disponível"
        End If

    End Sub

    Private Sub BtnDeposito_Click(sender As Object, e As EventArgs) Handles BtnDepositoAnnie.Click

        Dim valorDepositar = Val(TxtValorAnnie.Text)

        TxtResultadoAnnie.Text = ""
        TxtValorAnnie.Text = ""

        cc.Depositar(valorDepositar)
        TxtSaldoAnnie.Text = cc.Saldo
        TxtResultadoAnnie.Text = "Depósito efetuado com sucesso"
        cc.Extrato += Now.ToString _
                + " Depósito de " + valorDepositar.ToString _
                + " Saldo " + cc.Saldo.ToString + vbCrLf
        TxtExtratoAnnie.Text = cc.Extrato

    End Sub

    Private Sub BtnSacarKafka_Click(sender As Object, e As EventArgs) Handles BtnSacarKafka.Click

        Dim valorSaque = Val(TxtValorKafka.Text)
        TxtResultadoKafka.Text = ""
        TxtValorKafka.Text = ""

        If cc2.Sacar(valorSaque) Then
            cc2.Saldo -= valorSaque
            TxtResultadoKafka.Text = "Saque efetuado com sucesso"
            TxtSaldoKafka.Text = cc2.Saldo
            cc2.Extrato += Now.ToString _
                + " Saque de " + valorSaque.ToString _
                + " Saldo " + cc2.Saldo.ToString + vbCrLf
            TxtExtratoKafka.Text = cc2.Extrato
        Else
            TxtResultadoKafka.Text = "Saque não disponível"
        End If

    End Sub

    Private Sub BtnDepositoKafka_Click(sender As Object, e As EventArgs) Handles BtnDepositoKafka.Click

        Dim valorDepositar = Val(TxtValorKafka.Text)

        TxtResultadoKafka.Text = ""
        TxtValorKafka.Text = ""

        cc2.Depositar(valorDepositar)
        TxtSaldoKafka.Text = cc2.Saldo
        TxtResultadoKafka.Text = "Depósito efetuado com sucesso"
        cc2.Extrato += Now.ToString _
                + " Depósito de " + valorDepositar.ToString _
                + " Saldo " + cc2.Saldo.ToString + vbCrLf
        TxtExtratoKafka.Text = cc2.Extrato

    End Sub

    Private Sub BtnTransferirAnnie_Click(sender As Object, e As EventArgs) Handles BtnTransferirAnnie.Click

        Dim valorTransf = Val(TxtValorAnnie.Text)
        TxtResultadoAnnie.Text = ""
        TxtValorAnnie.Text = ""

        If cc.Transferir(valorTransf, cc2) Then
            TxtResultadoAnnie.Text = "Transferência efetuada com sucesso"
            TxtSaldoAnnie.Text = cc.Saldo
            TxtSaldoKafka.Text = cc2.Saldo
            cc.Extrato += Now.ToString _
                + " Transferência de " + valorTransf.ToString _
                + " Saldo " + cc.Saldo.ToString + vbCrLf
            TxtExtratoAnnie.Text = cc.Extrato
            cc2.Extrato += Now.ToString _
                + " Transferência de " + valorTransf.ToString _
                + " Saldo " + cc2.Saldo.ToString + vbCrLf
            TxtExtratoKafka.Text = cc2.Extrato
        Else
            TxtResultadoAnnie.Text = "Transferência não disponível"
        End If

    End Sub

    Private Sub BtnTransferirKafka_Click(sender As Object, e As EventArgs) Handles BtnTransferirKafka.Click

        Dim valorTransf = Val(TxtValorKafka.Text)
        TxtResultadoKafka.Text = ""
        TxtValorKafka.Text = ""

        If cc2.Transferir(valorTransf, cc) Then
            TxtResultadoKafka.Text = "Transferência efetuada com sucesso"
            TxtSaldoKafka.Text = cc2.Saldo
            TxtSaldoAnnie.Text = cc.Saldo
            cc2.Extrato += Now.ToString _
                + " Transferência de " + valorTransf.ToString _
                + " Saldo " + cc2.Saldo.ToString + vbCrLf
            TxtExtratoKafka.Text = cc2.Extrato
            cc.Extrato += Now.ToString _
                + " Transferência de " + valorTransf.ToString _
                + " Saldo " + cc.Saldo.ToString + vbCrLf
            TxtExtratoAnnie.Text = cc.Extrato
        Else
            TxtResultadoKafka.Text = "Transferência não disponível"
        End If

    End Sub

End Class