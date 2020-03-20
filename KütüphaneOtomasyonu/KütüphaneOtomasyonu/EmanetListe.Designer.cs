namespace KütüphaneOtomasyonu
{
    partial class EmanetListe
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
            this.button1Geri = new System.Windows.Forms.Button();
            this.dataGridView1Emanet = new System.Windows.Forms.DataGridView();
            this.butonlistelemeEmanet = new System.Windows.Forms.Button();
            this.comboBox1Emanet = new System.Windows.Forms.ComboBox();
            this.LBlliste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Emanet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Geri
            // 
            this.button1Geri.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1Geri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1Geri.Location = new System.Drawing.Point(638, 378);
            this.button1Geri.Name = "button1Geri";
            this.button1Geri.Size = new System.Drawing.Size(114, 52);
            this.button1Geri.TabIndex = 9;
            this.button1Geri.Text = "Geri";
            this.button1Geri.UseVisualStyleBackColor = false;
            this.button1Geri.Click += new System.EventHandler(this.button1Geri_Click);
            // 
            // dataGridView1Emanet
            // 
            this.dataGridView1Emanet.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1Emanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Emanet.Location = new System.Drawing.Point(74, 71);
            this.dataGridView1Emanet.Name = "dataGridView1Emanet";
            this.dataGridView1Emanet.RowHeadersWidth = 51;
            this.dataGridView1Emanet.RowTemplate.Height = 24;
            this.dataGridView1Emanet.Size = new System.Drawing.Size(678, 290);
            this.dataGridView1Emanet.TabIndex = 8;
            // 
            // butonlistelemeEmanet
            // 
            this.butonlistelemeEmanet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butonlistelemeEmanet.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonlistelemeEmanet.Location = new System.Drawing.Point(412, 26);
            this.butonlistelemeEmanet.Name = "butonlistelemeEmanet";
            this.butonlistelemeEmanet.Size = new System.Drawing.Size(111, 39);
            this.butonlistelemeEmanet.TabIndex = 7;
            this.butonlistelemeEmanet.Text = "Listele";
            this.butonlistelemeEmanet.UseVisualStyleBackColor = false;
            this.butonlistelemeEmanet.Click += new System.EventHandler(this.butonlistelemeEmanet_Click);
            // 
            // comboBox1Emanet
            // 
            this.comboBox1Emanet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1Emanet.FormattingEnabled = true;
            this.comboBox1Emanet.Items.AddRange(new object[] {
            "Emanet Aldıklarım",
            "Emanet Verdiklerim"});
            this.comboBox1Emanet.Location = new System.Drawing.Point(193, 33);
            this.comboBox1Emanet.Name = "comboBox1Emanet";
            this.comboBox1Emanet.Size = new System.Drawing.Size(187, 26);
            this.comboBox1Emanet.TabIndex = 6;
            // 
            // LBlliste
            // 
            this.LBlliste.AutoSize = true;
            this.LBlliste.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBlliste.Location = new System.Drawing.Point(70, 33);
            this.LBlliste.Name = "LBlliste";
            this.LBlliste.Size = new System.Drawing.Size(57, 23);
            this.LBlliste.TabIndex = 5;
            this.LBlliste.Text = "Liste:";
            // 
            // EmanetListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1Geri);
            this.Controls.Add(this.dataGridView1Emanet);
            this.Controls.Add(this.butonlistelemeEmanet);
            this.Controls.Add(this.comboBox1Emanet);
            this.Controls.Add(this.LBlliste);
            this.Name = "EmanetListe";
            this.Text = "EmanetListe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Emanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Geri;
        private System.Windows.Forms.DataGridView dataGridView1Emanet;
        private System.Windows.Forms.Button butonlistelemeEmanet;
        private System.Windows.Forms.ComboBox comboBox1Emanet;
        private System.Windows.Forms.Label LBlliste;
    }
}