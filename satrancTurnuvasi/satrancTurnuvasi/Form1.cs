using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace satrancTurnuvasi
{
    public partial class frmSatranc : Form
    {
        public frmSatranc()
        {
            InitializeComponent();
        }
        string[] kizOyuncular = { "MELDA", "BETÜL", "ÖZDENUR", "RÜMEYSA" };
        string[] erkekOyuncular = { "ERHAN", "FURKAN", "YUNUS", "SEZER" };
        int oyuncuIndex1, oyuncuIndex2;
        string oyuncuIsim1, oyuncuIsim2;
        Random rnd = new Random();
        string resimyol = Directory.GetCurrentDirectory() + "\\oyuncular\\";


        private void frmSatranc_Load(object sender, EventArgs e)
        {
            //tüm radio butonların pasif gelmesini sağlar
            rbtnErkekErkek.Checked = false;
            rbtnErkekKiz.Checked = false;
            rbtnKizKiz.Checked = false;
            //listboxlara oyuncu isimlerini diziden alarak ekler
            for (int i = 0; i < kizOyuncular.Length; i++)
            {
                lstbxErkekOyuncu.Items.Add(erkekOyuncular[i]);
                lstbxKizOyuncu.Items.Add(kizOyuncular[i]);
            }
        }



        private void rbtnKizKiz_CheckedChanged_1(object sender, EventArgs e)
        {

            if (lstbxKizOyuncu.Items.Count > 1)
            {
                if (rbtnKizKiz.Checked)
                {
                    do
                    {//Sıfır ile kız oyuncu listesindeki oyuncu sayısı aralığında bir birinden farklı iki sayı üretir
                        oyuncuIndex1 = rnd.Next(0, lstbxKizOyuncu.Items.Count);
                        oyuncuIndex2 = rnd.Next(0, lstbxKizOyuncu.Items.Count);
                        //ürettiği indekse denk gelen isimleri string değişkenlerine atar
                        oyuncuIsim1 = lstbxKizOyuncu.Items[oyuncuIndex1].ToString();
                        oyuncuIsim2 = lstbxKizOyuncu.Items[oyuncuIndex2].ToString();

                    } while (oyuncuIndex1 == oyuncuIndex2);
                    //seçilen isimleri ile aynı ismi taşıyan resimleri gösterir
                    pcbxOyuncu1.ImageLocation = resimyol + oyuncuIsim1 + ".jpg";
                    pcbxOyuncu2.ImageLocation = resimyol + oyuncuIsim2 + ".jpg";
                    //Seçilen oyuncu isimlerini resimleri üzerine yazar
                    lbloyuncuIsim1.Text = oyuncuIsim1;
                    lbloyuncuIsim2.Text = oyuncuIsim2;
                    //seçilen isimlerin bir daha seçilmemesi için listboxtan bu isimleri siler
                    lstbxKizOyuncu.Items.Remove(oyuncuIsim1);
                    lstbxKizOyuncu.Items.Remove(oyuncuIsim2);
                    //silme işlemi sonunda kız oyuncu sayısı 2'nin altına inerse kız-kız eşleşmesi olmayacağı için
                    //bu radio butonu pasif yapar
                    if (lstbxKizOyuncu.Items.Count < 2)
                    {
                        rbtnKizKiz.Enabled = false;
                        //silme işlemi sonunda kız oyuncu sayısı 1'nin altına inerse Erkek-Kız eşleşmesi olmayacağı için
                        //bu radio butonu pasif yapar
                        if (lstbxKizOyuncu.Items.Count<1)
                        {
                            rbtnErkekKiz.Enabled = false;
                        }
                    }

                }

            }
            //Kız-Kız eşlemesinin tekrar yapılabilmesi için radiobutonu seçim sonrası tekrar pasifleştir
            rbtnKizKiz.Checked = false;
            grpbxEslesmeTuru.Enabled = false;
            tmrkazanan.Start();
        }

        private void rbtnErkekErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (lstbxErkekOyuncu.Items.Count > 1)
            {
                if (rbtnErkekErkek.Checked)
                {
                    do
                    {
                        oyuncuIndex1 = rnd.Next(0, lstbxErkekOyuncu.Items.Count);
                        oyuncuIndex2 = rnd.Next(0, lstbxErkekOyuncu.Items.Count);
                        oyuncuIsim1 = lstbxErkekOyuncu.Items[oyuncuIndex1].ToString();
                        oyuncuIsim2 = lstbxErkekOyuncu.Items[oyuncuIndex2].ToString();

                    } while (oyuncuIndex1 == oyuncuIndex2);

                    pcbxOyuncu1.ImageLocation = resimyol + oyuncuIsim1 + ".jpg";
                    pcbxOyuncu2.ImageLocation = resimyol + oyuncuIsim2 + ".jpg";
                    lbloyuncuIsim1.Text = oyuncuIsim1;
                    lbloyuncuIsim2.Text = oyuncuIsim2;

                    lstbxErkekOyuncu.Items.Remove(oyuncuIsim1);
                    lstbxErkekOyuncu.Items.Remove(oyuncuIsim2);
                    if (lstbxErkekOyuncu.Items.Count < 2)
                    {
                        rbtnErkekErkek.Enabled = false;
                        if (lstbxErkekOyuncu.Items.Count<1)
                        {
                            rbtnErkekKiz.Enabled = false;
                        }
                    }

                }
            }
            rbtnErkekErkek.Checked = false;
        }

        private void rbtnErkekKiz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnErkekKiz.Checked)
            {
                //sıfır ile kız ve erkek oyuncu sayısı aralığında rastgele sayı üretir.
                //Kız ve erkek oyuncu isimleri ayrı ayrı listboxlarda saklandığı için benzersizlik kuralı aranmaz
                oyuncuIndex1 = rnd.Next(0, lstbxErkekOyuncu.Items.Count);
                oyuncuIndex2 = rnd.Next(0, lstbxKizOyuncu.Items.Count);
                //seçilen oyuncu isimlerinşi değişkenlere atar
                oyuncuIsim1 = lstbxErkekOyuncu.Items[oyuncuIndex1].ToString();
                oyuncuIsim2 = lstbxKizOyuncu.Items[oyuncuIndex2].ToString();
                //Oyuncu ismi ile aynı ismi taşıyan resmin görüntüler
                pcbxOyuncu1.ImageLocation = resimyol + oyuncuIsim1 + ".jpg";
                pcbxOyuncu2.ImageLocation = resimyol + oyuncuIsim2 + ".jpg";
                lbloyuncuIsim1.Text = oyuncuIsim1;
                lbloyuncuIsim2.Text = oyuncuIsim2;
                //Seçilen kız oyuncu adını kız oyuncuların yer aldığı listboxtan
                //Seçilen erkek oyuncu adını kız oyuncuların yer aldığı listboxtan siler
                lstbxErkekOyuncu.Items.Remove(oyuncuIsim1);
                lstbxKizOyuncu.Items.Remove(oyuncuIsim2);

                //silme sonunda kız ve erkek oyuncu sayısı 2'nin altına inerse Kız-Kız, Erkek-Erkek eşleşmesi yapılamayacağı için
                //radiobutonları pasif yapar
                if (lstbxErkekOyuncu.Items.Count < 2)
                {
                    rbtnErkekErkek.Enabled = false;
                }
                if (lstbxKizOyuncu.Items.Count < 2)
                {
                    rbtnKizKiz.Enabled = false;
                }

            }
            //Arka arkaya Erkek-Kız eşleşmesi seçilebilmesi için radiobutonu seçim sonrası pasifleştirir
            rbtnErkekKiz.Checked = false;
        }

        private void tmrkazanan_Tick(object sender, EventArgs e)
        {
            int kazananOyuncu = rnd.Next(0, 2);
          
            if (kazananOyuncu==0)
            { 
                lblkazananOyuncu.Text = "Kazanan Oyuncu=" + lbloyuncuIsim1.Text;
                pcbxOyuncu2.ImageLocation = resimyol + "bos.jpg";
               
                
            }
            if (kazananOyuncu==1)
            { lblkazananOyuncu.Text = "Kazanan Oyuncu=" + lbloyuncuIsim2.Text;
                pcbxOyuncu1.ImageLocation = resimyol + "bos.jpg";
               
            }
            grpbxEslesmeTuru.Enabled = true;
            lblkazananOyuncu.Text = "";
        }





    }
}
