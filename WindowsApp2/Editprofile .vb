Imports MySql.Data.MySqlClient
Public Class edit_profile


    Dim read1 As MySqlDataReader
    Dim sconn1 As New SQLCn
    Dim table1 As New DataTable
    Dim adapt1 As New MySqlDataAdapter
    Dim commnd1 As New MySqlCommand


    'Exiting the Form Solution_________Functions_______________________
    Private Function Solut_exitAddForm1() As Boolean
        If String.IsNullOrEmpty(name_First2.Text) And String.IsNullOrEmpty(name_Last3.Text) And String.IsNullOrEmpty(name_MIt.Text) Then
            'String.IsNullOrEmpty(time_assignn.Text) And String.IsNullOrEmpty(sub_teachh.Text) Then
            Return True
        End If
        Return False
    End Function
    Private Function numbrFun() As Boolean
        If IsNumeric(name_First2.Text) And IsNumeric(name_Last3.Text) And IsNumeric(name_MIt.Text) Then
            'String.IsNullOrEmpty(time_assign.Text) And String.IsNullOrEmpty(sub_teach.Text) 
            Return True
        End If
        Return False
    End Function
    Private Function NullorEmpty1() As Boolean
        For Each a As Control In prof_grp3.Controls
            If TypeOf a Is TextBox Then
                If String.IsNullOrEmpty(a.Text) Then
                    Return True
                End If
            End If
        Next
        'For Each a As Control In back_grpb.Controls
        '    If TypeOf a Is ComboBox Then
        '        If String.IsNullOrEmpty(a.Text) Then
        '            Return True
        '        End If
        '    End If
        'Next
        Return False
    End Function
    'Function to enable the forms
    Public Sub EnablingForms1()
        For Each c As Control In ActiveForm.Controls
            If c.Enabled = False Then
                c.Enabled = True
            End If
        Next
        For Each c As Control In TeachersTab.Controls
            If c.Enabled = False Then
                c.Enabled = True
            End If
        Next

    End Sub
    '


    'Buttons______________________________________Sender to apply at SQL
    Public Sub Adder_Click(sender As Object, e As EventArgs) Handles addedrBtnn.Click
        'DeclarationVariable
        Dim selectedrow As Integer = (TeachersTab.dataShowTeacher.SelectedRows(0).Cells("IDProf").Value)
        'time_lot = time_assignn.Text
        'sub_t = sub_teachh.Text
        Dim update As String

        update = ("UPDATE `prof_details_tbl` SET `FName_prof`= @tLN , `LName_prof` = @Lnp , `MName_prof`=@Mnp where ID_Prof='" & selectedrow & "'")


        'Checker______________________
        If NullorEmpty1() = True Then
            MessageBox.Show("Incomplete, Please fill the Fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
            'MAin Conn to submit in DAtaBase
        ElseIf numbrFun = True Then
            MessageBox.Show("Only Characters may enter", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Try 'Checking of Existing Profile___________Function___________________



                sconn1.CloseConnection()

                commnd1 = New MySqlCommand(update, sconn1.GetConnection)


                commnd1 = New MySqlCommand(update, sconn1.GetConnection)
                commnd1.Parameters.Add("@tLN", MySqlDbType.VarChar).Value = name_First2.Text
                commnd1.Parameters.Add("@Lnp", MySqlDbType.VarChar).Value = name_Last3.Text
                commnd1.Parameters.Add("@Mnp", MySqlDbType.VarChar).Value = name_MIt.Text
 


                sconn1.OpenConnection()

                If commnd1.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Profile has been Successfully Updated", "Profile Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sconn1.CloseConnection()

                Else
                    MessageBox.Show("Something Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sconn1.CloseConnection()
                End If
                EnablingForms1()
                Call TeachersTab.BindGrid()
                Me.Close()


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            Exit Sub
        End If

        'TeachersTab.BindDatatoGridSlter()


        'TeachersTab.binddatatogrid()
        TeachersTab.dataShowTeacher.Refresh()
    End Sub


    'CANCEL BUTTON__________________________________________________________________
    Private Sub CancBtn_Click(sender As Object, e As EventArgs) Handles cancBtnn.Click
        If Solut_exitAddForm1() = True Then

            Me.Close()
        Else
            Dim Reply
            Reply = MessageBox.Show("Are you sure want to leave? The information will be unsaved.", "Without Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Reply = vbYes Then
                Me.Close()
            End If
        End If
        EnablingForms1()
        TeachersTab.dataShowTeacher.Refresh()
        'TeachersTab.BindDatatoGridSlter()


    End Sub

    Private Sub AddingNew_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SlotprofDataSetWhole.subjects_tbl' table. You can move, or remove it, as needed.

        GunaAnimate_addProfh.Start()
    End Sub


    Private Sub name_Last_KeyPress(sender As Object, e As KeyPressEventArgs) Handles name_Last3.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("Only Letter are Allowed!", "Invalid Letter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub name_First_KeyPress(sender As Object, e As KeyPressEventArgs) Handles name_First2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("Only Letter are Allowed!", "Invalid Letter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub name_MI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles name_MIt.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("Only Letter are Allowed!", "Invalid Letter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class