using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüs_Bilet_Otomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void markaİşmeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Marka İşlemleri Formununu tanımlıyoruz.
            MarkaIslemleri markaislemleri = new MarkaIslemleri();
            markaislemleri.MdiParent = this;
            markaislemleri.Show();
        }

        private void otobüsDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Otobus Detay formunu tanımlıyoruz.
            OtobusDetay otobusdetay = new OtobusDetay();
            otobusdetay.MdiParent = this;
            otobusdetay.Show();
        }

        private void şubeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Şube İşlmleri formunu tanımlıyoruz.
            SubeIslemleri subeislemleri = new SubeIslemleri();
            subeislemleri.MdiParent = this;
            subeislemleri.Show();
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Personel İşlemleri Formonu tanımlıyoruz.
            Personel personel = new Personel();
            personel.MdiParent = this;
            personel.Show();
        }

        private void masrafİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasrafCesitleri masraf = new MasrafCesitleri();
            masraf.MdiParent = this;
            masraf.Show();
        }

        private void pozisyonİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PozisyonIslemleri pozisyon = new PozisyonIslemleri();
            pozisyon.MdiParent = this;
            pozisyon.Show();
        }

        private void guzergahİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuzergahIslemleri guzergah = new GuzergahIslemleri();
            guzergah.MdiParent = this;
            guzergah.Show();
        }

        private void seferİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seferim sefer = new Seferim();
            sefer.MdiParent = this;
            sefer.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
        }

        private void biletİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bilet bilet = new bilet();
            bilet.MdiParent = this;
            bilet.Show();
        }

        private void yönetimselAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void biletİşlemleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bilet bilet = new bilet();
            bilet.MdiParent = this;
            bilet.Show();
        }
    }
}
