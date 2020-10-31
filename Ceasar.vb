Public Class Caesar
    Dim Decoded As String
    Dim Check As String
    Dim Refresher As Integer
    Dim Decision As Integer
    Dim ASCII As Integer
    Dim KeyboardCheck As String
    Dim CheckKey As Boolean

    Private Sub Reset() '   This is to reset the entire form to its default state in case the user enters, leaves then enters this Cipher.
        UserInput.Clear()   '   This resets the Plaintext to clear.
        CodeOutput.Clear()  '   This resets the Output to clear.

        Encode.ForeColor = Color.Red    '   This resets the colour for the "Encode" label / button.
        Decode.ForeColor = Color.Red    '   This resets the colour for the "Decode" label / button.

        Decision = 0    '   This resets the Decision to Encode or Decode to its neutral value.

        Display(False)  '   This sets the main elements in this form invisible.

        Shift.Text = "0"    '   This resets the Cipher's 'Shift' value to 0.

        CheckKey = False    '   This enables the Check for any foreign characters, numbers, symbols or spaces.
    End Sub

    Private Sub UserClear_Click(sender As Object, e As EventArgs) Handles UserClear.Click
        UserInput.Clear()   '   This label / button clears the Plaintext.
    End Sub

    Private Sub CodeCopy_Click(sender As Object, e As EventArgs) Handles CodeCopy.Click
        Try
            My.Computer.Clipboard.SetText(CodeOutput.Text)  '   This label / button copies the Output onto the clipboard of the computer.
            MsgBox("Copied " + CodeOutput.Text + " to clipboard")   '   This is the confirmation message that is shown when the Output has been copied, including what was copied.
        Catch ex As Exception
            MsgBox("Nothing to copy.", , "Error")   '   If there is nothing to copy, a message will say so.
        End Try

    End Sub

    Private Sub Display(Condition As Boolean)   '   This sets the main elements to be visible when the Condition is met, or invisible when the Condition is met.
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
        Decision = 1    '   Decision 1 means the program is set to Encode Plaintext.
        Encode.ForeColor = Color.LimeGreen  '   This is a confirmation to the user that the program is set to Encode Plaintext.
        Decode.ForeColor = Color.Red    '   This is a confirmation that the program is not set to Decode.
        Display(True)   '   This sets the Condition to display the main elements to true; making those main elements visible.
    End Sub

    Private Sub Decode_Click(sender As Object, e As EventArgs) Handles Decode.Click
        Decision = 2    '   Decision 2 means the program is set to Decode.
        Decode.ForeColor = Color.LimeGreen  '   This is a confirmation to the user that the program is set to Decode.
        Encode.ForeColor = Color.Red  '   This is a confirmation that the program is not set to Encode.
        Display(True)   '   This sets the Condition to display the main elements to true; making those main elements visible.
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Reset() '   When the BACK label / button is clicked, the form will reset to its default state.
        Main.Show() '   Shows the landing form.
        Me.Hide()   '   Hides this form.
    End Sub

    Private Sub CaesarLogic()   '   When Plaintext has been modified, the program will run the logic for Caesar Cipher.
        UserInput.Focus()   '   This puts the focus of the insertion point onto the Plaintext textbox.

        CodeOutput.Clear()  '   This constantly clears the Output.

        Try
            If Decision = 1 Then    '   Sets the program to Encode.
                For Each letter As Char In UserInput.Text   '   Gets letter into an array of characters.
                    ASCII = Asc(letter) + Shift.Text    '   Sets the ASCII variable to the ASCII value of the letter and add the value of Shift.

                    If Char.IsLower(letter) Then    '   Checks if the letter is a lowercase letter.
                        If ASCII > 122 Then    '   Subtracts 26 from the ASCII value if the letter is a lowercase letter.
                            ASCII -= 26
                        End If
                        CodeOutput.Text += Chr(ASCII)   '   Outputs the character value after 26 has been subtracted from the letter.
                    Else
                        If Char.IsUpper(letter) Then    '   Checks if the letter is an uppercase letter.
                            If ASCII > 90 Then    '   Subtracts 26 from the ASCII value if the letter is an uppercase letter.
                                ASCII -= 26
                            End If
                            CodeOutput.Text += Chr(ASCII)   '   Outputs the character value after 26 has been subtracted from the letter.
                        End If
                    End If
                Next
            Else    '   Sets the program to Decode.
                For Each letter As Char In UserInput.Text   '   Gets letter into an array of characters.
                    ASCII = Asc(letter) + 26 - Shift.Text    '   Sets the ASCII variable to the ASCII value of the letter and add the value of Shift.

                    If Char.IsLower(letter) Then    '   Checks if the letter is a lowercase letter.
                        If ASCII > 122 Then    '   Subtracts 26 from the ASCII value if the letter is a lowercase letter.
                            ASCII -= 26
                        End If
                        CodeOutput.Text += Chr(ASCII)   '   Outputs the character value after 26 has been subtracted from the letter.
                    Else
                        If Char.IsUpper(letter) Then    '   Checks if the letter is an uppercase letter.
                            If ASCII > 90 Then    '   Subtracts 26 from the ASCII value if the letter is an uppercase letter.
                                ASCII -= 26
                            End If
                            CodeOutput.Text += Chr(ASCII)   '   Outputs the character value after 26 has been subtracted from the letter.
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            CodeOutput.Text = "Enter a Shift value between 0 And 26"    '   If, for some reason, the program fails to Encode or Decode the text, this message will show.
        End Try
    End Sub

    Private Sub Fresh_Tick(sender As Object, e As EventArgs) Handles Fresh.Tick
        CaesarLogic()   '   On every tick, every 10 milliseconds, the program will refresh the text, therefore constantly updating the Shift, Plaintext, Output and Encoded text so the program will operate without a delay.
    End Sub

    Private Sub Caesar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Reset() '   When the form is closed, the form will reset.
        Me.Hide()   '   When the form is closed, the form will hide itself.
        Main.Show() '   When the form is closed, the main form will show.
    End Sub

    Private Sub Caesar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset() '   When the form loads, the form will reset.
    End Sub

    Private Sub Caesar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) > 1 Then  '   Checks if there is a keyboard input.
            KeyboardCheck = e.KeyChar
        End If
        '   The Caesar Cipher cannot Encode or Decode foreign characters, special symbols, numbers or spaces. This is a check to notify the user if one of these forbidden characters have been entered.
        If KeyboardCheck = " " Or KeyboardCheck = "1" Or KeyboardCheck = "2" Or KeyboardCheck = "3" Or KeyboardCheck = "4" Or KeyboardCheck = "5" Or KeyboardCheck = "6" Or KeyboardCheck = "7" Or KeyboardCheck = "8" Or KeyboardCheck = "9" Or KeyboardCheck = "0" And CheckKey = False Then
            If CheckKey = False Then    '   The message will only be shown once, this boolean ensures that if the notification has been shown, it won't be shown again until the form has been reset.
                CheckKey = True '   This is the boolean that ensures this notification won't be shown again until the form resets.
                MsgBox("The Caesar cipher will ignore any spaces, numbers and symbols.")    '   This is the notification that will show if a forbidden character has been entered.
            End If
        End If
    End Sub
End Class