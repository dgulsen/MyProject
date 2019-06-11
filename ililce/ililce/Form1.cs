using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ililce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet dsgelenbilgi = new DataSet();
        DataSet yedekiller = new DataSet();
        OleDbDataAdapter adpverial = new OleDbDataAdapter();
        string vtyol = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ililce.accdb";
        string plaka;
        OleDbConnection cntbaglanti;
        string sorgu;
        private void Form1_Load(object sender, EventArgs e)
        {
            cntbaglanti = new OleDbConnection(vtyol);
            sorgu = "select * from bolgeler";
            adpverial = new OleDbDataAdapter(sorgu, cntbaglanti);
            adpverial.Fill(dsgelenbilgi, "bolgeler");
            for (int i = 0; i < dsgelenbilgi.Tables["bolgeler"].Rows.Count; i++)
            {
                cmbox_bolgeler.Items.Add(dsgelenbilgi.Tables["bolgeler"].Rows[i][1].ToString());
                cmbox_bolgesecimi.Items.Add(dsgelenbilgi.Tables["bolgeler"].Rows[i][1].ToString());
            }
            bolgeler();
        }
        public void bolgeler()
        {
            sorgu = "select * from iller";
            adpverial = new OleDbDataAdapter(sorgu, cntbaglanti);
            adpverial.Fill(yedekiller, "iller");
            for (int i = 0; i < yedekiller.Tables["iller"].Rows.Count; i++)
            {
                if (yedekiller.Tables["iller"].Rows[i][2].ToString() == "")
                {
                    cmbox_ilsecimi.Items.Add(yedekiller.Tables["iller"].Rows[i][1].ToString());
                    lstbox_atanmayaniller.Items.Add(yedekiller.Tables["iller"].Rows[i][1].ToString());
                }
            }
        }
        public void bolgeler(string asd)
        {
            sorgu = "select * from iller";
            adpverial = new OleDbDataAdapter(sorgu, cntbaglanti);
            adpverial.Fill(dsgelenbilgi, "iller");
            for (int i = 0; i < 81; i++)
            {
                if (dsgelenbilgi.Tables["iller"].Rows[i][2].ToString() == asd)
                    cmbox_ilsecimi.Items.Add(dsgelenbilgi.Tables["iller"].Rows[i][1].ToString());
            }
        }
        private void cmbox_bolgesecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbox_ilsecimi.Items.Clear();
            cmbox_ilsecimi.SelectedText = "";
            if (lstbox_atanmayaniller.Items.Count == 0)
            {
                cmbox_ilcesecimi.Enabled = true;
                cmbox_ilsecimi.Enabled = true;
            }
            bolgeler(cmbox_bolgesecimi.SelectedItem.ToString());
        }
        private void cmbox_ilsecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (dsgelenbilgi.Tables["iller"].Rows[i][1].ToString()==cmbox_ilsecimi.SelectedItem.ToString())
                    plaka = dsgelenbilgi.Tables["iller"].Rows[i][0].ToString();
            }
            cmbox_ilcesecimi.Items.Clear();
            sorgu = "select * from ilceler";
            adpverial = new OleDbDataAdapter(sorgu, cntbaglanti);
            adpverial.Fill(dsgelenbilgi, "ilceler");
            for (int i = 0; i < 911; i++)
            {
                if (dsgelenbilgi.Tables["ilceler"].Rows[i][2].ToString() == plaka)
                    cmbox_ilcesecimi.Items.Add(dsgelenbilgi.Tables["ilceler"].Rows[i][1].ToString());
            }
        }
        private void cmbox_bolgeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbox_atanmayaniller.Items.Clear();
            lstbox_secilibolgeilleri.Items.Clear();
            if (cmbox_bolgeler.SelectedItem.ToString() == cmbox_bolgeler.SelectedItem.ToString())
            {
                for (int i = 0; i < yedekiller.Tables["iller"].Rows.Count; i++)
                {
                    if (yedekiller.Tables["iller"].Rows[i][2].ToString() == "")
                        lstbox_atanmayaniller.Items.Add(yedekiller.Tables["iller"].Rows[i][1].ToString());
                    else if (yedekiller.Tables["iller"].Rows[i][2].ToString() == cmbox_bolgeler.SelectedItem.ToString())
                        lstbox_secilibolgeilleri.Items.Add(yedekiller.Tables["iller"].Rows[i][1].ToString());
                }

            }
        }
        string iladi;
        private void lstbox_atanmayaniller_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            iladi = lstbox_atanmayaniller.SelectedItem.ToString();
            lstbox_secilibolgeilleri.Items.Add(lstbox_atanmayaniller.SelectedItem.ToString());
            lstbox_atanmayaniller.Items.Remove(lstbox_atanmayaniller.SelectedItem.ToString());
            for (int i = 0; i < yedekiller.Tables["iller"].Rows.Count; i++)
            {
                if (yedekiller.Tables["iller"].Rows[i][1].ToString() == iladi)
                    yedekiller.Tables["iller"].Rows[i][2] = cmbox_bolgeler.SelectedItem;
            }
            OleDbCommandBuilder atama = new OleDbCommandBuilder(adpverial);
            adpverial.Update(yedekiller.Tables["iller"]);
        }
        private void lstbox_secilibolgeilleri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            iladi = lstbox_secilibolgeilleri.SelectedItem.ToString();
            lstbox_atanmayaniller.Items.Add(lstbox_secilibolgeilleri.SelectedItem.ToString());
            lstbox_secilibolgeilleri.Items.Remove(lstbox_secilibolgeilleri.SelectedItem.ToString());
            for (int i = 0; i < yedekiller.Tables["iller"].Rows.Count; i++)
            {
                if (yedekiller.Tables["iller"].Rows[i][1].ToString() == iladi)
                    yedekiller.Tables["iller"].Rows[i][2] = "";
            }
            OleDbCommandBuilder atama = new OleDbCommandBuilder(adpverial);
            adpverial.Update(yedekiller.Tables["iller"]);
        }
    }
}
