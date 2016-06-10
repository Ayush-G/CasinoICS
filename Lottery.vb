Public Class Lottery
    Dim rndNum1 As Integer = LblLottoNum1.Text
    Dim rndNum2 As Integer = LblLottoNum2.Text
    Dim rndNum3 As Integer = LblLottoNum3.Text
    Dim rndNum4 As Integer = LblLottoNum4.Text
    Dim rndNum5 As Integer = LblLottoNum5.Text
    Dim PlayerNum1 As Integer = TxtboxPlayerNum1.Text
    Dim PlayerNum2 As Integer = TxtBoxPlayerNum2.Text
    Dim PlayerNum3 As Integer = TxtBoxPlayerNum3.Text
    Dim playerNum4 As Integer = TxtBoxPlayerNum4.Text
    Dim playerNum5 As Integer = TxtBoxPlayerNum5.Text
    Dim RndSum As Integer = LblSumOfBalls.Text
    Dim PlayerSum As Integer = LblPlayerNumSum.Text
    Private Sub BtnCheckNumbers_Click(sender As Object, e As EventArgs) Handles BtnCheckNumbers.Click

        rndNum1 = (100 * Rnd()) + 1
        rndNum2 = (100 * Rnd()) + 1
        rndNum3 = (100 * Rnd()) + 1
        rndNum4 = (100 * Rnd()) + 1
        RndSum = rndNum1 + rndNum2 + rndNum3 + rndNum4
        PlayerSum = PlayerNum1 + PlayerNum2 + PlayerNum3 + playerNum4 + playerNum5

        If RndSum = PlayerSum Then
            Money = Money * 10 + Money
            MsgBox("Congratulations! the sum of your numbers and the lotery's are the same! You win 10 times the amount of your current winnnings and your 20$ ticket back" & Money)
        ElseIf PlayerNum1 = rndNum1 And PlayerNum2 = rndNum2 And PlayerNum3 = rndNum3 And playerNum4 = rndNum4 And playerNum5 = rndNum5 Then
            Money = Money * 100 + Money
            MsgBox("You guessed all the numbers exactly!!! You have won 100 times your current winnings and your 20$ ticket back:" & Money)
        ElseIf RndSum - 51 < PlayerSum Or RndSum + 51 > PlayerSum Then
            Money = Money + 100
            MsgBox("Your sum was within 50 of the lottery's sum, you win 100$ and the 20$ cost of your ticket" & Money)
        ElseIf RndSum - 101 < PlayerSum Or RndSum + 101 > PlayerSum Then
            Money = Money + 25
            MsgBox("the sum of your numbers was withing 100 of the lottery's sum, you win 25$ and the cost of your 20$ ticket back:" & Money)
        Else Money = Money - 20
            MsgBox("sorry, the sum of your numbers were nowhere near the sum of the lottery's. Please play agin")
        End If
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub
End Class