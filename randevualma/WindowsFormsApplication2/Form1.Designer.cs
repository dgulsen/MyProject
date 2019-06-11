namespace WindowsFormsApplication2
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
            this.cbx_girissaat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_girisdakika = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_cikissaat = new System.Windows.Forms.ComboBox();
            this.cbx_cikisdakika = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbx_oglebitissaat = new System.Windows.Forms.ComboBox();
            this.cbx_oglebitisdakika = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_oglebassaat = new System.Windows.Forms.ComboBox();
            this.cbx_oglebasdakika = new System.Windows.Forms.ComboBox();
            this.lbx_randevu = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbx_gorusmedakika = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_tamam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_girissaat
            // 
            this.cbx_girissaat.FormattingEnabled = true;
            this.cbx_girissaat.Location = new System.Drawing.Point(7, 44);
            this.cbx_girissaat.Name = "cbx_girissaat";
            this.cbx_girissaat.Size = new System.Drawing.Size(52, 21);
            this.cbx_girissaat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saat";
            // 
            // cbx_girisdakika
            // 
            this.cbx_girisdakika.FormattingEnabled = true;
            this.cbx_girisdakika.Location = new System.Drawing.Point(84, 44);
            this.cbx_girisdakika.Name = "cbx_girisdakika";
            this.cbx_girisdakika.Size = new System.Drawing.Size(56, 21);
            this.cbx_girisdakika.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dakika";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_girissaat);
            this.groupBox1.Controls.Add(this.cbx_girisdakika);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Başlangıç saati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbx_cikissaat);
            this.groupBox2.Controls.Add(this.cbx_cikisdakika);
            this.groupBox2.Location = new System.Drawing.Point(12, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 82);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çıkış saati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Saat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dakika";
            // 
            // cbx_cikissaat
            // 
            this.cbx_cikissaat.FormattingEnabled = true;
            this.cbx_cikissaat.Location = new System.Drawing.Point(7, 39);
            this.cbx_cikissaat.Name = "cbx_cikissaat";
            this.cbx_cikissaat.Size = new System.Drawing.Size(52, 21);
            this.cbx_cikissaat.TabIndex = 5;
            // 
            // cbx_cikisdakika
            // 
            this.cbx_cikisdakika.FormattingEnabled = true;
            this.cbx_cikisdakika.Location = new System.Drawing.Point(84, 39);
            this.cbx_cikisdakika.Name = "cbx_cikisdakika";
            this.cbx_cikisdakika.Size = new System.Drawing.Size(56, 21);
            this.cbx_cikisdakika.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cbx_oglebitissaat);
            this.groupBox3.Controls.Add(this.cbx_oglebitisdakika);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbx_oglebassaat);
            this.groupBox3.Controls.Add(this.cbx_oglebasdakika);
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 159);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğle arası";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Bitiş";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(64, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Saat";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Dakika";
            // 
            // cbx_oglebitissaat
            // 
            this.cbx_oglebitissaat.FormattingEnabled = true;
            this.cbx_oglebitissaat.Location = new System.Drawing.Point(6, 126);
            this.cbx_oglebitissaat.Name = "cbx_oglebitissaat";
            this.cbx_oglebitissaat.Size = new System.Drawing.Size(52, 21);
            this.cbx_oglebitissaat.TabIndex = 11;
            // 
            // cbx_oglebitisdakika
            // 
            this.cbx_oglebitisdakika.FormattingEnabled = true;
            this.cbx_oglebitisdakika.Location = new System.Drawing.Point(83, 126);
            this.cbx_oglebitisdakika.Name = "cbx_oglebitisdakika";
            this.cbx_oglebitisdakika.Size = new System.Drawing.Size(56, 21);
            this.cbx_oglebitisdakika.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Başlangıç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Saat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dakika";
            // 
            // cbx_oglebassaat
            // 
            this.cbx_oglebassaat.FormattingEnabled = true;
            this.cbx_oglebassaat.Location = new System.Drawing.Point(6, 54);
            this.cbx_oglebassaat.Name = "cbx_oglebassaat";
            this.cbx_oglebassaat.Size = new System.Drawing.Size(52, 21);
            this.cbx_oglebassaat.TabIndex = 5;
            // 
            // cbx_oglebasdakika
            // 
            this.cbx_oglebasdakika.FormattingEnabled = true;
            this.cbx_oglebasdakika.Location = new System.Drawing.Point(83, 54);
            this.cbx_oglebasdakika.Name = "cbx_oglebasdakika";
            this.cbx_oglebasdakika.Size = new System.Drawing.Size(56, 21);
            this.cbx_oglebasdakika.TabIndex = 7;
            // 
            // lbx_randevu
            // 
            this.lbx_randevu.FormattingEnabled = true;
            this.lbx_randevu.Location = new System.Drawing.Point(22, 19);
            this.lbx_randevu.Name = "lbx_randevu";
            this.lbx_randevu.Size = new System.Drawing.Size(214, 277);
            this.lbx_randevu.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbx_randevu);
            this.groupBox4.Location = new System.Drawing.Point(187, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 320);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Listesi";
            // 
            // cbx_gorusmedakika
            // 
            this.cbx_gorusmedakika.FormattingEnabled = true;
            this.cbx_gorusmedakika.Location = new System.Drawing.Point(27, 25);
            this.cbx_gorusmedakika.Name = "cbx_gorusmedakika";
            this.cbx_gorusmedakika.Size = new System.Drawing.Size(106, 21);
            this.cbx_gorusmedakika.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbx_gorusmedakika);
            this.groupBox5.Location = new System.Drawing.Point(198, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 67);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Görüşme Sürsi";
            // 
            // btn_tamam
            // 
            this.btn_tamam.Location = new System.Drawing.Point(375, 28);
            this.btn_tamam.Name = "btn_tamam";
            this.btn_tamam.Size = new System.Drawing.Size(62, 37);
            this.btn_tamam.TabIndex = 16;
            this.btn_tamam.Text = "TAMAM";
            this.btn_tamam.UseVisualStyleBackColor = true;
            this.btn_tamam.Click += new System.EventHandler(this.btn_tamam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 412);
            this.Controls.Add(this.btn_tamam);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_girissaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_girisdakika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_cikissaat;
        private System.Windows.Forms.ComboBox cbx_cikisdakika;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbx_oglebitissaat;
        private System.Windows.Forms.ComboBox cbx_oglebitisdakika;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_oglebassaat;
        private System.Windows.Forms.ComboBox cbx_oglebasdakika;
        private System.Windows.Forms.ListBox lbx_randevu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbx_gorusmedakika;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_tamam;
    }
}

