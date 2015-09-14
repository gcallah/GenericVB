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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MsgBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'FirstNumLbl
        '
        Me.FirstNumLbl.AutoSize = True
        Me.FirstNumLbl.Location = New System.Drawing.Point(33, 41)
        Me.FirstNumLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FirstNumLbl.Name = "FirstNumLbl"
        Me.FirstNumLbl.Size = New System.Drawing.Size(67, 13)
        Me.FirstNumLbl.TabIndex = 0
        Me.FirstNumLbl.Text = "First number:"
        '
        'ScndNumLbl
        '
        Me.ScndNumLbl.AutoSize = True
        Me.ScndNumLbl.Location = New System.Drawing.Point(33, 75)
        Me.ScndNumLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScndNumLbl.Name = "ScndNumLbl"
        Me.ScndNumLbl.Size = New System.Drawing.Size(85, 13)
        Me.ScndNumLbl.TabIndex = 1
        Me.ScndNumLbl.Text = "Second number:"
        '
        'FirstNumBox
        '
        Me.FirstNumBox.Location = New System.Drawing.Point(131, 41)
        Me.FirstNumBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstNumBox.Name = "FirstNumBox"
        Me.FirstNumBox.Size = New System.Drawing.Size(76, 20)
        Me.FirstNumBox.TabIndex = 2
        '
        'ScndNumBox
        '
        Me.ScndNumBox.Location = New System.Drawing.Point(131, 75)
        Me.ScndNumBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ScndNumBox.Name = "ScndNumBox"
        Me.ScndNumBox.Size = New System.Drawing.Size(76, 20)
        Me.ScndNumBox.TabIndex = 3
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(109, 119)
        Me.CalcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(72, 24)
        Me.CalcButton.TabIndex = 4
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'AnswerLbl
        '
        Me.AnswerLbl.AutoSize = True
        Me.AnswerLbl.Location = New System.Drawing.Point(35, 163)
        Me.AnswerLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AnswerLbl.Name = "AnswerLbl"
        Me.AnswerLbl.Size = New System.Drawing.Size(45, 13)
        Me.AnswerLbl.TabIndex = 5
        Me.AnswerLbl.Text = "Answer:"
        '
        'AnswerBox
        '
        Me.AnswerBox.Location = New System.Drawing.Point(131, 163)
        Me.AnswerBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AnswerBox.Name = "AnswerBox"
        Me.AnswerBox.Size = New System.Drawing.Size(76, 20)
        Me.AnswerBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Message:"
        '
        'MsgBox
        '
        Me.MsgBox.Location = New System.Drawing.Point(131, 210)
        Me.MsgBox.Name = "MsgBox"
        Me.MsgBox.ReadOnly = True
        Me.MsgBox.Size = New System.Drawing.Size(200, 20)
        Me.MsgBox.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(370, 266)
        Me.Controls.Add(Me.MsgBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AnswerBox)
        Me.Controls.Add(Me.AnswerLbl)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.ScndNumBox)
        Me.Controls.Add(Me.FirstNumBox)
        Me.Controls.Add(Me.ScndNumLbl)
        Me.Controls.Add(Me.FirstNumLbl)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents MsgBox As TextBox
End Class
