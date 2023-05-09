namespace homework1_console
{
    partial class Frm_sayhello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_sayhello));
            this.name = new System.Windows.Forms.Label();
            this.englishname = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.constellations = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtenglishname = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtconstellation = new System.Windows.Forms.TextBox();
            this.hello = new System.Windows.Forms.Button();
            this.Hi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.Window;
            this.name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.ForeColor = System.Drawing.Color.Gold;
            this.name.Location = new System.Drawing.Point(282, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 24);
            this.name.TabIndex = 0;
            this.name.Text = "姓名:";
            // 
            // englishname
            // 
            this.englishname.AutoSize = true;
            this.englishname.BackColor = System.Drawing.SystemColors.Window;
            this.englishname.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.englishname.ForeColor = System.Drawing.Color.Gold;
            this.englishname.Location = new System.Drawing.Point(244, 114);
            this.englishname.Name = "englishname";
            this.englishname.Size = new System.Drawing.Size(91, 24);
            this.englishname.TabIndex = 1;
            this.englishname.Text = "英文名字:";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.BackColor = System.Drawing.SystemColors.Window;
            this.sex.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sex.ForeColor = System.Drawing.Color.Gold;
            this.sex.Location = new System.Drawing.Point(282, 162);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(53, 24);
            this.sex.TabIndex = 2;
            this.sex.Text = "性別:";
            // 
            // constellations
            // 
            this.constellations.AutoSize = true;
            this.constellations.BackColor = System.Drawing.SystemColors.Window;
            this.constellations.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.constellations.ForeColor = System.Drawing.Color.Gold;
            this.constellations.Location = new System.Drawing.Point(282, 211);
            this.constellations.Name = "constellations";
            this.constellations.Size = new System.Drawing.Size(53, 24);
            this.constellations.TabIndex = 3;
            this.constellations.Text = "星座:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtname.Location = new System.Drawing.Point(341, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(150, 29);
            this.txtname.TabIndex = 4;
            // 
            // txtenglishname
            // 
            this.txtenglishname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtenglishname.Location = new System.Drawing.Point(341, 111);
            this.txtenglishname.Name = "txtenglishname";
            this.txtenglishname.Size = new System.Drawing.Size(150, 29);
            this.txtenglishname.TabIndex = 5;
            // 
            // txtsex
            // 
            this.txtsex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtsex.Location = new System.Drawing.Point(341, 159);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(150, 29);
            this.txtsex.TabIndex = 6;
            // 
            // txtconstellation
            // 
            this.txtconstellation.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtconstellation.Location = new System.Drawing.Point(341, 211);
            this.txtconstellation.Name = "txtconstellation";
            this.txtconstellation.Size = new System.Drawing.Size(150, 29);
            this.txtconstellation.TabIndex = 7;
            // 
            // hello
            // 
            this.hello.BackColor = System.Drawing.Color.Gold;
            this.hello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hello.FlatAppearance.BorderSize = 0;
            this.hello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hello.ForeColor = System.Drawing.Color.White;
            this.hello.Location = new System.Drawing.Point(245, 295);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(91, 38);
            this.hello.TabIndex = 8;
            this.hello.Text = "Say Hello";
            this.hello.UseVisualStyleBackColor = false;
            this.hello.Click += new System.EventHandler(this.hello_Click);
            // 
            // Hi
            // 
            this.Hi.BackColor = System.Drawing.Color.Gold;
            this.Hi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hi.FlatAppearance.BorderSize = 0;
            this.Hi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hi.ForeColor = System.Drawing.Color.White;
            this.Hi.Location = new System.Drawing.Point(461, 295);
            this.Hi.Name = "Hi";
            this.Hi.Size = new System.Drawing.Size(91, 38);
            this.Hi.TabIndex = 9;
            this.Hi.Text = "Say Hi";
            this.Hi.UseVisualStyleBackColor = false;
            this.Hi.Click += new System.EventHandler(this.Hi_Click);
            // 
            // Frm_sayhello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hi);
            this.Controls.Add(this.hello);
            this.Controls.Add(this.txtconstellation);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.txtenglishname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.constellations);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.englishname);
            this.Controls.Add(this.name);
            this.Name = "Frm_sayhello";
            this.Text = "請做自我介紹吧！";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label englishname;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label constellations;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtenglishname;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtconstellation;
        private System.Windows.Forms.Button hello;
        private System.Windows.Forms.Button Hi;
    }
}

