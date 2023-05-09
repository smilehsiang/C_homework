namespace homework1_console
{
    partial class Frm_guessNumber
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
            this.labShow = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(142, 120);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(543, 47);
            this.labShow.TabIndex = 0;
            this.labShow.Text = "請從1~100之間猜出正確的數字";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(191, 285);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(152, 103);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "我猜";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnAns
            // 
            this.btnAns.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAns.Location = new System.Drawing.Point(443, 285);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(152, 103);
            this.btnAns.TabIndex = 2;
            this.btnAns.Text = "顯示答案";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // Frm_guessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 595);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.labShow);
            this.Name = "Frm_guessNumber";
            this.Text = "猜數字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnAns;
    }
}