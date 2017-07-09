<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YMCAExerciseHoursApp
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
        Me.lblHowManyHoursHaveYouExercised = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCalculate = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.txtEnterBirthdayMonth = New System.Windows.Forms.TextBox()
        Me.txtEnterCurrentDateMonth = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtEnterBirthdayDate = New System.Windows.Forms.TextBox()
        Me.txtEnterBirthdayYear = New System.Windows.Forms.TextBox()
        Me.txtEnterCurrentDateDate = New System.Windows.Forms.TextBox()
        Me.txtEnterCurrentDateYear = New System.Windows.Forms.TextBox()
        Me.txtEnterUserName = New System.Windows.Forms.TextBox()
        Me.picRunners = New System.Windows.Forms.PictureBox()
        CType(Me.picRunners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHowManyHoursHaveYouExercised
        '
        Me.lblHowManyHoursHaveYouExercised.AutoSize = True
        Me.lblHowManyHoursHaveYouExercised.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowManyHoursHaveYouExercised.Location = New System.Drawing.Point(87, 12)
        Me.lblHowManyHoursHaveYouExercised.Name = "lblHowManyHoursHaveYouExercised"
        Me.lblHowManyHoursHaveYouExercised.Size = New System.Drawing.Size(259, 44)
        Me.lblHowManyHoursHaveYouExercised.TabIndex = 0
        Me.lblHowManyHoursHaveYouExercised.Text = "How many hours have you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " exercised in your lifetime?"
        Me.lblHowManyHoursHaveYouExercised.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(11, 104)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(125, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "What is your name?"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.Location = New System.Drawing.Point(11, 151)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(143, 16)
        Me.lblBirthday.TabIndex = 3
        Me.lblBirthday.Text = "What is your birthday? "
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(11, 197)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(159, 16)
        Me.lblCurrentDate.TabIndex = 4
        Me.lblCurrentDate.Text = "What is the current date? "
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Silver
        Me.btnCalculate.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(88, 323)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 27)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblCalculate
        '
        Me.lblCalculate.AutoSize = True
        Me.lblCalculate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculate.Location = New System.Drawing.Point(86, 256)
        Me.lblCalculate.Name = "lblCalculate"
        Me.lblCalculate.Size = New System.Drawing.Size(243, 36)
        Me.lblCalculate.TabIndex = 6
        Me.lblCalculate.Text = "You have worked out the following " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number of hours in your lifetime:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Silver
        Me.btnClear.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(179, 323)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 27)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(270, 323)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 27)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTotalHours
        '
        Me.lblTotalHours.AutoSize = True
        Me.lblTotalHours.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHours.Location = New System.Drawing.Point(312, 274)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(0, 18)
        Me.lblTotalHours.TabIndex = 9
        Me.lblTotalHours.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtEnterBirthdayMonth
        '
        Me.txtEnterBirthdayMonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterBirthdayMonth.ForeColor = System.Drawing.Color.DimGray
        Me.txtEnterBirthdayMonth.Location = New System.Drawing.Point(188, 145)
        Me.txtEnterBirthdayMonth.Name = "txtEnterBirthdayMonth"
        Me.txtEnterBirthdayMonth.Size = New System.Drawing.Size(37, 22)
        Me.txtEnterBirthdayMonth.TabIndex = 11
        Me.txtEnterBirthdayMonth.Text = "MM"
        '
        'txtEnterCurrentDateMonth
        '
        Me.txtEnterCurrentDateMonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterCurrentDateMonth.ForeColor = System.Drawing.Color.DimGray
        Me.txtEnterCurrentDateMonth.Location = New System.Drawing.Point(188, 191)
        Me.txtEnterCurrentDateMonth.Name = "txtEnterCurrentDateMonth"
        Me.txtEnterCurrentDateMonth.Size = New System.Drawing.Size(37, 22)
        Me.txtEnterCurrentDateMonth.TabIndex = 12
        Me.txtEnterCurrentDateMonth.Text = "MM"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(199, 230)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 18)
        Me.lblUserName.TabIndex = 13
        '
        'txtEnterBirthdayDate
        '
        Me.txtEnterBirthdayDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterBirthdayDate.ForeColor = System.Drawing.Color.DimGray
        Me.txtEnterBirthdayDate.Location = New System.Drawing.Point(231, 145)
        Me.txtEnterBirthdayDate.Name = "txtEnterBirthdayDate"
        Me.txtEnterBirthdayDate.Size = New System.Drawing.Size(37, 22)
        Me.txtEnterBirthdayDate.TabIndex = 15
        Me.txtEnterBirthdayDate.Text = "DD"
        '
        'txtEnterBirthdayYear
        '
        Me.txtEnterBirthdayYear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterBirthdayYear.ForeColor = System.Drawing.Color.DimGray
        Me.txtEnterBirthdayYear.Location = New System.Drawing.Point(274, 145)
        Me.txtEnterBirthdayYear.Name = "txtEnterBirthdayYear"
        Me.txtEnterBirthdayYear.Size = New System.Drawing.Size(50, 22)
        Me.txtEnterBirthdayYear.TabIndex = 16
        Me.txtEnterBirthdayYear.Text = "YYYY"
        '
        'txtEnterCurrentDateDate
        '
        Me.txtEnterCurrentDateDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterCurrentDateDate.ForeColor = System.Drawing.Color.DimGray
        Me.txtEnterCurrentDateDate.Location = New System.Drawing.Point(231, 191)
        Me.txtEnterCurrentDateDate.Name = "txtEnterCurrentDateDate"
        Me.txtEnterCurrentDateDate.Size = New System.Drawing.Size(37, 22)
        Me.txtEnterCurrentDateDate.TabIndex = 17
        Me.txtEnterCurrentDateDate.Text = "DD"
        '
        'txtEnterCurrentDateYear
        '
        Me.txtEnterCurrentDateYear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterCurrentDateYear.ForeColor = System.Drawing.Color.DimGray
        Me.txtEnterCurrentDateYear.Location = New System.Drawing.Point(274, 191)
        Me.txtEnterCurrentDateYear.Name = "txtEnterCurrentDateYear"
        Me.txtEnterCurrentDateYear.Size = New System.Drawing.Size(50, 22)
        Me.txtEnterCurrentDateYear.TabIndex = 18
        Me.txtEnterCurrentDateYear.Text = "YYYY"
        '
        'txtEnterUserName
        '
        Me.txtEnterUserName.Location = New System.Drawing.Point(188, 100)
        Me.txtEnterUserName.Name = "txtEnterUserName"
        Me.txtEnterUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterUserName.TabIndex = 19
        '
        'picRunners
        '
        Me.picRunners.Image = Global.YMCAExerciseHoursApplication.My.Resources.Resources.Ymca_logo_hr
        Me.picRunners.Location = New System.Drawing.Point(12, 12)
        Me.picRunners.Name = "picRunners"
        Me.picRunners.Size = New System.Drawing.Size(68, 63)
        Me.picRunners.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRunners.TabIndex = 1
        Me.picRunners.TabStop = False
        '
        'YMCAExerciseHoursApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 362)
        Me.Controls.Add(Me.txtEnterUserName)
        Me.Controls.Add(Me.txtEnterCurrentDateYear)
        Me.Controls.Add(Me.txtEnterCurrentDateDate)
        Me.Controls.Add(Me.txtEnterBirthdayYear)
        Me.Controls.Add(Me.txtEnterBirthdayDate)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtEnterCurrentDateMonth)
        Me.Controls.Add(Me.txtEnterBirthdayMonth)
        Me.Controls.Add(Me.lblTotalHours)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCalculate)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHowManyHoursHaveYouExercised)
        Me.Controls.Add(Me.picRunners)
        Me.Name = "YMCAExerciseHoursApp"
        Me.Text = "YMCA Calculate Exercise Hours"
        CType(Me.picRunners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHowManyHoursHaveYouExercised As System.Windows.Forms.Label
    Friend WithEvents picRunners As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblBirthday As System.Windows.Forms.Label
    Friend WithEvents lblCurrentDate As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblCalculate As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotalHours As System.Windows.Forms.Label
    Friend WithEvents txtEnterBirthdayMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterCurrentDateMonth As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtEnterBirthdayDate As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterBirthdayYear As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterCurrentDateDate As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterCurrentDateYear As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterUserName As System.Windows.Forms.TextBox

End Class
