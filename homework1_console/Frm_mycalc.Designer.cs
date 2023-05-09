namespace homework1_console
{
    partial class Frm_mycalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_mycalc));
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.ans = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.divided = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.Color.Sienna;
            this.num1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num1.ForeColor = System.Drawing.Color.Bisque;
            this.num1.Location = new System.Drawing.Point(150, 170);
            this.num1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(171, 61);
            this.num1.TabIndex = 0;
            this.num1.Text = "數字一";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.Color.Sienna;
            this.num2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num2.ForeColor = System.Drawing.Color.Bisque;
            this.num2.Location = new System.Drawing.Point(147, 290);
            this.num2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(171, 61);
            this.num2.TabIndex = 1;
            this.num2.Text = "數字二";
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnum1.ForeColor = System.Drawing.Color.Black;
            this.txtnum1.Location = new System.Drawing.Point(381, 164);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(221, 71);
            this.txtnum1.TabIndex = 2;
            this.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnum2.ForeColor = System.Drawing.Color.Black;
            this.txtnum2.Location = new System.Drawing.Point(381, 284);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(221, 71);
            this.txtnum2.TabIndex = 3;
            this.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.BackColor = System.Drawing.Color.Sienna;
            this.ans.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ans.ForeColor = System.Drawing.Color.Bisque;
            this.ans.Location = new System.Drawing.Point(178, 452);
            this.ans.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(123, 61);
            this.ans.TabIndex = 4;
            this.ans.Text = "答案";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SandyBrown;
            this.add.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add.ForeColor = System.Drawing.Color.SaddleBrown;
            this.add.Location = new System.Drawing.Point(674, 122);
            this.add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(89, 90);
            this.add.TabIndex = 6;
            this.add.Text = "加";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.SandyBrown;
            this.subtract.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subtract.ForeColor = System.Drawing.Color.SaddleBrown;
            this.subtract.Location = new System.Drawing.Point(776, 122);
            this.subtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(89, 90);
            this.subtract.TabIndex = 7;
            this.subtract.Text = "減";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.SandyBrown;
            this.mult.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mult.ForeColor = System.Drawing.Color.SaddleBrown;
            this.mult.Location = new System.Drawing.Point(674, 224);
            this.mult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(89, 90);
            this.mult.TabIndex = 8;
            this.mult.Text = "乘";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // divided
            // 
            this.divided.BackColor = System.Drawing.Color.SandyBrown;
            this.divided.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.divided.ForeColor = System.Drawing.Color.SaddleBrown;
            this.divided.Location = new System.Drawing.Point(776, 224);
            this.divided.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.divided.Name = "divided";
            this.divided.Size = new System.Drawing.Size(89, 90);
            this.divided.TabIndex = 9;
            this.divided.Text = "除";
            this.divided.UseVisualStyleBackColor = false;
            this.divided.Click += new System.EventHandler(this.divided_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(152, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "______________________________________________";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result.Location = new System.Drawing.Point(426, 446);
            this.result.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(85, 70);
            this.result.TabIndex = 11;
            this.result.Text = "？";
            // 
            // Frm_mycalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 706);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divided);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_mycalc";
            this.Text = "計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button divided;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
    }
}