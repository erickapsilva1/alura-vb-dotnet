<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.BtnAutentica = New System.Windows.Forms.Button()
        Me.BtnAutenticarExterno = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAutentica
        '
        Me.BtnAutentica.Location = New System.Drawing.Point(30, 67)
        Me.BtnAutentica.Name = "BtnAutentica"
        Me.BtnAutentica.Size = New System.Drawing.Size(75, 23)
        Me.BtnAutentica.TabIndex = 0
        Me.BtnAutentica.Text = "Autentica"
        Me.BtnAutentica.UseVisualStyleBackColor = True
        '
        'BtnAutenticarExterno
        '
        Me.BtnAutenticarExterno.Location = New System.Drawing.Point(127, 67)
        Me.BtnAutenticarExterno.Name = "BtnAutenticarExterno"
        Me.BtnAutenticarExterno.Size = New System.Drawing.Size(135, 23)
        Me.BtnAutenticarExterno.TabIndex = 1
        Me.BtnAutenticarExterno.Text = "Autentica Externo"
        Me.BtnAutenticarExterno.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 286)
        Me.Controls.Add(Me.BtnAutenticarExterno)
        Me.Controls.Add(Me.BtnAutentica)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autenticação ByteBank"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAutentica As Button
    Friend WithEvents BtnAutenticarExterno As Button
End Class
