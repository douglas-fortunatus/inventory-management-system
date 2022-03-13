Imports System.Data.SqlClient

Public Class orderRecordForm
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Private Sub orderRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCustomerName()
        fillorderNo()
        fillProductName()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(OrderInfo.OrderNo)[Order No.],rtrim(OrderDate)[Order Date],rtrim(OrderStatus)[Order Status],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Weight)[Weight],rtrim(Price)[Price],rtrim(Cartons)[Cartons],rtrim(TotalPackets)[Total Packets],RTRIM(OrderedProduct.TotalAmount)[Total Amount] from orderinfo,orderedproduct where orderinfo.orderno=orderedproduct.orderno and OrderDate between @date1 and @date2 order by orderinfo.OrderNo,OrderDate", con)
            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "OrderDate").Value = dtpOrderDateFrom.Value.Date
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "OrderDate").Value = dtpOrderDateTo.Value.Date

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView1.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
        dtpOrderDateFrom.Text = Today
        dtpOrderDateTo.Text = Today
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        DataGridView2.DataSource = Nothing
        cmbOrderNo.Text = ""
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(OrderInfo.OrderNo)[Order No.],rtrim(OrderDate)[Order Date],rtrim(OrderStatus)[Order Status],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Weight)[Weight],rtrim(Price)[Price],rtrim(Cartons)[Cartons],rtrim(TotalPackets)[Total Packets],RTRIM(OrderedProduct.TotalAmount)[Total Amount] from orderinfo,orderedproduct where orderinfo.orderno=orderedproduct.orderno and orderstatus = '" & cmbStatus.Text & "' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView3.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView3.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        DataGridView3.DataSource = Nothing
        cmbStatus.Text = ""
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        txtCustomer.Text = ""
        DataGridView6.DataSource = Nothing
        cmbCustomerName.Text = ""
    End Sub

    Sub fillProductName()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(ProductName) FROM orderedProduct", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbProductName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbProductName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillCustomerName()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(CustomerName) FROM orderinfo", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCustomerName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbCustomerName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillorderNo()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(orderno) FROM orderinfo", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbOrderNo.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbOrderNo.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        DataGridView1.DataSource = Nothing
        dtpOrderDateFrom.Text = Today
        dtpOrderDateTo.Text = Today
        DataGridView6.DataSource = Nothing
        cmbCustomerName.Text = ""
        txtCustomer.Text = ""
        DataGridView3.DataSource = Nothing
        cmbStatus.Text = ""
        DataGridView2.DataSource = Nothing
        cmbOrderNo.Text = ""
        cmbProductName.Text = ""
        txtProduct.Text = ""
        DataGridView5.DataSource = Nothing
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cmbProductName.Text = ""
        txtProduct.Text = ""
        DataGridView5.DataSource = Nothing
    End Sub

    Private Sub txtCustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.TextChanged
        Try
            con = New SqlConnection(cs)

            con.Open()

            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(OrderInfo.OrderNo)[Order No.],rtrim(OrderDate)[Order Date],rtrim(OrderStatus)[Order Status],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Weight)[Weight],rtrim(Price)[Price],rtrim(Cartons)[Cartons],rtrim(TotalPackets)[Total Packets],RTRIM(OrderedProduct.TotalAmount)[Total Amount] from orderinfo,orderedproduct where orderinfo.orderno=orderedproduct.orderno and CustomerName like '" & txtCustomer.Text & "%' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView6.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView6.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.TextChanged
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(OrderInfo.OrderNo)[Order No.],rtrim(OrderDate)[Order Date],rtrim(OrderStatus)[Order Status],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Weight)[Weight],rtrim(Price)[Price],rtrim(Cartons)[Cartons],rtrim(TotalPackets)[Total Packets],RTRIM(OrderedProduct.TotalAmount)[Total Amount] from orderinfo,orderedproduct where orderinfo.orderno=orderedproduct.orderno and ProductName like '" & txtProduct.Text & "%' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView5.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView5.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(OrderInfo.OrderNo)[Order No.],rtrim(OrderDate)[Order Date],rtrim(OrderStatus)[Order Status],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Weight)[Weight],rtrim(Price)[Price],rtrim(Cartons)[Cartons],rtrim(TotalPackets)[Total Packets],RTRIM(OrderedProduct.TotalAmount)[Total Amount] from orderinfo,orderedproduct where orderinfo.orderno=orderedproduct.orderno and ProductName = '" & cmbProductName.Text & "' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView5.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView5.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomerName.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(OrderInfo.OrderNo)[Order No.],rtrim(OrderDate)[Order Date],rtrim(OrderStatus)[Order Status],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Weight)[Weight],rtrim(Price)[Price],rtrim(Cartons)[Cartons],rtrim(TotalPackets)[Total Packets],RTRIM(OrderedProduct.TotalAmount)[Total Amount]  from orderinfo,orderedproduct where orderinfo.orderno=orderedproduct.orderno and CustomerName = '" & cmbCustomerName.Text & "' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView6.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView6.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbOrderNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrderNo.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(OrderInfo.OrderNo)[Order No.],rtrim(OrderDate)[Order Date],rtrim(OrderStatus)[Order Status],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Weight)[Weight],rtrim(Price)[Price],rtrim(Cartons)[Cartons],rtrim(TotalPackets)[Total Packets],RTRIM(OrderedProduct.TotalAmount)[Total Amount] from orderinfo,orderedproduct where orderinfo.orderno=orderedproduct.orderno and orderinfo.Orderno = '" & cmbOrderNo.Text & "' order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")
            myDA.Fill(myDataSet, "OrderedProduct")
            DataGridView2.DataSource = myDataSet.Tables("OrderInfo").DefaultView
            DataGridView2.DataSource = myDataSet.Tables("OrderedProduct").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmOrderRecord_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        mainform.Show()
    End Sub
End Class