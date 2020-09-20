Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios
Public Class Frm_Principal_2
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btn_Bonificacao_Click(sender As Object, e As EventArgs) Handles Btn_Bonificacao.Click

        Dim TotBonificacao As New GerenciadorBonificacao

        Dim p1 As New Diretor("123", 5000)
        Dim p2 As New Designer("456", 3000)
        Dim p3 As New Gerente("789", 4000)
        Dim p4 As New Auxiliar("321", 2000)
        Dim p5 As New Desenvolvedor("445", 2000)

        With TotBonificacao
            .Registrar(p1)
            .Registrar(p2)
            .Registrar(p3)
            .Registrar(p4)
            .Registrar(p5)
        End With

        MsgBox("Total de bonificação: " + TotBonificacao.GetBonificacao().ToString)

    End Sub
End Class