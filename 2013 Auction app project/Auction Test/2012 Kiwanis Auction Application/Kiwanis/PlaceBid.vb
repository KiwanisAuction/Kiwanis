Imports System.Text.RegularExpressions
Imports System
Imports System.Data.SqlClient

Public Class PlaceBid
    Public strBlock, strPos As String
    Public strEndTime, strDelayEndTime As Date
    Public intDuration, bidPosition As Integer
    Public minBid, currBid As Integer
    Public blnEnd As Boolean = False

    Public bidderPhone2 As String
    Public BidderPhone2Chk As String

    Public PhoneIsNum_sw As Integer = 0

    Public DBConnectionString As String = KiwanisConfig.LoadDatabaseConfig

    Private Sub PlaceBid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NotActive_lbl.Text = ""
        lblCurrentBlock.Text = ""
        lblTimeRemain.Text = ""

        BidderAreaPhone_txt.Text = ""
        BidderPrefixPhone_txt.Text = ""
        BidderLinePhone_txt.Text = ""
    End Sub

    Private Sub txtBidderID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBidderID.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            checkId()
        End If
    End Sub

    Private Sub checkId()
        Dim ChkBidID As Integer = txtBidderID.Text

        ' Database connection and query globals
        Dim SQLConn As New SqlConnection() 'The SQL 
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspSelectBidderConfirm"

        SQLCmd.Parameters.AddWithValue("@bidderid", txtBidderID.Text)

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Try

            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader

            If SQLRead.HasRows = True Then
                While SQLRead.Read
                    lblBidderLName.Text = SQLRead("BidderFName").ToString & " " & SQLRead("BidderLName").ToString
                    Dim BidderPhone As String = SQLRead("BidderPhone").ToString
                    If BidderPhone <> "" Then
                        Dim PhoneArea As String = BidderPhone.Substring(0, 3)
                        Dim PhonePrefix As String = BidderPhone.Substring(3, 3)
                        Dim PhoneLine As String = BidderPhone.Substring(6, 4)
                        PhoneVer_lbl.Text = "(" & PhoneArea & ")" & PhonePrefix & "-" & PhoneLine
                    End If
                    Dim BidderPhone2 As String = SQLRead("BidderPhone2").ToString
                    If BidderPhone2 <> "" Then
                        BidderPhone2Chk = BidderPhone2
                        Dim PhoneArea2 As String = BidderPhone2.Substring(0, 3)
                        Dim PhonePrefix2 As String = BidderPhone2.Substring(3, 3)
                        Dim PhoneLine2 As String = BidderPhone2.Substring(6, 4)
                        BidderAreaPhone_txt.Text = PhoneArea2
                        BidderPrefixPhone_txt.Text = PhonePrefix2
                        BidderLinePhone_txt.Text = PhoneLine2
                    Else
                        BidderAreaPhone_txt.Text = "413"
                        BidderPrefixPhone_txt.Focus()
                        lblMessageBox.Text = "Bidder requires and alternate phone number in order to bid."
                    End If
                    If SQLRead("BidderActive") = 0 Then
                        NotActive_lbl.Text = "NOT ACTIVE"
                        lblMessageBox.Text = "The bidder is not an active participant and is not allowed to bid."
                    Else
                        NotActive_lbl.Text = ""
                    End If
                End While
                SQLConn.Close()
                'Enable buttons for active blocks
                enableBtnBlocks()
            Else
                lblMessageBox.Text = "Invalid Input:: No record of provided BidderID " & txtBidderID.Text
                txtBidderID.Clear()
                SQLConn.Close()
            End If

        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue:: Unable to access the database"
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
            ChkBidID = Nothing
        End Try
    End Sub

    Private Sub enableBtnBlocks()

        ' Database connection and query globals
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        btnRegBlock.Enabled = False
        btnBigBlock.Enabled = False
        btnSupBlock.Enabled = False

        If NotActive_lbl.Text = "NOT ACTIVE" Then
            txtBidderID.Enabled = False
            lblMessageBox.Text = "Record shown Bidder -" & txtBidderID.Text & "- INACTIVE. Please contact the Administrator to resolve any problem."
            btnCheck.Enabled = False
            btnSignOff.Enabled = True
            btnRefresh.Enabled = True
        Else
            btnCheck.Enabled = False
            txtBidderID.Enabled = False
            btnSignOff.Enabled = True
            btnRefresh.Enabled = True
            clearMessageBox()

            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = "SELECT DISTINCT(Blocks.BlockType), Blocks.BlockSchedStartTime, Blocks.BlockSchedDuration, Items.ItemBlockID FROM Items, Blocks WHERE Items.ItemBlockID = Blocks.BlockID AND Items.ItemAuctionStatus = '2'"

            SQLConn.ConnectionString = DBConnectionString
            SQLCmd.Connection = SQLConn

            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader

            If SQLRead.HasRows = True Then
                While SQLRead.Read
                    Dim strStartTime As Date = SQLRead("BlockSchedStartTime")
                    Dim intDuration As Integer
                    If Not IsDBNull(SQLRead("BlockSchedDuration")) Then
                        intDuration = SQLRead("BlockSchedDuration")
                    Else : intDuration = 10
                    End If
                    '
                    Dim strEndTimeEB As Date = DateAdd(DateInterval.Minute, intDuration, strStartTime)
                    '
                    If strEndTimeEB > Main.getServerTime Then
                        If SQLRead("BlockType").ToString.Contains("RR") = True Then
                            btnRegBlock.Enabled = True
                        ElseIf SQLRead("BlockType").ToString.Contains("BB") = True Then
                            btnBigBlock.Enabled = True
                        ElseIf SQLRead("BlockType").ToString.Contains("SU") = True Then
                            btnSupBlock.Enabled = True
                        End If
                    End If
                End While
            End If
            SQLConn.Close()
            'if there's no active block... display message
            If btnRegBlock.Enabled = False And btnBigBlock.Enabled = False And btnSupBlock.Enabled = False Then
                lblMessageBox.Text = ("There are no active blocks currently available.") 'Changed from "No current active block" 
            End If
        End If
        lblCurrentBlock.Text = ""
        lblTimeRemain.Text = ""
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        checkId()
        BidderPrefixPhone_txt.Focus()
    End Sub

    Private Sub clearMessageBox()
        lblMessageBox.Text = ""
    End Sub

    Private Sub btnRegBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegBlock.Click
        blnEnd = False
        strBlock = "RR"
        'load and display active Regular block items
        enableBtnBlocks()
        timeRemain.Stop()
        If btnRegBlock.Enabled = True Then
            loadActiveBlock(strBlock)
        Else : clearDisplay()
        End If
        resetBid()
    End Sub

    Private Sub btnBigBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBigBlock.Click
        blnEnd = False
        strBlock = "BB"
        'load and display active Big block items
        enableBtnBlocks()
        timeRemain.Stop()
        If btnBigBlock.Enabled = True Then
            loadActiveBlock(strBlock)
        Else : clearDisplay()
        End If
        resetBid()
    End Sub

    Private Sub btnSpeBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupBlock.Click
        blnEnd = False
        strBlock = "SU"

        'load and display active Big block items
        enableBtnBlocks()
        timeRemain.Stop()
        If btnSupBlock.Enabled = True Then
            loadActiveBlock(strBlock)
        Else : clearDisplay()
        End If
        resetBid()
    End Sub

    Private Sub loadActiveBlock(ByVal strBlockType As String)
        clearDisplay()

        Dim SQLConnLAB As New SqlConnection() 'The SQL Connection for loadActiveBlock
        Dim SQLCmdLAB As New SqlCommand() 'The SQL Command for loadActiveBlock
        Dim SQLReadLAB As SqlDataReader 'The Local Data Store for loadActiveBlock

        SQLCmdLAB.CommandType = CommandType.StoredProcedure

        'Main.cmd.CommandType = System.Data.CommandType.Text
        If blnEnd = False Then

            SQLCmdLAB.CommandText = "uspSelectActiveBlocks"

        ElseIf blnEnd = True Then

            SQLCmdLAB.CommandText = "uspSelectNOTActiveBlocks"
            blnEnd = False

        End If

        SQLCmdLAB.Parameters.AddWithValue("@blocktype", strBlockType)

        SQLConnLAB.ConnectionString = DBConnectionString
        SQLCmdLAB.Connection = SQLConnLAB

        Dim arActiveBlock(11, 6) As String
        Try
            SQLConnLAB.Open()
            SQLReadLAB = SQLCmdLAB.ExecuteReader

            If SQLReadLAB.HasRows = True Then 'check for retrived data
                Dim intCount As Integer = 0
                Dim blnDisplayCurrentBlock As Boolean = False
                While SQLReadLAB.Read
                    If blnEnd = False Then
                        If blnDisplayCurrentBlock = False Then
                            lblCurrentBlock.Text = SQLReadLAB("BlockName").ToString
                            Dim strStartTime As Date = SQLReadLAB("BlockSchedStartTime")
                            If Not IsDBNull(SQLReadLAB("BlockSchedDuration")) Then
                                intDuration = SQLReadLAB("BlockSchedDuration")
                            Else : intDuration = 10
                                MessageBox.Show("Block Active Time is not set. Please set -block active time- first")
                            End If

                            strEndTime = DateAdd(DateInterval.Minute, intDuration, strStartTime)
                            startTimer()
                            blnDisplayCurrentBlock = True
                        End If
                    End If
                    Try
                        arActiveBlock(intCount, 0) = SQLReadLAB("ItemID").ToString
                        arActiveBlock(intCount, 1) = SQLReadLAB("ItemBlockPos").ToString
                        arActiveBlock(intCount, 2) = SQLReadLAB("ItemDesc").ToString

                        If Not IsDBNull(SQLReadLAB("ItemMinBid")) Then
                            arActiveBlock(intCount, 3) = Format(SQLReadLAB("ItemMinBid"), "##,##0")
                        Else : arActiveBlock(intCount, 3) = "0"
                        End If

                        If Not IsDBNull(SQLReadLAB("ItemHighBid")) Then '''xxxxxxxxxxxxx
                            arActiveBlock(intCount, 4) = Format(SQLReadLAB("ItemHighBid"), "##,##0")
                        Else : arActiveBlock(intCount, 4) = "0"
                        End If

                        arActiveBlock(intCount, 5) = SQLReadLAB("ItemHighBidderID").ToString

                        intCount += 1
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                End While
            End If

            SQLConnLAB.Close()
            Main.serverTime = Main.getServerTime

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConnLAB.State <> ConnectionState.Closed Then
                SQLConnLAB.Close()
            End If
            SQLCmdLAB.Dispose()
        End Try

        'display items base on ItemBlockPos
        For intCount = 0 To 10
            Select Case arActiveBlock(intCount, 1)
                Case "1"
                    lblItemID1.Text = arActiveBlock(intCount, 0)
                    lblItemPos1.Text = arActiveBlock(intCount, 1)
                    lblItemDesc1.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid1.Text = arActiveBlock(intCount, 3)
                    lblCurBid1.Text = arActiveBlock(intCount, 4)
                    lblBidID1.Text = arActiveBlock(intCount, 5)
                Case "2"
                    lblItemID2.Text = arActiveBlock(intCount, 0)
                    lblItemPos2.Text = arActiveBlock(intCount, 1)
                    lblItemDesc2.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid2.Text = arActiveBlock(intCount, 3)
                    lblCurBid2.Text = arActiveBlock(intCount, 4)
                    lblBidID2.Text = arActiveBlock(intCount, 5)
                Case "3"
                    lblItemID3.Text = arActiveBlock(intCount, 0)
                    lblItemPos3.Text = arActiveBlock(intCount, 1)
                    lblItemDesc3.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid3.Text = arActiveBlock(intCount, 3)
                    lblCurBid3.Text = arActiveBlock(intCount, 4)
                    lblBidID3.Text = arActiveBlock(intCount, 5)
                Case "4"
                    lblItemID4.Text = arActiveBlock(intCount, 0)
                    lblItemPos4.Text = arActiveBlock(intCount, 1)
                    lblItemDesc4.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid4.Text = arActiveBlock(intCount, 3)
                    lblCurBid4.Text = arActiveBlock(intCount, 4)
                    lblBidID4.Text = arActiveBlock(intCount, 5)
                Case "5"
                    lblItemID5.Text = arActiveBlock(intCount, 0)
                    lblItemPos5.Text = arActiveBlock(intCount, 1)
                    lblItemDesc5.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid5.Text = arActiveBlock(intCount, 3)
                    lblCurBid5.Text = arActiveBlock(intCount, 4)
                    lblBidID5.Text = arActiveBlock(intCount, 5)
                Case "6"
                    lblItemID6.Text = arActiveBlock(intCount, 0)
                    lblItemPos6.Text = arActiveBlock(intCount, 1)
                    lblItemDesc6.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid6.Text = arActiveBlock(intCount, 3)
                    lblCurBid6.Text = arActiveBlock(intCount, 4)
                    lblBidID6.Text = arActiveBlock(intCount, 5)
                Case "7"
                    lblItemID7.Text = arActiveBlock(intCount, 0)
                    lblItemPos7.Text = arActiveBlock(intCount, 1)
                    lblItemDesc7.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid7.Text = arActiveBlock(intCount, 3)
                    lblCurBid7.Text = arActiveBlock(intCount, 4)
                    lblBidID7.Text = arActiveBlock(intCount, 5)
                Case "8"
                    lblItemID8.Text = arActiveBlock(intCount, 0)
                    lblItemPos8.Text = arActiveBlock(intCount, 1)
                    lblItemDesc8.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid8.Text = arActiveBlock(intCount, 3)
                    lblCurBid8.Text = arActiveBlock(intCount, 4)
                    lblBidID8.Text = arActiveBlock(intCount, 5)
                Case "9"
                    lblItemID9.Text = arActiveBlock(intCount, 0)
                    lblItemPos9.Text = arActiveBlock(intCount, 1)
                    lblItemDesc9.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid9.Text = arActiveBlock(intCount, 3)
                    lblCurBid9.Text = arActiveBlock(intCount, 4)
                    lblBidID9.Text = arActiveBlock(intCount, 5)
                Case "10"
                    lblItemID10.Text = arActiveBlock(intCount, 0)
                    lblItemPos10.Text = arActiveBlock(intCount, 1)
                    lblItemDesc10.Text = arActiveBlock(intCount, 2)
                    lblItemMinBid10.Text = arActiveBlock(intCount, 3)
                    lblCurBid10.Text = arActiveBlock(intCount, 4)
                    lblBidID10.Text = arActiveBlock(intCount, 5)
            End Select
        Next
    End Sub

    'reset display label set text to blank
    Private Sub clearDisplay()
        'row 1
        lblItemPos1.Text = ""
        lblItemDesc1.Text = ""
        lblItemMinBid1.Text = ""
        lblCurBid1.Text = ""
        lblBidID1.Text = ""
        'row 2
        lblItemPos2.Text = ""
        lblItemDesc2.Text = ""
        lblItemMinBid2.Text = ""
        lblCurBid2.Text = ""
        lblBidID2.Text = ""
        'row 3
        lblItemPos3.Text = ""
        lblItemDesc3.Text = ""
        lblItemMinBid3.Text = ""
        lblCurBid3.Text = ""
        lblBidID3.Text = ""
        'row 4
        lblItemPos4.Text = ""
        lblItemDesc4.Text = ""
        lblItemMinBid4.Text = ""
        lblCurBid4.Text = ""
        lblBidID4.Text = ""
        'row 5
        lblItemPos5.Text = ""
        lblItemDesc5.Text = ""
        lblItemMinBid5.Text = ""
        lblCurBid5.Text = ""
        lblBidID5.Text = ""
        'row 6
        lblItemPos6.Text = ""
        lblItemDesc6.Text = ""
        lblItemMinBid6.Text = ""
        lblCurBid6.Text = ""
        lblBidID6.Text = ""
        'row 7
        lblItemPos7.Text = ""
        lblItemDesc7.Text = ""
        lblItemMinBid7.Text = ""
        lblCurBid7.Text = ""
        lblBidID7.Text = ""
        'row 8
        lblItemPos8.Text = ""
        lblItemDesc8.Text = ""
        lblItemMinBid8.Text = ""
        lblCurBid8.Text = ""
        lblBidID8.Text = ""
        'row 9
        lblItemPos9.Text = ""
        lblItemDesc9.Text = ""
        lblItemMinBid9.Text = ""
        lblCurBid9.Text = ""
        lblBidID9.Text = ""
        'row 10
        lblItemPos10.Text = ""
        lblItemDesc10.Text = ""
        lblItemMinBid10.Text = ""
        lblCurBid10.Text = ""
        lblBidID10.Text = ""
    End Sub

    Private Sub limitOtherBid(ByVal intLoc As Integer)
        'row 1
        If intLoc = 1 Then
            txtBid1.Enabled = True
            txtBid1.BackColor = Color.LightSkyBlue
        Else
            txtBid1.Enabled = False
        End If
        'row 2
        If intLoc = 2 Then
            txtBid2.Enabled = True
            txtBid2.BackColor = Color.LightSkyBlue
        Else
            txtBid2.Enabled = False
        End If
        'row 3
        If intLoc = 3 Then
            txtBid3.Enabled = True
            txtBid3.BackColor = Color.LightSkyBlue
        Else
            txtBid3.Enabled = False
        End If
        'row 4
        If intLoc = 4 Then
            txtBid4.Enabled = True
            txtBid4.BackColor = Color.LightSkyBlue
        Else
            txtBid4.Enabled = False
        End If
        'row 5
        If intLoc = 5 Then
            txtBid5.Enabled = True
            txtBid5.BackColor = Color.LightSkyBlue
        Else
            txtBid5.Enabled = False
        End If
        'row 6
        If intLoc = 6 Then
            txtBid6.Enabled = True
            txtBid6.BackColor = Color.LightSkyBlue
        Else
            txtBid6.Enabled = False
        End If
        'row 7
        If intLoc = 7 Then
            txtBid7.Enabled = True
            txtBid7.BackColor = Color.LightSkyBlue
        Else
            txtBid7.Enabled = False
        End If
        'row 8
        If intLoc = 8 Then
            txtBid8.Enabled = True
            txtBid8.BackColor = Color.LightSkyBlue
        Else
            txtBid8.Enabled = False
        End If
        'row 9
        If intLoc = 9 Then
            txtBid9.Enabled = True
            txtBid9.BackColor = Color.LightSkyBlue
        Else
            txtBid9.Enabled = False
        End If
        'row 10
        If intLoc = 10 Then
            txtBid10.Enabled = True
            txtBid10.BackColor = Color.LightSkyBlue
        Else
            txtBid10.Enabled = False
        End If
        'btnCommit.Enabled = True
        btnSignOff.Enabled = False
        btnRefresh.Enabled = False
        lblMessageBox.Text = "Press [Escape] key to cancel bid on selected item."
    End Sub

    'once [Esc] is pressed... allow bidder to pick an item to bid
    Private Sub resetBid()
        txtBid1.Enabled = True
        txtBid1.Clear()
        txtBid1.BackColor = Color.Gainsboro

        txtBid2.Enabled = True
        txtBid2.Clear()
        txtBid2.BackColor = Color.White

        txtBid3.Enabled = True
        txtBid3.Clear()
        txtBid3.BackColor = Color.Gainsboro

        txtBid4.Enabled = True
        txtBid4.Clear()
        txtBid4.BackColor = Color.White

        txtBid5.Enabled = True
        txtBid5.Clear()
        txtBid5.BackColor = Color.Gainsboro

        txtBid6.Enabled = True
        txtBid6.Clear()
        txtBid6.BackColor = Color.White

        txtBid7.Enabled = True
        txtBid7.Clear()
        txtBid7.BackColor = Color.Gainsboro

        txtBid8.Enabled = True
        txtBid8.Clear()
        txtBid8.BackColor = Color.White

        txtBid9.Enabled = True
        txtBid9.Clear()
        txtBid9.BackColor = Color.Gainsboro

        txtBid10.Enabled = True
        txtBid10.Clear()
        txtBid10.BackColor = Color.White

        lblMessageBox.Text = ""
        btnSignOff.Enabled = True
        btnRefresh.Enabled = True
        btnCommit.Enabled = False
        btnSignOff.Select()

    End Sub

    Private Sub btnSignOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOff.Click
        txtBidderID.Enabled = True
        txtBidderID.Text = ""
        PhoneVer_lbl.Text = ""
        lblBidderLName.Text = ""
        NotActive_lbl.Text = ""
        lblCurrentBlock.Text = ""
        lblTimeRemain.Text = ""
        timeRemain.Stop()
        btnCheck.Enabled = True
        btnBigBlock.Enabled = False
        btnRegBlock.Enabled = False
        btnSupBlock.Enabled = False
        resetBid()
        lockBid()
        clearDisplay()
        btnSignOff.Enabled = False
        btnRefresh.Enabled = False
        BidderAreaPhone_txt.Text = ""
        BidderPrefixPhone_txt.Text = ""
        BidderLinePhone_txt.Text = ""
        txtBidderID.Focus()
    End Sub

    'start timer (block remaining time)
    Private Sub startTimer()
        timeRemain.Start()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click

        If BidderAreaPhone_txt.Text = "" Or BidderPrefixPhone_txt.Text = "" Or BidderLinePhone_txt.Text = "" Or _
           BidderAreaPhone_txt.TextLength <> 3 Or BidderPrefixPhone_txt.TextLength <> 3 Or BidderLinePhone_txt.TextLength <> 4 Then
            BidderAreaPhone_txt.Focus()
            MessageBox.Show("ERROR: Please enter alternate bidder phone number!", "Required Input Error")
        ElseIf PhoneIsNum_sw = 1 Then
            BidderAreaPhone_txt.Focus()
            MessageBox.Show("ERROR: Alternate bidder phone number contains invalid characters!", "Required Input Error")
        Else
            'UPDATE BID
            assignVariableToBid()
        End If
    End Sub

    Private Sub assignVariableToBid()
        Dim newBid As Integer
        Dim intID As Integer
        Dim intBidderID As Integer = txtBidderID.Text

        'assign new bid with correct row(the display)
        Select Case bidPosition
            Case 1 : newBid = txtBid1.Text
                intID = lblItemID1.Text
                If lblItemMinBid1.Text <> "" Then
                    minBid = lblItemMinBid1.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid1.Text) Then
                    currBid = lblCurBid1.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos1.Text
            Case 2 : newBid = txtBid2.Text
                intID = lblItemID2.Text
                If lblItemMinBid2.Text <> "" Then
                    minBid = lblItemMinBid2.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid2.Text) Then
                    currBid = lblCurBid2.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos2.Text
            Case 3 : newBid = txtBid3.Text
                intID = lblItemID3.Text

                If lblItemMinBid3.Text <> "" Then
                    minBid = lblItemMinBid3.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid3.Text) Then
                    currBid = lblCurBid3.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos3.Text
            Case 4 : newBid = txtBid4.Text
                intID = lblItemID4.Text

                If lblItemMinBid4.Text <> "" Then
                    minBid = lblItemMinBid4.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid4.Text) Then
                    currBid = lblCurBid4.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos4.Text
            Case 5 : newBid = txtBid5.Text
                intID = lblItemID5.Text

                If lblItemMinBid5.Text <> "" Then
                    minBid = lblItemMinBid5.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid5.Text) Then
                    currBid = lblCurBid5.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos5.Text
            Case 6 : newBid = txtBid6.Text
                intID = lblItemID6.Text

                If lblItemMinBid6.Text <> "" Then
                    minBid = lblItemMinBid6.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid6.Text) Then
                    currBid = lblCurBid6.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos6.Text
            Case 7 : newBid = txtBid7.Text
                intID = lblItemID7.Text

                If lblItemMinBid7.Text <> "" Then
                    minBid = lblItemMinBid7.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid7.Text) Then
                    currBid = lblCurBid7.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos7.Text
            Case 8 : newBid = txtBid8.Text
                intID = lblItemID8.Text

                If lblItemMinBid8.Text <> "" Then
                    minBid = lblItemMinBid8.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid8.Text) Then
                    currBid = lblCurBid8.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos8.Text
            Case 9 : newBid = txtBid9.Text
                intID = lblItemID9.Text

                If lblItemMinBid9.Text <> "" Then
                    minBid = lblItemMinBid9.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid9.Text) Then
                    currBid = lblCurBid9.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos9.Text
            Case 10 : newBid = txtBid10.Text
                intID = lblItemID10.Text

                If lblItemMinBid10.Text <> "" Then
                    minBid = lblItemMinBid10.Text
                Else : minBid = 0
                End If

                If IsNumeric(lblCurBid10.Text) Then
                    currBid = lblCurBid10.Text
                Else : currBid = 0
                End If
                strPos = lblItemPos10.Text
        End Select

        placeBid(intID, intBidderID, newBid)

    End Sub

    Private Sub clearTextBid(ByVal intPos As Integer)
        Select Case bidPosition
            Case 1
                txtBid1.Clear()
            Case 2
                txtBid2.Clear()
            Case 3
                txtBid3.Clear()
            Case 4
                txtBid4.Clear()
            Case 5
                txtBid5.Clear()
            Case 6
                txtBid6.Clear()
            Case 7
                txtBid7.Clear()
            Case 8
                txtBid8.Clear()
            Case 9
                txtBid9.Clear()
            Case 10
                txtBid10.Clear()
        End Select
    End Sub

    Private Sub placeBid(ByVal ID As Integer, ByVal BidderID As Integer, ByVal BidPrice As Integer)

        ' Database connection and query globals

        Dim ReturnValue As Integer = 0
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        If checkHighAndMinBid(BidPrice) = True Then 'validate highBid against minBid and currBid
            lblMessageBox.Text = "Unsuccessful Bid. New Bid (" & Format(BidPrice, "$ ##,##0") & ") is less than, or equal to the Current Bid or Minimum Bid" ' Changed from "Unsuccessful Bid. New Bid (" & Format(BidPrice, "$ ##,##0") & ") is less than, equal to Current Bid or Min Bid"

            'clear invalid highBid
            clearTextBid(bidPosition)

        ElseIf blnEnd = False Then 'if TimeRemaining > 0 do normal update and refresh currBlock
            If MessageBox.Show("Are you sure you want to bid Item " & strPos & " at " & Format(BidPrice, "$ ##,###"), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                If blnEnd = False Then 'if confirm before block end

                    SQLCmd.CommandType = CommandType.StoredProcedure
                    SQLCmd.CommandText = "uspUpdateItemHighBid"

                    SQLCmd.Parameters.AddWithValue("@itemid", ID)
                    SQLCmd.Parameters.AddWithValue("@bidderid", BidderID)
                    SQLCmd.Parameters.AddWithValue("@bidamount", BidPrice)

                    SQLCmd.Parameters.Add(New SqlParameter("@RETURN_VALUE", SqlDbType.Int)).Direction = ParameterDirection.ReturnValue

                    SQLConn.ConnectionString = DBConnectionString
                    SQLCmd.Connection = SQLConn

                    Try
                        SQLConn.Open()
                        SQLCmd.ExecuteNonQuery()

                        ReturnValue = CType(SQLCmd.Parameters("@RETURN_VALUE").Value, Integer)

                        SQLConn.Close()

                    Catch ex As Exception
                        lblMessageBox.Text = "Connection Issue: Unable to access the database." ' Changed from "Connection Issue: Unable to access the database. Try again later"
                        MessageBox.Show(ex.ToString)
                    Finally
                        If SQLConn.State <> ConnectionState.Closed Then
                            SQLConn.Close()
                        End If
                        SQLCmd.Dispose()
                    End Try
                    loadActiveBlock(strBlock)
                    resetBid()

                    displaySuccessBid(ID, BidPrice)
                Else 'confirm after block end
                    MessageBox.Show("Unsuccessful Bid: The bid was placed after the session ended." & vbCrLf & "Please -Sign Off Bidder- or -Refresh Blocks-") ' Changed from "Unsuccessful Bid: The bid was placed after the session has been ended."
                    clearTextBid(bidPosition)
                    enableBtnBlocks()
                    clearDisplay()
                    resetBid()
                    lockBid()
                    blnEnd = False
                    lblCurrentBlock.Text = ""
                    lblTimeRemain.Text = ""
                End If
            ElseIf blnEnd = True Then
                clearTextBid(bidPosition)
                enableBtnBlocks()
                clearDisplay()
                resetBid()
                lockBid()
                blnEnd = False
                lblCurrentBlock.Text = ""
                lblTimeRemain.Text = ""
            End If
        Else
            'clear invalid highBid
            clearTextBid(bidPosition)
        End If
    End Sub

    Private Sub displaySuccessBid(ByVal ItemID As Integer, ByVal highBid As Integer)

        ' Database connection and query globals
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        Dim highBidID As String = ""
        Dim bidderID As String = Trim(txtBidderID.Text)
        Select Case strPos
            Case 1
                highBidID = lblBidID1.Text
            Case 2
                highBidID = lblBidID2.Text
            Case 3
                highBidID = lblBidID3.Text
            Case 4
                highBidID = lblBidID4.Text
            Case 5
                highBidID = lblBidID5.Text
            Case 6
                highBidID = lblBidID6.Text
            Case 7
                highBidID = lblBidID7.Text
            Case 8
                highBidID = lblBidID8.Text
            Case 9
                highBidID = lblBidID9.Text
            Case 10
                highBidID = lblBidID10.Text
        End Select
        Try
            If bidderID = highBidID Or highBidID = "" Then

                SQLCmd.CommandType = CommandType.StoredProcedure
                SQLCmd.CommandText = "uspInsertItemBidLog"

                SQLCmd.Parameters.AddWithValue("@itemid", ItemID)
                SQLCmd.Parameters.AddWithValue("@bidderid", txtBidderID.Text)
                SQLCmd.Parameters.AddWithValue("@bidamount", highBid)

                SQLConn.ConnectionString = DBConnectionString
                SQLCmd.Connection = SQLConn

                SQLConn.Open()
                SQLCmd.ExecuteNonQuery()
                SQLConn.Close()

                lblMessageBox.Text = "SUCCESSFUL BID!: Item [" & strPos & "] with highest bid " & Format(highBid, "$ ##,##0") ' Changed from "Successful Bid: Item [" & strPos & "] with highest bid " & Format(highBid, "$ ##,##0"
            Else
                lblMessageBox.Text = "UNSUCCESSFUL BID!: Another bid has been placed before this attempt." ' Changed from "Unsuccessful Bid: Another bidder has placed a bid before you"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Function checkHighAndMinBid(ByVal newBid As Double)
        loadActiveBlock(strBlock)
        Dim blnError As Boolean = False
        If newBid <= currBid Or newBid <= minBid Then
            blnError = True
        Else : blnError = False
        End If
        Return blnError
    End Function

    Private Sub lockBid()
        txtBid1.Enabled = False
        txtBid2.Enabled = False
        txtBid3.Enabled = False
        txtBid4.Enabled = False
        txtBid5.Enabled = False
        txtBid6.Enabled = False
        txtBid7.Enabled = False
        txtBid8.Enabled = False
        txtBid9.Enabled = False
        txtBid10.Enabled = False
    End Sub

    'counter for time remaining of current block
    Private Sub timeRemain_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeRemain.Tick
        If strEndTime < Main.getServerTime Then
            timeRemain.Stop()
            lblTimeRemain.Text = "00:00:00"
            blnEnd = True
            btnRefresh.Enabled = True
        Else
            Dim timeDiff As TimeSpan = strEndTime.Subtract(Main.getServerTime)
            lblTimeRemain.Text = Format(timeDiff.Hours, "00") & ":" & Format(timeDiff.Minutes, "00") & ":" & Format(timeDiff.Seconds, "00")
            If lblTimeRemain.Text = "00:00:00" Then
                timeRemain.Stop()
                If MessageBox.Show("Your session on Block: " & lblCurrentBlock.Text & " has ended." & vbCrLf & _
                                   "Please -Sign Off Bidder- or -Refresh Blocks-", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.OK Then
                    blnEnd = True
                    clearDisplay()
                    enableBtnBlocks()
                    resetBid()
                    lockBid()
                End If
            End If
            If Math.IEEERemainder(timeDiff.TotalMilliseconds, 100) = 0 And lblTimeRemain.Text <> "00:00:00" Then
                loadActiveBlock(strBlock)
            End If
        End If

        'IF block has no time left in minutes and has time left in seconds > form
        ' background will change from yellow to firebrick red in 10 seconds 
        ' and disable the place bid button at 0 seconds (no time left).
        If lblTimeRemain.Text = "" Then
            Me.BackColor = Color.SkyBlue
            btnCommit.Enabled = False
        ElseIf lblTimeRemain.Text <> "" Then
            If lblTimeRemain.Text.Substring(0, 2) = 0 And lblTimeRemain.Text.Substring(3, 2) = 0 And lblTimeRemain.Text.Substring(6, 2) = 10 Then
                Me.BackColor = Color.Yellow
            End If
            If lblTimeRemain.Text.Substring(0, 2) = 0 And lblTimeRemain.Text.Substring(3, 2) = 0 And lblTimeRemain.Text.Substring(6, 2) <= 8 Then
                Me.BackColor = Color.Gold
            End If
            If lblTimeRemain.Text.Substring(0, 2) = 0 And lblTimeRemain.Text.Substring(3, 2) = 0 And lblTimeRemain.Text.Substring(6, 2) <= 6 Then
                Me.BackColor = Color.Orange
            End If
            If lblTimeRemain.Text.Substring(0, 2) = 0 And lblTimeRemain.Text.Substring(3, 2) = 0 And lblTimeRemain.Text.Substring(6, 2) <= 4 Then
                Me.BackColor = Color.DarkOrange
            End If
            If lblTimeRemain.Text.Substring(0, 2) = 0 And lblTimeRemain.Text.Substring(3, 2) = 0 And lblTimeRemain.Text.Substring(6, 2) <= 2 Then
                Me.BackColor = Color.OrangeRed
            End If
            If lblTimeRemain.Text.Substring(0, 2) = 0 And lblTimeRemain.Text.Substring(3, 2) = 0 And lblTimeRemain.Text.Substring(6, 2) = 1 Then
                Me.BackColor = Color.Firebrick
            End If
            'Disable place bid button
            If lblTimeRemain.Text.Substring(0, 2) = 0 And lblTimeRemain.Text.Substring(3, 2) = 0 And lblTimeRemain.Text.Substring(6, 2) = 0 Then
                btnCommit.Enabled = False
            End If
        End If

    End Sub

    Private Function IsValidAlphaNum(ByVal AlphaNumIn As String) As Boolean
        Return Regex.IsMatch(AlphaNumIn, "[a-zA-Z]")
    End Function

    Private Sub txtBid1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid1.TextChanged
        If txtBid1.TextLength > 0 And IsNumeric(txtBid1.Text) And txtBid1.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid2.TextChanged
        If txtBid2.TextLength > 0 And IsNumeric(txtBid2.Text) And txtBid2.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid3.TextChanged
        If txtBid3.TextLength > 0 And IsNumeric(txtBid3.Text) And txtBid3.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid4.TextChanged
        If txtBid4.TextLength > 0 And IsNumeric(txtBid4.Text) And txtBid4.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid5.TextChanged
        If txtBid5.TextLength > 0 And IsNumeric(txtBid5.Text) And txtBid5.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid6.TextChanged
        If txtBid6.TextLength > 0 And IsNumeric(txtBid6.Text) And txtBid6.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid7.TextChanged
        If txtBid7.TextLength > 0 And IsNumeric(txtBid7.Text) And txtBid7.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid8.TextChanged
        If txtBid8.TextLength > 0 And IsNumeric(txtBid8.Text) And txtBid8.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid9.TextChanged
        If txtBid9.TextLength > 0 And IsNumeric(txtBid9.Text) And txtBid9.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBid10.TextChanged
        If txtBid10.TextLength > 0 And IsNumeric(txtBid10.Text) And txtBid10.Text <> "" Then
            btnCommit.Enabled = True
        Else : btnCommit.Enabled = False
        End If
    End Sub

    Private Sub txtBid1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid1.Enter
        bidPosition = 1
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid2.Enter
        bidPosition = 2
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid3.Enter
        bidPosition = 3
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid4.Enter
        bidPosition = 4
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid5_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid5.Enter
        bidPosition = 5
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid6_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid6.Enter
        bidPosition = 6
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid7_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid7.Enter
        bidPosition = 7
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid8_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid8.Enter
        bidPosition = 8
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid9_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid9.Enter
        bidPosition = 9
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid10_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBid10.Enter
        bidPosition = 10
        limitOtherBid(bidPosition)
    End Sub

    Private Sub txtBid1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid1.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid1.Text) Then
            txtBid1.Clear()
        End If
    End Sub

    Private Sub txtBid2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid2.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid2.Text) Then
            txtBid2.Clear()
        End If
    End Sub

    Private Sub txtBid3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid3.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid3.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid3.Text) Then
            txtBid3.Clear()
        End If
    End Sub

    Private Sub txtBid4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid4.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid4.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid4.Text) Then
            txtBid4.Clear()
        End If
    End Sub

    Private Sub txtBid5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid5.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid5.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid5.Text) Then
            txtBid5.Clear()
        End If
    End Sub

    Private Sub txtBid6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid6.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid6.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid6.Text) Then
            txtBid6.Clear()
        End If
    End Sub

    Private Sub txtBid7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid7.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid7.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid7.Text) Then
            txtBid7.Clear()
        End If
    End Sub

    Private Sub txtBid8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid8.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid8.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid8.Text) Then
            txtBid8.Clear()
        End If
    End Sub

    Private Sub txtBid9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid9.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid9.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid9.Text) Then
            txtBid9.Clear()
        End If
    End Sub

    Private Sub txtBid10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBid10.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            resetBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsNumeric(txtBid10.Text) Then
            assignVariableToBid()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsNumeric(txtBid10.Text) Then
            txtBid10.Clear()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        enableBtnBlocks()
        blnEnd = False
    End Sub

    Private Sub Exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_btn.Click
        Me.Hide()
        Me.Close()
        Main.Visible = True
    End Sub

    Private Sub ThisFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub BidderAreaPhone_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BidderAreaPhone_txt.KeyPress
        If BidderAreaPhone_txt.TextLength = 3 And Not e.KeyChar = ChrW(Keys.Back) Then
            BidderPrefixPhone_txt.Focus()
            BidderPrefixPhone_txt.Text = e.KeyChar
            BidderPrefixPhone_txt.SelectionStart = BidderPrefixPhone_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub BidderPrefixPhone_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BidderPrefixPhone_txt.KeyPress
        If BidderPrefixPhone_txt.TextLength = 3 And Not e.KeyChar = ChrW(Keys.Back) Then
            BidderLinePhone_txt.Focus()
            BidderLinePhone_txt.Text = e.KeyChar
            BidderLinePhone_txt.SelectionStart = BidderPrefixPhone_txt.TextLength
        ElseIf BidderPrefixPhone_txt.TextLength < 1 And e.KeyChar = ChrW(Keys.Back) Then
            BidderAreaPhone_txt.Focus()
            BidderAreaPhone_txt.SelectionStart = BidderAreaPhone_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        BidderPrefixPhone_txt.BackColor = Color.White
    End Sub

    Private Sub BidderLinePhone_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BidderLinePhone_txt.KeyPress
        If BidderLinePhone_txt.TextLength < 1 And e.KeyChar = ChrW(Keys.Back) Then
            BidderPrefixPhone_txt.Focus()
            BidderPrefixPhone_txt.SelectionStart = BidderPrefixPhone_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        BidderLinePhone_txt.BackColor = Color.White
    End Sub

    Private Sub BidderLinePhone_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BidderLinePhone_txt.TextChanged
        If BidderLinePhone_txt.TextLength < 1 Then
            BidderPrefixPhone_txt.Focus()
        End If
        ' Verify line number is NUMERIC
        If IsValidAlphaNum(BidderLinePhone_txt.Text) = True Then
            BidderLinePhone_txt.BackColor = Color.LightGreen
            lblMessageBox.Text = "Letters are not valid input for phone number."
            PhoneIsNum_sw = 1
        Else
            BidderLinePhone_txt.BackColor = Color.White
            lblMessageBox.Text = ""
            PhoneIsNum_sw = 0
        End If

    End Sub

    Private Sub txtBidderID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBidderID.TextChanged
        'IF characters for bidder ID are NOT NUMERIC, THEN the check ID button will be disabled. IF he characters ARE NUMERIC,
        ' the check ID buton be enabled.
        If IsValidAlphaNum(txtBidderID.Text) = True Then
            txtBidderID.BackColor = Color.LightGreen
            lblMessageBox.Text = "Letters are not valid input for a bidder ID."
            btnCheck.Enabled = False
        Else
            txtBidderID.BackColor = Color.White
            lblMessageBox.Text = ""
            btnCheck.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        UpdateBider2ndPhone()

        Dim PhoneArea As String = bidderPhone2.Substring(0, 3)
        Dim PhonePrefix As String = bidderPhone2.Substring(3, 3)
        Dim PhoneLine As String = bidderPhone2.Substring(6, 4)
        bidderPhone2 = "(" & PhoneArea & ")" & PhonePrefix & "-" & PhoneLine
        MessageBox.Show("Bidder alternate phone number has been updated to : " & bidderPhone2, "Bidder Secondary Phone Update")
        bidderPhone2 = ""

    End Sub

    Private Sub UpdateBider2ndPhone()

        ' Database connection and query globals
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        'UPDATE ALTERNATE PHONE NUMBER for BIDDER

        bidderPhone2 = BidderAreaPhone_txt.Text & "" & BidderPrefixPhone_txt.Text & "" & BidderLinePhone_txt.Text

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspUpdateBidderPhone2"

        SQLCmd.Parameters.AddWithValue("@bidderid", txtBidderID.Text)
        SQLCmd.Parameters.AddWithValue("@phone2", bidderPhone2)

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
            SQLConn.Dispose()
        End Try
    End Sub

End Class
