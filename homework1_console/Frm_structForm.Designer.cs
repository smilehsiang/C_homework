namespace homework1_console
{
    partial class Frm_structForm
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
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCn = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.scoreBox = new System.Windows.Forms.GroupBox();
            this.labMinMax = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.scoreBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(58, 58);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labCn
            // 
            this.labCn.AutoSize = true;
            this.labCn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCn.Location = new System.Drawing.Point(58, 103);
            this.labCn.Name = "labCn";
            this.labCn.Size = new System.Drawing.Size(67, 24);
            this.labCn.TabIndex = 1;
            this.labCn.Text = "國文：";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(58, 150);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(67, 24);
            this.labEn.TabIndex = 2;
            this.labEn.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(58, 197);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(120, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 33);
            this.txtName.TabIndex = 4;
            // 
            // txtCn
            // 
            this.txtCn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCn.Location = new System.Drawing.Point(120, 102);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(116, 33);
            this.txtCn.TabIndex = 5;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEn.Location = new System.Drawing.Point(120, 148);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(116, 33);
            this.txtEn.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(120, 195);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(116, 33);
            this.txtMath.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(27, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(163, 265);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 32);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // scoreBox
            // 
            this.scoreBox.Controls.Add(this.labMinMax);
            this.scoreBox.Controls.Add(this.labShow);
            this.scoreBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scoreBox.Location = new System.Drawing.Point(316, 21);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(262, 297);
            this.scoreBox.TabIndex = 10;
            this.scoreBox.TabStop = false;
            this.scoreBox.Text = "成績";
            // 
            // labMinMax
            // 
            this.labMinMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMinMax.Location = new System.Drawing.Point(6, 205);
            this.labMinMax.Name = "labMinMax";
            this.labMinMax.Size = new System.Drawing.Size(248, 81);
            this.labMinMax.TabIndex = 1;
            // 
            // labShow
            // 
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Location = new System.Drawing.Point(7, 27);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(248, 173);
            this.labShow.TabIndex = 0;
            // 
            // btnMinMax
            // 
            this.btnMinMax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinMax.Location = new System.Drawing.Point(370, 329);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(153, 32);
            this.btnMinMax.TabIndex = 11;
            this.btnMinMax.Text = "最高分/最低分科目";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // Frm_structForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 389);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCn);
            this.Controls.Add(this.labName);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Frm_structForm";
            this.Text = "科目最高分及最低分";
            this.scoreBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCn;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCn;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox scoreBox;
        private System.Windows.Forms.Label labMinMax;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button btnMinMax;
    }
}