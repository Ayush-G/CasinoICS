''' <summary>
''' By Ayush Gupta, Thomas Brown
''' 09/06/2016
''' Purpose: Navigation and Stats home for the game.
''' </summary>
Public Module GlobalVariables
    'Declare money and name as a global variable to use in other forms
    Public Money As Integer
    Public playerName As String
End Module

Public Class MainMenu

    Private Sub MainMenu_ReLoad(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        'when they come back to form they may get kicked out if they have no money
        My.Computer.Audio.Stop()
        If Money = 0 Then
            MsgBox("Get out of my casino, come back when you get a paycheck!")
            End
        End If
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gives them the initial money and sets the name
        My.Computer.Audio.Stop()
        Money = 100 'Initial amount of money
        playerName = StrConv(InputBox("Input Name: ", "Name"), vbProperCase)
        lblMoney.Text = "Money: $" & Money
        lblName.Text = "Name: " & playerName
        pnlStats.Hide()
    End Sub


    Private Sub btnRoulette_Click(sender As Object, e As EventArgs) Handles btnRoulette.Click
        'Goes to roulette
        Me.Hide()
        Roulette.Show()
    End Sub

    Private Sub btnSlots_Click(sender As Object, e As EventArgs) Handles btnSlots.Click
        'Goes to slots
        Me.Hide()
        TheSlots.Show()

    End Sub

    Private Sub btnStats_MouseHover(sender As Object, e As EventArgs) Handles btnStats.MouseHover
        'On mouse hover they can see stats
        pnlStats.Show()
    End Sub
    Private Sub btnStats_MouseLeave(sender As Object, e As EventArgs) Handles btnStats.MouseLeave
        'Stats go away when mouse is removed
        pnlStats.Hide()
    End Sub

    Private Sub btnBlackJack_Click(sender As Object, e As EventArgs) Handles btnBlackJack.Click
        'Switch to bj
        Me.Hide()
        BlackJack.Show()
    End Sub

    Private Sub btnLottery_Click(sender As Object, e As EventArgs) Handles btnLottery.Click
        'go to lottery
        Me.Hide()
        Lottery.show()
    End Sub

    Private Sub btnBingo_Click(sender As Object, e As EventArgs) Handles btnBingo.Click
        'go to bingo
        Me.Hide()
        Bingo.show()
    End Sub
End Class
