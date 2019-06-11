namespace tekCift
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
            this.btn_tek = new System.Windows.Forms.Button();
            this.btn_cift = new System.Windows.Forms.Button();
            this.txt_kücüksayi = new System.Windows.Forms.TextBox();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.txt_büyüksayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tek
            // 
            this.btn_tek.Location = new System.Drawing.Point(89, 131);
            this.btn_tek.Name = "btn_tek";
            this.btn_tek.Size = new System.Drawing.Size(75, 23);
            this.btn_tek.TabIndex = 0;
            this.btn_tek.Text = "TEK SAYI";
            this.btn_tek.UseVisualStyleBackColor = true;
            this.btn_tek.Click += new System.EventHandler(this.btn_tek_Click);
            // 
            // btn_cift
            // 
            this.btn_cift.Location = new System.Drawing.Point(187, 131);
            this.btn_cift.Name = "btn_cift";
            this.btn_cift.Size = new System.Drawing.Size(75, 23);
            this.btn_cift.TabIndex = 1;
            this.btn_cift.Text = "ÇİFT SAYI";
            this.btn_cift.UseVisualStyleBackColor = true;
            this.btn_cift.Click += new System.EventHandler(this.btn_cift_Click);
            // 
            // txt_kücüksayi
            // 
            this.txt_kücüksayi.Location = new System.Drawing.Point(170, 33);
            this.txt_kücüksayi.Name = "txt_kücüksayi";
            this.txt_kücüksayi.Size = new System.Drawing.Size(92, 20);
            this.txt_kücüksayi.TabIndex = 2;
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Location = new System.Drawing.Point(15, 186);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(247, 20);
            this.txt_sonuc.TabIndex = 3;
            // 
            // txt_büyüksayi
            // 
            this.txt_büyüksayi.Location = new System.Drawing.Point(170, 81);
            this.txt_büyüksayi.Name = "txt_büyüksayi";
            this.txt_büyüksayi.Size = new System.Drawing.Size(92, 20);
            this.txt_büyüksayi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Başlangıç Değerini Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bitiş Değerini Giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 237);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_büyüksayi);
            this.Controls.Add(this.txt_sonuc);
            this.Controls.Add(this.txt_kücüksayi);
            this.Controls.Add(this.btn_cift);
            this.Controls.Add(this.btn_tek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tek;
        private System.Windows.Forms.Button btn_cift;
        private System.Windows.Forms.TextBox txt_kücüksayi;
        private System.Windows.Forms.TextBox txt_sonuc;
        private System.Windows.Forms.TextBox txt_büyüksayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

