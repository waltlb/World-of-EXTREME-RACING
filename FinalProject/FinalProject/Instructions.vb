Public Class Instructions
    Dim intPage As Integer
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        intPage += 1
        Dim intNum As Integer
        lblInstructions.Text = ("Welcome to the world of Extreme Raceing! My name is really hard" _
     & "to pronounce, so you can just call me the Veteran Racer.")
        intNum = Next_Page(intPage)
    End Sub
    Function Next_Page(ByVal intPage As Integer)
        'This function changes the instructions listed in the black label
        Select Case intPage
            Case 1
                lblInstructions.Text = "The goal of the game is to collect as many coins as possible without crashing." _
                     & "The more coins you grab, the faster you go."
            Case 2
                lblInstructions.Text = "To drive your car left, press the left arrow key." _
                     & "To move your car right, press the right key."
            Case 3
                lblInstructions.Text = "Pressing the Turbo button will double your speed for 10 secconds." _
                     & "To recharge it, you need to collect more coins."
            Case 4
                lblInstructions.Text = "Be carefull not to hit the walls or any" _
                     & "other obtsacles though. You only have thre lives."
            Case 5
                lblInstructions.Text = "Press the Enter key to start the game once you " _
                     & "get to the track." & vbCrLf & "Good Luck!"
            Case 6
                Me.Hide()
                Track1.Show()
        End Select

    End Function

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Me.Close()
        Track1.Show()
    End Sub
End Class