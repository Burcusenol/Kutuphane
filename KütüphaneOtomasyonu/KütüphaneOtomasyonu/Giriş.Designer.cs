namespace KütüphaneOtomasyonu
{
    partial class Giriş
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
            this.groupboxgırıs = new System.Windows.Forms.GroupBox();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.TxtKullanıcı = new System.Windows.Forms.TextBox();
            this.Lblsıfre = new System.Windows.Forms.Label();
            this.LblKullanıcı = new System.Windows.Forms.Label();
            this.BtnGırıs = new System.Windows.Forms.Button();
            this.BtnVazgec = new System.Windows.Forms.Button();
            this.LblHata = new System.Windows.Forms.Label();
            this.BtnUye = new System.Windows.Forms.Button();
            this.groupboxgırıs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxgırıs
            // 
            this.groupboxgırıs.Controls.Add(this.TxtSıfre);
            this.groupboxgırıs.Controls.Add(this.TxtKullanıcı);
            this.groupboxgırıs.Controls.Add(this.Lblsıfre);
            this.groupboxgırıs.Controls.Add(this.LblKullanıcı);
            this.groupboxgırıs.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupboxgırıs.Location = new System.Drawing.Point(24, 12);
            this.groupboxgırıs.Name = "groupboxgırıs";
            this.groupboxgırıs.Size = new System.Drawing.Size(659, 241);
            this.groupboxgırıs.TabIndex = 0;
            this.groupboxgırıs.TabStop = false;
            this.groupboxgırıs.Text = "SeninKütüphanen";
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSıfre.Location = new System.Drawing.Point(388, 138);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.PasswordChar = '*';
            this.TxtSıfre.Size = new System.Drawing.Size(158, 32);
            this.TxtSıfre.TabIndex = 3;
            // 
            // TxtKullanıcı
            // 
            this.TxtKullanıcı.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullanıcı.Location = new System.Drawing.Point(388, 52);
            this.TxtKullanıcı.Name = "TxtKullanıcı";
            this.TxtKullanıcı.Size = new System.Drawing.Size(158, 32);
            this.TxtKullanıcı.TabIndex = 2;
            // 
            // Lblsıfre
            // 
            this.Lblsıfre.AutoSize = true;
            this.Lblsıfre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblsıfre.Location = new System.Drawing.Point(113, 138);
            this.Lblsıfre.Name = "Lblsıfre";
            this.Lblsıfre.Size = new System.Drawing.Size(67, 28);
            this.Lblsıfre.TabIndex = 1;
            this.Lblsıfre.Text = "Şifre:";
            // 
            // LblKullanıcı
            // 
            this.LblKullanıcı.AutoSize = true;
            this.LblKullanıcı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullanıcı.Location = new System.Drawing.Point(113, 59);
            this.LblKullanıcı.Name = "LblKullanıcı";
            this.LblKullanıcı.Size = new System.Drawing.Size(163, 28);
            this.LblKullanıcı.TabIndex = 0;
            this.LblKullanıcı.Text = "Kullanıcı Adı:";
            // 
            // BtnGırıs
            // 
            this.BtnGırıs.BackColor = System.Drawing.Color.Thistle;
            this.BtnGırıs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGırıs.Location = new System.Drawing.Point(274, 259);
            this.BtnGırıs.Name = "BtnGırıs";
            this.BtnGırıs.Size = new System.Drawing.Size(158, 54);
            this.BtnGırıs.TabIndex = 4;
            this.BtnGırıs.Text = "Giriş";
            this.BtnGırıs.UseVisualStyleBackColor = false;
            this.BtnGırıs.Click += new System.EventHandler(this.BtnGırıs_Click);
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.BackColor = System.Drawing.Color.Thistle;
            this.BtnVazgec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVazgec.Location = new System.Drawing.Point(494, 259);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(158, 54);
            this.BtnVazgec.TabIndex = 5;
            this.BtnVazgec.Text = "Vazgeç";
            this.BtnVazgec.UseVisualStyleBackColor = false;
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // LblHata
            // 
            this.LblHata.AutoSize = true;
            this.LblHata.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHata.Location = new System.Drawing.Point(185, 358);
            this.LblHata.Name = "LblHata";
            this.LblHata.Size = new System.Drawing.Size(368, 28);
            this.LblHata.TabIndex = 6;
            this.LblHata.Text = "Kullanıcı Adı Veya Şifre Yanlış! ";
            this.LblHata.Click += new System.EventHandler(this.LblHata_Click);
            // 
            // BtnUye
            // 
            this.BtnUye.BackColor = System.Drawing.Color.Thistle;
            this.BtnUye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUye.Location = new System.Drawing.Point(47, 259);
            this.BtnUye.Name = "BtnUye";
            this.BtnUye.Size = new System.Drawing.Size(162, 52);
            this.BtnUye.TabIndex = 7;
            this.BtnUye.Text = "Üye Ol";
            this.BtnUye.UseVisualStyleBackColor = false;
            this.BtnUye.Click += new System.EventHandler(this.BtnUye_Click);
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(766, 421);
            this.Controls.Add(this.BtnUye);
            this.Controls.Add(this.LblHata);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.BtnGırıs);
            this.Controls.Add(this.groupboxgırıs);
            this.Name = "Giriş";
            this.Text = "Giriş";
            this.groupboxgırıs.ResumeLayout(false);
            this.groupboxgırıs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxgırıs;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.TextBox TxtKullanıcı;
        private System.Windows.Forms.Label Lblsıfre;
        private System.Windows.Forms.Label LblKullanıcı;
        private System.Windows.Forms.Button BtnGırıs;
        private System.Windows.Forms.Button BtnVazgec;
        private System.Windows.Forms.Label LblHata;
        private System.Windows.Forms.Button BtnUye;
    }
}