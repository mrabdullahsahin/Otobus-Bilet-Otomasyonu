using System;
using System.Collections;
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
    public partial class bilet : Form
    {
        //Veri Tabanı Değişkenleri Tanımlama Bölümü.
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biletsistemi.accdb;");
        //@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= veritabaniadi.accdb Persist Security Info=True"
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter veriadaptoru = new OleDbDataAdapter();
        DataSet veriseti = new DataSet();
        OleDbDataReader veriokuyucu;
        public bilet()
        {
            InitializeComponent();
        }

        private void bilet_Load(object sender, EventArgs e)
        {
            listele();
            cmbGuzergahListele();
            seferseciniz();
            islemtipi();
            cinsiyet();
            cmbSeferSec.Enabled = false;
            tabloduzenle();
        }

        void tabloduzenle()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Sefer Bilgisi";
            dataGridView1.Columns[2].HeaderText = "Satış - Rezervasyon";
            dataGridView1.Columns[3].HeaderText = "Koltuk Numarası";
            dataGridView1.Columns[4].HeaderText = "Yolcu Cinsiyet";
            dataGridView1.Columns[5].HeaderText = "Yolcu Bilgileri";
            dataGridView1.Columns[6].HeaderText = "Ücret";
            dataGridView1.Columns[7].HeaderText = "Güzergah";
        }

        void cmbGuzergahListele()
        {
            OleDbDataReader verioku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select sehir From sefer";
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                cmbGuzergahSec.Items.Add(verioku[0]);
            }
            baglanti.Close();
        }

        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("Select * from Biletler", baglanti);
            veriadaptoru.Fill(veriseti, "Biletler");
            dataGridView1.DataSource = veriseti.Tables["Biletler"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        void seferseciniz()
        {
            OleDbDataReader verioku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select KalkisZamani From sefer";
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                cmbSeferSec.Items.Add(verioku[0]);
            }
            baglanti.Close();
        }

        void islemtipi()
        {
            cmbIslemTipi.Items.Add("Satış");
            cmbIslemTipi.Items.Add("Rezervasyon");
        }

        void cinsiyet()
        {
            cmbCinsiyet.Items.Add("Bayan");
            cmbCinsiyet.Items.Add("Bay");
        }

        void koltukkontrol()
        {
            ArrayList koltukno = new ArrayList();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT KoltukNo FROM Biletler WHERE Guzergah=('" + cmbGuzergahSec.Text + "') AND SeferID=('" + cmbSeferSec.Text+"')";
            veriokuyucu = komut.ExecuteReader();

            while (veriokuyucu.Read())
            {
                koltukno.Add(veriokuyucu["KoltukNo"]);
            }
            baglanti.Close();

            int a;
            a = koltukno.Count;
            txtUcret.Text = a.ToString();

            for(int i=0;i< a; i++)
            {
                cmbKoltukNo.Items.Remove("" + koltukno[i] + "");

            }
        }

        void koltukreng()
        {
            ArrayList koltukno = new ArrayList();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT KoltukNo FROM Biletler WHERE Guzergah=('" + cmbGuzergahSec.Text + "') AND SeferID=('" + cmbSeferSec.Text + "')";
            veriokuyucu = komut.ExecuteReader();

            while (veriokuyucu.Read())
            {
                koltukno.Add(veriokuyucu["KoltukNo"]);
            }
            baglanti.Close();

            int a;
            a = koltukno.Count;
            #region Bütün Koltukların Yeşil Yapıldığı Kısım
            for (int i = 1; i < 47; i++)
            {
                btnKoltuk1.BackColor = Color.Green;
                btnKoltuk2.BackColor = Color.Green;
                btnKoltuk3.BackColor = Color.Green;
                btnKoltuk4.BackColor = Color.Green;
                btnKoltuk5.BackColor = Color.Green;
                btnKoltuk6.BackColor = Color.Green;
                btnKoltuk7.BackColor = Color.Green;
                btnKoltuk8.BackColor = Color.Green;
                btnKoltuk9.BackColor = Color.Green;
                btnKoltuk10.BackColor = Color.Green;
                btnKoltuk11.BackColor = Color.Green;
                btnKoltuk12.BackColor = Color.Green;
                btnKoltuk13.BackColor = Color.Green;
                btnKoltuk14.BackColor = Color.Green;
                btnKoltuk15.BackColor = Color.Green;
                btnKoltuk16.BackColor = Color.Green;
                btnKoltuk17.BackColor = Color.Green;
                btnKoltuk18.BackColor = Color.Green;
                btnKoltuk19.BackColor = Color.Green;
                btnKoltuk20.BackColor = Color.Green;
                btnKoltuk21.BackColor = Color.Green;
                btnKoltuk22.BackColor = Color.Green;
                btnKoltuk23.BackColor = Color.Green;
                btnKoltuk24.BackColor = Color.Green;
                btnKoltuk25.BackColor = Color.Green;
                btnKoltuk26.BackColor = Color.Green;
                btnKoltuk27.BackColor = Color.Green;
                btnKoltuk28.BackColor = Color.Green;
                btnKoltuk29.BackColor = Color.Green;
                btnKoltuk30.BackColor = Color.Green;
                btnKoltuk31.BackColor = Color.Green;
                btnKoltuk32.BackColor = Color.Green;
                btnKoltuk33.BackColor = Color.Green;
                btnKoltuk34.BackColor = Color.Green;
                btnKoltuk35.BackColor = Color.Green;
                btnKoltuk36.BackColor = Color.Green;
                btnKoltuk37.BackColor = Color.Green;
                btnKoltuk38.BackColor = Color.Green;
                btnKoltuk39.BackColor = Color.Green;
                btnKoltuk40.BackColor = Color.Green;
                btnKoltuk41.BackColor = Color.Green;
                btnKoltuk42.BackColor = Color.Green;
                btnKoltuk43.BackColor = Color.Green;
                btnKoltuk44.BackColor = Color.Green;
                btnKoltuk45.BackColor = Color.Green;
                btnKoltuk46.BackColor = Color.Green;
            }
            #endregion

            #region Bayan Koltukların Renginin Ayarlandığı Kısım
            ArrayList koltukbayan = new ArrayList();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT KoltukNo,YolcuCinsiyet FROM Biletler WHERE Guzergah=('" + cmbGuzergahSec.Text + "') AND SeferID=('" + cmbSeferSec.Text + "') AND YolcuCinsiyet IN ('Bayan')";
            veriokuyucu = komut.ExecuteReader();

            while (veriokuyucu.Read())
            {
                koltukbayan.Add(veriokuyucu["KoltukNo"]);
            }
            baglanti.Close();

            for (int i=0;i<koltukbayan.Count;i++)
            {
                int d;
                d = Convert.ToInt32(koltukbayan[i]);
                for (int j=1;j<47;j++)
                {
                    if(d == j)
                    {
                        switch (d)
                        {
                            case 1:
                                btnKoltuk1.BackColor = Color.Pink;
                                break;
                            case 2:
                                btnKoltuk2.BackColor = Color.Pink;
                                break;
                            case 3:
                                btnKoltuk3.BackColor = Color.Pink;
                                break;
                            case 4:
                                btnKoltuk4.BackColor = Color.Pink;
                                break;
                            case 5:
                                btnKoltuk5.BackColor = Color.Pink;
                                break;
                            case 6:
                                btnKoltuk6.BackColor = Color.Pink;
                                break;
                            case 7:
                                btnKoltuk7.BackColor = Color.Pink;
                                break;
                            case 8:
                                btnKoltuk8.BackColor = Color.Pink;
                                break;
                            case 9:
                                btnKoltuk9.BackColor = Color.Pink;
                                break;
                            case 10:
                                btnKoltuk10.BackColor = Color.Pink;
                                break;
                            case 11:
                                btnKoltuk11.BackColor = Color.Pink;
                                break;
                            case 12:
                                btnKoltuk12.BackColor = Color.Pink;
                                break;
                            case 13:
                                btnKoltuk13.BackColor = Color.Pink;
                                break;
                            case 14:
                                btnKoltuk14.BackColor = Color.Pink;
                                break;
                            case 15:
                                btnKoltuk15.BackColor = Color.Pink;
                                break;
                            case 16:
                                btnKoltuk16.BackColor = Color.Pink;
                                break;
                            case 17:
                                btnKoltuk17.BackColor = Color.Pink;
                                break;
                            case 18:
                                btnKoltuk18.BackColor = Color.Pink;
                                break;
                            case 19:
                                btnKoltuk19.BackColor = Color.Pink;
                                break;
                            case 20:
                                btnKoltuk20.BackColor = Color.Pink;
                                break;
                            case 21:
                                btnKoltuk21.BackColor = Color.Pink;
                                break;
                            case 22:
                                btnKoltuk22.BackColor = Color.Pink;
                                break;
                            case 23:
                                btnKoltuk23.BackColor = Color.Pink;
                                break;
                            case 24:
                                btnKoltuk24.BackColor = Color.Pink;
                                break;
                            case 25:
                                btnKoltuk25.BackColor = Color.Pink;
                                break;
                            case 26:
                                btnKoltuk26.BackColor = Color.Pink;
                                break;
                            case 27:
                                btnKoltuk27.BackColor = Color.Pink;
                                break;
                            case 28:
                                btnKoltuk28.BackColor = Color.Pink;
                                break;
                            case 29:
                                btnKoltuk29.BackColor = Color.Pink;
                                break;
                            case 30:
                                btnKoltuk30.BackColor = Color.Pink;
                                break;
                            case 31:
                                btnKoltuk31.BackColor = Color.Pink;
                                break;
                            case 32:
                                btnKoltuk32.BackColor = Color.Pink;
                                break;
                            case 33:
                                btnKoltuk33.BackColor = Color.Pink;
                                break;
                            case 34:
                                btnKoltuk34.BackColor = Color.Pink;
                                break;
                            case 35:
                                btnKoltuk35.BackColor = Color.Pink;
                                break;
                            case 36:
                                btnKoltuk36.BackColor = Color.Pink;
                                break;
                            case 37:
                                btnKoltuk37.BackColor = Color.Pink;
                                break;
                            case 38:
                                btnKoltuk38.BackColor = Color.Pink;
                                break;
                            case 39:
                                btnKoltuk39.BackColor = Color.Pink;
                                break;
                            case 40:
                                btnKoltuk40.BackColor = Color.Pink;
                                break;
                            case 41:
                                btnKoltuk41.BackColor = Color.Pink;
                                break;
                            case 42:
                                btnKoltuk42.BackColor = Color.Pink;
                                break;
                            case 43:
                                btnKoltuk43.BackColor = Color.Pink;
                                break;
                            case 44:
                                btnKoltuk44.BackColor = Color.Pink;
                                break;
                            case 45:
                                btnKoltuk45.BackColor = Color.Pink;
                                break;
                            case 46:
                                btnKoltuk46.BackColor = Color.Pink;
                                break;
                        }
                    }
                }
            }
            #endregion

            #region Bay Koltukların Renginin Ayarlandığı Kısım
            ArrayList koltukbay = new ArrayList();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT KoltukNo,YolcuCinsiyet FROM Biletler WHERE Guzergah=('" + cmbGuzergahSec.Text + "') AND SeferID=('" + cmbSeferSec.Text + "') AND YolcuCinsiyet IN ('Bay')";
            veriokuyucu = komut.ExecuteReader();

            while (veriokuyucu.Read())
            {
                koltukbay.Add(veriokuyucu["KoltukNo"]);
            }
            baglanti.Close();

            for (int i = 0; i < koltukbay.Count; i++)
            {
                int d;
                d = Convert.ToInt32(koltukbay[i]);
                for (int j = 1; j < 47; j++)
                {
                    if (d == j)
                    {
                        switch (d)
                        {
                            case 1:
                                btnKoltuk1.BackColor = Color.Blue;
                                break;
                            case 2:
                                btnKoltuk2.BackColor = Color.Blue;
                                break;
                            case 3:
                                btnKoltuk3.BackColor = Color.Blue;
                                break;
                            case 4:
                                btnKoltuk4.BackColor = Color.Blue;
                                break;
                            case 5:
                                btnKoltuk5.BackColor = Color.Blue;
                                break;
                            case 6:
                                btnKoltuk6.BackColor = Color.Blue;
                                break;
                            case 7:
                                btnKoltuk7.BackColor = Color.Blue;
                                break;
                            case 8:
                                btnKoltuk8.BackColor = Color.Blue;
                                break;
                            case 9:
                                btnKoltuk9.BackColor = Color.Blue;
                                break;
                            case 10:
                                btnKoltuk10.BackColor = Color.Blue;
                                break;
                            case 11:
                                btnKoltuk11.BackColor = Color.Blue;
                                break;
                            case 12:
                                btnKoltuk12.BackColor = Color.Blue;
                                break;
                            case 13:
                                btnKoltuk13.BackColor = Color.Blue;
                                break;
                            case 14:
                                btnKoltuk14.BackColor = Color.Blue;
                                break;
                            case 15:
                                btnKoltuk15.BackColor = Color.Blue;
                                break;
                            case 16:
                                btnKoltuk16.BackColor = Color.Blue;
                                break;
                            case 17:
                                btnKoltuk17.BackColor = Color.Blue;
                                break;
                            case 18:
                                btnKoltuk18.BackColor = Color.Blue;
                                break;
                            case 19:
                                btnKoltuk19.BackColor = Color.Blue;
                                break;
                            case 20:
                                btnKoltuk20.BackColor = Color.Blue;
                                break;
                            case 21:
                                btnKoltuk21.BackColor = Color.Blue;
                                break;
                            case 22:
                                btnKoltuk22.BackColor = Color.Blue;
                                break;
                            case 23:
                                btnKoltuk23.BackColor = Color.Blue;
                                break;
                            case 24:
                                btnKoltuk24.BackColor = Color.Blue;
                                break;
                            case 25:
                                btnKoltuk25.BackColor = Color.Blue;
                                break;
                            case 26:
                                btnKoltuk26.BackColor = Color.Blue;
                                break;
                            case 27:
                                btnKoltuk27.BackColor = Color.Blue;
                                break;
                            case 28:
                                btnKoltuk28.BackColor = Color.Blue;
                                break;
                            case 29:
                                btnKoltuk29.BackColor = Color.Blue;
                                break;
                            case 30:
                                btnKoltuk30.BackColor = Color.Blue;
                                break;
                            case 31:
                                btnKoltuk31.BackColor = Color.Blue;
                                break;
                            case 32:
                                btnKoltuk32.BackColor = Color.Blue;
                                break;
                            case 33:
                                btnKoltuk33.BackColor = Color.Blue;
                                break;
                            case 34:
                                btnKoltuk34.BackColor = Color.Blue;
                                break;
                            case 35:
                                btnKoltuk35.BackColor = Color.Blue;
                                break;
                            case 36:
                                btnKoltuk36.BackColor = Color.Blue;
                                break;
                            case 37:
                                btnKoltuk37.BackColor = Color.Blue;
                                break;
                            case 38:
                                btnKoltuk38.BackColor = Color.Blue;
                                break;
                            case 39:
                                btnKoltuk39.BackColor = Color.Blue;
                                break;
                            case 40:
                                btnKoltuk40.BackColor = Color.Blue;
                                break;
                            case 41:
                                btnKoltuk41.BackColor = Color.Blue;
                                break;
                            case 42:
                                btnKoltuk42.BackColor = Color.Blue;
                                break;
                            case 43:
                                btnKoltuk43.BackColor = Color.Blue;
                                break;
                            case 44:
                                btnKoltuk44.BackColor = Color.Blue;
                                break;
                            case 45:
                                btnKoltuk45.BackColor = Color.Blue;
                                break;
                            case 46:
                                btnKoltuk46.BackColor = Color.Blue;
                                break;
                        }
                    }
                }
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbGuzergahSec.Text != "" && cmbSeferSec.Text != "" && cmbIslemTipi.Text != "" && cmbKoltukNo.Text != "" && cmbCinsiyet.Text != "" && txtUcret.Text != "" && txtYolcuAdSoyad.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = "insert into Biletler(SeferID,SatisRezervasyon,KoltukNo,YolcuCinsiyet,YolcuAd,Ucret,Guzergah) values ('" + cmbSeferSec.Text + "','" + cmbIslemTipi.Text + "','" + cmbKoltukNo.Text + "','" + cmbCinsiyet.Text + "','" + txtYolcuAdSoyad.Text + "','" + txtUcret.Text + "','" + cmbGuzergahSec.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Tamamlandı!");
                veriseti.Clear();
                listele();
                koltukreng();
            }
        }

        private void cmbSeferSec_SelectedValueChanged(object sender, EventArgs e)
        {
            koltukkontrol();
            koltukreng();

            veriseti.Clear();
            baglanti.Open();
            OleDbDataAdapter veriadaptoru = new OleDbDataAdapter("SELECT * FROM Biletler WHERE Guzergah=('" + cmbGuzergahSec.Text + "') AND SeferID=('" + cmbSeferSec.Text + "')", baglanti);
            veriadaptoru.Fill(veriseti, "Biletler");
            dataGridView1.DataSource = veriseti.Tables["Biletler"];
            veriadaptoru.Dispose();
            baglanti.Close();
        }

        private void cmbGuzergahSec_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbSeferSec.Enabled = true;
        }
    }
}
