Public Class Plugboard
    Dim DuplicateCheck As New Dictionary(Of String, String)
    Dim DeveloperControl As String

    Private Sub ConfirmPlugboard_Click(sender As Object, e As EventArgs) Handles ConfirmPlugboard.Click



        If SelectionA.Text.Length = 0 Or SelectionB.Text.Length = 0 Or SelectionC.Text.Length = 0 Or SelectionD.Text.Length = 0 Or SelectionE.Text.Length = 0 Or SelectionF.Text.Length = 0 Or SelectionG.Text.Length = 0 Or SelectionH.Text.Length = 0 Or SelectionI.Text.Length = 0 Or SelectionJ.Text.Length = 0 Or SelectionK.Text.Length = 0 Or SelectionL.Text.Length = 0 Or SelectionM.Text.Length = 0 Or SelectionN.Text.Length = 0 Or SelectionO.Text.Length = 0 Or SelectionP.Text.Length = 0 Or SelectionQ.Text.Length = 0 Or SelectionR.Text.Length = 0 Or SelectionS.Text.Length = 0 Or SelectionT.Text.Length = 0 Or SelectionU.Text.Length = 0 Or SelectionV.Text.Length = 0 Or SelectionW.Text.Length = 0 Or SelectionX.Text.Length = 0 Or SelectionY.Text.Length = 0 Or SelectionZ.Text.Length = 0 Or Selection0.Text.Length = 0 Or Selection2.Text.Length = 0 Or Selection3.Text.Length = 0 Or Selection4.Text.Length = 0 Or Selection5.Text.Length = 0 Or Selection6.Text.Length = 0 Or Selection7.Text.Length = 0 Or Selection8.Text.Length = 0 Or Selection9.Text.Length = 0 Or Selection0.Text.Length = 0 Or SelectionSpace.Text.Length = 0 Then
            MsgBox("Fill in all letters.", , "Error")
        Else
            Try
                DuplicateCheck.Remove(" ")
                DuplicateCheck.Remove(SelectionSpace.Text)
                DuplicateCheck.Remove(SelectionA.Text)
                DuplicateCheck.Remove(SelectionB.Text)
                DuplicateCheck.Remove(SelectionC.Text)
                DuplicateCheck.Remove(SelectionD.Text)
                DuplicateCheck.Remove(SelectionE.Text)
                DuplicateCheck.Remove(SelectionF.Text)
                DuplicateCheck.Remove(SelectionG.Text)
                DuplicateCheck.Remove(SelectionH.Text)
                DuplicateCheck.Remove(SelectionI.Text)
                DuplicateCheck.Remove(SelectionJ.Text)
                DuplicateCheck.Remove(SelectionK.Text)
                DuplicateCheck.Remove(SelectionL.Text)
                DuplicateCheck.Remove(SelectionM.Text)
                DuplicateCheck.Remove(SelectionN.Text)
                DuplicateCheck.Remove(SelectionO.Text)
                DuplicateCheck.Remove(SelectionP.Text)
                DuplicateCheck.Remove(SelectionQ.Text)
                DuplicateCheck.Remove(SelectionR.Text)
                DuplicateCheck.Remove(SelectionS.Text)
                DuplicateCheck.Remove(SelectionT.Text)
                DuplicateCheck.Remove(SelectionU.Text)
                DuplicateCheck.Remove(SelectionV.Text)
                DuplicateCheck.Remove(SelectionW.Text)
                DuplicateCheck.Remove(SelectionX.Text)
                DuplicateCheck.Remove(SelectionY.Text)
                DuplicateCheck.Remove(SelectionZ.Text)

                DuplicateCheck.Remove(Selection1.Text)
                DuplicateCheck.Remove(Selection2.Text)
                DuplicateCheck.Remove(Selection3.Text)
                DuplicateCheck.Remove(Selection4.Text)
                DuplicateCheck.Remove(Selection5.Text)
                DuplicateCheck.Remove(Selection6.Text)
                DuplicateCheck.Remove(Selection7.Text)
                DuplicateCheck.Remove(Selection8.Text)
                DuplicateCheck.Remove(Selection9.Text)
                DuplicateCheck.Remove(Selection0.Text)

                DuplicateCheck.Add(" ", " ")
                DuplicateCheck.Add(SelectionSpace.Text, " ")
                DuplicateCheck.Add(SelectionA.Text, "A")
                DuplicateCheck.Add(SelectionB.Text, "B")
                DuplicateCheck.Add(SelectionC.Text, "C")
                DuplicateCheck.Add(SelectionD.Text, "D")
                DuplicateCheck.Add(SelectionE.Text, "E")
                DuplicateCheck.Add(SelectionF.Text, "F")
                DuplicateCheck.Add(SelectionG.Text, "G")
                DuplicateCheck.Add(SelectionH.Text, "H")
                DuplicateCheck.Add(SelectionI.Text, "I")
                DuplicateCheck.Add(SelectionJ.Text, "J")
                DuplicateCheck.Add(SelectionK.Text, "K")
                DuplicateCheck.Add(SelectionL.Text, "L")
                DuplicateCheck.Add(SelectionM.Text, "M")
                DuplicateCheck.Add(SelectionN.Text, "N")
                DuplicateCheck.Add(SelectionO.Text, "O")
                DuplicateCheck.Add(SelectionP.Text, "P")
                DuplicateCheck.Add(SelectionQ.Text, "Q")
                DuplicateCheck.Add(SelectionR.Text, "R")
                DuplicateCheck.Add(SelectionS.Text, "S")
                DuplicateCheck.Add(SelectionT.Text, "T")
                DuplicateCheck.Add(SelectionU.Text, "U")
                DuplicateCheck.Add(SelectionV.Text, "V")
                DuplicateCheck.Add(SelectionW.Text, "W")
                DuplicateCheck.Add(SelectionX.Text, "X")
                DuplicateCheck.Add(SelectionY.Text, "Y")
                DuplicateCheck.Add(SelectionZ.Text, "Z")

                DuplicateCheck.Add(Selection1.Text, "1")
                DuplicateCheck.Add(Selection2.Text, "2")
                DuplicateCheck.Add(Selection3.Text, "3")
                DuplicateCheck.Add(Selection4.Text, "4")
                DuplicateCheck.Add(Selection5.Text, "5")
                DuplicateCheck.Add(Selection6.Text, "6")
                DuplicateCheck.Add(Selection7.Text, "7")
                DuplicateCheck.Add(Selection8.Text, "8")
                DuplicateCheck.Add(Selection9.Text, "9")
                DuplicateCheck.Add(Selection0.Text, "0")

                AlphabeticalSubstitution.ConfirmCheck.Text = "1"
                AlphabeticalSubstitution.UserInput.Text = ""
                AlphabeticalSubstitution.UserInput.ReadOnly = False
                AlphabeticalSubstitution.SetModPlugboard.Text = "Modify Plugboard"
                AlphabeticalSubstitution.UserInput.Clear()


                Me.Hide()

            Catch ex As Exception

                If SelectionA.Text.Length < 0 Or SelectionB.Text.Length < 0 Or SelectionC.Text.Length < 0 Or SelectionD.Text.Length < 0 Or SelectionE.Text.Length < 0 Or SelectionF.Text.Length < 0 Or SelectionG.Text.Length < 0 Or SelectionH.Text.Length < 0 Or SelectionI.Text.Length < 0 Or SelectionJ.Text.Length < 0 Or SelectionK.Text.Length < 0 Or SelectionL.Text.Length < 0 Or SelectionM.Text.Length < 0 Or SelectionN.Text.Length < 0 Or SelectionO.Text.Length < 0 Or SelectionP.Text.Length < 0 Or SelectionQ.Text.Length < 0 Or SelectionR.Text.Length < 0 Or SelectionS.Text.Length < 0 Or SelectionT.Text.Length < 0 Or SelectionU.Text.Length < 0 Or SelectionV.Text.Length < 0 Or SelectionW.Text.Length < 0 Or SelectionX.Text.Length < 0 Or SelectionY.Text.Length < 0 Or SelectionZ.Text.Length < 0 Or Selection0.Text.Length < 0 Or Selection2.Text.Length < 0 Or Selection3.Text.Length < 0 Or Selection4.Text.Length < 0 Or Selection5.Text.Length < 0 Or Selection6.Text.Length < 0 Or Selection7.Text.Length < 0 Or Selection8.Text.Length < 0 Or Selection9.Text.Length < 0 Or Selection0.Text.Length < 0 Or SelectionSpace.Text.Length < 0 Then
                    MsgBox("Fill in every field.", , "Error")
                Else
                    MsgBox("Ensure there are no duplicates and ensure all substitutions do not include a Space.", , "Error")
                    AlphabeticalSubstitution.ConfirmCheck.Text = "0"
                End If

                'AlphabeticalSubstitution.CodeOutput.Text = ex.ToString
            End Try
        End If
    End Sub

    Private Sub Plugboard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) > 1 Then
            DeveloperControl = e.KeyChar
        End If

        If DeveloperControl = "`" Then
            SelectionA.Text = "!"
            SelectionB.Text = "@"
            SelectionC.Text = "#"
            SelectionD.Text = "$"
            SelectionE.Text = "%"
            SelectionF.Text = "^"
            SelectionG.Text = "&"
            SelectionH.Text = "*"
            SelectionI.Text = "("
            SelectionJ.Text = ")"
            SelectionK.Text = "-"
            SelectionL.Text = "="
            SelectionM.Text = "Q"
            SelectionN.Text = "W"
            SelectionO.Text = "E"
            SelectionP.Text = "R"
            SelectionQ.Text = "T"
            SelectionR.Text = "Y"
            SelectionS.Text = "U"
            SelectionT.Text = "I"
            SelectionU.Text = "O"
            SelectionV.Text = "P"
            SelectionW.Text = "["
            SelectionX.Text = "]"
            SelectionY.Text = "\"
            SelectionZ.Text = "A"

            Selection1.Text = "SS"
            Selection2.Text = "DD"
            Selection3.Text = "WW"
            Selection4.Text = "?"
            Selection5.Text = ">"
            Selection6.Text = "<"
            Selection7.Text = ":"
            Selection8.Text = "|"
            Selection9.Text = "}"
            Selection0.Text = "{"
        End If
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles Preset.SelectedItemChanged
        If Preset.Text = "Custom" Then
            SelectionSpace.Clear()
            SelectionA.Clear()
            SelectionB.Clear()
            SelectionC.Clear()
            SelectionD.Clear()
            SelectionE.Clear()
            SelectionF.Clear()
            SelectionG.Clear()
            SelectionH.Clear()
            SelectionI.Clear()
            SelectionJ.Clear()
            SelectionK.Clear()
            SelectionL.Clear()
            SelectionM.Clear()
            SelectionN.Clear()
            SelectionO.Clear()
            SelectionP.Clear()
            SelectionQ.Clear()
            SelectionR.Clear()
            SelectionS.Clear()
            SelectionT.Clear()
            SelectionU.Clear()
            SelectionV.Clear()
            SelectionW.Clear()
            SelectionX.Clear()
            SelectionY.Clear()
            SelectionZ.Clear()

            Selection1.Clear()
            Selection2.Clear()
            Selection3.Clear()
            Selection4.Clear()
            Selection5.Clear()
            Selection6.Clear()
            Selection7.Clear()
            Selection0.Clear()
            Selection9.Clear()
            Selection0.Clear()
        End If

        If Preset.Text = "1" Then
            SelectionSpace.Text = "$%"
            SelectionA.Text = "!"
            SelectionB.Text = "@"
            SelectionC.Text = "#"
            SelectionD.Text = "$"
            SelectionE.Text = "%"
            SelectionF.Text = "^"
            SelectionG.Text = "&"
            SelectionH.Text = "*"
            SelectionI.Text = "("
            SelectionJ.Text = ")"
            SelectionK.Text = "-"
            SelectionL.Text = "="
            SelectionM.Text = "Q"
            SelectionN.Text = "W"
            SelectionO.Text = "E"
            SelectionP.Text = "R"
            SelectionQ.Text = "T"
            SelectionR.Text = "Y"
            SelectionS.Text = "U"
            SelectionT.Text = "I"
            SelectionU.Text = "O"
            SelectionV.Text = "P"
            SelectionW.Text = "["
            SelectionX.Text = "]"
            SelectionY.Text = "\"
            SelectionZ.Text = "A"

            Selection1.Text = "SS"
            Selection2.Text = "DD"
            Selection3.Text = "WW"
            Selection4.Text = "?"
            Selection5.Text = ">"
            Selection6.Text = "<"
            Selection7.Text = ":"
            Selection8.Text = "|"
            Selection9.Text = "}"
            Selection0.Text = "{"
        End If

        If Preset.Text = "2" Then
            SelectionSpace.Text = "#RD"
            SelectionA.Text = "QWE"
            SelectionB.Text = "FES"
            SelectionC.Text = "4TH"
            SelectionD.Text = "BVR"
            SelectionE.Text = "POK"
            SelectionF.Text = "QBX"
            SelectionG.Text = "XG6"
            SelectionH.Text = "36M"
            SelectionI.Text = "PNN"
            SelectionJ.Text = "34S"
            SelectionK.Text = "GTR"
            SelectionL.Text = "09I"
            SelectionM.Text = "BNM"
            SelectionN.Text = "DFV"
            SelectionO.Text = "ZTR"
            SelectionP.Text = "H2A"
            SelectionQ.Text = "P20"
            SelectionR.Text = "M4E"
            SelectionS.Text = "MOA"
            SelectionT.Text = "23E"
            SelectionU.Text = "LKE"
            SelectionV.Text = "UYT"
            SelectionW.Text = "QMD"
            SelectionX.Text = "ISI"
            SelectionY.Text = "RT0"
            SelectionZ.Text = "LKM"

            Selection1.Text = "WWS"
            Selection2.Text = "DP;"
            Selection3.Text = "+JH"
            Selection4.Text = "6T5"
            Selection5.Text = "TYU"
            Selection6.Text = "GFV"
            Selection7.Text = "LKI"
            Selection8.Text = "2WS"
            Selection9.Text = "6YH"
            Selection0.Text = "8IK"
        End If

        If Preset.Text = "3" Then
            SelectionSpace.Text = "&*UNS"
            SelectionA.Text = ")S*DU"
            SelectionB.Text = "DSY&W"
            SelectionC.Text = "SD>LM"
            SelectionD.Text = "SADBM"
            SelectionE.Text = "&*DS@"
            SelectionF.Text = "ASD35"
            SelectionG.Text = "ZFC6a"
            SelectionH.Text = "9*SD@"
            SelectionI.Text = "SD&^4"
            SelectionJ.Text = "+A31V"
            SelectionK.Text = "#4!MS"
            SelectionL.Text = "KS*VW"
            SelectionM.Text = "A0D&V"
            SelectionN.Text = ">CI>W"
            SelectionO.Text = "ZXC#A"
            SelectionP.Text = "A#FVF"
            SelectionQ.Text = "73MF%"
            SelectionR.Text = "?LKID"
            SelectionS.Text = "+D#MAZ"
            SelectionT.Text = "491A5"
            SelectionU.Text = "A114#"
            SelectionV.Text = "LK*D7"
            SelectionW.Text = "VBOA4"
            SelectionX.Text = "J^^AV"
            SelectionY.Text = "MV*A@"
            SelectionZ.Text = "]+ASC"

            Selection1.Text = "~#DAC"
            Selection2.Text = "AGD<O"
            Selection3.Text = "*HDSW"
            Selection4.Text = "AS$M@"
            Selection5.Text = "I#972"
            Selection6.Text = "MV&24"
            Selection7.Text = "LK21A"
            Selection8.Text = "MN783"
            Selection9.Text = "M83Q"
            Selection0.Text = "QTWKL"
        End If
    End Sub

    Private Sub Plugboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AlphabeticalSubstitution.AlphabeticalSubstitutionLogic()
    End Sub

    Private Sub Plugboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class