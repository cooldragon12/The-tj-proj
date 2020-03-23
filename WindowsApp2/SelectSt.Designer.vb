<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectSt
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
        Me.schedsy_combo = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaButton()
        Me.semester_combo = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.create_button = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'schedsy_combo
        '
        Me.schedsy_combo.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.schedsy_combo.BaseColor = System.Drawing.Color.White
        Me.schedsy_combo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.schedsy_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.schedsy_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.schedsy_combo.FocusedColor = System.Drawing.Color.Empty
        Me.schedsy_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.schedsy_combo.ForeColor = System.Drawing.Color.Black
        Me.schedsy_combo.FormattingEnabled = True
        Me.schedsy_combo.Location = New System.Drawing.Point(218, 179)
        Me.schedsy_combo.Name = "schedsy_combo"
        Me.schedsy_combo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.schedsy_combo.OnHoverItemForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.schedsy_combo.Size = New System.Drawing.Size(130, 26)
        Me.schedsy_combo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bebas", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " Select School Term"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaAdvenceButton1.BorderSize = 2
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(218, 291)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(130, 42)
        Me.GunaAdvenceButton1.TabIndex = 10
        Me.GunaAdvenceButton1.Text = "Continue"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'semester_combo
        '
        Me.semester_combo.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.semester_combo.BaseColor = System.Drawing.Color.White
        Me.semester_combo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.semester_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.semester_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semester_combo.FocusedColor = System.Drawing.Color.Empty
        Me.semester_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.semester_combo.ForeColor = System.Drawing.Color.Black
        Me.semester_combo.FormattingEnabled = True
        Me.semester_combo.Items.AddRange(New Object() {"1", "2"})
        Me.semester_combo.Location = New System.Drawing.Point(392, 179)
        Me.semester_combo.Name = "semester_combo"
        Me.semester_combo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.semester_combo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.semester_combo.Size = New System.Drawing.Size(130, 26)
        Me.semester_combo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "School Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bebas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Semester:"
        '
        'create_button
        '
        Me.create_button.AnimationHoverSpeed = 0.07!
        Me.create_button.AnimationSpeed = 0.03!
        Me.create_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.create_button.BaseColor = System.Drawing.Color.White
        Me.create_button.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.create_button.BorderSize = 2
        Me.create_button.DialogResult = System.Windows.Forms.DialogResult.None
        Me.create_button.FocusedColor = System.Drawing.Color.Empty
        Me.create_button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.create_button.Image = Nothing
        Me.create_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.create_button.ImageSize = New System.Drawing.Size(20, 20)
        Me.create_button.Location = New System.Drawing.Point(392, 291)
        Me.create_button.Name = "create_button"
        Me.create_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.create_button.OnHoverBorderColor = System.Drawing.Color.Black
        Me.create_button.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.create_button.OnHoverImage = Nothing
        Me.create_button.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.create_button.Size = New System.Drawing.Size(130, 42)
        Me.create_button.TabIndex = 10
        Me.create_button.Text = "Create"
        Me.create_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SelectSt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 435)
        Me.Controls.Add(Me.create_button)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.semester_combo)
        Me.Controls.Add(Me.schedsy_combo)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectSt"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents schedsy_combo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents semester_combo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents create_button As Guna.UI.WinForms.GunaButton
End Class
