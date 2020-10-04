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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Aula01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Vídeo01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tópico02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tópico03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Aula02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tópico04ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtDenominador = New System.Windows.Forms.TextBox()
        Me.LblDenominador = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAgencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtConta = New System.Windows.Forms.TextBox()
        Me.Aula03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tópico05ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Aula04ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tópico06ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Aula01ToolStripMenuItem, Me.Aula02ToolStripMenuItem, Me.Aula03ToolStripMenuItem, Me.Aula04ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(360, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Aula01ToolStripMenuItem
        '
        Me.Aula01ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Vídeo01ToolStripMenuItem, Me.Tópico02ToolStripMenuItem, Me.Tópico03ToolStripMenuItem})
        Me.Aula01ToolStripMenuItem.Name = "Aula01ToolStripMenuItem"
        Me.Aula01ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.Aula01ToolStripMenuItem.Text = "Aula 01"
        '
        'Vídeo01ToolStripMenuItem
        '
        Me.Vídeo01ToolStripMenuItem.Name = "Vídeo01ToolStripMenuItem"
        Me.Vídeo01ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.Vídeo01ToolStripMenuItem.Text = "Tópico 01"
        '
        'Tópico02ToolStripMenuItem
        '
        Me.Tópico02ToolStripMenuItem.Name = "Tópico02ToolStripMenuItem"
        Me.Tópico02ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.Tópico02ToolStripMenuItem.Text = "Tópico 02"
        '
        'Tópico03ToolStripMenuItem
        '
        Me.Tópico03ToolStripMenuItem.Name = "Tópico03ToolStripMenuItem"
        Me.Tópico03ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.Tópico03ToolStripMenuItem.Text = "Tópico 03"
        '
        'Aula02ToolStripMenuItem
        '
        Me.Aula02ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tópico04ToolStripMenuItem})
        Me.Aula02ToolStripMenuItem.Name = "Aula02ToolStripMenuItem"
        Me.Aula02ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.Aula02ToolStripMenuItem.Text = "Aula 02"
        '
        'Tópico04ToolStripMenuItem
        '
        Me.Tópico04ToolStripMenuItem.Name = "Tópico04ToolStripMenuItem"
        Me.Tópico04ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Tópico04ToolStripMenuItem.Text = "Tópico 04"
        '
        'TxtDenominador
        '
        Me.TxtDenominador.Location = New System.Drawing.Point(13, 92)
        Me.TxtDenominador.Name = "TxtDenominador"
        Me.TxtDenominador.Size = New System.Drawing.Size(100, 20)
        Me.TxtDenominador.TabIndex = 1
        '
        'LblDenominador
        '
        Me.LblDenominador.AutoSize = True
        Me.LblDenominador.Location = New System.Drawing.Point(13, 73)
        Me.LblDenominador.Name = "LblDenominador"
        Me.LblDenominador.Size = New System.Drawing.Size(70, 13)
        Me.LblDenominador.TabIndex = 2
        Me.LblDenominador.Text = "Denominador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Agência"
        '
        'TxtAgencia
        '
        Me.TxtAgencia.Location = New System.Drawing.Point(196, 92)
        Me.TxtAgencia.Name = "TxtAgencia"
        Me.TxtAgencia.Size = New System.Drawing.Size(100, 20)
        Me.TxtAgencia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Conta"
        '
        'TxtConta
        '
        Me.TxtConta.Location = New System.Drawing.Point(196, 143)
        Me.TxtConta.Name = "TxtConta"
        Me.TxtConta.Size = New System.Drawing.Size(100, 20)
        Me.TxtConta.TabIndex = 5
        '
        'Aula03ToolStripMenuItem
        '
        Me.Aula03ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tópico05ToolStripMenuItem})
        Me.Aula03ToolStripMenuItem.Name = "Aula03ToolStripMenuItem"
        Me.Aula03ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.Aula03ToolStripMenuItem.Text = "Aula 03"
        '
        'Tópico05ToolStripMenuItem
        '
        Me.Tópico05ToolStripMenuItem.Name = "Tópico05ToolStripMenuItem"
        Me.Tópico05ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Tópico05ToolStripMenuItem.Text = "Tópico 05"
        '
        'Aula04ToolStripMenuItem
        '
        Me.Aula04ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tópico06ToolStripMenuItem})
        Me.Aula04ToolStripMenuItem.Name = "Aula04ToolStripMenuItem"
        Me.Aula04ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.Aula04ToolStripMenuItem.Text = "Aula 04"
        '
        'Tópico06ToolStripMenuItem
        '
        Me.Tópico06ToolStripMenuItem.Name = "Tópico06ToolStripMenuItem"
        Me.Tópico06ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Tópico06ToolStripMenuItem.Text = "Tópico 06"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 272)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtConta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAgencia)
        Me.Controls.Add(Me.LblDenominador)
        Me.Controls.Add(Me.TxtDenominador)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ByteBank - Exceções"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Aula01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tópico02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtDenominador As TextBox
    Friend WithEvents LblDenominador As Label
    Friend WithEvents Tópico03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Aula02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tópico04ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAgencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtConta As TextBox
    Friend WithEvents Aula03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tópico05ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Aula04ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tópico06ToolStripMenuItem As ToolStripMenuItem
End Class
