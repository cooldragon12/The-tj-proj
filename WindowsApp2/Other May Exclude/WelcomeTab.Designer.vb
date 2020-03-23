<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeTab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeTab))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaTileButton1 = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaTileButton2 = New Guna.UI.WinForms.GunaTileButton()
        Me.GuWelcom1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTileButton3 = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.GunaTransition1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(356, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GunaTileButton1
        '
        Me.GunaTileButton1.Animated = True
        Me.GunaTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaTileButton1.AnimationSpeed = 0.03!
        Me.GunaTileButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaTileButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition1.SetDecoration(Me.GunaTileButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTileButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaTileButton1.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTileButton1.ForeColor = System.Drawing.Color.White
        Me.GunaTileButton1.Image = CType(resources.GetObject("GunaTileButton1.Image"), System.Drawing.Image)
        Me.GunaTileButton1.ImageSize = New System.Drawing.Size(70, 52)
        Me.GunaTileButton1.Location = New System.Drawing.Point(74, 259)
        Me.GunaTileButton1.Name = "GunaTileButton1"
        Me.GunaTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.GunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton1.OnHoverImage = Nothing
        Me.GunaTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton1.Size = New System.Drawing.Size(160, 160)
        Me.GunaTileButton1.TabIndex = 2
        Me.GunaTileButton1.Text = "Teacher "
        '
        'GunaTileButton2
        '
        Me.GunaTileButton2.Animated = True
        Me.GunaTileButton2.AnimationHoverSpeed = 0.07!
        Me.GunaTileButton2.AnimationSpeed = 0.03!
        Me.GunaTileButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaTileButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition1.SetDecoration(Me.GunaTileButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTileButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaTileButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaTileButton2.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTileButton2.ForeColor = System.Drawing.Color.White
        Me.GunaTileButton2.Image = CType(resources.GetObject("GunaTileButton2.Image"), System.Drawing.Image)
        Me.GunaTileButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaTileButton2.Location = New System.Drawing.Point(356, 259)
        Me.GunaTileButton2.Name = "GunaTileButton2"
        Me.GunaTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.GunaTileButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton2.OnHoverImage = Nothing
        Me.GunaTileButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton2.Size = New System.Drawing.Size(160, 160)
        Me.GunaTileButton2.TabIndex = 2
        Me.GunaTileButton2.Text = "Room & Facilities"
        '
        'GuWelcom1
        '
        Me.GuWelcom1.BackColor = System.Drawing.Color.White
        Me.GuWelcom1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GuWelcom1.BorderColor = System.Drawing.Color.Transparent
        Me.GuWelcom1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GunaTransition1.SetDecoration(Me.GuWelcom1, Guna.UI.Animation.DecorationType.None)
        Me.GuWelcom1.FocusedBaseColor = System.Drawing.Color.Transparent
        Me.GuWelcom1.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.GuWelcom1.FocusedForeColor = System.Drawing.Color.Transparent
        Me.GuWelcom1.Font = New System.Drawing.Font("Roboto", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuWelcom1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GuWelcom1.Location = New System.Drawing.Point(178, 148)
        Me.GuWelcom1.Name = "GuWelcom1"
        Me.GuWelcom1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GuWelcom1.Size = New System.Drawing.Size(521, 74)
        Me.GuWelcom1.TabIndex = 3
        Me.GuWelcom1.Text = "Welcome to Scheduler"
        '
        'GunaTileButton3
        '
        Me.GunaTileButton3.Animated = True
        Me.GunaTileButton3.AnimationHoverSpeed = 0.07!
        Me.GunaTileButton3.AnimationSpeed = 0.03!
        Me.GunaTileButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaTileButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition1.SetDecoration(Me.GunaTileButton3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTileButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaTileButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaTileButton3.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTileButton3.ForeColor = System.Drawing.Color.White
        Me.GunaTileButton3.Image = CType(resources.GetObject("GunaTileButton3.Image"), System.Drawing.Image)
        Me.GunaTileButton3.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaTileButton3.Location = New System.Drawing.Point(643, 259)
        Me.GunaTileButton3.Name = "GunaTileButton3"
        Me.GunaTileButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.GunaTileButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton3.OnHoverImage = Nothing
        Me.GunaTileButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton3.Size = New System.Drawing.Size(160, 160)
        Me.GunaTileButton3.TabIndex = 2
        Me.GunaTileButton3.Text = "View/Export"
        '
        'GunaTransition1
        '
        Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.GunaTransition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.GunaTransition1.DefaultAnimation = Animation2
        Me.GunaTransition1.Interval = 20
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_VER_NEGATIVE
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Nothing
        '
        'WelcomeTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 502)
        Me.Controls.Add(Me.GuWelcom1)
        Me.Controls.Add(Me.GunaTileButton3)
        Me.Controls.Add(Me.GunaTileButton2)
        Me.Controls.Add(Me.GunaTileButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WelcomeTab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome To Scheduler"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaTileButton1 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GunaTileButton2 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GuWelcom1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTileButton3 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents Timer1 As Timer
End Class
