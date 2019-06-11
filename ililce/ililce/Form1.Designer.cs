namespace ililce
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbox_bolgeler = new System.Windows.Forms.GroupBox();
            this.lstbox_secilibolgeilleri = new System.Windows.Forms.ListBox();
            this.lbl_secilibolgeilleri = new System.Windows.Forms.Label();
            this.lstbox_atanmayaniller = new System.Windows.Forms.ListBox();
            this.lbl_atanmayaniller = new System.Windows.Forms.Label();
            this.lbl_bolgesecim = new System.Windows.Forms.Label();
            this.cmbox_bolgeler = new System.Windows.Forms.ComboBox();
            this.grpbox_secim = new System.Windows.Forms.GroupBox();
            this.cmbox_ilcesecimi = new System.Windows.Forms.ComboBox();
            this.lbl_ilcesecimi = new System.Windows.Forms.Label();
            this.cmbox_ilsecimi = new System.Windows.Forms.ComboBox();
            this.lbl_ilsecimi = new System.Windows.Forms.Label();
            this.cmbox_bolgesecimi = new System.Windows.Forms.ComboBox();
            this.lbl_bolgesecimi = new System.Windows.Forms.Label();
            this.grpbox_bolgeler.SuspendLayout();
            this.grpbox_secim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_bolgeler
            // 
            this.grpbox_bolgeler.Controls.Add(this.lstbox_secilibolgeilleri);
            this.grpbox_bolgeler.Controls.Add(this.lbl_secilibolgeilleri);
            this.grpbox_bolgeler.Controls.Add(this.lstbox_atanmayaniller);
            this.grpbox_bolgeler.Controls.Add(this.lbl_atanmayaniller);
            this.grpbox_bolgeler.Controls.Add(this.lbl_bolgesecim);
            this.grpbox_bolgeler.Controls.Add(this.cmbox_bolgeler);
            this.grpbox_bolgeler.Location = new System.Drawing.Point(0, 0);
            this.grpbox_bolgeler.Name = "grpbox_bolgeler";
            this.grpbox_bolgeler.Size = new System.Drawing.Size(404, 378);
            this.grpbox_bolgeler.TabIndex = 0;
            this.grpbox_bolgeler.TabStop = false;
            this.grpbox_bolgeler.Text = "Bölgelere İl Atama";
            // 
            // lstbox_secilibolgeilleri
            // 
            this.lstbox_secilibolgeilleri.FormattingEnabled = true;
            this.lstbox_secilibolgeilleri.Location = new System.Drawing.Point(216, 140);
            this.lstbox_secilibolgeilleri.Name = "lstbox_secilibolgeilleri";
            this.lstbox_secilibolgeilleri.Size = new System.Drawing.Size(165, 225);
            this.lstbox_secilibolgeilleri.TabIndex = 5;
            this.lstbox_secilibolgeilleri.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbox_secilibolgeilleri_MouseDoubleClick);
            // 
            // lbl_secilibolgeilleri
            // 
            this.lbl_secilibolgeilleri.AutoSize = true;
            this.lbl_secilibolgeilleri.Location = new System.Drawing.Point(261, 107);
            this.lbl_secilibolgeilleri.Name = "lbl_secilibolgeilleri";
            this.lbl_secilibolgeilleri.Size = new System.Drawing.Size(83, 13);
            this.lbl_secilibolgeilleri.TabIndex = 4;
            this.lbl_secilibolgeilleri.Text = "Seçili Bölge İlleri";
            // 
            // lstbox_atanmayaniller
            // 
            this.lstbox_atanmayaniller.FormattingEnabled = true;
            this.lstbox_atanmayaniller.Location = new System.Drawing.Point(9, 140);
            this.lstbox_atanmayaniller.Name = "lstbox_atanmayaniller";
            this.lstbox_atanmayaniller.Size = new System.Drawing.Size(165, 225);
            this.lstbox_atanmayaniller.TabIndex = 3;
            this.lstbox_atanmayaniller.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbox_atanmayaniller_MouseDoubleClick);
            // 
            // lbl_atanmayaniller
            // 
            this.lbl_atanmayaniller.AutoSize = true;
            this.lbl_atanmayaniller.Location = new System.Drawing.Point(6, 107);
            this.lbl_atanmayaniller.Name = "lbl_atanmayaniller";
            this.lbl_atanmayaniller.Size = new System.Drawing.Size(120, 13);
            this.lbl_atanmayaniller.TabIndex = 2;
            this.lbl_atanmayaniller.Text = "Bölgeye Atanmayan İller";
            // 
            // lbl_bolgesecim
            // 
            this.lbl_bolgesecim.AutoSize = true;
            this.lbl_bolgesecim.Location = new System.Drawing.Point(144, 33);
            this.lbl_bolgesecim.Name = "lbl_bolgesecim";
            this.lbl_bolgesecim.Size = new System.Drawing.Size(71, 13);
            this.lbl_bolgesecim.TabIndex = 1;
            this.lbl_bolgesecim.Text = "Bölge Seçiniz";
            // 
            // cmbox_bolgeler
            // 
            this.cmbox_bolgeler.FormattingEnabled = true;
            this.cmbox_bolgeler.Location = new System.Drawing.Point(63, 49);
            this.cmbox_bolgeler.Name = "cmbox_bolgeler";
            this.cmbox_bolgeler.Size = new System.Drawing.Size(272, 21);
            this.cmbox_bolgeler.TabIndex = 0;
            this.cmbox_bolgeler.SelectedIndexChanged += new System.EventHandler(this.cmbox_bolgeler_SelectedIndexChanged);
            // 
            // grpbox_secim
            // 
            this.grpbox_secim.Controls.Add(this.cmbox_ilcesecimi);
            this.grpbox_secim.Controls.Add(this.lbl_ilcesecimi);
            this.grpbox_secim.Controls.Add(this.cmbox_ilsecimi);
            this.grpbox_secim.Controls.Add(this.lbl_ilsecimi);
            this.grpbox_secim.Controls.Add(this.cmbox_bolgesecimi);
            this.grpbox_secim.Controls.Add(this.lbl_bolgesecimi);
            this.grpbox_secim.Location = new System.Drawing.Point(423, 90);
            this.grpbox_secim.Name = "grpbox_secim";
            this.grpbox_secim.Size = new System.Drawing.Size(329, 214);
            this.grpbox_secim.TabIndex = 1;
            this.grpbox_secim.TabStop = false;
            this.grpbox_secim.Text = "İlçe Seçimi";
            // 
            // cmbox_ilcesecimi
            // 
            this.cmbox_ilcesecimi.Enabled = false;
            this.cmbox_ilcesecimi.FormattingEnabled = true;
            this.cmbox_ilcesecimi.Location = new System.Drawing.Point(25, 161);
            this.cmbox_ilcesecimi.Name = "cmbox_ilcesecimi";
            this.cmbox_ilcesecimi.Size = new System.Drawing.Size(272, 21);
            this.cmbox_ilcesecimi.TabIndex = 5;
            // 
            // lbl_ilcesecimi
            // 
            this.lbl_ilcesecimi.AutoSize = true;
            this.lbl_ilcesecimi.Location = new System.Drawing.Point(114, 145);
            this.lbl_ilcesecimi.Name = "lbl_ilcesecimi";
            this.lbl_ilcesecimi.Size = new System.Drawing.Size(61, 13);
            this.lbl_ilcesecimi.TabIndex = 4;
            this.lbl_ilcesecimi.Text = "İlçe Seçiniz";
            // 
            // cmbox_ilsecimi
            // 
            this.cmbox_ilsecimi.Enabled = false;
            this.cmbox_ilsecimi.FormattingEnabled = true;
            this.cmbox_ilsecimi.Location = new System.Drawing.Point(25, 96);
            this.cmbox_ilsecimi.Name = "cmbox_ilsecimi";
            this.cmbox_ilsecimi.Size = new System.Drawing.Size(272, 21);
            this.cmbox_ilsecimi.TabIndex = 3;
            this.cmbox_ilsecimi.SelectedIndexChanged += new System.EventHandler(this.cmbox_ilsecimi_SelectedIndexChanged);
            // 
            // lbl_ilsecimi
            // 
            this.lbl_ilsecimi.AutoSize = true;
            this.lbl_ilsecimi.Location = new System.Drawing.Point(114, 80);
            this.lbl_ilsecimi.Name = "lbl_ilsecimi";
            this.lbl_ilsecimi.Size = new System.Drawing.Size(47, 13);
            this.lbl_ilsecimi.TabIndex = 2;
            this.lbl_ilsecimi.Text = "İl seçiniz";
            // 
            // cmbox_bolgesecimi
            // 
            this.cmbox_bolgesecimi.FormattingEnabled = true;
            this.cmbox_bolgesecimi.Location = new System.Drawing.Point(25, 39);
            this.cmbox_bolgesecimi.Name = "cmbox_bolgesecimi";
            this.cmbox_bolgesecimi.Size = new System.Drawing.Size(272, 21);
            this.cmbox_bolgesecimi.TabIndex = 1;
            this.cmbox_bolgesecimi.SelectedIndexChanged += new System.EventHandler(this.cmbox_bolgesecimi_SelectedIndexChanged);
            // 
            // lbl_bolgesecimi
            // 
            this.lbl_bolgesecimi.AutoSize = true;
            this.lbl_bolgesecimi.Location = new System.Drawing.Point(114, 23);
            this.lbl_bolgesecimi.Name = "lbl_bolgesecimi";
            this.lbl_bolgesecimi.Size = new System.Drawing.Size(71, 13);
            this.lbl_bolgesecimi.TabIndex = 0;
            this.lbl_bolgesecimi.Text = "Bölge Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 387);
            this.Controls.Add(this.grpbox_secim);
            this.Controls.Add(this.grpbox_bolgeler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbox_bolgeler.ResumeLayout(false);
            this.grpbox_bolgeler.PerformLayout();
            this.grpbox_secim.ResumeLayout(false);
            this.grpbox_secim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_bolgeler;
        private System.Windows.Forms.GroupBox grpbox_secim;
        private System.Windows.Forms.ListBox lstbox_secilibolgeilleri;
        private System.Windows.Forms.Label lbl_secilibolgeilleri;
        private System.Windows.Forms.ListBox lstbox_atanmayaniller;
        private System.Windows.Forms.Label lbl_atanmayaniller;
        private System.Windows.Forms.Label lbl_bolgesecim;
        private System.Windows.Forms.ComboBox cmbox_bolgeler;
        private System.Windows.Forms.ComboBox cmbox_ilcesecimi;
        private System.Windows.Forms.Label lbl_ilcesecimi;
        private System.Windows.Forms.ComboBox cmbox_ilsecimi;
        private System.Windows.Forms.Label lbl_ilsecimi;
        private System.Windows.Forms.ComboBox cmbox_bolgesecimi;
        private System.Windows.Forms.Label lbl_bolgesecimi;
    }
}

