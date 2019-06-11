namespace arabaYarisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_basla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_redcar = new System.Windows.Forms.PictureBox();
            this.pb_yellowcar = new System.Windows.Forms.PictureBox();
            this.pb_bluecar = new System.Windows.Forms.PictureBox();
            this.pb_whitecar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_redcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_yellowcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bluecar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_whitecar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_basla
            // 
            this.btn_basla.Location = new System.Drawing.Point(13, 12);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(72, 36);
            this.btn_basla.TabIndex = 0;
            this.btn_basla.Text = "BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_redcar
            // 
            this.pb_redcar.Image = ((System.Drawing.Image)(resources.GetObject("pb_redcar.Image")));
            this.pb_redcar.Location = new System.Drawing.Point(12, 64);
            this.pb_redcar.Name = "pb_redcar";
            this.pb_redcar.Size = new System.Drawing.Size(77, 36);
            this.pb_redcar.TabIndex = 5;
            this.pb_redcar.TabStop = false;
            // 
            // pb_yellowcar
            // 
            this.pb_yellowcar.Image = ((System.Drawing.Image)(resources.GetObject("pb_yellowcar.Image")));
            this.pb_yellowcar.Location = new System.Drawing.Point(12, 117);
            this.pb_yellowcar.Name = "pb_yellowcar";
            this.pb_yellowcar.Size = new System.Drawing.Size(77, 36);
            this.pb_yellowcar.TabIndex = 6;
            this.pb_yellowcar.TabStop = false;
            // 
            // pb_bluecar
            // 
            this.pb_bluecar.Image = ((System.Drawing.Image)(resources.GetObject("pb_bluecar.Image")));
            this.pb_bluecar.Location = new System.Drawing.Point(12, 170);
            this.pb_bluecar.Name = "pb_bluecar";
            this.pb_bluecar.Size = new System.Drawing.Size(77, 36);
            this.pb_bluecar.TabIndex = 7;
            this.pb_bluecar.TabStop = false;
            // 
            // pb_whitecar
            // 
            this.pb_whitecar.Image = ((System.Drawing.Image)(resources.GetObject("pb_whitecar.Image")));
            this.pb_whitecar.Location = new System.Drawing.Point(12, 224);
            this.pb_whitecar.Name = "pb_whitecar";
            this.pb_whitecar.Size = new System.Drawing.Size(77, 36);
            this.pb_whitecar.TabIndex = 8;
            this.pb_whitecar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(630, 274);
            this.Controls.Add(this.pb_whitecar);
            this.Controls.Add(this.pb_bluecar);
            this.Controls.Add(this.pb_yellowcar);
            this.Controls.Add(this.pb_redcar);
            this.Controls.Add(this.btn_basla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_redcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_yellowcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bluecar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_whitecar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_redcar;
        private System.Windows.Forms.PictureBox pb_yellowcar;
        private System.Windows.Forms.PictureBox pb_bluecar;
        private System.Windows.Forms.PictureBox pb_whitecar;
    }
}

