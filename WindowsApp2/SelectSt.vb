Imports MySql.Data.MySqlClient

Public Class SelectSt

    Dim sconn As New SQLCn
    Dim cmm As MySqlCommand
    Dim schoolterm As String
    Dim schoolterm2 As String
    Dim read As MySqlDataReader
    Public Sub module_load()
        schedsy_combo.Items.Clear()
        Try
            sconn.CloseConnection()
            sconn.OpenConnection()
            cmm = New MySqlCommand("SELECT * from schoolterm", sconn.GetConnection)
            read = cmm.ExecuteReader
            While read.Read
                schoolterm = read.GetString("sy")
                schedsy_combo.Items.Add(schoolterm)

            End While


            read.Close()

            sconn.CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error")
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        module_load()
    End Sub

    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Me.Hide()

        With TeachersTab
            .MdiParent = Main_inper
            .Show()
            .Dock = DockStyle.Fill
        End With
    End Sub




    Private Sub create_button_Click(sender As Object, e As EventArgs) Handles create_button.Click
        With CreateSem
            .MdiParent = Main_inper

            .Show()
            .Dock = DockStyle.Fill
        End With
    End Sub
End Class