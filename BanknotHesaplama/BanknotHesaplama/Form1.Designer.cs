namespace BanknotHesaplama
{
    partial class frmbanknot
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtparaMiktari = new System.Windows.Forms.TextBox();
            this.btntamam = new System.Windows.Forms.Button();
            this.lbllira = new System.Windows.Forms.Label();
            this.lblkurus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grpbxresimler = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para Miktarını Giriniz";
            // 
            // txtparaMiktari
            // 
            this.txtparaMiktari.Location = new System.Drawing.Point(159, 34);
            this.txtparaMiktari.Name = "txtparaMiktari";
            this.txtparaMiktari.Size = new System.Drawing.Size(149, 20);
            this.txtparaMiktari.TabIndex = 1;
            // 
            // btntamam
            // 
            this.btntamam.Location = new System.Drawing.Point(233, 84);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(75, 23);
            this.btntamam.TabIndex = 2;
            this.btntamam.Text = "Tamam";
            this.btntamam.UseVisualStyleBackColor = true;
            this.btntamam.Click += new System.EventHandler(this.btntamam_Click);
            // 
            // lbllira
            // 
            this.lbllira.AutoSize = true;
            this.lbllira.Location = new System.Drawing.Point(156, 69);
            this.lbllira.Name = "lbllira";
            this.lbllira.Size = new System.Drawing.Size(0, 13);
            this.lbllira.TabIndex = 3;
            // 
            // lblkurus
            // 
            this.lblkurus.AutoSize = true;
            this.lblkurus.Location = new System.Drawing.Point(240, 68);
            this.lblkurus.Name = "lblkurus";
            this.lblkurus.Size = new System.Drawing.Size(0, 13);
            this.lblkurus.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(336, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(60, 121);
            this.listBox1.TabIndex = 5;
            // 
            // grpbxresimler
            // 
            this.grpbxresimler.Location = new System.Drawing.Point(12, 151);
            this.grpbxresimler.Name = "grpbxresimler";
            this.grpbxresimler.Size = new System.Drawing.Size(421, 278);
            this.grpbxresimler.TabIndex = 6;
            this.grpbxresimler.TabStop = false;
            this.grpbxresimler.Text = "Banknot Adetleri";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(402, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(60, 121);
            this.listBox2.TabIndex = 7;
            // 
            // frmbanknot
            // 
            this.AcceptButton = this.btntamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(463, 494);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.grpbxresimler);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblkurus);
            this.Controls.Add(this.lbllira);
            this.Controls.Add(this.btntamam);
            this.Controls.Add(this.txtparaMiktari);
            this.Controls.Add(this.label1);
            this.Name = "frmbanknot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banknot Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtparaMiktari;
        private System.Windows.Forms.Button btntamam;
        private System.Windows.Forms.Label lbllira;
        private System.Windows.Forms.Label lblkurus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox grpbxresimler;
        private System.Windows.Forms.ListBox listBox2;
    }
}

