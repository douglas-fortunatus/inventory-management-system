Imports System.Data.SqlClient

Public Class salesRecord
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Private Sub salesRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillInvoiceNo()
        fillCustomerName()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
        dtpInvoiceDateFrom.Text = Today
        dtpInvoiceDateTo.Text = Today
        GroupBox3.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            GroupBox3.Visible = True
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(invoiceNo)[Invoice No.],rtrim(BillingDate)[Invoice Date],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(GrandTotal)[Grand Total],rtrim(TotalPayment)[Total Payment],rtrim(PaymentDue)[Payment Due] from billinfo where BillingDate between @date1 and @date2 order by BillingDate", con)
            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "BillingDate").Value = dtpInvoiceDateFrom.Value.Date
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "BillingDate").Value = dtpInvoiceDateTo.Value.Date

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "BillInfo")

            DataGridView1.DataSource = myDataSet.Tables("Billinfo").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            Dim sum2 As Int64 = 0

            For Each r As DataGridViewRow In Me.DataGridView1.Rows
                sum = sum + r.Cells(4).Value
                sum1 = sum1 + r.Cells(5).Value
                sum2 = sum2 + r.Cells(6).Value
            Next
            TextBox1.Text = sum
            TextBox2.Text = sum1
            TextBox3.Text = sum2

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillCustomerName()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(CustomerName) FROM Billinfo", CN)
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

    Sub fillInvoiceNo()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(invoiceno) FROM Billinfo", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbInvoiceNo.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbInvoiceNo.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSalesRecord_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        mainform.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        DataGridView3.DataSource = Nothing
        cmbCustomerName.Text = ""
        GroupBox4.Visible = False
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        DataGridView4.DataSource = Nothing
        cmbInvoiceNo.Text = ""
        GroupBox5.Visible = False
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        DataGridView4.DataSource = Nothing
        cmbInvoiceNo.Text = ""
        GroupBox5.Visible = False
        DataGridView3.DataSource = Nothing
        cmbCustomerName.Text = ""
        GroupBox4.Visible = False
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DataGridView2.DataSource = Nothing
        GroupBox10.Visible = False
        DataGridView1.DataSource = Nothing
        dtpInvoiceDateFrom.Text = Today
        dtpInvoiceDateTo.Text = Today
        GroupBox3.Visible = False
    End Sub

    Private Sub cmbCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomerName.SelectedIndexChanged
        Try
            GroupBox4.Visible = True
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(invoiceNo)[Invoice No.],rtrim(BillingDate)[Invoice Date],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(GrandTotal)[Grand Total],rtrim(TotalPayment)[Total Payment],rtrim(PaymentDue)[Payment Due] from billinfo where customername= '" & cmbCustomerName.Text & "' order by BillingDate", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "BillInfo")

            DataGridView3.DataSource = myDataSet.Tables("Billinfo").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            Dim sum2 As Int64 = 0

            For Each r As DataGridViewRow In Me.DataGridView3.Rows
                sum = sum + r.Cells(4).Value
                sum1 = sum1 + r.Cells(5).Value
                sum2 = sum2 + r.Cells(6).Value
            Next
            TextBox6.Text = sum
            TextBox5.Text = sum1
            TextBox4.Text = sum2

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbInvoiceNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbInvoiceNo.SelectedIndexChanged
        Try
            GroupBox5.Visible = True
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand(" select rtrim(invoiceNo)[Invoice No.],rtrim(BillingDate)[Invoice Date],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(GrandTotal)[Grand Total],rtrim(TotalPayment)[Total Payment],rtrim(PaymentDue)[Payment Due] from billinfo where invoiceno = '" & cmbInvoiceNo.Text & "' order by BillingDate", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "BillInfo")

            DataGridView4.DataSource = myDataSet.Tables("Billinfo").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            Dim sum2 As Int64 = 0


            For Each r As DataGridViewRow In Me.DataGridView4.Rows
                sum = sum + r.Cells(4).Value
                sum1 = sum1 + r.Cells(5).Value
                sum2 = sum2 + r.Cells(6).Value
            Next
            TextBox9.Text = sum
            TextBox8.Text = sum1
            TextBox7.Text = sum2

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            GroupBox10.Visible = True
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(invoiceNo)[Invoice No.],rtrim(BillingDate)[Invoice Date],rtrim(CustomerNo)[Distributor ID],rtrim(CustomerName)[Distributor Name],rtrim(GrandTotal)[Grand Total],rtrim(TotalPayment)[Total Payment],rtrim(PaymentDue)[Payment Due] from billinfo where BillingDate between @date1 and @date2 and PaymentDue > 0 order by BillingDate", con)
            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "BillingDate").Value = DateTimePicker2.Value.Date
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "BillingDate").Value = DateTimePicker1.Value.Date

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "BillInfo")

            DataGridView2.DataSource = myDataSet.Tables("Billinfo").DefaultView
            Dim sum As Int64 = 0
            Dim sum1 As Int64 = 0
            Dim sum2 As Int64 = 0

            For Each r As DataGridViewRow In Me.DataGridView2.Rows
                sum = sum + r.Cells(4).Value
                sum1 = sum1 + r.Cells(5).Value
                sum2 = sum2 + r.Cells(6).Value
            Next
            TextBox12.Text = sum
            TextBox11.Text = sum1
            TextBox10.Text = sum2

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DataGridView2.DataSource = Nothing
        GroupBox10.Visible = False
    End Sub
End Class