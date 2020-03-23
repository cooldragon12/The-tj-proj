<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSem
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
        Me.year1 = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.year2 = New Guna.UI.WinForms.GunaComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.semnumber = New Guna.UI.WinForms.GunaComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'year1
        '
        Me.year1.AccessibleName = "year1com"
        Me.year1.BackColor = System.Drawing.Color.Transparent
        Me.year1.BaseColor = System.Drawing.Color.White
        Me.year1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.year1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.year1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.year1.FocusedColor = System.Drawing.Color.Empty
        Me.year1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.year1.ForeColor = System.Drawing.Color.Black
        Me.year1.FormattingEnabled = True
        Me.year1.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2038", "2029", "2030"})
        Me.year1.Location = New System.Drawing.Point(210, 188)
        Me.year1.Name = "year1"
        Me.year1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.year1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.year1.Size = New System.Drawing.Size(97, 26)
        Me.year1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bebas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SCHOOL YEAR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SEMESTER:"
        '
        'year2
        '
        Me.year2.AccessibleName = "year2om"
        Me.year2.BackColor = System.Drawing.Color.Transparent
        Me.year2.BaseColor = System.Drawing.Color.White
        Me.year2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.year2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.year2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.year2.FocusedColor = System.Drawing.Color.Empty
        Me.year2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.year2.ForeColor = System.Drawing.Color.Black
        Me.year2.FormattingEnabled = True
        Me.year2.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2038", "2029", "2030"})
        Me.year2.Location = New System.Drawing.Point(350, 188)
        Me.year2.Name = "year2"
        Me.year2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.year2.OnHoverItemForeColor = System.Drawing.Color.White
        Me.year2.Size = New System.Drawing.Size(97, 26)
        Me.year2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bebas", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 39)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "-"
        '
        'semnumber
        '
        Me.semnumber.BackColor = System.Drawing.Color.Transparent
        Me.semnumber.BaseColor = System.Drawing.Color.White
        Me.semnumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.semnumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.semnumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semnumber.FocusedColor = System.Drawing.Color.Empty
        Me.semnumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.semnumber.ForeColor = System.Drawing.Color.Black
        Me.semnumber.FormattingEnabled = True
        Me.semnumber.Items.AddRange(New Object() {"1", "2"})
        Me.semnumber.Location = New System.Drawing.Point(495, 188)
        Me.semnumber.Name = "semnumber"
        Me.semnumber.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.semnumber.OnHoverItemForeColor = System.Drawing.Color.White
        Me.semnumber.Size = New System.Drawing.Size(143, 26)
        Me.semnumber.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(615, 46)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Add New School Year and Semester"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaAdvenceButton1.BorderSize = 2
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(323, 283)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(130, 42)
        Me.GunaAdvenceButton1.TabIndex = 9
        Me.GunaAdvenceButton1.Text = "Add"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaAdvenceButton2.BorderSize = 2
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = Nothing
        Me.GunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(483, 283)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(130, 42)
        Me.GunaAdvenceButton2.TabIndex = 9
        Me.GunaAdvenceButton2.Text = "Cancel"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CreateSem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(763, 370)
        Me.Controls.Add(Me.GunaAdvenceButton2)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.semnumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.year2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.year1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateSem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Semestral Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents year1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents year2 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents semnumber As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaButton
End Class
