<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignItemToBlock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignItemToBlock))
        Me.btnAssign = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.AvailPos_lbl = New System.Windows.Forms.Label
        Me.AssignedBlockID_lbl = New System.Windows.Forms.Label
        Me.btnSaveNewPos = New System.Windows.Forms.Button
        Me.cb11 = New System.Windows.Forms.ComboBox
        Me.cbBlockName = New System.Windows.Forms.ComboBox
        Me.btnRemoveItem = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cb10 = New System.Windows.Forms.ComboBox
        Me.cb9 = New System.Windows.Forms.ComboBox
        Me.cb8 = New System.Windows.Forms.ComboBox
        Me.cb7 = New System.Windows.Forms.ComboBox
        Me.cb6 = New System.Windows.Forms.ComboBox
        Me.cb5 = New System.Windows.Forms.ComboBox
        Me.cb4 = New System.Windows.Forms.ComboBox
        Me.cb3 = New System.Windows.Forms.ComboBox
        Me.cb2 = New System.Windows.Forms.ComboBox
        Me.cb1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbItemAssigned = New System.Windows.Forms.ListBox
        Me.btnAssignItem = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.lbItemAvail = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblMessageBox = New System.Windows.Forms.Label
        Me.cbBlockID = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAssign
        '
        Me.btnAssign.Enabled = False
        Me.btnAssign.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssign.Location = New System.Drawing.Point(874, 11)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(145, 36)
        Me.btnAssign.TabIndex = 2
        Me.btnAssign.Text = "Assign Item to Block"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(10, 579)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(145, 30)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back to Main"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.AssignedBlockID_lbl)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnSaveNewPos)
        Me.Panel1.Controls.Add(Me.btnAssign)
        Me.Panel1.Controls.Add(Me.cb11)
        Me.Panel1.Controls.Add(Me.cbBlockName)
        Me.Panel1.Controls.Add(Me.btnRemoveItem)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cb10)
        Me.Panel1.Controls.Add(Me.cb9)
        Me.Panel1.Controls.Add(Me.cb8)
        Me.Panel1.Controls.Add(Me.cb7)
        Me.Panel1.Controls.Add(Me.cb6)
        Me.Panel1.Controls.Add(Me.cb5)
        Me.Panel1.Controls.Add(Me.cb4)
        Me.Panel1.Controls.Add(Me.cb3)
        Me.Panel1.Controls.Add(Me.cb2)
        Me.Panel1.Controls.Add(Me.cb1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbItemAssigned)
        Me.Panel1.Controls.Add(Me.btnAssignItem)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.lbItemAvail)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblMessageBox)
        Me.Panel1.Controls.Add(Me.cbBlockID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(1029, 619)
        Me.Panel1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AvailPos_lbl)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(524, 480)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 53)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Available Item Positions:"
        '
        'AvailPos_lbl
        '
        Me.AvailPos_lbl.AutoSize = True
        Me.AvailPos_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailPos_lbl.Location = New System.Drawing.Point(6, 20)
        Me.AvailPos_lbl.Name = "AvailPos_lbl"
        Me.AvailPos_lbl.Size = New System.Drawing.Size(103, 25)
        Me.AvailPos_lbl.TabIndex = 169
        Me.AvailPos_lbl.Text = "0000000"
        '
        'AssignedBlockID_lbl
        '
        Me.AssignedBlockID_lbl.AutoSize = True
        Me.AssignedBlockID_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignedBlockID_lbl.Location = New System.Drawing.Point(711, 86)
        Me.AssignedBlockID_lbl.Name = "AssignedBlockID_lbl"
        Me.AssignedBlockID_lbl.Size = New System.Drawing.Size(108, 20)
        Me.AssignedBlockID_lbl.TabIndex = 167
        Me.AssignedBlockID_lbl.Text = "BLOCK XXX"
        '
        'btnSaveNewPos
        '
        Me.btnSaveNewPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNewPos.Location = New System.Drawing.Point(894, 339)
        Me.btnSaveNewPos.Name = "btnSaveNewPos"
        Me.btnSaveNewPos.Size = New System.Drawing.Size(120, 45)
        Me.btnSaveNewPos.TabIndex = 162
        Me.btnSaveNewPos.Text = "Save" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Item Position"
        Me.btnSaveNewPos.UseVisualStyleBackColor = True
        '
        'cb11
        '
        Me.cb11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb11.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb11.FormattingEnabled = True
        Me.cb11.ItemHeight = 10
        Me.cb11.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb11.Location = New System.Drawing.Point(979, 314)
        Me.cb11.Margin = New System.Windows.Forms.Padding(0)
        Me.cb11.Name = "cb11"
        Me.cb11.Size = New System.Drawing.Size(35, 18)
        Me.cb11.TabIndex = 166
        '
        'cbBlockName
        '
        Me.cbBlockName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBlockName.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBlockName.FormattingEnabled = True
        Me.cbBlockName.Location = New System.Drawing.Point(115, 38)
        Me.cbBlockName.Name = "cbBlockName"
        Me.cbBlockName.Size = New System.Drawing.Size(225, 23)
        Me.cbBlockName.TabIndex = 165
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.Image = Global.Kiwanis.My.Resources.Resources.ArrowL
        Me.btnRemoveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveItem.Location = New System.Drawing.Point(524, 339)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(151, 39)
        Me.btnRemoveItem.TabIndex = 163
        Me.btnRemoveItem.Text = "    Remove"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(949, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Position"
        '
        'cb10
        '
        Me.cb10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb10.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb10.FormattingEnabled = True
        Me.cb10.ItemHeight = 10
        Me.cb10.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb10.Location = New System.Drawing.Point(979, 294)
        Me.cb10.Margin = New System.Windows.Forms.Padding(0)
        Me.cb10.Name = "cb10"
        Me.cb10.Size = New System.Drawing.Size(35, 18)
        Me.cb10.TabIndex = 160
        '
        'cb9
        '
        Me.cb9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb9.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb9.FormattingEnabled = True
        Me.cb9.ItemHeight = 10
        Me.cb9.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb9.Location = New System.Drawing.Point(979, 274)
        Me.cb9.Margin = New System.Windows.Forms.Padding(0)
        Me.cb9.Name = "cb9"
        Me.cb9.Size = New System.Drawing.Size(35, 18)
        Me.cb9.TabIndex = 159
        '
        'cb8
        '
        Me.cb8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb8.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb8.FormattingEnabled = True
        Me.cb8.ItemHeight = 10
        Me.cb8.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb8.Location = New System.Drawing.Point(979, 254)
        Me.cb8.Margin = New System.Windows.Forms.Padding(0)
        Me.cb8.Name = "cb8"
        Me.cb8.Size = New System.Drawing.Size(35, 18)
        Me.cb8.TabIndex = 158
        '
        'cb7
        '
        Me.cb7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb7.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb7.FormattingEnabled = True
        Me.cb7.ItemHeight = 10
        Me.cb7.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb7.Location = New System.Drawing.Point(979, 234)
        Me.cb7.Margin = New System.Windows.Forms.Padding(0)
        Me.cb7.Name = "cb7"
        Me.cb7.Size = New System.Drawing.Size(35, 18)
        Me.cb7.TabIndex = 157
        '
        'cb6
        '
        Me.cb6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb6.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb6.FormattingEnabled = True
        Me.cb6.ItemHeight = 10
        Me.cb6.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb6.Location = New System.Drawing.Point(979, 214)
        Me.cb6.Margin = New System.Windows.Forms.Padding(0)
        Me.cb6.Name = "cb6"
        Me.cb6.Size = New System.Drawing.Size(35, 18)
        Me.cb6.TabIndex = 156
        '
        'cb5
        '
        Me.cb5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb5.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb5.FormattingEnabled = True
        Me.cb5.ItemHeight = 10
        Me.cb5.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb5.Location = New System.Drawing.Point(979, 194)
        Me.cb5.Margin = New System.Windows.Forms.Padding(0)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(35, 18)
        Me.cb5.TabIndex = 155
        '
        'cb4
        '
        Me.cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb4.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb4.FormattingEnabled = True
        Me.cb4.ItemHeight = 10
        Me.cb4.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb4.Location = New System.Drawing.Point(979, 174)
        Me.cb4.Margin = New System.Windows.Forms.Padding(0)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(35, 18)
        Me.cb4.TabIndex = 154
        '
        'cb3
        '
        Me.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb3.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb3.FormattingEnabled = True
        Me.cb3.ItemHeight = 10
        Me.cb3.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb3.Location = New System.Drawing.Point(979, 154)
        Me.cb3.Margin = New System.Windows.Forms.Padding(0)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(35, 18)
        Me.cb3.TabIndex = 153
        '
        'cb2
        '
        Me.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb2.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.FormattingEnabled = True
        Me.cb2.ItemHeight = 10
        Me.cb2.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb2.Location = New System.Drawing.Point(979, 134)
        Me.cb2.Margin = New System.Windows.Forms.Padding(0)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(35, 18)
        Me.cb2.TabIndex = 152
        '
        'cb1
        '
        Me.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb1.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.FormattingEnabled = True
        Me.cb1.ItemHeight = 10
        Me.cb1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb1.Location = New System.Drawing.Point(979, 114)
        Me.cb1.Margin = New System.Windows.Forms.Padding(0)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(35, 18)
        Me.cb1.TabIndex = 151
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(520, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 20)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Current Items Assigned to"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbItemAssigned
        '
        Me.lbItemAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItemAssigned.FormattingEnabled = True
        Me.lbItemAssigned.ItemHeight = 20
        Me.lbItemAssigned.Location = New System.Drawing.Point(524, 109)
        Me.lbItemAssigned.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
        Me.lbItemAssigned.Name = "lbItemAssigned"
        Me.lbItemAssigned.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbItemAssigned.Size = New System.Drawing.Size(450, 224)
        Me.lbItemAssigned.TabIndex = 149
        '
        'btnAssignItem
        '
        Me.btnAssignItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAssignItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignItem.Image = Global.Kiwanis.My.Resources.Resources.ArrowR
        Me.btnAssignItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAssignItem.Location = New System.Drawing.Point(473, 114)
        Me.btnAssignItem.Name = "btnAssignItem"
        Me.btnAssignItem.Size = New System.Drawing.Size(45, 165)
        Me.btnAssignItem.TabIndex = 148
        Me.btnAssignItem.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAssignItem.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(8, 67)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1006, 2)
        Me.PictureBox3.TabIndex = 147
        Me.PictureBox3.TabStop = False
        '
        'lbItemAvail
        '
        Me.lbItemAvail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItemAvail.FormattingEnabled = True
        Me.lbItemAvail.ItemHeight = 20
        Me.lbItemAvail.Location = New System.Drawing.Point(15, 109)
        Me.lbItemAvail.Name = "lbItemAvail"
        Me.lbItemAvail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbItemAvail.Size = New System.Drawing.Size(450, 424)
        Me.lbItemAvail.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Available Items "
        '
        'lblMessageBox
        '
        Me.lblMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessageBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageBox.ForeColor = System.Drawing.Color.Red
        Me.lblMessageBox.Location = New System.Drawing.Point(15, 542)
        Me.lblMessageBox.Name = "lblMessageBox"
        Me.lblMessageBox.Size = New System.Drawing.Size(999, 23)
        Me.lblMessageBox.TabIndex = 143
        Me.lblMessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbBlockID
        '
        Me.cbBlockID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBlockID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBlockID.FormattingEnabled = True
        Me.cbBlockID.Location = New System.Drawing.Point(115, 8)
        Me.cbBlockID.Name = "cbBlockID"
        Me.cbBlockID.Size = New System.Drawing.Size(100, 23)
        Me.cbBlockID.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Block Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Block ID:"
        '
        'AssignItemToBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1054, 646)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AssignItemToBlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Items To Block"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAssign As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMessageBox As System.Windows.Forms.Label
    Friend WithEvents cbBlockID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbItemAvail As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbItemAssigned As System.Windows.Forms.ListBox
    Friend WithEvents btnAssignItem As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cb8 As System.Windows.Forms.ComboBox
    Friend WithEvents cb7 As System.Windows.Forms.ComboBox
    Friend WithEvents cb6 As System.Windows.Forms.ComboBox
    Friend WithEvents cb5 As System.Windows.Forms.ComboBox
    Friend WithEvents cb4 As System.Windows.Forms.ComboBox
    Friend WithEvents cb3 As System.Windows.Forms.ComboBox
    Friend WithEvents cb2 As System.Windows.Forms.ComboBox
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb10 As System.Windows.Forms.ComboBox
    Friend WithEvents cb9 As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents btnSaveNewPos As System.Windows.Forms.Button
    Friend WithEvents cbBlockName As System.Windows.Forms.ComboBox
    Friend WithEvents cb11 As System.Windows.Forms.ComboBox
    Friend WithEvents AssignedBlockID_lbl As System.Windows.Forms.Label
    Friend WithEvents AvailPos_lbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
