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
    public partial class Frm_screenSaver : Form
    {
        public Frm_screenSaver()
        {
            InitializeComponent();
        }
        int moveX = 5;
        int moveY = 8;
        private void Frm_screenSaver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Random r = new Random();  
        private void timeSaver_Tick(object sender, EventArgs e)
        {
            picSaver.Left += moveX;
            picSaver.Top += moveY;

            if (picSaver.Top + picSaver.Height > this.Height)
            {
                if (moveX > 0 && moveY > 0) /*圖片從左上碰到底部時*/
                {
                    moveX = 5;
                    moveY = -moveY;
                }
                if (moveX < 0 && moveY > 0) /*圖片從右上碰到底部時*/
                {
                    moveX = -moveY;
                    moveY = -moveY;
                }
            }
            if (picSaver.Left + picSaver.Width >= this.Width)
            {
                if (moveX > 0 && moveY > 0)
                {
                    moveX = -moveX;
                    moveY = 8;
                }
                if (moveX > 0 && moveY < 0)
                {
                    moveX = -moveX;
                    moveY = -moveY;
                }

            }
            if (picSaver.Left <= 0)
            {
                if (moveX < 0 && moveY < 0)
                {
                    moveX = 5;
                    moveY = -moveY;
                }
                if (moveX < 0 && moveY > 0)
                {
                    moveX = 5;
                    moveY = 8;
                }
            }
            if (picSaver.Top <= 0)
            {
                if (moveX < 0 && moveY < 0) /*圖片從右下碰到上邊緣*/
                {
                    moveX = -moveX;
                    moveY = 8;
                }
                if (moveX > 0 && moveY < 0) /*從左下方碰到上邊緣*/
                {
                    moveX = 5;
                    moveY = 8;
                }
            }

            //if(picSaver.Left<0 || picSaver.Left+picSaver.Width>this.Width)
            //{
            //    moveX = -moveX;
            //}
            //if (picSaver.Top < 0 || picSaver.Top + picSaver.Height > this.Height)
            //{ 
            //    moveY = -moveY;   
            //}

            //if (picSaver.Right < 0) 
            //{ 
            //    picSaver.Left=ClientSize.Width;
            //    picSaver.Top = r.Next(this.Height - picSaver.Height);
            //}

            //if (picSaver.Bottom < 0)
            //{
            //    picSaver.Top=ClientSize.Height;
            //    picSaver.Left = r.Next(this.Width - picSaver.Height);
            //}
        }
    }
}
