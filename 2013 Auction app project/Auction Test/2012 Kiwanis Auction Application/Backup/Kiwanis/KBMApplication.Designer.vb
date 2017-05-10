<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KBMApplication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KBMApplication))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.BidderLB_lbl = New System.Windows.Forms.Label
        Me.BacktoMain_btn = New System.Windows.Forms.Button
        Me.EditBidder_btn = New System.Windows.Forms.Button
        Me.AddBidder_btn = New System.Windows.Forms.Button
        Me.Bidder_lb = New System.Windows.Forms.ListBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.MODE_V_lbl = New System.Windows.Forms.Label
        Me.FormDelete_btn = New System.Windows.Forms.Button
        Me.FormCancel_btn = New System.Windows.Forms.Button
        Me.FormAdd_btn = New System.Windows.Forms.Button
        Me.AppLabel = New System.Windows.Forms.Label
        Me.BidderInfo_gb = New System.Windows.Forms.GroupBox
        Me.KMember_cb = New System.Windows.Forms.CheckBox
        Me.Member_lbl = New System.Windows.Forms.Label
        Me.LName_txt = New System.Windows.Forms.TextBox
        Me.Name2_lbl = New System.Windows.Forms.Label
        Me.PhonePrefix2_txt = New System.Windows.Forms.TextBox
        Me.PhoneLine2_txt = New System.Windows.Forms.TextBox
        Me.PhoneArea2_txt = New System.Windows.Forms.TextBox
        Me.Phone2_lbl = New System.Windows.Forms.Label
        Me.Active_lbl = New System.Windows.Forms.Label
        Me.Warning_lbl = New System.Windows.Forms.Label
        Me.Other_lbl = New System.Windows.Forms.Label
        Me.NotActive_cb = New System.Windows.Forms.CheckBox
        Me.Memo_rtb = New System.Windows.Forms.RichTextBox
        Me.Memo_lbl = New System.Windows.Forms.Label
        Me.Email_txt = New System.Windows.Forms.TextBox
        Me.Email_lbl = New System.Windows.Forms.Label
        Me.PhonePrefix_txt = New System.Windows.Forms.TextBox
        Me.PhoneLine_txt = New System.Windows.Forms.TextBox
        Me.PhoneArea_txt = New System.Windows.Forms.TextBox
        Me.Phone_lbl = New System.Windows.Forms.Label
        Me.ZIPPrefix_txt = New System.Windows.Forms.TextBox
        Me.Zip_lbl = New System.Windows.Forms.Label
        Me.State_dd = New System.Windows.Forms.ComboBox
        Me.State_lbl = New System.Windows.Forms.Label
        Me.City_txt = New System.Windows.Forms.TextBox
        Me.City_lbl = New System.Windows.Forms.Label
        Me.Address1_txt = New System.Windows.Forms.TextBox
        Me.Address1_lbl = New System.Windows.Forms.Label
        Me.FName_txt = New System.Windows.Forms.TextBox
        Me.Name_lbl = New System.Windows.Forms.Label
        Me.BidderID_txt = New System.Windows.Forms.TextBox
        Me.DonorID_lbl = New System.Windows.Forms.Label
        Me.DonorItem_gb = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ItemDateDonated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemRetailVal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemHighBid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.BidderInfo_gb.SuspendLayout()
        Me.DonorItem_gb.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BidderLB_lbl)
        Me.Panel1.Controls.Add(Me.BacktoMain_btn)
        Me.Panel1.Controls.Add(Me.EditBidder_btn)
        Me.Panel1.Controls.Add(Me.AddBidder_btn)
        Me.Panel1.Controls.Add(Me.Bidder_lb)
        Me.Panel1.Location = New System.Drawing.Point(12, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(181, 557)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 9)
        Me.Label1.TabIndex = 8
        '
        'BidderLB_lbl
        '
        Me.BidderLB_lbl.AutoSize = True
        Me.BidderLB_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BidderLB_lbl.Location = New System.Drawing.Point(8, 8)
        Me.BidderLB_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BidderLB_lbl.Name = "BidderLB_lbl"
        Me.BidderLB_lbl.Size = New System.Drawing.Size(60, 15)
        Me.BidderLB_lbl.TabIndex = 3
        Me.BidderLB_lbl.Text = "Bidders:"
        '
        'BacktoMain_btn
        '
        Me.BacktoMain_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BacktoMain_btn.Location = New System.Drawing.Point(11, 519)
        Me.BacktoMain_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.BacktoMain_btn.Name = "BacktoMain_btn"
        Me.BacktoMain_btn.Size = New System.Drawing.Size(137, 26)
        Me.BacktoMain_btn.TabIndex = 3
        Me.BacktoMain_btn.Text = "Back to Main"
        Me.BacktoMain_btn.UseVisualStyleBackColor = True
        '
        'EditBidder_btn
        '
        Me.EditBidder_btn.Location = New System.Drawing.Point(11, 475)
        Me.EditBidder_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.EditBidder_btn.Name = "EditBidder_btn"
        Me.EditBidder_btn.Size = New System.Drawing.Size(137, 24)
        Me.EditBidder_btn.TabIndex = 1
        Me.EditBidder_btn.Text = "EDIT Bidder"
        Me.EditBidder_btn.UseVisualStyleBackColor = True
        '
        'AddBidder_btn
        '
        Me.AddBidder_btn.Location = New System.Drawing.Point(11, 447)
        Me.AddBidder_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddBidder_btn.Name = "AddBidder_btn"
        Me.AddBidder_btn.Size = New System.Drawing.Size(137, 24)
        Me.AddBidder_btn.TabIndex = 2
        Me.AddBidder_btn.Text = "ADD Bidder"
        Me.AddBidder_btn.UseVisualStyleBackColor = True
        '
        'Bidder_lb
        '
        Me.Bidder_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bidder_lb.FormattingEnabled = True
        Me.Bidder_lb.Location = New System.Drawing.Point(10, 25)
        Me.Bidder_lb.Margin = New System.Windows.Forms.Padding(2)
        Me.Bidder_lb.Name = "Bidder_lb"
        Me.Bidder_lb.Size = New System.Drawing.Size(159, 418)
        Me.Bidder_lb.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MODE_V_lbl)
        Me.Panel2.Controls.Add(Me.FormDelete_btn)
        Me.Panel2.Controls.Add(Me.FormCancel_btn)
        Me.Panel2.Controls.Add(Me.FormAdd_btn)
        Me.Panel2.Controls.Add(Me.AppLabel)
        Me.Panel2.Controls.Add(Me.BidderInfo_gb)
        Me.Panel2.Controls.Add(Me.DonorItem_gb)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(197, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8, 8, 8, 16)
        Me.Panel2.Size = New System.Drawing.Size(651, 557)
        Me.Panel2.TabIndex = 1
        '
        'MODE_V_lbl
        '
        Me.MODE_V_lbl.AutoSize = True
        Me.MODE_V_lbl.BackColor = System.Drawing.Color.Transparent
        Me.MODE_V_lbl.Font = New System.Drawing.Font("Candara", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODE_V_lbl.ForeColor = System.Drawing.Color.Green
        Me.MODE_V_lbl.Location = New System.Drawing.Point(389, -1)
        Me.MODE_V_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MODE_V_lbl.Name = "MODE_V_lbl"
        Me.MODE_V_lbl.Size = New System.Drawing.Size(98, 42)
        Me.MODE_V_lbl.TabIndex = 7
        Me.MODE_V_lbl.Text = "VIEW"
        '
        'FormDelete_btn
        '
        Me.FormDelete_btn.Enabled = False
        Me.FormDelete_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormDelete_btn.Location = New System.Drawing.Point(550, 130)
        Me.FormDelete_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.FormDelete_btn.Name = "FormDelete_btn"
        Me.FormDelete_btn.Size = New System.Drawing.Size(89, 29)
        Me.FormDelete_btn.TabIndex = 2
        Me.FormDelete_btn.Text = "DELETE"
        Me.FormDelete_btn.UseVisualStyleBackColor = True
        '
        'FormCancel_btn
        '
        Me.FormCancel_btn.Enabled = False
        Me.FormCancel_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCancel_btn.Location = New System.Drawing.Point(550, 88)
        Me.FormCancel_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.FormCancel_btn.Name = "FormCancel_btn"
        Me.FormCancel_btn.Size = New System.Drawing.Size(89, 28)
        Me.FormCancel_btn.TabIndex = 1
        Me.FormCancel_btn.Text = "CANCEL"
        Me.FormCancel_btn.UseVisualStyleBackColor = True
        '
        'FormAdd_btn
        '
        Me.FormAdd_btn.Enabled = False
        Me.FormAdd_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormAdd_btn.Location = New System.Drawing.Point(550, 45)
        Me.FormAdd_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.FormAdd_btn.Name = "FormAdd_btn"
        Me.FormAdd_btn.Size = New System.Drawing.Size(89, 30)
        Me.FormAdd_btn.TabIndex = 0
        Me.FormAdd_btn.Text = "SAVE"
        Me.FormAdd_btn.UseVisualStyleBackColor = True
        '
        'AppLabel
        '
        Me.AppLabel.AutoSize = True
        Me.AppLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppLabel.ForeColor = System.Drawing.Color.CadetBlue
        Me.AppLabel.Location = New System.Drawing.Point(10, 8)
        Me.AppLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AppLabel.Name = "AppLabel"
        Me.AppLabel.Size = New System.Drawing.Size(197, 24)
        Me.AppLabel.TabIndex = 2
        Me.AppLabel.Text = "Bidder Maintenance"
        '
        'BidderInfo_gb
        '
        Me.BidderInfo_gb.Controls.Add(Me.KMember_cb)
        Me.BidderInfo_gb.Controls.Add(Me.Member_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.LName_txt)
        Me.BidderInfo_gb.Controls.Add(Me.Name2_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.PhonePrefix2_txt)
        Me.BidderInfo_gb.Controls.Add(Me.PhoneLine2_txt)
        Me.BidderInfo_gb.Controls.Add(Me.PhoneArea2_txt)
        Me.BidderInfo_gb.Controls.Add(Me.Phone2_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.Active_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.Warning_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.Other_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.NotActive_cb)
        Me.BidderInfo_gb.Controls.Add(Me.Memo_rtb)
        Me.BidderInfo_gb.Controls.Add(Me.Memo_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.Email_txt)
        Me.BidderInfo_gb.Controls.Add(Me.Email_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.PhonePrefix_txt)
        Me.BidderInfo_gb.Controls.Add(Me.PhoneLine_txt)
        Me.BidderInfo_gb.Controls.Add(Me.PhoneArea_txt)
        Me.BidderInfo_gb.Controls.Add(Me.Phone_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.ZIPPrefix_txt)
        Me.BidderInfo_gb.Controls.Add(Me.Zip_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.State_dd)
        Me.BidderInfo_gb.Controls.Add(Me.State_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.City_txt)
        Me.BidderInfo_gb.Controls.Add(Me.City_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.Address1_txt)
        Me.BidderInfo_gb.Controls.Add(Me.Address1_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.FName_txt)
        Me.BidderInfo_gb.Controls.Add(Me.Name_lbl)
        Me.BidderInfo_gb.Controls.Add(Me.BidderID_txt)
        Me.BidderInfo_gb.Controls.Add(Me.DonorID_lbl)
        Me.BidderInfo_gb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BidderInfo_gb.Location = New System.Drawing.Point(10, 34)
        Me.BidderInfo_gb.Margin = New System.Windows.Forms.Padding(2)
        Me.BidderInfo_gb.Name = "BidderInfo_gb"
        Me.BidderInfo_gb.Padding = New System.Windows.Forms.Padding(2, 2, 10, 10)
        Me.BidderInfo_gb.Size = New System.Drawing.Size(529, 361)
        Me.BidderInfo_gb.TabIndex = 1
        Me.BidderInfo_gb.TabStop = False
        '
        'KMember_cb
        '
        Me.KMember_cb.AutoSize = True
        Me.KMember_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KMember_cb.Location = New System.Drawing.Point(353, 140)
        Me.KMember_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.KMember_cb.Name = "KMember_cb"
        Me.KMember_cb.Size = New System.Drawing.Size(144, 20)
        Me.KMember_cb.TabIndex = 16
        Me.KMember_cb.Text = "Kawanis Member"
        Me.KMember_cb.UseVisualStyleBackColor = True
        '
        'Member_lbl
        '
        Me.Member_lbl.AutoSize = True
        Me.Member_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Member_lbl.ForeColor = System.Drawing.Color.Indigo
        Me.Member_lbl.Location = New System.Drawing.Point(315, 50)
        Me.Member_lbl.Name = "Member_lbl"
        Me.Member_lbl.Size = New System.Drawing.Size(214, 29)
        Me.Member_lbl.TabIndex = 45
        Me.Member_lbl.Text = "Kawanis Member"
        '
        'LName_txt
        '
        Me.LName_txt.Location = New System.Drawing.Point(82, 74)
        Me.LName_txt.MaxLength = 40
        Me.LName_txt.Name = "LName_txt"
        Me.LName_txt.Size = New System.Drawing.Size(220, 21)
        Me.LName_txt.TabIndex = 1
        '
        'Name2_lbl
        '
        Me.Name2_lbl.AutoSize = True
        Me.Name2_lbl.Location = New System.Drawing.Point(4, 77)
        Me.Name2_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Name2_lbl.Name = "Name2_lbl"
        Me.Name2_lbl.Size = New System.Drawing.Size(76, 15)
        Me.Name2_lbl.TabIndex = 44
        Me.Name2_lbl.Text = "Last Name"
        '
        'PhonePrefix2_txt
        '
        Me.PhonePrefix2_txt.Location = New System.Drawing.Point(130, 211)
        Me.PhonePrefix2_txt.MaxLength = 3
        Me.PhonePrefix2_txt.Name = "PhonePrefix2_txt"
        Me.PhonePrefix2_txt.Size = New System.Drawing.Size(41, 21)
        Me.PhonePrefix2_txt.TabIndex = 11
        '
        'PhoneLine2_txt
        '
        Me.PhoneLine2_txt.Location = New System.Drawing.Point(177, 211)
        Me.PhoneLine2_txt.MaxLength = 4
        Me.PhoneLine2_txt.Name = "PhoneLine2_txt"
        Me.PhoneLine2_txt.Size = New System.Drawing.Size(50, 21)
        Me.PhoneLine2_txt.TabIndex = 12
        '
        'PhoneArea2_txt
        '
        Me.PhoneArea2_txt.Location = New System.Drawing.Point(83, 211)
        Me.PhoneArea2_txt.MaxLength = 3
        Me.PhoneArea2_txt.Name = "PhoneArea2_txt"
        Me.PhoneArea2_txt.Size = New System.Drawing.Size(41, 21)
        Me.PhoneArea2_txt.TabIndex = 10
        '
        'Phone2_lbl
        '
        Me.Phone2_lbl.AutoSize = True
        Me.Phone2_lbl.Location = New System.Drawing.Point(4, 214)
        Me.Phone2_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Phone2_lbl.Name = "Phone2_lbl"
        Me.Phone2_lbl.Size = New System.Drawing.Size(72, 15)
        Me.Phone2_lbl.TabIndex = 42
        Me.Phone2_lbl.Text = "Alt. Phone"
        '
        'Active_lbl
        '
        Me.Active_lbl.AutoSize = True
        Me.Active_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Active_lbl.ForeColor = System.Drawing.Color.Indigo
        Me.Active_lbl.Location = New System.Drawing.Point(315, 16)
        Me.Active_lbl.Name = "Active_lbl"
        Me.Active_lbl.Size = New System.Drawing.Size(189, 29)
        Me.Active_lbl.TabIndex = 38
        Me.Active_lbl.Text = "not active label"
        '
        'Warning_lbl
        '
        Me.Warning_lbl.AutoSize = True
        Me.Warning_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Warning_lbl.ForeColor = System.Drawing.Color.Red
        Me.Warning_lbl.Location = New System.Drawing.Point(10, 335)
        Me.Warning_lbl.Name = "Warning_lbl"
        Me.Warning_lbl.Size = New System.Drawing.Size(273, 16)
        Me.Warning_lbl.TabIndex = 34
        Me.Warning_lbl.Text = "input warning label > > > > > > > > > > > "
        '
        'Other_lbl
        '
        Me.Other_lbl.AutoSize = True
        Me.Other_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Other_lbl.Location = New System.Drawing.Point(334, 96)
        Me.Other_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Other_lbl.Name = "Other_lbl"
        Me.Other_lbl.Size = New System.Drawing.Size(55, 18)
        Me.Other_lbl.TabIndex = 33
        Me.Other_lbl.Text = "Other:"
        '
        'NotActive_cb
        '
        Me.NotActive_cb.AutoSize = True
        Me.NotActive_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotActive_cb.Location = New System.Drawing.Point(353, 116)
        Me.NotActive_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.NotActive_cb.Name = "NotActive_cb"
        Me.NotActive_cb.Size = New System.Drawing.Size(98, 20)
        Me.NotActive_cb.TabIndex = 15
        Me.NotActive_cb.Text = "Not Active"
        Me.NotActive_cb.UseVisualStyleBackColor = True
        '
        'Memo_rtb
        '
        Me.Memo_rtb.Location = New System.Drawing.Point(83, 265)
        Me.Memo_rtb.MaxLength = 1000
        Me.Memo_rtb.Name = "Memo_rtb"
        Me.Memo_rtb.Size = New System.Drawing.Size(438, 57)
        Me.Memo_rtb.TabIndex = 14
        Me.Memo_rtb.Text = ""
        '
        'Memo_lbl
        '
        Me.Memo_lbl.AutoSize = True
        Me.Memo_lbl.Location = New System.Drawing.Point(5, 265)
        Me.Memo_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Memo_lbl.Name = "Memo_lbl"
        Me.Memo_lbl.Size = New System.Drawing.Size(47, 15)
        Me.Memo_lbl.TabIndex = 27
        Me.Memo_lbl.Text = "Memo"
        '
        'Email_txt
        '
        Me.Email_txt.Location = New System.Drawing.Point(83, 238)
        Me.Email_txt.MaxLength = 100
        Me.Email_txt.Name = "Email_txt"
        Me.Email_txt.Size = New System.Drawing.Size(219, 21)
        Me.Email_txt.TabIndex = 13
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Location = New System.Drawing.Point(4, 241)
        Me.Email_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(44, 15)
        Me.Email_lbl.TabIndex = 23
        Me.Email_lbl.Text = "Email"
        '
        'PhonePrefix_txt
        '
        Me.PhonePrefix_txt.Location = New System.Drawing.Point(130, 184)
        Me.PhonePrefix_txt.MaxLength = 3
        Me.PhonePrefix_txt.Name = "PhonePrefix_txt"
        Me.PhonePrefix_txt.Size = New System.Drawing.Size(41, 21)
        Me.PhonePrefix_txt.TabIndex = 8
        '
        'PhoneLine_txt
        '
        Me.PhoneLine_txt.Location = New System.Drawing.Point(177, 184)
        Me.PhoneLine_txt.MaxLength = 4
        Me.PhoneLine_txt.Name = "PhoneLine_txt"
        Me.PhoneLine_txt.Size = New System.Drawing.Size(50, 21)
        Me.PhoneLine_txt.TabIndex = 9
        '
        'PhoneArea_txt
        '
        Me.PhoneArea_txt.Location = New System.Drawing.Point(83, 184)
        Me.PhoneArea_txt.MaxLength = 3
        Me.PhoneArea_txt.Name = "PhoneArea_txt"
        Me.PhoneArea_txt.Size = New System.Drawing.Size(41, 21)
        Me.PhoneArea_txt.TabIndex = 7
        '
        'Phone_lbl
        '
        Me.Phone_lbl.AutoSize = True
        Me.Phone_lbl.Location = New System.Drawing.Point(4, 183)
        Me.Phone_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Phone_lbl.Name = "Phone_lbl"
        Me.Phone_lbl.Size = New System.Drawing.Size(48, 15)
        Me.Phone_lbl.TabIndex = 17
        Me.Phone_lbl.Text = "Phone"
        '
        'ZIPPrefix_txt
        '
        Me.ZIPPrefix_txt.Location = New System.Drawing.Point(241, 155)
        Me.ZIPPrefix_txt.MaxLength = 5
        Me.ZIPPrefix_txt.Name = "ZIPPrefix_txt"
        Me.ZIPPrefix_txt.Size = New System.Drawing.Size(61, 21)
        Me.ZIPPrefix_txt.TabIndex = 6
        '
        'Zip_lbl
        '
        Me.Zip_lbl.AutoSize = True
        Me.Zip_lbl.Location = New System.Drawing.Point(208, 158)
        Me.Zip_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Zip_lbl.Name = "Zip_lbl"
        Me.Zip_lbl.Size = New System.Drawing.Size(28, 15)
        Me.Zip_lbl.TabIndex = 5
        Me.Zip_lbl.Text = "ZIP"
        '
        'State_dd
        '
        Me.State_dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.State_dd.FormattingEnabled = True
        Me.State_dd.Items.AddRange(New Object() {"", "MA", "CT", "VT", "NH", "NY", "RI", "ME"})
        Me.State_dd.Location = New System.Drawing.Point(83, 155)
        Me.State_dd.Name = "State_dd"
        Me.State_dd.Size = New System.Drawing.Size(47, 23)
        Me.State_dd.TabIndex = 4
        '
        'State_lbl
        '
        Me.State_lbl.AutoSize = True
        Me.State_lbl.Location = New System.Drawing.Point(4, 158)
        Me.State_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.State_lbl.Name = "State_lbl"
        Me.State_lbl.Size = New System.Drawing.Size(40, 15)
        Me.State_lbl.TabIndex = 10
        Me.State_lbl.Text = "State"
        '
        'City_txt
        '
        Me.City_txt.Location = New System.Drawing.Point(82, 128)
        Me.City_txt.MaxLength = 100
        Me.City_txt.Name = "City_txt"
        Me.City_txt.Size = New System.Drawing.Size(219, 21)
        Me.City_txt.TabIndex = 3
        '
        'City_lbl
        '
        Me.City_lbl.AutoSize = True
        Me.City_lbl.Location = New System.Drawing.Point(4, 131)
        Me.City_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.City_lbl.Name = "City_lbl"
        Me.City_lbl.Size = New System.Drawing.Size(30, 15)
        Me.City_lbl.TabIndex = 8
        Me.City_lbl.Text = "City"
        '
        'Address1_txt
        '
        Me.Address1_txt.Location = New System.Drawing.Point(82, 101)
        Me.Address1_txt.MaxLength = 40
        Me.Address1_txt.Name = "Address1_txt"
        Me.Address1_txt.Size = New System.Drawing.Size(219, 21)
        Me.Address1_txt.TabIndex = 2
        '
        'Address1_lbl
        '
        Me.Address1_lbl.AutoSize = True
        Me.Address1_lbl.Location = New System.Drawing.Point(4, 104)
        Me.Address1_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Address1_lbl.Name = "Address1_lbl"
        Me.Address1_lbl.Size = New System.Drawing.Size(62, 15)
        Me.Address1_lbl.TabIndex = 4
        Me.Address1_lbl.Text = "Address "
        '
        'FName_txt
        '
        Me.FName_txt.Location = New System.Drawing.Point(82, 47)
        Me.FName_txt.MaxLength = 40
        Me.FName_txt.Name = "FName_txt"
        Me.FName_txt.Size = New System.Drawing.Size(220, 21)
        Me.FName_txt.TabIndex = 0
        '
        'Name_lbl
        '
        Me.Name_lbl.AutoSize = True
        Me.Name_lbl.Location = New System.Drawing.Point(4, 50)
        Me.Name_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Name_lbl.Name = "Name_lbl"
        Me.Name_lbl.Size = New System.Drawing.Size(81, 15)
        Me.Name_lbl.TabIndex = 2
        Me.Name_lbl.Text = "First Name "
        '
        'BidderID_txt
        '
        Me.BidderID_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BidderID_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BidderID_txt.Enabled = False
        Me.BidderID_txt.Location = New System.Drawing.Point(83, 16)
        Me.BidderID_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.BidderID_txt.Name = "BidderID_txt"
        Me.BidderID_txt.Size = New System.Drawing.Size(63, 21)
        Me.BidderID_txt.TabIndex = 0
        '
        'DonorID_lbl
        '
        Me.DonorID_lbl.AutoSize = True
        Me.DonorID_lbl.Location = New System.Drawing.Point(4, 18)
        Me.DonorID_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DonorID_lbl.Name = "DonorID_lbl"
        Me.DonorID_lbl.Size = New System.Drawing.Size(67, 15)
        Me.DonorID_lbl.TabIndex = 0
        Me.DonorID_lbl.Text = "Bidder ID"
        '
        'DonorItem_gb
        '
        Me.DonorItem_gb.Controls.Add(Me.DataGridView1)
        Me.DonorItem_gb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorItem_gb.Location = New System.Drawing.Point(10, 399)
        Me.DonorItem_gb.Margin = New System.Windows.Forms.Padding(2)
        Me.DonorItem_gb.Name = "DonorItem_gb"
        Me.DonorItem_gb.Padding = New System.Windows.Forms.Padding(10, 4, 10, 10)
        Me.DonorItem_gb.Size = New System.Drawing.Size(629, 143)
        Me.DonorItem_gb.TabIndex = 0
        Me.DonorItem_gb.TabStop = False
        Me.DonorItem_gb.Text = " Bid History (Items Won):"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeight = 19
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemDateDonated, Me.ItemDesc, Me.ItemRetailVal, Me.ItemHighBid})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(13, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.RowTemplate.Height = 19
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(603, 110)
        Me.DataGridView1.TabIndex = 0
        '
        'ItemDateDonated
        '
        Me.ItemDateDonated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ItemDateDonated.DataPropertyName = "ItemDateDonated"
        Me.ItemDateDonated.HeaderText = "Date"
        Me.ItemDateDonated.MinimumWidth = 80
        Me.ItemDateDonated.Name = "ItemDateDonated"
        Me.ItemDateDonated.ReadOnly = True
        Me.ItemDateDonated.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemDateDonated.Width = 80
        '
        'ItemDesc
        '
        Me.ItemDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ItemDesc.DataPropertyName = "ItemDesc"
        Me.ItemDesc.HeaderText = "Item"
        Me.ItemDesc.MinimumWidth = 300
        Me.ItemDesc.Name = "ItemDesc"
        Me.ItemDesc.ReadOnly = True
        Me.ItemDesc.Width = 300
        '
        'ItemRetailVal
        '
        Me.ItemRetailVal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ItemRetailVal.DataPropertyName = "ItemRetailVal"
        Me.ItemRetailVal.HeaderText = "Retail Value"
        Me.ItemRetailVal.MinimumWidth = 90
        Me.ItemRetailVal.Name = "ItemRetailVal"
        Me.ItemRetailVal.ReadOnly = True
        Me.ItemRetailVal.Width = 90
        '
        'ItemHighBid
        '
        Me.ItemHighBid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ItemHighBid.DataPropertyName = "ItemHighBid"
        Me.ItemHighBid.HeaderText = "High Bid"
        Me.ItemHighBid.MinimumWidth = 90
        Me.ItemHighBid.Name = "ItemHighBid"
        Me.ItemHighBid.ReadOnly = True
        Me.ItemHighBid.Width = 90
        '
        'KBMApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(860, 580)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "KBMApplication"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KBM Application"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.BidderInfo_gb.ResumeLayout(False)
        Me.BidderInfo_gb.PerformLayout()
        Me.DonorItem_gb.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Bidder_lb As System.Windows.Forms.ListBox
    Friend WithEvents DonorItem_gb As System.Windows.Forms.GroupBox
    Friend WithEvents AppLabel As System.Windows.Forms.Label
    Friend WithEvents BidderInfo_gb As System.Windows.Forms.GroupBox
    Friend WithEvents EditBidder_btn As System.Windows.Forms.Button
    Friend WithEvents AddBidder_btn As System.Windows.Forms.Button
    Friend WithEvents BidderLB_lbl As System.Windows.Forms.Label
    Friend WithEvents BacktoMain_btn As System.Windows.Forms.Button
    Friend WithEvents MODE_V_lbl As System.Windows.Forms.Label
    Friend WithEvents FormDelete_btn As System.Windows.Forms.Button
    Friend WithEvents FormCancel_btn As System.Windows.Forms.Button
    Friend WithEvents FormAdd_btn As System.Windows.Forms.Button
    Friend WithEvents FName_txt As System.Windows.Forms.TextBox
    Friend WithEvents Name_lbl As System.Windows.Forms.Label
    Friend WithEvents BidderID_txt As System.Windows.Forms.TextBox
    Friend WithEvents DonorID_lbl As System.Windows.Forms.Label
    Friend WithEvents Email_txt As System.Windows.Forms.TextBox
    Friend WithEvents Email_lbl As System.Windows.Forms.Label
    Friend WithEvents PhonePrefix_txt As System.Windows.Forms.TextBox
    Friend WithEvents PhoneLine_txt As System.Windows.Forms.TextBox
    Friend WithEvents PhoneArea_txt As System.Windows.Forms.TextBox
    Friend WithEvents Phone_lbl As System.Windows.Forms.Label
    Friend WithEvents ZIPPrefix_txt As System.Windows.Forms.TextBox
    Friend WithEvents Zip_lbl As System.Windows.Forms.Label
    Friend WithEvents State_lbl As System.Windows.Forms.Label
    Friend WithEvents City_txt As System.Windows.Forms.TextBox
    Friend WithEvents City_lbl As System.Windows.Forms.Label
    Friend WithEvents Address1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Address1_lbl As System.Windows.Forms.Label
    Friend WithEvents NotActive_cb As System.Windows.Forms.CheckBox
    Friend WithEvents Memo_rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents Memo_lbl As System.Windows.Forms.Label
    Friend WithEvents Other_lbl As System.Windows.Forms.Label
    Public WithEvents State_dd As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Warning_lbl As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Active_lbl As System.Windows.Forms.Label
    Friend WithEvents PhonePrefix2_txt As System.Windows.Forms.TextBox
    Friend WithEvents PhoneLine2_txt As System.Windows.Forms.TextBox
    Friend WithEvents PhoneArea2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Phone2_lbl As System.Windows.Forms.Label
    Friend WithEvents LName_txt As System.Windows.Forms.TextBox
    Friend WithEvents Name2_lbl As System.Windows.Forms.Label
    Friend WithEvents KMember_cb As System.Windows.Forms.CheckBox
    Friend WithEvents Member_lbl As System.Windows.Forms.Label
    Friend WithEvents ItemDateDonated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemRetailVal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemHighBid As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
