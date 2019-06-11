using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tekCift
{
    public partial class Form1 : Form
    {
        int kücüksayi, büyüksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_tek_Click(object sender, EventArgs e)
        {
            kücüksayi = Convert.ToInt16(txt_kücüksayi.Text);
            büyüksayi = Convert.ToInt16(txt_büyüksayi.Text);
            txt_sonuc.Clear();
            for (int i = kücüksayi; i < büyüksayi; i++)
            {
                if (i % 2 == 1) 
                {
                    txt_sonuc.Text += " - "+i.ToString();
                }
            }
        }

        private void btn_cift_Click(object sender, EventArgs e)
        {
            kücüksayi = Convert.ToInt16(txt_kücüksayi.Text);
            büyüksayi = Convert.ToInt16(txt_büyüksayi.Text);
            txt_sonuc.Clear();
            for (int i = kücüksayi; i < büyüksayi; i++)
            {
                if (i % 2 == 0)
                {
                    txt_sonuc.Text += " - "+i.ToString();
                }
            }
        }

    }
}
