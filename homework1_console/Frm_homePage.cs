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
    public partial class Frm_homePage : Form
    {
        public Frm_homePage()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_sayhello sayHello =new Frm_sayhello();
            sayHello.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(sayHello);            
            sayHello.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_loan loan =new Frm_loan(); 
            loan.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(loan);
            loan.Show();
        }

        private void btnDrinkPos_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_drinkpos drinkpos =new Frm_drinkpos();
            drinkpos.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(drinkpos);
            drinkpos.Show();
        }

        private void btnStructForm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_structForm structform =new Frm_structForm();
            structform.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(structform);
            structform.Show();
        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_studentGrade studentGrade=new Frm_studentGrade();
            studentGrade.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(studentGrade);
            studentGrade.Show();
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_mycalc myClac =new Frm_mycalc();
            myClac.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(myClac);
            myClac.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_screenSaver screenSaver =new Frm_screenSaver();
            screenSaver.Show();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_note note =new Frm_note();
            note.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(note);
            note.Show();
        }

        private void btn小畫家_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_小畫家 paint=new Frm_小畫家();
            paint.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(paint);
            paint.Show();
        }

        private void btnGuessNumber_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_guessNumber guessNumber =new Frm_guessNumber();
            guessNumber.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(guessNumber);
            guessNumber.Show();

        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_clock alarm =new Frm_clock();
            alarm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(alarm);
            alarm.Show();

        }
    }
}
