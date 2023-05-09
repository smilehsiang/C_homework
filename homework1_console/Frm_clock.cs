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
    public partial class Frm_clock : Form
    {
        
        public Frm_clock()
        {
            InitializeComponent();
        }        
        private void checkAlarm_CheckedChanged(object sender, EventArgs e)
        {
            nowTime.Enabled = true;         
        }       
        private void Frm_clock_Load(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("H:mm:ss"); /*讓系統顯示時間是從第0秒開始(畫面不會一閃而過)*/
        }
        private void showTime_Tick_1(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void nowTime_Tick(object sender, EventArgs e)
        {
            
            DateTime nt = DateTime.Now;
            int nHour = nt.Hour;
            int nMinute = nt.Minute;
            int sHour = Convert.ToInt32(comboHour.SelectedItem.ToString());
            int sMin = Convert.ToInt32(comboSec.SelectedItem.ToString());

            if (nHour == sHour && nMinute == sMin)
            {
                Frm_clock_pic pic = new Frm_clock_pic();
                pic.Show();
                System.Media.SoundPlayer ring = new System.Media.SoundPlayer();
                ring.SoundLocation = @"C:\Users\Maru\Desktop\翔翔0505\Csharp_Homework\使用的圖片\蠟筆小新.wav";
                ring.Play();
                comboHour.SelectedIndex = 0;
                comboSec.SelectedIndex = 0;
                checkAlarm.CheckState = CheckState.Unchecked;
                nowTime.Enabled = false;
            }
        }
    }
}
