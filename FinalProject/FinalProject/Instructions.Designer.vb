<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.picVet = New System.Windows.Forms.PictureBox()
        Me.btnSkip = New System.Windows.Forms.Button()
        CType(Me.picVet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(357, 245)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(71, 43)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoEllipsis = True
        Me.lblInstructions.BackColor = System.Drawing.Color.Black
        Me.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(0, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(262, 289)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Welcome to the world of Extreme Raceing! My name is really hard to pronounce, so " & _
    "you can just call me the Veteran Racer."
        '
        'picVet
        '
        Me.picVet.Image = Global.FinalProject.My.Resources.Resources.Racer1
        Me.picVet.Location = New System.Drawing.Point(232, 90)
        Me.picVet.Name = "picVet"
        Me.picVet.Size = New System.Drawing.Size(176, 199)
        Me.picVet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVet.TabIndex = 2
        Me.picVet.TabStop = False
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(187, 266)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(75, 23)
        Me.btnSkip.TabIndex = 3
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 288)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picVet)
        Me.Name = "Instructions"
        Me.Text = "Instructions"
        CType(Me.picVet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents picVet As System.Windows.Forms.PictureBox
    Friend WithEvents btnSkip As System.Windows.Forms.Button
End Class
