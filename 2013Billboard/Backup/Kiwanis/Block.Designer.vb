<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Block
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Block))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSetBlockTime = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnCommitDelete = New System.Windows.Forms.Button
        Me.pnlSetTime = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnSaveDuration = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDuration = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbBlockType2 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbBlockType = New System.Windows.Forms.ComboBox
        Me.lblMessageBox = New System.Windows.Forms.Label
        Me.cbSponsorID = New System.Windows.Forms.ComboBox
        Me.btnCommit = New System.Windows.Forms.Button
        Me.txtBlockAuctoneer = New System.Windows.Forms.TextBox
        Me.cbBlockID = New System.Windows.Forms.ComboBox
        Me.txtBlockName = New System.Windows.Forms.TextBox
        Me.txtBlockDesc = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BlockFrmStatus_lbl = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlSetTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSetBlockTime)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel2.Size = New System.Drawing.Size(160, 521)
        Me.Panel2.TabIndex = 7
        '
        'btnSetBlockTime
        '
        Me.btnSetBlockTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetBlockTime.Location = New System.Drawing.Point(9, 92)
        Me.btnSetBlockTime.Name = "btnSetBlockTime"
        Me.btnSetBlockTime.Size = New System.Drawing.Size(138, 30)
        Me.btnSetBlockTime.TabIndex = 7
        Me.btnSetBlockTime.Text = "Set Block Time"
        Me.btnSetBlockTime.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(9, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(138, 2)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(10, 11)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 30)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Block"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(9, 478)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(138, 30)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back to Main"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(9, 47)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(138, 30)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit Block"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BlockFrmStatus_lbl)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.btnCommitDelete)
        Me.Panel1.Controls.Add(Me.pnlSetTime)
        Me.Panel1.Controls.Add(Me.cbBlockType)
        Me.Panel1.Controls.Add(Me.lblMessageBox)
        Me.Panel1.Controls.Add(Me.cbSponsorID)
        Me.Panel1.Controls.Add(Me.btnCommit)
        Me.Panel1.Controls.Add(Me.txtBlockAuctoneer)
        Me.Panel1.Controls.Add(Me.cbBlockID)
        Me.Panel1.Controls.Add(Me.txtBlockName)
        Me.Panel1.Controls.Add(Me.txtBlockDesc)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(173, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 521)
        Me.Panel1.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(255, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(15, 20)
        Me.Label13.TabIndex = 156
        Me.Label13.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(257, 293)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(375, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(375, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(15, 20)
        Me.Label17.TabIndex = 153
        Me.Label17.Text = "*"
        '
        'btnCommitDelete
        '
        Me.btnCommitDelete.Enabled = False
        Me.btnCommitDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommitDelete.Location = New System.Drawing.Point(409, 11)
        Me.btnCommitDelete.Name = "btnCommitDelete"
        Me.btnCommitDelete.Size = New System.Drawing.Size(80, 35)
        Me.btnCommitDelete.TabIndex = 148
        Me.btnCommitDelete.Text = "Delete"
        Me.btnCommitDelete.UseVisualStyleBackColor = True
        '
        'pnlSetTime
        '
        Me.pnlSetTime.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlSetTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSetTime.Controls.Add(Me.Label9)
        Me.pnlSetTime.Controls.Add(Me.btnSaveDuration)
        Me.pnlSetTime.Controls.Add(Me.Label8)
        Me.pnlSetTime.Controls.Add(Me.txtDuration)
        Me.pnlSetTime.Controls.Add(Me.Label6)
        Me.pnlSetTime.Controls.Add(Me.cbBlockType2)
        Me.pnlSetTime.Controls.Add(Me.Label5)
        Me.pnlSetTime.Location = New System.Drawing.Point(10, 323)
        Me.pnlSetTime.Name = "pnlSetTime"
        Me.pnlSetTime.Size = New System.Drawing.Size(315, 150)
        Me.pnlSetTime.TabIndex = 147
        Me.pnlSetTime.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 20)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Set Block Active Time"
        '
        'btnSaveDuration
        '
        Me.btnSaveDuration.Enabled = False
        Me.btnSaveDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDuration.Location = New System.Drawing.Point(165, 100)
        Me.btnSaveDuration.Name = "btnSaveDuration"
        Me.btnSaveDuration.Size = New System.Drawing.Size(80, 35)
        Me.btnSaveDuration.TabIndex = 162
        Me.btnSaveDuration.Text = "Save"
        Me.btnSaveDuration.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(245, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 20)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "min"
        '
        'txtDuration
        '
        Me.txtDuration.Enabled = False
        Me.txtDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(145, 67)
        Me.txtDuration.MaxLength = 30
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(100, 22)
        Me.txtDuration.TabIndex = 160
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Duration:"
        '
        'cbBlockType2
        '
        Me.cbBlockType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBlockType2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBlockType2.FormattingEnabled = True
        Me.cbBlockType2.Location = New System.Drawing.Point(145, 37)
        Me.cbBlockType2.Name = "cbBlockType2"
        Me.cbBlockType2.Size = New System.Drawing.Size(100, 24)
        Me.cbBlockType2.TabIndex = 158
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Block Type:"
        '
        'cbBlockType
        '
        Me.cbBlockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBlockType.Enabled = False
        Me.cbBlockType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBlockType.FormattingEnabled = True
        Me.cbBlockType.Items.AddRange(New Object() {"RR", "BB", "SU", "SP"})
        Me.cbBlockType.Location = New System.Drawing.Point(149, 97)
        Me.cbBlockType.Name = "cbBlockType"
        Me.cbBlockType.Size = New System.Drawing.Size(100, 24)
        Me.cbBlockType.TabIndex = 144
        '
        'lblMessageBox
        '
        Me.lblMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessageBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageBox.ForeColor = System.Drawing.Color.Red
        Me.lblMessageBox.Location = New System.Drawing.Point(10, 479)
        Me.lblMessageBox.Name = "lblMessageBox"
        Me.lblMessageBox.Size = New System.Drawing.Size(479, 23)
        Me.lblMessageBox.TabIndex = 143
        Me.lblMessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbSponsorID
        '
        Me.cbSponsorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSponsorID.Enabled = False
        Me.cbSponsorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSponsorID.FormattingEnabled = True
        Me.cbSponsorID.Location = New System.Drawing.Point(149, 293)
        Me.cbSponsorID.MaxDropDownItems = 10
        Me.cbSponsorID.MaxLength = 10
        Me.cbSponsorID.Name = "cbSponsorID"
        Me.cbSponsorID.Size = New System.Drawing.Size(100, 24)
        Me.cbSponsorID.TabIndex = 14
        '
        'btnCommit
        '
        Me.btnCommit.Enabled = False
        Me.btnCommit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(409, 52)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(80, 35)
        Me.btnCommit.TabIndex = 18
        Me.btnCommit.Text = "Add"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'txtBlockAuctoneer
        '
        Me.txtBlockAuctoneer.Enabled = False
        Me.txtBlockAuctoneer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlockAuctoneer.Location = New System.Drawing.Point(149, 267)
        Me.txtBlockAuctoneer.MaxLength = 30
        Me.txtBlockAuctoneer.Name = "txtBlockAuctoneer"
        Me.txtBlockAuctoneer.Size = New System.Drawing.Size(220, 22)
        Me.txtBlockAuctoneer.TabIndex = 7
        '
        'cbBlockID
        '
        Me.cbBlockID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBlockID.Enabled = False
        Me.cbBlockID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBlockID.FormattingEnabled = True
        Me.cbBlockID.Location = New System.Drawing.Point(149, 47)
        Me.cbBlockID.Name = "cbBlockID"
        Me.cbBlockID.Size = New System.Drawing.Size(100, 24)
        Me.cbBlockID.TabIndex = 14
        '
        'txtBlockName
        '
        Me.txtBlockName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlockName.Location = New System.Drawing.Point(149, 73)
        Me.txtBlockName.MaxLength = 20
        Me.txtBlockName.Name = "txtBlockName"
        Me.txtBlockName.Size = New System.Drawing.Size(220, 22)
        Me.txtBlockName.TabIndex = 0
        '
        'txtBlockDesc
        '
        Me.txtBlockDesc.Enabled = False
        Me.txtBlockDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlockDesc.Location = New System.Drawing.Point(148, 132)
        Me.txtBlockDesc.MaxLength = 200
        Me.txtBlockDesc.Multiline = True
        Me.txtBlockDesc.Name = "txtBlockDesc"
        Me.txtBlockDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBlockDesc.Size = New System.Drawing.Size(341, 129)
        Me.txtBlockDesc.TabIndex = 13
        Me.txtBlockDesc.Text = "200 characters max"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 297)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Block Sponsor ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Block Auctioneer:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Block Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Block Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Block Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Block ID:"
        '
        'BlockFrmStatus_lbl
        '
        Me.BlockFrmStatus_lbl.AutoSize = True
        Me.BlockFrmStatus_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlockFrmStatus_lbl.Location = New System.Drawing.Point(5, 10)
        Me.BlockFrmStatus_lbl.Name = "BlockFrmStatus_lbl"
        Me.BlockFrmStatus_lbl.Size = New System.Drawing.Size(149, 25)
        Me.BlockFrmStatus_lbl.TabIndex = 157
        Me.BlockFrmStatus_lbl.Text = " ADD BLOCK"
        '
        'Block
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(689, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Block"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Edit Block"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSetTime.ResumeLayout(False)
        Me.pnlSetTime.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMessageBox As System.Windows.Forms.Label
    Friend WithEvents cbSponsorID As System.Windows.Forms.ComboBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents txtBlockAuctoneer As System.Windows.Forms.TextBox
    Friend WithEvents cbBlockID As System.Windows.Forms.ComboBox
    Friend WithEvents txtBlockName As System.Windows.Forms.TextBox
    Friend WithEvents txtBlockDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbBlockType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSetBlockTime As System.Windows.Forms.Button
    Friend WithEvents pnlSetTime As System.Windows.Forms.Panel
    Friend WithEvents btnSaveDuration As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbBlockType2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCommitDelete As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BlockFrmStatus_lbl As System.Windows.Forms.Label
End Class
