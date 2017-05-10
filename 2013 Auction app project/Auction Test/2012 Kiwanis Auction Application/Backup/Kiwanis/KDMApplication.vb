Imports System.Text.RegularExpressions
Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Public Class KDMApplication
    'Global Variables

    Public arDonor(99999, 17) As String
    Public arSol(99999, 5) As String
    Public arKMember(99999, 4) As String
    Public Solicitor_cbChanged As Integer
    Public KawanisMemberID_frm_array As Integer
    Public ErrorChckSWstr As String
    Public SAVEbutton As String
    Public ErrMsgStr As String
    Public DiaOkCrslt As DialogResult

    Public Conn_CMD As String = KDBConnect.loadKDMConnect

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOCK AND LOAD initial application defualts
        ErrorChckSWstr = "N"
        NonProfit_cb.Checked = False
        NotActive_cb.Checked = False
        Active_lbl.Text = ""
        Warning_lbl.Text = ""
        Solicitor_cbChanged = 0

        FormAdd_btn.Enabled = False
        FormCancel_btn.Enabled = False
        FormDelete_btn.Enabled = False
        Solicitor_cb.Enabled = False

        Name_txt.ReadOnly = True
        Address1_txt.ReadOnly = True
        Address2_txt.ReadOnly = True
        City_txt.ReadOnly = True
        State_dd.Enabled = False
        ZIPPrefix_txt.ReadOnly = True
        ContactName_txt.ReadOnly = True
        PhoneArea_txt.ReadOnly = True
        PhonePrefix_txt.ReadOnly = True
        PhoneLine_txt.ReadOnly = True
        PhoneExt_txt.ReadOnly = True
        Email_txt.ReadOnly = True
        Web_txt.ReadOnly = True
        Memo_rtb.ReadOnly = True
        NotActive_cb.Enabled = False
        NonProfit_cb.Enabled = False

        Name_txt.ForeColor = Color.Black
        Address1_txt.ForeColor = Color.Black
        Address2_txt.ForeColor = Color.Black
        City_txt.ForeColor = Color.Black
        ZIPPrefix_txt.ForeColor = Color.Black
        ContactName_txt.ForeColor = Color.Black
        PhoneArea_txt.ForeColor = Color.Black
        PhonePrefix_txt.ForeColor = Color.Black
        PhoneLine_txt.ForeColor = Color.Black
        PhoneExt_txt.ForeColor = Color.Black
        Email_txt.ForeColor = Color.Black
        Web_txt.ForeColor = Color.Black
        Memo_rtb.ForeColor = Color.Black

        WhiteOut() 'Clear and correct form color
        loadDonorID() 'LOAD donors to Donor_lb and generate donor array

        loadKiwanisMem() 'LOAD solicitors to Solicitor_cb
        Solicitor_cb.SelectedIndex = loadDonorKMember(110) 'LOAD default solicitor

    End Sub

    Private Sub Donor_lb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Donor_lb.SelectedIndexChanged

        NonProfit_cb.Checked = False
        NotActive_cb.Checked = False
        Active_lbl.Text = ""

        'ON SELECTION of a donor > retrieve data from donor array
        If Donor_lb.SelectedItem.ToString <> "" Then
            Dim intPos As Integer = Donor_lb.SelectedIndex
            Dim DonorID As Integer = arDonor(intPos, 0)
            Dim DonorName = arDonor(intPos, 1)
            Dim DonorAddr1 = arDonor(intPos, 2)
            Dim DonorAddr2 = arDonor(intPos, 3)
            Dim DonorCity = arDonor(intPos, 4)
            Dim DonorState = arDonor(intPos, 5)
            Dim DonorZip = arDonor(intPos, 6)
            Dim DonorContactName = arDonor(intPos, 7)
            Dim DonorPhone = arDonor(intPos, 8)
            Dim PhoneArea As String = DonorPhone.Substring(0, 3)
            Dim PhonePrefix As String = DonorPhone.Substring(3, 3)
            Dim PhoneLine As String = DonorPhone.Substring(6, 4)
            Dim DonorPhoneExt = arDonor(intPos, 9)
            Dim DonorEmail = arDonor(intPos, 10)
            Dim DonorURL = arDonor(intPos, 11)
            Dim DonorMemo = arDonor(intPos, 12)
            Dim DonorNotActive = arDonor(intPos, 13)
            Dim DonorIsNotProfit = arDonor(intPos, 14)
            Dim DonorLastDonate = arDonor(intPos, 15)
            Dim KiwSolicitorID = arDonor(intPos, 16)

            'POPULATE the donor form
            DonorID_txt.Text = DonorID
            Name_txt.Text = DonorName
            Address1_txt.Text = DonorAddr1
            Address2_txt.Text = DonorAddr2
            City_txt.Text = DonorCity
            Select Case DonorState
                Case "MA"
                    State_dd.SelectedItem = "MA"
                Case "CT"
                    State_dd.SelectedItem = "CT"
                Case "VT"
                    State_dd.SelectedItem = "VT"
                Case "NH"
                    State_dd.SelectedItem = "NH"
                Case "NY"
                    State_dd.SelectedItem = "NY"
                Case "RI"
                    State_dd.SelectedItem = "RI"
                Case "ME"
                    State_dd.SelectedItem = "ME"
            End Select
            ZIPPrefix_txt.Text = DonorZip
            ContactName_txt.Text = DonorContactName
            PhoneArea_txt.Text = PhoneArea
            PhonePrefix_txt.Text = PhonePrefix
            PhoneLine_txt.Text = PhoneLine
            PhoneExt_txt.Text = DonorPhoneExt
            Email_txt.Text = DonorEmail
            Web_txt.Text = DonorURL
            Memo_rtb.Text = DonorMemo

            If DonorNotActive = True Then
                NotActive_cb.Checked = True
                Active_lbl.Text = "NOT ACTIVE"
            End If
            If DonorIsNotProfit = True Then
                NonProfit_cb.Checked = True
            End If

            Solicitor_cb.SelectedIndex = loadDonorKMember(KiwSolicitorID)

            loadItem(DonorID)

        End If

    End Sub

    Private Sub AddDonor_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDonor_btn.Click
        '   ADD button: Clear and unlock form to insert data
        MODE_V_lbl.Text = "ADD"
        MODE_V_lbl.ForeColor = Color.Goldenrod

        EnableFrom()
        ClearEyes()
        Donor_lb.Enabled = False
        EditDonor_btn.Enabled = False

        SAVEbutton = "ADD0"
    End Sub

    Private Sub EditDonor_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDonor_btn.Click
        '   EDIT button: Unlock form for editing
        If DonorID_txt.Text = "" Then
            MessageBox.Show("Please select a donor to edit!", "Edit Donor")
        Else
            EnableFrom()
            MODE_V_lbl.Text = "EDIT"
            MODE_V_lbl.ForeColor = Color.Red
            SAVEbutton = "EDIT1"
            Donor_lb.Enabled = False
            AddDonor_btn.Enabled = False
        End If
    End Sub

    Private Sub BacktoMain_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BacktoMain_btn.Click
        '   BACK to main menu
        Main.Visible = True 'REMOVE FROM COMMENT WHEN IN APP
        Me.Close()
    End Sub

    Private Sub FormAdd_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormAdd_btn.Click
        '   ADD button for UPDATING or INSERTING donor information
        '   *** Triggers form validation ***
        Call HighlightErrors()
        Select Case ErrorChckSWstr
            Case "Y"
                InsertUpdateDonor(DonorID_txt.Text)
                ErrorChckSWstr = "N" 'RESETS validation routine for next attempt
                If DiaOkCrslt = DialogResult.OK Then
                    ClearEyes()
                    DisableFrom()
                    loadDonorID()
                    Donor_lb.Enabled = True
                    AddDonor_btn.Enabled = True
                    EditDonor_btn.Enabled = True
                    Solicitor_cb.SelectedIndex = loadDonorKMember(110)
                Else
                    Name_txt.Focus()
                End If
        End Select
    End Sub

    Private Sub FormCancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormCancel_btn.Click
        'CANCEL button: locks form and clears data
        WhiteOut()
        ClearEyes()
        DisableFrom()
        Donor_lb.Enabled = True
        EditDonor_btn.Enabled = True
        AddDonor_btn.Enabled = True
    End Sub
    Private Sub FormDelete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormDelete_btn.Click
        '   DELETE button: "Deletes" ONLY donor form database < sets donor to inactive (will not be queried).
    End Sub
    '
    '*******************************************************************
    'TEXT BOX CONTROL: Dynamic error detection & Remove error highlights.
    '*******************************************************************
    '
    Private Sub Name_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_txt.TextChanged
        Name_txt.BackColor = Color.White
    End Sub

    Private Sub Address1_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Address1_txt.TextChanged
        Address1_txt.BackColor = Color.White
    End Sub

    Private Sub City_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles City_txt.TextChanged
        City_txt.BackColor = Color.White
    End Sub

    Private Sub State_dd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles State_dd.SelectedIndexChanged
        State_dd.BackColor = Color.White
    End Sub

    Private Sub ZIPPrefix_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZIPPrefix_txt.TextChanged
        If IsValidAlphaNum(ZIPPrefix_txt.Text) = True Then
            ZIPPrefix_txt.BackColor = Color.LightGreen
            Warning_lbl.Text = "Letters are not valid input for ZIP."
        Else
            Warning_lbl.Text = ""
        End If
        ZIPPrefix_txt.BackColor = Color.White
    End Sub

    Private Sub ContactName_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactName_txt.TextChanged
        ContactName_txt.BackColor = Color.White
    End Sub

    Private Sub PhoneArea_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhoneArea_txt.TextChanged
        If PhoneArea_txt.TextLength = 3 Then
            PhonePrefix_txt.Focus()
        ElseIf PhoneArea_txt.TextLength < 1 Then
            PhoneArea_txt.Focus()
        End If
        '
        If IsValidAlphaNum(PhoneArea_txt.Text) = True Then
            PhoneArea_txt.BackColor = Color.LightGreen
            Warning_lbl.Text = "Letters are not valid input for phone number."
        Else
            Warning_lbl.Text = ""
        End If
        PhoneArea_txt.BackColor = Color.White
    End Sub

    Private Sub PhonePrefix_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhonePrefix_txt.TextChanged
        If PhonePrefix_txt.TextLength >= 3 Then
            PhoneLine_txt.Focus()
        ElseIf PhonePrefix_txt.TextLength < 1 Then
            PhoneArea_txt.Focus()
        End If
        '
        If IsValidAlphaNum(PhonePrefix_txt.Text) = True Then
            PhonePrefix_txt.BackColor = Color.LightGreen
            Warning_lbl.Text = "Letters are not valid input for phone number."
        Else
            Warning_lbl.Text = ""
        End If
        PhonePrefix_txt.BackColor = Color.White
    End Sub

    Private Sub PhoneLine_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhoneLine_txt.TextChanged
        If PhoneLine_txt.TextLength < 1 Then
            PhonePrefix_txt.Focus()
        End If
        '
        If IsValidAlphaNum(PhoneLine_txt.Text) = True Then
            PhoneLine_txt.BackColor = Color.LightGreen
            Warning_lbl.Text = "Letters are not valid input for phone number."
        Else
            Warning_lbl.Text = ""
        End If
        PhoneLine_txt.BackColor = Color.White
    End Sub

    Private Sub Solicitor_cb_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Solicitor_cb.SelectedIndexChanged
        Solicitor_cbChanged = 1
        'Retrieve Solictor ID stored in arKMember array for UPDATE/INSERT
        Dim SolicitorIndexID As String = Solicitor_cb.Items.IndexOf(Solicitor_cb.SelectedItem)
        KawanisMemberID_frm_array = arKMember(SolicitorIndexID, 0)

        'Warning_lbl.Text = "K ID:" & KawanisMemberID_frm_array ' DEMO

        Solicitor_cb.BackColor = Color.White
    End Sub
    '*******************************************************************
    'SUBROUTINES
    '*******************************************************************
    '
    Private Sub loadDonorID()
        Donor_lb.Items.Clear()

        'Genrates an array and populates a listbox of donors and donor information

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspSelectDonor"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLRead = SQLCmd.ExecuteReader

        Try
            If SQLRead.HasRows Then
                Dim intCount As Integer = 0
                'While SQLRead.HasRows
                While SQLRead.Read
                    arDonor(intCount, 0) = SQLRead("DonorID").ToString
                    arDonor(intCount, 1) = SQLRead("DonorName").ToString
                    arDonor(intCount, 2) = SQLRead("DonorAddr1").ToString
                    arDonor(intCount, 3) = SQLRead("DonorAddr2").ToString
                    arDonor(intCount, 4) = SQLRead("DonorCity").ToString
                    arDonor(intCount, 5) = SQLRead("DonorState").ToString
                    arDonor(intCount, 6) = SQLRead("DonorZip").ToString
                    arDonor(intCount, 7) = SQLRead("DonorContactName").ToString
                    arDonor(intCount, 8) = SQLRead("DonorPhone").ToString
                    arDonor(intCount, 9) = SQLRead("DonorPhoneExt").ToString
                    arDonor(intCount, 10) = SQLRead("DonorEmail").ToString
                    arDonor(intCount, 11) = SQLRead("DonorURL").ToString
                    arDonor(intCount, 12) = SQLRead("DonorMemo").ToString
                    arDonor(intCount, 13) = SQLRead("DonorNotActive").ToString
                    arDonor(intCount, 14) = SQLRead("DonorIsNotProfit").ToString
                    arDonor(intCount, 15) = SQLRead("DonorLastDonate").ToString
                    arDonor(intCount, 16) = SQLRead("KiwSolicitorID").ToString

                    Donor_lb.Items.Add(SQLRead("DonorName").ToString)

                    intCount += 1
                End While
                intCount = 0 'RESET counter to refresh listbox/ purge array
                SQLConn.Close()
            End If
        Catch ex As Exception
            'MessageBox.Show(MessageBoxIcon.Exclamation, "Connection Issue :: Unable to access the database. Try again later", "Connection Issue")
            MsgBox(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub loadKiwanisMem()
        'Genrates an array and populates a listbox of solicitor and solicitor information

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandText = "SELECT MemberID, MemLName, MemFName, MemMidInit FROM KiwanisMembers"

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader

            If SQLRead.HasRows Then
                Dim intCount As Integer = 0
                While SQLRead.Read
                    arKMember(intCount, 0) = SQLRead("MemberID").ToString
                    arKMember(intCount, 1) = SQLRead("MemFName").ToString
                    arKMember(intCount, 2) = SQLRead("MemLName").ToString
                    arKMember(intCount, 3) = SQLRead("MemMidInit").ToString

                    intCount += 1

                    Solicitor_cb.Items.Add(SQLRead("MemFName").ToString & " " & SQLRead("MemMidInit").ToString & " " & SQLRead("MemLName").ToString)

                End While

                SQLConn.Close()
            End If
        Catch ex As Exception
            'MessageBox.Show(MessageBoxIcon.Exclamation, "Unable to access the database > Unable to pull Kawanis member data.", "Connection Issue")
            MsgBox(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub loadItem(ByVal parDonorID)
        'Populate a data grid with items donated by donors

        Dim DataT As New DataSet

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLAdd As SqlDataAdapter 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspSelectDonorItems"

        SQLCmd.Parameters.Add("@donorid", SqlDbType.Int, 4).Value = parDonorID

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLAdd = New SqlDataAdapter(SQLCmd)

        Try
            SQLAdd.Fill(DataT, "Items")
            DataGridView1.Columns("ItemHighBid").DefaultCellStyle.Format = "c"
            DataGridView1.Columns("ItemRetailVal").DefaultCellStyle.Format = "c"
            DataGridView1.DataSource = DataT
            DataGridView1.DataMember = "Items"
            SQLConn.Close()

        Catch ex As Exception
            MessageBox.Show("Execute error :: " & ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try

    End Sub

    Private Sub InsertUpdateDonor(ByVal parDonorID)
        Dim MsgBM As String = ""
        Dim MsgBT As String = ""
        Select Case SAVEbutton
            Case Is = "ADD0"
                MsgBM = "NEW ata is about to be added to the database! Are you sure you would like to proceed?"
                MsgBT = "ADD DONOR"
            Case Is = "EDIT1"
                MsgBM = "Data is about to be added to the database! Are you sure you would like to proceed?"
                MsgBT = "EDIT DONOR"
        End Select

        DiaOkCrslt = MessageBox.Show(MsgBM, MsgBT, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If DiaOkCrslt = DialogResult.OK Then
            Dim DonorName = Name_txt.Text
            Dim DonorAddr1 = Address1_txt.Text
            Dim DonorAddr2 = Address2_txt.Text
            Dim DonorCity = City_txt.Text
            Dim DonorState = State_dd.SelectedItem
            Dim DonorZip = ZIPPrefix_txt.Text
            Dim DonorContactName = ContactName_txt.Text
            Dim DonorPhone = PhoneArea_txt.Text + PhonePrefix_txt.Text + PhoneLine_txt.Text
            Dim DonorPhoneExt = PhoneExt_txt.Text
            Dim DonorEmail = Email_txt.Text
            Dim DonorURL = Web_txt.Text
            Dim DonorMemo = Memo_rtb.Text
            Dim DonorNotActive As Integer
            Dim DonorIsNotProfit As Integer
            If NotActive_cb.Checked = True Then
                DonorNotActive = 1
            Else
                DonorNotActive = 0
            End If
            If NonProfit_cb.Checked = True Then
                DonorIsNotProfit = 1
            Else
                DonorIsNotProfit = 0
            End If
            Dim DonorLastDonate = 0
            Dim KiwSolicitorID As Integer

            Dim SQLConn As New SqlConnection() 'The SQL Connection
            Dim SQLCmd As New SqlCommand() 'The SQL Command

            SQLCmd.CommandType = CommandType.StoredProcedure

            If SAVEbutton = "ADD0" Then
                SQLCmd.CommandText = "uspInsertDonor"
                KiwSolicitorID = KawanisMemberID_frm_array
            ElseIf SAVEbutton = "EDIT1" Then
                SQLCmd.CommandText = "uspUpdateDonor"
                If Solicitor_cbChanged = 1 Then
                    KiwSolicitorID = KawanisMemberID_frm_array
                Else
                    KiwSolicitorID = getSolicitorBYDonor(parDonorID)
                End If
            End If

            SQLConn.ConnectionString = Conn_CMD
            SQLCmd.Connection = SQLConn

            SQLCmd.Parameters.Add("@name", SqlDbType.VarChar, 30).Value = DonorName
            SQLCmd.Parameters.Add("@addr", SqlDbType.VarChar, 30).Value = DonorAddr1
            SQLCmd.Parameters.Add("@addr2", SqlDbType.VarChar, 30).Value = DonorAddr2
            SQLCmd.Parameters.Add("@city", SqlDbType.VarChar, 30).Value = DonorCity
            SQLCmd.Parameters.Add("@state", SqlDbType.Char, 2).Value = DonorState
            SQLCmd.Parameters.Add("@zip", SqlDbType.VarChar, 9).Value = DonorZip
            SQLCmd.Parameters.Add("@contactname", SqlDbType.VarChar, 30).Value = DonorContactName
            SQLCmd.Parameters.Add("@phone", SqlDbType.Char, 10).Value = DonorPhone
            SQLCmd.Parameters.Add("@phoneext", SqlDbType.Char, 6).Value = DonorPhoneExt
            SQLCmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = DonorEmail
            SQLCmd.Parameters.Add("@url", SqlDbType.VarChar, 50).Value = DonorURL
            SQLCmd.Parameters.Add("@memo", SqlDbType.VarChar, 500).Value = DonorMemo
            SQLCmd.Parameters.Add("@notactive", SqlDbType.Bit, 0).Value = DonorNotActive
            SQLCmd.Parameters.Add("@isnotforprofit", SqlDbType.Bit, 0).Value = DonorIsNotProfit
            SQLCmd.Parameters.Add("@solicitorid", SqlDbType.SmallInt, 110).Value = KiwSolicitorID
            SQLCmd.Parameters.Add("@location", SqlDbType.VarChar, 5).Value = 0

            If SAVEbutton = "EDIT1" Then
                SQLCmd.Parameters.Add("@donorid", SqlDbType.Int, 4).Value = parDonorID
            End If

            Try
                SQLConn.Open()
                SQLCmd.ExecuteNonQuery()
                SQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If SQLConn.State <> ConnectionState.Closed Then
                    SQLConn.Close()
                End If
                SQLCmd.Dispose()
            End Try

            Solicitor_cbChanged = 0

        ElseIf DiaOkCrslt = DialogResult.Cancel Then
            'RETURNS control to SAVE button / DO NOTHING
        End If

    End Sub

    Sub WhiteOut()
        'Clear background color from input fields
        Name_txt.BackColor = Color.White
        Address1_txt.BackColor = Color.White
        Address2_txt.BackColor = Color.White
        City_txt.BackColor = Color.White
        State_dd.BackColor = Color.White
        ZIPPrefix_txt.BackColor = Color.White
        ContactName_txt.BackColor = Color.White
        PhoneArea_txt.BackColor = Color.White
        PhonePrefix_txt.BackColor = Color.White
        PhoneLine_txt.BackColor = Color.White
        PhoneExt_txt.BackColor = Color.White
        Email_txt.BackColor = Color.White
        Web_txt.BackColor = Color.White
        Memo_rtb.BackColor = Color.White
    End Sub

    Sub ClearEyes()
        'Clear data from input fields
        ErrorChckSWstr = "N"
        Solicitor_cb.SelectedValue = ""
        NonProfit_cb.Checked = False
        NotActive_cb.Checked = False
        Active_lbl.Text = ""
        Warning_lbl.Text = ""
        DonorID_txt.Clear()
        Name_txt.Clear()
        Address1_txt.Clear()
        Address2_txt.Clear()
        City_txt.Clear()
        State_dd.SelectedItem = ""
        ZIPPrefix_txt.Clear()
        ContactName_txt.Clear()
        PhoneArea_txt.Clear()
        PhonePrefix_txt.Clear()
        PhoneLine_txt.Clear()
        PhoneExt_txt.Clear()
        Email_txt.Clear()
        Web_txt.Clear()
        Memo_rtb.Clear()
        Call loadItem(0)
    End Sub
    Public Sub EnableFrom()
        Donor_lb.Enabled = True
        FormAdd_btn.Enabled = True
        FormCancel_btn.Enabled = True
        'FormDelete_btn.Enabled = True
        Solicitor_cb.Enabled = True
        Name_txt.ReadOnly = False
        Address1_txt.ReadOnly = False
        Address2_txt.ReadOnly = False
        City_txt.ReadOnly = False
        State_dd.Enabled = True
        ZIPPrefix_txt.ReadOnly = False
        ContactName_txt.ReadOnly = False
        PhoneArea_txt.ReadOnly = False
        PhonePrefix_txt.ReadOnly = False
        PhoneLine_txt.ReadOnly = False
        PhoneExt_txt.ReadOnly = False
        Email_txt.ReadOnly = False
        Web_txt.ReadOnly = False
        Memo_rtb.ReadOnly = False
        Solicitor_cb.Enabled = True
        NotActive_cb.Enabled = True
        NonProfit_cb.Enabled = True
    End Sub

    Public Sub DisableFrom()
        MODE_V_lbl.Text = "VIEW"
        MODE_V_lbl.ForeColor = Color.Green
        FormAdd_btn.Enabled = False
        FormCancel_btn.Enabled = False
        FormDelete_btn.Enabled = False
        Solicitor_cb.Enabled = False
        Name_txt.ReadOnly = True
        Address1_txt.ReadOnly = True
        Address2_txt.ReadOnly = True
        City_txt.ReadOnly = True
        State_dd.Enabled = False
        ZIPPrefix_txt.ReadOnly = True
        ContactName_txt.ReadOnly = True
        PhoneArea_txt.ReadOnly = True
        PhonePrefix_txt.ReadOnly = True
        PhoneLine_txt.ReadOnly = True
        PhoneExt_txt.ReadOnly = True
        Email_txt.ReadOnly = True
        Web_txt.ReadOnly = True
        Memo_rtb.ReadOnly = True
        Solicitor_cb.Enabled = False
        NotActive_cb.Enabled = False
        NonProfit_cb.Enabled = False
    End Sub

    Public Sub HighlightErrors()
        '
        'Detect and highlight input errors.
        '
        'Check for empty required input and accumulate error messages
        'for error message prompt box.
        '
        '**************************************************
        '   Name (company  -> DONOR)     
        '**************************************************
        If Name_txt.Text = "" Then
            Name_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Donor Name - This field may not be empty." & vbCr
        End If
        '**************************************************
        '   Address/State/ZIP    
        '**************************************************
        If Address1_txt.Text = "" Then
            Address1_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Address 1 - This field may not be empty." & vbCr
        End If
        If City_txt.Text = "" Then
            City_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing City - This field may not be empty." & vbCr
        End If
        If IsValidNumeric(City_txt.Text) = True Then
            City_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Numbers are not valid input for city." & vbCr
        End If
        If State_dd.Text = "" Then
            State_dd.BackColor = Color.LightGreen
            ErrMsgStr += "Missing State - This field may not be empty." & vbCr
        End If
        If ZIPPrefix_txt.Text = "" Then
            ZIPPrefix_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing ZIP Information - This field may not be empty." & vbCr
        ElseIf ZIPPrefix_txt.TextLength < 5 Then
            ZIPPrefix_txt.BackColor = Color.LightGreen
            ErrMsgStr += "ZIP Invalid Length: Requires 5 Digits." & vbCr
        End If
        If IsValidAlphaNum(ZIPPrefix_txt.Text) = True Then
            ZIPPrefix_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Letters are not valid input for ZIP." & vbCr
        End If
        '**************************************************
        '  Contact (person -> DONOR)    
        '**************************************************
        If ContactName_txt.Text = "" Then
            ContactName_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Contact Information - This field may not be empty." & vbCr
        End If
        If IsValidNumeric(ContactName_txt.Text) = True Then
            ContactName_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Numbers are not valid input for contact name." & vbCr
        End If
        '**************************************************
        '    Phone: area/prefix/line     
        '**************************************************
        'Check for nulls, input length and missing data
        If PhoneArea_txt.Text = "" Then
            PhoneArea_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Phone Area Code - This field may not be empty." & vbCr
        ElseIf PhoneArea_txt.TextLength < 3 Then
            PhoneArea_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Phone Area Code Invalid Length: Requires 3 Digits." & vbCr
        End If
        If PhonePrefix_txt.Text = "" Then
            PhonePrefix_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Phone Prefix Number - This field may not be empty." & vbCr
        ElseIf PhonePrefix_txt.TextLength < 3 Then
            PhonePrefix_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Phone Prefix Invalid Length: Requires 3 Digits." & vbCr
        End If
        If PhoneLine_txt.Text = "" Then
            PhoneLine_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Phone Line Number - This field may not be empty." & vbCr
        ElseIf PhoneLine_txt.TextLength < 4 Then
            PhoneLine_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Phone Line Invalid Length: Requires 4 Digits." & vbCr
        End If
        '
        'Check for non-numeric input
        If IsValidAlphaNum(PhoneArea_txt.Text) = True Or IsValidAlphaNum(PhonePrefix_txt.Text) = True Or IsValidAlphaNum(PhoneLine_txt.Text) = True Then
            PhoneArea_txt.BackColor = Color.LightGreen
            PhonePrefix_txt.BackColor = Color.LightGreen
            PhoneLine_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Letters are not valid input for phone number." & vbCr
        ElseIf IsValidAlphaNum(PhonePrefix_txt.Text) = True Or IsValidAlphaNum(PhoneLine_txt.Text) = True Then
            PhonePrefix_txt.BackColor = Color.LightGreen
            PhoneLine_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Letters are not valid input for phone number." & vbCr
        ElseIf IsValidAlphaNum(PhoneLine_txt.Text) = True Then
            PhoneLine_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Letters are not valid input for phone number." & vbCr
        End If
        'Check if a solicitor is selected
        If Solicitor_cb.SelectedItem = "" Then
            ErrMsgStr += "Please Assign a Solicitor to the Donor." & vbCr
        End If
        'Message box to notify user of errors and terminate error checking
        If ErrMsgStr = "" Then
            ErrorChckSWstr = "Y"
        Else
            MsgBox(ErrMsgStr, MsgBoxStyle.Exclamation, "ERROR: Incorrect Input!")
            ErrMsgStr = ""
            ErrorChckSWstr = "N"
        End If
    End Sub
    '*******************************************************************
    'FUNCTIONS
    '*******************************************************************
    '
    'Verify text using REGEX (regular expression class object)
    Private Function IsValidSpaces(ByVal strSpacesIn As String) As Boolean
        Return Regex.IsMatch(strSpacesIn, "^\s$")
    End Function

    Private Function IsValidNumeric(ByVal NumIn As String) As Boolean
        Return Regex.IsMatch(NumIn, "[0-9]")
    End Function

    Private Function IsValidAlphaNum(ByVal AlphaNumIn As String) As Boolean
        Return Regex.IsMatch(AlphaNumIn, "[a-zA-Z]")
    End Function
    Private Function loadDonorKMember(ByVal KawanisID As String) As Integer
        'Populate a text box with a solicitor related to a donors
        Dim indexID_Kmem As Integer
        Dim i As Integer = 0
        While i < arKMember.GetUpperBound(0)
            If arKMember(i, 0) = (KawanisID) Then
                indexID_Kmem = i
            End If
            i += 1
        End While
        Return indexID_Kmem
    End Function

    Private Function getSolicitorBYDonor(ByVal DonorID As String) As Integer
        Dim KawanisID As Integer
        Dim i As Integer = 0
        While i < arDonor.GetUpperBound(0)
            If arDonor(i, 0) = (DonorID) Then
                KawanisID = arDonor(i, 16)
            End If
            i += 1
        End While
        Return KawanisID
    End Function

End Class

'Dim Conn_CMD As String = "Data Source=sql2k804.discountasp.net; Initial Catalog=SQL2008R2_785987_tvauction ; User ID=devteam; Password='WsUdev2011';"
'Dim Conn_CMD As String = "Data Source=kiwanisauction01.db.6809554.hostedresource.com; Initial Catalog=kiwanisauction01; User ID=kiwanisauction01; Password='Auction2011';"