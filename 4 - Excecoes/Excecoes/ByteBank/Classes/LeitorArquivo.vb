Imports System.IO

Namespace Classes
    Public Class LeitorArquivo
        Implements IDisposable
        Public Property status As String
        Public ReadOnly Property nomeArquivo As String
        Public Property conteudoArquivo As String

        Public Sub New(_Arquivo As String)
            nomeArquivo = _Arquivo

            'Throw New FileNotFoundException

            status = "ABERTO"
            conteudoArquivo = ""
            Console.WriteLine("Abrindo arquivo...")
        End Sub

        Public Sub LeituraLinha()

            Throw New IOException

            conteudoArquivo += "Leitura de linha..." + vbCrLf
            status = "ABERTO"
        End Sub

        Sub FecharArquivo()
            status = "FECHADO"
            Console.WriteLine("Fechando arquivo...")
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            FecharArquivo()
        End Sub
    End Class
End Namespace