Imports DevExpress.Schedule
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace CustomDrawHolidayCells
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

			AddHoliday(DateTime.Today)
		End Sub
		Private ReadOnly Property Holidays() As WorkDaysCollection
			Get
				Return schedulerControl1.WorkDays
			End Get
		End Property

		Private Sub btnAddHoliday_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddHoliday.Click
			Dim days As New DayIntervalCollection()
			days.Add(schedulerControl1.SelectedInterval)

			schedulerControl1.BeginUpdate()
			Try
				For i As Integer = 0 To days.Count - 1
					AddHoliday(days(i).Start)
				Next i
			Finally
				schedulerControl1.EndUpdate()
			End Try

		End Sub
		Private Sub AddHoliday(ByVal holidayDate As DateTime)
			Dim interval As New TimeInterval(holidayDate, TimeSpan.FromDays(1))
			If Not IsHoliday(interval) Then
				Holidays.AddHoliday(holidayDate, String.Format("Holiday-{0}", holidayDate.ToShortDateString()))
			End If
		End Sub
		Private Function IsHoliday(ByVal interval As TimeInterval) As Boolean
			Dim count As Integer = Holidays.Count
			For i As Integer = 0 To count - 1
				Dim holiday As Holiday = TryCast(Holidays(i), Holiday)
				If holiday IsNot Nothing Then
					Dim holidayInterval As New TimeInterval(holiday.Date, TimeSpan.FromDays(1))
					If holidayInterval.IntersectsWithExcludingBounds(interval) Then
						Return True
					End If
				End If
			Next i
			Return False
		End Function
		Private Sub schedulerControl1_CustomDrawTimeCell(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles schedulerControl1.CustomDrawTimeCell
			Dim cell As SchedulerViewCellBase = TryCast(e.ObjectInfo, SchedulerViewCellBase)
			If cell IsNot Nothing AndAlso IsHoliday(cell.Interval) Then
				cell.Appearance.BackColor = Color.Tomato
			End If
		End Sub

	End Class
End Namespace