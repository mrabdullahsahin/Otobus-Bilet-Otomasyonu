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
    public partial class girisformu : Form
    {
        public girisformu()
        {
            InitializeComponent();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtkullaniciadi.Text;
            string sifre = txtsifre.Text;

            string veritabaniyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=biletsistemi.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(veritabaniyolu);
            OleDbCommand komut = new OleDbCommand();
            OleDbDataReader okuyucu;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Personel where KullaniciAdi='" + kullaniciadi + "' AND Sifre='" + sifre + "'";
            okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
            {
                AnaForm anaform = new AnaForm();
                this.Hide();
                anaform.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre yanlış");
                txtkullaniciadi.Text = "";
                txtsifre.Text = "";
                txtkullaniciadi.Focus();
            }

            baglanti.Close();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
