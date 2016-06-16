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
    public partial class MasrafCesitleri : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biletsistemi.accdb;");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter veriadaptoru = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();
        public MasrafCesitleri()
        {
            InitializeComponent();
        }

        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("Select * from MasrafTipleri", baglanti);
            veriadaptoru.Fill(veriseti, "MasrafTipleri");
            dataGridView1.DataSource = veriseti.Tables["MasrafTipleri"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        void sifirla()
        {
            txtMasrafEkle.Text = "";
            txtYeniAd.Text = "";
        }
        private void MasrafCesitleri_Load(object sender, EventArgs e)
        {
            listele();
            tabloduzenle();
        }

        void tabloduzenle()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Masraf Adı";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMasrafEkle.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into MasrafTipleri(MasrafAd) Values ('" + txtMasrafEkle.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı!");
                veriseti.Clear();
                listele();
                sifirla();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMasrafID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblEskiAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEkleIptal_Click(object sender, EventArgs e)
        {
            txtMasrafEkle.Text = "";
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtYeniAd.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from MasrafTipleri where ID=" + txtMasrafID.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                veriseti.Clear();
                listele();
            }
            sifirla();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update MasrafTipleri set MasrafAd= @masraf where ID = @ID";
            komut.Parameters.AddWithValue("@masraf", txtYeniAd.Text);
            komut.Parameters.AddWithValue("@ID", txtMasrafID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler Güncellendi!");
            veriseti.Clear();
            listele();
            sifirla();
         }
    }
}
