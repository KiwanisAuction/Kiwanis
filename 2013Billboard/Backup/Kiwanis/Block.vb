Imports System
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class Block

    Public arBlock(9999, 5) As String
    Public Conn_CMD As String = KDBConnect.loadKDMConnect

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Main.Visible = True
        Me.Close()
    End Sub

    Private Sub txtBlockName_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBlockName.Enter
        lblMessageBox.Text = ""
    End Sub

    Private Sub txtBlockName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBlockName.TextChanged
        If txtBlockName.TextLength > 0 Then
            cbBlockType.Enabled = True
        End If
    End Sub

    Private Sub cbBlockType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBlockType.SelectedIndexChanged
        If cbBlockType.SelectedItem <> "" Then
            txtBlockDesc.Enabled = True
            txtBlockAuctoneer.Enabled = True
        End If
    End Sub

    'Private Sub txtBlockDesc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBlockDesc.Enter
    '    txtBlockDesc.Clear()
    'End Sub

    Private Sub getSponsorID()

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspSelectDonorActive"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader

            If SQLRead.HasRows Then
                While SQLRead.Read
                    Dim intSponsorID = SQLRead("DonorID")
                    cbSponsorID.Items.Add(intSponsorID)
                End While
            End If
            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to retrieve Donor ID -Sponsor ID-."
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try

    End Sub

    Private Sub txtBlockAuctoneer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBlockAuctoneer.TextChanged
        If txtBlockAuctoneer.TextLength > 0 Then
            cbSponsorID.Enabled = True
            If btnCommit.Text = "Save" Then
                btnCommitDelete.Enabled = True
                btnCommit.Enabled = True
            End If
        Else
            cbSponsorID.Enabled = False
            btnCommit.Enabled = False
            btnCommitDelete.Enabled = False
        End If
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If btnCommit.Text = "Add" Then
            cmdCommit("Add")
        ElseIf btnCommit.Text = "Save" Then
            cmdCommit("Save")
        End If
    End Sub

    Private Sub cmdCommit(ByVal strCmd As String)

        Dim strBlockName As String = txtBlockName.Text
        Dim strBlockType As String = cbBlockType.SelectedItem
        Dim strBlockTypeDesc As String = txtBlockDesc.Text
        Dim strBlockAuctioneer As String = txtBlockAuctoneer.Text
        Dim strSponsorID As String = cbSponsorID.SelectedItem.ToString

        Dim blnOkToCommit As Boolean = False

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Select Case strCmd
            Case "Add"      'Add new block
                SQLCmd.CommandText = "SELECT BlockName FROM Blocks WHERE " & _
                                        "BlockName = '" & strBlockName & "'"

                SQLConn.Open()
                SQLRead = SQLCmd.ExecuteReader
                If SQLRead.HasRows Then 'check for duplicate record
                    If MessageBox.Show("One or more record of similar names existed in the database." & vbCrLf & _
                                       "Do you want to add new Block anyway?", "Existing Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        SQLConn.Close()
                        blnOkToCommit = True 'no duplicate present. ok to commit
                    Else : blnOkToCommit = False 'duplicate present. no commit
                    End If
                Else : SQLConn.Close()
                    blnOkToCommit = True
                End If

                If blnOkToCommit = True Then
                    SQLCmd.CommandText = "INSERT INTO Blocks (BlockName, BlockType, BlockTypeDesc, BlockAuctioneer, BlockSponsorID)" & _
                                                                "VALUES ('" & strBlockName & "', '" & strBlockType & "', '" & strBlockTypeDesc & _
                                                                "' ,'" & strBlockAuctioneer & "' ," & strSponsorID & ")"
                    Try
                        SQLConn.Open()
                        SQLCmd.ExecuteNonQuery()
                        SQLConn.Close()
                        initialState()
                        lblMessageBox.Text = "New Block added to the database"
                    Catch ex As Exception
                        lblMessageBox.Text = "Connection Issue:: Unable to access the database. Try again later"
                        MessageBox.Show(ex.ToString)
                    End Try
                End If


            Case "Save"     'Save changes made to current block
                SQLCmd.CommandText = "UPDATE Blocks SET " & _
                                            "BlockName = '" & strBlockName & "'," & _
                                            "BlockType = '" & strBlockType & "'," & _
                                            "BlockTypeDesc = '" & strBlockTypeDesc & "'," & _
                                            "BlockAuctioneer = '" & strBlockAuctioneer & "'," & _
                                            "BlockSponsorID = '" & strSponsorID & "'" & _
                                        "WHERE BlockID = '" & cbBlockID.SelectedItem & "'"
                Try
                    SQLConn.Open()
                    SQLCmd.ExecuteNonQuery()
                    SQLConn.Close()
                    lblMessageBox.Text = "Record Updated"
                Catch ex As Exception
                    lblMessageBox.Text = "Connection Issue :: Unable to access the database."
                    MessageBox.Show(ex.ToString)
                Finally
                    If SQLConn.State <> ConnectionState.Open Then
                        SQLConn.Close()
                    End If
                    SQLCmd.Dispose()
                End Try

            Case "Delete"   'Delete current block
                SQLCmd.CommandText = "SELECT ItemBlockID FROM Items WHERE " & _
                                        "ItemBlockID = '" & cbBlockID.SelectedItem & "'"

                SQLConn.Open()
                SQLRead = SQLCmd.ExecuteReader
                If SQLRead.HasRows Then 'check for duplicate record
                    MessageBox.Show("One or more Item associated with Block." & vbCrLf & _
                                        "Unable to delete Block.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SQLConn.Close()
                    blnOkToCommit = False 'duplicate present. no commit
                Else : SQLConn.Close()
                    blnOkToCommit = True
                End If
                If blnOkToCommit = True Then
                    SQLCmd.CommandText = "DELETE FROM Blocks WHERE BlockID = '" & cbBlockID.SelectedItem & "'"

                    Try
                        SQLConn.Open()
                        SQLCmd.ExecuteNonQuery()
                        SQLConn.Close()

                        loadBlockID()
                        initialState()
                        lblMessageBox.Text = "Record Deleted"
                    Catch ex As Exception
                        lblMessageBox.Text = "Connection Issue :: Unable to access the database."
                        MessageBox.Show(ex.ToString)
                    Finally
                        If SQLConn.State <> ConnectionState.Open Then
                            SQLConn.Close()
                        End If
                        SQLCmd.Dispose()
                    End Try
                End If

        End Select
    End Sub

    Private Sub cbSponsorID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSponsorID.SelectedIndexChanged
        If cbSponsorID.SelectedItem.ToString <> "" Then
            btnCommit.Enabled = True
        End If
    End Sub

    Private Sub initialState()
        cbBlockID.Items.Clear()
        cbBlockID.Text = ""
        cbBlockID.Enabled = False
        txtBlockName.Clear()
        txtBlockName.Enabled = False
        cbBlockType.Enabled = False
        cbBlockType.Text = ""
        txtBlockDesc.Enabled = False
        txtBlockDesc.Text = "200 characters max"
        txtBlockAuctoneer.Enabled = False
        txtBlockAuctoneer.Clear()
        cbSponsorID.Enabled = False
        cbSponsorID.Text = ""
        pnlSetTime.Visible = False
        cbBlockType2.Text = ""
        txtDuration.Clear()
        btnCommit.Enabled = False
        btnCommitDelete.Enabled = False
    End Sub

    Private Sub Block_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getSponsorID()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        initialState()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSetBlockTime.Enabled = True

        btnCommit.Text = "Save"
        BlockFrmStatus_lbl.Text = " EDIT BLOCK"

        btnCommitDelete.Visible = True
        cbBlockID.Enabled = True

        loadBlockID()
    End Sub

    Private Sub loadBlockID()

        cbBlockID.Items.Clear()

        Dim strBlockID, strBlockName, strBlockType, strBlockTypeDes, strBlockAuctioneer, strBlockSponsorID As String

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspSelectBlocksCurrentAuction"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader
            If SQLRead.HasRows Then
                Dim intCount As Integer = 0

                While SQLRead.Read
                    strBlockID = SQLRead("BlockID").ToString
                    strBlockName = SQLRead("Blockname").ToString
                    strBlockType = SQLRead("BlockType").ToString
                    strBlockTypeDes = SQLRead("BlockTypeDesc").ToString
                    strBlockAuctioneer = SQLRead("BlockAuctioneer").ToString
                    strBlockSponsorID = SQLRead("BlockSponsorID").ToString
                    cbBlockID.Items.Add(strBlockID)

                    arBlock(intCount, 0) = strBlockID
                    arBlock(intCount, 1) = strBlockName
                    arBlock(intCount, 2) = strBlockType
                    arBlock(intCount, 3) = strBlockTypeDes
                    arBlock(intCount, 4) = strBlockAuctioneer
                    arBlock(intCount, 5) = strBlockSponsorID

                    intCount += 1

                End While
            End If
            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue:: Unable to access the database. Try again later"
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub cbBlockID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBlockID.SelectedIndexChanged
        Dim intPos As Integer = cbBlockID.SelectedIndex

        If cbBlockID.SelectedItem.ToString <> "" Then
            btnCommit.Enabled = True
            btnCommitDelete.Enabled = True
            txtBlockName.Enabled = True
            txtBlockName.Text = arBlock(intPos, 1)
            cbBlockType.Enabled = True
            cbBlockType.Text = arBlock(intPos, 2).ToString
            txtBlockDesc.Enabled = True
            txtBlockDesc.Text = arBlock(intPos, 3)
            txtBlockAuctoneer.Enabled = True
            txtBlockAuctoneer.Text = arBlock(intPos, 4)
            'cbSponsorID.Enabled = True
            cbSponsorID.Text = arBlock(intPos, 5).ToString
        Else
            btnCommit.Enabled = True
            btnCommitDelete.Enabled = True
        End If

    End Sub

    Private Sub btnCommitDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommitDelete.Click
        cmdCommit("Delete")
    End Sub


    Private Sub btnSetBlockTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetBlockTime.Click
        initialState()

        BlockFrmStatus_lbl.Text = " SET BLOCK TIME"

        pnlSetTime.Visible = True

        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnSetBlockTime.Enabled = False
        cbBlockID.Enabled = False

        loadBlockType()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        initialState()
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnSetBlockTime.Enabled = True

        btnCommit.Text = "Add"
        BlockFrmStatus_lbl.Text = " ADD BLOCK"

        txtBlockName.Enabled = True

    End Sub

    Private Sub cbBlockType2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBlockType2.SelectedIndexChanged
        If cbBlockType2.SelectedItem.ToString <> "" Then
            txtDuration.Enabled = True
        Else
            txtDuration.Enabled = False
        End If
    End Sub

    Private Sub txtDuration_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDuration.TextChanged
        If txtDuration.TextLength > 0 And IsNumeric(txtDuration.Text) = True Then
            btnSaveDuration.Enabled = True
        Else
            btnSaveDuration.Enabled = False
        End If
    End Sub

    Private Sub btnSaveDuration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDuration.Click
        setDurationTime()
    End Sub

    Private Sub setDurationTime()

        Dim strBlockType As String = cbBlockType2.SelectedItem
        Dim strDuration As String = txtDuration.Text

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandText = "UPDATE Blocks SET BlockSchedDuration = '" & strDuration & "'" & _
                                    "FROM Blocks WHERE BlockType = '" & strBlockType & "'"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
            cbBlockType2.Text = ""
            txtDuration.Text = ""
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue: Unable to access the database. Try again later"
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub loadBlockType()

        cbBlockType2.Items.Clear()

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandText = "SELECT DISTINCT BlockType FROM Blocks ORDER BY BlockType"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader
            If SQLRead.HasRows Then
                While SQLRead.Read
                    cbBlockType2.Items.Add(SQLRead("BlockType"))
                End While
            End If
            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue:: Unable to access the database. Try again later"
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try

    End Sub
End Class