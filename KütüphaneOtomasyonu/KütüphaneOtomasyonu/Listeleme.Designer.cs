namespace KütüphaneOtomasyonu
{
    partial class Listeleme
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
            this.LblLİste = new System.Windows.Forms.Label();
            this.Btngöster = new System.Windows.Forms.Button();
            this.txtgörüntüle = new System.Windows.Forms.TextBox();
            this.Btntumunugoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btngeridon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLİste
            // 
            this.LblLİste.AutoSize = true;
            this.LblLİste.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLİste.Location = new System.Drawing.Point(80, 48);
            this.LblLİste.Name = "LblLİste";
            this.LblLİste.Size = new System.Drawing.Size(163, 21);
            this.LblLİste.TabIndex = 0;
            this.LblLİste.Text = "Kullanıcı Görüntüle";
            // 
            // Btngöster
            // 
            this.Btngöster.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btngöster.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngöster.Location = new System.Drawing.Point(454, 42);
            this.Btngöster.Name = "Btngöster";
            this.Btngöster.Size = new System.Drawing.Size(106, 37);
            this.Btngöster.TabIndex = 1;
            this.Btngöster.Text = "Göster";
            this.Btngöster.UseVisualStyleBackColor = false;
            this.Btngöster.Click += new System.EventHandler(this.Btngöster_Click);
            // 
            // txtgörüntüle
            // 
            this.txtgörüntüle.Location = new System.Drawing.Point(315, 48);
            this.txtgörüntüle.Name = "txtgörüntüle";
            this.txtgörüntüle.Size = new System.Drawing.Size(109, 22);
            this.txtgörüntüle.TabIndex = 2;
            // 
            // Btntumunugoster
            // 
            this.Btntumunugoster.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btntumunugoster.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btntumunugoster.Location = new System.Drawing.Point(586, 40);
            this.Btntumunugoster.Name = "Btntumunugoster";
            this.Btntumunugoster.Size = new System.Drawing.Size(240, 39);
            this.Btntumunugoster.TabIndex = 3;
            this.Btntumunugoster.Text = "Tüm Kullanıcıları Göster";
            this.Btntumunugoster.UseVisualStyleBackColor = false;
            this.Btntumunugoster.Click += new System.EventHandler(this.Btntumunugoster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(715, 288);
            this.dataGridView1.TabIndex = 4;
            // 
            // Btngeridon
            // 
            this.Btngeridon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btngeridon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngeridon.Location = new System.Drawing.Point(713, 430);
            this.Btngeridon.Name = "Btngeridon";
            this.Btngeridon.Size = new System.Drawing.Size(94, 41);
            this.Btngeridon.TabIndex = 5;
            this.Btngeridon.Text = "Geri";
            this.Btngeridon.UseVisualStyleBackColor = false;
            this.Btngeridon.Click += new System.EventHandler(this.Btngeridon_Click);
            // 
            // Listeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(903, 510);
            this.Controls.Add(this.Btngeridon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btntumunugoster);
            this.Controls.Add(this.txtgörüntüle);
            this.Controls.Add(this.Btngöster);
            this.Controls.Add(this.LblLİste);
            this.Name = "Listeleme";
            this.Text = "Listeleme";
            this.Load += new System.EventHandler(this.Listeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLİste;
        private System.Windows.Forms.Button Btngöster;
        private System.Windows.Forms.TextBox txtgörüntüle;
        private System.Windows.Forms.Button Btntumunugoster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btngeridon;
    }
}