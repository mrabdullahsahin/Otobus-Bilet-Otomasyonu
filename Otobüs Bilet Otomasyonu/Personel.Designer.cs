namespace Otobüs_Bilet_Otomasyonu
{
    partial class Personel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.chcYeniEkle = new System.Windows.Forms.CheckBox();
            this.cmbPersonelMertebesi = new System.Windows.Forms.ComboBox();
            this.cmbPersonelYoneticiMi = new System.Windows.Forms.ComboBox();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.txtPersonelKAdi = new System.Windows.Forms.TextBox();
            this.txtPersonelAdresi = new System.Windows.Forms.TextBox();
            this.txtPersonelMail = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPersonelSube = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 597);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPersonelID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.chcYeniEkle);
            this.groupBox1.Controls.Add(this.cmbPersonelMertebesi);
            this.groupBox1.Controls.Add(this.cmbPersonelYoneticiMi);
            this.groupBox1.Controls.Add(this.txtPersonelSifre);
            this.groupBox1.Controls.Add(this.txtPersonelKAdi);
            this.groupBox1.Controls.Add(this.txtPersonelAdresi);
            this.groupBox1.Controls.Add(this.txtPersonelMail);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPersonelTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPersonelAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPersonelSube);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(795, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 598);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Enabled = false;
            this.txtPersonelID.Location = new System.Drawing.Point(166, 38);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(154, 27);
            this.txtPersonelID.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(16, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Personel ID:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(192, 558);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 27);
            this.btnEkle.TabIndex = 25;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chcYeniEkle
            // 
            this.chcYeniEkle.AutoSize = true;
            this.chcYeniEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chcYeniEkle.Location = new System.Drawing.Point(192, 561);
            this.chcYeniEkle.Name = "chcYeniEkle";
            this.chcYeniEkle.Size = new System.Drawing.Size(180, 23);
            this.chcYeniEkle.TabIndex = 24;
            this.chcYeniEkle.Text = "Yeni Personel Ekle";
            this.chcYeniEkle.UseVisualStyleBackColor = true;
            this.chcYeniEkle.CheckedChanged += new System.EventHandler(this.chcYeniEkle_CheckedChanged);
            // 
            // cmbPersonelMertebesi
            // 
            this.cmbPersonelMertebesi.FormattingEnabled = true;
            this.cmbPersonelMertebesi.Location = new System.Drawing.Point(168, 505);
            this.cmbPersonelMertebesi.Name = "cmbPersonelMertebesi";
            this.cmbPersonelMertebesi.Size = new System.Drawing.Size(154, 27);
            this.cmbPersonelMertebesi.TabIndex = 9;
            this.cmbPersonelMertebesi.SelectedIndexChanged += new System.EventHandler(this.cmbPersonelMertebesi_SelectedIndexChanged);
            // 
            // cmbPersonelYoneticiMi
            // 
            this.cmbPersonelYoneticiMi.FormattingEnabled = true;
            this.cmbPersonelYoneticiMi.Location = new System.Drawing.Point(167, 467);
            this.cmbPersonelYoneticiMi.Name = "cmbPersonelYoneticiMi";
            this.cmbPersonelYoneticiMi.Size = new System.Drawing.Size(155, 27);
            this.cmbPersonelYoneticiMi.TabIndex = 8;
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(168, 430);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.Size = new System.Drawing.Size(154, 27);
            this.txtPersonelSifre.TabIndex = 7;
            // 
            // txtPersonelKAdi
            // 
            this.txtPersonelKAdi.Location = new System.Drawing.Point(168, 394);
            this.txtPersonelKAdi.Name = "txtPersonelKAdi";
            this.txtPersonelKAdi.Size = new System.Drawing.Size(154, 27);
            this.txtPersonelKAdi.TabIndex = 6;
            // 
            // txtPersonelAdresi
            // 
            this.txtPersonelAdresi.Location = new System.Drawing.Point(167, 262);
            this.txtPersonelAdresi.Multiline = true;
            this.txtPersonelAdresi.Name = "txtPersonelAdresi";
            this.txtPersonelAdresi.Size = new System.Drawing.Size(155, 126);
            this.txtPersonelAdresi.TabIndex = 5;
            // 
            // txtPersonelMail
            // 
            this.txtPersonelMail.Location = new System.Drawing.Point(167, 224);
            this.txtPersonelMail.Name = "txtPersonelMail";
            this.txtPersonelMail.Size = new System.Drawing.Size(154, 27);
            this.txtPersonelMail.TabIndex = 4;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(97, 559);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 27);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(6, 559);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 27);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(30, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mertebesi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(21, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Yönetici Mi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(73, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Şifre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(10, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kullanıcı Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(35, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ev Adresi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(59, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail:";
            // 
            // txtPersonelTelefon
            // 
            this.txtPersonelTelefon.Location = new System.Drawing.Point(168, 176);
            this.txtPersonelTelefon.MaxLength = 11;
            this.txtPersonelTelefon.Name = "txtPersonelTelefon";
            this.txtPersonelTelefon.Size = new System.Drawing.Size(154, 27);
            this.txtPersonelTelefon.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(49, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon:";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(166, 124);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(155, 27);
            this.txtPersonelAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad Soyad:";
            // 
            // cmbPersonelSube
            // 
            this.cmbPersonelSube.FormattingEnabled = true;
            this.cmbPersonelSube.Location = new System.Drawing.Point(166, 80);
            this.cmbPersonelSube.Name = "cmbPersonelSube";
            this.cmbPersonelSube.Size = new System.Drawing.Size(155, 27);
            this.cmbPersonelSube.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(71, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şube:";
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1178, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personel";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chcYeniEkle;
        private System.Windows.Forms.ComboBox cmbPersonelMertebesi;
        private System.Windows.Forms.ComboBox cmbPersonelYoneticiMi;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.TextBox txtPersonelKAdi;
        private System.Windows.Forms.TextBox txtPersonelAdresi;
        private System.Windows.Forms.TextBox txtPersonelMail;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonelTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPersonelSube;
        private System.Windows.Forms.Label label2;
    }
}