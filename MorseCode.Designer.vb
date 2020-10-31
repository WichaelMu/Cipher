﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SMorseCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMorseCode))
        Me.BackButton = New System.Windows.Forms.Label()
        Me.CodeCopy = New System.Windows.Forms.Label()
        Me.UserClear = New System.Windows.Forms.Label()
        Me.CodeOutput = New System.Windows.Forms.TextBox()
        Me.UserInput = New System.Windows.Forms.TextBox()
        Me.Encode = New System.Windows.Forms.Label()
        Me.Decode = New System.Windows.Forms.Label()
        Me.Fresh = New System.Windows.Forms.Timer(Me.components)
        Me.AV = New System.Windows.Forms.Label()
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
        Me.BackButton.TabIndex = 9
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
        Me.CodeCopy.TabIndex = 13
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
        Me.UserClear.TabIndex = 12
        Me.UserClear.Text = "Clear"
        Me.UserClear.Visible = False
        '
        'CodeOutput
        '
        Me.CodeOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeOutput.Location = New System.Drawing.Point(83, 162)
        Me.CodeOutput.Multiline = True
        Me.CodeOutput.Name = "CodeOutput"
        Me.CodeOutput.ReadOnly = True
        Me.CodeOutput.Size = New System.Drawing.Size(316, 145)
        Me.CodeOutput.TabIndex = 11
        Me.CodeOutput.Visible = False
        '
        'UserInput
        '
        Me.UserInput.Location = New System.Drawing.Point(83, 123)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.Size = New System.Drawing.Size(316, 20)
        Me.UserInput.TabIndex = 10
        Me.UserInput.Visible = False
        '
        'Encode
        '
        Me.Encode.AutoSize = True
        Me.Encode.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Encode.ForeColor = System.Drawing.Color.Red
        Me.Encode.Location = New System.Drawing.Point(80, 45)
        Me.Encode.Name = "Encode"
        Me.Encode.Size = New System.Drawing.Size(72, 18)
        Me.Encode.TabIndex = 14
        Me.Encode.Text = "Encode"
        '
        'Decode
        '
        Me.Decode.AutoSize = True
        Me.Decode.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Decode.ForeColor = System.Drawing.Color.Red
        Me.Decode.Location = New System.Drawing.Point(325, 45)
        Me.Decode.Name = "Decode"
        Me.Decode.Size = New System.Drawing.Size(74, 18)
        Me.Decode.TabIndex = 15
        Me.Decode.Text = "Decode"
        '
        'Fresh
        '
        Me.Fresh.Interval = 10
        '
        'AV
        '
        Me.AV.AutoSize = True
        Me.AV.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AV.ForeColor = System.Drawing.Color.Black
        Me.AV.Location = New System.Drawing.Point(156, 320)
        Me.AV.Name = "AV"
        Me.AV.Size = New System.Drawing.Size(185, 18)
        Me.AV.TabIndex = 72
        Me.AV.Text = "Audio Representation"
        Me.AV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AV.Visible = False
        '
        'SMorseCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.AV)
        Me.Controls.Add(Me.Decode)
        Me.Controls.Add(Me.Encode)
        Me.Controls.Add(Me.CodeCopy)
        Me.Controls.Add(Me.UserClear)
        Me.Controls.Add(Me.CodeOutput)
        Me.Controls.Add(Me.UserInput)
        Me.Controls.Add(Me.BackButton)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 400)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "SMorseCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morse Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Label
    Friend WithEvents CodeCopy As Label
    Friend WithEvents UserClear As Label
    Friend WithEvents CodeOutput As TextBox
    Friend WithEvents UserInput As TextBox
    Friend WithEvents Encode As Label
    Friend WithEvents Decode As Label
    Friend WithEvents Fresh As Timer
    Friend WithEvents AV As Label
End Class
