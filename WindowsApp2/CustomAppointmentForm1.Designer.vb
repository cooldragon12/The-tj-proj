Imports DevExpress.XtraScheduler.UI

Partial Class CustomAppointmentForm1
    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomAppointmentForm1))
        Me.lblSubject = New DevExpress.XtraEditors.LabelControl()
        Me.lblLocation = New DevExpress.XtraEditors.LabelControl()
        Me.tbSubject = New DevExpress.XtraEditors.TextEdit()
        Me.lblStartTime = New DevExpress.XtraEditors.LabelControl()
        Me.lblEndTime = New DevExpress.XtraEditors.LabelControl()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRecurrence = New DevExpress.XtraEditors.SimpleButton()
        Me.edtStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.edtEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.tbLocation = New DevExpress.XtraEditors.TextEdit()
        Me.edtStartTime = New DevExpress.XtraEditors.TimeEdit()
        Me.edtEndTime = New DevExpress.XtraEditors.TimeEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSubject
        '
        resources.ApplyResources(Me.lblSubject, "lblSubject")
        Me.lblSubject.Name = "lblSubject"
        '
        'lblLocation
        '
        resources.ApplyResources(Me.lblLocation, "lblLocation")
        Me.lblLocation.Name = "lblLocation"
        '
        'tbSubject
        '
        resources.ApplyResources(Me.tbSubject, "tbSubject")
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Properties.AccessibleName = resources.GetString("tbSubject.Properties.AccessibleName")
        '
        'lblStartTime
        '
        resources.ApplyResources(Me.lblStartTime, "lblStartTime")
        Me.lblStartTime.Name = "lblStartTime"
        '
        'lblEndTime
        '
        resources.ApplyResources(Me.lblEndTime, "lblEndTime")
        Me.lblEndTime.Name = "lblEndTime"
        '
        'btnOk
        '
        resources.ApplyResources(Me.btnOk, "btnOk")
        Me.btnOk.Name = "btnOk"
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Name = "btnCancel"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.CausesValidation = False
        Me.btnDelete.Name = "btnDelete"
        '
        'btnRecurrence
        '
        resources.ApplyResources(Me.btnRecurrence, "btnRecurrence")
        Me.btnRecurrence.Name = "btnRecurrence"
        '
        'edtStartDate
        '
        resources.ApplyResources(Me.edtStartDate, "edtStartDate")
        Me.edtStartDate.Name = "edtStartDate"
        Me.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName")
        Me.edtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtStartDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edtStartDate.Properties.MaxValue = New Date(4000, 1, 1, 0, 0, 0, 0)
        '
        'edtEndDate
        '
        resources.ApplyResources(Me.edtEndDate, "edtEndDate")
        Me.edtEndDate.Name = "edtEndDate"
        Me.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName")
        Me.edtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtEndDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edtEndDate.Properties.MaxValue = New Date(4000, 1, 1, 0, 0, 0, 0)
        '
        'tbLocation
        '
        resources.ApplyResources(Me.tbLocation, "tbLocation")
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Properties.AccessibleName = resources.GetString("tbLocation.Properties.AccessibleName")
        '
        'edtStartTime
        '
        resources.ApplyResources(Me.edtStartTime, "edtStartTime")
        Me.edtStartTime.Name = "edtStartTime"
        Me.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName")
        Me.edtStartTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'edtEndTime
        '
        resources.ApplyResources(Me.edtEndTime, "edtEndTime")
        Me.edtEndTime.Name = "edtEndTime"
        Me.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName")
        Me.edtEndTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'TextEdit1
        '
        resources.ApplyResources(Me.TextEdit1, "TextEdit1")
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.AccessibleName = resources.GetString("TextEdit1.Properties.AccessibleName")
        '
        'TextEdit2
        '
        resources.ApplyResources(Me.TextEdit2, "TextEdit2")
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.AccessibleName = resources.GetString("TextEdit2.Properties.AccessibleName")
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'CustomAppointmentForm1
        '
        Me.AcceptButton = Me.btnOk
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.Controls.Add(Me.edtStartTime)
        Me.Controls.Add(Me.edtStartDate)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.tbSubject)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.tbLocation)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRecurrence)
        Me.Controls.Add(Me.edtEndDate)
        Me.Controls.Add(Me.edtEndTime)
        Me.Name = "CustomAppointmentForm1"
        Me.ShowInTaskbar = False
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Protected lblSubject As DevExpress.XtraEditors.LabelControl
    Protected lblLocation As DevExpress.XtraEditors.LabelControl
    Protected lblStartTime As DevExpress.XtraEditors.LabelControl
    Protected lblEndTime As DevExpress.XtraEditors.LabelControl
    Protected WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Protected btnCancel As DevExpress.XtraEditors.SimpleButton
    Protected WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Protected WithEvents btnRecurrence As DevExpress.XtraEditors.SimpleButton
    Protected edtStartDate As DevExpress.XtraEditors.DateEdit
    Protected edtEndDate As DevExpress.XtraEditors.DateEdit
    Protected edtStartTime As DevExpress.XtraEditors.TimeEdit
    Protected edtEndTime As DevExpress.XtraEditors.TimeEdit
    Protected tbSubject As DevExpress.XtraEditors.TextEdit
    Private components As System.ComponentModel.IContainer = Nothing
    Protected tbLocation As DevExpress.XtraEditors.TextEdit
    Protected WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Protected WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Protected WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Protected WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class