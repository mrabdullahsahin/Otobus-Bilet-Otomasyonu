namespace Otobüs_Bilet_Otomasyonu
{
    partial class GuzergahIslemleri
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGuzergahID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGuzergahEkleSil = new System.Windows.Forms.Button();
            this.btnGuzergahEkleIptal = new System.Windows.Forms.Button();
            this.txtGuzergahIsmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVarisSehri = new System.Windows.Forms.ComboBox();
            this.cmbBaslangicSehri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuzergahEkle = new System.Windows.Forms.Button();
            this.txtGuzergahEkleIsim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGuzergahEkleVaris = new System.Windows.Forms.ComboBox();
            this.cmbGuzergahEkleBaslangic = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtGuzergahID);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnGuzergahEkleSil);
            this.groupBox2.Controls.Add(this.btnGuzergahEkleIptal);
            this.groupBox2.Controls.Add(this.txtGuzergahIsmi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbVarisSehri);
            this.groupBox2.Controls.Add(this.cmbBaslangicSehri);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(570, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güzergah Güncelle/Sil";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(160, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGuzergahID
            // 
            this.txtGuzergahID.Enabled = false;
            this.txtGuzergahID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuzergahID.Location = new System.Drawing.Point(142, 15);
            this.txtGuzergahID.Name = "txtGuzergahID";
            this.txtGuzergahID.Size = new System.Drawing.Size(249, 27);
            this.txtGuzergahID.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(19, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 19);
            this.label16.TabIndex = 9;
            this.label16.Text = "Güzergah ID:";
            // 
            // btnGuzergahEkleSil
            // 
            this.btnGuzergahEkleSil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuzergahEkleSil.ForeColor = System.Drawing.Color.Red;
            this.btnGuzergahEkleSil.Location = new System.Drawing.Point(15, 171);
            this.btnGuzergahEkleSil.Name = "btnGuzergahEkleSil";
            this.btnGuzergahEkleSil.Size = new System.Drawing.Size(75, 27);
            this.btnGuzergahEkleSil.TabIndex = 8;
            this.btnGuzergahEkleSil.Text = "Sil";
            this.btnGuzergahEkleSil.UseVisualStyleBackColor = true;
            this.btnGuzergahEkleSil.Click += new System.EventHandler(this.btnGuzergahEkleSil_Click);
            // 
            // btnGuzergahEkleIptal
            // 
            this.btnGuzergahEkleIptal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuzergahEkleIptal.ForeColor = System.Drawing.Color.Red;
            this.btnGuzergahEkleIptal.Location = new System.Drawing.Point(316, 170);
            this.btnGuzergahEkleIptal.Name = "btnGuzergahEkleIptal";
            this.btnGuzergahEkleIptal.Size = new System.Drawing.Size(75, 28);
            this.btnGuzergahEkleIptal.TabIndex = 6;
            this.btnGuzergahEkleIptal.Text = "İptal";
            this.btnGuzergahEkleIptal.UseVisualStyleBackColor = true;
            this.btnGuzergahEkleIptal.Click += new System.EventHandler(this.btnGuzergahEkleIptal_Click);
            // 
            // txtGuzergahIsmi
            // 
            this.txtGuzergahIsmi.Enabled = false;
            this.txtGuzergahIsmi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuzergahIsmi.Location = new System.Drawing.Point(142, 118);
            this.txtGuzergahIsmi.Name = "txtGuzergahIsmi";
            this.txtGuzergahIsmi.Size = new System.Drawing.Size(249, 27);
            this.txtGuzergahIsmi.TabIndex = 5;
            this.txtGuzergahIsmi.TextChanged += new System.EventHandler(this.txtGuzergahIsmi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güzergah İsmi:";
            // 
            // cmbVarisSehri
            // 
            this.cmbVarisSehri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbVarisSehri.FormattingEnabled = true;
            this.cmbVarisSehri.Location = new System.Drawing.Point(142, 82);
            this.cmbVarisSehri.Name = "cmbVarisSehri";
            this.cmbVarisSehri.Size = new System.Drawing.Size(249, 27);
            this.cmbVarisSehri.TabIndex = 3;
            this.cmbVarisSehri.SelectedValueChanged += new System.EventHandler(this.cmbVarisSehri_SelectedValueChanged);
            // 
            // cmbBaslangicSehri
            // 
            this.cmbBaslangicSehri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBaslangicSehri.FormattingEnabled = true;
            this.cmbBaslangicSehri.Location = new System.Drawing.Point(142, 49);
            this.cmbBaslangicSehri.Name = "cmbBaslangicSehri";
            this.cmbBaslangicSehri.Size = new System.Drawing.Size(249, 27);
            this.cmbBaslangicSehri.TabIndex = 2;
            this.cmbBaslangicSehri.SelectedValueChanged += new System.EventHandler(this.cmbBaslangicSehri_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varış Şehri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Şehri:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuzergahEkle);
            this.groupBox1.Controls.Add(this.txtGuzergahEkleIsim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbGuzergahEkleVaris);
            this.groupBox1.Controls.Add(this.cmbGuzergahEkleBaslangic);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(570, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güzergah Ekle";
            // 
            // btnGuzergahEkle
            // 
            this.btnGuzergahEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuzergahEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuzergahEkle.Location = new System.Drawing.Point(142, 153);
            this.btnGuzergahEkle.Name = "btnGuzergahEkle";
            this.btnGuzergahEkle.Size = new System.Drawing.Size(121, 26);
            this.btnGuzergahEkle.TabIndex = 6;
            this.btnGuzergahEkle.Text = "Ekle";
            this.btnGuzergahEkle.UseVisualStyleBackColor = true;
            this.btnGuzergahEkle.Click += new System.EventHandler(this.btnGuzergahEkle_Click);
            // 
            // txtGuzergahEkleIsim
            // 
            this.txtGuzergahEkleIsim.Enabled = false;
            this.txtGuzergahEkleIsim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuzergahEkleIsim.Location = new System.Drawing.Point(142, 120);
            this.txtGuzergahEkleIsim.Name = "txtGuzergahEkleIsim";
            this.txtGuzergahEkleIsim.Size = new System.Drawing.Size(249, 27);
            this.txtGuzergahEkleIsim.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Güzergah İsmi:";
            // 
            // cmbGuzergahEkleVaris
            // 
            this.cmbGuzergahEkleVaris.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGuzergahEkleVaris.FormattingEnabled = true;
            this.cmbGuzergahEkleVaris.Location = new System.Drawing.Point(142, 77);
            this.cmbGuzergahEkleVaris.Name = "cmbGuzergahEkleVaris";
            this.cmbGuzergahEkleVaris.Size = new System.Drawing.Size(249, 27);
            this.cmbGuzergahEkleVaris.TabIndex = 3;
            this.cmbGuzergahEkleVaris.SelectedValueChanged += new System.EventHandler(this.cmbGuzergahEkleVaris_SelectedValueChanged);
            // 
            // cmbGuzergahEkleBaslangic
            // 
            this.cmbGuzergahEkleBaslangic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGuzergahEkleBaslangic.FormattingEnabled = true;
            this.cmbGuzergahEkleBaslangic.Location = new System.Drawing.Point(142, 30);
            this.cmbGuzergahEkleBaslangic.Name = "cmbGuzergahEkleBaslangic";
            this.cmbGuzergahEkleBaslangic.Size = new System.Drawing.Size(249, 27);
            this.cmbGuzergahEkleBaslangic.TabIndex = 2;
            this.cmbGuzergahEkleBaslangic.SelectedValueChanged += new System.EventHandler(this.cmbGuzergahEkleBaslangic_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(39, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Varış Şehri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Başlangıç Şehri:";
            // 
            // GuzergahIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(979, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GuzergahIslemleri";
            this.Text = "Güzergah İşlemleri";
            this.Load += new System.EventHandler(this.GuzergahIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuzergahEkleIptal;
        private System.Windows.Forms.TextBox txtGuzergahIsmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVarisSehri;
        private System.Windows.Forms.ComboBox cmbBaslangicSehri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuzergahEkleSil;
        private System.Windows.Forms.TextBox txtGuzergahID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuzergahEkle;
        private System.Windows.Forms.TextBox txtGuzergahEkleIsim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGuzergahEkleVaris;
        private System.Windows.Forms.ComboBox cmbGuzergahEkleBaslangic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}