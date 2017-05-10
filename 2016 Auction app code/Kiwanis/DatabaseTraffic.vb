Public Class DatabaseTraffic
    Private DBConnectionString As String = KiwanisConfig.LoadDatabaseConfig
    Public isSelectSuccess = False


    Public Function getDataFromDatabase(dataList As ArrayList, header As String(), lblMessageBox As Label) As Boolean
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = header(0)

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn
        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader
            'put record into listbox
            If SQLRead.HasRows Then
                Dim temp = ""
                Dim length = header.GetUpperBound(0) - 1
                For index = 1 To length
                    temp += String.Format("{0},", (header(index)))
                Next
                temp += String.Format("{0}", header(header.GetUpperBound(0)))
                dataList.Add(temp)
                temp = ""
                While SQLRead.Read
                    For index = 1 To length
                        temp += String.Format("{0},", SQLRead(header(index)))
                    Next
                    temp += String.Format("{0}", SQLRead(header(header.GetUpperBound(0))))
                    dataList.Add(temp)
                    temp = ""
                End While
            End If
            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue:: Unable to connect to the database"
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
        Return True
    End Function

    'Get blocks' information for the latest year
    Public Sub getBlockFromDataBase(ByVal block As String(,), ByVal blockHeader As String(), ByVal lblMessageBox As Label)
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandText = "dbo.uspSelectAvaileBlocks"
        SQLCmd.CommandType = CommandType.StoredProcedure

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn
        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader
            'put record into listbox
            If SQLRead.HasRows Then
                Dim row = 0
                While SQLRead.Read
                    For index = 0 To blockHeader.GetUpperBound(0)
                        block(row, index) = SQLRead(blockHeader(index)) & ""
                    Next
                    row += 1
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

    Public Sub updateItemStatus(ByVal itemStatus As Integer, ByVal blockName As String, ByVal lblMessageBox As Label)
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspUpdateItemAuctionStatus"

        SQLCmd.Parameters.AddWithValue("@auctionstatus", itemStatus)
        SQLCmd.Parameters.AddWithValue("@blockname", blockName)

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn
        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
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

    Public Function updateDatabase(ByVal storedProcedureName As String, ByVal lblMessageBox As Label) As Boolean
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = storedProcedureName

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn
        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
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
    End Function

    Public Function updateDatabaseWithValue(ByVal storedProcedureName As String, ByVal values As String(), ByVal lblMessageBox As Label) As Boolean
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = storedProcedureName

        For index = 0 To values.GetUpperBound(0)
            SQLCmd.Parameters.AddWithValue(values(index), values(index + 1))
            index += 1
        Next

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn
        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue:: Unable to connect to the database"
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
        Return True
    End Function

    Public Function getDataWithQuery(query As String, header As String()) As String(,)
        Dim SQLConn As New SqlConnection() 'The SQL Connection for loadActiveBlock
        Dim SQLCmd As New SqlCommand() 'The SQL Command for loadActiveBlock
        Dim SQLRead As SqlDataReader 'The Local Data Store for loadActiveBlock

        SQLCmd.CommandType = CommandType.Text

        SQLCmd.CommandText = query

        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Dim blocks(11, header.GetUpperBound(0)) As String
        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader

            If SQLRead.HasRows = True Then 'check for retrived data
                Dim row = 0
                While SQLRead.Read
                    For col = 0 To header.GetUpperBound(0)
                        blocks(row, col) = SQLRead(header(col)) & ""
                    Next
                End While
            End If
            SQLConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
        Return blocks
    End Function
End Class
