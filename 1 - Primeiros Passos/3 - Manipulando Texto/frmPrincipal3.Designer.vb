<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal3
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
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.txtChar = New System.Windows.Forms.TextBox()
        Me.btnChar = New System.Windows.Forms.Button()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.txtListaCurso = New System.Windows.Forms.TextBox()
        Me.btnMostra = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrincipal
        '
        Me.btnPrincipal.Location = New System.Drawing.Point(15, 47)
        Me.btnPrincipal.Name = "btnPrincipal"
        Me.btnPrincipal.Size = New System.Drawing.Size(114, 23)
        Me.btnPrincipal.TabIndex = 0
        Me.btnPrincipal.Text = "Click"
        Me.btnPrincipal.UseVisualStyleBackColor = True
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Location = New System.Drawing.Point(12, 19)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(39, 13)
        Me.lblTexto.TabIndex = 1
        Me.lblTexto.Text = "Label1"
        '
        'txtChar
        '
        Me.txtChar.Location = New System.Drawing.Point(216, 20)
        Me.txtChar.Name = "txtChar"
        Me.txtChar.Size = New System.Drawing.Size(100, 20)
        Me.txtChar.TabIndex = 2
        '
        'btnChar
        '
        Me.btnChar.Location = New System.Drawing.Point(216, 47)
        Me.btnChar.Name = "btnChar"
        Me.btnChar.Size = New System.Drawing.Size(100, 23)
        Me.btnChar.TabIndex = 3
        Me.btnChar.Text = "Show the Char"
        Me.btnChar.UseVisualStyleBackColor = True
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(12, 96)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(39, 13)
        Me.lblCurso.TabIndex = 4
        Me.lblCurso.Text = "Label1"
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(15, 127)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(195, 20)
        Me.txtCurso.TabIndex = 5
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Location = New System.Drawing.Point(216, 124)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(112, 23)
        Me.btnAdiciona.TabIndex = 6
        Me.btnAdiciona.Text = "Button1"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'txtListaCurso
        '
        Me.txtListaCurso.Location = New System.Drawing.Point(15, 173)
        Me.txtListaCurso.Multiline = True
        Me.txtListaCurso.Name = "txtListaCurso"
        Me.txtListaCurso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtListaCurso.Size = New System.Drawing.Size(195, 93)
        Me.txtListaCurso.TabIndex = 7
        '
        'btnMostra
        '
        Me.btnMostra.Location = New System.Drawing.Point(217, 154)
        Me.btnMostra.Name = "btnMostra"
        Me.btnMostra.Size = New System.Drawing.Size(111, 23)
        Me.btnMostra.TabIndex = 8
        Me.btnMostra.Text = "Meus Cursos"
        Me.btnMostra.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 293)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMostra)
        Me.Controls.Add(Me.txtListaCurso)
        Me.Controls.Add(Me.btnAdiciona)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.btnChar)
        Me.Controls.Add(Me.txtChar)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.btnPrincipal)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manipulando Strings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrincipal As Button
    Friend WithEvents lblTexto As Label
    Friend WithEvents txtChar As TextBox
    Friend WithEvents btnChar As Button
    Friend WithEvents lblCurso As Label
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents btnAdiciona As Button
    Friend WithEvents txtListaCurso As TextBox
    Friend WithEvents btnMostra As Button
    Friend WithEvents Button1 As Button
End Class
