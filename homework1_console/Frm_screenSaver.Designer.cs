namespace homework1_console
{
    partial class Frm_screenSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_screenSaver));
            this.picSaver = new System.Windows.Forms.PictureBox();
            this.timeSaver = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSaver)).BeginInit();
            this.SuspendLayout();
            // 
            // picSaver
            // 
            this.picSaver.Image = ((System.Drawing.Image)(resources.GetObject("picSaver.Image")));
            this.picSaver.Location = new System.Drawing.Point(21, 11);
            this.picSaver.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.picSaver.Name = "picSaver";
            this.picSaver.Size = new System.Drawing.Size(256, 276);
            this.picSaver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSaver.TabIndex = 0;
            this.picSaver.TabStop = false;
            // 
            // timeSaver
            // 
            this.timeSaver.Enabled = true;
            this.timeSaver.Tick += new System.EventHandler(this.timeSaver_Tick);
            // 
            // Frm_screenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 476);
            this.Controls.Add(this.picSaver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Frm_screenSaver";
            this.Text = "Frm_螢幕保護程式";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Frm_screenSaver_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picSaver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSaver;
        private System.Windows.Forms.Timer timeSaver;
    }
}