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
    public partial class Frm_studentGrade : Form
    {
        
        public Frm_studentGrade()
        {
            InitializeComponent();
        }
        String stuName, cnScore, enScore, MaScore, totalScore, averageScore, highScore, lowScore;

        private void lvStuDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int Stu, Cn, En, Ma, tScore, aScore, hScore, lScore;
        private void btnAdd20_Click(object sender, EventArgs e)
        {
            btnStatistics.Enabled = true;
            int Stu = 0;
            Random rm = new Random();
            int[]cn= new int[20];
            int[]en = new int[20];
            int[]ma = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Stu += 1;
                cn[i] = rm.Next(0, 100);
                en[i] = rm.Next(0, 100);
                ma[i] = rm.Next(0, 100);
                tScore = cn[i] + en[i] + ma[i];
                aScore = (cn[i] + en[i] + ma[i]) / 3;
                int[] arr = { cn[i] , en[i] , ma[i] };
                hScore = arr.Max();
                lScore = arr.Min();

                stuName = Stu.ToString();
                cnScore = cn[i].ToString();
                enScore = en[i].ToString();
                MaScore = ma[i].ToString();
                totalScore = tScore.ToString();
                averageScore = aScore.ToString();
                highScore = hScore.ToString();
                lowScore = lScore.ToString();

                ListViewItem newItem = new ListViewItem(stuName);
                newItem.SubItems.Add(cnScore);
                newItem.SubItems.Add(enScore);
                newItem.SubItems.Add(MaScore);
                newItem.SubItems.Add(totalScore);
                newItem.SubItems.Add(averageScore);
                newItem.SubItems.Add(highScore);
                newItem.SubItems.Add(lowScore);
                lvStuDetails.Items.Add(newItem);
            }
            

            


        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            lvStuDetails.Items.Clear();
            labTotalSta.Text = string.Empty;
            Stu = 0;
            btnAdd.Enabled = true;
            btnRmAdd.Enabled = true;
            btnAdd20.Enabled = true;
            btnStatistics.Enabled = false;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            //關掉其他的按鈕
            btnAdd.Enabled = false;
            btnRmAdd.Enabled = false; 
            btnStatistics.Enabled = false;
            btnAdd20.Enabled = false;   
            //各科總分、各科平均
            float cnTotal = 0;
            float enTotal = 0;
            float maTotal = 0;
            float cnAverage=0;
            float enAverage=0;
            float maAverage=0;
            
            for (int i = 0; i < lvStuDetails.Items.Count; i++)
            {
                cnTotal += float.Parse(lvStuDetails.Items[i].SubItems[1].Text);
                enTotal += float.Parse(lvStuDetails.Items[i].SubItems[2].Text);
                maTotal += float.Parse(lvStuDetails.Items[i].SubItems[3].Text);
                cnAverage =cnTotal / lvStuDetails.Items.Count;
                enAverage = enTotal / lvStuDetails.Items.Count;
                maAverage = maTotal / lvStuDetails.Items.Count;
                
            }
            string cnTotalScore = cnTotal.ToString();
            string enTotalScore = enTotal.ToString();
            string maTotalScore = maTotal.ToString();
            string cnTotalAverage=cnAverage.ToString();
            string enTotalAverage = enAverage.ToString();
            string maTotalAverage = maAverage.ToString();

            labTotalSta.Text = $"國文總分：{cnTotalScore}分、總平均：{cnTotalAverage}分、最高分：分、最低分：分。\n" +
                $"英文總分：{enTotalScore}分、總平均：{enTotalAverage}分、最高分：分、最低分：分。\n" +
                $"數學總分：{maTotalScore}分、總平均：{maTotalAverage}分、最高分：分、最低分：分。";

        }

       
     

        private void Frm_studentGrade_Load(object sender, EventArgs e)
        {
            lvStuDetails.Columns.Add("姓名", 65);
            lvStuDetails.Columns.Add("國文", 65);
            lvStuDetails.Columns.Add("英文", 65);
            lvStuDetails.Columns.Add("數學", 65);
            lvStuDetails.Columns.Add("總分", 65);
            lvStuDetails.Columns.Add("平均", 65);
            lvStuDetails.Columns.Add("最高分", 65);
            lvStuDetails.Columns.Add("最低分", 65);

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnStatistics.Enabled = true;
            Cn = int.Parse(txtCn.Text);
            En= int.Parse(txtEn.Text);
            Ma = int.Parse(txtMa.Text);
            tScore = Cn + En + Ma;
            aScore = (Cn + En + Ma) / 3;
            
            int[] arr = { Cn, En, Ma };
            hScore = arr.Max();
            lScore = arr.Min();          

            stuName =txtName.Text;
            cnScore=txtCn.Text;
            enScore=txtEn.Text;
            MaScore=txtMa.Text;
            totalScore=tScore.ToString();
            averageScore=aScore.ToString();
            highScore=hScore.ToString();
            lowScore =lScore.ToString();


            ListViewItem newItem = new ListViewItem(stuName);
            newItem.SubItems.Add(cnScore);
            newItem.SubItems.Add(enScore);
            newItem.SubItems.Add(MaScore);
            newItem.SubItems.Add(totalScore);
            newItem.SubItems.Add(averageScore);
            newItem.SubItems.Add(highScore);
            newItem.SubItems.Add(lowScore);
            lvStuDetails.Items.Add(newItem);
        }

        private void btnRmAdd_Click(object sender, EventArgs e)
        {
            btnStatistics.Enabled = true;
            Stu += 1;
            Random rm= new Random();
            Cn=rm.Next(0, 100);
            En=rm.Next(0, 100);
            Ma=rm.Next(0, 100);
            tScore=Cn+En+Ma;
            aScore = (Cn + En + Ma) / 3;

            int[] arr = { Cn, En, Ma };
            hScore = arr.Max();
            lScore = arr.Min();

            stuName = Stu.ToString();
            cnScore=Cn.ToString();
            enScore=En.ToString();
            MaScore=Ma.ToString();
            totalScore=tScore.ToString();
            averageScore = aScore.ToString();
            highScore = hScore.ToString();
            lowScore = lScore.ToString();

            ListViewItem newItem = new ListViewItem(stuName);
            newItem.SubItems.Add(cnScore);
            newItem.SubItems.Add(enScore);
            newItem.SubItems.Add(MaScore);
            newItem.SubItems.Add(totalScore);
            newItem.SubItems.Add(averageScore);
            newItem.SubItems.Add(highScore);
            newItem.SubItems.Add(lowScore);
            lvStuDetails.Items.Add(newItem);
        }
    }
}
