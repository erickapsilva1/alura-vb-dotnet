Public Class frmTelaPrincipal1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        MsgBox("Olá mundo!", vbInformation, "Boas vindas. :D")
    End Sub


End Class
