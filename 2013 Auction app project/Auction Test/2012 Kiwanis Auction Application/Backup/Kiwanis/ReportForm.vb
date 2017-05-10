Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.VSDesigner
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine

Public Class ReportForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RptName_lbl.Text = ""
    End Sub

    Private Sub loadReport(ByVal reportNum)

        Dim DB_Server As String = KDBConnect.DataSource
        Dim DB_Database As String = KDBConnect.DataBase
        Dim DB_User As String = KDBConnect.User
        Dim DB_Pass As String = KDBConnect.Pass

        'Handles selection of reports from form menu.
        Dim rpt As Object = ""
        Select Case reportNum
            Case 1
                rpt = New Prod_rptTop3Bids
                'Dim ParamDate As DateTime = ("2010-03-06")
                'rpt.ParameterFields.Item(0).DefaultValues.AddValue(ParamDate) 'OPTIONAL to allow for selection of dates.
                'rpt.ParameterFields.Item(0).CurrentValues.AddValue("dbo.ufnNextAuctionDate()")
            Case 2
                rpt = New Prod_rptBlock_Review
            Case 3
                rpt = New Prod_rptAuction_Totals_By_Block
            Case 4
                rpt = New Prod_rptBidder_List
            Case 5
                rpt = New Prod_rptDonor_List
            Case 6
                rpt = New Prod_rptItems_Donated
            Case 7
                rpt = New Prod_rptTV_Descriptions
            Case 8
                rpt = New Prod_rptBidder_Receipts
            Case 9
                rpt = New Prod_rptAuction_Totals_By_Donor
            Case 10
                rpt = New Prod_rptTo_Be_Picked_Up
        End Select

        'Opens connection, loads form into viewer and processes into report format, closes connection
        Try

            'PRODUCTION DATABASE - Auto logs into database with default date selection.
            'rpt.DataSourceConnections.Item(0).SetConnection("kiwanisauction01.db.6809554.hostedresource.com", "kiwanisauction01", False)
            'rpt.DataSourceConnections.Item(0).SetLogon("kiwanisauction01", "Auction2011")

            'DEVELOPMENT DATABASE - Auto logs into database with default date selection.
            rpt.DataSourceConnections.Item(0).SetConnection("" & DB_Server & "", "" & DB_Database & "", False)
            rpt.DataSourceConnections.Item(0).SetLogon("" & DB_User & "", "" & DB_Pass & "")

            'Populate viewer with report.
            CrystalReportViewer.ReportSource = rpt
            CrystalReportViewer.Zoom(1)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            rpt = ""
        End Try
    End Sub

    Private Sub Exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_btn.Click
        Main.Visible = True
        Me.Close()
    End Sub

    Private Sub Top3Bid_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top3Bid_Button.Click
        loadReport(1)
        RptName_lbl.Text = "Top 3 Bids Report"
    End Sub

    Private Sub BlockReview_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockReview_Button.Click
        loadReport(2)
        RptName_lbl.Text = "Block Review Report"
    End Sub

    Private Sub AuctionTotalsByBlock_Button_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuctionTotal_Button.Click
        loadReport(3)
        RptName_lbl.Text = "Auction Totals by Block Report"
    End Sub

    Private Sub BidderList_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BidderList_Button.Click
        loadReport(4)
        RptName_lbl.Text = "Bidder List Report"
    End Sub

    Private Sub DonorList_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonorList_Button.Click
        loadReport(5)
        RptName_lbl.Text = "Donor List Report"
    End Sub

    Private Sub ItemsDonated_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsDonated_Button.Click
        loadReport(6)
        RptName_lbl.Text = "Items Donated Report"
    End Sub

    Private Sub TVDescription_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TVDescription_Button.Click
        loadReport(7)
        RptName_lbl.Text = "TV Description Report"
    End Sub

    Private Sub BidderReceipt_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BidderReceipt_Button.Click
        loadReport(8)
        RptName_lbl.Text = "Bidder Receipts"
    End Sub

    Private Sub ActionTotalsByDonor_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionTotalsByDonor_Button.Click
        loadReport(9)
        RptName_lbl.Text = "Auction Totals by Donor Report"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemPickUp.Click
        loadReport(10)
        RptName_lbl.Text = "Items To Be Picked Up Report"
    End Sub
End Class
