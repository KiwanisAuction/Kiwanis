<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Item))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnOverwrite = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ItemFrmMode_lbl = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.calExpire = New System.Windows.Forms.MonthCalendar
        Me.Other = New System.Windows.Forms.GroupBox
        Me.chbTBPU = New System.Windows.Forms.CheckBox
        Me.chError = New System.Windows.Forms.CheckBox
        Me.chShown = New System.Windows.Forms.CheckBox
        Me.chbIsBlockSponsor = New System.Windows.Forms.CheckBox
        Me.chbCertificate = New System.Windows.Forms.CheckBox
        Me.txtExprieDate = New System.Windows.Forms.TextBox
        Me.btnPickDate = New System.Windows.Forms.Button
        Me.btnCommitDelete = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbItemID = New System.Windows.Forms.ComboBox
        Me.cbDonorName = New System.Windows.Forms.ComboBox
        Me.lblMessageBox = New System.Windows.Forms.Label
        Me.btnCommit = New System.Windows.Forms.Button
        Me.txtItemMinIncr = New System.Windows.Forms.TextBox
        Me.txtItemRetailVal = New System.Windows.Forms.TextBox
        Me.cbDonorID = New System.Windows.Forms.ComboBox
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.txtTvDesc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtBidderID = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCurrentBid = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnSavePrice = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbItemDescription = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbItemID2 = New System.Windows.Forms.ComboBox
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Other.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnOverwrite)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 591)
        Me.Panel2.TabIndex = 8
        '
        'btnOverwrite
        '
        Me.btnOverwrite.Enabled = False
        Me.btnOverwrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverwrite.Location = New System.Drawing.Point(11, 91)
        Me.btnOverwrite.Name = "btnOverwrite"
        Me.btnOverwrite.Size = New System.Drawing.Size(145, 30)
        Me.btnOverwrite.TabIndex = 7
        Me.btnOverwrite.Text = "Overwrite Bid Price"
        Me.btnOverwrite.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(11, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 2)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(11, 541)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 2)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(11, 11)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(145, 30)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(11, 549)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(145, 30)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back to Main"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(11, 47)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(145, 30)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit Item"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ItemFrmMode_lbl)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.calExpire)
        Me.Panel1.Controls.Add(Me.Other)
        Me.Panel1.Controls.Add(Me.txtExprieDate)
        Me.Panel1.Controls.Add(Me.btnPickDate)
        Me.Panel1.Controls.Add(Me.btnCommitDelete)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbItemID)
        Me.Panel1.Controls.Add(Me.cbDonorName)
        Me.Panel1.Controls.Add(Me.lblMessageBox)
        Me.Panel1.Controls.Add(Me.btnCommit)
        Me.Panel1.Controls.Add(Me.txtItemMinIncr)
        Me.Panel1.Controls.Add(Me.txtItemRetailVal)
        Me.Panel1.Controls.Add(Me.cbDonorID)
        Me.Panel1.Controls.Add(Me.txtItemDesc)
        Me.Panel1.Controls.Add(Me.txtTvDesc)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(182, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 591)
        Me.Panel1.TabIndex = 7
        '
        'ItemFrmMode_lbl
        '
        Me.ItemFrmMode_lbl.AutoSize = True
        Me.ItemFrmMode_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemFrmMode_lbl.Location = New System.Drawing.Point(3, 11)
        Me.ItemFrmMode_lbl.Name = "ItemFrmMode_lbl"
        Me.ItemFrmMode_lbl.Size = New System.Drawing.Size(104, 25)
        Me.ItemFrmMode_lbl.TabIndex = 158
        Me.ItemFrmMode_lbl.Text = "Add Item"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(226, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "(whole dollar value)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(216, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(447, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(15, 20)
        Me.Label17.TabIndex = 155
        Me.Label17.Text = "*"
        '
        'calExpire
        '
        Me.calExpire.Location = New System.Drawing.Point(216, 262)
        Me.calExpire.Name = "calExpire"
        Me.calExpire.TabIndex = 150
        Me.calExpire.Visible = False
        '
        'Other
        '
        Me.Other.Controls.Add(Me.chbTBPU)
        Me.Other.Controls.Add(Me.chError)
        Me.Other.Controls.Add(Me.chShown)
        Me.Other.Controls.Add(Me.chbIsBlockSponsor)
        Me.Other.Controls.Add(Me.chbCertificate)
        Me.Other.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Other.Location = New System.Drawing.Point(136, 402)
        Me.Other.Name = "Other"
        Me.Other.Size = New System.Drawing.Size(307, 151)
        Me.Other.TabIndex = 154
        Me.Other.TabStop = False
        Me.Other.Text = " Other: "
        '
        'chbTBPU
        '
        Me.chbTBPU.AutoSize = True
        Me.chbTBPU.Enabled = False
        Me.chbTBPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTBPU.Location = New System.Drawing.Point(20, 125)
        Me.chbTBPU.Name = "chbTBPU"
        Me.chbTBPU.Size = New System.Drawing.Size(130, 20)
        Me.chbTBPU.TabIndex = 145
        Me.chbTBPU.Text = "To Be Picked Up"
        Me.chbTBPU.UseVisualStyleBackColor = True
        '
        'chError
        '
        Me.chError.AutoSize = True
        Me.chError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chError.Location = New System.Drawing.Point(20, 75)
        Me.chError.Name = "chError"
        Me.chError.Size = New System.Drawing.Size(249, 20)
        Me.chError.TabIndex = 17
        Me.chError.Text = "Description Different from Newspaper"
        Me.chError.UseVisualStyleBackColor = True
        '
        'chShown
        '
        Me.chShown.AutoSize = True
        Me.chShown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chShown.Location = New System.Drawing.Point(20, 50)
        Me.chShown.Name = "chShown"
        Me.chShown.Size = New System.Drawing.Size(99, 20)
        Me.chShown.TabIndex = 16
        Me.chShown.Text = "Show on TV"
        Me.chShown.UseVisualStyleBackColor = True
        '
        'chbIsBlockSponsor
        '
        Me.chbIsBlockSponsor.AutoSize = True
        Me.chbIsBlockSponsor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbIsBlockSponsor.Location = New System.Drawing.Point(20, 25)
        Me.chbIsBlockSponsor.Name = "chbIsBlockSponsor"
        Me.chbIsBlockSponsor.Size = New System.Drawing.Size(115, 20)
        Me.chbIsBlockSponsor.TabIndex = 15
        Me.chbIsBlockSponsor.Text = "Block Sponsor"
        Me.chbIsBlockSponsor.UseVisualStyleBackColor = True
        '
        'chbCertificate
        '
        Me.chbCertificate.AutoSize = True
        Me.chbCertificate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCertificate.Location = New System.Drawing.Point(20, 101)
        Me.chbCertificate.Name = "chbCertificate"
        Me.chbCertificate.Size = New System.Drawing.Size(171, 20)
        Me.chbCertificate.TabIndex = 144
        Me.chbCertificate.Text = "Required Print Certficate"
        Me.chbCertificate.UseVisualStyleBackColor = True
        '
        'txtExprieDate
        '
        Me.txtExprieDate.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExprieDate.Location = New System.Drawing.Point(136, 237)
        Me.txtExprieDate.MaxLength = 10
        Me.txtExprieDate.Name = "txtExprieDate"
        Me.txtExprieDate.Size = New System.Drawing.Size(80, 23)
        Me.txtExprieDate.TabIndex = 152
        Me.txtExprieDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPickDate
        '
        Me.btnPickDate.Font = New System.Drawing.Font("Webdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnPickDate.Location = New System.Drawing.Point(216, 237)
        Me.btnPickDate.Name = "btnPickDate"
        Me.btnPickDate.Size = New System.Drawing.Size(23, 23)
        Me.btnPickDate.TabIndex = 151
        Me.btnPickDate.Text = "6"
        Me.btnPickDate.UseVisualStyleBackColor = True
        '
        'btnCommitDelete
        '
        Me.btnCommitDelete.Enabled = False
        Me.btnCommitDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommitDelete.Location = New System.Drawing.Point(429, 80)
        Me.btnCommitDelete.Name = "btnCommitDelete"
        Me.btnCommitDelete.Size = New System.Drawing.Size(80, 35)
        Me.btnCommitDelete.TabIndex = 149
        Me.btnCommitDelete.Text = "Delete"
        Me.btnCommitDelete.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = "Item ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "Donor Name:"
        '
        'cbItemID
        '
        Me.cbItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbItemID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbItemID.FormattingEnabled = True
        Me.cbItemID.Location = New System.Drawing.Point(136, 102)
        Me.cbItemID.Name = "cbItemID"
        Me.cbItemID.Size = New System.Drawing.Size(100, 23)
        Me.cbItemID.TabIndex = 146
        '
        'cbDonorName
        '
        Me.cbDonorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDonorName.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDonorName.FormattingEnabled = True
        Me.cbDonorName.Location = New System.Drawing.Point(136, 72)
        Me.cbDonorName.Name = "cbDonorName"
        Me.cbDonorName.Size = New System.Drawing.Size(235, 23)
        Me.cbDonorName.Sorted = True
        Me.cbDonorName.TabIndex = 145
        '
        'lblMessageBox
        '
        Me.lblMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessageBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageBox.ForeColor = System.Drawing.Color.Red
        Me.lblMessageBox.Location = New System.Drawing.Point(10, 556)
        Me.lblMessageBox.Name = "lblMessageBox"
        Me.lblMessageBox.Size = New System.Drawing.Size(499, 23)
        Me.lblMessageBox.TabIndex = 143
        Me.lblMessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCommit
        '
        Me.btnCommit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(429, 41)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(80, 35)
        Me.btnCommit.TabIndex = 18
        Me.btnCommit.Text = "Add"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'txtItemMinIncr
        '
        Me.txtItemMinIncr.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemMinIncr.Location = New System.Drawing.Point(136, 207)
        Me.txtItemMinIncr.MaxLength = 30
        Me.txtItemMinIncr.Name = "txtItemMinIncr"
        Me.txtItemMinIncr.Size = New System.Drawing.Size(80, 23)
        Me.txtItemMinIncr.TabIndex = 3
        Me.txtItemMinIncr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemRetailVal
        '
        Me.txtItemRetailVal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemRetailVal.Location = New System.Drawing.Point(136, 177)
        Me.txtItemRetailVal.MaxLength = 7
        Me.txtItemRetailVal.Name = "txtItemRetailVal"
        Me.txtItemRetailVal.Size = New System.Drawing.Size(80, 23)
        Me.txtItemRetailVal.TabIndex = 2
        Me.txtItemRetailVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbDonorID
        '
        Me.cbDonorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDonorID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDonorID.FormattingEnabled = True
        Me.cbDonorID.Location = New System.Drawing.Point(136, 42)
        Me.cbDonorID.Name = "cbDonorID"
        Me.cbDonorID.Size = New System.Drawing.Size(100, 23)
        Me.cbDonorID.TabIndex = 14
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc.Location = New System.Drawing.Point(136, 132)
        Me.txtItemDesc.MaxLength = 50
        Me.txtItemDesc.Multiline = True
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(307, 38)
        Me.txtItemDesc.TabIndex = 0
        '
        'txtTvDesc
        '
        Me.txtTvDesc.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTvDesc.Location = New System.Drawing.Point(136, 267)
        Me.txtTvDesc.MaxLength = 2000
        Me.txtTvDesc.Multiline = True
        Me.txtTvDesc.Name = "txtTvDesc"
        Me.txtTvDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTvDesc.Size = New System.Drawing.Size(305, 126)
        Me.txtTvDesc.TabIndex = 13
        Me.txtTvDesc.Text = "2000 characters max"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "TV Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Expiration Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Min Bid:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Retail Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "On Screen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Donor ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 161
        Me.Label12.Text = "Bidder ID:"
        '
        'txtBidderID
        '
        Me.txtBidderID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBidderID.Location = New System.Drawing.Point(169, 137)
        Me.txtBidderID.MaxLength = 7
        Me.txtBidderID.Name = "txtBidderID"
        Me.txtBidderID.Size = New System.Drawing.Size(80, 23)
        Me.txtBidderID.TabIndex = 160
        Me.txtBidderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 159
        Me.Label11.Text = "Current Bid:"
        '
        'txtCurrentBid
        '
        Me.txtCurrentBid.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentBid.Location = New System.Drawing.Point(169, 106)
        Me.txtCurrentBid.MaxLength = 7
        Me.txtCurrentBid.Name = "txtCurrentBid"
        Me.txtCurrentBid.Size = New System.Drawing.Size(80, 23)
        Me.txtCurrentBid.TabIndex = 158
        Me.txtCurrentBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.btnSavePrice)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.cbItemDescription)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.cbItemID2)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtBidderID)
        Me.Panel3.Controls.Add(Me.txtCurrentBid)
        Me.Panel3.Location = New System.Drawing.Point(191, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(505, 530)
        Me.Panel3.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(214, 25)
        Me.Label19.TabIndex = 170
        Me.Label19.Text = "Overwrite Bid Price"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(250, 134)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(15, 20)
        Me.Label18.TabIndex = 169
        Me.Label18.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(260, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(98, 13)
        Me.Label15.TabIndex = 167
        Me.Label15.Text = "(whole dollar value)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(250, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(15, 20)
        Me.Label16.TabIndex = 168
        Me.Label16.Text = "*"
        '
        'btnSavePrice
        '
        Me.btnSavePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePrice.Location = New System.Drawing.Point(405, 125)
        Me.btnSavePrice.Name = "btnSavePrice"
        Me.btnSavePrice.Size = New System.Drawing.Size(80, 35)
        Me.btnSavePrice.TabIndex = 166
        Me.btnSavePrice.Text = "Save Bid"
        Me.btnSavePrice.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(40, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 20)
        Me.Label14.TabIndex = 165
        Me.Label14.Text = "Item Description:"
        '
        'cbItemDescription
        '
        Me.cbItemDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbItemDescription.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbItemDescription.FormattingEnabled = True
        Me.cbItemDescription.Location = New System.Drawing.Point(170, 69)
        Me.cbItemDescription.Name = "cbItemDescription"
        Me.cbItemDescription.Size = New System.Drawing.Size(315, 23)
        Me.cbItemDescription.TabIndex = 164
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(40, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 20)
        Me.Label13.TabIndex = 163
        Me.Label13.Text = "Item ID:"
        '
        'cbItemID2
        '
        Me.cbItemID2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbItemID2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbItemID2.FormattingEnabled = True
        Me.cbItemID2.Location = New System.Drawing.Point(170, 39)
        Me.cbItemID2.Name = "cbItemID2"
        Me.cbItemID2.Size = New System.Drawing.Size(100, 23)
        Me.cbItemID2.TabIndex = 162
        '
        'Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(712, 612)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Other.ResumeLayout(False)
        Me.Other.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMessageBox As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents txtItemMinIncr As System.Windows.Forms.TextBox
    Friend WithEvents txtItemRetailVal As System.Windows.Forms.TextBox
    Friend WithEvents cbDonorID As System.Windows.Forms.ComboBox
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtTvDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chbCertificate As System.Windows.Forms.CheckBox
    Friend WithEvents cbDonorName As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbItemID As System.Windows.Forms.ComboBox
    Friend WithEvents btnCommitDelete As System.Windows.Forms.Button
    Friend WithEvents calExpire As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnPickDate As System.Windows.Forms.Button
    Friend WithEvents txtExprieDate As System.Windows.Forms.TextBox
    Friend WithEvents Other As System.Windows.Forms.GroupBox
    Friend WithEvents chbIsBlockSponsor As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chShown As System.Windows.Forms.CheckBox
    Friend WithEvents chError As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBidderID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentBid As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbItemID2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnOverwrite As System.Windows.Forms.Button
    Friend WithEvents btnSavePrice As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbItemDescription As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ItemFrmMode_lbl As System.Windows.Forms.Label
    Friend WithEvents chbTBPU As System.Windows.Forms.CheckBox
End Class
