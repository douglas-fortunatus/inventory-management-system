Imports System.Data.SqlClient

Public Class distributordetails1
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Sub fillName()
        Try
            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(B_Name) FROM Customer", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            txtName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                txtName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub distributordetails1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillName()
    End Sub

    Private ReadOnly Property Connection() As SqlConnection
        Get
            Dim ConnectionToFetch As New SqlConnection(cs)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property

    Public Function GetData() As DataView
        Dim SelectQry = "SELECT rtrim(customerNo)[Distributor ID],rtrim(B_name)[B_Name],rtrim(b_address)[B_Address],rtrim(b_landmark)[B_LandMark],rtrim(b_city)[B_City],rtrim(b_state)[B_State],rtrim(b_zipcode)[B_Zip/Post Code],rtrim(s_name)[S_Name],rtrim(s_address)[S_Address],rtrim(s_landmark)[S_LandMark],rtrim(s_city)[S_City],rtrim(s_state)[S_State],rtrim(s_zipcode)[S_Zip/Post Code],rtrim(Phone)[Phone],rtrim(email)[Email],rtrim(mobileno)[Mobile No.],rtrim(faxno)[Fax No.],rtrim(notes)[Notes] from Customer order by CustomerNo"

        Dim SampleSource As New DataSet
        Dim TableView As DataView
        Try
            Dim SampleCommand As New SqlCommand()
            Dim SampleDataAdapter = New SqlDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TableView
    End Function

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.DataSource = GetData()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtName.Text = ""
        txtCustomer.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        DataGridView1.DataSource = Nothing
        txtName.Text = ""
        txtCustomer.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub

    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            Me.Hide()
            distributorform.Show()

            distributorform.txtCustomerNo.Text = dr.Cells(0).Value.ToString()
            distributorform.B_name.Text = dr.Cells(1).Value.ToString()
            distributorform.B_Address.Text = dr.Cells(2).Value.ToString()
            distributorform.B_City.Text = dr.Cells(4).Value.ToString()
            distributorform.B_Landmark.Text = dr.Cells(3).Value.ToString()
            distributorform.B_State.Text = dr.Cells(5).Value.ToString()
            distributorform.B_ZipCode.Text = dr.Cells(6).Value.ToString()
            distributorform.S_name.Text = dr.Cells(7).Value.ToString()
            distributorform.S_Address.Text = dr.Cells(8).Value.ToString()
            distributorform.S_City.Text = dr.Cells(10).Value.ToString()
            distributorform.S_Landmark.Text = dr.Cells(9).Value.ToString()
            distributorform.S_State.Text = dr.Cells(11).Value.ToString()
            distributorform.S_ZipCode.Text = dr.Cells(12).Value.ToString()
            distributorform.txtPhone.Text = dr.Cells(13).Value.ToString()
            distributorform.txtEmail.Text = dr.Cells(14).Value.ToString()
            distributorform.txtMobileNo.Text = dr.Cells(15).Value.ToString()
            distributorform.txtFaxNo.Text = dr.Cells(16).Value.ToString()
            distributorform.txtNotes.Text = dr.Cells(17).Value.ToString()
            distributorform.Update_Record.Enabled = True
            distributorform.Delete.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT rtrim(customerNo)[Distributor ID],rtrim(B_name)[B_Name],rtrim(b_address)[B_Address],rtrim(b_landmark)[B_LandMark],rtrim(b_city)[B_City],rtrim(b_state)[B_State],rtrim(b_zipcode)[B_Zip/Post Code],rtrim(s_name)[S_Name],rtrim(s_address)[S_Address],rtrim(s_landmark)[S_LandMark],rtrim(s_city)[S_City],rtrim(s_state)[S_State],rtrim(s_zipcode)[S_Zip/Post Code],rtrim(Phone)[Phone],rtrim(email)[Email],rtrim(mobileno)[Mobile No.],rtrim(faxno)[Fax No.],rtrim(notes)[Notes] from Customer where B_Name like '" & txtCustomer.Text & "%'  order by CustomerNo", con)

            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Customer")

            DataGridView2.DataSource = myDataSet.Tables("Customer").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT rtrim(customerNo)[Distributor ID],rtrim(B_name)[B_Name],rtrim(b_address)[B_Address],rtrim(b_landmark)[B_LandMark],rtrim(b_city)[B_City],rtrim(b_state)[B_State],rtrim(b_zipcode)[B_Zip/Post Code],rtrim(s_name)[S_Name],rtrim(s_address)[S_Address],rtrim(s_landmark)[S_LandMark],rtrim(s_city)[S_City],rtrim(s_state)[S_State],rtrim(s_zipcode)[S_Zip/Post Code],rtrim(Phone)[Phone],rtrim(email)[Email],rtrim(mobileno)[Mobile No.],rtrim(faxno)[Fax No.],rtrim(notes)[Notes] from Customer where B_Name = '" & txtName.Text & "' order by CustomerNo", con)



            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Customer")

            DataGridView2.DataSource = myDataSet.Tables("Customer").DefaultView



            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            distributorform.Show()

            distributorform.txtCustomerNo.Text = dr.Cells(0).Value.ToString()
            distributorform.B_name.Text = dr.Cells(1).Value.ToString()

            distributorform.B_Address.Text = dr.Cells(2).Value.ToString()
            distributorform.B_City.Text = dr.Cells(4).Value.ToString()
            distributorform.B_Landmark.Text = dr.Cells(3).Value.ToString()
            distributorform.B_State.Text = dr.Cells(5).Value.ToString()
            distributorform.B_ZipCode.Text = dr.Cells(6).Value.ToString()
            distributorform.S_name.Text = dr.Cells(7).Value.ToString()

            distributorform.S_Address.Text = dr.Cells(8).Value.ToString()
            distributorform.S_City.Text = dr.Cells(10).Value.ToString()
            distributorform.S_Landmark.Text = dr.Cells(9).Value.ToString()
            distributorform.S_State.Text = dr.Cells(11).Value.ToString()
            distributorform.S_ZipCode.Text = dr.Cells(12).Value.ToString()
            distributorform.txtPhone.Text = dr.Cells(13).Value.ToString()
            distributorform.txtEmail.Text = dr.Cells(14).Value.ToString()
            distributorform.txtMobileNo.Text = dr.Cells(15).Value.ToString()
            distributorform.txtFaxNo.Text = dr.Cells(16).Value.ToString()
            distributorform.txtNotes.Text = dr.Cells(17).Value.ToString()
            distributorform.Update_Record.Enabled = True
            distributorform.Delete.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class