using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToInt16(txt_sayi1.Text) + Convert.ToInt16(txt_sayi2.Text);
            lbl_sonuc.Text = sonuc.ToString();
        }

        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToInt16(txt_sayi1.Text) - Convert.ToInt16(txt_sayi2.Text);
            lbl_sonuc.Text = sonuc.ToString();
        }

        private void btn_böl_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToInt16(txt_sayi1.Text) / Convert.ToInt16(txt_sayi2.Text);
            lbl_sonuc.Text = sonuc.ToString();
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToInt16(txt_sayi1.Text) * Convert.ToInt16(txt_sayi2.Text);
            lbl_sonuc.Text = sonuc.ToString();
        }


    }
}
