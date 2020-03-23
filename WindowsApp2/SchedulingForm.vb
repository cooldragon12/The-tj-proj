Imports MySql.Data.MySqlClient

Public Class SchedulingForm
    Dim com As New MySqlCommand

    Dim read As MySqlDataReader
    Dim room_d As String
    Dim build_d As String
    Dim sec As String
    Dim cmd As MySqlCommand
    Dim scon As New SQLCn
    Dim query As String


    Private Sub SchedulingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.prof_details_tbl' table. You can move, or remove it, as needed.
        Me.Prof_details_tblTableAdapter.Fill(Me.SlotprofDataSetAll.prof_details_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.sections_tbl' table. You can move, or remove it, as needed.
        Me.Sections_tblTableAdapter.Fill(Me.SlotprofDataSetAll.sections_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.schedule_tbl' table. You can move, or remove it, as needed.5
        Me.Room_tblTableAdapter.Fill(Me.SlotprofDataSetAll.room_tbl)
        'TODO: This line of code loads data into the 'SlotprofDataSetAll.subjects_tbl' table. You can move, or remove it, as needed.
        Me.Subjects_tblTableAdapter.Fill(Me.SlotprofDataSetAll.subjects_tbl)

        'Load Items In Drop Box
        Call Room_drop_LOad()
        Call Sec_drop_LOad()
        '_____________________
        'CheckandLoad()
        'InitAppointments()
        Call Selectionsect_load()
        Call insert_day_time()
        Dim sd As String = section_dropdonw.Text
        Call Loaoded()

        Call disable_to()

    End Sub
    Dim selectid As String = TeachersTab.dataShowTeacher.SelectedRows(0).Cells("IDProf").Value
    'loading items
    Private Sub insert_day_time()
        If day_combo.Items.Contains("Monday") Then
            'nothing
        Else
            day_combo.Items.Add("Monday")
        End If
        If day_combo.Items.Contains("Tuesday") Then
            'nothing
        Else
            day_combo.Items.Add("Tuesday")
        End If
        If day_combo.Items.Contains("Wednesday") Then
            'nothing
        Else

            day_combo.Items.Add("Wednesday")
        End If
        If day_combo.Items.Contains("Thursday") Then
            'nothing
        Else
            day_combo.Items.Add("Thursday")
        End If
        If day_combo.Items.Contains("Friday") Then
            'nohting
        Else
            day_combo.Items.Add("Friday")
        End If

        If time_combo.Items.Contains("6:00 AM") Then
        Else
            time_combo.Items.Add("6:00 AM")
        End If
        If time_combo.Items.Contains("6:30 AM") Then
        Else
            time_combo.Items.Add("6:30 AM")
        End If
        If time_combo.Items.Contains("7:00 AM") Then

        Else
            time_combo.Items.Add("7:00 AM")
        End If
        If time_combo.Items.Contains("7:30 AM") Then
        Else
            time_combo.Items.Add("7:30 AM")
        End If
        If time_combo.Items.Contains("8:00 AM") Then
        Else
            time_combo.Items.Add("8:00 AM")
        End If
        If time_combo.Items.Contains("8:30 AM") Then
        Else
            time_combo.Items.Add("8:30 AM")
        End If

        If time_combo.Items.Contains("8:30 AM") Then
        Else
            time_combo.Items.Add("8:30 AM")
        End If
        If time_combo.Items.Contains("9:00 AM") Then
        Else
            time_combo.Items.Add("9:00 AM")
        End If
        If time_combo.Items.Contains("9:30 AM") Then
        Else
            time_combo.Items.Add("9:30 AM")
        End If
        If time_combo.Items.Contains("10:00 AM") Then
        Else
            time_combo.Items.Add("10:00 AM")
        End If
        If time_combo.Items.Contains("10:30 AM") Then
        Else
            time_combo.Items.Add("10:30 AM")
        End If
        If time_combo.Items.Contains("11:00 AM") Then
        Else
            time_combo.Items.Add("11:00 AM")
        End If
        If time_combo.Items.Contains("11:30 AM") Then
        Else
            time_combo.Items.Add("11:30 AM")
        End If
        If time_combo.Items.Contains("12:00 PM") Then
        Else
            time_combo.Items.Add("12:00 PM")
        End If
        If time_combo.Items.Contains("12:30 PM") Then
        Else
            time_combo.Items.Add("12:30 PM")
        End If
        If time_combo.Items.Contains("1:00 PM") Then
        Else
            time_combo.Items.Add("1:00 PM")
        End If
        If time_combo.Items.Contains("1:30 PM") Then
        Else
            time_combo.Items.Add("1:30 PM")
        End If
        If time_combo.Items.Contains("2:00 PM") Then
        Else
            time_combo.Items.Add("2:00 PM")
        End If
        If time_combo.Items.Contains("2:30 PM") Then
        Else
            time_combo.Items.Add("2:30 PM")
        End If
        If time_combo.Items.Contains("3:00 PM") Then
        Else
            time_combo.Items.Add("3:00 PM")
        End If
        If time_combo.Items.Contains("3:30 PM") Then
        Else
            time_combo.Items.Add("3:30 PM")
        End If
    End Sub

    Private Sub Clearer()
        time_combo.Text = " "
        time_end_combo.Text = " "
        room_dropdown.Text = " "
        build_dropbox.Text = " "
        section_dropdonw.Text = " "
        gradLvel_drop.Text = " "
        Track_dropdown.Text = " "
        subject_cmbo.Text = " "
        day_combo.Text = " "
    End Sub
    '=========================================================================

    'buttonn addddd
    Private Sub add_dragItemBttn_Click(ByVal s As Object, ByVal e As EventArgs) Handles add_dragItemBttn.Click
        Dim choosen_day As String
        Dim choosen_time As String
        Dim choosen_end_time As String



        If day_combo.Text = "Monday" Then
            choosen_day = "2020-02-10"
            '"02/10/2020"
            '2020-02-10
        ElseIf day_combo.Text = "Tuesday" Then
            choosen_day = "2020-02-11"
            '"02/11/2020"
            '2020-02-11
        ElseIf day_combo.Text = "Wednesday" Then
            choosen_day = "2020-02-12"
            '"02/11/2020"
            '2020-02-12
        ElseIf day_combo.Text = "Thursday" Then
            choosen_day = "2020-02-13"
            '"02/11/2020"
            '2020-02-13
        ElseIf day_combo.Text = "Friday" Then
            choosen_day = "2020-02-14"
            '"02/11/2020"
            '2020-02-14
        End If

        If time_combo.Text = "6:00 AM" Then
            choosen_time = "06:00:00"
        ElseIf time_combo.Text = "6:30 AM" Then
            choosen_time = "06:30:00"
        ElseIf time_combo.Text = "7:00 AM" Then
            choosen_time = "07:00:00"
        ElseIf time_combo.Text = "7:30 AM" Then
            choosen_time = "07:30:00"
        ElseIf time_combo.Text = "8:00 AM" Then
            choosen_time = "08:00:00"
        ElseIf time_combo.Text = "8:30 AM" Then
            choosen_time = "08:30:00"
        ElseIf time_combo.Text = "9:00 AM" Then
            choosen_time = "09:00:00"
        ElseIf time_combo.Text = "9:30 AM" Then
            choosen_time = "09:30:00"
        ElseIf time_combo.Text = "10:00 AM" Then
            choosen_time = "10:00:00"
        ElseIf time_combo.Text = "10:30 AM" Then
            choosen_time = "10:30:00"
        ElseIf time_combo.Text = "11:00 AM" Then
            choosen_time = "11:00:00"
        ElseIf time_combo.Text = "12:30 AM" Then
            choosen_time = "12:30:00"
        ElseIf time_combo.Text = "12:00 PM" Then
            choosen_time = "12:00:00"
        ElseIf time_combo.Text = "12:30 PM" Then
            choosen_time = "12:30:00"
        ElseIf time_combo.Text = "1:00 PM" Then
            choosen_time = "13:00:00"
        ElseIf time_combo.Text = "1:30 PM" Then
            choosen_time = "13:30:00"
        ElseIf time_combo.Text = "2:00 PM" Then
            choosen_time = "14:00:00"
        ElseIf time_combo.Text = "2:30 PM" Then
            choosen_time = "14:30:00"
        ElseIf time_combo.Text = "3:00 PM" Then
            choosen_time = "15:00:00"
        ElseIf time_combo.Text = "3:30 PM" Then
            choosen_time = "15:30:00"
        End If

        If time_end_combo.Text = "7:00 AM" Then
            choosen_end_time = "07:00:00"
        ElseIf time_end_combo.Text = "7:30 AM" Then
            choosen_end_time = "07:30:00"
        ElseIf time_end_combo.Text = "8:00 AM" Then
            choosen_end_time = "08:00:00"
        ElseIf time_end_combo.Text = "8:30 AM" Then
            choosen_end_time = "08:30:00"
        ElseIf time_end_combo.Text = "9:00 AM" Then
            choosen_end_time = "09:00:00"
        ElseIf time_end_combo.Text = "9:30 AM" Then
            choosen_end_time = "09:30:00"
        ElseIf time_end_combo.Text = "10:00 AM" Then
            choosen_end_time = "10:00:00"
        ElseIf time_end_combo.Text = "10:30 AM" Then
            choosen_end_time = "10:30:00"
        ElseIf time_end_combo.Text = "11:00 AM" Then
            choosen_end_time = "11:00:00"
        ElseIf time_end_combo.Text = "11:30 AM" Then
            choosen_end_time = "11:30:00"
        ElseIf time_end_combo.Text = "12:00 PM" Then
            choosen_end_time = "12:00:00"
        ElseIf time_end_combo.Text = "12:30 PM" Then
            choosen_end_time = "12:30:00"
        ElseIf time_end_combo.Text = "1:00 PM" Then
            choosen_end_time = "13:00:00"
        ElseIf time_end_combo.Text = "1:30 PM" Then
            choosen_end_time = "13:30:00"
        ElseIf time_end_combo.Text = "2:00 PM" Then
            choosen_end_time = "14:00:00"
        ElseIf time_end_combo.Text = "2:30 PM" Then
            choosen_end_time = "14:30:00"
        ElseIf time_end_combo.Text = "3:00 PM" Then
            choosen_end_time = "15:00:00"
        ElseIf time_end_combo.Text = "3:30 PM" Then
            choosen_end_time = "15:30:00"
        ElseIf time_end_combo.Text = "4:00 PM" Then
            choosen_end_time = "16:00:00"
        ElseIf time_end_combo.Text = "4:30 PM" Then
            choosen_end_time = "16:30:00"
        ElseIf time_end_combo.Text = "5:00 PM" Then
            choosen_end_time = "17:00:00"
        ElseIf time_end_combo.Text = "5:30 PM" Then
            choosen_end_time = "17:30:00"

        End If

        scon.CloseConnection()


        Dim final_end As String = choosen_day + " " + choosen_end_time

        Dim final_time_day As String = choosen_day + " " + choosen_time
        Dim d As DateTime = DateTime.Parse(final_end)
        Dim f As DateTime = DateTime.Parse(final_time_day)
        Static insertlimit As Integer



        query = "select * from schedule_tbl where time_start='" + final_time_day + "' and time_end='" + final_end + "' and building_no='" + build_dropbox.Text + "' and room_no='" + room_dropdown.Text + "' and sy='" + SelectSt.schedsy_combo.Text + "' and semestral_sche='" + SelectSt.semester_combo.Text + "'"
        Dim checkccount As String = "select count(id_Prof) as 'che' from schedule_tbl where id_Prof='" + selectid + "' and semestral_sche ='" + SelectSt.semester_combo.text + "' and sy='" + SelectSt.schedsy_combo.text + "'"
        scon.OpenConnection()
        cmd = New MySqlCommand(query, scon.GetConnection)

        read = cmd.ExecuteReader


        Try
            If read.HasRows Then
                MsgBox("The room already occupied")
                Exit Sub

            Else
                read.Close()
                scon.CloseConnection()
                scon.OpenConnection()
                'check already have local
                Dim ithas As String = "Select * From schedule_tbl Where time_start ='" + final_time_day + "' and time_end='" + final_end + "' and id_Prof='" + selectid + "' and semestral_sche = '" + SelectSt.semester_combo.Text + "' and sy='" + SelectSt.schedsy_combo.Text + "'"
                Dim lcmd As New MySqlCommand(ithas, scon.GetConnection)
                Dim readif As MySqlDataReader = lcmd.ExecuteReader
                'check room and time check global
                readif.Read()


                Dim hourwith0() As String = {"14:00:00", "15:00:00", "13:00:00", "12:00:00", "11:00:00", "09:00:00", "10:00:00", "08:00:00", "07:00:00", "6:00:00"}
                Dim hourwith30() As String = {"14:30:00", "15:30:00", "13:30:00", "12:30:00", "11:30:00", "09:30:00", "10:30:00", "08:30:00", "07:30:00", "6:30:00"}

                If readif.HasRows Then
                    MsgBox("The time already occupied")
                    Exit Sub

                ElseIf build_dropbox.Text = "" Or Track_dropdown.Text = "" Or time_combo.Text = "" Or time_end_combo.Text = "" Or day_combo.Text = "" Then
                    MsgBox("Fill the Fields")
                    readif.Close()
                Else

                    readif.Close()
                    scon.CloseConnection()

                    cmd = New MySqlCommand(checkccount, scon.GetConnection)
                    scon.OpenConnection()
                    Dim rread As MySqlDataReader = cmd.ExecuteReader()

                    rread.Read()

                    insertlimit = rread.Item("che")
                    If insertlimit >= 6 Then
                        MsgBox("You exceeded to recommended/required number of schedules. 
                           Only Allows maximum 6 schedule")

                        rread.Close()
                    Else

                        Try
                            rread.Close()
                            scon.CloseConnection()
                            Dim sa As String = subject_cmbo.SelectedValue
                            query = "insert into schedule_tbl(`id_Prof`, subject, time_start, time_end, semestral_sche,sy, strandname, grade_lvl, section_no, building_no,room_no) values('" + selectid + "','" + sa + "', @ft , @et, '" + SelectSt.semester_combo.Text + "', '" + SelectSt.schedsy_combo.Text + "', '" + Track_dropdown.Text + "', '" + gradLvel_drop.Text + "', '" + section_dropdonw.Text + "', '" + build_dropbox.Text + "', '" + room_dropdown.Text + "')"


                            scon.OpenConnection()
                            cmd = New MySqlCommand(query, scon.GetConnection)
                            cmd.Parameters.Add("@ft", MySqlDbType.DateTime).Value = final_time_day
                            cmd.Parameters.Add("@et", MySqlDbType.DateTime).Value = final_end


                            If cmd.ExecuteNonQuery = 1 Then
                                scon.CloseConnection()
                                Call Loaoded()
                                Call Clearer()
                                Call insert_day_time()

                                MsgBox("Successfully Added")


                            End If

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Loaoded()
        read.Close()
        scon.CloseConnection()
        query = "select subjects_tbl.subject_Name, schedule_tbl.scheid, id_Prof, subject, time_start
                    , time_end, semestral_sche, sy, strandname, grade_lvl, section_no, building_no, room_no from subjects_tbl inner join schedule_tbl on subjects_tbl.snn = schedule_tbl.subject where schedule_tbl.id_Prof='" + selectid + "' and schedule_tbl.sy='" + SelectSt.schedsy_combo.Text + "' and schedule_tbl.semestral_sche='" + SelectSt.semester_combo.Text + "'"
        cmd = New MySqlCommand(query, scon.GetConnection)
        scon.OpenConnection()
        read = cmd.ExecuteReader

        While read.Read
            Dim label As String = read.GetString("subject_Name")
            Dim label2 As String = read.GetString("strandname") + " " + read.GetString("grade_lvl") + " " + read.GetString("section_no")
            Dim label3 As String = read.GetString("building_no") + " " + read.GetString("room_no")

            'Monday start
            If read.GetDateTime("time_start") = "2020-02-10 06:00:00" Then
                monday_630.BackColor = color.lightyellow
                lbl_Monday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 07:00:00" Then
                    monday_700.BackColor = color.lightyellow
                    lbl_Monday_700.Text = label2
                ElseIf read.GetDateTime("time_end") = "2020-02-10 08:00:00" Then
                    monday_700.BackColor = color.lightyellow
                    monday_730.BackColor = color.lightyellow
                    monday_800.BackColor = color.lightyellow
                    lbl_Monday_700.Text = label2
                    lbl_Monday_730.Text = label3
                    lbl_Monday_800.Text = ""

                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 06:30:00" Then
                monday_630.BackColor = Color.Orange
                lbl_Monday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 07:30:00" Then
                    monday_700.BackColor = Color.Orange
                    monday_730.BackColor = Color.Orange
                    lbl_Monday_700.Text = label2
                    lbl_Monday_730.Text = label3
                ElseIf read.GetDateTime("time_end") = "2020-02-10 08:30:00" Then
                    monday_700.BackColor = Color.Orange
                    monday_730.BackColor = Color.Orange
                    monday_800.BackColor = Color.Orange
                    monday_830.BackColor = Color.Orange
                    lbl_Monday_700.Text = label2
                    lbl_Monday_730.Text = label3

                    lbl_Monday_800.Text = ""
                    lbl_Monday_830.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 07:00:00" Then
                monday_730.BackColor = Color.Orange
                label = lbl_Monday_730.Text
                If read.GetDateTime("time_end") = "2020-02-10 08:00:00" Then
                    lbl_Monday_800.Text = label2
                    monday_800.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 09:00:00" Then
                    monday_800.BackColor = Color.Orange
                    lbl_Monday_800.Text = label2
                    monday_830.BackColor = Color.Orange
                    lbl_Monday_830.Text = label3
                    monday_900.BackColor = Color.Orange
                    lbl_Monday_830.Text = ""
                End If
            End If


            If read.GetDateTime("time_start") = "2020-02-10 07:30:00" Then
                monday_800.BackColor = Color.Orange
                label = lbl_Monday_800.Text
                If read.GetDateTime("time_end") = "2020-02-10 08:30:00" Then

                    label2 = lbl_Monday_830.Text
                    monday_830.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 09:30:00" Then
                    monday_830.BackColor = Color.Orange
                    monday_900.BackColor = Color.Orange
                    monday_930.BackColor = Color.Orange
                    label2 = lbl_Monday_830.Text
                    label3 = lbl_Monday_900.Text
                    lbl_Monday_930.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 08:00:00" Then
                monday_830.BackColor = Color.Orange
                lbl_Monday_830.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 09:00:00" Then
                    lbl_Monday_900.Text = label2
                    monday_900.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 10:00:00" Then
                    monday_900.BackColor = Color.Orange
                    lbl_Monday_900.Text = label2
                    monday_930.BackColor = Color.Orange
                    lbl_Monday_930.Text = label3
                    monday_1000.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 08:30:00" Then
                monday_900.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-10 09:30:00" Then

                    monday_930.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 10:30:00" Then
                    monday_930.BackColor = Color.Orange
                    monday_1000.BackColor = Color.Orange
                    monday_1030.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 09:00:00" Then
                monday_930.BackColor = Color.Orange
                lbl_Monday_930.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 10:00:00" Then
                    lbl_Monday_1000.Text = label2
                    monday_1000.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 11:00:00" Then
                    lbl_Monday_1000.Text = label2
                    monday_1000.BackColor = Color.Orange
                    lbl_Monday_1030.Text = label3
                    monday_1030.BackColor = Color.Orange
                    monday_1100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 09:30:00" Then
                monday_1000.BackColor = Color.Orange
                lbl_Monday_1000.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 10:30:00" Then

                    monday_1030.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 11:30:00" Then

                    lbl_Monday_1100.Text = label2
                    lbl_Monday_1130.Text = label3
                    monday_1030.BackColor = Color.Orange
                    monday_1100.BackColor = Color.Orange
                    monday_1130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 10:00:00" Then
                monday_1030.BackColor = Color.Orange
                lbl_Monday_1030.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 11:00:00" Then

                    monday_1100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 12:00:00" Then

                    lbl_Monday_1130.Text = label2
                    lbl_Monday_1200.Text = label3
                    monday_1100.BackColor = Color.Orange
                    monday_1130.BackColor = Color.Orange
                    monday_1200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 10:30:00" Then
                monday_1100.BackColor = Color.Orange
                lbl_Monday_1100.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 11:30:00" Then

                    monday_1130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 12:30:00" Then
                    lbl_Monday_1130.Text = ""
                    lbl_Monday_1200.Text = label2
                    lbl_Monday_1230.Text = label3
                    monday_1130.BackColor = Color.Orange
                    monday_1200.BackColor = Color.Orange
                    monday_1230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 11:00:00" Then
                monday_1130.BackColor = Color.Orange
                lbl_Monday_1130.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 12:00:00" Then

                    monday_1200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 13:00:00" Then


                    lbl_Monday_1230.Text = label2
                    lbl_Monday_1100.Text = label3
                    monday_1200.BackColor = Color.Orange
                    monday_1230.BackColor = Color.Orange
                    monday_100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 11:30:00" Then
                monday_1200.BackColor = Color.Orange
                lbl_Monday_1200.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 12:30:00" Then
                    lbl_Monday_1230.Text = label2
                    monday_1230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 13:30:00" Then

                    lbl_Monday_1230.Text = label2
                    monday_1230.BackColor = Color.Orange
                    lbl_Monday_100.Text = label3
                    monday_100.BackColor = Color.Orange
                    monday_130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 12:00:00" Then
                monday_1230.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-10 13:00:00" Then
                    lbl_Monday_100.Text = label2
                    monday_100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 14:00:00" Then
                    lbl_Monday_100.Text = label2
                    lbl_Monday_130.Text = label3
                    monday_100.BackColor = Color.Orange
                    monday_130.BackColor = Color.Orange
                    monday_200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 12:30:00" Then
                monday_100.BackColor = Color.Orange
                lbl_Monday_100.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 13:30:00" Then
                    lbl_Monday_130.Text = label2
                    monday_130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 14:30:00" Then
                    lbl_Monday_130.Text = label2
                    lbl_Monday_200.Text = label3
                    monday_130.BackColor = Color.Orange
                    monday_200.BackColor = Color.Orange
                    monday_230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 13:00:00" Then
                monday_130.BackColor = Color.Orange
                lbl_Monday_130.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 14:00:00" Then
                    lbl_Monday_200.Text = label2
                    monday_200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 15:00:00" Then
                    lbl_Monday_200.Text = label2
                    lbl_Monday_230.Text = label3
                    monday_200.BackColor = Color.Orange
                    monday_230.BackColor = Color.Orange
                    monday_300.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 13:30:00" Then
                monday_200.BackColor = Color.Orange
                lbl_Monday_200.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 14:30:00" Then
                    lbl_Monday_230.Text = label2
                    monday_230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 15:30:00" Then

                    lbl_Monday_230.Text = label2
                    lbl_Monday_300.Text = label3
                    monday_300.BackColor = Color.Orange
                    monday_230.BackColor = Color.Orange
                    monday_330.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 14:00:00" Then
                monday_230.BackColor = Color.Orange
                lbl_Monday_230.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 15:00:00" Then
                    lbl_Monday_300.Text = label2
                    monday_300.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 16:00:00" Then
                    lbl_Monday_300.Text = label2
                    lbl_Monday_330.Text = label3
                    monday_300.BackColor = Color.Orange
                    monday_330.BackColor = Color.Orange
                    monday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 14:30:00" Then
                monday_300.BackColor = Color.Orange
                lbl_Monday_300.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 15:30:00" Then
                    lbl_Monday_330.Text = label2
                    monday_330.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 16:30:00" Then
                    lbl_Monday_330.Text = label2
                    lbl_Monday_400.Text = label3

                    monday_430.BackColor = Color.Orange
                    monday_330.BackColor = Color.Orange
                    monday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 15:00:00" Then
                monday_330.BackColor = Color.Orange
                lbl_Monday_330.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 16:00:00" Then
                    lbl_Monday_400.Text = label2
                    monday_400.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 17:00:00" Then

                    lbl_Monday_400.Text = label2
                    lbl_Monday_430.Text = label3
                    monday_430.BackColor = Color.Orange
                    monday_500.BackColor = Color.Orange
                    monday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 15:30:00" Then
                monday_400.BackColor = Color.Orange
                lbl_Monday_400.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 16:30:00" Then
                    lbl_Monday_430.Text = label2
                    monday_430.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 17:30:00" Then
                    lbl_Monday_430.Text = label2
                    lbl_Monday_500.Text = label3
                    monday_430.BackColor = Color.Orange
                    monday_500.BackColor = Color.Orange
                    monday_530.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-10 16:00:00" Then
                monday_430.BackColor = Color.Orange
                lbl_Monday_430.Text = label
                If read.GetDateTime("time_end") = "2020-02-10 17:00:00" Then
                    lbl_Monday_500.Text = label2
                    monday_500.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-10 18:00:00" Then
                    lbl_Monday_500.Text = label2
                    lbl_Monday_530.Text = label3
                    monday_600PM.BackColor = Color.Orange
                    monday_500.BackColor = Color.Orange
                    monday_530.BackColor = Color.Orange
                End If
            End If


            'tuesday start-----------------------------------------------


            If read.GetDateTime("time_start") = "2020-02-11 06:00:00" Then
                tuesday_630AM.BackColor = color.lightyellow
                lbl_Tuesday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 07:00:00" Then
                    tuesday_700.BackColor = color.lightyellow
                    lbl_Tuesday_700.Text = label2
                ElseIf read.GetDateTime("time_end") = "2020-02-11 08:00:00" Then
                    tuesday_700.BackColor = color.lightyellow
                    tuesday_730.BackColor = color.lightyellow
                    tuesday_800.BackColor = color.lightyellow
                    lbl_Tuesday_700.Text = label2
                    lbl_Tuesday_730.Text = label3
                    lbl_Tuesday_800.Text = ""

                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 06:30:00" Then
                tuesday_630AM.BackColor = Color.Orange
                lbl_Tuesday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 07:30:00" Then
                    tuesday_700.BackColor = Color.Orange
                    tuesday_730.BackColor = Color.Orange
                    lbl_Tuesday_700.Text = label2
                    lbl_Tuesday_730.Text = label3
                ElseIf read.GetDateTime("time_end") = "2020-02-11 08:30:00" Then
                    tuesday_700.BackColor = Color.Orange
                    tuesday_730.BackColor = Color.Orange
                    tuesday_800.BackColor = Color.Orange
                    tuesday_830.BackColor = Color.Orange
                    lbl_Tuesday_700.Text = label2
                    lbl_Tuesday_730.Text = label3

                    lbl_Tuesday_800.Text = ""
                    lbl_Tuesday_830.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 07:00:00" Then
                tuesday_730.BackColor = Color.Orange
                label = lbl_Tuesday_730.Text
                If read.GetDateTime("time_end") = "2020-02-11 08:00:00" Then
                    lbl_Tuesday_800.Text = label2
                    tuesday_800.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 09:00:00" Then
                    tuesday_800.BackColor = Color.Orange
                    lbl_Tuesday_800.Text = label2
                    tuesday_830.BackColor = Color.Orange
                    lbl_Tuesday_830.Text = label3
                    tuesday_900.BackColor = Color.Orange
                    lbl_Tuesday_830.Text = ""
                End If
            End If


            If read.GetDateTime("time_start") = "2020-02-11 07:30:00" Then
                tuesday_800.BackColor = Color.Orange
                label = lbl_Tuesday_800.Text
                If read.GetDateTime("time_end") = "2020-02-11 08:30:00" Then

                    label2 = lbl_Tuesday_830.Text
                    tuesday_830.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 09:30:00" Then
                    tuesday_830.BackColor = Color.Orange
                    tuesday_900.BackColor = Color.Orange
                    tuesday_930.BackColor = Color.Orange
                    label2 = lbl_Tuesday_830.Text
                    label3 = lbl_Tuesday_900.Text
                    lbl_Tuesday_930.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 08:00:00" Then
                tuesday_830.BackColor = Color.Orange
                lbl_Tuesday_830.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 09:00:00" Then
                    lbl_Tuesday_900.Text = label2
                    tuesday_900.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 10:00:00" Then
                    tuesday_900.BackColor = Color.Orange
                    lbl_Tuesday_900.Text = label2
                    tuesday_930.BackColor = Color.Orange
                    lbl_Tuesday_930.Text = label3
                    tuesday_1000.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 08:30:00" Then
                tuesday_900.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-11 09:30:00" Then

                    tuesday_930.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 10:30:00" Then
                    tuesday_930.BackColor = Color.Orange
                    tuesday_1000.BackColor = Color.Orange
                    tueasday_1030.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 09:00:00" Then
                tuesday_930.BackColor = Color.Orange
                lbl_Tuesday_930.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 10:00:00" Then
                    lbl_Tuesday_1000.Text = label2
                    tuesday_1000.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 11:00:00" Then
                    lbl_Tuesday_1000.Text = label2
                    tuesday_1000.BackColor = Color.Orange
                    lbl_Tuesday_1030.Text = label3
                    tueasday_1030.BackColor = Color.Orange
                    tuesday_1100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 09:30:00" Then
                tuesday_1000.BackColor = Color.Orange
                lbl_Tuesday_1000.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 10:30:00" Then

                    tueasday_1030.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 11:30:00" Then

                    lbl_Tuesday_1100.Text = label2
                    lbl_Tuesday_1130.Text = label3
                    tueasday_1030.BackColor = Color.Orange
                    tuesday_1100.BackColor = Color.Orange
                    tuesday_1130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 10:00:00" Then
                tueasday_1030.BackColor = Color.Orange
                lbl_Tuesday_1030.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 11:00:00" Then

                    tuesday_1100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 12:00:00" Then

                    lbl_Tuesday_1130.Text = label2
                    lbl_Tuesday_1200.Text = label3
                    tuesday_1100.BackColor = Color.Orange
                    tuesday_1130.BackColor = Color.Orange
                    tuesday_1200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 10:30:00" Then
                tuesday_1100.BackColor = Color.Orange
                lbl_Tuesday_1100.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 11:30:00" Then

                    tuesday_1130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 12:30:00" Then
                    lbl_Tuesday_1130.Text = ""
                    lbl_Tuesday_1200.Text = label2
                    lbl_Tuesday_1230.Text = label3
                    tuesday_1130.BackColor = Color.Orange
                    tuesday_1200.BackColor = Color.Orange
                    tuesday_1230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 11:00:00" Then
                tuesday_1130.BackColor = Color.Orange
                lbl_Tuesday_1130.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 12:00:00" Then

                    tuesday_1200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 13:00:00" Then


                    lbl_Tuesday_1230.Text = label2
                    lbl_Tuesday_1100.Text = label3
                    tuesday_1200.BackColor = Color.Orange
                    tuesday_1230.BackColor = Color.Orange
                    tuesday_100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 11:30:00" Then
                tuesday_1200.BackColor = Color.Orange
                lbl_Tuesday_1200.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 12:30:00" Then
                    lbl_Tuesday_1230.Text = label2
                    tuesday_1230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 13:30:00" Then

                    lbl_Tuesday_1230.Text = label2
                    tuesday_1230.BackColor = Color.Orange
                    lbl_Tuesday_100.Text = label3
                    tuesday_100.BackColor = Color.Orange
                    tuesday_130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 12:00:00" Then
                tuesday_1230.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-11 13:00:00" Then
                    lbl_Tuesday_100.Text = label2
                    tuesday_100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 14:00:00" Then
                    lbl_Tuesday_100.Text = label2
                    lbl_Tuesday_130.Text = label3
                    tuesday_100.BackColor = Color.Orange
                    tuesday_130.BackColor = Color.Orange
                    tuesday_200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 12:30:00" Then
                tuesday_100.BackColor = Color.Orange
                lbl_Tuesday_100.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 13:30:00" Then
                    lbl_Tuesday_130.Text = label2
                    tuesday_130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 14:30:00" Then
                    lbl_Tuesday_130.Text = label2
                    lbl_Tuesday_200.Text = label3
                    tuesday_130.BackColor = Color.Orange
                    tuesday_200.BackColor = Color.Orange
                    tuesday_230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 13:00:00" Then
                tuesday_130.BackColor = Color.Orange
                lbl_Tuesday_130.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 14:00:00" Then
                    lbl_Tuesday_200.Text = label2
                    tuesday_200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 15:00:00" Then
                    lbl_Tuesday_200.Text = label2
                    lbl_Tuesday_230.Text = label3
                    tuesday_200.BackColor = Color.Orange
                    tuesday_230.BackColor = Color.Orange
                    tuesday_300.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 13:30:00" Then
                tuesday_200.BackColor = Color.Orange
                lbl_Tuesday_200.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 14:30:00" Then
                    lbl_Tuesday_230.Text = label2
                    tuesday_230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 15:30:00" Then

                    lbl_Tuesday_230.Text = label2
                    lbl_Tuesday_300.Text = label3
                    tuesday_300.BackColor = Color.Orange
                    tuesday_230.BackColor = Color.Orange
                    tuesday_330.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 14:00:00" Then
                tuesday_230.BackColor = Color.Orange
                lbl_Tuesday_230.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 15:00:00" Then
                    lbl_Tuesday_300.Text = label2
                    tuesday_300.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 16:00:00" Then
                    lbl_Tuesday_300.Text = label2
                    lbl_Tuesday_330.Text = label3
                    tuesday_300.BackColor = Color.Orange
                    tuesday_330.BackColor = Color.Orange
                    tuesday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 14:30:00" Then
                tuesday_300.BackColor = Color.Orange
                lbl_Tuesday_300.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 15:30:00" Then
                    lbl_Tuesday_330.Text = label2
                    tuesday_330.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 16:30:00" Then
                    lbl_Tuesday_330.Text = label2
                    lbl_Tuesday_400.Text = label3

                    tuesday_430.BackColor = Color.Orange
                    tuesday_330.BackColor = Color.Orange
                    tuesday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 15:00:00" Then
                tuesday_330.BackColor = Color.Orange
                lbl_Tuesday_330.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 16:00:00" Then
                    lbl_Tuesday_400.Text = label2
                    tuesday_400.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 17:00:00" Then

                    lbl_Tuesday_400.Text = label2
                    lbl_Tuesday_430.Text = label3
                    tuesday_430.BackColor = Color.Orange
                    tuesday_500.BackColor = Color.Orange
                    tuesday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 15:30:00" Then
                tuesday_400.BackColor = Color.Orange
                lbl_Tuesday_400.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 16:30:00" Then
                    lbl_Tuesday_430.Text = label2
                    tuesday_430.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 17:30:00" Then
                    lbl_Tuesday_430.Text = label2
                    lbl_Tuesday_500.Text = label3
                    tuesday_430.BackColor = Color.Orange
                    tuesday_500.BackColor = Color.Orange
                    tuesday_530.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-11 16:00:00" Then
                tuesday_430.BackColor = Color.Orange
                lbl_Tuesday_430.Text = label
                If read.GetDateTime("time_end") = "2020-02-11 17:00:00" Then
                    lbl_Tuesday_500.Text = label2
                    tuesday_500.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-11 18:00:00" Then
                    lbl_Tuesday_500.Text = label2
                    lbl_Tuesday_530.Text = label3
                    tuesday_600PM.BackColor = Color.Orange
                    tuesday_500.BackColor = Color.Orange
                    tuesday_530.BackColor = Color.Orange
                End If
            End If

            ' wednesday


            If read.GetDateTime("time_start") = "2020-02-12 06:00:00" Then
                wednes_630.BackColor = color.lightyellow
                lbl_Wednesday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 07:00:00" Then
                    wednes_700.BackColor = color.lightyellow
                    lbl_Wednesday_700.Text = label2
                ElseIf read.GetDateTime("time_end") = "2020-02-12 08:00:00" Then
                    wednes_700.BackColor = color.lightyellow
                    wednes_730.BackColor = color.lightyellow
                    wednes_800.BackColor = color.lightyellow
                    lbl_Wednesday_700.Text = label2
                    lbl_Wednesday_730.Text = label3
                    lbl_Wednesday_800.Text = ""

                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 06:30:00" Then
                wednes_630.BackColor = Color.Orange
                lbl_Wednesday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 07:30:00" Then
                    wednes_700.BackColor = Color.Orange
                    wednes_730.BackColor = Color.Orange
                    lbl_Wednesday_700.Text = label2
                    lbl_Wednesday_730.Text = label3
                ElseIf read.GetDateTime("time_end") = "2020-02-12 08:30:00" Then
                    wednes_700.BackColor = Color.Orange
                    wednes_730.BackColor = Color.Orange
                    wednes_800.BackColor = Color.Orange
                    wednes_830.BackColor = Color.Orange
                    lbl_Wednesday_700.Text = label2
                    lbl_Wednesday_730.Text = label3

                    lbl_Wednesday_800.Text = ""
                    lbl_Wednesday_830.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 07:00:00" Then
                wednes_730.BackColor = Color.Orange
                label = lbl_Wednesday_730.Text
                If read.GetDateTime("time_end") = "2020-02-12 08:00:00" Then
                    lbl_Wednesday_800.Text = label2
                    wednes_800.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 09:00:00" Then
                    wednes_800.BackColor = Color.Orange
                    lbl_Wednesday_800.Text = label2
                    wednes_830.BackColor = Color.Orange
                    lbl_Wednesday_830.Text = label3
                    wednes_900.BackColor = Color.Orange
                    lbl_Wednesday_830.Text = ""
                End If
            End If


            If read.GetDateTime("time_start") = "2020-02-12 07:30:00" Then
                wednes_800.BackColor = Color.Orange
                label = lbl_Wednesday_800.Text
                If read.GetDateTime("time_end") = "2020-02-12 08:30:00" Then

                    label2 = lbl_Wednesday_830.Text
                    wednes_830.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 09:30:00" Then
                    wednes_830.BackColor = Color.Orange
                    wednes_900.BackColor = Color.Orange
                    wednes_930.BackColor = Color.Orange
                    label2 = lbl_Wednesday_830.Text
                    label3 = lbl_Wednesday_900.Text
                    lbl_Wednesday_930.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 08:00:00" Then
                wednes_830.BackColor = Color.Orange
                lbl_Wednesday_830.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 09:00:00" Then
                    lbl_Wednesday_900.Text = label2
                    wednes_900.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 10:00:00" Then
                    wednes_900.BackColor = Color.Orange
                    lbl_Wednesday_900.Text = label2
                    wednes_930.BackColor = Color.Orange
                    lbl_Wednesday_930.Text = label3
                    wednes_1000.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 08:30:00" Then
                wednes_900.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-12 09:30:00" Then

                    wednes_930.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 10:30:00" Then
                    wednes_930.BackColor = Color.Orange
                    wednes_1000.BackColor = Color.Orange
                    wednes_1030.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 09:00:00" Then
                wednes_930.BackColor = Color.Orange
                lbl_Wednesday_930.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 10:00:00" Then
                    lbl_Wednesday_1000.Text = label2
                    wednes_1000.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 11:00:00" Then
                    lbl_Wednesday_1000.Text = label2
                    wednes_1000.BackColor = Color.Orange
                    lbl_Wednesday_1030.Text = label3
                    wednes_1030.BackColor = Color.Orange
                    wednes_1100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 09:30:00" Then
                wednes_1000.BackColor = Color.Orange
                lbl_Wednesday_1000.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 10:30:00" Then

                    wednes_1030.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 11:30:00" Then

                    lbl_Wednesday_1100.Text = label2
                    lbl_Wednesday_1130.Text = label3
                    wednes_1030.BackColor = Color.Orange
                    wednes_1100.BackColor = Color.Orange
                    wednes_1130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 10:00:00" Then
                wednes_1030.BackColor = Color.Orange
                lbl_Wednesday_1030.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 11:00:00" Then

                    wednes_1100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 12:00:00" Then

                    lbl_Wednesday_1130.Text = label2
                    lbl_Wednesday_1200.Text = label3
                    wednes_1100.BackColor = Color.Orange
                    wednes_1130.BackColor = Color.Orange
                    wednes_1200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 10:30:00" Then
                wednes_1100.BackColor = Color.Orange
                lbl_Wednesday_1100.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 11:30:00" Then

                    wednes_1130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 12:30:00" Then
                    lbl_Wednesday_1130.Text = ""
                    lbl_Wednesday_1200.Text = label2
                    lbl_Wednesday_1230.Text = label3
                    wednes_1130.BackColor = Color.Orange
                    wednes_1200.BackColor = Color.Orange
                    wednes_1230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 11:00:00" Then
                wednes_1130.BackColor = Color.Orange
                lbl_Wednesday_1130.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 12:00:00" Then

                    wednes_1200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 13:00:00" Then


                    lbl_Wednesday_1230.Text = label2
                    lbl_Wednesday_1100.Text = label3
                    wednes_1200.BackColor = Color.Orange
                    wednes_1230.BackColor = Color.Orange
                    wednes_100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 11:30:00" Then
                wednes_1200.BackColor = Color.Orange
                lbl_Wednesday_1200.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 12:30:00" Then
                    lbl_Wednesday_1230.Text = label2
                    wednes_1230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 13:30:00" Then

                    lbl_Wednesday_1230.Text = label2
                    wednes_1230.BackColor = Color.Orange
                    lbl_Wednesday_100.Text = label3
                    wednes_100.BackColor = Color.Orange
                    wednes_130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 12:00:00" Then
                wednes_1230.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-12 13:00:00" Then
                    lbl_Wednesday_100.Text = label2
                    wednes_100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 14:00:00" Then
                    lbl_Wednesday_100.Text = label2
                    lbl_Wednesday_130.Text = label3
                    wednes_100.BackColor = Color.Orange
                    wednes_130.BackColor = Color.Orange
                    wednes_200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 12:30:00" Then
                wednes_100.BackColor = Color.Orange
                lbl_Wednesday_100.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 13:30:00" Then
                    lbl_Wednesday_130.Text = label2
                    wednes_130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 14:30:00" Then
                    lbl_Wednesday_130.Text = label2
                    lbl_Wednesday_200.Text = label3
                    wednes_130.BackColor = Color.Orange
                    wednes_200.BackColor = Color.Orange
                    wednes_230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 13:00:00" Then
                wednes_130.BackColor = Color.Orange
                lbl_Wednesday_130.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 14:00:00" Then
                    lbl_Wednesday_200.Text = label2
                    wednes_200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 15:00:00" Then
                    lbl_Wednesday_200.Text = label2
                    lbl_Wednesday_230.Text = label3
                    wednes_200.BackColor = Color.Orange
                    wednes_230.BackColor = Color.Orange
                    wednes_300.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 13:30:00" Then
                wednes_200.BackColor = Color.Orange
                lbl_Wednesday_200.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 14:30:00" Then
                    lbl_Wednesday_230.Text = label2
                    wednes_230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 15:30:00" Then

                    lbl_Wednesday_230.Text = label2
                    lbl_Wednesday_300.Text = label3
                    wednes_300.BackColor = Color.Orange
                    wednes_230.BackColor = Color.Orange
                    wednes_330.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 14:00:00" Then
                wednes_230.BackColor = Color.Orange
                lbl_Wednesday_230.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 15:00:00" Then
                    lbl_Wednesday_300.Text = label2
                    wednes_300.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 16:00:00" Then
                    lbl_Wednesday_300.Text = label2
                    lbl_Wednesday_330.Text = label3
                    wednes_300.BackColor = Color.Orange
                    wednes_330.BackColor = Color.Orange
                    wednes_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 14:30:00" Then
                wednes_300.BackColor = Color.Orange
                lbl_Wednesday_300.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 15:30:00" Then
                    lbl_Wednesday_330.Text = label2
                    wednes_330.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 16:30:00" Then
                    lbl_Wednesday_330.Text = label2
                    lbl_Wednesday_400.Text = label3

                    wednes_430.BackColor = Color.Orange
                    wednes_330.BackColor = Color.Orange
                    wednes_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 15:00:00" Then
                wednes_330.BackColor = Color.Orange
                lbl_Wednesday_330.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 16:00:00" Then
                    lbl_Wednesday_400.Text = label2
                    wednes_400.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 17:00:00" Then

                    lbl_Wednesday_400.Text = label2
                    lbl_Wednesday_430.Text = label3
                    wednes_430.BackColor = Color.Orange
                    wednes_500.BackColor = Color.Orange
                    wednes_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 15:30:00" Then
                wednes_400.BackColor = Color.Orange
                lbl_Wednesday_400.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 16:30:00" Then
                    lbl_Wednesday_430.Text = label2
                    wednes_430.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 17:30:00" Then
                    lbl_Wednesday_430.Text = label2
                    lbl_Wednesday_500.Text = label3
                    wednes_430.BackColor = Color.Orange
                    wednes_500.BackColor = Color.Orange
                    wednes_530.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-12 16:00:00" Then
                wednes_430.BackColor = Color.Orange
                lbl_Wednesday_430.Text = label
                If read.GetDateTime("time_end") = "2020-02-12 17:00:00" Then
                    lbl_Wednesday_500.Text = label2
                    wednes_500.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-12 18:00:00" Then
                    lbl_Wednesday_500.Text = label2
                    lbl_Wednesday_530.Text = label3
                    wednes_600PM.BackColor = Color.Orange
                    wednes_500.BackColor = Color.Orange
                    wednes_530.BackColor = Color.Orange
                End If
            End If

            'Thursday

            If read.GetDateTime("time_start") = "2020-02-13 06:00:00" Then
                thursday_630.BackColor = color.lightyellow
                lbl_Thursday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 07:00:00" Then
                    thursday_700.BackColor = color.lightyellow
                    lbl_Thursday_700.Text = label2
                ElseIf read.GetDateTime("time_end") = "2020-02-13 08:00:00" Then
                    thursday_700.BackColor = color.lightyellow
                    thursday_730.BackColor = color.lightyellow
                    thursday_800.BackColor = color.lightyellow
                    lbl_Thursday_700.Text = label2
                    lbl_Thursday_730.Text = label3
                    lbl_Thursday_800.Text = ""

                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 06:30:00" Then
                thursday_630.BackColor = Color.Orange
                lbl_Thursday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 07:30:00" Then
                    thursday_700.BackColor = Color.Orange
                    thursday_730.BackColor = Color.Orange
                    lbl_Thursday_700.Text = label2
                    lbl_Thursday_730.Text = label3
                ElseIf read.GetDateTime("time_end") = "2020-02-13 08:30:00" Then
                    thursday_700.BackColor = Color.Orange
                    thursday_730.BackColor = Color.Orange
                    thursday_800.BackColor = Color.Orange
                    thursday_830.BackColor = Color.Orange
                    lbl_Thursday_700.Text = label2
                    lbl_Thursday_730.Text = label3

                    lbl_Thursday_800.Text = ""
                    lbl_Thursday_830.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 07:00:00" Then
                thursday_730.BackColor = Color.Orange
                label = lbl_Thursday_730.Text
                If read.GetDateTime("time_end") = "2020-02-13 08:00:00" Then
                    lbl_Thursday_800.Text = label2
                    thursday_800.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 09:00:00" Then
                    thursday_800.BackColor = Color.Orange
                    lbl_Thursday_800.Text = label2
                    thursday_830.BackColor = Color.Orange
                    lbl_Thursday_830.Text = label3
                    thursday_900.BackColor = Color.Orange
                    lbl_Thursday_830.Text = ""
                End If
            End If


            If read.GetDateTime("time_start") = "2020-02-13 07:30:00" Then
                thursday_800.BackColor = Color.Orange
                label = lbl_Thursday_800.Text
                If read.GetDateTime("time_end") = "2020-02-13 08:30:00" Then

                    label2 = lbl_Thursday_830.Text
                    thursday_830.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 09:30:00" Then
                    thursday_830.BackColor = Color.Orange
                    thursday_900.BackColor = Color.Orange
                    thursday_930.BackColor = Color.Orange
                    label2 = lbl_Thursday_830.Text
                    label3 = lbl_Thursday_900.Text
                    lbl_Thursday_930.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 08:00:00" Then
                thursday_830.BackColor = Color.Orange
                lbl_Thursday_830.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 09:00:00" Then
                    lbl_Thursday_900.Text = label2
                    thursday_900.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 10:00:00" Then
                    thursday_900.BackColor = Color.Orange
                    lbl_Thursday_900.Text = label2
                    thursday_930.BackColor = Color.Orange
                    lbl_Thursday_930.Text = label3
                    thursday_1000.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 08:30:00" Then
                thursday_900.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-13 09:30:00" Then

                    thursday_930.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 10:30:00" Then
                    thursday_930.BackColor = Color.Orange
                    thursday_1000.BackColor = Color.Orange
                    thursday_1030.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 09:00:00" Then
                thursday_930.BackColor = Color.Orange
                lbl_Thursday_930.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 10:00:00" Then
                    lbl_Thursday_1000.Text = label2
                    thursday_1000.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 11:00:00" Then
                    lbl_Thursday_1000.Text = label2
                    thursday_1000.BackColor = Color.Orange
                    lbl_Thursday_1030.Text = label3
                    thursday_1030.BackColor = Color.Orange
                    thursday_1100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 09:30:00" Then
                thursday_1000.BackColor = Color.Orange
                lbl_Thursday_1000.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 10:30:00" Then
                    lbl_Thursday_1130.Text = label2
                    thursday_1030.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 11:30:00" Then

                    lbl_Thursday_1100.Text = label2
                    lbl_Thursday_1130.Text = label3
                    thursday_1030.BackColor = Color.Orange
                    thursday_1100.BackColor = Color.Orange
                    thursday_1130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 10:00:00" Then
                thursday_1030.BackColor = Color.Orange
                lbl_Thursday_1030.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 11:00:00" Then
                    lbl_Thursday_1100.Text = label2
                    thursday_1100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 12:00:00" Then

                    lbl_Thursday_1130.Text = label2
                    lbl_Thursday_1200.Text = label3
                    thursday_1100.BackColor = Color.Orange
                    thursday_1130.BackColor = Color.Orange
                    thursday_1200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 10:30:00" Then
                thursday_1100.BackColor = Color.Orange
                lbl_Thursday_1100.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 11:30:00" Then

                    thursday_1130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 12:30:00" Then
                    lbl_Thursday_1130.Text = ""
                    lbl_Thursday_1200.Text = label2
                    lbl_Thursday_1230.Text = label3
                    thursday_1130.BackColor = Color.Orange
                    thursday_1200.BackColor = Color.Orange
                    thursday_1230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 11:00:00" Then
                thursday_1130.BackColor = Color.Orange
                lbl_Thursday_1130.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 12:00:00" Then
                    lbl_Thursday_1200.Text = label2
                    thursday_1200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 13:00:00" Then


                    lbl_Thursday_1230.Text = label2
                    lbl_Thursday_1100.Text = label3
                    thursday_1200.BackColor = Color.Orange
                    thursday_1230.BackColor = Color.Orange
                    thursday_100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 11:30:00" Then
                thursday_1200.BackColor = Color.Orange
                lbl_Thursday_1200.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 12:30:00" Then
                    lbl_Thursday_1230.Text = label2
                    thursday_1230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 13:30:00" Then

                    lbl_Thursday_1230.Text = label2
                    thursday_1230.BackColor = Color.Orange
                    lbl_Thursday_100.Text = label3
                    thursday_100.BackColor = Color.Orange
                    thursday_130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 12:00:00" Then
                thursday_1230.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-13 13:00:00" Then
                    lbl_Thursday_100.Text = label2
                    thursday_100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 14:00:00" Then
                    lbl_Thursday_100.Text = label2
                    lbl_Thursday_130.Text = label3
                    thursday_100.BackColor = Color.Orange
                    thursday_130.BackColor = Color.Orange
                    thursday_200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 12:30:00" Then
                thursday_100.BackColor = Color.Orange
                lbl_Thursday_100.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 13:30:00" Then
                    lbl_Thursday_130.Text = label2
                    thursday_130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 14:30:00" Then
                    lbl_Thursday_130.Text = label2
                    lbl_Thursday_200.Text = label3
                    thursday_130.BackColor = Color.Orange
                    thursday_200.BackColor = Color.Orange
                    thursday_230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 13:00:00" Then
                thursday_130.BackColor = Color.Orange
                lbl_Thursday_130.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 14:00:00" Then
                    lbl_Thursday_200.Text = label2
                    thursday_200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 15:00:00" Then
                    lbl_Thursday_200.Text = label2
                    lbl_Thursday_230.Text = label3
                    thursday_200.BackColor = Color.Orange
                    thursday_230.BackColor = Color.Orange
                    thursday_300.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 13:30:00" Then
                thursday_200.BackColor = Color.Orange
                lbl_Thursday_200.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 14:30:00" Then
                    lbl_Thursday_230.Text = label2
                    thursday_230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 15:30:00" Then

                    lbl_Thursday_230.Text = label2
                    lbl_Thursday_300.Text = label3
                    thursday_300.BackColor = Color.Orange
                    thursday_230.BackColor = Color.Orange
                    thursday_330.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 14:00:00" Then
                thursday_230.BackColor = Color.Orange
                lbl_Thursday_230.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 15:00:00" Then
                    lbl_Thursday_300.Text = label2
                    thursday_300.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 16:00:00" Then
                    lbl_Thursday_300.Text = label2
                    lbl_Thursday_330.Text = label3
                    thursday_300.BackColor = Color.Orange
                    thursday_330.BackColor = Color.Orange
                    thursday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 14:30:00" Then
                thursday_300.BackColor = Color.Orange
                lbl_Thursday_300.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 15:30:00" Then
                    lbl_Thursday_330.Text = label2
                    thursday_330.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 16:30:00" Then
                    lbl_Thursday_330.Text = label2
                    lbl_Thursday_400.Text = label3

                    thursday_430.BackColor = Color.Orange
                    thursday_330.BackColor = Color.Orange
                    thursday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 15:00:00" Then
                thursday_330.BackColor = Color.Orange
                lbl_Thursday_330.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 16:00:00" Then
                    lbl_Thursday_400.Text = label2
                    thursday_400.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 17:00:00" Then

                    lbl_Thursday_400.Text = label2
                    lbl_Thursday_430.Text = label3
                    thursday_430.BackColor = Color.Orange
                    thursday_500.BackColor = Color.Orange
                    thursday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 15:30:00" Then
                thursday_400.BackColor = Color.Orange
                lbl_Thursday_400.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 16:30:00" Then
                    lbl_Thursday_430.Text = label2
                    thursday_430.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 17:30:00" Then
                    lbl_Thursday_430.Text = label2
                    lbl_Thursday_500.Text = label3
                    thursday_430.BackColor = Color.Orange
                    thursday_500.BackColor = Color.Orange
                    thursday_530.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-13 16:00:00" Then
                thursday_430.BackColor = Color.Orange
                lbl_Thursday_430.Text = label
                If read.GetDateTime("time_end") = "2020-02-13 17:00:00" Then
                    lbl_Thursday_500.Text = label2
                    thursday_500.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-13 18:00:00" Then
                    lbl_Thursday_500.Text = label2
                    lbl_Thursday_530.Text = label3
                    thursday_600PM.BackColor = Color.Orange
                    thursday_500.BackColor = Color.Orange
                    thursday_530.BackColor = Color.Orange
                End If
            End If




            If read.GetDateTime("time_start") = "2020-02-14 06:00:00" Then
                friday_630AM.BackColor = color.lightyellow
                lbl_Friday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 07:00:00" Then
                    friday_700.BackColor = color.lightyellow
                    lbl_Friday_700.Text = label2
                ElseIf read.GetDateTime("time_end") = "2020-02-14 08:00:00" Then
                    friday_700.BackColor = color.lightyellow
                    friday_730.BackColor = color.lightyellow
                    friday_800.BackColor = color.lightyellow
                    lbl_Friday_700.Text = label2
                    lbl_Friday_730.Text = label3
                    lbl_Friday_800.Text = ""

                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 06:30:00" Then
                friday_630AM.BackColor = Color.Orange
                lbl_Friday_630.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 07:30:00" Then
                    friday_700.BackColor = Color.Orange
                    friday_730.BackColor = Color.Orange
                    lbl_Friday_700.Text = label2
                    lbl_Friday_730.Text = label3
                ElseIf read.GetDateTime("time_end") = "2020-02-14 08:30:00" Then
                    friday_700.BackColor = Color.Orange
                    friday_730.BackColor = Color.Orange
                    friday_800.BackColor = Color.Orange
                    friday_830.BackColor = Color.Orange
                    lbl_Friday_700.Text = label2
                    lbl_Friday_730.Text = label3

                    lbl_Friday_800.Text = ""
                    lbl_Friday_830.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 07:00:00" Then
                friday_730.BackColor = Color.Orange
                label = lbl_Friday_730.Text
                If read.GetDateTime("time_end") = "2020-02-14 08:00:00" Then
                    lbl_Friday_800.Text = label2
                    friday_800.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 09:00:00" Then
                    friday_800.BackColor = Color.Orange
                    lbl_Friday_800.Text = label2
                    friday_830.BackColor = Color.Orange
                    lbl_Friday_830.Text = label3
                    friday_900.BackColor = Color.Orange
                    lbl_Friday_830.Text = ""
                End If
            End If


            If read.GetDateTime("time_start") = "2020-02-14 07:30:00" Then
                friday_800.BackColor = Color.Orange
                label = lbl_Friday_800.Text
                If read.GetDateTime("time_end") = "2020-02-14 08:30:00" Then

                    label2 = lbl_Friday_830.Text
                    friday_830.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 09:30:00" Then
                    friday_830.BackColor = Color.Orange
                    friday_900.BackColor = Color.Orange
                    friday_930.BackColor = Color.Orange
                    label2 = lbl_Friday_830.Text
                    label3 = lbl_Friday_900.Text
                    lbl_Friday_930.Text = ""
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 08:00:00" Then
                friday_830.BackColor = Color.Orange
                lbl_Friday_830.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 09:00:00" Then
                    lbl_Friday_900.Text = label2
                    friday_900.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 10:00:00" Then
                    friday_900.BackColor = Color.Orange
                    lbl_Friday_900.Text = label2
                    friday_930.BackColor = Color.Orange
                    lbl_Friday_930.Text = label3
                    friday_1000.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 08:30:00" Then
                lbl_Friday_900.Text = label
                friday_900.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-14 09:30:00" Then
                    lbl_Friday_930.Text = label2
                    friday_930.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 10:30:00" Then
                    lbl_Friday_930.Text = label2
                    lbl_Friday_1000.Text = label3
                    friday_930.BackColor = Color.Orange
                    friday_1000.BackColor = Color.Orange
                    friday_1030.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 09:00:00" Then
                friday_930.BackColor = Color.Orange
                lbl_Friday_930.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 10:00:00" Then
                    lbl_Friday_1000.Text = label2
                    friday_1000.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 11:00:00" Then
                    lbl_Friday_1000.Text = label2
                    friday_1000.BackColor = Color.Orange
                    lbl_Friday_1030.Text = label3
                    friday_1030.BackColor = Color.Orange
                    friday_1100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 09:30:00" Then
                friday_1000.BackColor = Color.Orange
                lbl_Friday_1000.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 10:30:00" Then
                    lbl_Friday_1030.Text = label2
                    friday_1030.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 11:30:00" Then

                    lbl_Friday_1100.Text = label2
                    lbl_Friday_1130.Text = label3
                    friday_1030.BackColor = Color.Orange
                    friday_1100.BackColor = Color.Orange
                    friday_1130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 10:00:00" Then
                friday_1030.BackColor = Color.Orange
                lbl_Friday_1030.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 11:00:00" Then
                    lbl_Friday_1100.Text = label2
                    friday_1100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 12:00:00" Then

                    lbl_Friday_1130.Text = label2
                    lbl_Friday_1200.Text = label3
                    friday_1100.BackColor = Color.Orange
                    friday_1130.BackColor = Color.Orange
                    friday_1200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 10:30:00" Then
                friday_1100.BackColor = Color.Orange
                lbl_Friday_1100.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 11:30:00" Then
                    lbl_Friday_1130.Text = label2
                    friday_1130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 12:30:00" Then
                    lbl_Friday_1130.Text = ""
                    lbl_Friday_1200.Text = label2
                    lbl_Friday_1230.Text = label3
                    friday_1130.BackColor = Color.Orange
                    friday_1200.BackColor = Color.Orange
                    friday_1230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 11:00:00" Then
                friday_1130.BackColor = Color.Orange
                lbl_Friday_1130.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 12:00:00" Then
                    lbl_Friday_1200.Text = label2
                    friday_1200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 13:00:00" Then


                    lbl_Friday_1230.Text = label2
                    lbl_Friday_1100.Text = label3
                    friday_1200.BackColor = Color.Orange
                    friday_1230.BackColor = Color.Orange
                    friday_100.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 11:30:00" Then
                friday_1200.BackColor = Color.Orange
                lbl_Friday_1200.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 12:30:00" Then
                    lbl_Friday_1230.Text = label2
                    friday_1230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 13:30:00" Then

                    lbl_Friday_1230.Text = label2
                    friday_1230.BackColor = Color.Orange
                    lbl_Friday_100.Text = label3
                    friday_100.BackColor = Color.Orange
                    friday_130.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 12:00:00" Then
                friday_1230.BackColor = Color.Orange
                If read.GetDateTime("time_end") = "2020-02-14 13:00:00" Then
                    lbl_Friday_100.Text = label2
                    friday_100.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 14:00:00" Then
                    lbl_Friday_100.Text = label2
                    lbl_Friday_130.Text = label3
                    friday_100.BackColor = Color.Orange
                    friday_130.BackColor = Color.Orange
                    friday_200.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 12:30:00" Then
                friday_100.BackColor = Color.Orange
                lbl_Friday_100.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 13:30:00" Then
                    lbl_Friday_130.Text = label2
                    friday_130.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 14:30:00" Then
                    lbl_Friday_130.Text = label2
                    lbl_Friday_200.Text = label3
                    friday_130.BackColor = Color.Orange
                    friday_200.BackColor = Color.Orange
                    friday_230.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 13:00:00" Then
                friday_130.BackColor = Color.Orange
                lbl_Friday_130.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 14:00:00" Then
                    lbl_Friday_200.Text = label2
                    friday_200.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 15:00:00" Then
                    lbl_Friday_200.Text = label2
                    lbl_Friday_230.Text = label3
                    friday_200.BackColor = Color.Orange
                    friday_230.BackColor = Color.Orange
                    friday_300.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 13:30:00" Then
                friday_200.BackColor = Color.Orange
                lbl_Friday_200.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 14:30:00" Then
                    lbl_Friday_230.Text = label2
                    friday_230.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 15:30:00" Then

                    lbl_Friday_230.Text = label2
                    lbl_Friday_300.Text = label3
                    friday_300.BackColor = Color.Orange
                    friday_230.BackColor = Color.Orange
                    friday_330.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 14:00:00" Then
                friday_230.BackColor = Color.Orange
                lbl_Friday_230.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 15:00:00" Then
                    lbl_Friday_300.Text = label2
                    friday_300.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 16:00:00" Then
                    lbl_Friday_300.Text = label2
                    lbl_Friday_330.Text = label3
                    friday_300.BackColor = Color.Orange
                    friday_330.BackColor = Color.Orange
                    friday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 14:30:00" Then
                friday_300.BackColor = Color.Orange
                lbl_Friday_300.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 15:30:00" Then
                    lbl_Friday_330.Text = label2
                    friday_330.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 16:30:00" Then
                    lbl_Friday_330.Text = label2
                    lbl_Friday_400.Text = label3

                    friday_430.BackColor = Color.Orange
                    friday_330.BackColor = Color.Orange
                    friday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 15:00:00" Then
                friday_330.BackColor = Color.Orange
                lbl_Friday_330.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 16:00:00" Then
                    lbl_Friday_400.Text = label2
                    friday_400.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 17:00:00" Then

                    lbl_Friday_400.Text = label2
                    lbl_Friday_430.Text = label3
                    friday_430.BackColor = Color.Orange
                    friday_500.BackColor = Color.Orange
                    friday_400.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 15:30:00" Then
                friday_400.BackColor = Color.Orange
                lbl_Friday_400.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 16:30:00" Then
                    lbl_Friday_430.Text = label2
                    friday_430.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 17:30:00" Then
                    lbl_Friday_430.Text = label2
                    lbl_Friday_500.Text = label3
                    friday_430.BackColor = Color.Orange
                    friday_500.BackColor = Color.Orange
                    friday_530.BackColor = Color.Orange
                End If
            End If
            If read.GetDateTime("time_start") = "2020-02-14 16:00:00" Then
                friday_430.BackColor = Color.Orange
                lbl_Friday_430.Text = label
                If read.GetDateTime("time_end") = "2020-02-14 17:00:00" Then
                    lbl_Friday_500.Text = label2
                    friday_500.BackColor = Color.Orange
                ElseIf read.GetDateTime("time_end") = "2020-02-14 18:00:00" Then
                    lbl_Friday_500.Text = label2
                    lbl_Friday_530.Text = label3
                    friday_600PM.BackColor = Color.Orange
                    friday_500.BackColor = Color.Orange
                    friday_530.BackColor = Color.Orange
                End If
            End If
        End While
        read.Close()
        scon.CloseConnection()

    End Sub

    'Loading Item to Drop Box-----------------------------------------
    Public Sub Room_drop_LOad() 'load of drop box

        build_dropbox.Items.Clear()
        Try
            scon.OpenConnection()
            com = New MySqlCommand("SELECT Distinct building_no from room_tbl", scon.GetConnection)
            read = com.ExecuteReader
            While read.Read
                build_d = read.GetString("building_no")
                build_dropbox.Items.Add(build_d)

            End While

            read.Close()

            scon.CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error")
        End Try
    End Sub
    Public Sub Sec_drop_LOad()
        Track_dropdown.Items.Clear()
        'LoadItem
        read.Close()
        Try
            scon.OpenConnection()
            com = New MySqlCommand("SELECT distinct strandName from sections_tbl", scon.GetConnection)
            read = com.ExecuteReader
            While read.Read
                room_d = read.GetString("strandName")


                Track_dropdown.Items.Add(room_d)

            End While
            read.Close()

            scon.CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error")
        End Try

    End Sub
    '---------------------------------------------------------

    'opening links button--------------------------
    Private Sub backBttn_Click(sender As Object, e As EventArgs)
        TeachersTab.Show()
        Me.Close()
    End Sub

    Private Sub add_nSection_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles add_nSection.LinkClicked
        SecAdd.ShowDialog()
        SecAdd.Focus()
    End Sub

    Private Sub add_nRoom_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles add_nRoom.LinkClicked
        room_adder.ShowDialog()
        room_adder.Focus()
    End Sub

    '-----------------------------------------------




    'Panelll Controllllsssss-=============================================================================
    Private Sub time_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles time_combo.SelectedIndexChanged

        If time_combo.Text = "6:00 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("7:00 AM")
            time_end_combo.Items.Add("8:00 AM")
        ElseIf time_combo.Text = "6:30 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("7:30 AM")
            time_end_combo.Items.Add("8:30 AM")
        ElseIf time_combo.Text = "7:00 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("8:00 AM")
            time_end_combo.Items.Add("9:00 AM")
        ElseIf time_combo.Text = "7:30 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("8:30 AM")
            time_end_combo.Items.Add("9:30 AM")
        ElseIf time_combo.Text = "8:00 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("9:00 AM")
            time_end_combo.Items.Add("10:00 AM")
        ElseIf time_combo.Text = "8:30 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("9:30 AM")
            time_end_combo.Items.Add("10:30 AM")
        ElseIf time_combo.Text = "9:00 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("10:00 AM")
            time_end_combo.Items.Add("11:00 AM")
        ElseIf time_combo.Text = "9:30 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("10:30 AM")
            time_end_combo.Items.Add("11:30 AM")
        ElseIf time_combo.Text = "10:00 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("11:00 AM")
            time_end_combo.Items.Add("12:00 PM")
        ElseIf time_combo.Text = "10:30 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("11:30 AM")
            time_end_combo.Items.Add("12:30 PM")
        ElseIf time_combo.Text = "11:00 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("12:00 PM")
            time_end_combo.Items.Add("1:00 PM")
        ElseIf time_combo.Text = "12:00 PM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("1:00 PM")
            time_end_combo.Items.Add("2:00 PM")
        ElseIf time_combo.Text = "12:30 AM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("1:30 PM")
            time_end_combo.Items.Add("2:30 PM")
        ElseIf time_combo.Text = "1:00 PM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("2:00 PM")
            time_end_combo.Items.Add("3:00 PM")
        ElseIf time_combo.Text = "1:30 PM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("2:30 PM")
            time_end_combo.Items.Add("3:30 PM")
        ElseIf time_combo.Text = "2:00 PM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("3:00 PM")
            time_end_combo.Items.Add("4:00 PM")
        ElseIf time_combo.Text = "2:30 PM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("3:30 PM")
            time_end_combo.Items.Add("4:30 PM")
        ElseIf time_combo.Text = "3:00 PM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("4:00 PM")
            time_end_combo.Items.Add("5:00 PM")
        ElseIf time_combo.Text = "3:30 PM" Then
            time_end_combo.Items.Clear()
            time_end_combo.Items.Add("4:30 PM")
            time_end_combo.Items.Add("5:30 PM")
        End If

    End Sub
    Private Sub build_dropbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles build_dropbox.SelectedIndexChanged
        room_dropdown.Items.Clear()
        scon.OpenConnection()
        read.Close()

        Try
            com = New MySqlCommand("select distinct room_no from room_tbl where building_no='" + build_dropbox.Text + "'", scon.GetConnection)
            read = com.ExecuteReader

            While read.Read
                room_d = read.GetString("room_no")
                room_dropdown.Items.Add(room_d)
            End While
            scon.CloseConnection()
            read.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Track_dropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Track_dropdown.SelectedIndexChanged, gradLvel_drop.SelectedIndexChanged
        section_dropdonw.Items.Clear()
        scon.OpenConnection()
        read.Close()

        Try
            com = New MySqlCommand("select distinct sections_no from sections_tbl where strandName='" + Track_dropdown.Text + "' and grade_lvl='" + gradLvel_drop.Text + "'", scon.GetConnection)
            read = com.ExecuteReader
            While read.Read
                sec = read.GetString("sections_no")
                section_dropdonw.Items.Add(sec)
            End While
            scon.CloseConnection()
            read.Close()
        Catch ex As Exception

        End Try


    End Sub



    Dim s As String = "select * from schedule_tbl where id_Prof='" + selectid + "' and sy='" + SelectSt.schedsy_combo.Text + "' and semestral_sche='" + SelectSt.semester_combo.Text + "'"
    Dim adapt As MySqlDataAdapter
    Dim tb As New DataTable
    Dim ds As DataSet

    Dim val1 As String
    Dim val2 As String
    Dim val3 As String
    Dim val4 As String
    Dim val5 As String
    Dim val6 As String

    Dim val7 As String
    Dim val8 As String




    Private Sub Row1_check()
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row1 As DataRow = tb.Rows(0)
        Try
            Dim sc As Date = row1.Item("time_start")
            If sc = "2020-02-10 06:00:00" Then
                val1 = "M 6:00"
            End If
            If sc = "2020-02-10 06:30:00" Then
                val1 = "M 6:30"
            End If
            If sc = "2020-02-10 07:00:00" Then
                val1 = "M 7:00"
            End If
            If sc = "2020-02-10 07:30:00" Then
                val1 = "M 7:30"
            End If
            If sc = "2020-02-10 08:00:00" Then
                val1 = "M 8:00"
            End If
            If sc = "2020-02-10 08:30:00" Then
                val1 = "M 8:30"
            End If
            If sc = "2020-02-10 09:00:00" Then
                val1 = "M 9:00"
            End If
            If sc = "2020-02-10 09:30:00" Then
                val1 = "M 9:30"
            End If
            If sc = "2020-02-10 10:00:00" Then
                val1 = "M 10:00"
            End If
            If sc = "2020-02-10 10:30:00" Then

                val1 = "M 10:30"
            End If
            If sc = "2020-02-10 11:00:00" Then
                val1 = "M 11:00"
            End If
            If sc = "2020-02-10 11:30:00" Then
                val1 = "M 11:30"
            End If
            If sc = "2020-02-10 12:00:00" Then
                val1 = "M 12:00"
            End If
            If sc = "2020-02-10 12:30:00" Then
                val1 = "M 12:30"
            End If
            If sc = "2020-02-10 01:00:00" Then
                val1 = "M 1:00"
            End If
            If sc = "2020-02-10 01:30:00" Then
                val1 = "M 1:30"
            End If
            If sc = "2020-02-10 02:00:00" Then
                val1 = "M 2:00"
            End If
            If sc = "2020-02-10 02:30:00" Then
                val1 = "M 2:30"
            End If
            If sc = "2020-02-10 03:00:00" Then
                val1 = "M 3:00"
            End If
            If sc = "2020-02-10 03:30:00" Then
                val1 = "M 3:30"
            End If
            If sc = "2020-02-11 06:00:00" Then
                val1 = "T 6:00"
            End If

            If sc = "2020-02-11 06:30:00" Then
                val1 = "T 6:30"
            End If

            If sc = "2020-02-11 07:00:00" Then
                val1 = "T 7:00"
            End If

            If sc = "2020-02-11 07:30:00" Then
                val1 = "T 7:30"
            End If
            If sc = "2020-02-11 08:00:00" Then
                val1 = "T 8:00"
            End If
            If sc = "2020-02-11 08:30:00" Then
                val1 = "T 8:30"
            End If
            If sc = "2020-02-11 09:00:00" Then
                val1 = "T 9:00"
            End If
            If sc = "2020-02-11 09:30:00" Then
                val1 = "T 9:30"
            End If
            If sc = "2020-02-11 10:00:00" Then
                val1 = "T 10:00"
            End If
            If sc = "2020-02-11 10:30:00" Then
                val1 = "T 10:30"
            End If
            If sc = "2020-02-11 11:00:00" Then
                val1 = "T 11:00"
            End If
            If sc = "2020-02-11 11:30:00" Then
                val1 = "T 11:30"
            End If
            If sc = "2020-02-11 12:00:00" Then
                val1 = "T 12:00"
            End If
            If sc = "2020-02-11 12:30:00" Then
                val1 = "T 12:30"
            End If
            If sc = "2020-02-11 01:00:00" Then
                val1 = "T 1:00"
            End If
            If sc = "2020-02-11 01:30:00" Then
                val1 = "T 1:30"
            End If
            If sc = "2020-02-11 02:00:00" Then
                val1 = "T 2:00"
            End If
            If sc = "2020-02-11 02:30:00" Then
                val1 = "T 2:30"
            End If
            If sc = "2020-02-11 03:00:00" Then
                val1 = "T 3:00"
            End If
            If sc = "2020-02-11 03:30:00" Then
                val1 = "T 3:30"
            End If

            If sc = "2020-02-12 06:00:00" Then
                val1 = "W 6:00"
            End If
            If sc = "2020-02-12 06:30:00" Then
                val1 = "W 6:30"
            End If
            If sc = "2020-02-12 07:00:00" Then
                val1 = "W 7:00"
            End If
            If sc = "2020-02-12 07:30:00" Then
                val1 = "W 7:30"
            End If
            If sc = "2020-02-12 08:00:00" Then
                val1 = "W 8:00"
            End If
            If sc = "2020-02-12 08:30:00" Then
                val1 = "W 8:30"
            End If
            If sc = "2020-02-12 09:00:00" Then
                val1 = "W 9:00"
            End If
            If sc = "2020-02-12 09:30:00" Then
                val1 = "W 9:30"
            End If
            If sc = "2020-02-12 10:00:00" Then
                val1 = "W 10:00"
            End If
            If sc = "2020-02-12 10:30:00" Then
                val1 = "W 10:30"
            End If
            If sc = "2020-02-12 11:00:00" Then
                val1 = "W 11:00"
            End If
            If sc = "2020-02-12 11:30:00" Then
                val1 = "W 11:30"
            End If
            If sc = "2020-02-12 12:00:00" Then
                val1 = "W 12:00"
            End If
            If sc = "2020-02-12 12:30:00" Then
                val1 = "W 12:30"
            End If
            If sc = "2020-02-12 01:00:00" Then
                val1 = "W 1:00"
            End If
            If sc = "2020-02-12 01:30:00" Then
                val1 = "W 1:30"
            End If
            If sc = "2020-02-12 02:00:00" Then
                val1 = "W 2:00"
            End If
            If sc = "2020-02-12 02:30:00" Then
                val1 = "W 2:30"
            End If
            If sc = "2020-02-12 03:00:00" Then
                val1 = "W 3:00"
            End If
            If sc = "2020-02-12 03:30:00" Then
                val1 = "W 3:30"
            End If

            If sc = "2020-02-13 06:00:00" Then
                val1 = "Thu 6:00"
            End If
            If sc = "2020-02-13 06:30:00" Then
                val1 = "Thu 6:30"
            End If
            If sc = "2020-02-13 07:00:00" Then
                val1 = "Thu 7:00"
            End If
            If sc = "2020-02-13 07:30:00" Then
                val1 = "Thu 7:30"
            End If
            If sc = "2020-02-13 08:00:00" Then
                val1 = "Thu 8:00"
            End If
            If sc = "2020-02-13 08:30:00" Then
                val1 = "Thu 8:30"
            End If
            If sc = "2020-02-13 09:00:00" Then
                val1 = "Thu 9:00"
            End If
            If sc = "2020-02-13 09:30:00" Then
                val1 = "Thu 9:30"
            End If
            If sc = "2020-02-13 10:00:00" Then
                val1 = "Thu 10:00"
            End If
            If sc = "2020-02-13 10:30:00" Then
                val1 = "Thu 10:30"
            End If
            If sc = "2020-02-13 11:00:00" Then
                val1 = "Thu 11:00"
            End If
            If sc = "2020-02-13 11:30:00" Then
                val1 = "Thu 11:30"
            End If
            If sc = "2020-02-13 12:00:00" Then
                val1 = "Thu 12:00"
            End If
            If sc = "2020-02-13 12:30:00" Then
                val1 = "Thu 12:30"
            End If
            If sc = "2020-02-13 01:00:00" Then
                val1 = "Thu 1:00"
            End If
            If sc = "2020-02-13 01:30:00" Then
                val1 = "Thu 1:30"
            End If
            If sc = "2020-02-13 02:00:00" Then
                val1 = "Thu 2:00"
            End If
            If sc = "2020-02-13 02:30:00" Then
                val1 = "Thu 2:30"
            End If
            If sc = "2020-02-13 03:00:00" Then
                val1 = "Thu 3:00"
            End If
            If sc = "2020-02-13 03:30:00" Then
                val1 = "Thu 3:30"
            End If
            If sc = "2020-02-14 06:00:00" Then
                val1 = "F 6:00"
            End If
            If sc = "2020-02-14 06:30:00" Then
                val1 = "F 6:30"
            End If
            If sc = "2020-02-14 07:00:00" Then
                val1 = "F 7:00"
            End If
            If sc = "2020-02-14 07:30:00" Then
                val1 = "F 7:30"
            End If
            If sc = "2020-02-14 08:00:00" Then
                val1 = "F 8:00"
            End If
            If sc = "2020-02-14 08:30:00" Then
                val1 = "F 8:30"
            End If
            If sc = "2020-02-14 09:00:00" Then
                val1 = "F 9:00"
            End If
            If sc = "2020-02-14 09:30:00" Then
                val1 = "F 9:30"
            End If
            If sc = "2020-02-14 10:00:00" Then
                val1 = "F 10:00"
            End If
            If sc = "2020-02-14 10:30:00" Then
                val1 = "F 10:30"
            End If
            If sc = "2020-02-14 11:00:00" Then
                val1 = "F 11:00"
            End If
            If sc = "2020-02-14 11:30:00" Then
                val1 = "F 11:30"
            End If
            If sc = "2020-02-14 12:00:00" Then
                val1 = "F 12:00"
            End If
            If sc = "2020-02-14 12:30:00" Then
                val1 = "F 12:30"
            End If
            If sc = "2020-02-14 01:00:00" Then
                val1 = "F 1:00"
            End If
            If sc = "2020-02-14 01:30:00" Then
                val1 = "F 1:30"
            End If

            If sc = "2020-02-14 02:00:00" Then
                val1 = "F 2:00"
            End If
            If sc = "2020-02-14 02:30:00" Then
                val1 = "F 2:30"
            End If
            If sc = "2020-02-14 03:00:00" Then
                val1 = "F 3:00"
            End If
            If sc = "2020-02-14 03:30:00" Then
                val1 = "F 3:30"
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Row2_check()
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row2 As DataRow = tb.Rows(1)
        Dim sc As Date = row2.Item("time_start")
        If sc = "2020-02-10 06:00:00" Then
            val2 = "M 6:00"
        ElseIf sc = "2020-02-10 06:30:00" Then
            val2 = "M 6:30"
        ElseIf sc = "2020-02-10 07:00:00" Then
            val2 = "M 7:00"
        ElseIf sc = "2020-02-10 07:30:00" Then
            val2 = "M 7:30"
        ElseIf sc = "2020-02-10 08:00:00" Then
            val2 = "M 8:00"
        ElseIf sc = "2020-02-10 08:30:00" Then
            val2 = "M 8:30"
        ElseIf sc = "2020-02-10 09:00:00" Then
            val2 = "M 9:00"
        ElseIf sc = "2020-02-10 09:30:00" Then
            val2 = "M 9:30"
        ElseIf sc = "2020-02-10 10:00:00" Then
            val2 = "M 10:00"
        ElseIf sc = "2020-02-10 10:30:00" Then
            val2 = "M 10:30"
        ElseIf sc = "2020-02-10 11:00:00" Then
            val2 = "M 11:00"
        ElseIf sc = "2020-02-10 11:30:00" Then
            val2 = "M 11:30"
        ElseIf sc = "2020-02-10 12:00:00" Then
            val2 = "M 12:00"
        ElseIf sc = "2020-02-10 12:30:00" Then
            val2 = "M 12:30"
        ElseIf sc = "2020-02-10 01:00:00" Then
            val2 = "M 1:00"
        ElseIf sc = "2020-02-10 01:30:00" Then
            val2 = "M 1:30"
        ElseIf sc = "2020-02-10 02:00:00" Then
            val2 = "M 2:00"
        ElseIf sc = "2020-02-10 02:30:00" Then
            val2 = "M 2:30"
        ElseIf sc = "2020-02-10 03:00:00" Then
            val2 = "M 3:00"
        ElseIf sc = "2020-02-10 03:30:00" Then
            val2 = "M 3:30"
        End If
        If sc = "2020-02-11 06:00:00" Then
            val2 = "T 6:00"
        ElseIf sc = "2020-02-11 06:30:00" Then
            val2 = "T 6:30"
        ElseIf sc = "2020-02-11 07:00:00" Then
            val2 = "T 7:00"
        ElseIf sc = "2020-02-11 07:30:00" Then
            val2 = "T 7:30"
        ElseIf sc = "2020-02-11 08:00:00" Then
            val2 = "T 8:00"
        ElseIf sc = "2020-02-11 08:30:00" Then
            val2 = "T 8:30"
        ElseIf sc = "2020-02-11 09:00:00" Then
            val2 = "T 9:00"
        ElseIf sc = "2020-02-11 09:30:00" Then
            val2 = "T 9:30"
        ElseIf sc = "2020-02-11 10:00:00" Then
            val2 = "T 10:00"
        ElseIf sc = "2020-02-11 10:30:00" Then
            val2 = "T 10:30"
        ElseIf sc = "2020-02-11 11:00:00" Then
            val2 = "T 11:00"
        ElseIf sc = "2020-02-11 11:30:00" Then
            val2 = "T 11:30"
        ElseIf sc = "2020-02-11 12:00:00" Then
            val2 = "T 12:00"
        ElseIf sc = "2020-02-11 12:30:00" Then
            val2 = "T 12:30"
        ElseIf sc = "2020-02-11 01:00:00" Then
            val2 = "T 1:00"
        ElseIf sc = "2020-02-11 01:30:00" Then
            val2 = "T 1:30"
        ElseIf sc = "2020-02-11 02:00:00" Then
            val2 = "T 2:00"
        ElseIf sc = "2020-02-11 02:30:00" Then
            val2 = "T 2:30"
        ElseIf sc = "2020-02-11 03:00:00" Then
            val2 = "T 3:00"
        ElseIf sc = "2020-02-11 03:30:00" Then
            val2 = "T 3:30"
        End If
        If sc = "2020-02-12 06:00:00" Then
            val2 = "W 6:00"
        ElseIf sc = "2020-02-12 06:30:00" Then
            val2 = "W 6:30"
        ElseIf sc = "2020-02-12 07:00:00" Then
            val2 = "W 7:00"
        ElseIf sc = "2020-02-12 07:30:00" Then
            val2 = "W 7:30"
        ElseIf sc = "2020-02-12 08:00:00" Then
            val2 = "W 8:00"
        ElseIf sc = "2020-02-12 08:30:00" Then
            val2 = "W 8:30"
        ElseIf sc = "2020-02-12 09:00:00" Then
            val2 = "W 9:00"
        ElseIf sc = "2020-02-12 09:30:00" Then
            val2 = "W 9:30"
        ElseIf sc = "2020-02-12 10:00:00" Then
            val2 = "W 10:00"
        ElseIf sc = "2020-02-12 10:30:00" Then
            val2 = "W 10:30"
        ElseIf sc = "2020-02-12 11:00:00" Then
            val2 = "W 11:00"
        ElseIf sc = "2020-02-12 11:30:00" Then
            val2 = "W 11:30"
        ElseIf sc = "2020-02-12 12:00:00" Then
            val2 = "W 12:00"
        ElseIf sc = "2020-02-12 12:30:00" Then
            val2 = "W 12:30"
        ElseIf sc = "2020-02-12 01:00:00" Then
            val2 = "W 1:00"
        ElseIf sc = "2020-02-12 01:30:00" Then
            val2 = "W 1:30"
        ElseIf sc = "2020-02-12 02:00:00" Then
            val2 = "W 2:00"
        ElseIf sc = "2020-02-12 02:30:00" Then
            val2 = "W 2:30"
        ElseIf sc = "2020-02-12 03:00:00" Then
            val2 = "W 3:00"
        ElseIf sc = "2020-02-12 03:30:00" Then
            val2 = "W 3:30"
        End If
        If sc = "2020-02-13 06:00:00" Then
            val2 = "Thu 6:00"
        ElseIf sc = "2020-02-13 06:30:00" Then
            val2 = "Thu 6:30"
        ElseIf sc = "2020-02-13 07:00:00" Then
            val2 = "Thu 7:00"
        ElseIf sc = "2020-02-13 07:30:00" Then
            val2 = "Thu 7:30"
        ElseIf sc = "2020-02-13 08:00:00" Then
            val2 = "Thu 8:00"
        ElseIf sc = "2020-02-13 08:30:00" Then
            val2 = "Thu 8:30"
        ElseIf sc = "2020-02-13 09:00:00" Then
            val2 = "Thu 9:00"
        ElseIf sc = "2020-02-13 09:30:00" Then
            val2 = "Thu 9:30"
        ElseIf sc = "2020-02-13 10:00:00" Then
            val2 = "Thu 10:00"
        ElseIf sc = "2020-02-13 10:30:00" Then
            val2 = "Thu 10:30"
        ElseIf sc = "2020-02-13 11:00:00" Then
            val2 = "Thu 11:00"
        ElseIf sc = "2020-02-13 11:30:00" Then
            val2 = "Thu 11:30"
        ElseIf sc = "2020-02-13 12:00:00" Then
            val2 = "Thu 12:00"
        ElseIf sc = "2020-02-13 12:30:00" Then
            val2 = "Thu 12:30"
        ElseIf sc = "2020-02-13 01:00:00" Then
            val2 = "Thu 1:00"
        ElseIf sc = "2020-02-13 01:30:00" Then
            val2 = "Thu 1:30"
        ElseIf sc = "2020-02-13 02:00:00" Then
            val2 = "Thu 2:00"
        ElseIf sc = "2020-02-13 02:30:00" Then
            val2 = "Thu 2:30"
        ElseIf sc = "2020-02-13 03:00:00" Then
            val2 = "Thu 3:00"
        ElseIf sc = "2020-02-13 03:30:00" Then
            val2 = "Thu 3:30"
        End If
        If sc = "2020-02-14 06:00:00" Then
            val2 = "F 6:00"
        ElseIf sc = "2020-02-14 06:30:00" Then
            val2 = "F 6:30"
        ElseIf sc = "2020-02-14 07:00:00" Then
            val2 = "F 7:00"
        ElseIf sc = "2020-02-14 07:30:00" Then
            val2 = "F 7:30"
        ElseIf sc = "2020-02-14 08:00:00" Then
            val2 = "F 8:00"
        ElseIf sc = "2020-02-14 08:30:00" Then
            val2 = "F 8:30"
        ElseIf sc = "2020-02-14 09:00:00" Then
            val2 = "F 9:00"
        ElseIf sc = "2020-02-14 09:30:00" Then
            val2 = "F 9:30"
        ElseIf sc = "2020-02-14 10:00:00" Then
            val2 = "F 10:00"
        ElseIf sc = "2020-02-14 10:30:00" Then
            val2 = "F 10:30"
        ElseIf sc = "2020-02-14 11:00:00" Then
            val2 = "F 11:00"
        ElseIf sc = "2020-02-14 11:30:00" Then
            val2 = "F 11:30"
        ElseIf sc = "2020-02-14 12:00:00" Then
            val2 = "F 12:00"
        ElseIf sc = "2020-02-14 12:30:00" Then
            val2 = "F 12:30"
        ElseIf sc = "2020-02-14 01:00:00" Then
            val2 = "F 1:00"
        ElseIf sc = "2020-02-14 01:30:00" Then
            val2 = "F 1:30"
        ElseIf sc = "2020-02-14 02:00:00" Then
            val2 = "F 2:00"
        ElseIf sc = "2020-02-14 02:30:00" Then
            val2 = "F 2:30"
        ElseIf sc = "2020-02-14 03:00:00" Then
            val2 = "F 3:00"
        ElseIf sc = "2020-02-14 03:30:00" Then
            val2 = "F 3:30"
        End If

    End Sub
    Private Sub row3_check()
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row3 As DataRow = tb.Rows(2)
        Dim sc As Date = row3.Item("time_start")
        If sc = "2020-02-10 06:00:00" Then
            val3 = "M 6:00"
        ElseIf sc = "2020-02-10 06:30:00" Then
            val3 = "M 6:30"
        ElseIf sc = "2020-02-10 07:00:00" Then
            val3 = "M 7:00"
        ElseIf sc = "2020-02-10 07:30:00" Then
            val3 = "M 7:30"
        ElseIf sc = "2020-02-10 08:00:00" Then
            val3 = "M 8:00"
        ElseIf sc = "2020-02-10 08:30:00" Then
            val3 = "M 8:30"
        ElseIf sc = "2020-02-10 09:00:00" Then
            val3 = "M 9:00"
        ElseIf sc = "2020-02-10 09:30:00" Then
            val3 = "M 9:30"
        ElseIf sc = "2020-02-10 10:00:00" Then
            val3 = "M 10:00"
        ElseIf sc = "2020-02-10 10:30:00" Then
            val3 = "M 10:30"
        ElseIf sc = "2020-02-10 11:00:00" Then
            val3 = "M 11:00"
        ElseIf sc = "2020-02-10 11:30:00" Then
            val3 = "M 11:30"
        ElseIf sc = "2020-02-10 12:00:00" Then
            val3 = "M 12:00"
        ElseIf sc = "2020-02-10 12:30:00" Then
            val3 = "M 12:30"
        ElseIf sc = "2020-02-10 01:00:00" Then
            val3 = "M 1:00"
        ElseIf sc = "2020-02-10 01:30:00" Then
            val3 = "M 1:30"
        ElseIf sc = "2020-02-10 02:00:00" Then
            val3 = "M 2:00"
        ElseIf sc = "2020-02-10 02:30:00" Then
            val3 = "M 2:30"
        ElseIf sc = "2020-02-10 03:00:00" Then
            val3 = "M 3:00"
        ElseIf sc = "2020-02-10 03:30:00" Then
            val3 = "M 3:30"
        End If
        If sc = "2020-02-11 06:00:00" Then
            val3 = "T 6:00"
        ElseIf sc = "2020-02-11 06:30:00" Then
            val3 = "T 6:30"
        ElseIf sc = "2020-02-11 07:00:00" Then
            val3 = "T 7:00"
        ElseIf sc = "2020-02-11 07:30:00" Then
            val3 = "T 7:30"
        ElseIf sc = "2020-02-11 08:00:00" Then
            val3 = "T 8:00"
        ElseIf sc = "2020-02-11 08:30:00" Then
            val3 = "T 8:30"
        ElseIf sc = "2020-02-11 09:00:00" Then
            val3 = "T 9:00"
        ElseIf sc = "2020-02-11 09:30:00" Then
            val3 = "T 9:30"
        ElseIf sc = "2020-02-11 10:00:00" Then
            val3 = "T 10:00"
        ElseIf sc = "2020-02-11 10:30:00" Then
            val3 = "T 10:30"
        ElseIf sc = "2020-02-11 11:00:00" Then
            val3 = "T 11:00"
        ElseIf sc = "2020-02-11 11:30:00" Then
            val3 = "T 11:30"
        ElseIf sc = "2020-02-11 12:00:00" Then
            val3 = "T 12:00"
        ElseIf sc = "2020-02-11 12:30:00" Then
            val3 = "T 12:30"
        ElseIf sc = "2020-02-11 01:00:00" Then
            val3 = "T 1:00"
        ElseIf sc = "2020-02-11 01:30:00" Then
            val3 = "T 1:30"
        ElseIf sc = "2020-02-11 02:00:00" Then
            val3 = "T 2:00"
        ElseIf sc = "2020-02-11 02:30:00" Then
            val3 = "T 2:30"
        ElseIf sc = "2020-02-11 03:00:00" Then
            val3 = "T 3:00"
        ElseIf sc = "2020-02-11 03:30:00" Then
            val3 = "T 3:30"
        End If
        If sc = "2020-02-12 06:00:00" Then
            val3 = "W 6:00"
        ElseIf sc = "2020-02-12 06:30:00" Then
            val3 = "W 6:30"
        ElseIf sc = "2020-02-12 07:00:00" Then
            val3 = "W 7:00"
        ElseIf sc = "2020-02-12 07:30:00" Then
            val3 = "W 7:30"
        ElseIf sc = "2020-02-12 08:00:00" Then
            val3 = "W 8:00"
        ElseIf sc = "2020-02-12 08:30:00" Then
            val3 = "W 8:30"
        ElseIf sc = "2020-02-12 09:00:00" Then
            val3 = "W 9:00"
        ElseIf sc = "2020-02-12 09:30:00" Then
            val3 = "W 9:30"
        ElseIf sc = "2020-02-12 10:00:00" Then
            val3 = "W 10:00"
        ElseIf sc = "2020-02-12 10:30:00" Then
            val3 = "W 10:30"
        ElseIf sc = "2020-02-12 11:00:00" Then
            val3 = "W 11:00"
        ElseIf sc = "2020-02-12 11:30:00" Then
            val3 = "W 11:30"
        ElseIf sc = "2020-02-12 12:00:00" Then
            val3 = "W 12:00"
        ElseIf sc = "2020-02-12 12:30:00" Then
            val3 = "W 12:30"
        ElseIf sc = "2020-02-12 01:00:00" Then
            val3 = "W 1:00"
        ElseIf sc = "2020-02-12 01:30:00" Then
            val3 = "W 1:30"
        ElseIf sc = "2020-02-12 02:00:00" Then
            val3 = "W 2:00"
        ElseIf sc = "2020-02-12 02:30:00" Then
            val3 = "W 2:30"
        ElseIf sc = "2020-02-12 03:00:00" Then
            val3 = "W 3:00"
        ElseIf sc = "2020-02-12 03:30:00" Then
            val3 = "W 3:30"
        End If
        If sc = "2020-02-13 06:00:00" Then
            val3 = "Thu 6:00"
        ElseIf sc = "2020-02-13 06:30:00" Then
            val3 = "Thu 6:30"
        ElseIf sc = "2020-02-13 07:00:00" Then
            val3 = "Thu 7:00"
        ElseIf sc = "2020-02-13 07:30:00" Then
            val3 = "Thu 7:30"
        ElseIf sc = "2020-02-13 08:00:00" Then
            val3 = "Thu 8:00"
        ElseIf sc = "2020-02-13 08:30:00" Then
            val3 = "Thu 8:30"
        ElseIf sc = "2020-02-13 09:00:00" Then
            val3 = "Thu 9:00"
        ElseIf sc = "2020-02-13 09:30:00" Then
            val3 = "Thu 9:30"
        ElseIf sc = "2020-02-13 10:00:00" Then
            val3 = "Thu 10:00"
        ElseIf sc = "2020-02-13 10:30:00" Then
            val3 = "Thu 10:30"
        ElseIf sc = "2020-02-13 11:00:00" Then
            val3 = "Thu 11:00"
        ElseIf sc = "2020-02-13 11:30:00" Then
            val3 = "Thu 11:30"
        ElseIf sc = "2020-02-13 12:00:00" Then
            val3 = "Thu 12:00"
        ElseIf sc = "2020-02-13 12:30:00" Then
            val3 = "Thu 12:30"
        ElseIf sc = "2020-02-13 01:00:00" Then
            val3 = "Thu 1:00"
        ElseIf sc = "2020-02-13 01:30:00" Then
            val3 = "Thu 1:30"
        ElseIf sc = "2020-02-13 02:00:00" Then
            val3 = "Thu 2:00"
        ElseIf sc = "2020-02-13 02:30:00" Then
            val3 = "Thu 2:30"
        ElseIf sc = "2020-02-13 03:00:00" Then
            val3 = "Thu 3:00"
        ElseIf sc = "2020-02-13 03:30:00" Then
            val3 = "Thu 3:30"
        End If
        If sc = "2020-02-14 06:00:00" Then
            val3 = "F 6:00"
        ElseIf sc = "2020-02-14 06:30:00" Then
            val3 = "F 6:30"
        ElseIf sc = "2020-02-14 07:00:00" Then
            val3 = "F 7:00"
        ElseIf sc = "2020-02-14 07:30:00" Then
            val3 = "F 7:30"
        ElseIf sc = "2020-02-14 08:00:00" Then
            val3 = "F 8:00"
        ElseIf sc = "2020-02-14 08:30:00" Then
            val3 = "F 8:30"
        ElseIf sc = "2020-02-14 09:00:00" Then
            val3 = "F 9:00"
        ElseIf sc = "2020-02-14 09:30:00" Then
            val3 = "F 9:30"
        ElseIf sc = "2020-02-14 10:00:00" Then
            val3 = "F 10:00"
        ElseIf sc = "2020-02-14 10:30:00" Then
            val3 = "F 10:30"
        ElseIf sc = "2020-02-14 11:00:00" Then
            val3 = "F 11:00"
        ElseIf sc = "2020-02-14 11:30:00" Then
            val3 = "F 11:30"
        ElseIf sc = "2020-02-14 12:00:00" Then
            val3 = "F 12:00"
        ElseIf sc = "2020-02-14 12:30:00" Then
            val3 = "F 12:30"
        ElseIf sc = "2020-02-14 01:00:00" Then
            val3 = "F 1:00"
        ElseIf sc = "2020-02-14 01:30:00" Then
            val3 = "F 1:30"
        ElseIf sc = "2020-02-14 02:00:00" Then
            val3 = "F 2:00"
        ElseIf sc = "2020-02-14 02:30:00" Then
            val3 = "F 2:30"
        ElseIf sc = "2020-02-14 03:00:00" Then
            val3 = "F 3:00"
        ElseIf sc = "2020-02-14 03:30:00" Then
            val3 = "F 3:30"
        End If
    End Sub
    Private Sub row4_check()
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row4 As DataRow = tb.Rows(3)
        Dim sc As Date = row4.Item("time_start")
        If sc = "2020-02-10 06:00:00" Then
            val4 = "M 6:00"
        ElseIf sc = "2020-02-10 06:30:00" Then
            val4 = "M 6:30"
        ElseIf sc = "2020-02-10 07:00:00" Then
            val4 = "M 7:00"
        ElseIf sc = "2020-02-10 07:30:00" Then
            val4 = "M 7:30"
        ElseIf sc = "2020-02-10 08:00:00" Then
            val4 = "M 8:00"
        ElseIf sc = "2020-02-10 08:30:00" Then
            val4 = "M 8:30"
        ElseIf sc = "2020-02-10 09:00:00" Then
            val4 = "M 9:00"
        ElseIf sc = "2020-02-10 09:30:00" Then
            val4 = "M 9:30"
        ElseIf sc = "2020-02-10 10:00:00" Then
            val4 = "M 10:00"
        ElseIf sc = "2020-02-10 10:30:00" Then
            val4 = "M 10:30"
        ElseIf sc = "2020-02-10 11:00:00" Then
            val4 = "M 11:00"
        ElseIf sc = "2020-02-10 11:30:00" Then
            val4 = "M 11:30"
        ElseIf sc = "2020-02-10 12:00:00" Then
            val4 = "M 12:00"
        ElseIf sc = "2020-02-10 12:30:00" Then
            val4 = "M 12:30"
        ElseIf sc = "2020-02-10 01:00:00" Then
            val4 = "M 1:00"
        ElseIf sc = "2020-02-10 01:30:00" Then
            val4 = "M 1:30"
        ElseIf sc = "2020-02-10 02:00:00" Then
            val4 = "M 2:00"
        ElseIf sc = "2020-02-10 02:30:00" Then
            val4 = "M 2:30"
        ElseIf sc = "2020-02-10 03:00:00" Then
            val4 = "M 3:00"
        ElseIf sc = "2020-02-10 03:30:00" Then
            val4 = "M 3:30"
        End If
        If sc = "2020-02-11 06:00:00" Then
            val4 = "T 6:00"
        ElseIf sc = "2020-02-11 06:30:00" Then
            val4 = "T 6:30"
        ElseIf sc = "2020-02-11 07:00:00" Then
            val4 = "T 7:00"
        ElseIf sc = "2020-02-11 07:30:00" Then
            val4 = "T 7:30"
        ElseIf sc = "2020-02-11 08:00:00" Then
            val4 = "T 8:00"
        ElseIf sc = "2020-02-11 08:30:00" Then
            val4 = "T 8:30"
        ElseIf sc = "2020-02-11 09:00:00" Then
            val4 = "T 9:00"
        ElseIf sc = "2020-02-11 09:30:00" Then
            val4 = "T 9:30"
        ElseIf sc = "2020-02-11 10:00:00" Then
            val4 = "T 10:00"
        ElseIf sc = "2020-02-11 10:30:00" Then
            val4 = "T 10:30"
        ElseIf sc = "2020-02-11 11:00:00" Then
            val4 = "T 11:00"
        ElseIf sc = "2020-02-11 11:30:00" Then
            val4 = "T 11:30"
        ElseIf sc = "2020-02-11 12:00:00" Then
            val4 = "T 12:00"
        ElseIf sc = "2020-02-11 12:30:00" Then
            val4 = "T 12:30"
        ElseIf sc = "2020-02-11 01:00:00" Then
            val4 = "T 1:00"
        ElseIf sc = "2020-02-11 01:30:00" Then
            val4 = "T 1:30"
        ElseIf sc = "2020-02-11 02:00:00" Then
            val4 = "T 2:00"
        ElseIf sc = "2020-02-11 02:30:00" Then
            val4 = "T 2:30"
        ElseIf sc = "2020-02-11 03:00:00" Then
            val4 = "T 3:00"
        ElseIf sc = "2020-02-11 03:30:00" Then
            val4 = "T 3:30"
        End If
        If sc = "2020-02-12 06:00:00" Then
            val4 = "W 6:00"
        ElseIf sc = "2020-02-12 06:30:00" Then
            val4 = "W 6:30"
        ElseIf sc = "2020-02-12 07:00:00" Then
            val4 = "W 7:00"
        ElseIf sc = "2020-02-12 07:30:00" Then
            val4 = "W 7:30"
        ElseIf sc = "2020-02-12 08:00:00" Then
            val4 = "W 8:00"
        ElseIf sc = "2020-02-12 08:30:00" Then
            val4 = "W 8:30"
        ElseIf sc = "2020-02-12 09:00:00" Then
            val4 = "W 9:00"
        ElseIf sc = "2020-02-12 09:30:00" Then
            val4 = "W 9:30"
        ElseIf sc = "2020-02-12 10:00:00" Then
            val4 = "W 10:00"
        ElseIf sc = "2020-02-12 10:30:00" Then
            val4 = "W 10:30"
        ElseIf sc = "2020-02-12 11:00:00" Then
            val4 = "W 11:00"
        ElseIf sc = "2020-02-12 11:30:00" Then
            val4 = "W 11:30"
        ElseIf sc = "2020-02-12 12:00:00" Then
            val4 = "W 12:00"
        ElseIf sc = "2020-02-12 12:30:00" Then
            val4 = "W 12:30"
        ElseIf sc = "2020-02-12 01:00:00" Then
            val4 = "W 1:00"
        ElseIf sc = "2020-02-12 01:30:00" Then
            val4 = "W 1:30"
        ElseIf sc = "2020-02-12 02:00:00" Then
            val4 = "W 2:00"
        ElseIf sc = "2020-02-12 02:30:00" Then
            val4 = "W 2:30"
        ElseIf sc = "2020-02-12 03:00:00" Then
            val4 = "W 3:00"
        ElseIf sc = "2020-02-12 03:30:00" Then
            val4 = "W 3:30"
        End If
        If sc = "2020-02-13 06:00:00" Then
            val4 = "Thu 6:00"
        ElseIf sc = "2020-02-13 06:30:00" Then
            val4 = "Thu 6:30"
        ElseIf sc = "2020-02-13 07:00:00" Then
            val4 = "Thu 7:00"
        ElseIf sc = "2020-02-13 07:30:00" Then
            val4 = "Thu 7:30"
        ElseIf sc = "2020-02-13 08:00:00" Then
            val4 = "Thu 8:00"
        ElseIf sc = "2020-02-13 08:30:00" Then
            val4 = "Thu 8:30"
        ElseIf sc = "2020-02-13 09:00:00" Then
            val4 = "Thu 9:00"
        ElseIf sc = "2020-02-13 09:30:00" Then
            val4 = "Thu 9:30"
        ElseIf sc = "2020-02-13 10:00:00" Then
            val4 = "Thu 10:00"
        ElseIf sc = "2020-02-13 10:30:00" Then
            val4 = "Thu 10:30"
        ElseIf sc = "2020-02-13 11:00:00" Then
            val4 = "Thu 11:00"
        ElseIf sc = "2020-02-13 11:30:00" Then
            val4 = "Thu 11:30"
        ElseIf sc = "2020-02-13 12:00:00" Then
            val4 = "Thu 12:00"
        ElseIf sc = "2020-02-13 12:30:00" Then
            val4 = "Thu 12:30"
        ElseIf sc = "2020-02-13 01:00:00" Then
            val4 = "Thu 1:00"
        ElseIf sc = "2020-02-13 01:30:00" Then
            val4 = "Thu 1:30"
        ElseIf sc = "2020-02-13 02:00:00" Then
            val4 = "Thu 2:00"
        ElseIf sc = "2020-02-13 02:30:00" Then
            val4 = "Thu 2:30"
        ElseIf sc = "2020-02-13 03:00:00" Then
            val4 = "Thu 3:00"
        ElseIf sc = "2020-02-13 03:30:00" Then
            val4 = "Thu 3:30"
        End If
        If sc = "2020-02-14 06:00:00" Then
            val4 = "F 6:00"
        ElseIf sc = "2020-02-14 06:30:00" Then
            val4 = "F 6:30"
        ElseIf sc = "2020-02-14 07:00:00" Then
            val4 = "F 7:00"
        ElseIf sc = "2020-02-14 07:30:00" Then
            val4 = "F 7:30"
        ElseIf sc = "2020-02-14 08:00:00" Then
            val4 = "F 8:00"
        ElseIf sc = "2020-02-14 08:30:00" Then
            val4 = "F 8:30"
        ElseIf sc = "2020-02-14 09:00:00" Then
            val4 = "F 9:00"
        ElseIf sc = "2020-02-14 09:30:00" Then
            val4 = "F 9:30"
        ElseIf sc = "2020-02-14 10:00:00" Then
            val4 = "F 10:00"
        ElseIf sc = "2020-02-14 10:30:00" Then
            val4 = "F 10:30"
        ElseIf sc = "2020-02-14 11:00:00" Then
            val4 = "F 11:00"
        ElseIf sc = "2020-02-14 11:30:00" Then
            val4 = "F 11:30"
        ElseIf sc = "2020-02-14 12:00:00" Then
            val4 = "F 12:00"
        ElseIf sc = "2020-02-14 12:30:00" Then
            val4 = "F 12:30"
        ElseIf sc = "2020-02-14 01:00:00" Then
            val4 = "F 1:00"
        ElseIf sc = "2020-02-14 01:30:00" Then
            val4 = "F 1:30"
        ElseIf sc = "2020-02-14 02:00:00" Then
            val4 = "F 2:00"
        ElseIf sc = "2020-02-14 02:30:00" Then
            val4 = "F 2:30"
        ElseIf sc = "2020-02-14 03:00:00" Then
            val4 = "F 3:00"
        ElseIf sc = "2020-02-14 03:30:00" Then
            val4 = "F 3:30"
        End If
    End Sub
    Private Sub row5_check()
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row5 As DataRow = tb.Rows(4)
        Dim sc As Date = row5.Item("time_start")
        If sc = "2020-02-10 06:00:00" Then
            val5 = "M 6:00"
        ElseIf sc = "2020-02-10 06:30:00" Then
            val5 = "M 6:30"
        ElseIf sc = "2020-02-10 07:00:00" Then
            val5 = "M 7:00"
        ElseIf sc = "2020-02-10 07:30:00" Then
            val5 = "M 7:30"
        ElseIf sc = "2020-02-10 08:00:00" Then
            val5 = "M 8:00"
        ElseIf sc = "2020-02-10 08:30:00" Then
            val5 = "M 8:30"
        ElseIf sc = "2020-02-10 09:00:00" Then
            val5 = "M 9:00"
        ElseIf sc = "2020-02-10 09:30:00" Then
            val5 = "M 9:30"
        ElseIf sc = "2020-02-10 10:00:00" Then
            val5 = "M 10:00"
        ElseIf sc = "2020-02-10 10:30:00" Then
            val5 = "M 10:30"
        ElseIf sc = "2020-02-10 11:00:00" Then
            val5 = "M 11:00"
        ElseIf sc = "2020-02-10 11:30:00" Then
            val5 = "M 11:30"
        ElseIf sc = "2020-02-10 12:00:00" Then
            val5 = "M 12:00"
        ElseIf sc = "2020-02-10 12:30:00" Then
            val5 = "M 12:30"
        ElseIf sc = "2020-02-10 01:00:00" Then
            val5 = "M 1:00"
        ElseIf sc = "2020-02-10 01:30:00" Then
            val5 = "M 1:30"
        ElseIf sc = "2020-02-10 02:00:00" Then
            val5 = "M 2:00"
        ElseIf sc = "2020-02-10 02:30:00" Then
            val5 = "M 2:30"
        ElseIf sc = "2020-02-10 03:00:00" Then
            val5 = "M 3:00"
        ElseIf sc = "2020-02-10 03:30:00" Then
            val5 = "M 3:30"
        End If
        If sc = "2020-02-11 06:00:00" Then
            val5 = "T 6:00"
        ElseIf sc = "2020-02-11 06:30:00" Then
            val5 = "T 6:30"
        ElseIf sc = "2020-02-11 07:00:00" Then
            val5 = "T 7:00"
        ElseIf sc = "2020-02-11 07:30:00" Then
            val5 = "T 7:30"
        ElseIf sc = "2020-02-11 08:00:00" Then
            val5 = "T 8:00"
        ElseIf sc = "2020-02-11 08:30:00" Then
            val5 = "T 8:30"
        ElseIf sc = "2020-02-11 09:00:00" Then
            val5 = "T 9:00"
        ElseIf sc = "2020-02-11 09:30:00" Then
            val5 = "T 9:30"
        ElseIf sc = "2020-02-11 10:00:00" Then
            val5 = "T 10:00"
        ElseIf sc = "2020-02-11 10:30:00" Then
            val5 = "T 10:30"
        ElseIf sc = "2020-02-11 11:00:00" Then
            val5 = "T 11:00"
        ElseIf sc = "2020-02-11 11:30:00" Then
            val5 = "T 11:30"
        ElseIf sc = "2020-02-11 12:00:00" Then
            val5 = "T 12:00"
        ElseIf sc = "2020-02-11 12:30:00" Then
            val5 = "T 12:30"
        ElseIf sc = "2020-02-11 01:00:00" Then
            val5 = "T 1:00"
        ElseIf sc = "2020-02-11 01:30:00" Then
            val5 = "T 1:30"
        ElseIf sc = "2020-02-11 02:00:00" Then
            val5 = "T 2:00"
        ElseIf sc = "2020-02-11 02:30:00" Then
            val5 = "T 2:30"
        ElseIf sc = "2020-02-11 03:00:00" Then
            val5 = "T 3:00"
        ElseIf sc = "2020-02-11 03:30:00" Then
            val5 = "T 3:30"
        End If
        If sc = "2020-02-12 06:00:00" Then
            val5 = "W 6:00"
        ElseIf sc = "2020-02-12 06:30:00" Then
            val5 = "W 6:30"
        ElseIf sc = "2020-02-12 07:00:00" Then
            val5 = "W 7:00"
        ElseIf sc = "2020-02-12 07:30:00" Then
            val5 = "W 7:30"
        ElseIf sc = "2020-02-12 08:00:00" Then
            val5 = "W 8:00"
        ElseIf sc = "2020-02-12 08:30:00" Then
            val5 = "W 8:30"
        ElseIf sc = "2020-02-12 09:00:00" Then
            val5 = "W 9:00"
        ElseIf sc = "2020-02-12 09:30:00" Then
            val5 = "W 9:30"
        ElseIf sc = "2020-02-12 10:00:00" Then
            val5 = "W 10:00"
        ElseIf sc = "2020-02-12 10:30:00" Then
            val5 = "W 10:30"
        ElseIf sc = "2020-02-12 11:00:00" Then
            val5 = "W 11:00"
        ElseIf sc = "2020-02-12 11:30:00" Then
            val5 = "W 11:30"
        ElseIf sc = "2020-02-12 12:00:00" Then
            val5 = "W 12:00"
        ElseIf sc = "2020-02-12 12:30:00" Then
            val5 = "W 12:30"
        ElseIf sc = "2020-02-12 01:00:00" Then
            val5 = "W 1:00"
        ElseIf sc = "2020-02-12 01:30:00" Then
            val5 = "W 1:30"
        ElseIf sc = "2020-02-12 02:00:00" Then
            val5 = "W 2:00"
        ElseIf sc = "2020-02-12 02:30:00" Then
            val5 = "W 2:30"
        ElseIf sc = "2020-02-12 03:00:00" Then
            val5 = "W 3:00"
        ElseIf sc = "2020-02-12 03:30:00" Then
            val5 = "W 3:30"
        End If
        If sc = "2020-02-13 06:00:00" Then
            val5 = "Thu 6:00"
        ElseIf sc = "2020-02-13 06:30:00" Then
            val5 = "Thu 6:30"
        ElseIf sc = "2020-02-13 07:00:00" Then
            val5 = "Thu 7:00"
        ElseIf sc = "2020-02-13 07:30:00" Then
            val5 = "Thu 7:30"
        ElseIf sc = "2020-02-13 08:00:00" Then
            val5 = "Thu 8:00"
        ElseIf sc = "2020-02-13 08:30:00" Then
            val5 = "Thu 8:30"
        ElseIf sc = "2020-02-13 09:00:00" Then
            val5 = "Thu 9:00"
        ElseIf sc = "2020-02-13 09:30:00" Then
            val5 = "Thu 9:30"
        ElseIf sc = "2020-02-13 10:00:00" Then
            val5 = "Thu 10:00"
        ElseIf sc = "2020-02-13 10:30:00" Then
            val5 = "Thu 10:30"
        ElseIf sc = "2020-02-13 11:00:00" Then
            val5 = "Thu 11:00"
        ElseIf sc = "2020-02-13 11:30:00" Then
            val5 = "Thu 11:30"
        ElseIf sc = "2020-02-13 12:00:00" Then
            val5 = "Thu 12:00"
        ElseIf sc = "2020-02-13 12:30:00" Then
            val5 = "Thu 12:30"
        ElseIf sc = "2020-02-13 01:00:00" Then
            val5 = "Thu 1:00"
        ElseIf sc = "2020-02-13 01:30:00" Then
            val5 = "Thu 1:30"
        ElseIf sc = "2020-02-13 02:00:00" Then
            val5 = "Thu 2:00"
        ElseIf sc = "2020-02-13 02:30:00" Then
            val5 = "Thu 2:30"
        ElseIf sc = "2020-02-13 03:00:00" Then
            val5 = "Thu 3:00"
        ElseIf sc = "2020-02-13 03:30:00" Then
            val5 = "Thu 3:30"
        End If
        If sc = "2020-02-14 06:00:00" Then
            val5 = "F 6:00"
        ElseIf sc = "2020-02-14 06:30:00" Then
            val5 = "F 6:30"
        ElseIf sc = "2020-02-14 07:00:00" Then
            val5 = "F 7:00"
        ElseIf sc = "2020-02-14 07:30:00" Then
            val5 = "F 7:30"
        ElseIf sc = "2020-02-14 08:00:00" Then
            val5 = "F 8:00"
        ElseIf sc = "2020-02-14 08:30:00" Then
            val5 = "F 8:30"
        ElseIf sc = "2020-02-14 09:00:00" Then
            val5 = "F 9:00"
        ElseIf sc = "2020-02-14 09:30:00" Then
            val5 = "F 9:30"
        ElseIf sc = "2020-02-14 10:00:00" Then
            val5 = "F 10:00"
        ElseIf sc = "2020-02-14 10:30:00" Then
            val5 = "F 10:30"
        ElseIf sc = "2020-02-14 11:00:00" Then
            val5 = "F 11:00"
        ElseIf sc = "2020-02-14 11:30:00" Then
            val5 = "F 11:30"
        ElseIf sc = "2020-02-14 12:00:00" Then
            val5 = "F 12:00"
        ElseIf sc = "2020-02-14 12:30:00" Then
            val5 = "F 12:30"
        ElseIf sc = "2020-02-14 01:00:00" Then
            val5 = "F 1:00"
        ElseIf sc = "2020-02-14 01:30:00" Then
            val5 = "F 1:30"
        ElseIf sc = "2020-02-14 02:00:00" Then
            val5 = "F 2:00"
        ElseIf sc = "2020-02-14 02:30:00" Then
            val5 = "F 2:30"
        ElseIf sc = "2020-02-14 03:00:00" Then
            val5 = "F 3:00"
        ElseIf sc = "2020-02-14 03:30:00" Then
            val5 = "F 3:30"
        End If
    End Sub
    Private Sub row6_check()
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row6 As DataRow = tb.Rows(5)
        Dim sc As Date = row6.Item("time_start")
        If sc = "2020-02-10 06:00:00" Then
            val6 = "M 6:00"
        ElseIf sc = "2020-02-10 06:30:00" Then
            val6 = "M 6:30"
        ElseIf sc = "2020-02-10 07:00:00" Then
            val6 = "M 7:00"
        ElseIf sc = "2020-02-10 07:30:00" Then
            val6 = "M 7:30"
        ElseIf sc = "2020-02-10 08:00:00" Then
            val6 = "M 8:00"
        ElseIf sc = "2020-02-10 08:30:00" Then
            val6 = "M 8:30"
        ElseIf sc = "2020-02-10 09:00:00" Then
            val6 = "M 9:00"
        ElseIf sc = "2020-02-10 09:30:00" Then
            val6 = "M 9:30"
        ElseIf sc = "2020-02-10 10:00:00" Then
            val6 = "M 10:00"
        ElseIf sc = "2020-02-10 10:30:00" Then
            val6 = "M 10:30"
        ElseIf sc = "2020-02-10 11:00:00" Then
            val6 = "M 11:00"
        ElseIf sc = "2020-02-10 11:30:00" Then
            val6 = "M 11:30"
        ElseIf sc = "2020-02-10 12:00:00" Then
            val6 = "M 12:00"
        ElseIf sc = "2020-02-10 12:30:00" Then
            val6 = "M 12:30"
        ElseIf sc = "2020-02-10 01:00:00" Then
            val6 = "M 1:00"
        ElseIf sc = "2020-02-10 01:30:00" Then
            val6 = "M 1:30"
        ElseIf sc = "2020-02-10 02:00:00" Then
            val6 = "M 2:00"
        ElseIf sc = "2020-02-10 02:30:00" Then
            val6 = "M 2:30"
        ElseIf sc = "2020-02-10 03:00:00" Then
            val6 = "M 3:00"
        ElseIf sc = "2020-02-10 03:30:00" Then
            val6 = "M 3:30"
        End If
        If sc = "2020-02-11 06:00:00" Then
            val6 = "T 6:00"
        ElseIf sc = "2020-02-11 06:30:00" Then
            val6 = "T 6:30"
        ElseIf sc = "2020-02-11 07:00:00" Then
            val6 = "T 7:00"
        ElseIf sc = "2020-02-11 07:30:00" Then
            val6 = "T 7:30"
        ElseIf sc = "2020-02-11 08:00:00" Then
            val6 = "T 8:00"
        ElseIf sc = "2020-02-11 08:30:00" Then
            val6 = "T 8:30"
        ElseIf sc = "2020-02-11 09:00:00" Then
            val6 = "T 9:00"
        ElseIf sc = "2020-02-11 09:30:00" Then
            val6 = "T 9:30"
        ElseIf sc = "2020-02-11 10:00:00" Then
            val6 = "T 10:00"
        ElseIf sc = "2020-02-11 10:30:00" Then
            val6 = "T 10:30"
        ElseIf sc = "2020-02-11 11:00:00" Then
            val6 = "T 11:00"
        ElseIf sc = "2020-02-11 11:30:00" Then
            val6 = "T 11:30"
        ElseIf sc = "2020-02-11 12:00:00" Then
            val6 = "T 12:00"
        ElseIf sc = "2020-02-11 12:30:00" Then
            val6 = "T 12:30"
        ElseIf sc = "2020-02-11 01:00:00" Then
            val6 = "T 1:00"
        ElseIf sc = "2020-02-11 01:30:00" Then
            val6 = "T 1:30"
        ElseIf sc = "2020-02-11 02:00:00" Then
            val6 = "T 2:00"
        ElseIf sc = "2020-02-11 02:30:00" Then
            val6 = "T 2:30"
        ElseIf sc = "2020-02-11 03:00:00" Then
            val6 = "T 3:00"
        ElseIf sc = "2020-02-11 03:30:00" Then
            val6 = "T 3:30"
        End If
        If sc = "2020-02-12 06:00:00" Then
            val6 = "W 6:00"
        ElseIf sc = "2020-02-12 06:30:00" Then
            val6 = "W 6:30"
        ElseIf sc = "2020-02-12 07:00:00" Then
            val6 = "W 7:00"
        ElseIf sc = "2020-02-12 07:30:00" Then
            val6 = "W 7:30"
        ElseIf sc = "2020-02-12 08:00:00" Then
            val6 = "W 8:00"
        ElseIf sc = "2020-02-12 08:30:00" Then
            val6 = "W 8:30"
        ElseIf sc = "2020-02-12 09:00:00" Then
            val6 = "W 9:00"
        ElseIf sc = "2020-02-12 09:30:00" Then
            val6 = "W 9:30"
        ElseIf sc = "2020-02-12 10:00:00" Then
            val6 = "W 10:00"
        ElseIf sc = "2020-02-12 10:30:00" Then
            val6 = "W 10:30"
        ElseIf sc = "2020-02-12 11:00:00" Then
            val6 = "W 11:00"
        ElseIf sc = "2020-02-12 11:30:00" Then
            val6 = "W 11:30"
        ElseIf sc = "2020-02-12 12:00:00" Then
            val6 = "W 12:00"
        ElseIf sc = "2020-02-12 12:30:00" Then
            val6 = "W 12:30"
        ElseIf sc = "2020-02-12 01:00:00" Then
            val6 = "W 1:00"
        ElseIf sc = "2020-02-12 01:30:00" Then
            val6 = "W 1:30"
        ElseIf sc = "2020-02-12 02:00:00" Then
            val6 = "W 2:00"
        ElseIf sc = "2020-02-12 02:30:00" Then
            val6 = "W 2:30"
        ElseIf sc = "2020-02-12 03:00:00" Then
            val6 = "W 3:00"
        ElseIf sc = "2020-02-12 03:30:00" Then
            val6 = "W 3:30"
        End If
        If sc = "2020-02-13 06:00:00" Then
            val6 = "Thu 6:00"
        ElseIf sc = "2020-02-13 06:30:00" Then
            val6 = "Thu 6:30"
        ElseIf sc = "2020-02-13 07:00:00" Then
            val6 = "Thu 7:00"
        ElseIf sc = "2020-02-13 07:30:00" Then
            val6 = "Thu 7:30"
        ElseIf sc = "2020-02-13 08:00:00" Then
            val6 = "Thu 8:00"
        ElseIf sc = "2020-02-13 08:30:00" Then
            val6 = "Thu 8:30"
        ElseIf sc = "2020-02-13 09:00:00" Then
            val6 = "Thu 9:00"
        ElseIf sc = "2020-02-13 09:30:00" Then
            val6 = "Thu 9:30"
        ElseIf sc = "2020-02-13 10:00:00" Then
            val6 = "Thu 10:00"
        ElseIf sc = "2020-02-13 10:30:00" Then
            val6 = "Thu 10:30"
        ElseIf sc = "2020-02-13 11:00:00" Then
            val6 = "Thu 11:00"
        ElseIf sc = "2020-02-13 11:30:00" Then
            val6 = "Thu 11:30"
        ElseIf sc = "2020-02-13 12:00:00" Then
            val6 = "Thu 12:00"
        ElseIf sc = "2020-02-13 12:30:00" Then
            val6 = "Thu 12:30"
        ElseIf sc = "2020-02-13 01:00:00" Then
            val6 = "Thu 1:00"
        ElseIf sc = "2020-02-13 01:30:00" Then
            val6 = "Thu 1:30"
        ElseIf sc = "2020-02-13 02:00:00" Then
            val6 = "Thu 2:00"
        ElseIf sc = "2020-02-13 02:30:00" Then
            val6 = "Thu 2:30"
        ElseIf sc = "2020-02-13 03:00:00" Then
            val6 = "Thu 3:00"
        ElseIf sc = "2020-02-13 03:30:00" Then
            val6 = "Thu 3:30"
        End If
        If sc = "2020-02-14 06:00:00" Then
            val6 = "F 6:00"
        ElseIf sc = "2020-02-14 06:30:00" Then
            val6 = "F 6:30"
        ElseIf sc = "2020-02-14 07:00:00" Then
            val6 = "F 7:00"
        ElseIf sc = "2020-02-14 07:30:00" Then
            val6 = "F 7:30"
        ElseIf sc = "2020-02-14 08:00:00" Then
            val6 = "F 8:00"
        ElseIf sc = "2020-02-14 08:30:00" Then
            val6 = "F 8:30"
        ElseIf sc = "2020-02-14 09:00:00" Then
            val6 = "F 9:00"
        ElseIf sc = "2020-02-14 09:30:00" Then
            val6 = "F 9:30"
        ElseIf sc = "2020-02-14 10:00:00" Then
            val6 = "F 10:00"
        ElseIf sc = "2020-02-14 10:30:00" Then
            val6 = "F 10:30"
        ElseIf sc = "2020-02-14 11:00:00" Then
            val6 = "F 11:00"
        ElseIf sc = "2020-02-14 11:30:00" Then
            val6 = "F 11:30"
        ElseIf sc = "2020-02-14 12:00:00" Then
            val6 = "F 12:00"
        ElseIf sc = "2020-02-14 12:30:00" Then
            val6 = "F 12:30"
        ElseIf sc = "2020-02-14 01:00:00" Then
            val6 = "F 1:00"
        ElseIf sc = "2020-02-14 01:30:00" Then
            val6 = "F 1:30"
        ElseIf sc = "2020-02-14 02:00:00" Then
            val6 = "F 2:00"
        ElseIf sc = "2020-02-14 02:30:00" Then
            val6 = "F 2:30"
        ElseIf sc = "2020-02-14 03:00:00" Then
            val6 = "F 3:00"
        ElseIf sc = "2020-02-14 03:30:00" Then
            val6 = "F 3:30"
        End If
    End Sub
    Private Sub row7_check()
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row7 As DataRow = tb.Rows(6)
        Dim sc As Date = row7.Item("time_start")
        If sc = "2020-02-10 06:00:00" Then
            val7 = "M 6:00"
        ElseIf sc = "2020-02-10 06:30:00" Then
            val7 = "M 6:30"
        ElseIf sc = "2020-02-10 07:00:00" Then
            val7 = "M 7:00"
        ElseIf sc = "2020-02-10 07:30:00" Then
            val7 = "M 7:30"
        ElseIf sc = "2020-02-10 08:00:00" Then
            val7 = "M 8:00"
        ElseIf sc = "2020-02-10 08:30:00" Then
            val7 = "M 8:30"
        ElseIf sc = "2020-02-10 09:00:00" Then
            val7 = "M 9:00"
        ElseIf sc = "2020-02-10 09:30:00" Then
            val7 = "M 9:30"
        ElseIf sc = "2020-02-10 10:00:00" Then
            val7 = "M 10:00"
        ElseIf sc = "2020-02-10 10:30:00" Then
            val7 = "M 10:30"
        ElseIf sc = "2020-02-10 11:00:00" Then
            val7 = "M 11:00"
        ElseIf sc = "2020-02-10 11:30:00" Then
            val7 = "M 11:30"
        ElseIf sc = "2020-02-10 12:00:00" Then
            val7 = "M 12:00"
        ElseIf sc = "2020-02-10 12:30:00" Then
            val7 = "M 12:30"
        ElseIf sc = "2020-02-10 01:00:00" Then
            val7 = "M 1:00"
        ElseIf sc = "2020-02-10 01:30:00" Then
            val7 = "M 1:30"
        ElseIf sc = "2020-02-10 02:00:00" Then
            val7 = "M 2:00"
        ElseIf sc = "2020-02-10 02:30:00" Then
            val7 = "M 2:30"
        ElseIf sc = "2020-02-10 03:00:00" Then
            val7 = "M 3:00"
        ElseIf sc = "2020-02-10 03:30:00" Then
            val7 = "M 3:30"
        End If
        If sc = "2020-02-11 06:00:00" Then
            val7 = "T 6:00"
        ElseIf sc = "2020-02-11 06:30:00" Then
            val7 = "T 6:30"
        ElseIf sc = "2020-02-11 07:00:00" Then
            val7 = "T 7:00"
        ElseIf sc = "2020-02-11 07:30:00" Then
            val7 = "T 7:30"
        ElseIf sc = "2020-02-11 08:00:00" Then
            val7 = "T 8:00"
        ElseIf sc = "2020-02-11 08:30:00" Then
            val7 = "T 8:30"
        ElseIf sc = "2020-02-11 09:00:00" Then
            val7 = "T 9:00"
        ElseIf sc = "2020-02-11 09:30:00" Then
            val7 = "T 9:30"
        ElseIf sc = "2020-02-11 10:00:00" Then
            val7 = "T 10:00"
        ElseIf sc = "2020-02-11 10:30:00" Then
            val7 = "T 10:30"
        ElseIf sc = "2020-02-11 11:00:00" Then
            val7 = "T 11:00"
        ElseIf sc = "2020-02-11 11:30:00" Then
            val7 = "T 11:30"
        ElseIf sc = "2020-02-11 12:00:00" Then
            val7 = "T 12:00"
        ElseIf sc = "2020-02-11 12:30:00" Then
            val7 = "T 12:30"
        ElseIf sc = "2020-02-11 01:00:00" Then
            val7 = "T 1:00"
        ElseIf sc = "2020-02-11 01:30:00" Then
            val7 = "T 1:30"
        ElseIf sc = "2020-02-11 02:00:00" Then
            val7 = "T 2:00"
        ElseIf sc = "2020-02-11 02:30:00" Then
            val7 = "T 2:30"
        ElseIf sc = "2020-02-11 03:00:00" Then
            val7 = "T 3:00"
        ElseIf sc = "2020-02-11 03:30:00" Then
            val7 = "T 3:30"
        End If
        If sc = "2020-02-12 06:00:00" Then
            val7 = "W 6:00"
        ElseIf sc = "2020-02-12 06:30:00" Then
            val7 = "W 6:30"
        ElseIf sc = "2020-02-12 07:00:00" Then
            val7 = "W 7:00"
        ElseIf sc = "2020-02-12 07:30:00" Then
            val7 = "W 7:30"
        ElseIf sc = "2020-02-12 08:00:00" Then
            val7 = "W 8:00"
        ElseIf sc = "2020-02-12 08:30:00" Then
            val7 = "W 8:30"
        ElseIf sc = "2020-02-12 09:00:00" Then
            val7 = "W 9:00"
        ElseIf sc = "2020-02-12 09:30:00" Then
            val7 = "W 9:30"
        ElseIf sc = "2020-02-12 10:00:00" Then
            val7 = "W 10:00"
        ElseIf sc = "2020-02-12 10:30:00" Then
            val7 = "W 10:30"
        ElseIf sc = "2020-02-12 11:00:00" Then
            val7 = "W 11:00"
        ElseIf sc = "2020-02-12 11:30:00" Then
            val7 = "W 11:30"
        ElseIf sc = "2020-02-12 12:00:00" Then
            val7 = "W 12:00"
        ElseIf sc = "2020-02-12 12:30:00" Then
            val7 = "W 12:30"
        ElseIf sc = "2020-02-12 01:00:00" Then
            val7 = "W 1:00"
        ElseIf sc = "2020-02-12 01:30:00" Then
            val7 = "W 1:30"
        ElseIf sc = "2020-02-12 02:00:00" Then
            val7 = "W 2:00"
        ElseIf sc = "2020-02-12 02:30:00" Then
            val7 = "W 2:30"
        ElseIf sc = "2020-02-12 03:00:00" Then
            val7 = "W 3:00"
        ElseIf sc = "2020-02-12 03:30:00" Then
            val7 = "W 3:30"
        End If
        If sc = "2020-02-13 06:00:00" Then
            val7 = "Thu 6:00"
        ElseIf sc = "2020-02-13 06:30:00" Then
            val7 = "Thu 6:30"
        ElseIf sc = "2020-02-13 07:00:00" Then
            val7 = "Thu 7:00"
        ElseIf sc = "2020-02-13 07:30:00" Then
            val7 = "Thu 7:30"
        ElseIf sc = "2020-02-13 08:00:00" Then
            val7 = "Thu 8:00"
        ElseIf sc = "2020-02-13 08:30:00" Then
            val7 = "Thu 8:30"
        ElseIf sc = "2020-02-13 09:00:00" Then
            val7 = "Thu 9:00"
        ElseIf sc = "2020-02-13 09:30:00" Then
            val7 = "Thu 9:30"
        ElseIf sc = "2020-02-13 10:00:00" Then
            val7 = "Thu 10:00"
        ElseIf sc = "2020-02-13 10:30:00" Then
            val7 = "Thu 10:30"
        ElseIf sc = "2020-02-13 11:00:00" Then
            val7 = "Thu 11:00"
        ElseIf sc = "2020-02-13 11:30:00" Then
            val7 = "Thu 11:30"
        ElseIf sc = "2020-02-13 12:00:00" Then
            val7 = "Thu 12:00"
        ElseIf sc = "2020-02-13 12:30:00" Then
            val7 = "Thu 12:30"
        ElseIf sc = "2020-02-13 01:00:00" Then
            val7 = "Thu 1:00"
        ElseIf sc = "2020-02-13 01:30:00" Then
            val7 = "Thu 1:30"
        ElseIf sc = "2020-02-13 02:00:00" Then
            val7 = "Thu 2:00"
        ElseIf sc = "2020-02-13 02:30:00" Then
            val7 = "Thu 2:30"
        ElseIf sc = "2020-02-13 03:00:00" Then
            val7 = "Thu 3:00"
        ElseIf sc = "2020-02-13 03:30:00" Then
            val7 = "Thu 3:30"
        End If
        If sc = "2020-02-14 06:00:00" Then
            val7 = "F 6:00"
        ElseIf sc = "2020-02-14 06:30:00" Then
            val7 = "F 6:30"
        ElseIf sc = "2020-02-14 07:00:00" Then
            val7 = "F 7:00"
        ElseIf sc = "2020-02-14 07:30:00" Then
            val7 = "F 7:30"
        ElseIf sc = "2020-02-14 08:00:00" Then
            val7 = "F 8:00"
        ElseIf sc = "2020-02-14 08:30:00" Then
            val7 = "F 8:30"
        ElseIf sc = "2020-02-14 09:00:00" Then
            val7 = "F 9:00"
        ElseIf sc = "2020-02-14 09:30:00" Then
            val7 = "F 9:30"
        ElseIf sc = "2020-02-14 10:00:00" Then
            val7 = "F 10:00"
        ElseIf sc = "2020-02-14 10:30:00" Then
            val7 = "F 10:30"
        ElseIf sc = "2020-02-14 11:00:00" Then
            val7 = "F 11:00"
        ElseIf sc = "2020-02-14 11:30:00" Then
            val7 = "F 11:30"
        ElseIf sc = "2020-02-14 12:00:00" Then
            val7 = "F 12:00"
        ElseIf sc = "2020-02-14 12:30:00" Then
            val7 = "F 12:30"
        ElseIf sc = "2020-02-14 01:00:00" Then
            val7 = "F 1:00"
        ElseIf sc = "2020-02-14 01:30:00" Then
            val7 = "F 1:30"
        ElseIf sc = "2020-02-14 02:00:00" Then
            val7 = "F 2:00"
        ElseIf sc = "2020-02-14 02:30:00" Then
            val7 = "F 2:30"
        ElseIf sc = "2020-02-14 03:00:00" Then
            val7 = "F 3:00"
        ElseIf sc = "2020-02-14 03:30:00" Then
            val7 = "F 3:30"
        End If
    End Sub
    Private Sub row8_check()
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row8 As DataRow = tb.Rows(7)
        Dim sc As Date = row8.Item("time_start")
        If sc = "2020-02-10 06:00:00" Then
            val8 = "M 6:00"
        ElseIf sc = "2020-02-10 06:30:00" Then
            val8 = "M 6:30"
        ElseIf sc = "2020-02-10 07:00:00" Then
            val8 = "M 7:00"
        ElseIf sc = "2020-02-10 07:30:00" Then
            val8 = "M 7:30"
        ElseIf sc = "2020-02-10 08:00:00" Then
            val8 = "M 8:00"
        ElseIf sc = "2020-02-10 08:30:00" Then
            val8 = "M 8:30"
        ElseIf sc = "2020-02-10 09:00:00" Then
            val8 = "M 9:00"
        ElseIf sc = "2020-02-10 09:30:00" Then
            val8 = "M 9:30"
        ElseIf sc = "2020-02-10 10:00:00" Then
            val8 = "M 10:00"
        ElseIf sc = "2020-02-10 10:30:00" Then
            val8 = "M 10:30"
        ElseIf sc = "2020-02-10 11:00:00" Then
            val8 = "M 11:00"
        ElseIf sc = "2020-02-10 11:30:00" Then
            val8 = "M 11:30"
        ElseIf sc = "2020-02-10 12:00:00" Then
            val8 = "M 12:00"
        ElseIf sc = "2020-02-10 12:30:00" Then
            val8 = "M 12:30"
        ElseIf sc = "2020-02-10 01:00:00" Then
            val8 = "M 1:00"
        ElseIf sc = "2020-02-10 01:30:00" Then
            val8 = "M 1:30"
        ElseIf sc = "2020-02-10 02:00:00" Then
            val8 = "M 2:00"
        ElseIf sc = "2020-02-10 02:30:00" Then
            val8 = "M 2:30"
        ElseIf sc = "2020-02-10 03:00:00" Then
            val8 = "M 3:00"
        ElseIf sc = "2020-02-10 03:30:00" Then
            val8 = "M 3:30"
        End If
        If sc = "2020-02-11 06:00:00" Then
            val8 = "T 6:00"
        ElseIf sc = "2020-02-11 06:30:00" Then
            val8 = "T 6:30"
        ElseIf sc = "2020-02-11 07:00:00" Then
            val8 = "T 7:00"
        ElseIf sc = "2020-02-11 07:30:00" Then
            val8 = "T 7:30"
        ElseIf sc = "2020-02-11 08:00:00" Then
            val8 = "T 8:00"
        ElseIf sc = "2020-02-11 08:30:00" Then
            val8 = "T 8:30"
        ElseIf sc = "2020-02-11 09:00:00" Then
            val8 = "T 9:00"
        ElseIf sc = "2020-02-11 09:30:00" Then
            val8 = "T 9:30"
        ElseIf sc = "2020-02-11 10:00:00" Then
            val8 = "T 10:00"
        ElseIf sc = "2020-02-11 10:30:00" Then
            val8 = "T 10:30"
        ElseIf sc = "2020-02-11 11:00:00" Then
            val8 = "T 11:00"
        ElseIf sc = "2020-02-11 11:30:00" Then
            val8 = "T 11:30"
        ElseIf sc = "2020-02-11 12:00:00" Then
            val8 = "T 12:00"
        ElseIf sc = "2020-02-11 12:30:00" Then
            val8 = "T 12:30"
        ElseIf sc = "2020-02-11 01:00:00" Then
            val8 = "T 1:00"
        ElseIf sc = "2020-02-11 01:30:00" Then
            val8 = "T 1:30"
        ElseIf sc = "2020-02-11 02:00:00" Then
            val8 = "T 2:00"
        ElseIf sc = "2020-02-11 02:30:00" Then
            val8 = "T 2:30"
        ElseIf sc = "2020-02-11 03:00:00" Then
            val8 = "T 3:00"
        ElseIf sc = "2020-02-11 03:30:00" Then
            val8 = "T 3:30"
        End If
        If sc = "2020-02-12 06:00:00" Then
            val8 = "W 6:00"
        ElseIf sc = "2020-02-12 06:30:00" Then
            val8 = "W 6:30"
        ElseIf sc = "2020-02-12 07:00:00" Then
            val8 = "W 7:00"
        ElseIf sc = "2020-02-12 07:30:00" Then
            val8 = "W 7:30"
        ElseIf sc = "2020-02-12 08:00:00" Then
            val8 = "W 8:00"
        ElseIf sc = "2020-02-12 08:30:00" Then
            val8 = "W 8:30"
        ElseIf sc = "2020-02-12 09:00:00" Then
            val8 = "W 9:00"
        ElseIf sc = "2020-02-12 09:30:00" Then
            val8 = "W 9:30"
        ElseIf sc = "2020-02-12 10:00:00" Then
            val8 = "W 10:00"
        ElseIf sc = "2020-02-12 10:30:00" Then
            val8 = "W 10:30"
        ElseIf sc = "2020-02-12 11:00:00" Then
            val8 = "W 11:00"
        ElseIf sc = "2020-02-12 11:30:00" Then
            val8 = "W 11:30"
        ElseIf sc = "2020-02-12 12:00:00" Then
            val8 = "W 12:00"
        ElseIf sc = "2020-02-12 12:30:00" Then
            val8 = "W 12:30"
        ElseIf sc = "2020-02-12 01:00:00" Then
            val8 = "W 1:00"
        ElseIf sc = "2020-02-12 01:30:00" Then
            val8 = "W 1:30"
        ElseIf sc = "2020-02-12 02:00:00" Then
            val8 = "W 2:00"
        ElseIf sc = "2020-02-12 02:30:00" Then
            val8 = "W 2:30"
        ElseIf sc = "2020-02-12 03:00:00" Then
            val8 = "W 3:00"
        ElseIf sc = "2020-02-12 03:30:00" Then
            val8 = "W 3:30"
        End If
        If sc = "2020-02-13 06:00:00" Then
            val8 = "Thu 6:00"
        ElseIf sc = "2020-02-13 06:30:00" Then
            val8 = "Thu 6:30"
        ElseIf sc = "2020-02-13 07:00:00" Then
            val8 = "Thu 7:00"
        ElseIf sc = "2020-02-13 07:30:00" Then
            val8 = "Thu 7:30"
        ElseIf sc = "2020-02-13 08:00:00" Then
            val8 = "Thu 8:00"
        ElseIf sc = "2020-02-13 08:30:00" Then
            val8 = "Thu 8:30"
        ElseIf sc = "2020-02-13 09:00:00" Then
            val8 = "Thu 9:00"
        ElseIf sc = "2020-02-13 09:30:00" Then
            val8 = "Thu 9:30"
        ElseIf sc = "2020-02-13 10:00:00" Then
            val8 = "Thu 10:00"
        ElseIf sc = "2020-02-13 10:30:00" Then
            val8 = "Thu 10:30"
        ElseIf sc = "2020-02-13 11:00:00" Then
            val8 = "Thu 11:00"
        ElseIf sc = "2020-02-13 11:30:00" Then
            val8 = "Thu 11:30"
        ElseIf sc = "2020-02-13 12:00:00" Then
            val8 = "Thu 12:00"
        ElseIf sc = "2020-02-13 12:30:00" Then
            val8 = "Thu 12:30"
        ElseIf sc = "2020-02-13 01:00:00" Then
            val8 = "Thu 1:00"
        ElseIf sc = "2020-02-13 01:30:00" Then
            val8 = "Thu 1:30"
        ElseIf sc = "2020-02-13 02:00:00" Then
            val8 = "Thu 2:00"
        ElseIf sc = "2020-02-13 02:30:00" Then
            val8 = "Thu 2:30"
        ElseIf sc = "2020-02-13 03:00:00" Then
            val8 = "Thu 3:00"
        ElseIf sc = "2020-02-13 03:30:00" Then
            val8 = "Thu 3:30"
        End If
        If sc = "2020-02-14 06:00:00" Then
            val8 = "F 6:00"
        ElseIf sc = "2020-02-14 06:30:00" Then
            val8 = "F 6:30"
        ElseIf sc = "2020-02-14 07:00:00" Then
            val8 = "F 7:00"
        ElseIf sc = "2020-02-14 07:30:00" Then
            val8 = "F 7:30"
        ElseIf sc = "2020-02-14 08:00:00" Then
            val8 = "F 8:00"
        ElseIf sc = "2020-02-14 08:30:00" Then
            val8 = "F 8:30"
        ElseIf sc = "2020-02-14 09:00:00" Then
            val8 = "F 9:00"
        ElseIf sc = "2020-02-14 09:30:00" Then
            val8 = "F 9:30"
        ElseIf sc = "2020-02-14 10:00:00" Then
            val8 = "F 10:00"
        ElseIf sc = "2020-02-14 10:30:00" Then
            val8 = "F 10:30"
        ElseIf sc = "2020-02-14 11:00:00" Then
            val8 = "F 11:00"
        ElseIf sc = "2020-02-14 11:30:00" Then
            val8 = "F 11:30"
        ElseIf sc = "2020-02-14 12:00:00" Then
            val8 = "F 12:00"
        ElseIf sc = "2020-02-14 12:30:00" Then
            val8 = "F 12:30"
        ElseIf sc = "2020-02-14 01:00:00" Then
            val8 = "F 1:00"
        ElseIf sc = "2020-02-14 01:30:00" Then
            val8 = "F 1:30"
        ElseIf sc = "2020-02-14 02:00:00" Then
            val8 = "F 2:00"
        ElseIf sc = "2020-02-14 02:30:00" Then
            val8 = "F 2:30"
        ElseIf sc = "2020-02-14 03:00:00" Then
            val8 = "F 3:00"
        ElseIf sc = "2020-02-14 03:30:00" Then
            val8 = "F 3:30"
        End If
    End Sub
    Private Sub Selectionsect_load()

        cmd = New MySqlCommand("select count(id_Prof) as 'num' from schedule_tbl where id_Prof='" + selectid + "' and sy='" + SelectSt.schedsy_combo.Text + "' and semestral_sche='" + SelectSt.semester_combo.Text + "'", scon.GetConnection)
        scon.OpenConnection()
        read = cmd.ExecuteReader

        If read.HasRows Then

            Try

                Dim num As String
                read.Read()
                num = read.Item("num")



                If num = 1 Then
                    read.Close()
                    scon.CloseConnection()
                    scon.OpenConnection()


                    Row1_check()

                    With slot_sched_1
                        .Enabled = True
                        .Text = val1
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                End If
                If num = 2 Then
                    read.Close()
                    scon.CloseConnection()
                    scon.OpenConnection()


                    'row 1
                    Row1_check()
                    'row 2
                    Row2_check()
                    With slot_sched_1
                        .Enabled = True
                        .Text = val1
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_2
                        .Enabled = True
                        .Text = val2
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                End If
                If num = 3 Then
                    read.Close()
                    scon.CloseConnection()
                    scon.OpenConnection()
                    'row 1
                    Row1_check()
                    'row 2
                    Row2_check()
                    'row 3
                    row4_check()
                    With slot_sched_1
                        .Enabled = True
                        .Text = val1
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_2
                        .Enabled = True
                        .Text = val2
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_3
                        .Enabled = True
                        .Text = val3
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                End If
                If num = 4 Then
                    read.Close()
                    scon.CloseConnection()
                    scon.OpenConnection()
                    'row 1
                    Row1_check()
                    'row 2
                    Row2_check()
                    'row 3
                    row4_check()

                    row4_check()
                    With slot_sched_1
                        .Enabled = True
                        .Text = val1
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_2
                        .Enabled = True
                        .Text = val2
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_3
                        .Enabled = True
                        .Text = val3
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_4
                        .Enabled = True
                        .Text = val4
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                End If
                If num = 5 Then
                    read.Close()
                    scon.CloseConnection()
                    scon.OpenConnection()
                    Row1_check()
                    'row 2
                    Row2_check()
                    'row 3
                    row4_check()

                    row4_check()

                    row5_check()
                    With slot_sched_1
                        .Enabled = True
                        .Text = val1
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_2
                        .Enabled = True
                        .Text = val2
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_3
                        .Enabled = True
                        .Text = val3
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_4
                        .Enabled = True
                        .Text = val4
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_5
                        .Enabled = True
                        .Text = val5
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                End If
                If num = 6 Then
                    read.Close()
                    scon.CloseConnection()
                    scon.OpenConnection()
                    Row1_check()
                    'row 2
                    Row2_check()
                    'row 3
                    row4_check()

                    row4_check()

                    row5_check()

                    row6_check()
                    With slot_sched_1
                        .Enabled = True
                        .Text = val1
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_2
                        .Enabled = True
                        .Text = val2
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_3
                        .Enabled = True
                        .Text = val3
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_4
                        .Enabled = True
                        .Text = val4
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_5
                        .Enabled = True
                        .Text = val5
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                    With slot_sched_6
                        .Enabled = True
                        .Text = val6
                        .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                        .OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                        .OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                        .BaseColor = Color.FromArgb(200, 39, 73, 109)
                        .ForeColor = Color.FromArgb(200, 170, 225, 238)
                    End With
                End If

                'If num = 7 Then
                '        read.Close()
                '        scon.CloseConnection()
                '        scon.OpenConnection()
                '        Row1_check()
                '        'row 2
                '        Row2_check()
                '        'row 3
                '        row4_check()

                '        row4_check()

                '        row5_check()

                '        row6_check()

                '        row7_check()
                '        With slot_sched_1
                '            .Enabled = True
                '            .Text = val1
                '.OnHoverBaseColor = Color.FromArgb(200, 39, 73, 109)
                '.OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                '.OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                '.BaseColor = Color.FromArgb(200, 39, 73, 109)
                '.ForeColor = Color.FromArgb(200, 170, 225, 238)
                '        End With
                '        With slot_sched_2
                '            .Enabled = True
                '            .Text = val2
                '    .OnHoverBaseColor = Color.FromArgb(200, 0, 168, 204)
                '.OnHoverBorderColor = Color.FromArgb(200, 39, 73, 109)
                '.OnHoverForeColor = Color.FromArgb(200, 226, 245, 249)
                '.BaseColor = Color.FromArgb(200, 39, 73, 109)
                '.ForeColor = Color.FromArgb(200, 170, 225, 238)
                '        End With
                '        With slot_sched_3
                '            .Enabled = True
                '            .Text = val3
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_4
                '            .Enabled = True
                '            .Text = val4
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_5
                '            .Enabled = True
                '            .Text = val5
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_6
                '            .Enabled = True
                '            .Text = val6
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_7
                '            .Enabled = True
                '            .Text = val7
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '    End If
                '    If num = 8 Then

                '        read.Close()
                '        scon.CloseConnection()
                '        scon.OpenConnection()
                '        Row1_check()
                '        'row 2
                '        Row2_check()
                '        'row 3
                '        row4_check()

                '        row4_check()

                '        row5_check()

                '        row6_check()

                '        row7_check()

                '        row8_check()

                '        With slot_sched_1
                '            .Enabled = True
                '            .Text = val1
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_2
                '            .Enabled = True
                '            .Text = val2
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_3
                '            .Enabled = True
                '            .Text = val3
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_5
                '            .Enabled = True
                '            .Text = val5
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_6
                '            .Enabled = True
                '            .Text = val6
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_7
                '            .Enabled = True
                '            .Text = val7
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_8
                '            .Enabled = True
                '            .Text = val8
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With
                '        With slot_sched_4
                '            .Enabled = True
                '            .Text = val4
                '            .OnHoverBaseColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverBorderColor = Color.FromArgb(0, 39, 73, 109)
                '            .OnHoverForeColor = Color.FromArgb(0, 226, 245, 249)
                '            .BaseColor = Color.FromArgb(0, 226, 245, 249)
                '            .ForeColor = Color.FromArgb(0, 226, 245, 249)
                '        End With

                'End If
                'nothing
                read.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MsgBox("welcome")
        End If
    End Sub

    Private Sub slot_sched_1_Click(sender As Object, e As EventArgs) Handles slot_sched_1.Click
        'While (slot_sched_1.Width > 120)
        '    slot_sched_1.Width -= 2
        'End While

        del_bot_sched1.BringToFront()
        edit_bot_sched1.BringToFront()

        del_bot_sched1.Enabled = True
        edit_bot_sched1.Enabled = True
    End Sub
    Private Sub slot_sched_1_Leave(sender As Object, e As EventArgs) Handles slot_sched_1.Leave
        del_bot_sched1.Hide()
        edit_bot_sched1.Hide()

        del_bot_sched1.Enabled = False
        edit_bot_sched1.Enabled = False
    End Sub


    Private Sub slot_sched_2_Click(sender As Object, e As EventArgs) Handles slot_sched_2.Click
        'While (slot_sched_2.Width > 120)
        '    slot_sched_2.Width -= 2
        'End While
        del_bot_sched2.BringToFront()
        edit_bot_sched2.BringToFront()
        del_bot_sched2.Enabled = True
        edit_bot_sched2.Enabled = True
    End Sub
    Private Sub slot_sched_2_Leave(sender As Object, e As EventArgs) Handles slot_sched_2.Leave
        del_bot_sched2.Hide()
        edit_bot_sched2.Hide()

        del_bot_sched2.Enabled = False
        edit_bot_sched2.Enabled = False
    End Sub


    Private Sub slot_sched_3_Click(sender As Object, e As EventArgs) Handles slot_sched_3.Click
        'While (slot_sched_3.Width > 120)
        '    slot_sched_3.Width -= 2
        'End While
        del_bot_sched3.BringToFront()
        edit_bot_sched3.BringToFront()
        del_bot_sched3.Enabled = True
        edit_bot_sched3.Enabled = True
    End Sub
    Private Sub slot_sched_3_Leave(sender As Object, e As EventArgs) Handles slot_sched_3.Leave
        del_bot_sched3.Hide()
        edit_bot_sched3.Hide()

        del_bot_sched3.Enabled = False
        edit_bot_sched3.Enabled = False
    End Sub


    Private Sub slot_sched_4_Click(sender As Object, e As EventArgs) Handles slot_sched_4.Click
        'While (slot_sched_4.Width > 120)
        '    slot_sched_4.Width -= 2
        'End While
        del_bot_sched4.BringToFront()
        edit_bot_sched4.BringToFront()
        del_bot_sched4.Enabled = True
        edit_bot_sched4.Enabled = True
    End Sub
    Private Sub slot_sched_4_Leave(sender As Object, e As EventArgs) Handles slot_sched_4.Leave
        del_bot_sched4.Hide()
        edit_bot_sched4.Hide()

        del_bot_sched4.Enabled = False
        edit_bot_sched4.Enabled = False
    End Sub


    Private Sub slot_sched_5_Click(sender As Object, e As EventArgs) Handles slot_sched_5.Click
        'While (slot_sched_5.Width > 120)
        '    slot_sched_5.Width -= 2
        'End While
        del_bot_sched5.BringToFront()
        edit_bot_sched5.BringToFront()
        del_bot_sched5.Enabled = True
        edit_bot_sched5.Enabled = True
    End Sub
    Private Sub slot_sched_5_Leave(sender As Object, e As EventArgs) Handles slot_sched_5.Leave
        del_bot_sched5.Hide()
        edit_bot_sched5.Hide()

        del_bot_sched5.Enabled = False
        edit_bot_sched5.Enabled = False
    End Sub

    Private Sub slot_sched_6_Click(sender As Object, e As EventArgs) Handles slot_sched_6.Click
        'While (slot_sched_6.Width > 120)
        '    slot_sched_6.Width -= 2
        'End While

        del_bot_sched6.BringToFront()
        edit_bot_sched6.BringToFront()
        del_bot_sched6.Enabled = True
        edit_bot_sched6.Enabled = True
    End Sub
    Private Sub slot_sched_6_Leave(sender As Object, e As EventArgs) Handles slot_sched_6.Leave
        del_bot_sched6.Hide()
        edit_bot_sched6.Hide()

        del_bot_sched6.Enabled = False
        edit_bot_sched6.Enabled = False
    End Sub
    Private Sub disable_to()
        del_bot_sched1.Enabled = False
        edit_bot_sched1.Enabled = False
        del_bot_sched2.Enabled = False
        edit_bot_sched2.Enabled = False
        del_bot_sched3.Enabled = False
        edit_bot_sched3.Enabled = False
        del_bot_sched4.Enabled = False
        edit_bot_sched4.Enabled = False
        del_bot_sched6.Enabled = False
        edit_bot_sched6.Enabled = False
        del_bot_sched5.Enabled = False
        edit_bot_sched5.Enabled = False
        GunaPanel1.Hide()
    End Sub
    'Private Sub slot_sched_7_Click(sender As Object, e As EventArgs) Handles slot_sched_7.Click
    '    While (slot_sched_7.Width > 120)
    '        slot_sched_7.Width -= 2
    '    End While
    '    del_bot_sched7.Enabled = True
    '    edit_bot_sched7.Enabled = True
    'End Sub

    'Private Sub slot_sched_8_Click(sender As Object, e As EventArgs) Handles slot_sched_8.Click
    '    While (slot_sched_8.Width > 120)
    '        slot_sched_8.Width -= 2
    '    End While
    '    del_bot_sched8.Enabled = True
    '    edit_bot_sched8.Enabled = True
    'End Sub
    'controls for del
    Private Sub del_bot_sched1_Click(sender As Object, e As EventArgs) Handles del_bot_sched1.Click

        Try
            read.Close()
            scon.CloseConnection()
            scon.OpenConnection()
            adapt = New MySqlDataAdapter(s, scon.GetConnection)
            tb = New DataTable
            adapt.Fill(tb)
            Dim row1 As DataRow = tb.Rows(0)
            row1.Delete()
            MsgBox("Deleted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub del_bot_sched2_Click(sender As Object, e As EventArgs) Handles del_bot_sched2.Click
        Try
            read.Close()
            scon.CloseConnection()
            scon.OpenConnection()
            adapt = New MySqlDataAdapter(s, scon.GetConnection)
            tb = New DataTable
            adapt.Fill(tb)
            Dim row2 As DataRow = tb.Rows(1)
            row2.Delete()
            MsgBox("Deleted Successfully")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub del_bot_sched3_Click(sender As Object, e As EventArgs) Handles del_bot_sched3.Click
        Try
            read.Close()
            scon.CloseConnection()
            scon.OpenConnection()
            adapt = New MySqlDataAdapter(s, scon.GetConnection)
            tb = New DataTable
            adapt.Fill(tb)
            Dim row4 As DataRow = tb.Rows(2)
            row4.Delete()
            MsgBox("Deleted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub del_bot_sched4_Click(sender As Object, e As EventArgs) Handles del_bot_sched4.Click
        Try
            read.Close()
            scon.CloseConnection()
            scon.OpenConnection()
            adapt = New MySqlDataAdapter(s, scon.GetConnection)
            tb = New DataTable
            adapt.Fill(tb)
            Dim row4 As DataRow = tb.Rows(3)
            row4.Delete()
            MsgBox("Deleted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub del_bot_sched5_Click(sender As Object, e As EventArgs) Handles del_bot_sched5.Click
        Try
            read.Close()
            scon.CloseConnection()
            scon.OpenConnection()
            adapt = New MySqlDataAdapter(s, scon.GetConnection)
            tb = New DataTable
            adapt.Fill(tb)
            Dim row5 As DataRow = tb.Rows(4)
            row5.Delete()
            MsgBox("Deleted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub del_bot_sched6_Click(sender As Object, e As EventArgs) Handles del_bot_sched6.Click
        Try

            read.Close()
            scon.CloseConnection()
            scon.OpenConnection()
            adapt = New MySqlDataAdapter(s, scon.GetConnection)
            tb = New DataTable
            adapt.Fill(tb)
            Dim row6 As DataRow = tb.Rows(5)
            row6.Delete()
            MsgBox("Deleted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub del_bot_sched7_Click(sender As Object, e As EventArgs) Handles del_bot_sched7.Click, GunaImageButton4.Click
        Try
            read.Close()
            scon.CloseConnection()
            scon.OpenConnection()
            adapt = New MySqlDataAdapter(s, scon.GetConnection)
            tb = New DataTable
            adapt.Fill(tb)
            Dim row7 As DataRow = tb.Rows(6)
            row7.Delete()
            MsgBox("Deleted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub del_bot_sched8_Click(sender As Object, e As EventArgs) Handles del_bot_sched8.Click, GunaImageButton3.Click
        Try
            read.Close()
            scon.CloseConnection()
            scon.OpenConnection()
            adapt = New MySqlDataAdapter(s, scon.GetConnection)
            tb = New DataTable
            adapt.Fill(tb)
            Dim row8 As DataRow = tb.Rows(7)
            row8.Delete()
            MsgBox("Deleted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Edit Button of Schedule Controls==============================
    Dim time_start As Date
    Dim time_end As Date
    Private Sub checkDateToInsert()
        'Monday start
        If time_start = "2020-02-10 06:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "6:00 AM"
            If time_end = "2020-02-10 07:00:00" Then
                time_end_combo.Text = "7:00 AM"
            ElseIf time_end = "2020-02-10 08:00:00" Then
                time_end_combo.Text = "8:00 AM"
            End If
        ElseIf time_start = "2020-02-10 06:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "6:30 AM"
            If time_end = "2020-02-10 07:30:00" Then
                time_end_combo.Text = "7:30 AM"
            ElseIf time_end = "2020-02-10 08:30:00" Then
                time_end_combo.Text = "8:30 AM"
            End If
        ElseIf time_start = "2020-02-10 07:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "7:00 AM"
            If time_end = "2020-02-10 08:00:00" Then
                time_end_combo.Text = "8:00 AM"
            ElseIf time_end = "2020-02-10 09:00:00" Then
                time_end_combo.Text = "9:00 AM"
            End If
        ElseIf time_start = "2020-02-10 07:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "7:30 AM"
            If time_end = "2020-02-10 08:30:00" Then

                time_end_combo.Text = "8:30 AM"
            ElseIf time_end = "2020-02-10 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            End If
        ElseIf time_start = "2020-02-10 08:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "8:00 AM"
            If time_end = "2020-02-10 09:00:00" Then

                time_end_combo.Text = "9:00 AM"
            ElseIf time_end = "2020-02-10 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            End If
        ElseIf time_start = "2020-02-10 08:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "8:30 AM"
            If time_end = "2020-02-10 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            ElseIf time_end = "2020-02-10 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            End If
        ElseIf time_start = "2020-02-10 09:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "9:00 AM"
            If time_end = "2020-02-10 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            ElseIf time_end = "2020-02-10 11:00:00" Then
                time_end_combo.Text = "11:00 AM"
            End If
        ElseIf time_start = "2020-02-10 09:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "9:30 AM"
            If time_end = "2020-02-10 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            ElseIf time_end = "2020-02-10 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            End If
        ElseIf time_start = "2020-02-10 10:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "10:00 AM"
            If time_end = "2020-02-10 11:00:00" Then
                time_end_combo.Text = "11:00 AM"

            ElseIf time_end = "2020-02-10 12:00:00" Then
                time_end_combo.Text = "12:00 PM"

            End If
        End If
        If time_start = "2020-02-10 10:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "10:30 AM"
            If time_end = "2020-02-10 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            ElseIf time_end = "2020-02-10 12:30:00" Then
                time_end_combo.Text = "12:30 AM"
            End If
        ElseIf time_start = "2020-02-10 11:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "11:00 AM"
            If time_end = "2020-02-10 12:00:00" Then
                time_end_combo.Text = "12:00 PM"
            ElseIf time_end = "2020-02-10 13:00:00" Then
                time_end_combo.Text = "1:00 PM"

            End If
        ElseIf time_start = "2020-02-10 11:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "11:30 AM"
            If time_end = "2020-02-10 12:30:00" Then
                time_end_combo.Text = "12:30 PM"
            ElseIf time_end = "2020-02-10 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            End If
        ElseIf time_start = "2020-02-10 12:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "12:00 PM"
            If time_end = "2020-02-10 13:00:00" Then
                time_end_combo.Text = "1:00 PM"
            ElseIf time_end = "2020-02-10 14:00:00" Then
                time_end_combo.Text = "2:00 PM"
            End If
        ElseIf time_start = "2020-02-10 12:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "12:30 PM"
            If time_end = "2020-02-10 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            ElseIf time_end = "2020-02-10 14:30:00" Then
                time_end_combo.Text = "2:30 PM"
            End If
        ElseIf time_start = "2020-02-10 13:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "1:00 PM"
            If time_end = "2020-02-10 14:00:00" Then
                time_end_combo.Text = "2:00 PM"
            ElseIf time_end = "2020-02-10 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            End If
        ElseIf time_start = "2020-02-10 13:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "1:30 PM"
            If time_end = "2020-02-10 14:30:00" Then
                time_end_combo.Text = "2:30 PM"
            ElseIf time_end = "2020-02-10 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            End If
        ElseIf time_start = "2020-02-10 14:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "2:00 PM"
            If time_end = "2020-02-10 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            ElseIf time_end = "2020-02-10 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            End If
        ElseIf time_start = "2020-02-10 14:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "2:30 PM"
            If time_end = "2020-02-10 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            ElseIf time_end = "2020-02-10 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            End If
        End If
        If time_start = "2020-02-10 15:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "3:00 PM"
            If time_end = "2020-02-10 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            ElseIf time_end = "2020-02-10 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            End If
        End If
        If time_start = "2020-02-10 15:30:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "3:30 PM"
            If time_end = "2020-02-10 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            ElseIf time_end = "2020-02-10 17:30:00" Then
                time_end_combo.Text = "5:30 PM"
            End If
        End If
        If time_start = "2020-02-10 16:00:00" Then
            day_combo.Text = "Monday"
            time_combo.Text = "4:00 PM"
            If time_end = "2020-02-10 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            ElseIf time_end = "2020-02-10 18:00:00" Then
                time_end_combo.Text = "6:00 PM"
            End If
        End If



        'tuesday start-----------------------------------------------


        If time_start = "2020-02-11 06:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "6:00 AM"
            If time_end = "2020-02-11 07:00:00" Then
                time_end_combo.Text = "7:00 AM"
            ElseIf time_end = "2020-02-11 08:00:00" Then
                time_end_combo.Text = "8:00 AM"

            End If
        End If
        If time_start = "2020-02-11 06:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "6:30 AM"
            If time_end = "2020-02-11 07:30:00" Then
                time_end_combo.Text = "7:30 AM"
            ElseIf time_end = "2020-02-11 08:30:00" Then
                time_end_combo.Text = "8:30 AM"
            End If
        End If
        If time_start = "2020-02-11 07:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "7:00 AM"
            If time_end = "2020-02-11 08:00:00" Then
                time_end_combo.Text = "8:00 AM"
            ElseIf time_end = "2020-02-11 09:00:00" Then
                time_end_combo.Text = "9:00 AM"
            End If
        End If


        If time_start = "2020-02-11 07:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "7:30 AM"
            If time_end = "2020-02-11 08:30:00" Then

                time_end_combo.Text = "8:30 AM"
            ElseIf time_end = "2020-02-11 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            End If
        End If
        If time_start = "2020-02-11 08:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "8:00 AM"
            If time_end = "2020-02-11 09:00:00" Then

                time_end_combo.Text = "9:00 AM"
            ElseIf time_end = "2020-02-11 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            End If
        End If
        If time_start = "2020-02-11 08:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "8:30 AM"
            If time_end = "2020-02-11 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            ElseIf time_end = "2020-02-11 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            End If
        End If
        If time_start = "2020-02-11 09:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "9:00 AM"
            If time_end = "2020-02-11 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            ElseIf time_end = "2020-02-11 11:00:00" Then
                time_end_combo.Text = "11:00 AM"
            End If
        End If
        If time_start = "2020-02-11 09:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "9:30 AM"
            If time_end = "2020-02-11 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            ElseIf time_end = "2020-02-11 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            End If
        End If
        If time_start = "2020-02-11 10:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "10:00 AM"
            If time_end = "2020-02-11 11:00:00" Then
                time_end_combo.Text = "11:00 AM"

            ElseIf time_end = "2020-02-11 12:00:00" Then
                time_end_combo.Text = "12:00 PM"

            End If
        End If
        If time_start = "2020-02-11 10:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "10:30 AM"
            If time_end = "2020-02-11 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            ElseIf time_end = "2020-02-11 12:30:00" Then
                time_end_combo.Text = "12:30 PM"
            End If
        End If
        If time_start = "2020-02-11 11:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "11:00 AM"
            If time_end = "2020-02-11 12:00:00" Then
                time_end_combo.Text = "12:00 PM"
            ElseIf time_end = "2020-02-11 13:00:00" Then
                time_end_combo.Text = "1:00 PM"

            End If
        End If
        If time_start = "2020-02-11 11:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "11:30 AM"
            If time_end = "2020-02-11 12:30:00" Then
                time_end_combo.Text = "12:30 PM"
            ElseIf time_end = "2020-02-11 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            End If
        End If
        If time_start = "2020-02-11 12:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "12:00 PM"
            If time_end = "2020-02-11 13:00:00" Then
                time_end_combo.Text = "1:00 PM"
            ElseIf time_end = "2020-02-11 14:00:00" Then
                time_end_combo.Text = "2:00"
            End If
        End If
        If time_start = "2020-02-11 12:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "12:30 PM"
            If time_end = "2020-02-11 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            ElseIf time_end = "2020-02-11 14:30:00" Then
                time_end_combo.Text = "2:30 PM"
            End If
        End If
        If time_start = "2020-02-11 13:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "1:00 PM"
            If time_end = "2020-02-11 14:00:00" Then
                time_end_combo.Text = "2:00 PM"
            ElseIf time_end = "2020-02-11 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            End If
        End If
        If time_start = "2020-02-11 13:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "1:30 PM"
            If time_end = "2020-02-11 14:30:00" Then
                time_end_combo.Text = "2:30 PM"
            ElseIf time_end = "2020-02-11 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            End If
        End If
        If time_start = "2020-02-11 14:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "2:00 PM"
            If time_end = "2020-02-11 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            ElseIf time_end = "2020-02-11 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            End If
        End If
        If time_start = "2020-02-11 14:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "2:30 PM"
            If time_end = "2020-02-11 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            ElseIf time_end = "2020-02-11 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            End If
        End If
        If time_start = "2020-02-11 15:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "3:00 PM"
            If time_end = "2020-02-11 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            ElseIf time_end = "2020-02-11 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            End If
        End If
        If time_start = "2020-02-11 15:30:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "3:30 PM"
            If time_end = "2020-02-11 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            ElseIf time_end = "2020-02-11 17:30:00" Then
                time_end_combo.Text = "5:30 PM"
            End If
        End If
        If time_start = "2020-02-11 16:00:00" Then
            day_combo.Text = "Tuesday"
            time_combo.Text = "4:00 PM"
            If time_end = "2020-02-11 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            ElseIf time_end = "2020-02-11 18:00:00" Then
                time_end_combo.Text = "6:00 PM"
            End If
        End If


        ' wednesday


        If time_start = "2020-02-12 06:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "6:00 AM"
            If time_end = "2020-02-12 07:00:00" Then
                time_end_combo.Text = "7:00 AM"
            ElseIf time_end = "2020-02-12 08:00:00" Then
                time_end_combo.Text = "8:00 AM"

            End If
        End If
        If time_start = "2020-02-12 06:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "6:30 AM"
            If time_end = "2020-02-12 07:30:00" Then
                time_end_combo.Text = "7:30 AM"
            ElseIf time_end = "2020-02-12 08:30:00" Then
                time_end_combo.Text = "8:30 AM"
            End If
        End If
        If time_start = "2020-02-12 07:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "7:00 AM"
            If time_end = "2020-02-12 08:00:00" Then
                time_end_combo.Text = "8:00 AM"
            ElseIf time_end = "2020-02-12 09:00:00" Then
                time_end_combo.Text = "9:00 AM"
            End If
        End If


        If time_start = "2020-02-12 07:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "7:30 AM"
            If time_end = "2020-02-12 08:30:00" Then

                time_end_combo.Text = "8:30 AM"
            ElseIf time_end = "2020-02-12 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            End If
        End If
        If time_start = "2020-02-12 08:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "8:00 AM"
            If time_end = "2020-02-12 09:00:00" Then

                time_end_combo.Text = "9:00 AM"
            ElseIf time_end = "2020-02-12 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            End If
        End If
        If time_start = "2020-02-12 08:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "8:30 AM"
            If time_end = "2020-02-12 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            ElseIf time_end = "2020-02-12 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            End If
        End If
        If time_start = "2020-02-12 09:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "9:00 AM"
            If time_end = "2020-02-12 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            ElseIf time_end = "2020-02-12 11:00:00" Then
                time_end_combo.Text = "11:00 AM"
            End If
        End If
        If time_start = "2020-02-12 09:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "9:30 AM"
            If time_end = "2020-02-12 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            ElseIf time_end = "2020-02-12 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            End If
        End If
        If time_start = "2020-02-12 10:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "10:00 AM"
            If time_end = "2020-02-12 11:00:00" Then
                time_end_combo.Text = "11:00 AM"

            ElseIf time_end = "2020-02-12 12:00:00" Then
                time_end_combo.Text = "12:00 PM"

            End If
        End If
        If time_start = "2020-02-12 10:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "10:30 AM"
            If time_end = "2020-02-12 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            ElseIf time_end = "2020-02-12 12:30:00" Then
                time_end_combo.Text = "12:30 PM"
            End If
        End If
        If time_start = "2020-02-12 11:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "11:00 AM"
            If time_end = "2020-02-12 12:00:00" Then
                time_end_combo.Text = "12:00 PM"
            ElseIf time_end = "2020-02-12 13:00:00" Then
                time_end_combo.Text = "1:00 PM"

            End If
        End If
        If time_start = "2020-02-12 11:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "11:30 AM"
            If time_end = "2020-02-12 12:30:00" Then
                time_end_combo.Text = "12:30 PM"
            ElseIf time_end = "2020-02-12 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            End If
        End If
        If time_start = "2020-02-12 12:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "12:00 PM"
            If time_end = "2020-02-12 13:00:00" Then
                time_end_combo.Text = "1:00 PM"
            ElseIf time_end = "2020-02-12 14:00:00" Then
                time_end_combo.Text = "2:00 PM"
            End If
        End If
        If time_start = "2020-02-12 12:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "12:30 PM"
            If time_end = "2020-02-12 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            ElseIf time_end = "2020-02-12 14:30:00" Then
                time_end_combo.Text = "2:30 PM"
            End If
        End If
        If time_start = "2020-02-12 13:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "1:00 PM"
            If time_end = "2020-02-12 14:00:00" Then
                time_end_combo.Text = "2:00 PM"
            ElseIf time_end = "2020-02-12 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            End If
        End If
        If time_start = "2020-02-12 13:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "1:30 PM"
            If time_end = "2020-02-12 14:30:00" Then
                time_end_combo.Text = "2:30 PM"
            ElseIf time_end = "2020-02-12 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            End If
        End If
        If time_start = "2020-02-12 14:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "2:00 PM"
            If time_end = "2020-02-12 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            ElseIf time_end = "2020-02-12 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            End If
        End If
        If time_start = "2020-02-12 14:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "2:30 PM"
            If time_end = "2020-02-12 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            ElseIf time_end = "2020-02-12 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            End If
        End If
        If time_start = "2020-02-12 15:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "3:00 PM"
            If time_end = "2020-02-12 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            ElseIf time_end = "2020-02-12 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            End If
        End If
        If time_start = "2020-02-12 15:30:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "3:30 PM"
            If time_end = "2020-02-12 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            ElseIf time_end = "2020-02-12 17:30:00" Then
                time_end_combo.Text = "5:30 PM"
            End If
        End If
        If time_start = "2020-02-12 16:00:00" Then
            day_combo.Text = "Wednesday"
            time_combo.Text = "4:00 PM"
            If time_end = "2020-02-12 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            ElseIf time_end = "2020-02-12 18:00:00" Then
                time_end_combo.Text = "6:00 PM"
            End If
        End If
        'Thursday

        If time_start = "2020-02-13 06:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "6:00 AM"
            If time_end = "2020-02-13 07:00:00" Then
                time_end_combo.Text = "7:00 AM"
            ElseIf time_end = "2020-02-13 08:00:00" Then
                time_end_combo.Text = "8:00 AM"

            End If
        End If
        If time_start = "2020-02-13 06:30:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "6:30 AM"
            If time_end = "2020-02-13 07:30:00" Then
                time_end_combo.Text = "7:30 AM"
            ElseIf time_end = "2020-02-13 08:30:00" Then
                time_end_combo.Text = "8:30 AM"
            End If
        End If
        If time_start = "2020-02-13 07:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "7:00 AM"
            If time_end = "2020-02-13 08:00:00" Then
                time_end_combo.Text = "8:00 AM"
            ElseIf time_end = "2020-02-13 09:00:00" Then
                time_end_combo.Text = "9:00"
            End If
        End If
        If time_start = "2020-02-13 07:30:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "7:30 AM"
            If time_end = "2020-02-13 08:30:00" Then

                time_end_combo.Text = "8:30 AM"
            ElseIf time_end = "2020-02-13 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            End If
        End If
        If time_start = "2020-02-13 08:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "8:00 AM"
            If time_end = "2020-02-13 09:00:00" Then

                time_end_combo.Text = "9:00 AM"
            ElseIf time_end = "2020-02-13 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            End If
        End If
        If time_start = "2020-02-13 08:30:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "8:30 AM"
            If time_end = "2020-02-13 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            ElseIf time_end = "2020-02-13 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            End If
        End If
        If time_start = "2020-02-13 09:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "9:00 AM"
            If time_end = "2020-02-13 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            ElseIf time_end = "2020-02-13 11:00:00" Then
                time_end_combo.Text = "11:00 AM"
            End If
        End If
        If time_start = "2020-02-13 09:30:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "9:30"
            If time_end = "2020-02-13 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            ElseIf time_end = "2020-02-13 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            End If
        End If
        If time_start = "2020-02-13 10:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "10:00 AM"
            If time_end = "2020-02-13 11:00:00" Then
                time_end_combo.Text = "11:00 AM"

            ElseIf time_end = "2020-02-13 12:00:00" Then
                time_end_combo.Text = "12:00 PM"

            End If
        End If
        If time_start = "2020-02-13 10:30:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "10:30 AM"
            If time_end = "2020-02-13 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            ElseIf time_end = "2020-02-13 12:30:00" Then
                time_end_combo.Text = "12:30 PM"
            End If
        End If
        If time_start = "2020-02-13 11:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "11:00 AM"
            If time_end = "2020-02-13 12:00:00" Then
                time_end_combo.Text = "12:00 PM"
            ElseIf time_end = "2020-02-13 13:00:00" Then
                time_end_combo.Text = "1:00 PM"

            End If
        End If
        If time_start = "2020-02-13 11:30:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "11:30 AM"
            If time_end = "2020-02-13 12:30:00" Then
                time_end_combo.Text = "12:30 PM"
            ElseIf time_end = "2020-02-13 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            End If
        End If
        If time_start = "2020-02-13 12:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "12:00 PM"
            If time_end = "2020-02-13 13:00:00" Then
                time_end_combo.Text = "1:00 PM"
            ElseIf time_end = "2020-02-13 14:00:00" Then
                time_end_combo.Text = "2:00 PM"
            End If
        End If
        If time_start = "2020-02-13 12:30:00 PM" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "12:30 PM"
            If time_end = "2020-02-13 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            ElseIf time_end = "2020-02-13 14:30:00" Then
                time_end_combo.Text = "2:30 PM "
            End If
        End If
        If time_start = "2020-02-13 13:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "1:00 PM"
            If time_end = "2020-02-13 14:00:00" Then
                time_end_combo.Text = "2:00 PM"
            ElseIf time_end = "2020-02-13 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            End If
        End If
        If time_start = "2020-02-13 13:30:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "1:30 PM"
            If time_end = "2020-02-13 14:30:00" Then
                time_end_combo.Text = "2:30 PM"
            ElseIf time_end = "2020-02-13 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            End If
        End If
        If time_start = "2020-02-13 14:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "2:00 PM"
            If time_end = "2020-02-13 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            ElseIf time_end = "2020-02-13 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            End If
        End If
        If time_start = "2020-02-13 14:30:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "2:30 PM"
            If time_end = "2020-02-13 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            ElseIf time_end = "2020-02-13 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            End If
        End If
        If time_start = "2020-02-13 15:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "3:00 PM"
            If time_end = "2020-02-13 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            ElseIf time_end = "2020-02-13 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            End If
        End If
        If time_start = "2020-02-13 15:30:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "3:30 PM"
            If time_end = "2020-02-13 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            ElseIf time_end = "2020-02-13 17:30:00" Then
                time_end_combo.Text = "5:30 PM"
            End If
        End If
        If time_start = "2020-02-13 16:00:00" Then
            day_combo.Text = "Thursday"
            time_combo.Text = "4:00 PM"
            If time_end = "2020-02-13 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            ElseIf time_end = "2020-02-13 18:00:00" Then
                time_end_combo.Text = "6:00 PM"
            End If
        End If

        If time_start = "2020-02-14 06:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "6:00 AM"
            If time_end = "2020-02-14 07:00:00" Then
                time_end_combo.Text = "7:00 AM"
            ElseIf time_end = "2020-02-14 08:00:00" Then
                time_end_combo.Text = "8:00 AM"

            End If
        End If
        If time_start = "2020-02-14 06:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "6:30 AM"
            If time_end = "2020-02-14 07:30:00" Then
                time_end_combo.Text = "7:30 AM"
            ElseIf time_end = "2020-02-14 08:30:00" Then
                time_end_combo.Text = "8:30 AM"
            End If
        End If
        If time_start = "2020-02-14 07:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "7:00 AM"
            If time_end = "2020-02-14 08:00:00" Then
                time_end_combo.Text = "8:00 AM"
            ElseIf time_end = "2020-02-14 09:00:00" Then
                time_end_combo.Text = "9:00 AM"
            End If
        End If


        If time_start = "2020-02-14 07:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "7:30 AM"
            If time_end = "2020-02-14 08:30:00" Then

                time_end_combo.Text = "8:30 AM"
            ElseIf time_end = "2020-02-14 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            End If
        End If
        If time_start = "2020-02-14 08:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "8:00 AM"
            If time_end = "2020-02-14 09:00:00" Then

                time_end_combo.Text = "9:00 AM"
            ElseIf time_end = "2020-02-14 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            End If
        End If
        If time_start = "2020-02-14 08:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "8:30 AM"
            If time_end = "2020-02-14 09:30:00" Then
                time_end_combo.Text = "9:30 AM"
            ElseIf time_end = "2020-02-14 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            End If
        End If
        If time_start = "2020-02-14 09:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "9:00 AM"
            If time_end = "2020-02-14 10:00:00" Then
                time_end_combo.Text = "10:00 AM"
            ElseIf time_end = "2020-02-14 11:00:00" Then
                time_end_combo.Text = "11:00 AM"
            End If
        End If
        If time_start = "2020-02-14 09:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "9:30 AM"
            If time_end = "2020-02-14 10:30:00" Then
                time_end_combo.Text = "10:30 AM"
            ElseIf time_end = "2020-02-14 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            End If
        End If
        If time_start = "2020-02-14 10:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "10:00 AM"
            If time_end = "2020-02-14 11:00:00" Then
                time_end_combo.Text = "11:00 AM"

            ElseIf time_end = "2020-02-14 12:00:00" Then
                time_end_combo.Text = "12:00 PM"

            End If
        End If
        If time_start = "2020-02-14 10:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "10:30 AM"
            If time_end = "2020-02-14 11:30:00" Then
                time_end_combo.Text = "11:30 AM"
            ElseIf time_end = "2020-02-14 12:30:00" Then
                time_end_combo.Text = "12:30 PM"
            End If
        End If
        If time_start = "2020-02-14 11:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "11:00 AM"
            If time_end = "2020-02-14 12:00:00" Then
                time_end_combo.Text = "12:00 PM"
            ElseIf time_end = "2020-02-14 13:00:00" Then
                time_end_combo.Text = "1:00 PM"

            End If
        End If
        If time_start = "2020-02-14 11:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "11:30 AM"
            If time_end = "2020-02-14 12:30:00" Then
                time_end_combo.Text = "12:30 PM"
            ElseIf time_end = "2020-02-14 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            End If
        End If
        If time_start = "2020-02-14 12:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "12:00 PM"
            If time_end = "2020-02-14 13:00:00" Then
                time_end_combo.Text = "1:00 PM"
            ElseIf time_end = "2020-02-14 14:00:00" Then
                time_end_combo.Text = "2:00 PM"
            End If
        End If
        If time_start = "2020-02-14 12:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "12:30 PM"
            If time_end = "2020-02-14 13:30:00" Then
                time_end_combo.Text = "1:30 PM"
            ElseIf time_end = "2020-02-14 14:30:00" Then
                time_end_combo.Text = "2:30 PM"
            End If
        End If
        If time_start = "2020-02-14 13:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "1:00 PM"
            If time_end = "2020-02-14 14:00:00" Then
                time_end_combo.Text = "2:00 PM"
            ElseIf time_end = "2020-02-14 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            End If
        End If
        If time_start = "2020-02-14 13:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "1:30 PM"
            If time_end = "2020-02-14 14:30:00" Then
                time_end_combo.Text = "2:30 PM"
            ElseIf time_end = "2020-02-14 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            End If
        End If
        If time_start = "2020-02-14 14:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "2:00 PM"
            If time_end = "2020-02-14 15:00:00" Then
                time_end_combo.Text = "3:00 PM"
            ElseIf time_end = "2020-02-14 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            End If
        End If
        If time_start = "2020-02-14 14:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "2:30 PM"
            If time_end = "2020-02-14 15:30:00" Then
                time_end_combo.Text = "3:30 PM"
            ElseIf time_end = "2020-02-14 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            End If
        End If
        If time_start = "2020-02-14 15:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "3:00 PM"
            If time_end = "2020-02-14 16:00:00" Then
                time_end_combo.Text = "4:00 PM"
            ElseIf time_end = "2020-02-14 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            End If
        End If
        If time_start = "2020-02-14 15:30:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "3:30 PM"
            If time_end = "2020-02-14 16:30:00" Then
                time_end_combo.Text = "4:30 PM"
            ElseIf time_end = "2020-02-14 17:30:00" Then
                time_end_combo.Text = "5:30 PM"
            End If
        End If
        If time_start = "2020-02-14 16:00:00" Then
            day_combo.Text = "Friday"
            time_combo.Text = "4:00 PM"
            If time_end = "2020-02-14 17:00:00" Then
                time_end_combo.Text = "5:00 PM"
            ElseIf time_end = "2020-02-14 18:00:00" Then
                time_end_combo.Text = "6:00 PM"
            End If
        End If

    End Sub
    Private Sub edit_bot_sched1_Click(sender As Object, e As EventArgs) Handles edit_bot_sched1.Click
        update_button.BringToFront()

        If update_button.Enabled = False Then
            update_button.Enabled = True
        Else
            'nothing
        End If
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row1 As DataRow = tb.Rows(0)
        row1.SetModified()
        subject_cmbo.Text = row1(2)

        time_start = (row1(3))
        time_end = (row1(4))
        checkDateToInsert()

        Track_dropdown.Text = row1(7)
        gradLvel_drop.Text = row1(8)
        section_dropdonw.Text = row1(9)
        build_dropbox.Text = row1(10)
        room_dropdown.Text = row1(11)
        GunaPanel1.Show()

    End Sub

    Private Sub edit_bot_sched2_Click(sender As Object, e As EventArgs) Handles edit_bot_sched2.Click

        update_button.BringToFront()
        If update_button.Enabled = False Then
            update_button.Enabled = True
        Else
            'nothing
        End If
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row2 As DataRow = tb.Rows(1)
        row2.SetModified()
        subject_cmbo.Text = row2(2)

        time_start = (row2(3))
        time_end = (row2(4))
        checkDateToInsert()

        Track_dropdown.Text = row2(7)
        gradLvel_drop.Text = row2(8)
        section_dropdonw.Text = row2(9)
        build_dropbox.Text = row2(10)
        room_dropdown.Text = row2(11)
        GunaPanel1.Show()


    End Sub

    Private Sub edit_bot_sched3_Click(sender As Object, e As EventArgs) Handles edit_bot_sched3.Click
        update_button.BringToFront()
        If update_button.Enabled = False Then
            update_button.Enabled = True
        Else
            'nothing
        End If
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row4 As DataRow = tb.Rows(2)
        row4.SetModified()
        subject_cmbo.Text = row4(2)

        time_start = (row4(3))
        time_end = (row4(4))
        checkDateToInsert()

        Track_dropdown.Text = row4(7)
        gradLvel_drop.Text = row4(8)
        section_dropdonw.Text = row4(9)
        build_dropbox.Text = row4(10)
        room_dropdown.Text = row4(11)
        GunaPanel1.Show()
    End Sub

    Private Sub edit_bot_sched4_Click(sender As Object, e As EventArgs) Handles edit_bot_sched4.Click
        update_button.BringToFront()
        If update_button.Enabled = False Then
            update_button.Enabled = True
        Else
            'nothing
        End If
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row4 As DataRow = tb.Rows(3)
        row4.SetModified()
        subject_cmbo.Text = row4(2)

        time_start = (row4(3))
        time_end = (row4(4))
        checkDateToInsert()

        Track_dropdown.Text = row4(7)
        gradLvel_drop.Text = row4(8)
        section_dropdonw.Text = row4(9)
        build_dropbox.Text = row4(10)
        room_dropdown.Text = row4(11)
        GunaPanel1.Show()
    End Sub

    Private Sub edit_bot_sched5_Click(sender As Object, e As EventArgs) Handles edit_bot_sched5.Click
        update_button.BringToFront()
        If update_button.Enabled = False Then
            update_button.Enabled = True
        Else
            'nothing
        End If
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row5 As DataRow = tb.Rows(4)
        row5.SetModified()
        subject_cmbo.Text = row5(2)

        time_start = (row5(3))
        time_end = (row5(4))
        checkDateToInsert()

        Track_dropdown.Text = row5(7)
        gradLvel_drop.Text = row5(8)
        section_dropdonw.Text = row5(9)
        build_dropbox.Text = row5(10)
        room_dropdown.Text = row5(11)
        GunaPanel1.Show()
    End Sub

    Private Sub edit_bot_sched6_Click(sender As Object, e As EventArgs) Handles edit_bot_sched6.Click
        update_button.BringToFront()
        If update_button.Enabled = False Then
            update_button.Enabled = True
        Else
            'nothing
        End If
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row6 As DataRow = tb.Rows(5)
        row6.SetModified()
        subject_cmbo.Text = row6(2)

        time_start = (row6(3))
        time_end = (row6(4))
        checkDateToInsert()

        Track_dropdown.Text = row6(7)
        gradLvel_drop.Text = row6(8)
        section_dropdonw.Text = row6(9)
        build_dropbox.Text = row6(10)
        room_dropdown.Text = row6(11)
        GunaPanel1.Show()
    End Sub

    Private Sub edit_bot_sched7_Click(sender As Object, e As EventArgs) Handles edit_bot_sched7.Click
        update_button.BringToFront()
        If update_button.Enabled = False Then
            update_button.Enabled = True
        Else
            'nothing
        End If
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row7 As DataRow = tb.Rows(6)
        row7.SetModified()
        subject_cmbo.Text = row7(2)

        time_start = (row7(3))
        time_end = (row7(4))
        checkDateToInsert()

        Track_dropdown.Text = row7(7)
        gradLvel_drop.Text = row7(8)
        section_dropdonw.Text = row7(9)
        build_dropbox.Text = row7(10)
        room_dropdown.Text = row7(11)
        GunaPanel1.Show()
    End Sub

    Private Sub edit_bot_sched8_Click(sender As Object, e As EventArgs) Handles edit_bot_sched8.Click
        update_button.BringToFront()
        If update_button.Enabled = False Then
            update_button.Enabled = True
        Else
            'nothing
        End If
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row8 As DataRow = tb.Rows(7)
        row8.SetModified()
        subject_cmbo.Text = row8(2)

        time_start = (row8(3))
        time_end = (row8(4))
        checkDateToInsert()

        Track_dropdown.Text = row8(7)
        gradLvel_drop.Text = row8(8)
        section_dropdonw.Text = row8(9)
        build_dropbox.Text = row8(10)
        room_dropdown.Text = row8(11)
        GunaPanel1.Show()
    End Sub
    '=--------------------------------------------
    'update button

    Private Sub update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click
        Dim choosen_day As String
        Dim choosen_time As String
        Dim choosen_end_time As String
        If day_combo.Text = "Monday" Then
            choosen_day = "2020-02-10"
            '"02/10/2020"
            '2020-02-10
        ElseIf day_combo.Text = "Tuesday" Then
            choosen_day = "2020-02-11"
            '"02/11/2020"
            '2020-02-11
        ElseIf day_combo.Text = "Wednesday" Then
            choosen_day = "2020-02-12"
            '"02/11/2020"
            '2020-02-12
        ElseIf day_combo.Text = "Thursday" Then
            choosen_day = "2020-02-13"
            '"02/11/2020"
            '2020-02-13
        ElseIf day_combo.Text = "Friday" Then
            choosen_day = "2020-02-14"
            '"02/11/2020"
            '2020-02-14
        End If

        If time_combo.Text = "6:00 AM" Then
            choosen_time = "06:00:00"
        ElseIf time_combo.Text = "6:30 AM" Then
            choosen_time = "06:30:00"
        ElseIf time_combo.Text = "7:00 AM" Then
            choosen_time = "07:00:00"
        ElseIf time_combo.Text = "7:30 AM" Then
            choosen_time = "07:30:00"
        ElseIf time_combo.Text = "8:00 AM" Then
            choosen_time = "08:00:00"
        ElseIf time_combo.Text = "8:30 AM" Then
            choosen_time = "08:30:00"
        ElseIf time_combo.Text = "9:00 AM" Then
            choosen_time = "09:00:00"
        ElseIf time_combo.Text = "9:30 AM" Then
            choosen_time = "09:30:00"
        ElseIf time_combo.Text = "10:00 AM" Then
            choosen_time = "10:00:00"
        ElseIf time_combo.Text = "10:30 AM" Then
            choosen_time = "10:30:00"
        ElseIf time_combo.Text = "11:00 AM" Then
            choosen_time = "11:00:00"
        ElseIf time_combo.Text = "12:30 AM" Then
            choosen_time = "12:30:00"
        ElseIf time_combo.Text = "12:00 PM" Then
            choosen_time = "12:00:00"
        ElseIf time_combo.Text = "12:30 PM" Then
            choosen_time = "12:30:00"
        ElseIf time_combo.Text = "1:00 PM" Then
            choosen_time = "13:00:00"
        ElseIf time_combo.Text = "1:30 PM" Then
            choosen_time = "13:30:00"
        ElseIf time_combo.Text = "2:00 PM" Then
            choosen_time = "14:00:00"
        ElseIf time_combo.Text = "2:30 PM" Then
            choosen_time = "14:30:00"
        ElseIf time_combo.Text = "3:00 PM" Then
            choosen_time = "15:00:00"
        ElseIf time_combo.Text = "3:30 PM" Then
            choosen_time = "15:30:00"
        End If

        If time_end_combo.Text = "7:00 AM" Then
            choosen_end_time = "07:00:00"
        ElseIf time_end_combo.Text = "7:30 AM" Then
            choosen_end_time = "07:30:00"
        ElseIf time_end_combo.Text = "8:00 AM" Then
            choosen_end_time = "08:00:00"
        ElseIf time_end_combo.Text = "8:30 AM" Then
            choosen_end_time = "08:30:00"
        ElseIf time_end_combo.Text = "9:00 AM" Then
            choosen_end_time = "09:00:00"
        ElseIf time_end_combo.Text = "9:30 AM" Then
            choosen_end_time = "09:30:00"
        ElseIf time_end_combo.Text = "10:00 AM" Then
            choosen_end_time = "10:00:00"
        ElseIf time_end_combo.Text = "10:30 AM" Then
            choosen_end_time = "10:30:00"
        ElseIf time_end_combo.Text = "11:00 AM" Then
            choosen_end_time = "11:00:00"
        ElseIf time_end_combo.Text = "11:30 AM" Then
            choosen_end_time = "11:30:00"
        ElseIf time_end_combo.Text = "12:00 PM" Then
            choosen_end_time = "12:00:00"
        ElseIf time_end_combo.Text = "12:30 PM" Then
            choosen_end_time = "12:30:00"
        ElseIf time_end_combo.Text = "1:00 PM" Then
            choosen_end_time = "13:00:00"
        ElseIf time_end_combo.Text = "1:30 PM" Then
            choosen_end_time = "13:30:00"
        ElseIf time_end_combo.Text = "2:00 PM" Then
            choosen_end_time = "14:00:00"
        ElseIf time_end_combo.Text = "2:30 PM" Then
            choosen_end_time = "14:30:00"
        ElseIf time_end_combo.Text = "3:00 PM" Then
            choosen_end_time = "15:00:00"
        ElseIf time_end_combo.Text = "3:30 PM" Then
            choosen_end_time = "15:30:00"
        ElseIf time_end_combo.Text = "4:00 PM" Then
            choosen_end_time = "16:00:00"
        ElseIf time_end_combo.Text = "4:30 PM" Then
            choosen_end_time = "16:30:00"
        ElseIf time_end_combo.Text = "5:00 PM" Then
            choosen_end_time = "17:00:00"
        ElseIf time_end_combo.Text = "5:30 PM" Then
            choosen_end_time = "17:30:00"

        End If

        scon.CloseConnection()

        Dim final_end As String = choosen_day + " " + choosen_end_time

        Dim final_time_day As String = choosen_day + " " + choosen_time

        Dim d As DateTime = DateTime.Parse(final_end)
        Dim f As DateTime = DateTime.Parse(final_time_day)


        query = "select * from schedule_tbl where time_start='" + f + "' and time_end='" + d + "' and building_no='" + build_dropbox.Text + "' and room_no='" + room_dropdown.Text + "' and sy='" + SelectSt.schedsy_combo.Text + "' and semestral_sche='" + SelectSt.semester_combo.Text + "'"
        Dim checkccount As String = "select count(id_Prof) as 'che' from schedule_tbl where id_Prof='" + selectid + "' and semestral_sche ='" + SelectSt.semester_combo.Text + "' and sy='" + SelectSt.schedsy_combo.Text + "'"
        scon.OpenConnection()
        cmd = New MySqlCommand(query, scon.GetConnection)
        read = cmd.ExecuteReader
        Try
            If read.HasRows Then
                MsgBox("The room already occupied")
                Exit Sub
            Else
                read.Close()
                scon.CloseConnection()
                scon.OpenConnection()
                'check already have local
                Dim ithas As String = "Select * From schedule_tbl Where time_start ='" + f + "' and time_end='" + d + "' and id_Prof='" + selectid + "'"
                Dim lcmd As New MySqlCommand(ithas, scon.GetConnection)
                Dim readif As MySqlDataReader = lcmd.ExecuteReader
                'check room and time check global

                If readif.HasRows Then
                    MsgBox("The time already occupied")
                    Exit Sub

                ElseIf build_dropbox.Text = "" Or Track_dropdown.Text = "" Or time_combo.Text = "" Or time_end_combo.Text = "" Or day_combo.Text = "" Then
                    MsgBox("Fill the Fields")
                    readif.Close()
                Else
                    readif.Close()
                    Try
                        scon.CloseConnection()

                        Dim sa As String = subject_cmbo.SelectedValue
                        query = "update schedule_tbl set `subject`='" + sa + "', 
                                   `time_start`='" + final_time_day + "',
                                   `time_end`='" + final_end + "', `strandname`='" + Track_dropdown.Text + "',
                                    `grade_lvl`='" + gradLvel_drop.Text + "',
                                    `section_no`='" + section_dropdonw.Text + "', 
                                    `building_no`='" + build_dropbox.Text + "',
                                    `room_no`='" + room_dropdown.Text + "' 
                                    where `id_Prof` = '" + selectid + "' and
                                    `time_start`='" + final_time_day + "' and
                                    `time_end`='" + final_end + "' and
                                    semestral_sche='" + SelectSt.semester_combo.Text + "' and
                                    sy='" + SelectSt.schedsy_combo.Text + "'"

                        scon.OpenConnection()
                        cmd = New MySqlCommand(query, scon.GetConnection)

                        'cmd.Parameters.Add()


                        If cmd.ExecuteNonQuery = 1 Then
                            scon.CloseConnection()
                            Call Loaoded()
                            MsgBox("Schedule Updated")


                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub day_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles day_combo.SelectedIndexChanged

        scon.CloseConnection()
        scon.OpenConnection()
        cmd = New MySqlCommand("select time_start,time_end from  schedule_tbl where id_Prof='" + selectid + "' and semestral_sche='" + SelectSt.semester_combo.Text + "' and sy='" + SelectSt.schedsy_combo.Text + "'", scon.GetConnection)
        read = cmd.ExecuteReader


    End Sub

    Private Sub room_dropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles room_dropdown.SelectedIndexChanged, day_combo.SelectedIndexChanged
        Call insert_day_time()
        scon.CloseConnection()
        cmd = New MySqlCommand("select * from schedule_tbl where semestral_sche ='" + SelectSt.semester_combo.Text + "' and sy='" + SelectSt.schedsy_combo.Text + "' and id_Prof='" + selectid + "'", scon.GetConnection)
        scon.OpenConnection()
        read = cmd.ExecuteReader
        While read.Read
            Dim time_start As DateTime = read.GetDateTime("time_start")
            Dim time_end As DateTime = read.GetDateTime("time_end")
            If day_combo.Text = "Monday" Then

                If time_start = "2020-02-10 06:00:00" Then
                    If time_end = "2020-02-10 07:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-10 08:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                    End If
                End If
                If time_start = "2020-02-10 06:30:00" Then
                    If time_end = "2020-02-10 07:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-10 08:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    End If
                End If
                If time_start = "2020-02-10 07:00:00" Then

                    If time_end = "2020-02-10 08:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-10 09:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    End If
                End If
                If time_start = "2020-02-10 07:30:00" Then
                    If time_end = "2020-02-10 08:30:00" Then

                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-10 09:30:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("7:30 AM")

                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    End If
                End If
                If time_start = "2020-02-10 08:00:00" Then
                    If time_end = "2020-02-10 09:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    ElseIf time_end = "2020-02-10 10:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                    End If
                End If
                If time_start = "2020-02-10 08:30:00" Then
                    If time_end = "2020-02-10 09:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    ElseIf time_end = "2020-02-10 10:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                    End If
                End If

                If time_start = "2020-02-10 09:00:00" Then
                    If time_end = "2020-02-10 10:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")

                    ElseIf time_end = "2020-02-10 11:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                    End If
                End If
                If time_start = "2020-02-10 09:30:00" Then
                    If time_end = "2020-02-10 10:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")

                    ElseIf time_end = "2020-02-10 11:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                    End If
                End If
                If time_start = "2020-02-10 10:00:00" Then
                    If time_end = "2020-02-10 11:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")

                    ElseIf time_end = "2020-02-10 12:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                    End If
                End If
                If time_start = "2020-02-10 10:30:00" Then
                    If time_end = "2020-02-10 11:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")

                    ElseIf time_end = "2020-02-10 12:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                    End If
                End If
                If time_start = "2020-02-10 11:00:00" Then
                    If time_end = "2020-02-10 12:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")

                    ElseIf time_end = "2020-02-10 13:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                    End If
                End If
                If time_start = "2020-02-10 11:30:00" Then
                    If time_end = "2020-02-10 12:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")

                    ElseIf time_end = "2020-02-10 13:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                    End If
                End If
                If time_start = "2020-02-10 12:00:00" Then
                    If time_end = "2020-02-10 13:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")

                    ElseIf time_end = "2020-02-10 14:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                    End If
                End If
                If time_start = "2020-02-10 12:30:00" Then
                    If time_end = "2020-02-10 13:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")

                    ElseIf time_end = "2020-02-10 14:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                    End If
                End If
                If time_start = "2020-02-10 13:00:00" Then
                    If time_end = "2020-02-10 14:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")

                    ElseIf time_end = "2020-02-10 15:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    End If
                End If
                If time_start = "2020-02-10 13:30:00" Then
                    If time_end = "2020-02-10 14:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")


                    ElseIf time_end = "2020-02-10 15:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    End If
                End If
                If time_start = "2020-02-10 14:00:00" Then
                    If time_end = "2020-02-10 15:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    ElseIf time_end = "2020-02-10 16:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    End If
                End If
                If time_start = "2020-02-10 14:30:00" Then
                    If time_end = "2020-02-10 15:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    ElseIf time_end = "2020-02-10 16:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    End If

                End If
                If time_start = "2020-02-10 15:00:00" Then
                    If time_end = "2020-02-10 16:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    ElseIf time_end = "2020-02-10 17:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    End If
                End If
                If time_start = "2020-02-10 15:30:00" Then
                    If time_end = "2020-02-10 16:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    ElseIf time_end = "2020-02-10 17:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                    End If
                End If
                If time_start = "2020-02-10 16:00:00" Then

                    If time_end = "2020-02-10 17:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    ElseIf time_end = "2020-02-10 18:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                        time_combo.Items.Remove("6:00 PM")
                    End If
                End If

                'tuesday
            ElseIf day_combo.Text = "Tuesday" Then

                If time_start = "2020-02-11 06:00:00" Then
                    If time_end = "2020-02-11 07:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-11 08:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                    End If
                End If
                If time_start = "2020-02-11 06:30:00" Then
                    If time_end = "2020-02-11 07:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-11 08:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    End If
                End If
                If time_start = "2020-02-11 07:00:00" Then

                    If time_end = "2020-02-11 08:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-11 09:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    End If
                End If
                If time_start = "2020-02-11 07:30:00" Then
                    If time_end = "2020-02-11 08:30:00" Then

                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-11 09:30:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("7:30 AM")

                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    End If
                End If
                If time_start = "2020-02-11 08:00:00" Then
                    If time_end = "2020-02-11 09:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    ElseIf time_end = "2020-02-11 10:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                    End If
                End If
                If time_start = "2020-02-11 08:30:00" Then
                    If time_end = "2020-02-11 09:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    ElseIf time_end = "2020-02-11 10:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                    End If
                End If

                If time_start = "2020-02-11 09:00:00" Then
                    If time_end = "2020-02-11 10:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")

                    ElseIf time_end = "2020-02-11 11:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                    End If
                End If
                If time_start = "2020-02-11 09:30:00" Then
                    If time_end = "2020-02-11 10:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")

                    ElseIf time_end = "2020-02-11 11:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                    End If
                End If
                If time_start = "2020-02-11 10:00:00" Then
                    If time_end = "2020-02-11 11:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")

                    ElseIf time_end = "2020-02-11 12:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                    End If
                End If
                If time_start = "2020-02-11 10:30:00" Then
                    If time_end = "2020-02-11 11:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")

                    ElseIf time_end = "2020-02-11 12:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                    End If
                End If
                If time_start = "2020-02-11 11:00:00" Then
                    If time_end = "2020-02-11 12:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")

                    ElseIf time_end = "2020-02-11 13:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                    End If
                End If
                If time_start = "2020-02-11 11:30:00" Then
                    If time_end = "2020-02-11 12:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")

                    ElseIf time_end = "2020-02-11 13:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                    End If
                End If
                If time_start = "2020-02-11 12:00:00" Then
                    If time_end = "2020-02-11 13:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")

                    ElseIf time_end = "2020-02-11 14:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                    End If
                End If
                If time_start = "2020-02-11 12:30:00" Then
                    If time_end = "2020-02-11 13:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")

                    ElseIf time_end = "2020-02-11 14:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                    End If
                End If
                If time_start = "2020-02-11 13:00:00" Then
                    If time_end = "2020-02-11 14:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")

                    ElseIf time_end = "2020-02-11 15:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    End If
                End If
                If time_start = "2020-02-11 13:30:00" Then
                    If time_end = "2020-02-11 14:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")


                    ElseIf time_end = "2020-02-11 15:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    End If
                End If
                If time_start = "2020-02-11 14:00:00" Then
                    If time_end = "2020-02-11 15:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    ElseIf time_end = "2020-02-11 16:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    End If
                End If
                If time_start = "2020-02-11 14:30:00" Then
                    If time_end = "2020-02-11 15:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    ElseIf time_end = "2020-02-11 16:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    End If

                End If
                If time_start = "2020-02-11 15:00:00" Then
                    If time_end = "2020-02-11 16:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    ElseIf time_end = "2020-02-11 17:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    End If
                End If
                If time_start = "2020-02-11 15:30:00" Then
                    If time_end = "2020-02-11 16:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    ElseIf time_end = "2020-02-11 17:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                    End If
                End If
                If time_start = "2020-02-11 16:00:00" Then

                    If time_end = "2020-02-11 17:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    ElseIf time_end = "2020-02-11 18:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                        time_combo.Items.Remove("6:00 PM")
                    End If
                End If


            ElseIf day_combo.Text = "Wednesday" Then

                If time_start = "2020-02-12 06:00:00" Then
                    If time_end = "2020-02-12 07:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-12 08:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                    End If
                End If
                If time_start = "2020-02-12 06:30:00" Then
                    If time_end = "2020-02-12 07:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-12 08:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    End If
                End If
                If time_start = "2020-02-12 07:00:00" Then

                    If time_end = "2020-02-12 08:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-12 09:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    End If
                End If
                If time_start = "2020-02-12 07:30:00" Then
                    If time_end = "2020-02-12 08:30:00" Then

                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-12 09:30:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("7:30 AM")

                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    End If
                End If
                If time_start = "2020-02-12 08:00:00" Then
                    If time_end = "2020-02-12 09:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    ElseIf time_end = "2020-02-12 10:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                    End If
                End If
                If time_start = "2020-02-12 08:30:00" Then
                    If time_end = "2020-02-12 09:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    ElseIf time_end = "2020-02-12 10:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                    End If
                End If

                If time_start = "2020-02-12 09:00:00" Then
                    If time_end = "2020-02-12 10:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")

                    ElseIf time_end = "2020-02-12 11:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                    End If
                End If
                If time_start = "2020-02-12 09:30:00" Then
                    If time_end = "2020-02-12 10:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")

                    ElseIf time_end = "2020-02-12 11:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                    End If
                End If
                If time_start = "2020-02-12 10:00:00" Then
                    If time_end = "2020-02-12 11:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")

                    ElseIf time_end = "2020-02-12 12:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                    End If
                End If
                If time_start = "2020-02-12 10:30:00" Then
                    If time_end = "2020-02-12 11:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")

                    ElseIf time_end = "2020-02-12 12:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                    End If
                End If
                If time_start = "2020-02-12 11:00:00" Then
                    If time_end = "2020-02-12 12:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")

                    ElseIf time_end = "2020-02-12 13:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                    End If
                End If
                If time_start = "2020-02-12 11:30:00" Then
                    If time_end = "2020-02-12 12:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")

                    ElseIf time_end = "2020-02-12 13:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                    End If
                End If
                If time_start = "2020-02-12 12:00:00" Then
                    If time_end = "2020-02-12 13:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")

                    ElseIf time_end = "2020-02-12 14:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                    End If
                End If
                If time_start = "2020-02-12 12:30:00" Then
                    If time_end = "2020-02-12 13:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")

                    ElseIf time_end = "2020-02-12 14:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                    End If
                End If
                If time_start = "2020-02-12 13:00:00" Then
                    If time_end = "2020-02-12 14:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")

                    ElseIf time_end = "2020-02-12 15:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    End If
                End If
                If time_start = "2020-02-12 13:30:00" Then
                    If time_end = "2020-02-12 14:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")


                    ElseIf time_end = "2020-02-12 15:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    End If
                End If
                If time_start = "2020-02-12 14:00:00" Then
                    If time_end = "2020-02-12 15:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    ElseIf time_end = "2020-02-12 16:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    End If
                End If
                If time_start = "2020-02-12 14:30:00" Then
                    If time_end = "2020-02-12 15:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    ElseIf time_end = "2020-02-12 16:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    End If

                End If
                If time_start = "2020-02-12 15:00:00" Then
                    If time_end = "2020-02-12 16:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    ElseIf time_end = "2020-02-12 17:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    End If
                End If
                If time_start = "2020-02-12 15:30:00" Then
                    If time_end = "2020-02-12 16:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    ElseIf time_end = "2020-02-12 17:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                    End If
                End If
                If time_start = "2020-02-12 16:00:00" Then

                    If time_end = "2020-02-12 17:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    ElseIf time_end = "2020-02-12 18:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                        time_combo.Items.Remove("6:00 PM")
                    End If
                End If
            ElseIf day_combo.Text = "Thursday" Then

                If time_start = "2020-02-13 06:00:00" Then
                    If time_end = "2020-02-13 07:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-13 08:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                    End If
                End If
                If time_start = "2020-02-13 06:30:00" Then
                    If time_end = "2020-02-13 07:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-13 08:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    End If
                End If
                If time_start = "2020-02-13 07:00:00" Then

                    If time_end = "2020-02-13 08:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-13 09:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    End If
                End If
                If time_start = "2020-02-13 07:30:00" Then
                    If time_end = "2020-02-13 08:30:00" Then

                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-13 09:30:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("7:30 AM")

                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    End If
                End If
                If time_start = "2020-02-13 08:00:00" Then
                    If time_end = "2020-02-13 09:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    ElseIf time_end = "2020-02-13 10:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                    End If
                End If
                If time_start = "2020-02-13 08:30:00" Then
                    If time_end = "2020-02-13 09:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    ElseIf time_end = "2020-02-13 10:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                    End If
                End If

                If time_start = "2020-02-13 09:00:00" Then
                    If time_end = "2020-02-13 10:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")

                    ElseIf time_end = "2020-02-13 11:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                    End If
                End If
                If time_start = "2020-02-13 09:30:00" Then
                    If time_end = "2020-02-13 10:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")

                    ElseIf time_end = "2020-02-13 11:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                    End If
                End If
                If time_start = "2020-02-13 10:00:00" Then
                    If time_end = "2020-02-13 11:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")

                    ElseIf time_end = "2020-02-13 12:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                    End If
                End If
                If time_start = "2020-02-13 10:30:00" Then
                    If time_end = "2020-02-13 11:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")

                    ElseIf time_end = "2020-02-13 12:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                    End If
                End If
                If time_start = "2020-02-13 11:00:00" Then
                    If time_end = "2020-02-13 12:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")

                    ElseIf time_end = "2020-02-13 13:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                    End If
                End If
                If time_start = "2020-02-13 11:30:00" Then
                    If time_end = "2020-02-13 12:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")

                    ElseIf time_end = "2020-02-13 13:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                    End If
                End If
                If time_start = "2020-02-13 12:00:00" Then
                    If time_end = "2020-02-13 13:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")

                    ElseIf time_end = "2020-02-13 14:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                    End If
                End If
                If time_start = "2020-02-13 12:30:00" Then
                    If time_end = "2020-02-13 13:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")

                    ElseIf time_end = "2020-02-13 14:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                    End If
                End If
                If time_start = "2020-02-13 13:00:00" Then
                    If time_end = "2020-02-13 14:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")

                    ElseIf time_end = "2020-02-13 15:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    End If
                End If
                If time_start = "2020-02-13 13:30:00" Then
                    If time_end = "2020-02-13 14:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")


                    ElseIf time_end = "2020-02-13 15:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    End If
                End If
                If time_start = "2020-02-13 14:00:00" Then
                    If time_end = "2020-02-13 15:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    ElseIf time_end = "2020-02-13 16:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    End If
                End If
                If time_start = "2020-02-13 14:30:00" Then
                    If time_end = "2020-02-13 15:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    ElseIf time_end = "2020-02-13 16:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    End If

                End If
                If time_start = "2020-02-13 15:00:00" Then
                    If time_end = "2020-02-13 16:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    ElseIf time_end = "2020-02-13 17:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    End If
                End If
                If time_start = "2020-02-13 15:30:00" Then
                    If time_end = "2020-02-13 16:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    ElseIf time_end = "2020-02-13 17:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                    End If
                End If
                If time_start = "2020-02-13 16:00:00" Then

                    If time_end = "2020-02-13 17:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    ElseIf time_end = "2020-02-13 18:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                        time_combo.Items.Remove("6:00 PM")
                    End If
                End If
            ElseIf day_combo.Text = "Friday" Then

                If time_start = "2020-02-14 06:00:00" Then
                    If time_end = "2020-02-14 07:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-14 08:00:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                    End If
                End If
                If time_start = "2020-02-14 06:30:00" Then
                    If time_end = "2020-02-14 07:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                    ElseIf time_end = "2020-02-14 08:30:00" Then
                        time_combo.Items.Remove("6:30 AM")
                        time_combo.Items.Remove("6:00 AM")
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    End If
                End If
                If time_start = "2020-02-14 07:00:00" Then

                    If time_end = "2020-02-14 08:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-14 09:00:00" Then
                        time_combo.Items.Remove("7:00 AM")
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    End If
                End If
                If time_start = "2020-02-14 07:30:00" Then
                    If time_end = "2020-02-14 08:30:00" Then

                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("7:30 AM")
                        time_combo.Items.Remove("8:30 AM")
                    ElseIf time_end = "2020-02-14 09:30:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("7:30 AM")

                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    End If
                End If
                If time_start = "2020-02-14 08:00:00" Then
                    If time_end = "2020-02-14 09:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                    ElseIf time_end = "2020-02-14 10:00:00" Then
                        time_combo.Items.Remove("8:00 AM")
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                    End If
                End If
                If time_start = "2020-02-14 08:30:00" Then
                    If time_end = "2020-02-14 09:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")

                    ElseIf time_end = "2020-02-14 10:30:00" Then
                        time_combo.Items.Remove("8:30 AM")
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                    End If
                End If

                If time_start = "2020-02-14 09:00:00" Then
                    If time_end = "2020-02-14 10:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")

                    ElseIf time_end = "2020-02-14 11:00:00" Then
                        time_combo.Items.Remove("9:00 AM")
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                    End If
                End If
                If time_start = "2020-02-14 09:30:00" Then
                    If time_end = "2020-02-14 10:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")

                    ElseIf time_end = "2020-02-14 11:30:00" Then
                        time_combo.Items.Remove("9:30 AM")
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                    End If
                End If
                If time_start = "2020-02-14 10:00:00" Then
                    If time_end = "2020-02-14 11:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")

                    ElseIf time_end = "2020-02-14 12:00:00" Then
                        time_combo.Items.Remove("10:00 AM")
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                    End If
                End If
                If time_start = "2020-02-14 10:30:00" Then
                    If time_end = "2020-02-14 11:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")

                    ElseIf time_end = "2020-02-14 12:30:00" Then
                        time_combo.Items.Remove("10:30 AM")
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                    End If
                End If
                If time_start = "2020-02-14 11:00:00" Then
                    If time_end = "2020-02-14 12:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")

                    ElseIf time_end = "2020-02-14 13:00:00" Then
                        time_combo.Items.Remove("11:00 AM")
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                    End If
                End If
                If time_start = "2020-02-14 11:30:00" Then
                    If time_end = "2020-02-14 12:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")

                    ElseIf time_end = "2020-02-14 13:30:00" Then
                        time_combo.Items.Remove("11:30 AM")
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                    End If
                End If
                If time_start = "2020-02-14 12:00:00" Then
                    If time_end = "2020-02-14 13:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")

                    ElseIf time_end = "2020-02-14 14:00:00" Then
                        time_combo.Items.Remove("12:00 PM")
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                    End If
                End If
                If time_start = "2020-02-14 12:30:00" Then
                    If time_end = "2020-02-14 13:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")

                    ElseIf time_end = "2020-02-14 14:30:00" Then
                        time_combo.Items.Remove("12:30 PM")
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                    End If
                End If
                If time_start = "2020-02-14 13:00:00" Then
                    If time_end = "2020-02-14 14:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")

                    ElseIf time_end = "2020-02-14 15:00:00" Then
                        time_combo.Items.Remove("1:00 PM")
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    End If
                End If
                If time_start = "2020-02-14 13:30:00" Then
                    If time_end = "2020-02-14 14:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")


                    ElseIf time_end = "2020-02-14 15:30:00" Then
                        time_combo.Items.Remove("1:30 PM")
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    End If
                End If
                If time_start = "2020-02-14 14:00:00" Then
                    If time_end = "2020-02-14 15:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                    ElseIf time_end = "2020-02-14 16:00:00" Then
                        time_combo.Items.Remove("2:00 PM")
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    End If
                End If
                If time_start = "2020-02-14 14:30:00" Then
                    If time_end = "2020-02-14 15:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                    ElseIf time_end = "2020-02-14 16:30:00" Then
                        time_combo.Items.Remove("2:30 PM")
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    End If

                End If
                If time_start = "2020-02-14 15:00:00" Then
                    If time_end = "2020-02-14 16:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                    ElseIf time_end = "2020-02-14 17:00:00" Then
                        time_combo.Items.Remove("3:00 PM")
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    End If
                End If
                If time_start = "2020-02-14 15:30:00" Then
                    If time_end = "2020-02-14 16:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                    ElseIf time_end = "2020-02-14 17:30:00" Then
                        time_combo.Items.Remove("3:30 PM")
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                    End If
                End If
                If time_start = "2020-02-14 16:00:00" Then

                    If time_end = "2020-02-14 17:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                    ElseIf time_end = "2020-02-14 18:00:00" Then
                        time_combo.Items.Remove("4:00 PM")
                        time_combo.Items.Remove("4:30 PM")
                        time_combo.Items.Remove("5:00 PM")
                        time_combo.Items.Remove("5:30 PM")
                        time_combo.Items.Remove("6:00 PM")
                    End If
                End If
            End If
        End While

    End Sub
End Class
