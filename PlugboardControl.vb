﻿Public Class PlugboardControl

    Dim SubstituteFrom As New Dictionary(Of String, String)
    Dim SubstituteTo As New Dictionary(Of String, String)

    Public Sub ConfirmPlugboard()
        'This removes the corresponding letter from the dictionary to avoid crashes when any changes to the substitution is made.

        SubstituteFrom.Remove(" ")
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

        'This is the Alphabetical Substitution from English to Ciphertext using the chosen String in the format of <ENGLISH> | <NUMBER>, <CIPHERTEXT>

        SubstituteFrom.Add(" ", " ")
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
    End Sub

End Class
