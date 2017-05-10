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

    Private arrBlockWinners(11, 7) As String
    Private WithEvents timer As New System.Timers.Timer




    Private Sub txtBidderID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
        End If
    End Sub

    Private Sub enableBtnBlocks()

        ' Database connection and query globals
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        btnRegBlock.Enabled = True
        btnBigBlock.Enabled = True
        btnSupBlock.Enabled = True
        btnRefresh.Enabled = True



        btnWinner.Enabled = True
        btnExit.Enabled = True

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
        'If btnRegBlock.Enabled = False And btnBigBlock.Enabled = False And btnSupBlock.Enabled = False Then
        'MessageBox.Show("There are no active blocks currently available.") 'Changed from "No current active block" HIDE
        'End If

        lblCurrentBlock.Text = ""
        lblTimeRemain.Text = ""
    End Sub

    Private Sub btnRegBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegBlock.Click
        Panel1.BackColor = Color.SeaGreen
        Me.BackColor = Color.DarkGreen

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
        Panel1.BackColor = Color.MediumPurple
        Me.BackColor = Color.DarkViolet

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
        Panel1.BackColor = Color.PaleVioletRed
        Me.BackColor = Color.DarkRed

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

        SQLCmdLAB.CommandType = CommandType.Text 'CommandType.StoredProcedure

        'Main.cmd.CommandType = System.Data.CommandType.Text
        ''If blnEnd = False Then

        'SQLCmdLAB.CommandText = "uspSelectActiveBlocks"

        SQLCmdLAB.CommandText = "SELECT I.ItemID, I.ItemBlockPos, I.ItemDesc, I.ItemRetailVal, I.ItemHighBid, I.ItemHighBidderID, I.ItemBlockID, B.BlockType, B.BlockName, B.BlockSchedStartTime, B.BlockSchedDuration FROM Items AS I INNER JOIN Blocks AS B ON I.ItemBlockID = B.BlockID WHERE (B.BlockType LIKE '" & strBlockType & "') AND (I.ItemAuctionStatus = '2') AND (B.BlockAuctionYear = YEAR(dbo.ufnNextAuctionDate()))"
        'ElseIf blnEnd = True Then

        'SQLCmdLAB.CommandText = "uspSelectNOTActiveBlocks"
        'blnEnd = False

        ''End If

        ''SQLCmdLAB.Parameters.AddWithValue("@blocktype", strBlockType)

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
                                'MessageBox.Show("Block Active Time is not set. Please set -block active time- first")
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

                        If Not IsDBNull(SQLReadLAB("ItemRetailVal")) Then
                            arActiveBlock(intCount, 3) = Format(SQLReadLAB("ItemRetailVal"), "$##,##0")
                        Else : arActiveBlock(intCount, 3) = "0"
                        End If

                        If Not IsDBNull(SQLReadLAB("ItemHighBid")) Then '''xxxxxxxxxxxxx
                            arActiveBlock(intCount, 4) = Format(SQLReadLAB("ItemHighBid"), "$##,##0")
                        Else : arActiveBlock(intCount, 4) = "0"
                        End If

                        arActiveBlock(intCount, 5) = SQLReadLAB("ItemHighBidderID").ToString

                        intCount += 1
                    Catch ex As Exception
                        'MessageBox.Show(ex.ToString)
                    End Try

                End While
            End If

            SQLConnLAB.Close()
            Main.serverTime = Main.getServerTime

        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
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

        btnRefresh.Enabled = False

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


        btnRefresh.Enabled = True


    End Sub


    'start timer (block remaining time)
    Private Sub startTimer()
        timeRemain.Start()
    End Sub


    Private Sub assignVariableToBid()
        Dim newBid As Integer
        Dim intID As Integer
        '  Dim intBidderID As Integer = txtBidderID.Text

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

        '     placeBid(intID, intBidderID, newBid)

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
            '  lblMessageBox.Text = "Unsuccessful Bid. New Bid (" & Format(BidPrice, "$ ##,##0") & ") is less than, or equal to the Current Bid or Minimum Bid" ' Changed from "Unsuccessful Bid. New Bid (" & Format(BidPrice, "$ ##,##0") & ") is less than, equal to Current Bid or Min Bid"

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
                        '   lblMessageBox.Text = "Connection Issue: Unable to access the database." ' Changed from "Connection Issue: Unable to access the database. Try again later"
                        'MessageBox.Show(ex.ToString)
                    Finally
                        If SQLConn.State <> ConnectionState.Closed Then
                            SQLConn.Close()
                        End If
                        SQLCmd.Dispose()
                    End Try
                    loadActiveBlock(strBlock)
                    resetBid()

                    ' displaySuccessBid(ID, BidPrice)
                Else 'confirm after block end
                    'MessageBox.Show("Unsuccessful Bid: The bid was placed after the session ended." & vbCrLf & "Please -Sign Off Bidder- or -Refresh Blocks-") ' Changed from "Unsuccessful Bid: The bid was placed after the session has been ended."
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

  

    End Sub

    Private Function IsValidAlphaNum(ByVal AlphaNumIn As String) As Boolean
        Return Regex.IsMatch(AlphaNumIn, "[a-zA-Z]")
    End Function

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
        btnRefresh_Auto()
        blnEnd = False

       

    End Sub
    Private Sub btnRefresh_Auto() '(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ' While True
        timer.Interval = 60000
        timer.Enabled = True
        enableBtnBlocks()
        blnEnd = False
        'Synchronize with current form, or else an error will occur when trying to
        ' update from within the elapsed event
        timer.SynchronizingObject = btnRefresh
        '  End While

    End Sub

    Private Sub Exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Me.Close()
        Main.Visible = True
    End Sub

    Private Sub ThisFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub PlaceBid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        enableBtnBlocks()
        LoadWinningBlocks()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbWinningBlcks.SelectedIndexChanged
        'GetWinningBlock(cbWinningBlcks.SelectedItem)



        Dim getBlockType As String = cbWinningBlcks.SelectedItem

        Dim blockType As String() = getBlockType.Split(":")

        lblBlockSponsor.Text = ""

        GetWinningBlock(blockType(0).Trim())

        Dim typeCheck = blockType(1)

        typeCheck = typeCheck.Trim()
        If (typeCheck = "RR") Then
            Panel2.BackColor = Color.SeaGreen
            Me.BackColor = Color.DarkGreen
        ElseIf (typeCheck = "BB") Then
            Panel2.BackColor = Color.MediumPurple
            Me.BackColor = Color.DarkViolet
        ElseIf (typeCheck = "SU") Then
            Panel2.BackColor = Color.PaleVioletRed
            Me.BackColor = Color.DarkRed
        Else
            'no CARE!!!!!!!!!!!!!!!!!!!ksacxdvjoblas'dcks'ndc!!!
        End If
    End Sub

    Private Sub LoadWinningBlocks()

        Dim currDate As String = Year(Today)

        ' Database connection and query globals
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        btnRegBlock.Enabled = True
        btnBigBlock.Enabled = True
        btnSupBlock.Enabled = True

        SQLCmd.CommandType = CommandType.Text
        SQLCmd.CommandText = String.Format("SELECT BlockName, BlockType FROM Blocks WHERE (BlockAuctionYear = {0}) ORDER BY BlockName", currDate)

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLRead = SQLCmd.ExecuteReader

        If SQLRead.HasRows = True Then
            While SQLRead.Read

                cbWinningBlcks.Items.Add(String.Format("{0}   :{1}", SQLRead("BlockName").ToString(), SQLRead("BlockType").ToString()))

            End While
        End If
    End Sub

    Private Sub GetWinningBlock(ByVal blockNum)

        lblWinBlock.Text = ""

        Dim blockDate As String = Main.dateYear
        'Dim blockNum As String = "Block 06"


        ' Database connection and query globals
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        btnRegBlock.Enabled = True
        btnBigBlock.Enabled = True
        btnSupBlock.Enabled = True

        SQLCmd.CommandType = CommandType.Text
        SQLCmd.CommandText = String.Format("SELECT Items.ItemBlockPos, Blocks.BlockID, Blocks.BlockName, Items.ItemDesc, Items.ItemHighBid, Bidders.BidderFName, Bidders.BidderLName FROM Blocks INNER JOIN Items ON Blocks.BlockID = Items.ItemBlockID INNER JOIN Bidders ON Items.ItemHighBidderID = Bidders.BidderID WHERE (Blocks.BlockName = '{0}') AND (Items.ItemDateDonated >= '{1}') ORDER BY Items.ItemBlockPos", blockNum, blockDate)

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLRead = SQLCmd.ExecuteReader

        Dim i As Integer = 0
        If SQLRead.HasRows = True Then
            While SQLRead.Read

                arrBlockWinners(i, 0) = SQLRead("ItemBlockPos").ToString()
                arrBlockWinners(i, 1) = SQLRead("BlockID").ToString()
                arrBlockWinners(i, 2) = SQLRead("BlockName").ToString()
                arrBlockWinners(i, 3) = SQLRead("ItemDesc").ToString()

                arrBlockWinners(i, 4) = Convert.ToInt16(SQLRead("ItemHighBid")).ToString
                arrBlockWinners(i, 5) = SQLRead("BidderFName").ToString()
                arrBlockWinners(i, 6) = SQLRead("BidderLName").ToString()

                i += 1
            End While
        End If
        Try

            lblWinBlock.Text = arrBlockWinners(0, 2).ToString()

            lblPos1.Text = arrBlockWinners(0, 0)
            lblDesc1.Text = arrBlockWinners(0, 3)
            lblHighBidder1.Text = String.Format("{0} {1}", arrBlockWinners(0, 5), arrBlockWinners(0, 6))
            lblWin1.Text = String.Format("${0}", arrBlockWinners(0, 4))

            lblPos2.Text = arrBlockWinners(1, 0)
            lblDesc2.Text = arrBlockWinners(1, 3)
            lblHighBidder2.Text = String.Format("{0} {1}", arrBlockWinners(1, 5), arrBlockWinners(1, 6))
            lblWin2.Text = String.Format("${0}", arrBlockWinners(1, 4))

            lblPos3.Text = arrBlockWinners(2, 0)
            lblDesc3.Text = arrBlockWinners(2, 3)
            lblHighBidder3.Text = String.Format("{0} {1}", arrBlockWinners(2, 5), arrBlockWinners(2, 6))
            lblWin3.Text = String.Format("${0}", arrBlockWinners(2, 4))

            lblPos4.Text = arrBlockWinners(3, 0)
            lblDesc4.Text = arrBlockWinners(3, 3)
            lblHighBidder4.Text = String.Format("{0} {1}", arrBlockWinners(3, 5), arrBlockWinners(3, 6))
            lblWin4.Text = String.Format("${0}", arrBlockWinners(3, 4))

            lblPos5.Text = arrBlockWinners(4, 0)
            lblDesc5.Text = arrBlockWinners(4, 3)
            lblHighBidder5.Text = String.Format("{0} {1}", arrBlockWinners(4, 5), arrBlockWinners(4, 6))
            lblWin5.Text = String.Format("${0}", arrBlockWinners(4, 4))

            lblPos6.Text = arrBlockWinners(5, 0)
            lblDesc6.Text = arrBlockWinners(5, 3)
            lblHighBidder6.Text = String.Format("{0} {1}", arrBlockWinners(5, 5), arrBlockWinners(5, 6))
            lblWin6.Text = String.Format("${0}", arrBlockWinners(5, 4))

            lblPos7.Text = arrBlockWinners(6, 0)
            lblDesc7.Text = arrBlockWinners(6, 3)
            lblHighBidder7.Text = String.Format("{0} {1}", arrBlockWinners(6, 5), arrBlockWinners(6, 6))
            lblWin7.Text = String.Format("${0}", arrBlockWinners(6, 4))

            lblPos8.Text = arrBlockWinners(7, 0)
            lblDesc8.Text = arrBlockWinners(7, 3)
            lblHighBidder8.Text = String.Format("{0} {1}", arrBlockWinners(7, 5), arrBlockWinners(7, 6))
            lblWin8.Text = String.Format("${0}", arrBlockWinners(7, 4))

            lblPos9.Text = arrBlockWinners(8, 0)
            lblDesc9.Text = arrBlockWinners(8, 3)
            lblHighBidder9.Text = String.Format("{0} {1}", arrBlockWinners(8, 5), arrBlockWinners(8, 6))
            lblWin9.Text = String.Format("${0}", arrBlockWinners(8, 4))

            lblPos10.Text = arrBlockWinners(9, 0)
            lblDesc10.Text = arrBlockWinners(9, 3)
            lblHighBidder10.Text = String.Format("{0} {1}", arrBlockWinners(9, 5), arrBlockWinners(9, 6))
            lblWin10.Text = String.Format("${0}", arrBlockWinners(9, 4))

            'lblPos10.Text = arrBlockWinners(10, 0)
            'lblDesc10.Text = arrBlockWinners(10, 3)
            'lblHighBidder10.Text = String.Format("{0} {1}", arrBlockWinners(10, 5), arrBlockWinners(10, 6))

        Catch

        End Try

    End Sub

    Private Sub lblWinBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWinBlock.TextChanged
        Sponsor(lblWinBlock.Text)
    End Sub

    Private Sub lblCurrentBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCurrentBlock.TextChanged
        Sponsor(lblCurrentBlock.Text)
    End Sub

    Private Sub Sponsor(ByVal block As String)
        Dim blockDate As String = Year(Today)

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        btnRegBlock.Enabled = True
        btnBigBlock.Enabled = True
        btnSupBlock.Enabled = True

        SQLCmd.CommandType = CommandType.Text
        SQLCmd.CommandText = String.Format("SELECT Donors.DonorName FROM Blocks INNER JOIN Donors ON Blocks.BlockSponsorID = Donors.DonorID WHERE (Blocks.BlockAuctionYear = {0}) AND (Blocks.BlockName = '{1}')", blockDate, block)

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLRead = SQLCmd.ExecuteReader

        If SQLRead.HasRows = True Then
            While SQLRead.Read

                lblBlockSponsor.Text = SQLRead("DonorName").ToString()

            End While
        End If
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Click, Panel3.Paint
        If btnRegBlock.Visible = True Then
            cbWinningBlcks.Visible = True
            btnRegBlock.Visible = True
            btnBigBlock.Visible = True
            btnSupBlock.Visible = True
            btnRefresh.Visible = True
            btnWinner.Visible = True
            btnExit.Visible = True
        ElseIf btnRegBlock.Visible = False Then
            cbWinningBlcks.Visible = True
            btnRegBlock.Visible = True
            btnBigBlock.Visible = True
            btnSupBlock.Visible = True
            btnRefresh.Visible = True
            btnWinner.Visible = True
            btnExit.Visible = True
        End If
    End Sub

    Private Sub btnWinner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWinner.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
            Panel2.Visible = True
        ElseIf Panel1.Visible = False Then
            Panel1.Visible = True
            Panel2.Visible = False
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Visible = False
        Me.Close()
        Main.Visible = True
    End Sub

    Private Sub Panel3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint, Panel3.Click

    End Sub

    Private Sub lblDesc10_Click(sender As System.Object, e As System.EventArgs) Handles lblDesc10.Click

    End Sub
End Class
