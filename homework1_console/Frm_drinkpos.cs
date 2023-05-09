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
    public partial class Frm_drinkpos : Form
    {
        public Frm_drinkpos()
        {
            InitializeComponent();
        }

        int a, b, c, d, productAme, productVie, productMocha, productCoco = 0;
        int labTotalPrice = 0;


        String showAme, showVie, showMocha, showCoco;

        private void Frm_drinkpos_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            labShowList.Text = string.Empty;
            labtotalprice.Text = string.Empty;
            Label sl = labShowList;
            Label tp = labtotalprice;
            sl.Text = "尚未點餐";
            tp.Text = "NT$0";
            a = b = c = d = productAme = productVie = productMocha = productCoco = 0;
            showAme = showVie = showMocha = showCoco = string.Empty;


        }

        private void btncoco_Click(object sender, EventArgs e)
        {
            d += 1;
            productCoco += 120;
            showCoco = $"醇可可{d}杯，共{productCoco}元" + Environment.NewLine;
            labShowList.Text = showAme + showVie + showMocha + showCoco;
            //labShowList.Text = $"醇可可 {d} 杯，共 {productCoco}元";   //這是較新的寫法，學起來
            //labShowList.Text = "醇可可" + d + "杯，共" + productCoco + "元"; //這是一般寫法
            int labTotalPrice = productAme + productVie + productMocha + productCoco;
            labtotalprice.Text = "NT$" + labTotalPrice;
        }

        private void btname_Click(object sender, EventArgs e)
        {
            a += 1;
            productAme += 100;
            showAme = $"美式咖啡{a}杯，共{productAme}元" + Environment.NewLine;
            labShowList.Text = showAme + showVie + showMocha + showCoco;
            int labTotalPrice = productAme + productVie + productMocha + productCoco;
            labtotalprice.Text = "NT$" + labTotalPrice;
        }

        private void btnvie_Click(object sender, EventArgs e)
        {
            b += 1;
            productVie += 150;
            showVie = $"維也納咖啡{b}杯，共{productVie}元" + Environment.NewLine;
            labShowList.Text = showAme + showVie + showMocha + showCoco;
            int labTotalPrice = productAme + productVie + productMocha + productCoco;
            labtotalprice.Text = "NT$" + labTotalPrice;
        }

        private void btnmocha_Click(object sender, EventArgs e)
        {
            c += 1;
            productMocha += 140;
            showMocha = $"摩卡咖啡{c}杯，共{productMocha}元" + Environment.NewLine;
            labShowList.Text = showAme + showVie + showMocha + showCoco;
            int labTotalPrice = productAme + productVie + productMocha + productCoco;
            labtotalprice.Text = "NT$" + labTotalPrice;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            
            int labTotalPrice = productAme + productVie + productMocha + productCoco;
            if (labTotalPrice == 0)
            {
                MessageBox.Show("還沒有點餐喔！", "快看菜單", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if (labTotalPrice > 0)
            {

                DialogResult cashResult = MessageBox.Show("總金額NT$:" + labTotalPrice + "元",
                   "請確認金額", MessageBoxButtons.OKCancel);
                if (cashResult == DialogResult.OK)
                {
                    MessageBox.Show("謝謝惠顧", "歡迎再次光臨");
                }
                else if (cashResult == DialogResult.Cancel)
                {
                    MessageBox.Show("請再確認一次", "Oops!");

                }

            }
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            int labTotalPrice = productAme + productVie + productMocha + productCoco;
            double discount = 0.9;
            double totalDiscountPrice = labTotalPrice * discount;
            if (labTotalPrice == 0)
            {
                MessageBox.Show("還沒有點餐喔！", "快看菜單", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if (labTotalPrice > 0)
            {
                DialogResult cardResult = MessageBox.Show("總金額NT$:" + labTotalPrice + "元" + Environment.NewLine +
                    "折扣後金額NT$:" + totalDiscountPrice + "元");
            }
        }
    }

}
