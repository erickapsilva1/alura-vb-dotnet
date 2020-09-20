<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Bonificacao = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Bonificacao
        '
        Me.Btn_Bonificacao.Location = New System.Drawing.Point(32, 28)
        Me.Btn_Bonificacao.Name = "Btn_Bonificacao"
        Me.Btn_Bonificacao.Size = New System.Drawing.Size(158, 23)
        Me.Btn_Bonificacao.TabIndex = 0
        Me.Btn_Bonificacao.Text = "Cálculo Bonificação"
        Me.Btn_Bonificacao.UseVisualStyleBackColor = True
        '
        'Frm_Principal_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 323)
        Me.Controls.Add(Me.Btn_Bonificacao)
        Me.Name = "Frm_Principal_2"
        Me.Text = "Cálculo Bonificação"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Bonificacao As Button
End Class
