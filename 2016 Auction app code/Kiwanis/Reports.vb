Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.VSDesigner
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine

Public Class Reports

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RptName_lbl.Text = ""
        pn_CSVGeneration.Visible = False
    End Sub

    Private Sub loadReport(ByVal rpt As System.Object)
        pn_CSVGeneration.Visible = False
        CrystalReportViewer.Visible = True
        'Opens connection, loads form into viewer and processes into report format, closes connection
        Try
            rpt.SetDatabaseLogon(KiwanisConfig.GetConfigValue("cDBUsername"), KiwanisConfig.GetConfigValue("cDBPassword"))
            CrystalReportViewer.ReportSource = rpt
            CrystalReportViewer.Zoom(1)
            CrystalReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            rpt = ""
        End Try
    End Sub

    Private Sub Exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_btn.Click
        Me.Hide()
        Main.Visible = True
        Me.Close()
    End Sub

    Private Sub ThisFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub Top3Bid_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top3Bid_Button.Click
        loadReport(New Prod_rptTop3Bids)
        RptName_lbl.Text = "Top 3 Bids Report"
    End Sub

    Private Sub BlockReview_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockReview_Button.Click
        loadReport(New Prod_rptBlock_Review)
        RptName_lbl.Text = "Block Review Report"
    End Sub

    Private Sub AuctionTotalsByBlock_Button_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuctionTotal_Button.Click
        loadReport(New Prod_rptAuction_Totals_By_Block)
        RptName_lbl.Text = "Auction Totals by Block Report"
    End Sub

    Private Sub BidderList_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BidderList_Button.Click
        loadReport(New Prod_rptBidder_List)
        RptName_lbl.Text = "Bidder List Report"
    End Sub

    Private Sub DonorList_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonorList_Button.Click
        loadReport(New Prod_rptDonor_List)
        RptName_lbl.Text = "Donor List Report"
    End Sub

    Private Sub ItemsDonated_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsDonated_Button.Click
        loadReport(New Prod_rptItems_Donated)
        RptName_lbl.Text = "Items Donated Report"
    End Sub

    Private Sub TVDescription_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TVDescription_Button.Click
        loadReport(New Prod_rptTV_Descriptions)
        RptName_lbl.Text = "TV Description Report"
    End Sub

    Private Sub BidderReceipt_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BidderReceipt_Button.Click
        loadReport(New Prod_rptBidder_Receipts)
        RptName_lbl.Text = "Bidder Receipts"
    End Sub

    Private Sub ActionTotalsByDonor_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionTotalsByDonor_Button.Click
        loadReport(New Prod_rptAuction_Totals_By_Donor)
        RptName_lbl.Text = "Auction Totals by Donor Report"
    End Sub

    Private Sub ItemPickUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemPickUp.Click
        loadReport(New Prod_rptTo_Be_Picked_Up)
        RptName_lbl.Text = "Items To Be Picked Up Report"
    End Sub

    Private Sub btn_MemberSolicitation_Click(sender As System.Object, e As System.EventArgs) Handles btn_MemberSolicitation.Click
        loadReport(New Pro_rptMemberSolicitation)
        RptName_lbl.Text = "Member Solicitation Worksheet"
    End Sub

    Private Sub btn_CSVGeneration_Click(sender As System.Object, e As System.EventArgs) Handles btn_CSVGeneration.Click
        CrystalReportViewer.Visible = False
        pn_CSVGeneration.Visible = True

    End Sub

    Private Sub btn_NewspaperCSV_Click(sender As System.Object, e As System.EventArgs) Handles btn_NewspaperCSV.Click
        RptName_lbl.Text = "Generating Newspaper for a CSV file"
        Dim comment = New String() {"#The items are not sorted in a correct block order", "#It needs to be ordered after it is opened in Excel"}
        Dim header = New String() {"uspNewspaper", "ItemDateDonated", "ItemRetailVal", "ItemBlockPos", "ItemDesc", "BlockName", "DonorName"}
        Dim csvFile As CSVFile = New CSVFile()
        csvFile.writeToFile(RptName_lbl, header, comment)

        'Dim dataList As ArrayList = New ArrayList()
        'Dim csvFile As CSVFile = New CSVFile()
        'Dim databaseTraffic = New DatabaseTraffic()
        ''Create file
        ''If file is created successful
        ''access database and get data
        'If databaseTraffic.getDataFromDatabase(dataList, header, RptName_lbl) And csvFile.createFile Then
        '    'open file
        '    'if open file is success, write data to file
        '    csvFile.writeToFile(comment, dataList, RptName_lbl)
        'End If
    End Sub

    Private Sub btn_DonationHistoryByDonorsCSV_Click(sender As System.Object, e As System.EventArgs) Handles btn_DonationHistoryByDonorsCSV.Click
        RptName_lbl.Text = "Generating DonationHistoryByDonors for a CSV file"
        Dim comment = New String() {"@Donation History By Donors", "@Order by DonorID, ItemDateDonated, ItemID"}
        Dim header = New String() {"uspDonationHistoryByDonors", "DonorID", "DonorName", "DonorAddr1", "DonorAddr2", "DonorCity", "DonorState", "DonorZip", "DonorContactName", "DonorPhone", "DonorEmail", "KiwSolicitorID", "ItemDateDonated", "ItemID", "ItemDesc", "ItemRetailVal", "ItemHighBid"}
        Dim csvFile As CSVFile = New CSVFile()
        csvFile.writeToFile(RptName_lbl, header, comment)
    End Sub

    Private Sub btn_DonorList_Click(sender As System.Object, e As System.EventArgs) Handles btn_DonorList.Click
        RptName_lbl.Text = "Generating DonorList for a CSV file"
        Dim comment = New String() {"@Donor List", "@Order by DonorName"}
        Dim header = New String() {"uspDonorList", "DonorID", "DonorName", "DonorAddr1", "DonorAddr2", "DonorCity", "DonorState", "DonorZip"}
        Dim csvFile As CSVFile = New CSVFile()
        csvFile.writeToFile(RptName_lbl, header, comment)
    End Sub

    Private Sub enableCSVButton(newspaper As Boolean, donationHistory As Boolean)
        btn_NewspaperCSV.Enabled = newspaper
        btn_DonationHistoryByDonorsCSV.Enabled = donationHistory
    End Sub

    
    
End Class
