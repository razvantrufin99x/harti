using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace harti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics g;
        public Pen pen0 = new Pen(Color.Black);
        public Font font0;
        public Brush brush0 = new SolidBrush(Color.Black);
        public List<elementharta> harta = new List<elementharta>();

        public void drawtext(string s, float x, float y)
        {
            g.DrawString(s, font0, brush0, x, y);
        }
        public void drawlinie(float x1, float y1, float x2, float y2)
        {
            g.DrawLine(pen0, x1, y1, x2, y2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            font0 = this.Font;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string s = e.X.ToString() + "_" + e.Y.ToString();
            harta.Add(new elementharta(e.X, e.Y, s,"",""));
        }

        public void drawharta()
        {
             string s1,s2;
            g.Clear(BackColor);
            for (int i = 0; i < harta.Count; i++)
            {
                try
                {
                    s1 = harta[i].latitudine.ToString() + "_" + harta[i].longitudine.ToString();
                    s2 = harta[i+1].latitudine.ToString() + "_" + harta[i+1].longitudine.ToString();
            
                    drawlinie(harta[i].latitudine, harta[i].longitudine, harta[i+1].latitudine, harta[i+1].longitudine);
                    drawtext(s1, harta[i].latitudine, harta[i].longitudine);
                    drawtext(s2, harta[i+1].latitudine, harta[i+1].longitudine);
                }
                catch { }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            drawharta();
        }
    }
}
