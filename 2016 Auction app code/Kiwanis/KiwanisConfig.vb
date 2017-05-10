Imports System.Configuration
Imports System.Xml

Public Class KiwanisConfig
    ' values that are pulled (get) or written to the KAapp.config file require a KeyName for the contained value
    '
    'List of KeyNames:
    '   cDBServer       = Database server/host
    '   cDBCatalog      = Database 
    '   cDBUsername     = Database username
    '   cDBPassword     = Database user password
    '   cAAdminPass     = Application Admin password
    '   cAAuctPass      = Application Auctioneer password
    '   cSuperBlockMin  = Minimum bid increment for super block bid
    '
    'Examples in code:
    '   KiwanisConfig.GetConfigValue("cAAdminPass") returns the application admin password
    '   KiwanisConfig.LoadDatabaseConfig returns database connection string
    '
    Public Shared Sub WriteConfigValue(ByVal KeyName As String, ByVal KeyValue As String)
        ' This will WRITE config values to the app.config (KAapp.config) file in the path from Current application Domain

        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of KAapp.config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "appSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                For Each xNode As XmlNode In xElement.ChildNodes
                    If xNode.Attributes(0).Value = KeyName Then
                        xNode.Attributes(1).Value = KeyValue
                    End If
                Next
            End If
        Next
        ' Save KAapp.config file
        XmlDoc.Save(".\KAapp.config")

    End Sub

    Public Shared Function LoadDatabaseConfig() As String
        ' This will FORMAT and RETURN a SQL connection string from the app.config (KAapp.config) file in the path from Current application Domain

        Dim ConnString As String = ""

        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of KAapp.config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "appSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                For Each xNode As XmlNode In xElement.ChildNodes ' Build connection string
                    If xNode.Attributes(0).Value = "cDBServer" Then
                        ConnString = "Data Source=" & "" & xNode.Attributes(1).Value.ToString & ";"
                    ElseIf xNode.Attributes(0).Value = "cDBCatalog" Then
                        ConnString += "Initial Catalog=" & "" & xNode.Attributes(1).Value.ToString & ";"
                    ElseIf xNode.Attributes(0).Value = "cDBUsername" Then
                        ConnString += "User ID=" & "" & xNode.Attributes(1).Value.ToString & ";"
                    ElseIf xNode.Attributes(0).Value = "cDBPassword" Then
                        ConnString += "Password='" & "" & xNode.Attributes(1).Value.ToString & "';"
                    End If
                Next
            End If
        Next

        Return ConnString

    End Function

    Public Shared Function GetConfigValue(ByVal KeyName As String) As String
        ' This will GET any value from the app.config (KAapp.config) file in the path from Current application Domain

        Dim configValue As String = ""

        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of KAapp.config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "appSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                Dim i As Integer = 0
                For Each xNode As XmlNode In xElement.ChildNodes
                    If xNode.Attributes(0).Value = KeyName Then
                        configValue = xNode.Attributes(1).Value.ToString
                    End If
                Next
            End If
        Next

        Return configValue

    End Function
End Class


