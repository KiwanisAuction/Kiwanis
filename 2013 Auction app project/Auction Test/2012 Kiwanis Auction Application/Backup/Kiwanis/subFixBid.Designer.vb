<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixBid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FixBid))
        Me.HighBidAdj_txt = New System.Windows.Forms.TextBox
        Me.BidderID_lbl = New System.Windows.Forms.Label
        Me.ItemID_lbl = New System.Windows.Forms.Label
        Me.HighBid_lbl = New System.Windows.Forms.Label
        Me.BidderID2_lbl = New System.Windows.Forms.Label
        Me.ItemID2_lbl = New System.Windows.Forms.Label
        Me.Save_btn = New System.Windows.Forms.Button
        Me.Cancel_btn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'HighBidAdj_txt
        '
        Me.HighBidAdj_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighBidAdj_txt.Location = New System.Drawing.Point(153, 48)
        Me.HighBidAdj_txt.Name = "HighBidAdj_txt"
        Me.HighBidAdj_txt.Size = New System.Drawing.Size(75, 22)
        Me.HighBidAdj_txt.TabIndex = 0
        '
        'BidderID_lbl
        '
        Me.BidderID_lbl.AutoSize = True
        Me.BidderID_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BidderID_lbl.Location = New System.Drawing.Point(12, 9)
        Me.BidderID_lbl.Name = "BidderID_lbl"
        Me.BidderID_lbl.Size = New System.Drawing.Size(67, 16)
        Me.BidderID_lbl.TabIndex = 1
        Me.BidderID_lbl.Text = "Bidder ID:"
        '
        'ItemID_lbl
        '
        Me.ItemID_lbl.AutoSize = True
        Me.ItemID_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemID_lbl.Location = New System.Drawing.Point(12, 25)
        Me.ItemID_lbl.Name = "ItemID_lbl"
        Me.ItemID_lbl.Size = New System.Drawing.Size(52, 16)
        Me.ItemID_lbl.TabIndex = 2
        Me.ItemID_lbl.Text = "Item ID:"
        '
        'HighBid_lbl
        '
        Me.HighBid_lbl.AutoSize = True
        Me.HighBid_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighBid_lbl.Location = New System.Drawing.Point(12, 51)
        Me.HighBid_lbl.Name = "HighBid_lbl"
        Me.HighBid_lbl.Size = New System.Drawing.Size(138, 16)
        Me.HighBid_lbl.TabIndex = 3
        Me.HighBid_lbl.Text = "High Bid Amount: $"
        '
        'BidderID2_lbl
        '
        Me.BidderID2_lbl.AutoSize = True
        Me.BidderID2_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BidderID2_lbl.Location = New System.Drawing.Point(150, 9)
        Me.BidderID2_lbl.Name = "BidderID2_lbl"
        Me.BidderID2_lbl.Size = New System.Drawing.Size(51, 16)
        Me.BidderID2_lbl.TabIndex = 4
        Me.BidderID2_lbl.Text = "BID999"
        '
        'ItemID2_lbl
        '
        Me.ItemID2_lbl.AutoSize = True
        Me.ItemID2_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemID2_lbl.Location = New System.Drawing.Point(150, 25)
        Me.ItemID2_lbl.Name = "ItemID2_lbl"
        Me.ItemID2_lbl.Size = New System.Drawing.Size(52, 16)
        Me.ItemID2_lbl.TabIndex = 5
        Me.ItemID2_lbl.Text = "IID9999"
        '
        'Save_btn
        '
        Me.Save_btn.Location = New System.Drawing.Point(64, 88)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(75, 23)
        Me.Save_btn.TabIndex = 7
        Me.Save_btn.Text = "SAVE"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Cancel_btn
        '
        Me.Cancel_btn.Location = New System.Drawing.Point(153, 88)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_btn.TabIndex = 8
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.UseVisualStyleBackColor = True
        '
        'FixBid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 125)
        Me.Controls.Add(Me.Cancel_btn)
        Me.Controls.Add(Me.Save_btn)
        Me.Controls.Add(Me.ItemID2_lbl)
        Me.Controls.Add(Me.BidderID2_lbl)
        Me.Controls.Add(Me.HighBid_lbl)
        Me.Controls.Add(Me.ItemID_lbl)
        Me.Controls.Add(Me.BidderID_lbl)
        Me.Controls.Add(Me.HighBidAdj_txt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FixBid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fix Bid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HighBidAdj_txt As System.Windows.Forms.TextBox
    Friend WithEvents BidderID_lbl As System.Windows.Forms.Label
    Friend WithEvents ItemID_lbl As System.Windows.Forms.Label
    Friend WithEvents HighBid_lbl As System.Windows.Forms.Label
    Friend WithEvents BidderID2_lbl As System.Windows.Forms.Label
    Friend WithEvents ItemID2_lbl As System.Windows.Forms.Label
    Friend WithEvents Save_btn As System.Windows.Forms.Button
    Friend WithEvents Cancel_btn As System.Windows.Forms.Button
End Class
