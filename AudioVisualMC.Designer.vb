<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AudioVisualMC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AudioVisualMC))
        Me.ShortSD = New System.Windows.Forms.Label()
        Me.LongSD = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.UserInput = New System.Windows.Forms.TextBox()
        Me.Representation = New System.Windows.Forms.Label()
        Me.kConstant = New System.Windows.Forms.Timer(Me.components)
        Me.StartGraphic = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShortSD
        '
        Me.ShortSD.AutoSize = True
        Me.ShortSD.Location = New System.Drawing.Point(386, 170)
        Me.ShortSD.Name = "ShortSD"
        Me.ShortSD.Size = New System.Drawing.Size(32, 13)
        Me.ShortSD.TabIndex = 0
        Me.ShortSD.Text = "Short"
        '
        'LongSD
        '
        Me.LongSD.AutoSize = True
        Me.LongSD.Location = New System.Drawing.Point(386, 136)
        Me.LongSD.Name = "LongSD"
        Me.LongSD.Size = New System.Drawing.Size(31, 13)
        Me.LongSD.TabIndex = 1
        Me.LongSD.Text = "Long"
        '
        'CloseButton
        '
        Me.CloseButton.AutoSize = True
        Me.CloseButton.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Gray
        Me.CloseButton.Location = New System.Drawing.Point(10, 340)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(48, 16)
        Me.CloseButton.TabIndex = 10
        Me.CloseButton.Text = "Close"
        '
        'UserInput
        '
        Me.UserInput.Location = New System.Drawing.Point(103, 40)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.Size = New System.Drawing.Size(277, 20)
        Me.UserInput.TabIndex = 11
        '
        'Representation
        '
        Me.Representation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Representation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Representation.Location = New System.Drawing.Point(103, 78)
        Me.Representation.Name = "Representation"
        Me.Representation.Size = New System.Drawing.Size(277, 200)
        Me.Representation.TabIndex = 12
        '
        'kConstant
        '
        Me.kConstant.Interval = 650
        '
        'StartGraphic
        '
        Me.StartGraphic.AutoSize = True
        Me.StartGraphic.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartGraphic.ForeColor = System.Drawing.Color.White
        Me.StartGraphic.Location = New System.Drawing.Point(103, 299)
        Me.StartGraphic.Name = "StartGraphic"
        Me.StartGraphic.Size = New System.Drawing.Size(48, 18)
        Me.StartGraphic.TabIndex = 72
        Me.StartGraphic.Text = "Start"
        Me.StartGraphic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(203, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(248, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(302, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(347, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(409, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'AudioVisualMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartGraphic)
        Me.Controls.Add(Me.Representation)
        Me.Controls.Add(Me.UserInput)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.LongSD)
        Me.Controls.Add(Me.ShortSD)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 400)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "AudioVisualMC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Audio/Visual Morse Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShortSD As Label
    Friend WithEvents LongSD As Label
    Friend WithEvents CloseButton As Label
    Friend WithEvents UserInput As TextBox
    Friend WithEvents Representation As Label
    Friend WithEvents StartGraphic As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents kConstant As Timer
End Class
