Imports System.Data.SqlClient

Public Class vendorFormRecords
    Dim rdr As SqlDataReader = Nothing
    Dim con As SqlConnection = Nothing
    Dim cmd As SqlCommand = Nothing
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Private ReadOnly Property Connection() As SqlConnection
        Get
            Dim ConnectionToFetch As New SqlConnection(cs)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property

    Public Function GetData() As DataView
        Dim SelectQry = "SELECT rtrim(vendorID)[Vendor ID],rtrim(name)[Name],rtrim(address)[Address],rtrim(landmark)[Landmark],rtrim(city)[City],rtrim(state)[State],rtrim(zipcode)[Zip/Post Code],rtrim(Phone)[Phone],rtrim(email)[Email],rtrim(mobileno)[Mobile No.],rtrim(faxno)[Fax No.],rtrim(notes)[Notes] from vendor order by vendorid"

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

    Private Sub vendorFormRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.DataSource = GetData()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
    End Sub


    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            VendorForm.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            VendorForm.inpVendorID.Text = dr.Cells(0).Value.ToString()
            VendorForm.inpVendorName.Text = dr.Cells(1).Value.ToString()

            VendorForm.inpVendorAddress.Text = dr.Cells(2).Value.ToString()
            VendorForm.inpCty.Text = dr.Cells(4).Value.ToString()
            VendorForm.inpVendorlandmark.Text = dr.Cells(3).Value.ToString()
            VendorForm.cbState.Text = dr.Cells(5).Value.ToString()
            VendorForm.inpZip.Text = dr.Cells(6).Value.ToString()
            VendorForm.inpPhone.Text = dr.Cells(7).Value.ToString()
            VendorForm.inpEmail.Text = dr.Cells(8).Value.ToString()
            VendorForm.inpMobile.Text = dr.Cells(9).Value.ToString()
            VendorForm.inpFax.Text = dr.Cells(10).Value.ToString()
            VendorForm.inpNotes.Text = dr.Cells(11).Value.ToString()
            VendorForm.Update_Record.Enabled = True
            VendorForm.Delete.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class