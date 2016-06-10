<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bingo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bingo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.A1 = New System.Windows.Forms.Label()
        Me.A2 = New System.Windows.Forms.Label()
        Me.A3 = New System.Windows.Forms.Label()
        Me.A4 = New System.Windows.Forms.Label()
        Me.A5 = New System.Windows.Forms.Label()
        Me.B1 = New System.Windows.Forms.Label()
        Me.B2 = New System.Windows.Forms.Label()
        Me.B3 = New System.Windows.Forms.Label()
        Me.B4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.B4)
        Me.Panel1.Controls.Add(Me.B3)
        Me.Panel1.Controls.Add(Me.B2)
        Me.Panel1.Controls.Add(Me.B1)
        Me.Panel1.Controls.Add(Me.A5)
        Me.Panel1.Controls.Add(Me.A4)
        Me.Panel1.Controls.Add(Me.A3)
        Me.Panel1.Controls.Add(Me.A2)
        Me.Panel1.Controls.Add(Me.A1)
        Me.Panel1.Location = New System.Drawing.Point(27, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 543)
        Me.Panel1.TabIndex = 0
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(78, 146)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(20, 13)
        Me.A1.TabIndex = 0
        Me.A1.Text = "A1"
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(178, 146)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(20, 13)
        Me.A2.TabIndex = 1
        Me.A2.Text = "A2"
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(275, 146)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(20, 13)
        Me.A3.TabIndex = 2
        Me.A3.Text = "A3"
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(366, 146)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(20, 13)
        Me.A4.TabIndex = 3
        Me.A4.Text = "A4"
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Location = New System.Drawing.Point(459, 147)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(20, 13)
        Me.A5.TabIndex = 4
        Me.A5.Text = "A5"
        '
        'B1
        '
        Me.B1.AutoSize = True
        Me.B1.Location = New System.Drawing.Point(78, 227)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(20, 13)
        Me.B1.TabIndex = 5
        Me.B1.Text = "B1"
        '
        'B2
        '
        Me.B2.AutoSize = True
        Me.B2.Location = New System.Drawing.Point(178, 227)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(20, 13)
        Me.B2.TabIndex = 6
        Me.B2.Text = "B2"
        '
        'B3
        '
        Me.B3.AutoSize = True
        Me.B3.Location = New System.Drawing.Point(275, 227)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(20, 13)
        Me.B3.TabIndex = 7
        Me.B3.Text = "B3"
        '
        'B4
        '
        Me.B4.AutoSize = True
        Me.B4.Location = New System.Drawing.Point(366, 227)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(20, 13)
        Me.B4.TabIndex = 8
        Me.B4.Text = "B4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(459, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "B5"
        '
        'Bingo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 604)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Bingo"
        Me.Text = "Bingo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents B4 As Label
    Friend WithEvents B3 As Label
    Friend WithEvents B2 As Label
    Friend WithEvents B1 As Label
    Friend WithEvents A5 As Label
    Friend WithEvents A4 As Label
    Friend WithEvents A3 As Label
    Friend WithEvents A2 As Label
    Friend WithEvents A1 As Label
End Class
