Public Class Caesar
    Dim Decoded As String
    Dim Check As String
    Dim Refresher As Integer
    Dim Decision As Integer
    Dim ASCII As Integer
    Dim KeyboardCheck As String
    Dim CheckKey As Boolean

    Private Sub Reset()
        UserInput.Clear()
        CodeOutput.Clear()

        Encode.ForeColor = Color.Red
        Decode.ForeColor = Color.Red

        Decision = 0

        Display(False)

        Shift.Text = "0"

        CheckKey = False
    End Sub

    Private Sub UserClear_Click(sender As Object, e As EventArgs) Handles UserClear.Click
        UserInput.Clear()
    End Sub

    Private Sub CodeCopy_Click(sender As Object, e As EventArgs) Handles CodeCopy.Click
        Try
            My.Computer.Clipboard.SetText(CodeOutput.Text)
            MsgBox("Copied " + CodeOutput.Text + " to clipboard")
        Catch ex As Exception
            MsgBox("Nothing to copy", , "Error")
        End Try

    End Sub

    Private Sub Display(Condition As Boolean)
        If Condition = True Then
            UserInput.Visible = True
            CodeOutput.Visible = True
            UserClear.Visible = True
            CodeCopy.Visible = True
            UserInput.Clear()
            CodeOutput.Clear()
            ShiftText.Visible = True
            Shift.Visible = True
            Fresh.Enabled = True
        Else
            UserInput.Visible = False
            CodeOutput.Visible = False
            UserClear.Visible = False
            CodeCopy.Visible = False
            UserInput.Clear()
            CodeOutput.Clear()
            ShiftText.Visible = False
            Shift.Visible = False
            Fresh.Enabled = False
            Shift.Text = 0
        End If
    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles Encode.Click
        Decision = 1
        Encode.ForeColor = Color.LimeGreen
        Decode.ForeColor = Color.Red
        Display(True)
    End Sub

    Private Sub Decode_Click(sender As Object, e As EventArgs) Handles Decode.Click
        Decision = 2
        Decode.ForeColor = Color.LimeGreen
        Encode.ForeColor = Color.Red
        Display(True)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Reset()
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub RefreshText()
        UserInput.Focus()

        CodeOutput.Clear()

        Try
            If Decision = 1 Then
                For Each letter As Char In UserInput.Text
                    ASCII = Asc(letter) + Shift.Text

                    If Char.IsLower(letter) Then
                        If ASCII > Asc("z") Then
                            ASCII -= 26
                        End If
                        CodeOutput.Text += Chr(ASCII)
                    Else
                        If Char.IsUpper(letter) Then
                            If ASCII > Asc("Z") Then
                                ASCII -= 26
                            End If
                            CodeOutput.Text += Chr(ASCII)
                        End If
                    End If
                Next
            Else
                For Each letter As Char In UserInput.Text
                    ASCII = Asc(letter) - Shift.Text

                    If Char.IsLower(letter) Then
                        If ASCII > Asc("z") Then
                            ASCII -= 26
                        End If
                        CodeOutput.Text += Chr(ASCII)
                    Else
                        If Char.IsUpper(letter) Then
                            If ASCII > Asc("Z") Then
                                ASCII -= 26
                            End If
                            CodeOutput.Text += Chr(ASCII)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            CodeOutput.Text = "Enter a Shift value between 0 And 26"
        End Try
    End Sub

    Private Sub Caesar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Reset()
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Fresh_Tick(sender As Object, e As EventArgs) Handles Fresh.Tick
        RefreshText()
    End Sub

    Private Sub Caesar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Caesar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) > 1 Then
            KeyboardCheck = e.KeyChar
        End If

        If KeyboardCheck = " " Or KeyboardCheck = "1" Or KeyboardCheck = "2" Or KeyboardCheck = "3" Or KeyboardCheck = "4" Or KeyboardCheck = "5" Or KeyboardCheck = "6" Or KeyboardCheck = "7" Or KeyboardCheck = "8" Or KeyboardCheck = "9" Or KeyboardCheck = "0" And CheckKey = False Then
            If CheckKey = False Then
                CheckKey = True
                MsgBox("The Caesar cipher will ignore any numbers and spaces.")
            End If
        End If
    End Sub
End Class