<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ItemPickUp = New System.Windows.Forms.Button
        Me.ActionTotalsByDonor_Button = New System.Windows.Forms.Button
        Me.BidderReceipt_Button = New System.Windows.Forms.Button
        Me.TVDescription_Button = New System.Windows.Forms.Button
        Me.BlockReview_Button = New System.Windows.Forms.Button
        Me.AuctionTotal_Button = New System.Windows.Forms.Button
        Me.BidderList_Button = New System.Windows.Forms.Button
        Me.DonorList_Button = New System.Windows.Forms.Button
        Me.ItemsDonated_Button = New System.Windows.Forms.Button
        Me.Exit_btn = New System.Windows.Forms.Button
        Me.Top3Bid_Button = New System.Windows.Forms.Button
        Me.ReportPanel = New System.Windows.Forms.Panel
        Me.RptName_lbl = New System.Windows.Forms.Label
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1.SuspendLayout()
        Me.ReportPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ItemPickUp)
        Me.Panel1.Controls.Add(Me.ActionTotalsByDonor_Button)
        Me.Panel1.Controls.Add(Me.BidderReceipt_Button)
        Me.Panel1.Controls.Add(Me.TVDescription_Button)
        Me.Panel1.Controls.Add(Me.BlockReview_Button)
        Me.Panel1.Controls.Add(Me.AuctionTotal_Button)
        Me.Panel1.Controls.Add(Me.BidderList_Button)
        Me.Panel1.Controls.Add(Me.DonorList_Button)
        Me.Panel1.Controls.Add(Me.ItemsDonated_Button)
        Me.Panel1.Controls.Add(Me.Exit_btn)
        Me.Panel1.Controls.Add(Me.Top3Bid_Button)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(183, 600)
        Me.Panel1.TabIndex = 0
        '
        'ItemPickUp
        '
        Me.ItemPickUp.Location = New System.Drawing.Point(8, 405)
        Me.ItemPickUp.Name = "ItemPickUp"
        Me.ItemPickUp.Size = New System.Drawing.Size(165, 41)
        Me.ItemPickUp.TabIndex = 10
        Me.ItemPickUp.Text = "Items To Be Picked Up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BA-13"
        Me.ItemPickUp.UseVisualStyleBackColor = True
        '
        'ActionTotalsByDonor_Button
        '
        Me.ActionTotalsByDonor_Button.Location = New System.Drawing.Point(8, 226)
        Me.ActionTotalsByDonor_Button.Name = "ActionTotalsByDonor_Button"
        Me.ActionTotalsByDonor_Button.Size = New System.Drawing.Size(165, 35)
        Me.ActionTotalsByDonor_Button.TabIndex = 9
        Me.ActionTotalsByDonor_Button.Text = "Auction Totals by Donor Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AA-07"
        Me.ActionTotalsByDonor_Button.UseVisualStyleBackColor = True
        '
        'BidderReceipt_Button
        '
        Me.BidderReceipt_Button.Location = New System.Drawing.Point(8, 140)
        Me.BidderReceipt_Button.Name = "BidderReceipt_Button"
        Me.BidderReceipt_Button.Size = New System.Drawing.Size(165, 36)
        Me.BidderReceipt_Button.TabIndex = 8
        Me.BidderReceipt_Button.Text = "Bidder Receipts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AA-05"
        Me.BidderReceipt_Button.UseVisualStyleBackColor = True
        '
        'TVDescription_Button
        '
        Me.TVDescription_Button.Location = New System.Drawing.Point(8, 8)
        Me.TVDescription_Button.Name = "TVDescription_Button"
        Me.TVDescription_Button.Size = New System.Drawing.Size(165, 38)
        Me.TVDescription_Button.TabIndex = 7
        Me.TVDescription_Button.Text = "TV Description Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BA-??"
        Me.TVDescription_Button.UseVisualStyleBackColor = True
        '
        'BlockReview_Button
        '
        Me.BlockReview_Button.Location = New System.Drawing.Point(8, 358)
        Me.BlockReview_Button.Name = "BlockReview_Button"
        Me.BlockReview_Button.Size = New System.Drawing.Size(165, 41)
        Me.BlockReview_Button.TabIndex = 6
        Me.BlockReview_Button.Text = "Block Review Report"
        Me.BlockReview_Button.UseVisualStyleBackColor = True
        '
        'AuctionTotal_Button
        '
        Me.AuctionTotal_Button.Location = New System.Drawing.Point(8, 267)
        Me.AuctionTotal_Button.Name = "AuctionTotal_Button"
        Me.AuctionTotal_Button.Size = New System.Drawing.Size(165, 41)
        Me.AuctionTotal_Button.TabIndex = 5
        Me.AuctionTotal_Button.Text = "Auction Totals by Block Report"
        Me.AuctionTotal_Button.UseVisualStyleBackColor = True
        '
        'BidderList_Button
        '
        Me.BidderList_Button.Location = New System.Drawing.Point(8, 183)
        Me.BidderList_Button.Name = "BidderList_Button"
        Me.BidderList_Button.Size = New System.Drawing.Size(165, 37)
        Me.BidderList_Button.TabIndex = 4
        Me.BidderList_Button.Text = "Bidder List Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DA-04 / AA-06"
        Me.BidderList_Button.UseVisualStyleBackColor = True
        '
        'DonorList_Button
        '
        Me.DonorList_Button.Location = New System.Drawing.Point(8, 52)
        Me.DonorList_Button.Name = "DonorList_Button"
        Me.DonorList_Button.Size = New System.Drawing.Size(165, 36)
        Me.DonorList_Button.TabIndex = 3
        Me.DonorList_Button.Text = "Donor List Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BA-02"
        Me.DonorList_Button.UseVisualStyleBackColor = True
        '
        'ItemsDonated_Button
        '
        Me.ItemsDonated_Button.Location = New System.Drawing.Point(8, 314)
        Me.ItemsDonated_Button.Name = "ItemsDonated_Button"
        Me.ItemsDonated_Button.Size = New System.Drawing.Size(165, 38)
        Me.ItemsDonated_Button.TabIndex = 2
        Me.ItemsDonated_Button.Text = "Items Donated Report"
        Me.ItemsDonated_Button.UseVisualStyleBackColor = True
        '
        'Exit_btn
        '
        Me.Exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.Location = New System.Drawing.Point(8, 557)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(165, 33)
        Me.Exit_btn.TabIndex = 1
        Me.Exit_btn.Text = "Back to Main"
        Me.Exit_btn.UseVisualStyleBackColor = True
        '
        'Top3Bid_Button
        '
        Me.Top3Bid_Button.Location = New System.Drawing.Point(8, 94)
        Me.Top3Bid_Button.Name = "Top3Bid_Button"
        Me.Top3Bid_Button.Size = New System.Drawing.Size(165, 39)
        Me.Top3Bid_Button.TabIndex = 0
        Me.Top3Bid_Button.Text = "Top 3 Bids Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DA-03"
        Me.Top3Bid_Button.UseVisualStyleBackColor = True
        '
        'ReportPanel
        '
        Me.ReportPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportPanel.Controls.Add(Me.RptName_lbl)
        Me.ReportPanel.Controls.Add(Me.CrystalReportViewer)
        Me.ReportPanel.Location = New System.Drawing.Point(202, 13)
        Me.ReportPanel.Name = "ReportPanel"
        Me.ReportPanel.Size = New System.Drawing.Size(800, 600)
        Me.ReportPanel.TabIndex = 1
        '
        'RptName_lbl
        '
        Me.RptName_lbl.AutoSize = True
        Me.RptName_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RptName_lbl.Location = New System.Drawing.Point(4, 4)
        Me.RptName_lbl.Name = "RptName_lbl"
        Me.RptName_lbl.Size = New System.Drawing.Size(115, 20)
        Me.RptName_lbl.TabIndex = 1
        Me.RptName_lbl.Text = "Report Name"
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, 30)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.SelectionFormula = ""
        Me.CrystalReportViewer.Size = New System.Drawing.Size(798, 568)
        Me.CrystalReportViewer.TabIndex = 0
        Me.CrystalReportViewer.ViewTimeSelectionFormula = ""
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1018, 629)
        Me.Controls.Add(Me.ReportPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Auction Reports "
        Me.Panel1.ResumeLayout(False)
        Me.ReportPanel.ResumeLayout(False)
        Me.ReportPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReportPanel As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Exit_btn As System.Windows.Forms.Button
    Friend WithEvents Top3Bid_Button As System.Windows.Forms.Button
    Friend WithEvents BlockReview_Button As System.Windows.Forms.Button
    Friend WithEvents AuctionTotal_Button As System.Windows.Forms.Button
    Friend WithEvents BidderList_Button As System.Windows.Forms.Button
    Friend WithEvents DonorList_Button As System.Windows.Forms.Button
    Friend WithEvents ItemsDonated_Button As System.Windows.Forms.Button
    Friend WithEvents RptName_lbl As System.Windows.Forms.Label
    Friend WithEvents BidderReceipt_Button As System.Windows.Forms.Button
    Friend WithEvents TVDescription_Button As System.Windows.Forms.Button
    Friend WithEvents ActionTotalsByDonor_Button As System.Windows.Forms.Button
    Friend WithEvents ItemPickUp As System.Windows.Forms.Button

End Class
