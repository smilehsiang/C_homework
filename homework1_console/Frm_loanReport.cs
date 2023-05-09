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
    public partial class Frm_loanReport : Form
    {
        public Frm_loanReport()
        {
            InitializeComponent();
        }

      public void LoanReport()
        {
            labLoanShow.Text = Report.reportLoan.ToString();
            labYearShow.Text = Report.reportYear.ToString();
            labInterestRateShow.Text= Report.reportInterestRate.ToString();
            labMonthPayShow.Text= Report.reportMonthPay.ToString();
            labTotalPriceShow.Text=Report.reportTotalPay.ToString();
        }

    }
}
