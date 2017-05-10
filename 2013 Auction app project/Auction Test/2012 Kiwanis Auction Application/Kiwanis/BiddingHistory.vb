Imports System.Data.SqlClient

Public Class BiddingHistory

    ' Database connection and query globals
    Public DBConnectionString As String = KiwanisConfig.LoadDatabaseConfig

    Public ErrorBlockID As String = ""
    Public ErrorBid As String = ""
    Public ErrorItemID As String = ""
    Public ErrorBidderID As String = ""

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Visible = True
        Me.Close()
    End Sub

    Private Sub ThisFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub BiddingHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadBlockID()
    End Sub

    Private Sub loadBlockID()

        Dim intCount As Integer = 1

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandText = "SELECT DISTINCT(Items.ItemBlockID), Items.ItemAuctionStatus, Items.ItemDateDonated, " & _
                                   "Blocks.BlockName, Blocks.BlockType, Blocks.BlockSchedStartTime, Blocks.BlockSchedDuration " & _
                                   "FROM Items INNER JOIN Blocks ON Items.ItemBlockID = Blocks.BlockID " & _
                                   "WHERE Items.ItemDateDonated = dbo.ufnNextAuctionDate()"

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLRead = SQLCmd.ExecuteReader

        Try

            'clear all item in list box
            lbAvailableBlock.Items.Clear()

            'put record into listbox
            While SQLRead.Read
                If SQLRead("ItemDateDonated") > Main.dateLastYear Then
                    lbAvailableBlock.Items.Add(SQLRead("BlockName").ToString)
                End If
            End While

            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue:: Unable to connect to the database"
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lbAvailableBlock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbAvailableBlock.SelectedIndexChanged
        loadBidHistory(Me.lbAvailableBlock.SelectedItem.ToString)
    End Sub

    Private Sub loadBidHistory(ByRef strBlock As String)

        Dim strPosPre As String = ""
        Dim strPos As String = ""
        Dim strItemID As String = ""
        Dim strDesc As String = ""
        Dim strBid As String = ""
        Dim strBidderID As String = ""

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandText = "SELECT Items.ItemID, Items.ItemBlockPos, Items.ItemDesc, ItemBidLog.BidAmount, ItemBidLog.BidderID " & _
                                "FROM (Blocks INNER JOIN Items ON Blocks.BlockID = Items.ItemBlockID) " & _
                                "INNER JOIN ItemBidLog ON Items.ItemID = ItemBidLog.ItemID " & _
                                "WHERE(((Blocks.BlockName) = '" & strBlock & "'))" & _
                                "ORDER BY Items.ItemBlockPos, ItemBidLog.BidAmount DESC"

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        SQLConn.Open()
        SQLRead = SQLCmd.ExecuteReader

        DataGridView1.Rows.Clear()
        If SQLRead.HasRows Then
            While SQLRead.Read

                strPos = SQLRead("ItemBlockPos").ToString
                If strPos <> strPosPre Then
                    strPos = SQLRead("ItemBlockPos").ToString
                    strItemID = SQLRead("ItemID").ToString
                    strDesc = SQLRead("ItemDesc").ToString & " - (Item ID: " & SQLRead("ItemID").ToString & ")"
                    strPosPre = strPos
                Else
                    strPos = ""
                    strDesc = ""
                End If

                strBid = Format(SQLRead("BidAmount"), "#####")
                strBidderID = SQLRead("BidderID").ToString

                'Seperate items with blank row for readability
                If strPos = "1" Then
                    ' DO NOTHING !!! IF first item.
                ElseIf strPos <> "" Then ' If item postion is present, insert blank row
                    DataGridView1.Rows.Add("")
                End If

                Dim strRow As String() = {strPos, strItemID, strDesc, strBid, strBidderID}

                DataGridView1.Columns("BidAmount").DefaultCellStyle.Format = "c"
                DataGridView1.Rows.Add(strRow) ' Insert item and bid information
            End While
        End If
        SQLConn.Close()

    End Sub

    Public Sub FixBid_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FixBid_btn.Click

        Dim rowNum As Integer = 0

        rowNum = DataGridView1.CurrentRow.Index
        ErrorBlockID = DataGridView1.Item(0, rowNum).Value()
        ErrorItemID = DataGridView1.Item(1, rowNum).Value()
        ErrorBid = DataGridView1.Item(3, rowNum).Value()
        ErrorBidderID = DataGridView1.Item(4, rowNum).Value()

        Me.Enabled = False
        Dim subFixBid As New FixBid
        subFixBid.Visible = True

        ErrorBlockID = ""
        ErrorItemID = ""
        ErrorBid = ""
        ErrorBidderID = ""

    End Sub
End Class