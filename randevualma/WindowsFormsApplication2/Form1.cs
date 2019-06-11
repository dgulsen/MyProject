using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = { "Melda Seçkin", "Betül Temiz", "Hafize Cebeci", "Sezer Koray Alakuş", "Yunus Emre Karataş", "Erhan Arı", "Devran Gülşen", "Furkan Açıkgöz", "Rümeysa Top", "Serap Damla Yüksel", "Özdenur Uçar" };
        DateTime baslangicsaat, bitissaat, oglebassaat, oglebitissaat, gorusmesuresi;
        List<DateTime> gorusmesureleri = new List<DateTime>();
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 24; i++)
            {
                cbx_cikissaat.Items.Add(i);
                cbx_girissaat.Items.Add(i);                
                cbx_oglebassaat.Items.Add(i);
                cbx_oglebitissaat.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                cbx_cikisdakika.Items.Add(i);
                cbx_girisdakika.Items.Add(i);
                cbx_gorusmedakika.Items.Add(i);
                cbx_oglebasdakika.Items.Add(i);
                cbx_oglebitisdakika.Items.Add(i);
            }
        }
        private void btn_tamam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\shutdown.exe", "-s -t 100");
            lbx_randevu.Items.Clear();
            baslangicsaat = baslangicsaat.AddHours(Convert.ToDouble(cbx_girissaat.Text));
            baslangicsaat = baslangicsaat.AddMinutes(Convert.ToDouble(cbx_girisdakika.Text));
            bitissaat = bitissaat.AddHours(Convert.ToDouble(cbx_cikissaat.Text));
            bitissaat = bitissaat.AddMinutes(Convert.ToDouble(cbx_cikisdakika.Text));
            oglebassaat = oglebassaat.AddHours(Convert.ToDouble(cbx_oglebassaat.Text));
            oglebassaat = oglebassaat.AddMinutes(Convert.ToDouble(cbx_oglebasdakika.Text));
            oglebitissaat = oglebitissaat.AddHours(Convert.ToDouble(cbx_oglebitissaat.Text));
            oglebitissaat = oglebitissaat.AddMinutes(Convert.ToDouble(cbx_oglebitisdakika.Text));            
            gorusmesuresi = gorusmesuresi.AddMinutes(Convert.ToDouble(cbx_gorusmedakika.Text));

            for (DateTime i = baslangicsaat; i < bitissaat; i = i.AddMinutes(Convert.ToDouble(cbx_gorusmedakika.Text)))
            {
                if (i < oglebassaat || i > oglebitissaat)
                {
                    gorusmesureleri.Add(i);
                }
                
            }
            do
            {
                 if (gorusmesureleri[sayac]<oglebassaat || gorusmesureleri[sayac]>oglebitissaat)
                 {
                     lbx_randevu.Items.Add(isimler[sayac] + "    " + gorusmesureleri[sayac].ToShortTimeString());
                     sayac++;
                 }       
            } while (sayac!=11);
        }
    }
}
