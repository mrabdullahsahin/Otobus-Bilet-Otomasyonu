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
    public partial class SubeIslemleri : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biletsistemi.accdb;");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter veriadaptoru = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();
        public SubeIslemleri()
        {
            InitializeComponent();
        }

        //DataGridview nesnesine Şubeler tablosunun aktarıldığı bölüm.
        void listele()
        {
            veriseti.Clear();
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("Select * from Subeler",baglanti);
            veriadaptoru.Fill(veriseti,"Subeler");
            dataGridView1.DataSource = veriseti.Tables["Subeler"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        //Combobox nesnesinin içerisine Şehirler tablosunda şehirlerin alınıp eklenme işleminin gerçekleştirildiği bölüm.
        void cmboxDoldur()
        {
            OleDbDataReader verioku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select SehirAd from Sehirler";
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                cmbSehirler.Items.Add(verioku[0]);
            }
            baglanti.Close();

        }

        //Nesnelerin Sıfırlandığı Bölüm
        void sifirla()
        {
            txtSubeAdi.Text = "";
            cmbSehirler.Text = "";
        }

        void tabloduzenle()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Şube Adı";
            dataGridView1.Columns[2].HeaderText = "Şubenin Bulunduğu Şehir";
        }

        private void SubeIslemleri_Load(object sender, EventArgs e)
        {
            sifirla();
            cmboxDoldur();
            listele();
            tabloduzenle();
        }

        //Yeni şube ekleme işlemlerini gerçekleştirildiği bölüm.
        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            if (txtSubeAdi.Text !="" && cmbSehirler.Text !="")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into Subeler(SehirID,SubeAd) Values ('" + cmbSehirler.Text + "','" + txtSubeAdi.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı!");
                listele();
                sifirla();
            }
        }

        //DataGridview de seçilen yerin nesnelere aktarıldığı bölüm.
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSubeDuzenleAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSubeBulunduguSehir.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSubeID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        //Silmek istenilen şube işlemlerinin gerçekleştirildiği bölüm.
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from Subeler where ID=" + txtSubeID.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                veriseti.Clear();
                listele();
            }
        }

        //Verileri güncellenen şubenin güncelleme işlemin gerçekleştirildiği bölüm.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update Subeler set SubeAd= @subeadi where ID = @ID";
            komut.Parameters.AddWithValue("@subeadi", txtSubeDuzenleAdi.Text);
            komut.Parameters.AddWithValue("@ID", txtSubeID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler Güncellendi!");
            veriseti.Clear();
            listele();
        }

        private void txtSubeBulunduguSehir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
