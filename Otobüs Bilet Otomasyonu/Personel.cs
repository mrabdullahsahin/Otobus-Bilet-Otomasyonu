using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otobüs_Bilet_Otomasyonu
{
    public partial class Personel : Form
    {
        //Veri Tabanı Değişkenleri Tanımlama Bölümü.
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biletsistemi.accdb;");
        //@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= veritabaniadi.accdb Persist Security Info=True"
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter veriadaptoru = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();
        public Personel()
        {
            InitializeComponent();
        }
        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("Select * from Personel", baglanti);
            veriadaptoru.Fill(veriseti, "Personel");
            dataGridView1.DataSource = veriseti.Tables["Personel"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        void sifirla()
        {
            txtPersonelAd.Text = "";
            txtPersonelAdresi.Text = "";
            txtPersonelKAdi.Text = "";
            txtPersonelID.Text = "";
            txtPersonelMail.Text = "";
            txtPersonelSifre.Text = "";
            txtPersonelTelefon.Text = "";
            cmbPersonelMertebesi.Text = "";
            cmbPersonelSube.Text = "";
            cmbPersonelYoneticiMi.Text = "";
        }

        void SubecmbDoldur()
        {
            OleDbDataReader verioku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select SubeAd From Subeler";
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                cmbPersonelSube.Items.Add(verioku[0]);
            }
            baglanti.Close();
        }

        void MertebesicmbDoldur()
        {
            OleDbDataReader verioku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select TipAd From CalisanTipleri";
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                cmbPersonelMertebesi.Items.Add(verioku[0]);
            }
            baglanti.Close();
        }

        void temizle()
        {
            txtPersonelAd.Text = "";
            txtPersonelAdresi.Text = "";
            txtPersonelKAdi.Text = "";
            txtPersonelMail.Text = "";
            txtPersonelSifre.Text = "";
            txtPersonelTelefon.Text = "";
            cmbPersonelMertebesi.Text = "";
            cmbPersonelSube.Text = "";
            cmbPersonelYoneticiMi.Text = "";
        }

        void YoneticiMicmbDoldur()
        {
            cmbPersonelYoneticiMi.Items.Add("Evet");
            cmbPersonelYoneticiMi.Items.Add("Hayır");
        }

        void tabloduzenle()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[2].HeaderText = "Telefon";
            dataGridView1.Columns[3].HeaderText = "E-Mail";
            dataGridView1.Columns[4].HeaderText = "Şubesi";
            dataGridView1.Columns[5].HeaderText = "Ev Adresi";
            dataGridView1.Columns[6].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[7].HeaderText = "Şifre";
            dataGridView1.Columns[8].HeaderText = "Yötenici Mi?";
            dataGridView1.Columns[9].HeaderText = "Mertebesi";
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            SubecmbDoldur();
            MertebesicmbDoldur();
            YoneticiMicmbDoldur();
            listele();
            btnEkle.Visible = false;
            tabloduzenle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from Personel Where ID=" + txtPersonelID.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                veriseti.Clear();
                listele();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbPersonelSube.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPersonelAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPersonelTelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPersonelMail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPersonelAdresi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPersonelKAdi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPersonelSifre.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbPersonelYoneticiMi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cmbPersonelMertebesi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text != "" && txtPersonelAdresi.Text != "" && txtPersonelKAdi.Text != "" && txtPersonelMail.Text != "" && txtPersonelSifre.Text != "" && txtPersonelTelefon.Text != "" && cmbPersonelMertebesi.Text != "" && cmbPersonelSube.Text != "" && cmbPersonelYoneticiMi.Text !="")
            {
                komut.Connection = baglanti;
                komut.CommandText = "insert into Personel(AdSoyad,Telefon,Email,SubeID,EvAdresi,KullaniciAdi,Sifre,YoneticiMi,CalisanTipID) values ('" + txtPersonelAd.Text + "','" + txtPersonelTelefon.Text + "','" + txtPersonelMail.Text + "','" + cmbPersonelSube.Text + "','" + txtPersonelAdresi.Text + "','" + txtPersonelKAdi.Text + "','" + txtPersonelSifre.Text + "','" + cmbPersonelYoneticiMi.Text + "','" + cmbPersonelMertebesi.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Tamamlandı!");
                veriseti.Clear();
                listele();
                temizle();
                btnEkle.Visible = false;
                chcYeniEkle.Visible = true;
                chcYeniEkle.Checked = false;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Personel set AdSoyad='" + txtPersonelAd.Text + "',Telefon='" + txtPersonelTelefon.Text + "',Email='" + txtPersonelMail.Text + "',SubeID='" + cmbPersonelSube.Text + "',EvAdresi='" + txtPersonelAdresi.Text + "',KullaniciAdi='" + txtPersonelKAdi.Text + "',Sifre='" + txtPersonelSifre.Text + "',YoneticiMi='" + cmbPersonelYoneticiMi.Text + "',CalisanTipID='" + cmbPersonelMertebesi.Text + "' where ID=" + txtPersonelID.Text + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler Güncellendi!");
            veriseti.Clear();
            listele();
        }

        private void chcYeniEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (chcYeniEkle.Checked == true)
            {
                sifirla();
                btnEkle.Visible = true;
                chcYeniEkle.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbPersonelMertebesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
