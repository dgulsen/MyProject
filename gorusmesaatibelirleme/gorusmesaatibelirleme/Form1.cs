using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gorusmesaatibelirleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = { "melda", "betül", "hafize", "yunus", "sezer", "erhan", "devran", "furkan", "rümeysa", "serap", "özdenur","ayten","simge","yıldız","fatma","muhammed","hilal","çağla","gizem" };
        List<DateTime> sureler = new List<DateTime>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 5; i <= 100; i += 5)
            {
                cmbx_gorusmeSure.Items.Add(i.ToString());
            }
            for (int i = 1; i < 25; i++)
            {
                cmbx_baslangicSaat.Items.Add(i.ToString());
                cmbx_bitisSaat.Items.Add(i.ToString());
                cmbx_oglenbaslangicSaat.Items.Add(i.ToString());
                cmbx_oglenbitisSaat.Items.Add(i.ToString());
            }
            for (int i = 0; i < 61; i+=5)
            {
                cmbx_baslangicDakika.Items.Add(i.ToString());
                cmbx_bitisDakika.Items.Add(i.ToString());
                cmbx_oglenbaslangicDakika.Items.Add(i.ToString());
                cmbx_oglenbitisDakika.Items.Add(i.ToString());
            }
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            lstbx_gorusmeler.Items.Clear();
            DateTime gorusmeBaslama, gorusmeBitis;
            TimeSpan fark;
            DateTime baslamaSaati = new DateTime(2013, 12, 2, Convert.ToInt16(cmbx_baslangicSaat.SelectedItem.ToString()), Convert.ToInt16(cmbx_baslangicDakika.SelectedItem.ToString()), 0);
            DateTime bitisSaati = new DateTime(2013, 12, 2, Convert.ToInt16(cmbx_bitisSaat.SelectedItem.ToString()), Convert.ToInt16(cmbx_bitisDakika.SelectedItem.ToString()), 0);
            DateTime oglenbaslangic = new DateTime(2013, 12, 2, Convert.ToInt16(cmbx_oglenbaslangicSaat.SelectedItem.ToString()), Convert.ToInt16(cmbx_oglenbaslangicDakika.SelectedItem.ToString()), 0);
            DateTime oglenbitis = new DateTime(2013, 12, 2, Convert.ToInt16(cmbx_oglenbitisSaat.SelectedItem.ToString()), Convert.ToInt16(cmbx_oglenbitisDakika.SelectedItem.ToString()), 0);
            int gorusmeSuresi = Convert.ToInt16(cmbx_gorusmeSure.SelectedItem);
            for (DateTime i =baslamaSaati ; i < bitisSaati; i=i.AddMinutes(gorusmeSuresi))
            {
                if (i<=oglenbaslangic || i>=oglenbitis)
                {
                    fark = i - oglenbitis;

                    if (Convert.ToInt16(fark.TotalMinutes) < gorusmeSuresi && Convert.ToInt16(fark.TotalMinutes) > 0)
                    {
                        i = oglenbitis;

                    }
                    sureler.Add(i);
                    listBox1.Items.Add(i.ToShortTimeString());
                }
                
                
            }

            for (int i = 0; i < sureler.Count-1; i++)
            {
                lstbx_gorusmeler.Items.Add(isimler[i] + "\t" + sureler[i].ToShortTimeString() + "\t" + sureler[i + 1].ToShortTimeString());

            }

        }
    }
}
