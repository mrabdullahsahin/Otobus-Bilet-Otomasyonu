namespace Otobüs_Bilet_Otomasyonu
{
    partial class PozisyonIslemleri
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
            this.lblPozisyonEskiAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPozisyonYeniAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPozsiyonGuncelle = new System.Windows.Forms.Button();
            this.btnPozisyonSil = new System.Windows.Forms.Button();
            this.btnPozisyonGuncelleIptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPozisyonEkle = new System.Windows.Forms.TextBox();
            this.btnPozisyonEkleIptal = new System.Windows.Forms.Button();
            this.btnPozisyonEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPozisyonID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // lblPozisyonEskiAdi
            // 
            this.lblPozisyonEskiAdi.AutoSize = true;
            this.lblPozisyonEskiAdi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyonEskiAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPozisyonEskiAdi.Location = new System.Drawing.Point(137, 63);
            this.lblPozisyonEskiAdi.Name = "lblPozisyonEskiAdi";
            this.lblPozisyonEskiAdi.Size = new System.Drawing.Size(69, 19);
            this.lblPozisyonEskiAdi.TabIndex = 1;
            this.lblPozisyonEskiAdi.Text = "Eski Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(48, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Adı:";
            // 
            // txtPozisyonYeniAdi
            // 
            this.txtPozisyonYeniAdi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPozisyonYeniAdi.Location = new System.Drawing.Point(137, 96);
            this.txtPozisyonYeniAdi.Name = "txtPozisyonYeniAdi";
            this.txtPozisyonYeniAdi.Size = new System.Drawing.Size(100, 27);
            this.txtPozisyonYeniAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eski Adı:";
            // 
            // btnPozsiyonGuncelle
            // 
            this.btnPozsiyonGuncelle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPozsiyonGuncelle.Location = new System.Drawing.Point(209, 135);
            this.btnPozsiyonGuncelle.Name = "btnPozsiyonGuncelle";
            this.btnPozsiyonGuncelle.Size = new System.Drawing.Size(95, 32);
            this.btnPozsiyonGuncelle.TabIndex = 5;
            this.btnPozsiyonGuncelle.Text = "Güncelle";
            this.btnPozsiyonGuncelle.UseVisualStyleBackColor = true;
            this.btnPozsiyonGuncelle.Click += new System.EventHandler(this.btnPozsiyonGuncelle_Click);
            // 
            // btnPozisyonSil
            // 
            this.btnPozisyonSil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPozisyonSil.ForeColor = System.Drawing.Color.Red;
            this.btnPozisyonSil.Location = new System.Drawing.Point(6, 135);
            this.btnPozisyonSil.Name = "btnPozisyonSil";
            this.btnPozisyonSil.Size = new System.Drawing.Size(95, 32);
            this.btnPozisyonSil.TabIndex = 6;
            this.btnPozisyonSil.Text = "Sil";
            this.btnPozisyonSil.UseVisualStyleBackColor = true;
            this.btnPozisyonSil.Click += new System.EventHandler(this.btnPozisyonSil_Click);
            // 
            // btnPozisyonGuncelleIptal
            // 
            this.btnPozisyonGuncelleIptal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPozisyonGuncelleIptal.ForeColor = System.Drawing.Color.Red;
            this.btnPozisyonGuncelleIptal.Location = new System.Drawing.Point(109, 135);
            this.btnPozisyonGuncelleIptal.Name = "btnPozisyonGuncelleIptal";
            this.btnPozisyonGuncelleIptal.Size = new System.Drawing.Size(94, 32);
            this.btnPozisyonGuncelleIptal.TabIndex = 7;
            this.btnPozisyonGuncelleIptal.Text = "İptal";
            this.btnPozisyonGuncelleIptal.UseVisualStyleBackColor = true;
            this.btnPozisyonGuncelleIptal.Click += new System.EventHandler(this.btnPozisyonGuncelleIptal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pozisyon Adı:";
            // 
            // txtPozisyonEkle
            // 
            this.txtPozisyonEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPozisyonEkle.Location = new System.Drawing.Point(141, 42);
            this.txtPozisyonEkle.Name = "txtPozisyonEkle";
            this.txtPozisyonEkle.Size = new System.Drawing.Size(100, 27);
            this.txtPozisyonEkle.TabIndex = 1;
            // 
            // btnPozisyonEkleIptal
            // 
            this.btnPozisyonEkleIptal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPozisyonEkleIptal.ForeColor = System.Drawing.Color.Red;
            this.btnPozisyonEkleIptal.Location = new System.Drawing.Point(109, 93);
            this.btnPozisyonEkleIptal.Name = "btnPozisyonEkleIptal";
            this.btnPozisyonEkleIptal.Size = new System.Drawing.Size(75, 32);
            this.btnPozisyonEkleIptal.TabIndex = 2;
            this.btnPozisyonEkleIptal.Text = "İptal";
            this.btnPozisyonEkleIptal.UseVisualStyleBackColor = true;
            this.btnPozisyonEkleIptal.Click += new System.EventHandler(this.btnPozisyonEkleIptal_Click);
            // 
            // btnPozisyonEkle
            // 
            this.btnPozisyonEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPozisyonEkle.Location = new System.Drawing.Point(209, 92);
            this.btnPozisyonEkle.Name = "btnPozisyonEkle";
            this.btnPozisyonEkle.Size = new System.Drawing.Size(70, 33);
            this.btnPozisyonEkle.TabIndex = 3;
            this.btnPozisyonEkle.Text = "Ekle";
            this.btnPozisyonEkle.UseVisualStyleBackColor = true;
            this.btnPozisyonEkle.Click += new System.EventHandler(this.btnPozisyonEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pozisyon ID:";
            // 
            // txtPozisyonID
            // 
            this.txtPozisyonID.Enabled = false;
            this.txtPozisyonID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPozisyonID.Location = new System.Drawing.Point(137, 23);
            this.txtPozisyonID.Name = "txtPozisyonID";
            this.txtPozisyonID.Size = new System.Drawing.Size(100, 27);
            this.txtPozisyonID.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPozisyonID);
            this.groupBox1.Controls.Add(this.btnPozsiyonGuncelle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPozisyonEskiAdi);
            this.groupBox1.Controls.Add(this.btnPozisyonGuncelleIptal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPozisyonSil);
            this.groupBox1.Controls.Add(this.txtPozisyonYeniAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(541, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 196);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pozisyon Güncelle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPozisyonEkle);
            this.groupBox2.Controls.Add(this.btnPozisyonEkleIptal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPozisyonEkle);
            this.groupBox2.Location = new System.Drawing.Point(541, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 150);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pozisyon Ekle";
            // 
            // PozisyonIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(860, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PozisyonIslemleri";
            this.Text = "Pozisyon İşlemleri";
            this.Load += new System.EventHandler(this.PozisyonIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPozisyonYeniAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPozisyonEskiAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPozisyonSil;
        private System.Windows.Forms.Button btnPozsiyonGuncelle;
        private System.Windows.Forms.Button btnPozisyonGuncelleIptal;
        private System.Windows.Forms.Button btnPozisyonEkle;
        private System.Windows.Forms.Button btnPozisyonEkleIptal;
        private System.Windows.Forms.TextBox txtPozisyonEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPozisyonID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}