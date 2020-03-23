<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeachersTab
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeachersTab))
        Me.GunaAnimate_teachtab = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.dataShowTeacher = New Guna.UI.WinForms.GunaDataGridView()
        Me.checkBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDProf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameprof = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameprof = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNameprof = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfdetailstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SlotprofDataSetAll = New PrjectScheduling.slotprofDataSetAll()
        Me.addProf = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.editButton = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.del_btn = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Prof_details_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.prof_details_tblTableAdapter()
        CType(Me.dataShowTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfdetailstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotprofDataSetAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaAnimate_teachtab
        '
        Me.GunaAnimate_teachtab.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_SLIDE
        Me.GunaAnimate_teachtab.Interval = 300
        Me.GunaAnimate_teachtab.TargetControl = Me
        '
        'dataShowTeacher
        '
        Me.dataShowTeacher.AllowUserToAddRows = False
        Me.dataShowTeacher.AllowUserToDeleteRows = False
        Me.dataShowTeacher.AllowUserToResizeColumns = False
        Me.dataShowTeacher.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dataShowTeacher.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataShowTeacher.AutoGenerateColumns = False
        Me.dataShowTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataShowTeacher.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dataShowTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataShowTeacher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataShowTeacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataShowTeacher.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataShowTeacher.ColumnHeadersHeight = 25
        Me.dataShowTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataShowTeacher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checkBoxColumn, Me.IDProf, Me.FNameprof, Me.LNameprof, Me.MNameprof})
        Me.dataShowTeacher.DataSource = Me.ProfdetailstblBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataShowTeacher.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataShowTeacher.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dataShowTeacher.EnableHeadersVisualStyles = False
        Me.dataShowTeacher.GridColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dataShowTeacher.Location = New System.Drawing.Point(55, 53)
        Me.dataShowTeacher.Name = "dataShowTeacher"
        Me.dataShowTeacher.ReadOnly = True
        Me.dataShowTeacher.RowHeadersVisible = False
        Me.dataShowTeacher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataShowTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataShowTeacher.Size = New System.Drawing.Size(713, 395)
        Me.dataShowTeacher.TabIndex = 1
        Me.dataShowTeacher.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot
        Me.dataShowTeacher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dataShowTeacher.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataShowTeacher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataShowTeacher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataShowTeacher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataShowTeacher.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dataShowTeacher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dataShowTeacher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dataShowTeacher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataShowTeacher.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataShowTeacher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataShowTeacher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataShowTeacher.ThemeStyle.HeaderStyle.Height = 25
        Me.dataShowTeacher.ThemeStyle.ReadOnly = True
        Me.dataShowTeacher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dataShowTeacher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataShowTeacher.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dataShowTeacher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dataShowTeacher.ThemeStyle.RowsStyle.Height = 22
        Me.dataShowTeacher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dataShowTeacher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        '
        'checkBoxColumn
        '
        Me.checkBoxColumn.FillWeight = 126.9036!
        Me.checkBoxColumn.HeaderText = "Selection"
        Me.checkBoxColumn.Name = "checkBoxColumn"
        Me.checkBoxColumn.ReadOnly = True
        '
        'IDProf
        '
        Me.IDProf.DataPropertyName = "ID_Prof"
        Me.IDProf.FillWeight = 93.27411!
        Me.IDProf.HeaderText = "Prof ID"
        Me.IDProf.Name = "IDProf"
        Me.IDProf.ReadOnly = True
        '
        'FNameprof
        '
        Me.FNameprof.DataPropertyName = "FName_prof"
        Me.FNameprof.FillWeight = 93.27411!
        Me.FNameprof.HeaderText = "First Name"
        Me.FNameprof.Name = "FNameprof"
        Me.FNameprof.ReadOnly = True
        '
        'LNameprof
        '
        Me.LNameprof.DataPropertyName = "LName_prof"
        Me.LNameprof.FillWeight = 93.27411!
        Me.LNameprof.HeaderText = "Last Name"
        Me.LNameprof.Name = "LNameprof"
        Me.LNameprof.ReadOnly = True
        '
        'MNameprof
        '
        Me.MNameprof.DataPropertyName = "MName_prof"
        Me.MNameprof.FillWeight = 93.27411!
        Me.MNameprof.HeaderText = "Middle Name"
        Me.MNameprof.Name = "MNameprof"
        Me.MNameprof.ReadOnly = True
        '
        'ProfdetailstblBindingSource
        '
        Me.ProfdetailstblBindingSource.DataMember = "prof_details_tbl"
        Me.ProfdetailstblBindingSource.DataSource = Me.SlotprofDataSetAll
        '
        'SlotprofDataSetAll
        '
        Me.SlotprofDataSetAll.DataSetName = "slotprofDataSetAll"
        Me.SlotprofDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'addProf
        '
        Me.addProf.Animated = True
        Me.addProf.AnimationHoverSpeed = 0.07!
        Me.addProf.AnimationSpeed = 0.03!
        Me.addProf.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.addProf.BorderColor = System.Drawing.Color.Black
        Me.addProf.CheckedBaseColor = System.Drawing.Color.Gray
        Me.addProf.CheckedBorderColor = System.Drawing.Color.Black
        Me.addProf.CheckedForeColor = System.Drawing.Color.White
        Me.addProf.CheckedImage = CType(resources.GetObject("addProf.CheckedImage"), System.Drawing.Image)
        Me.addProf.CheckedLineColor = System.Drawing.Color.DimGray
        Me.addProf.DialogResult = System.Windows.Forms.DialogResult.None
        Me.addProf.FocusedColor = System.Drawing.Color.Empty
        Me.addProf.Font = New System.Drawing.Font("Roboto Thin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addProf.ForeColor = System.Drawing.Color.White
        Me.addProf.Image = CType(resources.GetObject("addProf.Image"), System.Drawing.Image)
        Me.addProf.ImageSize = New System.Drawing.Size(20, 20)
        Me.addProf.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.addProf.Location = New System.Drawing.Point(55, -3)
        Me.addProf.Name = "addProf"
        Me.addProf.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.addProf.OnHoverBorderColor = System.Drawing.Color.Black
        Me.addProf.OnHoverForeColor = System.Drawing.Color.White
        Me.addProf.OnHoverImage = Nothing
        Me.addProf.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.addProf.OnPressedColor = System.Drawing.Color.Black
        Me.addProf.Size = New System.Drawing.Size(59, 57)
        Me.addProf.TabIndex = 2
        '
        'editButton
        '
        Me.editButton.AnimationHoverSpeed = 0.07!
        Me.editButton.AnimationSpeed = 0.03!
        Me.editButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.editButton.BorderColor = System.Drawing.Color.Black
        Me.editButton.CheckedBaseColor = System.Drawing.Color.Gray
        Me.editButton.CheckedBorderColor = System.Drawing.Color.Black
        Me.editButton.CheckedForeColor = System.Drawing.Color.White
        Me.editButton.CheckedImage = CType(resources.GetObject("editButton.CheckedImage"), System.Drawing.Image)
        Me.editButton.CheckedLineColor = System.Drawing.Color.DimGray
        Me.editButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.editButton.Enabled = False
        Me.editButton.FocusedColor = System.Drawing.Color.Empty
        Me.editButton.Font = New System.Drawing.Font("Roboto Thin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.ForeColor = System.Drawing.Color.White
        Me.editButton.Image = CType(resources.GetObject("editButton.Image"), System.Drawing.Image)
        Me.editButton.ImageSize = New System.Drawing.Size(20, 26)
        Me.editButton.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.editButton.Location = New System.Drawing.Point(115, -3)
        Me.editButton.Name = "editButton"
        Me.editButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.editButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.editButton.OnHoverForeColor = System.Drawing.Color.White
        Me.editButton.OnHoverImage = Nothing
        Me.editButton.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.editButton.OnPressedColor = System.Drawing.Color.Black
        Me.editButton.Size = New System.Drawing.Size(61, 57)
        Me.editButton.TabIndex = 2
        '
        'del_btn
        '
        Me.del_btn.AnimationHoverSpeed = 0.07!
        Me.del_btn.AnimationSpeed = 0.03!
        Me.del_btn.BackColor = System.Drawing.Color.Beige
        Me.del_btn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.del_btn.BorderColor = System.Drawing.Color.Black
        Me.del_btn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.del_btn.CheckedBorderColor = System.Drawing.Color.Black
        Me.del_btn.CheckedForeColor = System.Drawing.Color.White
        Me.del_btn.CheckedImage = CType(resources.GetObject("del_btn.CheckedImage"), System.Drawing.Image)
        Me.del_btn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.del_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.del_btn.Enabled = False
        Me.del_btn.FocusedColor = System.Drawing.Color.Empty
        Me.del_btn.Font = New System.Drawing.Font("Roboto Thin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del_btn.ForeColor = System.Drawing.Color.White
        Me.del_btn.Image = CType(resources.GetObject("del_btn.Image"), System.Drawing.Image)
        Me.del_btn.ImageSize = New System.Drawing.Size(20, 24)
        Me.del_btn.LineColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.del_btn.Location = New System.Drawing.Point(177, -3)
        Me.del_btn.Name = "del_btn"
        Me.del_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.del_btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.del_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.del_btn.OnHoverImage = Nothing
        Me.del_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.del_btn.OnPressedColor = System.Drawing.Color.Black
        Me.del_btn.Size = New System.Drawing.Size(60, 57)
        Me.del_btn.TabIndex = 2
        '
        'Prof_details_tblTableAdapter
        '
        Me.Prof_details_tblTableAdapter.ClearBeforeFill = True
        '
        'TeachersTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(766, 450)
        Me.Controls.Add(Me.del_btn)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.addProf)
        Me.Controls.Add(Me.dataShowTeacher)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(54, 49)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TeachersTab"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeachersTab"
        CType(Me.dataShowTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfdetailstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotprofDataSetAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaAnimate_teachtab As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents dataShowTeacher As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents del_btn As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents editButton As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents addProf As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents ID_Prof As DataGridViewTextBoxColumn
    Friend WithEvents FNameprofDataGridView As DataGridViewTextBoxColumn
    Friend WithEvents LNameprofDataGridView As DataGridViewTextBoxColumn
    Friend WithEvents MNameprofDataGridView As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridView As DataGridViewTextBoxColumn
    Friend WithEvents Timeslot As DataGridViewTextBoxColumn
    Friend WithEvents SlotprofDataSetAll As slotprofDataSetAll
    Friend WithEvents ProfdetailstblBindingSource As BindingSource
    Friend WithEvents Prof_details_tblTableAdapter As slotprofDataSetAllTableAdapters.prof_details_tblTableAdapter
    Friend WithEvents checkBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IDProf As DataGridViewTextBoxColumn
    Friend WithEvents FNameprof As DataGridViewTextBoxColumn
    Friend WithEvents LNameprof As DataGridViewTextBoxColumn
    Friend WithEvents MNameprof As DataGridViewTextBoxColumn
End Class
