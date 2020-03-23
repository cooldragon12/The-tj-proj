'Imports System.Drawing
'Imports System.ComponentModel
'Imports System.Reflection
'Imports System.Windows.Forms
'Imports DevExpress.Utils.Controls
'Imports DevExpress.XtraEditors
'Imports DevExpress.XtraEditors.Controls
'Imports DevExpress.XtraScheduler
'Imports DevExpress.XtraScheduler.Localization
'Imports DevExpress.XtraScheduler.Native
'Imports DevExpress.XtraScheduler.UI
'Imports DevExpress.Utils
'Imports DevExpress.Utils.Menu
'Imports DevExpress.XtraEditors.Native
'Imports DevExpress.Utils.Internal
'Imports System.Collections.Generic
'Imports DevExpress.XtraScheduler.Internal

'Partial Public Class CustomAppointmentForm1
'    Inherits DevExpress.XtraEditors.XtraForm
'    Implements IDXManagerPopupMenu

'    Private m_openRecurrenceForm As Boolean
'    Private ReadOnly m_storage As ISchedulerStorage
'    Private ReadOnly m_control As SchedulerControl
'    Private m_recurringIcon As Icon
'    Private m_normalIcon As Icon
'    Private ReadOnly m_controller As AppointmentFormController
'    Private m_menuManager As IDXMenuManager

'    <EditorBrowsable(EditorBrowsableState.Never)>
'    Public Sub New()
'        InitializeComponent()
'    End Sub
'    Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
'        Me.New(control, apt, False)
'    End Sub
'    Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
'        Guard.ArgumentNotNull(control, "control")
'        Guard.ArgumentNotNull(control.DataStorage, "control.DataStorage")
'        Guard.ArgumentNotNull(apt, "apt")

'        Me.m_openRecurrenceForm = openRecurrenceForm
'        Me.m_controller = CreateController(control, apt)
'        '
'        ' Required for Windows Form Designer support
'        '
'        InitializeComponent()
'        SetupPredefinedConstraints()

'        LoadIcons()

'        Me.m_control = control
'        Me.m_storage = control.DataStorage

'        'Me.edtShowTimeAs.Storage = Me.m_storage
'        'Me.edtLabel.Storage = Me.m_storage
'        'Me.edtResource.SchedulerControl = control
'        'Me.edtResource.Storage = Me.m_storage
'        'Me.edtResources.SchedulerControl = control

'        SubscribeControllerEvents(Controller)
'        SubscribeEditorsEvents()
'        BindControllerToControls()
'    End Sub

'    Protected Overrides ReadOnly Property ShowMode() As FormShowMode
'        Get
'            Return FormShowMode.AfterInitialization
'        End Get
'    End Property
'    <Browsable(False)>
'    Public Property MenuManager() As IDXMenuManager
'        Get
'            Return Me.m_menuManager
'        End Get
'        Private Set(ByVal value As IDXMenuManager)
'            Me.m_menuManager = value
'        End Set
'    End Property
'    Protected Friend ReadOnly Property Controller() As AppointmentFormController
'        Get
'            Return Me.m_controller
'        End Get
'    End Property
'    Protected Friend ReadOnly Property Control() As SchedulerControl
'        Get
'            Return Me.m_control
'        End Get
'    End Property
'    Protected Friend ReadOnly Property Storage() As ISchedulerStorage
'        Get
'            Return Me.m_storage
'        End Get
'    End Property
'    Protected Friend ReadOnly Property IsNewAppointment() As Boolean
'        Get
'            Return If(Me.m_controller IsNot Nothing, Me.m_controller.IsNewAppointment, True)
'        End Get
'    End Property
'    Protected Friend ReadOnly Property RecurringIcon() As Icon
'        Get
'            Return Me.m_recurringIcon
'        End Get
'    End Property
'    Protected Friend ReadOnly Property NormalIcon() As Icon
'        Get
'            Return Me.m_normalIcon
'        End Get
'    End Property
'    Protected Friend ReadOnly Property OpenRecurrenceForm() As Boolean
'        Get
'            Return Me.m_openRecurrenceForm
'        End Get
'    End Property
'    <DXDescription("DevExpress.XtraScheduler.UI.AppointmentForm,ReadOnly"), DXCategory(CategoryName.Behavior), DefaultValue(False)>
'    Public Property [ReadOnly]() As Boolean
'        Get
'            Return Controller IsNot Nothing AndAlso Controller.ReadOnly
'        End Get
'        Set(ByVal value As Boolean)
'            If Controller.ReadOnly = value Then
'                Return
'            End If
'            Controller.ReadOnly = value
'        End Set
'    End Property

'    Public Overridable Sub LoadFormData(ByVal appointment As Appointment)
'        'do nothing
'    End Sub
'    Public Overridable Function SaveFormData(ByVal appointment As Appointment) As Boolean
'        Return True
'    End Function
'    Public Overridable Function IsAppointmentChanged(ByVal appointment As Appointment) As Boolean
'        Return False
'    End Function
'    Public Overridable Sub SetMenuManager(ByVal menuManager As IDXMenuManager)
'        MenuManagerUtils.SetMenuManager(Controls, menuManager)
'        Me.m_menuManager = menuManager
'    End Sub

'    Protected Friend Overridable Sub SetupPredefinedConstraints()
'        Me.tbProgress.Properties.Minimum = AppointmentProcessValues.Min
'        Me.tbProgress.Properties.Maximum = AppointmentProcessValues.Max
'        Me.tbProgress.Properties.SmallChange = AppointmentProcessValues.Step
'        Me.edtResources.Visible = True
'    End Sub
'    Protected Overridable Sub BindControllerToControls()
'        BindControllerToIcon()
'        BindProperties(Me.tbSubject, "Text", "Subject")
'        BindProperties(Me.tbLocation, "Text", "Location")
'        BindProperties(Me.tbDescription, "Text", "Description")
'        BindProperties(Me.edtShowTimeAs, "Status", "Status")
'        BindProperties(Me.edtStartDate, "EditValue", "DisplayStartDate")
'        BindProperties(Me.edtStartDate, "Enabled", "IsDateTimeEditable")
'        BindProperties(Me.edtStartTime, "EditValue", "DisplayStartTime")
'        BindProperties(Me.edtStartTime, "Visible", "IsTimeVisible")
'        BindProperties(Me.edtStartTime, "Enabled", "IsTimeVisible")
'        BindProperties(Me.edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never)
'        BindProperties(Me.edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never)
'        BindProperties(Me.edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never)
'        BindProperties(Me.edtEndTime, "Visible", "IsTimeVisible", DataSourceUpdateMode.Never)
'        BindProperties(Me.edtEndTime, "Enabled", "IsTimeVisible", DataSourceUpdateMode.Never)
'        BindProperties(Me.chkAllDay, "Checked", "AllDay")
'        BindProperties(Me.chkAllDay, "Enabled", "IsDateTimeEditable")

'        BindProperties(Me.edtResource, "ResourceId", "ResourceId")
'        BindProperties(Me.edtResource, "Enabled", "CanEditResource")
'        BindToBoolPropertyAndInvert(Me.edtResource, "Visible", "ResourceSharing")

'        BindProperties(Me.edtResources, "ResourceIds", "ResourceIds")
'        BindProperties(Me.edtResources, "Visible", "ResourceSharing")
'        BindProperties(Me.edtResources, "Enabled", "CanEditResource")
'        BindProperties(Me.lblResource, "Enabled", "CanEditResource")

'        BindProperties(Me.edtLabel, "Label", "Label")
'        BindProperties(Me.chkReminder, "Enabled", "ReminderVisible")
'        BindProperties(Me.chkReminder, "Visible", "ReminderVisible")
'        BindProperties(Me.chkReminder, "Checked", "HasReminder")
'        BindProperties(Me.cbReminder, "Enabled", "HasReminder")
'        BindProperties(Me.cbReminder, "Visible", "ReminderVisible")
'        BindProperties(Me.cbReminder, "Duration", "ReminderTimeBeforeStart")

'        BindProperties(Me.tbProgress, "Value", "PercentComplete")
'        BindProperties(Me.lblPercentCompleteValue, "Text", "PercentComplete", AddressOf ObjectToStringConverter)
'        BindProperties(Me.progressPanel, "Visible", "ShouldEditTaskProgress")
'        BindToBoolPropertyAndInvert(Me.btnOk, "Enabled", "ReadOnly")
'        BindToBoolPropertyAndInvert(Me.btnRecurrence, "Enabled", "ReadOnly")
'        BindProperties(Me.btnDelete, "Enabled", "CanDeleteAppointment")
'        BindProperties(Me.btnRecurrence, "Visible", "ShouldShowRecurrenceButton")
'    End Sub
'    Protected Overridable Sub BindControllerToIcon()
'        Dim binding As New Binding("Icon", Controller, "AppointmentType")
'        AddHandler binding.Format, AddressOf AppointmentTypeToIconConverter
'        DataBindings.Add(binding)
'    End Sub
'    Protected Overridable Sub ObjectToStringConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
'        e.Value = e.Value.ToString()
'    End Sub
'    Protected Overridable Sub AppointmentTypeToIconConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
'        Dim type As AppointmentType = CType(e.Value, AppointmentType)
'        If type.Equals(AppointmentType.Pattern) Then
'            e.Value = RecurringIcon
'        Else
'            e.Value = NormalIcon
'        End If
'    End Sub
'    Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
'        BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged)
'    End Sub
'    Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal updateMode As DataSourceUpdateMode)
'        target.DataBindings.Add(targetProperty, Controller, sourceProperty, True, updateMode)
'    End Sub
'    Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal objectToStringConverter As ConvertEventHandler)
'        Dim binding As New Binding(targetProperty, Controller, sourceProperty, True)
'        AddHandler binding.Format, objectToStringConverter
'        target.DataBindings.Add(binding)
'    End Sub
'    Protected Overridable Sub BindToBoolPropertyAndInvert(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
'        target.DataBindings.Add(New BoolInvertBinding(targetProperty, Controller, sourceProperty))
'    End Sub
'    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
'        MyBase.OnLoad(e)
'        If Controller Is Nothing Then
'            Return
'        End If
'        DataBindings.Add("Text", Controller, "Caption")
'        SubscribeControlsEvents()
'        LoadFormData(Controller.EditedAppointmentCopy)
'        RecalculateLayoutOfControlsAffectedByProgressPanel()
'    End Sub
'    Protected Overridable Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
'        Return New AppointmentFormController(control, apt)
'    End Function
'    Private Sub SubscribeEditorsEvents()
'        AddHandler Me.cbReminder.EditValueChanging, AddressOf OnCbReminderEditValueChanging
'    End Sub
'    Private Sub SubscribeControllerEvents(ByVal controller As AppointmentFormController)
'        If controller Is Nothing Then
'            Return
'        End If
'        AddHandler controller.PropertyChanged, AddressOf OnControllerPropertyChanged
'    End Sub
'    Private Sub OnControllerPropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
'        If e.PropertyName = "ReadOnly" Then
'            UpdateReadonly()
'        End If
'    End Sub
'    Protected Overridable Sub UpdateReadonly()
'        If Controller Is Nothing Then
'            Return
'        End If
'        Dim controls As IList(Of Control) = GetAllControls(Me)
'        For Each control As Control In controls
'            Dim editor As BaseEdit = TryCast(control, BaseEdit)
'            If editor Is Nothing Then
'                Continue For
'            End If
'            editor.ReadOnly = Controller.ReadOnly
'        Next control
'        Me.btnOk.Enabled = Not Controller.ReadOnly
'        Me.btnRecurrence.Enabled = Not Controller.ReadOnly
'    End Sub

'    Private Function GetAllControls(ByVal rootControl As Control) As List(Of Control)
'        Dim result As New List(Of Control)()
'        For Each control As Control In rootControl.Controls
'            result.Add(control)
'            Dim childControls As IList(Of Control) = GetAllControls(control)
'            result.AddRange(childControls)
'        Next control
'        Return result
'    End Function
'    Protected Friend Overridable Sub LoadIcons()
'        Dim asm As System.Reflection.Assembly = GetType(SchedulerControl).Assembly
'        Me.m_recurringIcon = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.RecurringAppointment, asm)
'        Me.m_normalIcon = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.Appointment, asm)
'    End Sub
'    Protected Friend Overridable Sub SubscribeControlsEvents()
'        AddHandler edtEndDate.Validating, AddressOf OnEdtEndDateValidating
'        AddHandler edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
'        AddHandler edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
'        AddHandler edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
'        AddHandler cbReminder.InvalidValue, AddressOf OnCbReminderInvalidValue
'        AddHandler cbReminder.Validating, AddressOf OnCbReminderValidating
'        AddHandler edtStartDate.Validating, AddressOf OnEdtStartDateValidating
'        AddHandler edtStartDate.InvalidValue, AddressOf OnEdtStartDateInvalidValue
'        AddHandler edtStartTime.Validating, AddressOf OnEdtStartTimeValidating
'        AddHandler edtStartTime.InvalidValue, AddressOf OnEdtStartTimeInvalidValue
'    End Sub
'    Protected Friend Overridable Sub UnsubscribeControlsEvents()
'        RemoveHandler edtEndDate.Validating, AddressOf OnEdtEndDateValidating
'        RemoveHandler edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
'        RemoveHandler edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
'        RemoveHandler edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
'        RemoveHandler cbReminder.InvalidValue, AddressOf OnCbReminderInvalidValue
'        RemoveHandler cbReminder.Validating, AddressOf OnCbReminderValidating
'        RemoveHandler edtStartDate.Validating, AddressOf OnEdtStartDateValidating
'        RemoveHandler edtStartDate.InvalidValue, AddressOf OnEdtStartDateInvalidValue
'        RemoveHandler edtStartTime.Validating, AddressOf OnEdtStartTimeValidating
'        RemoveHandler edtStartTime.InvalidValue, AddressOf OnEdtStartTimeInvalidValue
'    End Sub
'    Private Sub OnBtnOkClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
'        OnOkButton()
'    End Sub
'    Protected Friend Overridable Sub OnEdtStartTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
'        e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
'    End Sub
'    Protected Friend Overridable Sub OnEdtStartTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
'        e.Cancel = Not Controller.ValidateLimitInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)
'    End Sub
'    Protected Friend Overridable Sub OnEdtStartDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
'        e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
'    End Sub
'    Protected Friend Overridable Sub OnEdtStartDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
'        e.Cancel = Not Controller.ValidateLimitInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)
'    End Sub
'    Protected Friend Overridable Sub OnEdtEndDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
'        e.Cancel = Not IsValidInterval()
'        If (Not e.Cancel) Then
'            Me.edtEndDate.DataBindings("EditValue").WriteValue()
'        End If
'    End Sub
'    Protected Friend Overridable Sub OnEdtEndDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
'        If (Not AppointmentFormControllerBase.ValidateInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)) Then
'            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
'        Else
'            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
'        End If
'    End Sub
'    Protected Friend Overridable Sub OnEdtEndTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
'        e.Cancel = Not IsValidInterval()
'        If (Not e.Cancel) Then
'            Me.edtEndTime.DataBindings("EditValue").WriteValue()
'        End If
'    End Sub
'    Protected Friend Overridable Sub OnEdtEndTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
'        If (Not AppointmentFormControllerBase.ValidateInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)) Then
'            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
'        Else
'            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
'        End If
'    End Sub
'    Protected Friend Overridable Function IsValidInterval() As Boolean
'        Return AppointmentFormControllerBase.ValidateInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay) AndAlso Controller.ValidateLimitInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)
'    End Function
'    Protected Friend Overridable Sub OnOkButton()
'        If (Not ValidateDateAndTime()) Then
'            Return
'        End If
'        If (Not SaveFormData(Controller.EditedAppointmentCopy)) Then
'            Return
'        End If
'        If (Not Controller.IsConflictResolved()) Then
'            ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'            Return
'        End If
'        If IsAppointmentChanged(Controller.EditedAppointmentCopy) OrElse Controller.IsAppointmentChanged() OrElse Controller.IsNewAppointment Then
'            Controller.ApplyChanges()
'        End If

'        DialogResult = System.Windows.Forms.DialogResult.OK
'    End Sub
'    Private Function ValidateDateAndTime() As Boolean
'        Me.edtEndDate.DoValidate()
'        Me.edtEndTime.DoValidate()
'        Me.edtStartDate.DoValidate()
'        Me.edtStartTime.DoValidate()

'        Return String.IsNullOrEmpty(Me.edtEndTime.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtEndDate.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtStartDate.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtStartTime.ErrorText)
'    End Function
'    Protected Friend Overridable Function ShowMessageBox(ByVal text As String, ByVal caption As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon) As DialogResult
'        Return XtraMessageBox.Show(Me, text, caption, buttons, icon)
'    End Function
'    Private Sub OnBtnDeleteClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
'        OnDeleteButton()
'    End Sub
'    Protected Friend Overridable Sub OnDeleteButton()
'        If IsNewAppointment Then
'            Return
'        End If

'        Controller.DeleteAppointment()

'        DialogResult = System.Windows.Forms.DialogResult.Abort
'        Close()
'    End Sub
'    Private Sub OnBtnRecurrenceClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnRecurrence.Click
'        OnRecurrenceButton()
'    End Sub
'    Protected Friend Overridable Sub OnRecurrenceButton()
'        If (Not Controller.ShouldShowRecurrenceButton) Then
'            Return
'        End If

'        Dim patternCopy As Appointment = Controller.PrepareToRecurrenceEdit()

'        Dim result As DialogResult
'        Using form As Form = CreateAppointmentRecurrenceForm(patternCopy, Control.OptionsView.FirstDayOfWeek)
'            result = ShowRecurrenceForm(form)
'        End Using

'        If result = System.Windows.Forms.DialogResult.Abort Then
'            Controller.RemoveRecurrence()
'        ElseIf result = System.Windows.Forms.DialogResult.OK Then
'            Controller.ApplyRecurrence(patternCopy)
'        End If
'    End Sub
'    Protected Overridable Function ShowRecurrenceForm(ByVal form As Form) As DialogResult
'        Return FormTouchUIAdapter.ShowDialog(form, Me)
'    End Function
'    Protected Friend Overridable Function CreateAppointmentRecurrenceForm(ByVal patternCopy As Appointment, ByVal firstDayOfWeek As DevExpress.XtraScheduler.FirstDayOfWeek) As Form
'        Dim form As New AppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Controller)
'        form.SetMenuManager(MenuManager)
'        form.LookAndFeel.ParentLookAndFeel = LookAndFeel
'        form.ShowExceptionsRemoveMsgBox = Me.m_controller.AreExceptionsPresent()
'        Return form
'    End Function
'    Friend Sub OnAppointmentFormActivated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
'        If Me.m_openRecurrenceForm Then
'            Me.m_openRecurrenceForm = False
'            OnRecurrenceButton()
'        End If
'    End Sub
'    Protected Friend Overridable Sub OnCbReminderValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
'        Dim span As TimeSpan = Me.cbReminder.Duration
'        e.Cancel = (span = TimeSpan.MinValue) OrElse (span.Ticks < 0)
'        If (Not e.Cancel) Then
'            Me.cbReminder.DataBindings("Duration").WriteValue()
'        End If
'    End Sub
'    Protected Friend Overridable Sub OnCbReminderInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
'        e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidReminderTimeBeforeStart)
'    End Sub
'    Protected Friend Overridable Sub RecalculateLayoutOfControlsAffectedByProgressPanel()
'        If Me.progressPanel.Visible Then
'            Return
'        End If
'        Dim intDeltaY As Integer = Me.progressPanel.Height
'        Me.tbDescription.Location = New Point(Me.tbDescription.Location.X, Me.tbDescription.Location.Y - intDeltaY)
'        Me.tbDescription.Size = New Size(Me.tbDescription.Size.Width, Me.tbDescription.Size.Height + intDeltaY)
'    End Sub
'    Private Sub OnCbReminderEditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs)
'        If TypeOf e.NewValue Is TimeSpan Then
'            Return
'        End If
'        Dim stringValue As String = TryCast(e.NewValue, String)
'        Dim duration As TimeSpan = HumanReadableTimeSpanHelper.Parse(stringValue)
'        If duration.Ticks < 0 Then
'            e.NewValue = TimeSpan.FromTicks(0)
'        End If
'    End Sub
'End Class