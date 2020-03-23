<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major,
                                            My.Application.Info.Version.Major)
        Version.Text &= Space(10) & "Loading..."

        progress_sched_start.Maximum = 100
        progress_sched_start.Minimum = 0
        progress_sched_start.Value = 0

        Timer1.Enabled = True
        Timer1.Interval = 200
        Timer1.Start()
    End Sub
    Private iProgressBar_value As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        iProgressBar_value += 1

        Select Case iProgressBar_value
            Case 1, 2, 5, 7, 9
                progress_sched_start.Value = (iProgressBar_value * 10)
            Case 2, 4, 6, 8, 10
                progress_sched_start.Value = (iProgressBar_value * 10)
            Case 13
                Timer1.Stop()
                Timer1.Enabled = False

                Main_inper.Show()
                Me.Close()

        End Select

    End Sub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.progress_sched_start = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.Version = New Guna.UI.WinForms.GunaLabel()
        Me.Copyright = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progress_sched_start
        '
        Me.progress_sched_start.AnimationSpeed = 0.4!
        Me.progress_sched_start.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.progress_sched_start.ColorStyle = Guna.UI.WinForms.ColorStyle.Transition
        Me.progress_sched_start.Font = New System.Drawing.Font("Bebas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progress_sched_start.IdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.progress_sched_start.IdleOffset = 20
        Me.progress_sched_start.Image = Nothing
        Me.progress_sched_start.ImageSize = New System.Drawing.Size(52, 52)
        Me.progress_sched_start.Location = New System.Drawing.Point(408, 118)
        Me.progress_sched_start.Name = "progress_sched_start"
        Me.progress_sched_start.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.progress_sched_start.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.progress_sched_start.ProgressOffset = 20
        Me.progress_sched_start.ProgressThickness = 20
        Me.progress_sched_start.Size = New System.Drawing.Size(98, 98)
        Me.progress_sched_start.TabIndex = 2
        Me.progress_sched_start.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixel
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(269, 273)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(51, 15)
        Me.Version.TabIndex = 3
        Me.Version.Text = "Version:"
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(269, 291)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(61, 15)
        Me.Copyright.TabIndex = 3
        Me.Copyright.Text = "Copyright"
        '
        'Timer1
        '
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(81, 44)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(321, 272)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 4
        Me.GunaPictureBox2.TabStop = False
        Me.GunaPictureBox2.UseTransfarantBackground = True
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.PrjectScheduling.My.Resources.Resources._32Asset_1
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-317, -13)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(647, 589)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 1
        Me.GunaPictureBox1.TabStop = False
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(582, 315)
        Me.Controls.Add(Me.progress_sched_start)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents progress_sched_start As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents Version As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Copyright As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox


End Class
