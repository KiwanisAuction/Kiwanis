<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class K_DBCC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(K_DBCC))
        Me.Host_lbl = New System.Windows.Forms.Label
        Me.Save_btn = New System.Windows.Forms.Button
        Me.Host_txt = New System.Windows.Forms.TextBox
        Me.Pass_lbl = New System.Windows.Forms.Label
        Me.User_lbl = New System.Windows.Forms.Label
        Me.Pass_txt = New System.Windows.Forms.TextBox
        Me.User_txt = New System.Windows.Forms.TextBox
        Me.Close_btn = New System.Windows.Forms.Button
        Me.Catalog_txt = New System.Windows.Forms.TextBox
        Me.Catalog_lbl = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Host_lbl
        '
        Me.Host_lbl.AutoSize = True
        Me.Host_lbl.Location = New System.Drawing.Point(12, 18)
        Me.Host_lbl.Name = "Host_lbl"
        Me.Host_lbl.Size = New System.Drawing.Size(68, 13)
        Me.Host_lbl.TabIndex = 0
        Me.Host_lbl.Text = "Host/Server:"
        '
        'Save_btn
        '
        Me.Save_btn.Location = New System.Drawing.Point(263, 130)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(75, 23)
        Me.Save_btn.TabIndex = 2
        Me.Save_btn.Text = "SAVE"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Host_txt
        '
        Me.Host_txt.Location = New System.Drawing.Point(86, 15)
        Me.Host_txt.Name = "Host_txt"
        Me.Host_txt.Size = New System.Drawing.Size(333, 20)
        Me.Host_txt.TabIndex = 3
        Me.Host_txt.Text = "Host/Server data."
        '
        'Pass_lbl
        '
        Me.Pass_lbl.AutoSize = True
        Me.Pass_lbl.Location = New System.Drawing.Point(12, 96)
        Me.Pass_lbl.Name = "Pass_lbl"
        Me.Pass_lbl.Size = New System.Drawing.Size(56, 13)
        Me.Pass_lbl.TabIndex = 4
        Me.Pass_lbl.Text = "Password:"
        '
        'User_lbl
        '
        Me.User_lbl.AutoSize = True
        Me.User_lbl.Location = New System.Drawing.Point(12, 70)
        Me.User_lbl.Name = "User_lbl"
        Me.User_lbl.Size = New System.Drawing.Size(58, 13)
        Me.User_lbl.TabIndex = 5
        Me.User_lbl.Text = "Username:"
        '
        'Pass_txt
        '
        Me.Pass_txt.Location = New System.Drawing.Point(86, 93)
        Me.Pass_txt.Name = "Pass_txt"
        Me.Pass_txt.Size = New System.Drawing.Size(197, 20)
        Me.Pass_txt.TabIndex = 6
        Me.Pass_txt.Text = "Password data."
        '
        'User_txt
        '
        Me.User_txt.Location = New System.Drawing.Point(86, 67)
        Me.User_txt.Name = "User_txt"
        Me.User_txt.Size = New System.Drawing.Size(197, 20)
        Me.User_txt.TabIndex = 7
        Me.User_txt.Text = "Username data."
        '
        'Close_btn
        '
        Me.Close_btn.Location = New System.Drawing.Point(344, 130)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(75, 23)
        Me.Close_btn.TabIndex = 9
        Me.Close_btn.Text = "Close"
        Me.Close_btn.UseVisualStyleBackColor = True
        '
        'Catalog_txt
        '
        Me.Catalog_txt.Location = New System.Drawing.Point(86, 41)
        Me.Catalog_txt.Name = "Catalog_txt"
        Me.Catalog_txt.Size = New System.Drawing.Size(333, 20)
        Me.Catalog_txt.TabIndex = 11
        Me.Catalog_txt.Text = "Catalog/Database data."
        '
        'Catalog_lbl
        '
        Me.Catalog_lbl.AutoSize = True
        Me.Catalog_lbl.Location = New System.Drawing.Point(12, 44)
        Me.Catalog_lbl.Name = "Catalog_lbl"
        Me.Catalog_lbl.Size = New System.Drawing.Size(66, 13)
        Me.Catalog_lbl.TabIndex = 10
        Me.Catalog_lbl.Text = "Catalog/DB:"
        '
        'K_DBCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 165)
        Me.Controls.Add(Me.Catalog_txt)
        Me.Controls.Add(Me.Catalog_lbl)
        Me.Controls.Add(Me.Close_btn)
        Me.Controls.Add(Me.User_txt)
        Me.Controls.Add(Me.Pass_txt)
        Me.Controls.Add(Me.User_lbl)
        Me.Controls.Add(Me.Pass_lbl)
        Me.Controls.Add(Me.Host_txt)
        Me.Controls.Add(Me.Save_btn)
        Me.Controls.Add(Me.Host_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "K_DBCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kiwanis DB Connection Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Host_lbl As System.Windows.Forms.Label
    Friend WithEvents Save_btn As System.Windows.Forms.Button
    Friend WithEvents Host_txt As System.Windows.Forms.TextBox
    Friend WithEvents Pass_lbl As System.Windows.Forms.Label
    Friend WithEvents User_lbl As System.Windows.Forms.Label
    Friend WithEvents Pass_txt As System.Windows.Forms.TextBox
    Friend WithEvents User_txt As System.Windows.Forms.TextBox
    Friend WithEvents Close_btn As System.Windows.Forms.Button
    Friend WithEvents Catalog_txt As System.Windows.Forms.TextBox
    Friend WithEvents Catalog_lbl As System.Windows.Forms.Label
End Class
