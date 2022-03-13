Imports System.Data.SqlClient

Public Class searchProductForm
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Private Sub searchProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCategory()
        fillProductName()
        fillWeight()
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged
        Try
            GroupBox2.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT rtrim(Product.ProductCode)[Product Code],rtrim(Product.ProductName)[Product Name],rtrim(Product.category)[Category],rtrim(Product.Weight)[Weight],rtrim(Price)[Unit Price],sum(Cartons)[Cartons],sum(TotalPackets)[Packets] from product,Stock  where product.productcode=stock.productcode and Product.ProductName= '" & cmbProductName.Text & "' group by Product.ProductCode,Product.Productname,Product.Weight,Product.Category,Product.Price order by Product.ProductName", con)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Product")
            myDA.Fill(myDataSet, "Stock")
            DataGridView1.DataSource = myDataSet.Tables("Product").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Stock").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            For Each r As DataGridViewRow In Me.DataGridView1.Rows
                sum = sum + r.Cells(5).Value
                sum1 = sum1 + r.Cells(6).Value

            Next
            txtC1.Text = sum
            txtP1.Text = sum1

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillWeight()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(weight) FROM Stock", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbWeight.Items.Clear()
            ComboBox1.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbWeight.Items.Add(drow(0).ToString())
                ComboBox1.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillProductName()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(ProductName) FROM Stock", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbProductName.Items.Clear()
            ComboBox2.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbProductName.Items.Add(drow(0).ToString())
                ComboBox2.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillCategory()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(Category) FROM stock", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCategory.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbCategory.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        txtProductName.Text = ""
        cmbProductName.Text = ""
        DataGridView1.DataSource = Nothing
        GroupBox2.Visible = False
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        txtProductName.Text = ""
        cmbProductName.Text = ""
        GroupBox2.Visible = False
        DataGridView1.DataSource = Nothing
        GroupBox5.Visible = False
        cmbWeight.Text = ""
        DataGridView2.DataSource = Nothing
        GroupBox7.Visible = False
        DataGridView3.DataSource = Nothing
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DataGridView4.DataSource = Nothing
        GroupBox13.Visible = False
        GroupBox16.Visible = False
        cmbCategory.Text = ""
        DataGridView5.DataSource = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox5.Visible = False
        cmbWeight.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub

    Private Sub cmbWeight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWeight.SelectedIndexChanged
        Try
            GroupBox5.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT rtrim(Product.ProductCode)[Product Code],rtrim(Product.ProductName)[Product Name],rtrim(Product.category)[Category],rtrim(Product.Weight)[Weight],rtrim(Price)[Unit Price],sum(Cartons)[Cartons],sum(TotalPackets)[Packets] from product,Stock  where product.productcode=stock.productcode and Product.Weight= '" & cmbWeight.Text & "' group by Product.ProductCode,Product.Productname,Product.Weight,Product.Category,Product.Price order by Product.ProductName,Product.Weight", con)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Product")
            myDA.Fill(myDataSet, "Stock")
            DataGridView2.DataSource = myDataSet.Tables("Product").DefaultView
            DataGridView2.DataSource = myDataSet.Tables("Stock").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            For Each r As DataGridViewRow In Me.DataGridView2.Rows
                sum = sum + r.Cells(5).Value
                sum1 = sum1 + r.Cells(6).Value

            Next
            txtC2.Text = sum
            txtP2.Text = sum1

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox7.Visible = False
        DataGridView3.DataSource = Nothing
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            GroupBox7.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT rtrim(Product.ProductCode)[Product Code],rtrim(Product.ProductName)[Product Name],rtrim(Product.category)[Category],rtrim(Product.Weight)[Weight],rtrim(Price)[Unit Price],sum(Cartons)[Cartons],sum(TotalPackets)[Packets] from product,Stock  where product.productcode=stock.productcode and cartons > 0 and TotalPackets > 0 group by Product.ProductCode,Product.Productname,Product.Weight,Product.Category,Product.Price order by Product.ProductName", con)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Product")
            myDA.Fill(myDataSet, "Stock")
            DataGridView3.DataSource = myDataSet.Tables("Product").DefaultView
            DataGridView3.DataSource = myDataSet.Tables("Stock").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            For Each r As DataGridViewRow In Me.DataGridView3.Rows
                sum = sum + r.Cells(5).Value
                sum1 = sum1 + r.Cells(6).Value

            Next
            txtC3.Text = sum
            txtP3.Text = sum1

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtProductName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductName.TextChanged
        Try
            GroupBox2.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT rtrim(Product.ProductCode)[Product Code],rtrim(Product.ProductName)[Product Name],rtrim(Product.category)[Category],rtrim(Product.Weight)[Weight],rtrim(Price)[Unit Price],sum(Cartons)[Cartons],sum(TotalPackets)[Packets] from product,Stock  where product.productcode=stock.productcode and Product.ProductName like '" & cmbProductName.Text & "%' group by Product.ProductCode,Product.Productname,Product.Weight,Product.Category,Product.Price order by Product.ProductName", con)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Product")
            myDA.Fill(myDataSet, "Stock")
            DataGridView1.DataSource = myDataSet.Tables("Product").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Stock").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            For Each r As DataGridViewRow In Me.DataGridView1.Rows
                sum = sum + r.Cells(5).Value
                sum1 = sum1 + r.Cells(6).Value

            Next
            txtC1.Text = sum
            txtP1.Text = sum1

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            GroupBox13.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT rtrim(Product.ProductCode)[Product Code],rtrim(Product.ProductName)[Product Name],rtrim(Product.category)[Category],rtrim(Product.Weight)[Weight],rtrim(Price)[Unit Price],sum(Cartons)[Cartons],sum(TotalPackets)[Packets] from product,Stock  where product.productcode=stock.productcode and Product.ProductName = '" & ComboBox2.Text & "' and Product.weight= '" & ComboBox1.Text & "' group by Product.ProductCode,Product.Productname,Product.Weight,Product.Category,Product.Price order by Product.ProductName,Product.Weight", con)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Product")
            myDA.Fill(myDataSet, "Stock")
            DataGridView4.DataSource = myDataSet.Tables("Product").DefaultView
            DataGridView4.DataSource = myDataSet.Tables("Stock").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            For Each r As DataGridViewRow In Me.DataGridView4.Rows
                sum = sum + r.Cells(5).Value
                sum1 = sum1 + r.Cells(6).Value

            Next
            txtC4.Text = sum
            txtP4.Text = sum1

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        Try
            GroupBox16.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT rtrim(Product.ProductCode)[Product Code],rtrim(Product.ProductName)[Product Name],rtrim(Product.category)[Category],rtrim(Product.Weight)[Weight],rtrim(Price)[Unit Price],sum(Cartons)[Cartons],sum(TotalPackets)[Packets] from product,Stock  where product.productcode=stock.productcode and Product.Category= '" & cmbCategory.Text & "' group by Product.ProductCode,Product.Productname,Product.Weight,Product.Category,Product.Price order by Product.ProductName,Product.Category", con)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Product")
            myDA.Fill(myDataSet, "Stock")
            DataGridView5.DataSource = myDataSet.Tables("Product").DefaultView
            DataGridView5.DataSource = myDataSet.Tables("Stock").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            For Each r As DataGridViewRow In Me.DataGridView5.Rows
                sum = sum + r.Cells(5).Value
                sum1 = sum1 + r.Cells(6).Value

            Next
            txtC5.Text = sum
            txtP5.Text = sum1

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            orderform.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            orderform.txtProductCode.Text = dr.Cells(0).Value()
            orderform.txtProductName.Text = dr.Cells(1).Value()
            orderform.txtWeight.Text = dr.Cells(3).Value()
            orderform.txtPrice.Text = dr.Cells(4).Value()
            orderform.txtAvailableCartons.Text = dr.Cells(5).Value()
            orderform.txtPacketsPerCarton.Text = dr.Cells(6).Value()
            orderform.txtCartons.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            Me.Hide()
            orderform.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            orderform.txtProductCode.Text = dr.Cells(0).Value()
            orderform.txtProductName.Text = dr.Cells(1).Value()
            orderform.txtWeight.Text = dr.Cells(3).Value()
            orderform.txtPrice.Text = dr.Cells(4).Value()
            orderform.txtAvailableCartons.Text = dr.Cells(5).Value()
            orderform.txtPacketsPerCarton.Text = dr.Cells(6).Value()
            orderform.txtCartons.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView3_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView3.SelectedRows(0)
            Me.Hide()
            orderform.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            orderform.txtProductCode.Text = dr.Cells(0).Value()
            orderform.txtProductName.Text = dr.Cells(1).Value()
            orderform.txtWeight.Text = dr.Cells(3).Value()
            orderform.txtPrice.Text = dr.Cells(4).Value()
            orderform.txtAvailableCartons.Text = dr.Cells(5).Value()
            orderform.txtPacketsPerCarton.Text = dr.Cells(6).Value()
            orderform.txtCartons.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView4_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView4.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView4.SelectedRows(0)
            Me.Hide()
            orderform.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            orderform.txtProductCode.Text = dr.Cells(0).Value()
            orderform.txtProductName.Text = dr.Cells(1).Value()
            orderform.txtWeight.Text = dr.Cells(3).Value()
            orderform.txtPrice.Text = dr.Cells(4).Value()
            orderform.txtAvailableCartons.Text = dr.Cells(5).Value()
            orderform.txtPacketsPerCarton.Text = dr.Cells(6).Value()
            orderform.txtCartons.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView5_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView5.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView5.SelectedRows(0)
            Me.Hide()
            orderform.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            orderform.txtProductCode.Text = dr.Cells(0).Value()
            orderform.txtProductName.Text = dr.Cells(1).Value()
            orderform.txtWeight.Text = dr.Cells(3).Value()
            orderform.txtPrice.Text = dr.Cells(4).Value()
            orderform.txtAvailableCartons.Text = dr.Cells(5).Value()
            orderform.txtPacketsPerCarton.Text = dr.Cells(6).Value()
            orderform.txtCartons.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class