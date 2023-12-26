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
        Me.FirstNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SecondNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddTogether = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FirstNumber
        '
        Me.FirstNumber.Location = New System.Drawing.Point(233, 37)
        Me.FirstNumber.Name = "FirstNumber"
        Me.FirstNumber.Size = New System.Drawing.Size(100, 20)
        Me.FirstNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "What is your first number?"
        '
        'SecondNumber
        '
        Me.SecondNumber.Location = New System.Drawing.Point(233, 83)
        Me.SecondNumber.Name = "SecondNumber"
        Me.SecondNumber.Size = New System.Drawing.Size(100, 20)
        Me.SecondNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "What is your second number?"
        '
        'AddTogether
        '
        Me.AddTogether.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.AddTogether.Location = New System.Drawing.Point(81, 137)
        Me.AddTogether.Name = "AddTogether"
        Me.AddTogether.Size = New System.Drawing.Size(93, 23)
        Me.AddTogether.TabIndex = 4
        Me.AddTogether.Text = "Calculate total"
        Me.AddTogether.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 259)
        Me.Controls.Add(Me.AddTogether)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SecondNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FirstNumber)
        Me.Name = "Form1"
        Me.Text = "Add 2 numbers together"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SecondNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AddTogether As Button
End Class
