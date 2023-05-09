using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1_console
{
    public partial class Frm_guessNumber : Form
    {
        public Frm_guessNumber()
        {
            InitializeComponent();
        }

      
        int num;
        int min;
        int max;

        public void btnGuess_Click(object sender, EventArgs e)
        {
            
            Random rm = new Random(); /*建立亂數物件*/
            rightAns.ans = rm.Next(1, 100);/* Next是傳回指定範圍內的隨機整數*/
            min = 1;
            max = 100;
           

            do /*do,while至少執行一次*/
            {
                String inputBox = Interaction.InputBox("請輸入數字", "猜猜看吧！");
                bool strNum = int.TryParse(inputBox, out num);
                if (inputBox.Length==0)
                {
                    this.Close();
                    
                }
                if (strNum && num >= min && num <= max) /*如果輸入的是數字再轉成int*/
                {
                    if (num > rightAns.ans)
                    {
                        max = num;
                        labShow.Text = String.Empty;
                        labShow.Text = $"猜得太大了！\n正確數字在{min}和{max}之間~";
                    }
                    else if (num < rightAns.ans)
                    {
                        min = num;
                        labShow.Text = String.Empty;
                        labShow.Text = $"猜得太小了！\n正確數字在{min}和{max}之間~";
                    }
                    else if (num == rightAns.ans)
                    {
                        MessageBox.Show($"太棒了，你猜到{rightAns.ans}了！");
                        labShow.Text = $"你真會猜！";
                        break; /*這是無窮迴圈，所以要設break中止迴圈*/
                    }

                }
                else
                {
                    MessageBox.Show($"叫你輸入{min}~{max}的數字！");
                }


            }
            while (true);
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"正確答案是{rightAns.ans}！");
            
               
        }
    }
}
