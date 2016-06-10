<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnBingo = New System.Windows.Forms.Button()
        Me.btnLottery = New System.Windows.Forms.Button()
        Me.btnBlackJack = New System.Windows.Forms.Button()
        Me.btnSlots = New System.Windows.Forms.Button()
        Me.btnRoulette = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBingo
        '
        Me.btnBingo.BackgroundImage = CType(resources.GetObject("btnBingo.BackgroundImage"), System.Drawing.Image)
        Me.btnBingo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBingo.Location = New System.Drawing.Point(15, 372)
        Me.btnBingo.Name = "btnBingo"
        Me.btnBingo.Size = New System.Drawing.Size(239, 161)
        Me.btnBingo.TabIndex = 13
        Me.btnBingo.UseVisualStyleBackColor = True
        '
        'btnLottery
        '
        Me.btnLottery.BackgroundImage = CType(resources.GetObject("btnLottery.BackgroundImage"), System.Drawing.Image)
        Me.btnLottery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLottery.Location = New System.Drawing.Point(15, 202)
        Me.btnLottery.Name = "btnLottery"
        Me.btnLottery.Size = New System.Drawing.Size(239, 164)
        Me.btnLottery.TabIndex = 12
        Me.btnLottery.UseVisualStyleBackColor = True
        '
        'btnBlackJack
        '
        Me.btnBlackJack.BackgroundImage = CType(resources.GetObject("btnBlackJack.BackgroundImage"), System.Drawing.Image)
        Me.btnBlackJack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBlackJack.Location = New System.Drawing.Point(276, 202)
        Me.btnBlackJack.Name = "btnBlackJack"
        Me.btnBlackJack.Size = New System.Drawing.Size(239, 164)
        Me.btnBlackJack.TabIndex = 11
        Me.btnBlackJack.UseVisualStyleBackColor = True
        '
        'btnSlots
        '
        Me.btnSlots.BackgroundImage = CType(resources.GetObject("btnSlots.BackgroundImage"), System.Drawing.Image)
        Me.btnSlots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlots.Location = New System.Drawing.Point(276, 32)
        Me.btnSlots.Name = "btnSlots"
        Me.btnSlots.Size = New System.Drawing.Size(239, 164)
        Me.btnSlots.TabIndex = 10
        Me.btnSlots.UseVisualStyleBackColor = True
        '
        'btnRoulette
        '
        Me.btnRoulette.BackgroundImage = CType(resources.GetObject("btnRoulette.BackgroundImage"), System.Drawing.Image)
        Me.btnRoulette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRoulette.Location = New System.Drawing.Point(15, 32)
        Me.btnRoulette.Name = "btnRoulette"
        Me.btnRoulette.Size = New System.Drawing.Size(239, 164)
        Me.btnRoulette.TabIndex = 9
        Me.btnRoulette.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.Teal
        Me.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStats.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.ForeColor = System.Drawing.Color.White
        Me.btnStats.Location = New System.Drawing.Point(420, 372)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(95, 47)
        Me.btnStats.TabIndex = 15
        Me.btnStats.Text = "Stats"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.Teal
        Me.pnlStats.Controls.Add(Me.lblName)
        Me.pnlStats.Controls.Add(Me.lblMoney)
        Me.pnlStats.Location = New System.Drawing.Point(276, 419)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(239, 95)
        Me.pnlStats.TabIndex = 16
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(7, 17)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(75, 26)
        Me.lblName.TabIndex = 52
        Me.lblName.Text = "Name: "
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.White
        Me.lblMoney.Location = New System.Drawing.Point(7, 54)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(84, 26)
        Me.lblMoney.TabIndex = 51
        Me.lblMoney.Text = "Money: "
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Sienna
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(530, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 32)
        Me.btnExit.TabIndex = 52
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(664, 545)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnBingo)
        Me.Controls.Add(Me.btnLottery)
        Me.Controls.Add(Me.btnBlackJack)
        Me.Controls.Add(Me.btnSlots)
        Me.Controls.Add(Me.btnRoulette)
        Me.Name = "MainMenu"
        Me.Text = "Form1"
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStats.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBingo As Button
    Friend WithEvents btnLottery As Button
    Friend WithEvents btnBlackJack As Button
    Friend WithEvents btnSlots As Button
    Friend WithEvents btnRoulette As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents pnlStats As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents btnExit As Button
End Class
