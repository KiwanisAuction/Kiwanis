<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_MemberSolicitation = New System.Windows.Forms.Button()
        Me.btn_CSVGeneration = New System.Windows.Forms.Button()
        Me.ItemPickUp = New System.Windows.Forms.Button()
        Me.ActionTotalsByDonor_Button = New System.Windows.Forms.Button()
        Me.BidderReceipt_Button = New System.Windows.Forms.Button()
        Me.TVDescription_Button = New System.Windows.Forms.Button()
        Me.BlockReview_Button = New System.Windows.Forms.Button()
        Me.AuctionTotal_Button = New System.Windows.Forms.Button()
        Me.BidderList_Button = New System.Windows.Forms.Button()
        Me.DonorList_Button = New System.Windows.Forms.Button()
        Me.ItemsDonated_Button = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.Top3Bid_Button = New System.Windows.Forms.Button()
        Me.ReportPanel = New System.Windows.Forms.Panel()
        Me.pn_CSVGeneration = New System.Windows.Forms.Panel()
        Me.btn_DonorList = New System.Windows.Forms.Button()
        Me.btn_DonationHistoryByDonorsCSV = New System.Windows.Forms.Button()
        Me.btn_NewspaperCSV = New System.Windows.Forms.Button()
        Me.RptName_lbl = New System.Windows.Forms.Label()
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.ReportPanel.SuspendLayout()
        Me.pn_CSVGeneration.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_MemberSolicitation)
        Me.Panel1.Controls.Add(Me.btn_CSVGeneration)
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
        'btn_MemberSolicitation
        '
        Me.btn_MemberSolicitation.Location = New System.Drawing.Point(8, 452)
        Me.btn_MemberSolicitation.Name = "btn_MemberSolicitation"
        Me.btn_MemberSolicitation.Size = New System.Drawing.Size(165, 41)
        Me.btn_MemberSolicitation.TabIndex = 12
        Me.btn_MemberSolicitation.Text = "Member Solicitation   Worksheet"
        Me.btn_MemberSolicitation.UseVisualStyleBackColor = True
        '
        'btn_CSVGeneration
        '
        Me.btn_CSVGeneration.Location = New System.Drawing.Point(8, 499)
        Me.btn_CSVGeneration.Name = "btn_CSVGeneration"
        Me.btn_CSVGeneration.Size = New System.Drawing.Size(165, 41)
        Me.btn_CSVGeneration.TabIndex = 11
        Me.btn_CSVGeneration.Text = "Generate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ".CSV File"
        Me.btn_CSVGeneration.UseVisualStyleBackColor = True
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
        Me.ReportPanel.Controls.Add(Me.pn_CSVGeneration)
        Me.ReportPanel.Controls.Add(Me.RptName_lbl)
        Me.ReportPanel.Controls.Add(Me.CrystalReportViewer)
        Me.ReportPanel.Location = New System.Drawing.Point(202, 13)
        Me.ReportPanel.Name = "ReportPanel"
        Me.ReportPanel.Size = New System.Drawing.Size(800, 600)
        Me.ReportPanel.TabIndex = 1
        '
        'pn_CSVGeneration
        '
        Me.pn_CSVGeneration.Controls.Add(Me.btn_DonorList)
        Me.pn_CSVGeneration.Controls.Add(Me.btn_DonationHistoryByDonorsCSV)
        Me.pn_CSVGeneration.Controls.Add(Me.btn_NewspaperCSV)
        Me.pn_CSVGeneration.Location = New System.Drawing.Point(4, 30)
        Me.pn_CSVGeneration.Name = "pn_CSVGeneration"
        Me.pn_CSVGeneration.Size = New System.Drawing.Size(594, 100)
        Me.pn_CSVGeneration.TabIndex = 2
        '
        'btn_DonorList
        '
        Me.btn_DonorList.Location = New System.Drawing.Point(300, 4)
        Me.btn_DonorList.Name = "btn_DonorList"
        Me.btn_DonorList.Size = New System.Drawing.Size(124, 44)
        Me.btn_DonorList.TabIndex = 2
        Me.btn_DonorList.Text = "Donor List"
        Me.btn_DonorList.UseVisualStyleBackColor = True
        '
        'btn_DonationHistoryByDonorsCSV
        '
        Me.btn_DonationHistoryByDonorsCSV.Location = New System.Drawing.Point(152, 4)
        Me.btn_DonationHistoryByDonorsCSV.Name = "btn_DonationHistoryByDonorsCSV"
        Me.btn_DonationHistoryByDonorsCSV.Size = New System.Drawing.Size(124, 44)
        Me.btn_DonationHistoryByDonorsCSV.TabIndex = 1
        Me.btn_DonationHistoryByDonorsCSV.Text = "Donation History By Donors"
        Me.btn_DonationHistoryByDonorsCSV.UseVisualStyleBackColor = True
        '
        'btn_NewspaperCSV
        '
        Me.btn_NewspaperCSV.Location = New System.Drawing.Point(4, 4)
        Me.btn_NewspaperCSV.Name = "btn_NewspaperCSV"
        Me.btn_NewspaperCSV.Size = New System.Drawing.Size(124, 44)
        Me.btn_NewspaperCSV.TabIndex = 0
        Me.btn_NewspaperCSV.Text = "Newspaper CSV"
        Me.btn_NewspaperCSV.UseVisualStyleBackColor = True
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
        Me.CrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, 30)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.SelectionFormula = ""
        Me.CrystalReportViewer.Size = New System.Drawing.Size(798, 568)
        Me.CrystalReportViewer.TabIndex = 0
        Me.CrystalReportViewer.ViewTimeSelectionFormula = ""
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1018, 629)
        Me.Controls.Add(Me.ReportPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reports"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Auction Reports "
        Me.Panel1.ResumeLayout(False)
        Me.ReportPanel.ResumeLayout(False)
        Me.ReportPanel.PerformLayout()
        Me.pn_CSVGeneration.ResumeLayout(False)
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
    Friend WithEvents btn_CSVGeneration As System.Windows.Forms.Button
    Friend WithEvents btn_MemberSolicitation As System.Windows.Forms.Button
    Friend WithEvents pn_CSVGeneration As System.Windows.Forms.Panel
    Friend WithEvents btn_NewspaperCSV As System.Windows.Forms.Button
    Friend WithEvents btn_DonationHistoryByDonorsCSV As System.Windows.Forms.Button
    Friend WithEvents btn_DonorList As System.Windows.Forms.Button

End Class
