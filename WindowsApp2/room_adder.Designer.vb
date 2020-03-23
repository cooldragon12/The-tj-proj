<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class room_adder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(room_adder))
        Me.Mai_fro = New System.Windows.Forms.GroupBox()
        Me.DataGridRoom = New Guna.UI.WinForms.GunaDataGridView()
        Me.BuildingnoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomtblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SlotprofDataSetAll1 = New PrjectScheduling.slotprofDataSetAll()
        Me.search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Info_fill = New System.Windows.Forms.GroupBox()
        Me.roomNo = New Guna.UI.WinForms.GunaTextBox()
        Me.buildi = New Guna.UI.WinForms.GunaTextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SlotprofDataSetAll = New PrjectScheduling.slotprofDataSetAll()
        Me.Room_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.room_tblTableAdapter()
        Me.RoomtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Schedule_tblTableAdapter = New PrjectScheduling.slotprofDataSetAllTableAdapters.schedule_tblTableAdapter()
        Me.BuildingnoroomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mai_fro.SuspendLayout()
        CType(Me.DataGridRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomtblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlotprofDataSetAll1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Info_fill.SuspendLayout()
        CType(Me.SlotprofDataSetAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingnoroomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mai_fro
        '
        Me.Mai_fro.Controls.Add(Me.DataGridRoom)
        Me.Mai_fro.Controls.Add(Me.search)
        Me.Mai_fro.Controls.Add(Me.btn_search)
        Me.Mai_fro.Controls.Add(Me.Info_fill)
        Me.Mai_fro.Location = New System.Drawing.Point(12, 5)
        Me.Mai_fro.Name = "Mai_fro"
        Me.Mai_fro.Size = New System.Drawing.Size(696, 276)
        Me.Mai_fro.TabIndex = 37
        Me.Mai_fro.TabStop = False
        Me.Mai_fro.Text = " Room"
        '
        'DataGridRoom
        '
        Me.DataGridRoom.AllowUserToAddRows = False
        Me.DataGridRoom.AllowUserToDeleteRows = False
        Me.DataGridRoom.AllowUserToResizeColumns = False
        Me.DataGridRoom.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridRoom.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridRoom.AutoGenerateColumns = False
        Me.DataGridRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridRoom.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.DataGridRoom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRoom.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridRoom.ColumnHeadersHeight = 21
        Me.DataGridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridRoom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BuildingnoColumn, Me.RoomnoColumn})
        Me.DataGridRoom.DataSource = Me.RoomtblBindingSource1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRoom.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridRoom.EnableHeadersVisualStyles = False
        Me.DataGridRoom.GridColor = System.Drawing.Color.White
        Me.DataGridRoom.Location = New System.Drawing.Point(298, 59)
        Me.DataGridRoom.Name = "DataGridRoom"
        Me.DataGridRoom.ReadOnly = True
        Me.DataGridRoom.RowHeadersVisible = False
        Me.DataGridRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRoom.Size = New System.Drawing.Size(392, 211)
        Me.DataGridRoom.TabIndex = 31
        Me.DataGridRoom.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DataGridRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridRoom.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridRoom.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.DataGridRoom.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.DataGridRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.DataGridRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridRoom.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.DataGridRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridRoom.ThemeStyle.HeaderStyle.Height = 21
        Me.DataGridRoom.ThemeStyle.ReadOnly = True
        Me.DataGridRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridRoom.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridRoom.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BuildingnoColumn
        '
        Me.BuildingnoColumn.DataPropertyName = "building_no"
        Me.BuildingnoColumn.HeaderText = "Building Letter"
        Me.BuildingnoColumn.Name = "BuildingnoColumn"
        Me.BuildingnoColumn.ReadOnly = True
        '
        'RoomnoColumn
        '
        Me.RoomnoColumn.DataPropertyName = "room_no"
        Me.RoomnoColumn.HeaderText = "Room no."
        Me.RoomnoColumn.Name = "RoomnoColumn"
        Me.RoomnoColumn.ReadOnly = True
        '
        'RoomtblBindingSource1
        '
        Me.RoomtblBindingSource1.DataMember = "room_tbl"
        Me.RoomtblBindingSource1.DataSource = Me.SlotprofDataSetAll1
        '
        'SlotprofDataSetAll1
        '
        Me.SlotprofDataSetAll1.DataSetName = "slotprofDataSetAll"
        Me.SlotprofDataSetAll1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'search
        '
        Me.search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(324, 27)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(151, 26)
        Me.search.TabIndex = 5
        Me.search.Tag = ""
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Image = CType(resources.GetObject("btn_search.Image"), System.Drawing.Image)
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_search.Location = New System.Drawing.Point(481, 27)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(64, 22)
        Me.btn_search.TabIndex = 8
        Me.btn_search.Tag = ""
        Me.btn_search.Text = "Search"
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Info_fill
        '
        Me.Info_fill.Controls.Add(Me.roomNo)
        Me.Info_fill.Controls.Add(Me.buildi)
        Me.Info_fill.Controls.Add(Me.btnDelete)
        Me.Info_fill.Controls.Add(Me.btn_add)
        Me.Info_fill.Controls.Add(Me.Label2)
        Me.Info_fill.Controls.Add(Me.Label5)
        Me.Info_fill.Location = New System.Drawing.Point(6, 19)
        Me.Info_fill.Name = "Info_fill"
        Me.Info_fill.Size = New System.Drawing.Size(274, 236)
        Me.Info_fill.TabIndex = 28
        Me.Info_fill.TabStop = False
        Me.Info_fill.Text = " Information"
        '
        'roomNo
        '
        Me.roomNo.BaseColor = System.Drawing.Color.White
        Me.roomNo.BorderColor = System.Drawing.Color.Silver
        Me.roomNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.roomNo.FocusedBaseColor = System.Drawing.Color.White
        Me.roomNo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.roomNo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.roomNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomNo.Location = New System.Drawing.Point(27, 131)
        Me.roomNo.Name = "roomNo"
        Me.roomNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.roomNo.Size = New System.Drawing.Size(160, 26)
        Me.roomNo.TabIndex = 2
        '
        'buildi
        '
        Me.buildi.BaseColor = System.Drawing.Color.White
        Me.buildi.BorderColor = System.Drawing.Color.Silver
        Me.buildi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.buildi.FocusedBaseColor = System.Drawing.Color.White
        Me.buildi.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.buildi.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.buildi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.buildi.Location = New System.Drawing.Point(27, 47)
        Me.buildi.Name = "buildi"
        Me.buildi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.buildi.Size = New System.Drawing.Size(160, 26)
        Me.buildi.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(200, 199)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(68, 30)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(119, 199)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(68, 30)
        Me.btn_add.TabIndex = 3
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Room"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Building"
        '
        'SlotprofDataSetAll
        '
        Me.SlotprofDataSetAll.DataSetName = "slotprofDataSetAll"
        Me.SlotprofDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Room_tblTableAdapter
        '
        Me.Room_tblTableAdapter.ClearBeforeFill = True
        '
        'RoomtblBindingSource
        '
        Me.RoomtblBindingSource.DataMember = "room_tbl"
        Me.RoomtblBindingSource.DataSource = Me.SlotprofDataSetAll
        '
        'Schedule_tblTableAdapter
        '
        Me.Schedule_tblTableAdapter.ClearBeforeFill = True
        '
        'BuildingnoroomBindingSource
        '
        Me.BuildingnoroomBindingSource.DataMember = "building_no_room"
        Me.BuildingnoroomBindingSource.DataSource = Me.RoomtblBindingSource
        '
        'room_adder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(716, 293)
        Me.Controls.Add(Me.Mai_fro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "room_adder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms"
        Me.Mai_fro.ResumeLayout(False)
        Me.Mai_fro.PerformLayout()
        CType(Me.DataGridRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomtblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlotprofDataSetAll1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Info_fill.ResumeLayout(False)
        Me.Info_fill.PerformLayout()
        CType(Me.SlotprofDataSetAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingnoroomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Mai_fro As GroupBox
    Friend WithEvents search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents Info_fill As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents roomNo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents buildi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents SlotprofDataSetAll As slotprofDataSetAll
    Friend WithEvents RoomtblBindingSource As BindingSource
    Friend WithEvents Room_tblTableAdapter As slotprofDataSetAllTableAdapters.room_tblTableAdapter
    Friend WithEvents DataGridRoom As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents BuildingnoroomBindingSource As BindingSource
    Friend WithEvents Schedule_tblTableAdapter As slotprofDataSetAllTableAdapters.schedule_tblTableAdapter
    Friend WithEvents SlotprofDataSetAll1 As slotprofDataSetAll
    Friend WithEvents RoomtblBindingSource1 As BindingSource
    Friend WithEvents BuildingnoColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomnoColumn As DataGridViewTextBoxColumn
End Class
