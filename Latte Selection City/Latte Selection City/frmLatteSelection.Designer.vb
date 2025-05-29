<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLatteSelection
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnPumpkin = New System.Windows.Forms.Button()
        Me.btnMocha = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picMocha = New System.Windows.Forms.PictureBox()
        Me.picPumpkin = New System.Windows.Forms.PictureBox()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblHeading.Location = New System.Drawing.Point(222, 65)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(265, 39)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Latte Selection " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnPumpkin
        '
        Me.btnPumpkin.BackColor = System.Drawing.Color.Bisque
        Me.btnPumpkin.Location = New System.Drawing.Point(68, 416)
        Me.btnPumpkin.Name = "btnPumpkin"
        Me.btnPumpkin.Size = New System.Drawing.Size(168, 38)
        Me.btnPumpkin.TabIndex = 3
        Me.btnPumpkin.Text = "Pumpkin Spice"
        Me.btnPumpkin.UseVisualStyleBackColor = False
        '
        'btnMocha
        '
        Me.btnMocha.BackColor = System.Drawing.Color.Bisque
        Me.btnMocha.Location = New System.Drawing.Point(594, 416)
        Me.btnMocha.Name = "btnMocha"
        Me.btnMocha.Size = New System.Drawing.Size(168, 38)
        Me.btnMocha.TabIndex = 4
        Me.btnMocha.Text = "Mocha"
        Me.btnMocha.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Bisque
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(337, 416)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(168, 38)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select Button"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.Black
        Me.lblInstructions.Location = New System.Drawing.Point(191, 492)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(448, 22)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose a latte flavor and then click Select Latte button."
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.ForeColor = System.Drawing.Color.Black
        Me.lblConfirmation.Location = New System.Drawing.Point(291, 534)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(209, 22)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your latte selection"
        Me.lblConfirmation.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Bisque
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(331, 580)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 38)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picMocha
        '
        Me.picMocha.Image = Global.Latte_Selection_City.My.Resources.Resources.mocha
        Me.picMocha.Location = New System.Drawing.Point(485, 136)
        Me.picMocha.Name = "picMocha"
        Me.picMocha.Size = New System.Drawing.Size(300, 250)
        Me.picMocha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMocha.TabIndex = 2
        Me.picMocha.TabStop = False
        Me.picMocha.Visible = False
        '
        'picPumpkin
        '
        Me.picPumpkin.Image = Global.Latte_Selection_City.My.Resources.Resources.pumpkin
        Me.picPumpkin.Location = New System.Drawing.Point(45, 136)
        Me.picPumpkin.Name = "picPumpkin"
        Me.picPumpkin.Size = New System.Drawing.Size(300, 250)
        Me.picPumpkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPumpkin.TabIndex = 1
        Me.picPumpkin.TabStop = False
        Me.picPumpkin.Visible = False
        '
        'frmLatteSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(831, 644)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnMocha)
        Me.Controls.Add(Me.btnPumpkin)
        Me.Controls.Add(Me.picMocha)
        Me.Controls.Add(Me.picPumpkin)
        Me.Controls.Add(Me.lblHeading)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmLatteSelection"
        Me.Text = "Latte Selection"
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPumpkin As PictureBox
    Friend WithEvents picMocha As PictureBox
    Friend WithEvents btnPumpkin As Button
    Friend WithEvents btnMocha As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
