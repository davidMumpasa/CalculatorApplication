<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDemoCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCalculator = New System.Windows.Forms.Label()
        Me.lblLine_1 = New System.Windows.Forms.Label()
        Me.lblLine_2 = New System.Windows.Forms.Label()
        Me.tbxLine_1 = New System.Windows.Forms.TextBox()
        Me.tbxLine_2 = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnMc = New System.Windows.Forms.Button()
        Me.btnMr = New System.Windows.Forms.Button()
        Me.btnMplus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPoint = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCalculator
        '
        Me.lblCalculator.AutoSize = True
        Me.lblCalculator.Font = New System.Drawing.Font("Segoe Print", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblCalculator.Location = New System.Drawing.Point(19, 9)
        Me.lblCalculator.Name = "lblCalculator"
        Me.lblCalculator.Size = New System.Drawing.Size(247, 47)
        Me.lblCalculator.TabIndex = 0
        Me.lblCalculator.Text = "Demo Calculator"
        '
        'lblLine_1
        '
        Me.lblLine_1.AutoSize = True
        Me.lblLine_1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLine_1.Location = New System.Drawing.Point(24, 68)
        Me.lblLine_1.Name = "lblLine_1"
        Me.lblLine_1.Size = New System.Drawing.Size(68, 27)
        Me.lblLine_1.TabIndex = 1
        Me.lblLine_1.Text = "Line 1"
        '
        'lblLine_2
        '
        Me.lblLine_2.AutoSize = True
        Me.lblLine_2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLine_2.Location = New System.Drawing.Point(24, 109)
        Me.lblLine_2.Name = "lblLine_2"
        Me.lblLine_2.Size = New System.Drawing.Size(68, 27)
        Me.lblLine_2.TabIndex = 2
        Me.lblLine_2.Text = "Line 2"
        '
        'tbxLine_1
        '
        Me.tbxLine_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbxLine_1.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbxLine_1.Location = New System.Drawing.Point(110, 68)
        Me.tbxLine_1.Name = "tbxLine_1"
        Me.tbxLine_1.ReadOnly = True
        Me.tbxLine_1.Size = New System.Drawing.Size(393, 30)
        Me.tbxLine_1.TabIndex = 3
        Me.tbxLine_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxLine_2
        '
        Me.tbxLine_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbxLine_2.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbxLine_2.Location = New System.Drawing.Point(110, 109)
        Me.tbxLine_2.Name = "tbxLine_2"
        Me.tbxLine_2.ReadOnly = True
        Me.tbxLine_2.Size = New System.Drawing.Size(393, 30)
        Me.tbxLine_2.TabIndex = 4
        Me.tbxLine_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(6, 17)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 47)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearAll.Location = New System.Drawing.Point(30, 209)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(101, 90)
        Me.btnClearAll.TabIndex = 6
        Me.btnClearAll.Text = "CLEA ALL"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnZero.Location = New System.Drawing.Point(30, 353)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(101, 42)
        Me.btnZero.TabIndex = 8
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnMc
        '
        Me.btnMc.Location = New System.Drawing.Point(107, 17)
        Me.btnMc.Name = "btnMc"
        Me.btnMc.Size = New System.Drawing.Size(101, 47)
        Me.btnMc.TabIndex = 9
        Me.btnMc.Text = "MC"
        Me.btnMc.UseVisualStyleBackColor = True
        '
        'btnMr
        '
        Me.btnMr.Location = New System.Drawing.Point(214, 17)
        Me.btnMr.Name = "btnMr"
        Me.btnMr.Size = New System.Drawing.Size(101, 47)
        Me.btnMr.TabIndex = 18
        Me.btnMr.Text = "MR"
        Me.btnMr.UseVisualStyleBackColor = True
        '
        'btnMplus
        '
        Me.btnMplus.Location = New System.Drawing.Point(321, 17)
        Me.btnMplus.Name = "btnMplus"
        Me.btnMplus.Size = New System.Drawing.Size(101, 47)
        Me.btnMplus.TabIndex = 26
        Me.btnMplus.Text = "M+"
        Me.btnMplus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlus.Location = New System.Drawing.Point(345, 207)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(101, 90)
        Me.btnPlus.TabIndex = 27
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.Location = New System.Drawing.Point(30, 304)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 43)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPoint
        '
        Me.btnPoint.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPoint.Location = New System.Drawing.Point(345, 305)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(101, 42)
        Me.btnPoint.TabIndex = 30
        Me.btnPoint.Text = "."
        Me.btnPoint.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEqual.Location = New System.Drawing.Point(345, 353)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(101, 42)
        Me.btnEqual.TabIndex = 31
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnMc)
        Me.GroupBox1.Controls.Add(Me.btnMr)
        Me.GroupBox1.Controls.Add(Me.btnMplus)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 70)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnThree)
        Me.GroupBox2.Controls.Add(Me.btnNine)
        Me.GroupBox2.Controls.Add(Me.btnSix)
        Me.GroupBox2.Controls.Add(Me.btnMinus)
        Me.GroupBox2.Controls.Add(Me.btnTwo)
        Me.GroupBox2.Controls.Add(Me.btnFive)
        Me.GroupBox2.Controls.Add(Me.btnEight)
        Me.GroupBox2.Controls.Add(Me.btnMultiply)
        Me.GroupBox2.Controls.Add(Me.btnOne)
        Me.GroupBox2.Controls.Add(Me.btnFour)
        Me.GroupBox2.Controls.Add(Me.btnSeven)
        Me.GroupBox2.Controls.Add(Me.btnDivision)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(137, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 186)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(137, 144)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(59, 42)
        Me.btnThree.TabIndex = 37
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.Location = New System.Drawing.Point(135, 46)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(59, 42)
        Me.btnNine.TabIndex = 36
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnSix
        '
        Me.btnSix.Location = New System.Drawing.Point(137, 96)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(59, 42)
        Me.btnSix.TabIndex = 35
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(135, 0)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(59, 42)
        Me.btnMinus.TabIndex = 34
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(70, 144)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(59, 42)
        Me.btnTwo.TabIndex = 33
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Location = New System.Drawing.Point(71, 96)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(59, 42)
        Me.btnFive.TabIndex = 32
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.Location = New System.Drawing.Point(70, 46)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(59, 42)
        Me.btnEight.TabIndex = 31
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(70, 0)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(59, 42)
        Me.btnMultiply.TabIndex = 30
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(6, 144)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(59, 42)
        Me.btnOne.TabIndex = 29
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(6, 96)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(59, 42)
        Me.btnFour.TabIndex = 28
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnSeven
        '
        Me.btnSeven.Location = New System.Drawing.Point(6, 47)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(59, 42)
        Me.btnSeven.TabIndex = 27
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(6, -1)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(59, 42)
        Me.btnDivision.TabIndex = 26
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'FrmDemoCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 415)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnPoint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.tbxLine_2)
        Me.Controls.Add(Me.tbxLine_1)
        Me.Controls.Add(Me.lblLine_2)
        Me.Controls.Add(Me.lblLine_1)
        Me.Controls.Add(Me.lblCalculator)
        Me.Name = "FrmDemoCalculator"
        Me.Text = "Demo Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCalculator As Label
    Friend WithEvents lblLine_1 As Label
    Friend WithEvents lblLine_2 As Label
    Friend WithEvents tbxLine_1 As TextBox
    Friend WithEvents tbxLine_2 As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnMc As Button
    Friend WithEvents btnMr As Button
    Friend WithEvents btnMplus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPoint As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnThree As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnDivision As Button
End Class
