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
    public partial class Frm_loan : Form
    {
        public Frm_loan()
        {
            InitializeComponent();
        }
        
        private void btnPMT_Click(object sender, EventArgs e)
        {
        //每月應還利息金額 = 本金餘額 * 月利率
        //每月應還本金金額 = 平均每月應還本息金額 - 每月應還利息金額
        //月還款金額 = (本金-頭期款) *[月利率 * (1 + 月利率) ^ n] /[(1+月利率)^n-1]
        //利息收益=(本金-頭期款)*月數*月利率* (1 + 月利率) ^ n)/[(1 + 月利率) ^ n - 1]-(本金-頭期款)
        //月利率=年利率/12，n表示貸款月數，^n表示n次方
        //Math.Pow(底,指數)，例如3的5次方為：Math.Pow(3,5)
        //數值型態為double的時候要給小數點才會成立

            int loan = int.Parse(txtLoan.Text); /*貸款金額*/
            int year = int.Parse(txtYear.Text);/*期限(年)*/
            int ir = int.Parse(txtInterestRate.Text);/*年利率*/
            int dp = int.Parse(txtDownPayment.Text);/*頭期款*/
            double monthIr = ir /12.0/100.0;/*月利率*/
            double monthYear = year*12.0;/*貸款月數*/

            double PMT = (loan-dp) *(monthIr* Math.Pow(1+monthIr,monthYear))/(Math.Pow((1+monthIr),monthYear)-1);
            int PMT1=Convert.ToInt32(PMT);

            MessageBox.Show("月付額" + PMT1+"元");


        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            //每月應還利息金額 = 本金餘額 * 月利率
            //每月應還本金金額 = 平均每月應還本息金額 - 每月應還利息金額
            //月還款金額 PMT= (本金-頭期款) *[月利率 * (1 + 月利率) ^ n] /[(1+月利率)^n-1]
            //利息收益=(本金-頭期款)*月數*月利率* (1 + 月利率) ^ n)/[(1 + 月利率) ^ n - 1]-(本金-頭期款)
            //月利率=年利率/12，n表示貸款月數，^n表示n次方
            //Math.Pow(底,指數)，例如3的5次方為：Math.Pow(3,5)
            //數值型態為double的時候要給小數點才會成立

            int loan = int.Parse(txtLoan.Text); /*貸款金額*/
            int year = int.Parse(txtYear.Text);/*期限(年)*/
            int ir = int.Parse(txtInterestRate.Text);/*年利率*/
            int dp = int.Parse(txtDownPayment.Text);/*頭期款*/
            double monthIr = ir / 12.0 / 100.0;/*月利率*/
            double monthYear = year * 12.0;/*貸款月數*/

            double PMT = (loan - dp) * (monthIr * Math.Pow(1 + monthIr, monthYear)) / (Math.Pow((1 + monthIr), monthYear) - 1);
            int PMT1=Convert.ToInt32(PMT)*Convert.ToInt32(monthYear);
            MessageBox.Show("總付款:" + PMT1 + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            int loan = int.Parse(txtLoan.Text); /*貸款金額*/
            int year = int.Parse(txtYear.Text);/*期限(年)*/
            int ir = int.Parse(txtInterestRate.Text);/*年利率*/
            int dp = int.Parse(txtDownPayment.Text);/*頭期款*/
            double monthIr = ir / 12.0 / 100.0;/*月利率*/
            double monthYear = year * 12.0;/*貸款月數*/

            double PMT = (loan - dp) * (monthIr * Math.Pow(1 + monthIr, monthYear)) / (Math.Pow((1 + monthIr), monthYear) - 1);
            int PMT1 = Convert.ToInt32(PMT);
            int totalPay = PMT1 * Convert.ToInt32(monthYear);


            Report.reportLoan = int.Parse(txtLoan.Text);
            Report.reportYear = int.Parse(txtYear.Text);
            Report.reportInterestRate=int.Parse(txtInterestRate.Text);
            Report.reportMonthPay =PMT1;
            Report.reportTotalPay =totalPay;

            Frm_loanReport frmreport=new Frm_loanReport();
            
            frmreport.LoanReport();
            frmreport.ShowDialog();
        }
    }
}
