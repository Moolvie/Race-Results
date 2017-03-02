<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRunnerOneName = New System.Windows.Forms.TextBox()
        Me.txtRunnerOneTime = New System.Windows.Forms.TextBox()
        Me.txtRunnerTwoName = New System.Windows.Forms.TextBox()
        Me.txtRunnerTwoTime = New System.Windows.Forms.TextBox()
        Me.txtRunnerThreeName = New System.Windows.Forms.TextBox()
        Me.txtRunnerThreeTime = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFirstPlace = New System.Windows.Forms.Label()
        Me.lblSecondPlace = New System.Windows.Forms.Label()
        Me.lblThirdPlace = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the three runner's names " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          and finishing times."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(227, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Finishing Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( in seconds )"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Runner 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Runner 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Runner 3:"
        '
        'txtRunnerOneName
        '
        Me.txtRunnerOneName.Location = New System.Drawing.Point(92, 159)
        Me.txtRunnerOneName.Name = "txtRunnerOneName"
        Me.txtRunnerOneName.Size = New System.Drawing.Size(114, 20)
        Me.txtRunnerOneName.TabIndex = 6
        '
        'txtRunnerOneTime
        '
        Me.txtRunnerOneTime.Location = New System.Drawing.Point(237, 159)
        Me.txtRunnerOneTime.Name = "txtRunnerOneTime"
        Me.txtRunnerOneTime.Size = New System.Drawing.Size(71, 20)
        Me.txtRunnerOneTime.TabIndex = 7
        '
        'txtRunnerTwoName
        '
        Me.txtRunnerTwoName.Location = New System.Drawing.Point(92, 197)
        Me.txtRunnerTwoName.Name = "txtRunnerTwoName"
        Me.txtRunnerTwoName.Size = New System.Drawing.Size(114, 20)
        Me.txtRunnerTwoName.TabIndex = 8
        '
        'txtRunnerTwoTime
        '
        Me.txtRunnerTwoTime.Location = New System.Drawing.Point(237, 197)
        Me.txtRunnerTwoTime.Name = "txtRunnerTwoTime"
        Me.txtRunnerTwoTime.Size = New System.Drawing.Size(71, 20)
        Me.txtRunnerTwoTime.TabIndex = 9
        '
        'txtRunnerThreeName
        '
        Me.txtRunnerThreeName.Location = New System.Drawing.Point(92, 233)
        Me.txtRunnerThreeName.Name = "txtRunnerThreeName"
        Me.txtRunnerThreeName.Size = New System.Drawing.Size(114, 20)
        Me.txtRunnerThreeName.TabIndex = 10
        '
        'txtRunnerThreeTime
        '
        Me.txtRunnerThreeTime.Location = New System.Drawing.Point(237, 233)
        Me.txtRunnerThreeTime.Name = "txtRunnerThreeTime"
        Me.txtRunnerThreeTime.Size = New System.Drawing.Size(69, 20)
        Me.txtRunnerThreeTime.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblThirdPlace)
        Me.GroupBox1.Controls.Add(Me.lblSecondPlace)
        Me.GroupBox1.Controls.Add(Me.lblFirstPlace)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 142)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Race Results"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1st Place: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "2nd Place: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "3rd Place: "
        '
        'lblFirstPlace
        '
        Me.lblFirstPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstPlace.Location = New System.Drawing.Point(137, 31)
        Me.lblFirstPlace.Name = "lblFirstPlace"
        Me.lblFirstPlace.Size = New System.Drawing.Size(141, 26)
        Me.lblFirstPlace.TabIndex = 3
        '
        'lblSecondPlace
        '
        Me.lblSecondPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecondPlace.Location = New System.Drawing.Point(137, 70)
        Me.lblSecondPlace.Name = "lblSecondPlace"
        Me.lblSecondPlace.Size = New System.Drawing.Size(141, 26)
        Me.lblSecondPlace.TabIndex = 13
        '
        'lblThirdPlace
        '
        Me.lblThirdPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThirdPlace.Location = New System.Drawing.Point(137, 106)
        Me.lblThirdPlace.Name = "lblThirdPlace"
        Me.lblThirdPlace.Size = New System.Drawing.Size(141, 26)
        Me.lblThirdPlace.TabIndex = 14
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(18, 436)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 41)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "Calculate Results"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(124, 436)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 41)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(230, 436)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 505)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRunnerThreeTime)
        Me.Controls.Add(Me.txtRunnerThreeName)
        Me.Controls.Add(Me.txtRunnerTwoTime)
        Me.Controls.Add(Me.txtRunnerTwoName)
        Me.Controls.Add(Me.txtRunnerOneTime)
        Me.Controls.Add(Me.txtRunnerOneName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Race Results"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRunnerOneName As System.Windows.Forms.TextBox
    Friend WithEvents txtRunnerOneTime As System.Windows.Forms.TextBox
    Friend WithEvents txtRunnerTwoName As System.Windows.Forms.TextBox
    Friend WithEvents txtRunnerTwoTime As System.Windows.Forms.TextBox
    Friend WithEvents txtRunnerThreeName As System.Windows.Forms.TextBox
    Friend WithEvents txtRunnerThreeTime As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblThirdPlace As System.Windows.Forms.Label
    Friend WithEvents lblSecondPlace As System.Windows.Forms.Label
    Friend WithEvents lblFirstPlace As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
