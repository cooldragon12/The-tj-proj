Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Prixport_Form
    Private Sub choice_to_ST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles choice_to_ST.SelectedIndexChanged
        If choice_to_ST.Text = "Teacher" Then
            choose_expo.Enabled = True
            print_sy.Enabled = True
            print_sem.Enabled = True
        End If
    End Sub
    Dim cmd As MySqlCommand
    Dim adapt As MySqlDataAdapter
    Dim ds As DataSet
    Dim scon As New SQLCn
    Dim tb As DataTable
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook


    Dim strFileName As String

    Private Sub browse_loc_Click(sender As Object, e As EventArgs) Handles browse_loc.Click
        Dim fd As New SaveFileDialog()
        Dim strFileName As String

        fd.Title = "Save File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            location_text.Text = strFileName
        End If
    End Sub

    Private Sub load_sy()
        Dim sylist As String = "select * from schoolterm"
        cmd = New MySqlCommand(sylist, scon.GetConnection)
        scon.CloseConnection()
        scon.OpenConnection()
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            Dim sy As String = read.GetString("sy")

            print_sy.Items.Add(sy)
        End While
        read.Close()
    End Sub

    Private Sub Choose_expo_Loaded()
        Try
            scon.CloseConnection()
            scon.OpenConnection()
            adapt = New MySqlDataAdapter("select ID_Prof, Concat(FName_prof, LName_prof) as 'name' from prof_details_tbl", scon.GetConnection)
            ds = New DataSet
            adapt.Fill(ds)

            choose_expo.DataSource = ds.Tables(0)
            choose_expo.ValueMember = "ID_Prof"
            choose_expo.DisplayMember = "name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Prixport_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_sy()
        Choose_expo_Loaded()
        print_sem.Enabled = False
        print_sy.Enabled = False
        choose_expo.Enabled = False
        print_ex_but.Enabled = False
    End Sub

#Disable Warning BC40004 ' variable 'name' conflicts with property 'name' in the base class 'Control' and should be declared 'Shadows'.
    Dim name As String
#Enable Warning BC40004 ' variable 'name' conflicts with property 'name' in the base class 'Control' and should be declared 'Shadows'.
    Private Sub print_ex_but_Click(sender As Object, e As EventArgs) Handles print_ex_but.Click
        Dim id As String = choose_expo.SelectedValue
        Dim s As String
        s = "select prof_details_tbl.FName_prof,prof_details_tbl.MName_prof,prof_details_tbl.LName_prof,subjects_tbl.subject_Name, 
`schedule_tbl`.strandName,`schedule_tbl`.grade_lvl, schedule_tbl.section_no, `schedule_tbl`.building_no,`schedule_tbl`.room_no, schedule_tbl.time_start, schedule_tbl.time_end from prof_details_tbl ,schedule_tbl inner join subjects_tbl on schedule_tbl.subject = subjects_tbl.snn 
where prof_details_tbl.ID_Prof='" + id + "' and `schedule_tbl`.`id_Prof`='" + id + "' and sy='" + print_sy.Text + "' and semestral_sche='" + print_sem.Text + "'"
        scon.CloseConnection()

        scon.OpenConnection()
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row1 As DataRow = tb.Rows(0)
        Dim f As String = row1(0)
        Dim l As String = row1(2)
        name = f + " " + l
        Dim checkccount As String = "select count(id_Prof) as 'che' from schedule_tbl where id_Prof='" + id + "' and semestral_sche ='" + print_sem.Text + "' and sy='" + print_sy.Text + "'"

        CreateExcelSchedule_format()
        cmd = New MySqlCommand(checkccount, scon.GetConnection)
        scon.OpenConnection()
        Dim rread As MySqlDataReader = cmd.ExecuteReader()

        rread.Read()

        Dim insertlimit As Integer = rread.Item("che")
        If insertlimit = 1 Then
            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow1()
        ElseIf insertlimit = 2 Then
            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow1()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow2()
        ElseIf insertlimit = 3 Then
            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow1()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow2()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow3()
        ElseIf insertlimit = 4 Then
            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow1()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow2()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow3()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow4()
        ElseIf insertlimit = 5 Then
            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow1()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow2()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow3()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow4()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow5()
        ElseIf insertlimit = 6 Then
            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow1()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow2()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow3()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow4()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow5()

            scon.CloseConnection()
            scon.OpenConnection()
            CheckDateToInsertRow6()

        End If


        worksheet.SaveAs(location_text.Text)
            workbook.Close()

            APP.Quit()

    End Sub
    Dim time_start As Date
    Dim time_end As Date


    'Row1
    Private Sub CheckDateToInsertRow1()
        Dim id As String = choose_expo.SelectedValue
        Dim s As String = "select prof_details_tbl.`FName_prof`, 
    prof_details_tbl.`MName_prof`, 
    prof_details_tbl.`LName_prof`,
    subjects_tbl.subject_Name, 
    `schedule_tbl`.strandName, 
    `schedule_tbl`.grade_lvl, 
    `schedule_tbl`.section_no, `schedule_tbl`.building_no, 
    `schedule_tbl`.room_no,
schedule_tbl.time_start, 
schedule_tbl.time_end from prof_details_tbl ,schedule_tbl inner join subjects_tbl on schedule_tbl.subject = subjects_tbl.snn
    where prof_details_tbl.ID_Prof='" + id + "' and `schedule_tbl`.`id_Prof`='" + id + "' and sy='" + print_sy.Text + "' and semestral_sche='" + print_sem.Text + "'"
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row1 As DataRow = tb.Rows(0)
        Dim subject As String = row1(3)
        Dim section As String = row1(4) + " " + row1(5) + "-" + row1(6)
        Dim room As String = row1(7) + " " + row1(8)
        time_start = row1(9)
        time_end = row1(10)
        'Monday start
        If time_start = "2020-02-10 06:00:00" Then
            If time_end = "2020-02-10 07:00:00" Then
                worksheet.Range("B4:B6").Merge()
                worksheet.Range("C4:C6").Merge()
                worksheet.Range("D4:D6").Merge()
                worksheet.Range("B4:B6").Value = subject
                worksheet.Range("C4:C6").Value = section
                worksheet.Range("D4:D6").Value = room
            ElseIf time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B4:B8").Merge()
                worksheet.Range("C4:C8").Merge()
                worksheet.Range("D4:D8").Merge()
                worksheet.Range("B4:B8").Value = subject
                worksheet.Range("C4:C8").Value = section
                worksheet.Range("D4:D8").Value = room
            End If
        ElseIf time_start = "2020-02-10 06:30:00" Then

            If time_end = "2020-02-10 07:30:00" Then
                worksheet.Range("B5:B7").Merge()
                worksheet.Range("C5:C7").Merge()
                worksheet.Range("D5:D7").Merge()
                worksheet.Range("B5:B7").Value = subject
                worksheet.Range("C5:C7").Value = section
                worksheet.Range("D5:D7").Value = room
            ElseIf time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B5:B9").Merge()
                worksheet.Range("C5:C9").Merge()
                worksheet.Range("D5:D9").Merge()
                worksheet.Range("B5:B9").Value = subject
                worksheet.Range("C5:C9").Value = section
            End If
            worksheet.Range("D5:D9").Value = room
        ElseIf time_start = "2020-02-10 07:00:00" Then
            If time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B6:B8").Merge()
                worksheet.Range("C6:C8").Merge()
                worksheet.Range("D6:D8").Merge()
                worksheet.Range("B6:B8").Value = subject
                worksheet.Range("C6:C8").Value = section
                worksheet.Range("D6:D8").Value = room
            ElseIf time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B6:B10").Merge()
                worksheet.Range("C6:C10").Merge()
                worksheet.Range("D6:D10").Merge()
                worksheet.Range("B6:B10").Value = subject
                worksheet.Range("C6:C10").Value = section
                worksheet.Range("D6:D10").Value = room
            End If
        ElseIf time_start = "2020-02-10 07:30:00" Then
            If time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B7:B9").Merge()
                worksheet.Range("C7:C9").Merge()
                worksheet.Range("D7:D9").Merge()
                worksheet.Range("B7:B9").Value = subject
                worksheet.Range("C7:C9").Value = section
                worksheet.Range("D7:D9").Value = room
            ElseIf time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B7:B11").Merge()
                worksheet.Range("C7:C11").Merge()
                worksheet.Range("D7:D11").Merge()
                worksheet.Range("B7:B11").Value = subject
                worksheet.Range("C7:C11").Value = section
                worksheet.Range("D7:D11").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:00:00" Then
            If time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B8:B10").Merge()
                worksheet.Range("C8:C10").Merge()
                worksheet.Range("D8:D10").Merge()
                worksheet.Range("B8:B10").Value = subject
                worksheet.Range("C8:C10").Value = section
                worksheet.Range("D8:D10").Value = room
            ElseIf time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B8:B12").Merge()
                worksheet.Range("C8:C12").Merge()
                worksheet.Range("D8:D12").Merge()
                worksheet.Range("B8:B12").Value = subject
                worksheet.Range("C8:C12").Value = section
                worksheet.Range("D8:D12").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:30:00" Then
            If time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B9:B11").Merge()
                worksheet.Range("C9:C11").Merge()
                worksheet.Range("D9:D11").Merge()
                worksheet.Range("B9:B11").Value = subject
                worksheet.Range("C9:C11").Value = section
                worksheet.Range("D9:D11").Value = room
            ElseIf time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B6:B13").Merge()
                worksheet.Range("C9:C13").Merge()
                worksheet.Range("D9:D13").Merge()
                worksheet.Range("B9:B13").Value = subject
                worksheet.Range("C9:C13").Value = section
                worksheet.Range("D9:D13").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:00:00" Then
            If time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B10:B12").Merge()
                worksheet.Range("C10:C12").Merge()
                worksheet.Range("D10:D12").Merge()
                worksheet.Range("B10:B12").Value = subject
                worksheet.Range("C10:C12").Value = section
                worksheet.Range("D10:D12").Value = room
            ElseIf time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B10:B14").Merge()
                worksheet.Range("C10:C14").Merge()
                worksheet.Range("D10:D14").Merge()
                worksheet.Range("B10:B14").Value = subject
                worksheet.Range("C10:C14").Value = section
                worksheet.Range("D10:D14").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:30:00" Then
            If time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B11:B13").Merge()
                worksheet.Range("C11:C13").Merge()
                worksheet.Range("D11:D13").Merge()
                worksheet.Range("B11:B13").Value = subject
                worksheet.Range("C11:C13").Value = section
                worksheet.Range("D11:D13").Value = room
            ElseIf time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B11:B15").Merge()
                worksheet.Range("C11:C15").Merge()
                worksheet.Range("D11:D15").Merge()
                worksheet.Range("B11:B15").Value = subject
                worksheet.Range("C11:C15").Value = section
                worksheet.Range("D11:D15").Value = room
            End If
        ElseIf time_start = "2020-02-10 10:00:00" Then
            If time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B12:B14").Merge()
                worksheet.Range("C12:C14").Merge()
                worksheet.Range("D12:D14").Merge()
                worksheet.Range("B12:B14").Value = subject
                worksheet.Range("C12:C14").Value = section
                worksheet.Range("D12:D14").Value = room

            ElseIf time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B12:B16").Merge()
                worksheet.Range("C12:C16").Merge()
                worksheet.Range("D12:D16").Merge()
                worksheet.Range("B12:B16").Value = subject
                worksheet.Range("C12:C16").Value = section
                worksheet.Range("D12:D16").Value = room

            End If
        End If
        If time_start = "2020-02-10 10:30:00" Then
            If time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B13:B15").Merge()
                worksheet.Range("C13:C15").Merge()
                worksheet.Range("D13:D15").Merge()
                worksheet.Range("B13:B15").Value = subject
                worksheet.Range("C13:C15").Value = section
                worksheet.Range("D13:D15").Value = room
            ElseIf time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B13:B17").Merge()
                worksheet.Range("C13:C17").Merge()
                worksheet.Range("D13:D17").Merge()
                worksheet.Range("B13:B17").Value = subject
                worksheet.Range("C13:C17").Value = section
                worksheet.Range("D13:D17").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:00:00" Then
            If time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B14:B16").Merge()
                worksheet.Range("C14:C16").Merge()
                worksheet.Range("D14:D16").Merge()
                worksheet.Range("B14:B16").Value = subject
                worksheet.Range("C14:C16").Value = section
                worksheet.Range("D14:D16").Value = room
            ElseIf time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B14:B18").Merge()
                worksheet.Range("C14:C18").Merge()
                worksheet.Range("D14:D18").Merge()
                worksheet.Range("B14:B18").Value = subject
                worksheet.Range("C14:C18").Value = section
                worksheet.Range("D14:D18").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:30:00" Then
            If time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B15:B17").Merge()
                worksheet.Range("C15:C17").Merge()
                worksheet.Range("D15:D17").Merge()
                worksheet.Range("B15:B17").Value = subject
                worksheet.Range("C15:C17").Value = section
                worksheet.Range("D15:D17").Value = room
            ElseIf time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B15:B19").Merge()
                worksheet.Range("C15:C19").Merge()
                worksheet.Range("D15:D19").Merge()
                worksheet.Range("B15:B19").Value = subject
                worksheet.Range("C15:C19").Value = section
                worksheet.Range("D15:D19").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:00:00" Then
            If time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B16:B14").Merge()
                worksheet.Range("C16:C18").Merge()
                worksheet.Range("D16:D18").Merge()
                worksheet.Range("B16:B18").Value = subject
                worksheet.Range("C16:C18").Value = section
                worksheet.Range("D16:D18").Value = room
            ElseIf time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B16:B20").Merge()
                worksheet.Range("C16:C20").Merge()
                worksheet.Range("D16:D20").Merge()
                worksheet.Range("B16:B20").Value = subject
                worksheet.Range("C16:C20").Value = section
                worksheet.Range("D16:D20").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:30:00" Then
            If time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B17:B19").Merge()
                worksheet.Range("C17:C19").Merge()
                worksheet.Range("D17:D19").Merge()
                worksheet.Range("B17:B19").Value = subject
                worksheet.Range("C17:C19").Value = section
                worksheet.Range("D17:D19").Value = room
            ElseIf time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B17:B21").Merge()
                worksheet.Range("C17:C21").Merge()
                worksheet.Range("D17:D21").Merge()
                worksheet.Range("B17:B21").Value = subject
                worksheet.Range("C17:C21").Value = section
                worksheet.Range("D17:D21").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:00:00" Then
            If time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B18:B20").Merge()
                worksheet.Range("C18:C20").Merge()
                worksheet.Range("D18:D20").Merge()
                worksheet.Range("B18:B20").Value = subject
                worksheet.Range("C18:C20").Value = section
                worksheet.Range("D18:D20").Value = room
            ElseIf time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B18:B22").Merge()
                worksheet.Range("C18:C22").Merge()
                worksheet.Range("D18:D22").Merge()
                worksheet.Range("B18:B22").Value = subject
                worksheet.Range("C18:C22").Value = section
                worksheet.Range("D18:D22").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:30:00" Then
            If time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B19:B21").Merge()
                worksheet.Range("C19:C21").Merge()
                worksheet.Range("D19:D21").Merge()
                worksheet.Range("B19:B21").Value = subject
                worksheet.Range("C19:C21").Value = section
                worksheet.Range("D19:D21").Value = room
            ElseIf time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B19:B23").Merge()
                worksheet.Range("C19:C23").Merge()
                worksheet.Range("D19:D23").Merge()
                worksheet.Range("B19:B23").Value = subject
                worksheet.Range("C19:C23").Value = section
                worksheet.Range("D19:D23").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:00:00" Then
            If time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B20:B22").Merge()
                worksheet.Range("C20:C22").Merge()
                worksheet.Range("D20:D22").Merge()
                worksheet.Range("B20:B22").Value = subject
                worksheet.Range("C20:C22").Value = section
                worksheet.Range("D20:D22").Value = room
            ElseIf time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B20:B24").Merge()
                worksheet.Range("C20:C24").Merge()
                worksheet.Range("D20:D24").Merge()
                worksheet.Range("B20:B24").Value = subject
                worksheet.Range("C20:C24").Value = section
                worksheet.Range("D20:D24").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:30:00" Then
            If time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B21:B23").Merge()
                worksheet.Range("C21:C23").Merge()
                worksheet.Range("D21:D23").Merge()
                worksheet.Range("B21:B23").Value = subject
                worksheet.Range("C21:C23").Value = section
                worksheet.Range("D21:D23").Value = room
            ElseIf time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B21:B25").Merge()
                worksheet.Range("C21:C25").Merge()
                worksheet.Range("D21:D25").Merge()
                worksheet.Range("B21:B25").Value = subject
                worksheet.Range("C21:C25").Value = section
                worksheet.Range("D21:D25").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:00:00" Then
            If time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B22:B24").Merge()
                worksheet.Range("C22:C24").Merge()
                worksheet.Range("D22:D24").Merge()
                worksheet.Range("B22:B24").Value = subject
                worksheet.Range("C22:C24").Value = section
                worksheet.Range("D22:D24").Value = room
            ElseIf time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B22:B26").Merge()
                worksheet.Range("C22:C26").Merge()
                worksheet.Range("D22:D26").Merge()
                worksheet.Range("B22:B26").Value = subject
                worksheet.Range("C22:C26").Value = section
                worksheet.Range("D22:D26").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:30:00" Then
            If time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B23:B25").Merge()
                worksheet.Range("C23:C25").Merge()
                worksheet.Range("D23:D25").Merge()
                worksheet.Range("B23:B25").Value = subject
                worksheet.Range("C23:C25").Value = section
                worksheet.Range("D23:D25").Value = room
            ElseIf time_end = "2020-02-10 17:30:00" Then
                worksheet.Range("B23:B27").Merge()
                worksheet.Range("C23:C27").Merge()
                worksheet.Range("D23:D27").Merge()
                worksheet.Range("B23:B27").Value = subject
                worksheet.Range("C23:C27").Value = section
                worksheet.Range("D23:D27").Value = room
            End If
        End If
        If time_start = "2020-02-10 16:00:00" Then
            If time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B24:B26").Merge()
                worksheet.Range("C24:C26").Merge()
                worksheet.Range("D24:D26").Merge()
                worksheet.Range("B24:B26").Value = subject
                worksheet.Range("C24:C26").Value = section
                worksheet.Range("D24:D26").Value = room
            ElseIf time_end = "2020-02-10 18:00:00" Then
                worksheet.Range("B24:B28").Merge()
                worksheet.Range("C24:C28").Merge()
                worksheet.Range("D24:D28").Merge()
                worksheet.Range("B24:B28").Value = subject
                worksheet.Range("C24:C28").Value = section
                worksheet.Range("D24:D28").Value = room
            End If
        End If



        'tuesday start-----------------------------------------------


        If time_start = "2020-02-11 06:00:00" Then
            If time_end = "2020-02-11 07:00:00" Then
                worksheet.Range("E4:E6").Merge()
                worksheet.Range("F4:F6").Merge()
                worksheet.Range("G4:G6").Merge()
                worksheet.Range("E4:E6").Value = subject
                worksheet.Range("F4:F6").Value = section
                worksheet.Range("G4:G6").Value = room
            ElseIf time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E4:E8").Merge()
                worksheet.Range("F4:F8").Merge()
                worksheet.Range("G4:G8").Merge()
                worksheet.Range("E4:E8").Value = subject
                worksheet.Range("F4:F8").Value = section
                worksheet.Range("G4:G8").Value = room
            End If
        ElseIf time_start = "2020-02-11 06:30:00" Then

            If time_end = "2020-02-11 07:30:00" Then
                worksheet.Range("E5:E7").Merge()
                worksheet.Range("F5:F7").Merge()
                worksheet.Range("G5:G7").Merge()
                worksheet.Range("E5:E7").Value = subject
                worksheet.Range("F5:F7").Value = section
                worksheet.Range("G5:G7").Value = room
            ElseIf time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E5:E9").Merge()
                worksheet.Range("F5:F9").Merge()
                worksheet.Range("G5:G9").Merge()
                worksheet.Range("E5:E9").Value = subject
                worksheet.Range("F5:F9").Value = section
            End If
            worksheet.Range("G5:G9").Value = room
        ElseIf time_start = "2020-02-11 07:00:00" Then
            If time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E6:E8").Merge()
                worksheet.Range("F6:F8").Merge()
                worksheet.Range("G6:G8").Merge()
                worksheet.Range("E6:E8").Value = subject
                worksheet.Range("F6:F8").Value = section
                worksheet.Range("G6:G8").Value = room
            ElseIf time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E6:E10").Merge()
                worksheet.Range("F6:F10").Merge()
                worksheet.Range("G6:G10").Merge()
                worksheet.Range("E6:E10").Value = subject
                worksheet.Range("F6:F10").Value = section
                worksheet.Range("G6:G10").Value = room
            End If
        ElseIf time_start = "2020-02-11 07:30:00" Then
            If time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E7:E9").Merge()
                worksheet.Range("F7:F9").Merge()
                worksheet.Range("G7:G9").Merge()
                worksheet.Range("E7:E9").Value = subject
                worksheet.Range("F7:F9").Value = section
                worksheet.Range("G7:G9").Value = room
            ElseIf time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E7:E11").Merge()
                worksheet.Range("F7:F11").Merge()
                worksheet.Range("G7:G11").Merge()
                worksheet.Range("E7:E11").Value = subject
                worksheet.Range("F7:F11").Value = section
                worksheet.Range("G7:G11").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:00:00" Then
            If time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E8:E10").Merge()
                worksheet.Range("F8:F10").Merge()
                worksheet.Range("G8:G10").Merge()
                worksheet.Range("E8:E10").Value = subject
                worksheet.Range("F8:F10").Value = section
                worksheet.Range("G8:G10").Value = room
            ElseIf time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E8:E12").Merge()
                worksheet.Range("F8:F12").Merge()
                worksheet.Range("G8:G12").Merge()
                worksheet.Range("E8:E12").Value = subject
                worksheet.Range("F8:F12").Value = section
                worksheet.Range("G8:G12").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:30:00" Then
            If time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E9:E11").Merge()
                worksheet.Range("F9:F11").Merge()
                worksheet.Range("G9:G11").Merge()
                worksheet.Range("E9:E11").Value = subject
                worksheet.Range("F9:F11").Value = section
                worksheet.Range("G9:G11").Value = room
            ElseIf time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E6:E13").Merge()
                worksheet.Range("F9:F13").Merge()
                worksheet.Range("G9:G13").Merge()
                worksheet.Range("E9:E13").Value = subject
                worksheet.Range("F9:F13").Value = section
                worksheet.Range("G9:G13").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:00:00" Then
            If time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E10:E12").Merge()
                worksheet.Range("F10:F12").Merge()
                worksheet.Range("G10:G12").Merge()
                worksheet.Range("E10:E12").Value = subject
                worksheet.Range("F10:F12").Value = section
                worksheet.Range("G10:G12").Value = room
            ElseIf time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E10:E14").Merge()
                worksheet.Range("F10:F14").Merge()
                worksheet.Range("G10:G14").Merge()
                worksheet.Range("E10:E14").Value = subject
                worksheet.Range("F10:F14").Value = section
                worksheet.Range("G10:G14").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:30:00" Then
            If time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E11:E13").Merge()
                worksheet.Range("F11:F13").Merge()
                worksheet.Range("G11:G13").Merge()
                worksheet.Range("E11:E13").Value = subject
                worksheet.Range("F11:F13").Value = section
                worksheet.Range("G11:G13").Value = room
            ElseIf time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E11:E15").Merge()
                worksheet.Range("F11:F15").Merge()
                worksheet.Range("G11:G15").Merge()
                worksheet.Range("E11:E15").Value = subject
                worksheet.Range("F11:F15").Value = section
                worksheet.Range("G11:G15").Value = room
            End If
        ElseIf time_start = "2020-02-11 10:00:00" Then
            If time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E12:E14").Merge()
                worksheet.Range("F12:F14").Merge()
                worksheet.Range("G12:G14").Merge()
                worksheet.Range("E12:E14").Value = subject
                worksheet.Range("F12:F14").Value = section
                worksheet.Range("G12:G14").Value = room

            ElseIf time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E12:E16").Merge()
                worksheet.Range("F12:F16").Merge()
                worksheet.Range("G12:G16").Merge()
                worksheet.Range("E12:E16").Value = subject
                worksheet.Range("F12:F16").Value = section
                worksheet.Range("G12:G16").Value = room

            End If
        End If
        If time_start = "2020-02-11 10:30:00" Then
            If time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E13:E15").Merge()
                worksheet.Range("F13:F15").Merge()
                worksheet.Range("G13:G15").Merge()
                worksheet.Range("E13:E15").Value = subject
                worksheet.Range("F13:F15").Value = section
                worksheet.Range("G13:G15").Value = room
            ElseIf time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E13:E17").Merge()
                worksheet.Range("F13:F17").Merge()
                worksheet.Range("G13:G17").Merge()
                worksheet.Range("E13:E17").Value = subject
                worksheet.Range("F13:F17").Value = section
                worksheet.Range("G13:G17").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:00:00" Then
            If time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E14:E16").Merge()
                worksheet.Range("F14:F16").Merge()
                worksheet.Range("G14:G16").Merge()
                worksheet.Range("E14:E16").Value = subject
                worksheet.Range("F14:F16").Value = section
                worksheet.Range("G14:G16").Value = room
            ElseIf time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E14:E18").Merge()
                worksheet.Range("F14:F18").Merge()
                worksheet.Range("G14:G18").Merge()
                worksheet.Range("E14:E18").Value = subject
                worksheet.Range("F14:F18").Value = section
                worksheet.Range("G14:G18").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:30:00" Then
            If time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E15:E17").Merge()
                worksheet.Range("F15:F17").Merge()
                worksheet.Range("G15:G17").Merge()
                worksheet.Range("E15:E17").Value = subject
                worksheet.Range("F15:F17").Value = section
                worksheet.Range("G15:G17").Value = room
            ElseIf time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E15:E19").Merge()
                worksheet.Range("F15:F19").Merge()
                worksheet.Range("G15:G19").Merge()
                worksheet.Range("E15:E19").Value = subject
                worksheet.Range("F15:F19").Value = section
                worksheet.Range("G15:G19").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:00:00" Then
            If time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E16:E14").Merge()
                worksheet.Range("F16:F18").Merge()
                worksheet.Range("G16:G18").Merge()
                worksheet.Range("E16:E18").Value = subject
                worksheet.Range("F16:F18").Value = section
                worksheet.Range("G16:G18").Value = room
            ElseIf time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E16:E20").Merge()
                worksheet.Range("F16:F20").Merge()
                worksheet.Range("G16:G20").Merge()
                worksheet.Range("E16:E20").Value = subject
                worksheet.Range("F16:F20").Value = section
                worksheet.Range("G16:G20").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:30:00" Then
            If time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E17:E19").Merge()
                worksheet.Range("F17:F19").Merge()
                worksheet.Range("G17:G19").Merge()
                worksheet.Range("E17:E19").Value = subject
                worksheet.Range("F17:F19").Value = section
                worksheet.Range("G17:G19").Value = room
            ElseIf time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E17:E21").Merge()
                worksheet.Range("F17:F21").Merge()
                worksheet.Range("G17:G21").Merge()
                worksheet.Range("E17:E21").Value = subject
                worksheet.Range("F17:F21").Value = section
                worksheet.Range("G17:G21").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:00:00" Then
            If time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E18:E20").Merge()
                worksheet.Range("F18:F20").Merge()
                worksheet.Range("G18:G20").Merge()
                worksheet.Range("E18:E20").Value = subject
                worksheet.Range("F18:F20").Value = section
                worksheet.Range("G18:G20").Value = room
            ElseIf time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E18:E22").Merge()
                worksheet.Range("F18:F22").Merge()
                worksheet.Range("G18:G22").Merge()
                worksheet.Range("E18:E22").Value = subject
                worksheet.Range("F18:F22").Value = section
                worksheet.Range("G18:G22").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:30:00" Then
            If time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E19:E21").Merge()
                worksheet.Range("F19:F21").Merge()
                worksheet.Range("G19:G21").Merge()
                worksheet.Range("E19:E21").Value = subject
                worksheet.Range("F19:F21").Value = section
                worksheet.Range("G19:G21").Value = room
            ElseIf time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E19:E23").Merge()
                worksheet.Range("F19:F23").Merge()
                worksheet.Range("G19:G23").Merge()
                worksheet.Range("E19:E23").Value = subject
                worksheet.Range("F19:F23").Value = section
                worksheet.Range("G19:G23").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:00:00" Then
            If time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E20:E22").Merge()
                worksheet.Range("F20:F22").Merge()
                worksheet.Range("G20:G22").Merge()
                worksheet.Range("E20:E22").Value = subject
                worksheet.Range("F20:F22").Value = section
                worksheet.Range("G20:G22").Value = room
            ElseIf time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E20:E24").Merge()
                worksheet.Range("F20:F24").Merge()
                worksheet.Range("G20:G24").Merge()
                worksheet.Range("E20:E24").Value = subject
                worksheet.Range("F20:F24").Value = section
                worksheet.Range("G20:G24").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:30:00" Then
            If time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E21:E23").Merge()
                worksheet.Range("F21:F23").Merge()
                worksheet.Range("G21:G23").Merge()
                worksheet.Range("E21:E23").Value = subject
                worksheet.Range("F21:F23").Value = section
                worksheet.Range("G21:G23").Value = room
            ElseIf time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E21:E25").Merge()
                worksheet.Range("F21:F25").Merge()
                worksheet.Range("G21:G25").Merge()
                worksheet.Range("E21:E25").Value = subject
                worksheet.Range("F21:F25").Value = section
                worksheet.Range("G21:G25").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:00:00" Then
            If time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E22:E24").Merge()
                worksheet.Range("F22:F24").Merge()
                worksheet.Range("G22:G24").Merge()
                worksheet.Range("E22:E24").Value = subject
                worksheet.Range("F22:F24").Value = section
                worksheet.Range("G22:G24").Value = room
            ElseIf time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E22:E26").Merge()
                worksheet.Range("F22:F26").Merge()
                worksheet.Range("G22:G26").Merge()
                worksheet.Range("E22:E26").Value = subject
                worksheet.Range("F22:F26").Value = section
                worksheet.Range("G22:G26").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:30:00" Then
            If time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E23:E25").Merge()
                worksheet.Range("F23:F25").Merge()
                worksheet.Range("G23:G25").Merge()
                worksheet.Range("E23:E25").Value = subject
                worksheet.Range("F23:F25").Value = section
                worksheet.Range("G23:G25").Value = room
            ElseIf time_end = "2020-02-11 17:30:00" Then
                worksheet.Range("E23:E27").Merge()
                worksheet.Range("F23:F27").Merge()
                worksheet.Range("G23:G27").Merge()
                worksheet.Range("E23:E27").Value = subject
                worksheet.Range("F23:F27").Value = section
                worksheet.Range("G23:G27").Value = room
            End If
        End If
        If time_start = "2020-02-11 16:00:00" Then
            If time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E24:E26").Merge()
                worksheet.Range("F24:F26").Merge()
                worksheet.Range("G24:G26").Merge()
                worksheet.Range("E24:E26").Value = subject
                worksheet.Range("F24:F26").Value = section
                worksheet.Range("G24:G26").Value = room
            ElseIf time_end = "2020-02-11 18:00:00" Then
                worksheet.Range("E24:E28").Merge()
                worksheet.Range("F24:F28").Merge()
                worksheet.Range("G24:G28").Merge()
                worksheet.Range("E24:E28").Value = subject
                worksheet.Range("F24:F28").Value = section
                worksheet.Range("G24:G28").Value = room
            End If
        End If


        ' wednesday


        If time_start = "2020-02-12 06:00:00" Then
            If time_end = "2020-02-12 07:00:00" Then
                worksheet.Range("H4:H6").Merge()
                worksheet.Range("I4:I6").Merge()
                worksheet.Range("J4:J6").Merge()
                worksheet.Range("H4:H6").Value = subject
                worksheet.Range("I4:I6").Value = section
                worksheet.Range("J4:J6").Value = room
            ElseIf time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H4:H8").Merge()
                worksheet.Range("I4:I8").Merge()
                worksheet.Range("J4:J8").Merge()
                worksheet.Range("H4:H8").Value = subject
                worksheet.Range("I4:I8").Value = section
                worksheet.Range("J4:J8").Value = room
            End If
        ElseIf time_start = "2020-02-12 06:30:00" Then

            If time_end = "2020-02-12 07:30:00" Then
                worksheet.Range("H5:H7").Merge()
                worksheet.Range("I5:I7").Merge()
                worksheet.Range("J5:J7").Merge()
                worksheet.Range("H5:H7").Value = subject
                worksheet.Range("I5:I7").Value = section
                worksheet.Range("J5:J7").Value = room
            ElseIf time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H5:H9").Merge()
                worksheet.Range("I5:I9").Merge()
                worksheet.Range("J5:J9").Merge()
                worksheet.Range("H5:H9").Value = subject
                worksheet.Range("I5:I9").Value = section
            End If
            worksheet.Range("J5:J9").Value = room
        ElseIf time_start = "2020-02-12 07:00:00" Then
            If time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H6:H8").Merge()
                worksheet.Range("I6:I8").Merge()
                worksheet.Range("J6:J8").Merge()
                worksheet.Range("H6:H8").Value = subject
                worksheet.Range("I6:I8").Value = section
                worksheet.Range("J6:J8").Value = room
            ElseIf time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H6:H10").Merge()
                worksheet.Range("I6:I10").Merge()
                worksheet.Range("J6:J10").Merge()
                worksheet.Range("H6:H10").Value = subject
                worksheet.Range("I6:I10").Value = section
                worksheet.Range("J6:J10").Value = room
            End If
        ElseIf time_start = "2020-02-12 07:30:00" Then
            If time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H7:H9").Merge()
                worksheet.Range("I7:I9").Merge()
                worksheet.Range("J7:J9").Merge()
                worksheet.Range("H7:H9").Value = subject
                worksheet.Range("I7:I9").Value = section
                worksheet.Range("J7:J9").Value = room
            ElseIf time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H7:H11").Merge()
                worksheet.Range("I7:I11").Merge()
                worksheet.Range("J7:J11").Merge()
                worksheet.Range("H7:H11").Value = subject
                worksheet.Range("I7:I11").Value = section
                worksheet.Range("J7:J11").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:00:00" Then
            If time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H8:H10").Merge()
                worksheet.Range("I8:I10").Merge()
                worksheet.Range("J8:J10").Merge()
                worksheet.Range("H8:H10").Value = subject
                worksheet.Range("I8:I10").Value = section
                worksheet.Range("J8:J10").Value = room
            ElseIf time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H8:H12").Merge()
                worksheet.Range("I8:I12").Merge()
                worksheet.Range("J8:J12").Merge()
                worksheet.Range("H8:H12").Value = subject
                worksheet.Range("I8:I12").Value = section
                worksheet.Range("J8:J12").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:30:00" Then
            If time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H9:H11").Merge()
                worksheet.Range("I9:I11").Merge()
                worksheet.Range("J9:J11").Merge()
                worksheet.Range("H9:H11").Value = subject
                worksheet.Range("I9:I11").Value = section
                worksheet.Range("J9:J11").Value = room
            ElseIf time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H6:H13").Merge()
                worksheet.Range("I9:I13").Merge()
                worksheet.Range("J9:J13").Merge()
                worksheet.Range("H9:H13").Value = subject
                worksheet.Range("I9:I13").Value = section
                worksheet.Range("J9:J13").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:00:00" Then
            If time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H10:H12").Merge()
                worksheet.Range("I10:I12").Merge()
                worksheet.Range("J10:J12").Merge()
                worksheet.Range("H10:H12").Value = subject
                worksheet.Range("I10:I12").Value = section
                worksheet.Range("J10:J12").Value = room
            ElseIf time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H10:H14").Merge()
                worksheet.Range("I10:I14").Merge()
                worksheet.Range("J10:J14").Merge()
                worksheet.Range("H10:H14").Value = subject
                worksheet.Range("I10:I14").Value = section
                worksheet.Range("J10:J14").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:30:00" Then
            If time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H11:H13").Merge()
                worksheet.Range("I11:I13").Merge()
                worksheet.Range("J11:J13").Merge()
                worksheet.Range("H11:H13").Value = subject
                worksheet.Range("I11:I13").Value = section
                worksheet.Range("J11:J13").Value = room
            ElseIf time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H11:H15").Merge()
                worksheet.Range("I11:I15").Merge()
                worksheet.Range("J11:J15").Merge()
                worksheet.Range("H11:H15").Value = subject
                worksheet.Range("I11:I15").Value = section
                worksheet.Range("J11:J15").Value = room
            End If
        ElseIf time_start = "2020-02-12 10:00:00" Then
            If time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H12:H14").Merge()
                worksheet.Range("I12:I14").Merge()
                worksheet.Range("J12:J14").Merge()
                worksheet.Range("H12:H14").Value = subject
                worksheet.Range("I12:I14").Value = section
                worksheet.Range("J12:J14").Value = room

            ElseIf time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H12:H16").Merge()
                worksheet.Range("I12:I16").Merge()
                worksheet.Range("J12:J16").Merge()
                worksheet.Range("H12:H16").Value = subject
                worksheet.Range("I12:I16").Value = section
                worksheet.Range("J12:J16").Value = room

            End If
        End If
        If time_start = "2020-02-12 10:30:00" Then
            If time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H13:H15").Merge()
                worksheet.Range("I13:I15").Merge()
                worksheet.Range("J13:J15").Merge()
                worksheet.Range("H13:H15").Value = subject
                worksheet.Range("I13:I15").Value = section
                worksheet.Range("J13:J15").Value = room
            ElseIf time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H13:H17").Merge()
                worksheet.Range("I13:I17").Merge()
                worksheet.Range("J13:J17").Merge()
                worksheet.Range("H13:H17").Value = subject
                worksheet.Range("I13:I17").Value = section
                worksheet.Range("J13:J17").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:00:00" Then
            If time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H14:H16").Merge()
                worksheet.Range("I14:I16").Merge()
                worksheet.Range("J14:J16").Merge()
                worksheet.Range("H14:H16").Value = subject
                worksheet.Range("I14:I16").Value = section
                worksheet.Range("J14:J16").Value = room
            ElseIf time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H14:H18").Merge()
                worksheet.Range("I14:I18").Merge()
                worksheet.Range("J14:J18").Merge()
                worksheet.Range("H14:H18").Value = subject
                worksheet.Range("I14:I18").Value = section
                worksheet.Range("J14:J18").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:30:00" Then
            If time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H15:H17").Merge()
                worksheet.Range("I15:I17").Merge()
                worksheet.Range("J15:J17").Merge()
                worksheet.Range("H15:H17").Value = subject
                worksheet.Range("I15:I17").Value = section
                worksheet.Range("J15:J17").Value = room
            ElseIf time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H15:H19").Merge()
                worksheet.Range("I15:I19").Merge()
                worksheet.Range("J15:J19").Merge()
                worksheet.Range("H15:H19").Value = subject
                worksheet.Range("I15:I19").Value = section
                worksheet.Range("J15:J19").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:00:00" Then
            If time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H16:H14").Merge()
                worksheet.Range("I16:I18").Merge()
                worksheet.Range("J16:J18").Merge()
                worksheet.Range("H16:H18").Value = subject
                worksheet.Range("I16:I18").Value = section
                worksheet.Range("J16:J18").Value = room
            ElseIf time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H16:H20").Merge()
                worksheet.Range("I16:I20").Merge()
                worksheet.Range("J16:J20").Merge()
                worksheet.Range("H16:H20").Value = subject
                worksheet.Range("I16:I20").Value = section
                worksheet.Range("J16:J20").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:30:00" Then
            If time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H17:H19").Merge()
                worksheet.Range("I17:I19").Merge()
                worksheet.Range("J17:J19").Merge()
                worksheet.Range("H17:H19").Value = subject
                worksheet.Range("I17:I19").Value = section
                worksheet.Range("J17:J19").Value = room
            ElseIf time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H17:H21").Merge()
                worksheet.Range("I17:I21").Merge()
                worksheet.Range("J17:J21").Merge()
                worksheet.Range("H17:H21").Value = subject
                worksheet.Range("I17:I21").Value = section
                worksheet.Range("J17:J21").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:00:00" Then
            If time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H18:H20").Merge()
                worksheet.Range("I18:I20").Merge()
                worksheet.Range("J18:J20").Merge()
                worksheet.Range("H18:H20").Value = subject
                worksheet.Range("I18:I20").Value = section
                worksheet.Range("J18:J20").Value = room
            ElseIf time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H18:H22").Merge()
                worksheet.Range("I18:I22").Merge()
                worksheet.Range("J18:J22").Merge()
                worksheet.Range("H18:H22").Value = subject
                worksheet.Range("I18:I22").Value = section
                worksheet.Range("J18:J22").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:30:00" Then
            If time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H19:H21").Merge()
                worksheet.Range("I19:I21").Merge()
                worksheet.Range("J19:J21").Merge()
                worksheet.Range("H19:H21").Value = subject
                worksheet.Range("I19:I21").Value = section
                worksheet.Range("J19:J21").Value = room
            ElseIf time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H19:H23").Merge()
                worksheet.Range("I19:I23").Merge()
                worksheet.Range("J19:J23").Merge()
                worksheet.Range("H19:H23").Value = subject
                worksheet.Range("I19:I23").Value = section
                worksheet.Range("J19:J23").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:00:00" Then
            If time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H20:H22").Merge()
                worksheet.Range("I20:I22").Merge()
                worksheet.Range("J20:J22").Merge()
                worksheet.Range("H20:H22").Value = subject
                worksheet.Range("I20:I22").Value = section
                worksheet.Range("J20:J22").Value = room
            ElseIf time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H20:H24").Merge()
                worksheet.Range("I20:I24").Merge()
                worksheet.Range("J20:J24").Merge()
                worksheet.Range("H20:H24").Value = subject
                worksheet.Range("I20:I24").Value = section
                worksheet.Range("J20:J24").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:30:00" Then
            If time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H21:H23").Merge()
                worksheet.Range("I21:I23").Merge()
                worksheet.Range("J21:J23").Merge()
                worksheet.Range("H21:H23").Value = subject
                worksheet.Range("I21:I23").Value = section
                worksheet.Range("J21:J23").Value = room
            ElseIf time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H21:H25").Merge()
                worksheet.Range("I21:I25").Merge()
                worksheet.Range("J21:J25").Merge()
                worksheet.Range("H21:H25").Value = subject
                worksheet.Range("I21:I25").Value = section
                worksheet.Range("J21:J25").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:00:00" Then
            If time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H22:H24").Merge()
                worksheet.Range("I22:I24").Merge()
                worksheet.Range("J22:J24").Merge()
                worksheet.Range("H22:H24").Value = subject
                worksheet.Range("I22:I24").Value = section
                worksheet.Range("J22:J24").Value = room
            ElseIf time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H22:H26").Merge()
                worksheet.Range("I22:I26").Merge()
                worksheet.Range("J22:J26").Merge()
                worksheet.Range("H22:H26").Value = subject
                worksheet.Range("I22:I26").Value = section
                worksheet.Range("J22:J26").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:30:00" Then
            If time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H23:H25").Merge()
                worksheet.Range("I23:I25").Merge()
                worksheet.Range("J23:J25").Merge()
                worksheet.Range("H23:H25").Value = subject
                worksheet.Range("I23:I25").Value = section
                worksheet.Range("J23:J25").Value = room
            ElseIf time_end = "2020-02-12 17:30:00" Then
                worksheet.Range("H23:H27").Merge()
                worksheet.Range("I23:I27").Merge()
                worksheet.Range("J23:J27").Merge()
                worksheet.Range("H23:H27").Value = subject
                worksheet.Range("I23:I27").Value = section
                worksheet.Range("J23:J27").Value = room
            End If
        End If
        If time_start = "2020-02-12 16:00:00" Then
            If time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H24:H26").Merge()
                worksheet.Range("I24:I26").Merge()
                worksheet.Range("J24:J26").Merge()
                worksheet.Range("H24:H26").Value = subject
                worksheet.Range("I24:I26").Value = section
                worksheet.Range("J24:J26").Value = room
            ElseIf time_end = "2020-02-12 18:00:00" Then
                worksheet.Range("H24:H28").Merge()
                worksheet.Range("I24:I28").Merge()
                worksheet.Range("J24:J28").Merge()
                worksheet.Range("H24:H28").Value = subject
                worksheet.Range("I24:I28").Value = section
                worksheet.Range("J24:J28").Value = room
            End If
        End If


        'Thursday

        If time_start = "2020-02-13 06:00:00" Then
            If time_end = "2020-02-13 07:00:00" Then
                worksheet.Range("K4:K6").Merge()
                worksheet.Range("L4:L6").Merge()
                worksheet.Range("M4:M6").Merge()
                worksheet.Range("K4:K6").Value = subject
                worksheet.Range("L4:L6").Value = section
                worksheet.Range("M4:M6").Value = room
            ElseIf time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K4:K8").Merge()
                worksheet.Range("L4:L8").Merge()
                worksheet.Range("M4:M8").Merge()
                worksheet.Range("K4:K8").Value = subject
                worksheet.Range("L4:L8").Value = section
                worksheet.Range("M4:M8").Value = room
            End If
        ElseIf time_start = "2020-02-13 06:30:00" Then

            If time_end = "2020-02-13 07:30:00" Then
                worksheet.Range("K5:K7").Merge()
                worksheet.Range("L5:L7").Merge()
                worksheet.Range("M5:M7").Merge()
                worksheet.Range("K5:K7").Value = subject
                worksheet.Range("L5:L7").Value = section
                worksheet.Range("M5:M7").Value = room
            ElseIf time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K5:K9").Merge()
                worksheet.Range("L5:L9").Merge()
                worksheet.Range("M5:M9").Merge()
                worksheet.Range("K5:K9").Value = subject
                worksheet.Range("L5:L9").Value = section
            End If
            worksheet.Range("M5:M9").Value = room
        ElseIf time_start = "2020-02-13 07:00:00" Then
            If time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K6:K8").Merge()
                worksheet.Range("L6:L8").Merge()
                worksheet.Range("M6:M8").Merge()
                worksheet.Range("K6:K8").Value = subject
                worksheet.Range("L6:L8").Value = section
                worksheet.Range("M6:M8").Value = room
            ElseIf time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K6:K10").Merge()
                worksheet.Range("L6:L10").Merge()
                worksheet.Range("M6:M10").Merge()
                worksheet.Range("K6:K10").Value = subject
                worksheet.Range("L6:L10").Value = section
                worksheet.Range("M6:M10").Value = room
            End If
        ElseIf time_start = "2020-02-13 07:30:00" Then
            If time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K7:K9").Merge()
                worksheet.Range("L7:L9").Merge()
                worksheet.Range("M7:M9").Merge()
                worksheet.Range("K7:K9").Value = subject
                worksheet.Range("L7:L9").Value = section
                worksheet.Range("M7:M9").Value = room
            ElseIf time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K7:K11").Merge()
                worksheet.Range("L7:L11").Merge()
                worksheet.Range("M7:M11").Merge()
                worksheet.Range("K7:K11").Value = subject
                worksheet.Range("L7:L11").Value = section
                worksheet.Range("M7:M11").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:00:00" Then
            If time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K8:K10").Merge()
                worksheet.Range("L8:L10").Merge()
                worksheet.Range("M8:M10").Merge()
                worksheet.Range("K8:K10").Value = subject
                worksheet.Range("L8:L10").Value = section
                worksheet.Range("M8:M10").Value = room
            ElseIf time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K8:K12").Merge()
                worksheet.Range("L8:L12").Merge()
                worksheet.Range("M8:M12").Merge()
                worksheet.Range("K8:K12").Value = subject
                worksheet.Range("L8:L12").Value = section
                worksheet.Range("M8:M12").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:30:00" Then
            If time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K9:K11").Merge()
                worksheet.Range("L9:L11").Merge()
                worksheet.Range("M9:M11").Merge()
                worksheet.Range("K9:K11").Value = subject
                worksheet.Range("L9:L11").Value = section
                worksheet.Range("M9:M11").Value = room
            ElseIf time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K6:K13").Merge()
                worksheet.Range("L9:L13").Merge()
                worksheet.Range("M9:M13").Merge()
                worksheet.Range("K9:K13").Value = subject
                worksheet.Range("L9:L13").Value = section
                worksheet.Range("M9:M13").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:00:00" Then
            If time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K10:K12").Merge()
                worksheet.Range("L10:L12").Merge()
                worksheet.Range("M10:M12").Merge()
                worksheet.Range("K10:K12").Value = subject
                worksheet.Range("L10:L12").Value = section
                worksheet.Range("M10:M12").Value = room
            ElseIf time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K10:K14").Merge()
                worksheet.Range("L10:L14").Merge()
                worksheet.Range("M10:M14").Merge()
                worksheet.Range("K10:K14").Value = subject
                worksheet.Range("L10:L14").Value = section
                worksheet.Range("M10:M14").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:30:00" Then
            If time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K11:K13").Merge()
                worksheet.Range("L11:L13").Merge()
                worksheet.Range("M11:M13").Merge()
                worksheet.Range("K11:K13").Value = subject
                worksheet.Range("L11:L13").Value = section
                worksheet.Range("M11:M13").Value = room
            ElseIf time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K11:K15").Merge()
                worksheet.Range("L11:L15").Merge()
                worksheet.Range("M11:M15").Merge()
                worksheet.Range("K11:K15").Value = subject
                worksheet.Range("L11:L15").Value = section
                worksheet.Range("M11:M15").Value = room
            End If
        ElseIf time_start = "2020-02-13 10:00:00" Then
            If time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K12:K14").Merge()
                worksheet.Range("L12:L14").Merge()
                worksheet.Range("M12:M14").Merge()
                worksheet.Range("K12:K14").Value = subject
                worksheet.Range("L12:L14").Value = section
                worksheet.Range("M12:M14").Value = room

            ElseIf time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K12:K16").Merge()
                worksheet.Range("L12:L16").Merge()
                worksheet.Range("M12:M16").Merge()
                worksheet.Range("K12:K16").Value = subject
                worksheet.Range("L12:L16").Value = section
                worksheet.Range("M12:M16").Value = room

            End If
        End If
        If time_start = "2020-02-13 10:30:00" Then
            If time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K13:K15").Merge()
                worksheet.Range("L13:L15").Merge()
                worksheet.Range("M13:M15").Merge()
                worksheet.Range("K13:K15").Value = subject
                worksheet.Range("L13:L15").Value = section
                worksheet.Range("M13:M15").Value = room
            ElseIf time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K13:K17").Merge()
                worksheet.Range("L13:L17").Merge()
                worksheet.Range("M13:M17").Merge()
                worksheet.Range("K13:K17").Value = subject
                worksheet.Range("L13:L17").Value = section
                worksheet.Range("M13:M17").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:00:00" Then
            If time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K14:K16").Merge()
                worksheet.Range("L14:L16").Merge()
                worksheet.Range("M14:M16").Merge()
                worksheet.Range("K14:K16").Value = subject
                worksheet.Range("L14:L16").Value = section
                worksheet.Range("M14:M16").Value = room
            ElseIf time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K14:K18").Merge()
                worksheet.Range("L14:L18").Merge()
                worksheet.Range("M14:M18").Merge()
                worksheet.Range("K14:K18").Value = subject
                worksheet.Range("L14:L18").Value = section
                worksheet.Range("M14:M18").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:30:00" Then
            If time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K15:K17").Merge()
                worksheet.Range("L15:L17").Merge()
                worksheet.Range("M15:M17").Merge()
                worksheet.Range("K15:K17").Value = subject
                worksheet.Range("L15:L17").Value = section
                worksheet.Range("M15:M17").Value = room
            ElseIf time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K15:K19").Merge()
                worksheet.Range("L15:L19").Merge()
                worksheet.Range("M15:M19").Merge()
                worksheet.Range("K15:K19").Value = subject
                worksheet.Range("L15:L19").Value = section
                worksheet.Range("M15:M19").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:00:00" Then
            If time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K16:K14").Merge()
                worksheet.Range("L16:L18").Merge()
                worksheet.Range("M16:M18").Merge()
                worksheet.Range("K16:K18").Value = subject
                worksheet.Range("L16:L18").Value = section
                worksheet.Range("M16:M18").Value = room
            ElseIf time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K16:K20").Merge()
                worksheet.Range("L16:L20").Merge()
                worksheet.Range("M16:M20").Merge()
                worksheet.Range("K16:K20").Value = subject
                worksheet.Range("L16:L20").Value = section
                worksheet.Range("M16:M20").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:30:00" Then
            If time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K17:K19").Merge()
                worksheet.Range("L17:L19").Merge()
                worksheet.Range("M17:M19").Merge()
                worksheet.Range("K17:K19").Value = subject
                worksheet.Range("L17:L19").Value = section
                worksheet.Range("M17:M19").Value = room
            ElseIf time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K17:K21").Merge()
                worksheet.Range("L17:L21").Merge()
                worksheet.Range("M17:M21").Merge()
                worksheet.Range("K17:K21").Value = subject
                worksheet.Range("L17:L21").Value = section
                worksheet.Range("M17:M21").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:00:00" Then
            If time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K18:K20").Merge()
                worksheet.Range("L18:L20").Merge()
                worksheet.Range("M18:M20").Merge()
                worksheet.Range("K18:K20").Value = subject
                worksheet.Range("L18:L20").Value = section
                worksheet.Range("M18:M20").Value = room
            ElseIf time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K18:K22").Merge()
                worksheet.Range("L18:L22").Merge()
                worksheet.Range("M18:M22").Merge()
                worksheet.Range("K18:K22").Value = subject
                worksheet.Range("L18:L22").Value = section
                worksheet.Range("M18:M22").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:30:00" Then
            If time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K19:K21").Merge()
                worksheet.Range("L19:L21").Merge()
                worksheet.Range("M19:M21").Merge()
                worksheet.Range("K19:K21").Value = subject
                worksheet.Range("L19:L21").Value = section
                worksheet.Range("M19:M21").Value = room
            ElseIf time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K19:K23").Merge()
                worksheet.Range("L19:L23").Merge()
                worksheet.Range("M19:M23").Merge()
                worksheet.Range("K19:K23").Value = subject
                worksheet.Range("L19:L23").Value = section
                worksheet.Range("M19:M23").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:00:00" Then
            If time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K20:K22").Merge()
                worksheet.Range("L20:L22").Merge()
                worksheet.Range("M20:M22").Merge()
                worksheet.Range("K20:K22").Value = subject
                worksheet.Range("L20:L22").Value = section
                worksheet.Range("M20:M22").Value = room
            ElseIf time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K20:K24").Merge()
                worksheet.Range("L20:L24").Merge()
                worksheet.Range("M20:M24").Merge()
                worksheet.Range("K20:K24").Value = subject
                worksheet.Range("L20:L24").Value = section
                worksheet.Range("M20:M24").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:30:00" Then
            If time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K21:K23").Merge()
                worksheet.Range("L21:L23").Merge()
                worksheet.Range("M21:M23").Merge()
                worksheet.Range("K21:K23").Value = subject
                worksheet.Range("L21:L23").Value = section
                worksheet.Range("M21:M23").Value = room
            ElseIf time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K21:K25").Merge()
                worksheet.Range("L21:L25").Merge()
                worksheet.Range("M21:M25").Merge()
                worksheet.Range("K21:K25").Value = subject
                worksheet.Range("L21:L25").Value = section
                worksheet.Range("M21:M25").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:00:00" Then
            If time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K22:K24").Merge()
                worksheet.Range("L22:L24").Merge()
                worksheet.Range("M22:M24").Merge()
                worksheet.Range("K22:K24").Value = subject
                worksheet.Range("L22:L24").Value = section
                worksheet.Range("M22:M24").Value = room
            ElseIf time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K22:K26").Merge()
                worksheet.Range("L22:L26").Merge()
                worksheet.Range("M22:M26").Merge()
                worksheet.Range("K22:K26").Value = subject
                worksheet.Range("L22:L26").Value = section
                worksheet.Range("M22:M26").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:30:00" Then
            If time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K23:K25").Merge()
                worksheet.Range("L23:L25").Merge()
                worksheet.Range("M23:M25").Merge()
                worksheet.Range("K23:K25").Value = subject
                worksheet.Range("L23:L25").Value = section
                worksheet.Range("M23:M25").Value = room
            ElseIf time_end = "2020-02-13 17:30:00" Then
                worksheet.Range("K23:K27").Merge()
                worksheet.Range("L23:L27").Merge()
                worksheet.Range("M23:M27").Merge()
                worksheet.Range("K23:K27").Value = subject
                worksheet.Range("L23:L27").Value = section
                worksheet.Range("M23:M27").Value = room
            End If
        End If
        If time_start = "2020-02-13 16:00:00" Then
            If time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K24:K26").Merge()
                worksheet.Range("L24:L26").Merge()
                worksheet.Range("M24:M26").Merge()
                worksheet.Range("K24:K26").Value = subject
                worksheet.Range("L24:L26").Value = section
                worksheet.Range("M24:M26").Value = room
            ElseIf time_end = "2020-02-13 18:00:00" Then
                worksheet.Range("K24:K28").Merge()
                worksheet.Range("L24:L28").Merge()
                worksheet.Range("M24:M28").Merge()
                worksheet.Range("K24:K28").Value = subject
                worksheet.Range("L24:L28").Value = section
                worksheet.Range("M24:M28").Value = room
            End If
        End If

        'Fridayyyy========
        If time_start = "2020-02-14 06:00:00" Then
            If time_end = "2020-02-14 07:00:00" Then
                worksheet.Range("N4:N6").Merge()
                worksheet.Range("O4:O6").Merge()
                worksheet.Range("P4:P6").Merge()
                worksheet.Range("N4:N6").Value = subject
                worksheet.Range("O4:O6").Value = section
                worksheet.Range("P4:P6").Value = room
            ElseIf time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N4:N8").Merge()
                worksheet.Range("O4:O8").Merge()
                worksheet.Range("P4:P8").Merge()
                worksheet.Range("N4:N8").Value = subject
                worksheet.Range("O4:O8").Value = section
                worksheet.Range("P4:P8").Value = room
            End If
        ElseIf time_start = "2020-02-14 06:30:00" Then

            If time_end = "2020-02-14 07:30:00" Then
                worksheet.Range("N5:N7").Merge()
                worksheet.Range("O5:O7").Merge()
                worksheet.Range("P5:P7").Merge()
                worksheet.Range("N5:N7").Value = subject
                worksheet.Range("O5:O7").Value = section
                worksheet.Range("P5:P7").Value = room
            ElseIf time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N5:N9").Merge()
                worksheet.Range("O5:O9").Merge()
                worksheet.Range("P5:P9").Merge()
                worksheet.Range("N5:N9").Value = subject
                worksheet.Range("O5:O9").Value = section
            End If
            worksheet.Range("P5:P9").Value = room
        ElseIf time_start = "2020-02-14 07:00:00" Then
            If time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N6:N8").Merge()
                worksheet.Range("O6:O8").Merge()
                worksheet.Range("P6:P8").Merge()
                worksheet.Range("N6:N8").Value = subject
                worksheet.Range("O6:O8").Value = section
                worksheet.Range("P6:P8").Value = room
            ElseIf time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N6:N10").Merge()
                worksheet.Range("O6:O10").Merge()
                worksheet.Range("P6:P10").Merge()
                worksheet.Range("N6:N10").Value = subject
                worksheet.Range("O6:O10").Value = section
                worksheet.Range("P6:P10").Value = room
            End If
        ElseIf time_start = "2020-02-14 07:30:00" Then
            If time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N7:N9").Merge()
                worksheet.Range("O7:O9").Merge()
                worksheet.Range("P7:P9").Merge()
                worksheet.Range("N7:N9").Value = subject
                worksheet.Range("O7:O9").Value = section
                worksheet.Range("P7:P9").Value = room
            ElseIf time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N7:N11").Merge()
                worksheet.Range("O7:O11").Merge()
                worksheet.Range("P7:P11").Merge()
                worksheet.Range("N7:N11").Value = subject
                worksheet.Range("O7:O11").Value = section
                worksheet.Range("P7:P11").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:00:00" Then
            If time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N8:N10").Merge()
                worksheet.Range("O8:O10").Merge()
                worksheet.Range("P8:P10").Merge()
                worksheet.Range("N8:N10").Value = subject
                worksheet.Range("O8:O10").Value = section
                worksheet.Range("P8:P10").Value = room
            ElseIf time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N8:N12").Merge()
                worksheet.Range("O8:O12").Merge()
                worksheet.Range("P8:P12").Merge()
                worksheet.Range("N8:N12").Value = subject
                worksheet.Range("O8:O12").Value = section
                worksheet.Range("P8:P12").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:30:00" Then
            If time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N9:N11").Merge()
                worksheet.Range("O9:O11").Merge()
                worksheet.Range("P9:P11").Merge()
                worksheet.Range("N9:N11").Value = subject
                worksheet.Range("O9:O11").Value = section
                worksheet.Range("P9:P11").Value = room
            ElseIf time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N6:N13").Merge()
                worksheet.Range("O9:O13").Merge()
                worksheet.Range("P9:P13").Merge()
                worksheet.Range("N9:N13").Value = subject
                worksheet.Range("O9:O13").Value = section
                worksheet.Range("P9:P13").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:00:00" Then
            If time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N10:N12").Merge()
                worksheet.Range("O10:O12").Merge()
                worksheet.Range("P10:P12").Merge()
                worksheet.Range("N10:N12").Value = subject
                worksheet.Range("O10:O12").Value = section
                worksheet.Range("P10:P12").Value = room
            ElseIf time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N10:N14").Merge()
                worksheet.Range("O10:O14").Merge()
                worksheet.Range("P10:P14").Merge()
                worksheet.Range("N10:N14").Value = subject
                worksheet.Range("O10:O14").Value = section
                worksheet.Range("P10:P14").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:30:00" Then
            If time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N11:N13").Merge()
                worksheet.Range("O11:O13").Merge()
                worksheet.Range("P11:P13").Merge()
                worksheet.Range("N11:N13").Value = subject
                worksheet.Range("O11:O13").Value = section
                worksheet.Range("P11:P13").Value = room
            ElseIf time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N11:N15").Merge()
                worksheet.Range("O11:O15").Merge()
                worksheet.Range("P11:P15").Merge()
                worksheet.Range("N11:N15").Value = subject
                worksheet.Range("O11:O15").Value = section
                worksheet.Range("P11:P15").Value = room
            End If
        ElseIf time_start = "2020-02-14 10:00:00" Then
            If time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N12:N14").Merge()
                worksheet.Range("O12:O14").Merge()
                worksheet.Range("P12:P14").Merge()
                worksheet.Range("N12:N14").Value = subject
                worksheet.Range("O12:O14").Value = section
                worksheet.Range("P12:P14").Value = room

            ElseIf time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N12:N16").Merge()
                worksheet.Range("O12:O16").Merge()
                worksheet.Range("P12:P16").Merge()
                worksheet.Range("N12:N16").Value = subject
                worksheet.Range("O12:O16").Value = section
                worksheet.Range("P12:P16").Value = room

            End If
        End If
        If time_start = "2020-02-14 10:30:00" Then
            If time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N13:N15").Merge()
                worksheet.Range("O13:O15").Merge()
                worksheet.Range("P13:P15").Merge()
                worksheet.Range("N13:N15").Value = subject
                worksheet.Range("O13:O15").Value = section
                worksheet.Range("P13:P15").Value = room
            ElseIf time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N13:N17").Merge()
                worksheet.Range("O13:O17").Merge()
                worksheet.Range("P13:P17").Merge()
                worksheet.Range("N13:N17").Value = subject
                worksheet.Range("O13:O17").Value = section
                worksheet.Range("P13:P17").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:00:00" Then
            If time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N14:N16").Merge()
                worksheet.Range("O14:O16").Merge()
                worksheet.Range("P14:P16").Merge()
                worksheet.Range("N14:N16").Value = subject
                worksheet.Range("O14:O16").Value = section
                worksheet.Range("P14:P16").Value = room
            ElseIf time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N14:N18").Merge()
                worksheet.Range("O14:O18").Merge()
                worksheet.Range("P14:P18").Merge()
                worksheet.Range("N14:N18").Value = subject
                worksheet.Range("O14:O18").Value = section
                worksheet.Range("P14:P18").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:30:00" Then
            If time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N15:N17").Merge()
                worksheet.Range("O15:O17").Merge()
                worksheet.Range("P15:P17").Merge()
                worksheet.Range("N15:N17").Value = subject
                worksheet.Range("O15:O17").Value = section
                worksheet.Range("P15:P17").Value = room
            ElseIf time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N15:N19").Merge()
                worksheet.Range("O15:O19").Merge()
                worksheet.Range("P15:P19").Merge()
                worksheet.Range("N15:N19").Value = subject
                worksheet.Range("O15:O19").Value = section
                worksheet.Range("P15:P19").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:00:00" Then
            If time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N16:N14").Merge()
                worksheet.Range("O16:O18").Merge()
                worksheet.Range("P16:P18").Merge()
                worksheet.Range("N16:N18").Value = subject
                worksheet.Range("O16:O18").Value = section
                worksheet.Range("P16:P18").Value = room
            ElseIf time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N16:N20").Merge()
                worksheet.Range("O16:O20").Merge()
                worksheet.Range("P16:P20").Merge()
                worksheet.Range("N16:N20").Value = subject
                worksheet.Range("O16:O20").Value = section
                worksheet.Range("P16:P20").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:30:00" Then
            If time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N17:N19").Merge()
                worksheet.Range("O17:O19").Merge()
                worksheet.Range("P17:P19").Merge()
                worksheet.Range("N17:N19").Value = subject
                worksheet.Range("O17:O19").Value = section
                worksheet.Range("P17:P19").Value = room
            ElseIf time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N17:N21").Merge()
                worksheet.Range("O17:O21").Merge()
                worksheet.Range("P17:P21").Merge()
                worksheet.Range("N17:N21").Value = subject
                worksheet.Range("O17:O21").Value = section
                worksheet.Range("P17:P21").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:00:00" Then
            If time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N18:N20").Merge()
                worksheet.Range("O18:O20").Merge()
                worksheet.Range("P18:P20").Merge()
                worksheet.Range("N18:N20").Value = subject
                worksheet.Range("O18:O20").Value = section
                worksheet.Range("P18:P20").Value = room
            ElseIf time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N18:N22").Merge()
                worksheet.Range("O18:O22").Merge()
                worksheet.Range("P18:P22").Merge()
                worksheet.Range("N18:N22").Value = subject
                worksheet.Range("O18:O22").Value = section
                worksheet.Range("P18:P22").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:30:00" Then
            If time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N19:N21").Merge()
                worksheet.Range("O19:O21").Merge()
                worksheet.Range("P19:P21").Merge()
                worksheet.Range("N19:N21").Value = subject
                worksheet.Range("O19:O21").Value = section
                worksheet.Range("P19:P21").Value = room
            ElseIf time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N19:N23").Merge()
                worksheet.Range("O19:O23").Merge()
                worksheet.Range("P19:P23").Merge()
                worksheet.Range("N19:N23").Value = subject
                worksheet.Range("O19:O23").Value = section
                worksheet.Range("P19:P23").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:00:00" Then
            If time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N20:N22").Merge()
                worksheet.Range("O20:O22").Merge()
                worksheet.Range("P20:P22").Merge()
                worksheet.Range("N20:N22").Value = subject
                worksheet.Range("O20:O22").Value = section
                worksheet.Range("P20:P22").Value = room
            ElseIf time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N20:N24").Merge()
                worksheet.Range("O20:O24").Merge()
                worksheet.Range("P20:P24").Merge()
                worksheet.Range("N20:N24").Value = subject
                worksheet.Range("O20:O24").Value = section
                worksheet.Range("P20:P24").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:30:00" Then
            If time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N21:N23").Merge()
                worksheet.Range("O21:O23").Merge()
                worksheet.Range("P21:P23").Merge()
                worksheet.Range("N21:N23").Value = subject
                worksheet.Range("O21:O23").Value = section
                worksheet.Range("P21:P23").Value = room
            ElseIf time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N21:N25").Merge()
                worksheet.Range("O21:O25").Merge()
                worksheet.Range("P21:P25").Merge()
                worksheet.Range("N21:N25").Value = subject
                worksheet.Range("O21:O25").Value = section
                worksheet.Range("P21:P25").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:00:00" Then
            If time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N22:N24").Merge()
                worksheet.Range("O22:O24").Merge()
                worksheet.Range("P22:P24").Merge()
                worksheet.Range("N22:N24").Value = subject
                worksheet.Range("O22:O24").Value = section
                worksheet.Range("P22:P24").Value = room
            ElseIf time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N22:N26").Merge()
                worksheet.Range("O22:O26").Merge()
                worksheet.Range("P22:P26").Merge()
                worksheet.Range("N22:N26").Value = subject
                worksheet.Range("O22:O26").Value = section
                worksheet.Range("P22:P26").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:30:00" Then
            If time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N23:N25").Merge()
                worksheet.Range("O23:O25").Merge()
                worksheet.Range("P23:P25").Merge()
                worksheet.Range("N23:N25").Value = subject
                worksheet.Range("O23:O25").Value = section
                worksheet.Range("P23:P25").Value = room
            ElseIf time_end = "2020-02-14 17:30:00" Then
                worksheet.Range("N23:N27").Merge()
                worksheet.Range("O23:O27").Merge()
                worksheet.Range("P23:P27").Merge()
                worksheet.Range("N23:N27").Value = subject
                worksheet.Range("O23:O27").Value = section
                worksheet.Range("P23:P27").Value = room
            End If
        End If
        If time_start = "2020-02-14 16:00:00" Then
            If time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N24:N26").Merge()
                worksheet.Range("O24:O26").Merge()
                worksheet.Range("P24:P26").Merge()
                worksheet.Range("N24:N26").Value = subject
                worksheet.Range("O24:O26").Value = section
                worksheet.Range("P24:P26").Value = room
            ElseIf time_end = "2020-02-14 18:00:00" Then
                worksheet.Range("N24:N28").Merge()
                worksheet.Range("O24:O28").Merge()
                worksheet.Range("P24:P28").Merge()
                worksheet.Range("N24:N28").Value = subject
                worksheet.Range("O24:O28").Value = section
                worksheet.Range("P24:P28").Value = room
            End If
        End If
    End Sub

    'Row2
    Private Sub CheckDateToInsertRow2()
        Dim id As String = choose_expo.SelectedValue
        Dim s As String = "select prof_details_tbl.`FName_prof`, 
    prof_details_tbl.`MName_prof`, 
    prof_details_tbl.`LName_prof`,
    subjects_tbl.subject_Name, 
    `schedule_tbl`.strandName, 
    `schedule_tbl`.grade_lvl, 
    `schedule_tbl`.section_no, `schedule_tbl`.building_no, 
    `schedule_tbl`.room_no,
schedule_tbl.time_start, 
schedule_tbl.time_end from prof_details_tbl ,schedule_tbl inner join subjects_tbl on schedule_tbl.subject = subjects_tbl.snn
    where prof_details_tbl.ID_Prof='" + id + "' and `schedule_tbl`.`id_Prof`='" + id + "' and sy='" + print_sy.Text + "' and semestral_sche='" + print_sem.Text + "'"
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row2 As DataRow = tb.Rows(1)
        Dim subject As String = row2(3)
        Dim section As String = row2(4) + " " + row2(5) + "-" + row2(6)
        Dim room As String = row2(7) + " " + row2(8)
        time_start = row2(9)
        time_end = row2(10)
        'Monday start
        If time_start = "2020-02-10 06:00:00" Then
            If time_end = "2020-02-10 07:00:00" Then
                worksheet.Range("B4:B6").Merge()
                worksheet.Range("C4:C6").Merge()
                worksheet.Range("D4:D6").Merge()
                worksheet.Range("B4:B6").Value = subject
                worksheet.Range("C4:C6").Value = section
                worksheet.Range("D4:D6").Value = room
            ElseIf time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B4:B8").Merge()
                worksheet.Range("C4:C8").Merge()
                worksheet.Range("D4:D8").Merge()
                worksheet.Range("B4:B8").Value = subject
                worksheet.Range("C4:C8").Value = section
                worksheet.Range("D4:D8").Value = room
            End If
        ElseIf time_start = "2020-02-10 06:30:00" Then

            If time_end = "2020-02-10 07:30:00" Then
                worksheet.Range("B5:B7").Merge()
                worksheet.Range("C5:C7").Merge()
                worksheet.Range("D5:D7").Merge()
                worksheet.Range("B5:B7").Value = subject
                worksheet.Range("C5:C7").Value = section
                worksheet.Range("D5:D7").Value = room
            ElseIf time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B5:B9").Merge()
                worksheet.Range("C5:C9").Merge()
                worksheet.Range("D5:D9").Merge()
                worksheet.Range("B5:B9").Value = subject
                worksheet.Range("C5:C9").Value = section
            End If
            worksheet.Range("D5:D9").Value = room
        ElseIf time_start = "2020-02-10 07:00:00" Then
            If time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B6:B8").Merge()
                worksheet.Range("C6:C8").Merge()
                worksheet.Range("D6:D8").Merge()
                worksheet.Range("B6:B8").Value = subject
                worksheet.Range("C6:C8").Value = section
                worksheet.Range("D6:D8").Value = room
            ElseIf time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B6:B10").Merge()
                worksheet.Range("C6:C10").Merge()
                worksheet.Range("D6:D10").Merge()
                worksheet.Range("B6:B10").Value = subject
                worksheet.Range("C6:C10").Value = section
                worksheet.Range("D6:D10").Value = room
            End If
        ElseIf time_start = "2020-02-10 07:30:00" Then
            If time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B7:B9").Merge()
                worksheet.Range("C7:C9").Merge()
                worksheet.Range("D7:D9").Merge()
                worksheet.Range("B7:B9").Value = subject
                worksheet.Range("C7:C9").Value = section
                worksheet.Range("D7:D9").Value = room
            ElseIf time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B7:B11").Merge()
                worksheet.Range("C7:C11").Merge()
                worksheet.Range("D7:D11").Merge()
                worksheet.Range("B7:B11").Value = subject
                worksheet.Range("C7:C11").Value = section
                worksheet.Range("D7:D11").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:00:00" Then
            If time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B8:B10").Merge()
                worksheet.Range("C8:C10").Merge()
                worksheet.Range("D8:D10").Merge()
                worksheet.Range("B8:B10").Value = subject
                worksheet.Range("C8:C10").Value = section
                worksheet.Range("D8:D10").Value = room
            ElseIf time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B8:B12").Merge()
                worksheet.Range("C8:C12").Merge()
                worksheet.Range("D8:D12").Merge()
                worksheet.Range("B8:B12").Value = subject
                worksheet.Range("C8:C12").Value = section
                worksheet.Range("D8:D12").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:30:00" Then
            If time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B9:B11").Merge()
                worksheet.Range("C9:C11").Merge()
                worksheet.Range("D9:D11").Merge()
                worksheet.Range("B9:B11").Value = subject
                worksheet.Range("C9:C11").Value = section
                worksheet.Range("D9:D11").Value = room
            ElseIf time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B6:B13").Merge()
                worksheet.Range("C9:C13").Merge()
                worksheet.Range("D9:D13").Merge()
                worksheet.Range("B9:B13").Value = subject
                worksheet.Range("C9:C13").Value = section
                worksheet.Range("D9:D13").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:00:00" Then
            If time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B10:B12").Merge()
                worksheet.Range("C10:C12").Merge()
                worksheet.Range("D10:D12").Merge()
                worksheet.Range("B10:B12").Value = subject
                worksheet.Range("C10:C12").Value = section
                worksheet.Range("D10:D12").Value = room
            ElseIf time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B10:B14").Merge()
                worksheet.Range("C10:C14").Merge()
                worksheet.Range("D10:D14").Merge()
                worksheet.Range("B10:B14").Value = subject
                worksheet.Range("C10:C14").Value = section
                worksheet.Range("D10:D14").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:30:00" Then
            If time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B11:B13").Merge()
                worksheet.Range("C11:C13").Merge()
                worksheet.Range("D11:D13").Merge()
                worksheet.Range("B11:B13").Value = subject
                worksheet.Range("C11:C13").Value = section
                worksheet.Range("D11:D13").Value = room
            ElseIf time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B11:B15").Merge()
                worksheet.Range("C11:C15").Merge()
                worksheet.Range("D11:D15").Merge()
                worksheet.Range("B11:B15").Value = subject
                worksheet.Range("C11:C15").Value = section
                worksheet.Range("D11:D15").Value = room
            End If
        ElseIf time_start = "2020-02-10 10:00:00" Then
            If time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B12:B14").Merge()
                worksheet.Range("C12:C14").Merge()
                worksheet.Range("D12:D14").Merge()
                worksheet.Range("B12:B14").Value = subject
                worksheet.Range("C12:C14").Value = section
                worksheet.Range("D12:D14").Value = room

            ElseIf time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B12:B16").Merge()
                worksheet.Range("C12:C16").Merge()
                worksheet.Range("D12:D16").Merge()
                worksheet.Range("B12:B16").Value = subject
                worksheet.Range("C12:C16").Value = section
                worksheet.Range("D12:D16").Value = room

            End If
        End If
        If time_start = "2020-02-10 10:30:00" Then
            If time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B13:B15").Merge()
                worksheet.Range("C13:C15").Merge()
                worksheet.Range("D13:D15").Merge()
                worksheet.Range("B13:B15").Value = subject
                worksheet.Range("C13:C15").Value = section
                worksheet.Range("D13:D15").Value = room
            ElseIf time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B13:B17").Merge()
                worksheet.Range("C13:C17").Merge()
                worksheet.Range("D13:D17").Merge()
                worksheet.Range("B13:B17").Value = subject
                worksheet.Range("C13:C17").Value = section
                worksheet.Range("D13:D17").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:00:00" Then
            If time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B14:B16").Merge()
                worksheet.Range("C14:C16").Merge()
                worksheet.Range("D14:D16").Merge()
                worksheet.Range("B14:B16").Value = subject
                worksheet.Range("C14:C16").Value = section
                worksheet.Range("D14:D16").Value = room
            ElseIf time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B14:B18").Merge()
                worksheet.Range("C14:C18").Merge()
                worksheet.Range("D14:D18").Merge()
                worksheet.Range("B14:B18").Value = subject
                worksheet.Range("C14:C18").Value = section
                worksheet.Range("D14:D18").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:30:00" Then
            If time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B15:B17").Merge()
                worksheet.Range("C15:C17").Merge()
                worksheet.Range("D15:D17").Merge()
                worksheet.Range("B15:B17").Value = subject
                worksheet.Range("C15:C17").Value = section
                worksheet.Range("D15:D17").Value = room
            ElseIf time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B15:B19").Merge()
                worksheet.Range("C15:C19").Merge()
                worksheet.Range("D15:D19").Merge()
                worksheet.Range("B15:B19").Value = subject
                worksheet.Range("C15:C19").Value = section
                worksheet.Range("D15:D19").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:00:00" Then
            If time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B16:B14").Merge()
                worksheet.Range("C16:C18").Merge()
                worksheet.Range("D16:D18").Merge()
                worksheet.Range("B16:B18").Value = subject
                worksheet.Range("C16:C18").Value = section
                worksheet.Range("D16:D18").Value = room
            ElseIf time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B16:B20").Merge()
                worksheet.Range("C16:C20").Merge()
                worksheet.Range("D16:D20").Merge()
                worksheet.Range("B16:B20").Value = subject
                worksheet.Range("C16:C20").Value = section
                worksheet.Range("D16:D20").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:30:00" Then
            If time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B17:B19").Merge()
                worksheet.Range("C17:C19").Merge()
                worksheet.Range("D17:D19").Merge()
                worksheet.Range("B17:B19").Value = subject
                worksheet.Range("C17:C19").Value = section
                worksheet.Range("D17:D19").Value = room
            ElseIf time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B17:B21").Merge()
                worksheet.Range("C17:C21").Merge()
                worksheet.Range("D17:D21").Merge()
                worksheet.Range("B17:B21").Value = subject
                worksheet.Range("C17:C21").Value = section
                worksheet.Range("D17:D21").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:00:00" Then
            If time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B18:B20").Merge()
                worksheet.Range("C18:C20").Merge()
                worksheet.Range("D18:D20").Merge()
                worksheet.Range("B18:B20").Value = subject
                worksheet.Range("C18:C20").Value = section
                worksheet.Range("D18:D20").Value = room
            ElseIf time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B18:B22").Merge()
                worksheet.Range("C18:C22").Merge()
                worksheet.Range("D18:D22").Merge()
                worksheet.Range("B18:B22").Value = subject
                worksheet.Range("C18:C22").Value = section
                worksheet.Range("D18:D22").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:30:00" Then
            If time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B19:B21").Merge()
                worksheet.Range("C19:C21").Merge()
                worksheet.Range("D19:D21").Merge()
                worksheet.Range("B19:B21").Value = subject
                worksheet.Range("C19:C21").Value = section
                worksheet.Range("D19:D21").Value = room
            ElseIf time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B19:B23").Merge()
                worksheet.Range("C19:C23").Merge()
                worksheet.Range("D19:D23").Merge()
                worksheet.Range("B19:B23").Value = subject
                worksheet.Range("C19:C23").Value = section
                worksheet.Range("D19:D23").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:00:00" Then
            If time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B20:B22").Merge()
                worksheet.Range("C20:C22").Merge()
                worksheet.Range("D20:D22").Merge()
                worksheet.Range("B20:B22").Value = subject
                worksheet.Range("C20:C22").Value = section
                worksheet.Range("D20:D22").Value = room
            ElseIf time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B20:B24").Merge()
                worksheet.Range("C20:C24").Merge()
                worksheet.Range("D20:D24").Merge()
                worksheet.Range("B20:B24").Value = subject
                worksheet.Range("C20:C24").Value = section
                worksheet.Range("D20:D24").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:30:00" Then
            If time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B21:B23").Merge()
                worksheet.Range("C21:C23").Merge()
                worksheet.Range("D21:D23").Merge()
                worksheet.Range("B21:B23").Value = subject
                worksheet.Range("C21:C23").Value = section
                worksheet.Range("D21:D23").Value = room
            ElseIf time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B21:B25").Merge()
                worksheet.Range("C21:C25").Merge()
                worksheet.Range("D21:D25").Merge()
                worksheet.Range("B21:B25").Value = subject
                worksheet.Range("C21:C25").Value = section
                worksheet.Range("D21:D25").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:00:00" Then
            If time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B22:B24").Merge()
                worksheet.Range("C22:C24").Merge()
                worksheet.Range("D22:D24").Merge()
                worksheet.Range("B22:B24").Value = subject
                worksheet.Range("C22:C24").Value = section
                worksheet.Range("D22:D24").Value = room
            ElseIf time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B22:B26").Merge()
                worksheet.Range("C22:C26").Merge()
                worksheet.Range("D22:D26").Merge()
                worksheet.Range("B22:B26").Value = subject
                worksheet.Range("C22:C26").Value = section
                worksheet.Range("D22:D26").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:30:00" Then
            If time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B23:B25").Merge()
                worksheet.Range("C23:C25").Merge()
                worksheet.Range("D23:D25").Merge()
                worksheet.Range("B23:B25").Value = subject
                worksheet.Range("C23:C25").Value = section
                worksheet.Range("D23:D25").Value = room
            ElseIf time_end = "2020-02-10 17:30:00" Then
                worksheet.Range("B23:B27").Merge()
                worksheet.Range("C23:C27").Merge()
                worksheet.Range("D23:D27").Merge()
                worksheet.Range("B23:B27").Value = subject
                worksheet.Range("C23:C27").Value = section
                worksheet.Range("D23:D27").Value = room
            End If
        End If
        If time_start = "2020-02-10 16:00:00" Then
            If time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B24:B26").Merge()
                worksheet.Range("C24:C26").Merge()
                worksheet.Range("D24:D26").Merge()
                worksheet.Range("B24:B26").Value = subject
                worksheet.Range("C24:C26").Value = section
                worksheet.Range("D24:D26").Value = room
            ElseIf time_end = "2020-02-10 18:00:00" Then
                worksheet.Range("B24:B28").Merge()
                worksheet.Range("C24:C28").Merge()
                worksheet.Range("D24:D28").Merge()
                worksheet.Range("B24:B28").Value = subject
                worksheet.Range("C24:C28").Value = section
                worksheet.Range("D24:D28").Value = room
            End If
        End If



        'tuesday start-----------------------------------------------


        If time_start = "2020-02-11 06:00:00" Then
            If time_end = "2020-02-11 07:00:00" Then
                worksheet.Range("E4:E6").Merge()
                worksheet.Range("F4:F6").Merge()
                worksheet.Range("G4:G6").Merge()
                worksheet.Range("E4:E6").Value = subject
                worksheet.Range("F4:F6").Value = section
                worksheet.Range("G4:G6").Value = room
            ElseIf time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E4:E8").Merge()
                worksheet.Range("F4:F8").Merge()
                worksheet.Range("G4:G8").Merge()
                worksheet.Range("E4:E8").Value = subject
                worksheet.Range("F4:F8").Value = section
                worksheet.Range("G4:G8").Value = room
            End If
        ElseIf time_start = "2020-02-11 06:30:00" Then

            If time_end = "2020-02-11 07:30:00" Then
                worksheet.Range("E5:E7").Merge()
                worksheet.Range("F5:F7").Merge()
                worksheet.Range("G5:G7").Merge()
                worksheet.Range("E5:E7").Value = subject
                worksheet.Range("F5:F7").Value = section
                worksheet.Range("G5:G7").Value = room
            ElseIf time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E5:E9").Merge()
                worksheet.Range("F5:F9").Merge()
                worksheet.Range("G5:G9").Merge()
                worksheet.Range("E5:E9").Value = subject
                worksheet.Range("F5:F9").Value = section
            End If
            worksheet.Range("G5:G9").Value = room
        ElseIf time_start = "2020-02-11 07:00:00" Then
            If time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E6:E8").Merge()
                worksheet.Range("F6:F8").Merge()
                worksheet.Range("G6:G8").Merge()
                worksheet.Range("E6:E8").Value = subject
                worksheet.Range("F6:F8").Value = section
                worksheet.Range("G6:G8").Value = room
            ElseIf time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E6:E10").Merge()
                worksheet.Range("F6:F10").Merge()
                worksheet.Range("G6:G10").Merge()
                worksheet.Range("E6:E10").Value = subject
                worksheet.Range("F6:F10").Value = section
                worksheet.Range("G6:G10").Value = room
            End If
        ElseIf time_start = "2020-02-11 07:30:00" Then
            If time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E7:E9").Merge()
                worksheet.Range("F7:F9").Merge()
                worksheet.Range("G7:G9").Merge()
                worksheet.Range("E7:E9").Value = subject
                worksheet.Range("F7:F9").Value = section
                worksheet.Range("G7:G9").Value = room
            ElseIf time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E7:E11").Merge()
                worksheet.Range("F7:F11").Merge()
                worksheet.Range("G7:G11").Merge()
                worksheet.Range("E7:E11").Value = subject
                worksheet.Range("F7:F11").Value = section
                worksheet.Range("G7:G11").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:00:00" Then
            If time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E8:E10").Merge()
                worksheet.Range("F8:F10").Merge()
                worksheet.Range("G8:G10").Merge()
                worksheet.Range("E8:E10").Value = subject
                worksheet.Range("F8:F10").Value = section
                worksheet.Range("G8:G10").Value = room
            ElseIf time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E8:E12").Merge()
                worksheet.Range("F8:F12").Merge()
                worksheet.Range("G8:G12").Merge()
                worksheet.Range("E8:E12").Value = subject
                worksheet.Range("F8:F12").Value = section
                worksheet.Range("G8:G12").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:30:00" Then
            If time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E9:E11").Merge()
                worksheet.Range("F9:F11").Merge()
                worksheet.Range("G9:G11").Merge()
                worksheet.Range("E9:E11").Value = subject
                worksheet.Range("F9:F11").Value = section
                worksheet.Range("G9:G11").Value = room
            ElseIf time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E6:E13").Merge()
                worksheet.Range("F9:F13").Merge()
                worksheet.Range("G9:G13").Merge()
                worksheet.Range("E9:E13").Value = subject
                worksheet.Range("F9:F13").Value = section
                worksheet.Range("G9:G13").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:00:00" Then
            If time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E10:E12").Merge()
                worksheet.Range("F10:F12").Merge()
                worksheet.Range("G10:G12").Merge()
                worksheet.Range("E10:E12").Value = subject
                worksheet.Range("F10:F12").Value = section
                worksheet.Range("G10:G12").Value = room
            ElseIf time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E10:E14").Merge()
                worksheet.Range("F10:F14").Merge()
                worksheet.Range("G10:G14").Merge()
                worksheet.Range("E10:E14").Value = subject
                worksheet.Range("F10:F14").Value = section
                worksheet.Range("G10:G14").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:30:00" Then
            If time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E11:E13").Merge()
                worksheet.Range("F11:F13").Merge()
                worksheet.Range("G11:G13").Merge()
                worksheet.Range("E11:E13").Value = subject
                worksheet.Range("F11:F13").Value = section
                worksheet.Range("G11:G13").Value = room
            ElseIf time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E11:E15").Merge()
                worksheet.Range("F11:F15").Merge()
                worksheet.Range("G11:G15").Merge()
                worksheet.Range("E11:E15").Value = subject
                worksheet.Range("F11:F15").Value = section
                worksheet.Range("G11:G15").Value = room
            End If
        ElseIf time_start = "2020-02-11 10:00:00" Then
            If time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E12:E14").Merge()
                worksheet.Range("F12:F14").Merge()
                worksheet.Range("G12:G14").Merge()
                worksheet.Range("E12:E14").Value = subject
                worksheet.Range("F12:F14").Value = section
                worksheet.Range("G12:G14").Value = room

            ElseIf time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E12:E16").Merge()
                worksheet.Range("F12:F16").Merge()
                worksheet.Range("G12:G16").Merge()
                worksheet.Range("E12:E16").Value = subject
                worksheet.Range("F12:F16").Value = section
                worksheet.Range("G12:G16").Value = room

            End If
        End If
        If time_start = "2020-02-11 10:30:00" Then
            If time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E13:E15").Merge()
                worksheet.Range("F13:F15").Merge()
                worksheet.Range("G13:G15").Merge()
                worksheet.Range("E13:E15").Value = subject
                worksheet.Range("F13:F15").Value = section
                worksheet.Range("G13:G15").Value = room
            ElseIf time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E13:E17").Merge()
                worksheet.Range("F13:F17").Merge()
                worksheet.Range("G13:G17").Merge()
                worksheet.Range("E13:E17").Value = subject
                worksheet.Range("F13:F17").Value = section
                worksheet.Range("G13:G17").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:00:00" Then
            If time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E14:E16").Merge()
                worksheet.Range("F14:F16").Merge()
                worksheet.Range("G14:G16").Merge()
                worksheet.Range("E14:E16").Value = subject
                worksheet.Range("F14:F16").Value = section
                worksheet.Range("G14:G16").Value = room
            ElseIf time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E14:E18").Merge()
                worksheet.Range("F14:F18").Merge()
                worksheet.Range("G14:G18").Merge()
                worksheet.Range("E14:E18").Value = subject
                worksheet.Range("F14:F18").Value = section
                worksheet.Range("G14:G18").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:30:00" Then
            If time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E15:E17").Merge()
                worksheet.Range("F15:F17").Merge()
                worksheet.Range("G15:G17").Merge()
                worksheet.Range("E15:E17").Value = subject
                worksheet.Range("F15:F17").Value = section
                worksheet.Range("G15:G17").Value = room
            ElseIf time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E15:E19").Merge()
                worksheet.Range("F15:F19").Merge()
                worksheet.Range("G15:G19").Merge()
                worksheet.Range("E15:E19").Value = subject
                worksheet.Range("F15:F19").Value = section
                worksheet.Range("G15:G19").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:00:00" Then
            If time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E16:E14").Merge()
                worksheet.Range("F16:F18").Merge()
                worksheet.Range("G16:G18").Merge()
                worksheet.Range("E16:E18").Value = subject
                worksheet.Range("F16:F18").Value = section
                worksheet.Range("G16:G18").Value = room
            ElseIf time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E16:E20").Merge()
                worksheet.Range("F16:F20").Merge()
                worksheet.Range("G16:G20").Merge()
                worksheet.Range("E16:E20").Value = subject
                worksheet.Range("F16:F20").Value = section
                worksheet.Range("G16:G20").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:30:00" Then
            If time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E17:E19").Merge()
                worksheet.Range("F17:F19").Merge()
                worksheet.Range("G17:G19").Merge()
                worksheet.Range("E17:E19").Value = subject
                worksheet.Range("F17:F19").Value = section
                worksheet.Range("G17:G19").Value = room
            ElseIf time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E17:E21").Merge()
                worksheet.Range("F17:F21").Merge()
                worksheet.Range("G17:G21").Merge()
                worksheet.Range("E17:E21").Value = subject
                worksheet.Range("F17:F21").Value = section
                worksheet.Range("G17:G21").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:00:00" Then
            If time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E18:E20").Merge()
                worksheet.Range("F18:F20").Merge()
                worksheet.Range("G18:G20").Merge()
                worksheet.Range("E18:E20").Value = subject
                worksheet.Range("F18:F20").Value = section
                worksheet.Range("G18:G20").Value = room
            ElseIf time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E18:E22").Merge()
                worksheet.Range("F18:F22").Merge()
                worksheet.Range("G18:G22").Merge()
                worksheet.Range("E18:E22").Value = subject
                worksheet.Range("F18:F22").Value = section
                worksheet.Range("G18:G22").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:30:00" Then
            If time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E19:E21").Merge()
                worksheet.Range("F19:F21").Merge()
                worksheet.Range("G19:G21").Merge()
                worksheet.Range("E19:E21").Value = subject
                worksheet.Range("F19:F21").Value = section
                worksheet.Range("G19:G21").Value = room
            ElseIf time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E19:E23").Merge()
                worksheet.Range("F19:F23").Merge()
                worksheet.Range("G19:G23").Merge()
                worksheet.Range("E19:E23").Value = subject
                worksheet.Range("F19:F23").Value = section
                worksheet.Range("G19:G23").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:00:00" Then
            If time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E20:E22").Merge()
                worksheet.Range("F20:F22").Merge()
                worksheet.Range("G20:G22").Merge()
                worksheet.Range("E20:E22").Value = subject
                worksheet.Range("F20:F22").Value = section
                worksheet.Range("G20:G22").Value = room
            ElseIf time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E20:E24").Merge()
                worksheet.Range("F20:F24").Merge()
                worksheet.Range("G20:G24").Merge()
                worksheet.Range("E20:E24").Value = subject
                worksheet.Range("F20:F24").Value = section
                worksheet.Range("G20:G24").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:30:00" Then
            If time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E21:E23").Merge()
                worksheet.Range("F21:F23").Merge()
                worksheet.Range("G21:G23").Merge()
                worksheet.Range("E21:E23").Value = subject
                worksheet.Range("F21:F23").Value = section
                worksheet.Range("G21:G23").Value = room
            ElseIf time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E21:E25").Merge()
                worksheet.Range("F21:F25").Merge()
                worksheet.Range("G21:G25").Merge()
                worksheet.Range("E21:E25").Value = subject
                worksheet.Range("F21:F25").Value = section
                worksheet.Range("G21:G25").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:00:00" Then
            If time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E22:E24").Merge()
                worksheet.Range("F22:F24").Merge()
                worksheet.Range("G22:G24").Merge()
                worksheet.Range("E22:E24").Value = subject
                worksheet.Range("F22:F24").Value = section
                worksheet.Range("G22:G24").Value = room
            ElseIf time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E22:E26").Merge()
                worksheet.Range("F22:F26").Merge()
                worksheet.Range("G22:G26").Merge()
                worksheet.Range("E22:E26").Value = subject
                worksheet.Range("F22:F26").Value = section
                worksheet.Range("G22:G26").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:30:00" Then
            If time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E23:E25").Merge()
                worksheet.Range("F23:F25").Merge()
                worksheet.Range("G23:G25").Merge()
                worksheet.Range("E23:E25").Value = subject
                worksheet.Range("F23:F25").Value = section
                worksheet.Range("G23:G25").Value = room
            ElseIf time_end = "2020-02-11 17:30:00" Then
                worksheet.Range("E23:E27").Merge()
                worksheet.Range("F23:F27").Merge()
                worksheet.Range("G23:G27").Merge()
                worksheet.Range("E23:E27").Value = subject
                worksheet.Range("F23:F27").Value = section
                worksheet.Range("G23:G27").Value = room
            End If
        End If
        If time_start = "2020-02-11 16:00:00" Then
            If time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E24:E26").Merge()
                worksheet.Range("F24:F26").Merge()
                worksheet.Range("G24:G26").Merge()
                worksheet.Range("E24:E26").Value = subject
                worksheet.Range("F24:F26").Value = section
                worksheet.Range("G24:G26").Value = room
            ElseIf time_end = "2020-02-11 18:00:00" Then
                worksheet.Range("E24:E28").Merge()
                worksheet.Range("F24:F28").Merge()
                worksheet.Range("G24:G28").Merge()
                worksheet.Range("E24:E28").Value = subject
                worksheet.Range("F24:F28").Value = section
                worksheet.Range("G24:G28").Value = room
            End If
        End If


        ' wednesday


        If time_start = "2020-02-12 06:00:00" Then
            If time_end = "2020-02-12 07:00:00" Then
                worksheet.Range("H4:H6").Merge()
                worksheet.Range("I4:I6").Merge()
                worksheet.Range("J4:J6").Merge()
                worksheet.Range("H4:H6").Value = subject
                worksheet.Range("I4:I6").Value = section
                worksheet.Range("J4:J6").Value = room
            ElseIf time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H4:H8").Merge()
                worksheet.Range("I4:I8").Merge()
                worksheet.Range("J4:J8").Merge()
                worksheet.Range("H4:H8").Value = subject
                worksheet.Range("I4:I8").Value = section
                worksheet.Range("J4:J8").Value = room
            End If
        ElseIf time_start = "2020-02-12 06:30:00" Then

            If time_end = "2020-02-12 07:30:00" Then
                worksheet.Range("H5:H7").Merge()
                worksheet.Range("I5:I7").Merge()
                worksheet.Range("J5:J7").Merge()
                worksheet.Range("H5:H7").Value = subject
                worksheet.Range("I5:I7").Value = section
                worksheet.Range("J5:J7").Value = room
            ElseIf time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H5:H9").Merge()
                worksheet.Range("I5:I9").Merge()
                worksheet.Range("J5:J9").Merge()
                worksheet.Range("H5:H9").Value = subject
                worksheet.Range("I5:I9").Value = section
            End If
            worksheet.Range("J5:J9").Value = room
        ElseIf time_start = "2020-02-12 07:00:00" Then
            If time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H6:H8").Merge()
                worksheet.Range("I6:I8").Merge()
                worksheet.Range("J6:J8").Merge()
                worksheet.Range("H6:H8").Value = subject
                worksheet.Range("I6:I8").Value = section
                worksheet.Range("J6:J8").Value = room
            ElseIf time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H6:H10").Merge()
                worksheet.Range("I6:I10").Merge()
                worksheet.Range("J6:J10").Merge()
                worksheet.Range("H6:H10").Value = subject
                worksheet.Range("I6:I10").Value = section
                worksheet.Range("J6:J10").Value = room
            End If
        ElseIf time_start = "2020-02-12 07:30:00" Then
            If time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H7:H9").Merge()
                worksheet.Range("I7:I9").Merge()
                worksheet.Range("J7:J9").Merge()
                worksheet.Range("H7:H9").Value = subject
                worksheet.Range("I7:I9").Value = section
                worksheet.Range("J7:J9").Value = room
            ElseIf time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H7:H11").Merge()
                worksheet.Range("I7:I11").Merge()
                worksheet.Range("J7:J11").Merge()
                worksheet.Range("H7:H11").Value = subject
                worksheet.Range("I7:I11").Value = section
                worksheet.Range("J7:J11").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:00:00" Then
            If time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H8:H10").Merge()
                worksheet.Range("I8:I10").Merge()
                worksheet.Range("J8:J10").Merge()
                worksheet.Range("H8:H10").Value = subject
                worksheet.Range("I8:I10").Value = section
                worksheet.Range("J8:J10").Value = room
            ElseIf time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H8:H12").Merge()
                worksheet.Range("I8:I12").Merge()
                worksheet.Range("J8:J12").Merge()
                worksheet.Range("H8:H12").Value = subject
                worksheet.Range("I8:I12").Value = section
                worksheet.Range("J8:J12").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:30:00" Then
            If time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H9:H11").Merge()
                worksheet.Range("I9:I11").Merge()
                worksheet.Range("J9:J11").Merge()
                worksheet.Range("H9:H11").Value = subject
                worksheet.Range("I9:I11").Value = section
                worksheet.Range("J9:J11").Value = room
            ElseIf time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H6:H13").Merge()
                worksheet.Range("I9:I13").Merge()
                worksheet.Range("J9:J13").Merge()
                worksheet.Range("H9:H13").Value = subject
                worksheet.Range("I9:I13").Value = section
                worksheet.Range("J9:J13").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:00:00" Then
            If time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H10:H12").Merge()
                worksheet.Range("I10:I12").Merge()
                worksheet.Range("J10:J12").Merge()
                worksheet.Range("H10:H12").Value = subject
                worksheet.Range("I10:I12").Value = section
                worksheet.Range("J10:J12").Value = room
            ElseIf time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H10:H14").Merge()
                worksheet.Range("I10:I14").Merge()
                worksheet.Range("J10:J14").Merge()
                worksheet.Range("H10:H14").Value = subject
                worksheet.Range("I10:I14").Value = section
                worksheet.Range("J10:J14").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:30:00" Then
            If time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H11:H13").Merge()
                worksheet.Range("I11:I13").Merge()
                worksheet.Range("J11:J13").Merge()
                worksheet.Range("H11:H13").Value = subject
                worksheet.Range("I11:I13").Value = section
                worksheet.Range("J11:J13").Value = room
            ElseIf time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H11:H15").Merge()
                worksheet.Range("I11:I15").Merge()
                worksheet.Range("J11:J15").Merge()
                worksheet.Range("H11:H15").Value = subject
                worksheet.Range("I11:I15").Value = section
                worksheet.Range("J11:J15").Value = room
            End If
        ElseIf time_start = "2020-02-12 10:00:00" Then
            If time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H12:H14").Merge()
                worksheet.Range("I12:I14").Merge()
                worksheet.Range("J12:J14").Merge()
                worksheet.Range("H12:H14").Value = subject
                worksheet.Range("I12:I14").Value = section
                worksheet.Range("J12:J14").Value = room

            ElseIf time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H12:H16").Merge()
                worksheet.Range("I12:I16").Merge()
                worksheet.Range("J12:J16").Merge()
                worksheet.Range("H12:H16").Value = subject
                worksheet.Range("I12:I16").Value = section
                worksheet.Range("J12:J16").Value = room

            End If
        End If
        If time_start = "2020-02-12 10:30:00" Then
            If time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H13:H15").Merge()
                worksheet.Range("I13:I15").Merge()
                worksheet.Range("J13:J15").Merge()
                worksheet.Range("H13:H15").Value = subject
                worksheet.Range("I13:I15").Value = section
                worksheet.Range("J13:J15").Value = room
            ElseIf time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H13:H17").Merge()
                worksheet.Range("I13:I17").Merge()
                worksheet.Range("J13:J17").Merge()
                worksheet.Range("H13:H17").Value = subject
                worksheet.Range("I13:I17").Value = section
                worksheet.Range("J13:J17").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:00:00" Then
            If time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H14:H16").Merge()
                worksheet.Range("I14:I16").Merge()
                worksheet.Range("J14:J16").Merge()
                worksheet.Range("H14:H16").Value = subject
                worksheet.Range("I14:I16").Value = section
                worksheet.Range("J14:J16").Value = room
            ElseIf time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H14:H18").Merge()
                worksheet.Range("I14:I18").Merge()
                worksheet.Range("J14:J18").Merge()
                worksheet.Range("H14:H18").Value = subject
                worksheet.Range("I14:I18").Value = section
                worksheet.Range("J14:J18").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:30:00" Then
            If time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H15:H17").Merge()
                worksheet.Range("I15:I17").Merge()
                worksheet.Range("J15:J17").Merge()
                worksheet.Range("H15:H17").Value = subject
                worksheet.Range("I15:I17").Value = section
                worksheet.Range("J15:J17").Value = room
            ElseIf time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H15:H19").Merge()
                worksheet.Range("I15:I19").Merge()
                worksheet.Range("J15:J19").Merge()
                worksheet.Range("H15:H19").Value = subject
                worksheet.Range("I15:I19").Value = section
                worksheet.Range("J15:J19").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:00:00" Then
            If time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H16:H14").Merge()
                worksheet.Range("I16:I18").Merge()
                worksheet.Range("J16:J18").Merge()
                worksheet.Range("H16:H18").Value = subject
                worksheet.Range("I16:I18").Value = section
                worksheet.Range("J16:J18").Value = room
            ElseIf time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H16:H20").Merge()
                worksheet.Range("I16:I20").Merge()
                worksheet.Range("J16:J20").Merge()
                worksheet.Range("H16:H20").Value = subject
                worksheet.Range("I16:I20").Value = section
                worksheet.Range("J16:J20").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:30:00" Then
            If time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H17:H19").Merge()
                worksheet.Range("I17:I19").Merge()
                worksheet.Range("J17:J19").Merge()
                worksheet.Range("H17:H19").Value = subject
                worksheet.Range("I17:I19").Value = section
                worksheet.Range("J17:J19").Value = room
            ElseIf time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H17:H21").Merge()
                worksheet.Range("I17:I21").Merge()
                worksheet.Range("J17:J21").Merge()
                worksheet.Range("H17:H21").Value = subject
                worksheet.Range("I17:I21").Value = section
                worksheet.Range("J17:J21").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:00:00" Then
            If time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H18:H20").Merge()
                worksheet.Range("I18:I20").Merge()
                worksheet.Range("J18:J20").Merge()
                worksheet.Range("H18:H20").Value = subject
                worksheet.Range("I18:I20").Value = section
                worksheet.Range("J18:J20").Value = room
            ElseIf time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H18:H22").Merge()
                worksheet.Range("I18:I22").Merge()
                worksheet.Range("J18:J22").Merge()
                worksheet.Range("H18:H22").Value = subject
                worksheet.Range("I18:I22").Value = section
                worksheet.Range("J18:J22").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:30:00" Then
            If time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H19:H21").Merge()
                worksheet.Range("I19:I21").Merge()
                worksheet.Range("J19:J21").Merge()
                worksheet.Range("H19:H21").Value = subject
                worksheet.Range("I19:I21").Value = section
                worksheet.Range("J19:J21").Value = room
            ElseIf time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H19:H23").Merge()
                worksheet.Range("I19:I23").Merge()
                worksheet.Range("J19:J23").Merge()
                worksheet.Range("H19:H23").Value = subject
                worksheet.Range("I19:I23").Value = section
                worksheet.Range("J19:J23").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:00:00" Then
            If time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H20:H22").Merge()
                worksheet.Range("I20:I22").Merge()
                worksheet.Range("J20:J22").Merge()
                worksheet.Range("H20:H22").Value = subject
                worksheet.Range("I20:I22").Value = section
                worksheet.Range("J20:J22").Value = room
            ElseIf time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H20:H24").Merge()
                worksheet.Range("I20:I24").Merge()
                worksheet.Range("J20:J24").Merge()
                worksheet.Range("H20:H24").Value = subject
                worksheet.Range("I20:I24").Value = section
                worksheet.Range("J20:J24").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:30:00" Then
            If time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H21:H23").Merge()
                worksheet.Range("I21:I23").Merge()
                worksheet.Range("J21:J23").Merge()
                worksheet.Range("H21:H23").Value = subject
                worksheet.Range("I21:I23").Value = section
                worksheet.Range("J21:J23").Value = room
            ElseIf time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H21:H25").Merge()
                worksheet.Range("I21:I25").Merge()
                worksheet.Range("J21:J25").Merge()
                worksheet.Range("H21:H25").Value = subject
                worksheet.Range("I21:I25").Value = section
                worksheet.Range("J21:J25").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:00:00" Then
            If time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H22:H24").Merge()
                worksheet.Range("I22:I24").Merge()
                worksheet.Range("J22:J24").Merge()
                worksheet.Range("H22:H24").Value = subject
                worksheet.Range("I22:I24").Value = section
                worksheet.Range("J22:J24").Value = room
            ElseIf time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H22:H26").Merge()
                worksheet.Range("I22:I26").Merge()
                worksheet.Range("J22:J26").Merge()
                worksheet.Range("H22:H26").Value = subject
                worksheet.Range("I22:I26").Value = section
                worksheet.Range("J22:J26").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:30:00" Then
            If time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H23:H25").Merge()
                worksheet.Range("I23:I25").Merge()
                worksheet.Range("J23:J25").Merge()
                worksheet.Range("H23:H25").Value = subject
                worksheet.Range("I23:I25").Value = section
                worksheet.Range("J23:J25").Value = room
            ElseIf time_end = "2020-02-12 17:30:00" Then
                worksheet.Range("H23:H27").Merge()
                worksheet.Range("I23:I27").Merge()
                worksheet.Range("J23:J27").Merge()
                worksheet.Range("H23:H27").Value = subject
                worksheet.Range("I23:I27").Value = section
                worksheet.Range("J23:J27").Value = room
            End If
        End If
        If time_start = "2020-02-12 16:00:00" Then
            If time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H24:H26").Merge()
                worksheet.Range("I24:I26").Merge()
                worksheet.Range("J24:J26").Merge()
                worksheet.Range("H24:H26").Value = subject
                worksheet.Range("I24:I26").Value = section
                worksheet.Range("J24:J26").Value = room
            ElseIf time_end = "2020-02-12 18:00:00" Then
                worksheet.Range("H24:H28").Merge()
                worksheet.Range("I24:I28").Merge()
                worksheet.Range("J24:J28").Merge()
                worksheet.Range("H24:H28").Value = subject
                worksheet.Range("I24:I28").Value = section
                worksheet.Range("J24:J28").Value = room
            End If
        End If


        'Thursday

        If time_start = "2020-02-13 06:00:00" Then
            If time_end = "2020-02-13 07:00:00" Then
                worksheet.Range("K4:K6").Merge()
                worksheet.Range("L4:L6").Merge()
                worksheet.Range("M4:M6").Merge()
                worksheet.Range("K4:K6").Value = subject
                worksheet.Range("L4:L6").Value = section
                worksheet.Range("M4:M6").Value = room
            ElseIf time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K4:K8").Merge()
                worksheet.Range("L4:L8").Merge()
                worksheet.Range("M4:M8").Merge()
                worksheet.Range("K4:K8").Value = subject
                worksheet.Range("L4:L8").Value = section
                worksheet.Range("M4:M8").Value = room
            End If
        ElseIf time_start = "2020-02-13 06:30:00" Then

            If time_end = "2020-02-13 07:30:00" Then
                worksheet.Range("K5:K7").Merge()
                worksheet.Range("L5:L7").Merge()
                worksheet.Range("M5:M7").Merge()
                worksheet.Range("K5:K7").Value = subject
                worksheet.Range("L5:L7").Value = section
                worksheet.Range("M5:M7").Value = room
            ElseIf time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K5:K9").Merge()
                worksheet.Range("L5:L9").Merge()
                worksheet.Range("M5:M9").Merge()
                worksheet.Range("K5:K9").Value = subject
                worksheet.Range("L5:L9").Value = section
            End If
            worksheet.Range("M5:M9").Value = room
        ElseIf time_start = "2020-02-13 07:00:00" Then
            If time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K6:K8").Merge()
                worksheet.Range("L6:L8").Merge()
                worksheet.Range("M6:M8").Merge()
                worksheet.Range("K6:K8").Value = subject
                worksheet.Range("L6:L8").Value = section
                worksheet.Range("M6:M8").Value = room
            ElseIf time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K6:K10").Merge()
                worksheet.Range("L6:L10").Merge()
                worksheet.Range("M6:M10").Merge()
                worksheet.Range("K6:K10").Value = subject
                worksheet.Range("L6:L10").Value = section
                worksheet.Range("M6:M10").Value = room
            End If
        ElseIf time_start = "2020-02-13 07:30:00" Then
            If time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K7:K9").Merge()
                worksheet.Range("L7:L9").Merge()
                worksheet.Range("M7:M9").Merge()
                worksheet.Range("K7:K9").Value = subject
                worksheet.Range("L7:L9").Value = section
                worksheet.Range("M7:M9").Value = room
            ElseIf time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K7:K11").Merge()
                worksheet.Range("L7:L11").Merge()
                worksheet.Range("M7:M11").Merge()
                worksheet.Range("K7:K11").Value = subject
                worksheet.Range("L7:L11").Value = section
                worksheet.Range("M7:M11").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:00:00" Then
            If time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K8:K10").Merge()
                worksheet.Range("L8:L10").Merge()
                worksheet.Range("M8:M10").Merge()
                worksheet.Range("K8:K10").Value = subject
                worksheet.Range("L8:L10").Value = section
                worksheet.Range("M8:M10").Value = room
            ElseIf time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K8:K12").Merge()
                worksheet.Range("L8:L12").Merge()
                worksheet.Range("M8:M12").Merge()
                worksheet.Range("K8:K12").Value = subject
                worksheet.Range("L8:L12").Value = section
                worksheet.Range("M8:M12").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:30:00" Then
            If time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K9:K11").Merge()
                worksheet.Range("L9:L11").Merge()
                worksheet.Range("M9:M11").Merge()
                worksheet.Range("K9:K11").Value = subject
                worksheet.Range("L9:L11").Value = section
                worksheet.Range("M9:M11").Value = room
            ElseIf time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K6:K13").Merge()
                worksheet.Range("L9:L13").Merge()
                worksheet.Range("M9:M13").Merge()
                worksheet.Range("K9:K13").Value = subject
                worksheet.Range("L9:L13").Value = section
                worksheet.Range("M9:M13").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:00:00" Then
            If time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K10:K12").Merge()
                worksheet.Range("L10:L12").Merge()
                worksheet.Range("M10:M12").Merge()
                worksheet.Range("K10:K12").Value = subject
                worksheet.Range("L10:L12").Value = section
                worksheet.Range("M10:M12").Value = room
            ElseIf time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K10:K14").Merge()
                worksheet.Range("L10:L14").Merge()
                worksheet.Range("M10:M14").Merge()
                worksheet.Range("K10:K14").Value = subject
                worksheet.Range("L10:L14").Value = section
                worksheet.Range("M10:M14").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:30:00" Then
            If time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K11:K13").Merge()
                worksheet.Range("L11:L13").Merge()
                worksheet.Range("M11:M13").Merge()
                worksheet.Range("K11:K13").Value = subject
                worksheet.Range("L11:L13").Value = section
                worksheet.Range("M11:M13").Value = room
            ElseIf time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K11:K15").Merge()
                worksheet.Range("L11:L15").Merge()
                worksheet.Range("M11:M15").Merge()
                worksheet.Range("K11:K15").Value = subject
                worksheet.Range("L11:L15").Value = section
                worksheet.Range("M11:M15").Value = room
            End If
        ElseIf time_start = "2020-02-13 10:00:00" Then
            If time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K12:K14").Merge()
                worksheet.Range("L12:L14").Merge()
                worksheet.Range("M12:M14").Merge()
                worksheet.Range("K12:K14").Value = subject
                worksheet.Range("L12:L14").Value = section
                worksheet.Range("M12:M14").Value = room

            ElseIf time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K12:K16").Merge()
                worksheet.Range("L12:L16").Merge()
                worksheet.Range("M12:M16").Merge()
                worksheet.Range("K12:K16").Value = subject
                worksheet.Range("L12:L16").Value = section
                worksheet.Range("M12:M16").Value = room

            End If
        End If
        If time_start = "2020-02-13 10:30:00" Then
            If time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K13:K15").Merge()
                worksheet.Range("L13:L15").Merge()
                worksheet.Range("M13:M15").Merge()
                worksheet.Range("K13:K15").Value = subject
                worksheet.Range("L13:L15").Value = section
                worksheet.Range("M13:M15").Value = room
            ElseIf time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K13:K17").Merge()
                worksheet.Range("L13:L17").Merge()
                worksheet.Range("M13:M17").Merge()
                worksheet.Range("K13:K17").Value = subject
                worksheet.Range("L13:L17").Value = section
                worksheet.Range("M13:M17").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:00:00" Then
            If time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K14:K16").Merge()
                worksheet.Range("L14:L16").Merge()
                worksheet.Range("M14:M16").Merge()
                worksheet.Range("K14:K16").Value = subject
                worksheet.Range("L14:L16").Value = section
                worksheet.Range("M14:M16").Value = room
            ElseIf time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K14:K18").Merge()
                worksheet.Range("L14:L18").Merge()
                worksheet.Range("M14:M18").Merge()
                worksheet.Range("K14:K18").Value = subject
                worksheet.Range("L14:L18").Value = section
                worksheet.Range("M14:M18").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:30:00" Then
            If time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K15:K17").Merge()
                worksheet.Range("L15:L17").Merge()
                worksheet.Range("M15:M17").Merge()
                worksheet.Range("K15:K17").Value = subject
                worksheet.Range("L15:L17").Value = section
                worksheet.Range("M15:M17").Value = room
            ElseIf time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K15:K19").Merge()
                worksheet.Range("L15:L19").Merge()
                worksheet.Range("M15:M19").Merge()
                worksheet.Range("K15:K19").Value = subject
                worksheet.Range("L15:L19").Value = section
                worksheet.Range("M15:M19").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:00:00" Then
            If time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K16:K14").Merge()
                worksheet.Range("L16:L18").Merge()
                worksheet.Range("M16:M18").Merge()
                worksheet.Range("K16:K18").Value = subject
                worksheet.Range("L16:L18").Value = section
                worksheet.Range("M16:M18").Value = room
            ElseIf time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K16:K20").Merge()
                worksheet.Range("L16:L20").Merge()
                worksheet.Range("M16:M20").Merge()
                worksheet.Range("K16:K20").Value = subject
                worksheet.Range("L16:L20").Value = section
                worksheet.Range("M16:M20").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:30:00" Then
            If time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K17:K19").Merge()
                worksheet.Range("L17:L19").Merge()
                worksheet.Range("M17:M19").Merge()
                worksheet.Range("K17:K19").Value = subject
                worksheet.Range("L17:L19").Value = section
                worksheet.Range("M17:M19").Value = room
            ElseIf time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K17:K21").Merge()
                worksheet.Range("L17:L21").Merge()
                worksheet.Range("M17:M21").Merge()
                worksheet.Range("K17:K21").Value = subject
                worksheet.Range("L17:L21").Value = section
                worksheet.Range("M17:M21").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:00:00" Then
            If time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K18:K20").Merge()
                worksheet.Range("L18:L20").Merge()
                worksheet.Range("M18:M20").Merge()
                worksheet.Range("K18:K20").Value = subject
                worksheet.Range("L18:L20").Value = section
                worksheet.Range("M18:M20").Value = room
            ElseIf time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K18:K22").Merge()
                worksheet.Range("L18:L22").Merge()
                worksheet.Range("M18:M22").Merge()
                worksheet.Range("K18:K22").Value = subject
                worksheet.Range("L18:L22").Value = section
                worksheet.Range("M18:M22").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:30:00" Then
            If time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K19:K21").Merge()
                worksheet.Range("L19:L21").Merge()
                worksheet.Range("M19:M21").Merge()
                worksheet.Range("K19:K21").Value = subject
                worksheet.Range("L19:L21").Value = section
                worksheet.Range("M19:M21").Value = room
            ElseIf time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K19:K23").Merge()
                worksheet.Range("L19:L23").Merge()
                worksheet.Range("M19:M23").Merge()
                worksheet.Range("K19:K23").Value = subject
                worksheet.Range("L19:L23").Value = section
                worksheet.Range("M19:M23").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:00:00" Then
            If time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K20:K22").Merge()
                worksheet.Range("L20:L22").Merge()
                worksheet.Range("M20:M22").Merge()
                worksheet.Range("K20:K22").Value = subject
                worksheet.Range("L20:L22").Value = section
                worksheet.Range("M20:M22").Value = room
            ElseIf time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K20:K24").Merge()
                worksheet.Range("L20:L24").Merge()
                worksheet.Range("M20:M24").Merge()
                worksheet.Range("K20:K24").Value = subject
                worksheet.Range("L20:L24").Value = section
                worksheet.Range("M20:M24").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:30:00" Then
            If time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K21:K23").Merge()
                worksheet.Range("L21:L23").Merge()
                worksheet.Range("M21:M23").Merge()
                worksheet.Range("K21:K23").Value = subject
                worksheet.Range("L21:L23").Value = section
                worksheet.Range("M21:M23").Value = room
            ElseIf time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K21:K25").Merge()
                worksheet.Range("L21:L25").Merge()
                worksheet.Range("M21:M25").Merge()
                worksheet.Range("K21:K25").Value = subject
                worksheet.Range("L21:L25").Value = section
                worksheet.Range("M21:M25").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:00:00" Then
            If time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K22:K24").Merge()
                worksheet.Range("L22:L24").Merge()
                worksheet.Range("M22:M24").Merge()
                worksheet.Range("K22:K24").Value = subject
                worksheet.Range("L22:L24").Value = section
                worksheet.Range("M22:M24").Value = room
            ElseIf time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K22:K26").Merge()
                worksheet.Range("L22:L26").Merge()
                worksheet.Range("M22:M26").Merge()
                worksheet.Range("K22:K26").Value = subject
                worksheet.Range("L22:L26").Value = section
                worksheet.Range("M22:M26").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:30:00" Then
            If time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K23:K25").Merge()
                worksheet.Range("L23:L25").Merge()
                worksheet.Range("M23:M25").Merge()
                worksheet.Range("K23:K25").Value = subject
                worksheet.Range("L23:L25").Value = section
                worksheet.Range("M23:M25").Value = room
            ElseIf time_end = "2020-02-13 17:30:00" Then
                worksheet.Range("K23:K27").Merge()
                worksheet.Range("L23:L27").Merge()
                worksheet.Range("M23:M27").Merge()
                worksheet.Range("K23:K27").Value = subject
                worksheet.Range("L23:L27").Value = section
                worksheet.Range("M23:M27").Value = room
            End If
        End If
        If time_start = "2020-02-13 16:00:00" Then
            If time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K24:K26").Merge()
                worksheet.Range("L24:L26").Merge()
                worksheet.Range("M24:M26").Merge()
                worksheet.Range("K24:K26").Value = subject
                worksheet.Range("L24:L26").Value = section
                worksheet.Range("M24:M26").Value = room
            ElseIf time_end = "2020-02-13 18:00:00" Then
                worksheet.Range("K24:K28").Merge()
                worksheet.Range("L24:L28").Merge()
                worksheet.Range("M24:M28").Merge()
                worksheet.Range("K24:K28").Value = subject
                worksheet.Range("L24:L28").Value = section
                worksheet.Range("M24:M28").Value = room
            End If
        End If

        'Fridayyyy========
        If time_start = "2020-02-14 06:00:00" Then
            If time_end = "2020-02-14 07:00:00" Then
                worksheet.Range("N4:N6").Merge()
                worksheet.Range("O4:O6").Merge()
                worksheet.Range("P4:P6").Merge()
                worksheet.Range("N4:N6").Value = subject
                worksheet.Range("O4:O6").Value = section
                worksheet.Range("P4:P6").Value = room
            ElseIf time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N4:N8").Merge()
                worksheet.Range("O4:O8").Merge()
                worksheet.Range("P4:P8").Merge()
                worksheet.Range("N4:N8").Value = subject
                worksheet.Range("O4:O8").Value = section
                worksheet.Range("P4:P8").Value = room
            End If
        ElseIf time_start = "2020-02-14 06:30:00" Then

            If time_end = "2020-02-14 07:30:00" Then
                worksheet.Range("N5:N7").Merge()
                worksheet.Range("O5:O7").Merge()
                worksheet.Range("P5:P7").Merge()
                worksheet.Range("N5:N7").Value = subject
                worksheet.Range("O5:O7").Value = section
                worksheet.Range("P5:P7").Value = room
            ElseIf time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N5:N9").Merge()
                worksheet.Range("O5:O9").Merge()
                worksheet.Range("P5:P9").Merge()
                worksheet.Range("N5:N9").Value = subject
                worksheet.Range("O5:O9").Value = section
            End If
            worksheet.Range("P5:P9").Value = room
        ElseIf time_start = "2020-02-14 07:00:00" Then
            If time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N6:N8").Merge()
                worksheet.Range("O6:O8").Merge()
                worksheet.Range("P6:P8").Merge()
                worksheet.Range("N6:N8").Value = subject
                worksheet.Range("O6:O8").Value = section
                worksheet.Range("P6:P8").Value = room
            ElseIf time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N6:N10").Merge()
                worksheet.Range("O6:O10").Merge()
                worksheet.Range("P6:P10").Merge()
                worksheet.Range("N6:N10").Value = subject
                worksheet.Range("O6:O10").Value = section
                worksheet.Range("P6:P10").Value = room
            End If
        ElseIf time_start = "2020-02-14 07:30:00" Then
            If time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N7:N9").Merge()
                worksheet.Range("O7:O9").Merge()
                worksheet.Range("P7:P9").Merge()
                worksheet.Range("N7:N9").Value = subject
                worksheet.Range("O7:O9").Value = section
                worksheet.Range("P7:P9").Value = room
            ElseIf time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N7:N11").Merge()
                worksheet.Range("O7:O11").Merge()
                worksheet.Range("P7:P11").Merge()
                worksheet.Range("N7:N11").Value = subject
                worksheet.Range("O7:O11").Value = section
                worksheet.Range("P7:P11").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:00:00" Then
            If time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N8:N10").Merge()
                worksheet.Range("O8:O10").Merge()
                worksheet.Range("P8:P10").Merge()
                worksheet.Range("N8:N10").Value = subject
                worksheet.Range("O8:O10").Value = section
                worksheet.Range("P8:P10").Value = room
            ElseIf time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N8:N12").Merge()
                worksheet.Range("O8:O12").Merge()
                worksheet.Range("P8:P12").Merge()
                worksheet.Range("N8:N12").Value = subject
                worksheet.Range("O8:O12").Value = section
                worksheet.Range("P8:P12").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:30:00" Then
            If time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N9:N11").Merge()
                worksheet.Range("O9:O11").Merge()
                worksheet.Range("P9:P11").Merge()
                worksheet.Range("N9:N11").Value = subject
                worksheet.Range("O9:O11").Value = section
                worksheet.Range("P9:P11").Value = room
            ElseIf time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N6:N13").Merge()
                worksheet.Range("O9:O13").Merge()
                worksheet.Range("P9:P13").Merge()
                worksheet.Range("N9:N13").Value = subject
                worksheet.Range("O9:O13").Value = section
                worksheet.Range("P9:P13").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:00:00" Then
            If time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N10:N12").Merge()
                worksheet.Range("O10:O12").Merge()
                worksheet.Range("P10:P12").Merge()
                worksheet.Range("N10:N12").Value = subject
                worksheet.Range("O10:O12").Value = section
                worksheet.Range("P10:P12").Value = room
            ElseIf time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N10:N14").Merge()
                worksheet.Range("O10:O14").Merge()
                worksheet.Range("P10:P14").Merge()
                worksheet.Range("N10:N14").Value = subject
                worksheet.Range("O10:O14").Value = section
                worksheet.Range("P10:P14").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:30:00" Then
            If time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N11:N13").Merge()
                worksheet.Range("O11:O13").Merge()
                worksheet.Range("P11:P13").Merge()
                worksheet.Range("N11:N13").Value = subject
                worksheet.Range("O11:O13").Value = section
                worksheet.Range("P11:P13").Value = room
            ElseIf time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N11:N15").Merge()
                worksheet.Range("O11:O15").Merge()
                worksheet.Range("P11:P15").Merge()
                worksheet.Range("N11:N15").Value = subject
                worksheet.Range("O11:O15").Value = section
                worksheet.Range("P11:P15").Value = room
            End If
        ElseIf time_start = "2020-02-14 10:00:00" Then
            If time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N12:N14").Merge()
                worksheet.Range("O12:O14").Merge()
                worksheet.Range("P12:P14").Merge()
                worksheet.Range("N12:N14").Value = subject
                worksheet.Range("O12:O14").Value = section
                worksheet.Range("P12:P14").Value = room

            ElseIf time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N12:N16").Merge()
                worksheet.Range("O12:O16").Merge()
                worksheet.Range("P12:P16").Merge()
                worksheet.Range("N12:N16").Value = subject
                worksheet.Range("O12:O16").Value = section
                worksheet.Range("P12:P16").Value = room

            End If
        End If
        If time_start = "2020-02-14 10:30:00" Then
            If time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N13:N15").Merge()
                worksheet.Range("O13:O15").Merge()
                worksheet.Range("P13:P15").Merge()
                worksheet.Range("N13:N15").Value = subject
                worksheet.Range("O13:O15").Value = section
                worksheet.Range("P13:P15").Value = room
            ElseIf time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N13:N17").Merge()
                worksheet.Range("O13:O17").Merge()
                worksheet.Range("P13:P17").Merge()
                worksheet.Range("N13:N17").Value = subject
                worksheet.Range("O13:O17").Value = section
                worksheet.Range("P13:P17").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:00:00" Then
            If time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N14:N16").Merge()
                worksheet.Range("O14:O16").Merge()
                worksheet.Range("P14:P16").Merge()
                worksheet.Range("N14:N16").Value = subject
                worksheet.Range("O14:O16").Value = section
                worksheet.Range("P14:P16").Value = room
            ElseIf time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N14:N18").Merge()
                worksheet.Range("O14:O18").Merge()
                worksheet.Range("P14:P18").Merge()
                worksheet.Range("N14:N18").Value = subject
                worksheet.Range("O14:O18").Value = section
                worksheet.Range("P14:P18").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:30:00" Then
            If time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N15:N17").Merge()
                worksheet.Range("O15:O17").Merge()
                worksheet.Range("P15:P17").Merge()
                worksheet.Range("N15:N17").Value = subject
                worksheet.Range("O15:O17").Value = section
                worksheet.Range("P15:P17").Value = room
            ElseIf time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N15:N19").Merge()
                worksheet.Range("O15:O19").Merge()
                worksheet.Range("P15:P19").Merge()
                worksheet.Range("N15:N19").Value = subject
                worksheet.Range("O15:O19").Value = section
                worksheet.Range("P15:P19").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:00:00" Then
            If time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N16:N14").Merge()
                worksheet.Range("O16:O18").Merge()
                worksheet.Range("P16:P18").Merge()
                worksheet.Range("N16:N18").Value = subject
                worksheet.Range("O16:O18").Value = section
                worksheet.Range("P16:P18").Value = room
            ElseIf time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N16:N20").Merge()
                worksheet.Range("O16:O20").Merge()
                worksheet.Range("P16:P20").Merge()
                worksheet.Range("N16:N20").Value = subject
                worksheet.Range("O16:O20").Value = section
                worksheet.Range("P16:P20").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:30:00" Then
            If time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N17:N19").Merge()
                worksheet.Range("O17:O19").Merge()
                worksheet.Range("P17:P19").Merge()
                worksheet.Range("N17:N19").Value = subject
                worksheet.Range("O17:O19").Value = section
                worksheet.Range("P17:P19").Value = room
            ElseIf time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N17:N21").Merge()
                worksheet.Range("O17:O21").Merge()
                worksheet.Range("P17:P21").Merge()
                worksheet.Range("N17:N21").Value = subject
                worksheet.Range("O17:O21").Value = section
                worksheet.Range("P17:P21").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:00:00" Then
            If time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N18:N20").Merge()
                worksheet.Range("O18:O20").Merge()
                worksheet.Range("P18:P20").Merge()
                worksheet.Range("N18:N20").Value = subject
                worksheet.Range("O18:O20").Value = section
                worksheet.Range("P18:P20").Value = room
            ElseIf time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N18:N22").Merge()
                worksheet.Range("O18:O22").Merge()
                worksheet.Range("P18:P22").Merge()
                worksheet.Range("N18:N22").Value = subject
                worksheet.Range("O18:O22").Value = section
                worksheet.Range("P18:P22").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:30:00" Then
            If time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N19:N21").Merge()
                worksheet.Range("O19:O21").Merge()
                worksheet.Range("P19:P21").Merge()
                worksheet.Range("N19:N21").Value = subject
                worksheet.Range("O19:O21").Value = section
                worksheet.Range("P19:P21").Value = room
            ElseIf time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N19:N23").Merge()
                worksheet.Range("O19:O23").Merge()
                worksheet.Range("P19:P23").Merge()
                worksheet.Range("N19:N23").Value = subject
                worksheet.Range("O19:O23").Value = section
                worksheet.Range("P19:P23").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:00:00" Then
            If time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N20:N22").Merge()
                worksheet.Range("O20:O22").Merge()
                worksheet.Range("P20:P22").Merge()
                worksheet.Range("N20:N22").Value = subject
                worksheet.Range("O20:O22").Value = section
                worksheet.Range("P20:P22").Value = room
            ElseIf time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N20:N24").Merge()
                worksheet.Range("O20:O24").Merge()
                worksheet.Range("P20:P24").Merge()
                worksheet.Range("N20:N24").Value = subject
                worksheet.Range("O20:O24").Value = section
                worksheet.Range("P20:P24").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:30:00" Then
            If time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N21:N23").Merge()
                worksheet.Range("O21:O23").Merge()
                worksheet.Range("P21:P23").Merge()
                worksheet.Range("N21:N23").Value = subject
                worksheet.Range("O21:O23").Value = section
                worksheet.Range("P21:P23").Value = room
            ElseIf time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N21:N25").Merge()
                worksheet.Range("O21:O25").Merge()
                worksheet.Range("P21:P25").Merge()
                worksheet.Range("N21:N25").Value = subject
                worksheet.Range("O21:O25").Value = section
                worksheet.Range("P21:P25").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:00:00" Then
            If time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N22:N24").Merge()
                worksheet.Range("O22:O24").Merge()
                worksheet.Range("P22:P24").Merge()
                worksheet.Range("N22:N24").Value = subject
                worksheet.Range("O22:O24").Value = section
                worksheet.Range("P22:P24").Value = room
            ElseIf time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N22:N26").Merge()
                worksheet.Range("O22:O26").Merge()
                worksheet.Range("P22:P26").Merge()
                worksheet.Range("N22:N26").Value = subject
                worksheet.Range("O22:O26").Value = section
                worksheet.Range("P22:P26").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:30:00" Then
            If time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N23:N25").Merge()
                worksheet.Range("O23:O25").Merge()
                worksheet.Range("P23:P25").Merge()
                worksheet.Range("N23:N25").Value = subject
                worksheet.Range("O23:O25").Value = section
                worksheet.Range("P23:P25").Value = room
            ElseIf time_end = "2020-02-14 17:30:00" Then
                worksheet.Range("N23:N27").Merge()
                worksheet.Range("O23:O27").Merge()
                worksheet.Range("P23:P27").Merge()
                worksheet.Range("N23:N27").Value = subject
                worksheet.Range("O23:O27").Value = section
                worksheet.Range("P23:P27").Value = room
            End If
        End If
        If time_start = "2020-02-14 16:00:00" Then
            If time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N24:N26").Merge()
                worksheet.Range("O24:O26").Merge()
                worksheet.Range("P24:P26").Merge()
                worksheet.Range("N24:N26").Value = subject
                worksheet.Range("O24:O26").Value = section
                worksheet.Range("P24:P26").Value = room
            ElseIf time_end = "2020-02-14 18:00:00" Then
                worksheet.Range("N24:N28").Merge()
                worksheet.Range("O24:O28").Merge()
                worksheet.Range("P24:P28").Merge()
                worksheet.Range("N24:N28").Value = subject
                worksheet.Range("O24:O28").Value = section
                worksheet.Range("P24:P28").Value = room
            End If
        End If
    End Sub

    'Row3
    Private Sub CheckDateToInsertRow3()
        Dim id As String = choose_expo.SelectedValue
        Dim s As String = "select prof_details_tbl.`FName_prof`, 
    prof_details_tbl.`MName_prof`, 
    prof_details_tbl.`LName_prof`,
    subjects_tbl.subject_Name, 
    `schedule_tbl`.strandName, 
    `schedule_tbl`.grade_lvl, 
    `schedule_tbl`.section_no, `schedule_tbl`.building_no, 
    `schedule_tbl`.room_no,
schedule_tbl.time_start, 
schedule_tbl.time_end from prof_details_tbl ,schedule_tbl inner join subjects_tbl on schedule_tbl.subject = subjects_tbl.snn
    where prof_details_tbl.ID_Prof='" + id + "' and `schedule_tbl`.`id_Prof`='" + id + "' and sy='" + print_sy.Text + "' and semestral_sche='" + print_sem.Text + "'"
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)

        Dim row3 As DataRow = tb.Rows(2)
        Dim subject As String = row3(3)
        Dim section As String = row3(4) + " " + row3(5) + "-" + row3(6)
        Dim room As String = row3(7) + " " + row3(8)
        time_start = row3(9)
        time_end = row3(10)
        'Monday start
        If time_start = "2020-02-10 06:00:00" Then
            If time_end = "2020-02-10 07:00:00" Then
                worksheet.Range("B4:B6").Merge()
                worksheet.Range("C4:C6").Merge()
                worksheet.Range("D4:D6").Merge()
                worksheet.Range("B4:B6").Value = subject
                worksheet.Range("C4:C6").Value = section
                worksheet.Range("D4:D6").Value = room
            ElseIf time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B4:B8").Merge()
                worksheet.Range("C4:C8").Merge()
                worksheet.Range("D4:D8").Merge()
                worksheet.Range("B4:B8").Value = subject
                worksheet.Range("C4:C8").Value = section
                worksheet.Range("D4:D8").Value = room
            End If
        ElseIf time_start = "2020-02-10 06:30:00" Then

            If time_end = "2020-02-10 07:30:00" Then
                worksheet.Range("B5:B7").Merge()
                worksheet.Range("C5:C7").Merge()
                worksheet.Range("D5:D7").Merge()
                worksheet.Range("B5:B7").Value = subject

                worksheet.Range("C5:C7").Value = section
                worksheet.Range("D5:D7").Value = room
            ElseIf time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B5:B9").Merge()
                worksheet.Range("C5:C9").Merge()
                worksheet.Range("D5:D9").Merge()
                worksheet.Range("B5:B9").Value = subject

                worksheet.Range("C5:C9").Value = section
            End If
            worksheet.Range("D5:D9").Value = room
        ElseIf time_start = "2020-02-10 07:00:00" Then
            If time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B6:B8").Merge()
                worksheet.Range("C6:C8").Merge()
                worksheet.Range("D6:D8").Merge()
                worksheet.Range("B6:B8").Value = subject
                worksheet.Range("C6:C8").Value = section
                worksheet.Range("D6:D8").Value = room
            ElseIf time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B6:B10").Merge()
                worksheet.Range("C6:C10").Merge()
                worksheet.Range("D6:D10").Merge()
                worksheet.Range("B6:B10").Value = subject
                worksheet.Range("C6:C10").Value = section
                worksheet.Range("D6:D10").Value = room
            End If
        ElseIf time_start = "2020-02-10 07:30:00" Then
            If time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B7:B9").Merge()
                worksheet.Range("C7:C9").Merge()
                worksheet.Range("D7:D9").Merge()
                worksheet.Range("B7:B9").Value = subject
                worksheet.Range("C7:C9").Value = section
                worksheet.Range("D7:D9").Value = room
            ElseIf time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B7:B11").Merge()
                worksheet.Range("C7:C11").Merge()
                worksheet.Range("D7:D11").Merge()
                worksheet.Range("B7:B11").Value = subject
                worksheet.Range("C7:C11").Value = section
                worksheet.Range("D7:D11").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:00:00" Then
            If time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B8:B10").Merge()
                worksheet.Range("C8:C10").Merge()
                worksheet.Range("D8:D10").Merge()
                worksheet.Range("B8:B10").Value = subject
                worksheet.Range("C8:C10").Value = section
                worksheet.Range("D8:D10").Value = room
            ElseIf time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B8:B12").Merge()
                worksheet.Range("C8:C12").Merge()
                worksheet.Range("D8:D12").Merge()
                worksheet.Range("B8:B12").Value = subject
                worksheet.Range("C8:C12").Value = section
                worksheet.Range("D8:D12").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:30:00" Then
            If time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B9:B11").Merge()
                worksheet.Range("C9:C11").Merge()
                worksheet.Range("D9:D11").Merge()
                worksheet.Range("B9:B11").Value = subject
                worksheet.Range("C9:C11").Value = section
                worksheet.Range("D9:D11").Value = room
            ElseIf time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B6:B13").Merge()
                worksheet.Range("C9:C13").Merge()
                worksheet.Range("D9:D13").Merge()
                worksheet.Range("B9:B13").Value = subject
                worksheet.Range("C9:C13").Value = section
                worksheet.Range("D9:D13").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:00:00" Then
            If time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B10:B12").Merge()
                worksheet.Range("C10:C12").Merge()
                worksheet.Range("D10:D12").Merge()
                worksheet.Range("B10:B12").Value = subject
                worksheet.Range("C10:C12").Value = section
                worksheet.Range("D10:D12").Value = room
            ElseIf time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B10:B14").Merge()
                worksheet.Range("C10:C14").Merge()
                worksheet.Range("D10:D14").Merge()
                worksheet.Range("B10:B14").Value = subject
                worksheet.Range("C10:C14").Value = section
                worksheet.Range("D10:D14").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:30:00" Then
            If time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B11:B13").Merge()
                worksheet.Range("C11:C13").Merge()
                worksheet.Range("D11:D13").Merge()
                worksheet.Range("B11:B13").Value = subject
                worksheet.Range("C11:C13").Value = section
                worksheet.Range("D11:D13").Value = room
            ElseIf time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B11:B15").Merge()
                worksheet.Range("C11:C15").Merge()
                worksheet.Range("D11:D15").Merge()
                worksheet.Range("B11:B15").Value = subject
                worksheet.Range("C11:C15").Value = section
                worksheet.Range("D11:D15").Value = room
            End If
        ElseIf time_start = "2020-02-10 10:00:00" Then
            If time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B12:B14").Merge()
                worksheet.Range("C12:C14").Merge()
                worksheet.Range("D12:D14").Merge()
                worksheet.Range("B12:B14").Value = subject
                worksheet.Range("C12:C14").Value = section
                worksheet.Range("D12:D14").Value = room

            ElseIf time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B12:B16").Merge()
                worksheet.Range("C12:C16").Merge()
                worksheet.Range("D12:D16").Merge()
                worksheet.Range("B12:B16").Value = subject
                worksheet.Range("C12:C16").Value = section
                worksheet.Range("D12:D16").Value = room

            End If
        End If
        If time_start = "2020-02-10 10:30:00" Then
            If time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B13:B15").Merge()
                worksheet.Range("C13:C15").Merge()
                worksheet.Range("D13:D15").Merge()
                worksheet.Range("B13:B15").Value = subject
                worksheet.Range("C13:C15").Value = section
                worksheet.Range("D13:D15").Value = room
            ElseIf time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B13:B17").Merge()
                worksheet.Range("C13:C17").Merge()
                worksheet.Range("D13:D17").Merge()
                worksheet.Range("B13:B17").Value = subject
                worksheet.Range("C13:C17").Value = section
                worksheet.Range("D13:D17").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:00:00" Then
            If time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B14:B16").Merge()
                worksheet.Range("C14:C16").Merge()
                worksheet.Range("D14:D16").Merge()
                worksheet.Range("B14:B16").Value = subject
                worksheet.Range("C14:C16").Value = section
                worksheet.Range("D14:D16").Value = room
            ElseIf time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B14:B18").Merge()
                worksheet.Range("C14:C18").Merge()
                worksheet.Range("D14:D18").Merge()
                worksheet.Range("B14:B18").Value = subject
                worksheet.Range("C14:C18").Value = section
                worksheet.Range("D14:D18").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:30:00" Then
            If time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B15:B17").Merge()
                worksheet.Range("C15:C17").Merge()
                worksheet.Range("D15:D17").Merge()
                worksheet.Range("B15:B17").Value = subject
                worksheet.Range("C15:C17").Value = section
                worksheet.Range("D15:D17").Value = room
            ElseIf time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B15:B19").Merge()
                worksheet.Range("C15:C19").Merge()
                worksheet.Range("D15:D19").Merge()
                worksheet.Range("B15:B19").Value = subject
                worksheet.Range("C15:C19").Value = section
                worksheet.Range("D15:D19").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:00:00" Then
            If time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B16:B14").Merge()
                worksheet.Range("C16:C18").Merge()
                worksheet.Range("D16:D18").Merge()
                worksheet.Range("B16:B18").Value = subject
                worksheet.Range("C16:C18").Value = section
                worksheet.Range("D16:D18").Value = room
            ElseIf time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B16:B20").Merge()
                worksheet.Range("C16:C20").Merge()
                worksheet.Range("D16:D20").Merge()
                worksheet.Range("B16:B20").Value = subject
                worksheet.Range("C16:C20").Value = section
                worksheet.Range("D16:D20").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:30:00" Then
            If time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B17:B19").Merge()
                worksheet.Range("C17:C19").Merge()
                worksheet.Range("D17:D19").Merge()
                worksheet.Range("B17:B19").Value = subject
                worksheet.Range("C17:C19").Value = section
                worksheet.Range("D17:D19").Value = room
            ElseIf time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B17:B21").Merge()
                worksheet.Range("C17:C21").Merge()
                worksheet.Range("D17:D21").Merge()
                worksheet.Range("B17:B21").Value = subject
                worksheet.Range("C17:C21").Value = section
                worksheet.Range("D17:D21").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:00:00" Then
            If time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B18:B20").Merge()
                worksheet.Range("C18:C20").Merge()
                worksheet.Range("D18:D20").Merge()
                worksheet.Range("B18:B20").Value = subject
                worksheet.Range("C18:C20").Value = section
                worksheet.Range("D18:D20").Value = room
            ElseIf time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B18:B22").Merge()
                worksheet.Range("C18:C22").Merge()
                worksheet.Range("D18:D22").Merge()
                worksheet.Range("B18:B22").Value = subject
                worksheet.Range("C18:C22").Value = section
                worksheet.Range("D18:D22").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:30:00" Then
            If time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B19:B21").Merge()
                worksheet.Range("C19:C21").Merge()
                worksheet.Range("D19:D21").Merge()
                worksheet.Range("B19:B21").Value = subject
                worksheet.Range("C19:C21").Value = section
                worksheet.Range("D19:D21").Value = room
            ElseIf time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B19:B23").Merge()
                worksheet.Range("C19:C23").Merge()
                worksheet.Range("D19:D23").Merge()
                worksheet.Range("B19:B23").Value = subject
                worksheet.Range("C19:C23").Value = section
                worksheet.Range("D19:D23").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:00:00" Then
            If time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B20:B22").Merge()
                worksheet.Range("C20:C22").Merge()
                worksheet.Range("D20:D22").Merge()
                worksheet.Range("B20:B22").Value = subject
                worksheet.Range("C20:C22").Value = section
                worksheet.Range("D20:D22").Value = room
            ElseIf time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B20:B24").Merge()
                worksheet.Range("C20:C24").Merge()
                worksheet.Range("D20:D24").Merge()
                worksheet.Range("B20:B24").Value = subject
                worksheet.Range("C20:C24").Value = section
                worksheet.Range("D20:D24").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:30:00" Then
            If time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B21:B23").Merge()
                worksheet.Range("C21:C23").Merge()
                worksheet.Range("D21:D23").Merge()
                worksheet.Range("B21:B23").Value = subject
                worksheet.Range("C21:C23").Value = section
                worksheet.Range("D21:D23").Value = room
            ElseIf time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B21:B25").Merge()
                worksheet.Range("C21:C25").Merge()
                worksheet.Range("D21:D25").Merge()
                worksheet.Range("B21:B25").Value = subject
                worksheet.Range("C21:C25").Value = section
                worksheet.Range("D21:D25").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:00:00" Then
            If time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B22:B24").Merge()
                worksheet.Range("C22:C24").Merge()
                worksheet.Range("D22:D24").Merge()
                worksheet.Range("B22:B24").Value = subject
                worksheet.Range("C22:C24").Value = section
                worksheet.Range("D22:D24").Value = room
            ElseIf time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B22:B26").Merge()
                worksheet.Range("C22:C26").Merge()
                worksheet.Range("D22:D26").Merge()
                worksheet.Range("B22:B26").Value = subject
                worksheet.Range("C22:C26").Value = section
                worksheet.Range("D22:D26").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:30:00" Then
            If time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B23:B25").Merge()
                worksheet.Range("C23:C25").Merge()
                worksheet.Range("D23:D25").Merge()
                worksheet.Range("B23:B25").Value = subject
                worksheet.Range("C23:C25").Value = section
                worksheet.Range("D23:D25").Value = room
            ElseIf time_end = "2020-02-10 17:30:00" Then
                worksheet.Range("B23:B27").Merge()
                worksheet.Range("C23:C27").Merge()
                worksheet.Range("D23:D27").Merge()
                worksheet.Range("B23:B27").Value = subject
                worksheet.Range("C23:C27").Value = section
                worksheet.Range("D23:D27").Value = room
            End If
        End If
        If time_start = "2020-02-10 16:00:00" Then
            If time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B24:B26").Merge()
                worksheet.Range("C24:C26").Merge()
                worksheet.Range("D24:D26").Merge()
                worksheet.Range("B24:B26").Value = subject
                worksheet.Range("C24:C26").Value = section
                worksheet.Range("D24:D26").Value = room
            ElseIf time_end = "2020-02-10 18:00:00" Then
                worksheet.Range("B24:B28").Merge()
                worksheet.Range("C24:C28").Merge()
                worksheet.Range("D24:D28").Merge()
                worksheet.Range("B24:B28").Value = subject
                worksheet.Range("C24:C28").Value = section
                worksheet.Range("D24:D28").Value = room
            End If
        End If



        'tuesday start-----------------------------------------------


        If time_start = "2020-02-11 06:00:00" Then
            If time_end = "2020-02-11 07:00:00" Then
                worksheet.Range("E4:E6").Merge()
                worksheet.Range("F4:F6").Merge()
                worksheet.Range("G4:G6").Merge()
                worksheet.Range("E4:E6").Value = subject
                worksheet.Range("F4:F6").Value = section
                worksheet.Range("G4:G6").Value = room
            ElseIf time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E4:E8").Merge()
                worksheet.Range("F4:F8").Merge()
                worksheet.Range("G4:G8").Merge()
                worksheet.Range("E4:E8").Value = subject
                worksheet.Range("F4:F8").Value = section
                worksheet.Range("G4:G8").Value = room
            End If
        ElseIf time_start = "2020-02-11 06:30:00" Then

            If time_end = "2020-02-11 07:30:00" Then
                worksheet.Range("E5:E7").Merge()
                worksheet.Range("F5:F7").Merge()
                worksheet.Range("G5:G7").Merge()
                worksheet.Range("E5:E7").Value = subject
                worksheet.Range("F5:F7").Value = section
                worksheet.Range("G5:G7").Value = room
            ElseIf time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E5:E9").Merge()
                worksheet.Range("F5:F9").Merge()
                worksheet.Range("G5:G9").Merge()
                worksheet.Range("E5:E9").Value = subject
                worksheet.Range("F5:F9").Value = section
            End If
            worksheet.Range("G5:G9").Value = room
        ElseIf time_start = "2020-02-11 07:00:00" Then
            If time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E6:E8").Merge()
                worksheet.Range("F6:F8").Merge()
                worksheet.Range("G6:G8").Merge()
                worksheet.Range("E6:E8").Value = subject
                worksheet.Range("F6:F8").Value = section
                worksheet.Range("G6:G8").Value = room
            ElseIf time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E6:E10").Merge()
                worksheet.Range("F6:F10").Merge()
                worksheet.Range("G6:G10").Merge()
                worksheet.Range("E6:E10").Value = subject
                worksheet.Range("F6:F10").Value = section
                worksheet.Range("G6:G10").Value = room
            End If
        ElseIf time_start = "2020-02-11 07:30:00" Then
            If time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E7:E9").Merge()
                worksheet.Range("F7:F9").Merge()
                worksheet.Range("G7:G9").Merge()
                worksheet.Range("E7:E9").Value = subject
                worksheet.Range("F7:F9").Value = section
                worksheet.Range("G7:G9").Value = room
            ElseIf time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E7:E11").Merge()
                worksheet.Range("F7:F11").Merge()
                worksheet.Range("G7:G11").Merge()
                worksheet.Range("E7:E11").Value = subject
                worksheet.Range("F7:F11").Value = section
                worksheet.Range("G7:G11").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:00:00" Then
            If time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E8:E10").Merge()
                worksheet.Range("F8:F10").Merge()
                worksheet.Range("G8:G10").Merge()
                worksheet.Range("E8:E10").Value = subject
                worksheet.Range("F8:F10").Value = section
                worksheet.Range("G8:G10").Value = room
            ElseIf time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E8:E12").Merge()
                worksheet.Range("F8:F12").Merge()
                worksheet.Range("G8:G12").Merge()
                worksheet.Range("E8:E12").Value = subject
                worksheet.Range("F8:F12").Value = section
                worksheet.Range("G8:G12").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:30:00" Then
            If time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E9:E11").Merge()
                worksheet.Range("F9:F11").Merge()
                worksheet.Range("G9:G11").Merge()
                worksheet.Range("E9:E11").Value = subject
                worksheet.Range("F9:F11").Value = section
                worksheet.Range("G9:G11").Value = room
            ElseIf time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E6:E13").Merge()
                worksheet.Range("F9:F13").Merge()
                worksheet.Range("G9:G13").Merge()
                worksheet.Range("E9:E13").Value = subject
                worksheet.Range("F9:F13").Value = section
                worksheet.Range("G9:G13").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:00:00" Then
            If time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E10:E12").Merge()
                worksheet.Range("F10:F12").Merge()
                worksheet.Range("G10:G12").Merge()
                worksheet.Range("E10:E12").Value = subject
                worksheet.Range("F10:F12").Value = section
                worksheet.Range("G10:G12").Value = room
            ElseIf time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E10:E14").Merge()
                worksheet.Range("F10:F14").Merge()
                worksheet.Range("G10:G14").Merge()
                worksheet.Range("E10:E14").Value = subject
                worksheet.Range("F10:F14").Value = section
                worksheet.Range("G10:G14").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:30:00" Then
            If time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E11:E13").Merge()
                worksheet.Range("F11:F13").Merge()
                worksheet.Range("G11:G13").Merge()
                worksheet.Range("E11:E13").Value = subject
                worksheet.Range("F11:F13").Value = section
                worksheet.Range("G11:G13").Value = room
            ElseIf time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E11:E15").Merge()
                worksheet.Range("F11:F15").Merge()
                worksheet.Range("G11:G15").Merge()
                worksheet.Range("E11:E15").Value = subject
                worksheet.Range("F11:F15").Value = section
                worksheet.Range("G11:G15").Value = room
            End If
        ElseIf time_start = "2020-02-11 10:00:00" Then
            If time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E12:E14").Merge()
                worksheet.Range("F12:F14").Merge()
                worksheet.Range("G12:G14").Merge()
                worksheet.Range("E12:E14").Value = subject
                worksheet.Range("F12:F14").Value = section
                worksheet.Range("G12:G14").Value = room

            ElseIf time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E12:E16").Merge()
                worksheet.Range("F12:F16").Merge()
                worksheet.Range("G12:G16").Merge()
                worksheet.Range("E12:E16").Value = subject
                worksheet.Range("F12:F16").Value = section
                worksheet.Range("G12:G16").Value = room

            End If
        End If
        If time_start = "2020-02-11 10:30:00" Then
            If time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E13:E15").Merge()
                worksheet.Range("F13:F15").Merge()
                worksheet.Range("G13:G15").Merge()
                worksheet.Range("E13:E15").Value = subject
                worksheet.Range("F13:F15").Value = section
                worksheet.Range("G13:G15").Value = room
            ElseIf time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E13:E17").Merge()
                worksheet.Range("F13:F17").Merge()
                worksheet.Range("G13:G17").Merge()
                worksheet.Range("E13:E17").Value = subject
                worksheet.Range("F13:F17").Value = section
                worksheet.Range("G13:G17").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:00:00" Then
            If time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E14:E16").Merge()
                worksheet.Range("F14:F16").Merge()
                worksheet.Range("G14:G16").Merge()
                worksheet.Range("E14:E16").Value = subject
                worksheet.Range("F14:F16").Value = section
                worksheet.Range("G14:G16").Value = room
            ElseIf time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E14:E18").Merge()
                worksheet.Range("F14:F18").Merge()
                worksheet.Range("G14:G18").Merge()
                worksheet.Range("E14:E18").Value = subject
                worksheet.Range("F14:F18").Value = section
                worksheet.Range("G14:G18").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:30:00" Then
            If time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E15:E17").Merge()
                worksheet.Range("F15:F17").Merge()
                worksheet.Range("G15:G17").Merge()
                worksheet.Range("E15:E17").Value = subject
                worksheet.Range("F15:F17").Value = section
                worksheet.Range("G15:G17").Value = room
            ElseIf time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E15:E19").Merge()
                worksheet.Range("F15:F19").Merge()
                worksheet.Range("G15:G19").Merge()
                worksheet.Range("E15:E19").Value = subject
                worksheet.Range("F15:F19").Value = section
                worksheet.Range("G15:G19").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:00:00" Then
            If time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E16:E14").Merge()
                worksheet.Range("F16:F18").Merge()
                worksheet.Range("G16:G18").Merge()
                worksheet.Range("E16:E18").Value = subject
                worksheet.Range("F16:F18").Value = section
                worksheet.Range("G16:G18").Value = room
            ElseIf time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E16:E20").Merge()
                worksheet.Range("F16:F20").Merge()
                worksheet.Range("G16:G20").Merge()
                worksheet.Range("E16:E20").Value = subject
                worksheet.Range("F16:F20").Value = section
                worksheet.Range("G16:G20").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:30:00" Then
            If time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E17:E19").Merge()
                worksheet.Range("F17:F19").Merge()
                worksheet.Range("G17:G19").Merge()
                worksheet.Range("E17:E19").Value = subject
                worksheet.Range("F17:F19").Value = section
                worksheet.Range("G17:G19").Value = room
            ElseIf time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E17:E21").Merge()
                worksheet.Range("F17:F21").Merge()
                worksheet.Range("G17:G21").Merge()
                worksheet.Range("E17:E21").Value = subject
                worksheet.Range("F17:F21").Value = section
                worksheet.Range("G17:G21").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:00:00" Then
            If time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E18:E20").Merge()
                worksheet.Range("F18:F20").Merge()
                worksheet.Range("G18:G20").Merge()
                worksheet.Range("E18:E20").Value = subject
                worksheet.Range("F18:F20").Value = section
                worksheet.Range("G18:G20").Value = room
            ElseIf time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E18:E22").Merge()
                worksheet.Range("F18:F22").Merge()
                worksheet.Range("G18:G22").Merge()
                worksheet.Range("E18:E22").Value = subject
                worksheet.Range("F18:F22").Value = section
                worksheet.Range("G18:G22").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:30:00" Then
            If time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E19:E21").Merge()
                worksheet.Range("F19:F21").Merge()
                worksheet.Range("G19:G21").Merge()
                worksheet.Range("E19:E21").Value = subject
                worksheet.Range("F19:F21").Value = section
                worksheet.Range("G19:G21").Value = room
            ElseIf time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E19:E23").Merge()
                worksheet.Range("F19:F23").Merge()
                worksheet.Range("G19:G23").Merge()
                worksheet.Range("E19:E23").Value = subject
                worksheet.Range("F19:F23").Value = section
                worksheet.Range("G19:G23").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:00:00" Then
            If time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E20:E22").Merge()
                worksheet.Range("F20:F22").Merge()
                worksheet.Range("G20:G22").Merge()
                worksheet.Range("E20:E22").Value = subject
                worksheet.Range("F20:F22").Value = section
                worksheet.Range("G20:G22").Value = room
            ElseIf time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E20:E24").Merge()
                worksheet.Range("F20:F24").Merge()
                worksheet.Range("G20:G24").Merge()
                worksheet.Range("E20:E24").Value = subject
                worksheet.Range("F20:F24").Value = section
                worksheet.Range("G20:G24").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:30:00" Then
            If time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E21:E23").Merge()
                worksheet.Range("F21:F23").Merge()
                worksheet.Range("G21:G23").Merge()
                worksheet.Range("E21:E23").Value = subject
                worksheet.Range("F21:F23").Value = section
                worksheet.Range("G21:G23").Value = room
            ElseIf time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E21:E25").Merge()
                worksheet.Range("F21:F25").Merge()
                worksheet.Range("G21:G25").Merge()
                worksheet.Range("E21:E25").Value = subject
                worksheet.Range("F21:F25").Value = section
                worksheet.Range("G21:G25").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:00:00" Then
            If time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E22:E24").Merge()
                worksheet.Range("F22:F24").Merge()
                worksheet.Range("G22:G24").Merge()
                worksheet.Range("E22:E24").Value = subject
                worksheet.Range("F22:F24").Value = section
                worksheet.Range("G22:G24").Value = room
            ElseIf time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E22:E26").Merge()
                worksheet.Range("F22:F26").Merge()
                worksheet.Range("G22:G26").Merge()
                worksheet.Range("E22:E26").Value = subject
                worksheet.Range("F22:F26").Value = section
                worksheet.Range("G22:G26").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:30:00" Then
            If time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E23:E25").Merge()
                worksheet.Range("F23:F25").Merge()
                worksheet.Range("G23:G25").Merge()
                worksheet.Range("E23:E25").Value = subject
                worksheet.Range("F23:F25").Value = section
                worksheet.Range("G23:G25").Value = room
            ElseIf time_end = "2020-02-11 17:30:00" Then
                worksheet.Range("E23:E27").Merge()
                worksheet.Range("F23:F27").Merge()
                worksheet.Range("G23:G27").Merge()
                worksheet.Range("E23:E27").Value = subject
                worksheet.Range("F23:F27").Value = section
                worksheet.Range("G23:G27").Value = room
            End If
        End If
        If time_start = "2020-02-11 16:00:00" Then
            If time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E24:E26").Merge()
                worksheet.Range("F24:F26").Merge()
                worksheet.Range("G24:G26").Merge()
                worksheet.Range("E24:E26").Value = subject
                worksheet.Range("F24:F26").Value = section
                worksheet.Range("G24:G26").Value = room
            ElseIf time_end = "2020-02-11 18:00:00" Then
                worksheet.Range("E24:E28").Merge()
                worksheet.Range("F24:F28").Merge()
                worksheet.Range("G24:G28").Merge()
                worksheet.Range("E24:E28").Value = subject
                worksheet.Range("F24:F28").Value = section
                worksheet.Range("G24:G28").Value = room
            End If
        End If


        ' wednesday


        If time_start = "2020-02-12 06:00:00" Then
            If time_end = "2020-02-12 07:00:00" Then
                worksheet.Range("H4:H6").Merge()
                worksheet.Range("I4:I6").Merge()
                worksheet.Range("J4:J6").Merge()
                worksheet.Range("H4:H6").Value = subject
                worksheet.Range("I4:I6").Value = section
                worksheet.Range("J4:J6").Value = room
            ElseIf time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H4:H8").Merge()
                worksheet.Range("I4:I8").Merge()
                worksheet.Range("J4:J8").Merge()
                worksheet.Range("H4:H8").Value = subject
                worksheet.Range("I4:I8").Value = section
                worksheet.Range("J4:J8").Value = room
            End If
        ElseIf time_start = "2020-02-12 06:30:00" Then

            If time_end = "2020-02-12 07:30:00" Then
                worksheet.Range("H5:H7").Merge()
                worksheet.Range("I5:I7").Merge()
                worksheet.Range("J5:J7").Merge()
                worksheet.Range("H5:H7").Value = subject
                worksheet.Range("I5:I7").Value = section
                worksheet.Range("J5:J7").Value = room
            ElseIf time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H5:H9").Merge()
                worksheet.Range("I5:I9").Merge()
                worksheet.Range("J5:J9").Merge()
                worksheet.Range("H5:H9").Value = subject
                worksheet.Range("I5:I9").Value = section
            End If
            worksheet.Range("J5:J9").Value = room
        ElseIf time_start = "2020-02-12 07:00:00" Then
            If time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H6:H8").Merge()
                worksheet.Range("I6:I8").Merge()
                worksheet.Range("J6:J8").Merge()
                worksheet.Range("H6:H8").Value = subject
                worksheet.Range("I6:I8").Value = section
                worksheet.Range("J6:J8").Value = room
            ElseIf time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H6:H10").Merge()
                worksheet.Range("I6:I10").Merge()
                worksheet.Range("J6:J10").Merge()
                worksheet.Range("H6:H10").Value = subject
                worksheet.Range("I6:I10").Value = section
                worksheet.Range("J6:J10").Value = room
            End If
        ElseIf time_start = "2020-02-12 07:30:00" Then
            If time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H7:H9").Merge()
                worksheet.Range("I7:I9").Merge()
                worksheet.Range("J7:J9").Merge()
                worksheet.Range("H7:H9").Value = subject
                worksheet.Range("I7:I9").Value = section
                worksheet.Range("J7:J9").Value = room
            ElseIf time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H7:H11").Merge()
                worksheet.Range("I7:I11").Merge()
                worksheet.Range("J7:J11").Merge()
                worksheet.Range("H7:H11").Value = subject
                worksheet.Range("I7:I11").Value = section
                worksheet.Range("J7:J11").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:00:00" Then
            If time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H8:H10").Merge()
                worksheet.Range("I8:I10").Merge()
                worksheet.Range("J8:J10").Merge()
                worksheet.Range("H8:H10").Value = subject
                worksheet.Range("I8:I10").Value = section
                worksheet.Range("J8:J10").Value = room
            ElseIf time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H8:H12").Merge()
                worksheet.Range("I8:I12").Merge()
                worksheet.Range("J8:J12").Merge()
                worksheet.Range("H8:H12").Value = subject
                worksheet.Range("I8:I12").Value = section
                worksheet.Range("J8:J12").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:30:00" Then
            If time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H9:H11").Merge()
                worksheet.Range("I9:I11").Merge()
                worksheet.Range("J9:J11").Merge()
                worksheet.Range("H9:H11").Value = subject
                worksheet.Range("I9:I11").Value = section
                worksheet.Range("J9:J11").Value = room
            ElseIf time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H6:H13").Merge()
                worksheet.Range("I9:I13").Merge()
                worksheet.Range("J9:J13").Merge()
                worksheet.Range("H9:H13").Value = subject
                worksheet.Range("I9:I13").Value = section
                worksheet.Range("J9:J13").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:00:00" Then
            If time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H10:H12").Merge()
                worksheet.Range("I10:I12").Merge()
                worksheet.Range("J10:J12").Merge()
                worksheet.Range("H10:H12").Value = subject
                worksheet.Range("I10:I12").Value = section
                worksheet.Range("J10:J12").Value = room
            ElseIf time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H10:H14").Merge()
                worksheet.Range("I10:I14").Merge()
                worksheet.Range("J10:J14").Merge()
                worksheet.Range("H10:H14").Value = subject
                worksheet.Range("I10:I14").Value = section
                worksheet.Range("J10:J14").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:30:00" Then
            If time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H11:H13").Merge()
                worksheet.Range("I11:I13").Merge()
                worksheet.Range("J11:J13").Merge()
                worksheet.Range("H11:H13").Value = subject
                worksheet.Range("I11:I13").Value = section
                worksheet.Range("J11:J13").Value = room
            ElseIf time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H11:H15").Merge()
                worksheet.Range("I11:I15").Merge()
                worksheet.Range("J11:J15").Merge()
                worksheet.Range("H11:H15").Value = subject
                worksheet.Range("I11:I15").Value = section
                worksheet.Range("J11:J15").Value = room
            End If
        ElseIf time_start = "2020-02-12 10:00:00" Then
            If time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H12:H14").Merge()
                worksheet.Range("I12:I14").Merge()
                worksheet.Range("J12:J14").Merge()
                worksheet.Range("H12:H14").Value = subject
                worksheet.Range("I12:I14").Value = section
                worksheet.Range("J12:J14").Value = room

            ElseIf time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H12:H16").Merge()
                worksheet.Range("I12:I16").Merge()
                worksheet.Range("J12:J16").Merge()
                worksheet.Range("H12:H16").Value = subject
                worksheet.Range("I12:I16").Value = section
                worksheet.Range("J12:J16").Value = room

            End If
        End If
        If time_start = "2020-02-12 10:30:00" Then
            If time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H13:H15").Merge()
                worksheet.Range("I13:I15").Merge()
                worksheet.Range("J13:J15").Merge()
                worksheet.Range("H13:H15").Value = subject
                worksheet.Range("I13:I15").Value = section
                worksheet.Range("J13:J15").Value = room
            ElseIf time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H13:H17").Merge()
                worksheet.Range("I13:I17").Merge()
                worksheet.Range("J13:J17").Merge()
                worksheet.Range("H13:H17").Value = subject
                worksheet.Range("I13:I17").Value = section
                worksheet.Range("J13:J17").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:00:00" Then
            If time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H14:H16").Merge()
                worksheet.Range("I14:I16").Merge()
                worksheet.Range("J14:J16").Merge()
                worksheet.Range("H14:H16").Value = subject
                worksheet.Range("I14:I16").Value = section
                worksheet.Range("J14:J16").Value = room
            ElseIf time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H14:H18").Merge()
                worksheet.Range("I14:I18").Merge()
                worksheet.Range("J14:J18").Merge()
                worksheet.Range("H14:H18").Value = subject
                worksheet.Range("I14:I18").Value = section
                worksheet.Range("J14:J18").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:30:00" Then
            If time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H15:H17").Merge()
                worksheet.Range("I15:I17").Merge()
                worksheet.Range("J15:J17").Merge()
                worksheet.Range("H15:H17").Value = subject
                worksheet.Range("I15:I17").Value = section
                worksheet.Range("J15:J17").Value = room
            ElseIf time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H15:H19").Merge()
                worksheet.Range("I15:I19").Merge()
                worksheet.Range("J15:J19").Merge()
                worksheet.Range("H15:H19").Value = subject
                worksheet.Range("I15:I19").Value = section
                worksheet.Range("J15:J19").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:00:00" Then
            If time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H16:H14").Merge()
                worksheet.Range("I16:I18").Merge()
                worksheet.Range("J16:J18").Merge()
                worksheet.Range("H16:H18").Value = subject
                worksheet.Range("I16:I18").Value = section
                worksheet.Range("J16:J18").Value = room
            ElseIf time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H16:H20").Merge()
                worksheet.Range("I16:I20").Merge()
                worksheet.Range("J16:J20").Merge()
                worksheet.Range("H16:H20").Value = subject
                worksheet.Range("I16:I20").Value = section
                worksheet.Range("J16:J20").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:30:00" Then
            If time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H17:H19").Merge()
                worksheet.Range("I17:I19").Merge()
                worksheet.Range("J17:J19").Merge()
                worksheet.Range("H17:H19").Value = subject
                worksheet.Range("I17:I19").Value = section
                worksheet.Range("J17:J19").Value = room
            ElseIf time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H17:H21").Merge()
                worksheet.Range("I17:I21").Merge()
                worksheet.Range("J17:J21").Merge()
                worksheet.Range("H17:H21").Value = subject
                worksheet.Range("I17:I21").Value = section
                worksheet.Range("J17:J21").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:00:00" Then
            If time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H18:H20").Merge()
                worksheet.Range("I18:I20").Merge()
                worksheet.Range("J18:J20").Merge()
                worksheet.Range("H18:H20").Value = subject
                worksheet.Range("I18:I20").Value = section
                worksheet.Range("J18:J20").Value = room
            ElseIf time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H18:H22").Merge()
                worksheet.Range("I18:I22").Merge()
                worksheet.Range("J18:J22").Merge()
                worksheet.Range("H18:H22").Value = subject
                worksheet.Range("I18:I22").Value = section
                worksheet.Range("J18:J22").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:30:00" Then
            If time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H19:H21").Merge()
                worksheet.Range("I19:I21").Merge()
                worksheet.Range("J19:J21").Merge()
                worksheet.Range("H19:H21").Value = subject
                worksheet.Range("I19:I21").Value = section
                worksheet.Range("J19:J21").Value = room
            ElseIf time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H19:H23").Merge()
                worksheet.Range("I19:I23").Merge()
                worksheet.Range("J19:J23").Merge()
                worksheet.Range("H19:H23").Value = subject
                worksheet.Range("I19:I23").Value = section
                worksheet.Range("J19:J23").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:00:00" Then
            If time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H20:H22").Merge()
                worksheet.Range("I20:I22").Merge()
                worksheet.Range("J20:J22").Merge()
                worksheet.Range("H20:H22").Value = subject
                worksheet.Range("I20:I22").Value = section
                worksheet.Range("J20:J22").Value = room
            ElseIf time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H20:H24").Merge()
                worksheet.Range("I20:I24").Merge()
                worksheet.Range("J20:J24").Merge()
                worksheet.Range("H20:H24").Value = subject
                worksheet.Range("I20:I24").Value = section
                worksheet.Range("J20:J24").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:30:00" Then
            If time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H21:H23").Merge()
                worksheet.Range("I21:I23").Merge()
                worksheet.Range("J21:J23").Merge()
                worksheet.Range("H21:H23").Value = subject
                worksheet.Range("I21:I23").Value = section
                worksheet.Range("J21:J23").Value = room
            ElseIf time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H21:H25").Merge()
                worksheet.Range("I21:I25").Merge()
                worksheet.Range("J21:J25").Merge()
                worksheet.Range("H21:H25").Value = subject
                worksheet.Range("I21:I25").Value = section
                worksheet.Range("J21:J25").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:00:00" Then
            If time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H22:H24").Merge()
                worksheet.Range("I22:I24").Merge()
                worksheet.Range("J22:J24").Merge()
                worksheet.Range("H22:H24").Value = subject
                worksheet.Range("I22:I24").Value = section
                worksheet.Range("J22:J24").Value = room
            ElseIf time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H22:H26").Merge()
                worksheet.Range("I22:I26").Merge()
                worksheet.Range("J22:J26").Merge()
                worksheet.Range("H22:H26").Value = subject
                worksheet.Range("I22:I26").Value = section
                worksheet.Range("J22:J26").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:30:00" Then
            If time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H23:H25").Merge()
                worksheet.Range("I23:I25").Merge()
                worksheet.Range("J23:J25").Merge()
                worksheet.Range("H23:H25").Value = subject
                worksheet.Range("I23:I25").Value = section
                worksheet.Range("J23:J25").Value = room
            ElseIf time_end = "2020-02-12 17:30:00" Then
                worksheet.Range("H23:H27").Merge()
                worksheet.Range("I23:I27").Merge()
                worksheet.Range("J23:J27").Merge()
                worksheet.Range("H23:H27").Value = subject
                worksheet.Range("I23:I27").Value = section
                worksheet.Range("J23:J27").Value = room
            End If
        End If
        If time_start = "2020-02-12 16:00:00" Then
            If time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H24:H26").Merge()
                worksheet.Range("I24:I26").Merge()
                worksheet.Range("J24:J26").Merge()
                worksheet.Range("H24:H26").Value = subject
                worksheet.Range("I24:I26").Value = section
                worksheet.Range("J24:J26").Value = room
            ElseIf time_end = "2020-02-12 18:00:00" Then
                worksheet.Range("H24:H28").Merge()
                worksheet.Range("I24:I28").Merge()
                worksheet.Range("J24:J28").Merge()
                worksheet.Range("H24:H28").Value = subject
                worksheet.Range("I24:I28").Value = section
                worksheet.Range("J24:J28").Value = room
            End If
        End If


        'Thursday

        If time_start = "2020-02-13 06:00:00" Then
            If time_end = "2020-02-13 07:00:00" Then
                worksheet.Range("K4:K6").Merge()
                worksheet.Range("L4:L6").Merge()
                worksheet.Range("M4:M6").Merge()
                worksheet.Range("K4:K6").Value = subject
                worksheet.Range("L4:L6").Value = section
                worksheet.Range("M4:M6").Value = room
            ElseIf time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K4:K8").Merge()
                worksheet.Range("L4:L8").Merge()
                worksheet.Range("M4:M8").Merge()
                worksheet.Range("K4:K8").Value = subject
                worksheet.Range("L4:L8").Value = section
                worksheet.Range("M4:M8").Value = room
            End If
        ElseIf time_start = "2020-02-13 06:30:00" Then

            If time_end = "2020-02-13 07:30:00" Then
                worksheet.Range("K5:K7").Merge()
                worksheet.Range("L5:L7").Merge()
                worksheet.Range("M5:M7").Merge()
                worksheet.Range("K5:K7").Value = subject
                worksheet.Range("L5:L7").Value = section
                worksheet.Range("M5:M7").Value = room
            ElseIf time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K5:K9").Merge()
                worksheet.Range("L5:L9").Merge()
                worksheet.Range("M5:M9").Merge()
                worksheet.Range("K5:K9").Value = subject
                worksheet.Range("L5:L9").Value = section
            End If
            worksheet.Range("M5:M9").Value = room
        ElseIf time_start = "2020-02-13 07:00:00" Then
            If time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K6:K8").Merge()
                worksheet.Range("L6:L8").Merge()
                worksheet.Range("M6:M8").Merge()
                worksheet.Range("K6:K8").Value = subject
                worksheet.Range("L6:L8").Value = section
                worksheet.Range("M6:M8").Value = room
            ElseIf time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K6:K10").Merge()
                worksheet.Range("L6:L10").Merge()
                worksheet.Range("M6:M10").Merge()
                worksheet.Range("K6:K10").Value = subject
                worksheet.Range("L6:L10").Value = section
                worksheet.Range("M6:M10").Value = room
            End If
        ElseIf time_start = "2020-02-13 07:30:00" Then
            If time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K7:K9").Merge()
                worksheet.Range("L7:L9").Merge()
                worksheet.Range("M7:M9").Merge()
                worksheet.Range("K7:K9").Value = subject
                worksheet.Range("L7:L9").Value = section
                worksheet.Range("M7:M9").Value = room
            ElseIf time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K7:K11").Merge()
                worksheet.Range("L7:L11").Merge()
                worksheet.Range("M7:M11").Merge()
                worksheet.Range("K7:K11").Value = subject
                worksheet.Range("L7:L11").Value = section
                worksheet.Range("M7:M11").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:00:00" Then
            If time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K8:K10").Merge()
                worksheet.Range("L8:L10").Merge()
                worksheet.Range("M8:M10").Merge()
                worksheet.Range("K8:K10").Value = subject
                worksheet.Range("L8:L10").Value = section
                worksheet.Range("M8:M10").Value = room
            ElseIf time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K8:K12").Merge()
                worksheet.Range("L8:L12").Merge()
                worksheet.Range("M8:M12").Merge()
                worksheet.Range("K8:K12").Value = subject
                worksheet.Range("L8:L12").Value = section
                worksheet.Range("M8:M12").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:30:00" Then
            If time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K9:K11").Merge()
                worksheet.Range("L9:L11").Merge()
                worksheet.Range("M9:M11").Merge()
                worksheet.Range("K9:K11").Value = subject
                worksheet.Range("L9:L11").Value = section
                worksheet.Range("M9:M11").Value = room
            ElseIf time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K6:K13").Merge()
                worksheet.Range("L9:L13").Merge()
                worksheet.Range("M9:M13").Merge()
                worksheet.Range("K9:K13").Value = subject
                worksheet.Range("L9:L13").Value = section
                worksheet.Range("M9:M13").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:00:00" Then
            If time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K10:K12").Merge()
                worksheet.Range("L10:L12").Merge()
                worksheet.Range("M10:M12").Merge()
                worksheet.Range("K10:K12").Value = subject
                worksheet.Range("L10:L12").Value = section
                worksheet.Range("M10:M12").Value = room
            ElseIf time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K10:K14").Merge()
                worksheet.Range("L10:L14").Merge()
                worksheet.Range("M10:M14").Merge()
                worksheet.Range("K10:K14").Value = subject
                worksheet.Range("L10:L14").Value = section
                worksheet.Range("M10:M14").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:30:00" Then
            If time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K11:K13").Merge()
                worksheet.Range("L11:L13").Merge()
                worksheet.Range("M11:M13").Merge()
                worksheet.Range("K11:K13").Value = subject
                worksheet.Range("L11:L13").Value = section
                worksheet.Range("M11:M13").Value = room
            ElseIf time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K11:K15").Merge()
                worksheet.Range("L11:L15").Merge()
                worksheet.Range("M11:M15").Merge()
                worksheet.Range("K11:K15").Value = subject
                worksheet.Range("L11:L15").Value = section
                worksheet.Range("M11:M15").Value = room
            End If
        ElseIf time_start = "2020-02-13 10:00:00" Then
            If time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K12:K14").Merge()
                worksheet.Range("L12:L14").Merge()
                worksheet.Range("M12:M14").Merge()
                worksheet.Range("K12:K14").Value = subject
                worksheet.Range("L12:L14").Value = section
                worksheet.Range("M12:M14").Value = room

            ElseIf time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K12:K16").Merge()
                worksheet.Range("L12:L16").Merge()
                worksheet.Range("M12:M16").Merge()
                worksheet.Range("K12:K16").Value = subject
                worksheet.Range("L12:L16").Value = section
                worksheet.Range("M12:M16").Value = room

            End If
        End If
        If time_start = "2020-02-13 10:30:00" Then
            If time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K13:K15").Merge()
                worksheet.Range("L13:L15").Merge()
                worksheet.Range("M13:M15").Merge()
                worksheet.Range("K13:K15").Value = subject
                worksheet.Range("L13:L15").Value = section
                worksheet.Range("M13:M15").Value = room
            ElseIf time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K13:K17").Merge()
                worksheet.Range("L13:L17").Merge()
                worksheet.Range("M13:M17").Merge()
                worksheet.Range("K13:K17").Value = subject
                worksheet.Range("L13:L17").Value = section
                worksheet.Range("M13:M17").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:00:00" Then
            If time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K14:K16").Merge()
                worksheet.Range("L14:L16").Merge()
                worksheet.Range("M14:M16").Merge()
                worksheet.Range("K14:K16").Value = subject
                worksheet.Range("L14:L16").Value = section
                worksheet.Range("M14:M16").Value = room
            ElseIf time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K14:K18").Merge()
                worksheet.Range("L14:L18").Merge()
                worksheet.Range("M14:M18").Merge()
                worksheet.Range("K14:K18").Value = subject
                worksheet.Range("L14:L18").Value = section
                worksheet.Range("M14:M18").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:30:00" Then
            If time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K15:K17").Merge()
                worksheet.Range("L15:L17").Merge()
                worksheet.Range("M15:M17").Merge()
                worksheet.Range("K15:K17").Value = subject
                worksheet.Range("L15:L17").Value = section
                worksheet.Range("M15:M17").Value = room
            ElseIf time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K15:K19").Merge()
                worksheet.Range("L15:L19").Merge()
                worksheet.Range("M15:M19").Merge()
                worksheet.Range("K15:K19").Value = subject
                worksheet.Range("L15:L19").Value = section
                worksheet.Range("M15:M19").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:00:00" Then
            If time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K16:K14").Merge()
                worksheet.Range("L16:L18").Merge()
                worksheet.Range("M16:M18").Merge()
                worksheet.Range("K16:K18").Value = subject
                worksheet.Range("L16:L18").Value = section
                worksheet.Range("M16:M18").Value = room
            ElseIf time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K16:K20").Merge()
                worksheet.Range("L16:L20").Merge()
                worksheet.Range("M16:M20").Merge()
                worksheet.Range("K16:K20").Value = subject
                worksheet.Range("L16:L20").Value = section
                worksheet.Range("M16:M20").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:30:00" Then
            If time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K17:K19").Merge()
                worksheet.Range("L17:L19").Merge()
                worksheet.Range("M17:M19").Merge()
                worksheet.Range("K17:K19").Value = subject
                worksheet.Range("L17:L19").Value = section
                worksheet.Range("M17:M19").Value = room
            ElseIf time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K17:K21").Merge()
                worksheet.Range("L17:L21").Merge()
                worksheet.Range("M17:M21").Merge()
                worksheet.Range("K17:K21").Value = subject
                worksheet.Range("L17:L21").Value = section
                worksheet.Range("M17:M21").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:00:00" Then
            If time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K18:K20").Merge()
                worksheet.Range("L18:L20").Merge()
                worksheet.Range("M18:M20").Merge()
                worksheet.Range("K18:K20").Value = subject
                worksheet.Range("L18:L20").Value = section
                worksheet.Range("M18:M20").Value = room
            ElseIf time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K18:K22").Merge()
                worksheet.Range("L18:L22").Merge()
                worksheet.Range("M18:M22").Merge()
                worksheet.Range("K18:K22").Value = subject
                worksheet.Range("L18:L22").Value = section
                worksheet.Range("M18:M22").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:30:00" Then
            If time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K19:K21").Merge()
                worksheet.Range("L19:L21").Merge()
                worksheet.Range("M19:M21").Merge()
                worksheet.Range("K19:K21").Value = subject
                worksheet.Range("L19:L21").Value = section
                worksheet.Range("M19:M21").Value = room
            ElseIf time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K19:K23").Merge()
                worksheet.Range("L19:L23").Merge()
                worksheet.Range("M19:M23").Merge()
                worksheet.Range("K19:K23").Value = subject
                worksheet.Range("L19:L23").Value = section
                worksheet.Range("M19:M23").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:00:00" Then
            If time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K20:K22").Merge()
                worksheet.Range("L20:L22").Merge()
                worksheet.Range("M20:M22").Merge()
                worksheet.Range("K20:K22").Value = subject
                worksheet.Range("L20:L22").Value = section
                worksheet.Range("M20:M22").Value = room
            ElseIf time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K20:K24").Merge()
                worksheet.Range("L20:L24").Merge()
                worksheet.Range("M20:M24").Merge()
                worksheet.Range("K20:K24").Value = subject
                worksheet.Range("L20:L24").Value = section
                worksheet.Range("M20:M24").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:30:00" Then
            If time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K21:K23").Merge()
                worksheet.Range("L21:L23").Merge()
                worksheet.Range("M21:M23").Merge()
                worksheet.Range("K21:K23").Value = subject
                worksheet.Range("L21:L23").Value = section
                worksheet.Range("M21:M23").Value = room
            ElseIf time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K21:K25").Merge()
                worksheet.Range("L21:L25").Merge()
                worksheet.Range("M21:M25").Merge()
                worksheet.Range("K21:K25").Value = subject
                worksheet.Range("L21:L25").Value = section
                worksheet.Range("M21:M25").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:00:00" Then
            If time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K22:K24").Merge()
                worksheet.Range("L22:L24").Merge()
                worksheet.Range("M22:M24").Merge()
                worksheet.Range("K22:K24").Value = subject
                worksheet.Range("L22:L24").Value = section
                worksheet.Range("M22:M24").Value = room
            ElseIf time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K22:K26").Merge()
                worksheet.Range("L22:L26").Merge()
                worksheet.Range("M22:M26").Merge()
                worksheet.Range("K22:K26").Value = subject
                worksheet.Range("L22:L26").Value = section
                worksheet.Range("M22:M26").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:30:00" Then
            If time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K23:K25").Merge()
                worksheet.Range("L23:L25").Merge()
                worksheet.Range("M23:M25").Merge()
                worksheet.Range("K23:K25").Value = subject
                worksheet.Range("L23:L25").Value = section
                worksheet.Range("M23:M25").Value = room
            ElseIf time_end = "2020-02-13 17:30:00" Then
                worksheet.Range("K23:K27").Merge()
                worksheet.Range("L23:L27").Merge()
                worksheet.Range("M23:M27").Merge()
                worksheet.Range("K23:K27").Value = subject
                worksheet.Range("L23:L27").Value = section
                worksheet.Range("M23:M27").Value = room
            End If
        End If
        If time_start = "2020-02-13 16:00:00" Then
            If time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K24:K26").Merge()
                worksheet.Range("L24:L26").Merge()
                worksheet.Range("M24:M26").Merge()
                worksheet.Range("K24:K26").Value = subject
                worksheet.Range("L24:L26").Value = section
                worksheet.Range("M24:M26").Value = room
            ElseIf time_end = "2020-02-13 18:00:00" Then
                worksheet.Range("K24:K28").Merge()
                worksheet.Range("L24:L28").Merge()
                worksheet.Range("M24:M28").Merge()
                worksheet.Range("K24:K28").Value = subject
                worksheet.Range("L24:L28").Value = section
                worksheet.Range("M24:M28").Value = room
            End If
        End If

        'Fridayyyy========
        If time_start = "2020-02-14 06:00:00" Then
            If time_end = "2020-02-14 07:00:00" Then
                worksheet.Range("N4:N6").Merge()
                worksheet.Range("O4:O6").Merge()
                worksheet.Range("P4:P6").Merge()
                worksheet.Range("N4:N6").Value = subject
                worksheet.Range("O4:O6").Value = section
                worksheet.Range("P4:P6").Value = room
            ElseIf time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N4:N8").Merge()
                worksheet.Range("O4:O8").Merge()
                worksheet.Range("P4:P8").Merge()
                worksheet.Range("N4:N8").Value = subject
                worksheet.Range("O4:O8").Value = section
                worksheet.Range("P4:P8").Value = room
            End If
        ElseIf time_start = "2020-02-14 06:30:00" Then

            If time_end = "2020-02-14 07:30:00" Then
                worksheet.Range("N5:N7").Merge()
                worksheet.Range("O5:O7").Merge()
                worksheet.Range("P5:P7").Merge()
                worksheet.Range("N5:N7").Value = subject
                worksheet.Range("O5:O7").Value = section
                worksheet.Range("P5:P7").Value = room
            ElseIf time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N5:N9").Merge()
                worksheet.Range("O5:O9").Merge()
                worksheet.Range("P5:P9").Merge()
                worksheet.Range("N5:N9").Value = subject
                worksheet.Range("O5:O9").Value = section
            End If
            worksheet.Range("P5:P9").Value = room
        ElseIf time_start = "2020-02-14 07:00:00" Then
            If time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N6:N8").Merge()
                worksheet.Range("O6:O8").Merge()
                worksheet.Range("P6:P8").Merge()
                worksheet.Range("N6:N8").Value = subject
                worksheet.Range("O6:O8").Value = section
                worksheet.Range("P6:P8").Value = room
            ElseIf time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N6:N10").Merge()
                worksheet.Range("O6:O10").Merge()
                worksheet.Range("P6:P10").Merge()
                worksheet.Range("N6:N10").Value = subject
                worksheet.Range("O6:O10").Value = section
                worksheet.Range("P6:P10").Value = room
            End If
        ElseIf time_start = "2020-02-14 07:30:00" Then
            If time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N7:N9").Merge()
                worksheet.Range("O7:O9").Merge()
                worksheet.Range("P7:P9").Merge()
                worksheet.Range("N7:N9").Value = subject
                worksheet.Range("O7:O9").Value = section
                worksheet.Range("P7:P9").Value = room
            ElseIf time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N7:N11").Merge()
                worksheet.Range("O7:O11").Merge()
                worksheet.Range("P7:P11").Merge()
                worksheet.Range("N7:N11").Value = subject
                worksheet.Range("O7:O11").Value = section
                worksheet.Range("P7:P11").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:00:00" Then
            If time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N8:N10").Merge()
                worksheet.Range("O8:O10").Merge()
                worksheet.Range("P8:P10").Merge()
                worksheet.Range("N8:N10").Value = subject
                worksheet.Range("O8:O10").Value = section
                worksheet.Range("P8:P10").Value = room
            ElseIf time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N8:N12").Merge()
                worksheet.Range("O8:O12").Merge()
                worksheet.Range("P8:P12").Merge()
                worksheet.Range("N8:N12").Value = subject
                worksheet.Range("O8:O12").Value = section
                worksheet.Range("P8:P12").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:30:00" Then
            If time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N9:N11").Merge()
                worksheet.Range("O9:O11").Merge()
                worksheet.Range("P9:P11").Merge()
                worksheet.Range("N9:N11").Value = subject
                worksheet.Range("O9:O11").Value = section
                worksheet.Range("P9:P11").Value = room
            ElseIf time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N6:N13").Merge()
                worksheet.Range("O9:O13").Merge()
                worksheet.Range("P9:P13").Merge()
                worksheet.Range("N9:N13").Value = subject
                worksheet.Range("O9:O13").Value = section
                worksheet.Range("P9:P13").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:00:00" Then
            If time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N10:N12").Merge()
                worksheet.Range("O10:O12").Merge()
                worksheet.Range("P10:P12").Merge()
                worksheet.Range("N10:N12").Value = subject
                worksheet.Range("O10:O12").Value = section
                worksheet.Range("P10:P12").Value = room
            ElseIf time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N10:N14").Merge()
                worksheet.Range("O10:O14").Merge()
                worksheet.Range("P10:P14").Merge()
                worksheet.Range("N10:N14").Value = subject
                worksheet.Range("O10:O14").Value = section
                worksheet.Range("P10:P14").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:30:00" Then
            If time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N11:N13").Merge()
                worksheet.Range("O11:O13").Merge()
                worksheet.Range("P11:P13").Merge()
                worksheet.Range("N11:N13").Value = subject
                worksheet.Range("O11:O13").Value = section
                worksheet.Range("P11:P13").Value = room
            ElseIf time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N11:N15").Merge()
                worksheet.Range("O11:O15").Merge()
                worksheet.Range("P11:P15").Merge()
                worksheet.Range("N11:N15").Value = subject
                worksheet.Range("O11:O15").Value = section
                worksheet.Range("P11:P15").Value = room
            End If
        ElseIf time_start = "2020-02-14 10:00:00" Then
            If time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N12:N14").Merge()
                worksheet.Range("O12:O14").Merge()
                worksheet.Range("P12:P14").Merge()
                worksheet.Range("N12:N14").Value = subject
                worksheet.Range("O12:O14").Value = section
                worksheet.Range("P12:P14").Value = room

            ElseIf time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N12:N16").Merge()
                worksheet.Range("O12:O16").Merge()
                worksheet.Range("P12:P16").Merge()
                worksheet.Range("N12:N16").Value = subject
                worksheet.Range("O12:O16").Value = section
                worksheet.Range("P12:P16").Value = room

            End If
        End If
        If time_start = "2020-02-14 10:30:00" Then
            If time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N13:N15").Merge()
                worksheet.Range("O13:O15").Merge()
                worksheet.Range("P13:P15").Merge()
                worksheet.Range("N13:N15").Value = subject
                worksheet.Range("O13:O15").Value = section
                worksheet.Range("P13:P15").Value = room
            ElseIf time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N13:N17").Merge()
                worksheet.Range("O13:O17").Merge()
                worksheet.Range("P13:P17").Merge()
                worksheet.Range("N13:N17").Value = subject
                worksheet.Range("O13:O17").Value = section
                worksheet.Range("P13:P17").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:00:00" Then
            If time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N14:N16").Merge()
                worksheet.Range("O14:O16").Merge()
                worksheet.Range("P14:P16").Merge()
                worksheet.Range("N14:N16").Value = subject
                worksheet.Range("O14:O16").Value = section
                worksheet.Range("P14:P16").Value = room
            ElseIf time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N14:N18").Merge()
                worksheet.Range("O14:O18").Merge()
                worksheet.Range("P14:P18").Merge()
                worksheet.Range("N14:N18").Value = subject
                worksheet.Range("O14:O18").Value = section
                worksheet.Range("P14:P18").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:30:00" Then
            If time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N15:N17").Merge()
                worksheet.Range("O15:O17").Merge()
                worksheet.Range("P15:P17").Merge()
                worksheet.Range("N15:N17").Value = subject
                worksheet.Range("O15:O17").Value = section
                worksheet.Range("P15:P17").Value = room
            ElseIf time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N15:N19").Merge()
                worksheet.Range("O15:O19").Merge()
                worksheet.Range("P15:P19").Merge()
                worksheet.Range("N15:N19").Value = subject
                worksheet.Range("O15:O19").Value = section
                worksheet.Range("P15:P19").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:00:00" Then
            If time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N16:N14").Merge()
                worksheet.Range("O16:O18").Merge()
                worksheet.Range("P16:P18").Merge()
                worksheet.Range("N16:N18").Value = subject
                worksheet.Range("O16:O18").Value = section
                worksheet.Range("P16:P18").Value = room
            ElseIf time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N16:N20").Merge()
                worksheet.Range("O16:O20").Merge()
                worksheet.Range("P16:P20").Merge()
                worksheet.Range("N16:N20").Value = subject
                worksheet.Range("O16:O20").Value = section
                worksheet.Range("P16:P20").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:30:00" Then
            If time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N17:N19").Merge()
                worksheet.Range("O17:O19").Merge()
                worksheet.Range("P17:P19").Merge()
                worksheet.Range("N17:N19").Value = subject
                worksheet.Range("O17:O19").Value = section
                worksheet.Range("P17:P19").Value = room
            ElseIf time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N17:N21").Merge()
                worksheet.Range("O17:O21").Merge()
                worksheet.Range("P17:P21").Merge()
                worksheet.Range("N17:N21").Value = subject
                worksheet.Range("O17:O21").Value = section
                worksheet.Range("P17:P21").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:00:00" Then
            If time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N18:N20").Merge()
                worksheet.Range("O18:O20").Merge()
                worksheet.Range("P18:P20").Merge()
                worksheet.Range("N18:N20").Value = subject
                worksheet.Range("O18:O20").Value = section
                worksheet.Range("P18:P20").Value = room
            ElseIf time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N18:N22").Merge()
                worksheet.Range("O18:O22").Merge()
                worksheet.Range("P18:P22").Merge()
                worksheet.Range("N18:N22").Value = subject
                worksheet.Range("O18:O22").Value = section
                worksheet.Range("P18:P22").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:30:00" Then
            If time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N19:N21").Merge()
                worksheet.Range("O19:O21").Merge()
                worksheet.Range("P19:P21").Merge()
                worksheet.Range("N19:N21").Value = subject
                worksheet.Range("O19:O21").Value = section
                worksheet.Range("P19:P21").Value = room
            ElseIf time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N19:N23").Merge()
                worksheet.Range("O19:O23").Merge()
                worksheet.Range("P19:P23").Merge()
                worksheet.Range("N19:N23").Value = subject
                worksheet.Range("O19:O23").Value = section
                worksheet.Range("P19:P23").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:00:00" Then
            If time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N20:N22").Merge()
                worksheet.Range("O20:O22").Merge()
                worksheet.Range("P20:P22").Merge()
                worksheet.Range("N20:N22").Value = subject
                worksheet.Range("O20:O22").Value = section
                worksheet.Range("P20:P22").Value = room
            ElseIf time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N20:N24").Merge()
                worksheet.Range("O20:O24").Merge()
                worksheet.Range("P20:P24").Merge()
                worksheet.Range("N20:N24").Value = subject
                worksheet.Range("O20:O24").Value = section
                worksheet.Range("P20:P24").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:30:00" Then
            If time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N21:N23").Merge()
                worksheet.Range("O21:O23").Merge()
                worksheet.Range("P21:P23").Merge()
                worksheet.Range("N21:N23").Value = subject
                worksheet.Range("O21:O23").Value = section
                worksheet.Range("P21:P23").Value = room
            ElseIf time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N21:N25").Merge()
                worksheet.Range("O21:O25").Merge()
                worksheet.Range("P21:P25").Merge()
                worksheet.Range("N21:N25").Value = subject
                worksheet.Range("O21:O25").Value = section
                worksheet.Range("P21:P25").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:00:00" Then
            If time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N22:N24").Merge()
                worksheet.Range("O22:O24").Merge()
                worksheet.Range("P22:P24").Merge()
                worksheet.Range("N22:N24").Value = subject
                worksheet.Range("O22:O24").Value = section
                worksheet.Range("P22:P24").Value = room
            ElseIf time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N22:N26").Merge()
                worksheet.Range("O22:O26").Merge()
                worksheet.Range("P22:P26").Merge()
                worksheet.Range("N22:N26").Value = subject
                worksheet.Range("O22:O26").Value = section
                worksheet.Range("P22:P26").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:30:00" Then
            If time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N23:N25").Merge()
                worksheet.Range("O23:O25").Merge()
                worksheet.Range("P23:P25").Merge()
                worksheet.Range("N23:N25").Value = subject
                worksheet.Range("O23:O25").Value = section
                worksheet.Range("P23:P25").Value = room
            ElseIf time_end = "2020-02-14 17:30:00" Then
                worksheet.Range("N23:N27").Merge()
                worksheet.Range("O23:O27").Merge()
                worksheet.Range("P23:P27").Merge()
                worksheet.Range("N23:N27").Value = subject
                worksheet.Range("O23:O27").Value = section
                worksheet.Range("P23:P27").Value = room
            End If
        End If
        If time_start = "2020-02-14 16:00:00" Then
            If time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N24:N26").Merge()
                worksheet.Range("O24:O26").Merge()
                worksheet.Range("P24:P26").Merge()
                worksheet.Range("N24:N26").Value = subject
                worksheet.Range("O24:O26").Value = section
                worksheet.Range("P24:P26").Value = room
            ElseIf time_end = "2020-02-14 18:00:00" Then
                worksheet.Range("N24:N28").Merge()
                worksheet.Range("O24:O28").Merge()
                worksheet.Range("P24:P28").Merge()
                worksheet.Range("N24:N28").Value = subject
                worksheet.Range("O24:O28").Value = section
                worksheet.Range("P24:P28").Value = room
            End If
        End If
    End Sub

    'Row4
    Private Sub CheckDateToInsertRow4()
        Dim id As String = choose_expo.SelectedValue
        Dim s As String = "select prof_details_tbl.`FName_prof`, 
    prof_details_tbl.`MName_prof`, 
    prof_details_tbl.`LName_prof`,
    subjects_tbl.subject_Name, 
    `schedule_tbl`.strandName, 
    `schedule_tbl`.grade_lvl, 
    `schedule_tbl`.section_no, `schedule_tbl`.building_no, 
    `schedule_tbl`.room_no,
schedule_tbl.time_start, 
schedule_tbl.time_end from prof_details_tbl ,schedule_tbl inner join subjects_tbl on schedule_tbl.subject = subjects_tbl.snn
    where prof_details_tbl.ID_Prof='" + id + "' and `schedule_tbl`.`id_Prof`='" + id + "' and sy='" + print_sy.Text + "' and semestral_sche='" + print_sem.Text + "'"
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row4 As DataRow = tb.Rows(3)
        Dim subject As String = row4(3)
        Dim section As String = row4(4) + " " + row4(5) + "-" + row4(6)
        Dim room As String = row4(7) + " " + row4(8)
        time_start = row4(9)
        time_end = row4(10)
        'Monday start
        If time_start = "2020-02-10 06:00:00" Then
            If time_end = "2020-02-10 07:00:00" Then
                worksheet.Range("B4:B6").Merge()
                worksheet.Range("C4:C6").Merge()
                worksheet.Range("D4:D6").Merge()
                worksheet.Range("B4:B6").Value = subject
                worksheet.Range("C4:C6").Value = section
                worksheet.Range("D4:D6").Value = room
            ElseIf time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B4:B8").Merge()
                worksheet.Range("C4:C8").Merge()
                worksheet.Range("D4:D8").Merge()
                worksheet.Range("B4:B8").Value = subject
                worksheet.Range("C4:C8").Value = section
                worksheet.Range("D4:D8").Value = room
            End If
        ElseIf time_start = "2020-02-10 06:30:00" Then

            If time_end = "2020-02-10 07:30:00" Then
                worksheet.Range("B5:B7").Merge()
                worksheet.Range("C5:C7").Merge()
                worksheet.Range("D5:D7").Merge()
                worksheet.Range("B5:B7").Value = subject
                worksheet.Range("C5:C7").Value = section
                worksheet.Range("D5:D7").Value = room
            ElseIf time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B5:B9").Merge()
                worksheet.Range("C5:C9").Merge()
                worksheet.Range("D5:D9").Merge()
                worksheet.Range("B5:B9").Value = subject
                worksheet.Range("C5:C9").Value = section
            End If
            worksheet.Range("D5:D9").Value = room
        ElseIf time_start = "2020-02-10 07:00:00" Then
            If time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B6:B8").Merge()
                worksheet.Range("C6:C8").Merge()
                worksheet.Range("D6:D8").Merge()
                worksheet.Range("B6:B8").Value = subject
                worksheet.Range("C6:C8").Value = section
                worksheet.Range("D6:D8").Value = room
            ElseIf time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B6:B10").Merge()
                worksheet.Range("C6:C10").Merge()
                worksheet.Range("D6:D10").Merge()
                worksheet.Range("B6:B10").Value = subject
                worksheet.Range("C6:C10").Value = section
                worksheet.Range("D6:D10").Value = room
            End If
        ElseIf time_start = "2020-02-10 07:30:00" Then
            If time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B7:B9").Merge()
                worksheet.Range("C7:C9").Merge()
                worksheet.Range("D7:D9").Merge()
                worksheet.Range("B7:B9").Value = subject
                worksheet.Range("C7:C9").Value = section
                worksheet.Range("D7:D9").Value = room
            ElseIf time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B7:B11").Merge()
                worksheet.Range("C7:C11").Merge()
                worksheet.Range("D7:D11").Merge()
                worksheet.Range("B7:B11").Value = subject
                worksheet.Range("C7:C11").Value = section
                worksheet.Range("D7:D11").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:00:00" Then
            If time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B8:B10").Merge()
                worksheet.Range("C8:C10").Merge()
                worksheet.Range("D8:D10").Merge()
                worksheet.Range("B8:B10").Value = subject
                worksheet.Range("C8:C10").Value = section
                worksheet.Range("D8:D10").Value = room
            ElseIf time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B8:B12").Merge()
                worksheet.Range("C8:C12").Merge()
                worksheet.Range("D8:D12").Merge()
                worksheet.Range("B8:B12").Value = subject
                worksheet.Range("C8:C12").Value = section
                worksheet.Range("D8:D12").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:30:00" Then
            If time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B9:B11").Merge()
                worksheet.Range("C9:C11").Merge()
                worksheet.Range("D9:D11").Merge()
                worksheet.Range("B9:B11").Value = subject
                worksheet.Range("C9:C11").Value = section
                worksheet.Range("D9:D11").Value = room
            ElseIf time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B6:B13").Merge()
                worksheet.Range("C9:C13").Merge()
                worksheet.Range("D9:D13").Merge()
                worksheet.Range("B9:B13").Value = subject
                worksheet.Range("C9:C13").Value = section
                worksheet.Range("D9:D13").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:00:00" Then
            If time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B10:B12").Merge()
                worksheet.Range("C10:C12").Merge()
                worksheet.Range("D10:D12").Merge()
                worksheet.Range("B10:B12").Value = subject
                worksheet.Range("C10:C12").Value = section
                worksheet.Range("D10:D12").Value = room
            ElseIf time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B10:B14").Merge()
                worksheet.Range("C10:C14").Merge()
                worksheet.Range("D10:D14").Merge()
                worksheet.Range("B10:B14").Value = subject
                worksheet.Range("C10:C14").Value = section
                worksheet.Range("D10:D14").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:30:00" Then
            If time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B11:B13").Merge()
                worksheet.Range("C11:C13").Merge()
                worksheet.Range("D11:D13").Merge()
                worksheet.Range("B11:B13").Value = subject
                worksheet.Range("C11:C13").Value = section
                worksheet.Range("D11:D13").Value = room
            ElseIf time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B11:B15").Merge()
                worksheet.Range("C11:C15").Merge()
                worksheet.Range("D11:D15").Merge()
                worksheet.Range("B11:B15").Value = subject
                worksheet.Range("C11:C15").Value = section
                worksheet.Range("D11:D15").Value = room
            End If
        ElseIf time_start = "2020-02-10 10:00:00" Then
            If time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B12:B14").Merge()
                worksheet.Range("C12:C14").Merge()
                worksheet.Range("D12:D14").Merge()
                worksheet.Range("B12:B14").Value = subject
                worksheet.Range("C12:C14").Value = section
                worksheet.Range("D12:D14").Value = room

            ElseIf time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B12:B16").Merge()
                worksheet.Range("C12:C16").Merge()
                worksheet.Range("D12:D16").Merge()
                worksheet.Range("B12:B16").Value = subject
                worksheet.Range("C12:C16").Value = section
                worksheet.Range("D12:D16").Value = room

            End If
        End If
        If time_start = "2020-02-10 10:30:00" Then
            If time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B13:B15").Merge()
                worksheet.Range("C13:C15").Merge()
                worksheet.Range("D13:D15").Merge()
                worksheet.Range("B13:B15").Value = subject
                worksheet.Range("C13:C15").Value = section
                worksheet.Range("D13:D15").Value = room
            ElseIf time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B13:B17").Merge()
                worksheet.Range("C13:C17").Merge()
                worksheet.Range("D13:D17").Merge()
                worksheet.Range("B13:B17").Value = subject
                worksheet.Range("C13:C17").Value = section
                worksheet.Range("D13:D17").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:00:00" Then
            If time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B14:B16").Merge()
                worksheet.Range("C14:C16").Merge()
                worksheet.Range("D14:D16").Merge()
                worksheet.Range("B14:B16").Value = subject
                worksheet.Range("C14:C16").Value = section
                worksheet.Range("D14:D16").Value = room
            ElseIf time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B14:B18").Merge()
                worksheet.Range("C14:C18").Merge()
                worksheet.Range("D14:D18").Merge()
                worksheet.Range("B14:B18").Value = subject
                worksheet.Range("C14:C18").Value = section
                worksheet.Range("D14:D18").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:30:00" Then
            If time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B15:B17").Merge()
                worksheet.Range("C15:C17").Merge()
                worksheet.Range("D15:D17").Merge()
                worksheet.Range("B15:B17").Value = subject
                worksheet.Range("C15:C17").Value = section
                worksheet.Range("D15:D17").Value = room
            ElseIf time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B15:B19").Merge()
                worksheet.Range("C15:C19").Merge()
                worksheet.Range("D15:D19").Merge()
                worksheet.Range("B15:B19").Value = subject
                worksheet.Range("C15:C19").Value = section
                worksheet.Range("D15:D19").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:00:00" Then
            If time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B16:B14").Merge()
                worksheet.Range("C16:C18").Merge()
                worksheet.Range("D16:D18").Merge()
                worksheet.Range("B16:B18").Value = subject
                worksheet.Range("C16:C18").Value = section
                worksheet.Range("D16:D18").Value = room
            ElseIf time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B16:B20").Merge()
                worksheet.Range("C16:C20").Merge()
                worksheet.Range("D16:D20").Merge()
                worksheet.Range("B16:B20").Value = subject
                worksheet.Range("C16:C20").Value = section
                worksheet.Range("D16:D20").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:30:00" Then
            If time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B17:B19").Merge()
                worksheet.Range("C17:C19").Merge()
                worksheet.Range("D17:D19").Merge()
                worksheet.Range("B17:B19").Value = subject
                worksheet.Range("C17:C19").Value = section
                worksheet.Range("D17:D19").Value = room
            ElseIf time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B17:B21").Merge()
                worksheet.Range("C17:C21").Merge()
                worksheet.Range("D17:D21").Merge()
                worksheet.Range("B17:B21").Value = subject
                worksheet.Range("C17:C21").Value = section
                worksheet.Range("D17:D21").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:00:00" Then
            If time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B18:B20").Merge()
                worksheet.Range("C18:C20").Merge()
                worksheet.Range("D18:D20").Merge()
                worksheet.Range("B18:B20").Value = subject
                worksheet.Range("C18:C20").Value = section
                worksheet.Range("D18:D20").Value = room
            ElseIf time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B18:B22").Merge()
                worksheet.Range("C18:C22").Merge()
                worksheet.Range("D18:D22").Merge()
                worksheet.Range("B18:B22").Value = subject
                worksheet.Range("C18:C22").Value = section
                worksheet.Range("D18:D22").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:30:00" Then
            If time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B19:B21").Merge()
                worksheet.Range("C19:C21").Merge()
                worksheet.Range("D19:D21").Merge()
                worksheet.Range("B19:B21").Value = subject
                worksheet.Range("C19:C21").Value = section
                worksheet.Range("D19:D21").Value = room
            ElseIf time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B19:B23").Merge()
                worksheet.Range("C19:C23").Merge()
                worksheet.Range("D19:D23").Merge()
                worksheet.Range("B19:B23").Value = subject
                worksheet.Range("C19:C23").Value = section
                worksheet.Range("D19:D23").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:00:00" Then
            If time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B20:B22").Merge()
                worksheet.Range("C20:C22").Merge()
                worksheet.Range("D20:D22").Merge()
                worksheet.Range("B20:B22").Value = subject
                worksheet.Range("C20:C22").Value = section
                worksheet.Range("D20:D22").Value = room
            ElseIf time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B20:B24").Merge()
                worksheet.Range("C20:C24").Merge()
                worksheet.Range("D20:D24").Merge()
                worksheet.Range("B20:B24").Value = subject
                worksheet.Range("C20:C24").Value = section
                worksheet.Range("D20:D24").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:30:00" Then
            If time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B21:B23").Merge()
                worksheet.Range("C21:C23").Merge()
                worksheet.Range("D21:D23").Merge()
                worksheet.Range("B21:B23").Value = subject
                worksheet.Range("C21:C23").Value = section
                worksheet.Range("D21:D23").Value = room
            ElseIf time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B21:B25").Merge()
                worksheet.Range("C21:C25").Merge()
                worksheet.Range("D21:D25").Merge()
                worksheet.Range("B21:B25").Value = subject
                worksheet.Range("C21:C25").Value = section
                worksheet.Range("D21:D25").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:00:00" Then
            If time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B22:B24").Merge()
                worksheet.Range("C22:C24").Merge()
                worksheet.Range("D22:D24").Merge()
                worksheet.Range("B22:B24").Value = subject
                worksheet.Range("C22:C24").Value = section
                worksheet.Range("D22:D24").Value = room
            ElseIf time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B22:B26").Merge()
                worksheet.Range("C22:C26").Merge()
                worksheet.Range("D22:D26").Merge()
                worksheet.Range("B22:B26").Value = subject
                worksheet.Range("C22:C26").Value = section
                worksheet.Range("D22:D26").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:30:00" Then
            If time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B23:B25").Merge()
                worksheet.Range("C23:C25").Merge()
                worksheet.Range("D23:D25").Merge()
                worksheet.Range("B23:B25").Value = subject
                worksheet.Range("C23:C25").Value = section
                worksheet.Range("D23:D25").Value = room
            ElseIf time_end = "2020-02-10 17:30:00" Then
                worksheet.Range("B23:B27").Merge()
                worksheet.Range("C23:C27").Merge()
                worksheet.Range("D23:D27").Merge()
                worksheet.Range("B23:B27").Value = subject
                worksheet.Range("C23:C27").Value = section
                worksheet.Range("D23:D27").Value = room
            End If
        End If
        If time_start = "2020-02-10 16:00:00" Then
            If time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B24:B26").Merge()
                worksheet.Range("C24:C26").Merge()
                worksheet.Range("D24:D26").Merge()
                worksheet.Range("B24:B26").Value = subject
                worksheet.Range("C24:C26").Value = section
                worksheet.Range("D24:D26").Value = room
            ElseIf time_end = "2020-02-10 18:00:00" Then
                worksheet.Range("B24:B28").Merge()
                worksheet.Range("C24:C28").Merge()
                worksheet.Range("D24:D28").Merge()
                worksheet.Range("B24:B28").Value = subject
                worksheet.Range("C24:C28").Value = section
                worksheet.Range("D24:D28").Value = room
            End If
        End If



        'tuesday start-----------------------------------------------


        If time_start = "2020-02-11 06:00:00" Then
            If time_end = "2020-02-11 07:00:00" Then
                worksheet.Range("E4:E6").Merge()
                worksheet.Range("F4:F6").Merge()
                worksheet.Range("G4:G6").Merge()
                worksheet.Range("E4:E6").Value = subject
                worksheet.Range("F4:F6").Value = section
                worksheet.Range("G4:G6").Value = room
            ElseIf time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E4:E8").Merge()
                worksheet.Range("F4:F8").Merge()
                worksheet.Range("G4:G8").Merge()
                worksheet.Range("E4:E8").Value = subject
                worksheet.Range("F4:F8").Value = section
                worksheet.Range("G4:G8").Value = room
            End If
        ElseIf time_start = "2020-02-11 06:30:00" Then

            If time_end = "2020-02-11 07:30:00" Then
                worksheet.Range("E5:E7").Merge()
                worksheet.Range("F5:F7").Merge()
                worksheet.Range("G5:G7").Merge()
                worksheet.Range("E5:E7").Value = subject
                worksheet.Range("F5:F7").Value = section
                worksheet.Range("G5:G7").Value = room
            ElseIf time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E5:E9").Merge()
                worksheet.Range("F5:F9").Merge()
                worksheet.Range("G5:G9").Merge()
                worksheet.Range("E5:E9").Value = subject
                worksheet.Range("F5:F9").Value = section
            End If
            worksheet.Range("G5:G9").Value = room
        ElseIf time_start = "2020-02-11 07:00:00" Then
            If time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E6:E8").Merge()
                worksheet.Range("F6:F8").Merge()
                worksheet.Range("G6:G8").Merge()
                worksheet.Range("E6:E8").Value = subject
                worksheet.Range("F6:F8").Value = section
                worksheet.Range("G6:G8").Value = room
            ElseIf time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E6:E10").Merge()
                worksheet.Range("F6:F10").Merge()
                worksheet.Range("G6:G10").Merge()
                worksheet.Range("E6:E10").Value = subject
                worksheet.Range("F6:F10").Value = section
                worksheet.Range("G6:G10").Value = room
            End If
        ElseIf time_start = "2020-02-11 07:30:00" Then
            If time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E7:E9").Merge()
                worksheet.Range("F7:F9").Merge()
                worksheet.Range("G7:G9").Merge()
                worksheet.Range("E7:E9").Value = subject
                worksheet.Range("F7:F9").Value = section
                worksheet.Range("G7:G9").Value = room
            ElseIf time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E7:E11").Merge()
                worksheet.Range("F7:F11").Merge()
                worksheet.Range("G7:G11").Merge()
                worksheet.Range("E7:E11").Value = subject
                worksheet.Range("F7:F11").Value = section
                worksheet.Range("G7:G11").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:00:00" Then
            If time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E8:E10").Merge()
                worksheet.Range("F8:F10").Merge()
                worksheet.Range("G8:G10").Merge()
                worksheet.Range("E8:E10").Value = subject
                worksheet.Range("F8:F10").Value = section
                worksheet.Range("G8:G10").Value = room
            ElseIf time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E8:E12").Merge()
                worksheet.Range("F8:F12").Merge()
                worksheet.Range("G8:G12").Merge()
                worksheet.Range("E8:E12").Value = subject
                worksheet.Range("F8:F12").Value = section
                worksheet.Range("G8:G12").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:30:00" Then
            If time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E9:E11").Merge()
                worksheet.Range("F9:F11").Merge()
                worksheet.Range("G9:G11").Merge()
                worksheet.Range("E9:E11").Value = subject
                worksheet.Range("F9:F11").Value = section
                worksheet.Range("G9:G11").Value = room
            ElseIf time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E6:E13").Merge()
                worksheet.Range("F9:F13").Merge()
                worksheet.Range("G9:G13").Merge()
                worksheet.Range("E9:E13").Value = subject
                worksheet.Range("F9:F13").Value = section
                worksheet.Range("G9:G13").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:00:00" Then
            If time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E10:E12").Merge()
                worksheet.Range("F10:F12").Merge()
                worksheet.Range("G10:G12").Merge()
                worksheet.Range("E10:E12").Value = subject
                worksheet.Range("F10:F12").Value = section
                worksheet.Range("G10:G12").Value = room
            ElseIf time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E10:E14").Merge()
                worksheet.Range("F10:F14").Merge()
                worksheet.Range("G10:G14").Merge()
                worksheet.Range("E10:E14").Value = subject
                worksheet.Range("F10:F14").Value = section
                worksheet.Range("G10:G14").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:30:00" Then
            If time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E11:E13").Merge()
                worksheet.Range("F11:F13").Merge()
                worksheet.Range("G11:G13").Merge()
                worksheet.Range("E11:E13").Value = subject
                worksheet.Range("F11:F13").Value = section
                worksheet.Range("G11:G13").Value = room
            ElseIf time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E11:E15").Merge()
                worksheet.Range("F11:F15").Merge()
                worksheet.Range("G11:G15").Merge()
                worksheet.Range("E11:E15").Value = subject
                worksheet.Range("F11:F15").Value = section
                worksheet.Range("G11:G15").Value = room
            End If
        ElseIf time_start = "2020-02-11 10:00:00" Then
            If time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E12:E14").Merge()
                worksheet.Range("F12:F14").Merge()
                worksheet.Range("G12:G14").Merge()
                worksheet.Range("E12:E14").Value = subject
                worksheet.Range("F12:F14").Value = section
                worksheet.Range("G12:G14").Value = room

            ElseIf time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E12:E16").Merge()
                worksheet.Range("F12:F16").Merge()
                worksheet.Range("G12:G16").Merge()
                worksheet.Range("E12:E16").Value = subject
                worksheet.Range("F12:F16").Value = section
                worksheet.Range("G12:G16").Value = room

            End If
        End If
        If time_start = "2020-02-11 10:30:00" Then
            If time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E13:E15").Merge()
                worksheet.Range("F13:F15").Merge()
                worksheet.Range("G13:G15").Merge()
                worksheet.Range("E13:E15").Value = subject
                worksheet.Range("F13:F15").Value = section
                worksheet.Range("G13:G15").Value = room
            ElseIf time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E13:E17").Merge()
                worksheet.Range("F13:F17").Merge()
                worksheet.Range("G13:G17").Merge()
                worksheet.Range("E13:E17").Value = subject
                worksheet.Range("F13:F17").Value = section
                worksheet.Range("G13:G17").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:00:00" Then
            If time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E14:E16").Merge()
                worksheet.Range("F14:F16").Merge()
                worksheet.Range("G14:G16").Merge()
                worksheet.Range("E14:E16").Value = subject
                worksheet.Range("F14:F16").Value = section
                worksheet.Range("G14:G16").Value = room
            ElseIf time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E14:E18").Merge()
                worksheet.Range("F14:F18").Merge()
                worksheet.Range("G14:G18").Merge()
                worksheet.Range("E14:E18").Value = subject
                worksheet.Range("F14:F18").Value = section
                worksheet.Range("G14:G18").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:30:00" Then
            If time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E15:E17").Merge()
                worksheet.Range("F15:F17").Merge()
                worksheet.Range("G15:G17").Merge()
                worksheet.Range("E15:E17").Value = subject
                worksheet.Range("F15:F17").Value = section
                worksheet.Range("G15:G17").Value = room
            ElseIf time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E15:E19").Merge()
                worksheet.Range("F15:F19").Merge()
                worksheet.Range("G15:G19").Merge()
                worksheet.Range("E15:E19").Value = subject
                worksheet.Range("F15:F19").Value = section
                worksheet.Range("G15:G19").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:00:00" Then
            If time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E16:E14").Merge()
                worksheet.Range("F16:F18").Merge()
                worksheet.Range("G16:G18").Merge()
                worksheet.Range("E16:E18").Value = subject
                worksheet.Range("F16:F18").Value = section
                worksheet.Range("G16:G18").Value = room
            ElseIf time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E16:E20").Merge()
                worksheet.Range("F16:F20").Merge()
                worksheet.Range("G16:G20").Merge()
                worksheet.Range("E16:E20").Value = subject
                worksheet.Range("F16:F20").Value = section
                worksheet.Range("G16:G20").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:30:00" Then
            If time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E17:E19").Merge()
                worksheet.Range("F17:F19").Merge()
                worksheet.Range("G17:G19").Merge()
                worksheet.Range("E17:E19").Value = subject
                worksheet.Range("F17:F19").Value = section
                worksheet.Range("G17:G19").Value = room
            ElseIf time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E17:E21").Merge()
                worksheet.Range("F17:F21").Merge()
                worksheet.Range("G17:G21").Merge()
                worksheet.Range("E17:E21").Value = subject
                worksheet.Range("F17:F21").Value = section
                worksheet.Range("G17:G21").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:00:00" Then
            If time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E18:E20").Merge()
                worksheet.Range("F18:F20").Merge()
                worksheet.Range("G18:G20").Merge()
                worksheet.Range("E18:E20").Value = subject
                worksheet.Range("F18:F20").Value = section
                worksheet.Range("G18:G20").Value = room
            ElseIf time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E18:E22").Merge()
                worksheet.Range("F18:F22").Merge()
                worksheet.Range("G18:G22").Merge()
                worksheet.Range("E18:E22").Value = subject
                worksheet.Range("F18:F22").Value = section
                worksheet.Range("G18:G22").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:30:00" Then
            If time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E19:E21").Merge()
                worksheet.Range("F19:F21").Merge()
                worksheet.Range("G19:G21").Merge()
                worksheet.Range("E19:E21").Value = subject
                worksheet.Range("F19:F21").Value = section
                worksheet.Range("G19:G21").Value = room
            ElseIf time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E19:E23").Merge()
                worksheet.Range("F19:F23").Merge()
                worksheet.Range("G19:G23").Merge()
                worksheet.Range("E19:E23").Value = subject
                worksheet.Range("F19:F23").Value = section
                worksheet.Range("G19:G23").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:00:00" Then
            If time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E20:E22").Merge()
                worksheet.Range("F20:F22").Merge()
                worksheet.Range("G20:G22").Merge()
                worksheet.Range("E20:E22").Value = subject
                worksheet.Range("F20:F22").Value = section
                worksheet.Range("G20:G22").Value = room
            ElseIf time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E20:E24").Merge()
                worksheet.Range("F20:F24").Merge()
                worksheet.Range("G20:G24").Merge()
                worksheet.Range("E20:E24").Value = subject
                worksheet.Range("F20:F24").Value = section
                worksheet.Range("G20:G24").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:30:00" Then
            If time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E21:E23").Merge()
                worksheet.Range("F21:F23").Merge()
                worksheet.Range("G21:G23").Merge()
                worksheet.Range("E21:E23").Value = subject
                worksheet.Range("F21:F23").Value = section
                worksheet.Range("G21:G23").Value = room
            ElseIf time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E21:E25").Merge()
                worksheet.Range("F21:F25").Merge()
                worksheet.Range("G21:G25").Merge()
                worksheet.Range("E21:E25").Value = subject
                worksheet.Range("F21:F25").Value = section
                worksheet.Range("G21:G25").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:00:00" Then
            If time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E22:E24").Merge()
                worksheet.Range("F22:F24").Merge()
                worksheet.Range("G22:G24").Merge()
                worksheet.Range("E22:E24").Value = subject
                worksheet.Range("F22:F24").Value = section
                worksheet.Range("G22:G24").Value = room
            ElseIf time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E22:E26").Merge()
                worksheet.Range("F22:F26").Merge()
                worksheet.Range("G22:G26").Merge()
                worksheet.Range("E22:E26").Value = subject
                worksheet.Range("F22:F26").Value = section
                worksheet.Range("G22:G26").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:30:00" Then
            If time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E23:E25").Merge()
                worksheet.Range("F23:F25").Merge()
                worksheet.Range("G23:G25").Merge()
                worksheet.Range("E23:E25").Value = subject
                worksheet.Range("F23:F25").Value = section
                worksheet.Range("G23:G25").Value = room
            ElseIf time_end = "2020-02-11 17:30:00" Then
                worksheet.Range("E23:E27").Merge()
                worksheet.Range("F23:F27").Merge()
                worksheet.Range("G23:G27").Merge()
                worksheet.Range("E23:E27").Value = subject
                worksheet.Range("F23:F27").Value = section
                worksheet.Range("G23:G27").Value = room
            End If
        End If
        If time_start = "2020-02-11 16:00:00" Then
            If time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E24:E26").Merge()
                worksheet.Range("F24:F26").Merge()
                worksheet.Range("G24:G26").Merge()
                worksheet.Range("E24:E26").Value = subject
                worksheet.Range("F24:F26").Value = section
                worksheet.Range("G24:G26").Value = room
            ElseIf time_end = "2020-02-11 18:00:00" Then
                worksheet.Range("E24:E28").Merge()
                worksheet.Range("F24:F28").Merge()
                worksheet.Range("G24:G28").Merge()
                worksheet.Range("E24:E28").Value = subject
                worksheet.Range("F24:F28").Value = section
                worksheet.Range("G24:G28").Value = room
            End If
        End If


        ' wednesday


        If time_start = "2020-02-12 06:00:00" Then
            If time_end = "2020-02-12 07:00:00" Then
                worksheet.Range("H4:H6").Merge()
                worksheet.Range("I4:I6").Merge()
                worksheet.Range("J4:J6").Merge()
                worksheet.Range("H4:H6").Value = subject
                worksheet.Range("I4:I6").Value = section
                worksheet.Range("J4:J6").Value = room
            ElseIf time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H4:H8").Merge()
                worksheet.Range("I4:I8").Merge()
                worksheet.Range("J4:J8").Merge()
                worksheet.Range("H4:H8").Value = subject
                worksheet.Range("I4:I8").Value = section
                worksheet.Range("J4:J8").Value = room
            End If
        ElseIf time_start = "2020-02-12 06:30:00" Then

            If time_end = "2020-02-12 07:30:00" Then
                worksheet.Range("H5:H7").Merge()
                worksheet.Range("I5:I7").Merge()
                worksheet.Range("J5:J7").Merge()
                worksheet.Range("H5:H7").Value = subject
                worksheet.Range("I5:I7").Value = section
                worksheet.Range("J5:J7").Value = room
            ElseIf time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H5:H9").Merge()
                worksheet.Range("I5:I9").Merge()
                worksheet.Range("J5:J9").Merge()
                worksheet.Range("H5:H9").Value = subject
                worksheet.Range("I5:I9").Value = section
            End If
            worksheet.Range("J5:J9").Value = room
        ElseIf time_start = "2020-02-12 07:00:00" Then
            If time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H6:H8").Merge()
                worksheet.Range("I6:I8").Merge()
                worksheet.Range("J6:J8").Merge()
                worksheet.Range("H6:H8").Value = subject
                worksheet.Range("I6:I8").Value = section
                worksheet.Range("J6:J8").Value = room
            ElseIf time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H6:H10").Merge()
                worksheet.Range("I6:I10").Merge()
                worksheet.Range("J6:J10").Merge()
                worksheet.Range("H6:H10").Value = subject
                worksheet.Range("I6:I10").Value = section
                worksheet.Range("J6:J10").Value = room
            End If
        ElseIf time_start = "2020-02-12 07:30:00" Then
            If time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H7:H9").Merge()
                worksheet.Range("I7:I9").Merge()
                worksheet.Range("J7:J9").Merge()
                worksheet.Range("H7:H9").Value = subject
                worksheet.Range("I7:I9").Value = section
                worksheet.Range("J7:J9").Value = room
            ElseIf time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H7:H11").Merge()
                worksheet.Range("I7:I11").Merge()
                worksheet.Range("J7:J11").Merge()
                worksheet.Range("H7:H11").Value = subject
                worksheet.Range("I7:I11").Value = section
                worksheet.Range("J7:J11").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:00:00" Then
            If time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H8:H10").Merge()
                worksheet.Range("I8:I10").Merge()
                worksheet.Range("J8:J10").Merge()
                worksheet.Range("H8:H10").Value = subject
                worksheet.Range("I8:I10").Value = section
                worksheet.Range("J8:J10").Value = room
            ElseIf time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H8:H12").Merge()
                worksheet.Range("I8:I12").Merge()
                worksheet.Range("J8:J12").Merge()
                worksheet.Range("H8:H12").Value = subject
                worksheet.Range("I8:I12").Value = section
                worksheet.Range("J8:J12").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:30:00" Then
            If time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H9:H11").Merge()
                worksheet.Range("I9:I11").Merge()
                worksheet.Range("J9:J11").Merge()
                worksheet.Range("H9:H11").Value = subject
                worksheet.Range("I9:I11").Value = section
                worksheet.Range("J9:J11").Value = room
            ElseIf time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H6:H13").Merge()
                worksheet.Range("I9:I13").Merge()
                worksheet.Range("J9:J13").Merge()
                worksheet.Range("H9:H13").Value = subject
                worksheet.Range("I9:I13").Value = section
                worksheet.Range("J9:J13").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:00:00" Then
            If time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H10:H12").Merge()
                worksheet.Range("I10:I12").Merge()
                worksheet.Range("J10:J12").Merge()
                worksheet.Range("H10:H12").Value = subject
                worksheet.Range("I10:I12").Value = section
                worksheet.Range("J10:J12").Value = room
            ElseIf time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H10:H14").Merge()
                worksheet.Range("I10:I14").Merge()
                worksheet.Range("J10:J14").Merge()
                worksheet.Range("H10:H14").Value = subject
                worksheet.Range("I10:I14").Value = section
                worksheet.Range("J10:J14").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:30:00" Then
            If time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H11:H13").Merge()
                worksheet.Range("I11:I13").Merge()
                worksheet.Range("J11:J13").Merge()
                worksheet.Range("H11:H13").Value = subject
                worksheet.Range("I11:I13").Value = section
                worksheet.Range("J11:J13").Value = room
            ElseIf time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H11:H15").Merge()
                worksheet.Range("I11:I15").Merge()
                worksheet.Range("J11:J15").Merge()
                worksheet.Range("H11:H15").Value = subject
                worksheet.Range("I11:I15").Value = section
                worksheet.Range("J11:J15").Value = room
            End If
        ElseIf time_start = "2020-02-12 10:00:00" Then
            If time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H12:H14").Merge()
                worksheet.Range("I12:I14").Merge()
                worksheet.Range("J12:J14").Merge()
                worksheet.Range("H12:H14").Value = subject
                worksheet.Range("I12:I14").Value = section
                worksheet.Range("J12:J14").Value = room

            ElseIf time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H12:H16").Merge()
                worksheet.Range("I12:I16").Merge()
                worksheet.Range("J12:J16").Merge()
                worksheet.Range("H12:H16").Value = subject
                worksheet.Range("I12:I16").Value = section
                worksheet.Range("J12:J16").Value = room

            End If
        End If
        If time_start = "2020-02-12 10:30:00" Then
            If time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H13:H15").Merge()
                worksheet.Range("I13:I15").Merge()
                worksheet.Range("J13:J15").Merge()
                worksheet.Range("H13:H15").Value = subject
                worksheet.Range("I13:I15").Value = section
                worksheet.Range("J13:J15").Value = room
            ElseIf time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H13:H17").Merge()
                worksheet.Range("I13:I17").Merge()
                worksheet.Range("J13:J17").Merge()
                worksheet.Range("H13:H17").Value = subject
                worksheet.Range("I13:I17").Value = section
                worksheet.Range("J13:J17").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:00:00" Then
            If time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H14:H16").Merge()
                worksheet.Range("I14:I16").Merge()
                worksheet.Range("J14:J16").Merge()
                worksheet.Range("H14:H16").Value = subject
                worksheet.Range("I14:I16").Value = section
                worksheet.Range("J14:J16").Value = room
            ElseIf time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H14:H18").Merge()
                worksheet.Range("I14:I18").Merge()
                worksheet.Range("J14:J18").Merge()
                worksheet.Range("H14:H18").Value = subject
                worksheet.Range("I14:I18").Value = section
                worksheet.Range("J14:J18").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:30:00" Then
            If time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H15:H17").Merge()
                worksheet.Range("I15:I17").Merge()
                worksheet.Range("J15:J17").Merge()
                worksheet.Range("H15:H17").Value = subject
                worksheet.Range("I15:I17").Value = section
                worksheet.Range("J15:J17").Value = room
            ElseIf time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H15:H19").Merge()
                worksheet.Range("I15:I19").Merge()
                worksheet.Range("J15:J19").Merge()
                worksheet.Range("H15:H19").Value = subject
                worksheet.Range("I15:I19").Value = section
                worksheet.Range("J15:J19").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:00:00" Then
            If time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H16:H14").Merge()
                worksheet.Range("I16:I18").Merge()
                worksheet.Range("J16:J18").Merge()
                worksheet.Range("H16:H18").Value = subject
                worksheet.Range("I16:I18").Value = section
                worksheet.Range("J16:J18").Value = room
            ElseIf time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H16:H20").Merge()
                worksheet.Range("I16:I20").Merge()
                worksheet.Range("J16:J20").Merge()
                worksheet.Range("H16:H20").Value = subject
                worksheet.Range("I16:I20").Value = section
                worksheet.Range("J16:J20").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:30:00" Then
            If time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H17:H19").Merge()
                worksheet.Range("I17:I19").Merge()
                worksheet.Range("J17:J19").Merge()
                worksheet.Range("H17:H19").Value = subject
                worksheet.Range("I17:I19").Value = section
                worksheet.Range("J17:J19").Value = room
            ElseIf time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H17:H21").Merge()
                worksheet.Range("I17:I21").Merge()
                worksheet.Range("J17:J21").Merge()
                worksheet.Range("H17:H21").Value = subject
                worksheet.Range("I17:I21").Value = section
                worksheet.Range("J17:J21").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:00:00" Then
            If time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H18:H20").Merge()
                worksheet.Range("I18:I20").Merge()
                worksheet.Range("J18:J20").Merge()
                worksheet.Range("H18:H20").Value = subject
                worksheet.Range("I18:I20").Value = section
                worksheet.Range("J18:J20").Value = room
            ElseIf time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H18:H22").Merge()
                worksheet.Range("I18:I22").Merge()
                worksheet.Range("J18:J22").Merge()
                worksheet.Range("H18:H22").Value = subject
                worksheet.Range("I18:I22").Value = section
                worksheet.Range("J18:J22").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:30:00" Then
            If time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H19:H21").Merge()
                worksheet.Range("I19:I21").Merge()
                worksheet.Range("J19:J21").Merge()
                worksheet.Range("H19:H21").Value = subject
                worksheet.Range("I19:I21").Value = section
                worksheet.Range("J19:J21").Value = room
            ElseIf time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H19:H23").Merge()
                worksheet.Range("I19:I23").Merge()
                worksheet.Range("J19:J23").Merge()
                worksheet.Range("H19:H23").Value = subject
                worksheet.Range("I19:I23").Value = section
                worksheet.Range("J19:J23").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:00:00" Then
            If time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H20:H22").Merge()
                worksheet.Range("I20:I22").Merge()
                worksheet.Range("J20:J22").Merge()
                worksheet.Range("H20:H22").Value = subject
                worksheet.Range("I20:I22").Value = section
                worksheet.Range("J20:J22").Value = room
            ElseIf time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H20:H24").Merge()
                worksheet.Range("I20:I24").Merge()
                worksheet.Range("J20:J24").Merge()
                worksheet.Range("H20:H24").Value = subject
                worksheet.Range("I20:I24").Value = section
                worksheet.Range("J20:J24").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:30:00" Then
            If time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H21:H23").Merge()
                worksheet.Range("I21:I23").Merge()
                worksheet.Range("J21:J23").Merge()
                worksheet.Range("H21:H23").Value = subject
                worksheet.Range("I21:I23").Value = section
                worksheet.Range("J21:J23").Value = room
            ElseIf time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H21:H25").Merge()
                worksheet.Range("I21:I25").Merge()
                worksheet.Range("J21:J25").Merge()
                worksheet.Range("H21:H25").Value = subject
                worksheet.Range("I21:I25").Value = section
                worksheet.Range("J21:J25").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:00:00" Then
            If time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H22:H24").Merge()
                worksheet.Range("I22:I24").Merge()
                worksheet.Range("J22:J24").Merge()
                worksheet.Range("H22:H24").Value = subject
                worksheet.Range("I22:I24").Value = section
                worksheet.Range("J22:J24").Value = room
            ElseIf time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H22:H26").Merge()
                worksheet.Range("I22:I26").Merge()
                worksheet.Range("J22:J26").Merge()
                worksheet.Range("H22:H26").Value = subject
                worksheet.Range("I22:I26").Value = section
                worksheet.Range("J22:J26").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:30:00" Then
            If time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H23:H25").Merge()
                worksheet.Range("I23:I25").Merge()
                worksheet.Range("J23:J25").Merge()
                worksheet.Range("H23:H25").Value = subject
                worksheet.Range("I23:I25").Value = section
                worksheet.Range("J23:J25").Value = room
            ElseIf time_end = "2020-02-12 17:30:00" Then
                worksheet.Range("H23:H27").Merge()
                worksheet.Range("I23:I27").Merge()
                worksheet.Range("J23:J27").Merge()
                worksheet.Range("H23:H27").Value = subject
                worksheet.Range("I23:I27").Value = section
                worksheet.Range("J23:J27").Value = room
            End If
        End If
        If time_start = "2020-02-12 16:00:00" Then
            If time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H24:H26").Merge()
                worksheet.Range("I24:I26").Merge()
                worksheet.Range("J24:J26").Merge()
                worksheet.Range("H24:H26").Value = subject
                worksheet.Range("I24:I26").Value = section
                worksheet.Range("J24:J26").Value = room
            ElseIf time_end = "2020-02-12 18:00:00" Then
                worksheet.Range("H24:H28").Merge()
                worksheet.Range("I24:I28").Merge()
                worksheet.Range("J24:J28").Merge()
                worksheet.Range("H24:H28").Value = subject
                worksheet.Range("I24:I28").Value = section
                worksheet.Range("J24:J28").Value = room
            End If
        End If


        'Thursday

        If time_start = "2020-02-13 06:00:00" Then
            If time_end = "2020-02-13 07:00:00" Then
                worksheet.Range("K4:K6").Merge()
                worksheet.Range("L4:L6").Merge()
                worksheet.Range("M4:M6").Merge()
                worksheet.Range("K4:K6").Value = subject
                worksheet.Range("L4:L6").Value = section
                worksheet.Range("M4:M6").Value = room
            ElseIf time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K4:K8").Merge()
                worksheet.Range("L4:L8").Merge()
                worksheet.Range("M4:M8").Merge()
                worksheet.Range("K4:K8").Value = subject
                worksheet.Range("L4:L8").Value = section
                worksheet.Range("M4:M8").Value = room
            End If
        ElseIf time_start = "2020-02-13 06:30:00" Then

            If time_end = "2020-02-13 07:30:00" Then
                worksheet.Range("K5:K7").Merge()
                worksheet.Range("L5:L7").Merge()
                worksheet.Range("M5:M7").Merge()
                worksheet.Range("K5:K7").Value = subject
                worksheet.Range("L5:L7").Value = section
                worksheet.Range("M5:M7").Value = room
            ElseIf time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K5:K9").Merge()
                worksheet.Range("L5:L9").Merge()
                worksheet.Range("M5:M9").Merge()
                worksheet.Range("K5:K9").Value = subject
                worksheet.Range("L5:L9").Value = section
            End If
            worksheet.Range("M5:M9").Value = room
        ElseIf time_start = "2020-02-13 07:00:00" Then
            If time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K6:K8").Merge()
                worksheet.Range("L6:L8").Merge()
                worksheet.Range("M6:M8").Merge()
                worksheet.Range("K6:K8").Value = subject
                worksheet.Range("L6:L8").Value = section
                worksheet.Range("M6:M8").Value = room
            ElseIf time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K6:K10").Merge()
                worksheet.Range("L6:L10").Merge()
                worksheet.Range("M6:M10").Merge()
                worksheet.Range("K6:K10").Value = subject
                worksheet.Range("L6:L10").Value = section
                worksheet.Range("M6:M10").Value = room
            End If
        ElseIf time_start = "2020-02-13 07:30:00" Then
            If time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K7:K9").Merge()
                worksheet.Range("L7:L9").Merge()
                worksheet.Range("M7:M9").Merge()
                worksheet.Range("K7:K9").Value = subject
                worksheet.Range("L7:L9").Value = section
                worksheet.Range("M7:M9").Value = room
            ElseIf time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K7:K11").Merge()
                worksheet.Range("L7:L11").Merge()
                worksheet.Range("M7:M11").Merge()
                worksheet.Range("K7:K11").Value = subject
                worksheet.Range("L7:L11").Value = section
                worksheet.Range("M7:M11").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:00:00" Then
            If time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K8:K10").Merge()
                worksheet.Range("L8:L10").Merge()
                worksheet.Range("M8:M10").Merge()
                worksheet.Range("K8:K10").Value = subject
                worksheet.Range("L8:L10").Value = section
                worksheet.Range("M8:M10").Value = room
            ElseIf time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K8:K12").Merge()
                worksheet.Range("L8:L12").Merge()
                worksheet.Range("M8:M12").Merge()
                worksheet.Range("K8:K12").Value = subject
                worksheet.Range("L8:L12").Value = section
                worksheet.Range("M8:M12").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:30:00" Then
            If time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K9:K11").Merge()
                worksheet.Range("L9:L11").Merge()
                worksheet.Range("M9:M11").Merge()
                worksheet.Range("K9:K11").Value = subject
                worksheet.Range("L9:L11").Value = section
                worksheet.Range("M9:M11").Value = room
            ElseIf time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K6:K13").Merge()
                worksheet.Range("L9:L13").Merge()
                worksheet.Range("M9:M13").Merge()
                worksheet.Range("K9:K13").Value = subject
                worksheet.Range("L9:L13").Value = section
                worksheet.Range("M9:M13").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:00:00" Then
            If time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K10:K12").Merge()
                worksheet.Range("L10:L12").Merge()
                worksheet.Range("M10:M12").Merge()
                worksheet.Range("K10:K12").Value = subject
                worksheet.Range("L10:L12").Value = section
                worksheet.Range("M10:M12").Value = room
            ElseIf time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K10:K14").Merge()
                worksheet.Range("L10:L14").Merge()
                worksheet.Range("M10:M14").Merge()
                worksheet.Range("K10:K14").Value = subject
                worksheet.Range("L10:L14").Value = section
                worksheet.Range("M10:M14").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:30:00" Then
            If time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K11:K13").Merge()
                worksheet.Range("L11:L13").Merge()
                worksheet.Range("M11:M13").Merge()
                worksheet.Range("K11:K13").Value = subject
                worksheet.Range("L11:L13").Value = section
                worksheet.Range("M11:M13").Value = room
            ElseIf time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K11:K15").Merge()
                worksheet.Range("L11:L15").Merge()
                worksheet.Range("M11:M15").Merge()
                worksheet.Range("K11:K15").Value = subject
                worksheet.Range("L11:L15").Value = section
                worksheet.Range("M11:M15").Value = room
            End If
        ElseIf time_start = "2020-02-13 10:00:00" Then
            If time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K12:K14").Merge()
                worksheet.Range("L12:L14").Merge()
                worksheet.Range("M12:M14").Merge()
                worksheet.Range("K12:K14").Value = subject
                worksheet.Range("L12:L14").Value = section
                worksheet.Range("M12:M14").Value = room

            ElseIf time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K12:K16").Merge()
                worksheet.Range("L12:L16").Merge()
                worksheet.Range("M12:M16").Merge()
                worksheet.Range("K12:K16").Value = subject
                worksheet.Range("L12:L16").Value = section
                worksheet.Range("M12:M16").Value = room

            End If
        End If
        If time_start = "2020-02-13 10:30:00" Then
            If time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K13:K15").Merge()
                worksheet.Range("L13:L15").Merge()
                worksheet.Range("M13:M15").Merge()
                worksheet.Range("K13:K15").Value = subject
                worksheet.Range("L13:L15").Value = section
                worksheet.Range("M13:M15").Value = room
            ElseIf time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K13:K17").Merge()
                worksheet.Range("L13:L17").Merge()
                worksheet.Range("M13:M17").Merge()
                worksheet.Range("K13:K17").Value = subject
                worksheet.Range("L13:L17").Value = section
                worksheet.Range("M13:M17").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:00:00" Then
            If time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K14:K16").Merge()
                worksheet.Range("L14:L16").Merge()
                worksheet.Range("M14:M16").Merge()
                worksheet.Range("K14:K16").Value = subject
                worksheet.Range("L14:L16").Value = section
                worksheet.Range("M14:M16").Value = room
            ElseIf time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K14:K18").Merge()
                worksheet.Range("L14:L18").Merge()
                worksheet.Range("M14:M18").Merge()
                worksheet.Range("K14:K18").Value = subject
                worksheet.Range("L14:L18").Value = section
                worksheet.Range("M14:M18").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:30:00" Then
            If time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K15:K17").Merge()
                worksheet.Range("L15:L17").Merge()
                worksheet.Range("M15:M17").Merge()
                worksheet.Range("K15:K17").Value = subject
                worksheet.Range("L15:L17").Value = section
                worksheet.Range("M15:M17").Value = room
            ElseIf time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K15:K19").Merge()
                worksheet.Range("L15:L19").Merge()
                worksheet.Range("M15:M19").Merge()
                worksheet.Range("K15:K19").Value = subject
                worksheet.Range("L15:L19").Value = section
                worksheet.Range("M15:M19").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:00:00" Then
            If time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K16:K14").Merge()
                worksheet.Range("L16:L18").Merge()
                worksheet.Range("M16:M18").Merge()
                worksheet.Range("K16:K18").Value = subject
                worksheet.Range("L16:L18").Value = section
                worksheet.Range("M16:M18").Value = room
            ElseIf time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K16:K20").Merge()
                worksheet.Range("L16:L20").Merge()
                worksheet.Range("M16:M20").Merge()
                worksheet.Range("K16:K20").Value = subject
                worksheet.Range("L16:L20").Value = section
                worksheet.Range("M16:M20").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:30:00" Then
            If time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K17:K19").Merge()
                worksheet.Range("L17:L19").Merge()
                worksheet.Range("M17:M19").Merge()
                worksheet.Range("K17:K19").Value = subject
                worksheet.Range("L17:L19").Value = section
                worksheet.Range("M17:M19").Value = room
            ElseIf time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K17:K21").Merge()
                worksheet.Range("L17:L21").Merge()
                worksheet.Range("M17:M21").Merge()
                worksheet.Range("K17:K21").Value = subject
                worksheet.Range("L17:L21").Value = section
                worksheet.Range("M17:M21").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:00:00" Then
            If time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K18:K20").Merge()
                worksheet.Range("L18:L20").Merge()
                worksheet.Range("M18:M20").Merge()
                worksheet.Range("K18:K20").Value = subject
                worksheet.Range("L18:L20").Value = section
                worksheet.Range("M18:M20").Value = room
            ElseIf time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K18:K22").Merge()
                worksheet.Range("L18:L22").Merge()
                worksheet.Range("M18:M22").Merge()
                worksheet.Range("K18:K22").Value = subject
                worksheet.Range("L18:L22").Value = section
                worksheet.Range("M18:M22").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:30:00" Then
            If time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K19:K21").Merge()
                worksheet.Range("L19:L21").Merge()
                worksheet.Range("M19:M21").Merge()
                worksheet.Range("K19:K21").Value = subject
                worksheet.Range("L19:L21").Value = section
                worksheet.Range("M19:M21").Value = room
            ElseIf time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K19:K23").Merge()
                worksheet.Range("L19:L23").Merge()
                worksheet.Range("M19:M23").Merge()
                worksheet.Range("K19:K23").Value = subject
                worksheet.Range("L19:L23").Value = section
                worksheet.Range("M19:M23").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:00:00" Then
            If time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K20:K22").Merge()
                worksheet.Range("L20:L22").Merge()
                worksheet.Range("M20:M22").Merge()
                worksheet.Range("K20:K22").Value = subject
                worksheet.Range("L20:L22").Value = section
                worksheet.Range("M20:M22").Value = room
            ElseIf time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K20:K24").Merge()
                worksheet.Range("L20:L24").Merge()
                worksheet.Range("M20:M24").Merge()
                worksheet.Range("K20:K24").Value = subject
                worksheet.Range("L20:L24").Value = section
                worksheet.Range("M20:M24").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:30:00" Then
            If time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K21:K23").Merge()
                worksheet.Range("L21:L23").Merge()
                worksheet.Range("M21:M23").Merge()
                worksheet.Range("K21:K23").Value = subject
                worksheet.Range("L21:L23").Value = section
                worksheet.Range("M21:M23").Value = room
            ElseIf time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K21:K25").Merge()
                worksheet.Range("L21:L25").Merge()
                worksheet.Range("M21:M25").Merge()
                worksheet.Range("K21:K25").Value = subject
                worksheet.Range("L21:L25").Value = section
                worksheet.Range("M21:M25").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:00:00" Then
            If time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K22:K24").Merge()
                worksheet.Range("L22:L24").Merge()
                worksheet.Range("M22:M24").Merge()
                worksheet.Range("K22:K24").Value = subject
                worksheet.Range("L22:L24").Value = section
                worksheet.Range("M22:M24").Value = room
            ElseIf time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K22:K26").Merge()
                worksheet.Range("L22:L26").Merge()
                worksheet.Range("M22:M26").Merge()
                worksheet.Range("K22:K26").Value = subject
                worksheet.Range("L22:L26").Value = section
                worksheet.Range("M22:M26").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:30:00" Then
            If time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K23:K25").Merge()
                worksheet.Range("L23:L25").Merge()
                worksheet.Range("M23:M25").Merge()
                worksheet.Range("K23:K25").Value = subject
                worksheet.Range("L23:L25").Value = section
                worksheet.Range("M23:M25").Value = room
            ElseIf time_end = "2020-02-13 17:30:00" Then
                worksheet.Range("K23:K27").Merge()
                worksheet.Range("L23:L27").Merge()
                worksheet.Range("M23:M27").Merge()
                worksheet.Range("K23:K27").Value = subject
                worksheet.Range("L23:L27").Value = section
                worksheet.Range("M23:M27").Value = room
            End If
        End If
        If time_start = "2020-02-13 16:00:00" Then
            If time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K24:K26").Merge()
                worksheet.Range("L24:L26").Merge()
                worksheet.Range("M24:M26").Merge()
                worksheet.Range("K24:K26").Value = subject
                worksheet.Range("L24:L26").Value = section
                worksheet.Range("M24:M26").Value = room
            ElseIf time_end = "2020-02-13 18:00:00" Then
                worksheet.Range("K24:K28").Merge()
                worksheet.Range("L24:L28").Merge()
                worksheet.Range("M24:M28").Merge()
                worksheet.Range("K24:K28").Value = subject
                worksheet.Range("L24:L28").Value = section
                worksheet.Range("M24:M28").Value = room
            End If
        End If

        'Fridayyyy========
        If time_start = "2020-02-14 06:00:00" Then
            If time_end = "2020-02-14 07:00:00" Then
                worksheet.Range("N4:N6").Merge()
                worksheet.Range("O4:O6").Merge()
                worksheet.Range("P4:P6").Merge()
                worksheet.Range("N4:N6").Value = subject
                worksheet.Range("O4:O6").Value = section
                worksheet.Range("P4:P6").Value = room
            ElseIf time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N4:N8").Merge()
                worksheet.Range("O4:O8").Merge()
                worksheet.Range("P4:P8").Merge()
                worksheet.Range("N4:N8").Value = subject
                worksheet.Range("O4:O8").Value = section
                worksheet.Range("P4:P8").Value = room
            End If
        ElseIf time_start = "2020-02-14 06:30:00" Then

            If time_end = "2020-02-14 07:30:00" Then
                worksheet.Range("N5:N7").Merge()
                worksheet.Range("O5:O7").Merge()
                worksheet.Range("P5:P7").Merge()
                worksheet.Range("N5:N7").Value = subject
                worksheet.Range("O5:O7").Value = section
                worksheet.Range("P5:P7").Value = room
            ElseIf time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N5:N9").Merge()
                worksheet.Range("O5:O9").Merge()
                worksheet.Range("P5:P9").Merge()
                worksheet.Range("N5:N9").Value = subject
                worksheet.Range("O5:O9").Value = section
            End If
            worksheet.Range("P5:P9").Value = room
        ElseIf time_start = "2020-02-14 07:00:00" Then
            If time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N6:N8").Merge()
                worksheet.Range("O6:O8").Merge()
                worksheet.Range("P6:P8").Merge()
                worksheet.Range("N6:N8").Value = subject
                worksheet.Range("O6:O8").Value = section
                worksheet.Range("P6:P8").Value = room
            ElseIf time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N6:N10").Merge()
                worksheet.Range("O6:O10").Merge()
                worksheet.Range("P6:P10").Merge()
                worksheet.Range("N6:N10").Value = subject
                worksheet.Range("O6:O10").Value = section
                worksheet.Range("P6:P10").Value = room
            End If
        ElseIf time_start = "2020-02-14 07:30:00" Then
            If time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N7:N9").Merge()
                worksheet.Range("O7:O9").Merge()
                worksheet.Range("P7:P9").Merge()
                worksheet.Range("N7:N9").Value = subject
                worksheet.Range("O7:O9").Value = section
                worksheet.Range("P7:P9").Value = room
            ElseIf time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N7:N11").Merge()
                worksheet.Range("O7:O11").Merge()
                worksheet.Range("P7:P11").Merge()
                worksheet.Range("N7:N11").Value = subject
                worksheet.Range("O7:O11").Value = section
                worksheet.Range("P7:P11").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:00:00" Then
            If time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N8:N10").Merge()
                worksheet.Range("O8:O10").Merge()
                worksheet.Range("P8:P10").Merge()
                worksheet.Range("N8:N10").Value = subject
                worksheet.Range("O8:O10").Value = section
                worksheet.Range("P8:P10").Value = room
            ElseIf time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N8:N12").Merge()
                worksheet.Range("O8:O12").Merge()
                worksheet.Range("P8:P12").Merge()
                worksheet.Range("N8:N12").Value = subject
                worksheet.Range("O8:O12").Value = section
                worksheet.Range("P8:P12").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:30:00" Then
            If time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N9:N11").Merge()
                worksheet.Range("O9:O11").Merge()
                worksheet.Range("P9:P11").Merge()
                worksheet.Range("N9:N11").Value = subject
                worksheet.Range("O9:O11").Value = section
                worksheet.Range("P9:P11").Value = room
            ElseIf time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N6:N13").Merge()
                worksheet.Range("O9:O13").Merge()
                worksheet.Range("P9:P13").Merge()
                worksheet.Range("N9:N13").Value = subject
                worksheet.Range("O9:O13").Value = section
                worksheet.Range("P9:P13").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:00:00" Then
            If time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N10:N12").Merge()
                worksheet.Range("O10:O12").Merge()
                worksheet.Range("P10:P12").Merge()
                worksheet.Range("N10:N12").Value = subject
                worksheet.Range("O10:O12").Value = section
                worksheet.Range("P10:P12").Value = room
            ElseIf time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N10:N14").Merge()
                worksheet.Range("O10:O14").Merge()
                worksheet.Range("P10:P14").Merge()
                worksheet.Range("N10:N14").Value = subject
                worksheet.Range("O10:O14").Value = section
                worksheet.Range("P10:P14").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:30:00" Then
            If time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N11:N13").Merge()
                worksheet.Range("O11:O13").Merge()
                worksheet.Range("P11:P13").Merge()
                worksheet.Range("N11:N13").Value = subject
                worksheet.Range("O11:O13").Value = section
                worksheet.Range("P11:P13").Value = room
            ElseIf time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N11:N15").Merge()
                worksheet.Range("O11:O15").Merge()
                worksheet.Range("P11:P15").Merge()
                worksheet.Range("N11:N15").Value = subject
                worksheet.Range("O11:O15").Value = section
                worksheet.Range("P11:P15").Value = room
            End If
        ElseIf time_start = "2020-02-14 10:00:00" Then
            If time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N12:N14").Merge()
                worksheet.Range("O12:O14").Merge()
                worksheet.Range("P12:P14").Merge()
                worksheet.Range("N12:N14").Value = subject
                worksheet.Range("O12:O14").Value = section
                worksheet.Range("P12:P14").Value = room

            ElseIf time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N12:N16").Merge()
                worksheet.Range("O12:O16").Merge()
                worksheet.Range("P12:P16").Merge()
                worksheet.Range("N12:N16").Value = subject
                worksheet.Range("O12:O16").Value = section
                worksheet.Range("P12:P16").Value = room

            End If
        End If
        If time_start = "2020-02-14 10:30:00" Then
            If time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N13:N15").Merge()
                worksheet.Range("O13:O15").Merge()
                worksheet.Range("P13:P15").Merge()
                worksheet.Range("N13:N15").Value = subject
                worksheet.Range("O13:O15").Value = section
                worksheet.Range("P13:P15").Value = room
            ElseIf time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N13:N17").Merge()
                worksheet.Range("O13:O17").Merge()
                worksheet.Range("P13:P17").Merge()
                worksheet.Range("N13:N17").Value = subject
                worksheet.Range("O13:O17").Value = section
                worksheet.Range("P13:P17").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:00:00" Then
            If time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N14:N16").Merge()
                worksheet.Range("O14:O16").Merge()
                worksheet.Range("P14:P16").Merge()
                worksheet.Range("N14:N16").Value = subject
                worksheet.Range("O14:O16").Value = section
                worksheet.Range("P14:P16").Value = room
            ElseIf time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N14:N18").Merge()
                worksheet.Range("O14:O18").Merge()
                worksheet.Range("P14:P18").Merge()
                worksheet.Range("N14:N18").Value = subject
                worksheet.Range("O14:O18").Value = section
                worksheet.Range("P14:P18").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:30:00" Then
            If time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N15:N17").Merge()
                worksheet.Range("O15:O17").Merge()
                worksheet.Range("P15:P17").Merge()
                worksheet.Range("N15:N17").Value = subject
                worksheet.Range("O15:O17").Value = section
                worksheet.Range("P15:P17").Value = room
            ElseIf time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N15:N19").Merge()
                worksheet.Range("O15:O19").Merge()
                worksheet.Range("P15:P19").Merge()
                worksheet.Range("N15:N19").Value = subject
                worksheet.Range("O15:O19").Value = section
                worksheet.Range("P15:P19").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:00:00" Then
            If time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N16:N14").Merge()
                worksheet.Range("O16:O18").Merge()
                worksheet.Range("P16:P18").Merge()
                worksheet.Range("N16:N18").Value = subject
                worksheet.Range("O16:O18").Value = section
                worksheet.Range("P16:P18").Value = room
            ElseIf time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N16:N20").Merge()
                worksheet.Range("O16:O20").Merge()
                worksheet.Range("P16:P20").Merge()
                worksheet.Range("N16:N20").Value = subject
                worksheet.Range("O16:O20").Value = section
                worksheet.Range("P16:P20").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:30:00" Then
            If time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N17:N19").Merge()
                worksheet.Range("O17:O19").Merge()
                worksheet.Range("P17:P19").Merge()
                worksheet.Range("N17:N19").Value = subject
                worksheet.Range("O17:O19").Value = section
                worksheet.Range("P17:P19").Value = room
            ElseIf time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N17:N21").Merge()
                worksheet.Range("O17:O21").Merge()
                worksheet.Range("P17:P21").Merge()
                worksheet.Range("N17:N21").Value = subject
                worksheet.Range("O17:O21").Value = section
                worksheet.Range("P17:P21").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:00:00" Then
            If time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N18:N20").Merge()
                worksheet.Range("O18:O20").Merge()
                worksheet.Range("P18:P20").Merge()
                worksheet.Range("N18:N20").Value = subject
                worksheet.Range("O18:O20").Value = section
                worksheet.Range("P18:P20").Value = room
            ElseIf time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N18:N22").Merge()
                worksheet.Range("O18:O22").Merge()
                worksheet.Range("P18:P22").Merge()
                worksheet.Range("N18:N22").Value = subject
                worksheet.Range("O18:O22").Value = section
                worksheet.Range("P18:P22").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:30:00" Then
            If time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N19:N21").Merge()
                worksheet.Range("O19:O21").Merge()
                worksheet.Range("P19:P21").Merge()
                worksheet.Range("N19:N21").Value = subject
                worksheet.Range("O19:O21").Value = section
                worksheet.Range("P19:P21").Value = room
            ElseIf time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N19:N23").Merge()
                worksheet.Range("O19:O23").Merge()
                worksheet.Range("P19:P23").Merge()
                worksheet.Range("N19:N23").Value = subject
                worksheet.Range("O19:O23").Value = section
                worksheet.Range("P19:P23").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:00:00" Then
            If time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N20:N22").Merge()
                worksheet.Range("O20:O22").Merge()
                worksheet.Range("P20:P22").Merge()
                worksheet.Range("N20:N22").Value = subject
                worksheet.Range("O20:O22").Value = section
                worksheet.Range("P20:P22").Value = room
            ElseIf time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N20:N24").Merge()
                worksheet.Range("O20:O24").Merge()
                worksheet.Range("P20:P24").Merge()
                worksheet.Range("N20:N24").Value = subject
                worksheet.Range("O20:O24").Value = section
                worksheet.Range("P20:P24").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:30:00" Then
            If time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N21:N23").Merge()
                worksheet.Range("O21:O23").Merge()
                worksheet.Range("P21:P23").Merge()
                worksheet.Range("N21:N23").Value = subject
                worksheet.Range("O21:O23").Value = section
                worksheet.Range("P21:P23").Value = room
            ElseIf time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N21:N25").Merge()
                worksheet.Range("O21:O25").Merge()
                worksheet.Range("P21:P25").Merge()
                worksheet.Range("N21:N25").Value = subject
                worksheet.Range("O21:O25").Value = section
                worksheet.Range("P21:P25").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:00:00" Then
            If time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N22:N24").Merge()
                worksheet.Range("O22:O24").Merge()
                worksheet.Range("P22:P24").Merge()
                worksheet.Range("N22:N24").Value = subject
                worksheet.Range("O22:O24").Value = section
                worksheet.Range("P22:P24").Value = room
            ElseIf time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N22:N26").Merge()
                worksheet.Range("O22:O26").Merge()
                worksheet.Range("P22:P26").Merge()
                worksheet.Range("N22:N26").Value = subject
                worksheet.Range("O22:O26").Value = section
                worksheet.Range("P22:P26").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:30:00" Then
            If time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N23:N25").Merge()
                worksheet.Range("O23:O25").Merge()
                worksheet.Range("P23:P25").Merge()
                worksheet.Range("N23:N25").Value = subject
                worksheet.Range("O23:O25").Value = section
                worksheet.Range("P23:P25").Value = room
            ElseIf time_end = "2020-02-14 17:30:00" Then
                worksheet.Range("N23:N27").Merge()
                worksheet.Range("O23:O27").Merge()
                worksheet.Range("P23:P27").Merge()
                worksheet.Range("N23:N27").Value = subject
                worksheet.Range("O23:O27").Value = section
                worksheet.Range("P23:P27").Value = room
            End If
        End If
        If time_start = "2020-02-14 16:00:00" Then
            If time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N24:N26").Merge()
                worksheet.Range("O24:O26").Merge()
                worksheet.Range("P24:P26").Merge()
                worksheet.Range("N24:N26").Value = subject
                worksheet.Range("O24:O26").Value = section
                worksheet.Range("P24:P26").Value = room
            ElseIf time_end = "2020-02-14 18:00:00" Then
                worksheet.Range("N24:N28").Merge()
                worksheet.Range("O24:O28").Merge()
                worksheet.Range("P24:P28").Merge()
                worksheet.Range("N24:N28").Value = subject
                worksheet.Range("O24:O28").Value = section
                worksheet.Range("P24:P28").Value = room
            End If
        End If
    End Sub

    'Row5
    Private Sub CheckDateToInsertRow5()
        Dim id As String = choose_expo.SelectedValue
        Dim s As String = "select prof_details_tbl.`FName_prof`, 
    prof_details_tbl.`MName_prof`, 
    prof_details_tbl.`LName_prof`,
    subjects_tbl.subject_Name, 
    `schedule_tbl`.strandName, 
    `schedule_tbl`.grade_lvl, 
    `schedule_tbl`.section_no, `schedule_tbl`.building_no, 
    `schedule_tbl`.room_no,
schedule_tbl.time_start, 
schedule_tbl.time_end from prof_details_tbl ,schedule_tbl inner join subjects_tbl on schedule_tbl.subject = subjects_tbl.snn
    where prof_details_tbl.ID_Prof='" + id + "' and `schedule_tbl`.`id_Prof`='" + id + "' and sy='" + print_sy.Text + "' and semestral_sche='" + print_sem.Text + "'"
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)
        Dim row5 As DataRow = tb.Rows(4)
        Dim subject As String = row5(3)
        Dim section As String = row5(4) + " " + row5(5) + "-" + row5(6)
        Dim room As String = row5(7) + " " + row5(8)
        time_start = row5(9)
        time_end = row5(10)
        'Monday start
        If time_start = "2020-02-10 06:00:00" Then
            If time_end = "2020-02-10 07:00:00" Then
                worksheet.Range("B4:B6").Merge()
                worksheet.Range("C4:C6").Merge()
                worksheet.Range("D4:D6").Merge()
                worksheet.Range("B4:B6").Value = subject
                worksheet.Range("C4:C6").Value = section
                worksheet.Range("D4:D6").Value = room
            ElseIf time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B4:B8").Merge()
                worksheet.Range("C4:C8").Merge()
                worksheet.Range("D4:D8").Merge()
                worksheet.Range("B4:B8").Value = subject
                worksheet.Range("C4:C8").Value = section
                worksheet.Range("D4:D8").Value = room
            End If
        ElseIf time_start = "2020-02-10 06:30:00" Then

            If time_end = "2020-02-10 07:30:00" Then
                worksheet.Range("B5:B7").Merge()
                worksheet.Range("C5:C7").Merge()
                worksheet.Range("D5:D7").Merge()
                worksheet.Range("B5:B7").Value = subject
                worksheet.Range("C5:C7").Value = section
                worksheet.Range("D5:D7").Value = room
            ElseIf time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B5:B9").Merge()
                worksheet.Range("C5:C9").Merge()
                worksheet.Range("D5:D9").Merge()
                worksheet.Range("B5:B9").Value = subject
                worksheet.Range("C5:C9").Value = section
            End If
            worksheet.Range("D5:D9").Value = room
        ElseIf time_start = "2020-02-10 07:00:00" Then
            If time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B6:B8").Merge()
                worksheet.Range("C6:C8").Merge()
                worksheet.Range("D6:D8").Merge()
                worksheet.Range("B6:B8").Value = subject
                worksheet.Range("C6:C8").Value = section
                worksheet.Range("D6:D8").Value = room
            ElseIf time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B6:B10").Merge()
                worksheet.Range("C6:C10").Merge()
                worksheet.Range("D6:D10").Merge()
                worksheet.Range("B6:B10").Value = subject
                worksheet.Range("C6:C10").Value = section
                worksheet.Range("D6:D10").Value = room
            End If
        ElseIf time_start = "2020-02-10 07:30:00" Then
            If time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B7:B9").Merge()
                worksheet.Range("C7:C9").Merge()
                worksheet.Range("D7:D9").Merge()
                worksheet.Range("B7:B9").Value = subject
                worksheet.Range("C7:C9").Value = section
                worksheet.Range("D7:D9").Value = room
            ElseIf time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B7:B11").Merge()
                worksheet.Range("C7:C11").Merge()
                worksheet.Range("D7:D11").Merge()
                worksheet.Range("B7:B11").Value = subject
                worksheet.Range("C7:C11").Value = section
                worksheet.Range("D7:D11").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:00:00" Then
            If time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B8:B10").Merge()
                worksheet.Range("C8:C10").Merge()
                worksheet.Range("D8:D10").Merge()
                worksheet.Range("B8:B10").Value = subject
                worksheet.Range("C8:C10").Value = section
                worksheet.Range("D8:D10").Value = room
            ElseIf time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B8:B12").Merge()
                worksheet.Range("C8:C12").Merge()
                worksheet.Range("D8:D12").Merge()
                worksheet.Range("B8:B12").Value = subject
                worksheet.Range("C8:C12").Value = section
                worksheet.Range("D8:D12").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:30:00" Then
            If time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B9:B11").Merge()
                worksheet.Range("C9:C11").Merge()
                worksheet.Range("D9:D11").Merge()
                worksheet.Range("B9:B11").Value = subject
                worksheet.Range("C9:C11").Value = section
                worksheet.Range("D9:D11").Value = room
            ElseIf time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B6:B13").Merge()
                worksheet.Range("C9:C13").Merge()
                worksheet.Range("D9:D13").Merge()
                worksheet.Range("B9:B13").Value = subject
                worksheet.Range("C9:C13").Value = section
                worksheet.Range("D9:D13").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:00:00" Then
            If time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B10:B12").Merge()
                worksheet.Range("C10:C12").Merge()
                worksheet.Range("D10:D12").Merge()
                worksheet.Range("B10:B12").Value = subject
                worksheet.Range("C10:C12").Value = section
                worksheet.Range("D10:D12").Value = room
            ElseIf time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B10:B14").Merge()
                worksheet.Range("C10:C14").Merge()
                worksheet.Range("D10:D14").Merge()
                worksheet.Range("B10:B14").Value = subject
                worksheet.Range("C10:C14").Value = section
                worksheet.Range("D10:D14").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:30:00" Then
            If time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B11:B13").Merge()
                worksheet.Range("C11:C13").Merge()
                worksheet.Range("D11:D13").Merge()
                worksheet.Range("B11:B13").Value = subject
                worksheet.Range("C11:C13").Value = section
                worksheet.Range("D11:D13").Value = room
            ElseIf time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B11:B15").Merge()
                worksheet.Range("C11:C15").Merge()
                worksheet.Range("D11:D15").Merge()
                worksheet.Range("B11:B15").Value = subject
                worksheet.Range("C11:C15").Value = section
                worksheet.Range("D11:D15").Value = room
            End If
        ElseIf time_start = "2020-02-10 10:00:00" Then
            If time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B12:B14").Merge()
                worksheet.Range("C12:C14").Merge()
                worksheet.Range("D12:D14").Merge()
                worksheet.Range("B12:B14").Value = subject
                worksheet.Range("C12:C14").Value = section
                worksheet.Range("D12:D14").Value = room

            ElseIf time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B12:B16").Merge()
                worksheet.Range("C12:C16").Merge()
                worksheet.Range("D12:D16").Merge()
                worksheet.Range("B12:B16").Value = subject
                worksheet.Range("C12:C16").Value = section
                worksheet.Range("D12:D16").Value = room

            End If
        End If
        If time_start = "2020-02-10 10:30:00" Then
            If time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B13:B15").Merge()
                worksheet.Range("C13:C15").Merge()
                worksheet.Range("D13:D15").Merge()
                worksheet.Range("B13:B15").Value = subject
                worksheet.Range("C13:C15").Value = section
                worksheet.Range("D13:D15").Value = room
            ElseIf time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B13:B17").Merge()
                worksheet.Range("C13:C17").Merge()
                worksheet.Range("D13:D17").Merge()
                worksheet.Range("B13:B17").Value = subject
                worksheet.Range("C13:C17").Value = section
                worksheet.Range("D13:D17").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:00:00" Then
            If time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B14:B16").Merge()
                worksheet.Range("C14:C16").Merge()
                worksheet.Range("D14:D16").Merge()
                worksheet.Range("B14:B16").Value = subject
                worksheet.Range("C14:C16").Value = section
                worksheet.Range("D14:D16").Value = room
            ElseIf time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B14:B18").Merge()
                worksheet.Range("C14:C18").Merge()
                worksheet.Range("D14:D18").Merge()
                worksheet.Range("B14:B18").Value = subject
                worksheet.Range("C14:C18").Value = section
                worksheet.Range("D14:D18").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:30:00" Then
            If time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B15:B17").Merge()
                worksheet.Range("C15:C17").Merge()
                worksheet.Range("D15:D17").Merge()
                worksheet.Range("B15:B17").Value = subject
                worksheet.Range("C15:C17").Value = section
                worksheet.Range("D15:D17").Value = room
            ElseIf time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B15:B19").Merge()
                worksheet.Range("C15:C19").Merge()
                worksheet.Range("D15:D19").Merge()
                worksheet.Range("B15:B19").Value = subject
                worksheet.Range("C15:C19").Value = section
                worksheet.Range("D15:D19").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:00:00" Then
            If time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B16:B14").Merge()
                worksheet.Range("C16:C18").Merge()
                worksheet.Range("D16:D18").Merge()
                worksheet.Range("B16:B18").Value = subject
                worksheet.Range("C16:C18").Value = section
                worksheet.Range("D16:D18").Value = room
            ElseIf time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B16:B20").Merge()
                worksheet.Range("C16:C20").Merge()
                worksheet.Range("D16:D20").Merge()
                worksheet.Range("B16:B20").Value = subject
                worksheet.Range("C16:C20").Value = section
                worksheet.Range("D16:D20").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:30:00" Then
            If time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B17:B19").Merge()
                worksheet.Range("C17:C19").Merge()
                worksheet.Range("D17:D19").Merge()
                worksheet.Range("B17:B19").Value = subject
                worksheet.Range("C17:C19").Value = section
                worksheet.Range("D17:D19").Value = room
            ElseIf time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B17:B21").Merge()
                worksheet.Range("C17:C21").Merge()
                worksheet.Range("D17:D21").Merge()
                worksheet.Range("B17:B21").Value = subject
                worksheet.Range("C17:C21").Value = section
                worksheet.Range("D17:D21").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:00:00" Then
            If time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B18:B20").Merge()
                worksheet.Range("C18:C20").Merge()
                worksheet.Range("D18:D20").Merge()
                worksheet.Range("B18:B20").Value = subject
                worksheet.Range("C18:C20").Value = section
                worksheet.Range("D18:D20").Value = room
            ElseIf time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B18:B22").Merge()
                worksheet.Range("C18:C22").Merge()
                worksheet.Range("D18:D22").Merge()
                worksheet.Range("B18:B22").Value = subject
                worksheet.Range("C18:C22").Value = section
                worksheet.Range("D18:D22").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:30:00" Then
            If time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B19:B21").Merge()
                worksheet.Range("C19:C21").Merge()
                worksheet.Range("D19:D21").Merge()
                worksheet.Range("B19:B21").Value = subject
                worksheet.Range("C19:C21").Value = section
                worksheet.Range("D19:D21").Value = room
            ElseIf time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B19:B23").Merge()
                worksheet.Range("C19:C23").Merge()
                worksheet.Range("D19:D23").Merge()
                worksheet.Range("B19:B23").Value = subject
                worksheet.Range("C19:C23").Value = section
                worksheet.Range("D19:D23").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:00:00" Then
            If time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B20:B22").Merge()
                worksheet.Range("C20:C22").Merge()
                worksheet.Range("D20:D22").Merge()
                worksheet.Range("B20:B22").Value = subject
                worksheet.Range("C20:C22").Value = section
                worksheet.Range("D20:D22").Value = room
            ElseIf time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B20:B24").Merge()
                worksheet.Range("C20:C24").Merge()
                worksheet.Range("D20:D24").Merge()
                worksheet.Range("B20:B24").Value = subject
                worksheet.Range("C20:C24").Value = section
                worksheet.Range("D20:D24").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:30:00" Then
            If time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B21:B23").Merge()
                worksheet.Range("C21:C23").Merge()
                worksheet.Range("D21:D23").Merge()
                worksheet.Range("B21:B23").Value = subject
                worksheet.Range("C21:C23").Value = section
                worksheet.Range("D21:D23").Value = room
            ElseIf time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B21:B25").Merge()
                worksheet.Range("C21:C25").Merge()
                worksheet.Range("D21:D25").Merge()
                worksheet.Range("B21:B25").Value = subject
                worksheet.Range("C21:C25").Value = section
                worksheet.Range("D21:D25").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:00:00" Then
            If time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B22:B24").Merge()
                worksheet.Range("C22:C24").Merge()
                worksheet.Range("D22:D24").Merge()
                worksheet.Range("B22:B24").Value = subject
                worksheet.Range("C22:C24").Value = section
                worksheet.Range("D22:D24").Value = room
            ElseIf time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B22:B26").Merge()
                worksheet.Range("C22:C26").Merge()
                worksheet.Range("D22:D26").Merge()
                worksheet.Range("B22:B26").Value = subject
                worksheet.Range("C22:C26").Value = section
                worksheet.Range("D22:D26").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:30:00" Then
            If time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B23:B25").Merge()
                worksheet.Range("C23:C25").Merge()
                worksheet.Range("D23:D25").Merge()
                worksheet.Range("B23:B25").Value = subject
                worksheet.Range("C23:C25").Value = section
                worksheet.Range("D23:D25").Value = room
            ElseIf time_end = "2020-02-10 17:30:00" Then
                worksheet.Range("B23:B27").Merge()
                worksheet.Range("C23:C27").Merge()
                worksheet.Range("D23:D27").Merge()
                worksheet.Range("B23:B27").Value = subject
                worksheet.Range("C23:C27").Value = section
                worksheet.Range("D23:D27").Value = room
            End If
        End If
        If time_start = "2020-02-10 16:00:00" Then
            If time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B24:B26").Merge()
                worksheet.Range("C24:C26").Merge()
                worksheet.Range("D24:D26").Merge()
                worksheet.Range("B24:B26").Value = subject
                worksheet.Range("C24:C26").Value = section
                worksheet.Range("D24:D26").Value = room
            ElseIf time_end = "2020-02-10 18:00:00" Then
                worksheet.Range("B24:B28").Merge()
                worksheet.Range("C24:C28").Merge()
                worksheet.Range("D24:D28").Merge()
                worksheet.Range("B24:B28").Value = subject
                worksheet.Range("C24:C28").Value = section
                worksheet.Range("D24:D28").Value = room
            End If
        End If



        'tuesday start-----------------------------------------------


        If time_start = "2020-02-11 06:00:00" Then
            If time_end = "2020-02-11 07:00:00" Then
                worksheet.Range("E4:E6").Merge()
                worksheet.Range("F4:F6").Merge()
                worksheet.Range("G4:G6").Merge()
                worksheet.Range("E4:E6").Value = subject
                worksheet.Range("F4:F6").Value = section
                worksheet.Range("G4:G6").Value = room
            ElseIf time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E4:E8").Merge()
                worksheet.Range("F4:F8").Merge()
                worksheet.Range("G4:G8").Merge()
                worksheet.Range("E4:E8").Value = subject
                worksheet.Range("F4:F8").Value = section
                worksheet.Range("G4:G8").Value = room
            End If
        ElseIf time_start = "2020-02-11 06:30:00" Then

            If time_end = "2020-02-11 07:30:00" Then
                worksheet.Range("E5:E7").Merge()
                worksheet.Range("F5:F7").Merge()
                worksheet.Range("G5:G7").Merge()
                worksheet.Range("E5:E7").Value = subject
                worksheet.Range("F5:F7").Value = section
                worksheet.Range("G5:G7").Value = room
            ElseIf time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E5:E9").Merge()
                worksheet.Range("F5:F9").Merge()
                worksheet.Range("G5:G9").Merge()
                worksheet.Range("E5:E9").Value = subject
                worksheet.Range("F5:F9").Value = section
            End If
            worksheet.Range("G5:G9").Value = room
        ElseIf time_start = "2020-02-11 07:00:00" Then
            If time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E6:E8").Merge()
                worksheet.Range("F6:F8").Merge()
                worksheet.Range("G6:G8").Merge()
                worksheet.Range("E6:E8").Value = subject
                worksheet.Range("F6:F8").Value = section
                worksheet.Range("G6:G8").Value = room
            ElseIf time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E6:E10").Merge()
                worksheet.Range("F6:F10").Merge()
                worksheet.Range("G6:G10").Merge()
                worksheet.Range("E6:E10").Value = subject
                worksheet.Range("F6:F10").Value = section
                worksheet.Range("G6:G10").Value = room
            End If
        ElseIf time_start = "2020-02-11 07:30:00" Then
            If time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E7:E9").Merge()
                worksheet.Range("F7:F9").Merge()
                worksheet.Range("G7:G9").Merge()
                worksheet.Range("E7:E9").Value = subject
                worksheet.Range("F7:F9").Value = section
                worksheet.Range("G7:G9").Value = room
            ElseIf time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E7:E11").Merge()
                worksheet.Range("F7:F11").Merge()
                worksheet.Range("G7:G11").Merge()
                worksheet.Range("E7:E11").Value = subject
                worksheet.Range("F7:F11").Value = section
                worksheet.Range("G7:G11").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:00:00" Then
            If time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E8:E10").Merge()
                worksheet.Range("F8:F10").Merge()
                worksheet.Range("G8:G10").Merge()
                worksheet.Range("E8:E10").Value = subject
                worksheet.Range("F8:F10").Value = section
                worksheet.Range("G8:G10").Value = room
            ElseIf time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E8:E12").Merge()
                worksheet.Range("F8:F12").Merge()
                worksheet.Range("G8:G12").Merge()
                worksheet.Range("E8:E12").Value = subject
                worksheet.Range("F8:F12").Value = section
                worksheet.Range("G8:G12").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:30:00" Then
            If time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E9:E11").Merge()
                worksheet.Range("F9:F11").Merge()
                worksheet.Range("G9:G11").Merge()
                worksheet.Range("E9:E11").Value = subject
                worksheet.Range("F9:F11").Value = section
                worksheet.Range("G9:G11").Value = room
            ElseIf time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E6:E13").Merge()
                worksheet.Range("F9:F13").Merge()
                worksheet.Range("G9:G13").Merge()
                worksheet.Range("E9:E13").Value = subject
                worksheet.Range("F9:F13").Value = section
                worksheet.Range("G9:G13").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:00:00" Then
            If time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E10:E12").Merge()
                worksheet.Range("F10:F12").Merge()
                worksheet.Range("G10:G12").Merge()
                worksheet.Range("E10:E12").Value = subject
                worksheet.Range("F10:F12").Value = section
                worksheet.Range("G10:G12").Value = room
            ElseIf time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E10:E14").Merge()
                worksheet.Range("F10:F14").Merge()
                worksheet.Range("G10:G14").Merge()
                worksheet.Range("E10:E14").Value = subject
                worksheet.Range("F10:F14").Value = section
                worksheet.Range("G10:G14").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:30:00" Then
            If time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E11:E13").Merge()
                worksheet.Range("F11:F13").Merge()
                worksheet.Range("G11:G13").Merge()
                worksheet.Range("E11:E13").Value = subject
                worksheet.Range("F11:F13").Value = section
                worksheet.Range("G11:G13").Value = room
            ElseIf time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E11:E15").Merge()
                worksheet.Range("F11:F15").Merge()
                worksheet.Range("G11:G15").Merge()
                worksheet.Range("E11:E15").Value = subject
                worksheet.Range("F11:F15").Value = section
                worksheet.Range("G11:G15").Value = room
            End If
        ElseIf time_start = "2020-02-11 10:00:00" Then
            If time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E12:E14").Merge()
                worksheet.Range("F12:F14").Merge()
                worksheet.Range("G12:G14").Merge()
                worksheet.Range("E12:E14").Value = subject
                worksheet.Range("F12:F14").Value = section
                worksheet.Range("G12:G14").Value = room

            ElseIf time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E12:E16").Merge()
                worksheet.Range("F12:F16").Merge()
                worksheet.Range("G12:G16").Merge()
                worksheet.Range("E12:E16").Value = subject
                worksheet.Range("F12:F16").Value = section
                worksheet.Range("G12:G16").Value = room

            End If
        End If
        If time_start = "2020-02-11 10:30:00" Then
            If time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E13:E15").Merge()
                worksheet.Range("F13:F15").Merge()
                worksheet.Range("G13:G15").Merge()
                worksheet.Range("E13:E15").Value = subject
                worksheet.Range("F13:F15").Value = section
                worksheet.Range("G13:G15").Value = room
            ElseIf time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E13:E17").Merge()
                worksheet.Range("F13:F17").Merge()
                worksheet.Range("G13:G17").Merge()
                worksheet.Range("E13:E17").Value = subject
                worksheet.Range("F13:F17").Value = section
                worksheet.Range("G13:G17").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:00:00" Then
            If time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E14:E16").Merge()
                worksheet.Range("F14:F16").Merge()
                worksheet.Range("G14:G16").Merge()
                worksheet.Range("E14:E16").Value = subject
                worksheet.Range("F14:F16").Value = section
                worksheet.Range("G14:G16").Value = room
            ElseIf time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E14:E18").Merge()
                worksheet.Range("F14:F18").Merge()
                worksheet.Range("G14:G18").Merge()
                worksheet.Range("E14:E18").Value = subject
                worksheet.Range("F14:F18").Value = section
                worksheet.Range("G14:G18").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:30:00" Then
            If time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E15:E17").Merge()
                worksheet.Range("F15:F17").Merge()
                worksheet.Range("G15:G17").Merge()
                worksheet.Range("E15:E17").Value = subject
                worksheet.Range("F15:F17").Value = section
                worksheet.Range("G15:G17").Value = room
            ElseIf time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E15:E19").Merge()
                worksheet.Range("F15:F19").Merge()
                worksheet.Range("G15:G19").Merge()
                worksheet.Range("E15:E19").Value = subject
                worksheet.Range("F15:F19").Value = section
                worksheet.Range("G15:G19").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:00:00" Then
            If time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E16:E14").Merge()
                worksheet.Range("F16:F18").Merge()
                worksheet.Range("G16:G18").Merge()
                worksheet.Range("E16:E18").Value = subject
                worksheet.Range("F16:F18").Value = section
                worksheet.Range("G16:G18").Value = room
            ElseIf time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E16:E20").Merge()
                worksheet.Range("F16:F20").Merge()
                worksheet.Range("G16:G20").Merge()
                worksheet.Range("E16:E20").Value = subject
                worksheet.Range("F16:F20").Value = section
                worksheet.Range("G16:G20").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:30:00" Then
            If time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E17:E19").Merge()
                worksheet.Range("F17:F19").Merge()
                worksheet.Range("G17:G19").Merge()
                worksheet.Range("E17:E19").Value = subject
                worksheet.Range("F17:F19").Value = section
                worksheet.Range("G17:G19").Value = room
            ElseIf time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E17:E21").Merge()
                worksheet.Range("F17:F21").Merge()
                worksheet.Range("G17:G21").Merge()
                worksheet.Range("E17:E21").Value = subject
                worksheet.Range("F17:F21").Value = section
                worksheet.Range("G17:G21").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:00:00" Then
            If time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E18:E20").Merge()
                worksheet.Range("F18:F20").Merge()
                worksheet.Range("G18:G20").Merge()
                worksheet.Range("E18:E20").Value = subject
                worksheet.Range("F18:F20").Value = section
                worksheet.Range("G18:G20").Value = room
            ElseIf time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E18:E22").Merge()
                worksheet.Range("F18:F22").Merge()
                worksheet.Range("G18:G22").Merge()
                worksheet.Range("E18:E22").Value = subject
                worksheet.Range("F18:F22").Value = section
                worksheet.Range("G18:G22").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:30:00" Then
            If time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E19:E21").Merge()
                worksheet.Range("F19:F21").Merge()
                worksheet.Range("G19:G21").Merge()
                worksheet.Range("E19:E21").Value = subject
                worksheet.Range("F19:F21").Value = section
                worksheet.Range("G19:G21").Value = room
            ElseIf time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E19:E23").Merge()
                worksheet.Range("F19:F23").Merge()
                worksheet.Range("G19:G23").Merge()
                worksheet.Range("E19:E23").Value = subject
                worksheet.Range("F19:F23").Value = section
                worksheet.Range("G19:G23").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:00:00" Then
            If time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E20:E22").Merge()
                worksheet.Range("F20:F22").Merge()
                worksheet.Range("G20:G22").Merge()
                worksheet.Range("E20:E22").Value = subject
                worksheet.Range("F20:F22").Value = section
                worksheet.Range("G20:G22").Value = room
            ElseIf time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E20:E24").Merge()
                worksheet.Range("F20:F24").Merge()
                worksheet.Range("G20:G24").Merge()
                worksheet.Range("E20:E24").Value = subject
                worksheet.Range("F20:F24").Value = section
                worksheet.Range("G20:G24").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:30:00" Then
            If time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E21:E23").Merge()
                worksheet.Range("F21:F23").Merge()
                worksheet.Range("G21:G23").Merge()
                worksheet.Range("E21:E23").Value = subject
                worksheet.Range("F21:F23").Value = section
                worksheet.Range("G21:G23").Value = room
            ElseIf time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E21:E25").Merge()
                worksheet.Range("F21:F25").Merge()
                worksheet.Range("G21:G25").Merge()
                worksheet.Range("E21:E25").Value = subject
                worksheet.Range("F21:F25").Value = section
                worksheet.Range("G21:G25").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:00:00" Then
            If time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E22:E24").Merge()
                worksheet.Range("F22:F24").Merge()
                worksheet.Range("G22:G24").Merge()
                worksheet.Range("E22:E24").Value = subject
                worksheet.Range("F22:F24").Value = section
                worksheet.Range("G22:G24").Value = room
            ElseIf time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E22:E26").Merge()
                worksheet.Range("F22:F26").Merge()
                worksheet.Range("G22:G26").Merge()
                worksheet.Range("E22:E26").Value = subject
                worksheet.Range("F22:F26").Value = section
                worksheet.Range("G22:G26").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:30:00" Then
            If time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E23:E25").Merge()
                worksheet.Range("F23:F25").Merge()
                worksheet.Range("G23:G25").Merge()
                worksheet.Range("E23:E25").Value = subject
                worksheet.Range("F23:F25").Value = section
                worksheet.Range("G23:G25").Value = room
            ElseIf time_end = "2020-02-11 17:30:00" Then
                worksheet.Range("E23:E27").Merge()
                worksheet.Range("F23:F27").Merge()
                worksheet.Range("G23:G27").Merge()
                worksheet.Range("E23:E27").Value = subject
                worksheet.Range("F23:F27").Value = section
                worksheet.Range("G23:G27").Value = room
            End If
        End If
        If time_start = "2020-02-11 16:00:00" Then
            If time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E24:E26").Merge()
                worksheet.Range("F24:F26").Merge()
                worksheet.Range("G24:G26").Merge()
                worksheet.Range("E24:E26").Value = subject
                worksheet.Range("F24:F26").Value = section
                worksheet.Range("G24:G26").Value = room
            ElseIf time_end = "2020-02-11 18:00:00" Then
                worksheet.Range("E24:E28").Merge()
                worksheet.Range("F24:F28").Merge()
                worksheet.Range("G24:G28").Merge()
                worksheet.Range("E24:E28").Value = subject
                worksheet.Range("F24:F28").Value = section
                worksheet.Range("G24:G28").Value = room
            End If
        End If


        ' wednesday


        If time_start = "2020-02-12 06:00:00" Then
            If time_end = "2020-02-12 07:00:00" Then
                worksheet.Range("H4:H6").Merge()
                worksheet.Range("I4:I6").Merge()
                worksheet.Range("J4:J6").Merge()
                worksheet.Range("H4:H6").Value = subject
                worksheet.Range("I4:I6").Value = section
                worksheet.Range("J4:J6").Value = room
            ElseIf time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H4:H8").Merge()
                worksheet.Range("I4:I8").Merge()
                worksheet.Range("J4:J8").Merge()
                worksheet.Range("H4:H8").Value = subject
                worksheet.Range("I4:I8").Value = section
                worksheet.Range("J4:J8").Value = room
            End If
        ElseIf time_start = "2020-02-12 06:30:00" Then

            If time_end = "2020-02-12 07:30:00" Then
                worksheet.Range("H5:H7").Merge()
                worksheet.Range("I5:I7").Merge()
                worksheet.Range("J5:J7").Merge()
                worksheet.Range("H5:H7").Value = subject
                worksheet.Range("I5:I7").Value = section
                worksheet.Range("J5:J7").Value = room
            ElseIf time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H5:H9").Merge()
                worksheet.Range("I5:I9").Merge()
                worksheet.Range("J5:J9").Merge()
                worksheet.Range("H5:H9").Value = subject
                worksheet.Range("I5:I9").Value = section
            End If
            worksheet.Range("J5:J9").Value = room
        ElseIf time_start = "2020-02-12 07:00:00" Then
            If time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H6:H8").Merge()
                worksheet.Range("I6:I8").Merge()
                worksheet.Range("J6:J8").Merge()
                worksheet.Range("H6:H8").Value = subject
                worksheet.Range("I6:I8").Value = section
                worksheet.Range("J6:J8").Value = room
            ElseIf time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H6:H10").Merge()
                worksheet.Range("I6:I10").Merge()
                worksheet.Range("J6:J10").Merge()
                worksheet.Range("H6:H10").Value = subject
                worksheet.Range("I6:I10").Value = section
                worksheet.Range("J6:J10").Value = room
            End If
        ElseIf time_start = "2020-02-12 07:30:00" Then
            If time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H7:H9").Merge()
                worksheet.Range("I7:I9").Merge()
                worksheet.Range("J7:J9").Merge()
                worksheet.Range("H7:H9").Value = subject
                worksheet.Range("I7:I9").Value = section
                worksheet.Range("J7:J9").Value = room
            ElseIf time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H7:H11").Merge()
                worksheet.Range("I7:I11").Merge()
                worksheet.Range("J7:J11").Merge()
                worksheet.Range("H7:H11").Value = subject
                worksheet.Range("I7:I11").Value = section
                worksheet.Range("J7:J11").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:00:00" Then
            If time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H8:H10").Merge()
                worksheet.Range("I8:I10").Merge()
                worksheet.Range("J8:J10").Merge()
                worksheet.Range("H8:H10").Value = subject
                worksheet.Range("I8:I10").Value = section
                worksheet.Range("J8:J10").Value = room
            ElseIf time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H8:H12").Merge()
                worksheet.Range("I8:I12").Merge()
                worksheet.Range("J8:J12").Merge()
                worksheet.Range("H8:H12").Value = subject
                worksheet.Range("I8:I12").Value = section
                worksheet.Range("J8:J12").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:30:00" Then
            If time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H9:H11").Merge()
                worksheet.Range("I9:I11").Merge()
                worksheet.Range("J9:J11").Merge()
                worksheet.Range("H9:H11").Value = subject
                worksheet.Range("I9:I11").Value = section
                worksheet.Range("J9:J11").Value = room
            ElseIf time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H6:H13").Merge()
                worksheet.Range("I9:I13").Merge()
                worksheet.Range("J9:J13").Merge()
                worksheet.Range("H9:H13").Value = subject
                worksheet.Range("I9:I13").Value = section
                worksheet.Range("J9:J13").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:00:00" Then
            If time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H10:H12").Merge()
                worksheet.Range("I10:I12").Merge()
                worksheet.Range("J10:J12").Merge()
                worksheet.Range("H10:H12").Value = subject
                worksheet.Range("I10:I12").Value = section
                worksheet.Range("J10:J12").Value = room
            ElseIf time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H10:H14").Merge()
                worksheet.Range("I10:I14").Merge()
                worksheet.Range("J10:J14").Merge()
                worksheet.Range("H10:H14").Value = subject
                worksheet.Range("I10:I14").Value = section
                worksheet.Range("J10:J14").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:30:00" Then
            If time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H11:H13").Merge()
                worksheet.Range("I11:I13").Merge()
                worksheet.Range("J11:J13").Merge()
                worksheet.Range("H11:H13").Value = subject
                worksheet.Range("I11:I13").Value = section
                worksheet.Range("J11:J13").Value = room
            ElseIf time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H11:H15").Merge()
                worksheet.Range("I11:I15").Merge()
                worksheet.Range("J11:J15").Merge()
                worksheet.Range("H11:H15").Value = subject
                worksheet.Range("I11:I15").Value = section
                worksheet.Range("J11:J15").Value = room
            End If
        ElseIf time_start = "2020-02-12 10:00:00" Then
            If time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H12:H14").Merge()
                worksheet.Range("I12:I14").Merge()
                worksheet.Range("J12:J14").Merge()
                worksheet.Range("H12:H14").Value = subject
                worksheet.Range("I12:I14").Value = section
                worksheet.Range("J12:J14").Value = room

            ElseIf time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H12:H16").Merge()
                worksheet.Range("I12:I16").Merge()
                worksheet.Range("J12:J16").Merge()
                worksheet.Range("H12:H16").Value = subject
                worksheet.Range("I12:I16").Value = section
                worksheet.Range("J12:J16").Value = room

            End If
        End If
        If time_start = "2020-02-12 10:30:00" Then
            If time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H13:H15").Merge()
                worksheet.Range("I13:I15").Merge()
                worksheet.Range("J13:J15").Merge()
                worksheet.Range("H13:H15").Value = subject
                worksheet.Range("I13:I15").Value = section
                worksheet.Range("J13:J15").Value = room
            ElseIf time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H13:H17").Merge()
                worksheet.Range("I13:I17").Merge()
                worksheet.Range("J13:J17").Merge()
                worksheet.Range("H13:H17").Value = subject
                worksheet.Range("I13:I17").Value = section
                worksheet.Range("J13:J17").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:00:00" Then
            If time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H14:H16").Merge()
                worksheet.Range("I14:I16").Merge()
                worksheet.Range("J14:J16").Merge()
                worksheet.Range("H14:H16").Value = subject
                worksheet.Range("I14:I16").Value = section
                worksheet.Range("J14:J16").Value = room
            ElseIf time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H14:H18").Merge()
                worksheet.Range("I14:I18").Merge()
                worksheet.Range("J14:J18").Merge()
                worksheet.Range("H14:H18").Value = subject
                worksheet.Range("I14:I18").Value = section
                worksheet.Range("J14:J18").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:30:00" Then
            If time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H15:H17").Merge()
                worksheet.Range("I15:I17").Merge()
                worksheet.Range("J15:J17").Merge()
                worksheet.Range("H15:H17").Value = subject
                worksheet.Range("I15:I17").Value = section
                worksheet.Range("J15:J17").Value = room
            ElseIf time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H15:H19").Merge()
                worksheet.Range("I15:I19").Merge()
                worksheet.Range("J15:J19").Merge()
                worksheet.Range("H15:H19").Value = subject
                worksheet.Range("I15:I19").Value = section
                worksheet.Range("J15:J19").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:00:00" Then
            If time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H16:H14").Merge()
                worksheet.Range("I16:I18").Merge()
                worksheet.Range("J16:J18").Merge()
                worksheet.Range("H16:H18").Value = subject
                worksheet.Range("I16:I18").Value = section
                worksheet.Range("J16:J18").Value = room
            ElseIf time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H16:H20").Merge()
                worksheet.Range("I16:I20").Merge()
                worksheet.Range("J16:J20").Merge()
                worksheet.Range("H16:H20").Value = subject
                worksheet.Range("I16:I20").Value = section
                worksheet.Range("J16:J20").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:30:00" Then
            If time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H17:H19").Merge()
                worksheet.Range("I17:I19").Merge()
                worksheet.Range("J17:J19").Merge()
                worksheet.Range("H17:H19").Value = subject
                worksheet.Range("I17:I19").Value = section
                worksheet.Range("J17:J19").Value = room
            ElseIf time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H17:H21").Merge()
                worksheet.Range("I17:I21").Merge()
                worksheet.Range("J17:J21").Merge()
                worksheet.Range("H17:H21").Value = subject
                worksheet.Range("I17:I21").Value = section
                worksheet.Range("J17:J21").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:00:00" Then
            If time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H18:H20").Merge()
                worksheet.Range("I18:I20").Merge()
                worksheet.Range("J18:J20").Merge()
                worksheet.Range("H18:H20").Value = subject
                worksheet.Range("I18:I20").Value = section
                worksheet.Range("J18:J20").Value = room
            ElseIf time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H18:H22").Merge()
                worksheet.Range("I18:I22").Merge()
                worksheet.Range("J18:J22").Merge()
                worksheet.Range("H18:H22").Value = subject
                worksheet.Range("I18:I22").Value = section
                worksheet.Range("J18:J22").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:30:00" Then
            If time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H19:H21").Merge()
                worksheet.Range("I19:I21").Merge()
                worksheet.Range("J19:J21").Merge()
                worksheet.Range("H19:H21").Value = subject
                worksheet.Range("I19:I21").Value = section
                worksheet.Range("J19:J21").Value = room
            ElseIf time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H19:H23").Merge()
                worksheet.Range("I19:I23").Merge()
                worksheet.Range("J19:J23").Merge()
                worksheet.Range("H19:H23").Value = subject
                worksheet.Range("I19:I23").Value = section
                worksheet.Range("J19:J23").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:00:00" Then
            If time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H20:H22").Merge()
                worksheet.Range("I20:I22").Merge()
                worksheet.Range("J20:J22").Merge()
                worksheet.Range("H20:H22").Value = subject
                worksheet.Range("I20:I22").Value = section
                worksheet.Range("J20:J22").Value = room
            ElseIf time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H20:H24").Merge()
                worksheet.Range("I20:I24").Merge()
                worksheet.Range("J20:J24").Merge()
                worksheet.Range("H20:H24").Value = subject
                worksheet.Range("I20:I24").Value = section
                worksheet.Range("J20:J24").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:30:00" Then
            If time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H21:H23").Merge()
                worksheet.Range("I21:I23").Merge()
                worksheet.Range("J21:J23").Merge()
                worksheet.Range("H21:H23").Value = subject
                worksheet.Range("I21:I23").Value = section
                worksheet.Range("J21:J23").Value = room
            ElseIf time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H21:H25").Merge()
                worksheet.Range("I21:I25").Merge()
                worksheet.Range("J21:J25").Merge()
                worksheet.Range("H21:H25").Value = subject
                worksheet.Range("I21:I25").Value = section
                worksheet.Range("J21:J25").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:00:00" Then
            If time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H22:H24").Merge()
                worksheet.Range("I22:I24").Merge()
                worksheet.Range("J22:J24").Merge()
                worksheet.Range("H22:H24").Value = subject
                worksheet.Range("I22:I24").Value = section
                worksheet.Range("J22:J24").Value = room
            ElseIf time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H22:H26").Merge()
                worksheet.Range("I22:I26").Merge()
                worksheet.Range("J22:J26").Merge()
                worksheet.Range("H22:H26").Value = subject
                worksheet.Range("I22:I26").Value = section
                worksheet.Range("J22:J26").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:30:00" Then
            If time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H23:H25").Merge()
                worksheet.Range("I23:I25").Merge()
                worksheet.Range("J23:J25").Merge()
                worksheet.Range("H23:H25").Value = subject
                worksheet.Range("I23:I25").Value = section
                worksheet.Range("J23:J25").Value = room
            ElseIf time_end = "2020-02-12 17:30:00" Then
                worksheet.Range("H23:H27").Merge()
                worksheet.Range("I23:I27").Merge()
                worksheet.Range("J23:J27").Merge()
                worksheet.Range("H23:H27").Value = subject
                worksheet.Range("I23:I27").Value = section
                worksheet.Range("J23:J27").Value = room
            End If
        End If
        If time_start = "2020-02-12 16:00:00" Then
            If time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H24:H26").Merge()
                worksheet.Range("I24:I26").Merge()
                worksheet.Range("J24:J26").Merge()
                worksheet.Range("H24:H26").Value = subject
                worksheet.Range("I24:I26").Value = section
                worksheet.Range("J24:J26").Value = room
            ElseIf time_end = "2020-02-12 18:00:00" Then
                worksheet.Range("H24:H28").Merge()
                worksheet.Range("I24:I28").Merge()
                worksheet.Range("J24:J28").Merge()
                worksheet.Range("H24:H28").Value = subject
                worksheet.Range("I24:I28").Value = section
                worksheet.Range("J24:J28").Value = room
            End If
        End If


        'Thursday

        If time_start = "2020-02-13 06:00:00" Then
            If time_end = "2020-02-13 07:00:00" Then
                worksheet.Range("K4:K6").Merge()
                worksheet.Range("L4:L6").Merge()
                worksheet.Range("M4:M6").Merge()
                worksheet.Range("K4:K6").Value = subject
                worksheet.Range("L4:L6").Value = section
                worksheet.Range("M4:M6").Value = room
            ElseIf time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K4:K8").Merge()
                worksheet.Range("L4:L8").Merge()
                worksheet.Range("M4:M8").Merge()
                worksheet.Range("K4:K8").Value = subject
                worksheet.Range("L4:L8").Value = section
                worksheet.Range("M4:M8").Value = room
            End If
        ElseIf time_start = "2020-02-13 06:30:00" Then

            If time_end = "2020-02-13 07:30:00" Then
                worksheet.Range("K5:K7").Merge()
                worksheet.Range("L5:L7").Merge()
                worksheet.Range("M5:M7").Merge()
                worksheet.Range("K5:K7").Value = subject
                worksheet.Range("L5:L7").Value = section
                worksheet.Range("M5:M7").Value = room
            ElseIf time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K5:K9").Merge()
                worksheet.Range("L5:L9").Merge()
                worksheet.Range("M5:M9").Merge()
                worksheet.Range("K5:K9").Value = subject
                worksheet.Range("L5:L9").Value = section
            End If
            worksheet.Range("M5:M9").Value = room
        ElseIf time_start = "2020-02-13 07:00:00" Then
            If time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K6:K8").Merge()
                worksheet.Range("L6:L8").Merge()
                worksheet.Range("M6:M8").Merge()
                worksheet.Range("K6:K8").Value = subject
                worksheet.Range("L6:L8").Value = section
                worksheet.Range("M6:M8").Value = room
            ElseIf time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K6:K10").Merge()
                worksheet.Range("L6:L10").Merge()
                worksheet.Range("M6:M10").Merge()
                worksheet.Range("K6:K10").Value = subject
                worksheet.Range("L6:L10").Value = section
                worksheet.Range("M6:M10").Value = room
            End If
        ElseIf time_start = "2020-02-13 07:30:00" Then
            If time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K7:K9").Merge()
                worksheet.Range("L7:L9").Merge()
                worksheet.Range("M7:M9").Merge()
                worksheet.Range("K7:K9").Value = subject
                worksheet.Range("L7:L9").Value = section
                worksheet.Range("M7:M9").Value = room
            ElseIf time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K7:K11").Merge()
                worksheet.Range("L7:L11").Merge()
                worksheet.Range("M7:M11").Merge()
                worksheet.Range("K7:K11").Value = subject
                worksheet.Range("L7:L11").Value = section
                worksheet.Range("M7:M11").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:00:00" Then
            If time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K8:K10").Merge()
                worksheet.Range("L8:L10").Merge()
                worksheet.Range("M8:M10").Merge()
                worksheet.Range("K8:K10").Value = subject
                worksheet.Range("L8:L10").Value = section
                worksheet.Range("M8:M10").Value = room
            ElseIf time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K8:K12").Merge()
                worksheet.Range("L8:L12").Merge()
                worksheet.Range("M8:M12").Merge()
                worksheet.Range("K8:K12").Value = subject
                worksheet.Range("L8:L12").Value = section
                worksheet.Range("M8:M12").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:30:00" Then
            If time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K9:K11").Merge()
                worksheet.Range("L9:L11").Merge()
                worksheet.Range("M9:M11").Merge()
                worksheet.Range("K9:K11").Value = subject
                worksheet.Range("L9:L11").Value = section
                worksheet.Range("M9:M11").Value = room
            ElseIf time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K6:K13").Merge()
                worksheet.Range("L9:L13").Merge()
                worksheet.Range("M9:M13").Merge()
                worksheet.Range("K9:K13").Value = subject
                worksheet.Range("L9:L13").Value = section
                worksheet.Range("M9:M13").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:00:00" Then
            If time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K10:K12").Merge()
                worksheet.Range("L10:L12").Merge()
                worksheet.Range("M10:M12").Merge()
                worksheet.Range("K10:K12").Value = subject
                worksheet.Range("L10:L12").Value = section
                worksheet.Range("M10:M12").Value = room
            ElseIf time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K10:K14").Merge()
                worksheet.Range("L10:L14").Merge()
                worksheet.Range("M10:M14").Merge()
                worksheet.Range("K10:K14").Value = subject
                worksheet.Range("L10:L14").Value = section
                worksheet.Range("M10:M14").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:30:00" Then
            If time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K11:K13").Merge()
                worksheet.Range("L11:L13").Merge()
                worksheet.Range("M11:M13").Merge()
                worksheet.Range("K11:K13").Value = subject
                worksheet.Range("L11:L13").Value = section
                worksheet.Range("M11:M13").Value = room
            ElseIf time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K11:K15").Merge()
                worksheet.Range("L11:L15").Merge()
                worksheet.Range("M11:M15").Merge()
                worksheet.Range("K11:K15").Value = subject
                worksheet.Range("L11:L15").Value = section
                worksheet.Range("M11:M15").Value = room
            End If
        ElseIf time_start = "2020-02-13 10:00:00" Then
            If time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K12:K14").Merge()
                worksheet.Range("L12:L14").Merge()
                worksheet.Range("M12:M14").Merge()
                worksheet.Range("K12:K14").Value = subject
                worksheet.Range("L12:L14").Value = section
                worksheet.Range("M12:M14").Value = room

            ElseIf time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K12:K16").Merge()
                worksheet.Range("L12:L16").Merge()
                worksheet.Range("M12:M16").Merge()
                worksheet.Range("K12:K16").Value = subject
                worksheet.Range("L12:L16").Value = section
                worksheet.Range("M12:M16").Value = room

            End If
        End If
        If time_start = "2020-02-13 10:30:00" Then
            If time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K13:K15").Merge()
                worksheet.Range("L13:L15").Merge()
                worksheet.Range("M13:M15").Merge()
                worksheet.Range("K13:K15").Value = subject
                worksheet.Range("L13:L15").Value = section
                worksheet.Range("M13:M15").Value = room
            ElseIf time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K13:K17").Merge()
                worksheet.Range("L13:L17").Merge()
                worksheet.Range("M13:M17").Merge()
                worksheet.Range("K13:K17").Value = subject
                worksheet.Range("L13:L17").Value = section
                worksheet.Range("M13:M17").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:00:00" Then
            If time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K14:K16").Merge()
                worksheet.Range("L14:L16").Merge()
                worksheet.Range("M14:M16").Merge()
                worksheet.Range("K14:K16").Value = subject
                worksheet.Range("L14:L16").Value = section
                worksheet.Range("M14:M16").Value = room
            ElseIf time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K14:K18").Merge()
                worksheet.Range("L14:L18").Merge()
                worksheet.Range("M14:M18").Merge()
                worksheet.Range("K14:K18").Value = subject
                worksheet.Range("L14:L18").Value = section
                worksheet.Range("M14:M18").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:30:00" Then
            If time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K15:K17").Merge()
                worksheet.Range("L15:L17").Merge()
                worksheet.Range("M15:M17").Merge()
                worksheet.Range("K15:K17").Value = subject
                worksheet.Range("L15:L17").Value = section
                worksheet.Range("M15:M17").Value = room
            ElseIf time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K15:K19").Merge()
                worksheet.Range("L15:L19").Merge()
                worksheet.Range("M15:M19").Merge()
                worksheet.Range("K15:K19").Value = subject
                worksheet.Range("L15:L19").Value = section
                worksheet.Range("M15:M19").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:00:00" Then
            If time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K16:K14").Merge()
                worksheet.Range("L16:L18").Merge()
                worksheet.Range("M16:M18").Merge()
                worksheet.Range("K16:K18").Value = subject
                worksheet.Range("L16:L18").Value = section
                worksheet.Range("M16:M18").Value = room
            ElseIf time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K16:K20").Merge()
                worksheet.Range("L16:L20").Merge()
                worksheet.Range("M16:M20").Merge()
                worksheet.Range("K16:K20").Value = subject
                worksheet.Range("L16:L20").Value = section
                worksheet.Range("M16:M20").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:30:00" Then
            If time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K17:K19").Merge()
                worksheet.Range("L17:L19").Merge()
                worksheet.Range("M17:M19").Merge()
                worksheet.Range("K17:K19").Value = subject
                worksheet.Range("L17:L19").Value = section
                worksheet.Range("M17:M19").Value = room
            ElseIf time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K17:K21").Merge()
                worksheet.Range("L17:L21").Merge()
                worksheet.Range("M17:M21").Merge()
                worksheet.Range("K17:K21").Value = subject
                worksheet.Range("L17:L21").Value = section
                worksheet.Range("M17:M21").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:00:00" Then
            If time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K18:K20").Merge()
                worksheet.Range("L18:L20").Merge()
                worksheet.Range("M18:M20").Merge()
                worksheet.Range("K18:K20").Value = subject
                worksheet.Range("L18:L20").Value = section
                worksheet.Range("M18:M20").Value = room
            ElseIf time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K18:K22").Merge()
                worksheet.Range("L18:L22").Merge()
                worksheet.Range("M18:M22").Merge()
                worksheet.Range("K18:K22").Value = subject
                worksheet.Range("L18:L22").Value = section
                worksheet.Range("M18:M22").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:30:00" Then
            If time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K19:K21").Merge()
                worksheet.Range("L19:L21").Merge()
                worksheet.Range("M19:M21").Merge()
                worksheet.Range("K19:K21").Value = subject
                worksheet.Range("L19:L21").Value = section
                worksheet.Range("M19:M21").Value = room
            ElseIf time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K19:K23").Merge()
                worksheet.Range("L19:L23").Merge()
                worksheet.Range("M19:M23").Merge()
                worksheet.Range("K19:K23").Value = subject
                worksheet.Range("L19:L23").Value = section
                worksheet.Range("M19:M23").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:00:00" Then
            If time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K20:K22").Merge()
                worksheet.Range("L20:L22").Merge()
                worksheet.Range("M20:M22").Merge()
                worksheet.Range("K20:K22").Value = subject
                worksheet.Range("L20:L22").Value = section
                worksheet.Range("M20:M22").Value = room
            ElseIf time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K20:K24").Merge()
                worksheet.Range("L20:L24").Merge()
                worksheet.Range("M20:M24").Merge()
                worksheet.Range("K20:K24").Value = subject
                worksheet.Range("L20:L24").Value = section
                worksheet.Range("M20:M24").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:30:00" Then
            If time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K21:K23").Merge()
                worksheet.Range("L21:L23").Merge()
                worksheet.Range("M21:M23").Merge()
                worksheet.Range("K21:K23").Value = subject
                worksheet.Range("L21:L23").Value = section
                worksheet.Range("M21:M23").Value = room
            ElseIf time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K21:K25").Merge()
                worksheet.Range("L21:L25").Merge()
                worksheet.Range("M21:M25").Merge()
                worksheet.Range("K21:K25").Value = subject
                worksheet.Range("L21:L25").Value = section
                worksheet.Range("M21:M25").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:00:00" Then
            If time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K22:K24").Merge()
                worksheet.Range("L22:L24").Merge()
                worksheet.Range("M22:M24").Merge()
                worksheet.Range("K22:K24").Value = subject
                worksheet.Range("L22:L24").Value = section
                worksheet.Range("M22:M24").Value = room
            ElseIf time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K22:K26").Merge()
                worksheet.Range("L22:L26").Merge()
                worksheet.Range("M22:M26").Merge()
                worksheet.Range("K22:K26").Value = subject
                worksheet.Range("L22:L26").Value = section
                worksheet.Range("M22:M26").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:30:00" Then
            If time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K23:K25").Merge()
                worksheet.Range("L23:L25").Merge()
                worksheet.Range("M23:M25").Merge()
                worksheet.Range("K23:K25").Value = subject
                worksheet.Range("L23:L25").Value = section
                worksheet.Range("M23:M25").Value = room
            ElseIf time_end = "2020-02-13 17:30:00" Then
                worksheet.Range("K23:K27").Merge()
                worksheet.Range("L23:L27").Merge()
                worksheet.Range("M23:M27").Merge()
                worksheet.Range("K23:K27").Value = subject
                worksheet.Range("L23:L27").Value = section
                worksheet.Range("M23:M27").Value = room
            End If
        End If
        If time_start = "2020-02-13 16:00:00" Then
            If time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K24:K26").Merge()
                worksheet.Range("L24:L26").Merge()
                worksheet.Range("M24:M26").Merge()
                worksheet.Range("K24:K26").Value = subject
                worksheet.Range("L24:L26").Value = section
                worksheet.Range("M24:M26").Value = room
            ElseIf time_end = "2020-02-13 18:00:00" Then
                worksheet.Range("K24:K28").Merge()
                worksheet.Range("L24:L28").Merge()
                worksheet.Range("M24:M28").Merge()
                worksheet.Range("K24:K28").Value = subject
                worksheet.Range("L24:L28").Value = section
                worksheet.Range("M24:M28").Value = room
            End If
        End If

        'Fridayyyy========
        If time_start = "2020-02-14 06:00:00" Then
            If time_end = "2020-02-14 07:00:00" Then
                worksheet.Range("N4:N6").Merge()
                worksheet.Range("O4:O6").Merge()
                worksheet.Range("P4:P6").Merge()
                worksheet.Range("N4:N6").Value = subject
                worksheet.Range("O4:O6").Value = section
                worksheet.Range("P4:P6").Value = room
            ElseIf time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N4:N8").Merge()
                worksheet.Range("O4:O8").Merge()
                worksheet.Range("P4:P8").Merge()
                worksheet.Range("N4:N8").Value = subject
                worksheet.Range("O4:O8").Value = section
                worksheet.Range("P4:P8").Value = room
            End If
        ElseIf time_start = "2020-02-14 06:30:00" Then

            If time_end = "2020-02-14 07:30:00" Then
                worksheet.Range("N5:N7").Merge()
                worksheet.Range("O5:O7").Merge()
                worksheet.Range("P5:P7").Merge()
                worksheet.Range("N5:N7").Value = subject
                worksheet.Range("O5:O7").Value = section
                worksheet.Range("P5:P7").Value = room
            ElseIf time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N5:N9").Merge()
                worksheet.Range("O5:O9").Merge()
                worksheet.Range("P5:P9").Merge()
                worksheet.Range("N5:N9").Value = subject
                worksheet.Range("O5:O9").Value = section
            End If
            worksheet.Range("P5:P9").Value = room
        ElseIf time_start = "2020-02-14 07:00:00" Then
            If time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N6:N8").Merge()
                worksheet.Range("O6:O8").Merge()
                worksheet.Range("P6:P8").Merge()
                worksheet.Range("N6:N8").Value = subject
                worksheet.Range("O6:O8").Value = section
                worksheet.Range("P6:P8").Value = room
            ElseIf time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N6:N10").Merge()
                worksheet.Range("O6:O10").Merge()
                worksheet.Range("P6:P10").Merge()
                worksheet.Range("N6:N10").Value = subject
                worksheet.Range("O6:O10").Value = section
                worksheet.Range("P6:P10").Value = room
            End If
        ElseIf time_start = "2020-02-14 07:30:00" Then
            If time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N7:N9").Merge()
                worksheet.Range("O7:O9").Merge()
                worksheet.Range("P7:P9").Merge()
                worksheet.Range("N7:N9").Value = subject
                worksheet.Range("O7:O9").Value = section
                worksheet.Range("P7:P9").Value = room
            ElseIf time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N7:N11").Merge()
                worksheet.Range("O7:O11").Merge()
                worksheet.Range("P7:P11").Merge()
                worksheet.Range("N7:N11").Value = subject
                worksheet.Range("O7:O11").Value = section
                worksheet.Range("P7:P11").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:00:00" Then
            If time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N8:N10").Merge()
                worksheet.Range("O8:O10").Merge()
                worksheet.Range("P8:P10").Merge()
                worksheet.Range("N8:N10").Value = subject
                worksheet.Range("O8:O10").Value = section
                worksheet.Range("P8:P10").Value = room
            ElseIf time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N8:N12").Merge()
                worksheet.Range("O8:O12").Merge()
                worksheet.Range("P8:P12").Merge()
                worksheet.Range("N8:N12").Value = subject
                worksheet.Range("O8:O12").Value = section
                worksheet.Range("P8:P12").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:30:00" Then
            If time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N9:N11").Merge()
                worksheet.Range("O9:O11").Merge()
                worksheet.Range("P9:P11").Merge()
                worksheet.Range("N9:N11").Value = subject
                worksheet.Range("O9:O11").Value = section
                worksheet.Range("P9:P11").Value = room
            ElseIf time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N6:N13").Merge()
                worksheet.Range("O9:O13").Merge()
                worksheet.Range("P9:P13").Merge()
                worksheet.Range("N9:N13").Value = subject
                worksheet.Range("O9:O13").Value = section
                worksheet.Range("P9:P13").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:00:00" Then
            If time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N10:N12").Merge()
                worksheet.Range("O10:O12").Merge()
                worksheet.Range("P10:P12").Merge()
                worksheet.Range("N10:N12").Value = subject
                worksheet.Range("O10:O12").Value = section
                worksheet.Range("P10:P12").Value = room
            ElseIf time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N10:N14").Merge()
                worksheet.Range("O10:O14").Merge()
                worksheet.Range("P10:P14").Merge()
                worksheet.Range("N10:N14").Value = subject
                worksheet.Range("O10:O14").Value = section
                worksheet.Range("P10:P14").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:30:00" Then
            If time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N11:N13").Merge()
                worksheet.Range("O11:O13").Merge()
                worksheet.Range("P11:P13").Merge()
                worksheet.Range("N11:N13").Value = subject
                worksheet.Range("O11:O13").Value = section
                worksheet.Range("P11:P13").Value = room
            ElseIf time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N11:N15").Merge()
                worksheet.Range("O11:O15").Merge()
                worksheet.Range("P11:P15").Merge()
                worksheet.Range("N11:N15").Value = subject
                worksheet.Range("O11:O15").Value = section
                worksheet.Range("P11:P15").Value = room
            End If
        ElseIf time_start = "2020-02-14 10:00:00" Then
            If time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N12:N14").Merge()
                worksheet.Range("O12:O14").Merge()
                worksheet.Range("P12:P14").Merge()
                worksheet.Range("N12:N14").Value = subject
                worksheet.Range("O12:O14").Value = section
                worksheet.Range("P12:P14").Value = room

            ElseIf time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N12:N16").Merge()
                worksheet.Range("O12:O16").Merge()
                worksheet.Range("P12:P16").Merge()
                worksheet.Range("N12:N16").Value = subject
                worksheet.Range("O12:O16").Value = section
                worksheet.Range("P12:P16").Value = room

            End If
        End If
        If time_start = "2020-02-14 10:30:00" Then
            If time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N13:N15").Merge()
                worksheet.Range("O13:O15").Merge()
                worksheet.Range("P13:P15").Merge()
                worksheet.Range("N13:N15").Value = subject
                worksheet.Range("O13:O15").Value = section
                worksheet.Range("P13:P15").Value = room
            ElseIf time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N13:N17").Merge()
                worksheet.Range("O13:O17").Merge()
                worksheet.Range("P13:P17").Merge()
                worksheet.Range("N13:N17").Value = subject
                worksheet.Range("O13:O17").Value = section
                worksheet.Range("P13:P17").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:00:00" Then
            If time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N14:N16").Merge()
                worksheet.Range("O14:O16").Merge()
                worksheet.Range("P14:P16").Merge()
                worksheet.Range("N14:N16").Value = subject
                worksheet.Range("O14:O16").Value = section
                worksheet.Range("P14:P16").Value = room
            ElseIf time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N14:N18").Merge()
                worksheet.Range("O14:O18").Merge()
                worksheet.Range("P14:P18").Merge()
                worksheet.Range("N14:N18").Value = subject
                worksheet.Range("O14:O18").Value = section
                worksheet.Range("P14:P18").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:30:00" Then
            If time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N15:N17").Merge()
                worksheet.Range("O15:O17").Merge()
                worksheet.Range("P15:P17").Merge()
                worksheet.Range("N15:N17").Value = subject
                worksheet.Range("O15:O17").Value = section
                worksheet.Range("P15:P17").Value = room
            ElseIf time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N15:N19").Merge()
                worksheet.Range("O15:O19").Merge()
                worksheet.Range("P15:P19").Merge()
                worksheet.Range("N15:N19").Value = subject
                worksheet.Range("O15:O19").Value = section
                worksheet.Range("P15:P19").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:00:00" Then
            If time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N16:N14").Merge()
                worksheet.Range("O16:O18").Merge()
                worksheet.Range("P16:P18").Merge()
                worksheet.Range("N16:N18").Value = subject
                worksheet.Range("O16:O18").Value = section
                worksheet.Range("P16:P18").Value = room
            ElseIf time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N16:N20").Merge()
                worksheet.Range("O16:O20").Merge()
                worksheet.Range("P16:P20").Merge()
                worksheet.Range("N16:N20").Value = subject
                worksheet.Range("O16:O20").Value = section
                worksheet.Range("P16:P20").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:30:00" Then
            If time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N17:N19").Merge()
                worksheet.Range("O17:O19").Merge()
                worksheet.Range("P17:P19").Merge()
                worksheet.Range("N17:N19").Value = subject
                worksheet.Range("O17:O19").Value = section
                worksheet.Range("P17:P19").Value = room
            ElseIf time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N17:N21").Merge()
                worksheet.Range("O17:O21").Merge()
                worksheet.Range("P17:P21").Merge()
                worksheet.Range("N17:N21").Value = subject
                worksheet.Range("O17:O21").Value = section
                worksheet.Range("P17:P21").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:00:00" Then
            If time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N18:N20").Merge()
                worksheet.Range("O18:O20").Merge()
                worksheet.Range("P18:P20").Merge()
                worksheet.Range("N18:N20").Value = subject
                worksheet.Range("O18:O20").Value = section
                worksheet.Range("P18:P20").Value = room
            ElseIf time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N18:N22").Merge()
                worksheet.Range("O18:O22").Merge()
                worksheet.Range("P18:P22").Merge()
                worksheet.Range("N18:N22").Value = subject
                worksheet.Range("O18:O22").Value = section
                worksheet.Range("P18:P22").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:30:00" Then
            If time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N19:N21").Merge()
                worksheet.Range("O19:O21").Merge()
                worksheet.Range("P19:P21").Merge()
                worksheet.Range("N19:N21").Value = subject
                worksheet.Range("O19:O21").Value = section
                worksheet.Range("P19:P21").Value = room
            ElseIf time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N19:N23").Merge()
                worksheet.Range("O19:O23").Merge()
                worksheet.Range("P19:P23").Merge()
                worksheet.Range("N19:N23").Value = subject
                worksheet.Range("O19:O23").Value = section
                worksheet.Range("P19:P23").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:00:00" Then
            If time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N20:N22").Merge()
                worksheet.Range("O20:O22").Merge()
                worksheet.Range("P20:P22").Merge()
                worksheet.Range("N20:N22").Value = subject
                worksheet.Range("O20:O22").Value = section
                worksheet.Range("P20:P22").Value = room
            ElseIf time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N20:N24").Merge()
                worksheet.Range("O20:O24").Merge()
                worksheet.Range("P20:P24").Merge()
                worksheet.Range("N20:N24").Value = subject
                worksheet.Range("O20:O24").Value = section
                worksheet.Range("P20:P24").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:30:00" Then
            If time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N21:N23").Merge()
                worksheet.Range("O21:O23").Merge()
                worksheet.Range("P21:P23").Merge()
                worksheet.Range("N21:N23").Value = subject
                worksheet.Range("O21:O23").Value = section
                worksheet.Range("P21:P23").Value = room
            ElseIf time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N21:N25").Merge()
                worksheet.Range("O21:O25").Merge()
                worksheet.Range("P21:P25").Merge()
                worksheet.Range("N21:N25").Value = subject
                worksheet.Range("O21:O25").Value = section
                worksheet.Range("P21:P25").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:00:00" Then
            If time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N22:N24").Merge()
                worksheet.Range("O22:O24").Merge()
                worksheet.Range("P22:P24").Merge()
                worksheet.Range("N22:N24").Value = subject
                worksheet.Range("O22:O24").Value = section
                worksheet.Range("P22:P24").Value = room
            ElseIf time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N22:N26").Merge()
                worksheet.Range("O22:O26").Merge()
                worksheet.Range("P22:P26").Merge()
                worksheet.Range("N22:N26").Value = subject
                worksheet.Range("O22:O26").Value = section
                worksheet.Range("P22:P26").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:30:00" Then
            If time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N23:N25").Merge()
                worksheet.Range("O23:O25").Merge()
                worksheet.Range("P23:P25").Merge()
                worksheet.Range("N23:N25").Value = subject
                worksheet.Range("O23:O25").Value = section
                worksheet.Range("P23:P25").Value = room
            ElseIf time_end = "2020-02-14 17:30:00" Then
                worksheet.Range("N23:N27").Merge()
                worksheet.Range("O23:O27").Merge()
                worksheet.Range("P23:P27").Merge()
                worksheet.Range("N23:N27").Value = subject
                worksheet.Range("O23:O27").Value = section
                worksheet.Range("P23:P27").Value = room
            End If
        End If
        If time_start = "2020-02-14 16:00:00" Then
            If time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N24:N26").Merge()
                worksheet.Range("O24:O26").Merge()
                worksheet.Range("P24:P26").Merge()
                worksheet.Range("N24:N26").Value = subject
                worksheet.Range("O24:O26").Value = section
                worksheet.Range("P24:P26").Value = room
            ElseIf time_end = "2020-02-14 18:00:00" Then
                worksheet.Range("N24:N28").Merge()
                worksheet.Range("O24:O28").Merge()
                worksheet.Range("P24:P28").Merge()
                worksheet.Range("N24:N28").Value = subject
                worksheet.Range("O24:O28").Value = section
                worksheet.Range("P24:P28").Value = room
            End If
        End If
    End Sub

    'Row6
    Private Sub CheckDateToInsertRow6()
        Dim id As String = choose_expo.SelectedValue
        Dim s As String = "select prof_details_tbl.`FName_prof`, 
    prof_details_tbl.`MName_prof`, 
    prof_details_tbl.`LName_prof`,
    subjects_tbl.subject_Name, 
    `schedule_tbl`.strandName, 
    `schedule_tbl`.grade_lvl, 
    `schedule_tbl`.section_no, `schedule_tbl`.building_no, 
    `schedule_tbl`.room_no,
schedule_tbl.time_start, 
schedule_tbl.time_end from prof_details_tbl ,schedule_tbl inner join subjects_tbl on schedule_tbl.subject = subjects_tbl.snn
    where prof_details_tbl.ID_Prof='" + id + "' and `schedule_tbl`.`id_Prof`='" + id + "' and sy='" + print_sy.Text + "' and semestral_sche='" + print_sem.Text + "'"
        adapt = New MySqlDataAdapter(s, scon.GetConnection)
        tb = New DataTable
        adapt.Fill(tb)

        Dim row6 As DataRow = tb.Rows(5)
        Dim subject As String = row6(3)
        Dim section As String = row6(4) + " " + row6(5) + "-" + row6(6)
        Dim room As String = row6(7) + " " + row6(8)
        time_start = row6(9)
        time_end = row6(10)
        'Monday start
        If time_start = "2020-02-10 06:00:00" Then
            If time_end = "2020-02-10 07:00:00" Then
                worksheet.Range("B4:B6").Merge()
                worksheet.Range("C4:C6").Merge()
                worksheet.Range("D4:D6").Merge()
                worksheet.Range("B4:B6").Value = subject
                worksheet.Range("C4:C6").Value = section
                worksheet.Range("D4:D6").Value = room
            ElseIf time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B4:B8").Merge()
                worksheet.Range("C4:C8").Merge()
                worksheet.Range("D4:D8").Merge()
                worksheet.Range("B4:B8").Value = subject
                worksheet.Range("C4:C8").Value = section
                worksheet.Range("D4:D8").Value = room
            End If
        ElseIf time_start = "2020-02-10 06:30:00" Then

            If time_end = "2020-02-10 07:30:00" Then
                worksheet.Range("B5:B7").Merge()
                worksheet.Range("C5:C7").Merge()
                worksheet.Range("D5:D7").Merge()
                worksheet.Range("B5:B7").Value = subject
                worksheet.Range("C5:C7").Value = section
                worksheet.Range("D5:D7").Value = room
            ElseIf time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B5:B9").Merge()
                worksheet.Range("C5:C9").Merge()
                worksheet.Range("D5:D9").Merge()
                worksheet.Range("B5:B9").Value = subject
                worksheet.Range("C5:C9").Value = section
            End If
            worksheet.Range("D5:D9").Value = room
        ElseIf time_start = "2020-02-10 07:00:00" Then
            If time_end = "2020-02-10 08:00:00" Then
                worksheet.Range("B6:B8").Merge()
                worksheet.Range("C6:C8").Merge()
                worksheet.Range("D6:D8").Merge()
                worksheet.Range("B6:B8").Value = subject
                worksheet.Range("C6:C8").Value = section
                worksheet.Range("D6:D8").Value = room
            ElseIf time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B6:B10").Merge()
                worksheet.Range("C6:C10").Merge()
                worksheet.Range("D6:D10").Merge()
                worksheet.Range("B6:B10").Value = subject
                worksheet.Range("C6:C10").Value = section
                worksheet.Range("D6:D10").Value = room
            End If
        ElseIf time_start = "2020-02-10 07:30:00" Then
            If time_end = "2020-02-10 08:30:00" Then
                worksheet.Range("B7:B9").Merge()
                worksheet.Range("C7:C9").Merge()
                worksheet.Range("D7:D9").Merge()
                worksheet.Range("B7:B9").Value = subject
                worksheet.Range("C7:C9").Value = section
                worksheet.Range("D7:D9").Value = room
            ElseIf time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B7:B11").Merge()
                worksheet.Range("C7:C11").Merge()
                worksheet.Range("D7:D11").Merge()
                worksheet.Range("B7:B11").Value = subject
                worksheet.Range("C7:C11").Value = section
                worksheet.Range("D7:D11").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:00:00" Then
            If time_end = "2020-02-10 09:00:00" Then
                worksheet.Range("B8:B10").Merge()
                worksheet.Range("C8:C10").Merge()
                worksheet.Range("D8:D10").Merge()
                worksheet.Range("B8:B10").Value = subject
                worksheet.Range("C8:C10").Value = section
                worksheet.Range("D8:D10").Value = room
            ElseIf time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B8:B12").Merge()
                worksheet.Range("C8:C12").Merge()
                worksheet.Range("D8:D12").Merge()
                worksheet.Range("B8:B12").Value = subject
                worksheet.Range("C8:C12").Value = section
                worksheet.Range("D8:D12").Value = room
            End If
        ElseIf time_start = "2020-02-10 08:30:00" Then
            If time_end = "2020-02-10 09:30:00" Then
                worksheet.Range("B9:B11").Merge()
                worksheet.Range("C9:C11").Merge()
                worksheet.Range("D9:D11").Merge()
                worksheet.Range("B9:B11").Value = subject
                worksheet.Range("C9:C11").Value = section
                worksheet.Range("D9:D11").Value = room
            ElseIf time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B6:B13").Merge()
                worksheet.Range("C9:C13").Merge()
                worksheet.Range("D9:D13").Merge()
                worksheet.Range("B9:B13").Value = subject
                worksheet.Range("C9:C13").Value = section
                worksheet.Range("D9:D13").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:00:00" Then
            If time_end = "2020-02-10 10:00:00" Then
                worksheet.Range("B10:B12").Merge()
                worksheet.Range("C10:C12").Merge()
                worksheet.Range("D10:D12").Merge()
                worksheet.Range("B10:B12").Value = subject
                worksheet.Range("C10:C12").Value = section
                worksheet.Range("D10:D12").Value = room
            ElseIf time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B10:B14").Merge()
                worksheet.Range("C10:C14").Merge()
                worksheet.Range("D10:D14").Merge()
                worksheet.Range("B10:B14").Value = subject
                worksheet.Range("C10:C14").Value = section
                worksheet.Range("D10:D14").Value = room
            End If
        ElseIf time_start = "2020-02-10 09:30:00" Then
            If time_end = "2020-02-10 10:30:00" Then
                worksheet.Range("B11:B13").Merge()
                worksheet.Range("C11:C13").Merge()
                worksheet.Range("D11:D13").Merge()
                worksheet.Range("B11:B13").Value = subject
                worksheet.Range("C11:C13").Value = section
                worksheet.Range("D11:D13").Value = room
            ElseIf time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B11:B15").Merge()
                worksheet.Range("C11:C15").Merge()
                worksheet.Range("D11:D15").Merge()
                worksheet.Range("B11:B15").Value = subject
                worksheet.Range("C11:C15").Value = section
                worksheet.Range("D11:D15").Value = room
            End If
        ElseIf time_start = "2020-02-10 10:00:00" Then
            If time_end = "2020-02-10 11:00:00" Then
                worksheet.Range("B12:B14").Merge()
                worksheet.Range("C12:C14").Merge()
                worksheet.Range("D12:D14").Merge()
                worksheet.Range("B12:B14").Value = subject
                worksheet.Range("C12:C14").Value = section
                worksheet.Range("D12:D14").Value = room

            ElseIf time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B12:B16").Merge()
                worksheet.Range("C12:C16").Merge()
                worksheet.Range("D12:D16").Merge()
                worksheet.Range("B12:B16").Value = subject
                worksheet.Range("C12:C16").Value = section
                worksheet.Range("D12:D16").Value = room

            End If
        End If
        If time_start = "2020-02-10 10:30:00" Then
            If time_end = "2020-02-10 11:30:00" Then
                worksheet.Range("B13:B15").Merge()
                worksheet.Range("C13:C15").Merge()
                worksheet.Range("D13:D15").Merge()
                worksheet.Range("B13:B15").Value = subject
                worksheet.Range("C13:C15").Value = section
                worksheet.Range("D13:D15").Value = room
            ElseIf time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B13:B17").Merge()
                worksheet.Range("C13:C17").Merge()
                worksheet.Range("D13:D17").Merge()
                worksheet.Range("B13:B17").Value = subject
                worksheet.Range("C13:C17").Value = section
                worksheet.Range("D13:D17").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:00:00" Then
            If time_end = "2020-02-10 12:00:00" Then
                worksheet.Range("B14:B16").Merge()
                worksheet.Range("C14:C16").Merge()
                worksheet.Range("D14:D16").Merge()
                worksheet.Range("B14:B16").Value = subject
                worksheet.Range("C14:C16").Value = section
                worksheet.Range("D14:D16").Value = room
            ElseIf time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B14:B18").Merge()
                worksheet.Range("C14:C18").Merge()
                worksheet.Range("D14:D18").Merge()
                worksheet.Range("B14:B18").Value = subject
                worksheet.Range("C14:C18").Value = section
                worksheet.Range("D14:D18").Value = room
            End If
        ElseIf time_start = "2020-02-10 11:30:00" Then
            If time_end = "2020-02-10 12:30:00" Then
                worksheet.Range("B15:B17").Merge()
                worksheet.Range("C15:C17").Merge()
                worksheet.Range("D15:D17").Merge()
                worksheet.Range("B15:B17").Value = subject
                worksheet.Range("C15:C17").Value = section
                worksheet.Range("D15:D17").Value = room
            ElseIf time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B15:B19").Merge()
                worksheet.Range("C15:C19").Merge()
                worksheet.Range("D15:D19").Merge()
                worksheet.Range("B15:B19").Value = subject
                worksheet.Range("C15:C19").Value = section
                worksheet.Range("D15:D19").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:00:00" Then
            If time_end = "2020-02-10 13:00:00" Then
                worksheet.Range("B16:B14").Merge()
                worksheet.Range("C16:C18").Merge()
                worksheet.Range("D16:D18").Merge()
                worksheet.Range("B16:B18").Value = subject
                worksheet.Range("C16:C18").Value = section
                worksheet.Range("D16:D18").Value = room
            ElseIf time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B16:B20").Merge()
                worksheet.Range("C16:C20").Merge()
                worksheet.Range("D16:D20").Merge()
                worksheet.Range("B16:B20").Value = subject
                worksheet.Range("C16:C20").Value = section
                worksheet.Range("D16:D20").Value = room
            End If
        ElseIf time_start = "2020-02-10 12:30:00" Then
            If time_end = "2020-02-10 13:30:00" Then
                worksheet.Range("B17:B19").Merge()
                worksheet.Range("C17:C19").Merge()
                worksheet.Range("D17:D19").Merge()
                worksheet.Range("B17:B19").Value = subject
                worksheet.Range("C17:C19").Value = section
                worksheet.Range("D17:D19").Value = room
            ElseIf time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B17:B21").Merge()
                worksheet.Range("C17:C21").Merge()
                worksheet.Range("D17:D21").Merge()
                worksheet.Range("B17:B21").Value = subject
                worksheet.Range("C17:C21").Value = section
                worksheet.Range("D17:D21").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:00:00" Then
            If time_end = "2020-02-10 14:00:00" Then
                worksheet.Range("B18:B20").Merge()
                worksheet.Range("C18:C20").Merge()
                worksheet.Range("D18:D20").Merge()
                worksheet.Range("B18:B20").Value = subject
                worksheet.Range("C18:C20").Value = section
                worksheet.Range("D18:D20").Value = room
            ElseIf time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B18:B22").Merge()
                worksheet.Range("C18:C22").Merge()
                worksheet.Range("D18:D22").Merge()
                worksheet.Range("B18:B22").Value = subject
                worksheet.Range("C18:C22").Value = section
                worksheet.Range("D18:D22").Value = room
            End If
        ElseIf time_start = "2020-02-10 13:30:00" Then
            If time_end = "2020-02-10 14:30:00" Then
                worksheet.Range("B19:B21").Merge()
                worksheet.Range("C19:C21").Merge()
                worksheet.Range("D19:D21").Merge()
                worksheet.Range("B19:B21").Value = subject
                worksheet.Range("C19:C21").Value = section
                worksheet.Range("D19:D21").Value = room
            ElseIf time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B19:B23").Merge()
                worksheet.Range("C19:C23").Merge()
                worksheet.Range("D19:D23").Merge()
                worksheet.Range("B19:B23").Value = subject
                worksheet.Range("C19:C23").Value = section
                worksheet.Range("D19:D23").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:00:00" Then
            If time_end = "2020-02-10 15:00:00" Then
                worksheet.Range("B20:B22").Merge()
                worksheet.Range("C20:C22").Merge()
                worksheet.Range("D20:D22").Merge()
                worksheet.Range("B20:B22").Value = subject
                worksheet.Range("C20:C22").Value = section
                worksheet.Range("D20:D22").Value = room
            ElseIf time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B20:B24").Merge()
                worksheet.Range("C20:C24").Merge()
                worksheet.Range("D20:D24").Merge()
                worksheet.Range("B20:B24").Value = subject
                worksheet.Range("C20:C24").Value = section
                worksheet.Range("D20:D24").Value = room
            End If
        ElseIf time_start = "2020-02-10 14:30:00" Then
            If time_end = "2020-02-10 15:30:00" Then
                worksheet.Range("B21:B23").Merge()
                worksheet.Range("C21:C23").Merge()
                worksheet.Range("D21:D23").Merge()
                worksheet.Range("B21:B23").Value = subject
                worksheet.Range("C21:C23").Value = section
                worksheet.Range("D21:D23").Value = room
            ElseIf time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B21:B25").Merge()
                worksheet.Range("C21:C25").Merge()
                worksheet.Range("D21:D25").Merge()
                worksheet.Range("B21:B25").Value = subject
                worksheet.Range("C21:C25").Value = section
                worksheet.Range("D21:D25").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:00:00" Then
            If time_end = "2020-02-10 16:00:00" Then
                worksheet.Range("B22:B24").Merge()
                worksheet.Range("C22:C24").Merge()
                worksheet.Range("D22:D24").Merge()
                worksheet.Range("B22:B24").Value = subject
                worksheet.Range("C22:C24").Value = section
                worksheet.Range("D22:D24").Value = room
            ElseIf time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B22:B26").Merge()
                worksheet.Range("C22:C26").Merge()
                worksheet.Range("D22:D26").Merge()
                worksheet.Range("B22:B26").Value = subject
                worksheet.Range("C22:C26").Value = section
                worksheet.Range("D22:D26").Value = room
            End If
        End If
        If time_start = "2020-02-10 15:30:00" Then
            If time_end = "2020-02-10 16:30:00" Then
                worksheet.Range("B23:B25").Merge()
                worksheet.Range("C23:C25").Merge()
                worksheet.Range("D23:D25").Merge()
                worksheet.Range("B23:B25").Value = subject
                worksheet.Range("C23:C25").Value = section
                worksheet.Range("D23:D25").Value = room
            ElseIf time_end = "2020-02-10 17:30:00" Then
                worksheet.Range("B23:B27").Merge()
                worksheet.Range("C23:C27").Merge()
                worksheet.Range("D23:D27").Merge()
                worksheet.Range("B23:B27").Value = subject
                worksheet.Range("C23:C27").Value = section
                worksheet.Range("D23:D27").Value = room
            End If
        End If
        If time_start = "2020-02-10 16:00:00" Then
            If time_end = "2020-02-10 17:00:00" Then
                worksheet.Range("B24:B26").Merge()
                worksheet.Range("C24:C26").Merge()
                worksheet.Range("D24:D26").Merge()
                worksheet.Range("B24:B26").Value = subject
                worksheet.Range("C24:C26").Value = section
                worksheet.Range("D24:D26").Value = room
            ElseIf time_end = "2020-02-10 18:00:00" Then
                worksheet.Range("B24:B28").Merge()
                worksheet.Range("C24:C28").Merge()
                worksheet.Range("D24:D28").Merge()
                worksheet.Range("B24:B28").Value = subject
                worksheet.Range("C24:C28").Value = section
                worksheet.Range("D24:D28").Value = room
            End If
        End If



        'tuesday start-----------------------------------------------


        If time_start = "2020-02-11 06:00:00" Then
            If time_end = "2020-02-11 07:00:00" Then
                worksheet.Range("E4:E6").Merge()
                worksheet.Range("F4:F6").Merge()
                worksheet.Range("G4:G6").Merge()
                worksheet.Range("E4:E6").Value = subject
                worksheet.Range("F4:F6").Value = section
                worksheet.Range("G4:G6").Value = room
            ElseIf time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E4:E8").Merge()
                worksheet.Range("F4:F8").Merge()
                worksheet.Range("G4:G8").Merge()
                worksheet.Range("E4:E8").Value = subject
                worksheet.Range("F4:F8").Value = section
                worksheet.Range("G4:G8").Value = room
            End If
        ElseIf time_start = "2020-02-11 06:30:00" Then

            If time_end = "2020-02-11 07:30:00" Then
                worksheet.Range("E5:E7").Merge()
                worksheet.Range("F5:F7").Merge()
                worksheet.Range("G5:G7").Merge()
                worksheet.Range("E5:E7").Value = subject
                worksheet.Range("F5:F7").Value = section
                worksheet.Range("G5:G7").Value = room
            ElseIf time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E5:E9").Merge()
                worksheet.Range("F5:F9").Merge()
                worksheet.Range("G5:G9").Merge()
                worksheet.Range("E5:E9").Value = subject
                worksheet.Range("F5:F9").Value = section
            End If
            worksheet.Range("G5:G9").Value = room
        ElseIf time_start = "2020-02-11 07:00:00" Then
            If time_end = "2020-02-11 08:00:00" Then
                worksheet.Range("E6:E8").Merge()
                worksheet.Range("F6:F8").Merge()
                worksheet.Range("G6:G8").Merge()
                worksheet.Range("E6:E8").Value = subject
                worksheet.Range("F6:F8").Value = section
                worksheet.Range("G6:G8").Value = room
            ElseIf time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E6:E10").Merge()
                worksheet.Range("F6:F10").Merge()
                worksheet.Range("G6:G10").Merge()
                worksheet.Range("E6:E10").Value = subject
                worksheet.Range("F6:F10").Value = section
                worksheet.Range("G6:G10").Value = room
            End If
        ElseIf time_start = "2020-02-11 07:30:00" Then
            If time_end = "2020-02-11 08:30:00" Then
                worksheet.Range("E7:E9").Merge()
                worksheet.Range("F7:F9").Merge()
                worksheet.Range("G7:G9").Merge()
                worksheet.Range("E7:E9").Value = subject
                worksheet.Range("F7:F9").Value = section
                worksheet.Range("G7:G9").Value = room
            ElseIf time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E7:E11").Merge()
                worksheet.Range("F7:F11").Merge()
                worksheet.Range("G7:G11").Merge()
                worksheet.Range("E7:E11").Value = subject
                worksheet.Range("F7:F11").Value = section
                worksheet.Range("G7:G11").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:00:00" Then
            If time_end = "2020-02-11 09:00:00" Then
                worksheet.Range("E8:E10").Merge()
                worksheet.Range("F8:F10").Merge()
                worksheet.Range("G8:G10").Merge()
                worksheet.Range("E8:E10").Value = subject
                worksheet.Range("F8:F10").Value = section
                worksheet.Range("G8:G10").Value = room
            ElseIf time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E8:E12").Merge()
                worksheet.Range("F8:F12").Merge()
                worksheet.Range("G8:G12").Merge()
                worksheet.Range("E8:E12").Value = subject
                worksheet.Range("F8:F12").Value = section
                worksheet.Range("G8:G12").Value = room
            End If
        ElseIf time_start = "2020-02-11 08:30:00" Then
            If time_end = "2020-02-11 09:30:00" Then
                worksheet.Range("E9:E11").Merge()
                worksheet.Range("F9:F11").Merge()
                worksheet.Range("G9:G11").Merge()
                worksheet.Range("E9:E11").Value = subject
                worksheet.Range("F9:F11").Value = section
                worksheet.Range("G9:G11").Value = room
            ElseIf time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E6:E13").Merge()
                worksheet.Range("F9:F13").Merge()
                worksheet.Range("G9:G13").Merge()
                worksheet.Range("E9:E13").Value = subject
                worksheet.Range("F9:F13").Value = section
                worksheet.Range("G9:G13").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:00:00" Then
            If time_end = "2020-02-11 10:00:00" Then
                worksheet.Range("E10:E12").Merge()
                worksheet.Range("F10:F12").Merge()
                worksheet.Range("G10:G12").Merge()
                worksheet.Range("E10:E12").Value = subject
                worksheet.Range("F10:F12").Value = section
                worksheet.Range("G10:G12").Value = room
            ElseIf time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E10:E14").Merge()
                worksheet.Range("F10:F14").Merge()
                worksheet.Range("G10:G14").Merge()
                worksheet.Range("E10:E14").Value = subject
                worksheet.Range("F10:F14").Value = section
                worksheet.Range("G10:G14").Value = room
            End If
        ElseIf time_start = "2020-02-11 09:30:00" Then
            If time_end = "2020-02-11 10:30:00" Then
                worksheet.Range("E11:E13").Merge()
                worksheet.Range("F11:F13").Merge()
                worksheet.Range("G11:G13").Merge()
                worksheet.Range("E11:E13").Value = subject
                worksheet.Range("F11:F13").Value = section
                worksheet.Range("G11:G13").Value = room
            ElseIf time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E11:E15").Merge()
                worksheet.Range("F11:F15").Merge()
                worksheet.Range("G11:G15").Merge()
                worksheet.Range("E11:E15").Value = subject
                worksheet.Range("F11:F15").Value = section
                worksheet.Range("G11:G15").Value = room
            End If
        ElseIf time_start = "2020-02-11 10:00:00" Then
            If time_end = "2020-02-11 11:00:00" Then
                worksheet.Range("E12:E14").Merge()
                worksheet.Range("F12:F14").Merge()
                worksheet.Range("G12:G14").Merge()
                worksheet.Range("E12:E14").Value = subject
                worksheet.Range("F12:F14").Value = section
                worksheet.Range("G12:G14").Value = room

            ElseIf time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E12:E16").Merge()
                worksheet.Range("F12:F16").Merge()
                worksheet.Range("G12:G16").Merge()
                worksheet.Range("E12:E16").Value = subject
                worksheet.Range("F12:F16").Value = section
                worksheet.Range("G12:G16").Value = room

            End If
        End If
        If time_start = "2020-02-11 10:30:00" Then
            If time_end = "2020-02-11 11:30:00" Then
                worksheet.Range("E13:E15").Merge()
                worksheet.Range("F13:F15").Merge()
                worksheet.Range("G13:G15").Merge()
                worksheet.Range("E13:E15").Value = subject
                worksheet.Range("F13:F15").Value = section
                worksheet.Range("G13:G15").Value = room
            ElseIf time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E13:E17").Merge()
                worksheet.Range("F13:F17").Merge()
                worksheet.Range("G13:G17").Merge()
                worksheet.Range("E13:E17").Value = subject
                worksheet.Range("F13:F17").Value = section
                worksheet.Range("G13:G17").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:00:00" Then
            If time_end = "2020-02-11 12:00:00" Then
                worksheet.Range("E14:E16").Merge()
                worksheet.Range("F14:F16").Merge()
                worksheet.Range("G14:G16").Merge()
                worksheet.Range("E14:E16").Value = subject
                worksheet.Range("F14:F16").Value = section
                worksheet.Range("G14:G16").Value = room
            ElseIf time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E14:E18").Merge()
                worksheet.Range("F14:F18").Merge()
                worksheet.Range("G14:G18").Merge()
                worksheet.Range("E14:E18").Value = subject
                worksheet.Range("F14:F18").Value = section
                worksheet.Range("G14:G18").Value = room
            End If
        ElseIf time_start = "2020-02-11 11:30:00" Then
            If time_end = "2020-02-11 12:30:00" Then
                worksheet.Range("E15:E17").Merge()
                worksheet.Range("F15:F17").Merge()
                worksheet.Range("G15:G17").Merge()
                worksheet.Range("E15:E17").Value = subject
                worksheet.Range("F15:F17").Value = section
                worksheet.Range("G15:G17").Value = room
            ElseIf time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E15:E19").Merge()
                worksheet.Range("F15:F19").Merge()
                worksheet.Range("G15:G19").Merge()
                worksheet.Range("E15:E19").Value = subject
                worksheet.Range("F15:F19").Value = section
                worksheet.Range("G15:G19").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:00:00" Then
            If time_end = "2020-02-11 13:00:00" Then
                worksheet.Range("E16:E14").Merge()
                worksheet.Range("F16:F18").Merge()
                worksheet.Range("G16:G18").Merge()
                worksheet.Range("E16:E18").Value = subject
                worksheet.Range("F16:F18").Value = section
                worksheet.Range("G16:G18").Value = room
            ElseIf time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E16:E20").Merge()
                worksheet.Range("F16:F20").Merge()
                worksheet.Range("G16:G20").Merge()
                worksheet.Range("E16:E20").Value = subject
                worksheet.Range("F16:F20").Value = section
                worksheet.Range("G16:G20").Value = room
            End If
        ElseIf time_start = "2020-02-11 12:30:00" Then
            If time_end = "2020-02-11 13:30:00" Then
                worksheet.Range("E17:E19").Merge()
                worksheet.Range("F17:F19").Merge()
                worksheet.Range("G17:G19").Merge()
                worksheet.Range("E17:E19").Value = subject
                worksheet.Range("F17:F19").Value = section
                worksheet.Range("G17:G19").Value = room
            ElseIf time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E17:E21").Merge()
                worksheet.Range("F17:F21").Merge()
                worksheet.Range("G17:G21").Merge()
                worksheet.Range("E17:E21").Value = subject
                worksheet.Range("F17:F21").Value = section
                worksheet.Range("G17:G21").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:00:00" Then
            If time_end = "2020-02-11 14:00:00" Then
                worksheet.Range("E18:E20").Merge()
                worksheet.Range("F18:F20").Merge()
                worksheet.Range("G18:G20").Merge()
                worksheet.Range("E18:E20").Value = subject
                worksheet.Range("F18:F20").Value = section
                worksheet.Range("G18:G20").Value = room
            ElseIf time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E18:E22").Merge()
                worksheet.Range("F18:F22").Merge()
                worksheet.Range("G18:G22").Merge()
                worksheet.Range("E18:E22").Value = subject
                worksheet.Range("F18:F22").Value = section
                worksheet.Range("G18:G22").Value = room
            End If
        ElseIf time_start = "2020-02-11 13:30:00" Then
            If time_end = "2020-02-11 14:30:00" Then
                worksheet.Range("E19:E21").Merge()
                worksheet.Range("F19:F21").Merge()
                worksheet.Range("G19:G21").Merge()
                worksheet.Range("E19:E21").Value = subject
                worksheet.Range("F19:F21").Value = section
                worksheet.Range("G19:G21").Value = room
            ElseIf time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E19:E23").Merge()
                worksheet.Range("F19:F23").Merge()
                worksheet.Range("G19:G23").Merge()
                worksheet.Range("E19:E23").Value = subject
                worksheet.Range("F19:F23").Value = section
                worksheet.Range("G19:G23").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:00:00" Then
            If time_end = "2020-02-11 15:00:00" Then
                worksheet.Range("E20:E22").Merge()
                worksheet.Range("F20:F22").Merge()
                worksheet.Range("G20:G22").Merge()
                worksheet.Range("E20:E22").Value = subject
                worksheet.Range("F20:F22").Value = section
                worksheet.Range("G20:G22").Value = room
            ElseIf time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E20:E24").Merge()
                worksheet.Range("F20:F24").Merge()
                worksheet.Range("G20:G24").Merge()
                worksheet.Range("E20:E24").Value = subject
                worksheet.Range("F20:F24").Value = section
                worksheet.Range("G20:G24").Value = room
            End If
        ElseIf time_start = "2020-02-11 14:30:00" Then
            If time_end = "2020-02-11 15:30:00" Then
                worksheet.Range("E21:E23").Merge()
                worksheet.Range("F21:F23").Merge()
                worksheet.Range("G21:G23").Merge()
                worksheet.Range("E21:E23").Value = subject
                worksheet.Range("F21:F23").Value = section
                worksheet.Range("G21:G23").Value = room
            ElseIf time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E21:E25").Merge()
                worksheet.Range("F21:F25").Merge()
                worksheet.Range("G21:G25").Merge()
                worksheet.Range("E21:E25").Value = subject
                worksheet.Range("F21:F25").Value = section
                worksheet.Range("G21:G25").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:00:00" Then
            If time_end = "2020-02-11 16:00:00" Then
                worksheet.Range("E22:E24").Merge()
                worksheet.Range("F22:F24").Merge()
                worksheet.Range("G22:G24").Merge()
                worksheet.Range("E22:E24").Value = subject
                worksheet.Range("F22:F24").Value = section
                worksheet.Range("G22:G24").Value = room
            ElseIf time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E22:E26").Merge()
                worksheet.Range("F22:F26").Merge()
                worksheet.Range("G22:G26").Merge()
                worksheet.Range("E22:E26").Value = subject
                worksheet.Range("F22:F26").Value = section
                worksheet.Range("G22:G26").Value = room
            End If
        End If
        If time_start = "2020-02-11 15:30:00" Then
            If time_end = "2020-02-11 16:30:00" Then
                worksheet.Range("E23:E25").Merge()
                worksheet.Range("F23:F25").Merge()
                worksheet.Range("G23:G25").Merge()
                worksheet.Range("E23:E25").Value = subject
                worksheet.Range("F23:F25").Value = section
                worksheet.Range("G23:G25").Value = room
            ElseIf time_end = "2020-02-11 17:30:00" Then
                worksheet.Range("E23:E27").Merge()
                worksheet.Range("F23:F27").Merge()
                worksheet.Range("G23:G27").Merge()
                worksheet.Range("E23:E27").Value = subject
                worksheet.Range("F23:F27").Value = section
                worksheet.Range("G23:G27").Value = room
            End If
        End If
        If time_start = "2020-02-11 16:00:00" Then
            If time_end = "2020-02-11 17:00:00" Then
                worksheet.Range("E24:E26").Merge()
                worksheet.Range("F24:F26").Merge()
                worksheet.Range("G24:G26").Merge()
                worksheet.Range("E24:E26").Value = subject
                worksheet.Range("F24:F26").Value = section
                worksheet.Range("G24:G26").Value = room
            ElseIf time_end = "2020-02-11 18:00:00" Then
                worksheet.Range("E24:E28").Merge()
                worksheet.Range("F24:F28").Merge()
                worksheet.Range("G24:G28").Merge()
                worksheet.Range("E24:E28").Value = subject
                worksheet.Range("F24:F28").Value = section
                worksheet.Range("G24:G28").Value = room
            End If
        End If


        ' wednesday


        If time_start = "2020-02-12 06:00:00" Then
            If time_end = "2020-02-12 07:00:00" Then
                worksheet.Range("H4:H6").Merge()
                worksheet.Range("I4:I6").Merge()
                worksheet.Range("J4:J6").Merge()
                worksheet.Range("H4:H6").Value = subject
                worksheet.Range("I4:I6").Value = section
                worksheet.Range("J4:J6").Value = room
            ElseIf time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H4:H8").Merge()
                worksheet.Range("I4:I8").Merge()
                worksheet.Range("J4:J8").Merge()
                worksheet.Range("H4:H8").Value = subject
                worksheet.Range("I4:I8").Value = section
                worksheet.Range("J4:J8").Value = room
            End If
        ElseIf time_start = "2020-02-12 06:30:00" Then

            If time_end = "2020-02-12 07:30:00" Then
                worksheet.Range("H5:H7").Merge()
                worksheet.Range("I5:I7").Merge()
                worksheet.Range("J5:J7").Merge()
                worksheet.Range("H5:H7").Value = subject
                worksheet.Range("I5:I7").Value = section
                worksheet.Range("J5:J7").Value = room
            ElseIf time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H5:H9").Merge()
                worksheet.Range("I5:I9").Merge()
                worksheet.Range("J5:J9").Merge()
                worksheet.Range("H5:H9").Value = subject
                worksheet.Range("I5:I9").Value = section
            End If
            worksheet.Range("J5:J9").Value = room
        ElseIf time_start = "2020-02-12 07:00:00" Then
            If time_end = "2020-02-12 08:00:00" Then
                worksheet.Range("H6:H8").Merge()
                worksheet.Range("I6:I8").Merge()
                worksheet.Range("J6:J8").Merge()
                worksheet.Range("H6:H8").Value = subject
                worksheet.Range("I6:I8").Value = section
                worksheet.Range("J6:J8").Value = room
            ElseIf time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H6:H10").Merge()
                worksheet.Range("I6:I10").Merge()
                worksheet.Range("J6:J10").Merge()
                worksheet.Range("H6:H10").Value = subject
                worksheet.Range("I6:I10").Value = section
                worksheet.Range("J6:J10").Value = room
            End If
        ElseIf time_start = "2020-02-12 07:30:00" Then
            If time_end = "2020-02-12 08:30:00" Then
                worksheet.Range("H7:H9").Merge()
                worksheet.Range("I7:I9").Merge()
                worksheet.Range("J7:J9").Merge()
                worksheet.Range("H7:H9").Value = subject
                worksheet.Range("I7:I9").Value = section
                worksheet.Range("J7:J9").Value = room
            ElseIf time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H7:H11").Merge()
                worksheet.Range("I7:I11").Merge()
                worksheet.Range("J7:J11").Merge()
                worksheet.Range("H7:H11").Value = subject
                worksheet.Range("I7:I11").Value = section
                worksheet.Range("J7:J11").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:00:00" Then
            If time_end = "2020-02-12 09:00:00" Then
                worksheet.Range("H8:H10").Merge()
                worksheet.Range("I8:I10").Merge()
                worksheet.Range("J8:J10").Merge()
                worksheet.Range("H8:H10").Value = subject
                worksheet.Range("I8:I10").Value = section
                worksheet.Range("J8:J10").Value = room
            ElseIf time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H8:H12").Merge()
                worksheet.Range("I8:I12").Merge()
                worksheet.Range("J8:J12").Merge()
                worksheet.Range("H8:H12").Value = subject
                worksheet.Range("I8:I12").Value = section
                worksheet.Range("J8:J12").Value = room
            End If
        ElseIf time_start = "2020-02-12 08:30:00" Then
            If time_end = "2020-02-12 09:30:00" Then
                worksheet.Range("H9:H11").Merge()
                worksheet.Range("I9:I11").Merge()
                worksheet.Range("J9:J11").Merge()
                worksheet.Range("H9:H11").Value = subject
                worksheet.Range("I9:I11").Value = section
                worksheet.Range("J9:J11").Value = room
            ElseIf time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H6:H13").Merge()
                worksheet.Range("I9:I13").Merge()
                worksheet.Range("J9:J13").Merge()
                worksheet.Range("H9:H13").Value = subject
                worksheet.Range("I9:I13").Value = section
                worksheet.Range("J9:J13").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:00:00" Then
            If time_end = "2020-02-12 10:00:00" Then
                worksheet.Range("H10:H12").Merge()
                worksheet.Range("I10:I12").Merge()
                worksheet.Range("J10:J12").Merge()
                worksheet.Range("H10:H12").Value = subject
                worksheet.Range("I10:I12").Value = section
                worksheet.Range("J10:J12").Value = room
            ElseIf time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H10:H14").Merge()
                worksheet.Range("I10:I14").Merge()
                worksheet.Range("J10:J14").Merge()
                worksheet.Range("H10:H14").Value = subject
                worksheet.Range("I10:I14").Value = section
                worksheet.Range("J10:J14").Value = room
            End If
        ElseIf time_start = "2020-02-12 09:30:00" Then
            If time_end = "2020-02-12 10:30:00" Then
                worksheet.Range("H11:H13").Merge()
                worksheet.Range("I11:I13").Merge()
                worksheet.Range("J11:J13").Merge()
                worksheet.Range("H11:H13").Value = subject
                worksheet.Range("I11:I13").Value = section
                worksheet.Range("J11:J13").Value = room
            ElseIf time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H11:H15").Merge()
                worksheet.Range("I11:I15").Merge()
                worksheet.Range("J11:J15").Merge()
                worksheet.Range("H11:H15").Value = subject
                worksheet.Range("I11:I15").Value = section
                worksheet.Range("J11:J15").Value = room
            End If
        ElseIf time_start = "2020-02-12 10:00:00" Then
            If time_end = "2020-02-12 11:00:00" Then
                worksheet.Range("H12:H14").Merge()
                worksheet.Range("I12:I14").Merge()
                worksheet.Range("J12:J14").Merge()
                worksheet.Range("H12:H14").Value = subject
                worksheet.Range("I12:I14").Value = section
                worksheet.Range("J12:J14").Value = room

            ElseIf time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H12:H16").Merge()
                worksheet.Range("I12:I16").Merge()
                worksheet.Range("J12:J16").Merge()
                worksheet.Range("H12:H16").Value = subject
                worksheet.Range("I12:I16").Value = section
                worksheet.Range("J12:J16").Value = room

            End If
        End If
        If time_start = "2020-02-12 10:30:00" Then
            If time_end = "2020-02-12 11:30:00" Then
                worksheet.Range("H13:H15").Merge()
                worksheet.Range("I13:I15").Merge()
                worksheet.Range("J13:J15").Merge()
                worksheet.Range("H13:H15").Value = subject
                worksheet.Range("I13:I15").Value = section
                worksheet.Range("J13:J15").Value = room
            ElseIf time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H13:H17").Merge()
                worksheet.Range("I13:I17").Merge()
                worksheet.Range("J13:J17").Merge()
                worksheet.Range("H13:H17").Value = subject
                worksheet.Range("I13:I17").Value = section
                worksheet.Range("J13:J17").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:00:00" Then
            If time_end = "2020-02-12 12:00:00" Then
                worksheet.Range("H14:H16").Merge()
                worksheet.Range("I14:I16").Merge()
                worksheet.Range("J14:J16").Merge()
                worksheet.Range("H14:H16").Value = subject
                worksheet.Range("I14:I16").Value = section
                worksheet.Range("J14:J16").Value = room
            ElseIf time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H14:H18").Merge()
                worksheet.Range("I14:I18").Merge()
                worksheet.Range("J14:J18").Merge()
                worksheet.Range("H14:H18").Value = subject
                worksheet.Range("I14:I18").Value = section
                worksheet.Range("J14:J18").Value = room
            End If
        ElseIf time_start = "2020-02-12 11:30:00" Then
            If time_end = "2020-02-12 12:30:00" Then
                worksheet.Range("H15:H17").Merge()
                worksheet.Range("I15:I17").Merge()
                worksheet.Range("J15:J17").Merge()
                worksheet.Range("H15:H17").Value = subject
                worksheet.Range("I15:I17").Value = section
                worksheet.Range("J15:J17").Value = room
            ElseIf time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H15:H19").Merge()
                worksheet.Range("I15:I19").Merge()
                worksheet.Range("J15:J19").Merge()
                worksheet.Range("H15:H19").Value = subject
                worksheet.Range("I15:I19").Value = section
                worksheet.Range("J15:J19").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:00:00" Then
            If time_end = "2020-02-12 13:00:00" Then
                worksheet.Range("H16:H14").Merge()
                worksheet.Range("I16:I18").Merge()
                worksheet.Range("J16:J18").Merge()
                worksheet.Range("H16:H18").Value = subject
                worksheet.Range("I16:I18").Value = section
                worksheet.Range("J16:J18").Value = room
            ElseIf time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H16:H20").Merge()
                worksheet.Range("I16:I20").Merge()
                worksheet.Range("J16:J20").Merge()
                worksheet.Range("H16:H20").Value = subject
                worksheet.Range("I16:I20").Value = section
                worksheet.Range("J16:J20").Value = room
            End If
        ElseIf time_start = "2020-02-12 12:30:00" Then
            If time_end = "2020-02-12 13:30:00" Then
                worksheet.Range("H17:H19").Merge()
                worksheet.Range("I17:I19").Merge()
                worksheet.Range("J17:J19").Merge()
                worksheet.Range("H17:H19").Value = subject
                worksheet.Range("I17:I19").Value = section
                worksheet.Range("J17:J19").Value = room
            ElseIf time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H17:H21").Merge()
                worksheet.Range("I17:I21").Merge()
                worksheet.Range("J17:J21").Merge()
                worksheet.Range("H17:H21").Value = subject
                worksheet.Range("I17:I21").Value = section
                worksheet.Range("J17:J21").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:00:00" Then
            If time_end = "2020-02-12 14:00:00" Then
                worksheet.Range("H18:H20").Merge()
                worksheet.Range("I18:I20").Merge()
                worksheet.Range("J18:J20").Merge()
                worksheet.Range("H18:H20").Value = subject
                worksheet.Range("I18:I20").Value = section
                worksheet.Range("J18:J20").Value = room
            ElseIf time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H18:H22").Merge()
                worksheet.Range("I18:I22").Merge()
                worksheet.Range("J18:J22").Merge()
                worksheet.Range("H18:H22").Value = subject
                worksheet.Range("I18:I22").Value = section
                worksheet.Range("J18:J22").Value = room
            End If
        ElseIf time_start = "2020-02-12 13:30:00" Then
            If time_end = "2020-02-12 14:30:00" Then
                worksheet.Range("H19:H21").Merge()
                worksheet.Range("I19:I21").Merge()
                worksheet.Range("J19:J21").Merge()
                worksheet.Range("H19:H21").Value = subject
                worksheet.Range("I19:I21").Value = section
                worksheet.Range("J19:J21").Value = room
            ElseIf time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H19:H23").Merge()
                worksheet.Range("I19:I23").Merge()
                worksheet.Range("J19:J23").Merge()
                worksheet.Range("H19:H23").Value = subject
                worksheet.Range("I19:I23").Value = section
                worksheet.Range("J19:J23").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:00:00" Then
            If time_end = "2020-02-12 15:00:00" Then
                worksheet.Range("H20:H22").Merge()
                worksheet.Range("I20:I22").Merge()
                worksheet.Range("J20:J22").Merge()
                worksheet.Range("H20:H22").Value = subject
                worksheet.Range("I20:I22").Value = section
                worksheet.Range("J20:J22").Value = room
            ElseIf time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H20:H24").Merge()
                worksheet.Range("I20:I24").Merge()
                worksheet.Range("J20:J24").Merge()
                worksheet.Range("H20:H24").Value = subject
                worksheet.Range("I20:I24").Value = section
                worksheet.Range("J20:J24").Value = room
            End If
        ElseIf time_start = "2020-02-12 14:30:00" Then
            If time_end = "2020-02-12 15:30:00" Then
                worksheet.Range("H21:H23").Merge()
                worksheet.Range("I21:I23").Merge()
                worksheet.Range("J21:J23").Merge()
                worksheet.Range("H21:H23").Value = subject
                worksheet.Range("I21:I23").Value = section
                worksheet.Range("J21:J23").Value = room
            ElseIf time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H21:H25").Merge()
                worksheet.Range("I21:I25").Merge()
                worksheet.Range("J21:J25").Merge()
                worksheet.Range("H21:H25").Value = subject
                worksheet.Range("I21:I25").Value = section
                worksheet.Range("J21:J25").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:00:00" Then
            If time_end = "2020-02-12 16:00:00" Then
                worksheet.Range("H22:H24").Merge()
                worksheet.Range("I22:I24").Merge()
                worksheet.Range("J22:J24").Merge()
                worksheet.Range("H22:H24").Value = subject
                worksheet.Range("I22:I24").Value = section
                worksheet.Range("J22:J24").Value = room
            ElseIf time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H22:H26").Merge()
                worksheet.Range("I22:I26").Merge()
                worksheet.Range("J22:J26").Merge()
                worksheet.Range("H22:H26").Value = subject
                worksheet.Range("I22:I26").Value = section
                worksheet.Range("J22:J26").Value = room
            End If
        End If
        If time_start = "2020-02-12 15:30:00" Then
            If time_end = "2020-02-12 16:30:00" Then
                worksheet.Range("H23:H25").Merge()
                worksheet.Range("I23:I25").Merge()
                worksheet.Range("J23:J25").Merge()
                worksheet.Range("H23:H25").Value = subject
                worksheet.Range("I23:I25").Value = section
                worksheet.Range("J23:J25").Value = room
            ElseIf time_end = "2020-02-12 17:30:00" Then
                worksheet.Range("H23:H27").Merge()
                worksheet.Range("I23:I27").Merge()
                worksheet.Range("J23:J27").Merge()
                worksheet.Range("H23:H27").Value = subject
                worksheet.Range("I23:I27").Value = section
                worksheet.Range("J23:J27").Value = room
            End If
        End If
        If time_start = "2020-02-12 16:00:00" Then
            If time_end = "2020-02-12 17:00:00" Then
                worksheet.Range("H24:H26").Merge()
                worksheet.Range("I24:I26").Merge()
                worksheet.Range("J24:J26").Merge()
                worksheet.Range("H24:H26").Value = subject
                worksheet.Range("I24:I26").Value = section
                worksheet.Range("J24:J26").Value = room
            ElseIf time_end = "2020-02-12 18:00:00" Then
                worksheet.Range("H24:H28").Merge()
                worksheet.Range("I24:I28").Merge()
                worksheet.Range("J24:J28").Merge()
                worksheet.Range("H24:H28").Value = subject
                worksheet.Range("I24:I28").Value = section
                worksheet.Range("J24:J28").Value = room
            End If
        End If


        'Thursday

        If time_start = "2020-02-13 06:00:00" Then
            If time_end = "2020-02-13 07:00:00" Then
                worksheet.Range("K4:K6").Merge()
                worksheet.Range("L4:L6").Merge()
                worksheet.Range("M4:M6").Merge()
                worksheet.Range("K4:K6").Value = subject
                worksheet.Range("L4:L6").Value = section
                worksheet.Range("M4:M6").Value = room
            ElseIf time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K4:K8").Merge()
                worksheet.Range("L4:L8").Merge()
                worksheet.Range("M4:M8").Merge()
                worksheet.Range("K4:K8").Value = subject
                worksheet.Range("L4:L8").Value = section
                worksheet.Range("M4:M8").Value = room
            End If
        ElseIf time_start = "2020-02-13 06:30:00" Then

            If time_end = "2020-02-13 07:30:00" Then
                worksheet.Range("K5:K7").Merge()
                worksheet.Range("L5:L7").Merge()
                worksheet.Range("M5:M7").Merge()
                worksheet.Range("K5:K7").Value = subject
                worksheet.Range("L5:L7").Value = section
                worksheet.Range("M5:M7").Value = room
            ElseIf time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K5:K9").Merge()
                worksheet.Range("L5:L9").Merge()
                worksheet.Range("M5:M9").Merge()
                worksheet.Range("K5:K9").Value = subject
                worksheet.Range("L5:L9").Value = section
            End If
            worksheet.Range("M5:M9").Value = room
        ElseIf time_start = "2020-02-13 07:00:00" Then
            If time_end = "2020-02-13 08:00:00" Then
                worksheet.Range("K6:K8").Merge()
                worksheet.Range("L6:L8").Merge()
                worksheet.Range("M6:M8").Merge()
                worksheet.Range("K6:K8").Value = subject
                worksheet.Range("L6:L8").Value = section
                worksheet.Range("M6:M8").Value = room
            ElseIf time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K6:K10").Merge()
                worksheet.Range("L6:L10").Merge()
                worksheet.Range("M6:M10").Merge()
                worksheet.Range("K6:K10").Value = subject
                worksheet.Range("L6:L10").Value = section
                worksheet.Range("M6:M10").Value = room
            End If
        ElseIf time_start = "2020-02-13 07:30:00" Then
            If time_end = "2020-02-13 08:30:00" Then
                worksheet.Range("K7:K9").Merge()
                worksheet.Range("L7:L9").Merge()
                worksheet.Range("M7:M9").Merge()
                worksheet.Range("K7:K9").Value = subject
                worksheet.Range("L7:L9").Value = section
                worksheet.Range("M7:M9").Value = room
            ElseIf time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K7:K11").Merge()
                worksheet.Range("L7:L11").Merge()
                worksheet.Range("M7:M11").Merge()
                worksheet.Range("K7:K11").Value = subject
                worksheet.Range("L7:L11").Value = section
                worksheet.Range("M7:M11").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:00:00" Then
            If time_end = "2020-02-13 09:00:00" Then
                worksheet.Range("K8:K10").Merge()
                worksheet.Range("L8:L10").Merge()
                worksheet.Range("M8:M10").Merge()
                worksheet.Range("K8:K10").Value = subject
                worksheet.Range("L8:L10").Value = section
                worksheet.Range("M8:M10").Value = room
            ElseIf time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K8:K12").Merge()
                worksheet.Range("L8:L12").Merge()
                worksheet.Range("M8:M12").Merge()
                worksheet.Range("K8:K12").Value = subject
                worksheet.Range("L8:L12").Value = section
                worksheet.Range("M8:M12").Value = room
            End If
        ElseIf time_start = "2020-02-13 08:30:00" Then
            If time_end = "2020-02-13 09:30:00" Then
                worksheet.Range("K9:K11").Merge()
                worksheet.Range("L9:L11").Merge()
                worksheet.Range("M9:M11").Merge()
                worksheet.Range("K9:K11").Value = subject
                worksheet.Range("L9:L11").Value = section
                worksheet.Range("M9:M11").Value = room
            ElseIf time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K6:K13").Merge()
                worksheet.Range("L9:L13").Merge()
                worksheet.Range("M9:M13").Merge()
                worksheet.Range("K9:K13").Value = subject
                worksheet.Range("L9:L13").Value = section
                worksheet.Range("M9:M13").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:00:00" Then
            If time_end = "2020-02-13 10:00:00" Then
                worksheet.Range("K10:K12").Merge()
                worksheet.Range("L10:L12").Merge()
                worksheet.Range("M10:M12").Merge()
                worksheet.Range("K10:K12").Value = subject
                worksheet.Range("L10:L12").Value = section
                worksheet.Range("M10:M12").Value = room
            ElseIf time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K10:K14").Merge()
                worksheet.Range("L10:L14").Merge()
                worksheet.Range("M10:M14").Merge()
                worksheet.Range("K10:K14").Value = subject
                worksheet.Range("L10:L14").Value = section
                worksheet.Range("M10:M14").Value = room
            End If
        ElseIf time_start = "2020-02-13 09:30:00" Then
            If time_end = "2020-02-13 10:30:00" Then
                worksheet.Range("K11:K13").Merge()
                worksheet.Range("L11:L13").Merge()
                worksheet.Range("M11:M13").Merge()
                worksheet.Range("K11:K13").Value = subject
                worksheet.Range("L11:L13").Value = section
                worksheet.Range("M11:M13").Value = room
            ElseIf time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K11:K15").Merge()
                worksheet.Range("L11:L15").Merge()
                worksheet.Range("M11:M15").Merge()
                worksheet.Range("K11:K15").Value = subject
                worksheet.Range("L11:L15").Value = section
                worksheet.Range("M11:M15").Value = room
            End If
        ElseIf time_start = "2020-02-13 10:00:00" Then
            If time_end = "2020-02-13 11:00:00" Then
                worksheet.Range("K12:K14").Merge()
                worksheet.Range("L12:L14").Merge()
                worksheet.Range("M12:M14").Merge()
                worksheet.Range("K12:K14").Value = subject
                worksheet.Range("L12:L14").Value = section
                worksheet.Range("M12:M14").Value = room

            ElseIf time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K12:K16").Merge()
                worksheet.Range("L12:L16").Merge()
                worksheet.Range("M12:M16").Merge()
                worksheet.Range("K12:K16").Value = subject
                worksheet.Range("L12:L16").Value = section
                worksheet.Range("M12:M16").Value = room

            End If
        End If
        If time_start = "2020-02-13 10:30:00" Then
            If time_end = "2020-02-13 11:30:00" Then
                worksheet.Range("K13:K15").Merge()
                worksheet.Range("L13:L15").Merge()
                worksheet.Range("M13:M15").Merge()
                worksheet.Range("K13:K15").Value = subject
                worksheet.Range("L13:L15").Value = section
                worksheet.Range("M13:M15").Value = room
            ElseIf time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K13:K17").Merge()
                worksheet.Range("L13:L17").Merge()
                worksheet.Range("M13:M17").Merge()
                worksheet.Range("K13:K17").Value = subject
                worksheet.Range("L13:L17").Value = section
                worksheet.Range("M13:M17").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:00:00" Then
            If time_end = "2020-02-13 12:00:00" Then
                worksheet.Range("K14:K16").Merge()
                worksheet.Range("L14:L16").Merge()
                worksheet.Range("M14:M16").Merge()
                worksheet.Range("K14:K16").Value = subject
                worksheet.Range("L14:L16").Value = section
                worksheet.Range("M14:M16").Value = room
            ElseIf time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K14:K18").Merge()
                worksheet.Range("L14:L18").Merge()
                worksheet.Range("M14:M18").Merge()
                worksheet.Range("K14:K18").Value = subject
                worksheet.Range("L14:L18").Value = section
                worksheet.Range("M14:M18").Value = room
            End If
        ElseIf time_start = "2020-02-13 11:30:00" Then
            If time_end = "2020-02-13 12:30:00" Then
                worksheet.Range("K15:K17").Merge()
                worksheet.Range("L15:L17").Merge()
                worksheet.Range("M15:M17").Merge()
                worksheet.Range("K15:K17").Value = subject
                worksheet.Range("L15:L17").Value = section
                worksheet.Range("M15:M17").Value = room
            ElseIf time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K15:K19").Merge()
                worksheet.Range("L15:L19").Merge()
                worksheet.Range("M15:M19").Merge()
                worksheet.Range("K15:K19").Value = subject
                worksheet.Range("L15:L19").Value = section
                worksheet.Range("M15:M19").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:00:00" Then
            If time_end = "2020-02-13 13:00:00" Then
                worksheet.Range("K16:K14").Merge()
                worksheet.Range("L16:L18").Merge()
                worksheet.Range("M16:M18").Merge()
                worksheet.Range("K16:K18").Value = subject
                worksheet.Range("L16:L18").Value = section
                worksheet.Range("M16:M18").Value = room
            ElseIf time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K16:K20").Merge()
                worksheet.Range("L16:L20").Merge()
                worksheet.Range("M16:M20").Merge()
                worksheet.Range("K16:K20").Value = subject
                worksheet.Range("L16:L20").Value = section
                worksheet.Range("M16:M20").Value = room
            End If
        ElseIf time_start = "2020-02-13 12:30:00" Then
            If time_end = "2020-02-13 13:30:00" Then
                worksheet.Range("K17:K19").Merge()
                worksheet.Range("L17:L19").Merge()
                worksheet.Range("M17:M19").Merge()
                worksheet.Range("K17:K19").Value = subject
                worksheet.Range("L17:L19").Value = section
                worksheet.Range("M17:M19").Value = room
            ElseIf time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K17:K21").Merge()
                worksheet.Range("L17:L21").Merge()
                worksheet.Range("M17:M21").Merge()
                worksheet.Range("K17:K21").Value = subject
                worksheet.Range("L17:L21").Value = section
                worksheet.Range("M17:M21").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:00:00" Then
            If time_end = "2020-02-13 14:00:00" Then
                worksheet.Range("K18:K20").Merge()
                worksheet.Range("L18:L20").Merge()
                worksheet.Range("M18:M20").Merge()
                worksheet.Range("K18:K20").Value = subject
                worksheet.Range("L18:L20").Value = section
                worksheet.Range("M18:M20").Value = room
            ElseIf time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K18:K22").Merge()
                worksheet.Range("L18:L22").Merge()
                worksheet.Range("M18:M22").Merge()
                worksheet.Range("K18:K22").Value = subject
                worksheet.Range("L18:L22").Value = section
                worksheet.Range("M18:M22").Value = room
            End If
        ElseIf time_start = "2020-02-13 13:30:00" Then
            If time_end = "2020-02-13 14:30:00" Then
                worksheet.Range("K19:K21").Merge()
                worksheet.Range("L19:L21").Merge()
                worksheet.Range("M19:M21").Merge()
                worksheet.Range("K19:K21").Value = subject
                worksheet.Range("L19:L21").Value = section
                worksheet.Range("M19:M21").Value = room
            ElseIf time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K19:K23").Merge()
                worksheet.Range("L19:L23").Merge()
                worksheet.Range("M19:M23").Merge()
                worksheet.Range("K19:K23").Value = subject
                worksheet.Range("L19:L23").Value = section
                worksheet.Range("M19:M23").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:00:00" Then
            If time_end = "2020-02-13 15:00:00" Then
                worksheet.Range("K20:K22").Merge()
                worksheet.Range("L20:L22").Merge()
                worksheet.Range("M20:M22").Merge()
                worksheet.Range("K20:K22").Value = subject
                worksheet.Range("L20:L22").Value = section
                worksheet.Range("M20:M22").Value = room
            ElseIf time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K20:K24").Merge()
                worksheet.Range("L20:L24").Merge()
                worksheet.Range("M20:M24").Merge()
                worksheet.Range("K20:K24").Value = subject
                worksheet.Range("L20:L24").Value = section
                worksheet.Range("M20:M24").Value = room
            End If
        ElseIf time_start = "2020-02-13 14:30:00" Then
            If time_end = "2020-02-13 15:30:00" Then
                worksheet.Range("K21:K23").Merge()
                worksheet.Range("L21:L23").Merge()
                worksheet.Range("M21:M23").Merge()
                worksheet.Range("K21:K23").Value = subject
                worksheet.Range("L21:L23").Value = section
                worksheet.Range("M21:M23").Value = room
            ElseIf time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K21:K25").Merge()
                worksheet.Range("L21:L25").Merge()
                worksheet.Range("M21:M25").Merge()
                worksheet.Range("K21:K25").Value = subject
                worksheet.Range("L21:L25").Value = section
                worksheet.Range("M21:M25").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:00:00" Then
            If time_end = "2020-02-13 16:00:00" Then
                worksheet.Range("K22:K24").Merge()
                worksheet.Range("L22:L24").Merge()
                worksheet.Range("M22:M24").Merge()
                worksheet.Range("K22:K24").Value = subject
                worksheet.Range("L22:L24").Value = section
                worksheet.Range("M22:M24").Value = room
            ElseIf time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K22:K26").Merge()
                worksheet.Range("L22:L26").Merge()
                worksheet.Range("M22:M26").Merge()
                worksheet.Range("K22:K26").Value = subject
                worksheet.Range("L22:L26").Value = section
                worksheet.Range("M22:M26").Value = room
            End If
        End If
        If time_start = "2020-02-13 15:30:00" Then
            If time_end = "2020-02-13 16:30:00" Then
                worksheet.Range("K23:K25").Merge()
                worksheet.Range("L23:L25").Merge()
                worksheet.Range("M23:M25").Merge()
                worksheet.Range("K23:K25").Value = subject
                worksheet.Range("L23:L25").Value = section
                worksheet.Range("M23:M25").Value = room
            ElseIf time_end = "2020-02-13 17:30:00" Then
                worksheet.Range("K23:K27").Merge()
                worksheet.Range("L23:L27").Merge()
                worksheet.Range("M23:M27").Merge()
                worksheet.Range("K23:K27").Value = subject
                worksheet.Range("L23:L27").Value = section
                worksheet.Range("M23:M27").Value = room
            End If
        End If
        If time_start = "2020-02-13 16:00:00" Then
            If time_end = "2020-02-13 17:00:00" Then
                worksheet.Range("K24:K26").Merge()
                worksheet.Range("L24:L26").Merge()
                worksheet.Range("M24:M26").Merge()
                worksheet.Range("K24:K26").Value = subject
                worksheet.Range("L24:L26").Value = section
                worksheet.Range("M24:M26").Value = room
            ElseIf time_end = "2020-02-13 18:00:00" Then
                worksheet.Range("K24:K28").Merge()
                worksheet.Range("L24:L28").Merge()
                worksheet.Range("M24:M28").Merge()
                worksheet.Range("K24:K28").Value = subject
                worksheet.Range("L24:L28").Value = section
                worksheet.Range("M24:M28").Value = room
            End If
        End If

        'Fridayyyy========
        If time_start = "2020-02-14 06:00:00" Then
            If time_end = "2020-02-14 07:00:00" Then
                worksheet.Range("N4:N6").Merge()
                worksheet.Range("O4:O6").Merge()
                worksheet.Range("P4:P6").Merge()
                worksheet.Range("N4:N6").Value = subject
                worksheet.Range("O4:O6").Value = section
                worksheet.Range("P4:P6").Value = room
            ElseIf time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N4:N8").Merge()
                worksheet.Range("O4:O8").Merge()
                worksheet.Range("P4:P8").Merge()
                worksheet.Range("N4:N8").Value = subject
                worksheet.Range("O4:O8").Value = section
                worksheet.Range("P4:P8").Value = room
            End If
        ElseIf time_start = "2020-02-14 06:30:00" Then

            If time_end = "2020-02-14 07:30:00" Then
                worksheet.Range("N5:N7").Merge()
                worksheet.Range("O5:O7").Merge()
                worksheet.Range("P5:P7").Merge()
                worksheet.Range("N5:N7").Value = subject
                worksheet.Range("O5:O7").Value = section
                worksheet.Range("P5:P7").Value = room
            ElseIf time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N5:N9").Merge()
                worksheet.Range("O5:O9").Merge()
                worksheet.Range("P5:P9").Merge()
                worksheet.Range("N5:N9").Value = subject
                worksheet.Range("O5:O9").Value = section
            End If
            worksheet.Range("P5:P9").Value = room
        ElseIf time_start = "2020-02-14 07:00:00" Then
            If time_end = "2020-02-14 08:00:00" Then
                worksheet.Range("N6:N8").Merge()
                worksheet.Range("O6:O8").Merge()
                worksheet.Range("P6:P8").Merge()
                worksheet.Range("N6:N8").Value = subject
                worksheet.Range("O6:O8").Value = section
                worksheet.Range("P6:P8").Value = room
            ElseIf time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N6:N10").Merge()
                worksheet.Range("O6:O10").Merge()
                worksheet.Range("P6:P10").Merge()
                worksheet.Range("N6:N10").Value = subject
                worksheet.Range("O6:O10").Value = section
                worksheet.Range("P6:P10").Value = room
            End If
        ElseIf time_start = "2020-02-14 07:30:00" Then
            If time_end = "2020-02-14 08:30:00" Then
                worksheet.Range("N7:N9").Merge()
                worksheet.Range("O7:O9").Merge()
                worksheet.Range("P7:P9").Merge()
                worksheet.Range("N7:N9").Value = subject
                worksheet.Range("O7:O9").Value = section
                worksheet.Range("P7:P9").Value = room
            ElseIf time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N7:N11").Merge()
                worksheet.Range("O7:O11").Merge()
                worksheet.Range("P7:P11").Merge()
                worksheet.Range("N7:N11").Value = subject
                worksheet.Range("O7:O11").Value = section
                worksheet.Range("P7:P11").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:00:00" Then
            If time_end = "2020-02-14 09:00:00" Then
                worksheet.Range("N8:N10").Merge()
                worksheet.Range("O8:O10").Merge()
                worksheet.Range("P8:P10").Merge()
                worksheet.Range("N8:N10").Value = subject
                worksheet.Range("O8:O10").Value = section
                worksheet.Range("P8:P10").Value = room
            ElseIf time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N8:N12").Merge()
                worksheet.Range("O8:O12").Merge()
                worksheet.Range("P8:P12").Merge()
                worksheet.Range("N8:N12").Value = subject
                worksheet.Range("O8:O12").Value = section
                worksheet.Range("P8:P12").Value = room
            End If
        ElseIf time_start = "2020-02-14 08:30:00" Then
            If time_end = "2020-02-14 09:30:00" Then
                worksheet.Range("N9:N11").Merge()
                worksheet.Range("O9:O11").Merge()
                worksheet.Range("P9:P11").Merge()
                worksheet.Range("N9:N11").Value = subject
                worksheet.Range("O9:O11").Value = section
                worksheet.Range("P9:P11").Value = room
            ElseIf time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N6:N13").Merge()
                worksheet.Range("O9:O13").Merge()
                worksheet.Range("P9:P13").Merge()
                worksheet.Range("N9:N13").Value = subject
                worksheet.Range("O9:O13").Value = section
                worksheet.Range("P9:P13").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:00:00" Then
            If time_end = "2020-02-14 10:00:00" Then
                worksheet.Range("N10:N12").Merge()
                worksheet.Range("O10:O12").Merge()
                worksheet.Range("P10:P12").Merge()
                worksheet.Range("N10:N12").Value = subject
                worksheet.Range("O10:O12").Value = section
                worksheet.Range("P10:P12").Value = room
            ElseIf time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N10:N14").Merge()
                worksheet.Range("O10:O14").Merge()
                worksheet.Range("P10:P14").Merge()
                worksheet.Range("N10:N14").Value = subject
                worksheet.Range("O10:O14").Value = section
                worksheet.Range("P10:P14").Value = room
            End If
        ElseIf time_start = "2020-02-14 09:30:00" Then
            If time_end = "2020-02-14 10:30:00" Then
                worksheet.Range("N11:N13").Merge()
                worksheet.Range("O11:O13").Merge()
                worksheet.Range("P11:P13").Merge()
                worksheet.Range("N11:N13").Value = subject
                worksheet.Range("O11:O13").Value = section
                worksheet.Range("P11:P13").Value = room
            ElseIf time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N11:N15").Merge()
                worksheet.Range("O11:O15").Merge()
                worksheet.Range("P11:P15").Merge()
                worksheet.Range("N11:N15").Value = subject
                worksheet.Range("O11:O15").Value = section
                worksheet.Range("P11:P15").Value = room
            End If
        ElseIf time_start = "2020-02-14 10:00:00" Then
            If time_end = "2020-02-14 11:00:00" Then
                worksheet.Range("N12:N14").Merge()
                worksheet.Range("O12:O14").Merge()
                worksheet.Range("P12:P14").Merge()
                worksheet.Range("N12:N14").Value = subject
                worksheet.Range("O12:O14").Value = section
                worksheet.Range("P12:P14").Value = room

            ElseIf time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N12:N16").Merge()
                worksheet.Range("O12:O16").Merge()
                worksheet.Range("P12:P16").Merge()
                worksheet.Range("N12:N16").Value = subject
                worksheet.Range("O12:O16").Value = section
                worksheet.Range("P12:P16").Value = room

            End If
        End If
        If time_start = "2020-02-14 10:30:00" Then
            If time_end = "2020-02-14 11:30:00" Then
                worksheet.Range("N13:N15").Merge()
                worksheet.Range("O13:O15").Merge()
                worksheet.Range("P13:P15").Merge()
                worksheet.Range("N13:N15").Value = subject
                worksheet.Range("O13:O15").Value = section
                worksheet.Range("P13:P15").Value = room
            ElseIf time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N13:N17").Merge()
                worksheet.Range("O13:O17").Merge()
                worksheet.Range("P13:P17").Merge()
                worksheet.Range("N13:N17").Value = subject
                worksheet.Range("O13:O17").Value = section
                worksheet.Range("P13:P17").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:00:00" Then
            If time_end = "2020-02-14 12:00:00" Then
                worksheet.Range("N14:N16").Merge()
                worksheet.Range("O14:O16").Merge()
                worksheet.Range("P14:P16").Merge()
                worksheet.Range("N14:N16").Value = subject
                worksheet.Range("O14:O16").Value = section
                worksheet.Range("P14:P16").Value = room
            ElseIf time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N14:N18").Merge()
                worksheet.Range("O14:O18").Merge()
                worksheet.Range("P14:P18").Merge()
                worksheet.Range("N14:N18").Value = subject
                worksheet.Range("O14:O18").Value = section
                worksheet.Range("P14:P18").Value = room
            End If
        ElseIf time_start = "2020-02-14 11:30:00" Then
            If time_end = "2020-02-14 12:30:00" Then
                worksheet.Range("N15:N17").Merge()
                worksheet.Range("O15:O17").Merge()
                worksheet.Range("P15:P17").Merge()
                worksheet.Range("N15:N17").Value = subject
                worksheet.Range("O15:O17").Value = section
                worksheet.Range("P15:P17").Value = room
            ElseIf time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N15:N19").Merge()
                worksheet.Range("O15:O19").Merge()
                worksheet.Range("P15:P19").Merge()
                worksheet.Range("N15:N19").Value = subject
                worksheet.Range("O15:O19").Value = section
                worksheet.Range("P15:P19").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:00:00" Then
            If time_end = "2020-02-14 13:00:00" Then
                worksheet.Range("N16:N14").Merge()
                worksheet.Range("O16:O18").Merge()
                worksheet.Range("P16:P18").Merge()
                worksheet.Range("N16:N18").Value = subject
                worksheet.Range("O16:O18").Value = section
                worksheet.Range("P16:P18").Value = room
            ElseIf time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N16:N20").Merge()
                worksheet.Range("O16:O20").Merge()
                worksheet.Range("P16:P20").Merge()
                worksheet.Range("N16:N20").Value = subject
                worksheet.Range("O16:O20").Value = section
                worksheet.Range("P16:P20").Value = room
            End If
        ElseIf time_start = "2020-02-14 12:30:00" Then
            If time_end = "2020-02-14 13:30:00" Then
                worksheet.Range("N17:N19").Merge()
                worksheet.Range("O17:O19").Merge()
                worksheet.Range("P17:P19").Merge()
                worksheet.Range("N17:N19").Value = subject
                worksheet.Range("O17:O19").Value = section
                worksheet.Range("P17:P19").Value = room
            ElseIf time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N17:N21").Merge()
                worksheet.Range("O17:O21").Merge()
                worksheet.Range("P17:P21").Merge()
                worksheet.Range("N17:N21").Value = subject
                worksheet.Range("O17:O21").Value = section
                worksheet.Range("P17:P21").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:00:00" Then
            If time_end = "2020-02-14 14:00:00" Then
                worksheet.Range("N18:N20").Merge()
                worksheet.Range("O18:O20").Merge()
                worksheet.Range("P18:P20").Merge()
                worksheet.Range("N18:N20").Value = subject
                worksheet.Range("O18:O20").Value = section
                worksheet.Range("P18:P20").Value = room
            ElseIf time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N18:N22").Merge()
                worksheet.Range("O18:O22").Merge()
                worksheet.Range("P18:P22").Merge()
                worksheet.Range("N18:N22").Value = subject
                worksheet.Range("O18:O22").Value = section
                worksheet.Range("P18:P22").Value = room
            End If
        ElseIf time_start = "2020-02-14 13:30:00" Then
            If time_end = "2020-02-14 14:30:00" Then
                worksheet.Range("N19:N21").Merge()
                worksheet.Range("O19:O21").Merge()
                worksheet.Range("P19:P21").Merge()
                worksheet.Range("N19:N21").Value = subject
                worksheet.Range("O19:O21").Value = section
                worksheet.Range("P19:P21").Value = room
            ElseIf time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N19:N23").Merge()
                worksheet.Range("O19:O23").Merge()
                worksheet.Range("P19:P23").Merge()
                worksheet.Range("N19:N23").Value = subject
                worksheet.Range("O19:O23").Value = section
                worksheet.Range("P19:P23").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:00:00" Then
            If time_end = "2020-02-14 15:00:00" Then
                worksheet.Range("N20:N22").Merge()
                worksheet.Range("O20:O22").Merge()
                worksheet.Range("P20:P22").Merge()
                worksheet.Range("N20:N22").Value = subject
                worksheet.Range("O20:O22").Value = section
                worksheet.Range("P20:P22").Value = room
            ElseIf time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N20:N24").Merge()
                worksheet.Range("O20:O24").Merge()
                worksheet.Range("P20:P24").Merge()
                worksheet.Range("N20:N24").Value = subject
                worksheet.Range("O20:O24").Value = section
                worksheet.Range("P20:P24").Value = room
            End If
        ElseIf time_start = "2020-02-14 14:30:00" Then
            If time_end = "2020-02-14 15:30:00" Then
                worksheet.Range("N21:N23").Merge()
                worksheet.Range("O21:O23").Merge()
                worksheet.Range("P21:P23").Merge()
                worksheet.Range("N21:N23").Value = subject
                worksheet.Range("O21:O23").Value = section
                worksheet.Range("P21:P23").Value = room
            ElseIf time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N21:N25").Merge()
                worksheet.Range("O21:O25").Merge()
                worksheet.Range("P21:P25").Merge()
                worksheet.Range("N21:N25").Value = subject
                worksheet.Range("O21:O25").Value = section
                worksheet.Range("P21:P25").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:00:00" Then
            If time_end = "2020-02-14 16:00:00" Then
                worksheet.Range("N22:N24").Merge()
                worksheet.Range("O22:O24").Merge()
                worksheet.Range("P22:P24").Merge()
                worksheet.Range("N22:N24").Value = subject
                worksheet.Range("O22:O24").Value = section
                worksheet.Range("P22:P24").Value = room
            ElseIf time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N22:N26").Merge()
                worksheet.Range("O22:O26").Merge()
                worksheet.Range("P22:P26").Merge()
                worksheet.Range("N22:N26").Value = subject
                worksheet.Range("O22:O26").Value = section
                worksheet.Range("P22:P26").Value = room
            End If
        End If
        If time_start = "2020-02-14 15:30:00" Then
            If time_end = "2020-02-14 16:30:00" Then
                worksheet.Range("N23:N25").Merge()
                worksheet.Range("O23:O25").Merge()
                worksheet.Range("P23:P25").Merge()
                worksheet.Range("N23:N25").Value = subject
                worksheet.Range("O23:O25").Value = section
                worksheet.Range("P23:P25").Value = room
            ElseIf time_end = "2020-02-14 17:30:00" Then
                worksheet.Range("N23:N27").Merge()
                worksheet.Range("O23:O27").Merge()
                worksheet.Range("P23:P27").Merge()
                worksheet.Range("N23:N27").Value = subject
                worksheet.Range("O23:O27").Value = section
                worksheet.Range("P23:P27").Value = room
            End If
        End If
        If time_start = "2020-02-14 16:00:00" Then
            If time_end = "2020-02-14 17:00:00" Then
                worksheet.Range("N24:N26").Merge()
                worksheet.Range("O24:O26").Merge()
                worksheet.Range("P24:P26").Merge()
                worksheet.Range("N24:N26").Value = subject
                worksheet.Range("O24:O26").Value = section
                worksheet.Range("P24:P26").Value = room
            ElseIf time_end = "2020-02-14 18:00:00" Then
                worksheet.Range("N24:N28").Merge()
                worksheet.Range("O24:O28").Merge()
                worksheet.Range("P24:P28").Merge()
                worksheet.Range("N24:N28").Value = subject
                worksheet.Range("O24:O28").Value = section
                worksheet.Range("P24:P28").Value = room
            End If
        End If
    End Sub
    Private Sub CreateExcelSchedule_format()
        Dim misvalue As Object = Reflection.Missing.Value
        APP = New Excel.Application
        workbook = APP.Workbooks.Add(misvalue)
        worksheet = workbook.Sheets("Sheet1")
        worksheet.Range("A2:P25").BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
        'worksheet = workbook.Sheets(name)
        worksheet.Range("A1:E1").Merge()
        'time set
        worksheet.Range("A2:A3").Merge()
        worksheet.Range("A2:A3").Value = "Time"

        'monday slot
        worksheet.Range("B2:D2").Merge()
        worksheet.Range("B2:D2").Value = "Monday"
        'tuesday slot
        worksheet.Range("E2:G2").Merge()
        worksheet.Range("E2:G2").Value = "Tuesday"
        'wednesday slot
        worksheet.Range("H2:J2").Merge()
        worksheet.Range("H2:J2").Value = "Wednesday"
        'thursday slot
        worksheet.Range("K2:M2").Merge()
        worksheet.Range("K2:M2").Value = "Thursday"
        'friday slot
        worksheet.Range("N2:P2").Merge()
        worksheet.Range("N2:P2").Value = "Friday"
        '====================================================================

        worksheet.Range("B3").Value = "Subject"
        worksheet.Range("E3").Value = "Subject"
        worksheet.Range("H3").Value = "Subject"
        worksheet.Range("K3").Value = "Subject"
        worksheet.Range("N3").Value = "Subject"

        worksheet.Range("C3").Value = "Section"
        worksheet.Range("F3").Value = "Section"
        worksheet.Range("I3").Value = "Section"
        worksheet.Range("L3").Value = "Section"
        worksheet.Range("O3").Value = "Section"

        worksheet.Range("D3").Value = "Room"
        worksheet.Range("G3").Value = "Room"
        worksheet.Range("J3").Value = "Room"
        worksheet.Range("M3").Value = "Room"
        worksheet.Range("P3").Value = "Room"
        'Timesett
        worksheet.Range("A4").Value = "6:00"
        worksheet.Range("A5").Value = "6:30"
        worksheet.Range("A6").Value = "7:00"
        worksheet.Range("A7").Value = "7:30"
        worksheet.Range("A8").Value = "8:00"
        worksheet.Range("A9").Value = "8:30"
        worksheet.Range("A10").Value = "9:00"
        worksheet.Range("A11").Value = "9:30"
        worksheet.Range("A12").Value = "10:00"
        worksheet.Range("A13").Value = "10:30"
        worksheet.Range("A14").Value = "11:00"
        worksheet.Range("A15").Value = "11:30"
        worksheet.Range("A16").Value = "12:00"
        worksheet.Range("A17").Value = "12:30"
        worksheet.Range("A18").Value = "1:00"
        worksheet.Range("A19").Value = "1:30"
        worksheet.Range("A20").Value = "2:00"
        worksheet.Range("A21").Value = "2:30"
        worksheet.Range("A22").Value = "3:00"
        worksheet.Range("A23").Value = "3:30"
        worksheet.Range("A24").Value = "4:00"
        worksheet.Range("A25").Value = "4:30"
        worksheet.Range("A25").Value = "5:00"
        'Format of the alignment
        worksheet.Range("B4:P25").WrapText = True
        worksheet.Range("A2:P25").HorizontalAlignment = HorizontalAlignment.Center
        'Lines for tim



    End Sub

    Private Sub location_text_TextChanged(sender As Object, e As EventArgs) Handles location_text.TextChanged
        print_ex_but.Enabled = True
    End Sub
End Class

