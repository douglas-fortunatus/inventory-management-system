Imports System.Data.SqlClient

Public Class inveCategoryForm
    Dim rdr As SqlDataReader = Nothing
    Dim con As SqlConnection = Nothing
    Dim cmd As SqlCommand = Nothing
    Dim cs As String = "Data Source=.\sqlexpress; Initial Catalog=inventory_managmrnt; Integrated Security=True;"

    Sub clear()
        inpCtgryID.Text = ""
        inpCtgryName.Text = ""
    End Sub

    Private Sub inveCategoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub new_category_Click(sender As Object, e As EventArgs) Handles new_category.Click
        inpCtgryID.Text = ""
        inpCtgryName.Text = ""
        Save_category.Enabled = True
        Delete_category.Enabled = False
        Update_categoty.Enabled = False
        inpCtgryName.Focus()
    End Sub

    Private Sub auto()
        con = New SqlConnection(cs)

        con.Open()

        Dim ct As String = "select Max(CategoryID) as CatID from Invcategory"

        cmd = New SqlCommand(ct)
        cmd.Connection = con
        rdr = cmd.ExecuteReader()
        rdr.Read()

        If rdr("CatID").ToString() <> "" Then
            inpCtgryID.Text = Integer.Parse(rdr("CatID").ToString()) + 1
        Else
            inpCtgryID.Text = 1
        End If

        con.Close()
        rdr.Close()
    End Sub

    Private Sub Save_category_Click(sender As Object, e As EventArgs) Handles Save_category.Click
        If Len(Trim(inpCtgryName.Text)) = 0 Then
            MessageBox.Show("Please enter category name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            inpCtgryName.Focus()
            Exit Sub
        End If

        Try
            auto()
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select CategoryID from Invcategory where CategoryID=@find"

            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 10, "CategoryID"))
            cmd.Parameters("@find").Value = inpCtgryID.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Category ID Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else

                con = New SqlConnection(cs)
                con.Open()

                Dim cb As String = "insert into Invcategory(CategoryID,CategoryName) VALUES (@d1,@d2)"

                cmd = New SqlCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 10, "VendorID"))
                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 150, "CategoryName"))

                cmd.Parameters("@d1").Value = inpCtgryID.Text
                cmd.Parameters("@d2").Value = inpCtgryName.Text

                cmd.ExecuteReader()
                MessageBox.Show("Successfully saved", "Category Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Save_category.Enabled = False
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Update_categoty_Click(sender As Object, e As EventArgs) Handles Update_categoty.Click
        Try
            con = New SqlConnection(cs)
            con.Open()

            Dim cb As String = "update Invcategory set CategoryName=@d2 where CategoryID=@d1"

            cmd = New SqlCommand(cb)

            cmd.Connection = con

            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 10, "VendorID"))
            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 150, "CategoryName"))

            cmd.Parameters("@d1").Value = inpCtgryID.Text
            cmd.Parameters("@d2").Value = inpCtgryName.Text

            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Category Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()

            Update_categoty.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub delete_records()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)

            con.Open()
            Dim ct As String = "select Category from Product where Category=@find"

            cmd = New SqlCommand(ct)

            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.VarChar, 150, "Category"))

            cmd.Parameters("@find").Value = inpCtgryName.Text

            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                clear()
                inpCtgryName.Focus()
                Update_categoty.Enabled = False
                Delete_category.Enabled = False
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If

            con = New SqlConnection(cs)

            con.Open()

            Dim cq As String = "delete from Invcategory where CategoryID=@DELETE1;"

            cmd = New SqlCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 10, "CategoryID"))

            cmd.Parameters("@DELETE1").Value = Trim(inpCtgryID.Text)
            RowsAffected = cmd.ExecuteNonQuery()

            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()
                inpCtgryName.Focus()
                Update_categoty.Enabled = False
                Delete_category.Enabled = False

            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()
                inpCtgryName.Focus()
                Update_categoty.Enabled = False
                Delete_category.Enabled = False

                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Delete_category_Click(sender As Object, e As EventArgs) Handles Delete_category.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Inventory Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                delete_records()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub View_category_Click(sender As Object, e As EventArgs) Handles View_category.Click
        CartegoryRecordForm.DataGridView1.DataSource = Nothing
        CartegoryRecordForm.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        clear()
        CartegoryRecordForm.DataGridView1.DataSource = Nothing
        CartegoryRecordForm.Show()
    End Sub

    Private Sub inveCategoryForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        mainform.Show()
    End Sub
End Class