Public Class bingo
    Dim CardLbl(4, 4) As Label
    Dim mypoint As Point
    Dim cardpnl(1, 2) As Panel
    Dim panelpoint As Point
    Private Sub Bingo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mypoint.X = 78
            mypoint.Y = 147

        panelpoint.X = 27
            panelpoint.Y = 12



        For x = 0 To UBound(CardLbl)
            For y = 0 To UBound(CardLbl)
                CardLbl(x, y).Location = mypoint
                CardLbl(x, y).Height = 10
                CardLbl(x, y).Width = 10
                mypoint.Y = mypoint.Y + 79
                CardLbl(x, y).BackColor = Color.DarkViolet
            Next
            mypoint.X = mypoint.X + 100
        Next

        ' For a = 0 To UBound(cardpnl)
        'For b = 0 To UBound(cardpnl)
        '  cardpnl(a, b).Location = panelpoint
        '  cardpnl(a, b) = New Panel
        '  cardpnl(a, b).Height = 1000
        'cardpnl(a, b).Width = 1000
        'cardpnl(a, b).BackColor = Color.Magenta
        ' For x = 1 To UBound(CardLbl)
        ' For y = 1 To UBound(CardLbl)
        '  CardLbl(x, y).Location = mypoint
        'CardLbl(x, y) = New Label
        'CardLbl(x, y).Height = 10
        'CardLbl(x, y).Width = 10

        'mypoint.X = mypoint.X + 100

        'CardLbl(x, y).Text = "thomas" 'Int(100 * Rnd() + 1)
        'Next
        'Next
        'Next
        'Next
    End Sub

        Private Sub PnlChoice_Paint(sender As Object, e As PaintEventArgs) Handles PnlChoice.Paint
            ' Dim cardbtn(4) As Button
            PnlChoice.Visible = False
        End Sub

        Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        End Sub

    End Class