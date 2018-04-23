namespace CustomDrawHolidayCells {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
			this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
			this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
			this.btnAddHoliday = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
			this.SuspendLayout();
			// 
			// schedulerControl1
			// 
			this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
			this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.schedulerControl1.Location = new System.Drawing.Point(0, 51);
			this.schedulerControl1.Name = "schedulerControl1";
			this.schedulerControl1.Size = new System.Drawing.Size(775, 488);
			this.schedulerControl1.Start = new System.DateTime(2008, 8, 18, 0, 0, 0, 0);
			this.schedulerControl1.Storage = this.schedulerStorage1;
			this.schedulerControl1.TabIndex = 0;
			this.schedulerControl1.Text = "schedulerControl1";
			this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
			this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
			this.schedulerControl1.CustomDrawTimeCell += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.schedulerControl1_CustomDrawTimeCell);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAddHoliday);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(954, 51);
			this.panel1.TabIndex = 1;
			// 
			// dateNavigator1
			// 
			this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right;
			this.dateNavigator1.Location = new System.Drawing.Point(775, 51);
			this.dateNavigator1.Name = "dateNavigator1";
			this.dateNavigator1.SchedulerControl = this.schedulerControl1;
			this.dateNavigator1.Size = new System.Drawing.Size(179, 488);
			this.dateNavigator1.TabIndex = 2;
			this.dateNavigator1.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.MonthInfo;
			// 
			// btnAddHoliday
			// 
			this.btnAddHoliday.Location = new System.Drawing.Point(12, 12);
			this.btnAddHoliday.Name = "btnAddHoliday";
			this.btnAddHoliday.Size = new System.Drawing.Size(171, 23);
			this.btnAddHoliday.TabIndex = 0;
			this.btnAddHoliday.Text = "Set selected days as holidays";
			this.btnAddHoliday.UseVisualStyleBackColor = true;
			this.btnAddHoliday.Click += new System.EventHandler(this.btnAddHoliday_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 539);
			this.Controls.Add(this.schedulerControl1);
			this.Controls.Add(this.dateNavigator1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "How to paint holiday cells";
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
		private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAddHoliday;
		private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
	}
}

