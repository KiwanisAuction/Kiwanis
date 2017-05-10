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
'************************************************************************************
' This version with edits by John Hicks
' 
' 
' 02/11/2013
'************************************************************************************


Public Class Main

    'declare public variables
    Public dateString As String = ("2/28/" & Year(Today))
    Public dateYear As Date = DateTime.Parse(dateString) ' Need to fix this

    Public serverTime As Date
    Public connString As String = KiwanisConfig.LoadDatabaseConfig
    Public adminPass As String = KiwanisConfig.GetConfigValue("cAAdminPass").ToUpper
    Public auctPass As String = KiwanisConfig.GetConfigValue("cAAuctPass").ToUpper
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnPlaceBid.Enabled = KiwanisConfig.GetConfigValue("cPlaceBidEnable")
    End Sub

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        K_DBCC.Enabled = True
        K_DBCC.Visible = True
        Me.Enabled = False
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