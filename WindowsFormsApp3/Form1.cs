using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int h = 90;
        int z = 90;
        int x = 90;
        int sec = 0;
    
        Random rnd = new Random();
        Random rnd2 = new Random();
        Random rnd3 = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (h < 1000)
            {
                h = h + 10;
            }
            else
            {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                if (sec == 1)
                {
                    MessageBox.Show("TEBRİKLER BEŞİKTAŞ KAZANDI");
                }
                else
                {
                    MessageBox.Show("MAALESEF BİLEMEDİN BEŞİKTAŞ KAZANDI");
                }
            }
                pictureBox1.Location = new Point(h, 80);
                timer1.Interval = rnd.Next(1, 100);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (z < 1000)
            {
                z = z + 10;
            }
            else
            {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                if (sec == 2)
                {
                    MessageBox.Show("TEBRİKLER FENERBAHÇE KAZANDI");
                }
                else
                {
                    MessageBox.Show("MAALESEF BİLEMEDİN FENERBAHÇE KAZANDI");
                }
            }
                pictureBox2.Location = new Point(z, 180);
                timer2.Interval = rnd2.Next(1, 100);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
           if (x < 1000)
            {
                x = x + 10;
            }
            else
            {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                if (sec == 3)
                {
                    MessageBox.Show("TEBRİKLER GALATASARAY KAZANDI");
                }
                else
                {
                    MessageBox.Show("MAALESEF BİLEMEDİN GALATASARAY KAZANDI");
                }
            }
                pictureBox3.Location = new Point(x, 280);
                timer3.Interval = rnd3.Next(1, 100);  
        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            comboBox1.Enabled = false;
           if(comboBox1.SelectedItem == ("BEŞİKTAŞ"))
            {
                sec = sec + 1;
            }
            if (comboBox1.SelectedItem == ("FENERBAHÇE"))
            {
                sec = sec + 2;
            }
            if (comboBox1.SelectedItem == ("GALATASARAY"))
            {
                sec = sec + 3;
            }
        }
    }
}
