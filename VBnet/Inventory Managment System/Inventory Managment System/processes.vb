Imports System.Data.SqlClient

Module processes
    Public Con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=inventory_managmrnt;Integrated Security=True")

    Public Sub setconnection(Optional ByVal Firstcomp As Boolean = False)
        Dim str As String

        str = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True"

        Try
            If IsNothing(Con) = False Then
                If Con.State = ConnectionState.Closed Then
                    Con.Close()
                End If
            End If
            Con = New SqlConnection(str)
            Con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Not Connecting to Database server.Please check your network")
        End Try
    End Sub

    Public Sub FillListView(ByRef lvList As ListView, ByRef myData As SqlDataReader)
        Dim itmListItem As ListViewItem

        Dim strValue As String

        Do While myData.Read
            itmListItem = New ListViewItem()
            strValue = IIf(myData.IsDBNull(0), "", myData.GetValue(0))
            itmListItem.Text = strValue

            For shtCntr = 1 To myData.FieldCount() - 1
                If myData.IsDBNull(shtCntr) Then
                    itmListItem.SubItems.Add("")
                Else
                    itmListItem.SubItems.Add(myData.GetValue(shtCntr))
                End If
            Next shtCntr

            lvList.Items.Add(itmListItem)
        Loop
    End Sub
End Module
