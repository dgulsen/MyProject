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
        public Form1()
        {
            InitializeComponent();
        }
        DateTime baslangic, bitis;
        int indeks;
        List<DateTime> tarih = new List<DateTime>();
        string[] ogrenciler = {"Melda SEÇKİN","Devran GÜLŞEN","Betül TEMİZ","Rümeysa TOP","Özdenur UÇAR","Serap YÜKSEL","Hafize CEBECİ","Yunus KARATAŞ","Erhan ARI" };
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                cbx_ogrencilistesi.Items.Add(ogrenciler[i].ToString());
            }            
        }

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            lbx_nobetgunleri.Items.Clear();
            indeks = cbx_ogrencilistesi.SelectedIndex;
            baslangic = dtp_baslangic.Value;
            bitis = dtp_bitis.Value;
            for (DateTime i = baslangic; i <= bitis; i=i.AddDays(1))
            {             
                if (i.DayOfWeek.ToString() != "Sunday" && i.DayOfWeek.ToString() != "Saturday")
                {
                    tarih.Add(i);                   
                }               
            }
           
            for (int i = indeks; i <= tarih.Count;i+=11)
            {
                lbx_nobetgunleri.Items.Add(tarih[i].ToLongDateString());
            } 
           
        }

        

    }
}
