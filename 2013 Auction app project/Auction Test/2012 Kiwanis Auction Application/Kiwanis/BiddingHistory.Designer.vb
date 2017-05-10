<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BiddingHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BiddingHistory))
        Me.btnBack = New System.Windows.Forms.Button
        Me.lbAvailableBlock = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ItemPos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BidAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BidderID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblMessageBox = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FixBid_btn = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 591)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(135, 30)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back to Main"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lbAvailableBlock
        '
        Me.lbAvailableBlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAvailableBlock.FormattingEnabled = True
        Me.lbAvailableBlock.ItemHeight = 20
        Me.lbAvailableBlock.Location = New System.Drawing.Point(12, 36)
        Me.lbAvailableBlock.Name = "lbAvailableBlock"
        Me.lbAvailableBlock.ScrollAlwaysVisible = True
        Me.lbAvailableBlock.Size = New System.Drawing.Size(135, 504)
        Me.lbAvailableBlock.Sorted = True
        Me.lbAvailableBlock.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Available Block:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeight = 24
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemPos, Me.ItemID, Me.ItemDesc, Me.BidAmount, Me.BidderID})
        Me.DataGridView1.Location = New System.Drawing.Point(157, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(659, 504)
        Me.DataGridView1.TabIndex = 5
        '
        'ItemPos
        '
        Me.ItemPos.HeaderText = "#"
        Me.ItemPos.Name = "ItemPos"
        Me.ItemPos.ReadOnly = True
        Me.ItemPos.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemPos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ItemPos.Width = 35
        '
        'ItemID
        '
        Me.ItemID.HeaderText = "Item ID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.Width = 60
        '
        'ItemDesc
        '
        Me.ItemDesc.HeaderText = "Item Description"
        Me.ItemDesc.Name = "ItemDesc"
        Me.ItemDesc.ReadOnly = True
        Me.ItemDesc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ItemDesc.Width = 360
        '
        'BidAmount
        '
        Me.BidAmount.HeaderText = "Bid Amount"
        Me.BidAmount.Name = "BidAmount"
        Me.BidAmount.ReadOnly = True
        Me.BidAmount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BidAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.BidAmount.Width = 80
        '
        'BidderID
        '
        Me.BidderID.HeaderText = "Bidder ID"
        Me.BidderID.Name = "BidderID"
        Me.BidderID.ReadOnly = True
        Me.BidderID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BidderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.BidderID.Width = 80
        '
        'lblMessageBox
        '
        Me.lblMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessageBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageBox.ForeColor = System.Drawing.Color.Red
        Me.lblMessageBox.Location = New System.Drawing.Point(12, 556)
        Me.lblMessageBox.Name = "lblMessageBox"
        Me.lblMessageBox.Size = New System.Drawing.Size(804, 23)
        Me.lblMessageBox.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FixBid_btn)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblMessageBox)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.lbAvailableBlock)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(832, 636)
        Me.Panel1.TabIndex = 27
        '
        'FixBid_btn
        '
        Me.FixBid_btn.Location = New System.Drawing.Point(694, 598)
        Me.FixBid_btn.Name = "FixBid_btn"
        Me.FixBid_btn.Size = New System.Drawing.Size(122, 23)
        Me.FixBid_btn.TabIndex = 27
        Me.FixBid_btn.Text = "Fix Bid"
        Me.FixBid_btn.UseVisualStyleBackColor = True
        '
        'BiddingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(859, 660)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BiddingHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bidding History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lbAvailableBlock As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblMessageBox As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FixBid_btn As System.Windows.Forms.Button
    Friend WithEvents ItemPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BidAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BidderID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
