using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;

namespace CustomDrawHolidayCells {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

			AddHoliday(DateTime.Today);
		}
		private WorkDaysCollection Holidays { get { return schedulerControl1.WorkDays; } }

		private void btnAddHoliday_Click(object sender, EventArgs e) {
			DayIntervalCollection days = new DayIntervalCollection();
			days.Add(schedulerControl1.SelectedInterval);

			schedulerControl1.BeginUpdate();
			try {
				for (int i = 0; i < days.Count; i++)
					AddHoliday(days[i].Start);
			} finally {
				schedulerControl1.EndUpdate();
			}
			 
		}
		private void AddHoliday(DateTime holidayDate) {
			TimeInterval interval = new TimeInterval(holidayDate, TimeSpan.FromDays(1));
			if (!IsHoliday(interval))
				Holidays.AddHoliday(holidayDate, string.Format("Holiday-{0}", holidayDate.ToShortDateString()));
		}
		private bool IsHoliday(TimeInterval interval) {
			int count = Holidays.Count;
			for (int i = 0; i < count; i++) {
				Holiday holiday = Holidays[i] as Holiday;
				if (holiday != null) {
					TimeInterval holidayInterval = new TimeInterval(holiday.Date, TimeSpan.FromDays(1));
					if (holidayInterval.IntersectsWithExcludingBounds(interval))
						return true;
				}
			}
			return false;
		}
		private void schedulerControl1_CustomDrawTimeCell(object sender, CustomDrawObjectEventArgs e) {
			SchedulerViewCellBase cell = e.ObjectInfo as SchedulerViewCellBase;
			if (cell != null && IsHoliday(cell.Interval)) {
				cell.Appearance.BackColor = Color.Tomato;
			}
		}

	}
}