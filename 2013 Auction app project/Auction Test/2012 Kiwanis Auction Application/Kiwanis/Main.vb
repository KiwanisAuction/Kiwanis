Imports System
Imports System.IO
Imports System.Text
'************************************************************************************
' This version with edits from Nick Meszaros
' All edits take place in function getConnectionString()
' Documented in OneNote on Nick's PC
' 2009-10-02 
'************************************************************************************
'************************************************************************************
' This version refactored by Steven R Walker
' 
' 
' 10/01/2010 - 3/4/2012
'************************************************************************************

Public Class Main

    'declare public variables
    Public dateLastYear As Date = "3/1/" & Year(Today) - 1 ' Need to fix this

    Public serverTime As Date
    Public connString As String = KiwanisConfig.LoadDatabaseConfig
    Public adminPass As String = KiwanisConfig.GetConfigValue("cAAdminPass").ToUpper
    Public auctPass As String = KiwanisConfig.GetConfigValue("cAAuctPass").ToUpper

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAuctioneer.Enabled = KiwanisConfig.GetConfigValue("cAuctDirectiveEnabled")
        Button1.Enabled = KiwanisConfig.GetConfigValue("cAddEditDonorEnable")
        Button2.Enabled = KiwanisConfig.GetConfigValue("cAddEditItemEnable")
        Button3.Enabled = KiwanisConfig.GetConfigValue("cAddEditBidderEnable")
        Button4.Enabled = KiwanisConfig.GetConfigValue("cAddEditBlockEnable")
        Button5.Enabled = KiwanisConfig.GetConfigValue("cAssignItemBlockEnable")
        Button6.Enabled = KiwanisConfig.GetConfigValue("cViewBidEnable")
        btnPlaceBid.Enabled = KiwanisConfig.GetConfigValue("cPlaceBidEnable")
        Report_btn.Enabled = KiwanisConfig.GetConfigValue("cReportsEnable")
    End Sub


    Private Sub btnAuctioneer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuctioneer.Click
        Dim strPass As String = InputBox("Password", "Login")
        Select Case strPass.ToUpper
            Case ""
            Case auctPass
                Auctioneer.Visible = True
                Me.Visible = False
            Case Else
                MessageBox.Show("Login Failed: Wrong Password", "Invalid Input")
        End Select
    End Sub

    'open donor
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strPass As String = InputBox("Password", "Login")
        Select Case strPass.ToUpper
            Case ""
            Case adminPass
                Donor.Visible = True
                Me.Visible = False
            Case Else
                MessageBox.Show("Login Failed: Wrong Password", "Invalid Input")
        End Select
    End Sub

    'open item
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strPass As String = InputBox("Password", "Login")
        Select Case strPass.ToUpper
            Case ""
            Case adminPass
                Item.Visible = True
                Me.Visible = False
            Case ""
            Case Else
                MessageBox.Show("Login Failed: Wrong Password", "Invalid Input")
        End Select
    End Sub

    'open bidder
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim strPass As String = InputBox("Password", "Login")
        Select Case strPass.ToUpper
            Case ""
            Case adminPass
                Bidder.Visible = True
                Me.Visible = False
            Case ""
            Case Else
                MessageBox.Show("Login Failed: Wrong Password", "Invalid Input")
        End Select
    End Sub

    'open block
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim strPass As String = InputBox("Password", "Login")
        Select Case strPass.ToUpper
            Case ""
            Case adminPass
                Block.Visible = True
                Me.Visible = False
            Case ""
            Case Else
                MessageBox.Show("Login Failed: Wrong Password", "Invalid Input")
        End Select
    End Sub

    'open assignItemToBlock
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim strPass As String = InputBox("Password", "Login")
        Select Case strPass.ToUpper
            Case ""
            Case adminPass
                AssignItemToBlock.Visible = True
                Me.Visible = False
            Case ""
            Case Else
                MessageBox.Show("Login Failed: Wrong Password", "Invalid Input")
        End Select
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim strPass As String = InputBox("Password", "Login")
        Select Case strPass.ToUpper
            Case ""
            Case "AUCTIONEER"
                BiddingHistory.Visible = True
                Me.Visible = False
            Case ""
            Case Else
                MessageBox.Show("Login Failed: Wrong Password", "Invalid Input")
        End Select
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim strPass As String = InputBox("Password", "Login")
        Select Case strPass.ToUpper
            Case ""
            Case adminPass
                KiwanisMem.Visible = True
                Me.Visible = False
            Case ""
            Case Else
                MessageBox.Show("Login Failed: Wrong Password", "Invalid Input")
        End Select
    End Sub

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        Dim strPass As String = InputBox("Password", "Login")
        Select Case strPass.ToUpper
            Case ""
            Case adminPass
                K_DBCC.Visible = True
                Me.Enabled = False
            Case ""
            Case Else
                MessageBox.Show("Login Failed: Wrong Password", "Invalid Input")
        End Select
    End Sub

    Private Sub Report_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report_btn.Click
        Reports.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnPlaceBid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaceBid.Click
        PlaceBid.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'get server time and calculate the different
    Public Function getServerTime()

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        Dim dtServerDateTime As New DateTime

        SQLCmd.CommandText = "SELECT getdate()"

        SQLConn.ConnectionString = connString

        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            dtServerDateTime = SQLCmd.ExecuteScalar
            SQLConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try

        Return dtServerDateTime
    End Function

End Class