<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class K_DBCC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(K_DBCC))
        Me.Host_lbl = New System.Windows.Forms.Label()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Host_txt = New System.Windows.Forms.TextBox()
        Me.Pass_lbl = New System.Windows.Forms.Label()
        Me.User_lbl = New System.Windows.Forms.Label()
        Me.Pass_txt = New System.Windows.Forms.TextBox()
        Me.User_txt = New System.Windows.Forms.TextBox()
        Me.Close_btn = New System.Windows.Forms.Button()
        Me.Catalog_txt = New System.Windows.Forms.TextBox()
        Me.Catalog_lbl = New System.Windows.Forms.Label()
        Me.gbDBConfig = New System.Windows.Forms.GroupBox()
        Me.gbAppConfig = New System.Windows.Forms.GroupBox()
        Me.txtAuctPass = New System.Windows.Forms.TextBox()
        Me.lblAuctPass = New System.Windows.Forms.Label()
        Me.txtAdminPass = New System.Windows.Forms.TextBox()
        Me.lblAdminPass = New System.Windows.Forms.Label()
        Me.gbAuctionConfig = New System.Windows.Forms.GroupBox()
        Me.txtSuperBlkMinBid = New System.Windows.Forms.TextBox()
        Me.lblSuperBlkMinBid = New System.Windows.Forms.Label()
        Me.gbFormControl = New System.Windows.Forms.GroupBox()
        Me.cbAddEditKiwanian = New System.Windows.Forms.CheckBox()
        Me.cbReports = New System.Windows.Forms.CheckBox()
        Me.cbPlaceBid = New System.Windows.Forms.CheckBox()
        Me.cbViewBid = New System.Windows.Forms.CheckBox()
        Me.cbAssignItemBlock = New System.Windows.Forms.CheckBox()
        Me.cbAddEditBlock = New System.Windows.Forms.CheckBox()
        Me.cbAddEditBidder = New System.Windows.Forms.CheckBox()
        Me.cbAddEditItem = New System.Windows.Forms.CheckBox()
        Me.cbAddEditDonor = New System.Windows.Forms.CheckBox()
        Me.cbAuctDirective = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbDBConfig.SuspendLayout()
        Me.gbAppConfig.SuspendLayout()
        Me.gbAuctionConfig.SuspendLayout()
        Me.gbFormControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Host_lbl
        '
        Me.Host_lbl.AutoSize = True
        Me.Host_lbl.Location = New System.Drawing.Point(20, 26)
        Me.Host_lbl.Name = "Host_lbl"
        Me.Host_lbl.Size = New System.Drawing.Size(68, 13)
        Me.Host_lbl.TabIndex = 0
        Me.Host_lbl.Text = "Host/Server:"
        '
        'Save_btn
        '
        Me.Save_btn.Location = New System.Drawing.Point(264, 514)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(75, 23)
        Me.Save_btn.TabIndex = 2
        Me.Save_btn.Text = "SAVE"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Host_txt
        '
        Me.Host_txt.Location = New System.Drawing.Point(94, 23)
        Me.Host_txt.Name = "Host_txt"
        Me.Host_txt.Size = New System.Drawing.Size(303, 20)
        Me.Host_txt.TabIndex = 3
        Me.Host_txt.Text = "Host/Server data."
        '
        'Pass_lbl
        '
        Me.Pass_lbl.AutoSize = True
        Me.Pass_lbl.Location = New System.Drawing.Point(20, 104)
        Me.Pass_lbl.Name = "Pass_lbl"
        Me.Pass_lbl.Size = New System.Drawing.Size(56, 13)
        Me.Pass_lbl.TabIndex = 4
        Me.Pass_lbl.Text = "Password:"
        '
        'User_lbl
        '
        Me.User_lbl.AutoSize = True
        Me.User_lbl.Location = New System.Drawing.Point(20, 78)
        Me.User_lbl.Name = "User_lbl"
        Me.User_lbl.Size = New System.Drawing.Size(58, 13)
        Me.User_lbl.TabIndex = 5
        Me.User_lbl.Text = "Username:"
        '
        'Pass_txt
        '
        Me.Pass_txt.Location = New System.Drawing.Point(94, 101)
        Me.Pass_txt.Name = "Pass_txt"
        Me.Pass_txt.Size = New System.Drawing.Size(303, 20)
        Me.Pass_txt.TabIndex = 6
        Me.Pass_txt.Text = "Password data."
        '
        'User_txt
        '
        Me.User_txt.Location = New System.Drawing.Point(94, 75)
        Me.User_txt.Name = "User_txt"
        Me.User_txt.Size = New System.Drawing.Size(303, 20)
        Me.User_txt.TabIndex = 7
        Me.User_txt.Text = "Username data."
        '
        'Close_btn
        '
        Me.Close_btn.Location = New System.Drawing.Point(345, 514)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(75, 23)
        Me.Close_btn.TabIndex = 9
        Me.Close_btn.Text = "Close"
        Me.Close_btn.UseVisualStyleBackColor = True
        '
        'Catalog_txt
        '
        Me.Catalog_txt.Location = New System.Drawing.Point(94, 49)
        Me.Catalog_txt.Name = "Catalog_txt"
        Me.Catalog_txt.Size = New System.Drawing.Size(303, 20)
        Me.Catalog_txt.TabIndex = 11
        Me.Catalog_txt.Text = "Catalog/Database data."
        '
        'Catalog_lbl
        '
        Me.Catalog_lbl.AutoSize = True
        Me.Catalog_lbl.Location = New System.Drawing.Point(20, 52)
        Me.Catalog_lbl.Name = "Catalog_lbl"
        Me.Catalog_lbl.Size = New System.Drawing.Size(66, 13)
        Me.Catalog_lbl.TabIndex = 10
        Me.Catalog_lbl.Text = "Catalog/DB:"
        '
        'gbDBConfig
        '
        Me.gbDBConfig.Controls.Add(Me.Host_lbl)
        Me.gbDBConfig.Controls.Add(Me.Catalog_txt)
        Me.gbDBConfig.Controls.Add(Me.Host_txt)
        Me.gbDBConfig.Controls.Add(Me.Catalog_lbl)
        Me.gbDBConfig.Controls.Add(Me.Pass_lbl)
        Me.gbDBConfig.Controls.Add(Me.User_lbl)
        Me.gbDBConfig.Controls.Add(Me.User_txt)
        Me.gbDBConfig.Controls.Add(Me.Pass_txt)
        Me.gbDBConfig.Location = New System.Drawing.Point(12, 12)
        Me.gbDBConfig.Name = "gbDBConfig"
        Me.gbDBConfig.Size = New System.Drawing.Size(408, 135)
        Me.gbDBConfig.TabIndex = 12
        Me.gbDBConfig.TabStop = False
        Me.gbDBConfig.Text = "Database Configuration"
        '
        'gbAppConfig
        '
        Me.gbAppConfig.Controls.Add(Me.txtAuctPass)
        Me.gbAppConfig.Controls.Add(Me.lblAuctPass)
        Me.gbAppConfig.Controls.Add(Me.txtAdminPass)
        Me.gbAppConfig.Controls.Add(Me.lblAdminPass)
        Me.gbAppConfig.Location = New System.Drawing.Point(12, 153)
        Me.gbAppConfig.Name = "gbAppConfig"
        Me.gbAppConfig.Size = New System.Drawing.Size(408, 83)
        Me.gbAppConfig.TabIndex = 13
        Me.gbAppConfig.TabStop = False
        Me.gbAppConfig.Text = "Application Password Configuration"
        '
        'txtAuctPass
        '
        Me.txtAuctPass.Location = New System.Drawing.Point(145, 47)
        Me.txtAuctPass.Name = "txtAuctPass"
        Me.txtAuctPass.Size = New System.Drawing.Size(252, 20)
        Me.txtAuctPass.TabIndex = 3
        '
        'lblAuctPass
        '
        Me.lblAuctPass.AutoSize = True
        Me.lblAuctPass.Location = New System.Drawing.Point(21, 50)
        Me.lblAuctPass.Name = "lblAuctPass"
        Me.lblAuctPass.Size = New System.Drawing.Size(110, 13)
        Me.lblAuctPass.TabIndex = 2
        Me.lblAuctPass.Text = "Auctioneer Password:"
        '
        'txtAdminPass
        '
        Me.txtAdminPass.Location = New System.Drawing.Point(145, 22)
        Me.txtAdminPass.Name = "txtAdminPass"
        Me.txtAdminPass.Size = New System.Drawing.Size(252, 20)
        Me.txtAdminPass.TabIndex = 1
        '
        'lblAdminPass
        '
        Me.lblAdminPass.AutoSize = True
        Me.lblAdminPass.Location = New System.Drawing.Point(20, 25)
        Me.lblAdminPass.Name = "lblAdminPass"
        Me.lblAdminPass.Size = New System.Drawing.Size(119, 13)
        Me.lblAdminPass.TabIndex = 0
        Me.lblAdminPass.Text = "Administrator Password:"
        '
        'gbAuctionConfig
        '
        Me.gbAuctionConfig.Controls.Add(Me.txtSuperBlkMinBid)
        Me.gbAuctionConfig.Controls.Add(Me.lblSuperBlkMinBid)
        Me.gbAuctionConfig.Location = New System.Drawing.Point(12, 242)
        Me.gbAuctionConfig.Name = "gbAuctionConfig"
        Me.gbAuctionConfig.Size = New System.Drawing.Size(408, 56)
        Me.gbAuctionConfig.TabIndex = 14
        Me.gbAuctionConfig.TabStop = False
        Me.gbAuctionConfig.Text = "Auction Configuration"
        '
        'txtSuperBlkMinBid
        '
        Me.txtSuperBlkMinBid.Location = New System.Drawing.Point(157, 22)
        Me.txtSuperBlkMinBid.Name = "txtSuperBlkMinBid"
        Me.txtSuperBlkMinBid.Size = New System.Drawing.Size(67, 20)
        Me.txtSuperBlkMinBid.TabIndex = 5
        '
        'lblSuperBlkMinBid
        '
        Me.lblSuperBlkMinBid.AutoSize = True
        Me.lblSuperBlkMinBid.Location = New System.Drawing.Point(21, 25)
        Me.lblSuperBlkMinBid.Name = "lblSuperBlkMinBid"
        Me.lblSuperBlkMinBid.Size = New System.Drawing.Size(130, 13)
        Me.lblSuperBlkMinBid.TabIndex = 4
        Me.lblSuperBlkMinBid.Text = "Super Block Minimum Bid:"
        '
        'gbFormControl
        '
        Me.gbFormControl.Controls.Add(Me.cbAddEditKiwanian)
        Me.gbFormControl.Controls.Add(Me.cbReports)
        Me.gbFormControl.Controls.Add(Me.cbPlaceBid)
        Me.gbFormControl.Controls.Add(Me.cbViewBid)
        Me.gbFormControl.Controls.Add(Me.cbAssignItemBlock)
        Me.gbFormControl.Controls.Add(Me.cbAddEditBlock)
        Me.gbFormControl.Controls.Add(Me.cbAddEditBidder)
        Me.gbFormControl.Controls.Add(Me.cbAddEditItem)
        Me.gbFormControl.Controls.Add(Me.cbAddEditDonor)
        Me.gbFormControl.Controls.Add(Me.cbAuctDirective)
        Me.gbFormControl.Location = New System.Drawing.Point(12, 304)
        Me.gbFormControl.Name = "gbFormControl"
        Me.gbFormControl.Size = New System.Drawing.Size(408, 138)
        Me.gbFormControl.TabIndex = 15
        Me.gbFormControl.TabStop = False
        Me.gbFormControl.Text = "Form Control"
        '
        'cbAddEditKiwanian
        '
        Me.cbAddEditKiwanian.AutoSize = True
        Me.cbAddEditKiwanian.Location = New System.Drawing.Point(157, 65)
        Me.cbAddEditKiwanian.Name = "cbAddEditKiwanian"
        Me.cbAddEditKiwanian.Size = New System.Drawing.Size(114, 17)
        Me.cbAddEditKiwanian.TabIndex = 9
        Me.cbAddEditKiwanian.Text = "Add/Edit Kiwanian"
        Me.cbAddEditKiwanian.UseVisualStyleBackColor = True
        '
        'cbReports
        '
        Me.cbReports.AutoSize = True
        Me.cbReports.Location = New System.Drawing.Point(157, 111)
        Me.cbReports.Name = "cbReports"
        Me.cbReports.Size = New System.Drawing.Size(63, 17)
        Me.cbReports.TabIndex = 8
        Me.cbReports.Text = "Reports"
        Me.cbReports.UseVisualStyleBackColor = True
        '
        'cbPlaceBid
        '
        Me.cbPlaceBid.AutoSize = True
        Me.cbPlaceBid.Location = New System.Drawing.Point(157, 88)
        Me.cbPlaceBid.Name = "cbPlaceBid"
        Me.cbPlaceBid.Size = New System.Drawing.Size(71, 17)
        Me.cbPlaceBid.TabIndex = 7
        Me.cbPlaceBid.Text = "Place Bid"
        Me.cbPlaceBid.UseVisualStyleBackColor = True
        '
        'cbViewBid
        '
        Me.cbViewBid.AutoSize = True
        Me.cbViewBid.Location = New System.Drawing.Point(157, 42)
        Me.cbViewBid.Name = "cbViewBid"
        Me.cbViewBid.Size = New System.Drawing.Size(122, 17)
        Me.cbViewBid.TabIndex = 6
        Me.cbViewBid.Text = "View Bidding History"
        Me.cbViewBid.UseVisualStyleBackColor = True
        '
        'cbAssignItemBlock
        '
        Me.cbAssignItemBlock.AutoSize = True
        Me.cbAssignItemBlock.Location = New System.Drawing.Point(157, 19)
        Me.cbAssignItemBlock.Name = "cbAssignItemBlock"
        Me.cbAssignItemBlock.Size = New System.Drawing.Size(122, 17)
        Me.cbAssignItemBlock.TabIndex = 5
        Me.cbAssignItemBlock.Text = "Assign Item to Block"
        Me.cbAssignItemBlock.UseVisualStyleBackColor = True
        '
        'cbAddEditBlock
        '
        Me.cbAddEditBlock.AutoSize = True
        Me.cbAddEditBlock.Location = New System.Drawing.Point(24, 111)
        Me.cbAddEditBlock.Name = "cbAddEditBlock"
        Me.cbAddEditBlock.Size = New System.Drawing.Size(98, 17)
        Me.cbAddEditBlock.TabIndex = 4
        Me.cbAddEditBlock.Text = "Add/Edit Block"
        Me.cbAddEditBlock.UseVisualStyleBackColor = True
        '
        'cbAddEditBidder
        '
        Me.cbAddEditBidder.AutoSize = True
        Me.cbAddEditBidder.Location = New System.Drawing.Point(23, 88)
        Me.cbAddEditBidder.Name = "cbAddEditBidder"
        Me.cbAddEditBidder.Size = New System.Drawing.Size(101, 17)
        Me.cbAddEditBidder.TabIndex = 3
        Me.cbAddEditBidder.Text = "Add/Edit Bidder"
        Me.cbAddEditBidder.UseVisualStyleBackColor = True
        '
        'cbAddEditItem
        '
        Me.cbAddEditItem.AutoSize = True
        Me.cbAddEditItem.Location = New System.Drawing.Point(23, 65)
        Me.cbAddEditItem.Name = "cbAddEditItem"
        Me.cbAddEditItem.Size = New System.Drawing.Size(91, 17)
        Me.cbAddEditItem.TabIndex = 2
        Me.cbAddEditItem.Text = "Add/EditI tem"
        Me.cbAddEditItem.UseVisualStyleBackColor = True
        '
        'cbAddEditDonor
        '
        Me.cbAddEditDonor.AutoSize = True
        Me.cbAddEditDonor.Location = New System.Drawing.Point(23, 42)
        Me.cbAddEditDonor.Name = "cbAddEditDonor"
        Me.cbAddEditDonor.Size = New System.Drawing.Size(100, 17)
        Me.cbAddEditDonor.TabIndex = 1
        Me.cbAddEditDonor.Text = "Add/Edit Donor"
        Me.cbAddEditDonor.UseVisualStyleBackColor = True
        '
        'cbAuctDirective
        '
        Me.cbAuctDirective.AutoSize = True
        Me.cbAuctDirective.Location = New System.Drawing.Point(24, 19)
        Me.cbAuctDirective.Name = "cbAuctDirective"
        Me.cbAuctDirective.Size = New System.Drawing.Size(122, 17)
        Me.cbAuctDirective.TabIndex = 0
        Me.cbAuctDirective.Text = "Auctioneer Directive"
        Me.cbAuctDirective.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 449)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 51)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CSV File Location"
        '
        'K_DBCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 549)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbFormControl)
        Me.Controls.Add(Me.gbAuctionConfig)
        Me.Controls.Add(Me.gbAppConfig)
        Me.Controls.Add(Me.gbDBConfig)
        Me.Controls.Add(Me.Close_btn)
        Me.Controls.Add(Me.Save_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "K_DBCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kiwanis Application Configuration"
        Me.gbDBConfig.ResumeLayout(False)
        Me.gbDBConfig.PerformLayout()
        Me.gbAppConfig.ResumeLayout(False)
        Me.gbAppConfig.PerformLayout()
        Me.gbAuctionConfig.ResumeLayout(False)
        Me.gbAuctionConfig.PerformLayout()
        Me.gbFormControl.ResumeLayout(False)
        Me.gbFormControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Host_lbl As System.Windows.Forms.Label
    Friend WithEvents Save_btn As System.Windows.Forms.Button
    Friend WithEvents Host_txt As System.Windows.Forms.TextBox
    Friend WithEvents Pass_lbl As System.Windows.Forms.Label
    Friend WithEvents User_lbl As System.Windows.Forms.Label
    Friend WithEvents Pass_txt As System.Windows.Forms.TextBox
    Friend WithEvents User_txt As System.Windows.Forms.TextBox
    Friend WithEvents Close_btn As System.Windows.Forms.Button
    Friend WithEvents Catalog_txt As System.Windows.Forms.TextBox
    Friend WithEvents Catalog_lbl As System.Windows.Forms.Label
    Friend WithEvents gbDBConfig As System.Windows.Forms.GroupBox
    Friend WithEvents gbAppConfig As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdminPass As System.Windows.Forms.TextBox
    Friend WithEvents lblAdminPass As System.Windows.Forms.Label
    Friend WithEvents txtAuctPass As System.Windows.Forms.TextBox
    Friend WithEvents lblAuctPass As System.Windows.Forms.Label
    Friend WithEvents gbAuctionConfig As System.Windows.Forms.GroupBox
    Friend WithEvents txtSuperBlkMinBid As System.Windows.Forms.TextBox
    Friend WithEvents lblSuperBlkMinBid As System.Windows.Forms.Label
    Friend WithEvents gbFormControl As System.Windows.Forms.GroupBox
    Friend WithEvents cbPlaceBid As System.Windows.Forms.CheckBox
    Friend WithEvents cbViewBid As System.Windows.Forms.CheckBox
    Friend WithEvents cbAssignItemBlock As System.Windows.Forms.CheckBox
    Friend WithEvents cbAddEditBlock As System.Windows.Forms.CheckBox
    Friend WithEvents cbAddEditBidder As System.Windows.Forms.CheckBox
    Friend WithEvents cbAddEditItem As System.Windows.Forms.CheckBox
    Friend WithEvents cbAddEditDonor As System.Windows.Forms.CheckBox
    Friend WithEvents cbAuctDirective As System.Windows.Forms.CheckBox
    Friend WithEvents cbReports As System.Windows.Forms.CheckBox
    Friend WithEvents cbAddEditKiwanian As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
