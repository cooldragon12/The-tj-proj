Imports System.Drawing.Printing


Public Class Main_inper


    Private Sub Main_inper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel2.Hide()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(mainMenu_inper, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

    End Sub

    'Properties tab main
    Private Sub MainMenu_inper_Animation(sender As Object, e As EventArgs) Handles mainMenu_inper.MouseEnter, teach_Sched.MouseEnter, room_SchedBtn.MouseEnter, print_exportBtnMain.MouseEnter
        'If mainMenu_inper.Width = 54 Then
        While (mainMenu_inper.Width < 184)
            mainMenu_inper.Width += 2
        End While
        'End If
        'Guna.UI.Animation.AnimationType.HorizSlide = 2
    End Sub
    Private Sub MainMenu_inper_Animation2(sender As Object, e As EventArgs) Handles mainMenu_inper.MouseLeave, teach_Sched.MouseLeave, room_SchedBtn.MouseLeave, print_exportBtnMain.MouseLeave

        'If Not mainMenu_inper.Width = 54 Then
        While (mainMenu_inper.Width > 54)
            mainMenu_inper.Width -= 2
        End While
        'mainMenu_inper.Width = 54
        'End If
    End Sub




    Private Sub Room_SchedBtn_Click(sender As Object, e As EventArgs) Handles room_SchedBtn.Click
        If room_SchedBtn.LineLeft = 0 Then
            room_SchedBtn.LineLeft = 4
            If teach_Sched.LineLeft = 4 Then
                teach_Sched.LineLeft = 0

            End If

        End If
        If print_exportBtnMain.LineLeft = 4 Then
            print_exportBtnMain.LineLeft = 0
        End If
    End Sub
    Private Sub Teacher_SchedBtn_Click(sender As Object, e As EventArgs) Handles teach_Sched.Click
        'call
        TeachersTab.MdiParent = Me
        With TeachersTab
            .Dock = DockStyle.Fill
            .Activate()
            .Show()
        End With

        'For Each c As MouseButtons In teach_Sched.Controls
        '    If c Is vb Then

        'Animation
        If teach_Sched.LineLeft = 0 Then
            teach_Sched.LineLeft = 4
            If room_SchedBtn.LineLeft = 4 Then
                room_SchedBtn.LineLeft = 0


            End If
        End If
        If print_exportBtnMain.LineLeft = 4 Then
            print_exportBtnMain.LineLeft = 0
        End If
    End Sub
    Private Sub PintBtn_Click(sender As Object, e As EventArgs) Handles print_exportBtnMain.Click

        If print_exportBtnMain.LineLeft = 0 Then
            print_exportBtnMain.LineLeft = 4
            If teach_Sched.LineLeft = 4 Then
                teach_Sched.LineLeft = 0

            End If
        End If
        If room_SchedBtn.LineLeft = 4 Then
            room_SchedBtn.LineLeft = 0


        End If
    End Sub




    'Panel for welcome
    Private Sub Teachersbutoong(sender As Object, e As EventArgs) Handles Teacher_sched_button.Click
        GunaPanel1.Hide()
        With SelectSt
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With

        teach_Sched.LineLeft = 4
        'teach_Sched.LineLeft = 4
        '    If room_SchedBtn.LineLeft = 4 Then
        '        room_SchedBtn.LineLeft = 0

        '    End If
        'End If
        'If print_exportBtnMain.LineLeft = 4 Then
        '    print_exportBtnMain.LineLeft = 0
        'End If
    End Sub



    Private Sub GunaTileButton3_Click(sender As Object, e As EventArgs) Handles export_vutton.Click
        With GunaPanel1
            GunaPanel1.Hide()
        End With

        With Prixport_Form
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
        End With


    End Sub





    Private Sub PrintDoc_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDoc.BeginPrint
        MsgBox("Begin Print")
    End Sub

    Private Sub PrintDoc_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDoc.EndPrint
        MsgBox("End Print")
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        MsgBox("You are in Print Page")
    End Sub

    Private Sub PrintDoc_QueryPageSettings(sender As Object, e As Printing.QueryPageSettingsEventArgs) Handles PrintDoc.QueryPageSettings
        MsgBox("You called query print")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub backBttn_Click(sender As Object, e As EventArgs) Handles backBttn.Click
        With Panel2
            .Hide()

        End With
        With Panel4
            .Show()
            .BringToFront()
        End With
        SchedulingForm.Close()
        TeachersTab.Show()

    End Sub
End Class
