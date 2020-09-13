Public Class frmPrincipal3
    Dim listaCurso As String

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        lblTexto.Text = "Manipulando Strings"
        lblCurso.Text = "Digite o seu curso favorito"
        btnPrincipal.Text = "Click me"
        btnAdiciona.Text = "Adicione sua lista"
        Me.Text = "Manipulação de Strings"
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        Dim primeiraLetra As Char = "a"
        Dim segundaLetra As Char = Chr(65)

        MsgBox("Caractere: " & primeiraLetra & vbNewLine &
               "Caractere2: " & segundaLetra)
    End Sub

    Private Sub btnChar_Click(sender As Object, e As EventArgs) Handles btnChar.Click
        Dim valorChar As Integer = Val(txtChar.Text)
        Dim letra As Char = Chr(valorChar)
        MsgBox("Caractere do número " & valorChar & " = " & letra)
    End Sub

    Private Sub btnAdiciona_Click(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        Dim cursoDigitado As String = txtCurso.Text
        listaCurso += cursoDigitado & vbCrLf
        txtListaCurso.Text = listaCurso
    End Sub

    Private Sub btnMostra_Click(sender As Object, e As EventArgs) Handles btnMostra.Click
        MsgBox(listaCurso)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idade As Integer = 6
        Dim idadeSophie As Integer = 42

        idadeSophie = idade
        MsgBox("Idade = " & idade & " | idadeSophie = " & idadeSophie)

        idade = 20
        MsgBox("Idade = " & idade & " | idadeSophie = " & idadeSophie)

    End Sub
End Class
