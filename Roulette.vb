''' <summary>
''' By Ayush Gupta
''' 10/06/2016
''' Roulette game.
''' Purpose: Game - Win Money (hopefully)
''' </summary>

Public Class Roulette
    Dim Buttons(45) As Button 'Array for all the buttons
    Dim intWager As Integer 'User's wager
    Dim wagerType As String 'Type of wager
    Dim count As Integer 'The count of rotation ticks of wheel
    Dim StopChance As Integer 'RND for the stopping of wheel
    Dim WinNum As Integer 'The winning number
    Dim imlist2Real(37) As Integer 'Shows the printed number for each slot in the wheel
    Dim Real2Colour(37) As Integer 'Dims the colour of the numbers
    Dim stopColour As Integer 'Stopped colour

    Private Sub Buttons_Click(sender As Object, e As EventArgs)
        'Makes sure they can play, then reduces the wager from the money and calls the spin sub routine
        If intWager >= Money Then
            lblWager.Text = "Wager: Invalid"
        Else
            intWager = nudWager.Value
            Money = Money - intWager
            lblWager.Text = "Wager: $" & intWager
            lblMoney.Text = "Money: $" & Money
            'Shows the label with what they're losing
            lblMoney.Text = "Money: $" & Money & " - $" & intWager
            System.Threading.Thread.Sleep(1000)
            lblMoney.Text = "Money: $" & Money
            wagerType = sender.text
            spinRoulette()
        End If

    End Sub

    Private Sub Roulette_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        lblMoney.Text = "Money: $" & Money 'Gets money from other games (if applicable) (Global variable)
        lblName.Text = "Name: " & playerName 'Same as above

        'Adds all the buttons in the form to the array and handles with the Buttons_Click sub
        Dim cntrl As Control
        Dim x As Integer = 0
        For Each cntrl In Me.Controls
            If TypeOf (cntrl) Is Button Then
                If Not (cntrl.Name = "btnMax" Or cntrl.Name = "btnInstructions" Or cntrl.Name = "btnExit") Then
                    Buttons(x) = cntrl
                    AddHandler Buttons(x).Click, AddressOf Buttons_Click
                    x = x + 1
                End If
            End If

        Next

        'Assigns the image value to the associated space value
        imlist2Real(0) = 0
        imlist2Real(1) = 26
        imlist2Real(2) = 3
        imlist2Real(3) = 35
        imlist2Real(4) = 12
        imlist2Real(5) = 28
        imlist2Real(6) = 7
        imlist2Real(7) = 29
        imlist2Real(8) = 18
        imlist2Real(9) = 22
        imlist2Real(10) = 9
        imlist2Real(11) = 31
        imlist2Real(12) = 14
        imlist2Real(13) = 20
        imlist2Real(14) = 1
        imlist2Real(15) = 33
        imlist2Real(16) = 16
        imlist2Real(17) = 24
        imlist2Real(18) = 5
        imlist2Real(19) = 10
        imlist2Real(20) = 23
        imlist2Real(21) = 8
        imlist2Real(22) = 30
        imlist2Real(23) = 11
        imlist2Real(24) = 36
        imlist2Real(25) = 13
        imlist2Real(26) = 27
        imlist2Real(27) = 6
        imlist2Real(28) = 34
        imlist2Real(29) = 17
        imlist2Real(30) = 25
        imlist2Real(31) = 2
        imlist2Real(32) = 21
        imlist2Real(33) = 4
        imlist2Real(34) = 19
        imlist2Real(35) = 15
        imlist2Real(36) = 32
        imlist2Real(37) = 0

        'Sets the colours associated with the number
        Real2Colour(0) = 2
        Real2Colour(1) = 0
        Real2Colour(2) = 1
        Real2Colour(3) = 0
        Real2Colour(4) = 1
        Real2Colour(5) = 0
        Real2Colour(6) = 1
        Real2Colour(7) = 0
        Real2Colour(8) = 1
        Real2Colour(9) = 0
        Real2Colour(10) = 1
        Real2Colour(11) = 1
        Real2Colour(12) = 0
        Real2Colour(13) = 1
        Real2Colour(14) = 0
        Real2Colour(15) = 1
        Real2Colour(16) = 0
        Real2Colour(17) = 1
        Real2Colour(18) = 0
        Real2Colour(19) = 0
        Real2Colour(20) = 1
        Real2Colour(21) = 0
        Real2Colour(22) = 1
        Real2Colour(23) = 0
        Real2Colour(24) = 1
        Real2Colour(25) = 0
        Real2Colour(26) = 1
        Real2Colour(27) = 0
        Real2Colour(28) = 1
        Real2Colour(29) = 1
        Real2Colour(30) = 0
        Real2Colour(31) = 1
        Real2Colour(32) = 0
        Real2Colour(33) = 1
        Real2Colour(34) = 0
        Real2Colour(35) = 1
        Real2Colour(36) = 0
        Real2Colour(37) = 2


        PictureBox1.Visible = False 'Can't see wheel
        lblInstructions.Visible = False 'Hides instructions
    End Sub

    Sub spinRoulette()
        'Spins the wheel, plays sound.
        For x = 0 To 45
            Buttons(x).Visible = False
        Next
        PictureBox1.Visible = True
        timRoulette.Start()
        My.Computer.Audio.Play(My.Resources.Roulette_sound_effect, AudioPlayMode.BackgroundLoop)
        count = 1
    End Sub

    Private Sub timRoulette_Tick(sender As Object, e As EventArgs) Handles timRoulette.Tick
        'Replaces the picture with a rotated one each tick, has a chance to stop each tick (makes it truly random)
        PictureBox1.Image = imlRouletteWheel.Images(count)
        StopChance = 40 * Rnd()

        'Once stopped, stops music and runs the Winmoney function and resetboard subroutine
        If StopChance = 10 Then
            timRoulette.Stop()
            My.Computer.Audio.Stop()
            WinNum = imlist2Real(count)
            stopColour = Real2Colour(WinNum)
            If stopColour = 0 Then
                MsgBox("Winning number: " & WinNum & vbCrLf & "Winning colour: Red", 0, "Winning Stats")
            ElseIf stopColour = 1 Then
                MsgBox("Winning number: " & WinNum & vbCrLf & "Winning colour: Black", 0, "Winning Stats")
            ElseIf stopColour = 2 Then
                MsgBox("Winning number: " & WinNum & vbCrLf & "Winning colour: Green", 0, "Winning Stats")
            End If
            Money += WinMoney(WinNum, wagerType, stopColour)
            lblMoney.Text = "Money: $" & Money
            ResetBoard()
        End If

        'Resets after complete rotation
        If count = 37 Then
            count = 1
        Else count += 1
        End If
    End Sub

    Function WinMoney(ByVal ChosenNum As Integer, ByVal TypeWager As String, ByVal spotColour As Integer) As Integer
        'if they picked a specific number and get it, they get more money
        If (IsNumeric(TypeWager) = True) Then
            If TypeWager = ChosenNum Then
                WinMoney = intWager * 20
            End If
            'Compares the winning number against the users choice, gives appropriate points
        ElseIf TypeWager = "RED" And (spotColour = 0) Then
            WinMoney = intWager * 2
        ElseIf TypeWager = "BLACK" And (spotColour = 1) Then
            WinMoney = intWager * 2
        ElseIf TypeWager = "EVEN" And (ChosenNum Mod 2 = 0) Then
            WinMoney = intWager * 2
        ElseIf TypeWager = "ODD" And (ChosenNum Mod 2 <> 0) Then
            WinMoney = intWager * 2
        ElseIf TypeWager = "1 TO 18" And (ChosenNum > 0 And ChosenNum < 19) Then
            WinMoney = intWager * 2
        ElseIf TypeWager = "19 TO 36" And (ChosenNum > 18 And ChosenNum <= 36) Then
            WinMoney = intWager * 2
        ElseIf TypeWager = "1st 12" And (ChosenNum > 0 And ChosenNum <= 12) Then
            WinMoney = intWager * 3
        ElseIf TypeWager = "2nd 12" And (ChosenNum > 12 And ChosenNum <= 24) Then
            WinMoney = intWager * 3
        ElseIf TypeWager = "3rd 12" And (ChosenNum > 24 And ChosenNum <= 36) Then
            WinMoney = intWager * 3
        Else WinMoney = 0 'If you lose
        End If
        'Shows a label with winnings
        lblMoney.Text = "Money: $" & Money & " + $" & WinMoney
        System.Threading.Thread.Sleep(1000)
        lblMoney.Text = "Money: $" & Money
        Return WinMoney
    End Function

    Sub ResetBoard()
        'Brings buttons back
        For x = 0 To UBound(Buttons)
            Buttons(x).Visible = True
        Next
        PictureBox1.Visible = False
        'resets vars
        wagerType = ""
        intWager = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Takes back to main menu
        My.Computer.Audio.Stop()
        My.Forms.MainMenu.lblMoney.Text = "Money: $" & Money
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub Instructions_Hover(sender As Object, e As EventArgs) Handles btnInstructions.MouseHover
        'Shows instructions
        lblInstructions.Visible = True
    End Sub
    Private Sub Instructions_Leave(sender As Object, e As EventArgs) Handles btnInstructions.MouseLeave
        'Hides instructions
        lblInstructions.Visible = False
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        'Max bet
        nudWager.Value = Money
    End Sub
End Class