<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_inper
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
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_inper))
        Me.mainMenu_inper = New Guna.UI.WinForms.GunaPanel()
        Me.mainMenu_settings = New Guna.UI.WinForms.GunaImageButton()
        Me.print_exportBtnMain = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.room_SchedBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.teach_Sched = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MainTitle = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.portalName_place = New Guna.UI.WinForms.GunaLabel()
        Me.backBttn = New Guna.UI.WinForms.GunaButton()
        Me.profName_place = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.export_vutton = New Guna.UI.WinForms.GunaTileButton()
        Me.Teacher_sched_button = New Guna.UI.WinForms.GunaTileButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintPreview_Dial = New System.Windows.Forms.PrintPreviewDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaTransition2 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDial = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.mainMenu_inper.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu_inper
        '
        Me.mainMenu_inper.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mainMenu_inper.Controls.Add(Me.mainMenu_settings)
        Me.mainMenu_inper.Controls.Add(Me.print_exportBtnMain)
        Me.mainMenu_inper.Controls.Add(Me.room_SchedBtn)
        Me.mainMenu_inper.Controls.Add(Me.teach_Sched)
        Me.GunaTransition2.SetDecoration(Me.mainMenu_inper, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.mainMenu_inper, Guna.UI.Animation.DecorationType.None)
        Me.mainMenu_inper.ForeColor = System.Drawing.Color.White
        Me.mainMenu_inper.Location = New System.Drawing.Point(0, 48)
        Me.mainMenu_inper.Name = "mainMenu_inper"
        Me.mainMenu_inper.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.mainMenu_inper.Size = New System.Drawing.Size(54, 542)
        Me.mainMenu_inper.TabIndex = 6
        '
        'mainMenu_settings
        '
        Me.GunaTransition2.SetDecoration(Me.mainMenu_settings, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.mainMenu_settings, Guna.UI.Animation.DecorationType.None)
        Me.mainMenu_settings.DialogResult = System.Windows.Forms.DialogResult.None
        Me.mainMenu_settings.Image = CType(resources.GetObject("mainMenu_settings.Image"), System.Drawing.Image)
        Me.mainMenu_settings.ImageSize = New System.Drawing.Size(35, 35)
        Me.mainMenu_settings.Location = New System.Drawing.Point(4, 487)
        Me.mainMenu_settings.Name = "mainMenu_settings"
        Me.mainMenu_settings.OnHoverImage = CType(resources.GetObject("mainMenu_settings.OnHoverImage"), System.Drawing.Image)
        Me.mainMenu_settings.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.mainMenu_settings.Size = New System.Drawing.Size(44, 45)
        Me.mainMenu_settings.TabIndex = 7
        '
        'print_exportBtnMain
        '
        Me.print_exportBtnMain.Animated = True
        Me.print_exportBtnMain.AnimationHoverSpeed = 0.1!
        Me.print_exportBtnMain.AnimationSpeed = 0.9!
        Me.print_exportBtnMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.print_exportBtnMain.BorderColor = System.Drawing.Color.Black
        Me.print_exportBtnMain.CheckedBaseColor = System.Drawing.Color.Gray
        Me.print_exportBtnMain.CheckedBorderColor = System.Drawing.Color.Black
        Me.print_exportBtnMain.CheckedForeColor = System.Drawing.Color.White
        Me.print_exportBtnMain.CheckedImage = CType(resources.GetObject("print_exportBtnMain.CheckedImage"), System.Drawing.Image)
        Me.print_exportBtnMain.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaTransition2.SetDecoration(Me.print_exportBtnMain, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.print_exportBtnMain, Guna.UI.Animation.DecorationType.None)
        Me.print_exportBtnMain.DialogResult = System.Windows.Forms.DialogResult.None
        Me.print_exportBtnMain.FocusedColor = System.Drawing.Color.Empty
        Me.print_exportBtnMain.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print_exportBtnMain.ForeColor = System.Drawing.Color.White
        Me.print_exportBtnMain.Image = CType(resources.GetObject("print_exportBtnMain.Image"), System.Drawing.Image)
        Me.print_exportBtnMain.ImageOffsetX = 2
        Me.print_exportBtnMain.ImageSize = New System.Drawing.Size(26, 25)
        Me.print_exportBtnMain.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.print_exportBtnMain.Location = New System.Drawing.Point(0, 134)
        Me.print_exportBtnMain.Name = "print_exportBtnMain"
        Me.print_exportBtnMain.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.print_exportBtnMain.OnHoverBorderColor = System.Drawing.Color.Black
        Me.print_exportBtnMain.OnHoverForeColor = System.Drawing.Color.White
        Me.print_exportBtnMain.OnHoverImage = Nothing
        Me.print_exportBtnMain.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.print_exportBtnMain.OnPressedColor = System.Drawing.Color.Black
        Me.print_exportBtnMain.Size = New System.Drawing.Size(183, 53)
        Me.print_exportBtnMain.TabIndex = 6
        Me.print_exportBtnMain.Text = "Export/Print"
        Me.print_exportBtnMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'room_SchedBtn
        '
        Me.room_SchedBtn.Animated = True
        Me.room_SchedBtn.AnimationHoverSpeed = 0.1!
        Me.room_SchedBtn.AnimationSpeed = 0.9!
        Me.room_SchedBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.room_SchedBtn.BorderColor = System.Drawing.Color.Black
        Me.room_SchedBtn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.room_SchedBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.room_SchedBtn.CheckedForeColor = System.Drawing.Color.White
        Me.room_SchedBtn.CheckedImage = CType(resources.GetObject("room_SchedBtn.CheckedImage"), System.Drawing.Image)
        Me.room_SchedBtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaTransition2.SetDecoration(Me.room_SchedBtn, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.room_SchedBtn, Guna.UI.Animation.DecorationType.None)
        Me.room_SchedBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.room_SchedBtn.FocusedColor = System.Drawing.Color.Empty
        Me.room_SchedBtn.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.room_SchedBtn.ForeColor = System.Drawing.Color.White
        Me.room_SchedBtn.Image = CType(resources.GetObject("room_SchedBtn.Image"), System.Drawing.Image)
        Me.room_SchedBtn.ImageOffsetX = 5
        Me.room_SchedBtn.ImageSize = New System.Drawing.Size(20, 28)
        Me.room_SchedBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.room_SchedBtn.Location = New System.Drawing.Point(0, 75)
        Me.room_SchedBtn.Name = "room_SchedBtn"
        Me.room_SchedBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.room_SchedBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.room_SchedBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.room_SchedBtn.OnHoverImage = Nothing
        Me.room_SchedBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.room_SchedBtn.OnPressedColor = System.Drawing.Color.Black
        Me.room_SchedBtn.Size = New System.Drawing.Size(183, 53)
        Me.room_SchedBtn.TabIndex = 6
        Me.room_SchedBtn.Text = "Room & Facilities"
        Me.room_SchedBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'teach_Sched
        '
        Me.teach_Sched.Animated = True
        Me.teach_Sched.AnimationHoverSpeed = 0.1!
        Me.teach_Sched.AnimationSpeed = 0.9!
        Me.teach_Sched.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.teach_Sched.BaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.teach_Sched.BorderColor = System.Drawing.Color.Black
        Me.teach_Sched.CheckedBaseColor = System.Drawing.Color.Gray
        Me.teach_Sched.CheckedBorderColor = System.Drawing.Color.Black
        Me.teach_Sched.CheckedForeColor = System.Drawing.Color.White
        Me.teach_Sched.CheckedImage = CType(resources.GetObject("teach_Sched.CheckedImage"), System.Drawing.Image)
        Me.teach_Sched.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaTransition2.SetDecoration(Me.teach_Sched, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.teach_Sched, Guna.UI.Animation.DecorationType.None)
        Me.teach_Sched.DialogResult = System.Windows.Forms.DialogResult.None
        Me.teach_Sched.FocusedColor = System.Drawing.Color.Empty
        Me.teach_Sched.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teach_Sched.ForeColor = System.Drawing.Color.White
        Me.teach_Sched.Image = CType(resources.GetObject("teach_Sched.Image"), System.Drawing.Image)
        Me.teach_Sched.ImageOffsetX = 1
        Me.teach_Sched.ImageSize = New System.Drawing.Size(30, 16)
        Me.teach_Sched.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.teach_Sched.Location = New System.Drawing.Point(0, 16)
        Me.teach_Sched.Name = "teach_Sched"
        Me.teach_Sched.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.teach_Sched.OnHoverBorderColor = System.Drawing.Color.Black
        Me.teach_Sched.OnHoverForeColor = System.Drawing.Color.White
        Me.teach_Sched.OnHoverImage = Nothing
        Me.teach_Sched.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.teach_Sched.OnPressedColor = System.Drawing.Color.Black
        Me.teach_Sched.Size = New System.Drawing.Size(183, 53)
        Me.teach_Sched.TabIndex = 6
        Me.teach_Sched.Text = "Teacher Schedule"
        Me.teach_Sched.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GunaTransition1
        '
        Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlideAndRotate
        Me.GunaTransition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(50)
        Animation2.RotateCoeff = 0.3!
        Animation2.RotateLimit = 0.2!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.GunaTransition1.DefaultAnimation = Animation2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.GunaTransition2.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.LightBlue
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 49)
        Me.Panel1.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.MainTitle)
        Me.Panel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaTransition2.SetDecoration(Me.Panel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Panel4, Guna.UI.Animation.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(-1, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(925, 51)
        Me.Panel4.TabIndex = 9
        '
        'MainTitle
        '
        Me.MainTitle.AutoSize = True
        Me.GunaTransition2.SetDecoration(Me.MainTitle, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.MainTitle, Guna.UI.Animation.DecorationType.None)
        Me.MainTitle.Font = New System.Drawing.Font("CPMono_v07 Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MainTitle.Location = New System.Drawing.Point(61, 13)
        Me.MainTitle.Name = "MainTitle"
        Me.MainTitle.Size = New System.Drawing.Size(96, 25)
        Me.MainTitle.TabIndex = 9
        Me.MainTitle.Text = "TSched"
        Me.MainTitle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTransition2.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox1.Image = Global.PrjectScheduling.My.Resources.Resources.Artboard_1
        Me.GunaPictureBox1.InitialImage = Nothing
        Me.GunaPictureBox1.Location = New System.Drawing.Point(6, 8)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(42, 35)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 8
        Me.GunaPictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.portalName_place)
        Me.Panel2.Controls.Add(Me.backBttn)
        Me.Panel2.Controls.Add(Me.profName_place)
        Me.GunaTransition2.SetDecoration(Me.Panel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Panel2, Guna.UI.Animation.DecorationType.None)
        Me.Panel2.ForeColor = System.Drawing.Color.LightBlue
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(880, 49)
        Me.Panel2.TabIndex = 9
        '
        'portalName_place
        '
        Me.portalName_place.AutoSize = True
        Me.GunaTransition2.SetDecoration(Me.portalName_place, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.portalName_place, Guna.UI.Animation.DecorationType.None)
        Me.portalName_place.Font = New System.Drawing.Font("CPMono_v07 Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.portalName_place.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.portalName_place.Location = New System.Drawing.Point(110, 8)
        Me.portalName_place.Name = "portalName_place"
        Me.portalName_place.Size = New System.Drawing.Size(141, 29)
        Me.portalName_place.TabIndex = 1
        Me.portalName_place.Text = "Schedule"
        '
        'backBttn
        '
        Me.backBttn.AnimationHoverSpeed = 0.07!
        Me.backBttn.AnimationSpeed = 0.03!
        Me.backBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.backBttn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.backBttn.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition2.SetDecoration(Me.backBttn, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.backBttn, Guna.UI.Animation.DecorationType.None)
        Me.backBttn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.backBttn.FocusedColor = System.Drawing.Color.Empty
        Me.backBttn.Font = New System.Drawing.Font("CPMono_v07 Black", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBttn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.backBttn.Image = CType(resources.GetObject("backBttn.Image"), System.Drawing.Image)
        Me.backBttn.ImageSize = New System.Drawing.Size(39, 35)
        Me.backBttn.Location = New System.Drawing.Point(-1, -1)
        Me.backBttn.Name = "backBttn"
        Me.backBttn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.backBttn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.backBttn.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.backBttn.OnHoverImage = Nothing
        Me.backBttn.OnPressedColor = System.Drawing.Color.Black
        Me.backBttn.Size = New System.Drawing.Size(93, 49)
        Me.backBttn.TabIndex = 0
        Me.backBttn.Text = "Back"
        '
        'profName_place
        '
        Me.profName_place.AutoSize = True
        Me.GunaTransition2.SetDecoration(Me.profName_place, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.profName_place, Guna.UI.Animation.DecorationType.None)
        Me.profName_place.Font = New System.Drawing.Font("CPMono_v07 Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profName_place.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.profName_place.Location = New System.Drawing.Point(262, 14)
        Me.profName_place.Name = "profName_place"
        Me.profName_place.Size = New System.Drawing.Size(118, 18)
        Me.profName_place.TabIndex = 7
        Me.profName_place.Text = "label_Teach"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Controls.Add(Me.export_vutton)
        Me.GunaPanel1.Controls.Add(Me.Teacher_sched_button)
        Me.GunaPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaTransition2.SetDecoration(Me.GunaPanel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.GunaPanel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(925, 590)
        Me.GunaPanel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Roboto", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(108, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(691, 84)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Welcome To Scheduler"
        '
        'export_vutton
        '
        Me.export_vutton.Animated = True
        Me.export_vutton.AnimationHoverSpeed = 0.07!
        Me.export_vutton.AnimationSpeed = 0.03!
        Me.export_vutton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.export_vutton.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition2.SetDecoration(Me.export_vutton, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.export_vutton, Guna.UI.Animation.DecorationType.None)
        Me.export_vutton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.export_vutton.FocusedColor = System.Drawing.Color.Empty
        Me.export_vutton.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.export_vutton.ForeColor = System.Drawing.Color.White
        Me.export_vutton.Image = Global.PrjectScheduling.My.Resources.Resources.Asset_7_89
        Me.export_vutton.ImageSize = New System.Drawing.Size(52, 52)
        Me.export_vutton.Location = New System.Drawing.Point(544, 317)
        Me.export_vutton.Name = "export_vutton"
        Me.export_vutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.export_vutton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.export_vutton.OnHoverForeColor = System.Drawing.Color.White
        Me.export_vutton.OnHoverImage = Nothing
        Me.export_vutton.OnPressedColor = System.Drawing.Color.Black
        Me.export_vutton.Size = New System.Drawing.Size(160, 160)
        Me.export_vutton.TabIndex = 5
        Me.export_vutton.Text = "View/Export"
        '
        'Teacher_sched_button
        '
        Me.Teacher_sched_button.Animated = True
        Me.Teacher_sched_button.AnimationHoverSpeed = 0.07!
        Me.Teacher_sched_button.AnimationSpeed = 0.03!
        Me.Teacher_sched_button.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Teacher_sched_button.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition2.SetDecoration(Me.Teacher_sched_button, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Teacher_sched_button, Guna.UI.Animation.DecorationType.None)
        Me.Teacher_sched_button.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Teacher_sched_button.FocusedColor = System.Drawing.Color.Empty
        Me.Teacher_sched_button.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Teacher_sched_button.ForeColor = System.Drawing.Color.White
        Me.Teacher_sched_button.Image = Global.PrjectScheduling.My.Resources.Resources.fd
        Me.Teacher_sched_button.ImageSize = New System.Drawing.Size(70, 52)
        Me.Teacher_sched_button.Location = New System.Drawing.Point(227, 317)
        Me.Teacher_sched_button.Name = "Teacher_sched_button"
        Me.Teacher_sched_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Teacher_sched_button.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Teacher_sched_button.OnHoverForeColor = System.Drawing.Color.White
        Me.Teacher_sched_button.OnHoverImage = Nothing
        Me.Teacher_sched_button.OnPressedColor = System.Drawing.Color.Black
        Me.Teacher_sched_button.Size = New System.Drawing.Size(160, 160)
        Me.Teacher_sched_button.TabIndex = 7
        Me.Teacher_sched_button.Text = "Teacher "
        '
        'PictureBox1
        '
        Me.GunaTransition1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = Global.PrjectScheduling.My.Resources.Resources.Lgo
        Me.PictureBox1.Location = New System.Drawing.Point(391, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PrintPreview_Dial
        '
        Me.PrintPreview_Dial.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreview_Dial.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreview_Dial.ClientSize = New System.Drawing.Size(400, 300)
        Me.GunaTransition2.SetDecoration(Me.PrintPreview_Dial, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.PrintPreview_Dial, Guna.UI.Animation.DecorationType.None)
        Me.PrintPreview_Dial.Enabled = True
        Me.PrintPreview_Dial.Icon = CType(resources.GetObject("PrintPreview_Dial.Icon"), System.Drawing.Icon)
        Me.PrintPreview_Dial.Name = "PrintPreview_Dial"
        Me.PrintPreview_Dial.Visible = False
        '
        'GunaTransition2
        '
        Me.GunaTransition2.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.GunaTransition2.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.GunaTransition2.DefaultAnimation = Animation1
        Me.GunaTransition2.Interval = 20
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_VER_NEGATIVE
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Nothing
        '
        'PrintDial
        '
        Me.PrintDial.UseEXDialog = True
        '
        'PrintDoc
        '
        '
        'Main_inper
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Application
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(925, 589)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainMenu_inper)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main_inper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SchedulerJK"
        Me.mainMenu_inper.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents teach_Sched As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents mainMenu_inper As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents mainMenu_settings As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents print_exportBtnMain As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents room_SchedBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents mainTimerMenu As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MainTitle As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTransition2 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Teacher_sched_button As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents export_vutton As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents PrintDial As PrintDialog
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintPreview_Dial As PrintPreviewDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents portalName_place As GunaLabel
    Friend WithEvents backBttn As GunaButton
    Friend WithEvents profName_place As GunaLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
End Class
