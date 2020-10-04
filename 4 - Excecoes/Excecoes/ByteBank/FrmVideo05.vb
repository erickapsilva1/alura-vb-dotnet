Imports System.ComponentModel
Imports ByteBank.Classes

Public Class FrmVideo05

    Dim cc As New ContaCorrente(123, 34556)
    Dim cc2 As New ContaCorrente(432, 77574)
    Dim vStack As String = ""
    Dim vControle As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblContaCorrente.Text = "Conta: " + cc.Agencia.ToString + " - Número: " + cc.Numero.ToString
        LblContaCorrente2.Text = "Conta: " + cc2.Agencia.ToString + " - Número: " + cc2.Numero.ToString
        LblSaldoCC1.Text = cc.Saldo.ToString
        LblSaldoCC2.Text = cc2.Saldo.ToString
        TxtStackTrace.Visible = False
        LblSaqueErrado.Text = "N. saques errados: " + cc.NumeroSaquesErrados.ToString
        LblTransfErrada.Text = "N. transferências erradas: " + cc.NumeroTransferenciasErradas.ToString
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub BtnSacar_Click(sender As Object, e As EventArgs) Handles BtnSacar.Click
        Try
            vStack = ""
            Dim ValorSacar As Double = Val(TxtValor.Text)
            cc.Sacar(ValorSacar)
            LblSaldoCC1.Text = cc.Saldo.ToString

        Catch ex As ValorSacadoMenorSaldoException
            vStack = ex.StackTrace
            MsgBox("Falha ao sacar. Saldo insuficiente" + vbCrLf + ex.Message +
                   vbNewLine + ex.ValorSacado.ToString +
                   vbNewLine + ex.Saldo.ToString)
            LblSaqueErrado.Text = "Número de saques errados: " + cc.NumeroSaquesErrados.ToString

        Catch ex As ArgumentException
            vStack = ex.StackTrace
            MsgBox("Agumento inválido" + ex.Message)
            LblSaqueErrado.Text = "Número de saques errados: " + cc.NumeroSaquesErrados.ToString

        Catch ex As Exception
            vStack = ex.StackTrace
            MsgBox("Erro ao sacar." + ex.Message)

        End Try

    End Sub

    Private Sub BtnTransferir_Click(sender As Object, e As EventArgs) Handles BtnTransferir.Click

        Try
            vStack = ""
            Dim ValorTransferencia As Double = Val(TxtValor.Text)
            cc.Transferir(ValorTransferencia, cc2)
            LblSaldoCC1.Text = cc.Saldo.ToString
            LblSaldoCC2.Text = cc2.Saldo.ToString

        Catch ex As ValorSacadoMenorSaldoException
            vStack = ex.StackTrace
            MsgBox("Falha ao transferir. Saldo insuficiente" + vbCrLf + ex.Message +
                   vbNewLine + ex.ValorSacado.ToString +
                   vbNewLine + ex.Saldo.ToString)
            LblTransfErrada.Text = "N. transferências erradas: " + cc.NumeroTransferenciasErradas.ToString

        Catch ex As OperacaoFinanceiraException
            vStack = ex.StackTrace
            vStack += ex.InnerException.StackTrace
            MsgBox("OperacaoFinanceiraException" + ex.Message)
            LblTransfErrada.Text = "N. transferências erradas: " + cc.NumeroTransferenciasErradas.ToString

        Catch ex As ArgumentException
            vStack = ex.StackTrace
            MsgBox("Agumento inválido" + ex.Message)
            LblTransfErrada.Text = "N. transferências erradas: " + cc.NumeroTransferenciasErradas.ToString

        Catch ex As Exception
            vStack = ex.StackTrace + vbCrLf
            vStack += ex.InnerException.StackTrace
            MsgBox("Erro ao transferir." + ex.Message + vbCrLf + ex.InnerException.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If vControle = False Then
            vControle = True
            TxtStackTrace.Visible = True
        Else
            vControle = False
            TxtStackTrace.Visible = False
        End If
        TxtStackTrace.Text = vStack
    End Sub
End Class