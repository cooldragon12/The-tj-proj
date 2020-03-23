<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SchedulingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.guna_add_edit_g = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel36 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel35 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel34 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel33 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel41 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel39 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel40 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel38 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel37 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.time_end_combo = New Guna.UI.WinForms.GunaComboBox()
        Me.time_combo = New Guna.UI.WinForms.GunaComboBox()
        Me.day_combo = New Guna.UI.WinForms.GunaComboBox()
        Me.subject_cmbo = New Guna.UI.WinForms.GunaComboBox()
        Me.SubjectstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SlotprofDataSetAll = New PrjectScheduling.slotprofDataSetAll()
        Me.add_nSection = New Guna.UI.WinForms.GunaLinkLabel()
        Me.add_nRoom = New Guna.UI.WinForms.GunaLinkLabel()
        Me.sectionlbl = New Guna.UI.WinForms.GunaLabel()
        Me.roomlbl = New Guna.UI.WinForms.GunaLabel()
        Me.section_dropdonw = New Guna.UI.WinForms.GunaComboBox()
        Me.gradLvel_drop = New Guna.UI.WinForms.GunaComboBox()
        Me.Track_dropdown = New Guna.UI.WinForms.GunaComboBox()
        Me.room_dropdown = New Guna.UI.WinForms.GunaComboBox()
        Me.build_dropbox = New Guna.UI.WinForms.GunaComboBox()
        Me.add_dragItemBttn = New Guna.UI.WinForms.GunaButton()
        Me.update_button = New Guna.UI.WinForms.GunaButton()
        Me.ScheduletblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SlotprofDataSetAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScheduletblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfdetailstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionstblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Room1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomtblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Subjects_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.subjects_tblTableAdapter()
        Me.RoomtblBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Room_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.room_tblTableAdapter()
        Me.BuildingnoroomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Schedule_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.schedule_tblTableAdapter()
        Me.Sections_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.sections_tblTableAdapter()
        Me.Prof_details_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.prof_details_tblTableAdapter()
        Me.calendar_Main = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel21 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel30 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel29 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel28 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel27 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel26 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel32 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel31 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel25 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel24 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel23 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel19 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel18 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLineTextBox11 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox10 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox9 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox8 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox7 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox6 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox5 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox4 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox3 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaPanel9 = New Guna.UI.WinForms.GunaPanel()
        Me.friday_600PM = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_600 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_300 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_300 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel145 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_1130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_1130 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_230 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_1100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_1100 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_200 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_530 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_530 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_1030 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_1030 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_130 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_1000 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_1000 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_100 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_930 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_930 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_500 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_500 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_1230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_1230 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_900 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_900 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_1200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_1200 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_830 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_830 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_800 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_800 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_430 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_430 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_730 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_730 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_700 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_700 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_630AM = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_630 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_330 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel42 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_Friday_330 = New Guna.UI.WinForms.GunaLabel()
        Me.friday_400 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Friday_400 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel8 = New Guna.UI.WinForms.GunaPanel()
        Me.thursday_600PM = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_600 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_300 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_300 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_1130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_1130 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_230 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_1100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_1100 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_530 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_530 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_200 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_1030 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_1030 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_130 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_1000 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_1000 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_500 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_500 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_100 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_930 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_930 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_1230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_1230 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_900 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_900 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_430 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_430 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_1200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_1200 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_830 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_830 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_800 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_800 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_730 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_730 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_400 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_400 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_700 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_700 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_630 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_630 = New Guna.UI.WinForms.GunaLabel()
        Me.thursday_330 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Thursday_330 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel6 = New Guna.UI.WinForms.GunaPanel()
        Me.wednes_600PM = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_600 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_300 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_300 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_1130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_1130 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_230 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_530 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_530 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_1100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_1100 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_200 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_1030 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_1030 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_500 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_500 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_130 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_1000 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_1000 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_100 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_430 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_430 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_930 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_930 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_1230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_1230 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_900 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_900 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_400 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_400 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_1200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_1200 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_830 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_830 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_800 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_800 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_330 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_330 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_730 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_730 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_700 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_700 = New Guna.UI.WinForms.GunaLabel()
        Me.wednes_630 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Wednesday_630 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel28 = New Guna.UI.WinForms.GunaPanel()
        Me.tuesday_600PM = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_600 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_300 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_300 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_1130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_1130 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_530 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_530 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_230 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_1100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_1100 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_500 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_500 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_200 = New Guna.UI.WinForms.GunaLabel()
        Me.tueasday_1030 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_1030 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_430 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_430 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_130 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_1000 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_1000 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_400 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_400 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_100 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_930 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_930 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_330 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_330 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_1230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_1230 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_900 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_900 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_1200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_1200 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_830 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_830 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_800 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_800 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_730 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_730 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_700 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_700 = New Guna.UI.WinForms.GunaLabel()
        Me.tuesday_630AM = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Tuesday_630 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.monday_630 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_700 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_600PM = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_600 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_530 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_530 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_300 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_300 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_1130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_1130 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_700 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_630 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_500 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_500 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_230 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_1100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_1100 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_430 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_430 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_200 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_1030 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_1030 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_400 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_400 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_130 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_130 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_1000 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_1000 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_330 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_330 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_100 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_100 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_930 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_930 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_1230 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_1230 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_900 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_900 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_1200 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_1200 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_830 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_830 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_800 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_800 = New Guna.UI.WinForms.GunaLabel()
        Me.monday_730 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_Monday_730 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.SlotprofDataSetAll1 = New PrjectScheduling.slotprofDataSetAll()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.del_bot_sched7 = New Guna.UI.WinForms.GunaImageButton()
        Me.del_bot_sched6 = New Guna.UI.WinForms.GunaImageButton()
        Me.del_bot_sched5 = New Guna.UI.WinForms.GunaImageButton()
        Me.del_bot_sched8 = New Guna.UI.WinForms.GunaImageButton()
        Me.del_bot_sched4 = New Guna.UI.WinForms.GunaImageButton()
        Me.del_bot_sched3 = New Guna.UI.WinForms.GunaImageButton()
        Me.del_bot_sched2 = New Guna.UI.WinForms.GunaImageButton()
        Me.edit_bot_sched8 = New Guna.UI.WinForms.GunaImageButton()
        Me.edit_bot_sched7 = New Guna.UI.WinForms.GunaImageButton()
        Me.edit_bot_sched6 = New Guna.UI.WinForms.GunaImageButton()
        Me.edit_bot_sched5 = New Guna.UI.WinForms.GunaImageButton()
        Me.edit_bot_sched4 = New Guna.UI.WinForms.GunaImageButton()
        Me.edit_bot_sched3 = New Guna.UI.WinForms.GunaImageButton()
        Me.edit_bot_sched2 = New Guna.UI.WinForms.GunaImageButton()
        Me.edit_bot_sched1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.del_bot_sched1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.slot_sched_7 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.slot_sched_8 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.slot_sched_6 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.slot_sched_5 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.slot_sched_4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.slot_sched_3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.slot_sched_2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.slot_sched_1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaImageButton4 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton3 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.guna_add_edit_g.SuspendLayout()
        CType(Me.SubjectstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotprofDataSetAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduletblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotprofDataSetAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduletblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfdetailstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionstblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Room1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomtblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomtblBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingnoroomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.calendar_Main.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel9.SuspendLayout()
        Me.friday_600PM.SuspendLayout()
        Me.friday_300.SuspendLayout()
        Me.friday_1130.SuspendLayout()
        Me.friday_230.SuspendLayout()
        Me.friday_1100.SuspendLayout()
        Me.friday_200.SuspendLayout()
        Me.friday_530.SuspendLayout()
        Me.friday_1030.SuspendLayout()
        Me.friday_130.SuspendLayout()
        Me.friday_1000.SuspendLayout()
        Me.friday_100.SuspendLayout()
        Me.friday_930.SuspendLayout()
        Me.friday_500.SuspendLayout()
        Me.friday_1230.SuspendLayout()
        Me.friday_900.SuspendLayout()
        Me.friday_1200.SuspendLayout()
        Me.friday_830.SuspendLayout()
        Me.friday_800.SuspendLayout()
        Me.friday_430.SuspendLayout()
        Me.friday_730.SuspendLayout()
        Me.friday_700.SuspendLayout()
        Me.friday_630AM.SuspendLayout()
        Me.friday_330.SuspendLayout()
        Me.friday_400.SuspendLayout()
        Me.GunaPanel8.SuspendLayout()
        Me.thursday_600PM.SuspendLayout()
        Me.thursday_300.SuspendLayout()
        Me.thursday_1130.SuspendLayout()
        Me.thursday_230.SuspendLayout()
        Me.thursday_1100.SuspendLayout()
        Me.thursday_530.SuspendLayout()
        Me.thursday_200.SuspendLayout()
        Me.thursday_1030.SuspendLayout()
        Me.thursday_130.SuspendLayout()
        Me.thursday_1000.SuspendLayout()
        Me.thursday_500.SuspendLayout()
        Me.thursday_100.SuspendLayout()
        Me.thursday_930.SuspendLayout()
        Me.thursday_1230.SuspendLayout()
        Me.thursday_900.SuspendLayout()
        Me.thursday_430.SuspendLayout()
        Me.thursday_1200.SuspendLayout()
        Me.thursday_830.SuspendLayout()
        Me.thursday_800.SuspendLayout()
        Me.thursday_730.SuspendLayout()
        Me.thursday_400.SuspendLayout()
        Me.thursday_700.SuspendLayout()
        Me.thursday_630.SuspendLayout()
        Me.thursday_330.SuspendLayout()
        Me.GunaPanel6.SuspendLayout()
        Me.wednes_600PM.SuspendLayout()
        Me.wednes_300.SuspendLayout()
        Me.wednes_1130.SuspendLayout()
        Me.wednes_230.SuspendLayout()
        Me.wednes_530.SuspendLayout()
        Me.wednes_1100.SuspendLayout()
        Me.wednes_200.SuspendLayout()
        Me.wednes_1030.SuspendLayout()
        Me.wednes_500.SuspendLayout()
        Me.wednes_130.SuspendLayout()
        Me.wednes_1000.SuspendLayout()
        Me.wednes_100.SuspendLayout()
        Me.wednes_430.SuspendLayout()
        Me.wednes_930.SuspendLayout()
        Me.wednes_1230.SuspendLayout()
        Me.wednes_900.SuspendLayout()
        Me.wednes_400.SuspendLayout()
        Me.wednes_1200.SuspendLayout()
        Me.wednes_830.SuspendLayout()
        Me.wednes_800.SuspendLayout()
        Me.wednes_330.SuspendLayout()
        Me.wednes_730.SuspendLayout()
        Me.wednes_700.SuspendLayout()
        Me.wednes_630.SuspendLayout()
        Me.GunaPanel28.SuspendLayout()
        Me.tuesday_600PM.SuspendLayout()
        Me.tuesday_300.SuspendLayout()
        Me.tuesday_1130.SuspendLayout()
        Me.tuesday_530.SuspendLayout()
        Me.tuesday_230.SuspendLayout()
        Me.tuesday_1100.SuspendLayout()
        Me.tuesday_500.SuspendLayout()
        Me.tuesday_200.SuspendLayout()
        Me.tueasday_1030.SuspendLayout()
        Me.tuesday_430.SuspendLayout()
        Me.tuesday_130.SuspendLayout()
        Me.tuesday_1000.SuspendLayout()
        Me.tuesday_400.SuspendLayout()
        Me.tuesday_100.SuspendLayout()
        Me.tuesday_930.SuspendLayout()
        Me.tuesday_330.SuspendLayout()
        Me.tuesday_1230.SuspendLayout()
        Me.tuesday_900.SuspendLayout()
        Me.tuesday_1200.SuspendLayout()
        Me.tuesday_830.SuspendLayout()
        Me.tuesday_800.SuspendLayout()
        Me.tuesday_730.SuspendLayout()
        Me.tuesday_700.SuspendLayout()
        Me.tuesday_630AM.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.monday_630.SuspendLayout()
        Me.monday_600PM.SuspendLayout()
        Me.monday_530.SuspendLayout()
        Me.monday_300.SuspendLayout()
        Me.monday_1130.SuspendLayout()
        Me.monday_700.SuspendLayout()
        Me.monday_500.SuspendLayout()
        Me.monday_230.SuspendLayout()
        Me.monday_1100.SuspendLayout()
        Me.monday_430.SuspendLayout()
        Me.monday_200.SuspendLayout()
        Me.monday_1030.SuspendLayout()
        Me.monday_400.SuspendLayout()
        Me.monday_130.SuspendLayout()
        Me.monday_1000.SuspendLayout()
        Me.monday_330.SuspendLayout()
        Me.monday_100.SuspendLayout()
        Me.monday_930.SuspendLayout()
        Me.monday_1230.SuspendLayout()
        Me.monday_900.SuspendLayout()
        Me.monday_1200.SuspendLayout()
        Me.monday_830.SuspendLayout()
        Me.monday_800.SuspendLayout()
        Me.monday_730.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        CType(Me.SlotprofDataSetAll1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'guna_add_edit_g
        '
        Me.guna_add_edit_g.BackColor = System.Drawing.Color.Transparent
        Me.guna_add_edit_g.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.guna_add_edit_g.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel36)
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel35)
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel34)
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel33)
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel41)
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel39)
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel40)
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel38)
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel37)
        Me.guna_add_edit_g.Controls.Add(Me.GunaLabel1)
        Me.guna_add_edit_g.Controls.Add(Me.time_end_combo)
        Me.guna_add_edit_g.Controls.Add(Me.time_combo)
        Me.guna_add_edit_g.Controls.Add(Me.day_combo)
        Me.guna_add_edit_g.Controls.Add(Me.subject_cmbo)
        Me.guna_add_edit_g.Controls.Add(Me.add_nSection)
        Me.guna_add_edit_g.Controls.Add(Me.add_nRoom)
        Me.guna_add_edit_g.Controls.Add(Me.sectionlbl)
        Me.guna_add_edit_g.Controls.Add(Me.roomlbl)
        Me.guna_add_edit_g.Controls.Add(Me.section_dropdonw)
        Me.guna_add_edit_g.Controls.Add(Me.gradLvel_drop)
        Me.guna_add_edit_g.Controls.Add(Me.Track_dropdown)
        Me.guna_add_edit_g.Controls.Add(Me.room_dropdown)
        Me.guna_add_edit_g.Controls.Add(Me.build_dropbox)
        Me.guna_add_edit_g.Controls.Add(Me.add_dragItemBttn)
        Me.guna_add_edit_g.Controls.Add(Me.update_button)
        Me.guna_add_edit_g.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.guna_add_edit_g.LineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.guna_add_edit_g.Location = New System.Drawing.Point(57, 3)
        Me.guna_add_edit_g.Name = "guna_add_edit_g"
        Me.guna_add_edit_g.Size = New System.Drawing.Size(204, 457)
        Me.guna_add_edit_g.TabIndex = 6
        Me.guna_add_edit_g.Text = "Add Section, Room, subjects"
        Me.guna_add_edit_g.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel36
        '
        Me.GunaLabel36.AutoSize = True
        Me.GunaLabel36.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel36.Location = New System.Drawing.Point(118, 377)
        Me.GunaLabel36.Name = "GunaLabel36"
        Me.GunaLabel36.Size = New System.Drawing.Size(26, 16)
        Me.GunaLabel36.TabIndex = 5
        Me.GunaLabel36.Text = "End"
        '
        'GunaLabel35
        '
        Me.GunaLabel35.AutoSize = True
        Me.GunaLabel35.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel35.Location = New System.Drawing.Point(31, 377)
        Me.GunaLabel35.Name = "GunaLabel35"
        Me.GunaLabel35.Size = New System.Drawing.Size(32, 16)
        Me.GunaLabel35.TabIndex = 5
        Me.GunaLabel35.Text = "Start"
        '
        'GunaLabel34
        '
        Me.GunaLabel34.AutoSize = True
        Me.GunaLabel34.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel34.Location = New System.Drawing.Point(15, 327)
        Me.GunaLabel34.Name = "GunaLabel34"
        Me.GunaLabel34.Size = New System.Drawing.Size(31, 16)
        Me.GunaLabel34.TabIndex = 5
        Me.GunaLabel34.Text = "Time"
        '
        'GunaLabel33
        '
        Me.GunaLabel33.AutoSize = True
        Me.GunaLabel33.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel33.Location = New System.Drawing.Point(15, 277)
        Me.GunaLabel33.Name = "GunaLabel33"
        Me.GunaLabel33.Size = New System.Drawing.Size(26, 16)
        Me.GunaLabel33.TabIndex = 5
        Me.GunaLabel33.Text = "Day"
        '
        'GunaLabel41
        '
        Me.GunaLabel41.AutoSize = True
        Me.GunaLabel41.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel41.Location = New System.Drawing.Point(118, 95)
        Me.GunaLabel41.Name = "GunaLabel41"
        Me.GunaLabel41.Size = New System.Drawing.Size(36, 16)
        Me.GunaLabel41.TabIndex = 5
        Me.GunaLabel41.Text = "Room"
        '
        'GunaLabel39
        '
        Me.GunaLabel39.AutoSize = True
        Me.GunaLabel39.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel39.Location = New System.Drawing.Point(24, 207)
        Me.GunaLabel39.Name = "GunaLabel39"
        Me.GunaLabel39.Size = New System.Drawing.Size(62, 16)
        Me.GunaLabel39.TabIndex = 5
        Me.GunaLabel39.Text = "Section No."
        '
        'GunaLabel40
        '
        Me.GunaLabel40.AutoSize = True
        Me.GunaLabel40.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel40.Location = New System.Drawing.Point(31, 95)
        Me.GunaLabel40.Name = "GunaLabel40"
        Me.GunaLabel40.Size = New System.Drawing.Size(48, 16)
        Me.GunaLabel40.TabIndex = 5
        Me.GunaLabel40.Text = "Building"
        '
        'GunaLabel38
        '
        Me.GunaLabel38.AutoSize = True
        Me.GunaLabel38.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel38.Location = New System.Drawing.Point(107, 163)
        Me.GunaLabel38.Name = "GunaLabel38"
        Me.GunaLabel38.Size = New System.Drawing.Size(63, 16)
        Me.GunaLabel38.TabIndex = 5
        Me.GunaLabel38.Text = "Grade Level"
        '
        'GunaLabel37
        '
        Me.GunaLabel37.AutoSize = True
        Me.GunaLabel37.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel37.Location = New System.Drawing.Point(31, 160)
        Me.GunaLabel37.Name = "GunaLabel37"
        Me.GunaLabel37.Size = New System.Drawing.Size(34, 16)
        Me.GunaLabel37.TabIndex = 5
        Me.GunaLabel37.Text = "Track"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(15, 228)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(48, 16)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Subjects"
        '
        'time_end_combo
        '
        Me.time_end_combo.BackColor = System.Drawing.Color.Transparent
        Me.time_end_combo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.time_end_combo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.time_end_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.time_end_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.time_end_combo.FocusedColor = System.Drawing.Color.Empty
        Me.time_end_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.time_end_combo.ForeColor = System.Drawing.Color.Black
        Me.time_end_combo.FormattingEnabled = True
        Me.time_end_combo.Location = New System.Drawing.Point(103, 349)
        Me.time_end_combo.Name = "time_end_combo"
        Me.time_end_combo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.time_end_combo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.time_end_combo.Size = New System.Drawing.Size(68, 26)
        Me.time_end_combo.TabIndex = 4
        '
        'time_combo
        '
        Me.time_combo.BackColor = System.Drawing.Color.Transparent
        Me.time_combo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.time_combo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.time_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.time_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.time_combo.FocusedColor = System.Drawing.Color.Empty
        Me.time_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.time_combo.ForeColor = System.Drawing.Color.Black
        Me.time_combo.FormattingEnabled = True
        Me.time_combo.Location = New System.Drawing.Point(18, 349)
        Me.time_combo.Name = "time_combo"
        Me.time_combo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.time_combo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.time_combo.Size = New System.Drawing.Size(68, 26)
        Me.time_combo.TabIndex = 4
        '
        'day_combo
        '
        Me.day_combo.BackColor = System.Drawing.Color.Transparent
        Me.day_combo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.day_combo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.day_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.day_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.day_combo.FocusedColor = System.Drawing.Color.Empty
        Me.day_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.day_combo.ForeColor = System.Drawing.Color.Black
        Me.day_combo.FormattingEnabled = True
        Me.day_combo.Location = New System.Drawing.Point(18, 296)
        Me.day_combo.Name = "day_combo"
        Me.day_combo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.day_combo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.day_combo.Size = New System.Drawing.Size(153, 26)
        Me.day_combo.TabIndex = 4
        '
        'subject_cmbo
        '
        Me.subject_cmbo.BackColor = System.Drawing.Color.Transparent
        Me.subject_cmbo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.subject_cmbo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.subject_cmbo.DataSource = Me.SubjectstblBindingSource
        Me.subject_cmbo.DisplayMember = "subject_Name"
        Me.subject_cmbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.subject_cmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subject_cmbo.FocusedColor = System.Drawing.Color.Empty
        Me.subject_cmbo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.subject_cmbo.ForeColor = System.Drawing.Color.Black
        Me.subject_cmbo.FormattingEnabled = True
        Me.subject_cmbo.Location = New System.Drawing.Point(18, 248)
        Me.subject_cmbo.Name = "subject_cmbo"
        Me.subject_cmbo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.subject_cmbo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.subject_cmbo.Size = New System.Drawing.Size(153, 26)
        Me.subject_cmbo.TabIndex = 4
        Me.subject_cmbo.ValueMember = "snn"
        '
        'SubjectstblBindingSource
        '
        Me.SubjectstblBindingSource.DataMember = "subjects_tbl"
        Me.SubjectstblBindingSource.DataSource = Me.SlotprofDataSetAll
        '
        'SlotprofDataSetAll
        '
        Me.SlotprofDataSetAll.DataSetName = "slotprofDataSetAll"
        Me.SlotprofDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'add_nSection
        '
        Me.add_nSection.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.add_nSection.AutoSize = True
        Me.add_nSection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.add_nSection.LinkColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.add_nSection.Location = New System.Drawing.Point(107, 114)
        Me.add_nSection.Name = "add_nSection"
        Me.add_nSection.Size = New System.Drawing.Size(82, 15)
        Me.add_nSection.TabIndex = 3
        Me.add_nSection.TabStop = True
        Me.add_nSection.Text = "Add Sections.."
        '
        'add_nRoom
        '
        Me.add_nRoom.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.add_nRoom.AutoSize = True
        Me.add_nRoom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.add_nRoom.LinkColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.add_nRoom.Location = New System.Drawing.Point(118, 46)
        Me.add_nRoom.Name = "add_nRoom"
        Me.add_nRoom.Size = New System.Drawing.Size(70, 15)
        Me.add_nRoom.TabIndex = 3
        Me.add_nRoom.TabStop = True
        Me.add_nRoom.Text = "Add Room.."
        '
        'sectionlbl
        '
        Me.sectionlbl.AutoSize = True
        Me.sectionlbl.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionlbl.Location = New System.Drawing.Point(15, 114)
        Me.sectionlbl.Name = "sectionlbl"
        Me.sectionlbl.Size = New System.Drawing.Size(48, 16)
        Me.sectionlbl.TabIndex = 1
        Me.sectionlbl.Text = "Sections"
        '
        'roomlbl
        '
        Me.roomlbl.AutoSize = True
        Me.roomlbl.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomlbl.Location = New System.Drawing.Point(15, 46)
        Me.roomlbl.Name = "roomlbl"
        Me.roomlbl.Size = New System.Drawing.Size(36, 16)
        Me.roomlbl.TabIndex = 1
        Me.roomlbl.Text = "Room"
        '
        'section_dropdonw
        '
        Me.section_dropdonw.BackColor = System.Drawing.Color.Transparent
        Me.section_dropdonw.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.section_dropdonw.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.section_dropdonw.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.section_dropdonw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.section_dropdonw.FocusedColor = System.Drawing.Color.Empty
        Me.section_dropdonw.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.section_dropdonw.ForeColor = System.Drawing.Color.Black
        Me.section_dropdonw.FormattingEnabled = True
        Me.section_dropdonw.Location = New System.Drawing.Point(18, 181)
        Me.section_dropdonw.Name = "section_dropdonw"
        Me.section_dropdonw.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.section_dropdonw.OnHoverItemForeColor = System.Drawing.Color.White
        Me.section_dropdonw.Size = New System.Drawing.Size(76, 26)
        Me.section_dropdonw.TabIndex = 0
        '
        'gradLvel_drop
        '
        Me.gradLvel_drop.BackColor = System.Drawing.Color.Transparent
        Me.gradLvel_drop.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.gradLvel_drop.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gradLvel_drop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gradLvel_drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gradLvel_drop.FocusedColor = System.Drawing.Color.Empty
        Me.gradLvel_drop.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.gradLvel_drop.ForeColor = System.Drawing.Color.Black
        Me.gradLvel_drop.FormattingEnabled = True
        Me.gradLvel_drop.Items.AddRange(New Object() {"11", "12"})
        Me.gradLvel_drop.Location = New System.Drawing.Point(103, 134)
        Me.gradLvel_drop.Name = "gradLvel_drop"
        Me.gradLvel_drop.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.gradLvel_drop.OnHoverItemForeColor = System.Drawing.Color.White
        Me.gradLvel_drop.Size = New System.Drawing.Size(68, 26)
        Me.gradLvel_drop.TabIndex = 0
        '
        'Track_dropdown
        '
        Me.Track_dropdown.BackColor = System.Drawing.Color.Transparent
        Me.Track_dropdown.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Track_dropdown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Track_dropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Track_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Track_dropdown.FocusedColor = System.Drawing.Color.Empty
        Me.Track_dropdown.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Track_dropdown.ForeColor = System.Drawing.Color.Black
        Me.Track_dropdown.FormattingEnabled = True
        Me.Track_dropdown.Location = New System.Drawing.Point(18, 134)
        Me.Track_dropdown.Name = "Track_dropdown"
        Me.Track_dropdown.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Track_dropdown.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Track_dropdown.Size = New System.Drawing.Size(76, 26)
        Me.Track_dropdown.TabIndex = 0
        '
        'room_dropdown
        '
        Me.room_dropdown.BackColor = System.Drawing.Color.Transparent
        Me.room_dropdown.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.room_dropdown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.room_dropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.room_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.room_dropdown.FocusedColor = System.Drawing.Color.Empty
        Me.room_dropdown.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.room_dropdown.ForeColor = System.Drawing.Color.Black
        Me.room_dropdown.FormattingEnabled = True
        Me.room_dropdown.Location = New System.Drawing.Point(103, 67)
        Me.room_dropdown.Name = "room_dropdown"
        Me.room_dropdown.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.room_dropdown.OnHoverItemForeColor = System.Drawing.Color.White
        Me.room_dropdown.Size = New System.Drawing.Size(68, 26)
        Me.room_dropdown.TabIndex = 0
        '
        'build_dropbox
        '
        Me.build_dropbox.BackColor = System.Drawing.Color.Transparent
        Me.build_dropbox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.build_dropbox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.build_dropbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.build_dropbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.build_dropbox.FocusedColor = System.Drawing.Color.Empty
        Me.build_dropbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.build_dropbox.ForeColor = System.Drawing.Color.Black
        Me.build_dropbox.FormattingEnabled = True
        Me.build_dropbox.Location = New System.Drawing.Point(18, 67)
        Me.build_dropbox.Name = "build_dropbox"
        Me.build_dropbox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.build_dropbox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.build_dropbox.Size = New System.Drawing.Size(76, 26)
        Me.build_dropbox.TabIndex = 0
        '
        'add_dragItemBttn
        '
        Me.add_dragItemBttn.AnimationHoverSpeed = 0.07!
        Me.add_dragItemBttn.AnimationSpeed = 0.03!
        Me.add_dragItemBttn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.add_dragItemBttn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.add_dragItemBttn.BorderSize = 2
        Me.add_dragItemBttn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.add_dragItemBttn.FocusedColor = System.Drawing.Color.Empty
        Me.add_dragItemBttn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.add_dragItemBttn.ForeColor = System.Drawing.Color.Black
        Me.add_dragItemBttn.Image = Nothing
        Me.add_dragItemBttn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.add_dragItemBttn.ImageSize = New System.Drawing.Size(20, 20)
        Me.add_dragItemBttn.Location = New System.Drawing.Point(121, 415)
        Me.add_dragItemBttn.Name = "add_dragItemBttn"
        Me.add_dragItemBttn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.add_dragItemBttn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.add_dragItemBttn.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.add_dragItemBttn.OnHoverImage = Nothing
        Me.add_dragItemBttn.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.add_dragItemBttn.Size = New System.Drawing.Size(75, 28)
        Me.add_dragItemBttn.TabIndex = 2
        Me.add_dragItemBttn.Text = "Add"
        Me.add_dragItemBttn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'update_button
        '
        Me.update_button.AnimationHoverSpeed = 0.07!
        Me.update_button.AnimationSpeed = 0.03!
        Me.update_button.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.update_button.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.update_button.BorderSize = 2
        Me.update_button.DialogResult = System.Windows.Forms.DialogResult.None
        Me.update_button.Enabled = False
        Me.update_button.FocusedColor = System.Drawing.Color.Empty
        Me.update_button.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.update_button.ForeColor = System.Drawing.Color.Black
        Me.update_button.Image = Nothing
        Me.update_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.update_button.ImageSize = New System.Drawing.Size(20, 20)
        Me.update_button.Location = New System.Drawing.Point(121, 415)
        Me.update_button.Name = "update_button"
        Me.update_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.update_button.OnHoverBorderColor = System.Drawing.Color.Black
        Me.update_button.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.update_button.OnHoverImage = Nothing
        Me.update_button.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.update_button.Size = New System.Drawing.Size(75, 28)
        Me.update_button.TabIndex = 6
        Me.update_button.Text = "Update"
        Me.update_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ScheduletblBindingSource1
        '
        Me.ScheduletblBindingSource1.DataMember = "schedule_tbl"
        Me.ScheduletblBindingSource1.DataSource = Me.SlotprofDataSetAllBindingSource
        '
        'SlotprofDataSetAllBindingSource
        '
        Me.SlotprofDataSetAllBindingSource.DataSource = Me.SlotprofDataSetAll
        Me.SlotprofDataSetAllBindingSource.Position = 0
        '
        'ScheduletblBindingSource
        '
        Me.ScheduletblBindingSource.DataMember = "schedule_tbl"
        Me.ScheduletblBindingSource.DataSource = Me.SlotprofDataSetAll
        '
        'ProfdetailstblBindingSource
        '
        Me.ProfdetailstblBindingSource.DataMember = "prof_details_tbl"
        Me.ProfdetailstblBindingSource.DataSource = Me.SlotprofDataSetAll
        '
        'SectionstblBindingSource1
        '
        Me.SectionstblBindingSource1.DataMember = "sections_tbl"
        Me.SectionstblBindingSource1.DataSource = Me.SlotprofDataSetAllBindingSource
        '
        'Subjects_tblTableAdapter
        '
        Me.Subjects_tblTableAdapter.ClearBeforeFill = True
        '
        'RoomtblBindingSource2
        '
        Me.RoomtblBindingSource2.DataMember = "room_tbl"
        Me.RoomtblBindingSource2.DataSource = Me.SlotprofDataSetAll
        '
        'Room_tblTableAdapter
        '
        Me.Room_tblTableAdapter.ClearBeforeFill = True
        '
        'BuildingnoroomBindingSource
        '
        Me.BuildingnoroomBindingSource.DataMember = "building_no_room"
        Me.BuildingnoroomBindingSource.DataSource = Me.RoomtblBindingSource2
        '
        'Schedule_tblTableAdapter
        '
        Me.Schedule_tblTableAdapter.ClearBeforeFill = True
        '
        'Sections_tblTableAdapter
        '
        Me.Sections_tblTableAdapter.ClearBeforeFill = True
        '
        'Prof_details_tblTableAdapter
        '
        Me.Prof_details_tblTableAdapter.ClearBeforeFill = True
        '
        'calendar_Main
        '
        Me.calendar_Main.AutoScroll = True
        Me.calendar_Main.Controls.Add(Me.GunaPanel4)
        Me.calendar_Main.Controls.Add(Me.GunaPanel9)
        Me.calendar_Main.Controls.Add(Me.GunaPanel8)
        Me.calendar_Main.Controls.Add(Me.GunaPanel6)
        Me.calendar_Main.Controls.Add(Me.GunaPanel28)
        Me.calendar_Main.Controls.Add(Me.GunaPanel5)
        Me.calendar_Main.Controls.Add(Me.GunaPanel2)
        Me.calendar_Main.Location = New System.Drawing.Point(264, 58)
        Me.calendar_Main.Name = "calendar_Main"
        Me.calendar_Main.Size = New System.Drawing.Size(673, 434)
        Me.calendar_Main.TabIndex = 10
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPanel4.Controls.Add(Me.GunaLabel21)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel20)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel30)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel29)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel28)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel27)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel26)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel32)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel31)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel25)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel24)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel23)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel22)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel19)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel8)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel18)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel17)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel16)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel15)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel14)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel13)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel11)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel12)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel10)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel9)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel7)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox11)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox10)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox9)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox8)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox7)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox6)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox5)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox4)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox3)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox2)
        Me.GunaPanel4.Controls.Add(Me.GunaLineTextBox1)
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 27)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(50, 531)
        Me.GunaPanel4.TabIndex = 11
        '
        'GunaLabel21
        '
        Me.GunaLabel21.AutoSize = True
        Me.GunaLabel21.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel21.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel21.Location = New System.Drawing.Point(31, 95)
        Me.GunaLabel21.Name = "GunaLabel21"
        Me.GunaLabel21.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel21.TabIndex = 2
        Me.GunaLabel21.Text = "00"
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel20.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel20.Location = New System.Drawing.Point(31, 51)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel20.TabIndex = 2
        Me.GunaLabel20.Text = "00"
        '
        'GunaLabel30
        '
        Me.GunaLabel30.AutoSize = True
        Me.GunaLabel30.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel30.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel30.Location = New System.Drawing.Point(31, 491)
        Me.GunaLabel30.Name = "GunaLabel30"
        Me.GunaLabel30.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel30.TabIndex = 2
        Me.GunaLabel30.Text = "00"
        '
        'GunaLabel29
        '
        Me.GunaLabel29.AutoSize = True
        Me.GunaLabel29.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel29.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel29.Location = New System.Drawing.Point(31, 447)
        Me.GunaLabel29.Name = "GunaLabel29"
        Me.GunaLabel29.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel29.TabIndex = 2
        Me.GunaLabel29.Text = "00"
        '
        'GunaLabel28
        '
        Me.GunaLabel28.AutoSize = True
        Me.GunaLabel28.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel28.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel28.Location = New System.Drawing.Point(30, 403)
        Me.GunaLabel28.Name = "GunaLabel28"
        Me.GunaLabel28.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel28.TabIndex = 2
        Me.GunaLabel28.Text = "00"
        '
        'GunaLabel27
        '
        Me.GunaLabel27.AutoSize = True
        Me.GunaLabel27.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel27.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel27.Location = New System.Drawing.Point(31, 359)
        Me.GunaLabel27.Name = "GunaLabel27"
        Me.GunaLabel27.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel27.TabIndex = 2
        Me.GunaLabel27.Text = "00"
        '
        'GunaLabel26
        '
        Me.GunaLabel26.AutoSize = True
        Me.GunaLabel26.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel26.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel26.Location = New System.Drawing.Point(31, 315)
        Me.GunaLabel26.Name = "GunaLabel26"
        Me.GunaLabel26.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel26.TabIndex = 2
        Me.GunaLabel26.Text = "00"
        '
        'GunaLabel32
        '
        Me.GunaLabel32.AutoSize = True
        Me.GunaLabel32.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel32.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel32.Location = New System.Drawing.Point(25, 25)
        Me.GunaLabel32.Name = "GunaLabel32"
        Me.GunaLabel32.Size = New System.Drawing.Size(26, 15)
        Me.GunaLabel32.TabIndex = 2
        Me.GunaLabel32.Text = "AM"
        '
        'GunaLabel31
        '
        Me.GunaLabel31.AutoSize = True
        Me.GunaLabel31.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel31.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel31.Location = New System.Drawing.Point(25, 289)
        Me.GunaLabel31.Name = "GunaLabel31"
        Me.GunaLabel31.Size = New System.Drawing.Size(25, 15)
        Me.GunaLabel31.TabIndex = 2
        Me.GunaLabel31.Text = "PM"
        '
        'GunaLabel25
        '
        Me.GunaLabel25.AutoSize = True
        Me.GunaLabel25.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel25.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel25.Location = New System.Drawing.Point(30, 271)
        Me.GunaLabel25.Name = "GunaLabel25"
        Me.GunaLabel25.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel25.TabIndex = 2
        Me.GunaLabel25.Text = "00"
        '
        'GunaLabel24
        '
        Me.GunaLabel24.AutoSize = True
        Me.GunaLabel24.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel24.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel24.Location = New System.Drawing.Point(30, 227)
        Me.GunaLabel24.Name = "GunaLabel24"
        Me.GunaLabel24.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel24.TabIndex = 2
        Me.GunaLabel24.Text = "00"
        '
        'GunaLabel23
        '
        Me.GunaLabel23.AutoSize = True
        Me.GunaLabel23.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel23.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel23.Location = New System.Drawing.Point(30, 183)
        Me.GunaLabel23.Name = "GunaLabel23"
        Me.GunaLabel23.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel23.TabIndex = 2
        Me.GunaLabel23.Text = "00"
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel22.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel22.Location = New System.Drawing.Point(30, 139)
        Me.GunaLabel22.Name = "GunaLabel22"
        Me.GunaLabel22.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel22.TabIndex = 2
        Me.GunaLabel22.Text = "00"
        '
        'GunaLabel19
        '
        Me.GunaLabel19.AutoSize = True
        Me.GunaLabel19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel19.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel19.Location = New System.Drawing.Point(31, 6)
        Me.GunaLabel19.Name = "GunaLabel19"
        Me.GunaLabel19.Size = New System.Drawing.Size(19, 15)
        Me.GunaLabel19.TabIndex = 2
        Me.GunaLabel19.Text = "00"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel8.Location = New System.Drawing.Point(0, 0)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(37, 30)
        Me.GunaLabel8.TabIndex = 0
        Me.GunaLabel8.Text = "06"
        '
        'GunaLabel18
        '
        Me.GunaLabel18.AutoSize = True
        Me.GunaLabel18.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel18.Location = New System.Drawing.Point(0, 485)
        Me.GunaLabel18.Name = "GunaLabel18"
        Me.GunaLabel18.Size = New System.Drawing.Size(37, 30)
        Me.GunaLabel18.TabIndex = 0
        Me.GunaLabel18.Text = "05"
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel17.Location = New System.Drawing.Point(0, 440)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(37, 30)
        Me.GunaLabel17.TabIndex = 0
        Me.GunaLabel17.Text = "04"
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel16.Location = New System.Drawing.Point(0, 396)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(37, 30)
        Me.GunaLabel16.TabIndex = 0
        Me.GunaLabel16.Text = "03"
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel15.Location = New System.Drawing.Point(0, 352)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(37, 30)
        Me.GunaLabel15.TabIndex = 0
        Me.GunaLabel15.Text = "02"
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel14.Location = New System.Drawing.Point(0, 308)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(33, 30)
        Me.GunaLabel14.TabIndex = 0
        Me.GunaLabel14.Text = "01"
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel13.Location = New System.Drawing.Point(0, 265)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(33, 30)
        Me.GunaLabel13.TabIndex = 0
        Me.GunaLabel13.Text = "12"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel11.Location = New System.Drawing.Point(0, 177)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(33, 30)
        Me.GunaLabel11.TabIndex = 0
        Me.GunaLabel11.Text = "10"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel12.Location = New System.Drawing.Point(0, 221)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(29, 30)
        Me.GunaLabel12.TabIndex = 0
        Me.GunaLabel12.Text = "11"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel10.Location = New System.Drawing.Point(0, 133)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(37, 30)
        Me.GunaLabel10.TabIndex = 0
        Me.GunaLabel10.Text = "09"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel9.Location = New System.Drawing.Point(0, 92)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(37, 30)
        Me.GunaLabel9.TabIndex = 0
        Me.GunaLabel9.Text = "08"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel7.Location = New System.Drawing.Point(0, 45)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(36, 30)
        Me.GunaLabel7.TabIndex = 0
        Me.GunaLabel7.Text = "07"
        '
        'GunaLineTextBox11
        '
        Me.GunaLineTextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox11.Enabled = False
        Me.GunaLineTextBox11.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox11.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox11.Location = New System.Drawing.Point(-1, 459)
        Me.GunaLineTextBox11.Name = "GunaLineTextBox11"
        Me.GunaLineTextBox11.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox11.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox11.TabIndex = 1
        '
        'GunaLineTextBox10
        '
        Me.GunaLineTextBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox10.Enabled = False
        Me.GunaLineTextBox10.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox10.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox10.Location = New System.Drawing.Point(-1, 414)
        Me.GunaLineTextBox10.Name = "GunaLineTextBox10"
        Me.GunaLineTextBox10.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox10.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox10.TabIndex = 1
        '
        'GunaLineTextBox9
        '
        Me.GunaLineTextBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox9.Enabled = False
        Me.GunaLineTextBox9.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox9.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox9.Location = New System.Drawing.Point(-1, 370)
        Me.GunaLineTextBox9.Name = "GunaLineTextBox9"
        Me.GunaLineTextBox9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox9.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox9.TabIndex = 1
        '
        'GunaLineTextBox8
        '
        Me.GunaLineTextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox8.Enabled = False
        Me.GunaLineTextBox8.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox8.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox8.Location = New System.Drawing.Point(-1, 326)
        Me.GunaLineTextBox8.Name = "GunaLineTextBox8"
        Me.GunaLineTextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox8.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox8.TabIndex = 1
        '
        'GunaLineTextBox7
        '
        Me.GunaLineTextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox7.Enabled = False
        Me.GunaLineTextBox7.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox7.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox7.Location = New System.Drawing.Point(-1, 282)
        Me.GunaLineTextBox7.Name = "GunaLineTextBox7"
        Me.GunaLineTextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox7.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox7.TabIndex = 1
        '
        'GunaLineTextBox6
        '
        Me.GunaLineTextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox6.Enabled = False
        Me.GunaLineTextBox6.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox6.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox6.Location = New System.Drawing.Point(-1, 239)
        Me.GunaLineTextBox6.Name = "GunaLineTextBox6"
        Me.GunaLineTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox6.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox6.TabIndex = 1
        '
        'GunaLineTextBox5
        '
        Me.GunaLineTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox5.Enabled = False
        Me.GunaLineTextBox5.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox5.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox5.Location = New System.Drawing.Point(-1, 195)
        Me.GunaLineTextBox5.Name = "GunaLineTextBox5"
        Me.GunaLineTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox5.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox5.TabIndex = 1
        '
        'GunaLineTextBox4
        '
        Me.GunaLineTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox4.Enabled = False
        Me.GunaLineTextBox4.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox4.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox4.Location = New System.Drawing.Point(-1, 150)
        Me.GunaLineTextBox4.Name = "GunaLineTextBox4"
        Me.GunaLineTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox4.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox4.TabIndex = 1
        '
        'GunaLineTextBox3
        '
        Me.GunaLineTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox3.Enabled = False
        Me.GunaLineTextBox3.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox3.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox3.Location = New System.Drawing.Point(-1, 106)
        Me.GunaLineTextBox3.Name = "GunaLineTextBox3"
        Me.GunaLineTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox3.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox3.TabIndex = 1
        '
        'GunaLineTextBox2
        '
        Me.GunaLineTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox2.Enabled = False
        Me.GunaLineTextBox2.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox2.Location = New System.Drawing.Point(-1, 64)
        Me.GunaLineTextBox2.Name = "GunaLineTextBox2"
        Me.GunaLineTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox2.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox2.TabIndex = 1
        '
        'GunaLineTextBox1
        '
        Me.GunaLineTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox1.Enabled = False
        Me.GunaLineTextBox1.FocusedLineColor = System.Drawing.Color.Transparent
        Me.GunaLineTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox1.Location = New System.Drawing.Point(-1, 18)
        Me.GunaLineTextBox1.Name = "GunaLineTextBox1"
        Me.GunaLineTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox1.Size = New System.Drawing.Size(50, 26)
        Me.GunaLineTextBox1.TabIndex = 1
        '
        'GunaPanel9
        '
        Me.GunaPanel9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaPanel9.Controls.Add(Me.friday_600PM)
        Me.GunaPanel9.Controls.Add(Me.friday_300)
        Me.GunaPanel9.Controls.Add(Me.friday_1130)
        Me.GunaPanel9.Controls.Add(Me.friday_230)
        Me.GunaPanel9.Controls.Add(Me.friday_1100)
        Me.GunaPanel9.Controls.Add(Me.friday_200)
        Me.GunaPanel9.Controls.Add(Me.friday_530)
        Me.GunaPanel9.Controls.Add(Me.friday_1030)
        Me.GunaPanel9.Controls.Add(Me.friday_130)
        Me.GunaPanel9.Controls.Add(Me.friday_1000)
        Me.GunaPanel9.Controls.Add(Me.friday_100)
        Me.GunaPanel9.Controls.Add(Me.friday_930)
        Me.GunaPanel9.Controls.Add(Me.friday_500)
        Me.GunaPanel9.Controls.Add(Me.friday_1230)
        Me.GunaPanel9.Controls.Add(Me.friday_900)
        Me.GunaPanel9.Controls.Add(Me.friday_1200)
        Me.GunaPanel9.Controls.Add(Me.friday_830)
        Me.GunaPanel9.Controls.Add(Me.friday_800)
        Me.GunaPanel9.Controls.Add(Me.friday_430)
        Me.GunaPanel9.Controls.Add(Me.friday_730)
        Me.GunaPanel9.Controls.Add(Me.friday_700)
        Me.GunaPanel9.Controls.Add(Me.friday_630AM)
        Me.GunaPanel9.Controls.Add(Me.friday_330)
        Me.GunaPanel9.Controls.Add(Me.friday_400)
        Me.GunaPanel9.Location = New System.Drawing.Point(533, 26)
        Me.GunaPanel9.Name = "GunaPanel9"
        Me.GunaPanel9.Size = New System.Drawing.Size(123, 532)
        Me.GunaPanel9.TabIndex = 11
        '
        'friday_600PM
        '
        Me.friday_600PM.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_600PM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_600PM.Controls.Add(Me.lbl_Friday_600)
        Me.friday_600PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_600PM.Location = New System.Drawing.Point(0, 507)
        Me.friday_600PM.Name = "friday_600PM"
        Me.friday_600PM.Size = New System.Drawing.Size(122, 23)
        Me.friday_600PM.TabIndex = 11
        '
        'lbl_Friday_600
        '
        Me.lbl_Friday_600.AutoSize = True
        Me.lbl_Friday_600.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_600.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_600.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_600.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_600.Name = "lbl_Friday_600"
        Me.lbl_Friday_600.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_600.TabIndex = 11
        Me.lbl_Friday_600.Text = "lbl_Friday_600"
        '
        'friday_300
        '
        Me.friday_300.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_300.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_300.Controls.Add(Me.lbl_Friday_300)
        Me.friday_300.Controls.Add(Me.GunaLabel145)
        Me.friday_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_300.Location = New System.Drawing.Point(0, 375)
        Me.friday_300.Name = "friday_300"
        Me.friday_300.Size = New System.Drawing.Size(122, 23)
        Me.friday_300.TabIndex = 11
        '
        'lbl_Friday_300
        '
        Me.lbl_Friday_300.AutoSize = True
        Me.lbl_Friday_300.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_300.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_300.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_300.Name = "lbl_Friday_300"
        Me.lbl_Friday_300.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_300.TabIndex = 11
        Me.lbl_Friday_300.Text = "lbl_Friday_300"
        '
        'GunaLabel145
        '
        Me.GunaLabel145.AutoSize = True
        Me.GunaLabel145.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel145.Location = New System.Drawing.Point(25, 6)
        Me.GunaLabel145.Name = "GunaLabel145"
        Me.GunaLabel145.Size = New System.Drawing.Size(75, 15)
        Me.GunaLabel145.TabIndex = 11
        Me.GunaLabel145.Text = "GunaLabel33"
        '
        'friday_1130
        '
        Me.friday_1130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_1130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_1130.Controls.Add(Me.lbl_Friday_1130)
        Me.friday_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_1130.Location = New System.Drawing.Point(0, 221)
        Me.friday_1130.Name = "friday_1130"
        Me.friday_1130.Size = New System.Drawing.Size(122, 23)
        Me.friday_1130.TabIndex = 11
        '
        'lbl_Friday_1130
        '
        Me.lbl_Friday_1130.AutoSize = True
        Me.lbl_Friday_1130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_1130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_1130.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_1130.Name = "lbl_Friday_1130"
        Me.lbl_Friday_1130.Size = New System.Drawing.Size(86, 15)
        Me.lbl_Friday_1130.TabIndex = 11
        Me.lbl_Friday_1130.Text = "lbl_Friday_1130"
        '
        'friday_230
        '
        Me.friday_230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_230.Controls.Add(Me.lbl_Friday_230)
        Me.friday_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_230.Location = New System.Drawing.Point(0, 353)
        Me.friday_230.Name = "friday_230"
        Me.friday_230.Size = New System.Drawing.Size(122, 23)
        Me.friday_230.TabIndex = 11
        '
        'lbl_Friday_230
        '
        Me.lbl_Friday_230.AutoSize = True
        Me.lbl_Friday_230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_230.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_230.Name = "lbl_Friday_230"
        Me.lbl_Friday_230.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_230.TabIndex = 11
        Me.lbl_Friday_230.Text = "lbl_Friday_230"
        '
        'friday_1100
        '
        Me.friday_1100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_1100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_1100.Controls.Add(Me.lbl_Friday_1100)
        Me.friday_1100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_1100.Location = New System.Drawing.Point(0, 199)
        Me.friday_1100.Name = "friday_1100"
        Me.friday_1100.Size = New System.Drawing.Size(122, 23)
        Me.friday_1100.TabIndex = 11
        '
        'lbl_Friday_1100
        '
        Me.lbl_Friday_1100.AutoSize = True
        Me.lbl_Friday_1100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_1100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_1100.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_1100.Name = "lbl_Friday_1100"
        Me.lbl_Friday_1100.Size = New System.Drawing.Size(86, 15)
        Me.lbl_Friday_1100.TabIndex = 11
        Me.lbl_Friday_1100.Text = "lbl_Friday_1100"
        '
        'friday_200
        '
        Me.friday_200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_200.Controls.Add(Me.lbl_Friday_200)
        Me.friday_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_200.Location = New System.Drawing.Point(0, 331)
        Me.friday_200.Name = "friday_200"
        Me.friday_200.Size = New System.Drawing.Size(122, 23)
        Me.friday_200.TabIndex = 11
        '
        'lbl_Friday_200
        '
        Me.lbl_Friday_200.AutoSize = True
        Me.lbl_Friday_200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_200.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_200.Name = "lbl_Friday_200"
        Me.lbl_Friday_200.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_200.TabIndex = 11
        Me.lbl_Friday_200.Text = "lbl_Friday_200"
        '
        'friday_530
        '
        Me.friday_530.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_530.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_530.Controls.Add(Me.lbl_Friday_530)
        Me.friday_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_530.Location = New System.Drawing.Point(0, 485)
        Me.friday_530.Name = "friday_530"
        Me.friday_530.Size = New System.Drawing.Size(122, 23)
        Me.friday_530.TabIndex = 11
        '
        'lbl_Friday_530
        '
        Me.lbl_Friday_530.AutoSize = True
        Me.lbl_Friday_530.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_530.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_530.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_530.Name = "lbl_Friday_530"
        Me.lbl_Friday_530.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_530.TabIndex = 11
        Me.lbl_Friday_530.Text = "lbl_Friday_530"
        '
        'friday_1030
        '
        Me.friday_1030.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_1030.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_1030.Controls.Add(Me.lbl_Friday_1030)
        Me.friday_1030.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_1030.Location = New System.Drawing.Point(0, 177)
        Me.friday_1030.Name = "friday_1030"
        Me.friday_1030.Size = New System.Drawing.Size(122, 23)
        Me.friday_1030.TabIndex = 11
        '
        'lbl_Friday_1030
        '
        Me.lbl_Friday_1030.AutoSize = True
        Me.lbl_Friday_1030.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_1030.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_1030.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_1030.Name = "lbl_Friday_1030"
        Me.lbl_Friday_1030.Size = New System.Drawing.Size(86, 15)
        Me.lbl_Friday_1030.TabIndex = 11
        Me.lbl_Friday_1030.Text = "lbl_Friday_1030"
        '
        'friday_130
        '
        Me.friday_130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_130.Controls.Add(Me.lbl_Friday_130)
        Me.friday_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_130.Location = New System.Drawing.Point(0, 309)
        Me.friday_130.Name = "friday_130"
        Me.friday_130.Size = New System.Drawing.Size(122, 23)
        Me.friday_130.TabIndex = 11
        '
        'lbl_Friday_130
        '
        Me.lbl_Friday_130.AutoSize = True
        Me.lbl_Friday_130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_130.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_130.Name = "lbl_Friday_130"
        Me.lbl_Friday_130.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_130.TabIndex = 11
        Me.lbl_Friday_130.Text = "lbl_Friday_130"
        '
        'friday_1000
        '
        Me.friday_1000.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_1000.Controls.Add(Me.lbl_Friday_1000)
        Me.friday_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_1000.Location = New System.Drawing.Point(0, 155)
        Me.friday_1000.Name = "friday_1000"
        Me.friday_1000.Size = New System.Drawing.Size(122, 23)
        Me.friday_1000.TabIndex = 11
        '
        'lbl_Friday_1000
        '
        Me.lbl_Friday_1000.AutoSize = True
        Me.lbl_Friday_1000.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_1000.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_1000.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_1000.Name = "lbl_Friday_1000"
        Me.lbl_Friday_1000.Size = New System.Drawing.Size(86, 15)
        Me.lbl_Friday_1000.TabIndex = 11
        Me.lbl_Friday_1000.Text = "lbl_Friday_1000"
        '
        'friday_100
        '
        Me.friday_100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_100.Controls.Add(Me.lbl_Friday_100)
        Me.friday_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_100.Location = New System.Drawing.Point(0, 287)
        Me.friday_100.Name = "friday_100"
        Me.friday_100.Size = New System.Drawing.Size(122, 23)
        Me.friday_100.TabIndex = 11
        '
        'lbl_Friday_100
        '
        Me.lbl_Friday_100.AutoSize = True
        Me.lbl_Friday_100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_100.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_100.Name = "lbl_Friday_100"
        Me.lbl_Friday_100.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_100.TabIndex = 11
        Me.lbl_Friday_100.Text = "lbl_Friday_100"
        '
        'friday_930
        '
        Me.friday_930.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_930.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_930.Controls.Add(Me.lbl_Friday_930)
        Me.friday_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_930.Location = New System.Drawing.Point(0, 133)
        Me.friday_930.Name = "friday_930"
        Me.friday_930.Size = New System.Drawing.Size(122, 23)
        Me.friday_930.TabIndex = 11
        '
        'lbl_Friday_930
        '
        Me.lbl_Friday_930.AutoSize = True
        Me.lbl_Friday_930.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_930.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_930.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_930.Name = "lbl_Friday_930"
        Me.lbl_Friday_930.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_930.TabIndex = 11
        Me.lbl_Friday_930.Text = "lbl_Friday_930"
        '
        'friday_500
        '
        Me.friday_500.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_500.Controls.Add(Me.lbl_Friday_500)
        Me.friday_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_500.Location = New System.Drawing.Point(0, 463)
        Me.friday_500.Name = "friday_500"
        Me.friday_500.Size = New System.Drawing.Size(122, 23)
        Me.friday_500.TabIndex = 11
        '
        'lbl_Friday_500
        '
        Me.lbl_Friday_500.AutoSize = True
        Me.lbl_Friday_500.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_500.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_500.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_500.Name = "lbl_Friday_500"
        Me.lbl_Friday_500.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_500.TabIndex = 11
        Me.lbl_Friday_500.Text = "lbl_Friday_500"
        '
        'friday_1230
        '
        Me.friday_1230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_1230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_1230.Controls.Add(Me.lbl_Friday_1230)
        Me.friday_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_1230.Location = New System.Drawing.Point(0, 265)
        Me.friday_1230.Name = "friday_1230"
        Me.friday_1230.Size = New System.Drawing.Size(122, 23)
        Me.friday_1230.TabIndex = 11
        '
        'lbl_Friday_1230
        '
        Me.lbl_Friday_1230.AutoSize = True
        Me.lbl_Friday_1230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_1230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_1230.Location = New System.Drawing.Point(9, 1)
        Me.lbl_Friday_1230.Name = "lbl_Friday_1230"
        Me.lbl_Friday_1230.Size = New System.Drawing.Size(86, 15)
        Me.lbl_Friday_1230.TabIndex = 11
        Me.lbl_Friday_1230.Text = "lbl_Friday_1230"
        '
        'friday_900
        '
        Me.friday_900.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_900.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_900.Controls.Add(Me.lbl_Friday_900)
        Me.friday_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_900.Location = New System.Drawing.Point(0, 111)
        Me.friday_900.Name = "friday_900"
        Me.friday_900.Size = New System.Drawing.Size(122, 23)
        Me.friday_900.TabIndex = 11
        '
        'lbl_Friday_900
        '
        Me.lbl_Friday_900.AutoSize = True
        Me.lbl_Friday_900.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_900.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_900.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_900.Name = "lbl_Friday_900"
        Me.lbl_Friday_900.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_900.TabIndex = 11
        Me.lbl_Friday_900.Text = "lbl_Friday_900"
        '
        'friday_1200
        '
        Me.friday_1200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_1200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_1200.Controls.Add(Me.lbl_Friday_1200)
        Me.friday_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_1200.Location = New System.Drawing.Point(0, 243)
        Me.friday_1200.Name = "friday_1200"
        Me.friday_1200.Size = New System.Drawing.Size(122, 23)
        Me.friday_1200.TabIndex = 11
        '
        'lbl_Friday_1200
        '
        Me.lbl_Friday_1200.AutoSize = True
        Me.lbl_Friday_1200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_1200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_1200.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_1200.Name = "lbl_Friday_1200"
        Me.lbl_Friday_1200.Size = New System.Drawing.Size(86, 15)
        Me.lbl_Friday_1200.TabIndex = 11
        Me.lbl_Friday_1200.Text = "lbl_Friday_1200"
        '
        'friday_830
        '
        Me.friday_830.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_830.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_830.Controls.Add(Me.lbl_Friday_830)
        Me.friday_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_830.Location = New System.Drawing.Point(0, 89)
        Me.friday_830.Name = "friday_830"
        Me.friday_830.Size = New System.Drawing.Size(122, 23)
        Me.friday_830.TabIndex = 11
        '
        'lbl_Friday_830
        '
        Me.lbl_Friday_830.AutoSize = True
        Me.lbl_Friday_830.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_830.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_830.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_830.Name = "lbl_Friday_830"
        Me.lbl_Friday_830.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_830.TabIndex = 11
        Me.lbl_Friday_830.Text = "lbl_Friday_830"
        '
        'friday_800
        '
        Me.friday_800.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_800.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_800.Controls.Add(Me.lbl_Friday_800)
        Me.friday_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_800.Location = New System.Drawing.Point(0, 67)
        Me.friday_800.Name = "friday_800"
        Me.friday_800.Size = New System.Drawing.Size(122, 23)
        Me.friday_800.TabIndex = 11
        '
        'lbl_Friday_800
        '
        Me.lbl_Friday_800.AutoSize = True
        Me.lbl_Friday_800.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_800.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_800.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_800.Name = "lbl_Friday_800"
        Me.lbl_Friday_800.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_800.TabIndex = 11
        Me.lbl_Friday_800.Text = "lbl_Friday_800"
        '
        'friday_430
        '
        Me.friday_430.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_430.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_430.Controls.Add(Me.lbl_Friday_430)
        Me.friday_430.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_430.Location = New System.Drawing.Point(0, 441)
        Me.friday_430.Name = "friday_430"
        Me.friday_430.Size = New System.Drawing.Size(122, 23)
        Me.friday_430.TabIndex = 11
        '
        'lbl_Friday_430
        '
        Me.lbl_Friday_430.AutoSize = True
        Me.lbl_Friday_430.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_430.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_430.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_430.Name = "lbl_Friday_430"
        Me.lbl_Friday_430.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_430.TabIndex = 11
        Me.lbl_Friday_430.Text = "lbl_Friday_430"
        '
        'friday_730
        '
        Me.friday_730.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_730.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_730.Controls.Add(Me.lbl_Friday_730)
        Me.friday_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_730.Location = New System.Drawing.Point(0, 45)
        Me.friday_730.Name = "friday_730"
        Me.friday_730.Size = New System.Drawing.Size(122, 23)
        Me.friday_730.TabIndex = 11
        '
        'lbl_Friday_730
        '
        Me.lbl_Friday_730.AutoSize = True
        Me.lbl_Friday_730.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_730.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_730.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_730.Name = "lbl_Friday_730"
        Me.lbl_Friday_730.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_730.TabIndex = 11
        Me.lbl_Friday_730.Text = "lbl_Friday_730"
        '
        'friday_700
        '
        Me.friday_700.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_700.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_700.Controls.Add(Me.lbl_Friday_700)
        Me.friday_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_700.Location = New System.Drawing.Point(0, 23)
        Me.friday_700.Name = "friday_700"
        Me.friday_700.Size = New System.Drawing.Size(122, 23)
        Me.friday_700.TabIndex = 11
        '
        'lbl_Friday_700
        '
        Me.lbl_Friday_700.AutoSize = True
        Me.lbl_Friday_700.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_700.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_700.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_700.Name = "lbl_Friday_700"
        Me.lbl_Friday_700.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_700.TabIndex = 11
        Me.lbl_Friday_700.Text = "lbl_Friday_700"
        '
        'friday_630AM
        '
        Me.friday_630AM.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_630AM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_630AM.Controls.Add(Me.lbl_Friday_630)
        Me.friday_630AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_630AM.Location = New System.Drawing.Point(0, 1)
        Me.friday_630AM.Name = "friday_630AM"
        Me.friday_630AM.Size = New System.Drawing.Size(122, 23)
        Me.friday_630AM.TabIndex = 11
        '
        'lbl_Friday_630
        '
        Me.lbl_Friday_630.AutoSize = True
        Me.lbl_Friday_630.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_630.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_630.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_630.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_630.Name = "lbl_Friday_630"
        Me.lbl_Friday_630.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_630.TabIndex = 11
        Me.lbl_Friday_630.Text = "lbl_Friday_630"
        '
        'friday_330
        '
        Me.friday_330.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_330.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_330.Controls.Add(Me.GunaLabel42)
        Me.friday_330.Controls.Add(Me.lbl_Friday_330)
        Me.friday_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_330.Location = New System.Drawing.Point(0, 397)
        Me.friday_330.Name = "friday_330"
        Me.friday_330.Size = New System.Drawing.Size(122, 23)
        Me.friday_330.TabIndex = 11
        '
        'GunaLabel42
        '
        Me.GunaLabel42.AutoSize = True
        Me.GunaLabel42.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GunaLabel42.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel42.Location = New System.Drawing.Point(-589, -251)
        Me.GunaLabel42.Name = "GunaLabel42"
        Me.GunaLabel42.Size = New System.Drawing.Size(92, 15)
        Me.GunaLabel42.TabIndex = 11
        Me.GunaLabel42.Text = "lbl_Monday_930"
        '
        'lbl_Friday_330
        '
        Me.lbl_Friday_330.AutoSize = True
        Me.lbl_Friday_330.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_330.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_330.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_330.Name = "lbl_Friday_330"
        Me.lbl_Friday_330.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Friday_330.TabIndex = 11
        Me.lbl_Friday_330.Text = "lbl_Friday_330"
        '
        'friday_400
        '
        Me.friday_400.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.friday_400.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.friday_400.Controls.Add(Me.lbl_Friday_400)
        Me.friday_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.friday_400.Location = New System.Drawing.Point(0, 419)
        Me.friday_400.Name = "friday_400"
        Me.friday_400.Size = New System.Drawing.Size(122, 23)
        Me.friday_400.TabIndex = 11
        '
        'lbl_Friday_400
        '
        Me.lbl_Friday_400.AutoSize = True
        Me.lbl_Friday_400.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Friday_400.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Friday_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Friday_400.Location = New System.Drawing.Point(9, 3)
        Me.lbl_Friday_400.Name = "lbl_Friday_400"
        Me.lbl_Friday_400.Size = New System.Drawing.Size(74, 15)
        Me.lbl_Friday_400.TabIndex = 11
        Me.lbl_Friday_400.Text = "lbl_Friday_4.."
        '
        'GunaPanel8
        '
        Me.GunaPanel8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaPanel8.Controls.Add(Me.thursday_600PM)
        Me.GunaPanel8.Controls.Add(Me.thursday_300)
        Me.GunaPanel8.Controls.Add(Me.thursday_1130)
        Me.GunaPanel8.Controls.Add(Me.thursday_230)
        Me.GunaPanel8.Controls.Add(Me.thursday_1100)
        Me.GunaPanel8.Controls.Add(Me.thursday_530)
        Me.GunaPanel8.Controls.Add(Me.thursday_200)
        Me.GunaPanel8.Controls.Add(Me.thursday_1030)
        Me.GunaPanel8.Controls.Add(Me.thursday_130)
        Me.GunaPanel8.Controls.Add(Me.thursday_1000)
        Me.GunaPanel8.Controls.Add(Me.thursday_500)
        Me.GunaPanel8.Controls.Add(Me.thursday_100)
        Me.GunaPanel8.Controls.Add(Me.thursday_930)
        Me.GunaPanel8.Controls.Add(Me.thursday_1230)
        Me.GunaPanel8.Controls.Add(Me.thursday_900)
        Me.GunaPanel8.Controls.Add(Me.thursday_430)
        Me.GunaPanel8.Controls.Add(Me.thursday_1200)
        Me.GunaPanel8.Controls.Add(Me.thursday_830)
        Me.GunaPanel8.Controls.Add(Me.thursday_800)
        Me.GunaPanel8.Controls.Add(Me.thursday_730)
        Me.GunaPanel8.Controls.Add(Me.thursday_400)
        Me.GunaPanel8.Controls.Add(Me.thursday_700)
        Me.GunaPanel8.Controls.Add(Me.thursday_630)
        Me.GunaPanel8.Controls.Add(Me.thursday_330)
        Me.GunaPanel8.Location = New System.Drawing.Point(412, 26)
        Me.GunaPanel8.Name = "GunaPanel8"
        Me.GunaPanel8.Size = New System.Drawing.Size(123, 532)
        Me.GunaPanel8.TabIndex = 11
        '
        'thursday_600PM
        '
        Me.thursday_600PM.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_600PM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_600PM.Controls.Add(Me.lbl_Thursday_600)
        Me.thursday_600PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_600PM.Location = New System.Drawing.Point(0, 507)
        Me.thursday_600PM.Name = "thursday_600PM"
        Me.thursday_600PM.Size = New System.Drawing.Size(122, 23)
        Me.thursday_600PM.TabIndex = 11
        '
        'lbl_Thursday_600
        '
        Me.lbl_Thursday_600.AutoSize = True
        Me.lbl_Thursday_600.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_600.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_600.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_600.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_600.Name = "lbl_Thursday_600"
        Me.lbl_Thursday_600.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_600.TabIndex = 11
        Me.lbl_Thursday_600.Text = "lbl_Thursday_600"
        '
        'thursday_300
        '
        Me.thursday_300.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_300.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_300.Controls.Add(Me.lbl_Thursday_300)
        Me.thursday_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_300.Location = New System.Drawing.Point(0, 375)
        Me.thursday_300.Name = "thursday_300"
        Me.thursday_300.Size = New System.Drawing.Size(122, 23)
        Me.thursday_300.TabIndex = 11
        '
        'lbl_Thursday_300
        '
        Me.lbl_Thursday_300.AutoSize = True
        Me.lbl_Thursday_300.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_300.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_300.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_300.Name = "lbl_Thursday_300"
        Me.lbl_Thursday_300.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_300.TabIndex = 11
        Me.lbl_Thursday_300.Text = "lbl_Thursday_300"
        '
        'thursday_1130
        '
        Me.thursday_1130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_1130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_1130.Controls.Add(Me.lbl_Thursday_1130)
        Me.thursday_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_1130.Location = New System.Drawing.Point(0, 221)
        Me.thursday_1130.Name = "thursday_1130"
        Me.thursday_1130.Size = New System.Drawing.Size(122, 23)
        Me.thursday_1130.TabIndex = 11
        '
        'lbl_Thursday_1130
        '
        Me.lbl_Thursday_1130.AutoSize = True
        Me.lbl_Thursday_1130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_1130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_1130.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_1130.Name = "lbl_Thursday_1130"
        Me.lbl_Thursday_1130.Size = New System.Drawing.Size(102, 15)
        Me.lbl_Thursday_1130.TabIndex = 11
        Me.lbl_Thursday_1130.Text = "lbl_Thursday_1130"
        '
        'thursday_230
        '
        Me.thursday_230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_230.Controls.Add(Me.lbl_Thursday_230)
        Me.thursday_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_230.Location = New System.Drawing.Point(0, 353)
        Me.thursday_230.Name = "thursday_230"
        Me.thursday_230.Size = New System.Drawing.Size(122, 23)
        Me.thursday_230.TabIndex = 11
        '
        'lbl_Thursday_230
        '
        Me.lbl_Thursday_230.AutoSize = True
        Me.lbl_Thursday_230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_230.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_230.Name = "lbl_Thursday_230"
        Me.lbl_Thursday_230.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_230.TabIndex = 11
        Me.lbl_Thursday_230.Text = "lbl_Thursday_230"
        '
        'thursday_1100
        '
        Me.thursday_1100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_1100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_1100.Controls.Add(Me.lbl_Thursday_1100)
        Me.thursday_1100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_1100.Location = New System.Drawing.Point(0, 199)
        Me.thursday_1100.Name = "thursday_1100"
        Me.thursday_1100.Size = New System.Drawing.Size(122, 23)
        Me.thursday_1100.TabIndex = 11
        '
        'lbl_Thursday_1100
        '
        Me.lbl_Thursday_1100.AutoSize = True
        Me.lbl_Thursday_1100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_1100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_1100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_1100.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_1100.Name = "lbl_Thursday_1100"
        Me.lbl_Thursday_1100.Size = New System.Drawing.Size(102, 15)
        Me.lbl_Thursday_1100.TabIndex = 11
        Me.lbl_Thursday_1100.Text = "lbl_Thursday_1100"
        '
        'thursday_530
        '
        Me.thursday_530.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_530.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_530.Controls.Add(Me.lbl_Thursday_530)
        Me.thursday_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_530.Location = New System.Drawing.Point(0, 485)
        Me.thursday_530.Name = "thursday_530"
        Me.thursday_530.Size = New System.Drawing.Size(122, 23)
        Me.thursday_530.TabIndex = 11
        '
        'lbl_Thursday_530
        '
        Me.lbl_Thursday_530.AutoSize = True
        Me.lbl_Thursday_530.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_530.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_530.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_530.Name = "lbl_Thursday_530"
        Me.lbl_Thursday_530.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_530.TabIndex = 11
        Me.lbl_Thursday_530.Text = "lbl_Thursday_530"
        '
        'thursday_200
        '
        Me.thursday_200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_200.Controls.Add(Me.lbl_Thursday_200)
        Me.thursday_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_200.Location = New System.Drawing.Point(0, 331)
        Me.thursday_200.Name = "thursday_200"
        Me.thursday_200.Size = New System.Drawing.Size(122, 23)
        Me.thursday_200.TabIndex = 11
        '
        'lbl_Thursday_200
        '
        Me.lbl_Thursday_200.AutoSize = True
        Me.lbl_Thursday_200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_200.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_200.Name = "lbl_Thursday_200"
        Me.lbl_Thursday_200.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_200.TabIndex = 11
        Me.lbl_Thursday_200.Text = "lbl_Thursday_200"
        '
        'thursday_1030
        '
        Me.thursday_1030.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_1030.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_1030.Controls.Add(Me.lbl_Thursday_1030)
        Me.thursday_1030.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_1030.Location = New System.Drawing.Point(0, 177)
        Me.thursday_1030.Name = "thursday_1030"
        Me.thursday_1030.Size = New System.Drawing.Size(122, 23)
        Me.thursday_1030.TabIndex = 11
        '
        'lbl_Thursday_1030
        '
        Me.lbl_Thursday_1030.AutoSize = True
        Me.lbl_Thursday_1030.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_1030.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_1030.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_1030.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_1030.Name = "lbl_Thursday_1030"
        Me.lbl_Thursday_1030.Size = New System.Drawing.Size(102, 15)
        Me.lbl_Thursday_1030.TabIndex = 11
        Me.lbl_Thursday_1030.Text = "lbl_Thursday_1030"
        '
        'thursday_130
        '
        Me.thursday_130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_130.Controls.Add(Me.lbl_Thursday_130)
        Me.thursday_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_130.Location = New System.Drawing.Point(0, 309)
        Me.thursday_130.Name = "thursday_130"
        Me.thursday_130.Size = New System.Drawing.Size(122, 23)
        Me.thursday_130.TabIndex = 11
        '
        'lbl_Thursday_130
        '
        Me.lbl_Thursday_130.AutoSize = True
        Me.lbl_Thursday_130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_130.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_130.Name = "lbl_Thursday_130"
        Me.lbl_Thursday_130.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_130.TabIndex = 11
        Me.lbl_Thursday_130.Text = "lbl_Thursday_130"
        '
        'thursday_1000
        '
        Me.thursday_1000.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_1000.Controls.Add(Me.lbl_Thursday_1000)
        Me.thursday_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_1000.Location = New System.Drawing.Point(0, 155)
        Me.thursday_1000.Name = "thursday_1000"
        Me.thursday_1000.Size = New System.Drawing.Size(122, 23)
        Me.thursday_1000.TabIndex = 11
        '
        'lbl_Thursday_1000
        '
        Me.lbl_Thursday_1000.AutoSize = True
        Me.lbl_Thursday_1000.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_1000.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_1000.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_1000.Name = "lbl_Thursday_1000"
        Me.lbl_Thursday_1000.Size = New System.Drawing.Size(102, 15)
        Me.lbl_Thursday_1000.TabIndex = 11
        Me.lbl_Thursday_1000.Text = "lbl_Thursday_1000"
        '
        'thursday_500
        '
        Me.thursday_500.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_500.Controls.Add(Me.lbl_Thursday_500)
        Me.thursday_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_500.Location = New System.Drawing.Point(0, 463)
        Me.thursday_500.Name = "thursday_500"
        Me.thursday_500.Size = New System.Drawing.Size(122, 23)
        Me.thursday_500.TabIndex = 11
        '
        'lbl_Thursday_500
        '
        Me.lbl_Thursday_500.AutoSize = True
        Me.lbl_Thursday_500.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_500.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_500.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_500.Name = "lbl_Thursday_500"
        Me.lbl_Thursday_500.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_500.TabIndex = 11
        Me.lbl_Thursday_500.Text = "lbl_Thursday_500"
        '
        'thursday_100
        '
        Me.thursday_100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_100.Controls.Add(Me.lbl_Thursday_100)
        Me.thursday_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_100.Location = New System.Drawing.Point(0, 287)
        Me.thursday_100.Name = "thursday_100"
        Me.thursday_100.Size = New System.Drawing.Size(122, 23)
        Me.thursday_100.TabIndex = 11
        '
        'lbl_Thursday_100
        '
        Me.lbl_Thursday_100.AutoSize = True
        Me.lbl_Thursday_100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_100.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_100.Name = "lbl_Thursday_100"
        Me.lbl_Thursday_100.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_100.TabIndex = 11
        Me.lbl_Thursday_100.Text = "lbl_Thursday_100"
        '
        'thursday_930
        '
        Me.thursday_930.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_930.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_930.Controls.Add(Me.lbl_Thursday_930)
        Me.thursday_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_930.Location = New System.Drawing.Point(0, 133)
        Me.thursday_930.Name = "thursday_930"
        Me.thursday_930.Size = New System.Drawing.Size(122, 23)
        Me.thursday_930.TabIndex = 11
        '
        'lbl_Thursday_930
        '
        Me.lbl_Thursday_930.AutoSize = True
        Me.lbl_Thursday_930.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_930.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_930.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_930.Name = "lbl_Thursday_930"
        Me.lbl_Thursday_930.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_930.TabIndex = 11
        Me.lbl_Thursday_930.Text = "lbl_Thursday_930"
        '
        'thursday_1230
        '
        Me.thursday_1230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_1230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_1230.Controls.Add(Me.lbl_Thursday_1230)
        Me.thursday_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_1230.Location = New System.Drawing.Point(0, 265)
        Me.thursday_1230.Name = "thursday_1230"
        Me.thursday_1230.Size = New System.Drawing.Size(122, 23)
        Me.thursday_1230.TabIndex = 11
        '
        'lbl_Thursday_1230
        '
        Me.lbl_Thursday_1230.AutoSize = True
        Me.lbl_Thursday_1230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_1230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_1230.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_1230.Name = "lbl_Thursday_1230"
        Me.lbl_Thursday_1230.Size = New System.Drawing.Size(102, 15)
        Me.lbl_Thursday_1230.TabIndex = 11
        Me.lbl_Thursday_1230.Text = "lbl_Thursday_1230"
        '
        'thursday_900
        '
        Me.thursday_900.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_900.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_900.Controls.Add(Me.lbl_Thursday_900)
        Me.thursday_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_900.Location = New System.Drawing.Point(0, 111)
        Me.thursday_900.Name = "thursday_900"
        Me.thursday_900.Size = New System.Drawing.Size(122, 23)
        Me.thursday_900.TabIndex = 11
        '
        'lbl_Thursday_900
        '
        Me.lbl_Thursday_900.AutoSize = True
        Me.lbl_Thursday_900.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_900.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_900.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_900.Name = "lbl_Thursday_900"
        Me.lbl_Thursday_900.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_900.TabIndex = 11
        Me.lbl_Thursday_900.Text = "lbl_Thursday_900"
        '
        'thursday_430
        '
        Me.thursday_430.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_430.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_430.Controls.Add(Me.lbl_Thursday_430)
        Me.thursday_430.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_430.Location = New System.Drawing.Point(0, 441)
        Me.thursday_430.Name = "thursday_430"
        Me.thursday_430.Size = New System.Drawing.Size(122, 23)
        Me.thursday_430.TabIndex = 11
        '
        'lbl_Thursday_430
        '
        Me.lbl_Thursday_430.AutoSize = True
        Me.lbl_Thursday_430.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_430.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_430.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_430.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_430.Name = "lbl_Thursday_430"
        Me.lbl_Thursday_430.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_430.TabIndex = 11
        Me.lbl_Thursday_430.Text = "lbl_Thursday_430"
        '
        'thursday_1200
        '
        Me.thursday_1200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_1200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_1200.Controls.Add(Me.lbl_Thursday_1200)
        Me.thursday_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_1200.Location = New System.Drawing.Point(0, 243)
        Me.thursday_1200.Name = "thursday_1200"
        Me.thursday_1200.Size = New System.Drawing.Size(122, 23)
        Me.thursday_1200.TabIndex = 11
        '
        'lbl_Thursday_1200
        '
        Me.lbl_Thursday_1200.AutoSize = True
        Me.lbl_Thursday_1200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_1200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_1200.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_1200.Name = "lbl_Thursday_1200"
        Me.lbl_Thursday_1200.Size = New System.Drawing.Size(102, 15)
        Me.lbl_Thursday_1200.TabIndex = 11
        Me.lbl_Thursday_1200.Text = "lbl_Thursday_1200"
        '
        'thursday_830
        '
        Me.thursday_830.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_830.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_830.Controls.Add(Me.lbl_Thursday_830)
        Me.thursday_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_830.Location = New System.Drawing.Point(0, 89)
        Me.thursday_830.Name = "thursday_830"
        Me.thursday_830.Size = New System.Drawing.Size(122, 23)
        Me.thursday_830.TabIndex = 11
        '
        'lbl_Thursday_830
        '
        Me.lbl_Thursday_830.AutoSize = True
        Me.lbl_Thursday_830.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_830.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_830.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_830.Name = "lbl_Thursday_830"
        Me.lbl_Thursday_830.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_830.TabIndex = 11
        Me.lbl_Thursday_830.Text = "lbl_Thursday_830"
        '
        'thursday_800
        '
        Me.thursday_800.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_800.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_800.Controls.Add(Me.lbl_Thursday_800)
        Me.thursday_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_800.Location = New System.Drawing.Point(0, 67)
        Me.thursday_800.Name = "thursday_800"
        Me.thursday_800.Size = New System.Drawing.Size(122, 23)
        Me.thursday_800.TabIndex = 11
        '
        'lbl_Thursday_800
        '
        Me.lbl_Thursday_800.AutoSize = True
        Me.lbl_Thursday_800.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_800.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_800.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_800.Name = "lbl_Thursday_800"
        Me.lbl_Thursday_800.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_800.TabIndex = 11
        Me.lbl_Thursday_800.Text = "lbl_Thursday_800"
        '
        'thursday_730
        '
        Me.thursday_730.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_730.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_730.Controls.Add(Me.lbl_Thursday_730)
        Me.thursday_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_730.Location = New System.Drawing.Point(0, 45)
        Me.thursday_730.Name = "thursday_730"
        Me.thursday_730.Size = New System.Drawing.Size(122, 23)
        Me.thursday_730.TabIndex = 11
        '
        'lbl_Thursday_730
        '
        Me.lbl_Thursday_730.AutoSize = True
        Me.lbl_Thursday_730.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_730.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_730.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_730.Name = "lbl_Thursday_730"
        Me.lbl_Thursday_730.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_730.TabIndex = 11
        Me.lbl_Thursday_730.Text = "lbl_Thursday_730"
        '
        'thursday_400
        '
        Me.thursday_400.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_400.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_400.Controls.Add(Me.lbl_Thursday_400)
        Me.thursday_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_400.Location = New System.Drawing.Point(0, 419)
        Me.thursday_400.Name = "thursday_400"
        Me.thursday_400.Size = New System.Drawing.Size(122, 23)
        Me.thursday_400.TabIndex = 11
        '
        'lbl_Thursday_400
        '
        Me.lbl_Thursday_400.AutoSize = True
        Me.lbl_Thursday_400.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_400.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_400.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_400.Name = "lbl_Thursday_400"
        Me.lbl_Thursday_400.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_400.TabIndex = 11
        Me.lbl_Thursday_400.Text = "lbl_Thursday_400"
        '
        'thursday_700
        '
        Me.thursday_700.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_700.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_700.Controls.Add(Me.lbl_Thursday_700)
        Me.thursday_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_700.Location = New System.Drawing.Point(0, 23)
        Me.thursday_700.Name = "thursday_700"
        Me.thursday_700.Size = New System.Drawing.Size(122, 23)
        Me.thursday_700.TabIndex = 11
        '
        'lbl_Thursday_700
        '
        Me.lbl_Thursday_700.AutoSize = True
        Me.lbl_Thursday_700.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_700.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_700.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_700.Name = "lbl_Thursday_700"
        Me.lbl_Thursday_700.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_700.TabIndex = 11
        Me.lbl_Thursday_700.Text = "lbl_Thursday_700"
        '
        'thursday_630
        '
        Me.thursday_630.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_630.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_630.Controls.Add(Me.lbl_Thursday_630)
        Me.thursday_630.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_630.Location = New System.Drawing.Point(0, 1)
        Me.thursday_630.Name = "thursday_630"
        Me.thursday_630.Size = New System.Drawing.Size(122, 23)
        Me.thursday_630.TabIndex = 11
        '
        'lbl_Thursday_630
        '
        Me.lbl_Thursday_630.AutoSize = True
        Me.lbl_Thursday_630.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_630.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_630.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_630.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_630.Name = "lbl_Thursday_630"
        Me.lbl_Thursday_630.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_630.TabIndex = 11
        Me.lbl_Thursday_630.Text = "lbl_Thursday_630"
        '
        'thursday_330
        '
        Me.thursday_330.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.thursday_330.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thursday_330.Controls.Add(Me.lbl_Thursday_330)
        Me.thursday_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thursday_330.Location = New System.Drawing.Point(0, 397)
        Me.thursday_330.Name = "thursday_330"
        Me.thursday_330.Size = New System.Drawing.Size(122, 23)
        Me.thursday_330.TabIndex = 11
        '
        'lbl_Thursday_330
        '
        Me.lbl_Thursday_330.AutoSize = True
        Me.lbl_Thursday_330.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Thursday_330.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Thursday_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Thursday_330.Location = New System.Drawing.Point(10, 3)
        Me.lbl_Thursday_330.Name = "lbl_Thursday_330"
        Me.lbl_Thursday_330.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Thursday_330.TabIndex = 11
        Me.lbl_Thursday_330.Text = "lbl_Thursday_330"
        '
        'GunaPanel6
        '
        Me.GunaPanel6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaPanel6.Controls.Add(Me.wednes_600PM)
        Me.GunaPanel6.Controls.Add(Me.wednes_300)
        Me.GunaPanel6.Controls.Add(Me.wednes_1130)
        Me.GunaPanel6.Controls.Add(Me.wednes_230)
        Me.GunaPanel6.Controls.Add(Me.wednes_530)
        Me.GunaPanel6.Controls.Add(Me.wednes_1100)
        Me.GunaPanel6.Controls.Add(Me.wednes_200)
        Me.GunaPanel6.Controls.Add(Me.wednes_1030)
        Me.GunaPanel6.Controls.Add(Me.wednes_500)
        Me.GunaPanel6.Controls.Add(Me.wednes_130)
        Me.GunaPanel6.Controls.Add(Me.wednes_1000)
        Me.GunaPanel6.Controls.Add(Me.wednes_100)
        Me.GunaPanel6.Controls.Add(Me.wednes_430)
        Me.GunaPanel6.Controls.Add(Me.wednes_930)
        Me.GunaPanel6.Controls.Add(Me.wednes_1230)
        Me.GunaPanel6.Controls.Add(Me.wednes_900)
        Me.GunaPanel6.Controls.Add(Me.wednes_400)
        Me.GunaPanel6.Controls.Add(Me.wednes_1200)
        Me.GunaPanel6.Controls.Add(Me.wednes_830)
        Me.GunaPanel6.Controls.Add(Me.wednes_800)
        Me.GunaPanel6.Controls.Add(Me.wednes_330)
        Me.GunaPanel6.Controls.Add(Me.wednes_730)
        Me.GunaPanel6.Controls.Add(Me.wednes_700)
        Me.GunaPanel6.Controls.Add(Me.wednes_630)
        Me.GunaPanel6.Location = New System.Drawing.Point(291, 26)
        Me.GunaPanel6.Name = "GunaPanel6"
        Me.GunaPanel6.Size = New System.Drawing.Size(123, 532)
        Me.GunaPanel6.TabIndex = 11
        '
        'wednes_600PM
        '
        Me.wednes_600PM.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_600PM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_600PM.Controls.Add(Me.lbl_Wednesday_600)
        Me.wednes_600PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_600PM.Location = New System.Drawing.Point(0, 507)
        Me.wednes_600PM.Name = "wednes_600PM"
        Me.wednes_600PM.Size = New System.Drawing.Size(122, 23)
        Me.wednes_600PM.TabIndex = 11
        '
        'lbl_Wednesday_600
        '
        Me.lbl_Wednesday_600.AutoSize = True
        Me.lbl_Wednesday_600.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_600.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_600.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_600.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_600.Name = "lbl_Wednesday_600"
        Me.lbl_Wednesday_600.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_600.TabIndex = 11
        Me.lbl_Wednesday_600.Text = "lbl_Wednesday_600"
        '
        'wednes_300
        '
        Me.wednes_300.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_300.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_300.Controls.Add(Me.lbl_Wednesday_300)
        Me.wednes_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_300.Location = New System.Drawing.Point(0, 375)
        Me.wednes_300.Name = "wednes_300"
        Me.wednes_300.Size = New System.Drawing.Size(122, 23)
        Me.wednes_300.TabIndex = 11
        '
        'lbl_Wednesday_300
        '
        Me.lbl_Wednesday_300.AutoSize = True
        Me.lbl_Wednesday_300.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_300.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_300.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_300.Name = "lbl_Wednesday_300"
        Me.lbl_Wednesday_300.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_300.TabIndex = 11
        Me.lbl_Wednesday_300.Text = "lbl_Wednesday_300"
        '
        'wednes_1130
        '
        Me.wednes_1130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_1130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_1130.Controls.Add(Me.lbl_Wednesday_1130)
        Me.wednes_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_1130.Location = New System.Drawing.Point(0, 221)
        Me.wednes_1130.Name = "wednes_1130"
        Me.wednes_1130.Size = New System.Drawing.Size(122, 23)
        Me.wednes_1130.TabIndex = 11
        '
        'lbl_Wednesday_1130
        '
        Me.lbl_Wednesday_1130.AutoSize = True
        Me.lbl_Wednesday_1130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_1130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_1130.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_1130.Name = "lbl_Wednesday_1130"
        Me.lbl_Wednesday_1130.Size = New System.Drawing.Size(115, 15)
        Me.lbl_Wednesday_1130.TabIndex = 11
        Me.lbl_Wednesday_1130.Text = "lbl_Wednesday_1130"
        '
        'wednes_230
        '
        Me.wednes_230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_230.Controls.Add(Me.lbl_Wednesday_230)
        Me.wednes_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_230.Location = New System.Drawing.Point(0, 353)
        Me.wednes_230.Name = "wednes_230"
        Me.wednes_230.Size = New System.Drawing.Size(122, 23)
        Me.wednes_230.TabIndex = 11
        '
        'lbl_Wednesday_230
        '
        Me.lbl_Wednesday_230.AutoSize = True
        Me.lbl_Wednesday_230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_230.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_230.Name = "lbl_Wednesday_230"
        Me.lbl_Wednesday_230.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_230.TabIndex = 11
        Me.lbl_Wednesday_230.Text = "lbl_Wednesday_230"
        '
        'wednes_530
        '
        Me.wednes_530.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_530.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_530.Controls.Add(Me.lbl_Wednesday_530)
        Me.wednes_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_530.Location = New System.Drawing.Point(0, 485)
        Me.wednes_530.Name = "wednes_530"
        Me.wednes_530.Size = New System.Drawing.Size(122, 23)
        Me.wednes_530.TabIndex = 11
        '
        'lbl_Wednesday_530
        '
        Me.lbl_Wednesday_530.AutoSize = True
        Me.lbl_Wednesday_530.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_530.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_530.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_530.Name = "lbl_Wednesday_530"
        Me.lbl_Wednesday_530.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_530.TabIndex = 11
        Me.lbl_Wednesday_530.Text = "lbl_Wednesday_530"
        '
        'wednes_1100
        '
        Me.wednes_1100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_1100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_1100.Controls.Add(Me.lbl_Wednesday_1100)
        Me.wednes_1100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_1100.Location = New System.Drawing.Point(0, 199)
        Me.wednes_1100.Name = "wednes_1100"
        Me.wednes_1100.Size = New System.Drawing.Size(122, 23)
        Me.wednes_1100.TabIndex = 11
        '
        'lbl_Wednesday_1100
        '
        Me.lbl_Wednesday_1100.AutoSize = True
        Me.lbl_Wednesday_1100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_1100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_1100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_1100.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_1100.Name = "lbl_Wednesday_1100"
        Me.lbl_Wednesday_1100.Size = New System.Drawing.Size(115, 15)
        Me.lbl_Wednesday_1100.TabIndex = 11
        Me.lbl_Wednesday_1100.Text = "lbl_Wednesday_1100"
        '
        'wednes_200
        '
        Me.wednes_200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_200.Controls.Add(Me.lbl_Wednesday_200)
        Me.wednes_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_200.Location = New System.Drawing.Point(0, 331)
        Me.wednes_200.Name = "wednes_200"
        Me.wednes_200.Size = New System.Drawing.Size(122, 23)
        Me.wednes_200.TabIndex = 11
        '
        'lbl_Wednesday_200
        '
        Me.lbl_Wednesday_200.AutoSize = True
        Me.lbl_Wednesday_200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_200.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_200.Name = "lbl_Wednesday_200"
        Me.lbl_Wednesday_200.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_200.TabIndex = 11
        Me.lbl_Wednesday_200.Text = "lbl_Wednesday_200"
        '
        'wednes_1030
        '
        Me.wednes_1030.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_1030.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_1030.Controls.Add(Me.lbl_Wednesday_1030)
        Me.wednes_1030.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_1030.Location = New System.Drawing.Point(0, 177)
        Me.wednes_1030.Name = "wednes_1030"
        Me.wednes_1030.Size = New System.Drawing.Size(122, 23)
        Me.wednes_1030.TabIndex = 11
        '
        'lbl_Wednesday_1030
        '
        Me.lbl_Wednesday_1030.AutoSize = True
        Me.lbl_Wednesday_1030.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_1030.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_1030.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_1030.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_1030.Name = "lbl_Wednesday_1030"
        Me.lbl_Wednesday_1030.Size = New System.Drawing.Size(115, 15)
        Me.lbl_Wednesday_1030.TabIndex = 11
        Me.lbl_Wednesday_1030.Text = "lbl_Wednesday_1030"
        '
        'wednes_500
        '
        Me.wednes_500.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_500.Controls.Add(Me.lbl_Wednesday_500)
        Me.wednes_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_500.Location = New System.Drawing.Point(0, 463)
        Me.wednes_500.Name = "wednes_500"
        Me.wednes_500.Size = New System.Drawing.Size(122, 23)
        Me.wednes_500.TabIndex = 11
        '
        'lbl_Wednesday_500
        '
        Me.lbl_Wednesday_500.AutoSize = True
        Me.lbl_Wednesday_500.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_500.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_500.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_500.Name = "lbl_Wednesday_500"
        Me.lbl_Wednesday_500.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_500.TabIndex = 11
        Me.lbl_Wednesday_500.Text = "lbl_Wednesday_500"
        '
        'wednes_130
        '
        Me.wednes_130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_130.Controls.Add(Me.lbl_Wednesday_130)
        Me.wednes_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_130.Location = New System.Drawing.Point(0, 309)
        Me.wednes_130.Name = "wednes_130"
        Me.wednes_130.Size = New System.Drawing.Size(122, 23)
        Me.wednes_130.TabIndex = 11
        '
        'lbl_Wednesday_130
        '
        Me.lbl_Wednesday_130.AutoSize = True
        Me.lbl_Wednesday_130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_130.Location = New System.Drawing.Point(7, 3)
        Me.lbl_Wednesday_130.Name = "lbl_Wednesday_130"
        Me.lbl_Wednesday_130.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_130.TabIndex = 11
        Me.lbl_Wednesday_130.Text = "lbl_Wednesday_130"
        '
        'wednes_1000
        '
        Me.wednes_1000.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_1000.Controls.Add(Me.lbl_Wednesday_1000)
        Me.wednes_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_1000.Location = New System.Drawing.Point(0, 155)
        Me.wednes_1000.Name = "wednes_1000"
        Me.wednes_1000.Size = New System.Drawing.Size(122, 23)
        Me.wednes_1000.TabIndex = 11
        '
        'lbl_Wednesday_1000
        '
        Me.lbl_Wednesday_1000.AutoSize = True
        Me.lbl_Wednesday_1000.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_1000.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_1000.Location = New System.Drawing.Point(7, 3)
        Me.lbl_Wednesday_1000.Name = "lbl_Wednesday_1000"
        Me.lbl_Wednesday_1000.Size = New System.Drawing.Size(115, 15)
        Me.lbl_Wednesday_1000.TabIndex = 11
        Me.lbl_Wednesday_1000.Text = "lbl_Wednesday_1000"
        '
        'wednes_100
        '
        Me.wednes_100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_100.Controls.Add(Me.lbl_Wednesday_100)
        Me.wednes_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_100.Location = New System.Drawing.Point(0, 287)
        Me.wednes_100.Name = "wednes_100"
        Me.wednes_100.Size = New System.Drawing.Size(122, 23)
        Me.wednes_100.TabIndex = 11
        '
        'lbl_Wednesday_100
        '
        Me.lbl_Wednesday_100.AutoSize = True
        Me.lbl_Wednesday_100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_100.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_100.Name = "lbl_Wednesday_100"
        Me.lbl_Wednesday_100.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_100.TabIndex = 11
        Me.lbl_Wednesday_100.Text = "lbl_Wednesday_100"
        '
        'wednes_430
        '
        Me.wednes_430.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_430.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_430.Controls.Add(Me.lbl_Wednesday_430)
        Me.wednes_430.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_430.Location = New System.Drawing.Point(0, 441)
        Me.wednes_430.Name = "wednes_430"
        Me.wednes_430.Size = New System.Drawing.Size(122, 23)
        Me.wednes_430.TabIndex = 11
        '
        'lbl_Wednesday_430
        '
        Me.lbl_Wednesday_430.AutoSize = True
        Me.lbl_Wednesday_430.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_430.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_430.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_430.Location = New System.Drawing.Point(7, 3)
        Me.lbl_Wednesday_430.Name = "lbl_Wednesday_430"
        Me.lbl_Wednesday_430.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_430.TabIndex = 11
        Me.lbl_Wednesday_430.Text = "lbl_Wednesday_430"
        '
        'wednes_930
        '
        Me.wednes_930.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_930.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_930.Controls.Add(Me.lbl_Wednesday_930)
        Me.wednes_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_930.Location = New System.Drawing.Point(0, 133)
        Me.wednes_930.Name = "wednes_930"
        Me.wednes_930.Size = New System.Drawing.Size(122, 23)
        Me.wednes_930.TabIndex = 11
        '
        'lbl_Wednesday_930
        '
        Me.lbl_Wednesday_930.AutoSize = True
        Me.lbl_Wednesday_930.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_930.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_930.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_930.Name = "lbl_Wednesday_930"
        Me.lbl_Wednesday_930.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_930.TabIndex = 11
        Me.lbl_Wednesday_930.Text = "lbl_Wednesday_930"
        '
        'wednes_1230
        '
        Me.wednes_1230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_1230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_1230.Controls.Add(Me.lbl_Wednesday_1230)
        Me.wednes_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_1230.Location = New System.Drawing.Point(0, 265)
        Me.wednes_1230.Name = "wednes_1230"
        Me.wednes_1230.Size = New System.Drawing.Size(122, 23)
        Me.wednes_1230.TabIndex = 11
        '
        'lbl_Wednesday_1230
        '
        Me.lbl_Wednesday_1230.AutoSize = True
        Me.lbl_Wednesday_1230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_1230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_1230.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_1230.Name = "lbl_Wednesday_1230"
        Me.lbl_Wednesday_1230.Size = New System.Drawing.Size(115, 15)
        Me.lbl_Wednesday_1230.TabIndex = 11
        Me.lbl_Wednesday_1230.Text = "lbl_Wednesday_1230"
        '
        'wednes_900
        '
        Me.wednes_900.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_900.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_900.Controls.Add(Me.lbl_Wednesday_900)
        Me.wednes_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_900.Location = New System.Drawing.Point(0, 111)
        Me.wednes_900.Name = "wednes_900"
        Me.wednes_900.Size = New System.Drawing.Size(122, 23)
        Me.wednes_900.TabIndex = 11
        '
        'lbl_Wednesday_900
        '
        Me.lbl_Wednesday_900.AutoSize = True
        Me.lbl_Wednesday_900.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_900.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_900.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_900.Name = "lbl_Wednesday_900"
        Me.lbl_Wednesday_900.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_900.TabIndex = 11
        Me.lbl_Wednesday_900.Text = "lbl_Wednesday_900"
        '
        'wednes_400
        '
        Me.wednes_400.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_400.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_400.Controls.Add(Me.lbl_Wednesday_400)
        Me.wednes_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_400.Location = New System.Drawing.Point(0, 419)
        Me.wednes_400.Name = "wednes_400"
        Me.wednes_400.Size = New System.Drawing.Size(122, 23)
        Me.wednes_400.TabIndex = 11
        '
        'lbl_Wednesday_400
        '
        Me.lbl_Wednesday_400.AutoSize = True
        Me.lbl_Wednesday_400.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_400.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_400.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_400.Name = "lbl_Wednesday_400"
        Me.lbl_Wednesday_400.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_400.TabIndex = 11
        Me.lbl_Wednesday_400.Text = "lbl_Wednesday_400"
        '
        'wednes_1200
        '
        Me.wednes_1200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_1200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_1200.Controls.Add(Me.lbl_Wednesday_1200)
        Me.wednes_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_1200.Location = New System.Drawing.Point(0, 243)
        Me.wednes_1200.Name = "wednes_1200"
        Me.wednes_1200.Size = New System.Drawing.Size(122, 23)
        Me.wednes_1200.TabIndex = 11
        '
        'lbl_Wednesday_1200
        '
        Me.lbl_Wednesday_1200.AutoSize = True
        Me.lbl_Wednesday_1200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_1200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_1200.Location = New System.Drawing.Point(7, 3)
        Me.lbl_Wednesday_1200.Name = "lbl_Wednesday_1200"
        Me.lbl_Wednesday_1200.Size = New System.Drawing.Size(115, 15)
        Me.lbl_Wednesday_1200.TabIndex = 11
        Me.lbl_Wednesday_1200.Text = "lbl_Wednesday_1200"
        '
        'wednes_830
        '
        Me.wednes_830.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_830.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_830.Controls.Add(Me.lbl_Wednesday_830)
        Me.wednes_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_830.Location = New System.Drawing.Point(0, 89)
        Me.wednes_830.Name = "wednes_830"
        Me.wednes_830.Size = New System.Drawing.Size(122, 23)
        Me.wednes_830.TabIndex = 11
        '
        'lbl_Wednesday_830
        '
        Me.lbl_Wednesday_830.AutoSize = True
        Me.lbl_Wednesday_830.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_830.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_830.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_830.Name = "lbl_Wednesday_830"
        Me.lbl_Wednesday_830.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_830.TabIndex = 11
        Me.lbl_Wednesday_830.Text = "lbl_Wednesday_830"
        '
        'wednes_800
        '
        Me.wednes_800.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_800.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_800.Controls.Add(Me.lbl_Wednesday_800)
        Me.wednes_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_800.Location = New System.Drawing.Point(0, 67)
        Me.wednes_800.Name = "wednes_800"
        Me.wednes_800.Size = New System.Drawing.Size(122, 23)
        Me.wednes_800.TabIndex = 11
        '
        'lbl_Wednesday_800
        '
        Me.lbl_Wednesday_800.AutoSize = True
        Me.lbl_Wednesday_800.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_800.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_800.Location = New System.Drawing.Point(7, 3)
        Me.lbl_Wednesday_800.Name = "lbl_Wednesday_800"
        Me.lbl_Wednesday_800.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_800.TabIndex = 11
        Me.lbl_Wednesday_800.Text = "lbl_Wednesday_800"
        '
        'wednes_330
        '
        Me.wednes_330.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_330.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_330.Controls.Add(Me.lbl_Wednesday_330)
        Me.wednes_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_330.Location = New System.Drawing.Point(0, 397)
        Me.wednes_330.Name = "wednes_330"
        Me.wednes_330.Size = New System.Drawing.Size(122, 23)
        Me.wednes_330.TabIndex = 11
        '
        'lbl_Wednesday_330
        '
        Me.lbl_Wednesday_330.AutoSize = True
        Me.lbl_Wednesday_330.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_330.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_330.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Wednesday_330.Name = "lbl_Wednesday_330"
        Me.lbl_Wednesday_330.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_330.TabIndex = 11
        Me.lbl_Wednesday_330.Text = "lbl_Wednesday_330"
        '
        'wednes_730
        '
        Me.wednes_730.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_730.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_730.Controls.Add(Me.lbl_Wednesday_730)
        Me.wednes_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_730.Location = New System.Drawing.Point(0, 45)
        Me.wednes_730.Name = "wednes_730"
        Me.wednes_730.Size = New System.Drawing.Size(122, 23)
        Me.wednes_730.TabIndex = 11
        '
        'lbl_Wednesday_730
        '
        Me.lbl_Wednesday_730.AutoSize = True
        Me.lbl_Wednesday_730.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_730.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_730.Location = New System.Drawing.Point(7, 3)
        Me.lbl_Wednesday_730.Name = "lbl_Wednesday_730"
        Me.lbl_Wednesday_730.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_730.TabIndex = 11
        Me.lbl_Wednesday_730.Text = "lbl_Wednesday_730"
        '
        'wednes_700
        '
        Me.wednes_700.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_700.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_700.Controls.Add(Me.lbl_Wednesday_700)
        Me.wednes_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_700.Location = New System.Drawing.Point(0, 23)
        Me.wednes_700.Name = "wednes_700"
        Me.wednes_700.Size = New System.Drawing.Size(122, 23)
        Me.wednes_700.TabIndex = 11
        '
        'lbl_Wednesday_700
        '
        Me.lbl_Wednesday_700.AutoSize = True
        Me.lbl_Wednesday_700.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_700.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_700.Location = New System.Drawing.Point(7, 2)
        Me.lbl_Wednesday_700.Name = "lbl_Wednesday_700"
        Me.lbl_Wednesday_700.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_700.TabIndex = 11
        Me.lbl_Wednesday_700.Text = "lbl_Wednesday_700"
        '
        'wednes_630
        '
        Me.wednes_630.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.wednes_630.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wednes_630.Controls.Add(Me.lbl_Wednesday_630)
        Me.wednes_630.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wednes_630.Location = New System.Drawing.Point(0, 1)
        Me.wednes_630.Name = "wednes_630"
        Me.wednes_630.Size = New System.Drawing.Size(122, 23)
        Me.wednes_630.TabIndex = 11
        '
        'lbl_Wednesday_630
        '
        Me.lbl_Wednesday_630.AutoSize = True
        Me.lbl_Wednesday_630.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wednesday_630.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wednesday_630.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Wednesday_630.Location = New System.Drawing.Point(5, 3)
        Me.lbl_Wednesday_630.Name = "lbl_Wednesday_630"
        Me.lbl_Wednesday_630.Size = New System.Drawing.Size(109, 15)
        Me.lbl_Wednesday_630.TabIndex = 11
        Me.lbl_Wednesday_630.Text = "lbl_Wednesday_630"
        '
        'GunaPanel28
        '
        Me.GunaPanel28.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaPanel28.Controls.Add(Me.tuesday_600PM)
        Me.GunaPanel28.Controls.Add(Me.tuesday_300)
        Me.GunaPanel28.Controls.Add(Me.tuesday_1130)
        Me.GunaPanel28.Controls.Add(Me.tuesday_530)
        Me.GunaPanel28.Controls.Add(Me.tuesday_230)
        Me.GunaPanel28.Controls.Add(Me.tuesday_1100)
        Me.GunaPanel28.Controls.Add(Me.tuesday_500)
        Me.GunaPanel28.Controls.Add(Me.tuesday_200)
        Me.GunaPanel28.Controls.Add(Me.tueasday_1030)
        Me.GunaPanel28.Controls.Add(Me.tuesday_430)
        Me.GunaPanel28.Controls.Add(Me.tuesday_130)
        Me.GunaPanel28.Controls.Add(Me.tuesday_1000)
        Me.GunaPanel28.Controls.Add(Me.tuesday_400)
        Me.GunaPanel28.Controls.Add(Me.tuesday_100)
        Me.GunaPanel28.Controls.Add(Me.tuesday_930)
        Me.GunaPanel28.Controls.Add(Me.tuesday_330)
        Me.GunaPanel28.Controls.Add(Me.tuesday_1230)
        Me.GunaPanel28.Controls.Add(Me.tuesday_900)
        Me.GunaPanel28.Controls.Add(Me.tuesday_1200)
        Me.GunaPanel28.Controls.Add(Me.tuesday_830)
        Me.GunaPanel28.Controls.Add(Me.tuesday_800)
        Me.GunaPanel28.Controls.Add(Me.tuesday_730)
        Me.GunaPanel28.Controls.Add(Me.tuesday_700)
        Me.GunaPanel28.Controls.Add(Me.tuesday_630AM)
        Me.GunaPanel28.Location = New System.Drawing.Point(170, 26)
        Me.GunaPanel28.Name = "GunaPanel28"
        Me.GunaPanel28.Size = New System.Drawing.Size(123, 532)
        Me.GunaPanel28.TabIndex = 11
        '
        'tuesday_600PM
        '
        Me.tuesday_600PM.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_600PM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_600PM.Controls.Add(Me.lbl_Tuesday_600)
        Me.tuesday_600PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_600PM.Location = New System.Drawing.Point(0, 507)
        Me.tuesday_600PM.Name = "tuesday_600PM"
        Me.tuesday_600PM.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_600PM.TabIndex = 11
        '
        'lbl_Tuesday_600
        '
        Me.lbl_Tuesday_600.AutoSize = True
        Me.lbl_Tuesday_600.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_600.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_600.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_600.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_600.Name = "lbl_Tuesday_600"
        Me.lbl_Tuesday_600.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_600.TabIndex = 11
        Me.lbl_Tuesday_600.Text = "lbl_Tuesday_600"
        '
        'tuesday_300
        '
        Me.tuesday_300.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_300.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_300.Controls.Add(Me.lbl_Tuesday_300)
        Me.tuesday_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_300.Location = New System.Drawing.Point(0, 375)
        Me.tuesday_300.Name = "tuesday_300"
        Me.tuesday_300.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_300.TabIndex = 11
        '
        'lbl_Tuesday_300
        '
        Me.lbl_Tuesday_300.AutoSize = True
        Me.lbl_Tuesday_300.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_300.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_300.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_300.Name = "lbl_Tuesday_300"
        Me.lbl_Tuesday_300.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_300.TabIndex = 11
        Me.lbl_Tuesday_300.Text = "lbl_Tuesday_300"
        '
        'tuesday_1130
        '
        Me.tuesday_1130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_1130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_1130.Controls.Add(Me.lbl_Tuesday_1130)
        Me.tuesday_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_1130.Location = New System.Drawing.Point(0, 221)
        Me.tuesday_1130.Name = "tuesday_1130"
        Me.tuesday_1130.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_1130.TabIndex = 11
        '
        'lbl_Tuesday_1130
        '
        Me.lbl_Tuesday_1130.AutoSize = True
        Me.lbl_Tuesday_1130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_1130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_1130.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_1130.Name = "lbl_Tuesday_1130"
        Me.lbl_Tuesday_1130.Size = New System.Drawing.Size(97, 15)
        Me.lbl_Tuesday_1130.TabIndex = 11
        Me.lbl_Tuesday_1130.Text = "lbl_Tuesday_1130"
        '
        'tuesday_530
        '
        Me.tuesday_530.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_530.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_530.Controls.Add(Me.lbl_Tuesday_530)
        Me.tuesday_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_530.Location = New System.Drawing.Point(0, 485)
        Me.tuesday_530.Name = "tuesday_530"
        Me.tuesday_530.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_530.TabIndex = 11
        '
        'lbl_Tuesday_530
        '
        Me.lbl_Tuesday_530.AutoSize = True
        Me.lbl_Tuesday_530.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_530.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_530.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_530.Name = "lbl_Tuesday_530"
        Me.lbl_Tuesday_530.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_530.TabIndex = 11
        Me.lbl_Tuesday_530.Text = "lbl_Tuesday_530"
        '
        'tuesday_230
        '
        Me.tuesday_230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_230.Controls.Add(Me.lbl_Tuesday_230)
        Me.tuesday_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_230.Location = New System.Drawing.Point(0, 353)
        Me.tuesday_230.Name = "tuesday_230"
        Me.tuesday_230.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_230.TabIndex = 11
        '
        'lbl_Tuesday_230
        '
        Me.lbl_Tuesday_230.AutoSize = True
        Me.lbl_Tuesday_230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_230.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_230.Name = "lbl_Tuesday_230"
        Me.lbl_Tuesday_230.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_230.TabIndex = 11
        Me.lbl_Tuesday_230.Text = "lbl_Tuesday_230"
        '
        'tuesday_1100
        '
        Me.tuesday_1100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_1100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_1100.Controls.Add(Me.lbl_Tuesday_1100)
        Me.tuesday_1100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_1100.Location = New System.Drawing.Point(0, 199)
        Me.tuesday_1100.Name = "tuesday_1100"
        Me.tuesday_1100.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_1100.TabIndex = 11
        '
        'lbl_Tuesday_1100
        '
        Me.lbl_Tuesday_1100.AutoSize = True
        Me.lbl_Tuesday_1100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_1100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_1100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_1100.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_1100.Name = "lbl_Tuesday_1100"
        Me.lbl_Tuesday_1100.Size = New System.Drawing.Size(97, 15)
        Me.lbl_Tuesday_1100.TabIndex = 11
        Me.lbl_Tuesday_1100.Text = "lbl_Tuesday_1100"
        '
        'tuesday_500
        '
        Me.tuesday_500.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_500.Controls.Add(Me.lbl_Tuesday_500)
        Me.tuesday_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_500.Location = New System.Drawing.Point(0, 463)
        Me.tuesday_500.Name = "tuesday_500"
        Me.tuesday_500.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_500.TabIndex = 11
        '
        'lbl_Tuesday_500
        '
        Me.lbl_Tuesday_500.AutoSize = True
        Me.lbl_Tuesday_500.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_500.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_500.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_500.Name = "lbl_Tuesday_500"
        Me.lbl_Tuesday_500.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_500.TabIndex = 11
        Me.lbl_Tuesday_500.Text = "lbl_Tuesday_500"
        '
        'tuesday_200
        '
        Me.tuesday_200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_200.Controls.Add(Me.lbl_Tuesday_200)
        Me.tuesday_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_200.Location = New System.Drawing.Point(0, 331)
        Me.tuesday_200.Name = "tuesday_200"
        Me.tuesday_200.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_200.TabIndex = 11
        '
        'lbl_Tuesday_200
        '
        Me.lbl_Tuesday_200.AutoSize = True
        Me.lbl_Tuesday_200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_200.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_200.Name = "lbl_Tuesday_200"
        Me.lbl_Tuesday_200.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_200.TabIndex = 11
        Me.lbl_Tuesday_200.Text = "lbl_Tuesday_200"
        '
        'tueasday_1030
        '
        Me.tueasday_1030.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tueasday_1030.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tueasday_1030.Controls.Add(Me.lbl_Tuesday_1030)
        Me.tueasday_1030.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tueasday_1030.Location = New System.Drawing.Point(0, 177)
        Me.tueasday_1030.Name = "tueasday_1030"
        Me.tueasday_1030.Size = New System.Drawing.Size(122, 23)
        Me.tueasday_1030.TabIndex = 11
        '
        'lbl_Tuesday_1030
        '
        Me.lbl_Tuesday_1030.AutoSize = True
        Me.lbl_Tuesday_1030.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_1030.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_1030.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_1030.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_1030.Name = "lbl_Tuesday_1030"
        Me.lbl_Tuesday_1030.Size = New System.Drawing.Size(97, 15)
        Me.lbl_Tuesday_1030.TabIndex = 11
        Me.lbl_Tuesday_1030.Text = "lbl_Tuesday_1030"
        '
        'tuesday_430
        '
        Me.tuesday_430.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_430.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_430.Controls.Add(Me.lbl_Tuesday_430)
        Me.tuesday_430.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_430.Location = New System.Drawing.Point(0, 441)
        Me.tuesday_430.Name = "tuesday_430"
        Me.tuesday_430.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_430.TabIndex = 11
        '
        'lbl_Tuesday_430
        '
        Me.lbl_Tuesday_430.AutoSize = True
        Me.lbl_Tuesday_430.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_430.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_430.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_430.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_430.Name = "lbl_Tuesday_430"
        Me.lbl_Tuesday_430.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_430.TabIndex = 11
        Me.lbl_Tuesday_430.Text = "lbl_Tuesday_430"
        '
        'tuesday_130
        '
        Me.tuesday_130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_130.Controls.Add(Me.lbl_Tuesday_130)
        Me.tuesday_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_130.Location = New System.Drawing.Point(0, 309)
        Me.tuesday_130.Name = "tuesday_130"
        Me.tuesday_130.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_130.TabIndex = 11
        '
        'lbl_Tuesday_130
        '
        Me.lbl_Tuesday_130.AutoSize = True
        Me.lbl_Tuesday_130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_130.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_130.Name = "lbl_Tuesday_130"
        Me.lbl_Tuesday_130.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_130.TabIndex = 11
        Me.lbl_Tuesday_130.Text = "lbl_Tuesday_130"
        '
        'tuesday_1000
        '
        Me.tuesday_1000.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_1000.Controls.Add(Me.lbl_Tuesday_1000)
        Me.tuesday_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_1000.Location = New System.Drawing.Point(0, 155)
        Me.tuesday_1000.Name = "tuesday_1000"
        Me.tuesday_1000.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_1000.TabIndex = 11
        '
        'lbl_Tuesday_1000
        '
        Me.lbl_Tuesday_1000.AutoSize = True
        Me.lbl_Tuesday_1000.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_1000.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_1000.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_1000.Name = "lbl_Tuesday_1000"
        Me.lbl_Tuesday_1000.Size = New System.Drawing.Size(97, 15)
        Me.lbl_Tuesday_1000.TabIndex = 11
        Me.lbl_Tuesday_1000.Text = "lbl_Tuesday_1000"
        '
        'tuesday_400
        '
        Me.tuesday_400.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_400.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_400.Controls.Add(Me.lbl_Tuesday_400)
        Me.tuesday_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_400.Location = New System.Drawing.Point(0, 419)
        Me.tuesday_400.Name = "tuesday_400"
        Me.tuesday_400.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_400.TabIndex = 11
        '
        'lbl_Tuesday_400
        '
        Me.lbl_Tuesday_400.AutoSize = True
        Me.lbl_Tuesday_400.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_400.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_400.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_400.Name = "lbl_Tuesday_400"
        Me.lbl_Tuesday_400.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_400.TabIndex = 11
        Me.lbl_Tuesday_400.Text = "lbl_Tuesday_400"
        '
        'tuesday_100
        '
        Me.tuesday_100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_100.Controls.Add(Me.lbl_Tuesday_100)
        Me.tuesday_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_100.Location = New System.Drawing.Point(0, 287)
        Me.tuesday_100.Name = "tuesday_100"
        Me.tuesday_100.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_100.TabIndex = 11
        '
        'lbl_Tuesday_100
        '
        Me.lbl_Tuesday_100.AutoSize = True
        Me.lbl_Tuesday_100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_100.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_100.Name = "lbl_Tuesday_100"
        Me.lbl_Tuesday_100.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_100.TabIndex = 11
        Me.lbl_Tuesday_100.Text = "lbl_Tuesday_100"
        '
        'tuesday_930
        '
        Me.tuesday_930.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_930.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_930.Controls.Add(Me.lbl_Tuesday_930)
        Me.tuesday_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_930.Location = New System.Drawing.Point(0, 133)
        Me.tuesday_930.Name = "tuesday_930"
        Me.tuesday_930.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_930.TabIndex = 11
        '
        'lbl_Tuesday_930
        '
        Me.lbl_Tuesday_930.AutoSize = True
        Me.lbl_Tuesday_930.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_930.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_930.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_930.Name = "lbl_Tuesday_930"
        Me.lbl_Tuesday_930.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_930.TabIndex = 11
        Me.lbl_Tuesday_930.Text = "lbl_Tuesday_930"
        '
        'tuesday_330
        '
        Me.tuesday_330.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_330.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_330.Controls.Add(Me.lbl_Tuesday_330)
        Me.tuesday_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_330.Location = New System.Drawing.Point(0, 397)
        Me.tuesday_330.Name = "tuesday_330"
        Me.tuesday_330.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_330.TabIndex = 11
        '
        'lbl_Tuesday_330
        '
        Me.lbl_Tuesday_330.AutoSize = True
        Me.lbl_Tuesday_330.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_330.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_330.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_330.Name = "lbl_Tuesday_330"
        Me.lbl_Tuesday_330.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_330.TabIndex = 11
        Me.lbl_Tuesday_330.Text = "lbl_Tuesday_330"
        '
        'tuesday_1230
        '
        Me.tuesday_1230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_1230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_1230.Controls.Add(Me.lbl_Tuesday_1230)
        Me.tuesday_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_1230.Location = New System.Drawing.Point(0, 265)
        Me.tuesday_1230.Name = "tuesday_1230"
        Me.tuesday_1230.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_1230.TabIndex = 11
        '
        'lbl_Tuesday_1230
        '
        Me.lbl_Tuesday_1230.AutoSize = True
        Me.lbl_Tuesday_1230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_1230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_1230.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_1230.Name = "lbl_Tuesday_1230"
        Me.lbl_Tuesday_1230.Size = New System.Drawing.Size(97, 15)
        Me.lbl_Tuesday_1230.TabIndex = 11
        Me.lbl_Tuesday_1230.Text = "lbl_Tuesday_1230"
        '
        'tuesday_900
        '
        Me.tuesday_900.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_900.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_900.Controls.Add(Me.lbl_Tuesday_900)
        Me.tuesday_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_900.Location = New System.Drawing.Point(0, 111)
        Me.tuesday_900.Name = "tuesday_900"
        Me.tuesday_900.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_900.TabIndex = 11
        '
        'lbl_Tuesday_900
        '
        Me.lbl_Tuesday_900.AutoSize = True
        Me.lbl_Tuesday_900.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_900.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_900.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_900.Name = "lbl_Tuesday_900"
        Me.lbl_Tuesday_900.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_900.TabIndex = 11
        Me.lbl_Tuesday_900.Text = "lbl_Tuesday_900"
        '
        'tuesday_1200
        '
        Me.tuesday_1200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_1200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_1200.Controls.Add(Me.lbl_Tuesday_1200)
        Me.tuesday_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_1200.Location = New System.Drawing.Point(0, 243)
        Me.tuesday_1200.Name = "tuesday_1200"
        Me.tuesday_1200.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_1200.TabIndex = 11
        '
        'lbl_Tuesday_1200
        '
        Me.lbl_Tuesday_1200.AutoSize = True
        Me.lbl_Tuesday_1200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_1200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_1200.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_1200.Name = "lbl_Tuesday_1200"
        Me.lbl_Tuesday_1200.Size = New System.Drawing.Size(97, 15)
        Me.lbl_Tuesday_1200.TabIndex = 11
        Me.lbl_Tuesday_1200.Text = "lbl_Tuesday_1200"
        '
        'tuesday_830
        '
        Me.tuesday_830.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_830.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_830.Controls.Add(Me.lbl_Tuesday_830)
        Me.tuesday_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_830.Location = New System.Drawing.Point(0, 89)
        Me.tuesday_830.Name = "tuesday_830"
        Me.tuesday_830.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_830.TabIndex = 11
        '
        'lbl_Tuesday_830
        '
        Me.lbl_Tuesday_830.AutoSize = True
        Me.lbl_Tuesday_830.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_830.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_830.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_830.Name = "lbl_Tuesday_830"
        Me.lbl_Tuesday_830.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_830.TabIndex = 11
        Me.lbl_Tuesday_830.Text = "lbl_Tuesday_830"
        '
        'tuesday_800
        '
        Me.tuesday_800.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_800.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_800.Controls.Add(Me.lbl_Tuesday_800)
        Me.tuesday_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_800.Location = New System.Drawing.Point(0, 67)
        Me.tuesday_800.Name = "tuesday_800"
        Me.tuesday_800.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_800.TabIndex = 11
        '
        'lbl_Tuesday_800
        '
        Me.lbl_Tuesday_800.AutoSize = True
        Me.lbl_Tuesday_800.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_800.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_800.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_800.Name = "lbl_Tuesday_800"
        Me.lbl_Tuesday_800.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_800.TabIndex = 11
        Me.lbl_Tuesday_800.Text = "lbl_Tuesday_800"
        '
        'tuesday_730
        '
        Me.tuesday_730.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_730.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_730.Controls.Add(Me.lbl_Tuesday_730)
        Me.tuesday_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_730.Location = New System.Drawing.Point(0, 45)
        Me.tuesday_730.Name = "tuesday_730"
        Me.tuesday_730.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_730.TabIndex = 11
        '
        'lbl_Tuesday_730
        '
        Me.lbl_Tuesday_730.AutoSize = True
        Me.lbl_Tuesday_730.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_730.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_730.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_730.Name = "lbl_Tuesday_730"
        Me.lbl_Tuesday_730.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_730.TabIndex = 11
        Me.lbl_Tuesday_730.Text = "lbl_Tuesday_730"
        '
        'tuesday_700
        '
        Me.tuesday_700.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_700.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_700.Controls.Add(Me.lbl_Tuesday_700)
        Me.tuesday_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_700.Location = New System.Drawing.Point(0, 23)
        Me.tuesday_700.Name = "tuesday_700"
        Me.tuesday_700.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_700.TabIndex = 11
        '
        'lbl_Tuesday_700
        '
        Me.lbl_Tuesday_700.AutoSize = True
        Me.lbl_Tuesday_700.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_700.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_700.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_700.Name = "lbl_Tuesday_700"
        Me.lbl_Tuesday_700.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_700.TabIndex = 11
        Me.lbl_Tuesday_700.Text = "lbl_Tuesday_700"
        '
        'tuesday_630AM
        '
        Me.tuesday_630AM.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tuesday_630AM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuesday_630AM.Controls.Add(Me.lbl_Tuesday_630)
        Me.tuesday_630AM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tuesday_630AM.Location = New System.Drawing.Point(0, 1)
        Me.tuesday_630AM.Name = "tuesday_630AM"
        Me.tuesday_630AM.Size = New System.Drawing.Size(122, 23)
        Me.tuesday_630AM.TabIndex = 11
        '
        'lbl_Tuesday_630
        '
        Me.lbl_Tuesday_630.AutoSize = True
        Me.lbl_Tuesday_630.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tuesday_630.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Tuesday_630.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Tuesday_630.Location = New System.Drawing.Point(11, 3)
        Me.lbl_Tuesday_630.Name = "lbl_Tuesday_630"
        Me.lbl_Tuesday_630.Size = New System.Drawing.Size(91, 15)
        Me.lbl_Tuesday_630.TabIndex = 11
        Me.lbl_Tuesday_630.Text = "lbl_Tuesday_630"
        '
        'GunaPanel5
        '
        Me.GunaPanel5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaPanel5.Controls.Add(Me.monday_630)
        Me.GunaPanel5.Controls.Add(Me.monday_600PM)
        Me.GunaPanel5.Controls.Add(Me.monday_530)
        Me.GunaPanel5.Controls.Add(Me.monday_300)
        Me.GunaPanel5.Controls.Add(Me.monday_1130)
        Me.GunaPanel5.Controls.Add(Me.monday_700)
        Me.GunaPanel5.Controls.Add(Me.monday_500)
        Me.GunaPanel5.Controls.Add(Me.monday_230)
        Me.GunaPanel5.Controls.Add(Me.monday_1100)
        Me.GunaPanel5.Controls.Add(Me.monday_430)
        Me.GunaPanel5.Controls.Add(Me.monday_200)
        Me.GunaPanel5.Controls.Add(Me.monday_1030)
        Me.GunaPanel5.Controls.Add(Me.monday_400)
        Me.GunaPanel5.Controls.Add(Me.monday_130)
        Me.GunaPanel5.Controls.Add(Me.monday_1000)
        Me.GunaPanel5.Controls.Add(Me.monday_330)
        Me.GunaPanel5.Controls.Add(Me.monday_100)
        Me.GunaPanel5.Controls.Add(Me.monday_930)
        Me.GunaPanel5.Controls.Add(Me.monday_1230)
        Me.GunaPanel5.Controls.Add(Me.monday_900)
        Me.GunaPanel5.Controls.Add(Me.monday_1200)
        Me.GunaPanel5.Controls.Add(Me.monday_830)
        Me.GunaPanel5.Controls.Add(Me.monday_800)
        Me.GunaPanel5.Controls.Add(Me.monday_730)
        Me.GunaPanel5.Location = New System.Drawing.Point(49, 26)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(123, 532)
        Me.GunaPanel5.TabIndex = 11
        '
        'monday_630
        '
        Me.monday_630.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_630.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_630.Controls.Add(Me.lbl_Monday_700)
        Me.monday_630.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_630.Location = New System.Drawing.Point(0, 23)
        Me.monday_630.Name = "monday_630"
        Me.monday_630.Size = New System.Drawing.Size(122, 23)
        Me.monday_630.TabIndex = 11
        '
        'lbl_Monday_700
        '
        Me.lbl_Monday_700.AutoSize = True
        Me.lbl_Monday_700.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_700.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_700.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_700.Name = "lbl_Monday_700"
        Me.lbl_Monday_700.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_700.TabIndex = 11
        Me.lbl_Monday_700.Text = "lbl_Monday_700"
        '
        'monday_600PM
        '
        Me.monday_600PM.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_600PM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_600PM.Controls.Add(Me.lbl_Monday_600)
        Me.monday_600PM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_600PM.Location = New System.Drawing.Point(0, 507)
        Me.monday_600PM.Name = "monday_600PM"
        Me.monday_600PM.Size = New System.Drawing.Size(122, 23)
        Me.monday_600PM.TabIndex = 11
        '
        'lbl_Monday_600
        '
        Me.lbl_Monday_600.AutoSize = True
        Me.lbl_Monday_600.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_600.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_600.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_600.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_600.Name = "lbl_Monday_600"
        Me.lbl_Monday_600.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_600.TabIndex = 11
        Me.lbl_Monday_600.Text = "lbl_Monday_600"
        '
        'monday_530
        '
        Me.monday_530.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_530.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_530.Controls.Add(Me.lbl_Monday_530)
        Me.monday_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_530.Location = New System.Drawing.Point(0, 485)
        Me.monday_530.Name = "monday_530"
        Me.monday_530.Size = New System.Drawing.Size(122, 23)
        Me.monday_530.TabIndex = 11
        '
        'lbl_Monday_530
        '
        Me.lbl_Monday_530.AutoSize = True
        Me.lbl_Monday_530.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_530.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_530.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_530.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_530.Name = "lbl_Monday_530"
        Me.lbl_Monday_530.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_530.TabIndex = 11
        Me.lbl_Monday_530.Text = "lbl_Monday_530"
        '
        'monday_300
        '
        Me.monday_300.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_300.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_300.Controls.Add(Me.lbl_Monday_300)
        Me.monday_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_300.Location = New System.Drawing.Point(0, 375)
        Me.monday_300.Name = "monday_300"
        Me.monday_300.Size = New System.Drawing.Size(122, 23)
        Me.monday_300.TabIndex = 11
        '
        'lbl_Monday_300
        '
        Me.lbl_Monday_300.AutoSize = True
        Me.lbl_Monday_300.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_300.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_300.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_300.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_300.Name = "lbl_Monday_300"
        Me.lbl_Monday_300.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_300.TabIndex = 11
        Me.lbl_Monday_300.Text = "lbl_Monday_300"
        '
        'monday_1130
        '
        Me.monday_1130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_1130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_1130.Controls.Add(Me.lbl_Monday_1130)
        Me.monday_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_1130.Location = New System.Drawing.Point(0, 221)
        Me.monday_1130.Name = "monday_1130"
        Me.monday_1130.Size = New System.Drawing.Size(122, 23)
        Me.monday_1130.TabIndex = 11
        '
        'lbl_Monday_1130
        '
        Me.lbl_Monday_1130.AutoSize = True
        Me.lbl_Monday_1130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_1130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_1130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_1130.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_1130.Name = "lbl_Monday_1130"
        Me.lbl_Monday_1130.Size = New System.Drawing.Size(98, 15)
        Me.lbl_Monday_1130.TabIndex = 11
        Me.lbl_Monday_1130.Text = "lbl_Monday_1130"
        '
        'monday_700
        '
        Me.monday_700.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_700.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_700.Controls.Add(Me.lbl_Monday_630)
        Me.monday_700.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_700.Location = New System.Drawing.Point(0, 1)
        Me.monday_700.Name = "monday_700"
        Me.monday_700.Size = New System.Drawing.Size(122, 23)
        Me.monday_700.TabIndex = 11
        '
        'lbl_Monday_630
        '
        Me.lbl_Monday_630.AutoSize = True
        Me.lbl_Monday_630.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_630.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_630.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_630.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_630.Name = "lbl_Monday_630"
        Me.lbl_Monday_630.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_630.TabIndex = 11
        Me.lbl_Monday_630.Text = "lbl_Monday_630"
        '
        'monday_500
        '
        Me.monday_500.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_500.Controls.Add(Me.lbl_Monday_500)
        Me.monday_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_500.Location = New System.Drawing.Point(0, 463)
        Me.monday_500.Name = "monday_500"
        Me.monday_500.Size = New System.Drawing.Size(122, 23)
        Me.monday_500.TabIndex = 11
        '
        'lbl_Monday_500
        '
        Me.lbl_Monday_500.AutoSize = True
        Me.lbl_Monday_500.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_500.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_500.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_500.Name = "lbl_Monday_500"
        Me.lbl_Monday_500.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_500.TabIndex = 11
        Me.lbl_Monday_500.Text = "lbl_Monday_500"
        '
        'monday_230
        '
        Me.monday_230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_230.Controls.Add(Me.lbl_Monday_230)
        Me.monday_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_230.Location = New System.Drawing.Point(0, 353)
        Me.monday_230.Name = "monday_230"
        Me.monday_230.Size = New System.Drawing.Size(122, 23)
        Me.monday_230.TabIndex = 11
        '
        'lbl_Monday_230
        '
        Me.lbl_Monday_230.AutoSize = True
        Me.lbl_Monday_230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_230.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_230.Name = "lbl_Monday_230"
        Me.lbl_Monday_230.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_230.TabIndex = 11
        Me.lbl_Monday_230.Text = "lbl_Monday_230"
        '
        'monday_1100
        '
        Me.monday_1100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_1100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_1100.Controls.Add(Me.lbl_Monday_1100)
        Me.monday_1100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_1100.Location = New System.Drawing.Point(0, 199)
        Me.monday_1100.Name = "monday_1100"
        Me.monday_1100.Size = New System.Drawing.Size(122, 23)
        Me.monday_1100.TabIndex = 11
        '
        'lbl_Monday_1100
        '
        Me.lbl_Monday_1100.AutoSize = True
        Me.lbl_Monday_1100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_1100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_1100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_1100.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_1100.Name = "lbl_Monday_1100"
        Me.lbl_Monday_1100.Size = New System.Drawing.Size(98, 15)
        Me.lbl_Monday_1100.TabIndex = 11
        Me.lbl_Monday_1100.Text = "lbl_Monday_1100"
        '
        'monday_430
        '
        Me.monday_430.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_430.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_430.Controls.Add(Me.lbl_Monday_430)
        Me.monday_430.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_430.Location = New System.Drawing.Point(0, 441)
        Me.monday_430.Name = "monday_430"
        Me.monday_430.Size = New System.Drawing.Size(122, 23)
        Me.monday_430.TabIndex = 11
        '
        'lbl_Monday_430
        '
        Me.lbl_Monday_430.AutoSize = True
        Me.lbl_Monday_430.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_430.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_430.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_430.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_430.Name = "lbl_Monday_430"
        Me.lbl_Monday_430.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_430.TabIndex = 11
        Me.lbl_Monday_430.Text = "lbl_Monday_430"
        '
        'monday_200
        '
        Me.monday_200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_200.Controls.Add(Me.lbl_Monday_200)
        Me.monday_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_200.Location = New System.Drawing.Point(0, 331)
        Me.monday_200.Name = "monday_200"
        Me.monday_200.Size = New System.Drawing.Size(122, 23)
        Me.monday_200.TabIndex = 11
        '
        'lbl_Monday_200
        '
        Me.lbl_Monday_200.AutoSize = True
        Me.lbl_Monday_200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_200.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_200.Name = "lbl_Monday_200"
        Me.lbl_Monday_200.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_200.TabIndex = 11
        Me.lbl_Monday_200.Text = "lbl_Monday_200"
        '
        'monday_1030
        '
        Me.monday_1030.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_1030.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_1030.Controls.Add(Me.lbl_Monday_1030)
        Me.monday_1030.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_1030.Location = New System.Drawing.Point(0, 177)
        Me.monday_1030.Name = "monday_1030"
        Me.monday_1030.Size = New System.Drawing.Size(122, 23)
        Me.monday_1030.TabIndex = 11
        '
        'lbl_Monday_1030
        '
        Me.lbl_Monday_1030.AutoSize = True
        Me.lbl_Monday_1030.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_1030.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_1030.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_1030.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_1030.Name = "lbl_Monday_1030"
        Me.lbl_Monday_1030.Size = New System.Drawing.Size(98, 15)
        Me.lbl_Monday_1030.TabIndex = 11
        Me.lbl_Monday_1030.Text = "lbl_Monday_1030"
        '
        'monday_400
        '
        Me.monday_400.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_400.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_400.Controls.Add(Me.lbl_Monday_400)
        Me.monday_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_400.Location = New System.Drawing.Point(0, 419)
        Me.monday_400.Name = "monday_400"
        Me.monday_400.Size = New System.Drawing.Size(122, 23)
        Me.monday_400.TabIndex = 11
        '
        'lbl_Monday_400
        '
        Me.lbl_Monday_400.AutoSize = True
        Me.lbl_Monday_400.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_400.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_400.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_400.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_400.Name = "lbl_Monday_400"
        Me.lbl_Monday_400.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_400.TabIndex = 11
        Me.lbl_Monday_400.Text = "lbl_Monday_400"
        '
        'monday_130
        '
        Me.monday_130.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_130.Controls.Add(Me.lbl_Monday_130)
        Me.monday_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_130.Location = New System.Drawing.Point(0, 309)
        Me.monday_130.Name = "monday_130"
        Me.monday_130.Size = New System.Drawing.Size(122, 23)
        Me.monday_130.TabIndex = 11
        '
        'lbl_Monday_130
        '
        Me.lbl_Monday_130.AutoSize = True
        Me.lbl_Monday_130.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_130.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_130.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_130.Name = "lbl_Monday_130"
        Me.lbl_Monday_130.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_130.TabIndex = 11
        Me.lbl_Monday_130.Text = "lbl_Monday_130"
        '
        'monday_1000
        '
        Me.monday_1000.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_1000.Controls.Add(Me.lbl_Monday_1000)
        Me.monday_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_1000.Location = New System.Drawing.Point(0, 155)
        Me.monday_1000.Name = "monday_1000"
        Me.monday_1000.Size = New System.Drawing.Size(122, 23)
        Me.monday_1000.TabIndex = 11
        '
        'lbl_Monday_1000
        '
        Me.lbl_Monday_1000.AutoSize = True
        Me.lbl_Monday_1000.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_1000.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_1000.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_1000.Name = "lbl_Monday_1000"
        Me.lbl_Monday_1000.Size = New System.Drawing.Size(98, 15)
        Me.lbl_Monday_1000.TabIndex = 11
        Me.lbl_Monday_1000.Text = "lbl_Monday_1000"
        '
        'monday_330
        '
        Me.monday_330.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_330.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_330.Controls.Add(Me.lbl_Monday_330)
        Me.monday_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_330.Location = New System.Drawing.Point(0, 397)
        Me.monday_330.Name = "monday_330"
        Me.monday_330.Size = New System.Drawing.Size(122, 23)
        Me.monday_330.TabIndex = 11
        '
        'lbl_Monday_330
        '
        Me.lbl_Monday_330.AutoSize = True
        Me.lbl_Monday_330.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_330.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_330.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_330.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_330.Name = "lbl_Monday_330"
        Me.lbl_Monday_330.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_330.TabIndex = 11
        Me.lbl_Monday_330.Text = "lbl_Monday_330"
        '
        'monday_100
        '
        Me.monday_100.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_100.Controls.Add(Me.lbl_Monday_100)
        Me.monday_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_100.Location = New System.Drawing.Point(0, 287)
        Me.monday_100.Name = "monday_100"
        Me.monday_100.Size = New System.Drawing.Size(122, 23)
        Me.monday_100.TabIndex = 11
        '
        'lbl_Monday_100
        '
        Me.lbl_Monday_100.AutoSize = True
        Me.lbl_Monday_100.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_100.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_100.Name = "lbl_Monday_100"
        Me.lbl_Monday_100.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_100.TabIndex = 11
        Me.lbl_Monday_100.Text = "lbl_Monday_100"
        '
        'monday_930
        '
        Me.monday_930.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_930.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_930.Controls.Add(Me.lbl_Monday_930)
        Me.monday_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_930.Location = New System.Drawing.Point(0, 133)
        Me.monday_930.Name = "monday_930"
        Me.monday_930.Size = New System.Drawing.Size(122, 23)
        Me.monday_930.TabIndex = 11
        '
        'lbl_Monday_930
        '
        Me.lbl_Monday_930.AutoSize = True
        Me.lbl_Monday_930.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_930.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_930.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_930.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_930.Name = "lbl_Monday_930"
        Me.lbl_Monday_930.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_930.TabIndex = 11
        Me.lbl_Monday_930.Text = "lbl_Monday_930"
        '
        'monday_1230
        '
        Me.monday_1230.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_1230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_1230.Controls.Add(Me.lbl_Monday_1230)
        Me.monday_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_1230.Location = New System.Drawing.Point(0, 265)
        Me.monday_1230.Name = "monday_1230"
        Me.monday_1230.Size = New System.Drawing.Size(122, 23)
        Me.monday_1230.TabIndex = 11
        '
        'lbl_Monday_1230
        '
        Me.lbl_Monday_1230.AutoSize = True
        Me.lbl_Monday_1230.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_1230.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_1230.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_1230.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_1230.Name = "lbl_Monday_1230"
        Me.lbl_Monday_1230.Size = New System.Drawing.Size(98, 15)
        Me.lbl_Monday_1230.TabIndex = 11
        Me.lbl_Monday_1230.Text = "lbl_Monday_1230"
        '
        'monday_900
        '
        Me.monday_900.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_900.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_900.Controls.Add(Me.lbl_Monday_900)
        Me.monday_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_900.Location = New System.Drawing.Point(0, 111)
        Me.monday_900.Name = "monday_900"
        Me.monday_900.Size = New System.Drawing.Size(122, 23)
        Me.monday_900.TabIndex = 11
        '
        'lbl_Monday_900
        '
        Me.lbl_Monday_900.AutoSize = True
        Me.lbl_Monday_900.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_900.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_900.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_900.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_900.Name = "lbl_Monday_900"
        Me.lbl_Monday_900.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_900.TabIndex = 11
        Me.lbl_Monday_900.Text = "lbl_Monday_900"
        '
        'monday_1200
        '
        Me.monday_1200.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_1200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_1200.Controls.Add(Me.lbl_Monday_1200)
        Me.monday_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_1200.Location = New System.Drawing.Point(0, 243)
        Me.monday_1200.Name = "monday_1200"
        Me.monday_1200.Size = New System.Drawing.Size(122, 23)
        Me.monday_1200.TabIndex = 11
        '
        'lbl_Monday_1200
        '
        Me.lbl_Monday_1200.AutoSize = True
        Me.lbl_Monday_1200.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_1200.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_1200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_1200.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_1200.Name = "lbl_Monday_1200"
        Me.lbl_Monday_1200.Size = New System.Drawing.Size(98, 15)
        Me.lbl_Monday_1200.TabIndex = 11
        Me.lbl_Monday_1200.Text = "lbl_Monday_1200"
        '
        'monday_830
        '
        Me.monday_830.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_830.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_830.Controls.Add(Me.lbl_Monday_830)
        Me.monday_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_830.Location = New System.Drawing.Point(0, 89)
        Me.monday_830.Name = "monday_830"
        Me.monday_830.Size = New System.Drawing.Size(122, 23)
        Me.monday_830.TabIndex = 11
        '
        'lbl_Monday_830
        '
        Me.lbl_Monday_830.AutoSize = True
        Me.lbl_Monday_830.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_830.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_830.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_830.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_830.Name = "lbl_Monday_830"
        Me.lbl_Monday_830.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_830.TabIndex = 11
        Me.lbl_Monday_830.Text = "lbl_Monday_830"
        '
        'monday_800
        '
        Me.monday_800.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_800.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_800.Controls.Add(Me.lbl_Monday_800)
        Me.monday_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_800.Location = New System.Drawing.Point(0, 67)
        Me.monday_800.Name = "monday_800"
        Me.monday_800.Size = New System.Drawing.Size(122, 23)
        Me.monday_800.TabIndex = 11
        '
        'lbl_Monday_800
        '
        Me.lbl_Monday_800.AutoSize = True
        Me.lbl_Monday_800.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_800.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_800.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_800.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_800.Name = "lbl_Monday_800"
        Me.lbl_Monday_800.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_800.TabIndex = 11
        Me.lbl_Monday_800.Text = "lbl_Monday_800"
        '
        'monday_730
        '
        Me.monday_730.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.monday_730.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monday_730.Controls.Add(Me.lbl_Monday_730)
        Me.monday_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.monday_730.Location = New System.Drawing.Point(0, 45)
        Me.monday_730.Name = "monday_730"
        Me.monday_730.Size = New System.Drawing.Size(122, 23)
        Me.monday_730.TabIndex = 11
        '
        'lbl_Monday_730
        '
        Me.lbl_Monday_730.AutoSize = True
        Me.lbl_Monday_730.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Monday_730.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Monday_730.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lbl_Monday_730.Location = New System.Drawing.Point(8, 3)
        Me.lbl_Monday_730.Name = "lbl_Monday_730"
        Me.lbl_Monday_730.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Monday_730.TabIndex = 11
        Me.lbl_Monday_730.Text = "lbl_Monday_730"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Location = New System.Drawing.Point(49, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(606, 27)
        Me.GunaPanel2.TabIndex = 10
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GunaPanel3.Controls.Add(Me.GunaLabel6)
        Me.GunaPanel3.Controls.Add(Me.GunaLabel5)
        Me.GunaPanel3.Controls.Add(Me.GunaLabel4)
        Me.GunaPanel3.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel3.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaPanel3.Location = New System.Drawing.Point(313, 58)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(607, 27)
        Me.GunaPanel3.TabIndex = 10
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("CPMono_v07 Bold", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(525, 6)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(55, 14)
        Me.GunaLabel6.TabIndex = 0
        Me.GunaLabel6.Text = "Friday"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("CPMono_v07 Bold", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(399, 6)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(71, 14)
        Me.GunaLabel5.TabIndex = 0
        Me.GunaLabel5.Text = "Thursday"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("CPMono_v07 Bold", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(268, 6)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(79, 14)
        Me.GunaLabel4.TabIndex = 0
        Me.GunaLabel4.Text = "Wednesday"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("CPMono_v07 Bold", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(152, 6)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(63, 14)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "Tuesday"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("CPMono_v07 Bold", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(34, 6)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(55, 14)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "Monday"
        '
        'SlotprofDataSetAll1
        '
        Me.SlotprofDataSetAll1.DataSetName = "slotprofDataSetAll"
        Me.SlotprofDataSetAll1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel2.Controls.Add(Me.del_bot_sched7)
        Me.Panel2.Controls.Add(Me.del_bot_sched6)
        Me.Panel2.Controls.Add(Me.del_bot_sched5)
        Me.Panel2.Controls.Add(Me.del_bot_sched8)
        Me.Panel2.Controls.Add(Me.del_bot_sched4)
        Me.Panel2.Controls.Add(Me.del_bot_sched3)
        Me.Panel2.Controls.Add(Me.del_bot_sched2)
        Me.Panel2.Controls.Add(Me.edit_bot_sched8)
        Me.Panel2.Controls.Add(Me.edit_bot_sched7)
        Me.Panel2.Controls.Add(Me.edit_bot_sched6)
        Me.Panel2.Controls.Add(Me.edit_bot_sched5)
        Me.Panel2.Controls.Add(Me.edit_bot_sched4)
        Me.Panel2.Controls.Add(Me.edit_bot_sched3)
        Me.Panel2.Controls.Add(Me.edit_bot_sched2)
        Me.Panel2.Controls.Add(Me.edit_bot_sched1)
        Me.Panel2.Controls.Add(Me.GunaAdvenceButton2)
        Me.Panel2.Controls.Add(Me.del_bot_sched1)
        Me.Panel2.Controls.Add(Me.GunaAdvenceButton1)
        Me.Panel2.Controls.Add(Me.slot_sched_7)
        Me.Panel2.Controls.Add(Me.slot_sched_8)
        Me.Panel2.Controls.Add(Me.slot_sched_6)
        Me.Panel2.Controls.Add(Me.slot_sched_5)
        Me.Panel2.Controls.Add(Me.slot_sched_4)
        Me.Panel2.Controls.Add(Me.slot_sched_3)
        Me.Panel2.Controls.Add(Me.slot_sched_2)
        Me.Panel2.Controls.Add(Me.slot_sched_1)
        Me.Panel2.Controls.Add(Me.GunaImageButton4)
        Me.Panel2.Controls.Add(Me.GunaImageButton3)
        Me.Panel2.Controls.Add(Me.GunaImageButton2)
        Me.Panel2.Controls.Add(Me.GunaImageButton1)
        Me.Panel2.Location = New System.Drawing.Point(264, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(655, 53)
        Me.Panel2.TabIndex = 11
        '
        'del_bot_sched7
        '
        Me.del_bot_sched7.BackColor = System.Drawing.Color.Transparent
        Me.del_bot_sched7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.del_bot_sched7.Enabled = False
        Me.del_bot_sched7.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.del_bot_sched7.ImageSize = New System.Drawing.Size(20, 20)
        Me.del_bot_sched7.Location = New System.Drawing.Point(412, 0)
        Me.del_bot_sched7.Name = "del_bot_sched7"
        Me.del_bot_sched7.OnHoverImage = Nothing
        Me.del_bot_sched7.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.del_bot_sched7.Size = New System.Drawing.Size(23, 29)
        Me.del_bot_sched7.TabIndex = 1
        '
        'del_bot_sched6
        '
        Me.del_bot_sched6.BackColor = System.Drawing.Color.Transparent
        Me.del_bot_sched6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.del_bot_sched6.Enabled = False
        Me.del_bot_sched6.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.del_bot_sched6.ImageSize = New System.Drawing.Size(20, 20)
        Me.del_bot_sched6.Location = New System.Drawing.Point(291, 25)
        Me.del_bot_sched6.Name = "del_bot_sched6"
        Me.del_bot_sched6.OnHoverImage = Nothing
        Me.del_bot_sched6.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.del_bot_sched6.Size = New System.Drawing.Size(23, 29)
        Me.del_bot_sched6.TabIndex = 1
        '
        'del_bot_sched5
        '
        Me.del_bot_sched5.BackColor = System.Drawing.Color.Transparent
        Me.del_bot_sched5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.del_bot_sched5.Enabled = False
        Me.del_bot_sched5.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.del_bot_sched5.ImageSize = New System.Drawing.Size(20, 20)
        Me.del_bot_sched5.Location = New System.Drawing.Point(291, -3)
        Me.del_bot_sched5.Name = "del_bot_sched5"
        Me.del_bot_sched5.OnHoverImage = Nothing
        Me.del_bot_sched5.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.del_bot_sched5.Size = New System.Drawing.Size(23, 29)
        Me.del_bot_sched5.TabIndex = 1
        '
        'del_bot_sched8
        '
        Me.del_bot_sched8.BackColor = System.Drawing.Color.Transparent
        Me.del_bot_sched8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.del_bot_sched8.Enabled = False
        Me.del_bot_sched8.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.del_bot_sched8.ImageSize = New System.Drawing.Size(20, 20)
        Me.del_bot_sched8.Location = New System.Drawing.Point(412, 25)
        Me.del_bot_sched8.Name = "del_bot_sched8"
        Me.del_bot_sched8.OnHoverImage = Nothing
        Me.del_bot_sched8.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.del_bot_sched8.Size = New System.Drawing.Size(23, 29)
        Me.del_bot_sched8.TabIndex = 1
        '
        'del_bot_sched4
        '
        Me.del_bot_sched4.BackColor = System.Drawing.Color.Transparent
        Me.del_bot_sched4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.del_bot_sched4.Enabled = False
        Me.del_bot_sched4.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.del_bot_sched4.ImageSize = New System.Drawing.Size(20, 20)
        Me.del_bot_sched4.Location = New System.Drawing.Point(170, 25)
        Me.del_bot_sched4.Name = "del_bot_sched4"
        Me.del_bot_sched4.OnHoverImage = Nothing
        Me.del_bot_sched4.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.del_bot_sched4.Size = New System.Drawing.Size(23, 29)
        Me.del_bot_sched4.TabIndex = 1
        '
        'del_bot_sched3
        '
        Me.del_bot_sched3.BackColor = System.Drawing.Color.Transparent
        Me.del_bot_sched3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.del_bot_sched3.Enabled = False
        Me.del_bot_sched3.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.del_bot_sched3.ImageSize = New System.Drawing.Size(20, 20)
        Me.del_bot_sched3.Location = New System.Drawing.Point(170, -1)
        Me.del_bot_sched3.Name = "del_bot_sched3"
        Me.del_bot_sched3.OnHoverImage = Nothing
        Me.del_bot_sched3.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.del_bot_sched3.Size = New System.Drawing.Size(23, 29)
        Me.del_bot_sched3.TabIndex = 1
        '
        'del_bot_sched2
        '
        Me.del_bot_sched2.BackColor = System.Drawing.Color.Transparent
        Me.del_bot_sched2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.del_bot_sched2.Enabled = False
        Me.del_bot_sched2.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.del_bot_sched2.ImageSize = New System.Drawing.Size(20, 20)
        Me.del_bot_sched2.Location = New System.Drawing.Point(61, 25)
        Me.del_bot_sched2.Name = "del_bot_sched2"
        Me.del_bot_sched2.OnHoverImage = Nothing
        Me.del_bot_sched2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.del_bot_sched2.Size = New System.Drawing.Size(23, 29)
        Me.del_bot_sched2.TabIndex = 1
        '
        'edit_bot_sched8
        '
        Me.edit_bot_sched8.BackColor = System.Drawing.Color.Transparent
        Me.edit_bot_sched8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.edit_bot_sched8.Enabled = False
        Me.edit_bot_sched8.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.edit_bot_sched8.ImageSize = New System.Drawing.Size(20, 20)
        Me.edit_bot_sched8.Location = New System.Drawing.Point(391, 25)
        Me.edit_bot_sched8.Name = "edit_bot_sched8"
        Me.edit_bot_sched8.OnHoverImage = Nothing
        Me.edit_bot_sched8.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.edit_bot_sched8.Size = New System.Drawing.Size(23, 29)
        Me.edit_bot_sched8.TabIndex = 1
        '
        'edit_bot_sched7
        '
        Me.edit_bot_sched7.BackColor = System.Drawing.Color.Transparent
        Me.edit_bot_sched7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.edit_bot_sched7.Enabled = False
        Me.edit_bot_sched7.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.edit_bot_sched7.ImageSize = New System.Drawing.Size(20, 20)
        Me.edit_bot_sched7.Location = New System.Drawing.Point(391, 0)
        Me.edit_bot_sched7.Name = "edit_bot_sched7"
        Me.edit_bot_sched7.OnHoverImage = Nothing
        Me.edit_bot_sched7.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.edit_bot_sched7.Size = New System.Drawing.Size(23, 29)
        Me.edit_bot_sched7.TabIndex = 1
        '
        'edit_bot_sched6
        '
        Me.edit_bot_sched6.BackColor = System.Drawing.Color.Transparent
        Me.edit_bot_sched6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.edit_bot_sched6.Enabled = False
        Me.edit_bot_sched6.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.edit_bot_sched6.ImageSize = New System.Drawing.Size(20, 20)
        Me.edit_bot_sched6.Location = New System.Drawing.Point(269, 25)
        Me.edit_bot_sched6.Name = "edit_bot_sched6"
        Me.edit_bot_sched6.OnHoverImage = Nothing
        Me.edit_bot_sched6.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.edit_bot_sched6.Size = New System.Drawing.Size(23, 29)
        Me.edit_bot_sched6.TabIndex = 1
        '
        'edit_bot_sched5
        '
        Me.edit_bot_sched5.BackColor = System.Drawing.Color.Transparent
        Me.edit_bot_sched5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.edit_bot_sched5.Enabled = False
        Me.edit_bot_sched5.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.edit_bot_sched5.ImageSize = New System.Drawing.Size(20, 20)
        Me.edit_bot_sched5.Location = New System.Drawing.Point(269, -1)
        Me.edit_bot_sched5.Name = "edit_bot_sched5"
        Me.edit_bot_sched5.OnHoverImage = Nothing
        Me.edit_bot_sched5.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.edit_bot_sched5.Size = New System.Drawing.Size(23, 29)
        Me.edit_bot_sched5.TabIndex = 1
        '
        'edit_bot_sched4
        '
        Me.edit_bot_sched4.BackColor = System.Drawing.Color.Transparent
        Me.edit_bot_sched4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.edit_bot_sched4.Enabled = False
        Me.edit_bot_sched4.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.edit_bot_sched4.ImageSize = New System.Drawing.Size(20, 20)
        Me.edit_bot_sched4.Location = New System.Drawing.Point(148, 25)
        Me.edit_bot_sched4.Name = "edit_bot_sched4"
        Me.edit_bot_sched4.OnHoverImage = Nothing
        Me.edit_bot_sched4.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.edit_bot_sched4.Size = New System.Drawing.Size(23, 29)
        Me.edit_bot_sched4.TabIndex = 1
        '
        'edit_bot_sched3
        '
        Me.edit_bot_sched3.BackColor = System.Drawing.Color.Transparent
        Me.edit_bot_sched3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.edit_bot_sched3.Enabled = False
        Me.edit_bot_sched3.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.edit_bot_sched3.ImageSize = New System.Drawing.Size(20, 20)
        Me.edit_bot_sched3.Location = New System.Drawing.Point(149, -1)
        Me.edit_bot_sched3.Name = "edit_bot_sched3"
        Me.edit_bot_sched3.OnHoverImage = Nothing
        Me.edit_bot_sched3.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.edit_bot_sched3.Size = New System.Drawing.Size(23, 29)
        Me.edit_bot_sched3.TabIndex = 1
        '
        'edit_bot_sched2
        '
        Me.edit_bot_sched2.BackColor = System.Drawing.Color.Transparent
        Me.edit_bot_sched2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.edit_bot_sched2.Enabled = False
        Me.edit_bot_sched2.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.edit_bot_sched2.ImageSize = New System.Drawing.Size(20, 20)
        Me.edit_bot_sched2.Location = New System.Drawing.Point(35, 25)
        Me.edit_bot_sched2.Name = "edit_bot_sched2"
        Me.edit_bot_sched2.OnHoverImage = Nothing
        Me.edit_bot_sched2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.edit_bot_sched2.Size = New System.Drawing.Size(23, 29)
        Me.edit_bot_sched2.TabIndex = 1
        '
        'edit_bot_sched1
        '
        Me.edit_bot_sched1.BackColor = System.Drawing.Color.Transparent
        Me.edit_bot_sched1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.edit_bot_sched1.Enabled = False
        Me.edit_bot_sched1.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.edit_bot_sched1.ImageSize = New System.Drawing.Size(20, 20)
        Me.edit_bot_sched1.Location = New System.Drawing.Point(35, -3)
        Me.edit_bot_sched1.Name = "edit_bot_sched1"
        Me.edit_bot_sched1.OnHoverImage = Nothing
        Me.edit_bot_sched1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.edit_bot_sched1.Size = New System.Drawing.Size(23, 29)
        Me.edit_bot_sched1.TabIndex = 1
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedImage = Nothing
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.Enabled = False
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton2.Image = Nothing
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(486, 0)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(120, 26)
        Me.GunaAdvenceButton2.TabIndex = 0
        Me.GunaAdvenceButton2.Text = "GunaAdvenceButton1"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'del_bot_sched1
        '
        Me.del_bot_sched1.BackColor = System.Drawing.Color.Transparent
        Me.del_bot_sched1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.del_bot_sched1.Enabled = False
        Me.del_bot_sched1.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.del_bot_sched1.ImageSize = New System.Drawing.Size(20, 20)
        Me.del_bot_sched1.Location = New System.Drawing.Point(61, -1)
        Me.del_bot_sched1.Name = "del_bot_sched1"
        Me.del_bot_sched1.OnHoverImage = Nothing
        Me.del_bot_sched1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.del_bot_sched1.Size = New System.Drawing.Size(23, 29)
        Me.del_bot_sched1.TabIndex = 1
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedImage = Nothing
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.Enabled = False
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(486, 26)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(120, 26)
        Me.GunaAdvenceButton1.TabIndex = 0
        Me.GunaAdvenceButton1.Text = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'slot_sched_7
        '
        Me.slot_sched_7.AnimationHoverSpeed = 0.07!
        Me.slot_sched_7.AnimationSpeed = 0.03!
        Me.slot_sched_7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_7.BorderColor = System.Drawing.Color.Black
        Me.slot_sched_7.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_7.CheckedBorderColor = System.Drawing.Color.Black
        Me.slot_sched_7.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_7.CheckedImage = Nothing
        Me.slot_sched_7.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.slot_sched_7.Enabled = False
        Me.slot_sched_7.FocusedColor = System.Drawing.Color.Empty
        Me.slot_sched_7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot_sched_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_7.Image = Nothing
        Me.slot_sched_7.ImageSize = New System.Drawing.Size(20, 20)
        Me.slot_sched_7.LineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_7.Location = New System.Drawing.Point(360, 0)
        Me.slot_sched_7.Name = "slot_sched_7"
        Me.slot_sched_7.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.slot_sched_7.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_7.OnHoverImage = Nothing
        Me.slot_sched_7.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_7.OnPressedColor = System.Drawing.Color.Black
        Me.slot_sched_7.Size = New System.Drawing.Size(120, 26)
        Me.slot_sched_7.TabIndex = 0
        Me.slot_sched_7.Text = "GunaAdvenceButton1"
        Me.slot_sched_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'slot_sched_8
        '
        Me.slot_sched_8.AnimationHoverSpeed = 0.07!
        Me.slot_sched_8.AnimationSpeed = 0.03!
        Me.slot_sched_8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_8.BorderColor = System.Drawing.Color.Black
        Me.slot_sched_8.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_8.CheckedBorderColor = System.Drawing.Color.Black
        Me.slot_sched_8.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_8.CheckedImage = Nothing
        Me.slot_sched_8.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.slot_sched_8.Enabled = False
        Me.slot_sched_8.FocusedColor = System.Drawing.Color.Empty
        Me.slot_sched_8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot_sched_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_8.Image = Nothing
        Me.slot_sched_8.ImageSize = New System.Drawing.Size(20, 20)
        Me.slot_sched_8.LineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_8.Location = New System.Drawing.Point(360, 26)
        Me.slot_sched_8.Name = "slot_sched_8"
        Me.slot_sched_8.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_8.OnHoverBorderColor = System.Drawing.Color.Black
        Me.slot_sched_8.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_8.OnHoverImage = Nothing
        Me.slot_sched_8.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_8.OnPressedColor = System.Drawing.Color.Black
        Me.slot_sched_8.Size = New System.Drawing.Size(120, 26)
        Me.slot_sched_8.TabIndex = 0
        Me.slot_sched_8.Text = "GunaAdvenceButton1"
        Me.slot_sched_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'slot_sched_6
        '
        Me.slot_sched_6.AnimationHoverSpeed = 0.07!
        Me.slot_sched_6.AnimationSpeed = 0.03!
        Me.slot_sched_6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_6.BorderColor = System.Drawing.Color.Black
        Me.slot_sched_6.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_6.CheckedBorderColor = System.Drawing.Color.Black
        Me.slot_sched_6.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_6.CheckedImage = Nothing
        Me.slot_sched_6.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.slot_sched_6.Enabled = False
        Me.slot_sched_6.FocusedColor = System.Drawing.Color.Empty
        Me.slot_sched_6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot_sched_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_6.Image = Nothing
        Me.slot_sched_6.ImageSize = New System.Drawing.Size(20, 20)
        Me.slot_sched_6.LineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_6.Location = New System.Drawing.Point(240, 26)
        Me.slot_sched_6.Name = "slot_sched_6"
        Me.slot_sched_6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.slot_sched_6.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_6.OnHoverImage = Nothing
        Me.slot_sched_6.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_6.OnPressedColor = System.Drawing.Color.Black
        Me.slot_sched_6.Size = New System.Drawing.Size(120, 26)
        Me.slot_sched_6.TabIndex = 0
        Me.slot_sched_6.Text = "GunaAdvenceButton1"
        Me.slot_sched_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'slot_sched_5
        '
        Me.slot_sched_5.AnimationHoverSpeed = 0.07!
        Me.slot_sched_5.AnimationSpeed = 0.03!
        Me.slot_sched_5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_5.BorderColor = System.Drawing.Color.Black
        Me.slot_sched_5.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_5.CheckedBorderColor = System.Drawing.Color.Black
        Me.slot_sched_5.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_5.CheckedImage = Nothing
        Me.slot_sched_5.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.slot_sched_5.Enabled = False
        Me.slot_sched_5.FocusedColor = System.Drawing.Color.Empty
        Me.slot_sched_5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot_sched_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_5.Image = Nothing
        Me.slot_sched_5.ImageSize = New System.Drawing.Size(20, 20)
        Me.slot_sched_5.LineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_5.Location = New System.Drawing.Point(240, 0)
        Me.slot_sched_5.Name = "slot_sched_5"
        Me.slot_sched_5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.slot_sched_5.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_5.OnHoverImage = Nothing
        Me.slot_sched_5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_5.OnPressedColor = System.Drawing.Color.Black
        Me.slot_sched_5.Size = New System.Drawing.Size(120, 26)
        Me.slot_sched_5.TabIndex = 0
        Me.slot_sched_5.Text = "GunaAdvenceButton1"
        Me.slot_sched_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'slot_sched_4
        '
        Me.slot_sched_4.AnimationHoverSpeed = 0.07!
        Me.slot_sched_4.AnimationSpeed = 0.03!
        Me.slot_sched_4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_4.BorderColor = System.Drawing.Color.Black
        Me.slot_sched_4.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_4.CheckedBorderColor = System.Drawing.Color.Black
        Me.slot_sched_4.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_4.CheckedImage = Nothing
        Me.slot_sched_4.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.slot_sched_4.Enabled = False
        Me.slot_sched_4.FocusedColor = System.Drawing.Color.Empty
        Me.slot_sched_4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot_sched_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_4.Image = Nothing
        Me.slot_sched_4.ImageSize = New System.Drawing.Size(20, 20)
        Me.slot_sched_4.LineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_4.Location = New System.Drawing.Point(120, 26)
        Me.slot_sched_4.Name = "slot_sched_4"
        Me.slot_sched_4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.slot_sched_4.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_4.OnHoverImage = Nothing
        Me.slot_sched_4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_4.OnPressedColor = System.Drawing.Color.Black
        Me.slot_sched_4.Size = New System.Drawing.Size(120, 26)
        Me.slot_sched_4.TabIndex = 0
        Me.slot_sched_4.Text = "GunaAdvenceButton1"
        Me.slot_sched_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'slot_sched_3
        '
        Me.slot_sched_3.AnimationHoverSpeed = 0.07!
        Me.slot_sched_3.AnimationSpeed = 0.03!
        Me.slot_sched_3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_3.BorderColor = System.Drawing.Color.Black
        Me.slot_sched_3.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_3.CheckedBorderColor = System.Drawing.Color.Black
        Me.slot_sched_3.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_3.CheckedImage = Nothing
        Me.slot_sched_3.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.slot_sched_3.Enabled = False
        Me.slot_sched_3.FocusedColor = System.Drawing.Color.Empty
        Me.slot_sched_3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot_sched_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_3.Image = Nothing
        Me.slot_sched_3.ImageSize = New System.Drawing.Size(20, 20)
        Me.slot_sched_3.LineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_3.Location = New System.Drawing.Point(120, 0)
        Me.slot_sched_3.Name = "slot_sched_3"
        Me.slot_sched_3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.slot_sched_3.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_3.OnHoverImage = Nothing
        Me.slot_sched_3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_3.OnPressedColor = System.Drawing.Color.Black
        Me.slot_sched_3.Size = New System.Drawing.Size(120, 26)
        Me.slot_sched_3.TabIndex = 0
        Me.slot_sched_3.Text = "GunaAdvenceButton1"
        Me.slot_sched_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'slot_sched_2
        '
        Me.slot_sched_2.AnimationHoverSpeed = 0.07!
        Me.slot_sched_2.AnimationSpeed = 0.03!
        Me.slot_sched_2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_2.BorderColor = System.Drawing.Color.Black
        Me.slot_sched_2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_2.CheckedBorderColor = System.Drawing.Color.Black
        Me.slot_sched_2.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_2.CheckedImage = Nothing
        Me.slot_sched_2.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.slot_sched_2.Enabled = False
        Me.slot_sched_2.FocusedColor = System.Drawing.Color.Empty
        Me.slot_sched_2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot_sched_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_2.Image = Nothing
        Me.slot_sched_2.ImageSize = New System.Drawing.Size(20, 20)
        Me.slot_sched_2.LineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_2.Location = New System.Drawing.Point(0, 26)
        Me.slot_sched_2.Name = "slot_sched_2"
        Me.slot_sched_2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.slot_sched_2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_2.OnHoverImage = Nothing
        Me.slot_sched_2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_2.OnPressedColor = System.Drawing.Color.Black
        Me.slot_sched_2.Size = New System.Drawing.Size(120, 26)
        Me.slot_sched_2.TabIndex = 0
        Me.slot_sched_2.Text = "GunaAdvenceButton1"
        Me.slot_sched_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'slot_sched_1
        '
        Me.slot_sched_1.AnimationHoverSpeed = 0.07!
        Me.slot_sched_1.AnimationSpeed = 0.03!
        Me.slot_sched_1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_1.BorderColor = System.Drawing.Color.Black
        Me.slot_sched_1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_1.CheckedBorderColor = System.Drawing.Color.Black
        Me.slot_sched_1.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_1.CheckedImage = Nothing
        Me.slot_sched_1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.slot_sched_1.Enabled = False
        Me.slot_sched_1.FocusedColor = System.Drawing.Color.Empty
        Me.slot_sched_1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot_sched_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_1.Image = Nothing
        Me.slot_sched_1.ImageSize = New System.Drawing.Size(20, 20)
        Me.slot_sched_1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.slot_sched_1.Location = New System.Drawing.Point(0, 0)
        Me.slot_sched_1.Name = "slot_sched_1"
        Me.slot_sched_1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.slot_sched_1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_1.OnHoverImage = Nothing
        Me.slot_sched_1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.slot_sched_1.OnPressedColor = System.Drawing.Color.Black
        Me.slot_sched_1.Size = New System.Drawing.Size(120, 26)
        Me.slot_sched_1.TabIndex = 0
        Me.slot_sched_1.Text = "GunaAdvenceButton1"
        Me.slot_sched_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaImageButton4
        '
        Me.GunaImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton4.Enabled = False
        Me.GunaImageButton4.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.GunaImageButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaImageButton4.Location = New System.Drawing.Point(538, 0)
        Me.GunaImageButton4.Name = "GunaImageButton4"
        Me.GunaImageButton4.OnHoverImage = Nothing
        Me.GunaImageButton4.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton4.Size = New System.Drawing.Size(23, 29)
        Me.GunaImageButton4.TabIndex = 1
        '
        'GunaImageButton3
        '
        Me.GunaImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton3.Enabled = False
        Me.GunaImageButton3.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_1_8
        Me.GunaImageButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaImageButton3.Location = New System.Drawing.Point(538, 25)
        Me.GunaImageButton3.Name = "GunaImageButton3"
        Me.GunaImageButton3.OnHoverImage = Nothing
        Me.GunaImageButton3.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton3.Size = New System.Drawing.Size(23, 29)
        Me.GunaImageButton3.TabIndex = 1
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Enabled = False
        Me.GunaImageButton2.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaImageButton2.Location = New System.Drawing.Point(517, 25)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(23, 29)
        Me.GunaImageButton2.TabIndex = 1
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Enabled = False
        Me.GunaImageButton1.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_12_89
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaImageButton1.Location = New System.Drawing.Point(517, 0)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(23, 29)
        Me.GunaImageButton1.TabIndex = 1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GunaPanel1.Location = New System.Drawing.Point(1, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(955, 512)
        Me.GunaPanel1.TabIndex = 3
        '
        'SchedulingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(952, 509)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.calendar_Main)
        Me.Controls.Add(Me.guna_add_edit_g)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "SchedulingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SchedulingForm"
        Me.guna_add_edit_g.ResumeLayout(False)
        Me.guna_add_edit_g.PerformLayout()
        CType(Me.SubjectstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotprofDataSetAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduletblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotprofDataSetAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduletblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfdetailstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionstblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Room1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomtblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomtblBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingnoroomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.calendar_Main.ResumeLayout(False)
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel9.ResumeLayout(False)
        Me.friday_600PM.ResumeLayout(False)
        Me.friday_600PM.PerformLayout()
        Me.friday_300.ResumeLayout(False)
        Me.friday_300.PerformLayout()
        Me.friday_1130.ResumeLayout(False)
        Me.friday_1130.PerformLayout()
        Me.friday_230.ResumeLayout(False)
        Me.friday_230.PerformLayout()
        Me.friday_1100.ResumeLayout(False)
        Me.friday_1100.PerformLayout()
        Me.friday_200.ResumeLayout(False)
        Me.friday_200.PerformLayout()
        Me.friday_530.ResumeLayout(False)
        Me.friday_530.PerformLayout()
        Me.friday_1030.ResumeLayout(False)
        Me.friday_1030.PerformLayout()
        Me.friday_130.ResumeLayout(False)
        Me.friday_130.PerformLayout()
        Me.friday_1000.ResumeLayout(False)
        Me.friday_1000.PerformLayout()
        Me.friday_100.ResumeLayout(False)
        Me.friday_100.PerformLayout()
        Me.friday_930.ResumeLayout(False)
        Me.friday_930.PerformLayout()
        Me.friday_500.ResumeLayout(False)
        Me.friday_500.PerformLayout()
        Me.friday_1230.ResumeLayout(False)
        Me.friday_1230.PerformLayout()
        Me.friday_900.ResumeLayout(False)
        Me.friday_900.PerformLayout()
        Me.friday_1200.ResumeLayout(False)
        Me.friday_1200.PerformLayout()
        Me.friday_830.ResumeLayout(False)
        Me.friday_830.PerformLayout()
        Me.friday_800.ResumeLayout(False)
        Me.friday_800.PerformLayout()
        Me.friday_430.ResumeLayout(False)
        Me.friday_430.PerformLayout()
        Me.friday_730.ResumeLayout(False)
        Me.friday_730.PerformLayout()
        Me.friday_700.ResumeLayout(False)
        Me.friday_700.PerformLayout()
        Me.friday_630AM.ResumeLayout(False)
        Me.friday_630AM.PerformLayout()
        Me.friday_330.ResumeLayout(False)
        Me.friday_330.PerformLayout()
        Me.friday_400.ResumeLayout(False)
        Me.friday_400.PerformLayout()
        Me.GunaPanel8.ResumeLayout(False)
        Me.thursday_600PM.ResumeLayout(False)
        Me.thursday_600PM.PerformLayout()
        Me.thursday_300.ResumeLayout(False)
        Me.thursday_300.PerformLayout()
        Me.thursday_1130.ResumeLayout(False)
        Me.thursday_1130.PerformLayout()
        Me.thursday_230.ResumeLayout(False)
        Me.thursday_230.PerformLayout()
        Me.thursday_1100.ResumeLayout(False)
        Me.thursday_1100.PerformLayout()
        Me.thursday_530.ResumeLayout(False)
        Me.thursday_530.PerformLayout()
        Me.thursday_200.ResumeLayout(False)
        Me.thursday_200.PerformLayout()
        Me.thursday_1030.ResumeLayout(False)
        Me.thursday_1030.PerformLayout()
        Me.thursday_130.ResumeLayout(False)
        Me.thursday_130.PerformLayout()
        Me.thursday_1000.ResumeLayout(False)
        Me.thursday_1000.PerformLayout()
        Me.thursday_500.ResumeLayout(False)
        Me.thursday_500.PerformLayout()
        Me.thursday_100.ResumeLayout(False)
        Me.thursday_100.PerformLayout()
        Me.thursday_930.ResumeLayout(False)
        Me.thursday_930.PerformLayout()
        Me.thursday_1230.ResumeLayout(False)
        Me.thursday_1230.PerformLayout()
        Me.thursday_900.ResumeLayout(False)
        Me.thursday_900.PerformLayout()
        Me.thursday_430.ResumeLayout(False)
        Me.thursday_430.PerformLayout()
        Me.thursday_1200.ResumeLayout(False)
        Me.thursday_1200.PerformLayout()
        Me.thursday_830.ResumeLayout(False)
        Me.thursday_830.PerformLayout()
        Me.thursday_800.ResumeLayout(False)
        Me.thursday_800.PerformLayout()
        Me.thursday_730.ResumeLayout(False)
        Me.thursday_730.PerformLayout()
        Me.thursday_400.ResumeLayout(False)
        Me.thursday_400.PerformLayout()
        Me.thursday_700.ResumeLayout(False)
        Me.thursday_700.PerformLayout()
        Me.thursday_630.ResumeLayout(False)
        Me.thursday_630.PerformLayout()
        Me.thursday_330.ResumeLayout(False)
        Me.thursday_330.PerformLayout()
        Me.GunaPanel6.ResumeLayout(False)
        Me.wednes_600PM.ResumeLayout(False)
        Me.wednes_600PM.PerformLayout()
        Me.wednes_300.ResumeLayout(False)
        Me.wednes_300.PerformLayout()
        Me.wednes_1130.ResumeLayout(False)
        Me.wednes_1130.PerformLayout()
        Me.wednes_230.ResumeLayout(False)
        Me.wednes_230.PerformLayout()
        Me.wednes_530.ResumeLayout(False)
        Me.wednes_530.PerformLayout()
        Me.wednes_1100.ResumeLayout(False)
        Me.wednes_1100.PerformLayout()
        Me.wednes_200.ResumeLayout(False)
        Me.wednes_200.PerformLayout()
        Me.wednes_1030.ResumeLayout(False)
        Me.wednes_1030.PerformLayout()
        Me.wednes_500.ResumeLayout(False)
        Me.wednes_500.PerformLayout()
        Me.wednes_130.ResumeLayout(False)
        Me.wednes_130.PerformLayout()
        Me.wednes_1000.ResumeLayout(False)
        Me.wednes_1000.PerformLayout()
        Me.wednes_100.ResumeLayout(False)
        Me.wednes_100.PerformLayout()
        Me.wednes_430.ResumeLayout(False)
        Me.wednes_430.PerformLayout()
        Me.wednes_930.ResumeLayout(False)
        Me.wednes_930.PerformLayout()
        Me.wednes_1230.ResumeLayout(False)
        Me.wednes_1230.PerformLayout()
        Me.wednes_900.ResumeLayout(False)
        Me.wednes_900.PerformLayout()
        Me.wednes_400.ResumeLayout(False)
        Me.wednes_400.PerformLayout()
        Me.wednes_1200.ResumeLayout(False)
        Me.wednes_1200.PerformLayout()
        Me.wednes_830.ResumeLayout(False)
        Me.wednes_830.PerformLayout()
        Me.wednes_800.ResumeLayout(False)
        Me.wednes_800.PerformLayout()
        Me.wednes_330.ResumeLayout(False)
        Me.wednes_330.PerformLayout()
        Me.wednes_730.ResumeLayout(False)
        Me.wednes_730.PerformLayout()
        Me.wednes_700.ResumeLayout(False)
        Me.wednes_700.PerformLayout()
        Me.wednes_630.ResumeLayout(False)
        Me.wednes_630.PerformLayout()
        Me.GunaPanel28.ResumeLayout(False)
        Me.tuesday_600PM.ResumeLayout(False)
        Me.tuesday_600PM.PerformLayout()
        Me.tuesday_300.ResumeLayout(False)
        Me.tuesday_300.PerformLayout()
        Me.tuesday_1130.ResumeLayout(False)
        Me.tuesday_1130.PerformLayout()
        Me.tuesday_530.ResumeLayout(False)
        Me.tuesday_530.PerformLayout()
        Me.tuesday_230.ResumeLayout(False)
        Me.tuesday_230.PerformLayout()
        Me.tuesday_1100.ResumeLayout(False)
        Me.tuesday_1100.PerformLayout()
        Me.tuesday_500.ResumeLayout(False)
        Me.tuesday_500.PerformLayout()
        Me.tuesday_200.ResumeLayout(False)
        Me.tuesday_200.PerformLayout()
        Me.tueasday_1030.ResumeLayout(False)
        Me.tueasday_1030.PerformLayout()
        Me.tuesday_430.ResumeLayout(False)
        Me.tuesday_430.PerformLayout()
        Me.tuesday_130.ResumeLayout(False)
        Me.tuesday_130.PerformLayout()
        Me.tuesday_1000.ResumeLayout(False)
        Me.tuesday_1000.PerformLayout()
        Me.tuesday_400.ResumeLayout(False)
        Me.tuesday_400.PerformLayout()
        Me.tuesday_100.ResumeLayout(False)
        Me.tuesday_100.PerformLayout()
        Me.tuesday_930.ResumeLayout(False)
        Me.tuesday_930.PerformLayout()
        Me.tuesday_330.ResumeLayout(False)
        Me.tuesday_330.PerformLayout()
        Me.tuesday_1230.ResumeLayout(False)
        Me.tuesday_1230.PerformLayout()
        Me.tuesday_900.ResumeLayout(False)
        Me.tuesday_900.PerformLayout()
        Me.tuesday_1200.ResumeLayout(False)
        Me.tuesday_1200.PerformLayout()
        Me.tuesday_830.ResumeLayout(False)
        Me.tuesday_830.PerformLayout()
        Me.tuesday_800.ResumeLayout(False)
        Me.tuesday_800.PerformLayout()
        Me.tuesday_730.ResumeLayout(False)
        Me.tuesday_730.PerformLayout()
        Me.tuesday_700.ResumeLayout(False)
        Me.tuesday_700.PerformLayout()
        Me.tuesday_630AM.ResumeLayout(False)
        Me.tuesday_630AM.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.monday_630.ResumeLayout(False)
        Me.monday_630.PerformLayout()
        Me.monday_600PM.ResumeLayout(False)
        Me.monday_600PM.PerformLayout()
        Me.monday_530.ResumeLayout(False)
        Me.monday_530.PerformLayout()
        Me.monday_300.ResumeLayout(False)
        Me.monday_300.PerformLayout()
        Me.monday_1130.ResumeLayout(False)
        Me.monday_1130.PerformLayout()
        Me.monday_700.ResumeLayout(False)
        Me.monday_700.PerformLayout()
        Me.monday_500.ResumeLayout(False)
        Me.monday_500.PerformLayout()
        Me.monday_230.ResumeLayout(False)
        Me.monday_230.PerformLayout()
        Me.monday_1100.ResumeLayout(False)
        Me.monday_1100.PerformLayout()
        Me.monday_430.ResumeLayout(False)
        Me.monday_430.PerformLayout()
        Me.monday_200.ResumeLayout(False)
        Me.monday_200.PerformLayout()
        Me.monday_1030.ResumeLayout(False)
        Me.monday_1030.PerformLayout()
        Me.monday_400.ResumeLayout(False)
        Me.monday_400.PerformLayout()
        Me.monday_130.ResumeLayout(False)
        Me.monday_130.PerformLayout()
        Me.monday_1000.ResumeLayout(False)
        Me.monday_1000.PerformLayout()
        Me.monday_330.ResumeLayout(False)
        Me.monday_330.PerformLayout()
        Me.monday_100.ResumeLayout(False)
        Me.monday_100.PerformLayout()
        Me.monday_930.ResumeLayout(False)
        Me.monday_930.PerformLayout()
        Me.monday_1230.ResumeLayout(False)
        Me.monday_1230.PerformLayout()
        Me.monday_900.ResumeLayout(False)
        Me.monday_900.PerformLayout()
        Me.monday_1200.ResumeLayout(False)
        Me.monday_1200.PerformLayout()
        Me.monday_830.ResumeLayout(False)
        Me.monday_830.PerformLayout()
        Me.monday_800.ResumeLayout(False)
        Me.monday_800.PerformLayout()
        Me.monday_730.ResumeLayout(False)
        Me.monday_730.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        CType(Me.SlotprofDataSetAll1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents guna_add_edit_g As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents sectionlbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents roomlbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Track_dropdown As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents build_dropbox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents add_dragItemBttn As Guna.UI.WinForms.GunaButton

    Friend WithEvents RoomtblBindingSource As BindingSource

    Friend WithEvents Room1BindingSource As BindingSource

    Friend WithEvents RoomtblBindingSource1 As BindingSource
    Friend WithEvents SectionstblBindingSource As BindingSource

    Friend WithEvents add_nSection As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents add_nRoom As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents subject_cmbo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents SlotprofDataSetAll As slotprofDataSetAll
    Friend WithEvents SubjectstblBindingSource As BindingSource
    Friend WithEvents Subjects_tblTableAdapter As slotprofDataSetAllTableAdapters.subjects_tblTableAdapter
    Friend WithEvents RoomtblBindingSource2 As BindingSource
    Friend WithEvents Room_tblTableAdapter As slotprofDataSetAllTableAdapters.room_tblTableAdapter
    Friend WithEvents BuildingnoroomBindingSource As BindingSource
    Friend WithEvents Schedule_tblTableAdapter As slotprofDataSetAllTableAdapters.schedule_tblTableAdapter
    Friend WithEvents ScheduletblBindingSource As BindingSource
    Friend WithEvents SlotprofDataSetAllBindingSource As BindingSource
    Friend WithEvents SectionstblBindingSource1 As BindingSource
    Friend WithEvents Sections_tblTableAdapter As slotprofDataSetAllTableAdapters.sections_tblTableAdapter
    Friend WithEvents room_dropdown As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents section_dropdonw As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents gradLvel_drop As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents ProfdetailstblBindingSource As BindingSource
    Friend WithEvents Prof_details_tblTableAdapter As slotprofDataSetAllTableAdapters.prof_details_tblTableAdapter
    Friend WithEvents ScheduletblBindingSource1 As BindingSource
    Friend WithEvents calendar_Main As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel21 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel30 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel29 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel28 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel27 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel26 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel32 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel31 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel25 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel24 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel23 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel18 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLineTextBox11 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox10 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox9 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox8 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox7 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox6 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox5 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox4 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox3 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaPanel9 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_600PM As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_300 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_1130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_1100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_530 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_1030 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_1000 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_930 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_500 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_1230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_900 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_1200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_830 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_800 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_430 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_730 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_700 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_630AM As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_330 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents friday_400 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel8 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_600PM As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_300 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_1130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_1100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_530 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_1030 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_1000 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_500 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_930 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_1230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_900 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_430 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_1200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_830 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_800 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_730 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_400 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_700 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_630 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents thursday_330 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel6 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_600PM As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_300 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_1130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_530 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_1100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_1030 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_500 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_1000 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_430 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_930 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_1230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_900 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_400 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_1200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_830 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_800 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_330 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_730 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_700 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents wednes_630 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel28 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_600PM As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_300 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_1130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_530 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_1100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_500 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tueasday_1030 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_430 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_1000 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_400 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_930 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_330 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_1230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_900 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_1200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_830 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_800 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_730 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_700 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents tuesday_630AM As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_600PM As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_530 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_300 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_1130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_500 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_1100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_430 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_1030 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_400 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_130 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_1000 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_330 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_100 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_930 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_1230 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_900 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_1200 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_830 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_800 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_730 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_700 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents monday_630 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents SlotprofDataSetAll1 As slotprofDataSetAll
    Friend WithEvents GunaLabel34 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel33 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents day_combo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lbl_Friday_600 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_300 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel145 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_1130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_1100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_530 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_1030 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_1000 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_930 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_500 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_1230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_900 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_1200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_830 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_800 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_430 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_730 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_700 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_630 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_330 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Friday_400 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_600 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_300 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_1130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_1100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_530 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_1030 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_1000 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_500 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_930 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_1230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_900 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_430 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_1200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_830 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_800 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_730 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_400 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_700 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_630 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Thursday_330 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_600 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_300 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_1130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_530 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_1100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_1030 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_500 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_1000 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_430 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_930 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_1230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_900 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_400 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_1200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_830 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_800 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_330 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_730 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_700 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Wednesday_630 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_600 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_300 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_1130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_530 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_1100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_500 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_1030 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_430 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_1000 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_400 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_930 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_330 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_1230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_900 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_1200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_830 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_800 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_730 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_700 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Tuesday_630 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_700 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_600 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_530 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_300 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_1130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_630 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_500 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_1100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_430 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_1030 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_400 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_130 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_1000 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_330 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_100 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_930 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_1230 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_900 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_1200 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_830 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_800 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Monday_730 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents time_combo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents time_end_combo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel36 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel35 As Guna.UI.WinForms.GunaLabel

    Friend WithEvents GunaLabel41 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel39 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel40 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel38 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel37 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents slot_sched_7 As GunaAdvenceButton
    Friend WithEvents slot_sched_8 As GunaAdvenceButton
    Friend WithEvents slot_sched_6 As GunaAdvenceButton
    Friend WithEvents slot_sched_5 As GunaAdvenceButton
    Friend WithEvents slot_sched_4 As GunaAdvenceButton
    Friend WithEvents slot_sched_3 As GunaAdvenceButton
    Friend WithEvents slot_sched_2 As GunaAdvenceButton
    Friend WithEvents slot_sched_1 As GunaAdvenceButton
    Friend WithEvents GunaLabel42 As GunaLabel
    Friend WithEvents del_bot_sched1 As GunaImageButton
    Friend WithEvents del_bot_sched7 As GunaImageButton
    Friend WithEvents del_bot_sched6 As GunaImageButton
    Friend WithEvents del_bot_sched5 As GunaImageButton
    Friend WithEvents del_bot_sched8 As GunaImageButton
    Friend WithEvents del_bot_sched4 As GunaImageButton
    Friend WithEvents del_bot_sched3 As GunaImageButton
    Friend WithEvents del_bot_sched2 As GunaImageButton
    Friend WithEvents edit_bot_sched1 As GunaImageButton
    Friend WithEvents edit_bot_sched8 As GunaImageButton
    Friend WithEvents edit_bot_sched7 As GunaImageButton
    Friend WithEvents edit_bot_sched6 As GunaImageButton
    Friend WithEvents edit_bot_sched5 As GunaImageButton
    Friend WithEvents edit_bot_sched4 As GunaImageButton
    Friend WithEvents edit_bot_sched3 As GunaImageButton
    Friend WithEvents edit_bot_sched2 As GunaImageButton
    Friend WithEvents GunaPanel1 As GunaPanel
    Friend WithEvents update_button As GunaButton
    Friend WithEvents GunaImageButton4 As GunaImageButton
    Friend WithEvents GunaImageButton3 As GunaImageButton
    Friend WithEvents GunaImageButton2 As GunaImageButton
    Friend WithEvents GunaImageButton1 As GunaImageButton
    Friend WithEvents GunaAdvenceButton2 As GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As GunaAdvenceButton
End Class
