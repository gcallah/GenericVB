<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FirstNumLbl = New System.Windows.Forms.Label()
        Me.ScndNumLbl = New System.Windows.Forms.Label()
        Me.FirstNumBox = New System.Windows.Forms.TextBox()
        Me.ScndNumBox = New System.Windows.Forms.TextBox()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.AnswerLbl = New System.Windows.Forms.Label()
        Me.AnswerBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'FirstNumLbl
        '
        Me.FirstNumLbl.AutoSize = True
        Me.FirstNumLbl.Location = New System.Drawing.Point(44, 50)
        Me.FirstNumLbl.Name = "FirstNumLbl"
        Me.FirstNumLbl.Size = New System.Drawing.Size(91, 17)
        Me.FirstNumLbl.TabIndex = 0
        Me.FirstNumLbl.Text = "First number:"
        '
        'ScndNumLbl
        '
        Me.ScndNumLbl.AutoSize = True
        Me.ScndNumLbl.Location = New System.Drawing.Point(44, 92)
        Me.ScndNumLbl.Name = "ScndNumLbl"
        Me.ScndNumLbl.Size = New System.Drawing.Size(112, 17)
        Me.ScndNumLbl.TabIndex = 1
        Me.ScndNumLbl.Text = "Second number:"
        '
        'FirstNumBox
        '
        Me.FirstNumBox.Location = New System.Drawing.Point(175, 50)
        Me.FirstNumBox.Name = "FirstNumBox"
        Me.FirstNumBox.Size = New System.Drawing.Size(100, 22)
        Me.FirstNumBox.TabIndex = 2
        '
        'ScndNumBox
        '
        Me.ScndNumBox.Location = New System.Drawing.Point(175, 92)
        Me.ScndNumBox.Name = "ScndNumBox"
        Me.ScndNumBox.Size = New System.Drawing.Size(100, 22)
        Me.ScndNumBox.TabIndex = 3
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(145, 152)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(96, 29)
        Me.CalcButton.TabIndex = 4
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'AnswerLbl
        '
        Me.AnswerLbl.AutoSize = True
        Me.AnswerLbl.Location = New System.Drawing.Point(47, 201)
        Me.AnswerLbl.Name = "AnswerLbl"
        Me.AnswerLbl.Size = New System.Drawing.Size(58, 17)
        Me.AnswerLbl.TabIndex = 5
        Me.AnswerLbl.Text = "Answer:"
        '
        'AnswerBox
        '
        Me.AnswerBox.Location = New System.Drawing.Point(175, 201)
        Me.AnswerBox.Name = "AnswerBox"
        Me.AnswerBox.Size = New System.Drawing.Size(100, 22)
        Me.AnswerBox.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 328)
        Me.Controls.Add(Me.AnswerBox)
        Me.Controls.Add(Me.AnswerLbl)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.ScndNumBox)
        Me.Controls.Add(Me.FirstNumBox)
        Me.Controls.Add(Me.ScndNumLbl)
        Me.Controls.Add(Me.FirstNumLbl)
        Me.Name = "Form1"
        Me.Text = "Greatest Common Denominator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNumLbl As Label
    Friend WithEvents ScndNumLbl As Label
    Friend WithEvents FirstNumBox As TextBox
    Friend WithEvents ScndNumBox As TextBox
    Friend WithEvents CalcButton As Button
    Friend WithEvents AnswerLbl As Label
    Friend WithEvents AnswerBox As TextBox
End Class
