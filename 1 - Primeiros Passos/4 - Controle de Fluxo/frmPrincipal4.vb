Public Class frmPrincipal4
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        Dim idade As Integer
        Dim respAdicional As String

        idade = txtIdade.Text
        respAdicional = "Está acompanhada(o)."

        If (idade >= 18) Or (cbAcompanhado.Checked And idade >= 16) Then
            txtResultado.Text = "Acesso liberado. "
            If cbAcompanhado.Checked And idade >= 16 And idade < 18 Then txtResultado.Text += respAdicional
            txtResultado.ForeColor = Color.CadetBlue
        Else
            txtResultado.Text = "Acesso não liberado. A pessoa é menor de idade."
            txtResultado.ForeColor = Color.OrangeRed
        End If

        txtIdade.Text = ""

    End Sub


End Class
