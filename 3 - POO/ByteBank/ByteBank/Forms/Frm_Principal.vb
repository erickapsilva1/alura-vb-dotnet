Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnClick_Click(sender As Object, e As EventArgs) Handles BtnClick.Click

        Dim f As New Gerente("3432123454", 10000) With {
            .Nome = "Cunegunda"
        }

        Dim g As New Diretor("3432123454", 20000) With {
            .Nome = "Pangloss"
        }

        Dim ger As New GerenciadorBonificacao()
        ger.Registrar(f)
        ger.Registrar(g)

        MsgBox("Funcionaria(o): " + f.Nome + vbCrLf _
               + "Salário: " + f.Salario.ToString())
        MsgBox("Funcionaria(o): " + f.Nome + vbCrLf _
               + "Bonificação: " + f.GetBonificacao().ToString())

        MsgBox("Funcionaria(o): " + g.Nome + vbCrLf _
       + "Salário: " + g.Salario.ToString())
        MsgBox("Funcionaria(o): " + g.Nome + vbCrLf _
               + "Bonificação: " + g.GetBonificacao().ToString())

        MsgBox("Total de bonificação: " + ger.GetBonificacao.ToString)

    End Sub



    Private Sub TxtMyBase_Click(sender As Object, e As EventArgs) Handles TxtMyBase.Click

        Dim vDiretor As New Diretor("3432123454", 10000)

        MsgBox("A bonificação do diretor é: " + vDiretor.GetBonificacao().ToString)

    End Sub

    Private Sub BtnTesteHeranca_Click_1(sender As Object, e As EventArgs) Handles BtnTesteHeranca.Click

        Dim vDiretor As New Diretor("3432123454", 10000)
        'Dim vFuncionario As New Funcionario("987654321", 10000)
        'Dim vDiretorFuncionario As New Funcionario("123456789", 10000)

        MsgBox("Total funcionários: " + Funcionario.TotalDeFuncionarios.ToString)

        'vDiretorFuncionario = vDiretor

        Dim vSaida As String = ""

        vSaida = "Bonificação vDiretor: " + vDiretor.GetBonificacao().ToString + vbCrLf
        'vSaida += "Bonificação vFuncionario: " + vFuncionario.GetBonificacao().ToString + vbCrLf
        'vSaida += "Bonificação vDiretorFuncionario: " + vDiretorFuncionario.GetBonificacao().ToString + vbCrLf

        MsgBox(vSaida)

    End Sub

    Private Sub BtnAumento_Click(sender As Object, e As EventArgs) Handles BtnAumento.Click

        'Dim vFuncionario As New Funcionario("123", 1000)
        Dim vGerente As New Gerente("789", 2000)
        Dim vDiretor As New Diretor("456", 3000)


        Dim vTexto As String = ""
        'vTexto = "Salário Funcionário: " + vFuncionario.Salario.ToString + vbCrLf
        vTexto += "Salário Gerente: " + vGerente.Salario.ToString + vbCrLf
        vTexto += "Salário Diretor: " + vDiretor.Salario.ToString + vbCrLf

        MsgBox(vTexto)

        'vFuncionario.AumentarSalario()
        vGerente.AumentarSalario()
        vDiretor.AumentarSalario()

        'vTexto = "Salário Funcionário: " + vFuncionario.Salario.ToString + vbCrLf
        vTexto += "Salário Gerente: " + vGerente.Salario.ToString + vbCrLf
        vTexto += "Salário Diretor: " + vDiretor.Salario.ToString + vbCrLf

        MsgBox(vTexto)

    End Sub
End Class
