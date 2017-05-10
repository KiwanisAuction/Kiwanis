Imports System.Text.RegularExpressions
Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Public Class Bidder
    'Global Variables
    Public arBidder(99999, 13) As String
    Public ErrorChckSWstr As String
    Public SAVEbutton As String
    Public ErrMsgStr As String
    Public DiaOkCrslt As DialogResult

    Public DBConnectionString As String = KiwanisConfig.LoadDatabaseConfig

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOCK AND LOAD initial application defualts
        ErrorChckSWstr = "N"
        NotActive_cb.Checked = False
        Active_lbl.Text = ""
        KMember_cb.Checked = False
        lblKiwanis.Text = ""
        Warning_lbl.Text = ""

        FormAdd_btn.Enabled = False
        FormCancel_btn.Enabled = False
        FormDelete_btn.Enabled = False

        FName_txt.ReadOnly = True
        LName_txt.ReadOnly = True
        Address1_txt.ReadOnly = True

        City_txt.ReadOnly = True
        State_dd.Enabled = False
        ZIPPrefix_txt.ReadOnly = True
        PhoneArea_txt.ReadOnly = True
        PhonePrefix_txt.ReadOnly = True
        PhoneLine_txt.ReadOnly = True
        PhoneArea2_txt.ReadOnly = True
        PhonePrefix2_txt.ReadOnly = True
        PhoneLine2_txt.ReadOnly = True
        Email_txt.ReadOnly = True
        Memo_rtb.ReadOnly = True
        NotActive_cb.Enabled = False
        KMember_cb.Enabled = False

        FName_txt.ForeColor = Color.Black
        LName_txt.ForeColor = Color.Black
        Address1_txt.ForeColor = Color.Black
        City_txt.ForeColor = Color.Black
        ZIPPrefix_txt.ForeColor = Color.Black
        PhoneArea_txt.ForeColor = Color.Black
        PhonePrefix_txt.ForeColor = Color.Black
        PhoneLine_txt.ForeColor = Color.Black
        PhoneArea2_txt.ForeColor = Color.Black
        PhonePrefix2_txt.ForeColor = Color.Black
        PhoneLine2_txt.ForeColor = Color.Black
        Email_txt.ForeColor = Color.Black
        Memo_rtb.ForeColor = Color.Black

        cbxViewNotActive.Checked = False

        WhiteOutFormFields() 'Clear and correct form color
        loadBidderID() 'LOAD Bidders to Bidder_lb and generate Bidder array

    End Sub

    Private Sub Bidder_lb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bidder_lb.SelectedIndexChanged

        NotActive_cb.Checked = False
        Active_lbl.Text = ""
        KMember_cb.Checked = False
        lblKiwanis.Text = ""

        'ON SELECTION of a Bidder > retrieve data from Bidder array
        If Bidder_lb.SelectedItem.ToString <> "" Then
            Dim intPos As Integer = Bidder_lb.SelectedIndex
            Dim BidderID As Integer = arBidder(intPos, 0)
            Dim BidderFName = arBidder(intPos, 1)
            Dim BidderLName = arBidder(intPos, 2)
            Dim BidderAddr1 = arBidder(intPos, 3)
            Dim BidderCity = arBidder(intPos, 4)
            Dim BidderState = arBidder(intPos, 5)
            Dim BidderZip = arBidder(intPos, 6)
            Dim BidderEmail = arBidder(intPos, 7)
            Dim BidderActive = arBidder(intPos, 8)
            Dim BidderIsKMember = arBidder(intPos, 9)
            Dim BidderMemo = arBidder(intPos, 10)
            Dim BidderPhone = arBidder(intPos, 11)
            Dim PhoneArea As String = BidderPhone.Substring(0, 3)
            Dim PhonePrefix As String = BidderPhone.Substring(3, 3)
            Dim PhoneLine As String = BidderPhone.Substring(6, 4)
            Dim BidderPhone2 = arBidder(intPos, 12)
            Dim PhoneArea2 As String = ""
            Dim PhonePrefix2 As String = ""
            Dim PhoneLine2 As String = ""
            If BidderPhone2 <> "" Then
                PhoneArea2 = BidderPhone2.Substring(0, 3)
                PhonePrefix2 = BidderPhone2.Substring(3, 3)
                PhoneLine2 = BidderPhone2.Substring(6, 4)
            End If
            PhoneArea_txt.Text = PhoneArea
            PhonePrefix_txt.Text = PhonePrefix
            PhoneLine_txt.Text = PhoneLine
            PhoneArea2_txt.Text = PhoneArea2
            PhonePrefix2_txt.Text = PhonePrefix2
            PhoneLine2_txt.Text = PhoneLine2

            'POPULATE the Bidder form
            BidderID_txt.Text = BidderID
            FName_txt.Text = BidderFName
            LName_txt.Text = BidderLName
            Address1_txt.Text = BidderAddr1
            City_txt.Text = BidderCity
            Select Case BidderState
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
            ZIPPrefix_txt.Text = BidderZip
            Email_txt.Text = BidderEmail
            Memo_rtb.Text = BidderMemo
            'PhoneArea_txt.Text = PhoneArea
            'PhonePrefix_txt.Text = PhonePrefix
            ' PhoneLine_txt.Text = PhoneLine
            ' PhoneArea2_txt.Text = PhoneArea2
            ' PhonePrefix2_txt.Text = PhonePrefix2
            ' PhoneLine2_txt.Text = PhoneLine2
            If BidderActive = "False" Then
                NotActive_cb.Checked = True
                Active_lbl.Text = "NOT ACTIVE"
            End If
            If BidderIsKMember = "True" Then
                KMember_cb.Checked = True
                lblKiwanis.Text = "Kawanis Member"
            End If
            loadItem(BidderID)
        End If

    End Sub

    Private Sub AddBidder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBidder_btn.Click
        '   ADD button: Clear and unlock form to insert data
        MODE_V_lbl.Text = "ADD"
        MODE_V_lbl.ForeColor = Color.Goldenrod

        EnableFrom()
        ClearFormFields()
        Bidder_lb.Enabled = False
        EditBidder_btn.Enabled = False

        SAVEbutton = "ADD0"
    End Sub

    Private Sub EditBidder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBidder_btn.Click
        '   EDIT button: Unlock form for editing
        If BidderID_txt.Text = "" Then
            MessageBox.Show("Please select a Bidder to edit!", "Edit Bidder")
        Else
            EnableFrom()
            MODE_V_lbl.Text = "EDIT"
            MODE_V_lbl.ForeColor = Color.Red
            SAVEbutton = "EDIT1"
            Bidder_lb.Enabled = False
            AddBidder_btn.Enabled = False
        End If
    End Sub

    Private Sub BacktoMain_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BacktoMain_btn.Click
        Me.Hide()
        Main.Visible = True 'REMOVE FROM COMMENT WHEN IN APP
        Me.Close()
    End Sub

    Private Sub ThisFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub FormAdd_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormAdd_btn.Click
        '   ADD button for UPDATING or INSERTING Bidder information
        '   *** Triggers form validation ***
        HighlightErrors()
        Select Case ErrorChckSWstr
            Case "Y"
                InsertUpdateBidder(BidderID_txt.Text)
                ErrorChckSWstr = "N" 'RESETS validation routine for next attempt
                If DiaOkCrslt = DialogResult.OK Then
                    ClearFormFields()
                    DisableFrom()
                    loadBidderID()
                    Bidder_lb.Enabled = True
                    AddBidder_btn.Enabled = True
                    EditBidder_btn.Enabled = True
                Else
                    FName_txt.Focus()
                End If
        End Select
    End Sub

    Private Sub FormCancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormCancel_btn.Click
        ' CANCEL button: locks form and clears data
        WhiteOutFormFields()
        ClearFormFields()
        DisableFrom()
        Bidder_lb.Enabled = True
        EditBidder_btn.Enabled = True
        AddBidder_btn.Enabled = True
    End Sub
    Private Sub FormDelete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormDelete_btn.Click
        ' DELETE button: "Deletes" ONLY Bidder form database < sets Bidder to inactive (will not be queried).
        If NotActive_cb.Checked = False Then
            NotActive_cb.Checked = True
        ElseIf NotActive_cb.Checked = True Then
            NotActive_cb.Checked = False
        End If
    End Sub
    '
    '*******************************************************************
    'TEXT BOX CONTROL: Dynamic error detection & Remove error highlights.
    '*******************************************************************
    '
    Private Sub Name_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FName_txt.TextChanged
        FName_txt.BackColor = Color.White
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

    Private Sub ZIPPrefix_txt_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles ZIPPrefix_txt.KeyPress
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        ZIPPrefix_txt.BackColor = Color.White
    End Sub

    Private Sub PhoneArea_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhoneArea_txt.KeyPress

        If PhoneArea_txt.TextLength = 3 And Not e.KeyChar = ChrW(Keys.Back) Then
            PhonePrefix_txt.Focus()
            PhonePrefix_txt.Text = e.KeyChar
            PhonePrefix_txt.SelectionStart = PhonePrefix_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If

        PhoneArea_txt.BackColor = Color.White

    End Sub

    Private Sub PhonePrefix_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhonePrefix_txt.KeyPress
        If PhonePrefix_txt.TextLength = 3 And Not e.KeyChar = ChrW(Keys.Back) Then
            PhoneLine_txt.Focus()
            PhoneLine_txt.Text = e.KeyChar
            PhoneLine_txt.SelectionStart = PhoneLine_txt.TextLength
        ElseIf PhonePrefix_txt.TextLength < 1 And e.KeyChar = ChrW(Keys.Back) Then
            PhoneArea_txt.Focus()
            PhoneArea_txt.SelectionStart = PhoneArea_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        PhonePrefix_txt.BackColor = Color.White
    End Sub

    Private Sub PhoneLine_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhoneLine_txt.KeyPress

        If PhoneLine_txt.TextLength < 1 And e.KeyChar = ChrW(Keys.Back) Then
            PhonePrefix_txt.Focus()
            PhonePrefix_txt.SelectionStart = PhonePrefix_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        PhoneLine_txt.BackColor = Color.White

    End Sub

    Private Sub PhoneArea2_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhoneArea2_txt.KeyPress

        If PhoneArea2_txt.TextLength = 3 And Not e.KeyChar = ChrW(Keys.Back) Then
            PhonePrefix2_txt.Focus()
            PhonePrefix2_txt.Text = e.KeyChar
            PhonePrefix2_txt.SelectionStart = PhonePrefix2_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        PhoneArea2_txt.BackColor = Color.White
    End Sub

    Private Sub PhonePrefix2_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhonePrefix2_txt.KeyPress
        If PhonePrefix2_txt.TextLength = 3 And Not e.KeyChar = ChrW(Keys.Back) Then
            PhoneLine2_txt.Focus()
            PhoneLine2_txt.Text = e.KeyChar
            PhoneLine2_txt.SelectionStart = PhoneLine2_txt.TextLength
        ElseIf PhonePrefix2_txt.TextLength < 1 And e.KeyChar = ChrW(Keys.Back) Then
            PhoneArea2_txt.Focus()
            PhoneArea2_txt.SelectionStart = PhoneArea2_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        PhonePrefix2_txt.BackColor = Color.White
    End Sub

    Private Sub PhoneLine2_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhoneLine2_txt.KeyPress

        If PhoneLine2_txt.TextLength < 1 And e.KeyChar = ChrW(Keys.Back) Then
            PhonePrefix2_txt.Focus()
            PhonePrefix2_txt.SelectionStart = PhonePrefix2_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        PhoneLine2_txt.BackColor = Color.White
    End Sub
    '*******************************************************************
    'SUBROUTINES
    '*******************************************************************
    '
    Private Sub loadBidderID()
        Bidder_lb.Items.Clear()

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRd As SqlDataReader 'The Local Data Store

        'Genrates an array and populates a listbox of Bidders and Bidder information
        SQLCmd.CommandText = "uspSelectBidders"

        SQLConn.ConnectionString = DBConnectionString

        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLRd = SQLCmd.ExecuteReader

        Try
            Dim intCount As Integer = 0
            If SQLRd.HasRows Then

                'While SQLRd.HasRows
                While SQLRd.Read


                    If cbxViewNotActive.Checked = True And SQLRd("BidderActive") = False Then
                        arBidder(intCount, 0) = SQLRd("BidderID").ToString
                        arBidder(intCount, 1) = SQLRd("BidderFName").ToString
                        arBidder(intCount, 2) = SQLRd("BidderLName").ToString
                        arBidder(intCount, 3) = SQLRd("BidderAddr").ToString
                        arBidder(intCount, 4) = SQLRd("BidderCity").ToString
                        arBidder(intCount, 5) = SQLRd("BidderState").ToString
                        arBidder(intCount, 6) = SQLRd("BidderZip").ToString
                        arBidder(intCount, 7) = SQLRd("BidderEmail").ToString
                        arBidder(intCount, 8) = SQLRd("BidderActive").ToString
                        arBidder(intCount, 9) = SQLRd("BidderIsKMember").ToString
                        arBidder(intCount, 10) = SQLRd("BidderMemo").ToString
                        arBidder(intCount, 11) = SQLRd("BidderPhone").ToString
                        arBidder(intCount, 12) = SQLRd("BidderPhone2").ToString

                        Bidder_lb.Items.Add(SQLRd("BidderLName").ToString & " " & SQLRd("BidderFName").ToString)
                        intCount += 1
                    End If

                    If SQLRd("BidderActive") = True And cbxViewNotActive.Checked = False Then
                        arBidder(intCount, 0) = SQLRd("BidderID").ToString
                        arBidder(intCount, 1) = SQLRd("BidderFName").ToString
                        arBidder(intCount, 2) = SQLRd("BidderLName").ToString
                        arBidder(intCount, 3) = SQLRd("BidderAddr").ToString
                        arBidder(intCount, 4) = SQLRd("BidderCity").ToString
                        arBidder(intCount, 5) = SQLRd("BidderState").ToString
                        arBidder(intCount, 6) = SQLRd("BidderZip").ToString
                        arBidder(intCount, 7) = SQLRd("BidderEmail").ToString
                        arBidder(intCount, 8) = SQLRd("BidderActive").ToString
                        arBidder(intCount, 9) = SQLRd("BidderIsKMember").ToString
                        arBidder(intCount, 10) = SQLRd("BidderMemo").ToString
                        arBidder(intCount, 11) = SQLRd("BidderPhone").ToString
                        arBidder(intCount, 12) = SQLRd("BidderPhone2").ToString

                        Bidder_lb.Items.Add(SQLRd("BidderLName").ToString & " " & SQLRd("BidderFName").ToString)
                        intCount += 1
                    End If

                End While
                'intCount = 0 'RESET counter to refresh listbox/ purge array
                SQLConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(MessageBoxIcon.Exclamation, "Unable to access the database. Try again later", "Connection Issue")
            MsgBox(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub loadItem(ByVal parBidderID)

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLAdd As SqlDataAdapter 'The Local Data Store

        'Populate a data grid with items donated by Bidders

        SQLCmd.CommandText = "SELECT * FROM Items WHERE ItemHighBidderID = '" & parBidderID & "'"

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn


        SQLConn.Open()
        SQLAdd = New SqlDataAdapter(SQLCmd)

        Try
            Dim DataT As New DataSet
            SQLAdd.Fill(DataT, "Items")
            DataGridView1.Columns("ItemHighBid").DefaultCellStyle.Format = "c"
            DataGridView1.Columns("ItemRetailVal").DefaultCellStyle.Format = "c"
            DataGridView1.DataSource = DataT
            DataGridView1.DataMember = "Items"
            SQLConn.Close()

        Catch ex As Exception
            MessageBox.Show("Execute error: " & ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub InsertUpdateBidder(ByVal parBidderID)

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        Dim MsgBM As String = ""
        Dim MsgBT As String = ""
        Select Case SAVEbutton
            Case Is = "ADD0"
                MsgBM = "NEW data is about to be added to the database! Are you sure you would like to proceed?"
                MsgBT = "ADD Bidder"
            Case Is = "EDIT1"
                MsgBM = "Data is about to be added to the database! Are you sure you would like to proceed?"
                MsgBT = "EDIT Bidder"
        End Select

        DiaOkCrslt = MessageBox.Show(MsgBM, MsgBT, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If DiaOkCrslt = DialogResult.OK Then
            Dim BidderFName = FName_txt.Text
            Dim BidderLName = LName_txt.Text
            Dim BidderAddr1 = Address1_txt.Text
            Dim BidderCity = City_txt.Text
            Dim BidderState = State_dd.SelectedItem
            Dim BidderZip = ZIPPrefix_txt.Text
            Dim BidderNotActive As Integer
            Dim BidderIsKMemeber As Integer
            If NotActive_cb.Checked = True Then
                BidderNotActive = 0
            ElseIf NotActive_cb.Checked = False Then
                BidderNotActive = 1
            End If
            If KMember_cb.Checked = True Then
                BidderIsKMemeber = 1
            ElseIf KMember_cb.Checked = False Then
                BidderIsKMemeber = 0
            End If
            Dim BidderPhone = PhoneArea_txt.Text + PhonePrefix_txt.Text + PhoneLine_txt.Text
            Dim BidderPhone2 = PhoneArea2_txt.Text + PhonePrefix2_txt.Text + PhoneLine2_txt.Text
            Dim BidderEmail = Email_txt.Text
            Dim BidderMemo = Memo_rtb.Text

            '*****************************************************
            SQLCmd.CommandType = CommandType.StoredProcedure

            If SAVEbutton = "ADD0" Then
                SQLCmd.CommandText = "uspInsertBidder"
            ElseIf SAVEbutton = "EDIT1" Then
                SQLCmd.CommandText = "uspUpdateBidder"
            End If

            SQLConn.ConnectionString = DBConnectionString
            SQLCmd.Connection = SQLConn

            SQLCmd.Parameters.AddWithValue("@fname", BidderFName)
            SQLCmd.Parameters.AddWithValue("@lname", BidderLName)
            SQLCmd.Parameters.AddWithValue("@address", BidderAddr1)
            SQLCmd.Parameters.AddWithValue("@city", BidderCity)
            SQLCmd.Parameters.AddWithValue("@state", BidderState)
            SQLCmd.Parameters.AddWithValue("@zip", BidderZip)
            SQLCmd.Parameters.AddWithValue("@email", BidderEmail)
            If SAVEbutton = "ADD0" Then
                SQLCmd.Parameters.AddWithValue("@isactive", 1)
            ElseIf SAVEbutton = "EDIT1" Then
                SQLCmd.Parameters.AddWithValue("@isactive", BidderNotActive)
            End If
            SQLCmd.Parameters.AddWithValue("@iskmember", BidderIsKMemeber)
            SQLCmd.Parameters.AddWithValue("@memo", BidderMemo)
            SQLCmd.Parameters.AddWithValue("@phone", BidderPhone)
            SQLCmd.Parameters.AddWithValue("@phone2", BidderPhone2)
            If SAVEbutton = "EDIT1" Then
                SQLCmd.Parameters.AddWithValue("@Bidderid", parBidderID)
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

        ElseIf DiaOkCrslt = DialogResult.Cancel Then
            'RETURNS control to SAVE button / DO NOTHING
        End If

    End Sub

    Sub WhiteOutFormFields()
        'Clear background color from input fields
        FName_txt.BackColor = Color.White
        LName_txt.BackColor = Color.White
        Address1_txt.BackColor = Color.White
        City_txt.BackColor = Color.White
        State_dd.BackColor = Color.White
        ZIPPrefix_txt.BackColor = Color.White
        PhoneArea_txt.BackColor = Color.White
        PhonePrefix_txt.BackColor = Color.White
        PhoneLine_txt.BackColor = Color.White
        PhoneArea2_txt.BackColor = Color.White
        PhonePrefix2_txt.BackColor = Color.White
        PhoneLine2_txt.BackColor = Color.White
        Email_txt.BackColor = Color.White
        Memo_rtb.BackColor = Color.White
    End Sub

    Sub ClearFormFields()
        'Clear data from input fields
        ErrorChckSWstr = "N"

        NotActive_cb.Checked = False
        KMember_cb.Checked = False
        Active_lbl.Text = ""
        lblKiwanis.Text = ""
        Warning_lbl.Text = ""
        BidderID_txt.Clear()
        FName_txt.Clear()
        LName_txt.Clear()
        Address1_txt.Clear()
        City_txt.Clear()
        State_dd.SelectedItem = ""
        ZIPPrefix_txt.Clear()
        PhoneArea_txt.Clear()
        PhonePrefix_txt.Clear()
        PhoneLine_txt.Clear()
        PhoneArea2_txt.Clear()
        PhonePrefix2_txt.Clear()
        PhoneLine2_txt.Clear()
        Email_txt.Clear()
        Memo_rtb.Clear()
        'loadItem(0)
    End Sub
    Public Sub EnableFrom()
        Bidder_lb.Enabled = True
        FormAdd_btn.Enabled = True
        FormCancel_btn.Enabled = True
        'FormDelete_btn.Enabled = True
        FName_txt.ReadOnly = False
        LName_txt.ReadOnly = False
        Address1_txt.ReadOnly = False
        City_txt.ReadOnly = False
        State_dd.Enabled = True
        ZIPPrefix_txt.ReadOnly = False
        PhoneArea_txt.ReadOnly = False
        PhonePrefix_txt.ReadOnly = False
        PhoneLine_txt.ReadOnly = False
        PhoneArea2_txt.ReadOnly = False
        PhonePrefix2_txt.ReadOnly = False
        PhoneLine2_txt.ReadOnly = False
        Email_txt.ReadOnly = False
        Memo_rtb.ReadOnly = False
        NotActive_cb.Enabled = True
        KMember_cb.Enabled = True
    End Sub

    Public Sub DisableFrom()
        MODE_V_lbl.Text = "VIEW"
        MODE_V_lbl.ForeColor = Color.Green
        FormAdd_btn.Enabled = False
        FormCancel_btn.Enabled = False
        FormDelete_btn.Enabled = False
        FName_txt.ReadOnly = True
        LName_txt.ReadOnly = True
        Address1_txt.ReadOnly = True
        City_txt.ReadOnly = True
        State_dd.Enabled = False
        ZIPPrefix_txt.ReadOnly = True
        PhoneArea_txt.ReadOnly = True
        PhonePrefix_txt.ReadOnly = True
        PhoneLine_txt.ReadOnly = True
        PhoneArea2_txt.ReadOnly = True
        PhonePrefix2_txt.ReadOnly = True
        PhoneLine2_txt.ReadOnly = True
        Email_txt.ReadOnly = True
        Memo_rtb.ReadOnly = True
        NotActive_cb.Enabled = False
        KMember_cb.Enabled = False
    End Sub

    Public Sub HighlightErrors()
        '
        'Detect and highlight input errors.
        '
        'Check for empty required input and accumulate error messages
        'for error message prompt box.
        '
        '**************************************************
        '   Name (company  -> Bidder)     
        '**************************************************
        If FName_txt.Text = "" Then
            FName_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Bidder Name - This field may not be empty." & vbCr
        End If
        If LName_txt.Text = "" Then
            FName_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Bidder Name - This field may not be empty." & vbCr
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
        '**************************************************
        '    Phone: area/prefix/line     
        '**************************************************
        'Check for nulls, input length and missing data for Phone 1
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

    Private Sub PhonePrefix_txt_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhonePrefix_txt.TextChanged

    End Sub

    Private Sub chxViewNotActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxViewNotActive.CheckedChanged
        loadBidderID()
    End Sub

    Private Sub KMember_cb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles KMember_cb.CheckedChanged

    End Sub
End Class