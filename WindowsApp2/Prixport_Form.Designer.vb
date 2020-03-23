<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prixport_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prixport_Form))
        Me.browse_loc = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.print_sem = New Guna.UI.WinForms.GunaComboBox()
        Me.print_sy = New Guna.UI.WinForms.GunaComboBox()
        Me.choose_expo = New Guna.UI.WinForms.GunaComboBox()
        Me.choice_to_ST = New Guna.UI.WinForms.GunaComboBox()
        Me.print_ex_but = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.location_text = New Guna.UI.WinForms.GunaTextBox()
        Me.SuspendLayout()
        '
        'browse_loc
        '
        Me.browse_loc.AnimationHoverSpeed = 0.07!
        Me.browse_loc.AnimationSpeed = 0.03!
        Me.browse_loc.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.browse_loc.BorderColor = System.Drawing.Color.Black
        Me.browse_loc.DialogResult = System.Windows.Forms.DialogResult.None
        Me.browse_loc.FocusedColor = System.Drawing.Color.Empty
        Me.browse_loc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.browse_loc.ForeColor = System.Drawing.Color.White
        Me.browse_loc.Image = Nothing
        Me.browse_loc.ImageSize = New System.Drawing.Size(20, 20)
        Me.browse_loc.Location = New System.Drawing.Point(308, 320)
        Me.browse_loc.Name = "browse_loc"
        Me.browse_loc.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.browse_loc.OnHoverBorderColor = System.Drawing.Color.White
        Me.browse_loc.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.browse_loc.OnHoverImage = Nothing
        Me.browse_loc.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.browse_loc.Size = New System.Drawing.Size(26, 25)
        Me.browse_loc.TabIndex = 15
        Me.browse_loc.Text = "..."
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(110, 126)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(83, 25)
        Me.GunaLabel2.TabIndex = 10
        Me.GunaLabel2.Text = "EXPORT"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("CPMono_v07 Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(245, 183)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(72, 16)
        Me.GunaLabel5.TabIndex = 11
        Me.GunaLabel5.Text = "Semester"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("CPMono_v07 Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(112, 183)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(96, 16)
        Me.GunaLabel4.TabIndex = 12
        Me.GunaLabel4.Text = "School Year"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("CPMono_v07 Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(112, 231)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(136, 16)
        Me.GunaLabel3.TabIndex = 13
        Me.GunaLabel3.Text = "Choose to Export"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("CPMono_v07 Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(109, 299)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(88, 18)
        Me.GunaLabel1.TabIndex = 14
        Me.GunaLabel1.Text = "Location"
        '
        'print_sem
        '
        Me.print_sem.BackColor = System.Drawing.Color.Transparent
        Me.print_sem.BaseColor = System.Drawing.Color.White
        Me.print_sem.BorderColor = System.Drawing.Color.Silver
        Me.print_sem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.print_sem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.print_sem.FocusedColor = System.Drawing.Color.Empty
        Me.print_sem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.print_sem.ForeColor = System.Drawing.Color.Black
        Me.print_sem.FormattingEnabled = True
        Me.print_sem.Items.AddRange(New Object() {"1", "2"})
        Me.print_sem.Location = New System.Drawing.Point(248, 202)
        Me.print_sem.Name = "print_sem"
        Me.print_sem.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.print_sem.OnHoverItemForeColor = System.Drawing.Color.White
        Me.print_sem.Size = New System.Drawing.Size(57, 26)
        Me.print_sem.TabIndex = 6
        '
        'print_sy
        '
        Me.print_sy.BackColor = System.Drawing.Color.Transparent
        Me.print_sy.BaseColor = System.Drawing.Color.White
        Me.print_sy.BorderColor = System.Drawing.Color.Silver
        Me.print_sy.DisplayMember = "sy"
        Me.print_sy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.print_sy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.print_sy.FocusedColor = System.Drawing.Color.Empty
        Me.print_sy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.print_sy.ForeColor = System.Drawing.Color.Black
        Me.print_sy.FormattingEnabled = True
        Me.print_sy.Location = New System.Drawing.Point(112, 202)
        Me.print_sy.Name = "print_sy"
        Me.print_sy.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.print_sy.OnHoverItemForeColor = System.Drawing.Color.White
        Me.print_sy.Size = New System.Drawing.Size(130, 26)
        Me.print_sy.TabIndex = 7
        '
        'choose_expo
        '
        Me.choose_expo.BackColor = System.Drawing.Color.Transparent
        Me.choose_expo.BaseColor = System.Drawing.Color.White
        Me.choose_expo.BorderColor = System.Drawing.Color.Silver
        Me.choose_expo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.choose_expo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.choose_expo.FocusedColor = System.Drawing.Color.Empty
        Me.choose_expo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.choose_expo.ForeColor = System.Drawing.Color.Black
        Me.choose_expo.FormattingEnabled = True
        Me.choose_expo.Location = New System.Drawing.Point(112, 250)
        Me.choose_expo.Name = "choose_expo"
        Me.choose_expo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.choose_expo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.choose_expo.Size = New System.Drawing.Size(193, 26)
        Me.choose_expo.TabIndex = 8
        '
        'choice_to_ST
        '
        Me.choice_to_ST.BackColor = System.Drawing.Color.Transparent
        Me.choice_to_ST.BaseColor = System.Drawing.Color.White
        Me.choice_to_ST.BorderColor = System.Drawing.Color.Silver
        Me.choice_to_ST.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.choice_to_ST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.choice_to_ST.FocusedColor = System.Drawing.Color.Empty
        Me.choice_to_ST.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.choice_to_ST.ForeColor = System.Drawing.Color.Black
        Me.choice_to_ST.FormattingEnabled = True
        Me.choice_to_ST.Items.AddRange(New Object() {"Teacher"})
        Me.choice_to_ST.Location = New System.Drawing.Point(112, 154)
        Me.choice_to_ST.Name = "choice_to_ST"
        Me.choice_to_ST.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.choice_to_ST.OnHoverItemForeColor = System.Drawing.Color.White
        Me.choice_to_ST.Size = New System.Drawing.Size(193, 26)
        Me.choice_to_ST.TabIndex = 9
        '
        'print_ex_but
        '
        Me.print_ex_but.Animated = True
        Me.print_ex_but.AnimationHoverSpeed = 0.07!
        Me.print_ex_but.AnimationSpeed = 0.03!
        Me.print_ex_but.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.print_ex_but.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.print_ex_but.BorderColor = System.Drawing.Color.Black
        Me.print_ex_but.CheckedBaseColor = System.Drawing.Color.Gray
        Me.print_ex_but.CheckedBorderColor = System.Drawing.Color.Black
        Me.print_ex_but.CheckedForeColor = System.Drawing.Color.White
        Me.print_ex_but.CheckedImage = Nothing
        Me.print_ex_but.CheckedLineColor = System.Drawing.Color.DimGray
        Me.print_ex_but.DialogResult = System.Windows.Forms.DialogResult.None
        Me.print_ex_but.FocusedColor = System.Drawing.Color.Empty
        Me.print_ex_but.Font = New System.Drawing.Font("CPMono_v07 Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print_ex_but.ForeColor = System.Drawing.SystemColors.Info
        Me.print_ex_but.Image = Nothing
        Me.print_ex_but.ImageSize = New System.Drawing.Size(52, 52)
        Me.print_ex_but.LineBottom = 1
        Me.print_ex_but.LineColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.print_ex_but.LineLeft = 1
        Me.print_ex_but.LineRight = 1
        Me.print_ex_but.LineTop = 1
        Me.print_ex_but.Location = New System.Drawing.Point(112, 30)
        Me.print_ex_but.Name = "print_ex_but"
        Me.print_ex_but.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.print_ex_but.OnHoverBorderColor = System.Drawing.Color.Black
        Me.print_ex_but.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.print_ex_but.OnHoverImage = Nothing
        Me.print_ex_but.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.print_ex_but.OnPressedColor = System.Drawing.Color.Black
        Me.print_ex_but.Size = New System.Drawing.Size(114, 70)
        Me.print_ex_but.TabIndex = 4
        Me.print_ex_but.Text = "Export"
        '
        'location_text
        '
        Me.location_text.BaseColor = System.Drawing.Color.White
        Me.location_text.BorderColor = System.Drawing.Color.Silver
        Me.location_text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.location_text.FocusedBaseColor = System.Drawing.Color.White
        Me.location_text.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.location_text.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.location_text.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.location_text.Location = New System.Drawing.Point(112, 320)
        Me.location_text.Name = "location_text"
        Me.location_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.location_text.Size = New System.Drawing.Size(193, 26)
        Me.location_text.TabIndex = 16
        '
        'Prixport_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(587, 431)
        Me.Controls.Add(Me.location_text)
        Me.Controls.Add(Me.browse_loc)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.print_sem)
        Me.Controls.Add(Me.print_sy)
        Me.Controls.Add(Me.choose_expo)
        Me.Controls.Add(Me.choice_to_ST)
        Me.Controls.Add(Me.print_ex_but)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.name = "Prixport_Form"
        Me.Text = "Prixport_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents browse_loc As GunaButton
    Friend WithEvents GunaLabel2 As GunaLabel
    Friend WithEvents GunaLabel5 As GunaLabel
    Friend WithEvents GunaLabel4 As GunaLabel
    Friend WithEvents GunaLabel3 As GunaLabel
    Friend WithEvents GunaLabel1 As GunaLabel
    Friend WithEvents print_sem As GunaComboBox
    Friend WithEvents print_sy As GunaComboBox
    Friend WithEvents choose_expo As GunaComboBox
    Friend WithEvents choice_to_ST As GunaComboBox
    Friend WithEvents print_ex_but As GunaAdvenceTileButton
    Friend WithEvents location_text As GunaTextBox
End Class
