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
        Me.CalcButton.Location = New System.Drawing.Point(136, 149)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 4
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 292)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.ScndNumBox)
        Me.Controls.Add(Me.FirstNumBox)
        Me.Controls.Add(Me.ScndNumLbl)
        Me.Controls.Add(Me.FirstNumLbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNumLbl As Label
    Friend WithEvents ScndNumLbl As Label
    Friend WithEvents FirstNumBox As TextBox
    Friend WithEvents ScndNumBox As TextBox
    Friend WithEvents CalcButton As Button
End Class
