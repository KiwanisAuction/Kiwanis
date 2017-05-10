Imports System.Text.RegularExpressions
Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Public Class KiwanisMem
    'Global Variables
    Public arKiwanisMem(99999, 12) As String
    Public ErrorChckSWstr As String
    Public SAVEbutton As String
    Public ErrMsgStr As String
    Public DiaOkCrslt As DialogResult

    Public DBConnectionString As String = KiwanisConfig.LoadDatabaseConfig

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOCK AND LOAD initial application defualts
        ErrorChckSWstr = "N"
        NotActive_cb.Checked = False
        cbxViewNotActive.Checked = False
        Active_lbl.Text = ""
        lblKiwanis.Text = ""
        Warning_lbl.Text = ""

        FormAdd_btn.Enabled = False
        FormCancel_btn.Enabled = False
        FormDelete_btn.Enabled = False


        FName_txt.ReadOnly = True
        LName_txt.ReadOnly = True
        Address_txt.ReadOnly = True

        City_txt.ReadOnly = True
        State_dd.Enabled = False
        ZIPPrefix_txt.ReadOnly = True
        PhoneArea_txt.ReadOnly = True
        PhonePrefix_txt.ReadOnly = True
        PhoneLine_txt.ReadOnly = True
        MemWorkPhoneArea_txt.ReadOnly = True
        MemWorkPhonePrefix_txt.ReadOnly = True
        MemWorkPhoneLine_txt.ReadOnly = True
        Email_txt.ReadOnly = True
        Memo_rtb.ReadOnly = True
        NotActive_cb.Enabled = False
        cbxViewNotActive.Enabled = True

        FName_txt.ForeColor = Color.Black
        LName_txt.ForeColor = Color.Black
        Address_txt.ForeColor = Color.Black
        City_txt.ForeColor = Color.Black
        ZIPPrefix_txt.ForeColor = Color.Black
        PhoneArea_txt.ForeColor = Color.Black
        PhonePrefix_txt.ForeColor = Color.Black
        PhoneLine_txt.ForeColor = Color.Black
        MemWorkPhoneArea_txt.ForeColor = Color.Black
        MemWorkPhonePrefix_txt.ForeColor = Color.Black
        MemWorkPhoneLine_txt.ForeColor = Color.Black
        Email_txt.ForeColor = Color.Black
        Memo_rtb.ForeColor = Color.Black


        WhiteOutFormFields() 'Clear and correct form color
        loadKiwanisMemID() 'LOAD KiwanisMems to KiwanisMem_lb and generate KiwanisMem array

    End Sub

    Private Sub lstbKiwanis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstbKiwanis.SelectedIndexChanged

        NotActive_cb.Checked = False
        Active_lbl.Text = ""
        lblKiwanis.Text = ""

        'ON SELECTION of a KiwanisMem > retrieve data from KiwanisMem array
        If lstbKiwanis.SelectedItem.ToString <> "" Then
            Dim intPos As Integer = lstbKiwanis.SelectedIndex
            Dim MemberID As Integer = arKiwanisMem(intPos, 0)
            Dim MemFName = arKiwanisMem(intPos, 1)
            Dim MemLName = arKiwanisMem(intPos, 2)
            Dim MemAddr1 = arKiwanisMem(intPos, 3)
            Dim MemCity = arKiwanisMem(intPos, 4)
            Dim MemState = arKiwanisMem(intPos, 5)
            Dim MemZip = arKiwanisMem(intPos, 6)
            Dim MemEmail = arKiwanisMem(intPos, 7)
            Dim MemInActive = arKiwanisMem(intPos, 8)
            Dim MemMemo = arKiwanisMem(intPos, 9)
            Dim MemPhone = arKiwanisMem(intPos, 10)
            Dim PhoneArea As String = ""
            Dim PhonePrefix As String = ""
            Dim PhoneLine As String = ""
            If MemPhone <> "" Then
                PhoneArea = MemPhone.Substring(0, 3)
                PhonePrefix = MemPhone.Substring(3, 3)
                PhoneLine = MemPhone.Substring(6, 4)
            End If
            Dim MemWorkPhone = arKiwanisMem(intPos, 11)
            Dim MemWorkPhoneArea As String = ""
            Dim MemWorkPhonePrefix As String = ""
            Dim MemWorkPhoneLine As String = ""

            If MemWorkPhone <> "" Then
                MemWorkPhoneArea = MemWorkPhone.Substring(0, 3)
                MemWorkPhonePrefix = MemWorkPhone.Substring(3, 3)
                MemWorkPhoneLine = MemWorkPhone.Substring(6, 4)
            End If
            PhoneArea_txt.Text = PhoneArea
            PhonePrefix_txt.Text = PhonePrefix
            PhoneLine_txt.Text = PhoneLine
            MemWorkPhoneArea_txt.Text = MemWorkPhoneArea
            MemWorkPhonePrefix_txt.Text = MemWorkPhonePrefix
            MemWorkPhoneLine_txt.Text = MemWorkPhoneLine

            'POPULATE the KiwanisMem form
            MemberID_txt.Text = MemberID
            FName_txt.Text = MemFName
            LName_txt.Text = MemLName
            Address_txt.Text = MemAddr1
            City_txt.Text = MemCity
            Select Case MemState
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
            ZIPPrefix_txt.Text = MemZip
            Email_txt.Text = MemEmail
            Memo_rtb.Text = MemMemo
            'PhoneArea_txt.Text = PhoneArea
            'PhonePrefix_txt.Text = PhonePrefix
            'PhoneLine_txt.Text = PhoneLine
            'MemWorkPhoneArea_txt.Text = MemWorkPhoneArea
            'MemWorkPhonePrefix_txt.Text = MemWorkPhonePrefix
            'MemWorkPhoneLine_txt.Text = MemWorkPhoneLine
            If MemInActive = "True" Then
                NotActive_cb.Checked = True
                Active_lbl.Text = "NOT ACTIVE"
            End If

        End If

    End Sub

    Private Sub AddKiwanisMem_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddKiwanisMem_btn.Click
        '   ADD button: Clear and unlock form to insert data
        MODE_V_lbl.Text = "ADD"
        MODE_V_lbl.ForeColor = Color.Goldenrod

        EnableFrom()
        ClearFormFields()
        lstbKiwanis.Enabled = False
        EditKiwanisMem_btn.Enabled = False

        SAVEbutton = "ADD0"
    End Sub

    Private Sub EditKiwanisMem_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditKiwanisMem_btn.Click
        '   EDIT button: Unlock form for editing
        If MemberID_txt.Text = "" Then
            MessageBox.Show("Please select a Kiwanis Member to edit!", "Edit Kiwanis Members")
        Else
            EnableFrom()
            MODE_V_lbl.Text = "EDIT"
            MODE_V_lbl.ForeColor = Color.Red
            SAVEbutton = "EDIT1"
            lstbKiwanis.Enabled = False
            AddKiwanisMem_btn.Enabled = False
        End If
    End Sub

    Private Sub BacktoMain_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BacktoMain_btn.Click
        '   BACK to main menu
        Me.Hide()
        Main.Visible = True 'REMOVE FROM COMMENT WHEN IN APP
        Me.Close()
        'Close()
    End Sub

    Private Sub FormAdd_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormAdd_btn.Click
        '   ADD button for UPDATING or INSERTING KiwanisMem information
        '   *** Triggers form validation ***
        HighlightErrors()
        Select Case ErrorChckSWstr
            Case "Y"
                InsertUpdateKiwanisMem(MemberID_txt.Text)
                ErrorChckSWstr = "N" 'RESETS validation routine for next attempt
                If DiaOkCrslt = DialogResult.OK Then
                    ClearFormFields()
                    DisableFrom()
                    loadKiwanisMemID()
                    lstbKiwanis.Enabled = True
                    AddKiwanisMem_btn.Enabled = True
                    EditKiwanisMem_btn.Enabled = True
                Else
                    FName_txt.Focus()
                End If
        End Select
    End Sub

    Private Sub FormCancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormCancel_btn.Click
        'CANCEL button: locks form and clears data
        WhiteOutFormFields()
        ClearFormFields()
        DisableFrom()
        lstbKiwanis.Enabled = True
        EditKiwanisMem_btn.Enabled = True
        AddKiwanisMem_btn.Enabled = True
    End Sub
    Private Sub FormDelete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormDelete_btn.Click
        '   DELETE button: "Deletes" ONLY KiwanisMem form database < sets KiwanisMem to inactive (will not be queried).
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

    Private Sub Address1_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Address_txt.TextChanged
        Address_txt.BackColor = Color.White
    End Sub

    Private Sub City_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles City_txt.TextChanged
        City_txt.BackColor = Color.White
    End Sub

    Private Sub State_dd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles State_dd.SelectedIndexChanged
        State_dd.BackColor = Color.White
    End Sub
    Private Sub PhonePrefix_txt_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhonePrefix_txt.TextChanged
        PhonePrefix_txt.BackColor = Color.White
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

    Private Sub MemWorkPhoneArea_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MemWorkPhoneArea_txt.KeyPress

        If MemWorkPhoneArea_txt.TextLength = 3 And Not e.KeyChar = ChrW(Keys.Back) Then
            MemWorkPhonePrefix_txt.Focus()
            MemWorkPhonePrefix_txt.Text = e.KeyChar
            MemWorkPhonePrefix_txt.SelectionStart = MemWorkPhonePrefix_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        MemWorkPhoneArea_txt.BackColor = Color.White
    End Sub

    Private Sub MemWorkPhonePrefix_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MemWorkPhonePrefix_txt.KeyPress
        If MemWorkPhonePrefix_txt.TextLength = 3 And Not e.KeyChar = ChrW(Keys.Back) Then
            MemWorkPhoneLine_txt.Focus()
            MemWorkPhoneLine_txt.Text = e.KeyChar
            MemWorkPhoneLine_txt.SelectionStart = MemWorkPhoneLine_txt.TextLength
        ElseIf MemWorkPhonePrefix_txt.TextLength < 1 And e.KeyChar = ChrW(Keys.Back) Then
            MemWorkPhoneArea_txt.Focus()
            MemWorkPhoneArea_txt.SelectionStart = MemWorkPhoneArea_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        MemWorkPhonePrefix_txt.BackColor = Color.White
    End Sub

    Private Sub MemWorkPhoneLine_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MemWorkPhoneLine_txt.KeyPress

        If MemWorkPhoneLine_txt.TextLength < 1 And e.KeyChar = ChrW(Keys.Back) Then
            MemWorkPhonePrefix_txt.Focus()
            MemWorkPhonePrefix_txt.SelectionStart = MemWorkPhonePrefix_txt.TextLength
        End If
        '
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar = ChrW(Keys.Back))) Then
            e.KeyChar = ""
        End If
        MemWorkPhoneLine_txt.BackColor = Color.White
    End Sub
    '*******************************************************************
    'SUBROUTINES
    '*******************************************************************
    '
    Private Sub loadKiwanisMemID()
        lstbKiwanis.Items.Clear()

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRd As SqlDataReader 'The Local Data Store

        'Genrates an array and populates a listbox of KiwanisMems and KiwanisMem information
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspSelectKiwanisMembers"

        SQLConn.ConnectionString = DBConnectionString

        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLRd = SQLCmd.ExecuteReader

        Try
            Dim intCount As Integer = 0
            If SQLRd.HasRows Then

                'While SQLRd.HasRows
                While SQLRd.Read

                   
                    If cbxViewNotActive.Checked = True And SQLRd("MemInActive") = True Then

                        arKiwanisMem(intCount, 0) = SQLRd("MemberID").ToString
                        arKiwanisMem(intCount, 1) = SQLRd("MemLName").ToString
                        arKiwanisMem(intCount, 2) = SQLRd("MemFName").ToString
                        arKiwanisMem(intCount, 3) = SQLRd("MemAddr").ToString
                        arKiwanisMem(intCount, 4) = SQLRd("MemCity").ToString
                        arKiwanisMem(intCount, 5) = SQLRd("MemState").ToString
                        arKiwanisMem(intCount, 6) = SQLRd("MemZip").ToString
                        arKiwanisMem(intCount, 7) = SQLRd("MemEmail").ToString
                        arKiwanisMem(intCount, 8) = SQLRd("MemInActive").ToString
                        arKiwanisMem(intCount, 9) = SQLRd("MemMemo").ToString
                        arKiwanisMem(intCount, 10) = SQLRd("MemPhone").ToString
                        arKiwanisMem(intCount, 11) = SQLRd("MemWorkPhone").ToString


                        lstbKiwanis.Items.Add(SQLRd("MemLName").ToString & " " & SQLRd("MemFName").ToString)

                        intCount += 1

                    End If

                    If SQLRd("MemInActive") = False And cbxViewNotActive.Checked = False Then

                        arKiwanisMem(intCount, 0) = SQLRd("MemberID").ToString
                        arKiwanisMem(intCount, 1) = SQLRd("MemLName").ToString
                        arKiwanisMem(intCount, 2) = SQLRd("MemFName").ToString
                        arKiwanisMem(intCount, 3) = SQLRd("MemAddr").ToString
                        arKiwanisMem(intCount, 4) = SQLRd("MemCity").ToString
                        arKiwanisMem(intCount, 5) = SQLRd("MemState").ToString
                        arKiwanisMem(intCount, 6) = SQLRd("MemZip").ToString
                        arKiwanisMem(intCount, 7) = SQLRd("MemEmail").ToString
                        arKiwanisMem(intCount, 8) = SQLRd("MemInActive").ToString
                        arKiwanisMem(intCount, 9) = SQLRd("MemMemo").ToString
                        arKiwanisMem(intCount, 10) = SQLRd("MemPhone").ToString
                        arKiwanisMem(intCount, 11) = SQLRd("MemWorkPhone").ToString


                        lstbKiwanis.Items.Add(SQLRd("MemLName").ToString & " " & SQLRd("MemFName").ToString)

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




    Private Sub InsertUpdateKiwanisMem(ByVal parMemberID)

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        Dim MsgBM As String = ""
        Dim MsgBT As String = ""
        Select Case SAVEbutton
            Case Is = "ADD0"
                MsgBM = "NEW data is about to be added to the database! Are you sure you would like to proceed?"
                MsgBT = "ADD Kiwanis Member"
            Case Is = "EDIT1"
                MsgBM = "Data is about to be added to the database! Are you sure you would like to proceed?"
                MsgBT = "EDIT Kiwanis Member"
        End Select

        DiaOkCrslt = MessageBox.Show(MsgBM, MsgBT, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If DiaOkCrslt = DialogResult.OK Then
            Dim MemFName = FName_txt.Text
            Dim MemLName = LName_txt.Text
            Dim MemAddr1 = Address_txt.Text
            Dim MemCity = City_txt.Text
            Dim MemState = State_dd.SelectedItem
            Dim MemZip = ZIPPrefix_txt.Text
            Dim MemInActive As Integer

            If NotActive_cb.Checked = True Then
                MemInActive = 1
            ElseIf NotActive_cb.Checked = False Then
                MemInActive = 0
            End If
            Dim MemPhone = PhoneArea_txt.Text + PhonePrefix_txt.Text + PhoneLine_txt.Text
            Dim MemWorkPhone = MemWorkPhoneArea_txt.Text + MemWorkPhonePrefix_txt.Text + MemWorkPhoneLine_txt.Text
            Dim MemEmail = Email_txt.Text
            Dim MemMemo = Memo_rtb.Text

            '*****************************************************
            SQLCmd.CommandType = CommandType.StoredProcedure

            If SAVEbutton = "ADD0" Then
                SQLCmd.CommandText = "uspInsertKiwanisMembers"
            ElseIf SAVEbutton = "EDIT1" Then
                SQLCmd.CommandText = "uspUpdateKiwanisMembers"
            End If

            SQLConn.ConnectionString = DBConnectionString
            SQLCmd.Connection = SQLConn

            SQLCmd.Parameters.AddWithValue("@fname", MemFName)
            SQLCmd.Parameters.AddWithValue("@lname", MemLName)
            SQLCmd.Parameters.AddWithValue("@address", MemAddr1)
            SQLCmd.Parameters.AddWithValue("@city", MemCity)
            SQLCmd.Parameters.AddWithValue("@state", MemState)
            SQLCmd.Parameters.AddWithValue("@zip", MemZip)
            SQLCmd.Parameters.AddWithValue("@email", MemEmail)
            If SAVEbutton = "ADD0" Then
                SQLCmd.Parameters.AddWithValue("@inactive", 0)
            ElseIf SAVEbutton = "EDIT1" Then
                SQLCmd.Parameters.AddWithValue("@inactive", MemInActive)
            End If

            SQLCmd.Parameters.AddWithValue("@memo", MemMemo)
            SQLCmd.Parameters.AddWithValue("@phone", MemPhone)
            SQLCmd.Parameters.AddWithValue("@workphone", MemWorkPhone)
            If SAVEbutton = "EDIT1" Then
                SQLCmd.Parameters.AddWithValue("@memberid", parMemberID)
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
        Address_txt.BackColor = Color.White
        City_txt.BackColor = Color.White
        State_dd.BackColor = Color.White
        ZIPPrefix_txt.BackColor = Color.White
        PhoneArea_txt.BackColor = Color.White
        PhonePrefix_txt.BackColor = Color.White
        PhoneLine_txt.BackColor = Color.White
        MemWorkPhoneArea_txt.BackColor = Color.White
        MemWorkPhonePrefix_txt.BackColor = Color.White
        MemWorkPhoneLine_txt.BackColor = Color.White
        Email_txt.BackColor = Color.White
        Memo_rtb.BackColor = Color.White
    End Sub

    Sub ClearFormFields()
        'Clear data from input fields
        ErrorChckSWstr = "N"

        NotActive_cb.Checked = False
        Active_lbl.Text = ""
        lblKiwanis.Text = ""
        Warning_lbl.Text = ""
        MemberID_txt.Clear()
        FName_txt.Clear()
        LName_txt.Clear()
        Address_txt.Clear()
        City_txt.Clear()
        State_dd.SelectedItem = ""
        ZIPPrefix_txt.Clear()
        PhoneArea_txt.Clear()
        PhonePrefix_txt.Clear()
        PhoneLine_txt.Clear()
        MemWorkPhoneArea_txt.Clear()
        MemWorkPhonePrefix_txt.Clear()
        MemWorkPhoneLine_txt.Clear()
        Email_txt.Clear()
        Memo_rtb.Clear()
        'loadItem(0)
    End Sub
    Public Sub EnableFrom()
        lstbKiwanis.Enabled = True
        FormAdd_btn.Enabled = True
        FormCancel_btn.Enabled = True
        'FormDelete_btn.Enabled = True
        FName_txt.ReadOnly = False
        LName_txt.ReadOnly = False
        Address_txt.ReadOnly = False
        City_txt.ReadOnly = False
        State_dd.Enabled = True
        ZIPPrefix_txt.ReadOnly = False
        PhoneArea_txt.ReadOnly = False
        PhonePrefix_txt.ReadOnly = False
        PhoneLine_txt.ReadOnly = False
        MemWorkPhoneArea_txt.ReadOnly = False
        MemWorkPhonePrefix_txt.ReadOnly = False
        MemWorkPhoneLine_txt.ReadOnly = False
        Email_txt.ReadOnly = False
        Memo_rtb.ReadOnly = False
        NotActive_cb.Enabled = True
    End Sub

    Public Sub DisableFrom()
        MODE_V_lbl.Text = "VIEW"
        MODE_V_lbl.ForeColor = Color.Green
        FormAdd_btn.Enabled = False
        FormCancel_btn.Enabled = False
        FormDelete_btn.Enabled = False
        FName_txt.ReadOnly = True
        LName_txt.ReadOnly = True
        Address_txt.ReadOnly = True
        City_txt.ReadOnly = True
        State_dd.Enabled = False
        ZIPPrefix_txt.ReadOnly = True
        PhoneArea_txt.ReadOnly = True
        PhonePrefix_txt.ReadOnly = True
        PhoneLine_txt.ReadOnly = True
        MemWorkPhoneArea_txt.ReadOnly = True
        MemWorkPhonePrefix_txt.ReadOnly = True
        MemWorkPhoneLine_txt.ReadOnly = True
        Email_txt.ReadOnly = True
        Memo_rtb.ReadOnly = True
        NotActive_cb.Enabled = False
    End Sub

    Public Sub HighlightErrors()
        '
        'Detect and highlight input errors.
        '
        'Check for empty required input and accumulate error messages
        'for error message prompt box.
        '
        '**************************************************
        '   Name (company  -> KiwanisMem)     
        '**************************************************
        If FName_txt.Text = "" Then
            FName_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Kiwanis Member Name - This field may not be empty." & vbCr
        End If
        If LName_txt.Text = "" Then
            FName_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Kiwanis Member Name - This field may not be empty." & vbCr
        End If
        '**************************************************
        '   Address/State/ZIP    
        '**************************************************
        If Address_txt.Text = "" Then
            Address_txt.BackColor = Color.LightGreen
            ErrMsgStr += "Missing Address  - This field may not be empty." & vbCr
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


    '
    'Private Sub MemberID_txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles MemberID_txt.TextChanged
    '
    'End Sub
    '
    'Private Sub AppLabel_Click(sender As System.Object, e As System.EventArgs) Handles AppLabel.Click
    '
    'End Sub
    '
    'Private Sub MODE_V_lbl_Click(sender As System.Object, e As System.EventArgs) Handles MODE_V_lbl.Click
    '
    'End Sub
    '
    '
    'Private Sub Memo_rtb_TextChanged(sender As System.Object, e As System.EventArgs) Handles Memo_rtb.TextChanged
    '
    'End Sub

    ' Private Sub lstbKiwanis_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstbKiwanis.SelectedIndexChanged

    ' End Sub

    'Private Sub NotActive_cb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles NotActive_cb.CheckedChanged

    ' End Sub

    Private Sub cbxViewNotActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxViewNotActive.CheckedChanged
        loadKiwanisMemID()
    End Sub
End Class