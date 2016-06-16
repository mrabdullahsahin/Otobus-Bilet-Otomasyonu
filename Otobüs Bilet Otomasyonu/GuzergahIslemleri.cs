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
    public partial class GuzergahIslemleri : Form
    {
        public GuzergahIslemleri()
        {
            InitializeComponent();
        }

        //Veri Tabanı Değişkenleri Tanımlama Bölümü.
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biletsistemi.accdb;");
        //@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= veritabaniadi.accdb Persist Security Info=True"
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter veriadaptoru = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();
        OleDbDataReader veriokuyucu;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        void tabloduzenle()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Güzergah";
            dataGridView1.Columns[2].HeaderText = "Kalkış Şehri";
            dataGridView1.Columns[3].HeaderText = "Varış Şehri";
        }

        private void GuzergahIslemleri_Load(object sender, EventArgs e)
        {
            baglanti.Close();
            listele();
            SehirListele();
            tabloduzenle();
        }
        //Textbox'ların içeriği temizleniyor.
        void sifirla()
        {
            txtGuzergahID.Text = "";
            cmbVarisSehri.Text = "";
            cmbBaslangicSehri.Text = "";
            txtGuzergahIsmi.Text = "";
            cmbGuzergahEkleBaslangic.Text = "";
            cmbGuzergahEkleVaris.Text = "";
            txtGuzergahEkleIsim.Text = "";
        }

        //Datagridview1 nesnesinin içerisine guzergahlar listeleniyor.
        void listele()
        {
            veriseti.Clear();
            baglanti.Close();
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("Select * from Guzergah", baglanti);
            veriadaptoru.Fill(veriseti, "Guzergah");
            dataGridView1.DataSource = veriseti.Tables["Guzergah"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        void SehirListele()
        {
            OleDbDataReader verioku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select SehirAd from Sehirler";
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                cmbBaslangicSehri.Items.Add(verioku[0]);
                cmbGuzergahEkleBaslangic.Items.Add(verioku[0]);
                cmbGuzergahEkleVaris.Items.Add(verioku[0]);
                cmbVarisSehri.Items.Add(verioku[0]);
            }
            baglanti.Close();
        }

        //Guzergah ekle kısmında iptal butonuna basılırsa ne olur onun gerçekleşeceği kısım.
        private void btnGuzergahEkleIptal_Click(object sender, EventArgs e)
        {
            sifirla();
        }

        //Guzergah ekleme butonuna basıldığı zaman nelerin olacağının gerçekleşeği kısım.
        private void btnGuzergahEkleKaydet_Click(object sender, EventArgs e)
        {
        }

        //Datagridview1 nesnesinin içerisinde nesne seçilirse neler olacak onların gerçekleştiği kısım.
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmbBaslangicSehri.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbVarisSehri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGuzergahIsmi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGuzergahID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        //Guzergah silme butonuna basıldığı zaman nelerin gerçekleşeceğinin belirtildiği kısım.
        private void btnGuzergahEkleSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from Guzergah Where ID=" + txtGuzergahID.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                veriseti.Clear();
                listele();
                sifirla();
            }
        }

        private void btnGuzergahaSehirEkleKaydet_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //Guzergah silme işlemine basıldığı zaman nelerin gerçekleşeceğini belirten kısım.
        private void btnGuzergahSil_Click(object sender, EventArgs e)
        {
        }

        private void listGuzergahListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbGuzergahSec_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void txtGuzergahIsmi_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbGuzergahSec_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbGuzergahEkleBaslangic_SelectedValueChanged(object sender, EventArgs e)
        {
            txtGuzergahEkleIsim.Text = cmbGuzergahEkleBaslangic.Text + "-" + cmbGuzergahEkleVaris.Text; 
        }

        private void cmbGuzergahEkleVaris_SelectedValueChanged(object sender, EventArgs e)
        {
            txtGuzergahEkleIsim.Text = cmbGuzergahEkleBaslangic.Text + "-" + cmbGuzergahEkleVaris.Text;
        }

        private void btnGuzergahEkle_Click(object sender, EventArgs e)
        {
            if (cmbGuzergahEkleBaslangic.Text != "" && cmbGuzergahEkleVaris.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into Guzergah(Tanim,kalkis_sehir,varis_sehir) Values ('" + txtGuzergahEkleIsim.Text + "','" + cmbGuzergahEkleBaslangic.Text + "','" + cmbGuzergahEkleVaris.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı!");
                listele();
                sifirla();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtGuzergahIsmi.Text != "" && cmbBaslangicSehri.Text != "" && cmbVarisSehri.Text != "")
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE Guzergah SET Tanim='" + txtGuzergahIsmi.Text + "',kalkis_sehir='" + cmbBaslangicSehri.Text + "' ,varis_sehir='" + cmbVarisSehri.Text + "' WHERE ID=@ID", baglanti);
                cmd.Parameters.AddWithValue("@ID", txtGuzergahID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("GÜNCELLENDİ !");
                baglanti.Close();
                veriseti.Clear();
                listele();
            }
        }

        private void cmbBaslangicSehri_SelectedValueChanged(object sender, EventArgs e)
        {
            txtGuzergahIsmi.Text = cmbBaslangicSehri.Text + "-" + cmbVarisSehri.Text;
        }

        private void cmbVarisSehri_SelectedValueChanged(object sender, EventArgs e)
        {
            txtGuzergahIsmi.Text = cmbBaslangicSehri.Text + "-" + cmbVarisSehri.Text;

        }
    }
}

