using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Access Veritabanı Bağlantısı için gereken kütüphane.

namespace Otobüs_Bilet_Otomasyonu
{
    public partial class MarkaIslemleri : Form
    {
        #region veritabani değişkenleri
        //Veri Tabanı Değişkenleri Tanımlama Bölümü.
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biletsistemi.accdb;");
        //@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= veritabaniadi.accdb Persist Security Info=True"
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter veriadaptoru = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();
        #endregion
        public MarkaIslemleri()
        {
            InitializeComponent();
        }

        //DataGridview de kayıtları listeleme bölümü.
        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("Select * from Markalar",baglanti);
            veriadaptoru.Fill(veriseti,"Markalar");
            dataGridView1.DataSource = veriseti.Tables["Markalar"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        void tabloduzenle()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Marka Adı";
        }

        private void MarkaIslemleri_Load(object sender, EventArgs e)
        {
            listele();
            tabloduzenle();
        }

        //DataGridview de seçilen kayıtın textbox'lara aktarıldığı bölüm.
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMarkaID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMarkaGuncelleSil.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        //DataGridview'de seçilen bir kayıtın silme işleminin gerçekleştirildiği bölüm.
        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from Markalar Where ID="+txtMarkaID.Text+"";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                veriseti.Clear();
                listele();
            }
        }

        //Veri Tabanına Yeni Kayıt Ekleme Bölümü.
        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            if (txtMarkaEkle.Text !="")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into Markalar(MarkaAd) Values ('"+txtMarkaEkle.Text+"')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Tamamlandı!");
                veriseti.Clear();
                listele();
            }
        }

        //Veri Tabanında Bulunan Verilerden Seçilenin Tekrara Düzenlendiği Bölüm
        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update Markalar set MarkaAd= @markaadi where ID = @ID";
            komut.Parameters.AddWithValue("@markaadi", txtMarkaGuncelleSil.Text);
            komut.Parameters.AddWithValue("@ID",txtMarkaID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler Güncellendi!");
            veriseti.Clear();
            listele();
        }
    }
}
