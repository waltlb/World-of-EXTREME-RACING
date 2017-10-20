Public Class Track1
    Dim decSpeed As Decimal

    Private Sub Track1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Pressing shift by itself slows down the car. Shift and an arrow key enables a drift.
        decSpeed = 1
        'This locks the controlls until the user presses the enter key
        Select Case e.KeyCode
            Case Keys.Enter
                tmrTime.Start()
                lblStatus.Text = "Go!"
            Case Keys.Left
                lblStatus.Visible = False
                picFPV.Left -= 4 * decSpeed
                lblTarget.Left -= 4 * decSpeed
            Case Keys.Right
                lblStatus.Visible = False
                picFPV.Left += 4 * decSpeed
                lblTarget.Left += 4 * decSpeed
        End Select
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick

        Dim WallArray() As Label = {lblRightWall, lblLeftWall}
        Dim coinArray() As PictureBox = {picCoinLeft, picCoinMiddle, picCoinRight}
        Dim TrackSurface As Drawing.Graphics = picTrack.CreateGraphics
        Dim Hits As Integer
        Dim coins As New System.Random
        Dim intShot As Integer
        Static blnShoot As Boolean

            intShot = coins.Next(0, 3)
            Select Case blnShoot
                Case True
                    For intShot = 0 To 2
                        coinArray(intShot).Visible = True
                        coinArray(intShot).Top += 10
                    Next
                Case False
                    coinArray(intShot).Visible = False
            End Select
            For Each Wall In WallArray
                If picFPV.Bounds.IntersectsWith(Wall.Bounds) Then 'Car hits the wall
                    intScore -= 10
                    picFPV.SetBounds(242, 455, 284, 112)
                    lblTarget.SetBounds(360, 409, 53, 55)
                    Hits += 1
                End If
                Select Case Hits 'Takes away hearts
                    Case 1
                        picHeart3.Visible = False
                    Case 2
                        picHeart2.Visible = False
                    Case 3
                        picHeart1.Visible = False
                    Case 4 'Ends the game
                        tmrTime.Stop()
                    picCoinLeft.Visible = False
                    picCoinMiddle.Visible = False
                    picCoinRight.Visible = False
                        picFPV.Enabled = False
                        lblTarget.Visible = False
                    Call You_Lose(intScore)
                End Select
            Next
            For Each coin In coinArray
                If lblTarget.Bounds.IntersectsWith(coin.Bounds) Then
                    blnShoot = False
                    intScore += 50
                    decSpeed += 1.5
                    Select Case intShot
                        Case 0
                            coinArray(0).SetBounds(223, 82, 25, 25)
                        Case 1
                            coinArray(1).SetBounds(381, 82, 25, 25)
                        Case 2
                            coinArray(3).SetBounds(540, 82, 25, 25)
                    End Select
                End If
            Next

    End Sub
    Sub You_Lose(ByRef intScore As Integer)
        MsgBox("You Lose " & strName & vbCrLf & vbCrLf & "Your score is: " & intScore, "You have died")
        Me.Hide()
        Dim strPlayAgain As String = InputBox("Would you like to play again?", "Play Again?", "Yes or No")
        Dim strAnswer As String = strPlayAgain.ToLower
        Select Case strAnswer
            Case "no"
                MsgBox("Thanks for playing!")
                Application.Exit()
            Case "yes"
                Application.Restart()
        End Select
    End Sub
End Class