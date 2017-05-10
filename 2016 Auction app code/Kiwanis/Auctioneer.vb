Imports System.Data
Imports System.Data.SqlClient
'
Public Class Auctioneer

    Public strEndTime1, strEndTime2, strEndTime3, strEndTime4, strEndTime5 As Date
    Public intDuration1, intDuration2, intDuration3, intDuration4, intDuration5 As Integer
    Public blnRegBlock, blnBigBlock, blnSupBlock As Boolean
    Public strBlockInfo(200, 2), strBlockInfoDone(200, 2) As String

    Public DBConnectionString As String = KiwanisConfig.LoadDatabaseConfig

    Private Sub Auctioneer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadTest()
        initialState()
        loadBlockID()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Visible = True
        Me.Close()
    End Sub

    Private Sub ThisFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub initialState()
        lblTime1.Text = ""
        lblTime1.ForeColor = Color.Black
        lblTime2.Text = ""
        lblTime2.ForeColor = Color.Black
        lblTime3.Text = ""
        lblTime3.ForeColor = Color.Black
        lblTime4.Text = ""
        lblTime4.ForeColor = Color.Black
        lblTime5.Text = ""
        lblTime5.ForeColor = Color.Black
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        btnStart.Enabled = False
        btnEnd.Enabled = False
        btnExtend.Enabled = False
        btnReduce.Enabled = False
        btnCancel.Enabled = False
        btnReActivate.Enabled = False
    End Sub

    Private Sub LoadTest()
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandText = "SELECT BlockName, BlockType, BlockSchedStartTime, BlockSchedDuration FROM Blocks"

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLRead = SQLCmd.ExecuteReader

        If SQLRead.HasRows Then
            While SQLRead.Read
                Dim xxx As String = (SQLRead("BlockName") & " " & SQLRead("BlockSchedStartTime") & " " & SQLRead("BlockSchedDuration"))
                MsgBox(xxx)
            End While
        End If

        SQLConn.Close()

    End Sub


    Private Sub loadBlockID()
        initialState()
        blnBigBlock = False
        blnRegBlock = False
        blnSupBlock = False

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandText = "uspSelectAvailableBlocks"

        'SQLCmd.CommandText = "SELECT DISTINCT(Items.ItemBlockID), Items.ItemAuctionStatus, Items.ItemDateDonated, " & _
        '                           "Blocks.BlockName, Blocks.BlockType, Blocks.BlockSchedStartTime, Blocks.BlockSchedDuration " & _
        '                           "FROM Items INNER JOIN Blocks ON Items.ItemBlockID = Blocks.BlockID " & _
        '                          "ORDER BY Items.ItemBlockID"

        SQLCmd.CommandType = CommandType.StoredProcedure

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Dim intCount As Integer = 1
        Dim intCountPos As Integer = 0
        Dim intCountPosDone As Integer = 0

        Try
            'clear all item in list box
            lbNotActive.Items.Clear()
            lbInProgress.Items.Clear()
            lbDone.Items.Clear()

            'Dim intDuration As Date
            Dim intDuration As Integer = 0

            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader

            'put record into listbox
            If SQLRead.HasRows Then
                While SQLRead.Read
                    'If SQLRead("ItemDateDonated") > Main.dateLastYear Then
                    If SQLRead("ItemAuctionStatus") = 1 Then
                        strBlockInfo(intCountPos, 0) = SQLRead("BlockName").ToString
                        strBlockInfo(intCountPos, 1) = SQLRead("BlockType").ToString
                        lbNotActive.Items.Add(SQLRead("BlockName").ToString)
                        intCountPos += 1
                    ElseIf SQLRead("ItemAuctionStatus") = 2 Then
                        Dim strStartTime As Date = SQLRead("BlockSchedStartTime")
                        If Not IsDBNull(SQLRead("BlockSchedDuration")) Then
                            intDuration = SQLRead("BlockSchedDuration")
                        Else : intDuration = 10
                        End If
                        Dim strEndTimeLB As Date = DateAdd(DateInterval.Second, (intDuration * 60), strStartTime)
                        '
                        setTimer(intCount, strEndTimeLB, intDuration)
                        '
                        startTimer(intCount)
                        lbInProgress.Items.Add(SQLRead("BlockName").ToString)
                        Select Case SQLRead("BlockType").ToString
                            Case "RR"
                                blnRegBlock = True
                            Case "BB"
                                blnBigBlock = True
                            Case "SU"
                                blnSupBlock = True
                        End Select
                        intCount += 1
                    ElseIf SQLRead("ItemAuctionStatus") = 3 Then
                        lbDone.Items.Add(SQLRead("BlockName").ToString)
                        strBlockInfoDone(intCountPosDone, 0) = SQLRead("BlockName").ToString
                        strBlockInfoDone(intCountPosDone, 1) = SQLRead("BlockType").ToString
                        intCountPosDone += 1
                    End If
                    'End If
                End While
            End If
            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue:: Unable to connect to the database"
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub setTimer(ByVal count As Integer, ByVal strTime As String, ByVal duration As Integer)
        Select Case count
            Case 1
                strEndTime1 = strTime
                intDuration1 = duration
            Case 2
                strEndTime2 = strTime
                intDuration2 = duration
            Case 3
                strEndTime3 = strTime
                intDuration3 = duration
            Case 4
                strEndTime4 = strTime
                intDuration4 = duration
            Case 5
                strEndTime5 = strTime
                intDuration5 = duration
        End Select
    End Sub

    Private Sub startTimer(ByVal count As Integer)
        Select Case count
            Case 1
                Timer1.Start()
            Case 2
                Timer2.Start()
            Case 3
                Timer3.Start()
            Case 4
                Timer4.Start()
            Case 5
                Timer5.Start()
        End Select
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If lbNotActive.SelectedItem <> "" Then
            setBlockStartTime()
            changeBlockStatus(2)
            clearMessageBox()
        Else
            lblMessageBox.Text = "Please select a Block in the -Not Yet Started- list box to Start"
        End If
        If lbInProgress.Items.Count > 3 Then
            btnStart.Enabled = False
        End If
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If lbInProgress.SelectedItem <> "" Then
            changeBlockStatus(3)
            clearMessageBox()
        Else
            lblMessageBox.Text = "Please select a Block in the -In Progress- list box to End"
        End If
        If lbInProgress.Items.Count < 3 Then
            btnStart.Enabled = True
        End If
    End Sub

    Private Sub clearMessageBox()
        lblMessageBox.Text = ""
    End Sub

    Private Sub setBlockStartTime()

        Dim strTime As String = Main.getServerTime
        Dim strBlockName As String = lbNotActive.SelectedItem

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandText = "UPDATE Blocks SET BlockSchedStartTime = '" & strTime & "'" & _
                                    "WHERE BlockAuctionYear = YEAR(dbo.ufnNextAuctionDate()) AND  BlockName = '" & strBlockName & "'"

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try

    End Sub

    Private Sub changeBlockStatus(ByVal intStatusCode As Integer)

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        If intStatusCode = 2 Then
            'change blockStatusCode to 2 = In progress
            SQLCmd.CommandText = "UPDATE Items SET ItemAuctionStatus = '2'" & _
                                "WHERE ItemBlockID = (SELECT BlockID FROM Blocks WHERE BlockAuctionYear = YEAR(dbo.ufnNextAuctionDate()) AND BlockName = '" & lbNotActive.SelectedItem.ToString & "');"
        End If
        If intStatusCode = 3 Then
            'change blockStatusCode to 3 = Done
            SQLCmd.CommandText = "UPDATE Items SET ItemAuctionStatus = '3'" & _
                                "WHERE ItemBlockID = (SELECT BlockID FROM Blocks WHERE BlockAuctionYear = YEAR(dbo.ufnNextAuctionDate()) AND BlockName = '" & lbInProgress.SelectedItem.ToString & "');"

        End If
        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
            loadBlockID()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub lblAvailableBlock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If strEndTime1 < Main.getServerTime Then
            Timer1.Stop()
            lblTime1.Text = "00:00:00"
            btnExtend.Enabled = False
            btnReduce.Enabled = False
        Else
            Dim timeDiff As TimeSpan = strEndTime1.Subtract(Main.getServerTime)
            lblTime1.Text = Format(timeDiff.Hours, "00") & ":" & Format(timeDiff.Minutes, "00") & ":" & Format(timeDiff.Seconds, "00")
            If lblTime1.Text = "00:00:00" Then
                Timer1.Stop()
                lbInProgress.SelectedIndex = 0
                changeBlockStatus(3)
                btnExtend.Enabled = False
                btnReduce.Enabled = False
                btnEnd.Enabled = False
            End If
            If lblTime1.Text = "00:00:10" Then
                lblTime1.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If strEndTime2 < Main.getServerTime Then
            Timer2.Stop()
            lblTime2.Text = "00:00:00"
            btnExtend.Enabled = False
            btnReduce.Enabled = False
        Else
            Dim timeDiff As TimeSpan = strEndTime2.Subtract(Main.getServerTime)
            lblTime2.Text = Format(timeDiff.Hours, "00") & ":" & Format(timeDiff.Minutes, "00") & ":" & Format(timeDiff.Seconds, "00")
            If lblTime2.Text = "00:00:00" Then
                Timer2.Stop()
                lbInProgress.SelectedIndex = 1
                changeBlockStatus(3)
                btnExtend.Enabled = False
                btnReduce.Enabled = False
                btnEnd.Enabled = False
            End If
            If lblTime2.Text = "00:00:10" Then
                lblTime2.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If strEndTime3 < Main.getServerTime Then
            Timer3.Stop()
            lblTime3.Text = "00:00:00"
            btnExtend.Enabled = False
            btnReduce.Enabled = False
        Else
            Dim timeDiff As TimeSpan = strEndTime3.Subtract(Main.getServerTime)
            lblTime3.Text = Format(timeDiff.Hours, "00") & ":" & Format(timeDiff.Minutes, "00") & ":" & Format(timeDiff.Seconds, "00")
            If lblTime3.Text = "00:00:00" Then
                Timer3.Stop()
                lbInProgress.SelectedIndex = 2
                changeBlockStatus(3)
                btnExtend.Enabled = False
                btnReduce.Enabled = False
                btnEnd.Enabled = False
            End If
            If lblTime3.Text = "00:00:10" Then
                lblTime3.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If strEndTime4 < Main.getServerTime Then
            Timer4.Stop()
            lblTime4.Text = "00:00:00"
            btnExtend.Enabled = False
            btnReduce.Enabled = False
        Else
            Dim timeDiff As TimeSpan = strEndTime4.Subtract(Main.getServerTime)
            lblTime4.Text = Format(timeDiff.Hours, "00") & ":" & Format(timeDiff.Minutes, "00") & ":" & Format(timeDiff.Seconds, "00")
            If lblTime4.Text = "00:00:00" Then
                Timer4.Stop()
                lbInProgress.SelectedIndex = 3
                changeBlockStatus(3)
                btnExtend.Enabled = False
                btnReduce.Enabled = False
                btnEnd.Enabled = False
            End If
            If lblTime4.Text = "00:00:10" Then
                lblTime4.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If strEndTime5 < Main.getServerTime Then
            Timer5.Stop()
            lblTime5.Text = "00:00:00"
            btnExtend.Enabled = False
            btnReduce.Enabled = False
        Else
            Dim timeDiff As TimeSpan = strEndTime5.Subtract(Main.getServerTime)
            lblTime5.Text = Format(timeDiff.Hours, "00") & ":" & Format(timeDiff.Minutes, "00") & ":" & Format(timeDiff.Seconds, "00")
            If lblTime5.Text = "00:00:00" Then
                Timer5.Stop()
                lbInProgress.SelectedIndex = 4
                changeBlockStatus(3)
                btnExtend.Enabled = False
                btnReduce.Enabled = False
                btnEnd.Enabled = False
            End If
            If lblTime5.Text = "00:00:10" Then
                lblTime5.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub lbNotActive_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbNotActive.SelectedIndexChanged
        If lbNotActive.SelectedItem.ToString <> "" Then
            Select Case strBlockInfo(lbNotActive.SelectedIndex, 1)
                Case "RR"
                    If blnRegBlock Then
                        btnStart.Enabled = False
                    Else : btnStart.Enabled = True
                    End If
                Case "BB"
                    If blnBigBlock Then
                        btnStart.Enabled = False
                    Else : btnStart.Enabled = True
                    End If
                Case "SU"
                    If blnSupBlock Then
                        btnStart.Enabled = False
                    Else : btnStart.Enabled = True
                    End If
            End Select
        End If
    End Sub

    Private Sub lbInProgress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbInProgress.SelectedIndexChanged
        Select Case lbInProgress.SelectedIndex
            Case 0
                If lblTime1.Text = "00:00:00" Then
                    timeRemainGreaterThanZero()
                Else : timeRemainLessThanZero()
                End If
            Case 1
                If lblTime2.Text = "00:00:00" Then
                    timeRemainGreaterThanZero()
                Else : timeRemainLessThanZero()
                End If
            Case 2
                If lblTime3.Text = "00:00:00" Then
                    timeRemainGreaterThanZero()
                Else : timeRemainLessThanZero()
                End If
            Case 3
                If lblTime4.Text = "00:00:00" Then
                    timeRemainGreaterThanZero()
                Else : timeRemainLessThanZero()
                End If
            Case 4
                If lblTime5.Text = "00:00:00" Then
                    timeRemainGreaterThanZero()
                Else : timeRemainLessThanZero()
                End If
        End Select
        If lbInProgress.SelectedItem <> "" Then
            btnCancel.Enabled = True
        Else
            btnCancel.Enabled = False
        End If
    End Sub

    Private Sub timeRemainGreaterThanZero()
        btnEnd.Enabled = True
        btnExtend.Enabled = False
        btnReduce.Enabled = False
    End Sub

    Private Sub timeRemainLessThanZero()
        btnEnd.Enabled = False
        btnExtend.Enabled = True
        btnReduce.Enabled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandText = "UPDATE Items SET ItemAuctionStatus = '1'" & _
                            "WHERE ItemBlockID = (SELECT BlockID FROM Blocks WHERE BlockAuctionYear = YEAR(dbo.ufnNextAuctionDate()) AND BlockName = '" & lbInProgress.SelectedItem.ToString & "')"

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
            loadBlockID()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub btnExtend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtend.Click

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Dim strExtentMin As String = InputBox("Enter the amount of time to extend in minutes." & vbCrLf & "" & vbCrLf & _
                                              "*** Use whole numbers for minutes ***", "Extend Block Bidding Time")
        If IsNumeric(strExtentMin) Then
            Dim intMin As Integer = strExtentMin
            If intMin > 0 Then
                SQLCmd.CommandType = System.Data.CommandType.Text
                SQLCmd.CommandText = "UPDATE Blocks SET BlockSchedDuration = BlockSchedDuration + " & intMin & _
                                            "WHERE BlockName = '" & lbInProgress.SelectedItem.ToString & "'"
                Try
                    SQLConn.Open()
                    SQLCmd.ExecuteNonQuery()
                    SQLConn.Close()
                    loadBlockID()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    If SQLConn.State <> ConnectionState.Open Then
                        SQLConn.Close()
                    End If
                    SQLCmd.Dispose()
                End Try
            End If
        End If
    End Sub

    Private Sub btnReActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReActivate.Click

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        SQLCmd.CommandText = "UPDATE Items SET ItemAuctionStatus = '2' WHERE ItemBlockID = " & _
                                   "(SELECT BlockID FROM Blocks WHERE BlockAuctionYear = YEAR(dbo.ufnNextAuctionDate()) AND BlockName = '" & lbDone.SelectedItem.ToString & "');"

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
            loadBlockID()
            btnReActivate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub lbDone_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDone.SelectedIndexChanged
        If lbDone.SelectedItem <> "" Then
            Select Case strBlockInfoDone(lbDone.SelectedIndex, 1)
                Case "RR"
                    If blnRegBlock Then
                        btnReActivate.Enabled = False
                    Else : btnReActivate.Enabled = True
                    End If
                Case "BB"
                    If blnBigBlock Then
                        btnReActivate.Enabled = False
                    Else : btnReActivate.Enabled = True
                    End If
                Case "SU"
                    If blnSupBlock Then
                        btnReActivate.Enabled = False
                    Else : btnReActivate.Enabled = True
                    End If
            End Select
        End If
    End Sub

    Private Sub btnReduce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReduce.Click

        Dim strExtentMin As String = InputBox("Enter the amount of time to reduce in minutes." & vbCrLf & "" & vbCrLf & _
                                                      "*** Use whole numbers for minutes ***", "Reduce Block Bidding Time")

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        If IsNumeric(strExtentMin) Then
            Dim intMin As Integer = (strExtentMin - (strExtentMin * 2))
            If intMin < 0 Then
                Dim intHrRemain, intMinRemain, intSecRemain As Integer
                Dim tmpString As String
                Select Case lbInProgress.SelectedIndex
                    Case 0
                        tmpString = lblTime1.Text
                        intHrRemain = tmpString.Remove(2, 6) * 3600
                        intMinRemain = tmpString.Remove(0, 3).Remove(2, 3) * 60
                        intSecRemain = tmpString.Remove(0, 6)
                    Case 1
                        tmpString = lblTime2.Text
                        intHrRemain = tmpString.Remove(2, 6) * 3600
                        intMinRemain = tmpString.Remove(0, 3).Remove(2, 3) * 60
                        intSecRemain = tmpString.Remove(0, 6)
                    Case 2
                        tmpString = lblTime3.Text
                        intHrRemain = tmpString.Remove(2, 6) * 3600
                        intMinRemain = tmpString.Remove(0, 3).Remove(2, 3) * 60
                        intSecRemain = tmpString.Remove(0, 6)
                    Case 3
                        tmpString = lblTime4.Text
                        intHrRemain = tmpString.Remove(2, 6) * 3600
                        intMinRemain = tmpString.Remove(0, 3).Remove(2, 3) * 60
                        intSecRemain = tmpString.Remove(0, 6)
                    Case 4
                        tmpString = lblTime5.Text
                        intHrRemain = tmpString.Remove(2, 6) * 3600
                        intMinRemain = tmpString.Remove(0, 3).Remove(2, 3) * 60
                        intSecRemain = tmpString.Remove(0, 6)
                End Select
                If intMin * -60 < (intHrRemain + intMinRemain + intSecRemain) Then
                    SQLCmd.CommandType = System.Data.CommandType.Text
                    SQLCmd.CommandText = "UPDATE Blocks SET BlockSchedDuration = BlockSchedDuration + " & intMin & _
                                                "WHERE BlockAuctionYear = YEAR(dbo.ufnNextAuctionDate()) AND BlockName = '" & lbInProgress.SelectedItem.ToString & "'"

                    Try
                        SQLConn.Open()
                        SQLCmd.ExecuteNonQuery()
                        SQLConn.Close()
                        loadBlockID()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    Finally
                        If SQLConn.State <> ConnectionState.Open Then
                            SQLConn.Close()
                        End If
                        SQLCmd.Dispose()
                    End Try
                End If
            End If
        End If
    End Sub

End Class