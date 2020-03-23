Public Class WelcomeTab


    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs) Handles GunaTileButton1.Click
        Main_inper.BringToFront()
        Main_inper.Focus()

        SelectSt.MdiParent = Main_inper
        Me.Hide()
    End Sub

    Private Sub WelcomeTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main_inper.Show()
        Main_inper.SendToBack()
    End Sub
End Class