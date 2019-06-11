using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bolum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sonuc = 0, buyuksayi, kucuksayi;
        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_sonuc.Clear();
            buyuksayi = Convert.ToInt16(txt_sayi1.Text);
            kucuksayi = Convert.ToInt16(txt_sayi2.Text);
            sonuc += kucuksayi;
            txt_sonuc.Text += sonuc.ToString();
            if (sonuc >= buyuksayi)
            {
                timer1.Stop();
            }
        }

        
    }
}
