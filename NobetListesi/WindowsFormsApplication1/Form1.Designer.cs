namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.cbx_ogrencilistesi = new System.Windows.Forms.ComboBox();
            this.lbx_nobetgunleri = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tamam = new System.Windows.Forms.Button();
            this.dtp_baslangic = new System.Windows.Forms.DateTimePicker();
            this.dtp_bitis = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sezerDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alakuşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ölümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_ogrencilistesi
            // 
            this.cbx_ogrencilistesi.FormattingEnabled = true;
            this.cbx_ogrencilistesi.Location = new System.Drawing.Point(21, 30);
            this.cbx_ogrencilistesi.Name = "cbx_ogrencilistesi";
            this.cbx_ogrencilistesi.Size = new System.Drawing.Size(166, 21);
            this.cbx_ogrencilistesi.TabIndex = 0;
            // 
            // lbx_nobetgunleri
            // 
            this.lbx_nobetgunleri.FormattingEnabled = true;
            this.lbx_nobetgunleri.Location = new System.Drawing.Point(16, 19);
            this.lbx_nobetgunleri.Name = "lbx_nobetgunleri";
            this.lbx_nobetgunleri.Size = new System.Drawing.Size(265, 121);
            this.lbx_nobetgunleri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bitiş tarihi";
            // 
            // btn_tamam
            // 
            this.btn_tamam.Location = new System.Drawing.Point(92, 68);
            this.btn_tamam.Name = "btn_tamam";
            this.btn_tamam.Size = new System.Drawing.Size(75, 47);
            this.btn_tamam.TabIndex = 7;
            this.btn_tamam.Text = "TAMAM";
            this.btn_tamam.UseVisualStyleBackColor = true;
            this.btn_tamam.Click += new System.EventHandler(this.btn_tamam_Click);
            // 
            // dtp_baslangic
            // 
            this.dtp_baslangic.Location = new System.Drawing.Point(6, 38);
            this.dtp_baslangic.MaxDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dtp_baslangic.MinDate = new System.DateTime(2013, 9, 1, 0, 0, 0, 0);
            this.dtp_baslangic.Name = "dtp_baslangic";
            this.dtp_baslangic.Size = new System.Drawing.Size(200, 20);
            this.dtp_baslangic.TabIndex = 8;
            this.dtp_baslangic.Value = new System.DateTime(2013, 9, 1, 0, 0, 0, 0);
            // 
            // dtp_bitis
            // 
            this.dtp_bitis.Location = new System.Drawing.Point(5, 91);
            this.dtp_bitis.MaxDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dtp_bitis.MinDate = new System.DateTime(2014, 6, 1, 0, 0, 0, 0);
            this.dtp_bitis.Name = "dtp_bitis";
            this.dtp_bitis.Size = new System.Drawing.Size(200, 20);
            this.dtp_bitis.TabIndex = 9;
            this.dtp_bitis.Value = new System.DateTime(2014, 6, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_baslangic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_bitis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbx_nobetgunleri);
            this.groupBox2.Location = new System.Drawing.Point(92, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 156);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nöbet Günleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbx_ogrencilistesi);
            this.groupBox3.Controls.Add(this.btn_tamam);
            this.groupBox3.Location = new System.Drawing.Point(245, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 127);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci seçiniz";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sezerDToolStripMenuItem,
            this.korayToolStripMenuItem,
            this.alakuşToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // sezerDToolStripMenuItem
            // 
            this.sezerDToolStripMenuItem.Name = "sezerDToolStripMenuItem";
            this.sezerDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sezerDToolStripMenuItem.Text = "Sezer..:D";
            // 
            // korayToolStripMenuItem
            // 
            this.korayToolStripMenuItem.Name = "korayToolStripMenuItem";
            this.korayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.korayToolStripMenuItem.Text = "Koray";
            // 
            // alakuşToolStripMenuItem
            // 
            this.alakuşToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ölümToolStripMenuItem,
            this.deadToolStripMenuItem});
            this.alakuşToolStripMenuItem.Name = "alakuşToolStripMenuItem";
            this.alakuşToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alakuşToolStripMenuItem.Text = "Alakuş";
            // 
            // ölümToolStripMenuItem
            // 
            this.ölümToolStripMenuItem.Name = "ölümToolStripMenuItem";
            this.ölümToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ölümToolStripMenuItem.Text = "Ölüm";
            // 
            // deadToolStripMenuItem
            // 
            this.deadToolStripMenuItem.Name = "deadToolStripMenuItem";
            this.deadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deadToolStripMenuItem.Text = "Dead";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_ogrencilistesi;
        private System.Windows.Forms.ListBox lbx_nobetgunleri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_tamam;
        private System.Windows.Forms.DateTimePicker dtp_baslangic;
        private System.Windows.Forms.DateTimePicker dtp_bitis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sezerDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alakuşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ölümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadToolStripMenuItem;

    }
}

