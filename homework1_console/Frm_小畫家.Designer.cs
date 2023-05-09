namespace homework1_console
{
    partial class Frm_小畫家
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
            this.btnColor = new System.Windows.Forms.Button();
            this.labColor = new System.Windows.Forms.Label();
            this.trkPenSize = new System.Windows.Forms.TrackBar();
            this.labPenSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkPenSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColor.Location = new System.Drawing.Point(1190, 42);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(242, 64);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "筆刷顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // labColor
            // 
            this.labColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labColor.Location = new System.Drawing.Point(1190, 126);
            this.labColor.Name = "labColor";
            this.labColor.Size = new System.Drawing.Size(242, 65);
            this.labColor.TabIndex = 1;
            // 
            // trkPenSize
            // 
            this.trkPenSize.BackColor = System.Drawing.SystemColors.Control;
            this.trkPenSize.Location = new System.Drawing.Point(1285, 220);
            this.trkPenSize.Maximum = 100;
            this.trkPenSize.Minimum = 1;
            this.trkPenSize.Name = "trkPenSize";
            this.trkPenSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkPenSize.Size = new System.Drawing.Size(90, 358);
            this.trkPenSize.TabIndex = 2;
            this.trkPenSize.Value = 1;
            this.trkPenSize.ValueChanged += new System.EventHandler(this.trackPenSize_ValueChanged);
            // 
            // labPenSize
            // 
            this.labPenSize.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPenSize.Location = new System.Drawing.Point(1248, 581);
            this.labPenSize.Name = "labPenSize";
            this.labPenSize.Size = new System.Drawing.Size(147, 48);
            this.labPenSize.TabIndex = 3;
            this.labPenSize.Text = "1";
            this.labPenSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_小畫家
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 1121);
            this.Controls.Add(this.labPenSize);
            this.Controls.Add(this.trkPenSize);
            this.Controls.Add(this.labColor);
            this.Controls.Add(this.btnColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_小畫家";
            this.Text = "Frm_小畫家";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_小畫家_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_小畫家_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_小畫家_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trkPenSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label labColor;
        private System.Windows.Forms.TrackBar trkPenSize;
        private System.Windows.Forms.Label labPenSize;
    }
}