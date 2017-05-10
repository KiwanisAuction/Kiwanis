Imports System.Data.SqlClient

Public Class AssignItemToBlock

    ' Database connection and query globals
    Public arItem(99999, 4) As String
    Public arItem2(99999, 4) As String

    Public Conn_CMD As String = KDBConnect.loadKDMConnect

    Private Sub getBlockID()
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspSelectBlocksCurrentAuction"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader()

            If SQLRead.HasRows = True Then
                While SQLRead.Read
                    cbBlockID.Items.Add(SQLRead("BlockID"))
                    cbBlockName.Items.Add(SQLRead("BlockName"))
                End While
            End If

            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to access the database."
            MessageBox.Show(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub loadItem()
        lbItemAssigned.Items.Clear()
        lbItemAvail.Items.Clear()

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandText = "SELECT ItemID, ItemDesc, ItemBlockPos, ItemBlockID FROM Items WHERE ItemDateDonated = dbo.ufnNextAuctionDate()"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader()

            If SQLRead.HasRows = True Then
                Dim intItemID, intCount, intCount2 As Integer
                Dim strItemPos As String

                'clear ItemPos in comboBox
                cb1.SelectedItem = ""
                cb2.SelectedItem = ""
                cb3.SelectedItem = ""
                cb4.SelectedItem = ""
                cb5.SelectedItem = ""
                cb6.SelectedItem = ""
                cb7.SelectedItem = ""
                cb8.SelectedItem = ""
                cb9.SelectedItem = ""
                cb10.SelectedItem = ""
                cb11.SelectedItem = ""

                While SQLRead.Read
                    If SQLRead("ItemBlockID").ToString = cbBlockID.SelectedItem.ToString Then

                        arItem(intCount, 0) = SQLRead("ItemID").ToString
                        arItem(intCount, 1) = SQLRead("ItemDesc").ToString
                        arItem(intCount, 2) = SQLRead("ItemBlockPos").ToString
                        arItem(intCount, 3) = SQLRead("ItemBlockID").ToString

                        lbItemAssigned.Items.Add(SQLRead("ItemID") & " - " & SQLRead("ItemDesc"))

                        intItemID = SQLRead("ItemID")
                        strItemPos = SQLRead("ItemBlockPos").ToString

                        'lbItemAssigned.Items.Add(intItemID)
                        Select Case intCount
                            Case 0
                                cb1.SelectedItem = strItemPos
                            Case 1
                                cb2.SelectedItem = strItemPos
                            Case 2
                                cb3.SelectedItem = strItemPos
                            Case 3
                                cb4.SelectedItem = strItemPos
                            Case 4
                                cb5.SelectedItem = strItemPos
                            Case 5
                                cb6.SelectedItem = strItemPos
                            Case 6
                                cb7.SelectedItem = strItemPos
                            Case 7
                                cb8.SelectedItem = strItemPos
                            Case 8
                                cb9.SelectedItem = strItemPos
                            Case 9
                                cb10.SelectedItem = strItemPos
                            Case 10
                                cb11.SelectedItem = strItemPos
                        End Select

                        intCount += 1

                    ElseIf SQLRead("ItemBlockID").ToString.ToUpper = "" Then

                        arItem2(intCount2, 0) = SQLRead("ItemID").ToString
                        arItem2(intCount2, 1) = SQLRead("ItemDesc").ToString
                        arItem2(intCount2, 2) = SQLRead("ItemBlockPos").ToString
                        arItem2(intCount2, 3) = SQLRead("ItemBlockID").ToString

                        lbItemAvail.Items.Add(SQLRead("ItemID") & " - " & SQLRead("ItemDesc"))

                        intCount2 += 1
                    End If

                End While
                intCount = 0
                intCount2 = 0
                AvailPos_lbl.Text = AvailablePosition().ToString
            End If
            SQLConn.Close()
            AssignedBlockID_lbl.Text = cbBlockName.SelectedItem.ToString
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to access the database."
            MessageBox.Show(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Main.Visible = True
        Me.Close()
    End Sub

    Private Sub AssignItemToBlock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call getBlockID()
        AssignedBlockID_lbl.Text = ""
        AvailPos_lbl.Text = ""
    End Sub

    Private Sub cbBlockID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBlockID.SelectedIndexChanged
        cbBlockName.SelectedIndex = cbBlockID.SelectedIndex
        Call loadItem()
        If lbItemAssigned.Items.Count >= 11 Then
            btnAssignItem.Enabled = False
        ElseIf lbItemAssigned.Items.Count < 11 Then
            btnAssignItem.Enabled = True
        End If
    End Sub

    Private Sub cbBlockName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBlockName.SelectedIndexChanged
        cbBlockID.SelectedIndex = cbBlockName.SelectedIndex
    End Sub

    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        If lbItemAssigned.SelectedIndex < 0 Then
            lblMessageBox.Text = "Please select an ITEM in the -Current Assigned Items- box to REMOVE."
        Else
            Dim RemoveItemID As Integer
            Dim ItemID As Integer = lbItemAssigned.SelectedIndex
            RemoveItemID = arItem(ItemID, 0)
            Call removeBlockIDfromItem(RemoveItemID)
            loadItem()
        End If
    End Sub

    Private Sub removeBlockIDfromItem(ByVal ID As String)

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandText = "UPDATE Items SET ItemBlockID = NULL, ItemBlockPos = NULL WHERE ItemID = '" & ID & "'"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
            Call loadItem()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to access the database."
            MessageBox.Show(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub btnAssignItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignItem.Click
        If lbItemAvail.SelectedIndex < 0 Then
            lblMessageBox.Text = "Please select an ITEM in the -Available Items- box to ASSIGN to a block."
        Else
            Dim AddItemID As Integer
            Dim ItemID As Integer = lbItemAvail.SelectedIndex
            AddItemID = arItem2(ItemID, 0)
            assignItemToBlock(AddItemID)
            loadItem()
        End If
    End Sub

    Private Sub assignItemToBlock(ByVal ID As String)

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandText = "UPDATE Items SET ItemBlockID = '" & cbBlockID.SelectedItem.ToString & "'," & _
                                            "ItemBlockPos = NULL WHERE ItemID = '" & ID & "'"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
            Call loadItem()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to access the database."
            MessageBox.Show(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub btnSaveNewPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNewPos.Click

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        If checkPosConflict() = True Then
            lblMessageBox.Text = "Unsuccessful Update :: Conflict with the Item Position."
        Else

            lblMessageBox.Text = ""
            Dim strItemID As String = ""
            Dim strItemPos As String = ""
            Try
                SQLConn.Open()

                For intCount = 0 To lbItemAssigned.Items.Count - 1
                    Select Case intCount
                        Case 0
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb1.SelectedItem
                        Case 1
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb2.SelectedItem
                        Case 2
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb3.SelectedItem
                        Case 3
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb4.SelectedItem
                        Case 4
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb5.SelectedItem
                        Case 5
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb6.SelectedItem
                        Case 6
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb7.SelectedItem
                        Case 7
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb8.SelectedItem
                        Case 8
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb9.SelectedItem
                        Case 9
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb10.SelectedItem
                        Case 10
                            strItemID = arItem(intCount, 0)
                            strItemPos = cb11.SelectedItem
                    End Select

                    SQLCmd.CommandText = "UPDATE Items SET ItemBlockPos = '" & strItemPos & "' WHERE ItemID = '" & strItemID & "'"
                    SQLCmd.ExecuteNonQuery()
                Next
                SQLConn.Close()
                loadItem()
            Catch ex As Exception
                lblMessageBox.Text = "Connection Issue:: Unable to access the database"
                MessageBox.Show(ex.Message)
            Finally
                If SQLConn.State <> ConnectionState.Closed Then
                    SQLConn.Close()
                End If
                SQLCmd.Dispose()
            End Try
        End If

    End Sub

    Private Function checkPosConflict()

        Dim blnConflict As Boolean = False
        Dim firstOccur As Boolean = False
        Dim intPos As String = ""

        For intCount = 1 To 11
            Dim number As String = intCount.ToString
            firstOccur = False
            For intCount2 = 1 To lbItemAssigned.Items.Count
                Select Case intCount2
                    Case 1
                        intPos = cb1.SelectedItem
                    Case 2
                        intPos = cb2.Text
                    Case 3
                        intPos = cb3.Text
                    Case 4
                        intPos = cb4.Text
                    Case 5
                        intPos = cb5.Text
                    Case 6
                        intPos = cb6.Text
                    Case 7
                        intPos = cb7.Text
                    Case 8
                        intPos = cb8.Text
                    Case 9
                        intPos = cb9.Text
                    Case 10
                        intPos = cb10.Text
                    Case 11
                        intPos = cb11.Text
                End Select
                If intPos = number And firstOccur = False Then
                    firstOccur = True
                ElseIf intPos = number And firstOccur = True Then
                    blnConflict = True
                    Exit For
                End If
            Next
            If blnConflict Then
                Exit For
            End If
        Next
        Return blnConflict
    End Function

    Private Function AvailablePosition() As String
        Dim AP As String = ""
        Dim i As Integer = 0
        If AssignedBlockID_lbl.Text = "CASH DONATIONS" Then
            AP = "Item postions are not required for cash donations."
        Else
            While i < 11
                If cb1.SelectedItem <> i.ToString And cb2.SelectedItem <> i.ToString And cb3.SelectedItem <> i.ToString And cb4.SelectedItem <> i.ToString And cb5.SelectedItem <> i.ToString And cb6.SelectedItem <> i.ToString And cb7.SelectedItem <> i.ToString And cb8.SelectedItem <> i.ToString And cb9.SelectedItem <> i.ToString And cb10.SelectedItem <> i.ToString And cb11.SelectedItem <> i.ToString Then
                    AP += i & " "
                End If
                i += 1
            End While
            i = 0
            If AP = "" Then
                AP = "ALL item postions are currently allocated."
            End If
        End If
        Return AP
    End Function

    Private Sub cb11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb11.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb10.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb9.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb8.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb7.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb6.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb5.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb4.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb3.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub
    Private Sub cb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.SelectedIndexChanged
        AvailPos_lbl.Text = AvailablePosition().ToString
    End Sub

End Class