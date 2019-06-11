using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace arabaYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btn_basla.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pb_redcar.Left += rnd.Next(1, 10);
            pb_yellowcar.Left += rnd.Next(1, 10);
            pb_bluecar.Left += rnd.Next(1, 10);
            pb_whitecar.Left += rnd.Next(1, 10);
            if (pb_redcar.Left >= this.Width - pb_redcar.Width - 20)
            {
                timer1.Stop();
                MessageBox.Show("Kırmızı araba kazandı!");
            }

            if (pb_yellowcar.Left >= this.Width - pb_yellowcar.Width - 20)
            {
                timer1.Stop();
                MessageBox.Show("Sarı araba kazandı!");
            }

            if (pb_bluecar.Left >= this.Width - pb_bluecar.Width - 20)
            {
                timer1.Stop();
                MessageBox.Show("Mavi araba kazandı!");
            }

            if (pb_whitecar.Left >= this.Width - pb_whitecar.Width - 20)
            {
                timer1.Stop();
                MessageBox.Show("Beyaz araba kazandı!");
            }
        }

    }
}
