Imports System.Data.SqlClient

Public Class mainform

    Dim sSql As String
    Dim con As SqlConnection
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Public Sub FillList()
        Try
            With ListView1
                .Clear()
                .Columns.Add("Product Code", 90)
                .Columns.Add("Product Name", 250, HorizontalAlignment.Center)
                .Columns.Add("Weight/Qty", 90, HorizontalAlignment.Center)
                .Columns.Add("Cartons", 90, HorizontalAlignment.Center)
                .Columns.Add("Total Packets", 90, HorizontalAlignment.Center)


                FillListView(ListView1, GetData(sSql))

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        sSql = "SELECT ProductCode,ProductName,Weight,sum(Cartons),sum(TotalPackets) from Stock where Cartons > 0 and TotalPackets > 0 group by ProductCode,ProductName,Weight order by ProductName "
        FillList()
    End Sub

    Private Sub NewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem2.Click
        VendorForm.Show()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        inveCategoryForm.Show()
    End Sub

    Private Sub ProductToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem1.Click
        ProductForm.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Me.Hide()
        stockForm.Show()
    End Sub

    Public Function GetData(ByVal sSQL As String)

        Dim sqlCmd As SqlCommand = New SqlCommand(sSQL)
        Dim myData As SqlDataReader

        Con = New SqlConnection(cs)

        Try
            Con.Open()

            sqlCmd.Connection = Con

            myData = sqlCmd.ExecuteReader

            Return myData
        Catch ex As Exception
            Return ex
        End Try
    End Function

    Private Sub mainform_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        distributorform.Show()
    End Sub

    Private Sub NewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
        orderform.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        salesform.Show()
    End Sub

    Private Sub SalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem1.Click
        salesRecord.Show()
    End Sub

    Private Sub VendorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorToolStripMenuItem.Click
        vendorFormRecords.Show()
    End Sub

    Private Sub StockToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem1.Click
        stockdetailsform.Show()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        orderFormRecords.Show()
    End Sub

    Private Sub RecordsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem1.Click
        distributordetails.Show()
    End Sub
End Class
