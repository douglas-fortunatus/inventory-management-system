Imports System.Data.SqlClient

Public Class CartegoryRecordForm
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
        Dim SelectQry = "SELECT rtrim(CategoryID)[Category ID],rtrim(CategoryName)[Category Name] from Invcategory order by CategoryID"

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

    Private Sub CartegoryRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.DataSource = GetData()
    End Sub

    Private Sub CartegoryRecordForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        inveCategoryForm.Show()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            inveCategoryForm.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            inveCategoryForm.inpCtgryID.Text = dr.Cells(0).Value.ToString()
            inveCategoryForm.inpCtgryName.Text = dr.Cells(1).Value.ToString()
            inveCategoryForm.Update_categoty.Enabled = True
            inveCategoryForm.Delete_category.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            inveCategoryForm.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            inveCategoryForm.inpCtgryID.Text = dr.Cells(0).Value.ToString()
            inveCategoryForm.inpCtgryName.Text = dr.Cells(1).Value.ToString()
            inveCategoryForm.Update_categoty.Enabled = True
            inveCategoryForm.Delete_category.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class