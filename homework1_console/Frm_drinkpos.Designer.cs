namespace homework1_console
{
    partial class Frm_drinkpos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_drinkpos));
            this.btname = new System.Windows.Forms.Button();
            this.btnvie = new System.Windows.Forms.Button();
            this.btnmocha = new System.Windows.Forms.Button();
            this.btncoco = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.labmenu = new System.Windows.Forms.Label();
            this.labprice = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labtotalprice = new System.Windows.Forms.Label();
            this.labmethod = new System.Windows.Forms.Label();
            this.labcard = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.lablist = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.labShowList = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btname
            // 
            this.btname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btname.BackgroundImage")));
            this.btname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btname.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btname.Location = new System.Drawing.Point(102, 166);
            this.btname.Margin = new System.Windows.Forms.Padding(6);
            this.btname.Name = "btname";
            this.btname.Size = new System.Drawing.Size(208, 240);
            this.btname.TabIndex = 0;
            this.btname.Text = "  美式    咖啡\r\n100元\r\n";
            this.btname.UseVisualStyleBackColor = true;
            this.btname.Click += new System.EventHandler(this.btname_Click);
            // 
            // btnvie
            // 
            this.btnvie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvie.BackgroundImage")));
            this.btnvie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvie.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnvie.Location = new System.Drawing.Point(362, 166);
            this.btnvie.Margin = new System.Windows.Forms.Padding(6);
            this.btnvie.Name = "btnvie";
            this.btnvie.Size = new System.Drawing.Size(208, 240);
            this.btnvie.TabIndex = 1;
            this.btnvie.Text = "維也納\r\n咖啡\r\n150元";
            this.btnvie.UseVisualStyleBackColor = true;
            this.btnvie.Click += new System.EventHandler(this.btnvie_Click);
            // 
            // btnmocha
            // 
            this.btnmocha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmocha.BackgroundImage")));
            this.btnmocha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmocha.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmocha.Location = new System.Drawing.Point(102, 446);
            this.btnmocha.Margin = new System.Windows.Forms.Padding(6);
            this.btnmocha.Name = "btnmocha";
            this.btnmocha.Size = new System.Drawing.Size(208, 240);
            this.btnmocha.TabIndex = 5;
            this.btnmocha.Text = "摩卡\r\n咖啡\r\n140元\r\n";
            this.btnmocha.UseVisualStyleBackColor = true;
            this.btnmocha.Click += new System.EventHandler(this.btnmocha_Click);
            // 
            // btncoco
            // 
            this.btncoco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncoco.BackgroundImage")));
            this.btncoco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncoco.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncoco.Location = new System.Drawing.Point(362, 446);
            this.btncoco.Margin = new System.Windows.Forms.Padding(6);
            this.btncoco.Name = "btncoco";
            this.btncoco.Size = new System.Drawing.Size(208, 240);
            this.btncoco.TabIndex = 6;
            this.btncoco.Text = "醇可可\r\n120元\r\n";
            this.btncoco.UseVisualStyleBackColor = true;
            this.btncoco.Click += new System.EventHandler(this.btncoco_Click);
            // 
            // labmenu
            // 
            this.labmenu.BackColor = System.Drawing.Color.Transparent;
            this.labmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labmenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labmenu.Location = new System.Drawing.Point(76, 84);
            this.labmenu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labmenu.Name = "labmenu";
            this.labmenu.Size = new System.Drawing.Size(528, 642);
            this.labmenu.TabIndex = 7;
            this.labmenu.Text = "菜單MENU";
            // 
            // labprice
            // 
            this.labprice.BackColor = System.Drawing.Color.Transparent;
            this.labprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labprice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labprice.Location = new System.Drawing.Point(644, 84);
            this.labprice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labprice.Name = "labprice";
            this.labprice.Size = new System.Drawing.Size(528, 238);
            this.labprice.TabIndex = 8;
            this.labprice.Text = "總金額 Total Price";
            // 
            // labtotalprice
            // 
            this.labtotalprice.BackColor = System.Drawing.SystemColors.ControlText;
            this.labtotalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labtotalprice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtotalprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labtotalprice.Location = new System.Drawing.Point(693, 166);
            this.labtotalprice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labtotalprice.Name = "labtotalprice";
            this.labtotalprice.Size = new System.Drawing.Size(431, 106);
            this.labtotalprice.TabIndex = 9;
            this.labtotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labmethod
            // 
            this.labmethod.BackColor = System.Drawing.Color.Transparent;
            this.labmethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labmethod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labmethod.Location = new System.Drawing.Point(644, 488);
            this.labmethod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labmethod.Name = "labmethod";
            this.labmethod.Size = new System.Drawing.Size(528, 238);
            this.labmethod.TabIndex = 10;
            this.labmethod.Text = " 付款方式Payment Method";
            // 
            // labcard
            // 
            this.labcard.AutoSize = true;
            this.labcard.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcard.Location = new System.Drawing.Point(897, 674);
            this.labcard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labcard.Name = "labcard";
            this.labcard.Size = new System.Drawing.Size(249, 33);
            this.labcard.TabIndex = 13;
            this.labcard.Text = "信用卡可享九折優惠";
            // 
            // lablist
            // 
            this.lablist.BackColor = System.Drawing.Color.Transparent;
            this.lablist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lablist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lablist.Location = new System.Drawing.Point(1187, 84);
            this.lablist.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lablist.Name = "lablist";
            this.lablist.Size = new System.Drawing.Size(492, 642);
            this.lablist.TabIndex = 14;
            this.lablist.Text = "購物清單Shopping List";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(1450, 620);
            this.btnclear.Margin = new System.Windows.Forms.Padding(6);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(202, 88);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "清除清單";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // labShowList
            // 
            this.labShowList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labShowList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowList.Location = new System.Drawing.Point(1213, 152);
            this.labShowList.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labShowList.Name = "labShowList";
            this.labShowList.Size = new System.Drawing.Size(433, 448);
            this.labShowList.TabIndex = 17;
            this.labShowList.Text = "尚未點餐";
            this.labShowList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(693, 555);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(196, 100);
            this.btnCash.TabIndex = 18;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCard.Location = new System.Drawing.Point(928, 555);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(196, 100);
            this.btnCard.TabIndex = 19;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // Frm_drinkpos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1808, 900);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.labShowList);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lablist);
            this.Controls.Add(this.labcard);
            this.Controls.Add(this.labmethod);
            this.Controls.Add(this.labtotalprice);
            this.Controls.Add(this.labprice);
            this.Controls.Add(this.btnmocha);
            this.Controls.Add(this.btnvie);
            this.Controls.Add(this.btncoco);
            this.Controls.Add(this.btname);
            this.Controls.Add(this.labmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_drinkpos";
            this.Text = "Drink Menu";
            this.Load += new System.EventHandler(this.Frm_drinkpos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btname;
        private System.Windows.Forms.Button btnvie;
        private System.Windows.Forms.Button btnmocha;
        private System.Windows.Forms.Button btncoco;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label labmenu;
        private System.Windows.Forms.Label labprice;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labtotalprice;
        private System.Windows.Forms.Label labmethod;
        private System.Windows.Forms.Label labcard;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label lablist;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label labShowList;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
    }
}