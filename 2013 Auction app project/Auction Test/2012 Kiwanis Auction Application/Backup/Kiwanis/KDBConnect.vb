Imports System.Configuration
Imports System.Xml

Public Class KDBConnect

    Public Shared Function getKDMConnect(ByVal KeyName As String) As String

        Dim ConnString As String = ""
        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        ' XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of app.Config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "appSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                For Each xNode As XmlNode In xElement.ChildNodes
                    If xNode.Attributes(0).Value = KeyName Then
                        ConnString = xNode.Attributes(1).Value.ToString
                    End If
                Next
            End If
        Next

        Return ConnString

    End Function

    Public Shared Sub writeKDMConnect(ByVal KeyName As String, ByVal KeyValue As String)

        '  AppDomain.CurrentDomain.SetupInformation.ConfigurationFile 
        ' This will get the app.config file path from Current application Domain
        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        ' XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of app.Config file
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
        ' Save app.config file
        XmlDoc.Save(".\KAapp.config")

    End Sub

    Public Shared Function loadKDMConnect() As String

        Dim ConnString As String = ""

        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        ' XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of app.Config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "appSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                Dim i As Integer = 0
                For Each xNode As XmlNode In xElement.ChildNodes
                    If i = 0 Then
                        ConnString = "Data Source=" & "" & xNode.Attributes(1).Value.ToString & ";"
                    ElseIf i = 1 Then
                        ConnString += "Initial Catalog=" & "" & xNode.Attributes(1).Value.ToString & ";"
                    ElseIf i = 2 Then
                        ConnString += "User ID=" & "" & xNode.Attributes(1).Value.ToString & ";"
                    ElseIf i = 3 Then
                        ConnString += "Password='" & "" & xNode.Attributes(1).Value.ToString & "';"
                    End If
                    i += 1
                Next
            End If
        Next

        Return ConnString

    End Function

    Public Shared Function DataSource() As String

        Dim ConnString As String = ""

        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        ' XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of app.Config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "appSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                Dim i As Integer = 0
                For Each xNode As XmlNode In xElement.ChildNodes
                    If i = 0 Then
                        ConnString = "" & xNode.Attributes(1).Value.ToString & ""
                    End If
                    i += 1
                Next
            End If
        Next

        Return ConnString

    End Function

    Public Shared Function DataBase() As String

        Dim ConnString As String = ""

        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        ' XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of app.Config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "appSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                Dim i As Integer = 0
                For Each xNode As XmlNode In xElement.ChildNodes
                    If i = 1 Then
                        ConnString = "" & xNode.Attributes(1).Value.ToString & ""
                    End If
                    i += 1
                Next
            End If
        Next

        Return ConnString

    End Function

    Public Shared Function User() As String

        Dim ConnString As String = ""

        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        ' XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of app.Config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "appSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                Dim i As Integer = 0
                For Each xNode As XmlNode In xElement.ChildNodes
                    If i = 2 Then
                        ConnString = "" & xNode.Attributes(1).Value.ToString & ""
                    End If
                    i += 1
                Next
            End If
        Next

        Return ConnString

    End Function

    Public Shared Function Pass() As String

        Dim ConnString As String = ""

        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        ' XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Load(".\KAapp.config")
        ' Navigate Each XML Element of app.Config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "appSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                Dim i As Integer = 0
                For Each xNode As XmlNode In xElement.ChildNodes
                    If i = 3 Then
                        ConnString = "" & xNode.Attributes(1).Value.ToString & ""
                    End If
                    i += 1
                Next
            End If
        Next

        Return ConnString

    End Function

End Class
