Imports MySql.Data.MySqlClient

Public Class TeachersTab
    Dim filter As Integer
    Dim adapter As New MySqlDataAdapter
    Dim commnd As New MySqlCommand
    Dim ds As DataSet
    Dim read As MySqlDataReader
    Dim scon As New SQLCn
    Dim names As String

    Private Sub TeachersTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.prof_details_tbl' table. You can move, or remove it, as needed.
        Me.Prof_details_tblTableAdapter.Fill(Me.SlotprofDataSetAll.prof_details_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.room_tbl' table. You can move, or remove it, as needed.

        Me.Prof_details_tblTableAdapter.Fill(Me.SlotprofDataSetAll.prof_details_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSet2.prof_details_tbl' table. You can move, or remove it, as needed.

        GunaAnimate_teachtab.Start()

        Call BindGrid()

        dataShowTeacher.Update()
        dataShowTeacher.Refresh()

    End Sub

    Private Sub AddProfile_disble()
        Dim nf As New addingNew_profile
        With nf
            .Activate()
            .ShowDialog()

            .StartPosition = FormStartPosition.CenterScreen

        End With

    End Sub

    Private Sub Edit_disable()
        Dim nf As New edit_profile
        With nf

            .ShowDialog()
            .StartPosition = FormStartPosition.CenterScreen

        End With

        For Each c As Control In Me.Controls
            c.Enabled = False

        Next
        For Each c As Control In Main_inper.Controls
            c.Enabled = False

        Next
    End Sub






    Private Sub DataShowTeach(sender As Object, e As DataGridViewCellEventArgs) Handles dataShowTeacher.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dataShowTeacher.Rows(e.RowIndex)
            If row.Cells("checkBoxColumn").Selected Then
                addingNew_profile.Enabled = False
                editButton.Enabled = True
                del_btn.Enabled = True
            Else
                addingNew_profile.Enabled = True
                editButton.Enabled = False
                del_btn.Enabled = False
                'Buttons Folling properties

            End If

        End If

    End Sub

    Public Sub BindGrid()

        Dim sql As String = "select * from prof_details_tbl"
        adapter = New MySqlDataAdapter(sql, scon.GetConnection)
        ds = New DataSet

        Try
            scon.OpenConnection()
            adapter.Fill(ds, 0, 25, "IDProf")
            scon.CloseConnection()
            dataShowTeacher.DataSource = ds
            dataShowTeacher.DataMember = "IDProf"
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error")
        Finally
            scon.CloseConnection()
        End Try

    End Sub

    Public Sub DataShow(sender As Object, e As DataGridViewCellEventArgs) Handles dataShowTeacher.CellContentDoubleClick
        Dim selectedrow As Integer = (dataShowTeacher.SelectedRows(0).Cells("IDProf").Value)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dataShowTeacher.Rows(e.RowIndex)

            If row.Cells("checkBoxColumn").Selected Then
                Dim sdn As New SchedulingForm
                Try
                    Dim selt As String = ("select * from prof_details_tbl where ID_Prof='" & selectedrow & "'")
                    commnd = New MySqlCommand(selt, scon.GetConnection)
                    scon.OpenConnection()
                    read = commnd.ExecuteReader
                    While read.Read

                        names = read.GetString("FName_Prof") & " " & read.GetString("LName_Prof")


                        Main_inper.profName_place.Text = names

                    End While
                    read.Close()
                    With Main_inper.Panel2
                        .Show()
                        .BringToFront()
                    End With

                    Main_inper.Panel4.Hide()
                    Me.Hide()
                    sdn.MdiParent = Main_inper
                    sdn.Dock = DockStyle.Fill
                    sdn.Show()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    scon.CloseConnection()
                End Try

            End If
        End If
    End Sub

    Private Sub addProf_Click(sender As Object, e As EventArgs) Handles addProf.Click

        AddProfile_disble()

    End Sub



    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim edit As New edit_profile
        Dim dr As New System.Windows.Forms.DataGridViewRow
        For Each dr In Me.dataShowTeacher.SelectedRows
            edit.name_First2.Text = dr.Cells(2).Value
            edit.name_Last3.Text = dr.Cells(3).Value
            edit.name_MIt.Text = dr.Cells(4).Value

        Next
        Call edit.ShowDialog()
        Call edit.Focus()

    End Sub


    Private Sub del_btn_Click(sender As Object, e As EventArgs) Handles del_btn.Click
        If dataShowTeacher.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            Dim result As MsgBoxResult = MessageBox.Show("Confirmation to Delete", "Do you really want to delete?", MessageBoxButtons.YesNo)
            Dim selectedrow As Integer = (dataShowTeacher.SelectedRows(0).Cells("IDProf").Value)
            If result = MsgBoxResult.No Then
                Exit Sub
            Else
                commnd = New MySqlCommand
                commnd.CommandText = "DELETE FROM schedule_tbl WHERE id_Prof ='" & selectedrow & "'"
                commnd.Connection = scon.GetConnection

                scon.OpenConnection()
                If commnd.ExecuteNonQuery() = 0 Then
                    scon.CloseConnection()

                    commnd = New MySqlCommand("delete from prof_details_tbl where ID_Prof = '" & selectedrow & "'", scon.GetConnection)
                    scon.OpenConnection()
                    If commnd.ExecuteNonQuery = 1 Then
                        dataShowTeacher.Rows.Remove(dataShowTeacher.SelectedRows(0))
                        MsgBox("Record successfully deleted", MsgBoxStyle.Information, "Deleted")
                        scon.OpenConnection()
                    End If
                End If
            End If
        Else
                    MessageBox.Show("Select 1 row before you hit Delete")
                End If


    End Sub


End Class