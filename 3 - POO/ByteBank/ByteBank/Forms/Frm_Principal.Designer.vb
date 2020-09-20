<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblPrincipal = New System.Windows.Forms.Label()
        Me.BtnClick = New System.Windows.Forms.Button()
        Me.TxtMyBase = New System.Windows.Forms.Button()
        Me.BtnTesteHeranca = New System.Windows.Forms.Button()
        Me.BtnAumento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPrincipal
        '
        Me.LblPrincipal.AutoSize = True
        Me.LblPrincipal.Location = New System.Drawing.Point(13, 13)
        Me.LblPrincipal.Name = "LblPrincipal"
        Me.LblPrincipal.Size = New System.Drawing.Size(47, 13)
        Me.LblPrincipal.TabIndex = 0
        Me.LblPrincipal.Text = "Principal"
        '
        'BtnClick
        '
        Me.BtnClick.Location = New System.Drawing.Point(16, 52)
        Me.BtnClick.Name = "BtnClick"
        Me.BtnClick.Size = New System.Drawing.Size(75, 23)
        Me.BtnClick.TabIndex = 1
        Me.BtnClick.Text = "Herança"
        Me.BtnClick.UseVisualStyleBackColor = True
        '
        'TxtMyBase
        '
        Me.TxtMyBase.Location = New System.Drawing.Point(200, 52)
        Me.TxtMyBase.Name = "TxtMyBase"
        Me.TxtMyBase.Size = New System.Drawing.Size(75, 23)
        Me.TxtMyBase.TabIndex = 2
        Me.TxtMyBase.Text = "MyBase"
        Me.TxtMyBase.UseVisualStyleBackColor = True
        '
        'BtnTesteHeranca
        '
        Me.BtnTesteHeranca.Location = New System.Drawing.Point(107, 52)
        Me.BtnTesteHeranca.Name = "BtnTesteHeranca"
        Me.BtnTesteHeranca.Size = New System.Drawing.Size(75, 23)
        Me.BtnTesteHeranca.TabIndex = 3
        Me.BtnTesteHeranca.Text = "Test"
        Me.BtnTesteHeranca.UseVisualStyleBackColor = True
        '
        'BtnAumento
        '
        Me.BtnAumento.Location = New System.Drawing.Point(16, 93)
        Me.BtnAumento.Name = "BtnAumento"
        Me.BtnAumento.Size = New System.Drawing.Size(101, 23)
        Me.BtnAumento.TabIndex = 4
        Me.BtnAumento.Text = "Aumento Salário"
        Me.BtnAumento.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 163)
        Me.Controls.Add(Me.BtnAumento)
        Me.Controls.Add(Me.BtnTesteHeranca)
        Me.Controls.Add(Me.TxtMyBase)
        Me.Controls.Add(Me.BtnClick)
        Me.Controls.Add(Me.LblPrincipal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ByteBank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPrincipal As Label
    Friend WithEvents BtnClick As Button
    Friend WithEvents TxtMyBase As Button
    Friend WithEvents BtnTesteHeranca As Button
    Friend WithEvents BtnAumento As Button
End Class
