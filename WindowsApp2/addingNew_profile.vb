Imports MySql.Data.MySqlClient
Public Class addingNew_profile
    Dim read As MySqlDataReader
    Dim sconn As New SQLCn
    Dim table As New DataTable
    Dim adapt As New MySqlDataAdapter
    Dim commnd As New MySqlCommand
    Dim Filter As Integer

    'Exiting the Form Solution_________Functions_______________________
    Private Function Solut_exitAddForm() As Boolean
        If String.IsNullOrEmpty(name_First.Text) And String.IsNullOrEmpty(name_Last.Text) Then
            'String.IsNullOrEmpty(time_assign.Text) And String.IsNullOrEmpty(sub_teach.Text) 
            Return True
        End If
        Return False
    End Function

    Private Function numbrFun() As Boolean
        If IsNumeric(name_First.Text) And IsNumeric(name_Last.Text) And IsNumeric(name_MI.Text) Then
            'String.IsNullOrEmpty(time_assign.Text) And String.IsNullOrEmpty(sub_teach.Text) 
            Return True
        End If
        Return False
    End Function
    'Private Function NullorEmpty() As Boolean
    '    For Each a As Control In prof_grp.Controls
    '        If TypeOf a Is TextBox Then
    '            If String.IsNullOrEmpty(a.Text) Then
    '                Return True
    '            End If
    '        End If
    '    Next
    '    'For Each a As Control In back_grp.Controls
    '    '    If TypeOf a Is ComboBox Then
    '    '        If String.IsNullOrEmpty(a.Text) Then
    '    '            Return True
    '    '        End If
    '    '    End If
    '    'Next
    '    Return False
    'End Function
    'Function to enable the forms
    Public Sub EnablingForms()
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
    'Exitting____________________________________________________________



    'check_______________________________________________________________

    'Buttons______________________________________Sender to apply at SQL
    Public Sub Adder_Click(sender As Object, e As EventArgs) Handles addedrBtn.Click
        'DeclarationVariable
        Dim nf As String
        Dim lf As String
        lf = name_Last.Text
        nf = name_First.Text
        'sub_t = sub_teach.Text

        'fullName_Prof' =" &  & " WHERE FName_prof='" & name_First2 & "' and subject =" & sub_t & "' and A.M./P.M. = " & time_lot & "' and LName_prof='" & name_Last3 & "' and MName_prof='" & name_MIt & " '"
        Dim insertNew As String
        Dim checkex As String
        insertNew = ("INSERT INTO `prof_details_tbl`(`FName_prof`, `LName_prof`, `MName_prof`) VALUES ( @Fnp, @Lnp, @Mnp)")
        'insertNew = ("INSERT INTO `prof_details_tbl`(`FName_prof`, `LName_prof`, `MName_prof`, `A.M./P.M.`) VALUES (@Fnp, @Lnp, @Mnpx, @tlot)")
        checkex = ("select * FROM prof_details_tbl WHERE FName_prof='" + nf + "' and LName_prof='" + lf + "'")

        'Checker______________________
        If Solut_exitAddForm() = True Then
            MessageBox.Show("Incomplete, Please fill the Fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
            'MAin Conn to submit in DAtaBase

        ElseIf numbrFun() = True Then
            MessageBox.Show("Only Characters may enter", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Try 'Checking of Existing Profile___________Function___________________
                sconn.OpenConnection()
                commnd = New MySqlCommand(checkex, sconn.GetConnection)
                read = commnd.ExecuteReader
                If read.HasRows Then
                    MessageBox.Show("The Profile is Existing", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    sconn.CloseConnection()
                    read.Close()
                Else
                    sconn.CloseConnection()

                    Dim contain As String
                    contain = ""

                    commnd = New MySqlCommand(insertNew, sconn.GetConnection)
                    'commnd.Parameters.Add("@id", MySqlDbType.VarChar).Value = name_First
                    commnd.Parameters.Add("@Fnp", MySqlDbType.VarChar).Value = name_First.Text
                    commnd.Parameters.Add("@Lnp", MySqlDbType.VarChar).Value = name_Last.Text
                    commnd.Parameters.Add("@Mnp", MySqlDbType.VarChar).Value = name_MI.Text

                    'commnd.Parameters.Add("@st", MySqlDbType.VarChar).Value = sub_teach.Text

                    sconn.OpenConnection()

                    If commnd.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Profile has been Successfully Added", "Profile Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        sconn.CloseConnection()
                        TeachersTab.BindGrid()
                        TeachersTab.addProf.Enabled = True
                        Me.Close()

                    Else
                        MessageBox.Show("Something Wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        sconn.CloseConnection()
                    End If
                    'sub_teach_Selected()





                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            Exit Sub

        End If




    End Sub


    'CANCEL BUTTON__________________________________________________________________
    Private Sub CancBtn_Click(sender As Object, e As EventArgs) Handles cancBtn.Click
        If Solut_exitAddForm() = True Then
            TeachersTab.addProf.Enabled = True
            Me.Close()
        Else
            Dim Reply
            Reply = MessageBox.Show("Are you sure want to leave? The information will be unsaved.", "Without Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Reply = vbYes Then
                TeachersTab.addProf.Enabled = True
                Me.Close()

            End If
        End If

    End Sub

    Private Sub AddingNew_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SlotprofDataSet.subjects_tbl' table. You can move, or remove it, as needed.

        GunaAnimate_addProf.Start()

    End Sub

End Class