Imports System.Data
Imports System.Data.SqlClient

Public Class Item

    Public arItem(99999, 14) As String

    Public DBConnectionString As String = KiwanisConfig.LoadDatabaseConfig
    'Public DBConnectionString As String = "Data Source=kiwanisauction01.db.6809554.hostedresource.com; Initial Catalog=kiwanisauction01; User ID=kiwanisauction01; Password='Auction2011';" TESTING ONLY

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

        cbDonorID.Enabled = False
        cbDonorName.Enabled = False
        cbItemID.Enabled = False
        cbItemID.Items.Clear()
        cbItemID.Text = ""
        txtItemDesc.Enabled = False
        txtItemDesc.Clear()
        txtItemRetailVal.Enabled = False
        txtItemRetailVal.Clear()
        txtItemMinIncr.Enabled = False
        txtItemMinIncr.Clear()
        txtExprieDate.Enabled = False
        txtExprieDate.Clear()
        txtTvDesc.Enabled = False
        txtTvDesc.Text = "2000 characters max"
        Other.Enabled = False
        chbIsBlockSponsor.CheckState = CheckState.Unchecked
        chShown.CheckState = CheckState.Unchecked
        chError.CheckState = CheckState.Unchecked
        chbCertificate.CheckState = CheckState.Unchecked
        chbTBPU.CheckState = CheckState.Unchecked


        lblMessageBox.Text = ""

        btnPickDate.Enabled = False
        btnCommit.Enabled = False
        btnCommitDelete.Enabled = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Panel3.SendToBack()
        'btnOverwrite.Enabled = True

        initialState()
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        ItemFrmMode_lbl.Text = "Add Item"

        cbDonorID.Enabled = True
        cbDonorName.Enabled = True
        cbDonorID.SelectedItem = -1
        cbDonorName.SelectedIndex = -1
        txtItemDesc.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Panel3.SendToBack()
        'btnOverwrite.Enabled = True

        initialState()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        ItemFrmMode_lbl.Text = "Edit Item"

        loadItemID()
    End Sub

    Private Sub Item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialState()
        loadDonorID()
    End Sub

    Private Sub loadDonorID()

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandText = "SELECT DonorID, DonorName FROM Donors ORDER BY DonorName"

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader

            If SQLRead.HasRows Then
                While SQLRead.Read
                    cbDonorID.Items.Add(SQLRead("DonorID"))
                    cbDonorName.Items.Add(SQLRead("DonorName"))
                End While
            End If

            cbDonorID.Enabled = True
            cbDonorName.Enabled = True
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue:: Unable to retrieve Donor ID. Try again later"
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub txtItemDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemDesc.TextChanged
        If (cbDonorID.SelectedIndex <> -1 And cbDonorName.SelectedIndex <> -1 And cbDonorID.Text <> "") Then
            txtItemDesc.Enabled = True
        End If

        If txtItemDesc.TextLength > 0 Then
            txtItemRetailVal.Enabled = True
        Else
            txtItemRetailVal.Enabled = False
        End If
    End Sub

    Private Sub txtItemRetailVal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemRetailVal.TextChanged

        If txtItemRetailVal.Text = "" Then
            txtItemMinIncr.Enabled = False
            txtExprieDate.Enabled = False
            txtTvDesc.Enabled = False
            btnCommit.Enabled = False
            btnCommitDelete.Enabled = False
            btnPickDate.Enabled = False
            Other.Enabled = False
        End If
        If txtItemRetailVal.TextLength >= 0 And IsNumeric(txtItemRetailVal.Text) Then
            txtItemMinIncr.Enabled = True
            txtExprieDate.Enabled = False
            txtTvDesc.Enabled = True
            txtTvDesc.Text = ""
            btnCommit.Enabled = True
            btnPickDate.Enabled = True
            lblMessageBox.Text = ""
            Other.Enabled = True
            lblMessageBox.Text = ""
            If ItemFrmMode_lbl.Text = "Edit Item" Then
                btnCommitDelete.Enabled = True
            End If
        End If
        If IsNumeric(txtItemRetailVal.Text) = True Then
            If txtItemRetailVal.Text < 0 Then
                txtItemMinIncr.Enabled = False
                txtExprieDate.Enabled = False
                txtTvDesc.Enabled = False
                btnCommit.Enabled = False
                btnCommitDelete.Enabled = False
                btnPickDate.Enabled = False
                Other.Enabled = False
                lblMessageBox.Text = "ERROR: Retail price can not be a negative number."
            End If
        End If
        If IsNumeric(txtItemRetailVal.Text) = False And txtItemRetailVal.TextLength > 0 Then
            txtItemMinIncr.Enabled = False
            txtExprieDate.Enabled = False
            txtTvDesc.Enabled = False
            btnCommit.Enabled = False
            btnCommitDelete.Enabled = False
            btnPickDate.Enabled = False
            Other.Enabled = False
            lblMessageBox.Text = "ERROR: Retail price must be numeric."
        End If

    End Sub

    Private Sub txtItemMinIncr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemMinIncr.TextChanged

        If txtItemMinIncr.Text = "" Then
            btnCommit.Enabled = True
            lblMessageBox.Text = ""
            If ItemFrmMode_lbl.Text = "Edit Item" Then
                btnCommitDelete.Enabled = True
            End If
        End If
        If txtItemMinIncr.TextLength >= 0 And IsNumeric(txtItemMinIncr.Text) Then
            btnCommit.Enabled = True
            lblMessageBox.Text = ""
            If ItemFrmMode_lbl.Text = "Edit Item" Then
                btnCommitDelete.Enabled = True
            End If
        End If
        If IsNumeric(txtItemMinIncr.Text) = True Then
            If txtItemMinIncr.Text < 0 Then
                btnCommit.Enabled = False
                btnCommitDelete.Enabled = False
                lblMessageBox.Text = "ERROR: Mininum bid can not be a negative number."
            End If
        End If
        If IsNumeric(txtItemMinIncr.Text) = False And txtItemMinIncr.TextLength > 0 Then
            btnCommit.Enabled = False
            btnCommitDelete.Enabled = False
            lblMessageBox.Text = "ERROR: Mininum bid must be numeric."
        End If


    End Sub

    Private Sub btnPickDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickDate.Click
        If calExpire.Visible = False Then
            calExpire.Visible = True
            btnCommit.Enabled = False
        Else
            calExpire.Visible = False
            btnCommit.Enabled = True
        End If
    End Sub

    Private Sub cbDonorID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDonorID.SelectedIndexChanged
        cbDonorName.SelectedIndex = cbDonorID.SelectedIndex
        'initialState()
        txtItemDesc.Enabled = True
    End Sub

    Private Sub cbDonorName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDonorName.SelectedIndexChanged
        cbDonorID.SelectedIndex = cbDonorName.SelectedIndex
        'initialState()
        txtItemDesc.Enabled = True
    End Sub

    Private Sub calExpire_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calExpire.DateSelected
        txtExprieDate.Text = e.End.Date
        calExpire.Visible = False
        btnCommit.Enabled = True
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If ItemFrmMode_lbl.Text = "Add Item" Then
            ButtonCommand("Save")
        ElseIf ItemFrmMode_lbl.Text = "Edit Item" Then
            ButtonCommand("Edit")
        End If
    End Sub

    Private Sub btnCommitDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommitDelete.Click
        ButtonCommand("Delete")
    End Sub

    Private Sub ButtonCommand(ByVal strCmd As String)

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Dim strItemID As String = ""

        ' Get Item ID from cbItemID.SelectedItem using ':' delimitor
        Dim strLine As String = cbItemID.SelectedItem
        Dim strspltItemID As String()
        Try
            strspltItemID = strLine.Split(New Char() {":"c})
            strItemID = strspltItemID(0)
        Catch
            strItemID = ""
        End Try

        Dim strDonorID As String = cbDonorID.SelectedItem
        Dim strDateDonated As String = MAXDate()
        Dim strItemDesc As String = txtItemDesc.Text
        Dim strItemRetailVal As String = txtItemRetailVal.Text
        Dim strItemExpireDate As String = ""
        Dim strItemMinIncr As String = ""
        Dim strItemTvDesc As String = txtTvDesc.Text
        Dim strPrintRequired As String = ""
        Dim strIsBlockSponsor As String = ""
        Dim strShownOnTv As String = ""
        Dim strNewspaperError As String = ""
        Dim strTBPU As String = ""

        If chbCertificate.CheckState = CheckState.Checked Then
            strPrintRequired = "1"
        Else : strPrintRequired = "0"
        End If
        If chbIsBlockSponsor.CheckState = CheckState.Checked Then
            strIsBlockSponsor = "1"
        Else : strIsBlockSponsor = "0"
        End If
        If chShown.CheckState = CheckState.Checked Then
            strShownOnTv = "1"
        Else : strShownOnTv = "0"
        End If
        If chError.CheckState = CheckState.Checked Then
            strNewspaperError = "1"
        Else : strNewspaperError = "0"
        End If
        If chbTBPU.CheckState = CheckState.Checked Then
            strTBPU = "1"
        Else : strTBPU = "0"
        End If

        Select Case strCmd
            Case "Save"

                SQLCmd.CommandType = CommandType.StoredProcedure
                SQLCmd.CommandText = "uspInsertItem"

                SQLCmd.Parameters.AddWithValue("@donorid", strDonorID)
                SQLCmd.Parameters.AddWithValue("@datedonated", strDateDonated)
                SQLCmd.Parameters.AddWithValue("@description", strItemDesc)
                SQLCmd.Parameters.AddWithValue("@tvdescription", strItemTvDesc)
                SQLCmd.Parameters.AddWithValue("@retailvalue", strItemRetailVal)
                If txtItemMinIncr.Text <> "" Then
                    strItemMinIncr = txtItemMinIncr.Text
                    SQLCmd.Parameters.AddWithValue("@minimumbid", strItemMinIncr)
                Else
                    SQLCmd.Parameters.AddWithValue("@minimumbid", 0)
                End If
                SQLCmd.Parameters.AddWithValue("@isblocksponsor", strIsBlockSponsor)
                SQLCmd.Parameters.AddWithValue("@printcert", strPrintRequired)
                If txtExprieDate.Text = "" Then
                    SQLCmd.Parameters.AddWithValue("@expires", DBNull.Value)
                Else
                    strItemExpireDate = txtExprieDate.Text
                    SQLCmd.Parameters.AddWithValue("@expires", strItemExpireDate)
                End If
                SQLCmd.Parameters.AddWithValue("@auctionstatus", "1")
                SQLCmd.Parameters.AddWithValue("@displayontv", strShownOnTv)
                SQLCmd.Parameters.AddWithValue("@newspapererror", strNewspaperError)
                SQLCmd.Parameters.AddWithValue("@tobepickedup", strTBPU)

                Try
                    SQLConn.Open()
                    SQLCmd.ExecuteNonQuery()
                    SQLConn.Close()

                    initialState()
                    lblMessageBox.Text = "NEW Item added to the database!"

                    cbDonorID.SelectedIndex = -1
                    cbDonorName.Text = ""
                    cbDonorID.Enabled = True
                    cbDonorName.Enabled = True
                Catch ex As Exception
                    lblMessageBox.Text = "Connection Issue:: Unable to access the database. Try again later"
                    MessageBox.Show(ex.ToString)
                Finally
                    If SQLConn.State <> ConnectionState.Closed Then
                        SQLConn.Close()
                    End If
                    SQLCmd.Dispose()
                    loadItemID()
                    txtItemDesc.Enabled = False
                    cbItemID.Enabled = False
                End Try

            Case "Edit"     'Save changes made to current bidder
                SQLCmd.CommandType = CommandType.StoredProcedure
                SQLCmd.CommandText = "uspUpdateItem"

                SQLCmd.Parameters.AddWithValue("@itemid", strItemID)
                SQLCmd.Parameters.AddWithValue("@donorid", strDonorID)
                SQLCmd.Parameters.AddWithValue("@description", strItemDesc)
                SQLCmd.Parameters.AddWithValue("@tvdescription", strItemTvDesc)
                SQLCmd.Parameters.AddWithValue("@retailvalue", strItemRetailVal)
                If txtItemMinIncr.Text <> "" Then
                    strItemMinIncr = txtItemMinIncr.Text
                    SQLCmd.Parameters.AddWithValue("@minimumbid", strItemMinIncr)
                Else
                    SQLCmd.Parameters.AddWithValue("@minimumbid", 0)
                End If
                SQLCmd.Parameters.AddWithValue("@isblocksponsor", strIsBlockSponsor)
                SQLCmd.Parameters.AddWithValue("@printcert", strPrintRequired)
                If txtExprieDate.Text = "" Then
                    SQLCmd.Parameters.AddWithValue("@expires", DBNull.Value)
                Else
                    strItemExpireDate = txtExprieDate.Text
                    SQLCmd.Parameters.AddWithValue("@expires", strItemExpireDate)
                End If
                SQLCmd.Parameters.AddWithValue("@auctionstatus", "1")
                SQLCmd.Parameters.AddWithValue("@displayontv", strShownOnTv)
                SQLCmd.Parameters.AddWithValue("@newspapererror", strNewspaperError)
                SQLCmd.Parameters.AddWithValue("@tobepickedup", strTBPU)

                Try
                    SQLConn.Open()
                    SQLCmd.ExecuteNonQuery()
                    SQLConn.Close()

                    initialState()
                    cbDonorID.SelectedIndex = -1
                    lblMessageBox.Text = "Record Updated!"
                Catch ex As Exception
                    lblMessageBox.Text = "Connection Issue:: Unable to access the database. Try again later"
                    MessageBox.Show(ex.ToString)
                Finally
                    If SQLConn.State <> ConnectionState.Closed Then
                        SQLConn.Close()
                    End If
                    SQLCmd.Dispose()
                    loadItemID()
                    txtItemDesc.Enabled = False
                End Try

            Case "Delete"   'Delete current item
                SQLCmd.CommandType = CommandType.StoredProcedure
                SQLCmd.CommandText = "uspDeleteItem"

                SQLCmd.Parameters.AddWithValue("@itemid", strItemID)

                Try
                    SQLConn.Open()
                    SQLCmd.ExecuteNonQuery()
                    SQLConn.Close()

                    initialState()
                    cbDonorID.SelectedIndex = -1
                    lblMessageBox.Text = "Record Deleted!"
                Catch ex As Exception
                    lblMessageBox.Text = "Connection Issue:: Unable to access the database. Try again later"
                    MessageBox.Show(ex.ToString)
                Finally
                    If SQLConn.State <> ConnectionState.Closed Then
                        SQLConn.Close()
                    End If
                    SQLCmd.Dispose()
                    loadItemID()
                    txtItemDesc.Enabled = False
                End Try

        End Select
    End Sub

    Private Sub loadItemID()

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspSelectItemsCurrentAuction"

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        cbItemID2.Items.Clear()
        cbItemDescription.Items.Clear()

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader

            If SQLRead.HasRows Then
                Dim intCount As Integer = 0
                While SQLRead.Read
                    If SQLRead("ItemDateDonated") > Main.dateLastYear Then
                        arItem(intCount, 0) = SQLRead("ItemID").ToString
                        cbItemID2.Items.Add(arItem(intCount, 0))
                        arItem(intCount, 1) = SQLRead("ItemDesc").ToString
                        cbItemDescription.Items.Add(arItem(intCount, 1))
                        arItem(intCount, 2) = SQLRead("ItemTVDesc").ToString
                        arItem(intCount, 3) = Format(SQLRead("ItemRetailVal"), "####0")
                        If SQLRead("ItemMinBid").ToString <> "" Then
                            arItem(intCount, 4) = Format(SQLRead("ItemMinBid"), "####0")
                        Else
                            arItem(intCount, 4) = "0"
                        End If

                        arItem(intCount, 5) = SQLRead("ItemIsBlockSponsor").ToString
                        arItem(intCount, 6) = SQLRead("ItemPrintCertificate").ToString
                        arItem(intCount, 7) = SQLRead("ItemExpires").ToString
                        arItem(intCount, 8) = SQLRead("DonorID").ToString
                        arItem(intCount, 9) = SQLRead("ItemDisplayOnTv").ToString
                        arItem(intCount, 10) = SQLRead("ItemNewspaperError").ToString
                        arItem(intCount, 11) = SQLRead("ItemHighBid").ToString
                        arItem(intCount, 12) = SQLRead("ItemHighBidderID").ToString
                        arItem(intCount, 13) = SQLRead("ItemToBePickedUp").ToString

                        cbItemID.Items.Add(SQLRead("ItemID") & ": " & SQLRead("ItemDesc"))
                        intCount += 1
                    End If
                End While
                cbItemID.Enabled = True
            End If
            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue:: Unable to retrieve Item ID. Try again later"
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub cbItemID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbItemID.SelectedIndexChanged
        txtItemDesc.Enabled = True
        btnCommitDelete.Enabled = True
        displayItem()
    End Sub

    Private Sub displayItem()
        cbDonorID.Text = ""
        cbDonorName.Text = ""
        Dim intPos As Integer = cbItemID.SelectedIndex
        Dim itemDesc As String = arItem(intPos, 1)
        Dim itemTvDesc As String = arItem(intPos, 2)
        Dim retailVal As String = arItem(intPos, 3)
        Dim minBid As String = arItem(intPos, 4)
        Dim blockSponsor As String = arItem(intPos, 5)
        Dim printCertificate As String = arItem(intPos, 6)

        If IsDate(arItem(intPos, 7)) Then
            Dim expiresDate As Date = arItem(intPos, 7)
            txtExprieDate.Text = expiresDate.Date
        Else
            txtExprieDate.Text = ""
        End If

        Dim donorID As String = arItem(intPos, 8)
        Dim displayOnTv As String = arItem(intPos, 9)
        Dim NewspaperError As String = arItem(intPos, 10)

        Dim TBPU As String = arItem(intPos, 13)

        cbDonorID.Text = donorID
        cbDonorName.SelectedIndex = cbDonorID.SelectedIndex


        txtItemDesc.Text = itemDesc
        txtItemRetailVal.Text = retailVal
        txtItemMinIncr.Text = minBid


        Select Case printCertificate
            Case "False" : chbCertificate.CheckState = CheckState.Unchecked
            Case "True" : chbCertificate.CheckState = CheckState.Checked
        End Select

        txtTvDesc.Text = itemTvDesc

        Select Case blockSponsor
            Case "False" : chbIsBlockSponsor.CheckState = CheckState.Unchecked
            Case "True" : chbIsBlockSponsor.CheckState = CheckState.Checked
        End Select

        Select Case displayOnTv
            Case "False" : chShown.CheckState = CheckState.Unchecked
            Case "True" : chShown.CheckState = CheckState.Checked
        End Select

        Select Case NewspaperError
            Case "False" : chError.CheckState = CheckState.Unchecked
            Case "True" : chError.CheckState = CheckState.Checked
        End Select

        Select Case TBPU
            Case "False" : chbTBPU.CheckState = CheckState.Unchecked
            Case "True" : chbTBPU.CheckState = CheckState.Checked
        End Select

    End Sub

    ' Private Sub btnOverwrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverwrite.Click
    '    Panel3.BringToFront()
    '   txtCurrentBid.Enabled = False
    '  txtBidderID.Enabled = False
    ' loadItemID()
    'btnAdd.Enabled = True
    '   btnEdit.Enabled = True
    '   btnOverwrite.Enabled = False
    'txtTitle.Text = "OverWrite Bid Form"
    'End Sub

    Private Sub cbItemID2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbItemID2.SelectedIndexChanged
        cbItemDescription.SelectedIndex = cbItemID2.SelectedIndex
        txtCurrentBid.Text = arItem(cbItemID2.SelectedIndex, 11)
        txtBidderID.Text = arItem(cbItemID2.SelectedIndex, 12)
        txtCurrentBid.Enabled = True
        txtBidderID.Enabled = True
        If cbItemID2.SelectedItem = "" Or txtCurrentBid.Text = "" Or txtBidderID.Text = "" Then
            btnSavePrice.Enabled = False
        Else
            btnSavePrice.Enabled = True
        End If
    End Sub

    Private Sub cbItemDescription_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbItemDescription.SelectedIndexChanged
        cbItemID2.SelectedIndex = cbItemDescription.SelectedIndex
        txtCurrentBid.Text = arItem(cbItemID2.SelectedIndex, 11)
        txtBidderID.Text = arItem(cbItemID2.SelectedIndex, 12)
        txtCurrentBid.Enabled = True
        txtBidderID.Enabled = True
        If cbItemID2.SelectedItem = "" Or txtCurrentBid.Text = "" Or txtBidderID.Text = "" Then
            btnSavePrice.Enabled = False
        Else
            btnSavePrice.Enabled = True
        End If
    End Sub

    Private Sub btnSavePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePrice.Click
        If cbItemID2.Text = "" Or cbItemDescription.Text = "" Then
            lblMessageBox.Text = "ERROR :: Please select Item ID or Item Description."
        ElseIf txtCurrentBid.TextLength > 0 And Not IsNumeric(txtCurrentBid.Text) Then
            lblMessageBox.Text = "ERROR :: Bid Price must be a NUMBERIC or leave blank."
        ElseIf txtBidderID.TextLength > 0 And Not IsNumeric(txtBidderID.Text) Then
            lblMessageBox.Text = "ERROR :: Bidder ID must be a NUMBERIC or leave blank."
        Else
            If MessageBox.Show("Are you sure you want to change Item: ID-" & cbItemID2.SelectedItem & " to $" & txtCurrentBid.Text & _
                               " with BidderID-" & txtBidderID.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                overWriteBid()
                txtCurrentBid.Enabled = False
                txtBidderID.Enabled = False
                lblMessageBox.Text = "Success :: One record has been modified."
                loadItemID()
                cbItemID2.Text = ""
                cbItemDescription.Text = ""
                txtCurrentBid.Text = ""
                txtBidderID.Text = ""
            End If
        End If
    End Sub

    Private Sub overWriteBid()

        Dim strItemID As String = cbItemID2.SelectedItem
        Dim strBid As Integer = txtCurrentBid.Text
        Dim strBidderID As String = txtBidderID.Text

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLConn.ConnectionString = DBConnectionString

        SQLCmd.Connection = SQLConn

        SQLCmd.CommandText = "UPDATE Items SET ItemHighBid = " & strBid & "," & "ItemHighBidderID = " & strBidderID & "WHERE ItemID = " & strItemID

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to connect to the database."
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub btnClearDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearDate.Click

        txtExprieDate.Text = ""
        Call MAXDate()

    End Sub

    Private Function MAXDate() As String

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLConn.ConnectionString = DBConnectionString

        SQLCmd.Connection = SQLConn

        SQLCmd.CommandText = "Select [dbo].[ufnNextAuctionDate]()"

        Dim mxDate As String = ""

        Try
            SQLConn.Open()
            mxDate = SQLCmd.ExecuteScalar()
            SQLConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try

        Return mxDate.ToString()

    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtTvDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTvDesc.TextChanged
        lblCharRemain.Text = (2000 - txtTvDesc.Text.Length)
    End Sub
End Class