using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otobüs_Bilet_Otomasyonu
{
    public partial class OtobusDetay : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biletsistemi.accdb;");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter veriadaptoru = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();

        public OtobusDetay()
        {
            InitializeComponent();
        }

        //DataGridview içerisine Otobüsler veritabaındaki verileri aktardığımız kod bloğu.
        void listele()
        {
            //veriseti.Clear();
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("Select * from Otobusler",baglanti);
            veriadaptoru.Fill(veriseti,"Otobusler");
            dataGridView1.DataSource = veriseti.Tables["Otobusler"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        void cmboxDoldur()
        {
            cmbAktifMi.Items.Add("Aktif");
            cmbAktifMi.Items.Add("Aktif Değil");
            comboBox1.Items.Add("Aktif");
            comboBox1.Items.Add("Aktif Değil");
        }

        void tabloduzenle()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Plaka";
            dataGridView1.Columns[2].HeaderText = "Koltuk Sayısı";
            dataGridView1.Columns[3].HeaderText = "Marka";
            dataGridView1.Columns[4].HeaderText = "Aktiflik Durumu";
        }
        private void OtobusDetay_Load(object sender, EventArgs e)
        {
            textBox1.Text = 46.ToString();
            txtKoltukSayisi.Text = 46.ToString();
            listele();
            cmboxDoldur();
            cmbmarkadoldur();
            tabloduzenle();
        }

        //DataGridview de seçilenlerin Otobüs Güncelleme Panelinde bulunan elemanlara aktarıldığı bölüm.
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOtobusID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOtobusPlakasi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKoltukSayisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbOtobusMarkasi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbAktifMi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        void cmbmarkadoldur()
        {
            OleDbDataReader verioku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select MarkaAd From Markalar";
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                cmbMarka.Items.Add(verioku[0]);
                cmbOtobusMarkasi.Items.Add(verioku[0]);
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPlaka.Text != "" && cmbMarka.Text != "" && comboBox1.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into Otobusler(Plaka,KoltukSayisi,Marka,AktifMi) Values ('" + txtPlaka.Text + "','" + textBox1.Text + "','" + cmbMarka.Text + "','" + comboBox1.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı.");
                textBox1.Text = 46.ToString();
                txtPlaka.Text = "";
                cmbMarka.Text = "";
                comboBox1.Text = "";
                veriseti.Clear();
                listele();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            textBox1.Text = 46.ToString();
            txtPlaka.Text = "";
            cmbMarka.Text = "";
            comboBox1.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from Otobusler Where ID=" + txtOtobusID.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                veriseti.Clear();
            }
            veriseti.Clear();
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //komut = new OleDbCommand();
            //baglanti.Open();
            //komut.Connection = baglanti;
            //komut.CommandText = "Update Markalar set MarkaAd= @markaadi where ID = @ID";
            //komut.Parameters.AddWithValue("@markaadi", txtMarkaGuncelleSil.Text);
            //komut.Parameters.AddWithValue("@ID", txtMarkaID.Text);
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //MessageBox.Show("Bilgiler Güncellendi!");
            //veriseti.Clear();
            //listele();

            //komut.CommandText = "insert into tblrehber (adi,soyadi, evtelefon) values (@pAdi, @pSoyadi, @pEvTelefon)";
            //komut.Parameters.AddWithValue("@pAdi", txtAdi.Text);
            //komut.Parameters.AddWithValue("@pSoyadi", txtSoyadi.Text);
            //komut.Parameters.AddWithValue("@pEvTelefon", txtEvTelefon.Text);

            if (txtKoltukSayisi.Text != "" && cmbOtobusMarkasi.Text != "" && txtOtobusPlakasi.Text != "" && cmbAktifMi.Text != "")
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE Otobusler SET Plaka='" + txtOtobusPlakasi.Text + "',KoltukSayisi='" + txtKoltukSayisi.Text + "' ,Marka='" + cmbOtobusMarkasi.Text + "', AktifMi='" + cmbAktifMi.Text + "' WHERE ID=@ID", baglanti);
                cmd.Parameters.AddWithValue("@ID", txtOtobusID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("GÜNCELLENDİ !");
                baglanti.Close();
                veriseti.Clear();
                listele();
            }
        }

        private void cmbAktifMi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
