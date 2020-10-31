Public Class AlphabeticalSubstitution
    Dim Decision As Integer
    Dim SubstituteFrom As New Dictionary(Of String, String)
    Dim SubstituteTo As New Dictionary(Of String, String)
    Dim Populate As Boolean
    Dim DeveloperControl As String
    Dim Indexx As Integer
    Dim Penultimate As String
    Dim Validatee As Boolean

    Private Sub Reset()
        UserInput.Clear()
        CodeOutput.Clear()

        Encode.ForeColor = Color.Red
        Decode.ForeColor = Color.Red

        Decision = 0

        Display(False)

        Populate = False

        Fresh.Enabled = False

        '///////ALPHABETICAL SUBSTITUTION///////

        SetModPlugboard.Text = "Set Plugboard"

        Plugboard.SelectionA.Clear()
        Plugboard.SelectionB.Clear()
        Plugboard.SelectionC.Clear()
        Plugboard.SelectionD.Clear()
        Plugboard.SelectionE.Clear()
        Plugboard.SelectionF.Clear()
        Plugboard.SelectionG.Clear()
        Plugboard.SelectionH.Clear()
        Plugboard.SelectionI.Clear()
        Plugboard.SelectionJ.Clear()
        Plugboard.SelectionK.Clear()
        Plugboard.SelectionL.Clear()
        Plugboard.SelectionM.Clear()
        Plugboard.SelectionN.Clear()
        Plugboard.SelectionO.Clear()
        Plugboard.SelectionP.Clear()
        Plugboard.SelectionQ.Clear()
        Plugboard.SelectionR.Clear()
        Plugboard.SelectionS.Clear()
        Plugboard.SelectionT.Clear()
        Plugboard.SelectionU.Clear()
        Plugboard.SelectionV.Clear()
        Plugboard.SelectionW.Clear()
        Plugboard.SelectionX.Clear()
        Plugboard.SelectionY.Clear()
        Plugboard.SelectionZ.Clear()

        Plugboard.Selection1.Clear()
        Plugboard.Selection2.Clear()
        Plugboard.Selection3.Clear()
        Plugboard.Selection4.Clear()
        Plugboard.Selection5.Clear()
        Plugboard.Selection6.Clear()
        Plugboard.Selection7.Clear()
        Plugboard.Selection8.Clear()
        Plugboard.Selection9.Clear()
        Plugboard.Selection0.Clear()

        Plugboard.SelectionSpace.Clear()

        RemoveDictionary()



        ConfirmCheck.Text = "0"
        'SetModPlugboard.Text = "Set Plugboard"

    End Sub

    Private Sub UserClear_Click(sender As Object, e As EventArgs) Handles UserClear.Click
        UserInput.Clear()
    End Sub

    Private Sub CodeCopy_Click(sender As Object, e As EventArgs) Handles CodeCopy.Click
        Try
            My.Computer.Clipboard.SetText(CodeOutput.Text)
            MsgBox("Copied " + CodeOutput.Text + " to clipboard")
        Catch ex As Exception
            MsgBox("Nothing to copy.", , "Error")
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
            Message.Visible = True
            SetModPlugboard.Visible = True
            Fresh.Enabled = True
        Else
            UserInput.Visible = False
            CodeOutput.Visible = False
            UserClear.Visible = False
            CodeCopy.Visible = False
            UserInput.Clear()
            CodeOutput.Clear()
            Message.Visible = False
            SetModPlugboard.Visible = False
            Fresh.Enabled = False
        End If
    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles Encode.Click
        Decision = 1
        Encode.ForeColor = Color.LimeGreen
        Decode.ForeColor = Color.Red
        Display(True)
        Indexx = 0

        AlphabeticalSubstitutionLogic()
    End Sub

    Private Sub Decode_Click(sender As Object, e As EventArgs) Handles Decode.Click
        Decision = 2
        Decode.ForeColor = Color.LimeGreen
        Encode.ForeColor = Color.Red
        Display(True)
        Indexx = 0

        AlphabeticalSubstitutionLogic()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Reset()
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub AlphabeticalSubstitution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    ' Public Sub Method(Keyboard As String, TFName As String)

    '    replace = SelectionA.Name.Last
    'If replace = "A" Or replace = "a" Then

    '       SubstituteFrom.Add(replace, Keyboard)
    'End If
    'End Sub

    Private Sub RemoveDictionary()
        SubstituteFrom.Remove(" ")
        SubstituteFrom.Remove(Plugboard.SelectionSpace.Text)
        SubstituteFrom.Remove("A")
        SubstituteFrom.Remove("B")
        SubstituteFrom.Remove("C")
        SubstituteFrom.Remove("D")
        SubstituteFrom.Remove("E")
        SubstituteFrom.Remove("F")
        SubstituteFrom.Remove("G")
        SubstituteFrom.Remove("H")
        SubstituteFrom.Remove("I")
        SubstituteFrom.Remove("J")
        SubstituteFrom.Remove("K")
        SubstituteFrom.Remove("L")
        SubstituteFrom.Remove("M")
        SubstituteFrom.Remove("N")
        SubstituteFrom.Remove("O")
        SubstituteFrom.Remove("P")
        SubstituteFrom.Remove("Q")
        SubstituteFrom.Remove("R")
        SubstituteFrom.Remove("S")
        SubstituteFrom.Remove("T")
        SubstituteFrom.Remove("U")
        SubstituteFrom.Remove("V")
        SubstituteFrom.Remove("W")
        SubstituteFrom.Remove("X")
        SubstituteFrom.Remove("Y")
        SubstituteFrom.Remove("Z")

        SubstituteFrom.Remove("1")
        SubstituteFrom.Remove("2")
        SubstituteFrom.Remove("3")
        SubstituteFrom.Remove("4")
        SubstituteFrom.Remove("5")
        SubstituteFrom.Remove("6")
        SubstituteFrom.Remove("7")
        SubstituteFrom.Remove("8")
        SubstituteFrom.Remove("9")
        SubstituteFrom.Remove("0")

        SubstituteTo.Remove(" ")
        SubstituteTo.Remove(Plugboard.SelectionSpace.Text)
        SubstituteTo.Remove(Plugboard.SelectionA.Text)
        SubstituteTo.Remove(Plugboard.SelectionB.Text)
        SubstituteTo.Remove(Plugboard.SelectionC.Text)
        SubstituteTo.Remove(Plugboard.SelectionD.Text)
        SubstituteTo.Remove(Plugboard.SelectionE.Text)
        SubstituteTo.Remove(Plugboard.SelectionF.Text)
        SubstituteTo.Remove(Plugboard.SelectionG.Text)
        SubstituteTo.Remove(Plugboard.SelectionH.Text)
        SubstituteTo.Remove(Plugboard.SelectionI.Text)
        SubstituteTo.Remove(Plugboard.SelectionJ.Text)
        SubstituteTo.Remove(Plugboard.SelectionK.Text)
        SubstituteTo.Remove(Plugboard.SelectionL.Text)
        SubstituteTo.Remove(Plugboard.SelectionM.Text)
        SubstituteTo.Remove(Plugboard.SelectionN.Text)
        SubstituteTo.Remove(Plugboard.SelectionO.Text)
        SubstituteTo.Remove(Plugboard.SelectionP.Text)
        SubstituteTo.Remove(Plugboard.SelectionQ.Text)
        SubstituteTo.Remove(Plugboard.SelectionR.Text)
        SubstituteTo.Remove(Plugboard.SelectionS.Text)
        SubstituteTo.Remove(Plugboard.SelectionT.Text)
        SubstituteTo.Remove(Plugboard.SelectionU.Text)
        SubstituteTo.Remove(Plugboard.SelectionV.Text)
        SubstituteTo.Remove(Plugboard.SelectionW.Text)
        SubstituteTo.Remove(Plugboard.SelectionX.Text)
        SubstituteTo.Remove(Plugboard.SelectionY.Text)
        SubstituteTo.Remove(Plugboard.SelectionZ.Text)

        SubstituteTo.Remove(Plugboard.Selection1.Text)
        SubstituteTo.Remove(Plugboard.Selection2.Text)
        SubstituteTo.Remove(Plugboard.Selection3.Text)
        SubstituteTo.Remove(Plugboard.Selection4.Text)
        SubstituteTo.Remove(Plugboard.Selection5.Text)
        SubstituteTo.Remove(Plugboard.Selection6.Text)
        SubstituteTo.Remove(Plugboard.Selection7.Text)
        SubstituteTo.Remove(Plugboard.Selection8.Text)
        SubstituteTo.Remove(Plugboard.Selection9.Text)
        SubstituteTo.Remove(Plugboard.Selection0.Text)
    End Sub

    Public Sub AlphabeticalSubstitutionLogic() 'sender As Object, e As EventArgs) Handles MyBase.Load

        'Populate = False

        'SelectionA.Text = vbEmpty
        'Method(SelectionA.Text, SelectionA.Name)

        RemoveDictionary()

        Try

            'This is the Alphabetical Substitution from English or Numbers to Ciphertext using the chosen String in the format of <ENGLISH> | <NUMBER>, <CIPHERTEXT>

            'SubstituteFrom.Add(" ", "")
            SubstituteFrom.Add(" ", Plugboard.SelectionSpace.Text)
            SubstituteFrom.Add("A", Plugboard.SelectionA.Text)
            SubstituteFrom.Add("B", Plugboard.SelectionB.Text)
            SubstituteFrom.Add("C", Plugboard.SelectionC.Text)
            SubstituteFrom.Add("D", Plugboard.SelectionD.Text)
            SubstituteFrom.Add("E", Plugboard.SelectionE.Text)
            SubstituteFrom.Add("F", Plugboard.SelectionF.Text)
            SubstituteFrom.Add("G", Plugboard.SelectionG.Text)
            SubstituteFrom.Add("H", Plugboard.SelectionH.Text)
            SubstituteFrom.Add("I", Plugboard.SelectionI.Text)
            SubstituteFrom.Add("J", Plugboard.SelectionJ.Text)
            SubstituteFrom.Add("K", Plugboard.SelectionK.Text)
            SubstituteFrom.Add("L", Plugboard.SelectionL.Text)
            SubstituteFrom.Add("M", Plugboard.SelectionM.Text)
            SubstituteFrom.Add("N", Plugboard.SelectionN.Text)
            SubstituteFrom.Add("O", Plugboard.SelectionO.Text)
            SubstituteFrom.Add("P", Plugboard.SelectionP.Text)
            SubstituteFrom.Add("Q", Plugboard.SelectionQ.Text)
            SubstituteFrom.Add("R", Plugboard.SelectionR.Text)
            SubstituteFrom.Add("S", Plugboard.SelectionS.Text)
            SubstituteFrom.Add("T", Plugboard.SelectionT.Text)
            SubstituteFrom.Add("U", Plugboard.SelectionU.Text)
            SubstituteFrom.Add("V", Plugboard.SelectionV.Text)
            SubstituteFrom.Add("W", Plugboard.SelectionW.Text)
            SubstituteFrom.Add("X", Plugboard.SelectionX.Text)
            SubstituteFrom.Add("Y", Plugboard.SelectionY.Text)
            SubstituteFrom.Add("Z", Plugboard.SelectionZ.Text)

            SubstituteFrom.Add("1", Plugboard.Selection1.Text)
            SubstituteFrom.Add("2", Plugboard.Selection2.Text)
            SubstituteFrom.Add("3", Plugboard.Selection3.Text)
            SubstituteFrom.Add("4", Plugboard.Selection4.Text)
            SubstituteFrom.Add("5", Plugboard.Selection5.Text)
            SubstituteFrom.Add("6", Plugboard.Selection6.Text)
            SubstituteFrom.Add("7", Plugboard.Selection7.Text)
            SubstituteFrom.Add("8", Plugboard.Selection8.Text)
            SubstituteFrom.Add("9", Plugboard.Selection9.Text)
            SubstituteFrom.Add("0", Plugboard.Selection0.Text)

            'This is the Alphabetical Substitution from Ciphertext to English or Numbers using the chosen String in the format of <CIPHERTEXT>, <ENGLISH> | <NUMBER>

            SubstituteTo.Add(" ", "")
            SubstituteTo.Add(Plugboard.SelectionSpace.Text, " ")
            SubstituteTo.Add(Plugboard.SelectionA.Text, "A")
            SubstituteTo.Add(Plugboard.SelectionB.Text, "B")
            SubstituteTo.Add(Plugboard.SelectionC.Text, "C")
            SubstituteTo.Add(Plugboard.SelectionD.Text, "D")
            SubstituteTo.Add(Plugboard.SelectionE.Text, "E")
            SubstituteTo.Add(Plugboard.SelectionF.Text, "F")
            SubstituteTo.Add(Plugboard.SelectionG.Text, "G")
            SubstituteTo.Add(Plugboard.SelectionH.Text, "H")
            SubstituteTo.Add(Plugboard.SelectionI.Text, "I")
            SubstituteTo.Add(Plugboard.SelectionJ.Text, "J")
            SubstituteTo.Add(Plugboard.SelectionK.Text, "K")
            SubstituteTo.Add(Plugboard.SelectionL.Text, "L")
            SubstituteTo.Add(Plugboard.SelectionM.Text, "M")
            SubstituteTo.Add(Plugboard.SelectionN.Text, "N")
            SubstituteTo.Add(Plugboard.SelectionO.Text, "O")
            SubstituteTo.Add(Plugboard.SelectionP.Text, "P")
            SubstituteTo.Add(Plugboard.SelectionQ.Text, "Q")
            SubstituteTo.Add(Plugboard.SelectionR.Text, "R")
            SubstituteTo.Add(Plugboard.SelectionS.Text, "S")
            SubstituteTo.Add(Plugboard.SelectionT.Text, "T")
            SubstituteTo.Add(Plugboard.SelectionU.Text, "U")
            SubstituteTo.Add(Plugboard.SelectionV.Text, "V")
            SubstituteTo.Add(Plugboard.SelectionW.Text, "W")
            SubstituteTo.Add(Plugboard.SelectionX.Text, "X")
            SubstituteTo.Add(Plugboard.SelectionY.Text, "Y")
            SubstituteTo.Add(Plugboard.SelectionZ.Text, "Z")

            SubstituteTo.Add(Plugboard.Selection1.Text, "1")
            SubstituteTo.Add(Plugboard.Selection2.Text, "2")
            SubstituteTo.Add(Plugboard.Selection3.Text, "3")
            SubstituteTo.Add(Plugboard.Selection4.Text, "4")
            SubstituteTo.Add(Plugboard.Selection5.Text, "5")
            SubstituteTo.Add(Plugboard.Selection6.Text, "6")
            SubstituteTo.Add(Plugboard.Selection7.Text, "7")
            SubstituteTo.Add(Plugboard.Selection8.Text, "8")
            SubstituteTo.Add(Plugboard.Selection9.Text, "9")
            SubstituteTo.Add(Plugboard.Selection0.Text, "0")
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Sandy_Click(sender As Object, e As EventArgs) Handles SetModPlugboard.Click
        If ConfirmCheck.Text = "1" Then

            SetModPlugboard.Text = "Modify Plugboard"
            Plugboard.Show()
        Else
            Plugboard.Show()
        End If
    End Sub

    Private Sub AlphabeticalSubstitution_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Reset()
        Plugboard.Hide()
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub UserInput_TextChanged(sender As Object, e As EventArgs) Handles UserInput.TextChanged
        CodeOutput.Clear()

        Indexx = 0

        AlphabeticalSubstitutionLogic()

        If Plugboard.SelectionA.TextLength > 0 And Plugboard.SelectionB.TextLength > 0 And Plugboard.SelectionC.TextLength > 0 And Plugboard.SelectionD.TextLength > 0 And Plugboard.SelectionE.TextLength > 0 And Plugboard.SelectionF.TextLength > 0 And Plugboard.SelectionG.TextLength > 0 And Plugboard.SelectionH.TextLength > 0 And Plugboard.SelectionI.TextLength > 0 And Plugboard.SelectionI.TextLength > 0 And Plugboard.SelectionJ.TextLength > 0 And Plugboard.SelectionK.TextLength > 0 And Plugboard.SelectionL.TextLength > 0 And Plugboard.SelectionM.TextLength > 0 And Plugboard.SelectionN.TextLength > 0 And Plugboard.SelectionO.TextLength > 0 And Plugboard.SelectionP.TextLength > 0 And Plugboard.SelectionQ.TextLength > 0 And Plugboard.SelectionR.TextLength > 0 And Plugboard.SelectionS.TextLength > 0 And Plugboard.SelectionT.TextLength > 0 And Plugboard.SelectionU.TextLength > 0 And Plugboard.SelectionV.TextLength > 0 And Plugboard.SelectionW.TextLength > 0 And Plugboard.SelectionX.TextLength > 0 And Plugboard.SelectionY.TextLength > 0 And Plugboard.SelectionZ.TextLength > 0 And Plugboard.Selection1.TextLength > 0 And Plugboard.Selection2.TextLength > 0 And Plugboard.Selection3.TextLength > 0 And Plugboard.Selection4.TextLength > 0 And Plugboard.Selection5.TextLength > 0 And Plugboard.Selection6.TextLength > 0 And Plugboard.Selection7.TextLength > 0 And Plugboard.Selection8.TextLength > 0 And Plugboard.Selection9.TextLength > 0 And Plugboard.Selection0.TextLength > 0 And Plugboard.SelectionSpace.TextLength > 0 Then 'include a check that ensures there is not space.
            Populate = True
        Else
            Populate = False
        End If

        If Plugboard.SelectionSpace.Text = " " Then
            Validatee = False
        Else
            Validatee = True
        End If

        If Populate = True And Validate() = True Or ConfirmCheck.Text = "1" Then
            UserInput.ReadOnly = False
            If Decision = 1 Then
                Try
                    For Each character In UserInput.Text
                        CodeOutput.Text += SubstituteFrom(character.ToString.ToUpper) + " "
                    Next
                Catch ex As Exception
                    CodeOutput.Text = "Sorry, some characters cannot be encoded using Alphabetical Substitution."
                End Try
            Else
                Try
                    For Each character In UserInput.Text

                        Dim LetterSplitter() As String = UserInput.Text.Split(" ")

                        CodeOutput.Text += SubstituteTo((LetterSplitter(Indexx)).ToString)
                        Indexx = Indexx + 1

                    Next
                Catch ex As Exception
                    'CodeOutput.Text = "Malinformed Input."
                End Try
            End If
        Else
            UserInput.ReadOnly = True
            UserInput.Clear()
            CodeOutput.Text = " "
            CodeOutput.Text = "Ensure the Plugboard has been filled with no duplicates." + vbCrLf + vbCrLf + "Also ensure that the SPACEBAR' does not include a Space."
        End If

        If ConfirmCheck.Text = "1" Then
            AlphabeticalSubstitutionLogic()
        End If
    End Sub

    Private Sub Fresh_Tick(sender As Object, e As EventArgs) Handles Fresh.Tick
        Indexx = 0
    End Sub
End Class