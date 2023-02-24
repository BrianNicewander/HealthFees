<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HealthFees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HealthFees))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pbxLogoSecond = New System.Windows.Forms.PictureBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.grpMembership = New System.Windows.Forms.GroupBox()
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radChild = New System.Windows.Forms.RadioButton()
        Me.radAdult = New System.Windows.Forms.RadioButton()
        Me.grpMembershipLength = New System.Windows.Forms.GroupBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblDiscountPercent = New System.Windows.Forms.Label()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.lblNumberofMonths = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkTrainer = New System.Windows.Forms.CheckBox()
        Me.chkkarate = New System.Windows.Forms.CheckBox()
        Me.chkYoga = New System.Windows.Forms.CheckBox()
        Me.grpMembershipFees = New System.Windows.Forms.GroupBox()
        Me.lblGT2 = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblTax2 = New System.Windows.Forms.Label()
        Me.lblDiscount2 = New System.Windows.Forms.Label()
        Me.lblContract2 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblMT2 = New System.Windows.Forms.Label()
        Me.lblContract = New System.Windows.Forms.Label()
        Me.lblmonthlyFee = New System.Windows.Forms.Label()
        Me.lblDisount = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMembership.SuspendLayout()
        Me.grpMembershipLength.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpMembershipFees.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(159, 513)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "This will Calculate the total")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(18, 513)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "This will reset your inputs and totals")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(320, 513)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "This will Exit you out of the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(3, 12)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(215, 94)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'pbxLogoSecond
        '
        Me.pbxLogoSecond.Image = CType(resources.GetObject("pbxLogoSecond.Image"), System.Drawing.Image)
        Me.pbxLogoSecond.Location = New System.Drawing.Point(210, 12)
        Me.pbxLogoSecond.Name = "pbxLogoSecond"
        Me.pbxLogoSecond.Size = New System.Drawing.Size(215, 94)
        Me.pbxLogoSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogoSecond.TabIndex = 1
        Me.pbxLogoSecond.TabStop = False
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Font = New System.Drawing.Font("Viner Hand ITC", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCompanyName.Location = New System.Drawing.Point(-3, 113)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(428, 32)
        Me.lblCompanyName.TabIndex = 2
        Me.lblCompanyName.Text = "Ice Wolf Health Clubs INC"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpMembership
        '
        Me.grpMembership.Controls.Add(Me.radSenior)
        Me.grpMembership.Controls.Add(Me.radStudent)
        Me.grpMembership.Controls.Add(Me.radChild)
        Me.grpMembership.Controls.Add(Me.radAdult)
        Me.grpMembership.Location = New System.Drawing.Point(12, 148)
        Me.grpMembership.Name = "grpMembership"
        Me.grpMembership.Size = New System.Drawing.Size(132, 124)
        Me.grpMembership.TabIndex = 3
        Me.grpMembership.TabStop = False
        Me.grpMembership.Text = "Type of Membership"
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(11, 91)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(89, 17)
        Me.radSenior.TabIndex = 3
        Me.radSenior.TabStop = True
        Me.radSenior.Text = "Senior Citizen"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Location = New System.Drawing.Point(11, 67)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(62, 17)
        Me.radStudent.TabIndex = 2
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'radChild
        '
        Me.radChild.Location = New System.Drawing.Point(11, 43)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(121, 18)
        Me.radChild.TabIndex = 1
        Me.radChild.TabStop = True
        Me.radChild.Text = "Child (12 && under)"
        Me.radChild.UseVisualStyleBackColor = True
        '
        'radAdult
        '
        Me.radAdult.AutoSize = True
        Me.radAdult.Location = New System.Drawing.Point(11, 19)
        Me.radAdult.Name = "radAdult"
        Me.radAdult.Size = New System.Drawing.Size(95, 17)
        Me.radAdult.TabIndex = 0
        Me.radAdult.TabStop = True
        Me.radAdult.Text = "Standard Adult"
        Me.radAdult.UseVisualStyleBackColor = True
        '
        'grpMembershipLength
        '
        Me.grpMembershipLength.Controls.Add(Me.txtDiscount)
        Me.grpMembershipLength.Controls.Add(Me.lblDiscountPercent)
        Me.grpMembershipLength.Controls.Add(Me.txtMonths)
        Me.grpMembershipLength.Controls.Add(Me.lblNumberofMonths)
        Me.grpMembershipLength.Location = New System.Drawing.Point(12, 278)
        Me.grpMembershipLength.Name = "grpMembershipLength"
        Me.grpMembershipLength.Size = New System.Drawing.Size(132, 212)
        Me.grpMembershipLength.TabIndex = 4
        Me.grpMembershipLength.TabStop = False
        Me.grpMembershipLength.Text = "Membership Length"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(6, 174)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 3
        '
        'lblDiscountPercent
        '
        Me.lblDiscountPercent.AutoSize = True
        Me.lblDiscountPercent.Location = New System.Drawing.Point(3, 148)
        Me.lblDiscountPercent.Name = "lblDiscountPercent"
        Me.lblDiscountPercent.Size = New System.Drawing.Size(106, 13)
        Me.lblDiscountPercent.TabIndex = 2
        Me.lblDiscountPercent.Text = "Enter the Discount %"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(6, 90)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(100, 20)
        Me.txtMonths.TabIndex = 1
        '
        'lblNumberofMonths
        '
        Me.lblNumberofMonths.Location = New System.Drawing.Point(3, 53)
        Me.lblNumberofMonths.Name = "lblNumberofMonths"
        Me.lblNumberofMonths.Size = New System.Drawing.Size(103, 27)
        Me.lblNumberofMonths.TabIndex = 0
        Me.lblNumberofMonths.Text = "Enter the Number of Months:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkTrainer)
        Me.grpOptions.Controls.Add(Me.chkkarate)
        Me.grpOptions.Controls.Add(Me.chkYoga)
        Me.grpOptions.Location = New System.Drawing.Point(225, 148)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(200, 124)
        Me.grpOptions.TabIndex = 5
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkTrainer
        '
        Me.chkTrainer.AutoSize = True
        Me.chkTrainer.Location = New System.Drawing.Point(19, 91)
        Me.chkTrainer.Name = "chkTrainer"
        Me.chkTrainer.Size = New System.Drawing.Size(103, 17)
        Me.chkTrainer.TabIndex = 2
        Me.chkTrainer.Text = "Personal Trainer"
        Me.chkTrainer.UseVisualStyleBackColor = True
        '
        'chkkarate
        '
        Me.chkkarate.AutoSize = True
        Me.chkkarate.Location = New System.Drawing.Point(19, 55)
        Me.chkkarate.Name = "chkkarate"
        Me.chkkarate.Size = New System.Drawing.Size(123, 17)
        Me.chkkarate.TabIndex = 1
        Me.chkkarate.Text = "Karate/Self-Defense"
        Me.chkkarate.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.AutoSize = True
        Me.chkYoga.Location = New System.Drawing.Point(19, 20)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(51, 17)
        Me.chkYoga.TabIndex = 0
        Me.chkYoga.Text = "Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'grpMembershipFees
        '
        Me.grpMembershipFees.Controls.Add(Me.lblGT2)
        Me.grpMembershipFees.Controls.Add(Me.lblGrandTotal)
        Me.grpMembershipFees.Controls.Add(Me.lblTax2)
        Me.grpMembershipFees.Controls.Add(Me.lblDiscount2)
        Me.grpMembershipFees.Controls.Add(Me.lblContract2)
        Me.grpMembershipFees.Controls.Add(Me.lblTax)
        Me.grpMembershipFees.Controls.Add(Me.lblMT2)
        Me.grpMembershipFees.Controls.Add(Me.lblContract)
        Me.grpMembershipFees.Controls.Add(Me.lblmonthlyFee)
        Me.grpMembershipFees.Controls.Add(Me.lblDisount)
        Me.grpMembershipFees.Location = New System.Drawing.Point(225, 278)
        Me.grpMembershipFees.Name = "grpMembershipFees"
        Me.grpMembershipFees.Size = New System.Drawing.Size(200, 212)
        Me.grpMembershipFees.TabIndex = 6
        Me.grpMembershipFees.TabStop = False
        Me.grpMembershipFees.Text = "Membership Fees"
        '
        'lblGT2
        '
        Me.lblGT2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGT2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGT2.Location = New System.Drawing.Point(83, 147)
        Me.lblGT2.Name = "lblGT2"
        Me.lblGT2.Size = New System.Drawing.Size(106, 23)
        Me.lblGT2.TabIndex = 9
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Location = New System.Drawing.Point(36, 157)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblGrandTotal.TabIndex = 4
        Me.lblGrandTotal.Text = "Total:"
        '
        'lblTax2
        '
        Me.lblTax2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTax2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax2.Location = New System.Drawing.Point(83, 119)
        Me.lblTax2.Name = "lblTax2"
        Me.lblTax2.Size = New System.Drawing.Size(106, 24)
        Me.lblTax2.TabIndex = 6
        '
        'lblDiscount2
        '
        Me.lblDiscount2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDiscount2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount2.Location = New System.Drawing.Point(83, 79)
        Me.lblDiscount2.Name = "lblDiscount2"
        Me.lblDiscount2.Size = New System.Drawing.Size(106, 24)
        Me.lblDiscount2.TabIndex = 8
        '
        'lblContract2
        '
        Me.lblContract2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblContract2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblContract2.Location = New System.Drawing.Point(83, 52)
        Me.lblContract2.Name = "lblContract2"
        Me.lblContract2.Size = New System.Drawing.Size(106, 24)
        Me.lblContract2.TabIndex = 7
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(42, 130)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 3
        Me.lblTax.Text = "Tax:"
        '
        'lblMT2
        '
        Me.lblMT2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMT2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMT2.Location = New System.Drawing.Point(83, 20)
        Me.lblMT2.Name = "lblMT2"
        Me.lblMT2.Size = New System.Drawing.Size(106, 24)
        Me.lblMT2.TabIndex = 5
        '
        'lblContract
        '
        Me.lblContract.AutoSize = True
        Me.lblContract.Location = New System.Drawing.Point(25, 59)
        Me.lblContract.Name = "lblContract"
        Me.lblContract.Size = New System.Drawing.Size(50, 13)
        Me.lblContract.TabIndex = 1
        Me.lblContract.Text = "Contract:"
        '
        'lblmonthlyFee
        '
        Me.lblmonthlyFee.AutoSize = True
        Me.lblmonthlyFee.Location = New System.Drawing.Point(6, 31)
        Me.lblmonthlyFee.Name = "lblmonthlyFee"
        Me.lblmonthlyFee.Size = New System.Drawing.Size(68, 13)
        Me.lblmonthlyFee.TabIndex = 0
        Me.lblmonthlyFee.Text = "Monthly Fee:"
        '
        'lblDisount
        '
        Me.lblDisount.AutoSize = True
        Me.lblDisount.Location = New System.Drawing.Point(25, 90)
        Me.lblDisount.Name = "lblDisount"
        Me.lblDisount.Size = New System.Drawing.Size(52, 13)
        Me.lblDisount.TabIndex = 2
        Me.lblDisount.Text = "Discount:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(344, 556)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 13)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Brian Nicewander"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(3, 555)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(204, 19)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "Date and Time"
        '
        'HealthFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 580)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpMembershipFees)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpMembershipLength)
        Me.Controls.Add(Me.grpMembership)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.pbxLogoSecond)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "HealthFees"
        Me.Text = "Membership Fee Calculator"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoSecond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMembership.ResumeLayout(False)
        Me.grpMembership.PerformLayout()
        Me.grpMembershipLength.ResumeLayout(False)
        Me.grpMembershipLength.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpMembershipFees.ResumeLayout(False)
        Me.grpMembershipFees.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pbxLogoSecond As PictureBox
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents grpMembership As GroupBox
    Friend WithEvents grpMembershipLength As GroupBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents grpMembershipFees As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblDiscountPercent As Label
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents lblNumberofMonths As Label
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkkarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblDisount As Label
    Friend WithEvents lblContract As Label
    Friend WithEvents lblmonthlyFee As Label
    Friend WithEvents lblMT2 As Label
    Friend WithEvents lblTax2 As Label
    Friend WithEvents lblContract2 As Label
    Friend WithEvents lblDiscount2 As Label
    Friend WithEvents lblGT2 As Label
    Friend WithEvents lblTime As Label
End Class
