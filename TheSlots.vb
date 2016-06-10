Public Class TheSlots
    Dim Wager As Integer 'Users wager
    Dim rndSlot1, rndSlot2, rndSlot3 As Integer 'Randomizes the slots
    Dim StopCounter As Integer 'Number of stopped image
    Dim FreeSpins As Integer = 0 'Free Spins!

    Private Sub TheSlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows global var. in form
        Randomize()
        lblMoney.Text = "Money: $" & Money
        lblName.Text = "Name: " & playerName

        lblInstructions.Visible = False 'Hides the instructions
    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        'Uses the free spin if they got one
        If FreeSpins > 0 Then
            FreeSpins -= 1
            lblFreeSpins.Text = "Free Spins: " & FreeSpins
            timSpin1.Start()
            timSpin2.Start()
            timSpin3.Start()
            My.Computer.Audio.Play(My.Resources.Slot_Machine_Jackpot_Sound_Effect, AudioPlayMode.BackgroundLoop)
        Else
            'Makes sure they can pay
            If nudWager.Value > Money Then
                lblWager.Text = "Wager: Invalid"
            Else
                'Sets the money starts the spinners
                Wager = nudWager.Value
                Money -= Wager
                lblWager.Text = "Wager: $" & Wager
                lblMoney.Text = "Money: $" & Money
                'Shows the label with money wager
                lblMoney.Text = "Money: $" & Money & " - $" & Wager
                System.Threading.Thread.Sleep(1000)
                lblMoney.Text = "Money: $" & Money
                timSpin1.Start()
                timSpin2.Start()
                timSpin3.Start()
                'Play spin sound
                My.Computer.Audio.Play(My.Resources.Slot_Machine_Jackpot_Sound_Effect, AudioPlayMode.BackgroundLoop)
            End If
        End If
    End Sub

    Private Sub timSpin1_Tick(sender As Object, e As EventArgs) Handles timSpin1.Tick
        'Alternates between images 
        rndSlot1 = 8 * Rnd()
        picSlot1.Image = imlSlots.Images(rndSlot1)
        'Random chance to stop
        StopCounter = 20 * Rnd()
        If StopCounter = 10 Then
            timSpin1.Stop()
        End If
    End Sub

    Private Sub timSpin2_Tick(sender As Object, e As EventArgs) Handles timSpin2.Tick
        'Spins between images
        rndSlot2 = 8 * Rnd()
        picSlot2.Image = imlSlots.Images(rndSlot2)
        'Random stop
        StopCounter = 20 * Rnd()
        If StopCounter = 10 And timSpin1.Enabled = False Then 'Only stops if first is stopped, like real slots
            timSpin2.Stop()
        End If
    End Sub

    Private Sub timSpin3_Tick(sender As Object, e As EventArgs) Handles timSpin3.Tick
        'Random image spin
        rndSlot3 = 8 * Rnd()
        picSlot3.Image = imlSlots.Images(rndSlot3)
        StopCounter = 20 * Rnd()
        If StopCounter = 10 And timSpin1.Enabled = False And timSpin2.Enabled = False Then 'Stops if previous have been stopped
            timSpin3.Stop()
            Money += Winnings(rndSlot1, rndSlot2, rndSlot3, Wager, FreeSpins) 'Calls the Win function with the stop positions of the slots and wager 
            lblMoney.Text = "Money: $" & Money 'Updates labels
            lblFreeSpins.Text = "Free Spins: " & FreeSpins
            My.Computer.Audio.Stop() 'Stops music
        End If
    End Sub

    Private Sub btnInstructions_MouseHover(sender As Object, e As EventArgs) Handles btnInstructions.MouseHover
        'Shows instructions
        lblInstructions.Visible = True
    End Sub

    Private Sub btnInstructions_MouseLeave(sender As Object, e As EventArgs) Handles btnInstructions.MouseLeave
        'Hides instructions
        lblInstructions.Visible = False
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        'Max bet
        nudWager.Value = Money
    End Sub

    Function Winnings(ByVal pic1 As Integer, ByVal pic2 As Integer, ByVal pic3 As Integer, ByVal wager As Integer, ByRef FreeSpin As Integer) As Integer
        'Calculates winnings based on the type and number of identical slots, adds free spins if token
        If (rndSlot1 = 7 And rndSlot2 = 7) Or (rndSlot1 = 7 And rndSlot3 = 7) Or (rndSlot2 = 7 And rndSlot3 = 7) Then
            FreeSpin += 1
        ElseIf (rndSlot1 = 7 And rndSlot2 = 7 And rndSlot3 = 7) Then
            FreeSpin += 3
        ElseIf (rndSlot1 = 2 And rndSlot2 = 2 And rndSlot3 = 2) Then
            Winnings = wager * 20
        ElseIf rndSlot1 = 3 And rndSlot2 = 3 And rndSlot3 = 3 Then
            Winnings = wager * 10
        ElseIf (rndSlot1 = 3 And rndSlot2 = 3 And rndSlot3 = 3) Then
            Winnings = wager * 15
        ElseIf (rndSlot1 = 3 And rndSlot2 = 3) Or (rndSlot1 = 3 And rndSlot3 = 3) Or (rndSlot2 = 3 And rndSlot3 = 3) Then
            Winnings = wager * 10
        ElseIf (rndSlot1 = 2 And rndSlot2 = 2) Or (rndSlot1 = 2 And rndSlot3 = 2) Or (rndSlot2 = 2 And rndSlot3 = 2) Then
            Winnings = wager * 15
        ElseIf rndSlot1 = rndSlot2 Or rndSlot1 = rndSlot3 Or rndSlot2 = rndSlot3 Then
            Winnings = wager * 2
        Else Winnings = 0
        End If
        'Shows the label with winnings for 1 sec
        lblMoney.Text = "Money: $" & Money & " + $" & Winnings
        System.Threading.Thread.Sleep(1000)
        lblMoney.Text = "Money: $" & Money
        Return Winnings
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Takes user back to main menu
        My.Forms.MainMenu.lblMoney.Text = "Money: $" & Money
        Me.Close()
        MainMenu.Show()
    End Sub

End Class