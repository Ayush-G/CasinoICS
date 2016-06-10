<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackJack
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBoxTotalMoney = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxWager = New System.Windows.Forms.TextBox()
        Me.BtnPlayAgain = New System.Windows.Forms.Button()
        Me.LblComputerScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblPlayerSum = New System.Windows.Forms.Label()
        Me.LblComputerCard3 = New System.Windows.Forms.Label()
        Me.LblComputerCard2 = New System.Windows.Forms.Label()
        Me.LblComputerCard1 = New System.Windows.Forms.Label()
        Me.LblPlayerCard5 = New System.Windows.Forms.Label()
        Me.LblPlayerCard4 = New System.Windows.Forms.Label()
        Me.LblPlayerCard3 = New System.Windows.Forms.Label()
        Me.LblPlayerCard2 = New System.Windows.Forms.Label()
        Me.LblPLayerCard1 = New System.Windows.Forms.Label()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnCheckScore = New System.Windows.Forms.Button()
        Me.BtnDrawCard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Total money:"
        '
        'TxtBoxTotalMoney
        '
        Me.TxtBoxTotalMoney.Location = New System.Drawing.Point(371, 9)
        Me.TxtBoxTotalMoney.Name = "TxtBoxTotalMoney"
        Me.TxtBoxTotalMoney.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxTotalMoney.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Place your wager:"
        '
        'TxtBoxWager
        '
        Me.TxtBoxWager.Location = New System.Drawing.Point(219, 9)
        Me.TxtBoxWager.Name = "TxtBoxWager"
        Me.TxtBoxWager.Size = New System.Drawing.Size(73, 20)
        Me.TxtBoxWager.TabIndex = 45
        '
        'BtnPlayAgain
        '
        Me.BtnPlayAgain.Location = New System.Drawing.Point(258, 396)
        Me.BtnPlayAgain.Name = "BtnPlayAgain"
        Me.BtnPlayAgain.Size = New System.Drawing.Size(75, 48)
        Me.BtnPlayAgain.TabIndex = 44
        Me.BtnPlayAgain.Text = "Play Again"
        Me.BtnPlayAgain.UseVisualStyleBackColor = True
        '
        'LblComputerScore
        '
        Me.LblComputerScore.AutoSize = True
        Me.LblComputerScore.Location = New System.Drawing.Point(596, 13)
        Me.LblComputerScore.Name = "LblComputerScore"
        Me.LblComputerScore.Size = New System.Drawing.Size(13, 13)
        Me.LblComputerScore.TabIndex = 43
        Me.LblComputerScore.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(635, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 42
        '
        'LblPlayerSum
        '
        Me.LblPlayerSum.AutoSize = True
        Me.LblPlayerSum.Location = New System.Drawing.Point(79, 13)
        Me.LblPlayerSum.Name = "LblPlayerSum"
        Me.LblPlayerSum.Size = New System.Drawing.Size(13, 13)
        Me.LblPlayerSum.TabIndex = 41
        Me.LblPlayerSum.Text = "0"
        '
        'LblComputerCard3
        '
        Me.LblComputerCard3.BackColor = System.Drawing.Color.Snow
        Me.LblComputerCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblComputerCard3.Location = New System.Drawing.Point(596, 70)
        Me.LblComputerCard3.Name = "LblComputerCard3"
        Me.LblComputerCard3.Size = New System.Drawing.Size(99, 139)
        Me.LblComputerCard3.TabIndex = 40
        Me.LblComputerCard3.Text = "0"
        '
        'LblComputerCard2
        '
        Me.LblComputerCard2.BackColor = System.Drawing.Color.Snow
        Me.LblComputerCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblComputerCard2.Location = New System.Drawing.Point(491, 72)
        Me.LblComputerCard2.Name = "LblComputerCard2"
        Me.LblComputerCard2.Size = New System.Drawing.Size(99, 137)
        Me.LblComputerCard2.TabIndex = 39
        Me.LblComputerCard2.Text = "0"
        '
        'LblComputerCard1
        '
        Me.LblComputerCard1.BackColor = System.Drawing.Color.Snow
        Me.LblComputerCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblComputerCard1.Location = New System.Drawing.Point(386, 72)
        Me.LblComputerCard1.Name = "LblComputerCard1"
        Me.LblComputerCard1.Size = New System.Drawing.Size(99, 137)
        Me.LblComputerCard1.TabIndex = 38
        Me.LblComputerCard1.Text = "0"
        '
        'LblPlayerCard5
        '
        Me.LblPlayerCard5.BackColor = System.Drawing.Color.Snow
        Me.LblPlayerCard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPlayerCard5.Location = New System.Drawing.Point(277, 222)
        Me.LblPlayerCard5.Name = "LblPlayerCard5"
        Me.LblPlayerCard5.Size = New System.Drawing.Size(100, 138)
        Me.LblPlayerCard5.TabIndex = 37
        Me.LblPlayerCard5.Text = "0"
        '
        'LblPlayerCard4
        '
        Me.LblPlayerCard4.BackColor = System.Drawing.Color.Snow
        Me.LblPlayerCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPlayerCard4.Location = New System.Drawing.Point(145, 222)
        Me.LblPlayerCard4.Name = "LblPlayerCard4"
        Me.LblPlayerCard4.Size = New System.Drawing.Size(99, 138)
        Me.LblPlayerCard4.TabIndex = 36
        Me.LblPlayerCard4.Text = "0"
        '
        'LblPlayerCard3
        '
        Me.LblPlayerCard3.BackColor = System.Drawing.Color.Snow
        Me.LblPlayerCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPlayerCard3.Location = New System.Drawing.Point(27, 222)
        Me.LblPlayerCard3.Name = "LblPlayerCard3"
        Me.LblPlayerCard3.Size = New System.Drawing.Size(96, 138)
        Me.LblPlayerCard3.TabIndex = 35
        Me.LblPlayerCard3.Text = "0"
        '
        'LblPlayerCard2
        '
        Me.LblPlayerCard2.BackColor = System.Drawing.Color.Snow
        Me.LblPlayerCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPlayerCard2.Location = New System.Drawing.Point(145, 57)
        Me.LblPlayerCard2.Name = "LblPlayerCard2"
        Me.LblPlayerCard2.Size = New System.Drawing.Size(99, 139)
        Me.LblPlayerCard2.TabIndex = 34
        Me.LblPlayerCard2.Text = "0"
        '
        'LblPLayerCard1
        '
        Me.LblPLayerCard1.BackColor = System.Drawing.Color.Snow
        Me.LblPLayerCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPLayerCard1.Location = New System.Drawing.Point(26, 57)
        Me.LblPLayerCard1.Name = "LblPLayerCard1"
        Me.LblPLayerCard1.Size = New System.Drawing.Size(96, 139)
        Me.LblPLayerCard1.TabIndex = 33
        Me.LblPLayerCard1.Text = "0"
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(348, 396)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(75, 48)
        Me.BtnQuit.TabIndex = 28
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnCheckScore
        '
        Me.BtnCheckScore.Location = New System.Drawing.Point(145, 396)
        Me.BtnCheckScore.Name = "BtnCheckScore"
        Me.BtnCheckScore.Size = New System.Drawing.Size(89, 48)
        Me.BtnCheckScore.TabIndex = 32
        Me.BtnCheckScore.Text = "Check Score"
        Me.BtnCheckScore.UseVisualStyleBackColor = True
        '
        'BtnDrawCard
        '
        Me.BtnDrawCard.Location = New System.Drawing.Point(13, 396)
        Me.BtnDrawCard.Name = "BtnDrawCard"
        Me.BtnDrawCard.Size = New System.Drawing.Size(109, 48)
        Me.BtnDrawCard.TabIndex = 31
        Me.BtnDrawCard.Text = "Draw Card"
        Me.BtnDrawCard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(495, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Opponent's Score:"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Location = New System.Drawing.Point(10, 13)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(63, 13)
        Me.LabelScore.TabIndex = 29
        Me.LabelScore.Text = "Your Score:"
        '
        'Blackjack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 458)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBoxTotalMoney)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBoxWager)
        Me.Controls.Add(Me.BtnPlayAgain)
        Me.Controls.Add(Me.LblComputerScore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblPlayerSum)
        Me.Controls.Add(Me.LblComputerCard3)
        Me.Controls.Add(Me.LblComputerCard2)
        Me.Controls.Add(Me.LblComputerCard1)
        Me.Controls.Add(Me.LblPlayerCard5)
        Me.Controls.Add(Me.LblPlayerCard4)
        Me.Controls.Add(Me.LblPlayerCard3)
        Me.Controls.Add(Me.LblPlayerCard2)
        Me.Controls.Add(Me.LblPLayerCard1)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnCheckScore)
        Me.Controls.Add(Me.BtnDrawCard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelScore)
        Me.Name = "Blackjack"
        Me.Text = "Blackjack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxTotalMoney As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxWager As TextBox
    Friend WithEvents BtnPlayAgain As Button
    Friend WithEvents LblComputerScore As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblPlayerSum As Label
    Friend WithEvents LblComputerCard3 As Label
    Friend WithEvents LblComputerCard2 As Label
    Friend WithEvents LblComputerCard1 As Label
    Friend WithEvents LblPlayerCard5 As Label
    Friend WithEvents LblPlayerCard4 As Label
    Friend WithEvents LblPlayerCard3 As Label
    Friend WithEvents LblPlayerCard2 As Label
    Friend WithEvents LblPLayerCard1 As Label
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnCheckScore As Button
    Friend WithEvents BtnDrawCard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelScore As Label
End Class
