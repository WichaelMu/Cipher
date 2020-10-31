<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlphabeticalSubstitution
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlphabeticalSubstitution))
        Me.BackButton = New System.Windows.Forms.Label()
        Me.CodeCopy = New System.Windows.Forms.Label()
        Me.UserClear = New System.Windows.Forms.Label()
        Me.CodeOutput = New System.Windows.Forms.TextBox()
        Me.UserInput = New System.Windows.Forms.TextBox()
        Me.Decode = New System.Windows.Forms.Label()
        Me.Encode = New System.Windows.Forms.Label()
        Me.SetModPlugboard = New System.Windows.Forms.Label()
        Me.Message = New System.Windows.Forms.Label()
        Me.ConfirmCheck = New System.Windows.Forms.Label()
        Me.Fresh = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.AutoSize = True
        Me.BackButton.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.Gray
        Me.BackButton.Location = New System.Drawing.Point(10, 340)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(43, 16)
        Me.BackButton.TabIndex = 17
        Me.BackButton.Text = "Back"
        '
        'CodeCopy
        '
        Me.CodeCopy.AutoSize = True
        Me.CodeCopy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeCopy.ForeColor = System.Drawing.Color.Black
        Me.CodeCopy.Location = New System.Drawing.Point(405, 291)
        Me.CodeCopy.Name = "CodeCopy"
        Me.CodeCopy.Size = New System.Drawing.Size(41, 16)
        Me.CodeCopy.TabIndex = 14
        Me.CodeCopy.Text = "Copy"
        Me.CodeCopy.Visible = False
        '
        'UserClear
        '
        Me.UserClear.AutoSize = True
        Me.UserClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserClear.ForeColor = System.Drawing.Color.Black
        Me.UserClear.Location = New System.Drawing.Point(405, 124)
        Me.UserClear.Name = "UserClear"
        Me.UserClear.Size = New System.Drawing.Size(41, 16)
        Me.UserClear.TabIndex = 13
        Me.UserClear.Text = "Clear"
        Me.UserClear.Visible = False
        '
        'CodeOutput
        '
        Me.CodeOutput.Location = New System.Drawing.Point(83, 162)
        Me.CodeOutput.Multiline = True
        Me.CodeOutput.Name = "CodeOutput"
        Me.CodeOutput.ReadOnly = True
        Me.CodeOutput.Size = New System.Drawing.Size(316, 145)
        Me.CodeOutput.TabIndex = 12
        Me.CodeOutput.Visible = False
        '
        'UserInput
        '
        Me.UserInput.Location = New System.Drawing.Point(83, 123)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.Size = New System.Drawing.Size(316, 20)
        Me.UserInput.TabIndex = 11
        Me.UserInput.Visible = False
        '
        'Decode
        '
        Me.Decode.AutoSize = True
        Me.Decode.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Decode.ForeColor = System.Drawing.Color.Red
        Me.Decode.Location = New System.Drawing.Point(325, 45)
        Me.Decode.Name = "Decode"
        Me.Decode.Size = New System.Drawing.Size(74, 18)
        Me.Decode.TabIndex = 10
        Me.Decode.Text = "Decode"
        '
        'Encode
        '
        Me.Encode.AutoSize = True
        Me.Encode.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Encode.ForeColor = System.Drawing.Color.Red
        Me.Encode.Location = New System.Drawing.Point(80, 45)
        Me.Encode.Name = "Encode"
        Me.Encode.Size = New System.Drawing.Size(72, 18)
        Me.Encode.TabIndex = 9
        Me.Encode.Text = "Encode"
        '
        'SetModPlugboard
        '
        Me.SetModPlugboard.AutoSize = True
        Me.SetModPlugboard.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetModPlugboard.ForeColor = System.Drawing.Color.Black
        Me.SetModPlugboard.Location = New System.Drawing.Point(177, 320)
        Me.SetModPlugboard.Name = "SetModPlugboard"
        Me.SetModPlugboard.Size = New System.Drawing.Size(122, 18)
        Me.SetModPlugboard.TabIndex = 71
        Me.SetModPlugboard.Text = "Set Plugboard"
        Me.SetModPlugboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SetModPlugboard.Visible = False
        '
        'Message
        '
        Me.Message.AutoSize = True
        Me.Message.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Message.Location = New System.Drawing.Point(80, 102)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(219, 13)
        Me.Message.TabIndex = 72
        Me.Message.Text = "Set the Plugboard with no duplicates."
        Me.Message.Visible = False
        '
        'ConfirmCheck
        '
        Me.ConfirmCheck.AutoSize = True
        Me.ConfirmCheck.Location = New System.Drawing.Point(433, 343)
        Me.ConfirmCheck.Name = "ConfirmCheck"
        Me.ConfirmCheck.Size = New System.Drawing.Size(39, 13)
        Me.ConfirmCheck.TabIndex = 73
        Me.ConfirmCheck.Text = "Label1"
        Me.ConfirmCheck.Visible = False
        '
        'Fresh
        '
        Me.Fresh.Enabled = True
        Me.Fresh.Interval = 10
        '
        'AlphabeticalSubstitution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.ConfirmCheck)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.SetModPlugboard)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CodeCopy)
        Me.Controls.Add(Me.UserClear)
        Me.Controls.Add(Me.CodeOutput)
        Me.Controls.Add(Me.UserInput)
        Me.Controls.Add(Me.Decode)
        Me.Controls.Add(Me.Encode)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlphabeticalSubstitution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AlphabeticalSubstitution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As Label
    Friend WithEvents CodeCopy As Label
    Friend WithEvents UserClear As Label
    Friend WithEvents CodeOutput As TextBox
    Friend WithEvents UserInput As TextBox
    Friend WithEvents Decode As Label
    Friend WithEvents Encode As Label
    Friend WithEvents SetModPlugboard As Label
    Friend WithEvents Message As Label
    Friend WithEvents ConfirmCheck As Label
    Friend WithEvents Fresh As Timer
End Class
