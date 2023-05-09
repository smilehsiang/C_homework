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
    public partial class Frm_小畫家 : Form
    {
        Graphics g;
        Pen pen;
        bool isMouseDown=false;
        List<Point>points = new List<Point>();
        ColorDialog chooseColor = new ColorDialog();
        int penSize=1;
        

        public Frm_小畫家()
        {
            InitializeComponent();

            g=this.CreateGraphics();
            pen = new Pen(chooseColor.Color,trkPenSize.Value);
            labColor.BackColor= pen.Color;
        }

        private void Frm_小畫家_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            points.Add(e.Location);
        }
        private void Frm_小畫家_MouseMove(object sender, MouseEventArgs e)
        {
            points.Add(e.Location);
            if (isMouseDown)
            {
                g.DrawLine(pen, points[points.Count - 2], points[points.Count - 1]);
            }
        }
        private void Frm_小畫家_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown=false;  
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (chooseColor.ShowDialog() == DialogResult.OK)
            {
                pen.Color = chooseColor.Color;
                labColor.BackColor = pen.Color;
            }
        }

        private void trackPenSize_ValueChanged(object sender, EventArgs e)
        {
            labPenSize.Text=trkPenSize.Value.ToString();
            penSize=Convert.ToInt32(trkPenSize.Value.ToString());
            pen.Width = penSize;
        }
    }
    
}
