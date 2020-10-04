Imports System.IO
Imports ByteBank.Classes

Public Class FrmPrincipal

    Private Sub Vídeo01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo01ToolStripMenuItem.Click
        Dim c As New ContaCorrente(662, 300)

        MsgBox("Quantidade de Contas Correntes: " + ContaCorrente.TotalContasCriadas.ToString + vbCrLf +
               "Total taxas manutenção Contas Correntes: " + ContaCorrente.TaxaManutencaoCC.ToString)

    End Sub

    Private Sub Tópico02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Tópico02ToolStripMenuItem.Click

        Dim denominador As Integer = Val(TxtDenominador.Text)

        TestarDivisao(denominador)
    End Sub

    Sub TestarDivisao(Valor As Integer)
        Dim Resultado As Integer = EfetuarDivisao(10, Valor)
        MsgBox("Resultado de 10 / " + Valor.ToString + " = " + Resultado.ToString)
    End Sub

    Function EfetuarDivisao(Numerador As Integer, Denominador As Integer) As Integer
        Return Numerador / Denominador
    End Function

    Private Sub Tópico03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Tópico03ToolStripMenuItem.Click
        Dim denominador As Integer = Val(TxtDenominador.Text)
        TestarDivisao2(denominador)
    End Sub

    Sub TestarDivisao2(Valor As Integer)
        Try
            Dim Resultado As Integer = EfetuarDivisao2(10, Valor)
            MsgBox("Resultado de 10 / " + Valor.ToString + " = " + Resultado.ToString)
        Catch ex As OverflowException
            MsgBox("Não é possível dividir por zero")
        Catch ex As InvalidCastException
            MsgBox("Falha ao converter número para texto" + vbCrLf +
                   ex.Message + vbCrLf +
                   ex.StackTrace)
        Catch ex As Exception
            MsgBox("Falha ao realizar a divisão")
        End Try

    End Sub

    Function EfetuarDivisao2(Numerador As Integer, Denominador As Integer) As Integer
        Try
            Return Numerador / Denominador
        Catch ex As Exception
            MsgBox("Tentativa de dividir " + Numerador.ToString + " por " + Denominador.ToString)
            Throw
        End Try

    End Function

    Private Sub Tópico04ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Tópico04ToolStripMenuItem.Click
        Try
            Dim agencia = Val(TxtAgencia.Text)
            Dim conta = Val(TxtConta.Text)
            Dim cc As New ContaCorrente(agencia, conta)
            MsgBox("Agência: " + cc.Agencia.ToString + " - Conta: " + cc.Numero.ToString)
        Catch ex As ArgumentException
            If ex.ParamName = "CodigoDaAgencia" Then
                MsgBox(ex.Message)
            ElseIf ex.ParamName = "NumeroDaConta" Then
                MsgBox(ex.Message)
            End If

        Catch ex As Exception
            MsgBox("Erro genérico.")
        End Try

    End Sub

    Private Sub Tópico05ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Tópico05ToolStripMenuItem.Click
        Dim f As New FrmVideo05
        f.ShowDialog()
    End Sub

    Private Sub Tópico06ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Tópico06ToolStripMenuItem.Click

        Try
            LeituraArquivo()
        Catch ex As Exception
            Console.WriteLine("Erro no arquivo.")
        End Try


    End Sub

    Sub LeituraArquivo()

        Using x As New LeitorArquivo("ContaCorrente.Txt")
            x.LeituraLinha()
            x.LeituraLinha()
            x.LeituraLinha()
            x.LeituraLinha()
            Console.WriteLine(x.conteudoArquivo())
            Console.WriteLine(x.status)
        End Using

        'Dim x As LeitorArquivo

        'Try
        '    x = New LeitorArquivo("ContaCorrente.txt")
        '    Console.WriteLine(x.status)
        '    x.LeituraLinha()
        '    x.LeituraLinha()
        '    x.LeituraLinha()
        '    x.LeituraLinha()
        '    Console.WriteLine(x.conteudoArquivo())
        '    Console.WriteLine(x.status)
        'Finally
        '    If Not x Is Nothing Then
        '        x.FecharArquivo()
        '        Console.WriteLine(x.status)
        '    End If
        'End Try

    End Sub

End Class

