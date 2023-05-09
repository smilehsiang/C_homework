namespace homework1_console
{
    partial class Frm_studentGrade
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
            this.labName = new System.Windows.Forms.Label();
            this.labCn = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labMa = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCn = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRmAdd = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnAdd20 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvStuDetails = new System.Windows.Forms.ListView();
            this.labTotalSta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(11, 30);
            this.labName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(78, 28);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labCn
            // 
            this.labCn.AutoSize = true;
            this.labCn.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCn.Location = new System.Drawing.Point(11, 78);
            this.labCn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labCn.Name = "labCn";
            this.labCn.Size = new System.Drawing.Size(78, 28);
            this.labCn.TabIndex = 1;
            this.labCn.Text = "國文：";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(11, 128);
            this.labEn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(78, 28);
            this.labEn.TabIndex = 2;
            this.labEn.Text = "英文：";
            // 
            // labMa
            // 
            this.labMa.AutoSize = true;
            this.labMa.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMa.Location = new System.Drawing.Point(11, 178);
            this.labMa.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labMa.Name = "labMa";
            this.labMa.Size = new System.Drawing.Size(78, 28);
            this.labMa.TabIndex = 3;
            this.labMa.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(77, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(92, 36);
            this.txtName.TabIndex = 4;
            // 
            // txtCn
            // 
            this.txtCn.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCn.Location = new System.Drawing.Point(77, 76);
            this.txtCn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(92, 36);
            this.txtCn.TabIndex = 5;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEn.Location = new System.Drawing.Point(77, 127);
            this.txtEn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(92, 36);
            this.txtEn.TabIndex = 6;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMa.Location = new System.Drawing.Point(77, 177);
            this.txtMa.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(92, 36);
            this.txtMa.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(33, 223);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRmAdd
            // 
            this.btnRmAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRmAdd.Location = new System.Drawing.Point(33, 267);
            this.btnRmAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnRmAdd.Name = "btnRmAdd";
            this.btnRmAdd.Size = new System.Drawing.Size(114, 34);
            this.btnRmAdd.TabIndex = 9;
            this.btnRmAdd.Text = "隨機儲存資料";
            this.btnRmAdd.UseVisualStyleBackColor = true;
            this.btnRmAdd.Click += new System.EventHandler(this.btnRmAdd_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(33, 312);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(114, 34);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnAdd20
            // 
            this.btnAdd20.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd20.Location = new System.Drawing.Point(33, 434);
            this.btnAdd20.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAdd20.Name = "btnAdd20";
            this.btnAdd20.Size = new System.Drawing.Size(114, 34);
            this.btnAdd20.TabIndex = 11;
            this.btnAdd20.Text = "隨機加入20筆";
            this.btnAdd20.UseVisualStyleBackColor = true;
            this.btnAdd20.Click += new System.EventHandler(this.btnAdd20_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(33, 391);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 34);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "重設所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvStuDetails
            // 
            this.lvStuDetails.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvStuDetails.GridLines = true;
            this.lvStuDetails.HideSelection = false;
            this.lvStuDetails.Location = new System.Drawing.Point(183, 12);
            this.lvStuDetails.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lvStuDetails.Name = "lvStuDetails";
            this.lvStuDetails.Size = new System.Drawing.Size(532, 326);
            this.lvStuDetails.TabIndex = 15;
            this.lvStuDetails.UseCompatibleStateImageBehavior = false;
            this.lvStuDetails.View = System.Windows.Forms.View.Details;
            this.lvStuDetails.SelectedIndexChanged += new System.EventHandler(this.lvStuDetails_SelectedIndexChanged);
            // 
            // labTotalSta
            // 
            this.labTotalSta.BackColor = System.Drawing.Color.White;
            this.labTotalSta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotalSta.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalSta.Location = new System.Drawing.Point(183, 350);
            this.labTotalSta.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labTotalSta.Name = "labTotalSta";
            this.labTotalSta.Size = new System.Drawing.Size(531, 132);
            this.labTotalSta.TabIndex = 16;
            // 
            // Frm_studentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 496);
            this.Controls.Add(this.labTotalSta);
            this.Controls.Add(this.lvStuDetails);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd20);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRmAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMa);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCn);
            this.Controls.Add(this.labName);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Frm_studentGrade";
            this.Text = "Frm_studentGrade";
            this.Load += new System.EventHandler(this.Frm_studentGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCn;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labMa;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCn;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRmAdd;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnAdd20;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvStuDetails;
        private System.Windows.Forms.Label labTotalSta;
    }
}