<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal1
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
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.btnAcao = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.TxtIncremento = New System.Windows.Forms.TextBox()
        Me.BtnAcao2 = New System.Windows.Forms.Button()
        Me.BtnRefVal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(12, 9)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(78, 13)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "Primeira Classe"
        '
        'btnAcao
        '
        Me.btnAcao.Location = New System.Drawing.Point(15, 46)
        Me.btnAcao.Name = "btnAcao"
        Me.btnAcao.Size = New System.Drawing.Size(75, 23)
        Me.btnAcao.TabIndex = 1
        Me.btnAcao.Text = "Click"
        Me.btnAcao.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Saldo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Incremento"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Location = New System.Drawing.Point(15, 97)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(75, 20)
        Me.TxtSaldo.TabIndex = 4
        '
        'TxtIncremento
        '
        Me.TxtIncremento.Location = New System.Drawing.Point(108, 97)
        Me.TxtIncremento.Name = "TxtIncremento"
        Me.TxtIncremento.Size = New System.Drawing.Size(75, 20)
        Me.TxtIncremento.TabIndex = 5
        '
        'BtnAcao2
        '
        Me.BtnAcao2.Location = New System.Drawing.Point(249, 46)
        Me.BtnAcao2.Name = "BtnAcao2"
        Me.BtnAcao2.Size = New System.Drawing.Size(75, 23)
        Me.BtnAcao2.TabIndex = 6
        Me.BtnAcao2.Text = "Click"
        Me.BtnAcao2.UseVisualStyleBackColor = True
        '
        'BtnRefVal
        '
        Me.BtnRefVal.Location = New System.Drawing.Point(249, 81)
        Me.BtnRefVal.Name = "BtnRefVal"
        Me.BtnRefVal.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefVal.TabIndex = 7
        Me.BtnRefVal.Text = "Ref e Val"
        Me.BtnRefVal.UseVisualStyleBackColor = True
        '
        'FrmPrincipal1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 152)
        Me.Controls.Add(Me.BtnRefVal)
        Me.Controls.Add(Me.BtnAcao2)
        Me.Controls.Add(Me.TxtIncremento)
        Me.Controls.Add(Me.TxtSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAcao)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Name = "FrmPrincipal1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Primeira Classe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrincipal As Label
    Friend WithEvents btnAcao As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSaldo As TextBox
    Friend WithEvents TxtIncremento As TextBox
    Friend WithEvents BtnAcao2 As Button
    Friend WithEvents BtnRefVal As Button
End Class
