Imports Microsoft.VisualBasic
Imports System
Namespace CustomDrawHolidayCells
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
			Me.btnAddHoliday = New System.Windows.Forms.Button()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 51)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(775, 488)
			Me.schedulerControl1.Start = New System.DateTime(2008, 8, 18, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'			Me.schedulerControl1.CustomDrawTimeCell += New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(Me.schedulerControl1_CustomDrawTimeCell);
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.btnAddHoliday)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(954, 51)
			Me.panel1.TabIndex = 1
			' 
			' dateNavigator1
			' 
			Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
			Me.dateNavigator1.Location = New System.Drawing.Point(775, 51)
			Me.dateNavigator1.Name = "dateNavigator1"
			Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
			Me.dateNavigator1.Size = New System.Drawing.Size(179, 488)
			Me.dateNavigator1.TabIndex = 2
			Me.dateNavigator1.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.MonthInfo
			' 
			' btnAddHoliday
			' 
			Me.btnAddHoliday.Location = New System.Drawing.Point(12, 12)
			Me.btnAddHoliday.Name = "btnAddHoliday"
			Me.btnAddHoliday.Size = New System.Drawing.Size(171, 23)
			Me.btnAddHoliday.TabIndex = 0
			Me.btnAddHoliday.Text = "Set selected days as holidays"
			Me.btnAddHoliday.UseVisualStyleBackColor = True
'			Me.btnAddHoliday.Click += New System.EventHandler(Me.btnAddHoliday_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(954, 539)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.dateNavigator1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "How to paint holiday cells"
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents btnAddHoliday As System.Windows.Forms.Button
		Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
	End Class
End Namespace

