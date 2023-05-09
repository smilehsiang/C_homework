using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1_console
{
    public partial class Frm_sayhello : Form
    {
        public Frm_sayhello()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hello_Click(object sender, EventArgs e)
        {
            String Name = txtname.Text;
            String EnglishName = txtenglishname.Text;
            String Sex = txtsex.Text;
            String constellation = txtconstellation.Text;
            MessageBox.Show("Hello，我是" + Name + "，" + "\n\r" +
                "英文名字是" + EnglishName + "，" + "\n\r" +
                "性別是" + Sex + "，" + "\n\r" +
                "星座是" + constellation + "，" + "\n\r"+
                "很開心認識你!");
           }

        private void Hi_Click(object sender, EventArgs e)
        {
            String Name = txtname.Text;
            String EnglishName = txtenglishname.Text;
            String Sex = txtsex.Text;
            String constellation = txtconstellation.Text;
            MessageBox.Show("Hi，我是" + Name + "，" + "\n\r" +
                "英文名字是" + EnglishName + "，" + "\n\r" +
                "性別是" + Sex + "，" + "\n\r" +
                "星座是" + constellation + "，" + "\n\r" +
                "很開心認識你!");
        }
    }
}
