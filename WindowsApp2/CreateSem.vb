Imports MySql.Data.MySqlClient
Public Class CreateSem
    Dim sconn As New SQLCn
    Dim read As MySqlDataReader
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim s As String = year1.Text
        Dim s2 As String = year2.Text

        Dim t1 As Integer = s
        Dim t2 As Integer = s2
        If s > s2 Or (s + 1) < s2 Or s = s2 Then
            MessageBox.Show("Invalid School Year!", "Invalid Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf semnumber.Text = "" Then
            MessageBox.Show("Please select semester", "Semester no input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim que As String = "INSERT INTO schoolterm(`sy`,`semestral`) VALUES (@sr,@sn)"
            Dim comm As MySqlCommand
            Dim sy As String

            sy = year1.Text & "-" & year2.Text
            Dim check As String = ("SELECT * from schoolterm where sy='" & sy & "'and semestral='" & semnumber.Text & "'")
            sconn.OpenConnection()
            comm = New MySqlCommand(check, sconn.GetConnection)
            read = comm.ExecuteReader
            If read.HasRows Then
                MessageBox.Show("The school and semester has already existing", "Duplicate Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                sconn.CloseConnection()
                read.Close()
            Else
                read.Close()
                comm = New MySqlCommand(que, sconn.GetConnection)

                comm.Parameters.Add("@sr", MySqlDbType.VarChar).Value = sy
                comm.Parameters.Add("@sn", MySqlDbType.VarChar).Value = semnumber.Text

                sconn.OpenConnection()
                If comm.ExecuteNonQuery() = 1 Then
                    Me.Close()
                    SelectSt.module_load()
                    sconn.CloseConnection()
                End If
            End If
        End If



    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Me.Close()
    End Sub
End Class
