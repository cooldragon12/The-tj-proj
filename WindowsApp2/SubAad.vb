Imports MySql.Data.MySqlClient
Public Class SecAdd
    Dim scon As New SQLCn
    Dim filter As Integer
    Dim sda As MySqlDataAdapter
    Dim com As MySqlCommand
    Dim ds As DataSet
    Dim read As MySqlDataReader
    Private Sub BindGrid()
        Filter = 0
        Dim sql As String = "select * from sections_tbl"
        sda = New MySqlDataAdapter(sql, scon.GetConnection)
        ds = New DataSet

        Try
            scon.OpenConnection()
            sda.Fill(ds, filter, 25, "StrandName_Column")
            scon.CloseConnection()
            DataGrid_section.DataSource = ds
            DataGrid_section.DataMember = "StrandName_Column"
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error")
        Finally
            scon.CloseConnection()
        End Try

    End Sub
    Private Sub SecAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.sections_tbl' table. You can move, or remove it, as needed.
        Me.Sections_tblTableAdapter.Fill(Me.SlotprofDataSetAll.sections_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.subjects_tbl' table. You can move, or remove it, as needed.
        Me.Subjects_tblTableAdapter.Fill(Me.SlotprofDataSetAll.subjects_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.room_tbl' table. You can move, or remove it, as needed.
        Me.Room_tblTableAdapter.Fill(Me.SlotprofDataSetAll.room_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.sections_tbl' table. You can move, or remove it, as needed.
        Me.Sections_tblTableAdapter.Fill(Me.SlotprofDataSetAll.sections_tbl)

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim insertquery As String = "insert into slotprof.sections_tbl(`strandName`,`grade_lvl`,`sections_no`) values(@sn,@gl,@sc)"
        'Dim check As String = "select * from sections_tbl where strandName='" & track_to.Text & "' and grade_lvl='" & grde_level.Text & "'"

        If check_null() = True Then
            MessageBox.Show("Incomplete, Please fill the Fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Try
                'scon.OpenConnection()
                'com = New MySqlCommand(check, scon.GetConnection)
                'read = com.ExecuteReader
                'If read.HasRows Then
                '    MessageBox.Show("The Profile is Existing", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    scon.CloseConnection()
                '    read.Close()


                com = New MySqlCommand(insertquery, scon.GetConnection)
                    com.Parameters.Add("@sn", MySqlDbType.VarChar).Value = track_to.Text
                    com.Parameters.Add("@gl", MySqlDbType.VarChar).Value = grde_level.Text
                    com.Parameters.Add("@sc", MySqlDbType.VarChar).Value = sec_no.Text


                    scon.OpenConnection()

                    If com.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Profile has been Successfully Added", "Profile Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        scon.CloseConnection()
                    Call SchedulingForm.Sec_drop_LOad()
                    Call BindGrid()
                    Else
                        MessageBox.Show("Something Wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        scon.CloseConnection()
                    End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If



    End Sub

    Private Function check_null() As Boolean
        If String.IsNullOrEmpty(track_to.Text) = True Or String.IsNullOrEmpty(sec_no.Text) Or String.IsNullOrEmpty(grde_level.Text) Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGrid_section.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            Dim result As MsgBoxResult = MessageBox.Show("Confirmation to Delete", "Do you really want to delete?", MessageBoxButtons.YesNo)
            Dim selectedrow1 As String = (DataGrid_section.SelectedRows(0).Cells("StrandName").Value)
            Dim selectedrow2 As String = (DataGrid_section.SelectedRows(0).Cells("Gradelvl").Value)
            Dim selectedrow3 As String = (DataGrid_section.SelectedRows(0).Cells("Sectionsno").Value)
            If result = MsgBoxResult.No Then
                Exit Sub
            Else
                com = New MySqlCommand
                com.CommandText = "DELETE FROM sections_tbl WHERE strandName ='" & selectedrow1 & "' and grade_lvl='" & selectedrow2 & "' and sections_no='" & selectedrow3 & "'"
                com.Connection = scon.GetConnection

                scon.OpenConnection()
                com.ExecuteNonQuery()
                DataGrid_section.Rows.Remove(DataGrid_section.SelectedRows(0))
                MsgBox("Record successfully deleted", MsgBoxStyle.Information, "Deleted")
                scon.CloseConnection()
            End If


        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        btn_add.Enabled = False
        info_group.Enabled = True
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGrid_section.Rows(e.RowIndex)

            If row.Cells("checkBoxColumn").Selected = True Then
                info_group.Enabled = False

                btn_add.Enabled = False
                btnDelete.Enabled = True

            Else
                btnDelete.Enabled = False


            End If

        End If


    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim ds As New DataSet
        Dim sqlstr As String
        Dim da As MySqlDataAdapter



        sqlstr = "SELECT * from sections_tbl WHERE strandName LIKE '%" & search.Text & "%' or sections_no LIKE '%" & search.Text & "' or grade_lvl LIKE '%" & search.Text & "'"

        'sqlstr = "Select * from sections_tbl WHERE strandName='" + search.Text + "'OR sections_no='" + search.Text + "' or grade_lvl='" + search.Text + "'"
        da = New MySqlDataAdapter(sqlstr, scon.GetConnection)
        da.Fill(ds)

        DataGrid_section.DataSource = ds.Tables(0)
        DataGrid_section.Columns(0).HeaderText = "Track"
        DataGrid_section.Columns(1).HeaderText = "Grade Level"
        DataGrid_section.ReadOnly = True
    End Sub


    Private Sub track_to_KeyPress(sender As Object, e As KeyPressEventArgs) Handles track_to.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("Only Letter are Allowed!", "Invalid Letter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class