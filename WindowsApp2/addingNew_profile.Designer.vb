<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addingNew_profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addingNew_profile))
        Me.name_Last = New System.Windows.Forms.TextBox()
        Me.prof_grp = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.last = New System.Windows.Forms.Label()
        Me.name_MI = New System.Windows.Forms.TextBox()
        Me.name_First = New System.Windows.Forms.TextBox()
        Me.SubjectstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.addedrBtn = New System.Windows.Forms.Button()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.cancBtn = New System.Windows.Forms.Button()
        Me.GunaAnimate_addProf = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.prof_grp.SuspendLayout()
        CType(Me.SubjectstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'name_Last
        '
        Me.name_Last.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_Last.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_Last.Location = New System.Drawing.Point(135, 44)
        Me.name_Last.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.name_Last.Name = "name_Last"
        Me.name_Last.Size = New System.Drawing.Size(206, 18)
        Me.name_Last.TabIndex = 0
        '
        'prof_grp
        '
        Me.prof_grp.Controls.Add(Me.Label3)
        Me.prof_grp.Controls.Add(Me.Label2)
        Me.prof_grp.Controls.Add(Me.last)
        Me.prof_grp.Controls.Add(Me.name_MI)
        Me.prof_grp.Controls.Add(Me.name_First)
        Me.prof_grp.Controls.Add(Me.name_Last)
        Me.prof_grp.Font = New System.Drawing.Font("Bebas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_grp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.prof_grp.Location = New System.Drawing.Point(13, 82)
        Me.prof_grp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prof_grp.Name = "prof_grp"
        Me.prof_grp.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prof_grp.Size = New System.Drawing.Size(373, 176)
        Me.prof_grp.TabIndex = 0
        Me.prof_grp.TabStop = False
        Me.prof_grp.Text = "Profile "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bebas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'last
        '
        Me.last.AutoSize = True
        Me.last.Font = New System.Drawing.Font("Bebas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.Location = New System.Drawing.Point(53, 45)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(56, 15)
        Me.last.TabIndex = 1
        Me.last.Text = "Last Name"
        '
        'name_MI
        '
        Me.name_MI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_MI.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_MI.Location = New System.Drawing.Point(135, 116)
        Me.name_MI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.name_MI.Name = "name_MI"
        Me.name_MI.Size = New System.Drawing.Size(206, 18)
        Me.name_MI.TabIndex = 2
        '
        'name_First
        '
        Me.name_First.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_First.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_First.Location = New System.Drawing.Point(135, 80)
        Me.name_First.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.name_First.Name = "name_First"
        Me.name_First.Size = New System.Drawing.Size(206, 18)
        Me.name_First.TabIndex = 1
        '
        'addedrBtn
        '
        Me.addedrBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.addedrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addedrBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.addedrBtn.Location = New System.Drawing.Point(148, 303)
        Me.addedrBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addedrBtn.Name = "addedrBtn"
        Me.addedrBtn.Size = New System.Drawing.Size(103, 36)
        Me.addedrBtn.TabIndex = 2
        Me.addedrBtn.Text = "Add"
        Me.addedrBtn.UseVisualStyleBackColor = False
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(164, 12)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(65, 63)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 4
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'cancBtn
        '
        Me.cancBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.cancBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cancBtn.Location = New System.Drawing.Point(283, 303)
        Me.cancBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cancBtn.Name = "cancBtn"
        Me.cancBtn.Size = New System.Drawing.Size(103, 36)
        Me.cancBtn.TabIndex = 3
        Me.cancBtn.Text = "Cancel"
        Me.cancBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cancBtn.UseVisualStyleBackColor = False
        '
        'GunaAnimate_addProf
        '
        Me.GunaAnimate_addProf.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Me.GunaAnimate_addProf.Interval = 100
        Me.GunaAnimate_addProf.TargetControl = Me
        '
        'addingNew_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(402, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.cancBtn)
        Me.Controls.Add(Me.addedrBtn)
        Me.Controls.Add(Me.prof_grp)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addingNew_profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Profile"
        Me.prof_grp.ResumeLayout(False)
        Me.prof_grp.PerformLayout()
        CType(Me.SubjectstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents name_Last As TextBox
    Friend WithEvents prof_grp As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents last As Label
    Friend WithEvents name_MI As TextBox
    Friend WithEvents name_First As TextBox
    Friend WithEvents addedrBtn As Button
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents cancBtn As Button
    Friend WithEvents GunaAnimate_addProf As Guna.UI.WinForms.GunaAnimateWindow

    Friend WithEvents SubjectstblBindingSource As BindingSource

End Class
