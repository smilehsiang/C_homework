using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; /*匯入檔案輸出或輸入的涵式庫*/
using System.Drawing.Design;

namespace homework1_console
{
    public partial class Frm_note : Form
    {
        public Frm_note()
        {
            InitializeComponent();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (開啟檔案.ShowDialog() == DialogResult.OK)
            { 
            txtBox.Text=File.ReadAllText(開啟檔案.FileName,Encoding.Default);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (儲存檔案.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(儲存檔案.FileName, txtBox.Text, Encoding.Default);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (開啟檔案.FileName == "")
            {
                if (儲存檔案.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(儲存檔案.FileName, txtBox.Text, Encoding.Default);
                }
            }
            else 
            {
                File.WriteAllText(開啟檔案.FileName, txtBox.Text, Encoding.Default);
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            開啟檔案.FileName = "";
            txtBox.Clear();   
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //寫成this.Close();也是可以，但意義不同，
            //this是指這個表單，一個專案可能有多個表單，這樣未必關得了其他表單。
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.SelectAll();   
            
        }


        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            字型.ShowDialog();
            txtBox.Font=字型.Font;
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            顏色.ShowDialog();
            txtBox.ForeColor = 顏色.Color;
        }

        private void 轉成大寫_Click(object sender, EventArgs e)
        {
            string str = txtBox.Text;
            string strUpper=str.ToUpper();
            txtBox.Text= strUpper;
        }

        private void 轉成小寫_Click(object sender, EventArgs e)
        {
            string str=txtBox.Text;
            string strLower=str.ToLower();
            txtBox .Text= strLower;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void 自動換行_Click(object sender, EventArgs e)
        {
            if (自動換行.Checked == false)
            {
                自動換行.Checked = true;
                txtBox.WordWrap = true;
            }
            else
            {
                自動換行.Checked = false;
                txtBox.WordWrap = false;
            }
        }

        private void 時間_Tick(object sender, EventArgs e)
        {
            time.Text = System.DateTime.Now.ToString();
        }

        private void 紅色_Click(object sender, EventArgs e)
        {
            txtBox.ForeColor = Color.Red;
        }

        private void 綠色_Click(object sender, EventArgs e)
        {
            txtBox.ForeColor = Color.Green;
        }

        private void 藍色_Click(object sender, EventArgs e)
        {
            txtBox.ForeColor = Color.Blue;
        }

        private void 黑色_Click(object sender, EventArgs e)
        {
            txtBox.ForeColor = Color.Black;
        }

        private void 關於_Click(object sender, EventArgs e)
        {
            MessageBox.Show("這是翔翔製作的記事本，請安心服用！","關於");
        }

        private void 新增tool_Click(object sender, EventArgs e)
        {
            開啟檔案.FileName = "";
            txtBox.Clear();
        }

        private void 開啟tool_Click(object sender, EventArgs e)
        {
            if (開啟檔案.ShowDialog() == DialogResult.OK)
            {
                txtBox.Text = File.ReadAllText(開啟檔案.FileName, Encoding.Default);
            }
        }

        private void 儲存tool_Click(object sender, EventArgs e)
        {
            if (開啟檔案.FileName == "")
            {
                if (儲存檔案.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(儲存檔案.FileName, txtBox.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(開啟檔案.FileName, txtBox.Text, Encoding.Default);
            }
        }

        private void 剪下tool_Click(object sender, EventArgs e)
        {
            txtBox.Cut();
        }

        private void 複製tool_Click(object sender, EventArgs e)
        {
            txtBox.Copy();  
        }

        private void 貼上tool_Click(object sender, EventArgs e)
        {
            txtBox.Paste(); 
        }

        private void 說明tool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("這是翔翔製作的記事本，請安心服用！", "關於");
        }

       
    }
}
