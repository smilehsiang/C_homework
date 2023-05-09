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
    public partial class Frm_mycalc : Form
    {
        public Frm_mycalc()
        {
            InitializeComponent();
        }

        decimal number1;
        decimal number2;
        decimal num;
        bool isNum1;
        bool isNum2;


        //private void Condition()
        //{

        //   isNum1 = decimal.TryParse(txtnum1.Text, out num);
        //   isNum2 = decimal.TryParse(txtnum2.Text, out num);
        //   number1 = decimal.Parse(txtnum1.Text);
        //   number2= decimal.Parse(txtnum2.Text);

        //}
        
        private void add_Click(object sender, EventArgs e)
        {
            
            isNum1 = decimal.TryParse(txtnum1.Text, out num);
            isNum2 = decimal.TryParse(txtnum2.Text, out num);
            

            if (isNum1 && isNum2)
            {
               //number1 & 2放在if外面會出現例外錯誤，因為也許輸入的不是數字，
               //跑到number1&2的時候永遠不會轉成數字
                number1 = decimal.Parse(txtnum1.Text);
                number2 = decimal.Parse(txtnum2.Text);
                decimal Ans=decimal.Round(number1+number2,2);
                result.Text=Ans.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字！", "錯誤訊息", MessageBoxButtons.OK);
            }

            //double a = double.Parse(txtnum1.Text);
            //double b = double.Parse(txtnum2.Text);
            //double c = a + b;
            //result.Text = c.ToString();
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            isNum1 = decimal.TryParse(txtnum1.Text, out num);
            isNum2 = decimal.TryParse(txtnum2.Text, out num);
            

            if (isNum1 && isNum2)
            {
                number1 = decimal.Parse(txtnum1.Text);
                number2 = decimal.Parse(txtnum2.Text);
                decimal Ans = decimal.Round(number1 - number2, 2);
                result.Text = Ans.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字！", "錯誤訊息", MessageBoxButtons.OK);
            }

            //double a = double.Parse(txtnum1.Text);
            //double b = double.Parse(txtnum2.Text);
            //double c = a - b;
            //result.Text = c.ToString();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            isNum1 = decimal.TryParse(txtnum1.Text, out num);
            isNum2 = decimal.TryParse(txtnum2.Text, out num);


            if (isNum1 && isNum2)
            {
                number1 = decimal.Parse(txtnum1.Text);
                number2 = decimal.Parse(txtnum2.Text);
                decimal Ans = decimal.Round(number1 * number2, 2);
                result.Text = Ans.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字！", "錯誤訊息", MessageBoxButtons.OK);
            }
            //double a = double.Parse(txtnum1.Text);
            //double b = double.Parse(txtnum2.Text);
            //double c = a * b;
            //result.Text = c.ToString();
        }

        private void divided_Click(object sender, EventArgs e)
        {
            isNum1 = decimal.TryParse(txtnum1.Text, out num);
            isNum2 = decimal.TryParse(txtnum2.Text, out num);


            if (isNum1 && isNum2)
            {
                number1 = decimal.Parse(txtnum1.Text);
                number2 = decimal.Parse(txtnum2.Text);
                decimal Ans = decimal.Round(number1 / number2, 2);
                result.Text = Ans.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字！", "錯誤訊息", MessageBoxButtons.OK);
            }
            //decimal a = decimal.Parse(txtnum1.Text);
            //decimal b = decimal.Parse(txtnum2.Text);
            //decimal c = decimal.Round(a / b, 2);
            //result.Text = c.ToString();
        }


    }
}


