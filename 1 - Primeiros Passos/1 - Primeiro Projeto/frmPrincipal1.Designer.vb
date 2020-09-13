<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelaPrincipal1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPrincipal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrincipal
        '
        Me.btnPrincipal.Location = New System.Drawing.Point(64, 26)
        Me.btnPrincipal.Name = "btnPrincipal"
        Me.btnPrincipal.Size = New System.Drawing.Size(114, 23)
        Me.btnPrincipal.TabIndex = 0
        Me.btnPrincipal.Text = "Romper a Maldição"
        Me.btnPrincipal.UseVisualStyleBackColor = True
        '
        'frmTelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 78)
        Me.Controls.Add(Me.btnPrincipal)
        Me.Name = "frmTelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "App Alô Mundo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrincipal As Button
End Class
