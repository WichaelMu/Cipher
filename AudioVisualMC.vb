Public Class AudioVisualMC
    'Dim Interval As Integer
    Dim Tap As String
    'Dim Speed As Integer
    Dim Dash As Integer
    Dim Dot As Integer

    Dim Visual As Integer

    Private Sub ShortSD_Click(sender As Object, e As EventArgs) Handles ShortSD.Click
        My.Computer.Audio.Play(My.Resources._Short, AudioPlayMode.Background)
    End Sub

    Private Sub LongSD_Click(sender As Object, e As EventArgs) Handles LongSD.Click
        My.Computer.Audio.Play(My.Resources._Long, AudioPlayMode.Background)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Reset()
        Me.Hide()
    End Sub

    Private Sub Reset()
        UserInput.Clear()

        Representation.Visible = False

        kConstant.Enabled = False

        'Dash = 1

        'Speed = 0
        'Interval = 0
        Dot = 0
        Dash = 0
        Tap = ""

    End Sub

    Private Sub AudioVisualMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("You have activated the experimental feature of Morse Code, this shows the attempt made to represent the Morse Code visually, unfortunately, it does not work and only the audio works.", , "Hidden Feature.")
        MsgBox("Press CTRL + V to Paste the Morse Code.")

        Reset()
    End Sub

    'Private Sub RunGraphic(Plaintext As String, Instruction As Boolean)
    'Representation.Visible = False

    'If Instruction = True Then
    'If Interval = 0 Then
    'Representation.Visible = True
    'If Interval = 5 Then
    'Representation.Visible = False
    'End If
    'End If
    'End If

    'If Instruction = False Then
    'If Interval = 0 Then
    'Representation.Visible = True

    'If Interval = 10 Then
    'Representation.Visible = False
    'End If
    'End If
    'End If

    'End Sub

    'Private Sub SubGraphic(Instruction As Boolean)

    'End Sub

    'Private Sub ShortPulse()
    'Do Until Dash = 10
    'Representation.Visible = True

    'If Dash = 10 Then
    'Representation.Visible = False

    'End If
    'Loop
    'End Sub

    'Private Sub LongPulse()
    'Do Until Dash = 25
    'Representation.Visible = True

    'If Dash = 25 Then
    'Representation.Visible = False

    'End If
    'Loop
    'End Sub

    'Private Sub kConstant_Tick(sender As Object, e As EventArgs) Handles kConstant.Tick
    'UserInput.Focus()

    'Interval = Interval + 1

    'Label1.Text = Interval
    'Label2.Text = Tap
    'Label3.Text = Dash
    'Label4.Text = Dot

    'Dot = 0

    'Dash = Dash + 1

    'For Index As Integer = 0 To UserInput.Text.Length - 1


    'If Interval = 25 Then
    '   Interval = 0
    'End If

    'If Dash > UserInput.Text.Length Then
    '   Dash = 0
    'End If
    '    End Sub

    'Private Sub Split_Tick(sender As Object, e As EventArgs)    '   nothing
    'Dot = Dot + 1
    '    End Sub

    'Private Sub Gap_Tick(sender As Object, e As EventArgs)  '   nothing

    'Speed = Speed + 1

    'If Speed = 20 Then
    'Speed = 0
    'End If

    'Label5.Text = Speed
    'End Sub

    Private Sub StartGraphic_Click(sender As Object, e As EventArgs) Handles StartGraphic.Click

        If UserInput.Text.Length = 0 Then
            MsgBox("Please paste a message in Morse Code")
        Else
            kConstant.Enabled = True
            Dot = 0

            Do Until Dot >= UserInput.Text.Length

                Dash = 0

                If Dot >= UserInput.Text.Length Then
                    Dot = 0
                End If

                Tap = UserInput.Text(Dot)

                If Tap = "." Then
                    'Visuals.Enabled = True
                    My.Computer.Audio.Play(My.Resources._Short, AudioPlayMode.WaitToComplete)
                    'ShortPulse()

                    'Do While Visual < 20

                    'Representation.Visible = True
                    'Visual = Visual + 1
                    'Loop

                    Representation.Visible = False
                End If

                If Tap = "-" Then
                    'Visuals.Enabled = True
                    My.Computer.Audio.Play(My.Resources._Long, AudioPlayMode.WaitToComplete)
                    'LongPulse()
                End If

                If Tap = " " Or Tap = "/" Then
                    My.Computer.Audio.Play(My.Resources.Space, AudioPlayMode.WaitToComplete)
                End If

                'If Tap = " " Then
                'Dot = Dot + 1
                'End If

                'Next

                Dot = Dot + 1

                If Dot >= UserInput.Text.Length Then
                    'MsgBox("End of Morse Code")
                    kConstant.Enabled = False
                    MsgBox("End of Message")
                End If

            Loop

        End If


    End Sub

    'Private Sub Visuals_Tick(sender As Object, e As EventArgs) Handles Visuals.Tick
    'Dash = Dash + 1

    'Label1.Text = Dash

    'If Dash = 26 Then
    'Dash = 0
    'End If
    'End Sub
End Class