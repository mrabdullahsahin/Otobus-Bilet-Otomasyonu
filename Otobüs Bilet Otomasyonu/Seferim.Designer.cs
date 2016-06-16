namespace Otobüs_Bilet_Otomasyonu
{
    partial class Seferim
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtTahminiSure = new System.Windows.Forms.TextBox();
            this.dateVarisZamani = new System.Windows.Forms.DateTimePicker();
            this.dateKalkisZamani = new System.Windows.Forms.DateTimePicker();
            this.cmbMuavin = new System.Windows.Forms.ComboBox();
            this.cmbSofor = new System.Windows.Forms.ComboBox();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.txtVarisSehri = new System.Windows.Forms.TextBox();
            this.txtKalkisSehri = new System.Windows.Forms.TextBox();
            this.cmbGuzergah = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeferSil = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1074, 443);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.txtTahminiSure);
            this.groupBox1.Controls.Add(this.dateVarisZamani);
            this.groupBox1.Controls.Add(this.dateKalkisZamani);
            this.groupBox1.Controls.Add(this.cmbMuavin);
            this.groupBox1.Controls.Add(this.cmbSofor);
            this.groupBox1.Controls.Add(this.cmbOtobus);
            this.groupBox1.Controls.Add(this.txtVarisSehri);
            this.groupBox1.Controls.Add(this.txtKalkisSehri);
            this.groupBox1.Controls.Add(this.cmbGuzergah);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 511);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Ekle";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(69, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(237, 462);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 31);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(149, 423);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 20;
            // 
            // txtTahminiSure
            // 
            this.txtTahminiSure.Location = new System.Drawing.Point(149, 371);
            this.txtTahminiSure.Name = "txtTahminiSure";
            this.txtTahminiSure.Size = new System.Drawing.Size(100, 20);
            this.txtTahminiSure.TabIndex = 19;
            // 
            // dateVarisZamani
            // 
            this.dateVarisZamani.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVarisZamani.Location = new System.Drawing.Point(149, 331);
            this.dateVarisZamani.Name = "dateVarisZamani";
            this.dateVarisZamani.Size = new System.Drawing.Size(200, 20);
            this.dateVarisZamani.TabIndex = 18;
            // 
            // dateKalkisZamani
            // 
            this.dateKalkisZamani.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKalkisZamani.Location = new System.Drawing.Point(149, 290);
            this.dateKalkisZamani.Name = "dateKalkisZamani";
            this.dateKalkisZamani.Size = new System.Drawing.Size(200, 20);
            this.dateKalkisZamani.TabIndex = 16;
            // 
            // cmbMuavin
            // 
            this.cmbMuavin.FormattingEnabled = true;
            this.cmbMuavin.Location = new System.Drawing.Point(149, 242);
            this.cmbMuavin.Name = "cmbMuavin";
            this.cmbMuavin.Size = new System.Drawing.Size(121, 21);
            this.cmbMuavin.TabIndex = 15;
            // 
            // cmbSofor
            // 
            this.cmbSofor.FormattingEnabled = true;
            this.cmbSofor.Location = new System.Drawing.Point(149, 199);
            this.cmbSofor.Name = "cmbSofor";
            this.cmbSofor.Size = new System.Drawing.Size(121, 21);
            this.cmbSofor.TabIndex = 14;
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Location = new System.Drawing.Point(149, 157);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(121, 21);
            this.cmbOtobus.TabIndex = 13;
            // 
            // txtVarisSehri
            // 
            this.txtVarisSehri.Enabled = false;
            this.txtVarisSehri.Location = new System.Drawing.Point(149, 116);
            this.txtVarisSehri.Name = "txtVarisSehri";
            this.txtVarisSehri.Size = new System.Drawing.Size(121, 20);
            this.txtVarisSehri.TabIndex = 12;
            // 
            // txtKalkisSehri
            // 
            this.txtKalkisSehri.Enabled = false;
            this.txtKalkisSehri.Location = new System.Drawing.Point(149, 77);
            this.txtKalkisSehri.Name = "txtKalkisSehri";
            this.txtKalkisSehri.Size = new System.Drawing.Size(121, 20);
            this.txtKalkisSehri.TabIndex = 11;
            // 
            // cmbGuzergah
            // 
            this.cmbGuzergah.FormattingEnabled = true;
            this.cmbGuzergah.Location = new System.Drawing.Point(149, 41);
            this.cmbGuzergah.Name = "cmbGuzergah";
            this.cmbGuzergah.Size = new System.Drawing.Size(121, 21);
            this.cmbGuzergah.TabIndex = 10;
            this.cmbGuzergah.SelectedValueChanged += new System.EventHandler(this.cmbGuzergah_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(78, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tutar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(15, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tahmini Süre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(17, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Varış Zamanı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kalkış Zamanı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(65, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Muavin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(80, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şoför:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(66, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Otobüs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varış Şehri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kalkış Şehri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güzergah:";
            // 
            // btnSeferSil
            // 
            this.btnSeferSil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeferSil.ForeColor = System.Drawing.Color.Red;
            this.btnSeferSil.Location = new System.Drawing.Point(1310, 474);
            this.btnSeferSil.Name = "btnSeferSil";
            this.btnSeferSil.Size = new System.Drawing.Size(144, 31);
            this.btnSeferSil.TabIndex = 6;
            this.btnSeferSil.Text = "Seçili Seferi Sil";
            this.btnSeferSil.UseVisualStyleBackColor = true;
            this.btnSeferSil.Click += new System.EventHandler(this.btnSeferSil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(419, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "label11";
            // 
            // Seferim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 531);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSeferSil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Seferim";
            this.Text = "Sefer İşlemleri";
            this.Load += new System.EventHandler(this.Seferim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtTahminiSure;
        private System.Windows.Forms.DateTimePicker dateVarisZamani;
        private System.Windows.Forms.DateTimePicker dateKalkisZamani;
        private System.Windows.Forms.ComboBox cmbMuavin;
        private System.Windows.Forms.ComboBox cmbSofor;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.TextBox txtVarisSehri;
        private System.Windows.Forms.TextBox txtKalkisSehri;
        private System.Windows.Forms.ComboBox cmbGuzergah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeferSil;
        private System.Windows.Forms.Label label11;
    }
}