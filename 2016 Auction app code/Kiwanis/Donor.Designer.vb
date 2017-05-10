<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxViewNotActive = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DonorLB_lbl = New System.Windows.Forms.Label()
        Me.BacktoMain_btn = New System.Windows.Forms.Button()
        Me.EditDonor_btn = New System.Windows.Forms.Button()
        Me.AddDonor_btn = New System.Windows.Forms.Button()
        Me.Donor_lb = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MODE_V_lbl = New System.Windows.Forms.Label()
        Me.FormDelete_btn = New System.Windows.Forms.Button()
        Me.FormCancel_btn = New System.Windows.Forms.Button()
        Me.FormAdd_btn = New System.Windows.Forms.Button()
        Me.AppLabel = New System.Windows.Forms.Label()
        Me.DonorInfo_gb = New System.Windows.Forms.GroupBox()
        Me.Solicitor_cb = New System.Windows.Forms.ComboBox()
        Me.Active_lbl = New System.Windows.Forms.Label()
        Me.SolMem_lbl = New System.Windows.Forms.Label()
        Me.Warning_lbl = New System.Windows.Forms.Label()
        Me.Other_lbl = New System.Windows.Forms.Label()
        Me.NotActive_cb = New System.Windows.Forms.CheckBox()
        Me.NonProfit_cb = New System.Windows.Forms.CheckBox()
        Me.Memo_rtb = New System.Windows.Forms.RichTextBox()
        Me.Memo_lbl = New System.Windows.Forms.Label()
        Me.Web_txt = New System.Windows.Forms.TextBox()
        Me.Web_lbl = New System.Windows.Forms.Label()
        Me.Email_txt = New System.Windows.Forms.TextBox()
        Me.Email_lbl = New System.Windows.Forms.Label()
        Me.PhoneExt_txt = New System.Windows.Forms.TextBox()
        Me.PhoneExt_lbl = New System.Windows.Forms.Label()
        Me.PhonePrefix_txt = New System.Windows.Forms.TextBox()
        Me.PhoneLine_txt = New System.Windows.Forms.TextBox()
        Me.PhoneArea_txt = New System.Windows.Forms.TextBox()
        Me.Phone_lbl = New System.Windows.Forms.Label()
        Me.ContactName_txt = New System.Windows.Forms.TextBox()
        Me.Contact_lbl = New System.Windows.Forms.Label()
        Me.ZIPPrefix_txt = New System.Windows.Forms.TextBox()
        Me.Zip_lbl = New System.Windows.Forms.Label()
        Me.State_dd = New System.Windows.Forms.ComboBox()
        Me.State_lbl = New System.Windows.Forms.Label()
        Me.City_txt = New System.Windows.Forms.TextBox()
        Me.City_lbl = New System.Windows.Forms.Label()
        Me.Address2_txt = New System.Windows.Forms.TextBox()
        Me.Address2_lbl = New System.Windows.Forms.Label()
        Me.Address1_txt = New System.Windows.Forms.TextBox()
        Me.Address1_lbl = New System.Windows.Forms.Label()
        Me.Name_txt = New System.Windows.Forms.TextBox()
        Me.Name_lbl = New System.Windows.Forms.Label()
        Me.DonorID_txt = New System.Windows.Forms.TextBox()
        Me.DonorID_lbl = New System.Windows.Forms.Label()
        Me.DonorItem_gb = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemDateDonated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemRetailVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemHighBid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.DonorInfo_gb.SuspendLayout()
        Me.DonorItem_gb.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbxViewNotActive)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DonorLB_lbl)
        Me.Panel1.Controls.Add(Me.BacktoMain_btn)
        Me.Panel1.Controls.Add(Me.EditDonor_btn)
        Me.Panel1.Controls.Add(Me.AddDonor_btn)
        Me.Panel1.Controls.Add(Me.Donor_lb)
        Me.Panel1.Location = New System.Drawing.Point(12, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(228, 618)
        Me.Panel1.TabIndex = 0
        '
        'cbxViewNotActive
        '
        Me.cbxViewNotActive.AutoSize = True
        Me.cbxViewNotActive.Location = New System.Drawing.Point(11, 483)
        Me.cbxViewNotActive.Name = "cbxViewNotActive"
        Me.cbxViewNotActive.Size = New System.Drawing.Size(148, 17)
        Me.cbxViewNotActive.TabIndex = 9
        Me.cbxViewNotActive.Text = "View None Active Donors"
        Me.cbxViewNotActive.UseVisualStyleBackColor = True
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
        'DonorLB_lbl
        '
        Me.DonorLB_lbl.AutoSize = True
        Me.DonorLB_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorLB_lbl.Location = New System.Drawing.Point(8, 8)
        Me.DonorLB_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DonorLB_lbl.Name = "DonorLB_lbl"
        Me.DonorLB_lbl.Size = New System.Drawing.Size(57, 15)
        Me.DonorLB_lbl.TabIndex = 3
        Me.DonorLB_lbl.Text = "Donors:"
        '
        'BacktoMain_btn
        '
        Me.BacktoMain_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BacktoMain_btn.Location = New System.Drawing.Point(10, 580)
        Me.BacktoMain_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.BacktoMain_btn.Name = "BacktoMain_btn"
        Me.BacktoMain_btn.Size = New System.Drawing.Size(138, 26)
        Me.BacktoMain_btn.TabIndex = 3
        Me.BacktoMain_btn.Text = "Back to Main"
        Me.BacktoMain_btn.UseVisualStyleBackColor = True
        '
        'EditDonor_btn
        '
        Me.EditDonor_btn.Location = New System.Drawing.Point(10, 540)
        Me.EditDonor_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.EditDonor_btn.Name = "EditDonor_btn"
        Me.EditDonor_btn.Size = New System.Drawing.Size(138, 24)
        Me.EditDonor_btn.TabIndex = 1
        Me.EditDonor_btn.Text = "EDIT Donor"
        Me.EditDonor_btn.UseVisualStyleBackColor = True
        '
        'AddDonor_btn
        '
        Me.AddDonor_btn.Location = New System.Drawing.Point(10, 512)
        Me.AddDonor_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddDonor_btn.Name = "AddDonor_btn"
        Me.AddDonor_btn.Size = New System.Drawing.Size(138, 24)
        Me.AddDonor_btn.TabIndex = 2
        Me.AddDonor_btn.Text = "ADD Donor"
        Me.AddDonor_btn.UseVisualStyleBackColor = True
        '
        'Donor_lb
        '
        Me.Donor_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Donor_lb.FormattingEnabled = True
        Me.Donor_lb.Location = New System.Drawing.Point(10, 25)
        Me.Donor_lb.Margin = New System.Windows.Forms.Padding(2)
        Me.Donor_lb.Name = "Donor_lb"
        Me.Donor_lb.Size = New System.Drawing.Size(206, 457)
        Me.Donor_lb.TabIndex = 0
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
        Me.Panel2.Controls.Add(Me.DonorInfo_gb)
        Me.Panel2.Controls.Add(Me.DonorItem_gb)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(244, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel2.Size = New System.Drawing.Size(651, 618)
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
        Me.AppLabel.Size = New System.Drawing.Size(193, 24)
        Me.AppLabel.TabIndex = 2
        Me.AppLabel.Text = "Donor Maintenance"
        '
        'DonorInfo_gb
        '
        Me.DonorInfo_gb.Controls.Add(Me.Solicitor_cb)
        Me.DonorInfo_gb.Controls.Add(Me.Active_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.SolMem_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.Warning_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.Other_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.NotActive_cb)
        Me.DonorInfo_gb.Controls.Add(Me.NonProfit_cb)
        Me.DonorInfo_gb.Controls.Add(Me.Memo_rtb)
        Me.DonorInfo_gb.Controls.Add(Me.Memo_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.Web_txt)
        Me.DonorInfo_gb.Controls.Add(Me.Web_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.Email_txt)
        Me.DonorInfo_gb.Controls.Add(Me.Email_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.PhoneExt_txt)
        Me.DonorInfo_gb.Controls.Add(Me.PhoneExt_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.PhonePrefix_txt)
        Me.DonorInfo_gb.Controls.Add(Me.PhoneLine_txt)
        Me.DonorInfo_gb.Controls.Add(Me.PhoneArea_txt)
        Me.DonorInfo_gb.Controls.Add(Me.Phone_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.ContactName_txt)
        Me.DonorInfo_gb.Controls.Add(Me.Contact_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.ZIPPrefix_txt)
        Me.DonorInfo_gb.Controls.Add(Me.Zip_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.State_dd)
        Me.DonorInfo_gb.Controls.Add(Me.State_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.City_txt)
        Me.DonorInfo_gb.Controls.Add(Me.City_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.Address2_txt)
        Me.DonorInfo_gb.Controls.Add(Me.Address2_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.Address1_txt)
        Me.DonorInfo_gb.Controls.Add(Me.Address1_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.Name_txt)
        Me.DonorInfo_gb.Controls.Add(Me.Name_lbl)
        Me.DonorInfo_gb.Controls.Add(Me.DonorID_txt)
        Me.DonorInfo_gb.Controls.Add(Me.DonorID_lbl)
        Me.DonorInfo_gb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorInfo_gb.Location = New System.Drawing.Point(10, 34)
        Me.DonorInfo_gb.Margin = New System.Windows.Forms.Padding(2)
        Me.DonorInfo_gb.Name = "DonorInfo_gb"
        Me.DonorInfo_gb.Padding = New System.Windows.Forms.Padding(2, 2, 10, 10)
        Me.DonorInfo_gb.Size = New System.Drawing.Size(529, 411)
        Me.DonorInfo_gb.TabIndex = 1
        Me.DonorInfo_gb.TabStop = False
        '
        'Solicitor_cb
        '
        Me.Solicitor_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Solicitor_cb.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Solicitor_cb.FormattingEnabled = True
        Me.Solicitor_cb.Location = New System.Drawing.Point(73, 48)
        Me.Solicitor_cb.Name = "Solicitor_cb"
        Me.Solicitor_cb.Size = New System.Drawing.Size(219, 23)
        Me.Solicitor_cb.TabIndex = 0
        '
        'Active_lbl
        '
        Me.Active_lbl.AutoSize = True
        Me.Active_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Active_lbl.ForeColor = System.Drawing.Color.Indigo
        Me.Active_lbl.Location = New System.Drawing.Point(332, 16)
        Me.Active_lbl.Name = "Active_lbl"
        Me.Active_lbl.Size = New System.Drawing.Size(189, 29)
        Me.Active_lbl.TabIndex = 38
        Me.Active_lbl.Text = "not active label"
        '
        'SolMem_lbl
        '
        Me.SolMem_lbl.AutoSize = True
        Me.SolMem_lbl.Location = New System.Drawing.Point(4, 54)
        Me.SolMem_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SolMem_lbl.Name = "SolMem_lbl"
        Me.SolMem_lbl.Size = New System.Drawing.Size(60, 15)
        Me.SolMem_lbl.TabIndex = 35
        Me.SolMem_lbl.Text = "Solicitor"
        '
        'Warning_lbl
        '
        Me.Warning_lbl.AutoSize = True
        Me.Warning_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Warning_lbl.ForeColor = System.Drawing.Color.Red
        Me.Warning_lbl.Location = New System.Drawing.Point(10, 385)
        Me.Warning_lbl.Name = "Warning_lbl"
        Me.Warning_lbl.Size = New System.Drawing.Size(273, 16)
        Me.Warning_lbl.TabIndex = 34
        Me.Warning_lbl.Text = "input warning label > > > > > > > > > > > "
        '
        'Other_lbl
        '
        Me.Other_lbl.AutoSize = True
        Me.Other_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Other_lbl.Location = New System.Drawing.Point(334, 81)
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
        Me.NotActive_cb.Location = New System.Drawing.Point(353, 101)
        Me.NotActive_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.NotActive_cb.Name = "NotActive_cb"
        Me.NotActive_cb.Size = New System.Drawing.Size(98, 20)
        Me.NotActive_cb.TabIndex = 15
        Me.NotActive_cb.Text = "Not Active"
        Me.NotActive_cb.UseVisualStyleBackColor = True
        '
        'NonProfit_cb
        '
        Me.NonProfit_cb.AutoSize = True
        Me.NonProfit_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NonProfit_cb.Location = New System.Drawing.Point(353, 122)
        Me.NonProfit_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.NonProfit_cb.Name = "NonProfit_cb"
        Me.NonProfit_cb.Size = New System.Drawing.Size(96, 20)
        Me.NonProfit_cb.TabIndex = 16
        Me.NonProfit_cb.Text = "Non-Profit"
        Me.NonProfit_cb.UseVisualStyleBackColor = True
        '
        'Memo_rtb
        '
        Me.Memo_rtb.Location = New System.Drawing.Point(72, 322)
        Me.Memo_rtb.MaxLength = 1000
        Me.Memo_rtb.Name = "Memo_rtb"
        Me.Memo_rtb.Size = New System.Drawing.Size(444, 57)
        Me.Memo_rtb.TabIndex = 14
        Me.Memo_rtb.Text = ""
        '
        'Memo_lbl
        '
        Me.Memo_lbl.AutoSize = True
        Me.Memo_lbl.Location = New System.Drawing.Point(2, 322)
        Me.Memo_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Memo_lbl.Name = "Memo_lbl"
        Me.Memo_lbl.Size = New System.Drawing.Size(47, 15)
        Me.Memo_lbl.TabIndex = 27
        Me.Memo_lbl.Text = "Memo"
        '
        'Web_txt
        '
        Me.Web_txt.Location = New System.Drawing.Point(74, 295)
        Me.Web_txt.MaxLength = 100
        Me.Web_txt.Name = "Web_txt"
        Me.Web_txt.Size = New System.Drawing.Size(220, 21)
        Me.Web_txt.TabIndex = 13
        '
        'Web_lbl
        '
        Me.Web_lbl.AutoSize = True
        Me.Web_lbl.Location = New System.Drawing.Point(4, 298)
        Me.Web_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Web_lbl.Name = "Web_lbl"
        Me.Web_lbl.Size = New System.Drawing.Size(58, 15)
        Me.Web_lbl.TabIndex = 25
        Me.Web_lbl.Text = "Website"
        '
        'Email_txt
        '
        Me.Email_txt.Location = New System.Drawing.Point(74, 268)
        Me.Email_txt.MaxLength = 100
        Me.Email_txt.Name = "Email_txt"
        Me.Email_txt.Size = New System.Drawing.Size(219, 21)
        Me.Email_txt.TabIndex = 12
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Location = New System.Drawing.Point(4, 271)
        Me.Email_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(44, 15)
        Me.Email_lbl.TabIndex = 23
        Me.Email_lbl.Text = "Email"
        '
        'PhoneExt_txt
        '
        Me.PhoneExt_txt.Location = New System.Drawing.Point(243, 241)
        Me.PhoneExt_txt.MaxLength = 7
        Me.PhoneExt_txt.Name = "PhoneExt_txt"
        Me.PhoneExt_txt.Size = New System.Drawing.Size(48, 21)
        Me.PhoneExt_txt.TabIndex = 11
        '
        'PhoneExt_lbl
        '
        Me.PhoneExt_lbl.AutoSize = True
        Me.PhoneExt_lbl.Location = New System.Drawing.Point(218, 244)
        Me.PhoneExt_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PhoneExt_lbl.Name = "PhoneExt_lbl"
        Me.PhoneExt_lbl.Size = New System.Drawing.Size(27, 15)
        Me.PhoneExt_lbl.TabIndex = 21
        Me.PhoneExt_lbl.Text = "Ext"
        '
        'PhonePrefix_txt
        '
        Me.PhonePrefix_txt.Location = New System.Drawing.Point(119, 241)
        Me.PhonePrefix_txt.MaxLength = 3
        Me.PhonePrefix_txt.Name = "PhonePrefix_txt"
        Me.PhonePrefix_txt.Size = New System.Drawing.Size(41, 21)
        Me.PhonePrefix_txt.TabIndex = 9
        '
        'PhoneLine_txt
        '
        Me.PhoneLine_txt.Location = New System.Drawing.Point(163, 241)
        Me.PhoneLine_txt.MaxLength = 4
        Me.PhoneLine_txt.Name = "PhoneLine_txt"
        Me.PhoneLine_txt.Size = New System.Drawing.Size(50, 21)
        Me.PhoneLine_txt.TabIndex = 10
        '
        'PhoneArea_txt
        '
        Me.PhoneArea_txt.Location = New System.Drawing.Point(72, 241)
        Me.PhoneArea_txt.MaxLength = 3
        Me.PhoneArea_txt.Name = "PhoneArea_txt"
        Me.PhoneArea_txt.Size = New System.Drawing.Size(41, 21)
        Me.PhoneArea_txt.TabIndex = 8
        '
        'Phone_lbl
        '
        Me.Phone_lbl.AutoSize = True
        Me.Phone_lbl.Location = New System.Drawing.Point(4, 244)
        Me.Phone_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Phone_lbl.Name = "Phone_lbl"
        Me.Phone_lbl.Size = New System.Drawing.Size(48, 15)
        Me.Phone_lbl.TabIndex = 17
        Me.Phone_lbl.Text = "Phone"
        '
        'ContactName_txt
        '
        Me.ContactName_txt.Location = New System.Drawing.Point(73, 214)
        Me.ContactName_txt.Name = "ContactName_txt"
        Me.ContactName_txt.Size = New System.Drawing.Size(219, 21)
        Me.ContactName_txt.TabIndex = 7
        '
        'Contact_lbl
        '
        Me.Contact_lbl.AutoSize = True
        Me.Contact_lbl.Location = New System.Drawing.Point(4, 217)
        Me.Contact_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Contact_lbl.Name = "Contact_lbl"
        Me.Contact_lbl.Size = New System.Drawing.Size(55, 15)
        Me.Contact_lbl.TabIndex = 15
        Me.Contact_lbl.Text = "Contact"
        '
        'ZIPPrefix_txt
        '
        Me.ZIPPrefix_txt.Location = New System.Drawing.Point(231, 185)
        Me.ZIPPrefix_txt.MaxLength = 5
        Me.ZIPPrefix_txt.Name = "ZIPPrefix_txt"
        Me.ZIPPrefix_txt.Size = New System.Drawing.Size(61, 21)
        Me.ZIPPrefix_txt.TabIndex = 6
        '
        'Zip_lbl
        '
        Me.Zip_lbl.AutoSize = True
        Me.Zip_lbl.Location = New System.Drawing.Point(198, 188)
        Me.Zip_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Zip_lbl.Name = "Zip_lbl"
        Me.Zip_lbl.Size = New System.Drawing.Size(28, 15)
        Me.Zip_lbl.TabIndex = 12
        Me.Zip_lbl.Text = "ZIP"
        '
        'State_dd
        '
        Me.State_dd.AllowDrop = True
        Me.State_dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.State_dd.FormattingEnabled = True
        Me.State_dd.Items.AddRange(New Object() {"", "MA", "CT", "VT", "NH", "NY", "RI", "ME"})
        Me.State_dd.Location = New System.Drawing.Point(72, 185)
        Me.State_dd.Name = "State_dd"
        Me.State_dd.Size = New System.Drawing.Size(47, 23)
        Me.State_dd.TabIndex = 5
        '
        'State_lbl
        '
        Me.State_lbl.AutoSize = True
        Me.State_lbl.Location = New System.Drawing.Point(4, 188)
        Me.State_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.State_lbl.Name = "State_lbl"
        Me.State_lbl.Size = New System.Drawing.Size(40, 15)
        Me.State_lbl.TabIndex = 10
        Me.State_lbl.Text = "State"
        '
        'City_txt
        '
        Me.City_txt.Location = New System.Drawing.Point(73, 158)
        Me.City_txt.MaxLength = 100
        Me.City_txt.Name = "City_txt"
        Me.City_txt.Size = New System.Drawing.Size(219, 21)
        Me.City_txt.TabIndex = 4
        '
        'City_lbl
        '
        Me.City_lbl.AutoSize = True
        Me.City_lbl.Location = New System.Drawing.Point(4, 161)
        Me.City_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.City_lbl.Name = "City_lbl"
        Me.City_lbl.Size = New System.Drawing.Size(30, 15)
        Me.City_lbl.TabIndex = 8
        Me.City_lbl.Text = "City"
        '
        'Address2_txt
        '
        Me.Address2_txt.Location = New System.Drawing.Point(73, 131)
        Me.Address2_txt.MaxLength = 40
        Me.Address2_txt.Name = "Address2_txt"
        Me.Address2_txt.Size = New System.Drawing.Size(220, 21)
        Me.Address2_txt.TabIndex = 3
        '
        'Address2_lbl
        '
        Me.Address2_lbl.AutoSize = True
        Me.Address2_lbl.Location = New System.Drawing.Point(4, 134)
        Me.Address2_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Address2_lbl.Name = "Address2_lbl"
        Me.Address2_lbl.Size = New System.Drawing.Size(70, 15)
        Me.Address2_lbl.TabIndex = 6
        Me.Address2_lbl.Text = "Address 2"
        '
        'Address1_txt
        '
        Me.Address1_txt.Location = New System.Drawing.Point(72, 104)
        Me.Address1_txt.MaxLength = 40
        Me.Address1_txt.Name = "Address1_txt"
        Me.Address1_txt.Size = New System.Drawing.Size(219, 21)
        Me.Address1_txt.TabIndex = 2
        '
        'Address1_lbl
        '
        Me.Address1_lbl.AutoSize = True
        Me.Address1_lbl.Location = New System.Drawing.Point(4, 107)
        Me.Address1_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Address1_lbl.Name = "Address1_lbl"
        Me.Address1_lbl.Size = New System.Drawing.Size(70, 15)
        Me.Address1_lbl.TabIndex = 4
        Me.Address1_lbl.Text = "Address 1"
        '
        'Name_txt
        '
        Me.Name_txt.Location = New System.Drawing.Point(72, 77)
        Me.Name_txt.MaxLength = 40
        Me.Name_txt.Name = "Name_txt"
        Me.Name_txt.Size = New System.Drawing.Size(220, 21)
        Me.Name_txt.TabIndex = 1
        '
        'Name_lbl
        '
        Me.Name_lbl.AutoSize = True
        Me.Name_lbl.Location = New System.Drawing.Point(4, 83)
        Me.Name_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Name_lbl.Name = "Name_lbl"
        Me.Name_lbl.Size = New System.Drawing.Size(45, 15)
        Me.Name_lbl.TabIndex = 2
        Me.Name_lbl.Text = "Name"
        '
        'DonorID_txt
        '
        Me.DonorID_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DonorID_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DonorID_txt.Enabled = False
        Me.DonorID_txt.Location = New System.Drawing.Point(73, 18)
        Me.DonorID_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.DonorID_txt.Name = "DonorID_txt"
        Me.DonorID_txt.Size = New System.Drawing.Size(63, 21)
        Me.DonorID_txt.TabIndex = 0
        '
        'DonorID_lbl
        '
        Me.DonorID_lbl.AutoSize = True
        Me.DonorID_lbl.Location = New System.Drawing.Point(4, 20)
        Me.DonorID_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DonorID_lbl.Name = "DonorID_lbl"
        Me.DonorID_lbl.Size = New System.Drawing.Size(64, 15)
        Me.DonorID_lbl.TabIndex = 0
        Me.DonorID_lbl.Text = "Donor ID"
        '
        'DonorItem_gb
        '
        Me.DonorItem_gb.Controls.Add(Me.DataGridView1)
        Me.DonorItem_gb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorItem_gb.Location = New System.Drawing.Point(10, 463)
        Me.DonorItem_gb.Margin = New System.Windows.Forms.Padding(2)
        Me.DonorItem_gb.Name = "DonorItem_gb"
        Me.DonorItem_gb.Padding = New System.Windows.Forms.Padding(10, 4, 10, 10)
        Me.DonorItem_gb.Size = New System.Drawing.Size(629, 143)
        Me.DonorItem_gb.TabIndex = 0
        Me.DonorItem_gb.TabStop = False
        Me.DonorItem_gb.Text = "Donor Item(s):"
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
        Me.DataGridView1.Location = New System.Drawing.Point(13, 20)
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
        Me.ItemHighBid.HeaderText = "Highest Bid"
        Me.ItemHighBid.MinimumWidth = 90
        Me.ItemHighBid.Name = "ItemHighBid"
        Me.ItemHighBid.ReadOnly = True
        Me.ItemHighBid.Width = 90
        '
        'Donor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(908, 640)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Donor"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donor Maintenance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.DonorInfo_gb.ResumeLayout(False)
        Me.DonorInfo_gb.PerformLayout()
        Me.DonorItem_gb.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Donor_lb As System.Windows.Forms.ListBox
    Friend WithEvents DonorItem_gb As System.Windows.Forms.GroupBox
    Friend WithEvents AppLabel As System.Windows.Forms.Label
    Friend WithEvents DonorInfo_gb As System.Windows.Forms.GroupBox
    Friend WithEvents EditDonor_btn As System.Windows.Forms.Button
    Friend WithEvents AddDonor_btn As System.Windows.Forms.Button
    Friend WithEvents DonorLB_lbl As System.Windows.Forms.Label
    Friend WithEvents BacktoMain_btn As System.Windows.Forms.Button
    Friend WithEvents MODE_V_lbl As System.Windows.Forms.Label
    Friend WithEvents FormDelete_btn As System.Windows.Forms.Button
    Friend WithEvents FormCancel_btn As System.Windows.Forms.Button
    Friend WithEvents FormAdd_btn As System.Windows.Forms.Button
    Friend WithEvents Name_txt As System.Windows.Forms.TextBox
    Friend WithEvents Name_lbl As System.Windows.Forms.Label
    Friend WithEvents DonorID_txt As System.Windows.Forms.TextBox
    Friend WithEvents DonorID_lbl As System.Windows.Forms.Label
    Friend WithEvents Web_txt As System.Windows.Forms.TextBox
    Friend WithEvents Web_lbl As System.Windows.Forms.Label
    Friend WithEvents Email_txt As System.Windows.Forms.TextBox
    Friend WithEvents Email_lbl As System.Windows.Forms.Label
    Friend WithEvents PhoneExt_txt As System.Windows.Forms.TextBox
    Friend WithEvents PhoneExt_lbl As System.Windows.Forms.Label
    Friend WithEvents PhonePrefix_txt As System.Windows.Forms.TextBox
    Friend WithEvents PhoneLine_txt As System.Windows.Forms.TextBox
    Friend WithEvents PhoneArea_txt As System.Windows.Forms.TextBox
    Friend WithEvents Phone_lbl As System.Windows.Forms.Label
    Friend WithEvents ContactName_txt As System.Windows.Forms.TextBox
    Friend WithEvents Contact_lbl As System.Windows.Forms.Label
    Friend WithEvents ZIPPrefix_txt As System.Windows.Forms.TextBox
    Friend WithEvents Zip_lbl As System.Windows.Forms.Label
    Friend WithEvents State_lbl As System.Windows.Forms.Label
    Friend WithEvents City_txt As System.Windows.Forms.TextBox
    Friend WithEvents City_lbl As System.Windows.Forms.Label
    Friend WithEvents Address2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Address2_lbl As System.Windows.Forms.Label
    Friend WithEvents Address1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Address1_lbl As System.Windows.Forms.Label
    Friend WithEvents NotActive_cb As System.Windows.Forms.CheckBox
    Friend WithEvents NonProfit_cb As System.Windows.Forms.CheckBox
    Friend WithEvents Memo_rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents Memo_lbl As System.Windows.Forms.Label
    Friend WithEvents Other_lbl As System.Windows.Forms.Label
    Public WithEvents State_dd As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Warning_lbl As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SolMem_lbl As System.Windows.Forms.Label
    Friend WithEvents ItemDateDonated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemRetailVal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemHighBid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Active_lbl As System.Windows.Forms.Label
    Friend WithEvents Solicitor_cb As System.Windows.Forms.ComboBox
    Friend WithEvents cbxViewNotActive As System.Windows.Forms.CheckBox

End Class
