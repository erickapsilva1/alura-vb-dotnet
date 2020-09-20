Public Class Form1
    Private Sub BtnInterface_Click(sender As Object, e As EventArgs) Handles BtnInterface.Click
        Dim x As New Imovel
        MsgBox(x.AbrirPorta(New Casa))
        MsgBox(x.AbrirPorta(New Predio))
        MsgBox(x.AbrirPorta(New Sobrado))
    End Sub
End Class
