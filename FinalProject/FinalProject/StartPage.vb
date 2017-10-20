Public Class StartPage

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click, HelpToolStripMenuItem.Click
        HelpMe()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        Do
            strName = InputBox("Please enter your name", "RACERNAME")
            Select Case strName
                Case "Name"
                    MsgBox("Please enter your name")
                    InputBox("Please enter your name", "RACERNAME")
                Case Else
                    'intNames += 1
            End Select
        Loop While strName = Nothing
        HelpMe()
    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        Me.Hide()
        HighScores.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        Application.Restart()
    End Sub
End Class
