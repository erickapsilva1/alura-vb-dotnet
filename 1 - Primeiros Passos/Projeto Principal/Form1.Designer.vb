<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.btn01 = New System.Windows.Forms.Button()
        Me.btn02 = New System.Windows.Forms.Button()
        Me.btn03 = New System.Windows.Forms.Button()
        Me.btn04 = New System.Windows.Forms.Button()
        Me.btn05 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn01
        '
        Me.btn01.Location = New System.Drawing.Point(27, 28)
        Me.btn01.Name = "btn01"
        Me.btn01.Size = New System.Drawing.Size(200, 23)
        Me.btn01.TabIndex = 0
        Me.btn01.Text = "Projeto 1 - Inicial"
        Me.btn01.UseVisualStyleBackColor = True
        '
        'btn02
        '
        Me.btn02.Location = New System.Drawing.Point(27, 57)
        Me.btn02.Name = "btn02"
        Me.btn02.Size = New System.Drawing.Size(200, 23)
        Me.btn02.TabIndex = 1
        Me.btn02.Text = "Projeto 2 - Variáveis"
        Me.btn02.UseVisualStyleBackColor = True
        '
        'btn03
        '
        Me.btn03.Location = New System.Drawing.Point(27, 86)
        Me.btn03.Name = "btn03"
        Me.btn03.Size = New System.Drawing.Size(200, 23)
        Me.btn03.TabIndex = 2
        Me.btn03.Text = "Projeto 3 - Manipulando Textos"
        Me.btn03.UseVisualStyleBackColor = True
        '
        'btn04
        '
        Me.btn04.Location = New System.Drawing.Point(27, 115)
        Me.btn04.Name = "btn04"
        Me.btn04.Size = New System.Drawing.Size(200, 23)
        Me.btn04.TabIndex = 3
        Me.btn04.Text = "Projeto 4 - Controle de Fluxos"
        Me.btn04.UseVisualStyleBackColor = True
        '
        'btn05
        '
        Me.btn05.Location = New System.Drawing.Point(27, 144)
        Me.btn05.Name = "btn05"
        Me.btn05.Size = New System.Drawing.Size(200, 23)
        Me.btn05.TabIndex = 4
        Me.btn05.Text = "Projeto 5 - Laços de Repetição"
        Me.btn05.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 199)
        Me.Controls.Add(Me.btn05)
        Me.Controls.Add(Me.btn04)
        Me.Controls.Add(Me.btn03)
        Me.Controls.Add(Me.btn02)
        Me.Controls.Add(Me.btn01)
        Me.Name = "frmPrincipal"
        Me.Text = "Projeto Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn01 As Button
    Friend WithEvents btn02 As Button
    Friend WithEvents btn03 As Button
    Friend WithEvents btn04 As Button
    Friend WithEvents btn05 As Button
End Class
