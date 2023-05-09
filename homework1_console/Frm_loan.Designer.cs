namespace homework1_console
{
    partial class Frm_loan
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
            this.labLoan = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labInterestRate = new System.Windows.Forms.Label();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.Location = new System.Drawing.Point(97, 48);
            this.labLoan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(86, 24);
            this.labLoan.TabIndex = 0;
            this.labLoan.Text = "貸款金額";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(97, 87);
            this.labYear.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(81, 24);
            this.labYear.TabIndex = 1;
            this.labYear.Text = "期限(年)";
            // 
            // labInterestRate
            // 
            this.labInterestRate.AutoSize = true;
            this.labInterestRate.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInterestRate.Location = new System.Drawing.Point(97, 126);
            this.labInterestRate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labInterestRate.Name = "labInterestRate";
            this.labInterestRate.Size = new System.Drawing.Size(79, 24);
            this.labInterestRate.TabIndex = 2;
            this.labInterestRate.Text = "利率(%)";
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPayment.Location = new System.Drawing.Point(97, 164);
            this.labDownPayment.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(67, 24);
            this.labDownPayment.TabIndex = 3;
            this.labDownPayment.Text = "頭期款";
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoan.Location = new System.Drawing.Point(188, 48);
            this.txtLoan.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(95, 32);
            this.txtLoan.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(188, 87);
            this.txtYear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(95, 32);
            this.txtYear.TabIndex = 5;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInterestRate.Location = new System.Drawing.Point(188, 126);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(95, 32);
            this.txtInterestRate.TabIndex = 6;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPayment.Location = new System.Drawing.Point(188, 164);
            this.txtDownPayment.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(95, 32);
            this.txtDownPayment.TabIndex = 7;
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(69, 222);
            this.btnPMT.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(69, 36);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "月付額";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotalPrice.Location = new System.Drawing.Point(166, 222);
            this.btnTotalPrice.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(69, 36);
            this.btnTotalPrice.TabIndex = 9;
            this.btnTotalPrice.Text = "總付款";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(265, 222);
            this.btnReport.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(69, 36);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "報告";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Frm_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 298);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.labInterestRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labLoan);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Frm_loan";
            this.Text = "Frm_loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labInterestRate;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.Button btnReport;
    }
}