Imports System.Data.SqlClient

Public Class productdetailsform
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Private Sub productdetailsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCategory()
        fillProduct()
        fillWeight()
    End Sub

    Sub fillProduct()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(ProductName) FROM Product", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cbPName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cbPName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
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
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(Weight) FROM product", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cbProductWeight.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cbProductWeight.Items.Add(drow(0).ToString())
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
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(Category) FROM Product", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cbpCategory.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cbpCategory.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Con = New SqlConnection(cs)

            Con.Open()
            cmd = New SqlCommand("SELECT rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Category)[Category],rtrim(Weight)[Weight Per Qty],rtrim(Price)[Price] from Product order by ProductName", Con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Product")

            DataGridView1.DataSource = myDataSet.Tables("Product").DefaultView


            Con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabsBody_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabsBody.Click
        DataGridView4.DataSource = Nothing
        cbpCategory.Text = ""
        cbProductWeight.Text = ""
        DataGridView3.DataSource = Nothing
        cbPName.Text = ""
        inpSearchP.Text = ""
        DataGridView2.DataSource = Nothing
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub cbPName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPName.SelectedIndexChanged
        Try
            Con = New SqlConnection(cs)

            Con.Open()
            cmd = New SqlCommand("SELECT rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Category)[Category],rtrim(Weight)[Weight Per Qty],rtrim(Price)[Price] from Product where ProductName= '" & cbPName.Text & "' order by Productname", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Product")

            DataGridView2.DataSource = myDataSet.Tables("Product").DefaultView

            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub inpSearchP_TextChanged(sender As Object, e As EventArgs) Handles inpSearchP.TextChanged
        Try
            Con = New SqlConnection(cs)

            Con.Open()
            cmd = New SqlCommand("SELECT rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Category)[Category],rtrim(Weight)[Weight Per Qty],rtrim(Price)[Price] from Product where ProductName like '" & inpSearchP.Text & "%' order by ProductName", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Product")

            DataGridView2.DataSource = myDataSet.Tables("Product").DefaultView

            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbProductWeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductWeight.SelectedIndexChanged
        Try
            Con = New SqlConnection(cs)

            Con.Open()
            cmd = New SqlCommand("SELECT rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Category)[Category],rtrim(Weight)[Weight Per Qty],rtrim(Price)[Price] from Product where Weight = '" & cbProductWeight.Text & "' order by ProductName", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Product")

            DataGridView3.DataSource = myDataSet.Tables("Product").DefaultView


            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbpCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpCategory.SelectedIndexChanged
        Try
            Con = New SqlConnection(cs)

            Con.Open()
            cmd = New SqlCommand("SELECT rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Category)[Category],rtrim(Weight)[Weight Per Qty],rtrim(Price)[Price] from Product where Category = '" & cbpCategory.Text & "' order by ProductName", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Product")

            DataGridView4.DataSource = myDataSet.Tables("Product").DefaultView


            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            stockForm.Show()
            stockForm.txtProductCode.Text = dr.Cells(0).Value.ToString()
            stockForm.txtProductName.Text = dr.Cells(1).Value.ToString()
            stockForm.txtCategory.Text = dr.Cells(2).Value.ToString()
            stockForm.txtWeight.Text = dr.Cells(3).Value.ToString()
            stockForm.txtCartons.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            Me.Hide()
            stockForm.Show()
            stockForm.txtProductCode.Text = dr.Cells(0).Value.ToString()
            stockForm.txtProductName.Text = dr.Cells(1).Value.ToString()
            stockForm.txtCategory.Text = dr.Cells(2).Value.ToString()
            stockForm.txtWeight.Text = dr.Cells(3).Value.ToString()
            stockForm.txtCartons.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView3_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView3.SelectedRows(0)
            Me.Hide()
            stockForm.Show()
            stockForm.txtProductCode.Text = dr.Cells(0).Value.ToString()
            stockForm.txtProductName.Text = dr.Cells(1).Value.ToString()
            stockForm.txtCategory.Text = dr.Cells(2).Value.ToString()
            stockForm.txtWeight.Text = dr.Cells(3).Value.ToString()
            stockForm.txtCartons.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView4_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView4.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView4.SelectedRows(0)
            Me.Hide()
            stockForm.Show()
            stockForm.txtProductCode.Text = dr.Cells(0).Value.ToString()
            stockForm.txtProductName.Text = dr.Cells(1).Value.ToString()
            stockForm.txtCategory.Text = dr.Cells(2).Value.ToString()
            stockForm.txtWeight.Text = dr.Cells(3).Value.ToString()
            stockForm.txtCartons.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class