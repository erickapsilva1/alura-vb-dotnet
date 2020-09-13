Imports _1___Primeiro_Projeto
Imports _2___Criando_Variaveis
Imports _3___Manipulando_Texto
Imports _4___Controle_de_Fluxo
Imports _5___Laços

Public Class frmPrincipal
    Private Sub btn01_Click(sender As Object, e As EventArgs) Handles btn01.Click
        Dim f As New frmTelaPrincipal1
        f.ShowDialog()
    End Sub

    Private Sub btn02_Click(sender As Object, e As EventArgs) Handles btn02.Click
        Dim f As New frmPrincipal2
        f.ShowDialog()
    End Sub

    Private Sub btn03_Click(sender As Object, e As EventArgs) Handles btn03.Click
        Dim f As New frmPrincipal3
        f.ShowDialog()
    End Sub

    Private Sub btn04_Click(sender As Object, e As EventArgs) Handles btn04.Click
        Dim f As New frmPrincipal4
        f.ShowDialog()
    End Sub

    Private Sub btn05_Click(sender As Object, e As EventArgs) Handles btn05.Click
        Dim f As New frmPrincipal5
        f.ShowDialog()
    End Sub
End Class
