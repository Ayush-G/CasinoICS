<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheSlots
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheSlots))
        Me.lblWager = New System.Windows.Forms.Label()
        Me.nudWager = New System.Windows.Forms.NumericUpDown()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.imlSlots = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.timSpin1 = New System.Windows.Forms.Timer(Me.components)
        Me.timSpin2 = New System.Windows.Forms.Timer(Me.components)
        Me.timSpin3 = New System.Windows.Forms.Timer(Me.components)
        Me.lblFreeSpins = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picSlot3 = New System.Windows.Forms.PictureBox()
        Me.picSlot2 = New System.Windows.Forms.PictureBox()
        Me.picSlot1 = New System.Windows.Forms.PictureBox()
        Me.picSlot = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        CType(Me.nudWager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWager
        '
        Me.lblWager.AutoSize = True
        Me.lblWager.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWager.Location = New System.Drawing.Point(12, 44)
        Me.lblWager.Name = "lblWager"
        Me.lblWager.Size = New System.Drawing.Size(79, 26)
        Me.lblWager.TabIndex = 52
        Me.lblWager.Text = "Wager: "
        '
        'nudWager
        '
        Me.nudWager.BackColor = System.Drawing.Color.Green
        Me.nudWager.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudWager.ForeColor = System.Drawing.Color.White
        Me.nudWager.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudWager.Location = New System.Drawing.Point(17, 73)
        Me.nudWager.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudWager.Name = "nudWager"
        Me.nudWager.Size = New System.Drawing.Size(68, 33)
        Me.nudWager.TabIndex = 51
        Me.nudWager.ThousandsSeparator = True
        Me.nudWager.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(12, 9)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(84, 26)
        Me.lblMoney.TabIndex = 50
        Me.lblMoney.Text = "Money: "
        '
        'imlSlots
        '
        Me.imlSlots.ImageStream = CType(resources.GetObject("imlSlots.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlSlots.TransparentColor = System.Drawing.Color.Transparent
        Me.imlSlots.Images.SetKeyName(0, "Banana.png")
        Me.imlSlots.Images.SetKeyName(1, "Cherry.png")
        Me.imlSlots.Images.SetKeyName(2, "Coins.png")
        Me.imlSlots.Images.SetKeyName(3, "Diamond.png")
        Me.imlSlots.Images.SetKeyName(4, "Grape.png")
        Me.imlSlots.Images.SetKeyName(5, "Lemon.png")
        Me.imlSlots.Images.SetKeyName(6, "Strawberry.png")
        Me.imlSlots.Images.SetKeyName(7, "Token.png")
        Me.imlSlots.Images.SetKeyName(8, "Watermelon.png")
        '
        'btnSpin
        '
        Me.btnSpin.BackColor = System.Drawing.Color.Red
        Me.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpin.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpin.ForeColor = System.Drawing.Color.White
        Me.btnSpin.Location = New System.Drawing.Point(434, 463)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(183, 47)
        Me.btnSpin.TabIndex = 56
        Me.btnSpin.Text = "SPIN"
        Me.btnSpin.UseVisualStyleBackColor = False
        '
        'timSpin1
        '
        '
        'timSpin2
        '
        '
        'timSpin3
        '
        '
        'lblFreeSpins
        '
        Me.lblFreeSpins.AutoSize = True
        Me.lblFreeSpins.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreeSpins.Location = New System.Drawing.Point(176, 477)
        Me.lblFreeSpins.Name = "lblFreeSpins"
        Me.lblFreeSpins.Size = New System.Drawing.Size(107, 26)
        Me.lblFreeSpins.TabIndex = 57
        Me.lblFreeSpins.Text = "Free Spins:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(468, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(70, 26)
        Me.lblName.TabIndex = 58
        Me.lblName.Text = "Name:"
        '
        'picSlot3
        '
        Me.picSlot3.Image = Global.CasinoGame.My.Resources.Resources.Coins1
        Me.picSlot3.Location = New System.Drawing.Point(648, 151)
        Me.picSlot3.Name = "picSlot3"
        Me.picSlot3.Size = New System.Drawing.Size(215, 280)
        Me.picSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSlot3.TabIndex = 55
        Me.picSlot3.TabStop = False
        '
        'picSlot2
        '
        Me.picSlot2.Image = Global.CasinoGame.My.Resources.Resources.Coins1
        Me.picSlot2.Location = New System.Drawing.Point(416, 151)
        Me.picSlot2.Name = "picSlot2"
        Me.picSlot2.Size = New System.Drawing.Size(215, 280)
        Me.picSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSlot2.TabIndex = 54
        Me.picSlot2.TabStop = False
        '
        'picSlot1
        '
        Me.picSlot1.Image = Global.CasinoGame.My.Resources.Resources.Coins
        Me.picSlot1.Location = New System.Drawing.Point(181, 152)
        Me.picSlot1.Name = "picSlot1"
        Me.picSlot1.Size = New System.Drawing.Size(215, 280)
        Me.picSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSlot1.TabIndex = 53
        Me.picSlot1.TabStop = False
        '
        'picSlot
        '
        Me.picSlot.BackgroundImage = Global.CasinoGame.My.Resources.Resources.slot_machine
        Me.picSlot.Location = New System.Drawing.Point(163, 118)
        Me.picSlot.Name = "picSlot"
        Me.picSlot.Size = New System.Drawing.Size(722, 339)
        Me.picSlot.TabIndex = 0
        Me.picSlot.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Sienna
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(796, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 32)
        Me.btnExit.TabIndex = 59
        Me.btnExit.Text = "Main Menu"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BackColor = System.Drawing.Color.Teal
        Me.lblInstructions.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(451, 79)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(467, 130)
        Me.lblInstructions.TabIndex = 60
        Me.lblInstructions.Text = "1. Pick your wager." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Click the spin button. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Watch it spin. You are hoping" &
    " to get multiple" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the same, preferably coins or tokens or diamonds." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. Ez mo" &
    "ney!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.Teal
        Me.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstructions.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.Color.White
        Me.btnInstructions.Location = New System.Drawing.Point(796, 44)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(122, 32)
        Me.btnInstructions.TabIndex = 61
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        Me.btnMax.BackColor = System.Drawing.Color.Coral
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMax.ForeColor = System.Drawing.Color.White
        Me.btnMax.Location = New System.Drawing.Point(17, 112)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(122, 32)
        Me.btnMax.TabIndex = 62
        Me.btnMax.Text = "Max Bet"
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'TheSlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(930, 561)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblFreeSpins)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.picSlot3)
        Me.Controls.Add(Me.picSlot2)
        Me.Controls.Add(Me.picSlot1)
        Me.Controls.Add(Me.lblWager)
        Me.Controls.Add(Me.nudWager)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.picSlot)
        Me.Name = "TheSlots"
        Me.Text = "The Slots"
        CType(Me.nudWager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSlot As PictureBox
    Friend WithEvents lblWager As Label
    Friend WithEvents nudWager As NumericUpDown
    Friend WithEvents lblMoney As Label
    Friend WithEvents picSlot1 As PictureBox
    Friend WithEvents picSlot2 As PictureBox
    Friend WithEvents picSlot3 As PictureBox
    Friend WithEvents imlSlots As ImageList
    Friend WithEvents btnSpin As Button
    Friend WithEvents timSpin1 As Timer
    Friend WithEvents timSpin2 As Timer
    Friend WithEvents timSpin3 As Timer
    Friend WithEvents lblFreeSpins As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnMax As Button
End Class
