Imports AutenticacaoByteBank.Classes.Bibliotecas
Imports AutenticacaoByteBank.Classes.Externos
Imports AutenticacaoByteBank.Classes.Funcionarios
Public Class FrmPrincipal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnAutentica_Click(sender As Object, e As EventArgs) Handles BtnAutentica.Click
        Dim dir As New Diretor("123", 2000)
        dir.Senha = "abc"

        Dim ger As New Gerente("443", 1000)
        ger.Senha = "ssa"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno

        vLoga = SistemaInterno.Logar(dir, "abc")
        MsgBox("Tem acesso? " + vLoga.ToString)

        vLoga = SistemaInterno.Logar(ger, "ssa")
        MsgBox("Tem acesso? " + vLoga.ToString)



    End Sub

    Private Sub BtnAutenticarExterno_Click(sender As Object, e As EventArgs) Handles BtnAutenticarExterno.Click
        Dim dir As New Diretor("123", 2000)
        dir.Senha = "abc567"

        Dim rep As New Representante()
        rep.Senha = "ssa2343221244"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno

        vLoga = SistemaInterno.Logar(dir, "abc567")
        MsgBox("Tem acesso? " + vLoga.ToString)

        vLoga = SistemaInterno.Logar(rep, "ssa2343221244")
        MsgBox("Tem acesso? " + vLoga.ToString)
    End Sub
End Class
