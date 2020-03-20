namespace KütüphaneOtomasyonu
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PcKullanıcı = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pckitap = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pcEmanet = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcKullanıcı)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pckitap)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmanet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PcKullanıcı);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(29, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı İşlemleri";
            // 
            // PcKullanıcı
            // 
            this.PcKullanıcı.Image = ((System.Drawing.Image)(resources.GetObject("PcKullanıcı.Image")));
            this.PcKullanıcı.Location = new System.Drawing.Point(53, 52);
            this.PcKullanıcı.Name = "PcKullanıcı";
            this.PcKullanıcı.Size = new System.Drawing.Size(138, 135);
            this.PcKullanıcı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcKullanıcı.TabIndex = 0;
            this.PcKullanıcı.TabStop = false;
            this.PcKullanıcı.Click += new System.EventHandler(this.PcKullanıcı_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pckitap);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(471, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // Pckitap
            // 
            this.Pckitap.Image = ((System.Drawing.Image)(resources.GetObject("Pckitap.Image")));
            this.Pckitap.Location = new System.Drawing.Point(68, 52);
            this.Pckitap.Name = "Pckitap";
            this.Pckitap.Size = new System.Drawing.Size(160, 135);
            this.Pckitap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pckitap.TabIndex = 0;
            this.Pckitap.TabStop = false;
            this.Pckitap.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(654, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pcEmanet);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(261, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 220);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // pcEmanet
            // 
            this.pcEmanet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pcEmanet.Image = ((System.Drawing.Image)(resources.GetObject("pcEmanet.Image")));
            this.pcEmanet.Location = new System.Drawing.Point(41, 42);
            this.pcEmanet.Name = "pcEmanet";
            this.pcEmanet.Size = new System.Drawing.Size(167, 146);
            this.pcEmanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmanet.TabIndex = 0;
            this.pcEmanet.TabStop = false;
            this.pcEmanet.Click += new System.EventHandler(this.pcEmanet_Click_2);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(797, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcKullanıcı)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pckitap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcEmanet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PcKullanıcı;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Pckitap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pcEmanet;
    }
}

