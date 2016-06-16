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
    public partial class PozisyonIslemleri : Form
    {
        public PozisyonIslemleri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biletsistemi.accdb;");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter veriadaptoru = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();
        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("Select * from CalisanTipleri", baglanti);
            veriadaptoru.Fill(veriseti, "CalisanTipleri");
            dataGridView1.DataSource = veriseti.Tables["CalisanTipleri"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        void sifirla()
        {
            txtPozisyonEkle.Text = "";
            txtPozisyonYeniAdi.Text = "";
        }

        private void PozisyonIslemleri_Load(object sender, EventArgs e)
        {
            listele();
            tabloduzenle();
        }

        void tabloduzenle()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Mertebe Adı";
        }

        private void btnPozisyonEkle_Click(object sender, EventArgs e)
        {
            if (txtPozisyonEkle.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into CalisanTipleri(TipAd) Values ('" + txtPozisyonEkle.Text + "')";
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

        private void btnPozisyonEkleIptal_Click(object sender, EventArgs e)
        {
            sifirla();
        }

        private void btnPozisyonSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from CalisanTipleri where ID=" + txtPozisyonID.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                veriseti.Clear();
                listele();
            }
        }

        private void btnPozisyonGuncelleIptal_Click(object sender, EventArgs e)
        {
            sifirla();
        }

        private void btnPozsiyonGuncelle_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update CalisanTipleri set TipAd= @tip where ID = @ID";
            komut.Parameters.AddWithValue("@tip", txtPozisyonYeniAdi.Text);
            komut.Parameters.AddWithValue("@ID", txtPozisyonID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler Güncellendi!");
            veriseti.Clear();
            listele();
            txtPozisyonYeniAdi.Text = "";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtPozisyonID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblPozisyonEskiAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
