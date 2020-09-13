Public Class frmPrincipal2
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnNumInteiros.Click
        Dim idade As Integer
        idade = 12

        MsgBox("O valor da idade é: " & idade)
    End Sub

    Private Sub btnNumFluatuantes_Click(sender As Object, e As EventArgs) Handles btnNumFluatuantes.Click
        Dim valor As Double
        Dim valorAdicional As Double = 11.5
        valor = 9.5

        valor += valorAdicional

        MsgBox("O valor é: " & valor)
    End Sub
End Class
