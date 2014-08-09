<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
    Me.components = New System.ComponentModel.Container()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.Label1 = New System.Windows.Forms.Label()
    Me.chkAutoStart = New System.Windows.Forms.CheckBox()
    Me.SuspendLayout()
    '
    'Timer1
    '
    Me.Timer1.Enabled = True
    Me.Timer1.Interval = 5000
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(142, 45)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "The screensaver should not start while this application is running."
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'chkAutoStart
    '
    Me.chkAutoStart.AutoSize = True
    Me.chkAutoStart.Enabled = False
    Me.chkAutoStart.Location = New System.Drawing.Point(15, 57)
    Me.chkAutoStart.Name = "chkAutoStart"
    Me.chkAutoStart.Size = New System.Drawing.Size(143, 17)
    Me.chkAutoStart.TabIndex = 1
    Me.chkAutoStart.Text = "Run on Windows startup"
    Me.chkAutoStart.UseVisualStyleBackColor = True
    '
    'Main
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(166, 87)
    Me.Controls.Add(Me.chkAutoStart)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Main"
    Me.Text = "ScreenAlive"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents chkAutoStart As System.Windows.Forms.CheckBox

End Class
