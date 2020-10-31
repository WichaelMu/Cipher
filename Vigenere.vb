Public Class Vigenere
    Dim Decision As Integer
    Dim Decrypter As Integer
    Dim PreEncrypt As String
    Dim ASCII As Integer
    Dim Number As Integer
    Dim Encrypted As String
    Dim KeyboardCheck As String
    Dim Check As Boolean
    Dim OscarKilo As Boolean
    Dim Repeater As Boolean

    Private Sub Reset() '   This is to reset the entire form to its default state in case the user enters, leaves then enters this Cipher.
        UserInput.Clear()   '   This resets the Plaintext to clear.
        CodeOutput.Clear()  '   This resets the Output to clear.

        Encode.ForeColor = Color.Red    '   This resets the colour for the "Encode" label / button.
        Decode.ForeColor = Color.Red    '   This resets the colour for the "Decode" label / button.

        Decision = 0    '   This resets the Decision to Encode or Decode to its neutral value.

        Display(False)  '   This sets the main elements in this form invisible.

        Check = False   '   This resets the error / warning message for the user, regarding the limitations of this Cipher.

        Encrypted = ""  '   This resets this unused variable.
        PreEncrypt = "" '   This resets the variable that stores the letter from the Plaintext array or the Decipher Key array.

        OscarKilo = False   '   This resets this unused variable.

        DecipherKey.Clear() '   This clears the Decipher Key.

        Repeater = True
    End Sub

    Private Sub UserClear_Click(sender As Object, e As EventArgs) Handles UserClear.Click
        UserInput.Clear()   '   This label / button clears the Plaintext.
    End Sub

    Private Sub CodeCopy_Click(sender As Object, e As EventArgs) Handles CodeCopy.Click
        Try
            My.Computer.Clipboard.SetText(CodeOutput.Text)  '   This label / button copies the Output onto the clipboard of the computer.
            MsgBox("Copied " + CodeOutput.Text + " To clipboard")   '   This is the confirmation message that is shown when the Output has been copied, including what was copied.
        Catch ex As Exception
            MsgBox("Nothing To copy.", , "Error")   '   If there is nothing to copy, a message will say so.
        End Try
    End Sub

    Private Sub Display(Condition As Boolean)   '   This sets the main elements to be visible when the Condition is met, or invisible when the Condition is met.
        If Condition = True Then
            UserInput.Visible = True
            CodeOutput.Visible = True
            UserClear.Visible = True
            CodeCopy.Visible = True
            Fresh.Enabled = True
            UserInput.Clear()
            CodeOutput.Clear()
            DecipherKey.Visible = True
            Message.Visible = True
        Else
            UserInput.Visible = False
            CodeOutput.Visible = False
            UserClear.Visible = False
            CodeCopy.Visible = False
            Fresh.Enabled = False
            UserInput.Clear()
            CodeOutput.Clear()
            DecipherKey.Visible = False
            Message.Visible = False
        End If
    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles Encode.Click
        Decision = 1    '   Decision 1 means the program is set to Encode Plaintext.
        Encode.ForeColor = Color.LimeGreen  '   This is a confirmation to the user that the program is set to Encode Plaintext.
        Decode.ForeColor = Color.Red    '   This is a confirmation that the program is not set to Decode.
        Display(True)   '   This sets the Condition to display the main elements to true; making those main elements visible.

        '#IGNORE DecipherKey.Clear()
    End Sub

    Private Sub Decode_Click(sender As Object, e As EventArgs) Handles Decode.Click
        Decision = 2    '   Decision 2 means the program is set to Decode.
        Decode.ForeColor = Color.LimeGreen  '   This is a confirmation to the user that the program is set to Decode.
        Encode.ForeColor = Color.Red  '   This is a confirmation that the program is not set to Encode.
        Display(True)   '   This sets the Condition to display the main elements to true; making those main elements visible.

        '#IGNORE DecipherKey.Clear()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Reset() '   When the BACK label / button is clicked, the form will reset to its default state.
        Main.Show() '   Shows the landing Menu.
        Me.Hide()   '   Hides this Cipher.
    End Sub

    Private Sub Vigenere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset() '   When this Cipher loads, it will reset everything to its default state.
    End Sub

    Private Sub Vigenere_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Reset() '   When the Cipher is closed, the Cipher will reset.
        Me.Hide()   '   When the Cipher is closed, the Cipher will hide itself.
        Main.Show() '   When the Cipher is closed, the main Menu will show.
    End Sub

    Private Sub VigenereLogic() '   This is the main logic for the Vigenère Cipher.

        PreEncrypt = "" '   This is a variable that stores the letter from the array.
        CodeOutput.Clear()  '   This constantly clearas the Ciphertext.
        Decrypter = 0

        If DecipherKey.TextLength = 0 Then  '   Checks if the Decipher Key is not filled with 2 or more letters.
            MsgBox("Fill in the Decipher Key.") '   The error message telling the user to input more than 2 letters into the Decipher Key.
            UserInput.ReadOnly = True   '   Sets the Plaintext input to readonly - denying the user to enter Plaintext that would cause the program to crash.
        End If

        If Decision = 1 Then    '   Decision 1 means the program is Encoding.

            Try ' FOR ENCRYPT   /////////////////////////////////
                For Indexx As Integer = 0 To UserInput.Text.Length - 1  '   Minus 1 beacuse the Decipher Key will always Encode everything + 1 of the Plaintext, for some reason.
                    If Decrypter = DecipherKey.Text.Length Then '   If the length of the Decipher Key is 0, then the program will not run and the index for the array will be reset to 0.
                        Decrypter = 0
                    End If

                    If Char.IsLetter(DecipherKey.Text(Decrypter)) Then  '   Checks if the letters of the DecipherKey contains only letters.

                        If UserInput.Text(Indexx) <> " " And Char.IsLetter(UserInput.Text(Indexx)) Then '   Checks if the letter in the Plaintext is not a space and it is a letter.
                            PreEncrypt += DecipherKey.Text(Decrypter)   '   To add the letter in Decipher Key if the Plaintext is a letter.
                            Decrypter += 1  '   Increments the Index for the Decipher Key.
                        Else
                            PreEncrypt += UserInput.Text(Indexx)    '   If the Plaintext character is a SPACE and is not a letter, the program will retain the character and ignore it, therefore not Encoding it.
                        End If
                    Else
                        Decrypter += 1  '   To skip the character in DecipherKey if it is not a letter.
                        Indexx -= 1 '   If the Decipher Key is not a letter, the program will skip the character in Plaintext, not Encoding it.

                        If Repeater = True Then '   This ensures the notification shows only once, unless the program is reset.
                            MsgBox("Ensure there is at least 1 letter in the Decipher Key.")    '   This is the notification message to warn that there should be at least 1 letter in the Decipher Key.
                            Repeater = False    '   This turns off the notification, unless the program is reset.
                        End If

                        If Decrypter >= DecipherKey.Text.Length Then    '   Checks if the index for the Decipher Key has exceeded the length of the Decipher Key; if so, the index will reset to 0 and continue the Encoding process.
                            Decrypter = 0
                        End If
                    End If
                Next

                For Indecks As Integer = 0 To UserInput.Text.Length - 1 '   Minus 1 beacuse the Decipher Key will always Encode everything + 1 of the Plaintext, for some reason.

                    If Char.IsLetter(UserInput.Text(Indecks)) Then  '   Checks if the index character of Plaintext is a letter; if so, the program moves on.
                        If Char.IsLower(PreEncrypt(Indecks)) Then   '   Because this Cipher works with the ASCII values, checks are put in place to check if the character in Plaintext is a lowercase.
                            Number = Asc(PreEncrypt(Indecks)) - 97
                        Else
                            If Char.IsUpper(PreEncrypt(Indecks)) Then   '   Because this Cipher works with the ASCII values, checks are put in place to check if the character in Plaintext is a uppercase.
                                Number = Asc(PreEncrypt(Indecks)) - 65
                            End If

                            ASCII = Number + Asc(UserInput.Text(Indecks))   '   Because the ASCII values of uppercase and lowercase letters are different, they need to be added to the final ASCII value, so the character will output into the corresponding letter.
                        End If

                        If (ASCII > 122 And Char.IsLower(UserInput.Text(Indecks))) Or (ASCII > 90 And Char.IsUpper(UserInput.Text(Indecks))) Then    '   This checks if the ASCII value is over the end of the alphabet (past 'z' and 'Z') by checking the ASCII value that is calculated above.
                            ASCII -= 26 '   If the ASCII value is over the end of the alphabet, the ASCII value will subtract 26 to loop if back to 'a' or 'A'.
                        End If
                    Else
                        ASCII = Asc(UserInput.Text(Indecks))    '   If the index character of Plaintext is not a letter, the program will retain its character. E.g. if the character is a SPACE, the output will be a SPACE.
                    End If
                    CodeOutput.Text += Chr(ASCII)   '   Appends the Character value of the ASCII variable to the Output.
                Next
            Catch ex As Exception
                '   There is nothing here because, for some reason, it always shows the error message. However, this needs to be here to stop the program from crashing.
            End Try

        Else ' FOR DECRYPT  /////////////////////////////////
            '   /////////////////////////////////   MOST OF THE CODE IS EITHER THE SAME AS ENCRYPT ABOVE, OR REVERSED   /////////////////////////////////
            '   /////////////////////////////////   PLAINTEXT IS THE ENCODED MESSAGE; CIPHERTEXT    /////////////////////////////////

            Try
                For Indexx As Integer = 0 To UserInput.Text.Length - 1  '   Minus 1 beacuse the Decipher Key will always Decode everything + 1 of the Plaintext, for some reason.
                    If Decrypter = DecipherKey.Text.Length Then '   If the length of the Decipher Key is 0, then the program will not run and the index for the array will be reset to 0.
                        Decrypter = 0
                    End If

                    If Char.IsLetter(DecipherKey.Text(Decrypter)) Then  '   Checks if the letters of the DecipherKey contains only letters.
                        If Asc(UserInput.Text(Indexx)) <> 32 And Char.IsLetter(UserInput.Text(Indexx)) Then '   Checks if the letter in the Plaintext is not a space and it is a letter.
                            PreEncrypt += DecipherKey.Text(Decrypter)   '   To add the letter in Decipher Key if the Plaintext is a letter.
                            Decrypter += 1  '   Increments the Index for the Decipher Key.
                        Else
                            PreEncrypt += UserInput.Text(Indexx)    '   If the Plaintext character is a SPACE and is not a letter, the program will retain the character and ignore it, therefore not Decoding it.
                        End If
                    Else
                        Decrypter += 1  '   To skip the character in Decipher Key if it is not a letter.
                        Indexx -= 1 '   If the Decipher Key is not a letter, the program will skip the character in Plaintext, not Decoding it.

                        If Repeater = True Then
                            MsgBox("Ensure there is at least 1 letter in the Decipher Key.")
                            Repeater = False
                        End If

                        If Decrypter >= DecipherKey.Text.Length Then    '   Checks if the index for the Decipher Key has exceeded the length of the Decipher Key; if so, the index will reset to 0 and continue the Decoding process.
                            Decrypter = 0
                        End If
                    End If
                Next

                For Indecks As Integer = 0 To UserInput.Text.Length - 1 '   Minus 1 beacuse the Decipher Key will always Encode everything + 1 of the Plaintext, for some reason.

                    If Char.IsLetter(UserInput.Text(Indecks)) Then  '   Checks if the index character of Plaintext is a letter; if so, the program moves on.
                        If Char.IsLower(PreEncrypt(Indecks)) Then   '   Because this Cipher works with the ASCII values, checks are put in place to check if the character in Plaintext is a lowercase.
                            Number = Asc(PreEncrypt(Indecks)) - 97 'Asc("a")
                        Else
                            If Char.IsUpper(PreEncrypt(Indecks)) Then   '   Because this Cipher works with the ASCII values, checks are put in place to check if the character in Plaintext is a uppercase.
                                Number = Asc(PreEncrypt(Indecks)) - 65 'Asc("A")
                            End If
                        End If

                        ASCII = 26 - Number + Asc(UserInput.Text(Indecks))   '   Because the ASCII values of uppercase and lowercase letters are different, they need to be subtracted to the final ASCII value, so the character will Decode into its corresponding letter.

                        If (ASCII > 122 And Char.IsLower(UserInput.Text(Indecks))) Or (ASCII > 90 And Char.IsUpper(UserInput.Text(Indecks))) Then    '   This checks if the ASCII value is over the end of the alphabet (past 'z' and 'Z') by checking the ASCII value that is calculated above.
                            ASCII -= 26 '   If the ASCII value is over the end of the alphabet, the ASCII value will subtract 26 to loop if back to 'a' or 'A'.
                        End If
                    Else
                        ASCII = Asc(UserInput.Text(Indecks))    '   If the index character of Plaintext is not a letter, the program will retain its character. E.g. if the character is a SPACE, the output will be a SPACE.
                    End If
                    CodeOutput.Text += Chr(ASCII)   '   Appends the Character value of the ASCII variable to the Output.
                Next
            Catch ex As Exception
                '   There is nothing here because, for some reason, it always shows the error message. However, this needs to be here to stop the program from crashing.
            End Try
        End If
    End Sub

    Private Sub UserInput_TextChanged(sender As Object, e As EventArgs) Handles UserInput.TextChanged   '   When Plaintext has been modified, the program will run the logic for the Vigenère Cipher.
        UserInput.Focus()   '   Maintains the computer's insertion point on the Plaintext.

        VigenereLogic() '   Calls on the Logic of the Vigenère Cipher.
    End Sub

    Private Sub DecipherKey_TextChanged(sender As Object, e As EventArgs) Handles DecipherKey.TextChanged
        If DecipherKey.TextLength > 1 Then  '   This is a check to ensure if the DecipherKey contains more than 1 letter.
            UserInput.ReadOnly = False  '   This allows the Plaintext to be modified if the DecipherKey contains more than 1 letter.
            'If UserInput.Text = "Fill in the Decipher Key." Then
            'Else
            '  UserInput.Clear()   '   This will clear the Plaintext.
            'End If
            DecipherKey.Focus() '   This puts focus on the DecipherKey textbox.

            VigenereLogic()
        End If
    End Sub

    Private Sub Vigenere_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) > 1 Then  '   Checks for a keyboard input to warn the user the limitations of this cipher.
            KeyboardCheck = e.KeyChar
        End If

        '#IGNORE If KeyboardCheck = " " Or KeyboardCheck = "1" Or KeyboardCheck = "2" Or KeyboardCheck = "3" Or KeyboardCheck = "4" Or KeyboardCheck = "5" Or KeyboardCheck = "6" Or KeyboardCheck = "7" Or KeyboardCheck = "8" Or KeyboardCheck = "9" Or KeyboardCheck = "0" And Check = False Then

        If KeyboardCheck <> "A" And KeyboardCheck <> "B" And KeyboardCheck <> "C" And KeyboardCheck <> "D" And KeyboardCheck <> "E" And KeyboardCheck <> "F" And KeyboardCheck <> "G" And KeyboardCheck <> "H" And KeyboardCheck <> "I" And KeyboardCheck <> "J" And KeyboardCheck <> "K" And KeyboardCheck <> "L" And KeyboardCheck <> "M" And KeyboardCheck <> "N" And KeyboardCheck <> "O" And KeyboardCheck <> "P" And KeyboardCheck <> "Q" And KeyboardCheck <> "R" And KeyboardCheck <> "S" And KeyboardCheck <> "T" And KeyboardCheck <> "U" And KeyboardCheck <> "V" And KeyboardCheck <> "W" And KeyboardCheck <> "X" And KeyboardCheck <> "Y" And KeyboardCheck <> "Z" And KeyboardCheck <> "a" And KeyboardCheck <> "b" And KeyboardCheck <> "c" And KeyboardCheck <> "d" And KeyboardCheck <> "e" And KeyboardCheck <> "f" And KeyboardCheck <> "g" And KeyboardCheck <> "h" And KeyboardCheck <> "i" And KeyboardCheck <> "j" And KeyboardCheck <> "k" And KeyboardCheck <> "l" And KeyboardCheck <> "m" And KeyboardCheck <> "n" And KeyboardCheck <> "o" And KeyboardCheck <> "p" And KeyboardCheck <> "q" And KeyboardCheck <> "r" And KeyboardCheck <> "s" And KeyboardCheck <> "t" And KeyboardCheck <> "u" And KeyboardCheck <> "v" And KeyboardCheck <> "w" And KeyboardCheck <> "x" And KeyboardCheck <> "y" And KeyboardCheck <> "z" And KeyboardCheck <> " " And Asc(KeyboardCheck) <> 8 And Asc(KeyboardCheck) <> 22 Then '   This checks if the user inputs a character that is unsupported by this cipher; numbers, spaces, punctuation and special symbols. The code 'Asc(KeyboardCheck) <> 8' was put in place because if the user makes a mistake when typing the Decipher Key, or when typing the Plaintext, and when the BASCKSPACE button is pressed, this error message will show; it isn't supposed to. This code checks if BACKSPACE has been pressed by checking BACKSPACE's ASCII value, which is 8. /////////////////////////The code 'Asc(KeyboardCheck) <> 22' was put in place because if the user presses CTRL + V when pasting. When the CTRL + V is pressed, this error message will show; it isn't supposed to. This code checks if CTRL + V has been pressed by checking the ASCII value for CTRL + V, which is 22.
            If Check = False Then   '   This ensures the error message shows only once.
                Check = True   '   This is a boolean that ensures the error message only gets shown once throughout the cipher, unless it is restarted.
                MsgBox("The Vigenère cipher will ignore any numbers, spaces, special characters and punctuation.")  '   This is the message to warn the user regarding the limitations of this cipher.
            End If
        End If
    End Sub
End Class