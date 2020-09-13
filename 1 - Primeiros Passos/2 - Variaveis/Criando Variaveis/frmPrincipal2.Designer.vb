<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnNumInteiros = New System.Windows.Forms.Button()
        Me.lblNomeProjeto = New System.Windows.Forms.Label()
        Me.btnNumFluatuantes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNumInteiros
        '
        Me.btnNumInteiros.Location = New System.Drawing.Point(215, 31)
        Me.btnNumInteiros.Name = "btnNumInteiros"
        Me.btnNumInteiros.Size = New System.Drawing.Size(114, 23)
        Me.btnNumInteiros.TabIndex = 0
        Me.btnNumInteiros.Text = "Números Inteiros"
        Me.btnNumInteiros.UseVisualStyleBackColor = True
        '
        'lblNomeProjeto
        '
        Me.lblNomeProjeto.AutoSize = True
        Me.lblNomeProjeto.Location = New System.Drawing.Point(13, 13)
        Me.lblNomeProjeto.Name = "lblNomeProjeto"
        Me.lblNomeProjeto.Size = New System.Drawing.Size(101, 13)
        Me.lblNomeProjeto.TabIndex = 1
        Me.lblNomeProjeto.Text = "2 - Projeto Variáveis"
        '
        'btnNumFluatuantes
        '
        Me.btnNumFluatuantes.Location = New System.Drawing.Point(215, 60)
        Me.btnNumFluatuantes.Name = "btnNumFluatuantes"
        Me.btnNumFluatuantes.Size = New System.Drawing.Size(114, 23)
        Me.btnNumFluatuantes.TabIndex = 2
        Me.btnNumFluatuantes.Text = "Números Flutuantes"
        Me.btnNumFluatuantes.UseVisualStyleBackColor = True
        '
        'frmTelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 122)
        Me.Controls.Add(Me.btnNumFluatuantes)
        Me.Controls.Add(Me.lblNomeProjeto)
        Me.Controls.Add(Me.btnNumInteiros)
        Me.Name = "frmTelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variáveis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNumInteiros As Button
    Friend WithEvents lblNomeProjeto As Label
    Friend WithEvents btnNumFluatuantes As Button
End Class
