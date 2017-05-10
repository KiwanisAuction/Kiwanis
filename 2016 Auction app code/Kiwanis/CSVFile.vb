Imports System.IO
Imports System.Data.SqlClient

Public Class CSVFile

    Private header As String()
    Private comment As String()
    Private labelText As String
    Private myStream As Stream

    Public Function createFile() As Boolean
        Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
        saveFileDialog1.Filter = "All files (*.*)|*.*|Comma Separated Values (*.csv)|*.csv"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        'If file name doesn't contain the 'csv' extension, it will add.
        'If file can be written, it is opened to write and close after the writing finishes.
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FilterIndex <> 2 Then
                saveFileDialog1.FileName = String.Format("{0}{1}", saveFileDialog1.FileName, ".csv")
            End If
            myStream = saveFileDialog1.OpenFile()
        End If
        Return saveFileDialog1.CheckFileExists
    End Function

    Public Sub writeToFile(comment As String(), dataList As ArrayList, label As Label)
        If (myStream IsNot Nothing) Then
            Using sw As StreamWriter = New StreamWriter(myStream)
                'Write comments to file
                For Each c In comment
                    sw.WriteLine("""{0}""", c)
                Next
                'Write header data to file
                'Write data to file
                For Each d In dataList
                    sw.WriteLine(d)
                Next
            End Using
            myStream.Close()
        End If
    End Sub

    'A static method writes database information 
    'with a parameter as a header label, so it displays result to a user.
    Public Sub writeToFile(label As Label, header As String(), comment As String())
        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt|Comma Separated Values (*.csv)|*.csv"
        saveFileDialog1.FilterIndex = 3
        saveFileDialog1.RestoreDirectory = True

        'If file name doesn't contain the 'csv' extension, it will add.
        'If file can be written, it is opened to write and close after the writing finishes.
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            'If saveFileDialog1.FileName.Contains(".csv") = False Or saveFileDialog1.FileName.Contains(".CSV") = False Then
            '    saveFileDialog1.FileName = saveFileDialog1.FileName & ".csv"
            'End If
            myStream = saveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                'assignheaderInfoAndNote(headerName)
                writeDataToFile(myStream, label, header, comment, labelText)
                myStream.Close()
            End If
        End If
    End Sub



    'Connect to the database and get header result using a stored procedure
    'Write result to file
    Private Sub writeDataToFile(myStream As Stream, label As Label, header As String(), comment As String(), labelText As String)
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        'SQLCmd.CommandText = "uspNewspaper"
        SQLCmd.CommandText = header(0)

        Dim DBConnectionString As String = KiwanisConfig.LoadDatabaseConfig
        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader

            If SQLRead.HasRows Then

                Using sw As StreamWriter = New StreamWriter(myStream)

                    For index = 0 To comment.GetUpperBound(0)
                        sw.WriteLine("""" & comment(index) & """")
                    Next
                    For index = 1 To header.GetUpperBound(0) - 1
                        sw.Write(header(index) & ",")
                    Next
                    sw.Write(header(header.GetUpperBound(0)))
                    sw.WriteLine("")

                    While SQLRead.Read
                        Dim temp As String = ""
                        For index = 1 To header.GetUpperBound(0) - 1
                            temp = temp & convertToRightFormat(SQLRead(header(index)) & "") & ","
                        Next
                        temp = temp & convertToRightFormat(SQLRead(header(header.GetUpperBound(0))) & "")
                        sw.WriteLine(temp)

                    End While
                End Using
                label.Text = "Generated " & labelText & " for a CSV file"
            End If
            SQLConn.Close()
        Catch ex As Exception
            label.Text = "Connection Issue :: Unable to retrieve " & labelText & " header."
            MessageBox.Show(ex.ToString)
        Finally
            If SQLConn.State <> ConnectionState.Open Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Function convertToRightFormat(col As String) As String
        col = col.Replace("""", "'")
        If col.Contains(",") Then
            Return """" & col & """"
        ElseIf col.ToLower().Contains("block") Then
            'Block order: Block 1, Block 2, Block 3, ..., Big Block A, Big Block B, Super Block
            'Because the block names are not displayed in block order,
            'it converts 2 last character to a right format for block order in excel
            Dim index = col.Length - 2
            Dim blockName = col.Substring(index, 2)
            col = changeBlockName(blockName)
            Return col
        End If
        Return col
    End Function

    'Convert a block name to lower case
    'Base on block name, it changes to the correct format name, and return it
    Private Function changeBlockName(col As String) As String
        Select Case col.ToLower
            Case " a"
                col = "Block 97-Big Block A"
            Case " b"
                col = "Block 98-Big Block B"
            Case "ck"
                col = "Block 99-Super Block"
            Case Else
                col = "Block " & col.Replace(" "c, "0"c)
        End Select
        Return col
    End Function

End Class
