using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1_console
{
    public partial class Frm_structForm : Form
    {
        public Frm_structForm()
        {
            InitializeComponent();
        }

        List<Score> IsScore=new List<Score>(); /*事先在Utility建立Score的結構*/

        
        void ShowScore()
        { 
        foreach (Score StuScore in IsScore) 
            {
                
                labShow.Text = $"姓名：{StuScore.Student}\n國文：{StuScore.CnScore}分\n" +
                    $"英文：{StuScore.Enscore}分\n數學：{StuScore.MathScore}分";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            labShow.Text = $"姓名：未知\n國文：0分\n英文：0分\n數學：0分\n";
            ShowScore();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            { 
            Score StuScore;
            StuScore.Student = txtName.Text;
            StuScore.CnScore = int.Parse(txtCn.Text);
            StuScore.Enscore = int.Parse(txtEn.Text);
            StuScore.MathScore = int.Parse(txtMath.Text);
            IsScore.Add(StuScore);
            }
            catch(FormatException)
            {
                MessageBox.Show("請輸入正確的資料喔！");
            }

            }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            foreach (Score StuScore in IsScore)
            {
                string[] subject = new string[] { "國文", "英文", "數學" };
                int[] arr = { StuScore.CnScore, StuScore.Enscore, StuScore.MathScore };
                int Max = arr[0];
                int Min = arr[0];
                int j = 0;
                int k = 0;

                for (int i = 0; i < 3; i++)
                {
                    if (arr[i] > Max)
                    { 
                        Max = arr[i];
                        j = i;
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    if (arr[i] < Min)
                    {
                       Min = arr[i];
                        k = i;
                    }
                }
                labMinMax.Text = $"最高科目成績：{subject[j]},{Max}分\n最低科目成績：{subject[k]},{Min}分";
                

            }
            
        }
    }
}
