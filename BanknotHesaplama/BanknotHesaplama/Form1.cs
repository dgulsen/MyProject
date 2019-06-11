using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BanknotHesaplama
{
    public partial class frmbanknot : Form
    {
        public frmbanknot()
        {
            InitializeComponent();
        }
        double paraMiktari, kurusMiktari;
        int liraMiktari, kurusMik;
        int[] banknotDegeri = { 200, 100, 50, 20, 10, 5, 1 };
        int[] kurusDegeri = { 50, 25, 10, 5, 1 };
        int[] banknotAdeti = new int[7];
        int[] kurusAdeti = new int[5];
        private void btntamam_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            grpbxresimler.Controls.Clear();
            int pcbresimX = 0, pcbresimY = 20;
            string resimyol = Application.StartupPath + "\\paraResimleri\\";
            paraMiktari = Convert.ToDouble(txtparaMiktari.Text);
            liraMiktari = (int)paraMiktari;
            kurusMiktari = Math.Round((paraMiktari - liraMiktari), 2) * 100;
            kurusMik = Convert.ToInt16(kurusMiktari);
            lbllira.Text = liraMiktari.ToString() + "  Lira";
            lblkurus.Text = kurusMiktari.ToString() + "  Kurus";

            for (int i = 0; i < 7; i++)
            {
                banknotAdeti[i] = liraMiktari / banknotDegeri[i];
                liraMiktari = liraMiktari % banknotDegeri[i];
                listBox1.Items.Add(banknotDegeri[i].ToString() + "-->" + banknotAdeti[i].ToString());

                if (banknotAdeti[i] != 0)
                {
                    PictureBox pcbxbanknotResim = new PictureBox();
                    Label lblresimadet = new Label();
                    pcbxbanknotResim.Width = 100;
                    pcbxbanknotResim.Height = 100;
                    lblresimadet.Width = 78;
                    lblresimadet.Height = 15;
                    pcbxbanknotResim.ImageLocation = resimyol + banknotDegeri[i].ToString() + "lira.jpg";
                    pcbxbanknotResim.SizeMode = PictureBoxSizeMode.StretchImage;
                    pcbxbanknotResim.Location = new Point(pcbresimX * 100, pcbresimY);
                    lblresimadet.Text = banknotAdeti[i].ToString() + " Adet";
                    lblresimadet.Location = new Point((pcbresimX * 100) + 40, pcbresimY + 100);
                    pcbresimX++;
                    if (pcbresimX >= 4)
                    {
                        pcbresimX = 0;
                        pcbresimY = 150;
                    }
                    grpbxresimler.Controls.Add(lblresimadet);
                    grpbxresimler.Controls.Add(pcbxbanknotResim);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                kurusAdeti[i] = kurusMik / kurusDegeri[i];
                kurusMik = kurusMik % kurusDegeri[i];
                listBox2.Items.Add(kurusDegeri[i].ToString() + "-->" + kurusAdeti[i].ToString());
                if (kurusAdeti[i] != 0)
                {
                    PictureBox pcbxkurusResim = new PictureBox();
                    Label lblresimadet = new Label();
                    pcbxkurusResim.Width = 100;
                    pcbxkurusResim.Height = 100;
                    lblresimadet.Width = 78;
                    lblresimadet.Height = 15;
                    pcbxkurusResim.ImageLocation = resimyol + kurusDegeri[i].ToString() + "kurus.jpg";
                    pcbxkurusResim.SizeMode = PictureBoxSizeMode.StretchImage;
                    pcbxkurusResim.Location = new Point(pcbresimX * 100, pcbresimY);
                    lblresimadet.Text = kurusAdeti[i].ToString() + " Adet";
                    lblresimadet.Location = new Point((pcbresimX * 100) + 40, pcbresimY + 100);
                    pcbresimX++;
                    if (pcbresimX >= 4)
                    {
                        pcbresimX = 0;
                        pcbresimY = 150;
                    }
                    grpbxresimler.Controls.Add(lblresimadet);
                    grpbxresimler.Controls.Add(pcbxkurusResim);
                }
            }
        }
    }
}
