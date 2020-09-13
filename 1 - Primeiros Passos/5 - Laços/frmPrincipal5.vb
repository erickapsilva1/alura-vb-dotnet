Public Class frmPrincipal5
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCalcula_Click(sender As Object, e As EventArgs) Handles btnCalculaWhile.Click
        Dim investimento As Double = Val(txtPrincipal.Text)
        Dim rendimento As Double = Val(txtRendimento.Text)
        Dim prazo As Integer = Val(txtPrazo.Text)
        Dim i As Integer
        Dim extrato As String = ""

        txtParcelas.Text = ""

        i = 1
        While i <= prazo
            investimento += (investimento * (rendimento / 100))
            extrato += i & " - " & FormatNumber(investimento, 2) & vbCrLf
            i += 1
        End While

        txtParcelas.Text = extrato

        MsgBox(FormatNumber(investimento, 2))
    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        Dim investimento As Double = Val(txtPrincipal.Text)
        Dim rendimento As Double = Val(txtRendimento.Text)
        Dim prazo As Integer = Val(txtPrazo.Text)
        Dim extrato As String = ""

        txtParcelas.Text = ""

        For i As Integer = 1 To prazo
            investimento += (investimento * (rendimento / 100))
            extrato += i & " - " & FormatNumber(investimento, 2) & vbCrLf
        Next

        txtParcelas.Text = extrato

        MsgBox(FormatNumber(investimento, 2))
    End Sub

    Private Sub txtCalcula_Click(sender As Object, e As EventArgs) Handles txtCalcula.Click
        Dim investimento As Double = Val(txtPrincipal2.Text)
        Dim taxa As Double = Val(txtTx2.Text)
        Dim prazo As Integer = Val(txtAno.Text)
        Dim acrescimo As Double = Val(txtAcrescimo.Text)
        Dim limite As Double = Val(txtLimite.Text)
        Dim extrato As String = ""
        Dim contador As Integer = 1
        Dim limiteAtingido As Boolean = False

        txtParcelas2.Text = ""

        For i As Integer = 1 To prazo
            For j As Integer = 1 To 12
                investimento += (investimento * (taxa / 100))
                extrato += "Mês: " + contador.ToString _
                + " Taxa: " + taxa.ToString _
                + " Valor: " + FormatNumber(investimento.ToString, 2) +
                vbCrLf
                If investimento >= limite Then
                    limiteAtingido = True
                    extrato += "Limite de " + limite.ToString + " atingido" + vbCrLf
                    Exit For
                End If
                contador += 1
            Next
            If limiteAtingido Then
                Exit For
            End If
            taxa += (taxa * acrescimo / 100)
        Next

        txtParcelas2.Text = extrato

    End Sub
End Class
