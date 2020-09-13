<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal4
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
        Me.btnPrincipal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdade = New System.Windows.Forms.Label()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.cbAcompanhado = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnPrincipal
        '
        Me.btnPrincipal.Location = New System.Drawing.Point(300, 164)
        Me.btnPrincipal.Name = "btnPrincipal"
        Me.btnPrincipal.Size = New System.Drawing.Size(87, 23)
        Me.btnPrincipal.TabIndex = 0
        Me.btnPrincipal.Text = "Checar"
        Me.btnPrincipal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Controle de Fluxo"
        '
        'lblIdade
        '
        Me.lblIdade.AutoSize = True
        Me.lblIdade.Location = New System.Drawing.Point(27, 54)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(34, 13)
        Me.lblIdade.TabIndex = 2
        Me.lblIdade.Text = "Idade"
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(30, 70)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(86, 20)
        Me.txtIdade.TabIndex = 3
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(30, 122)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(357, 20)
        Me.txtResultado.TabIndex = 4
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(27, 106)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(55, 13)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "Resultado"
        '
        'cbAcompanhado
        '
        Me.cbAcompanhado.AutoSize = True
        Me.cbAcompanhado.Location = New System.Drawing.Point(137, 70)
        Me.cbAcompanhado.Name = "cbAcompanhado"
        Me.cbAcompanhado.Size = New System.Drawing.Size(119, 17)
        Me.cbAcompanhado.TabIndex = 7
        Me.cbAcompanhado.Text = "Pais acompanham?"
        Me.cbAcompanhado.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 199)
        Me.Controls.Add(Me.cbAcompanhado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrincipal)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Fluxo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIdade As Label
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents cbAcompanhado As CheckBox
End Class
