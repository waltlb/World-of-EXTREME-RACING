<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Track1
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblMap = New System.Windows.Forms.Label()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRecharge = New System.Windows.Forms.Timer(Me.components)
        Me.picFPV = New System.Windows.Forms.PictureBox()
        Me.picMapCar = New System.Windows.Forms.PictureBox()
        Me.picMap = New System.Windows.Forms.PictureBox()
        Me.picTrack = New System.Windows.Forms.PictureBox()
        Me.Wall1 = New System.Windows.Forms.Label()
        Me.Wall2 = New System.Windows.Forms.Label()
        Me.Wall3 = New System.Windows.Forms.Label()
        Me.Wall4 = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.picHeart1 = New System.Windows.Forms.PictureBox()
        Me.picHeart3 = New System.Windows.Forms.PictureBox()
        Me.picHeart2 = New System.Windows.Forms.PictureBox()
        Me.picCoinMiddle = New System.Windows.Forms.PictureBox()
        Me.picCoinLeft = New System.Windows.Forms.PictureBox()
        Me.picCoinRight = New System.Windows.Forms.PictureBox()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.picLeft = New System.Windows.Forms.PictureBox()
        Me.picRight = New System.Windows.Forms.PictureBox()
        CType(Me.picFPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMapCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTrack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCoinMiddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCoinLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCoinRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Black
        Me.lblStatus.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(213, 169)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(150, 50)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(22, 13)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(35, 13)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "Score"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(123, 13)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(30, 13)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Time"
        '
        'lblMap
        '
        Me.lblMap.AutoSize = True
        Me.lblMap.Location = New System.Drawing.Point(817, 55)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(28, 13)
        Me.lblMap.TabIndex = 8
        Me.lblMap.Text = "Map"
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'tmrRecharge
        '
        Me.tmrRecharge.Interval = 1000
        '
        'picFPV
        '
        Me.picFPV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picFPV.BackColor = System.Drawing.Color.Transparent
        Me.picFPV.Image = Global.FinalProject.My.Resources.Resources.FPVStraight
        Me.picFPV.Location = New System.Drawing.Point(242, 455)
        Me.picFPV.Name = "picFPV"
        Me.picFPV.Size = New System.Drawing.Size(284, 112)
        Me.picFPV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFPV.TabIndex = 15
        Me.picFPV.TabStop = False
        '
        'picMapCar
        '
        Me.picMapCar.Image = Global.FinalProject.My.Resources.Resources.carDown1
        Me.picMapCar.Location = New System.Drawing.Point(908, 220)
        Me.picMapCar.Name = "picMapCar"
        Me.picMapCar.Size = New System.Drawing.Size(17, 10)
        Me.picMapCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMapCar.TabIndex = 10
        Me.picMapCar.TabStop = False
        '
        'picMap
        '
        Me.picMap.Image = Global.FinalProject.My.Resources.Resources.track1
        Me.picMap.Location = New System.Drawing.Point(820, 71)
        Me.picMap.Name = "picMap"
        Me.picMap.Size = New System.Drawing.Size(147, 306)
        Me.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMap.TabIndex = 3
        Me.picMap.TabStop = False
        '
        'picTrack
        '
        Me.picTrack.BackColor = System.Drawing.Color.Black
        Me.picTrack.Location = New System.Drawing.Point(95, 51)
        Me.picTrack.Name = "picTrack"
        Me.picTrack.Size = New System.Drawing.Size(605, 516)
        Me.picTrack.TabIndex = 16
        Me.picTrack.TabStop = False
        '
        'Wall1
        '
        Me.Wall1.BackColor = System.Drawing.Color.Green
        Me.Wall1.Location = New System.Drawing.Point(879, 137)
        Me.Wall1.Name = "Wall1"
        Me.Wall1.Size = New System.Drawing.Size(11, 239)
        Me.Wall1.TabIndex = 17
        '
        'Wall2
        '
        Me.Wall2.BackColor = System.Drawing.Color.Green
        Me.Wall2.Location = New System.Drawing.Point(896, 124)
        Me.Wall2.Name = "Wall2"
        Me.Wall2.Size = New System.Drawing.Size(10, 170)
        Me.Wall2.TabIndex = 18
        '
        'Wall3
        '
        Me.Wall3.BackColor = System.Drawing.Color.Green
        Me.Wall3.Location = New System.Drawing.Point(843, 99)
        Me.Wall3.Name = "Wall3"
        Me.Wall3.Size = New System.Drawing.Size(17, 245)
        Me.Wall3.TabIndex = 19
        '
        'Wall4
        '
        Me.Wall4.BackColor = System.Drawing.Color.Green
        Me.Wall4.Location = New System.Drawing.Point(925, 158)
        Me.Wall4.Name = "Wall4"
        Me.Wall4.Size = New System.Drawing.Size(22, 171)
        Me.Wall4.TabIndex = 20
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Location = New System.Drawing.Point(351, 12)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(35, 13)
        Me.lblLives.TabIndex = 21
        Me.lblLives.Text = "Lives:"
        '
        'picHeart1
        '
        Me.picHeart1.Image = Global.FinalProject.My.Resources.Resources.carUp1
        Me.picHeart1.Location = New System.Drawing.Point(389, 12)
        Me.picHeart1.Name = "picHeart1"
        Me.picHeart1.Size = New System.Drawing.Size(35, 35)
        Me.picHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeart1.TabIndex = 22
        Me.picHeart1.TabStop = False
        '
        'picHeart3
        '
        Me.picHeart3.Image = Global.FinalProject.My.Resources.Resources.carUp1
        Me.picHeart3.Location = New System.Drawing.Point(476, 13)
        Me.picHeart3.Name = "picHeart3"
        Me.picHeart3.Size = New System.Drawing.Size(35, 35)
        Me.picHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeart3.TabIndex = 23
        Me.picHeart3.TabStop = False
        '
        'picHeart2
        '
        Me.picHeart2.Image = Global.FinalProject.My.Resources.Resources.carUp1
        Me.picHeart2.Location = New System.Drawing.Point(432, 12)
        Me.picHeart2.Name = "picHeart2"
        Me.picHeart2.Size = New System.Drawing.Size(35, 35)
        Me.picHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeart2.TabIndex = 24
        Me.picHeart2.TabStop = False
        '
        'picCoinMiddle
        '
        Me.picCoinMiddle.BackColor = System.Drawing.Color.Black
        Me.picCoinMiddle.Location = New System.Drawing.Point(223, 82)
        Me.picCoinMiddle.Name = "picCoinMiddle"
        Me.picCoinMiddle.Size = New System.Drawing.Size(25, 25)
        Me.picCoinMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoinMiddle.TabIndex = 25
        Me.picCoinMiddle.TabStop = False
        '
        'picCoinLeft
        '
        Me.picCoinLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picCoinLeft.Location = New System.Drawing.Point(541, 82)
        Me.picCoinLeft.Name = "picCoinLeft"
        Me.picCoinLeft.Size = New System.Drawing.Size(25, 25)
        Me.picCoinLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoinLeft.TabIndex = 26
        Me.picCoinLeft.TabStop = False
        '
        'picCoinRight
        '
        Me.picCoinRight.BackColor = System.Drawing.Color.Black
        Me.picCoinRight.Location = New System.Drawing.Point(382, 82)
        Me.picCoinRight.Name = "picCoinRight"
        Me.picCoinRight.Size = New System.Drawing.Size(25, 25)
        Me.picCoinRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoinRight.TabIndex = 27
        Me.picCoinRight.TabStop = False
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.BackColor = System.Drawing.Color.Black
        Me.lblTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarget.ForeColor = System.Drawing.Color.White
        Me.lblTarget.Location = New System.Drawing.Point(360, 409)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(53, 55)
        Me.lblTarget.TabIndex = 28
        Me.lblTarget.Text = "+"
        '
        'picLeft
        '
        Me.picLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLeft.BackColor = System.Drawing.Color.Green
        Me.picLeft.Location = New System.Drawing.Point(22, 51)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(74, 516)
        Me.picLeft.TabIndex = 29
        Me.picLeft.TabStop = False
        '
        'picRight
        '
        Me.picRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRight.BackColor = System.Drawing.Color.Green
        Me.picRight.Location = New System.Drawing.Point(699, 51)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(74, 516)
        Me.picRight.TabIndex = 30
        Me.picRight.TabStop = False
        '
        'Track1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 638)
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.picLeft)
        Me.Controls.Add(Me.picFPV)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.picCoinRight)
        Me.Controls.Add(Me.picCoinLeft)
        Me.Controls.Add(Me.picCoinMiddle)
        Me.Controls.Add(Me.picHeart2)
        Me.Controls.Add(Me.picHeart3)
        Me.Controls.Add(Me.picHeart1)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.Wall4)
        Me.Controls.Add(Me.Wall3)
        Me.Controls.Add(Me.Wall2)
        Me.Controls.Add(Me.Wall1)
        Me.Controls.Add(Me.picMapCar)
        Me.Controls.Add(Me.lblMap)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picMap)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.picTrack)
        Me.Name = "Track1"
        Me.Text = "Track1"
        CType(Me.picFPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMapCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTrack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCoinMiddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCoinLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCoinRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents picMap As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblMap As System.Windows.Forms.Label
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents picMapCar As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRecharge As System.Windows.Forms.Timer
    Friend WithEvents picFPV As System.Windows.Forms.PictureBox
    Friend WithEvents picTrack As System.Windows.Forms.PictureBox
    Friend WithEvents Wall1 As System.Windows.Forms.Label
    Friend WithEvents Wall2 As System.Windows.Forms.Label
    Friend WithEvents Wall3 As System.Windows.Forms.Label
    Friend WithEvents Wall4 As System.Windows.Forms.Label
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents picHeart1 As System.Windows.Forms.PictureBox
    Friend WithEvents picHeart3 As System.Windows.Forms.PictureBox
    Friend WithEvents picHeart2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCoinMiddle As System.Windows.Forms.PictureBox
    Friend WithEvents picCoinLeft As System.