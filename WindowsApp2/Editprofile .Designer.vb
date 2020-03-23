<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class edit_profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components2 IsNot Nothing Then
                components2.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components2 As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_profile))
        Me.name_Last3 = New System.Windows.Forms.TextBox()
        Me.prof_grp3 = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lastr = New System.Windows.Forms.Label()
        Me.name_MIt = New System.Windows.Forms.TextBox()
        Me.name_First2 = New System.Windows.Forms.TextBox()
        Me.SlotprofDataSetWholeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.addedrBtnn = New System.Windows.Forms.Button()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.cancBtnn = New System.Windows.Forms.Button()
        Me.GunaAnimate_addProfh = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.prof_grp3.SuspendLayout()
        CType(Me.SlotprofDataSetWholeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'name_Last3
        '
        Me.name_Last3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_Last3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_Last3.Location = New System.Drawing.Point(135, 44)
        Me.name_Last3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.name_Last3.Name = "name_Last3"
        Me.name_Last3.Size = New System.Drawing.Size(206, 18)
        Me.name_Last3.TabIndex = 0
        '
        'prof_grp3
        '
        Me.prof_grp3.Controls.Add(Me.Label33)
        Me.prof_grp3.Controls.Add(Me.Label23)
        Me.prof_grp3.Controls.Add(Me.lastr)
        Me.prof_grp3.Controls.Add(Me.name_MIt)
        Me.prof_grp3.Controls.Add(Me.name_First2)
        Me.prof_grp3.Controls.Add(Me.name_Last3)
        Me.prof_grp3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_grp3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.prof_grp3.Location = New System.Drawing.Point(13, 82)
        Me.prof_grp3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prof_grp3.Name = "prof_grp3"
        Me.prof_grp3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prof_grp3.Size = New System.Drawing.Size(373, 176)
        Me.prof_grp3.TabIndex = 0
        Me.prof_grp3.TabStop = False
        Me.prof_grp3.Text = "Profile "
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Bebas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(43, 116)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(75, 17)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "Middle Name"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Bebas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(43, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 17)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "First Name"
        '
        'lastr
        '
        Me.lastr.AutoSize = True
        Me.lastr.Font = New System.Drawing.Font("Bebas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lastr.Location = New System.Drawing.Point(43, 44)
        Me.lastr.Name = "lastr"
        Me.lastr.Size = New System.Drawing.Size(64, 17)
        Me.lastr.TabIndex = 1
        Me.lastr.Text = "Last Name"
        '
        'name_MIt
        '
        Me.name_MIt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_MIt.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_MIt.Location = New System.Drawing.Point(135, 116)
        Me.name_MIt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.name_MIt.Name = "name_MIt"
        Me.name_MIt.Size = New System.Drawing.Size(206, 18)
        Me.name_MIt.TabIndex = 2
        '
        'name_First2
        '
        Me.name_First2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_First2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_First2.Location = New System.Drawing.Point(135, 80)
        Me.name_First2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.name_First2.Name = "name_First2"
        Me.name_First2.Size = New System.Drawing.Size(206, 18)
        Me.name_First2.TabIndex = 1
        '
        'addedrBtnn
        '
        Me.addedrBtnn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.addedrBtnn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addedrBtnn.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addedrBtnn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.addedrBtnn.Location = New System.Drawing.Point(148, 306)
        Me.addedrBtnn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addedrBtnn.Name = "addedrBtnn"
        Me.addedrBtnn.Size = New System.Drawing.Size(103, 36)
        Me.addedrBtnn.TabIndex = 2
        Me.addedrBtnn.Text = "Update"
        Me.addedrBtnn.UseVisualStyleBackColor = False
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(164, 12)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(65, 63)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 4
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'cancBtnn
        '
        Me.cancBtnn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.cancBtnn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancBtnn.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancBtnn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cancBtnn.Location = New System.Drawing.Point(283, 306)
        Me.cancBtnn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cancBtnn.Name = "cancBtnn"
        Me.cancBtnn.Size = New System.Drawing.Size(103, 36)
        Me.cancBtnn.TabIndex = 3
        Me.cancBtnn.Text = "Cancel"
        Me.cancBtnn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cancBtnn.UseVisualStyleBackColor = False
        '
        'GunaAnimate_addProfh
        '
        Me.GunaAnimate_addProfh.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Me.GunaAnimate_addProfh.Interval = 100
        Me.GunaAnimate_addProfh.TargetControl = Me
        '
        'edit_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(402, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Controls.Add(Me.cancBtnn)
        Me.Controls.Add(Me.addedrBtnn)
        Me.Controls.Add(Me.prof_grp3)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "edit_profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Profile"
        Me.prof_grp3.ResumeLayout(False)
        Me.prof_grp3.PerformLayout()
        CType(Me.SlotprofDataSetWholeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents name_Last3 As TextBox
    Friend WithEvents prof_grp3 As GroupBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lastr As Label
    Friend WithEvents name_MIt As TextBox
    Friend WithEvents name_First2 As TextBox
    Friend WithEvents addedrBtnn As Button
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents cancBtnn As Button
    Friend WithEvents GunaAnimate_addProfh As Guna.UI.WinForms.GunaAnimateWindow
    Private components As System.ComponentModel.IContainer
    Friend WithEvents SlotprofDataSetWholeBindingSource As BindingSource

End Class
