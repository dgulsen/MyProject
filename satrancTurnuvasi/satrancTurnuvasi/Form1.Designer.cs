namespace satrancTurnuvasi
{
    partial class frmSatranc
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
            this.grpbxEslesmeTuru = new System.Windows.Forms.GroupBox();
            this.rbtnErkekKiz = new System.Windows.Forms.RadioButton();
            this.rbtnErkekErkek = new System.Windows.Forms.RadioButton();
            this.rbtnKizKiz = new System.Windows.Forms.RadioButton();
            this.grpbxOyuncuGoster = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstbxKizOyuncu = new System.Windows.Forms.ListBox();
            this.lstbxErkekOyuncu = new System.Windows.Forms.ListBox();
            this.pcbxOyuncu2 = new System.Windows.Forms.PictureBox();
            this.pcbxOyuncu1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbloyuncuIsim1 = new System.Windows.Forms.Label();
            this.lbloyuncuIsim2 = new System.Windows.Forms.Label();
            this.tmrkazanan = new System.Windows.Forms.Timer(this.components);
            this.lblkazananOyuncu = new System.Windows.Forms.Label();
            this.grpbxEslesmeTuru.SuspendLayout();
            this.grpbxOyuncuGoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxOyuncu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxOyuncu1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxEslesmeTuru
            // 
            this.grpbxEslesmeTuru.Controls.Add(this.rbtnErkekKiz);
            this.grpbxEslesmeTuru.Controls.Add(this.rbtnErkekErkek);
            this.grpbxEslesmeTuru.Controls.Add(this.rbtnKizKiz);
            this.grpbxEslesmeTuru.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbxEslesmeTuru.Location = new System.Drawing.Point(23, 16);
            this.grpbxEslesmeTuru.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxEslesmeTuru.Name = "grpbxEslesmeTuru";
            this.grpbxEslesmeTuru.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxEslesmeTuru.Size = new System.Drawing.Size(439, 119);
            this.grpbxEslesmeTuru.TabIndex = 0;
            this.grpbxEslesmeTuru.TabStop = false;
            this.grpbxEslesmeTuru.Text = "Oyuncu Eşleşmesi";
            // 
            // rbtnErkekKiz
            // 
            this.rbtnErkekKiz.AutoSize = true;
            this.rbtnErkekKiz.Checked = true;
            this.rbtnErkekKiz.Location = new System.Drawing.Point(345, 47);
            this.rbtnErkekKiz.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnErkekKiz.Name = "rbtnErkekKiz";
            this.rbtnErkekKiz.Size = new System.Drawing.Size(85, 20);
            this.rbtnErkekKiz.TabIndex = 2;
            this.rbtnErkekKiz.TabStop = true;
            this.rbtnErkekKiz.Text = "Erkek-Kız";
            this.rbtnErkekKiz.UseVisualStyleBackColor = true;
            this.rbtnErkekKiz.CheckedChanged += new System.EventHandler(this.rbtnErkekKiz_CheckedChanged);
            // 
            // rbtnErkekErkek
            // 
            this.rbtnErkekErkek.AutoSize = true;
            this.rbtnErkekErkek.Location = new System.Drawing.Point(178, 47);
            this.rbtnErkekErkek.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnErkekErkek.Name = "rbtnErkekErkek";
            this.rbtnErkekErkek.Size = new System.Drawing.Size(100, 20);
            this.rbtnErkekErkek.TabIndex = 1;
            this.rbtnErkekErkek.Text = "Erkek-Erkek";
            this.rbtnErkekErkek.UseVisualStyleBackColor = true;
            this.rbtnErkekErkek.CheckedChanged += new System.EventHandler(this.rbtnErkekErkek_CheckedChanged);
            // 
            // rbtnKizKiz
            // 
            this.rbtnKizKiz.AutoSize = true;
            this.rbtnKizKiz.Location = new System.Drawing.Point(28, 47);
            this.rbtnKizKiz.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnKizKiz.Name = "rbtnKizKiz";
            this.rbtnKizKiz.Size = new System.Drawing.Size(70, 20);
            this.rbtnKizKiz.TabIndex = 0;
            this.rbtnKizKiz.Text = "Kız-Kız";
            this.rbtnKizKiz.UseVisualStyleBackColor = true;
            this.rbtnKizKiz.CheckedChanged += new System.EventHandler(this.rbtnKizKiz_CheckedChanged_1);
            // 
            // grpbxOyuncuGoster
            // 
            this.grpbxOyuncuGoster.Controls.Add(this.lblkazananOyuncu);
            this.grpbxOyuncuGoster.Controls.Add(this.lbloyuncuIsim2);
            this.grpbxOyuncuGoster.Controls.Add(this.lbloyuncuIsim1);
            this.grpbxOyuncuGoster.Controls.Add(this.label4);
            this.grpbxOyuncuGoster.Controls.Add(this.label3);
            this.grpbxOyuncuGoster.Controls.Add(this.lstbxKizOyuncu);
            this.grpbxOyuncuGoster.Controls.Add(this.lstbxErkekOyuncu);
            this.grpbxOyuncuGoster.Controls.Add(this.pcbxOyuncu2);
            this.grpbxOyuncuGoster.Controls.Add(this.pcbxOyuncu1);
            this.grpbxOyuncuGoster.Controls.Add(this.label2);
            this.grpbxOyuncuGoster.Controls.Add(this.label1);
            this.grpbxOyuncuGoster.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbxOyuncuGoster.Location = new System.Drawing.Point(12, 155);
            this.grpbxOyuncuGoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbxOyuncuGoster.Name = "grpbxOyuncuGoster";
            this.grpbxOyuncuGoster.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbxOyuncuGoster.Size = new System.Drawing.Size(481, 246);
            this.grpbxOyuncuGoster.TabIndex = 3;
            this.grpbxOyuncuGoster.TabStop = false;
            this.grpbxOyuncuGoster.Text = "Oyuncular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kız\r\nOyuncular";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Erkek\r\nOyuncular";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstbxKizOyuncu
            // 
            this.lstbxKizOyuncu.Enabled = false;
            this.lstbxKizOyuncu.FormattingEnabled = true;
            this.lstbxKizOyuncu.ItemHeight = 16;
            this.lstbxKizOyuncu.Location = new System.Drawing.Point(96, 82);
            this.lstbxKizOyuncu.Name = "lstbxKizOyuncu";
            this.lstbxKizOyuncu.Size = new System.Drawing.Size(75, 132);
            this.lstbxKizOyuncu.TabIndex = 5;
            // 
            // lstbxErkekOyuncu
            // 
            this.lstbxErkekOyuncu.Enabled = false;
            this.lstbxErkekOyuncu.FormattingEnabled = true;
            this.lstbxErkekOyuncu.ItemHeight = 16;
            this.lstbxErkekOyuncu.Location = new System.Drawing.Point(10, 81);
            this.lstbxErkekOyuncu.Name = "lstbxErkekOyuncu";
            this.lstbxErkekOyuncu.Size = new System.Drawing.Size(75, 132);
            this.lstbxErkekOyuncu.TabIndex = 4;
            // 
            // pcbxOyuncu2
            // 
            this.pcbxOyuncu2.BackColor = System.Drawing.Color.White;
            this.pcbxOyuncu2.Location = new System.Drawing.Point(331, 82);
            this.pcbxOyuncu2.Name = "pcbxOyuncu2";
            this.pcbxOyuncu2.Size = new System.Drawing.Size(130, 135);
            this.pcbxOyuncu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxOyuncu2.TabIndex = 3;
            this.pcbxOyuncu2.TabStop = false;
            // 
            // pcbxOyuncu1
            // 
            this.pcbxOyuncu1.BackColor = System.Drawing.Color.White;
            this.pcbxOyuncu1.Location = new System.Drawing.Point(187, 82);
            this.pcbxOyuncu1.Name = "pcbxOyuncu1";
            this.pcbxOyuncu1.Size = new System.Drawing.Size(130, 135);
            this.pcbxOyuncu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxOyuncu1.TabIndex = 2;
            this.pcbxOyuncu1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İkinci Oyuncu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birinci Oyuncu";
            // 
            // lbloyuncuIsim1
            // 
            this.lbloyuncuIsim1.AutoSize = true;
            this.lbloyuncuIsim1.ForeColor = System.Drawing.Color.Maroon;
            this.lbloyuncuIsim1.Location = new System.Drawing.Point(208, 59);
            this.lbloyuncuIsim1.Name = "lbloyuncuIsim1";
            this.lbloyuncuIsim1.Size = new System.Drawing.Size(0, 16);
            this.lbloyuncuIsim1.TabIndex = 8;
            // 
            // lbloyuncuIsim2
            // 
            this.lbloyuncuIsim2.AutoSize = true;
            this.lbloyuncuIsim2.ForeColor = System.Drawing.Color.Maroon;
            this.lbloyuncuIsim2.Location = new System.Drawing.Point(362, 58);
            this.lbloyuncuIsim2.Name = "lbloyuncuIsim2";
            this.lbloyuncuIsim2.Size = new System.Drawing.Size(0, 16);
            this.lbloyuncuIsim2.TabIndex = 9;
            // 
            // tmrkazanan
            // 
            this.tmrkazanan.Interval = 5000;
            this.tmrkazanan.Tick += new System.EventHandler(this.tmrkazanan_Tick);
            // 
            // lblkazananOyuncu
            // 
            this.lblkazananOyuncu.AutoSize = true;
            this.lblkazananOyuncu.ForeColor = System.Drawing.Color.Blue;
            this.lblkazananOyuncu.Location = new System.Drawing.Point(223, 224);
            this.lblkazananOyuncu.Name = "lblkazananOyuncu";
            this.lblkazananOyuncu.Size = new System.Drawing.Size(0, 16);
            this.lblkazananOyuncu.TabIndex = 10;
            // 
            // frmSatranc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(515, 414);
            this.Controls.Add(this.grpbxOyuncuGoster);
            this.Controls.Add(this.grpbxEslesmeTuru);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmSatranc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satranç Turnuvası";
            this.Load += new System.EventHandler(this.frmSatranc_Load);
            this.grpbxEslesmeTuru.ResumeLayout(false);
            this.grpbxEslesmeTuru.PerformLayout();
            this.grpbxOyuncuGoster.ResumeLayout(false);
            this.grpbxOyuncuGoster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxOyuncu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxOyuncu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxEslesmeTuru;
        private System.Windows.Forms.RadioButton rbtnErkekKiz;
        private System.Windows.Forms.RadioButton rbtnErkekErkek;
        private System.Windows.Forms.RadioButton rbtnKizKiz;
        private System.Windows.Forms.GroupBox grpbxOyuncuGoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbxOyuncu2;
        private System.Windows.Forms.PictureBox pcbxOyuncu1;
        private System.Windows.Forms.ListBox lstbxKizOyuncu;
        private System.Windows.Forms.ListBox lstbxErkekOyuncu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbloyuncuIsim2;
        private System.Windows.Forms.Label lbloyuncuIsim1;
        private System.Windows.Forms.Timer tmrkazanan;
        private System.Windows.Forms.Label lblkazananOyuncu;
    }
}

