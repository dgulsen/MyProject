using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yerDegisenSayılar
{
    public partial class frm_kodgiris : Form
    {
        public frm_kodgiris()
        {
            InitializeComponent();
        }

        static int[] butonyaz()
        {
            int[] sayilar = new int[9];
            Random rnd = new Random();
            int sayi;
            for (int i = 0; i < 9; i++)
            {
                sayi = rnd.Next(1, 10);
                if (Array.IndexOf(sayilar, sayi) == -1)
                {
                    sayilar[i] = sayi;
                }
                else
                {
                    i--;
                }

            }
            return sayilar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] butonsayilari = butonyaz();
            txt_sifre.Text += button1.Text;
            button1.Text = butonsayilari[0].ToString();
            button2.Text = butonsayilari[1].ToString();
            button3.Text = butonsayilari[2].ToString();
            button4.Text = butonsayilari[3].ToString();
            button5.Text = butonsayilari[4].ToString();
            button6.Text = butonsayilari[5].ToString();
            button7.Text = butonsayilari[6].ToString();
            button8.Text = butonsayilari[7].ToString();
            button9.Text = butonsayilari[8].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] butonsayilari = butonyaz();
            txt_sifre.Text += button2.Text;
            button1.Text = butonsayilari[0].ToString();
            button2.Text = butonsayilari[1].ToString();
            button3.Text = butonsayilari[2].ToString();
            button4.Text = butonsayilari[3].ToString();
            button5.Text = butonsayilari[4].ToString();
            button6.Text = butonsayilari[5].ToString();
            button7.Text = butonsayilari[6].ToString();
            button8.Text = butonsayilari[7].ToString();
            button9.Text = butonsayilari[8].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] butonsayilari = butonyaz();
            txt_sifre.Text += button3.Text;
            button1.Text = butonsayilari[0].ToString();
            button2.Text = butonsayilari[1].ToString();
            button3.Text = butonsayilari[2].ToString();
            button4.Text = butonsayilari[3].ToString();
            button5.Text = butonsayilari[4].ToString();
            button6.Text = butonsayilari[5].ToString();
            button7.Text = butonsayilari[6].ToString();
            button8.Text = butonsayilari[7].ToString();
            button9.Text = butonsayilari[8].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] butonsayilari = butonyaz();
            txt_sifre.Text += button4.Text;
            button1.Text = butonsayilari[0].ToString();
            button2.Text = butonsayilari[1].ToString();
            button3.Text = butonsayilari[2].ToString();
            button4.Text = butonsayilari[3].ToString();
            button5.Text = butonsayilari[4].ToString();
            button6.Text = butonsayilari[5].ToString();
            button7.Text = butonsayilari[6].ToString();
            button8.Text = butonsayilari[7].ToString();
            button9.Text = butonsayilari[8].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] butonsayilari = butonyaz();
            txt_sifre.Text += button5.Text;
            button1.Text = butonsayilari[0].ToString();
            button2.Text = butonsayilari[1].ToString();
            button3.Text = butonsayilari[2].ToString();
            button4.Text = butonsayilari[3].ToString();
            button5.Text = butonsayilari[4].ToString();
            button6.Text = butonsayilari[5].ToString();
            button7.Text = butonsayilari[6].ToString();
            button8.Text = butonsayilari[7].ToString();
            button9.Text = butonsayilari[8].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] butonsayilari = butonyaz();
            txt_sifre.Text += button6.Text;
            button1.Text = butonsayilari[0].ToString();
            button2.Text = butonsayilari[1].ToString();
            button3.Text = butonsayilari[2].ToString();
            button4.Text = butonsayilari[3].ToString();
            button5.Text = butonsayilari[4].ToString();
            button6.Text = butonsayilari[5].ToString();
            button7.Text = butonsayilari[6].ToString();
            button8.Text = butonsayilari[7].ToString();
            button9.Text = butonsayilari[8].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] butonsayilari = butonyaz();
            txt_sifre.Text += button7.Text;
            button1.Text = butonsayilari[0].ToString();
            button2.Text = butonsayilari[1].ToString();
            button3.Text = butonsayilari[2].ToString();
            button4.Text = butonsayilari[3].ToString();
            button5.Text = butonsayilari[4].ToString();
            button6.Text = butonsayilari[5].ToString();
            button7.Text = butonsayilari[6].ToString();
            button8.Text = butonsayilari[7].ToString();
            button9.Text = butonsayilari[8].ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] butonsayilari = butonyaz();
            txt_sifre.Text += button8.Text;
            button1.Text = butonsayilari[0].ToString();
            button2.Text = butonsayilari[1].ToString();
            button3.Text = butonsayilari[2].ToString();
            button4.Text = butonsayilari[3].ToString();
            button5.Text = butonsayilari[4].ToString();
            button6.Text = butonsayilari[5].ToString();
            button7.Text = butonsayilari[6].ToString();
            button8.Text = butonsayilari[7].ToString();
            button9.Text = butonsayilari[8].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[] butonsayilari = butonyaz();
            txt_sifre.Text += button9.Text;
            button1.Text = butonsayilari[0].ToString();
            button2.Text = butonsayilari[1].ToString();
            button3.Text = butonsayilari[2].ToString();
            button4.Text = butonsayilari[3].ToString();
            button5.Text = butonsayilari[4].ToString();
            button6.Text = butonsayilari[5].ToString();
            button7.Text = butonsayilari[6].ToString();
            button8.Text = butonsayilari[7].ToString();
            button9.Text = butonsayilari[8].ToString();
        }

        private void chc_göster_CheckedChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '\0';
        }

        //private void chc_göster_CheckedChanged(object sender, EventArgs e)
        //{
        //    txt_sifre.PasswordChar = '*';
        //}

    }
}
