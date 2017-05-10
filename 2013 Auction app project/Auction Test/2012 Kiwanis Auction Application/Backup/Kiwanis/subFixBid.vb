Imports System.Data.SqlClient

Public Class FixBid

    Public Conn_CMD As String = KDBConnect.loadKDMConnect

    Private Sub subFixBid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BidderID2_lbl.Text = BiddingHistory.ErrorBidderID
        ItemID2_lbl.Text = BiddingHistory.ErrorItemID
        HighBidAdj_txt.Text = BiddingHistory.ErrorBid

    End Sub
    Private Sub Save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_btn.Click

        Dim ErrorBid As String = HighBidAdj_txt.Text
        Dim ErrorItemID As String = BiddingHistory.ErrorItemID
        Dim ErrorBidderID As String = BiddingHistory.ErrorBidderID

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandType = CommandType.StoredProcedure

        SQLCmd.CommandText = "uspDeleteBadBid"

        SQLCmd.Parameters.AddWithValue("@itemidtochange", ErrorItemID)
        SQLCmd.Parameters.AddWithValue("@bidamounttochange", ErrorBid)

        SQLConn.ConnectionString = Conn_CMD
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
        Catch ex As Exception
            'lblMessageBox.Text = "Connection Issue :: Unable to connect to the database."
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try

        Me.Visible = False
        BiddingHistory.Enabled = True

    End Sub

    Private Sub Cancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_btn.Click

        Me.Visible = False
        BiddingHistory.Enabled = True

    End Sub

End Class