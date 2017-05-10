Imports System
Imports System.IO


Public Class K_DBCC
    Public Sub K_DBCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Read 
        Host_txt.Text = KDBConnect.getKDMConnect("UServer")
        Catalog_txt.Text = KDBConnect.getKDMConnect("UCatalog")
        User_txt.Text = KDBConnect.getKDMConnect("UName")
        Pass_txt.Text = KDBConnect.getKDMConnect("UPass")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_btn.Click
        'Save and return to main
        KDBConnect.writeKDMConnect("UServer", Host_txt.Text)
        KDBConnect.writeKDMConnect("UCatalog", Catalog_txt.Text)
        KDBConnect.writeKDMConnect("UName", User_txt.Text)
        KDBConnect.writeKDMConnect("UPass", Pass_txt.Text)

        Main.Enabled = True
        Me.Visible = False
    End Sub

    Private Sub Close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_btn.Click
        'Do nothing!
        Main.Enabled = True
        Me.Visible = False
    End Sub
End Class