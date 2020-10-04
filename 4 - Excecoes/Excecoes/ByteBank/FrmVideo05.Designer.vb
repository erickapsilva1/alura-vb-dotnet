<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVideo05
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
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblSaldoCC2 = New System.Windows.Forms.Label()
        Me.BtnTransferir = New System.Windows.Forms.Button()
        Me.LblSaldoCC1 = New System.Windows.Forms.Label()
        Me.BtnSacar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblContaCorrente = New System.Windows.Forms.Label()
        Me.LblContaCorrente2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtStackTrace = New System.Windows.Forms.TextBox()
        Me.LblSaqueErrado = New System.Windows.Forms.Label()
        Me.LblTransfErrada = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFechar
        '
        Me.BtnFechar.Location = New System.Drawing.Point(554, 70)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(75, 23)
        Me.BtnFechar.TabIndex = 0
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblTransfErrada)
        Me.GroupBox1.Controls.Add(Me.LblSaqueErrado)
        Me.GroupBox1.Controls.Add(Me.LblSaldoCC2)
        Me.GroupBox1.Controls.Add(Me.BtnTransferir)
        Me.GroupBox1.Controls.Add(Me.LblSaldoCC1)
        Me.GroupBox1.Controls.Add(Me.BtnSacar)
        Me.GroupBox1.Controls.Add(Me.TxtValor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 164)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movimentação da Conta"
        '
        'LblSaldoCC2
        '
        Me.LblSaldoCC2.AutoSize = True
        Me.LblSaldoCC2.Location = New System.Drawing.Point(264, 98)
        Me.LblSaldoCC2.Name = "LblSaldoCC2"
        Me.LblSaldoCC2.Size = New System.Drawing.Size(57, 13)
        Me.LblSaldoCC2.TabIndex = 5
        Me.LblSaldoCC2.Text = "Saldo CC2"
        '
        'BtnTransferir
        '
        Me.BtnTransferir.Location = New System.Drawing.Point(311, 56)
        Me.BtnTransferir.Name = "BtnTransferir"
        Me.BtnTransferir.Size = New System.Drawing.Size(75, 23)
        Me.BtnTransferir.TabIndex = 4
        Me.BtnTransferir.Text = "Transferir"
        Me.BtnTransferir.UseVisualStyleBackColor = True
        '
        'LblSaldoCC1
        '
        Me.LblSaldoCC1.AutoSize = True
        Me.LblSaldoCC1.Location = New System.Drawing.Point(6, 98)
        Me.LblSaldoCC1.Name = "LblSaldoCC1"
        Me.LblSaldoCC1.Size = New System.Drawing.Size(57, 13)
        Me.LblSaldoCC1.TabIndex = 3
        Me.LblSaldoCC1.Text = "Saldo CC1"
        '
        'BtnSacar
        '
        Me.BtnSacar.Location = New System.Drawing.Point(230, 55)
        Me.BtnSacar.Name = "BtnSacar"
        Me.BtnSacar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSacar.TabIndex = 2
        Me.BtnSacar.Text = "Sacar"
        Me.BtnSacar.UseVisualStyleBackColor = True
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(9, 56)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(198, 20)
        Me.TxtValor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor"
        '
        'LblContaCorrente
        '
        Me.LblContaCorrente.AutoSize = True
        Me.LblContaCorrente.Location = New System.Drawing.Point(18, 23)
        Me.LblContaCorrente.Name = "LblContaCorrente"
        Me.LblContaCorrente.Size = New System.Drawing.Size(19, 13)
        Me.LblContaCorrente.TabIndex = 2
        Me.LblContaCorrente.Text = "cc"
        '
        'LblContaCorrente2
        '
        Me.LblContaCorrente2.AutoSize = True
        Me.LblContaCorrente2.Location = New System.Drawing.Point(276, 23)
        Me.LblContaCorrente2.Name = "LblContaCorrente2"
        Me.LblContaCorrente2.Size = New System.Drawing.Size(25, 13)
        Me.LblContaCorrente2.TabIndex = 3
        Me.LblContaCorrente2.Text = "cc2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ver último trace"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtStackTrace
        '
        Me.TxtStackTrace.Location = New System.Drawing.Point(21, 256)
        Me.TxtStackTrace.Multiline = True
        Me.TxtStackTrace.Name = "TxtStackTrace"
        Me.TxtStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtStackTrace.Size = New System.Drawing.Size(510, 103)
        Me.TxtStackTrace.TabIndex = 4
        '
        'LblSaqueErrado
        '
        Me.LblSaqueErrado.AutoSize = True
        Me.LblSaqueErrado.Location = New System.Drawing.Point(6, 135)
        Me.LblSaqueErrado.Name = "LblSaqueErrado"
        Me.LblSaqueErrado.Size = New System.Drawing.Size(31, 13)
        Me.LblSaqueErrado.TabIndex = 6
        Me.LblSaqueErrado.Text = "sErro"
        '
        'LblTransfErrada
        '
        Me.LblTransfErrada.AutoSize = True
        Me.LblTransfErrada.Location = New System.Drawing.Point(264, 135)
        Me.LblTransfErrada.Name = "LblTransfErrada"
        Me.LblTransfErrada.Size = New System.Drawing.Size(29, 13)
        Me.LblTransfErrada.TabIndex = 7
        Me.LblTransfErrada.Text = "tErro"
        '
        'FrmVideo05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 369)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtStackTrace)
        Me.Controls.Add(Me.LblContaCorrente2)
        Me.Controls.Add(Me.LblContaCorrente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnFechar)
        Me.Name = "FrmVideo05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário Vídeo 05"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFechar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSacar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblContaCorrente As Label
    Friend WithEvents LblSaldoCC1 As Label
    Friend WithEvents BtnTransferir As Button
    Friend WithEvents LblContaCorrente2 As Label
    Friend WithEvents LblSaldoCC2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtStackTrace As TextBox
    Friend WithEvents LblSaqueErrado As Label
    Friend WithEvents LblTransfErrada As Label
End Class
