<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auctioneer
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auctioneer))
        Me.btnBack = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlStartEnd = New System.Windows.Forms.Panel
        Me.btnReduce = New System.Windows.Forms.Button
        Me.btnReActivate = New System.Windows.Forms.Button
        Me.btnExtend = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblTime5 = New System.Windows.Forms.Label
        Me.lblTime4 = New System.Windows.Forms.Label
        Me.lblTime3 = New System.Windows.Forms.Label
        Me.lblTime2 = New System.Windows.Forms.Label
        Me.lblTime1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblMessageBox = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbDone = New System.Windows.Forms.ListBox
        Me.btnEnd = New System.Windows.Forms.Button
        Me.lbInProgress = New System.Windows.Forms.ListBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.lbNotActive = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlStartEnd.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(10, 398)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(145, 30)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back to Main"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'pnlStartEnd
        '
        Me.pnlStartEnd.BackColor = System.Drawing.SystemColors.Control
        Me.pnlStartEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStartEnd.Controls.Add(Me.btnBack)
        Me.pnlStartEnd.Controls.Add(Me.btnReduce)
        Me.pnlStartEnd.Controls.Add(Me.btnReActivate)
        Me.pnlStartEnd.Controls.Add(Me.btnExtend)
        Me.pnlStartEnd.Controls.Add(Me.btnCancel)
        Me.pnlStartEnd.Controls.Add(Me.lblTime5)
        Me.pnlStartEnd.Controls.Add(Me.lblTime4)
        Me.pnlStartEnd.Controls.Add(Me.lblTime3)
        Me.pnlStartEnd.Controls.Add(Me.lblTime2)
        Me.pnlStartEnd.Controls.Add(Me.lblTime1)
        Me.pnlStartEnd.Controls.Add(Me.Label4)
        Me.pnlStartEnd.Controls.Add(Me.lblMessageBox)
        Me.pnlStartEnd.Controls.Add(Me.Label3)
        Me.pnlStartEnd.Controls.Add(Me.Label2)
        Me.pnlStartEnd.Controls.Add(Me.lbDone)
        Me.pnlStartEnd.Controls.Add(Me.btnEnd)
        Me.pnlStartEnd.Controls.Add(Me.lbInProgress)
        Me.pnlStartEnd.Controls.Add(Me.btnStart)
        Me.pnlStartEnd.Controls.Add(Me.lbNotActive)
        Me.pnlStartEnd.Controls.Add(Me.Label1)
        Me.pnlStartEnd.Location = New System.Drawing.Point(8, 8)
        Me.pnlStartEnd.Name = "pnlStartEnd"
        Me.pnlStartEnd.Padding = New System.Windows.Forms.Padding(2)
        Me.pnlStartEnd.Size = New System.Drawing.Size(640, 439)
        Me.pnlStartEnd.TabIndex = 8
        '
        'btnReduce
        '
        Me.btnReduce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReduce.Location = New System.Drawing.Point(355, 241)
        Me.btnReduce.Name = "btnReduce"
        Me.btnReduce.Size = New System.Drawing.Size(130, 60)
        Me.btnReduce.TabIndex = 37
        Me.btnReduce.Text = "Reduce Block Bidding Time"
        Me.btnReduce.UseVisualStyleBackColor = True
        '
        'btnReActivate
        '
        Me.btnReActivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReActivate.Image = Global.Kiwanis.My.Resources.Resources.ArrowL
        Me.btnReActivate.Location = New System.Drawing.Point(355, 307)
        Me.btnReActivate.Name = "btnReActivate"
        Me.btnReActivate.Size = New System.Drawing.Size(130, 40)
        Me.btnReActivate.TabIndex = 36
        Me.btnReActivate.Text = "REACTIVATE"
        Me.btnReActivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReActivate.UseVisualStyleBackColor = True
        '
        'btnExtend
        '
        Me.btnExtend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtend.Location = New System.Drawing.Point(355, 181)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.Size = New System.Drawing.Size(130, 60)
        Me.btnExtend.TabIndex = 32
        Me.btnExtend.Text = "Extend Block Bidding Time"
        Me.btnExtend.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Kiwanis.My.Resources.Resources.ArrowL
        Me.btnCancel.Location = New System.Drawing.Point(155, 207)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 140)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTime5
        '
        Me.lblTime5.BackColor = System.Drawing.Color.White
        Me.lblTime5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime5.Location = New System.Drawing.Point(350, 115)
        Me.lblTime5.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime5.Name = "lblTime5"
        Me.lblTime5.Size = New System.Drawing.Size(110, 16)
        Me.lblTime5.TabIndex = 31
        '
        'lblTime4
        '
        Me.lblTime4.BackColor = System.Drawing.Color.White
        Me.lblTime4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime4.Location = New System.Drawing.Point(350, 95)
        Me.lblTime4.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime4.Name = "lblTime4"
        Me.lblTime4.Size = New System.Drawing.Size(110, 16)
        Me.lblTime4.TabIndex = 30
        '
        'lblTime3
        '
        Me.lblTime3.BackColor = System.Drawing.Color.White
        Me.lblTime3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime3.Location = New System.Drawing.Point(350, 75)
        Me.lblTime3.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime3.Name = "lblTime3"
        Me.lblTime3.Size = New System.Drawing.Size(110, 16)
        Me.lblTime3.TabIndex = 29
        '
        'lblTime2
        '
        Me.lblTime2.BackColor = System.Drawing.Color.White
        Me.lblTime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.Location = New System.Drawing.Point(350, 55)
        Me.lblTime2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(110, 16)
        Me.lblTime2.TabIndex = 28
        '
        'lblTime1
        '
        Me.lblTime1.BackColor = System.Drawing.Color.White
        Me.lblTime1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime1.Location = New System.Drawing.Point(350, 35)
        Me.lblTime1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(110, 16)
        Me.lblTime1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(352, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Time Remaining:"
        '
        'lblMessageBox
        '
        Me.lblMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessageBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageBox.ForeColor = System.Drawing.Color.Red
        Me.lblMessageBox.Location = New System.Drawing.Point(10, 367)
        Me.lblMessageBox.Name = "lblMessageBox"
        Me.lblMessageBox.Size = New System.Drawing.Size(620, 23)
        Me.lblMessageBox.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(493, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Done:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "In Progress:"
        '
        'lbDone
        '
        Me.lbDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDone.FormattingEnabled = True
        Me.lbDone.ItemHeight = 20
        Me.lbDone.Location = New System.Drawing.Point(495, 30)
        Me.lbDone.Name = "lbDone"
        Me.lbDone.ScrollAlwaysVisible = True
        Me.lbDone.Size = New System.Drawing.Size(135, 324)
        Me.lbDone.Sorted = True
        Me.lbDone.TabIndex = 22
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Image = Global.Kiwanis.My.Resources.Resources.ArrowR
        Me.btnEnd.Location = New System.Drawing.Point(355, 135)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(130, 40)
        Me.btnEnd.TabIndex = 21
        Me.btnEnd.Text = "END   "
        Me.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'lbInProgress
        '
        Me.lbInProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInProgress.FormattingEnabled = True
        Me.lbInProgress.ItemHeight = 20
        Me.lbInProgress.Location = New System.Drawing.Point(215, 30)
        Me.lbInProgress.Name = "lbInProgress"
        Me.lbInProgress.Size = New System.Drawing.Size(130, 324)
        Me.lbInProgress.TabIndex = 20
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Image = Global.Kiwanis.My.Resources.Resources.ArrowR
        Me.btnStart.Location = New System.Drawing.Point(155, 35)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(50, 140)
        Me.btnStart.TabIndex = 19
        Me.btnStart.Text = "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lbNotActive
        '
        Me.lbNotActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNotActive.FormattingEnabled = True
        Me.lbNotActive.ItemHeight = 20
        Me.lbNotActive.Location = New System.Drawing.Point(10, 30)
        Me.lbNotActive.Name = "lbNotActive"
        Me.lbNotActive.ScrollAlwaysVisible = True
        Me.lbNotActive.Size = New System.Drawing.Size(135, 324)
        Me.lbNotActive.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Not Yet Started:"
        '
        'Auctioneer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(657, 457)
        Me.Controls.Add(Me.pnlStartEnd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Auctioneer"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Auctioneer"
        Me.pnlStartEnd.ResumeLayout(False)
        Me.pnlStartEnd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents pnlStartEnd As System.Windows.Forms.Panel
    Friend WithEvents btnReduce As System.Windows.Forms.Button
    Friend WithEvents btnReActivate As System.Windows.Forms.Button
    Friend WithEvents btnExtend As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblTime5 As System.Windows.Forms.Label
    Friend WithEvents lblTime4 As System.Windows.Forms.Label
    Friend WithEvents lblTime3 As System.Windows.Forms.Label
    Friend WithEvents lblTime2 As System.Windows.Forms.Label
    Friend WithEvents lblTime1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMessageBox As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbDone As System.Windows.Forms.ListBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents lbInProgress As System.Windows.Forms.ListBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lbNotActive As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
