namespace KütüphaneOtomasyonu
{
    partial class Kullanıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanıcı));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PcGüncelle = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PcListe = new System.Windows.Forms.PictureBox();
            this.BTnAnaMenü = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcGüncelle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PcGüncelle);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgilerimi Güncelle";
            // 
            // PcGüncelle
            // 
            this.PcGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("PcGüncelle.Image")));
            this.PcGüncelle.Location = new System.Drawing.Point(44, 31);
            this.PcGüncelle.Name = "PcGüncelle";
            this.PcGüncelle.Size = new System.Drawing.Size(170, 156);
            this.PcGüncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcGüncelle.TabIndex = 0;
            this.PcGüncelle.TabStop = false;
            this.PcGüncelle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PcListe);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(383, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Listesi ";
            // 
            // PcListe
            // 
            this.PcListe.Image = ((System.Drawing.Image)(resources.GetObject("PcListe.Image")));
            this.PcListe.Location = new System.Drawing.Point(52, 31);
            this.PcListe.Name = "PcListe";
            this.PcListe.Size = new System.Drawing.Size(184, 156);
            this.PcListe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcListe.TabIndex = 0;
            this.PcListe.TabStop = false;
            this.PcListe.Click += new System.EventHandler(this.PcListe_Click);
            // 
            // BTnAnaMenü
            // 
            this.BTnAnaMenü.BackColor = System.Drawing.Color.Thistle;
            this.BTnAnaMenü.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTnAnaMenü.Location = new System.Drawing.Point(200, 334);
            this.BTnAnaMenü.Name = "BTnAnaMenü";
            this.BTnAnaMenü.Size = new System.Drawing.Size(263, 53);
            this.BTnAnaMenü.TabIndex = 2;
            this.BTnAnaMenü.Text = "Ana Menüye Dön";
            this.BTnAnaMenü.UseVisualStyleBackColor = false;
            this.BTnAnaMenü.Click += new System.EventHandler(this.BTnAnaMenü_Click);
            // 
            // Kullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.BTnAnaMenü);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kullanıcı";
            this.Text = "Kullanıcı";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcGüncelle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PcGüncelle;
        private System.Windows.Forms.PictureBox PcListe;
        private System.Windows.Forms.Button BTnAnaMenü;
    }
}