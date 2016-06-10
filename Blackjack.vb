Public Class BlackJack

    Dim counter As Integer = 0
    Dim card1 As Integer = LblPLayerCard1.Text
    Dim card2 As Integer = LblPlayerCard2.Text
    Dim card3 As Integer = LblPlayerCard3.Text
    Dim card4 As Integer = LblPlayerCard4.Text
    Dim card5 As Integer = LblPlayerCard5.Text
    Dim computercard1 As Integer = LblComputerCard1.Text
    Dim computercard2 As Integer = LblComputerCard2.Text
    Dim computercard3 As Integer = LblComputerCard3.Text
    Dim wager As Integer = TxtBoxWager.Text
    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub BtnDrawCard_Click(sender As Object, e As EventArgs) Handles BtnDrawCard.Click
        counter = counter + 1

        LblComputerCard1.Text = computercard1
        LblComputerCard2.Text = computercard2
        LblComputerCard3.Text = computercard3

        card1 = (10 * Rnd()) + 1
        card2 = (10 * Rnd()) + 1
        LblPLayerCard1.Text = card1
        LblPlayerCard2.Text = card2
        If counter = 1 Then
            card3 = (10 * Rnd()) + 1
            LblPlayerCard3.Text = card3
        ElseIf counter = 2 Then
            card4 = (10 * Rnd()) + 1
            LblPlayerCard4.Text = card4
        ElseIf counter = 3 Then
            card5 = (10 * Rnd()) + 1
            LblPlayerCard5.Text = card5
        ElseIf counter >= 4 Then
            MsgBox("you can no longer draw a card")
        End If


    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub BlackJack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        card1 = (10 * Rnd()) + 1
        card2 = (10 * Rnd()) + 1

    End Sub

    Private Sub BtnCheckScore_Click(sender As Object, e As EventArgs) Handles BtnCheckScore.Click
        BtnDrawCard.Enabled = False
        BtnCheckScore.Enabled = False
        Money = TxtBoxTotalMoney.Text
        If counter = 0 Then
            LblPlayerSum.Text = card1 + card2
        ElseIf counter = 1 Then
            LblPlayerSum.Text = card1 + card2 + card3
        ElseIf counter = 2 Then
            LblPlayerSum.Text = card1 + card2 + card3 + card4
        ElseIf counter = 3 Then
            LblPlayerSum.Text = card1 + card2 + card3 + card4 + card5
        End If
        LblComputerScore.Text = computercard1 + computercard2 + computercard3
        If LblPlayerSum.Text >= 21 And LblComputerScore.Text < 21 Then
            Money = Money + wager
            MsgBox("Congrats, you win!")
        ElseIf LblPlayerSum.Text < 21 And LblComputerScore.Text >= 21 Then
            MsgBox("sorry, you loose!")
            Money = Money - wager
        ElseIf LblPlayerSum.Text = 21 And LblComputerScore.Text = 21 Then
            MsgBox("It's a draw!")
            Money = Money
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles LblPlayerCard5.Click
    End Sub

    Private Sub BtnPlayAgain_Click(sender As Object, e As EventArgs) Handles BtnPlayAgain.Click
        BtnCheckScore.Enabled = True
        BtnDrawCard.Enabled = True
        LblComputerCard1.Text = " "
        LblComputerCard2.Text = " "
        LblComputerCard3.Text = " "
        LblPLayerCard1.Text = " "
        LblPlayerCard2.Text = " "
        LblPlayerCard3.Text = " "
        LblPlayerCard4.Text = " "
        LblPlayerCard5.Text = " "
        LblPlayerSum.Text = " "
        counter = 0
        LblComputerCard1.Visible = False
        LblComputerCard2.Visible = False
        LblComputerCard3.Visible = False

    End Sub
End Class