Imports System.Data.SqlClient

Public Class stockdetailsform
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Sub fillProduct()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(ProductName) FROM stock", CN)
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
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(Weight) FROM stock", CN)
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
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(Category) FROM stock", CN)
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

    Private Sub stockdetailsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCategory()
        fillProduct()
        fillWeight()
    End Sub

    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        cbPName.Text = ""
        inpSearchP.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub

    Private Sub TabsBody_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabsBody.Click
        DataGridView4.DataSource = Nothing
        cbpCategory.Text = ""
        cbProductWeight.Text = ""
        DataGridView3.DataSource = Nothing
        cbPName.Text = ""
        inpSearchP.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub

    Private Sub cbPName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPName.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(StockID)[Stock ID],rtrim(StockDate)[Entry Date],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Category)[Category],rtrim(Weight)[Weight/Qty],rtrim(Cartons)[Cartons],rtrim(Packets)[Packets],rtrim(TotalPackets)[Total Packets] from Stock where Productname = '" & cbPName.Text & "'order by ProductName", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Stock")

            DataGridView2.DataSource = myDataSet.Tables("Stock").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub inpSearchP_TextChanged(sender As Object, e As EventArgs) Handles inpSearchP.TextChanged
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(StockID)[Stock ID],rtrim(StockDate)[Entry Date],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Category)[Category],rtrim(Weight)[Weight/Qty],rtrim(Cartons)[Cartons],rtrim(Packets)[Packets],rtrim(TotalPackets)[Total Packets] from Stock where Productname like '" & inpSearchP.Text & "%' order by ProductName", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Stock")

            DataGridView2.DataSource = myDataSet.Tables("Stock").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Resetbtn3_Click(sender As Object, e As EventArgs) Handles Resetbtn3.Click
        cbpCategory.Text = ""
        DataGridView3.DataSource = Nothing
    End Sub

    Private Sub Resetbtn2_Click(sender As Object, e As EventArgs) Handles Resetbtn2.Click
        cbProductWeight.Text = ""
        DataGridView4.DataSource = Nothing
    End Sub

    Private Sub cbpCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpCategory.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(StockID)[Stock ID],rtrim(StockDate)[Entry Date],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Category)[Category],rtrim(Weight)[Weight/Qty],rtrim(Cartons)[Cartons],rtrim(Packets)[Packets],rtrim(TotalPackets)[Total Packets] from Stock where category = '" & cbpCategory.Text & "'order by Category", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Stock")

            DataGridView4.DataSource = myDataSet.Tables("Stock").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbProductWeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductWeight.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)

            con.Open()
            cmd = New SqlCommand("SELECT rtrim(StockID)[Stock ID],rtrim(StockDate)[Entry Date],rtrim(ProductCode)[Product Code],rtrim(ProductName)[Product Name],rtrim(Category)[Category],rtrim(Weight)[Weight/Qty],rtrim(Cartons)[Cartons],rtrim(Packets)[Packets],rtrim(TotalPackets)[Total Packets] from Stock where Weight = '" & cbProductWeight.Text & "'order by weight", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Stock")

            DataGridView3.DataSource = myDataSet.Tables("Stock").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class