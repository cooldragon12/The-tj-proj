Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class room_adder

    Dim section As String
    Dim strandName As String

    Dim ds As DataSet
    Dim Filter As Integer

    Dim room_no As String
    Dim scon As New SQLCn
    Dim sda As MySqlDataAdapter
    Dim room As String
    Dim build As String
    Dim desc As String


    Private Sub room_adder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SlotprofDataSetAll1.room_tbl' table. You can move, or remove it, as needed.
        Me.Room_tblTableAdapter.Fill(Me.SlotprofDataSetAll1.room_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.schedule_tbl' table. You can move, or remove it, as needed.
        Me.Schedule_tblTableAdapter.Fill(Me.SlotprofDataSetAll.schedule_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.room_tbl' table. You can move, or remove it, as needed.
        Me.Room_tblTableAdapter.Fill(Me.SlotprofDataSetAll.room_tbl)

        'TODO: This line of code loads data into the 'SlotprofDataSetAll.room_tbl' table. You can move, or remove it, as needed.
        Me.Room_tblTableAdapter.Fill(Me.SlotprofDataSetAll.room_tbl)

    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim read As MySqlDataReader
        room = roomNo.Text
        build = buildi.Text

        Dim cmd1 As New MySqlCommand
        Dim s1 As String
        s1 = "select * from room_tbl where building_no= '" & build & "' and room_no= '" & room & "'"
        If (buildi.Text = "" Or roomNo.Text = "") Then
            MessageBox.Show("Required Infomation", "Input Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        Else
            scon.CloseConnection()
            Try
                scon.OpenConnection()
                cmd1 = New MySqlCommand(s1, scon.GetConnection)
                read = cmd1.ExecuteReader
                If read.HasRows Then
                    MessageBox.Show("The Profile is Existing", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    scon.CloseConnection()
                    read.Close()
                Else
                    scon.CloseConnection()


                    cmd1 = New MySqlCommand("INSERT INTO `room_tbl`(`room_no`, `building_no`) VALUES (@room_n, @build_n)", scon.GetConnection)


                    cmd1.Parameters.Add("@room_n", MySqlDbType.VarChar).Value = room
                    cmd1.Parameters.Add("@build_n", MySqlDbType.VarChar).Value = build



                    scon.OpenConnection()
                    If cmd1.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Successfully Added", "New Room Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        scon.CloseConnection()
                        Call bindtogrid()
                        Call SchedulingForm.Room_drop_LOad()
                    Else
                        MessageBox.Show("Something Wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        scon.CloseConnection()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        bindtogrid()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim str As String
        room = roomNo.Text
        build = buildi.Text
        Dim selectedrow As String = (DataGridRoom.SelectedRows(0).Cells("BuildingnoColumn").Value)
        Dim selectedrow1 As String = (DataGridRoom.SelectedRows(0).Cells("RoomnoColumn").Value)

        Try
            If (MsgBox(“Are you sure you want to delete the item?”, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = “DELETE FROM room_tbl WHERE building_no ='” & selectedrow & "' and room_no ='" & selectedrow1 & "'"
                scon.OpenConnection()
                Dim mysc As New MySqlCommand(str, scon.GetConnection)
                mysc.ExecuteNonQuery()
                MsgBox(“Data Deleted!”, MsgBoxStyle.Information)
                scon.CloseConnection()
            End If
            bindtogrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            scon.CloseConnection()
        End Try
    End Sub



    Private Sub bindtogrid()
        Filter = 0
        Dim sql As String = "select * from room_tbl"
        sda = New MySqlDataAdapter(sql, scon.GetConnection)
        ds = New DataSet

        Try
            scon.OpenConnection()
            sda.Fill(ds, Filter, 25, "BuildingnoColumn")
            scon.CloseConnection()
            DataGridRoom.DataSource = ds
            DataGridRoom.DataMember = "BuildingnoColumn"
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error")
        Finally
            scon.CloseConnection()
        End Try
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim ds As New DataSet
        Dim sqlstr As String
        Dim da As MySqlDataAdapter



        sqlstr = "SELECT * from room_tbl where REGEXP_LIKE(building_no,'" + search.Text + "','i') OR REGEXP_LIKE(room_no,'" + search.Text + "','i')"
        da = New MySqlDataAdapter(sqlstr, scon.GetConnection)
        da.Fill(ds)

        DataGridRoom.DataSource = ds.Tables(0)
        DataGridRoom.Columns(0).HeaderText = "Building No."
        DataGridRoom.Columns(1).HeaderText = "Room No."

        DataGridRoom.ReadOnly = True
    End Sub

    Private Sub DataGridRoom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Process.Start("http://localhost:60870/")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 

    End Sub






End Class
