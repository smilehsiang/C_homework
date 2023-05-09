namespace homework1_console
{
    partial class Frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menu));
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
            this.btncash = new System.Windows.Forms.Button();
            this.btncard = new System.Windows.Forms.Button();
            this.labcard = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.lablist = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.labshowlist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btname
            // 
            this.btname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btname.BackgroundImage")));
            this.btname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btname.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btname.Location = new System.Drawing.Point(59, 80);
            this.btname.Name = "btname";
            this.btname.Size = new System.Drawing.Size(96, 120);
            this.btname.TabIndex = 0;
            this.btname.Text = "  美式    咖啡\r\n100元\r\n";
            this.btname.UseVisualStyleBackColor = true;
            // 
            // btnvie
            // 
            this.btnvie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvie.BackgroundImage")));
            this.btnvie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvie.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnvie.Location = new System.Drawing.Point(179, 80);
            this.btnvie.Name = "btnvie";
            this.btnvie.Size = new System.Drawing.Size(96, 120);
            this.btnvie.TabIndex = 1;
            this.btnvie.Text = "維也納\r\n咖啡\r\n150元";
            this.btnvie.UseVisualStyleBackColor = true;
            // 
            // btnmocha
            // 
            this.btnmocha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmocha.BackgroundImage")));
            this.btnmocha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmocha.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmocha.Location = new System.Drawing.Point(59, 220);
            this.btnmocha.Name = "btnmocha";
            this.btnmocha.Size = new System.Drawing.Size(96, 120);
            this.btnmocha.TabIndex = 5;
            this.btnmocha.Text = "摩卡\r\n咖啡\r\n140元\r\n";
            this.btnmocha.UseVisualStyleBackColor = true;
            // 
            // btncoco
            // 
            this.btncoco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncoco.BackgroundImage")));
            this.btncoco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncoco.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncoco.Location = new System.Drawing.Point(179, 220);
            this.btncoco.Name = "btncoco";
            this.btncoco.Size = new System.Drawing.Size(96, 120);
            this.btncoco.TabIndex = 6;
            this.btncoco.Text = "醇可可\r\n120元\r\n";
            this.btncoco.UseVisualStyleBackColor = true;
            // 
            // labmenu
            // 
            this.labmenu.BackColor = System.Drawing.Color.Transparent;
            this.labmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labmenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labmenu.Location = new System.Drawing.Point(47, 39);
            this.labmenu.Name = "labmenu";
            this.labmenu.Size = new System.Drawing.Size(245, 322);
            this.labmenu.TabIndex = 7;
            this.labmenu.Text = "菜單MENU";
            // 
            // labprice
            // 
            this.labprice.BackColor = System.Drawing.Color.Transparent;
            this.labprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labprice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labprice.Location = new System.Drawing.Point(309, 39);
            this.labprice.Name = "labprice";
            this.labprice.Size = new System.Drawing.Size(245, 120);
            this.labprice.TabIndex = 8;
            this.labprice.Text = "總金額 Total Price";
            // 
            // labtotalprice
            // 
            this.labtotalprice.BackColor = System.Drawing.SystemColors.ControlText;
            this.labtotalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labtotalprice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtotalprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labtotalprice.Location = new System.Drawing.Point(332, 80);
            this.labtotalprice.Name = "labtotalprice";
            this.labtotalprice.Size = new System.Drawing.Size(200, 54);
            this.labtotalprice.TabIndex = 9;
            this.labtotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labmethod
            // 
            this.labmethod.BackColor = System.Drawing.Color.Transparent;
            this.labmethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labmethod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labmethod.Location = new System.Drawing.Point(309, 241);
            this.labmethod.Name = "labmethod";
            this.labmethod.Size = new System.Drawing.Size(245, 120);
            this.labmethod.TabIndex = 10;
            this.labmethod.Text = " 付款方式Payment Method";
            // 
            // btncash
            // 
            this.btncash.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncash.Location = new System.Drawing.Point(323, 287);
            this.btncash.Name = "btncash";
            this.btncash.Size = new System.Drawing.Size(93, 44);
            this.btncash.TabIndex = 11;
            this.btncash.Text = "現金";
            this.btncash.UseVisualStyleBackColor = false;
            // 
            // btncard
            // 
            this.btncard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncard.Location = new System.Drawing.Point(439, 287);
            this.btncard.Name = "btncard";
            this.btncard.Size = new System.Drawing.Size(93, 44);
            this.btncard.TabIndex = 12;
            this.btncard.Text = "信用卡";
            this.btncard.UseVisualStyleBackColor = false;
            // 
            // labcard
            // 
            this.labcard.AutoSize = true;
            this.labcard.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcard.Location = new System.Drawing.Point(426, 334);
            this.labcard.Name = "labcard";
            this.labcard.Size = new System.Drawing.Size(125, 17);
            this.labcard.TabIndex = 13;
            this.labcard.Text = "信用卡可享九折優惠";
            // 
            // lablist
            // 
            this.lablist.BackColor = System.Drawing.Color.Transparent;
            this.lablist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lablist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lablist.Location = new System.Drawing.Point(560, 39);
            this.lablist.Name = "lablist";
            this.lablist.Size = new System.Drawing.Size(228, 322);
            this.lablist.TabIndex = 14;
            this.lablist.Text = "購物清單Shopping List";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(681, 307);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(93, 44);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "清除清單";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // labshowlist
            // 
            this.labshowlist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labshowlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labshowlist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labshowlist.Location = new System.Drawing.Point(572, 73);
            this.labshowlist.Name = "labshowlist";
            this.labshowlist.Size = new System.Drawing.Size(201, 225);
            this.labshowlist.TabIndex = 17;
            this.labshowlist.Text = "尚未點餐";
            // 
            // Frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labshowlist);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lablist);
            this.Controls.Add(this.labcard);
            this.Controls.Add(this.btncard);
            this.Controls.Add(this.btncash);
            this.Controls.Add(this.labmethod);
            this.Controls.Add(this.labtotalprice);
            this.Controls.Add(this.labprice);
            this.Controls.Add(this.btnmocha);
            this.Controls.Add(this.btnvie);
            this.Controls.Add(this.btncoco);
            this.Controls.Add(this.btname);
            this.Controls.Add(this.labmenu);
            this.Name = "Frm_menu";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btncash;
        private System.Windows.Forms.Button btncard;
        private System.Windows.Forms.Label labcard;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label lablist;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label labshowlist;
    }
}