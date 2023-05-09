namespace homework1_console
{
    partial class Frm_clock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nowTime = new System.Windows.Forms.Timer(this.components);
            this.gbAlarm = new System.Windows.Forms.GroupBox();
            this.Time = new System.Windows.Forms.Label();
            this.checkAlarm = new System.Windows.Forms.CheckBox();
            this.comboSec = new System.Windows.Forms.ComboBox();
            this.comboHour = new System.Windows.Forms.ComboBox();
            this.labSec = new System.Windows.Forms.Label();
            this.labHour = new System.Windows.Forms.Label();
            this.labSetTime = new System.Windows.Forms.Label();
            this.showTime = new System.Windows.Forms.Timer(this.components);
            this.gbAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // nowTime
            // 
            this.nowTime.Interval = 1000;
            this.nowTime.Tick += new System.EventHandler(this.nowTime_Tick);
            // 
            // gbAlarm
            // 
            this.gbAlarm.Controls.Add(this.Time);
            this.gbAlarm.Controls.Add(this.checkAlarm);
            this.gbAlarm.Controls.Add(this.comboSec);
            this.gbAlarm.Controls.Add(this.comboHour);
            this.gbAlarm.Controls.Add(this.labSec);
            this.gbAlarm.Controls.Add(this.labHour);
            this.gbAlarm.Controls.Add(this.labSetTime);
            this.gbAlarm.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbAlarm.Location = new System.Drawing.Point(136, 152);
            this.gbAlarm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbAlarm.Name = "gbAlarm";
            this.gbAlarm.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbAlarm.Size = new System.Drawing.Size(895, 548);
            this.gbAlarm.TabIndex = 1;
            this.gbAlarm.TabStop = false;
            this.gbAlarm.Text = "鬧鐘";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Time.Location = new System.Drawing.Point(340, 106);
            this.Time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(158, 68);
            this.Time.TabIndex = 5;
            this.Time.Text = "Time";
            // 
            // checkAlarm
            // 
            this.checkAlarm.AutoSize = true;
            this.checkAlarm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkAlarm.Location = new System.Drawing.Point(373, 390);
            this.checkAlarm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.checkAlarm.Name = "checkAlarm";
            this.checkAlarm.Size = new System.Drawing.Size(145, 44);
            this.checkAlarm.TabIndex = 2;
            this.checkAlarm.Text = "設鬧鐘";
            this.checkAlarm.UseVisualStyleBackColor = true;
            this.checkAlarm.CheckedChanged += new System.EventHandler(this.checkAlarm_CheckedChanged);
            // 
            // comboSec
            // 
            this.comboSec.DropDownHeight = 100;
            this.comboSec.FormattingEnabled = true;
            this.comboSec.IntegralHeight = false;
            this.comboSec.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboSec.Location = new System.Drawing.Point(572, 268);
            this.comboSec.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboSec.Name = "comboSec";
            this.comboSec.Size = new System.Drawing.Size(115, 63);
            this.comboSec.TabIndex = 4;
            // 
            // comboHour
            // 
            this.comboHour.DropDownHeight = 100;
            this.comboHour.FormattingEnabled = true;
            this.comboHour.IntegralHeight = false;
            this.comboHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboHour.Location = new System.Drawing.Point(347, 268);
            this.comboHour.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboHour.Name = "comboHour";
            this.comboHour.Size = new System.Drawing.Size(115, 63);
            this.comboHour.TabIndex = 3;
            // 
            // labSec
            // 
            this.labSec.AutoSize = true;
            this.labSec.Location = new System.Drawing.Point(715, 276);
            this.labSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSec.Name = "labSec";
            this.labSec.Size = new System.Drawing.Size(67, 55);
            this.labSec.TabIndex = 2;
            this.labSec.Text = "分";
            // 
            // labHour
            // 
            this.labHour.AutoSize = true;
            this.labHour.Location = new System.Drawing.Point(479, 276);
            this.labHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(67, 55);
            this.labHour.TabIndex = 1;
            this.labHour.Text = "時";
            // 
            // labSetTime
            // 
            this.labSetTime.AutoSize = true;
            this.labSetTime.Location = new System.Drawing.Point(95, 272);
            this.labSetTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSetTime.Name = "labSetTime";
            this.labSetTime.Size = new System.Drawing.Size(239, 55);
            this.labSetTime.TabIndex = 0;
            this.labSetTime.Text = "設定時間：";
            // 
            // showTime
            // 
            this.showTime.Enabled = true;
            this.showTime.Tick += new System.EventHandler(this.showTime_Tick_1);
            // 
            // Frm_clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 884);
            this.Controls.Add(this.gbAlarm);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Frm_clock";
            this.Text = "Frm_clock";
            this.Load += new System.EventHandler(this.Frm_clock_Load);
            this.gbAlarm.ResumeLayout(false);
            this.gbAlarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer nowTime;
        private System.Windows.Forms.GroupBox gbAlarm;
        private System.Windows.Forms.Label labSetTime;
        private System.Windows.Forms.ComboBox comboHour;
        private System.Windows.Forms.Label labSec;
        private System.Windows.Forms.Label labHour;
        private System.Windows.Forms.ComboBox comboSec;
        private System.Windows.Forms.CheckBox checkAlarm;
        private System.Windows.Forms.Timer showTime;
        private System.Windows.Forms.Label Time;
    }
}