Public Class Main
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles CaesarCipher.Click
        Caesar.Show()
        Me.Hide()
    End Sub

    Private Sub MorseCode_Click(sender As Object, e As EventArgs) Handles MorseCode.Click
        SMorseCode.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Atbash.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        AlphabeticalSubstitution.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Vigenere.Show()
        Me.Hide()
    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class
