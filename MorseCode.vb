Public Class SMorseCode
    Dim Decision As Integer
    Dim Indexx As Integer
    Dim TranslateFrom As New Dictionary(Of String, String)
    Dim TranslateTo As New Dictionary(Of String, String)

    Dim Tap As String
    Dim Dot As Integer

    Dim EasterEgg As Boolean

    Private Sub Reset()
        UserInput.Clear()
        CodeOutput.Clear()

        Encode.ForeColor = Color.Red
        Decode.ForeColor = Color.Red

        Decision = 0
        Indexx = 0

        Display(False)

        EasterEgg = False
    End Sub

    Private Sub UserClear_Click(sender As Object, e As EventArgs) Handles UserClear.Click
        UserInput.Clear()
    End Sub

    Private Sub CodeCopy_Click(sender As Object, e As EventArgs) Handles CodeCopy.Click
        Try
            My.Computer.Clipboard.SetText(CodeOutput.Text)
            MsgBox("Copied " + CodeOutput.Text + " to clipboard")
        Catch ex As Exception
            MsgBox("Nothing To copy.", , "Error")
        End Try

    End Sub

    Private Sub Display(Condition As Boolean)
        If Condition = True Then
            UserInput.Visible = True
            CodeOutput.Visible = True
            UserClear.Visible = True
            CodeCopy.Visible = True
            Fresh.Enabled = True
            UserInput.Clear()
            CodeOutput.Clear()
            AV.Visible = True
        Else
            UserInput.Visible = False
            CodeOutput.Visible = False
            UserClear.Visible = False
            CodeCopy.Visible = False
            Fresh.Enabled = False
            UserInput.Clear()
            CodeOutput.Clear()
            AV.Visible = False
        End If
    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles Encode.Click
        Decision = 1
        Encode.ForeColor = Color.LimeGreen
        Decode.ForeColor = Color.Red
        Display(True)
        Indexx = 0

        AV.Visible = True
    End Sub

    Private Sub Decode_Click(sender As Object, e As EventArgs) Handles Decode.Click
        Decision = 2
        Decode.ForeColor = Color.LimeGreen
        Encode.ForeColor = Color.Red
        Display(True)
        Indexx = 0

        AV.Visible = False
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Reset()
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub MorseCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserInput.Focus()

        'This is the Morse Code translation from English or numbers to Morse Code in the format of <LETTER> | <NUMBER>, <MORSE CODE>

        TranslateFrom.Add(" ", "/")
        TranslateFrom.Add("A", ".-")
        TranslateFrom.Add("B", "-...")
        TranslateFrom.Add("C", "-.-.")
        TranslateFrom.Add("D", "-..")
        TranslateFrom.Add("E", ".")
        TranslateFrom.Add("F", "..-.")
        TranslateFrom.Add("G", "--.")
        TranslateFrom.Add("H", "....")
        TranslateFrom.Add("I", "..")
        TranslateFrom.Add("J", ".---")
        TranslateFrom.Add("K", "-.-")
        TranslateFrom.Add("L", ".-..")
        TranslateFrom.Add("M", "--")
        TranslateFrom.Add("N", "-.")
        TranslateFrom.Add("O", "---")
        TranslateFrom.Add("P", ".--.")
        TranslateFrom.Add("Q", "--.-")
        TranslateFrom.Add("R", ".-.")
        TranslateFrom.Add("S", "...")
        TranslateFrom.Add("T", "-")
        TranslateFrom.Add("U", "..-")
        TranslateFrom.Add("V", "...-")
        TranslateFrom.Add("W", ".--")
        TranslateFrom.Add("X", "-..-")
        TranslateFrom.Add("Y", "-.--")
        TranslateFrom.Add("Z", "--..")

        TranslateFrom.Add("1", ".----")
        TranslateFrom.Add("2", "..---")
        TranslateFrom.Add("3", "...--")
        TranslateFrom.Add("4", "....-")
        TranslateFrom.Add("5", ".....")
        TranslateFrom.Add("6", "-....")
        TranslateFrom.Add("7", "--...")
        TranslateFrom.Add("8", "---..")
        TranslateFrom.Add("9", "----.")
        TranslateFrom.Add("0", "-----")

        TranslateFrom.Add(".", ".-.-.-")
        TranslateFrom.Add(",", "--..--")
        TranslateFrom.Add("?", "..--..")
        TranslateFrom.Add("'", ".----.")
        TranslateFrom.Add("!", "-.-.--")
        TranslateFrom.Add("&", ".-...")
        TranslateFrom.Add(":", "---...")
        TranslateFrom.Add(";", "-.-.-.")
        TranslateFrom.Add("=", "-...-")
        TranslateFrom.Add("+", ".-.-.")


        'This is the Morse Code translation from Morse Code to English and Numbers in the format of <MORESE CODE>, <LETTER> | <NUMBER>

        TranslateTo.Add(" ", " ")
        TranslateTo.Add("/", " ")
        TranslateTo.Add(".-", "A")
        TranslateTo.Add("-...", "B")
        TranslateTo.Add("-.-.", "C")
        TranslateTo.Add("-..", "D")
        TranslateTo.Add(".", "E")
        TranslateTo.Add("..-.", "F")
        TranslateTo.Add("--.", "G")
        TranslateTo.Add("....", "H")
        TranslateTo.Add("..", "I")
        TranslateTo.Add(".---", "J")
        TranslateTo.Add("-.-", "K")
        TranslateTo.Add(".-..", "L")
        TranslateTo.Add("--", "M")
        TranslateTo.Add("-.", "N")
        TranslateTo.Add("---", "O")
        TranslateTo.Add(".--.", "P")
        TranslateTo.Add("--.-", "Q")
        TranslateTo.Add(".-.", "R")
        TranslateTo.Add("...", "S")
        TranslateTo.Add("-", "T")
        TranslateTo.Add("..-", "U")
        TranslateTo.Add("...-", "V")
        TranslateTo.Add(".--", "W")
        TranslateTo.Add("-..-", "X")
        TranslateTo.Add("-.--", "Y")
        TranslateTo.Add("--..", "Z")

        TranslateTo.Add(".----", "1")
        TranslateTo.Add("..---", "2")
        TranslateTo.Add("...--", "3")
        TranslateTo.Add("....-", "4")
        TranslateTo.Add(".....", "5")
        TranslateTo.Add("-....", "6")
        TranslateTo.Add("--...", "7")
        TranslateTo.Add("---..", "8")
        TranslateTo.Add("----.", "9")
        TranslateTo.Add("-----", "0")

        TranslateTo.Add(".-.-.-", ".")
        TranslateTo.Add("--..--", ",")
        TranslateTo.Add("..--..", "?")
        TranslateTo.Add(".----.", "'")
        TranslateTo.Add("-.-.--", "!")
        TranslateTo.Add(".-...", "&")
        TranslateTo.Add("---...", ":")
        TranslateTo.Add("-.-.-.", ";")
        TranslateTo.Add("-...-", "=")
        TranslateTo.Add(".-.-.", "+")

        TranslateTo.Add("-.-.-", "BEGIN")
        TranslateTo.Add("...-.-", "END")
    End Sub

    Private Sub SMorseCode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Reset()
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub MorseCodeLogic()
        UserInput.Focus()

        CodeOutput.Clear()

        If UserInput.Text = " Hidden Feature" Then
            EasterEgg = True
        Else
            EasterEgg = False
        End If

        If Decision = 1 Then
            Try
                For Each letter In UserInput.Text
                    'CodeOutput.Text += "-.-.-" + " " + TranslateFrom(letter.ToString.ToUpper) + " " + "...-.-"
                    CodeOutput.Text += TranslateFrom(letter.ToString.ToUpper) + " "
                Next
            Catch ex As Exception
                CodeOutput.Text = "Sorry, some characters cannot be encoded using Morse Code."
            End Try
        Else
            Indexx = 0
            Try
                For Each letter In UserInput.Text

                    Dim MorseCodeBeeps As String = UserInput.Text
                    Dim LetterSplitter() As String = MorseCodeBeeps.Split(" ")

                    CodeOutput.Text += TranslateTo(LetterSplitter(Indexx).ToString)
                    Indexx = Indexx + 1
                Next
            Catch ex As Exception
                'CodeOutput.Text = "Malinformed Input." + vbCrLf + vbCrLf + ex.ToString
            End Try
        End If
    End Sub

    Private Sub AVLogic()
        If EasterEgg = True Then
            Try
                My.Computer.Clipboard.SetText(CodeOutput.Text)
                AudioVisualMC.Show()
            Catch ex As Exception
                MsgBox("Nothing to Represent", , "Error")
            End Try
        End If

        If EasterEgg = False Then
            If UserInput.Text.Length = 0 Then
                MsgBox("Please paste a message in Morse Code")
            Else
                'kConstant.Enabled = True
                Dot = 0

                Do Until Dot >= CodeOutput.Text.Length

                    'Dash = 0

                    If Dot >= CodeOutput.Text.Length Then
                        Dot = 0
                    End If

                    Tap = CodeOutput.Text(Dot)

                    If Tap = "." Then
                        'Visuals.Enabled = True
                        My.Computer.Audio.Play(My.Resources._Short, AudioPlayMode.WaitToComplete)
                        'ShortPulse()
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

                    If Dot >= CodeOutput.Text.Length Then
                        'MsgBox("End of Morse Code")
                        'kConstant.Enabled = False
                        MsgBox("End of Message")
                    End If
                Loop
            End If
        End If
    End Sub

    Private Sub UserInput_TextChanged(sender As Object, e As EventArgs) Handles UserInput.TextChanged
        UserInput.Focus()

        MorseCodeLogic()    '   Runs the algortihm to operate Morse Code.
    End Sub

    Private Sub AV_Click(sender As Object, e As EventArgs) Handles AV.Click
        AVLogic()
    End Sub
End Class