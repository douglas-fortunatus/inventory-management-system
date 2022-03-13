Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class ProductForm
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Sub clear()
        inpUnitPrice.Text = ""
        inpProductCode.Text = ""
        inpProductName.Text = ""
        cbCategory.Text = ""
        cbWeight.Text = ""

    End Sub

    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function

    Sub auto()
        inpProductCode.Text = "P-" & GetUniqueKey(4)
    End Sub

    Sub fillCategory()

        Try

            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(CategoryName) FROM Invcategory", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cbCategory.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cbCategory.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillWeight()

        Try

            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(Weight) FROM Stock", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cbWeight.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cbWeight.Items.Add(drow(0).ToString())

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCategory()
        fillWeight()
        autocomplete()
    End Sub

    Private Sub NewProeduct_Click(sender As Object, e As EventArgs) Handles NewProeduct.Click
        clear()
        inpProductName.Focus()
        SaveProduct.Enabled = True
        EditProduct.Enabled = False
        DeleteProduct.Enabled = False
    End Sub

    Sub autocomplete()
        con = New SqlConnection(cs)
        con.Open()

        Dim cmd As New SqlCommand("SELECT ProductName FROM product", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "My List") 'list can be any name u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Productname").ToString())
        Next

        inpProductName.AutoCompleteSource = AutoCompleteSource.CustomSource
        inpProductName.AutoCompleteCustomSource = col
        inpProductName.AutoCompleteMode = AutoCompleteMode.Suggest

        con.Close()
    End Sub

    Private Sub SaveProduct_Click(sender As Object, e As EventArgs) Handles SaveProduct.Click
        If Len(Trim(inpProductName.Text)) = 0 Then
            MessageBox.Show("Please enter product name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            inpProductName.Focus()
            Exit Sub
        End If
        If Len(Trim(cbCategory.Text)) = 0 Then
            MessageBox.Show("Please select category", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbCategory.Focus()
            Exit Sub
        End If
        If Len(Trim(cbWeight.Text)) = 0 Then
            MessageBox.Show("Please enter weight", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbWeight.Focus()
            Exit Sub
        End If
        If Len(Trim(inpUnitPrice.Text)) = 0 Then
            MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            inpUnitPrice.Focus()
            Exit Sub
        End If

        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct1 As String = "select Productname from Product where Productname= '" & inpProductName.Text & "' and Weight= '" & cbWeight.Text & "'"

            cmd = New SqlCommand(ct1)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Entry for product already exists" & vbCrLf & "You can not make duplicate entry" & vbCrLf & "for the same product name & weight" & vbCrLf & "please update the details of product", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If

            auto()
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select productcode from Product where productcode=@find"

            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "productcode"))
            cmd.Parameters("@find").Value = inpProductCode.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Product Code Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else

                con = New SqlConnection(cs)
                con.Open()

                Dim cb As String = "insert into Product(productcode,productname,category,weight,price) VALUES (@d1,@d2,@d3,@d4,@d5)"

                cmd = New SqlCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "productcode"))
                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "productname"))
                cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.VarChar, 150, "category"))
                cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "weight"))
                cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.Float, 10, "price"))

                cmd.Parameters("@d1").Value = inpProductCode.Text
                cmd.Parameters("@d2").Value = inpProductName.Text
                cmd.Parameters("@d3").Value = cbCategory.Text
                cmd.Parameters("@d4").Value = cbWeight.Text
                cmd.Parameters("@d5").Value = CDbl(inpUnitPrice.Text)


                cmd.ExecuteReader()
                MessageBox.Show("Successfully saved", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SaveProduct.Enabled = False
                fillCategory()
                fillWeight()
                autocomplete()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditProduct_Click(sender As Object, e As EventArgs) Handles EditProduct.Click
        Try

            con = New SqlConnection(cs)
            con.Open()

            Dim cb As String = "update product set Productname=@d2,category=@d3,Weight=@d4,price=@d5 where Productcode=@d1"

            cmd = New SqlCommand(cb)

            cmd.Connection = con

            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "productcode"))
            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "productname"))
            cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.VarChar, 150, "category"))
            cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "weight"))
            cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.Float, 10, "price"))

            cmd.Parameters("@d1").Value = inpProductCode.Text
            cmd.Parameters("@d2").Value = inpProductName.Text
            cmd.Parameters("@d3").Value = cbCategory.Text
            cmd.Parameters("@d4").Value = cbWeight.Text
            cmd.Parameters("@d5").Value = CDbl(inpUnitPrice.Text)

            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EditProduct.Enabled = False
            fillCategory()
            fillWeight()
            autocomplete()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteProduct_Click(sender As Object, e As EventArgs) Handles DeleteProduct.Click
        Try

            If MessageBox.Show("Do you really want to delete the record?", "Product Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                delete_records()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ProductForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        mainform.Show()
    End Sub

    Private Sub delete_records()
        Try
            Dim RowsAffected As Integer = 0

            con = New SqlConnection(cs)

            con.Open()
            Dim ct As String = "select ProductCode from Stock where ProductCode=@find"

            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "ProductCode"))
            cmd.Parameters("@find").Value = inpProductCode.Text

            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()

                EditProduct.Enabled = False
                DeleteProduct.Enabled = False

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)

            con.Open()
            Dim ct1 As String = "select ProductCode from ProductSold where ProductCode=@find"

            cmd = New SqlCommand(ct1)

            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "ProductCode"))
            cmd.Parameters("@find").Value = inpProductCode.Text

            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()

                EditProduct.Enabled = False
                DeleteProduct.Enabled = False

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)

            con.Open()
            Dim ct2 As String = "select ProductCode from OrderedProduct where ProductCode=@find"


            cmd = New SqlCommand(ct2)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "ProductCode"))
            cmd.Parameters("@find").Value = inpProductCode.Text

            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()

                EditProduct.Enabled = False
                DeleteProduct.Enabled = False

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)

            con.Open()


            Dim cq As String = "delete from Product where ProductCode=@DELETE1;"

            cmd = New SqlCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 20, "ProductCode"))


            cmd.Parameters("@DELETE1").Value = Trim(inpProductCode.Text)
            RowsAffected = cmd.ExecuteNonQuery()

            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()

                EditProduct.Enabled = False
                DeleteProduct.Enabled = False
                fillCategory()
                fillWeight()
                autocomplete()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()
                EditProduct.Enabled = False
                DeleteProduct.Enabled = False

                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inpUnitPrice.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then

        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.inpUnitPrice.Text
            Dim selectionStart = Me.inpUnitPrice.SelectionStart
            Dim selectionLength = Me.inpUnitPrice.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then

                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3 Then

                e.Handled = False
            End If
        Else

            e.Handled = True
        End If
    End Sub

    Private Sub ViewProduct_Click(sender As Object, e As EventArgs) Handles ViewProduct.Click
        Me.clear()
        productdetailsform.DataGridView4.DataSource = Nothing
        productdetailsform.cbpCategory.Text = ""
        productdetailsform.cbProductWeight.Text = ""
        productdetailsform.DataGridView3.DataSource = Nothing
        productdetailsform.cbPName.Text = ""
        productdetailsform.inpSearchP.Text = ""
        productdetailsform.DataGridView2.DataSource = Nothing
        productdetailsform.DataGridView1.DataSource = Nothing
        productdetailsform.Show()
    End Sub
End Class