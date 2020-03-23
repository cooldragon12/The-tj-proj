<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SecAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecAdd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid_section = New Guna.UI.WinForms.GunaDataGridView()
        Me.StrandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gradelvl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sectionsno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SlotprofDataSetAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SlotprofDataSetAll = New PrjectScheduling.slotprofDataSetAll()
        Me.search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.info_group = New System.Windows.Forms.GroupBox()
        Me.track_to = New Guna.UI.WinForms.GunaTextBox()
        Me.sec_no = New Guna.UI.WinForms.GunaTextBox()
        Me.grde_level = New Guna.UI.WinForms.GunaComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LAbelt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RoomtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Room_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.room_tblTableAdapter()
        Me.SubjectstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Subjects_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.subjects_tblTableAdapter()
        Me.SubjectstblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sections_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.sections_tblTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid_section, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotprofDataSetAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotprofDataSetAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.info_group.SuspendLayout()
        CType(Me.RoomtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectstblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrid_section)
        Me.GroupBox1.Controls.Add(Me.search)
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.info_group)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 264)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Section"
        '
        'DataGrid_section
        '
        Me.DataGrid_section.AllowUserToAddRows = False
        Me.DataGrid_section.AllowUserToDeleteRows = False
        Me.DataGrid_section.AllowUserToResizeColumns = False
        Me.DataGrid_section.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGrid_section.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid_section.AutoGenerateColumns = False
        Me.DataGrid_section.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_section.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DataGrid_section.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid_section.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGrid_section.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_section.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid_section.ColumnHeadersHeight = 21
        Me.DataGrid_section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrid_section.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StrandName, Me.Gradelvl, Me.Sectionsno})
        Me.DataGrid_section.DataSource = Me.SectionstblBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_section.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid_section.EnableHeadersVisualStyles = False
        Me.DataGrid_section.GridColor = System.Drawing.Color.White
        Me.DataGrid_section.Location = New System.Drawing.Point(286, 46)
        Me.DataGrid_section.Name = "DataGrid_section"
        Me.DataGrid_section.ReadOnly = True
        Me.DataGrid_section.RowHeadersVisible = False
        Me.DataGrid_section.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_section.Size = New System.Drawing.Size(392, 211)
        Me.DataGrid_section.TabIndex = 30
        Me.DataGrid_section.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DataGrid_section.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGrid_section.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGrid_section.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGrid_section.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGrid_section.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGrid_section.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DataGrid_section.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.DataGrid_section.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DataGrid_section.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGrid_section.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGrid_section.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray
        Me.DataGrid_section.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrid_section.ThemeStyle.HeaderStyle.Height = 21
        Me.DataGrid_section.ThemeStyle.ReadOnly = True
        Me.DataGrid_section.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGrid_section.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGrid_section.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGrid_section.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGrid_section.ThemeStyle.RowsStyle.Height = 22
        Me.DataGrid_section.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGrid_section.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'StrandName
        '
        Me.StrandName.DataPropertyName = "strandName"
        Me.StrandName.HeaderText = "Track"
        Me.StrandName.Name = "StrandName"
        Me.StrandName.ReadOnly = True
        '
        'Gradelvl
        '
        Me.Gradelvl.DataPropertyName = "grade_lvl"
        Me.Gradelvl.HeaderText = "Grade Level"
        Me.Gradelvl.Name = "Gradelvl"
        Me.Gradelvl.ReadOnly = True
        '
        'Sectionsno
        '
        Me.Sectionsno.DataPropertyName = "sections_no"
        Me.Sectionsno.HeaderText = "No."
        Me.Sectionsno.Name = "Sectionsno"
        Me.Sectionsno.ReadOnly = True
        '
        'SectionstblBindingSource
        '
        Me.SectionstblBindingSource.DataMember = "sections_tbl"
        Me.SectionstblBindingSource.DataSource = Me.SlotprofDataSetAllBindingSource
        '
        'SlotprofDataSetAllBindingSource
        '
        Me.SlotprofDataSetAllBindingSource.DataSource = Me.SlotprofDataSetAll
        Me.SlotprofDataSetAllBindingSource.Position = 0
        '
        'SlotprofDataSetAll
        '
        Me.SlotprofDataSetAll.DataSetName = "slotprofDataSetAll"
        Me.SlotprofDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'search
        '
        Me.search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(324, 19)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(139, 22)
        Me.search.TabIndex = 6
        Me.search.Tag = ""
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Image = CType(resources.GetObject("btn_search.Image"), System.Drawing.Image)
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_search.Location = New System.Drawing.Point(469, 19)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(64, 22)
        Me.btn_search.TabIndex = 7
        Me.btn_search.Tag = ""
        Me.btn_search.Text = "Search"
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'info_group
        '
        Me.info_group.Controls.Add(Me.track_to)
        Me.info_group.Controls.Add(Me.sec_no)
        Me.info_group.Controls.Add(Me.grde_level)
        Me.info_group.Controls.Add(Me.btnDelete)
        Me.info_group.Controls.Add(Me.btn_add)
        Me.info_group.Controls.Add(Me.Label4)
        Me.info_group.Controls.Add(Me.LAbelt)
        Me.info_group.Controls.Add(Me.Label5)
        Me.info_group.Location = New System.Drawing.Point(6, 17)
        Me.info_group.Name = "info_group"
        Me.info_group.Size = New System.Drawing.Size(274, 217)
        Me.info_group.TabIndex = 28
        Me.info_group.TabStop = False
        Me.info_group.Text = " Information"
        '
        'track_to
        '
        Me.track_to.BaseColor = System.Drawing.Color.White
        Me.track_to.BorderColor = System.Drawing.Color.Silver
        Me.track_to.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.track_to.FocusedBaseColor = System.Drawing.Color.White
        Me.track_to.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.track_to.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.track_to.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.track_to.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.track_to.Location = New System.Drawing.Point(27, 44)
        Me.track_to.Name = "track_to"
        Me.track_to.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.track_to.Size = New System.Drawing.Size(109, 30)
        Me.track_to.TabIndex = 1
        '
        'sec_no
        '
        Me.sec_no.BaseColor = System.Drawing.Color.White
        Me.sec_no.BorderColor = System.Drawing.Color.Silver
        Me.sec_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sec_no.FocusedBaseColor = System.Drawing.Color.White
        Me.sec_no.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_no.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.sec_no.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sec_no.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.sec_no.Location = New System.Drawing.Point(27, 146)
        Me.sec_no.Name = "sec_no"
        Me.sec_no.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.sec_no.Size = New System.Drawing.Size(66, 30)
        Me.sec_no.TabIndex = 3
        '
        'grde_level
        '
        Me.grde_level.BackColor = System.Drawing.Color.Transparent
        Me.grde_level.BaseColor = System.Drawing.Color.White
        Me.grde_level.BorderColor = System.Drawing.Color.Silver
        Me.grde_level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.grde_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.grde_level.FocusedColor = System.Drawing.Color.Black
        Me.grde_level.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grde_level.ForeColor = System.Drawing.Color.Black
        Me.grde_level.FormattingEnabled = True
        Me.grde_level.Items.AddRange(New Object() {"11", "12"})
        Me.grde_level.Location = New System.Drawing.Point(27, 97)
        Me.grde_level.Name = "grde_level"
        Me.grde_level.OnHoverItemBaseColor = System.Drawing.Color.DarkOrange
        Me.grde_level.OnHoverItemForeColor = System.Drawing.Color.White
        Me.grde_level.Size = New System.Drawing.Size(66, 26)
        Me.grde_level.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkOrange
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(200, 180)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(68, 30)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(126, 180)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(68, 30)
        Me.btn_add.TabIndex = 4
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Section no."
        '
        'LAbelt
        '
        Me.LAbelt.AutoSize = True
        Me.LAbelt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LAbelt.Location = New System.Drawing.Point(24, 77)
        Me.LAbelt.Name = "LAbelt"
        Me.LAbelt.Size = New System.Drawing.Size(86, 17)
        Me.LAbelt.TabIndex = 29
        Me.LAbelt.Text = "Grade Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Track"
        '
        'RoomtblBindingSource
        '
        Me.RoomtblBindingSource.DataMember = "room_tbl"
        Me.RoomtblBindingSource.DataSource = Me.SlotprofDataSetAll
        '
        'Room_tblTableAdapter
        '
        Me.Room_tblTableAdapter.ClearBeforeFill = True
        '
        'SubjectstblBindingSource
        '
        Me.SubjectstblBindingSource.DataMember = "subjects_tbl"
        Me.SubjectstblBindingSource.DataSource = Me.SlotprofDataSetAllBindingSource
        '
        'Subjects_tblTableAdapter
        '
        Me.Subjects_tblTableAdapter.ClearBeforeFill = True
        '
        'SubjectstblBindingSource1
        '
        Me.SubjectstblBindingSource1.DataMember = "subjects_tbl"
        Me.SubjectstblBindingSource1.DataSource = Me.SlotprofDataSetAllBindingSource
        '
        'Sections_tblTableAdapter
        '
        Me.Sections_tblTableAdapter.ClearBeforeFill = True
        '
        'SecAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(702, 294)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SecAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sections"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid_section, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotprofDataSetAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotprofDataSetAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.info_group.ResumeLayout(False)
        Me.info_group.PerformLayout()
        CType(Me.RoomtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectstblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents info_group As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LAbelt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents grde_level As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents DataGrid_section As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents track_to As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents sec_no As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents SlotprofDataSetAllBindingSource As BindingSource
    Friend WithEvents SlotprofDataSetAll As slotprofDataSetAll
    Friend WithEvents RoomtblBindingSource As BindingSource
    Friend WithEvents Room_tblTableAdapter As slotprofDataSetAllTableAdapters.room_tblTableAdapter
    Friend WithEvents SubjectstblBindingSource As BindingSource
    Friend WithEvents Subjects_tblTableAdapter As slotprofDataSetAllTableAdapters.subjects_tblTableAdapter
    Friend WithEvents SubjectstblBindingSource1 As BindingSource
    Friend WithEvents SectionstblBindingSource As BindingSource
    Friend WithEvents Sections_tblTableAdapter As slotprofDataSetAllTableAdapters.sections_tblTableAdapter
    Friend WithEvents StrandName As DataGridViewTextBoxColumn
    Friend WithEvents Gradelvl As DataGridViewTextBoxColumn
    Friend WithEvents Sectionsno As DataGridViewTextBoxColumn
End Class
