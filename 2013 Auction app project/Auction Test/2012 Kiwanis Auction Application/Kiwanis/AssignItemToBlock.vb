
Option Explicit On
Option Compare Text
Option Infer On
Imports System.Data.SqlClient

Public Class AssignItemToBlock

    Private DebugFlag As Boolean = True 'FALSE FOR RELEASE
    Private m_MouseIsDown As Boolean
    Private lIndex As Integer
    Private liItem1Max, rIndex As UShort
    Private liItem2Max As UInteger
    Private liItem1(11) As arFormat
    Private liItem2() As arFormat
    Private ItemAssignedList(0 To 10) As Label
    Private DBConnectionString As String = KiwanisConfig.LoadDatabaseConfig
    Private Const UP As Integer = 1
    Private Const DOWN As Integer = -1

    Private Class arFormat

        Friend ItemID As String
        Friend ItemDesc As String
        Friend ItemBlockPos As String
        Friend ItemBlockID As String

        Friend Sub New(ByVal ItemIDi As String, ByVal ItemDesci As String, ByVal ItemBlockPosi As String, ByVal ItemblockIDi As String)
            ItemID = ItemIDi
            ItemDesc = ItemDesci
            ItemBlockPos = ItemBlockPosi
            ItemBlockID = ItemblockIDi
        End Sub

        Friend Sub New()
            ItemID = ""
            ItemDesc = ""
            ItemBlockPos = ""
            ItemBlockID = ""
        End Sub

        Public Overrides Function ToString() As String
            If ItemID.ToString <> "" Then
                Return (ItemID.ToString & " - " & ItemDesc.ToString)
            Else
                Return ""
            End If
        End Function

    End Class

    Private Sub ItemAssignedList_CLear()
        For Each label In ItemAssignedList
            label.Text = ""
        Next
    End Sub


    Private Sub ItemAssignedList_Init()
        ItemAssignedList(0) = ItemAssigned0
        ItemAssignedList(1) = ItemAssigned1
        ItemAssignedList(2) = ItemAssigned2
        ItemAssignedList(3) = ItemAssigned3
        ItemAssignedList(4) = ItemAssigned4
        ItemAssignedList(5) = ItemAssigned5
        ItemAssignedList(6) = ItemAssigned6
        ItemAssignedList(7) = ItemAssigned7
        ItemAssignedList(8) = ItemAssigned8
        ItemAssignedList(9) = ItemAssigned9
        ItemAssignedList(10) = ItemAssigned10
        Call ItemAssignedList_CLear()
    End Sub

    Private Sub ItemAssignedList_Set(ByRef TextVal As String, ByRef index As Integer)
        ItemAssignedList(index).Text = TextVal
    End Sub

    Private Sub ItemAssignedList_SetList()
        Dim intCount1 As Integer
        Call ItemAssignedList_CLear()
        While intCount1 < 11
            ItemAssignedList_Set(liItem1(intCount1).ToString, intCount1)
            intCount1 += 1
        End While
    End Sub

    Private Sub getBlockID()
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandText = "uspSelectBlocksCurrentAuction"
        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader()

            If SQLRead.HasRows = True Then
                While SQLRead.Read
                    cbBlockID.Items.Add(SQLRead("BlockID"))
                    cbBlockName.Items.Add(SQLRead("BlockName"))
                End While
            End If

        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to access the database."
            MessageBox.Show(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Visible = True
        Me.Close()
    End Sub

    Private Sub AssignItemToBlock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub AssignItemToBlock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Enabled = False
        Call getBlockID()
        AssignedBlockID_lbl.Text = ""
        Call ItemAssignedList_Init()
        Me.Enabled = True
    End Sub


    Private Sub cbBlockName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBlockName.SelectedIndexChanged
        cbBlockID.SelectedIndex = cbBlockName.SelectedIndex
        AssignedBlockID_lbl.Text = cbBlockName.SelectedItem.ToString
    End Sub


    Private Sub removeBlockIDfromItem(ByVal ID As String)

        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command

        SQLCmd.CommandText = "UPDATE Items SET ItemBlockID = NULL, ItemBlockPos = NULL WHERE ItemID = '" & ID & "'"
        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Try
            SQLConn.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to access the database."
            MessageBox.Show(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try
    End Sub

    Private Sub cbBlockID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBlockID.SelectedIndexChanged
        cbBlockName.SelectedIndex = cbBlockID.SelectedIndex
        AssignedBlockID_lbl.Text = cbBlockName.SelectedItem.ToString
        Call loadItem()
    End Sub

    Sub MoveItemRight(ByVal input As Integer)
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store
        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn
        If lbItemAvail.SelectedIndex > -1 And cbBlockID.Text <> "" Then
            Try

                SQLCmd.CommandText = "SELECT ItemID, ItemDesc, ItemBlockPos, ItemBlockID FROM Items WHERE ItemDateDonated = dbo.ufnNextAuctionDate() AND ItemBlockID = " & cbBlockID.Text & " AND ItemBlockPos = " & input.ToString
                SQLConn.Open()
                SQLRead = SQLCmd.ExecuteReader()
                liItem1Max = 0
                If SQLRead.HasRows = True Then
                    If SQLRead.Read Then
                        If SQLRead("ItemBlockPos") = input.ToString Then
                            If MsgBox("That space is occupied, would you like to overwrite it?", CType(1, MsgBoxStyle)) = 1 Then
                                SQLConn.Close()
                                SQLCmd.CommandText = "UPDATE Items SET ItemBlockID = NULL, ItemBlockPos = NULL WHERE ItemID = '" & liItem1(input).ItemID & "'"
                                SQLConn.Open()
                                SQLCmd.ExecuteNonQuery()
                            Else : Exit Sub
                            End If
                        End If
                    End If
                End If
                SQLConn.Close()

                SQLCmd.CommandText = "UPDATE Items SET ItemBlockID = '" & cbBlockID.Text & "'," & "ItemBlockPos = '" & input.ToString & "' WHERE ItemID = '" & liItem2(lbItemAvail.SelectedIndex).ItemID.ToString & "'"
                SQLConn.Open()
                SQLCmd.ExecuteNonQuery()
                Call loadItem()

            Catch ex As Exception
                lblMessageBox.Text = "Connection Issue :: Unable to access the database."
                MessageBox.Show(ex.Message)
            Finally
                If SQLConn.State <> ConnectionState.Closed Then
                    SQLConn.Close()
                End If
                SQLCmd.Dispose()
            End Try
        End If
    End Sub

    Private Sub swapBlockPos(ByVal index1 As Integer, ByVal direction As Integer)
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store
        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn
        Dim index2 As Integer = 0
        Dim item1ID As String = ""
        Dim item2ID As String = ""
        Dim index1Empty, index2Empty As Boolean
        If direction = 1 Then
            If index1 < 10 Then
                index2 = index1 + 1
            ElseIf index1 = 10 Then
                index2 = 1
            End If
        Else
            If index1 > 1 Then
                index2 = index1 - 1
            ElseIf index1 = 1 Then
                index2 = 10
            End If
        End If


        Try
            If cbBlockID.Text <> "" Then
                SQLCmd.CommandText = "SELECT ItemID, ItemBlockPos, ItemBlockID FROM Items WHERE ItemDateDonated = dbo.ufnNextAuctionDate() AND ItemBlockID = " & cbBlockID.Text & " AND ItemBlockPos = " & index1.ToString
                SQLConn.Open()
                SQLRead = SQLCmd.ExecuteReader()
                If SQLRead.HasRows = True Then
                    If SQLRead.Read Then
                        index1Empty = Not (SQLRead("ItemBlockPos") = index1.ToString)
                        item1ID = SQLRead("ItemID")
                    End If
                End If
                SQLConn.Close()

                SQLCmd.CommandText = "SELECT ItemID, ItemBlockPos, ItemBlockID FROM Items WHERE ItemDateDonated = dbo.ufnNextAuctionDate() AND ItemBlockID = " & cbBlockID.Text & " AND ItemBlockPos = " & index2.ToString
                SQLConn.Open()
                SQLRead = SQLCmd.ExecuteReader()
                If SQLRead.HasRows = True Then
                    If SQLRead.Read Then
                        index2Empty = Not (SQLRead("ItemBlockPos") = index2.ToString)
                        item2ID = SQLRead("ItemID")
                    End If
                End If
                SQLConn.Close()
                If Not (index2Empty And index2Empty) Then ' They should really implement NAND in VB.NET...
                    If Not index2Empty Then
                        SQLCmd.CommandText = "UPDATE Items SET ItemBlockPos = " & index1.ToString & " WHERE ItemID = '" & item2ID & "'"
                        SQLConn.Open()
                        SQLCmd.ExecuteNonQuery()
                        SQLConn.Close()
                    End If

                    If Not index1Empty Then
                        SQLCmd.CommandText = "UPDATE Items SET ItemBlockPos = " & index2.ToString & " WHERE ItemID = '" & item1ID & "'"
                        SQLConn.Open()
                        SQLCmd.ExecuteNonQuery()
                        SQLConn.Close()
                    End If
                    Call loadItem()
                End If
            End If


        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to access the database."
            MessageBox.Show(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try


    End Sub

    Sub MoveItemLeft(ByVal index As Integer)
        If cbBlockID.Text <> "" Then
            Call removeBlockIDfromItem(liItem1(index).ItemID.ToString)
            Call loadItem()
        End If
    End Sub


    Private Sub loadItem()
        Dim placeHolder As Integer = lbItemAvail.SelectedIndex
        Dim SQLConn As New SqlConnection() 'The SQL Connection
        Dim SQLCmd As New SqlCommand() 'The SQL Command
        Dim SQLRead As SqlDataReader 'The Local Data Store
        liItem1 = Nothing
        liItem2 = Nothing
        SQLConn.ConnectionString = DBConnectionString
        SQLCmd.Connection = SQLConn

        Dim intCounter = 0
        Do While intCounter < 11
            Array.Resize(liItem1, intCounter + 1)
            liItem1(intCounter) = New arFormat()
            intCounter += 1
        Loop

        Try

            SQLCmd.CommandText = "SELECT ItemID, ItemDesc, ItemBlockPos, ItemBlockID FROM Items WHERE ItemDateDonated = dbo.ufnNextAuctionDate() AND ItemBlockID = " & cbBlockID.Text & " ORDER BY ItemBlockPos ASC"
            SQLConn.Open()
            SQLRead = SQLCmd.ExecuteReader()
            liItem1Max = 0
            If SQLRead.HasRows = True Then
                While SQLRead.Read
                    Dim intTemp As String = SQLRead("ItemBlockPos").ToString
                    If intTemp <> "" Then
                        liItem1(CInt(intTemp)).ItemID = SQLRead("ItemID").ToString
                        liItem1(CInt(intTemp)).ItemDesc = SQLRead("ItemDesc").ToString
                        liItem1(CInt(intTemp)).ItemBlockPos = intTemp
                        liItem1(CInt(intTemp)).ItemBlockID = SQLRead("ItemBlockID").ToString
                    End If
                    liItem1Max = CUShort(liItem1Max + 1)
                End While
            End If
            SQLRead.Close()
            SQLCmd.CommandText = "SELECT COUNT(ItemID) FROM Items WHERE ItemDateDonated = dbo.ufnNextAuctionDate() AND ItemBlockID Is Null"
            SQLRead = SQLCmd.ExecuteReader()
            Dim intArSize As Integer = -1
            If SQLRead.HasRows = True Then
                If SQLRead.Read Then
                    intArSize = CInt(SQLRead(""))
                End If
            End If
            SQLRead.Close()
            SQLCmd.CommandText = "SELECT ItemID, ItemDesc, ItemBlockPos, ItemBlockID FROM Items WHERE ItemDateDonated = dbo.ufnNextAuctionDate() AND ItemBlockID Is Null"
            SQLRead = SQLCmd.ExecuteReader()

            If SQLRead.HasRows = True Then
                liItem2Max = 0
                If (intArSize > -1 And intArSize < 999999) Then
                    Array.Resize(liItem2, intArSize)
                    While SQLRead.Read
                        liItem2.SetValue(New arFormat(SQLRead("ItemID").ToString, SQLRead("ItemDesc").ToString, SQLRead("ItemBlockPos").ToString, SQLRead("ItemBlockID").ToString), liItem2Max)
                        liItem2Max = CUInt(liItem2Max + 1)
                    End While
                End If
            End If

            Call ItemAssignedList_SetList()
            lbItemAvail.Enabled = False
            lbItemAvail.DataSource = liItem2
            lbItemAvail.Enabled = True
        Catch ex As Exception
            lblMessageBox.Text = "Connection Issue :: Unable to access the database."
            MessageBox.Show(ex.Message)
        Finally
            If SQLConn.State <> ConnectionState.Closed Then
                SQLConn.Close()
            End If
            SQLCmd.Dispose()
        End Try

        If placeHolder < lbItemAvail.Items.Count Then
            lbItemAvail.SelectedIndex = placeHolder
        End If

    End Sub

    Private Sub lbItemAvail_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbItemAvail.MouseMove
        If m_MouseIsDown And lbItemAvail.SelectedIndex > -1 Then
            Try
                lIndex = lbItemAvail.SelectedIndex
                lbItemAvail.DoDragDrop(lbItemAvail.SelectedItem.ToString, DragDropEffects.Copy Or DragDropEffects.Move)
            Catch ex As Exception
                If DebugFlag = True Then : MsgBox(ex) : End If
                lIndex = -1
            End Try
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub lbItemAvail_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lbItemAvail.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub lbItemAvail_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbItemAvail.MouseDown
        m_MouseIsDown = True
        If lbItemAvail.IndexFromPoint(e.Location) <> -1 Then
            lbItemAvail.SetSelected(lbItemAvail.IndexFromPoint(e.Location), True)
        End If

    End Sub

    Private Sub ItemAssigned0_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned0.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(0)
        End If
    End Sub

    Private Sub ItemAssigned0_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned0.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub


    Private Sub ItemAssigned1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned1.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(1)
        End If
    End Sub

    Private Sub ItemAssigned1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub


    Private Sub ItemAssigned2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned2.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(2)
        End If
    End Sub

    Private Sub ItemAssigned2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned2.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub


    Private Sub ItemAssigned3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned3.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(3)
        End If
    End Sub

    Private Sub ItemAssigned3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned3.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub


    Private Sub ItemAssigned4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned4.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(4)
        End If
    End Sub

    Private Sub ItemAssigned4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned4.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub


    Private Sub ItemAssigned5_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned5.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(5)
        End If
    End Sub

    Private Sub ItemAssigned5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned5.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub


    Private Sub ItemAssigned6_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned6.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(6)
        End If
    End Sub

    Private Sub ItemAssigned6_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned6.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub ItemAssigned7_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned7.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(7)
        End If
    End Sub

    Private Sub ItemAssigned7_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned7.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub ItemAssigned8_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned8.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(8)
        End If
    End Sub

    Private Sub ItemAssigned8_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned8.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub ItemAssigned9_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned9.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(9)
        End If
    End Sub

    Private Sub ItemAssigned9_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned9.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub ItemAssigned10_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned10.DragDrop
        If lbItemAvail.SelectedIndex > -1 Then
            Call MoveItemRight(10)
        End If
    End Sub

    Private Sub ItemAssigned10_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ItemAssigned10.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call MoveItemRight(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call MoveItemLeft(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call MoveItemRight(1)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call MoveItemRight(2)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call MoveItemRight(3)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Call MoveItemRight(4)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Call MoveItemRight(5)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Call MoveItemRight(6)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Call MoveItemRight(7)
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Call MoveItemRight(8)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Call MoveItemRight(9)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Call MoveItemRight(10)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call MoveItemLeft(1)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call MoveItemLeft(2)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Call MoveItemLeft(3)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Call MoveItemLeft(4)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Call MoveItemLeft(5)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Call MoveItemLeft(6)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Call MoveItemLeft(7)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Call MoveItemLeft(8)
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Call MoveItemLeft(9)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Call MoveItemLeft(10)
    End Sub

    Private Sub AssignItemToPosition1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition1ToolStripMenuItem.Click
        Call MoveItemRight(0)
    End Sub

    Private Sub AssignItemToPosition2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition2ToolStripMenuItem.Click
        Call MoveItemRight(1)
    End Sub

    Private Sub AssignItemToPosition3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition3ToolStripMenuItem.Click
        Call MoveItemRight(2)
    End Sub

    Private Sub AssignItemToPosition4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition4ToolStripMenuItem.Click
        Call MoveItemRight(3)
    End Sub

    Private Sub AssignItemToPosition5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition5ToolStripMenuItem.Click
        Call MoveItemRight(4)
    End Sub

    Private Sub AssignItemToPosition6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition6ToolStripMenuItem.Click
        Call MoveItemRight(5)
    End Sub

    Private Sub AssignItemToPosition7ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition7ToolStripMenuItem.Click
        Call MoveItemRight(6)
    End Sub

    Private Sub AssignItemToPosition8ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition8ToolStripMenuItem.Click
        Call MoveItemRight(7)
    End Sub

    Private Sub AssignItemToPosition9ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition9ToolStripMenuItem.Click
        Call MoveItemRight(8)
    End Sub

    Private Sub AssignItemToPosition10ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition10ToolStripMenuItem.Click
        Call MoveItemRight(9)
    End Sub

    Private Sub AssignItemToPosition11ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignItemToPosition11ToolStripMenuItem.Click
        Call MoveItemRight(10)
    End Sub

    Private Sub lbItemAvail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbItemAvail.SelectedIndexChanged

    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        swapBlockPos(10, DOWN)
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        swapBlockPos(9, DOWN)
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        swapBlockPos(8, DOWN)
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        swapBlockPos(7, DOWN)
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        swapBlockPos(6, DOWN)
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        swapBlockPos(5, DOWN)
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        swapBlockPos(4, DOWN)
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        swapBlockPos(3, DOWN)
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        swapBlockPos(2, DOWN)
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        swapBlockPos(1, DOWN)
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        swapBlockPos(1, UP)
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        swapBlockPos(2, UP)
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        swapBlockPos(3, UP)
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        swapBlockPos(4, UP)
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        swapBlockPos(5, UP)
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        swapBlockPos(6, UP)
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        swapBlockPos(7, UP)
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        swapBlockPos(8, UP)
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        swapBlockPos(9, UP)
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        swapBlockPos(10, UP)
    End Sub
End Class