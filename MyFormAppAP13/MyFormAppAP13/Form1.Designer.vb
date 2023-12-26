<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MyText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BThis = New System.Windows.Forms.Button()
        Me.BIs = New System.Windows.Forms.Button()
        Me.BMy = New System.Windows.Forms.Button()
        Me.BProgram = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MyText
        '
        Me.MyText.Enabled = False
        Me.MyText.Location = New System.Drawing.Point(121, 43)
        Me.MyText.Name = "MyText"
        Me.MyText.Size = New System.Drawing.Size(100, 20)
        Me.MyText.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "My text is"
        '
        'BThis
        '
        Me.BThis.Location = New System.Drawing.Point(35, 85)
        Me.BThis.Name = "BThis"
        Me.BThis.Size = New System.Drawing.Size(75, 23)
        Me.BThis.TabIndex = 2
        Me.BThis.Text = "Add ""This"""
        Me.BThis.UseVisualStyleBackColor = True
        '
        'BIs
        '
        Me.BIs.AutoEllipsis = True
        Me.BIs.Location = New System.Drawing.Point(121, 84)
        Me.BIs.Name = "BIs"
        Me.BIs.Size = New System.Drawing.Size(75, 23)
        Me.BIs.TabIndex = 3
        Me.BIs.Text = "Add ""is"""
        Me.BIs.UseVisualStyleBackColor = True
        '
        'BMy
        '
        Me.BMy.Location = New System.Drawing.Point(202, 85)
        Me.BMy.Name = "BMy"
        Me.BMy.Size = New System.Drawing.Size(75, 23)
        Me.BMy.TabIndex = 4
        Me.BMy.Text = "Add ""my"""
        Me.BMy.UseVisualStyleBackColor = True
        '
        'BProgram
        '
        Me.BProgram.Location = New System.Drawing.Point(283, 84)
        Me.BProgram.Name = "BProgram"
        Me.BProgram.Size = New System.Drawing.Size(100, 23)
        Me.BProgram.TabIndex = 5
        Me.BProgram.Text = "Add ""program"""
        Me.BProgram.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 187)
        Me.Controls.Add(Me.BProgram)
        Me.Controls.Add(Me.BMy)
        Me.Controls.Add(Me.BIs)
        Me.Controls.Add(Me.BThis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MyText)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BThis As Button
    Friend WithEvents BIs As Button
    Friend WithEvents BMy As Button
    Friend WithEvents BProgram As Button
End Class
