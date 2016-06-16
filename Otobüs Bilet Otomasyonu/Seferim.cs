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
    public partial class Seferim : Form
    {
        //Veri Tabanı Değişkenleri Tanımlama Bölümü.
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biletsistemi.accdb;");
        //@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= veritabaniadi.accdb Persist Security Info=True"
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter veriadaptoru = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();
        OleDbDataReader veriokuyucu;
        public Seferim()
        {
            InitializeComponent();
        }
        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("Select * from sefer", baglanti);
            veriadaptoru.Fill(veriseti, "sefer");
            dataGridView1.DataSource = veriseti.Tables["sefer"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        private void Seferim_Load(object sender, EventArgs e)
        {
            dateKalkisZamani.CustomFormat = "dd MMM yyyy ddd HH:mm";
            dateVarisZamani.CustomFormat = "dd MMM yyyy ddd HH:mm";
            cmbGuzergahListele();
            cmbOtobusListele();
            cmbSoforListele();
            cmbMuavinListele();
            //cmbSeferListele();
            listele();
            label11.Visible = false;
            tabloduzenle();
        }

        void tabloduzenle()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Kalkış Şehri";
            dataGridView1.Columns[2].HeaderText = "Varış Şehri";
            dataGridView1.Columns[3].HeaderText = "Otobüs Plaka";
            dataGridView1.Columns[4].HeaderText = "Muavin";
            dataGridView1.Columns[5].HeaderText = "Şoför";
            dataGridView1.Columns[6].HeaderText = "Kalkış Zamanı";
            dataGridView1.Columns[7].HeaderText = "Varış Zamanı";
            dataGridView1.Columns[8].HeaderText = "Tahmini Süre";
            dataGridView1.Columns[9].HeaderText = "Bilet Fiyatı";
            dataGridView1.Columns[10].HeaderText = "Güzergah";
        }

        void cmbGuzergahListele()
        {
            OleDbDataReader verioku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select Tanim From Guzergah";
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                cmbGuzergah.Items.Add(verioku[0]);
            }
            baglanti.Close();
        }

        void cmbOtobusListele()
        {
            OleDbDataReader verioku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select Plaka From Otobusler";
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                cmbOtobus.Items.Add(verioku[0]);
            }
            baglanti.Close();
        }

        void cmbSoforListele()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT AdSoyad FROM Personel WHERE CalisanTipID IN ('Şoför')";
            veriokuyucu = komut.ExecuteReader();

            while (veriokuyucu.Read())
            {
                cmbSofor.Items.Add(veriokuyucu["AdSoyad"]);
            }
            baglanti.Close();
        }

        void cmbMuavinListele()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT AdSoyad FROM Personel WHERE CalisanTipID IN ('Muavin')";
            veriokuyucu = komut.ExecuteReader();

            while (veriokuyucu.Read())
            {
                cmbMuavin.Items.Add(veriokuyucu["AdSoyad"]);
            }
            baglanti.Close();
        }

        void cmbSeferListele()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT GuzergahID FROM Personel";
            veriokuyucu = komut.ExecuteReader();

            while (veriokuyucu.Read())
            {
                cmbMuavin.Items.Add(veriokuyucu["GuzergahID"]);
            }
            baglanti.Close();
        }

        void Sifirla()
        {
            cmbGuzergah.Text = "";
            txtKalkisSehri.Text = "";
            txtVarisSehri.Text = "";
            cmbOtobus.Text = "";
            cmbSofor.Text = "";
            cmbMuavin.Text = "";
            txtTahminiSure.Text = "";
            txtTutar.Text = "";
        }

        private void cmbGuzergah_SelectedValueChanged(object sender, EventArgs e)
        {
            string veri = cmbGuzergah.Text;
            string[] parcalanmis_veri = veri.Split("-".ToCharArray());

            txtKalkisSehri.Text = parcalanmis_veri[0];
            txtVarisSehri.Text = parcalanmis_veri[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sifirla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            if (cmbGuzergah.Text != "" && txtKalkisSehri.Text != "" && txtVarisSehri.Text != "" && cmbOtobus.Text != "" && cmbSofor.Text != "" && cmbMuavin.Text != "" && dateKalkisZamani.Text != "" && dateVarisZamani.Text != "" && txtTahminiSure.Text != "" && txtTutar.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into sefer(KalkisSehirID,VarisSehirID,OtobusID,MuavinID,SoforID,KalkisZamani,VarisZamani,TahminiSure,BiletTutar,sehir) values ('" + txtKalkisSehri.Text + "','" + txtVarisSehri.Text + "','" + cmbOtobus.Text + "','" + cmbMuavin.Text + "','" + cmbSofor.Text + "','" + dateKalkisZamani.Text + "','" + dateVarisZamani.Text + "','" + txtTahminiSure.Text + "','" + txtTutar.Text + "','" + cmbGuzergah.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı!");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label11.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSeferSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from sefer Where ID=" + label11.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                veriseti.Clear();
                listele();
            }
        }
    }
}
