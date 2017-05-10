Imports System
Imports System.IO


Public Class K_DBCC
    Public Sub K_DBCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Read 
        Host_txt.Text = KiwanisConfig.GetConfigValue("cDBServer")
        Catalog_txt.Text = KiwanisConfig.GetConfigValue("cDBCatalog")
        User_txt.Text = KiwanisConfig.GetConfigValue("cDBUsername")
        Pass_txt.Text = KiwanisConfig.GetConfigValue("cDBPassword")
        txtAdminPass.Text = KiwanisConfig.GetConfigValue("cAAdminPass")
        txtAuctPass.Text = KiwanisConfig.GetConfigValue("cAAuctPass")
        txtSuperBlkMinBid.Text = KiwanisConfig.GetConfigValue("cSuperBlockMin")

        cbAuctDirective.Checked = KiwanisConfig.GetConfigValue("cAuctDirectiveEnabled")
        cbAddEditDonor.Checked = KiwanisConfig.GetConfigValue("cAddEditDonorEnable")
        cbAddEditItem.Checked = KiwanisConfig.GetConfigValue("cAddEditItemEnable")
        cbAddEditBidder.Checked = KiwanisConfig.GetConfigValue("cAddEditBidderEnable")
        cbAddEditBlock.Checked = KiwanisConfig.GetConfigValue("cAddEditBlockEnable")
        cbAssignItemBlock.Checked = KiwanisConfig.GetConfigValue("cAssignItemBlockEnable")
        cbViewBid.Checked = KiwanisConfig.GetConfigValue("cViewBidEnable")
        cbPlaceBid.Checked = KiwanisConfig.GetConfigValue("cPlaceBidEnable")
        cbAddEditKiwanian.Checked = KiwanisConfig.GetConfigValue("cAddEditKiwanianEnable")
        cbReports.Checked = KiwanisConfig.GetConfigValue("cReportsEnable")


    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_btn.Click
        'Save config values to KAapp.config
        KiwanisConfig.WriteConfigValue("cDBServer", Host_txt.Text)
        KiwanisConfig.WriteConfigValue("cDBCatalog", Catalog_txt.Text)
        KiwanisConfig.WriteConfigValue("cDBUsername", User_txt.Text)
        KiwanisConfig.WriteConfigValue("cDBPassword", Pass_txt.Text)
        KiwanisConfig.WriteConfigValue("cAAdminPass", txtAdminPass.Text)
        KiwanisConfig.WriteConfigValue("cAAuctPass", txtAuctPass.Text)
        KiwanisConfig.WriteConfigValue("cSuperBlockMin", txtSuperBlkMinBid.Text)

        If cbAuctDirective.Checked = True Then
            KiwanisConfig.WriteConfigValue("cAuctDirectiveEnabled", "True")
        Else
            KiwanisConfig.WriteConfigValue("cAuctDirectiveEnabled", "False")
        End If
        If cbAddEditDonor.Checked = True Then
            KiwanisConfig.WriteConfigValue("cAddEditDonorEnable", "True")
        Else
            KiwanisConfig.WriteConfigValue("cAddEditDonorEnable", "False")
        End If
        If cbAddEditItem.Checked = True Then
            KiwanisConfig.WriteConfigValue("cAddEditItemEnable", "True")
        Else
            KiwanisConfig.WriteConfigValue("cAddEditItemEnable", "False")
        End If
        If cbAddEditBidder.Checked = True Then
            KiwanisConfig.WriteConfigValue("cAddEditBidderEnable", "True")
        Else
            KiwanisConfig.WriteConfigValue("cAddEditBidderEnable", "False")
        End If
        If cbAddEditBlock.Checked = True Then
            KiwanisConfig.WriteConfigValue("cAddEditBlockEnable", "True")
        Else
            KiwanisConfig.WriteConfigValue("cAddEditBlockEnable", "False")
        End If
        If cbAssignItemBlock.Checked = True Then
            KiwanisConfig.WriteConfigValue("cAssignItemBlockEnable", "True")
        Else
            KiwanisConfig.WriteConfigValue("cAssignItemBlockEnable", "False")
        End If
        If cbViewBid.Checked = True Then
            KiwanisConfig.WriteConfigValue("cViewBidEnable", "True")
        Else
            KiwanisConfig.WriteConfigValue("cViewBidEnable", "False")
        End If
        If cbPlaceBid.Checked = True Then
            KiwanisConfig.WriteConfigValue("cPlaceBidEnable", "True")
        Else
            KiwanisConfig.WriteConfigValue("cPlaceBidEnable", "False")
        End If
        If cbAddEditKiwanian.Checked = True Then
            KiwanisConfig.WriteConfigValue("cAddEditKiwanianEnable", "True")
        Else
            KiwanisConfig.WriteConfigValue("cAddEditKiwanianEnable", "False")
        End If
        If cbReports.Checked = True Then
            KiwanisConfig.WriteConfigValue("cReportsEnable", "True")
        Else
            KiwanisConfig.WriteConfigValue("cReportsEnable", "False")
        End If

        '"Refresh" connection string, and admin and auctioneer passwords
        Main.connString = KiwanisConfig.LoadDatabaseConfig
        Main.adminPass = KiwanisConfig.GetConfigValue("cAAdminPass").ToUpper
        Main.auctPass = KiwanisConfig.GetConfigValue("cAAuctPass").ToUpper

        '"Refresh" buttons .Enabled status

        Main.btnPlaceBid.Enabled = KiwanisConfig.GetConfigValue("cPlaceBidEnable")

        'Return to Main
        Main.Enabled = True
        Me.Visible = False
    End Sub

    Private Sub Close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_btn.Click
        'Do nothing!
        Main.Enabled = True
        Me.Visible = False
    End Sub

End Class