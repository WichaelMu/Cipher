Public Class Atbash
    Dim Decision As Integer
    Dim TranslateFrom As New Dictionary(Of String, String)
    Dim TranslateTo As New Dictionary(Of String, String)

    Private Sub Reset() '   This is to reset the entire form to its default state in case the user enters, leaves then enters this Cipher.
        UserInput.Clear()   '   This resets the Plaintext to clear.
        CodeOutput.Clear()  '   This resets the Output to clear.

        Encode.ForeColor = Color.Red    '   This resets the colour for the "Encode" label / button.
        Decode.ForeColor = Color.Red    '   This resets the colour for the "Decode" label / button.

        Decision = 0    '   This resets the Decision to Encode or Decode to its neutral value.

        Display(False)  '   This sets the main elements in this form invisible.

        Fresh.Enabled = False   '   This disables the timer. It is not in use and I don't know why it's here.
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
            UserInput.Clear()
            CodeOutput.Clear()
        Else
            UserInput.Visible = False
            CodeOutput.Visible = False
            UserClear.Visible = False
            CodeCopy.Visible = False
            UserInput.Clear()
            CodeOutput.Clear()
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
        Main.Show() '   Shows the landing Menu.
        Me.Hide()   '   Hides this Cipher.
    End Sub

    Private Sub Atbash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset() '   When this Cipher loads, it will reset everything to its default state.

        'This is the Atbash translation from English, punctuation and numbers in the format of <LETTER> | <PUNCTUATION> | <NUMBER>, <ATBASH>

        TranslateFrom.Add(" ", "9")
        TranslateFrom.Add(".", "8")
        TranslateFrom.Add(",", "7")
        TranslateFrom.Add("?", "6")
        TranslateFrom.Add("!", "5")
        TranslateFrom.Add("A", "4")
        TranslateFrom.Add("B", "3")
        TranslateFrom.Add("C", "2")
        TranslateFrom.Add("D", "1")
        TranslateFrom.Add("E", "0")
        TranslateFrom.Add("F", "Z")
        TranslateFrom.Add("G", "Y")
        TranslateFrom.Add("H", "X")
        TranslateFrom.Add("I", "W")
        TranslateFrom.Add("J", "V")
        TranslateFrom.Add("K", "U")
        TranslateFrom.Add("L", "T")
        TranslateFrom.Add("M", "S")
        TranslateFrom.Add("N", "R")
        TranslateFrom.Add("O", "Q")
        TranslateFrom.Add("P", "P")
        TranslateFrom.Add("Q", "O")
        TranslateFrom.Add("R", "N")
        TranslateFrom.Add("S", "M")
        TranslateFrom.Add("T", "L")
        TranslateFrom.Add("U", "K")
        TranslateFrom.Add("V", "J")
        TranslateFrom.Add("W", "I")
        TranslateFrom.Add("X", "H")
        TranslateFrom.Add("Y", "G")
        TranslateFrom.Add("Z", "F")

        TranslateFrom.Add("0", "E")
        TranslateFrom.Add("1", "D")
        TranslateFrom.Add("2", "C")
        TranslateFrom.Add("3", "B")
        TranslateFrom.Add("4", "A")
        TranslateFrom.Add("5", "!")
        TranslateFrom.Add("6", "?")
        TranslateFrom.Add("7", ",")
        TranslateFrom.Add("8", ".")
        TranslateFrom.Add("9", " ")

        'This is the Atbash translation from Atbash to English, puncutation and numbers in the format of <ATBASH>, <LETTER> | <PUNCTUATION> | <NUMBER>

        TranslateTo.Add("9", " ")
        TranslateTo.Add("8", ".")
        TranslateTo.Add("7", ",")
        TranslateTo.Add("6", "?")
        TranslateTo.Add("5", "!")
        TranslateTo.Add("4", "A")
        TranslateTo.Add("3", "B")
        TranslateTo.Add("2", "C")
        TranslateTo.Add("1", "D")
        TranslateTo.Add("0", "E")

        TranslateTo.Add("Z", "F")
        TranslateTo.Add("Y", "G")
        TranslateTo.Add("X", "H")
        TranslateTo.Add("W", "I")
        TranslateTo.Add("V", "J")
        TranslateTo.Add("U", "K")
        TranslateTo.Add("T", "L")
        TranslateTo.Add("S", "M")
        TranslateTo.Add("R", "N")
        TranslateTo.Add("Q", "O")
        TranslateTo.Add("P", "P")
        TranslateTo.Add("O", "Q")
        TranslateTo.Add("N", "R")
        TranslateTo.Add("M", "S")
        TranslateTo.Add("L", "T")
        TranslateTo.Add("K", "U")
        TranslateTo.Add("J", "V")
        TranslateTo.Add("I", "W")
        TranslateTo.Add("H", "X")
        TranslateTo.Add("G", "Y")
        TranslateTo.Add("F", "Z")
        TranslateTo.Add("E", "0")
        TranslateTo.Add("D", "1")
        TranslateTo.Add("C", "2")
        TranslateTo.Add("B", "3")
        TranslateTo.Add("A", "4")
        TranslateTo.Add("!", "5")
        TranslateTo.Add("?", "6")
        TranslateTo.Add(",", "7")
        TranslateTo.Add(".", "8")
        TranslateTo.Add(" ", "9")

    End Sub

    Private Sub Atbash_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Reset() '   When the Cipher is closed, the Cipher will reset.
        Me.Hide()   '   When the Cipher is closed, the Cipher will hide itself.
        Main.Show() '   When the Cipher is closed, the main Menu will show.
    End Sub

    Private Sub AtbashLogic()
        UserInput.Focus()

        CodeOutput.Clear()  '   This constantly clears the Output.

        If Decision = 1 Then    '   Sets the program to Encode.
            Try
                For Each Character In UserInput.Text    '   Gets Character into an array of characters.
                    CodeOutput.Text += TranslateFrom(Character.ToString.ToUpper)    '   Converts Character to its corresponding Output.
                Next
            Catch ex As Exception
                CodeOutput.Text = "Sorry, some charcters cannot be encoded with Atbash" '   Fails if numbers, symbols, foreign characters or punctuation characters are entered.
            End Try
        Else
            Try
                For Each Character In UserInput.Text    '   Gets Character into an array of characters.
                    CodeOutput.Text += TranslateTo(Character.ToString.ToUpper)    '   Converts Character to its corresponding Output.
                Next
            Catch ex As Exception
                CodeOutput.Text = "Malinformed Input." '   Fails if numbers, symbols, foreign characters or punctuation characters are entered. I'm not sure if I've ever seen this error message before.
            End Try
        End If
    End Sub

    Private Sub UserInput_TextChanged(sender As Object, e As EventArgs) Handles UserInput.TextChanged   '   When Plaintext has been modified, the program will run the logic for the Atbash Cipher.
        UserInput.Focus()   '   This puts the focus of the insertion point onto the Plaintext textbox.

        AtbashLogic()   '   Runs the algortihm to operate the Atbash Cipher.
    End Sub
End Class