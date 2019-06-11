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
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_cıkar = new System.Windows.Forms.Button();
            this.btn_böl = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.lbl_sayi1 = new System.Windows.Forms.Label();
            this.lbl_sayi2 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(12, 29);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(54, 20);
            this.txt_sayi1.TabIndex = 0;
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(12, 73);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(54, 20);
            this.txt_sayi2.TabIndex = 1;
            // 
            // btn_topla
            // 
            this.btn_topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_topla.Location = new System.Drawing.Point(85, 23);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(30, 30);
            this.btn_topla.TabIndex = 2;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_cıkar
            // 
            this.btn_cıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cıkar.Location = new System.Drawing.Point(85, 67);
            this.btn_cıkar.Name = "btn_cıkar";
            this.btn_cıkar.Size = new System.Drawing.Size(30, 30);
            this.btn_cıkar.TabIndex = 3;
            this.btn_cıkar.Text = "-";
            this.btn_cıkar.UseVisualStyleBackColor = true;
            this.btn_cıkar.Click += new System.EventHandler(this.btn_cıkar_Click);
            // 
            // btn_böl
            // 
            this.btn_böl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_böl.Location = new System.Drawing.Point(131, 23);
            this.btn_böl.Name = "btn_böl";
            this.btn_böl.Size = new System.Drawing.Size(30, 30);
            this.btn_böl.TabIndex = 4;
            this.btn_böl.Text = "/";
            this.btn_böl.UseVisualStyleBackColor = true;
            this.btn_böl.Click += new System.EventHandler(this.btn_böl_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carp.Location = new System.Drawing.Point(131, 67);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(30, 30);
            this.btn_carp.TabIndex = 5;
            this.btn_carp.Text = "*";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // lbl_sayi1
            // 
            this.lbl_sayi1.AutoSize = true;
            this.lbl_sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayi1.Location = new System.Drawing.Point(9, 9);
            this.lbl_sayi1.Name = "lbl_sayi1";
            this.lbl_sayi1.Size = new System.Drawing.Size(56, 13);
            this.lbl_sayi1.TabIndex = 6;
            this.lbl_sayi1.Text = "Sayı giriniz";
            // 
            // lbl_sayi2
            // 
            this.lbl_sayi2.AutoSize = true;
            this.lbl_sayi2.Location = new System.Drawing.Point(10, 57);
            this.lbl_sayi2.Name = "lbl_sayi2";
            this.lbl_sayi2.Size = new System.Drawing.Size(56, 13);
            this.lbl_sayi2.TabIndex = 7;
            this.lbl_sayi2.Text = "Sayı giriniz";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(180, 57);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(0, 13);
            this.lbl_sonuc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 120);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_sayi2);
            this.Controls.Add(this.lbl_sayi1);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_böl);
            this.Controls.Add(this.btn_cıkar);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.txt_sayi2);
            this.Controls.Add(this.txt_sayi1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_cıkar;
        private System.Windows.Forms.Button btn_böl;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Label lbl_sayi1;
        private System.Windows.Forms.Label lbl_sayi2;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

