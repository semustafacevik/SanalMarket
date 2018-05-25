using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalMarket
{
    public partial class frm_PersonelEkrani : Form
    {
        public frm_PersonelEkrani()
        {
            InitializeComponent();
            GerekliGizlemeler();
        }
        public void GerekliGizlemeler()
        {
            cmbKategoriSecim.Hide();
            lblMarka.Hide();
            lblModel.Hide();
            lblMiktar.Hide();
            lblMaliyet.Hide();
            lblSatisFiyati.Hide();
            lblUrunAciklama.Hide();
            txtMarka.Hide();
            txtModel.Hide();
            txtMiktar.Hide();
            txtMaliyet.Hide();
            txtSatisFiyati.Hide();
            txtUrunAciklama.Hide();
            btnUrunuEkle.Hide();
            cmb_AltKatBilg.Hide();
            cmb_AltKatBEsya.Hide();
        }
        public void GizlileriGoster()
        {
            cmbKategoriSecim.Show();
            lblMarka.Show();
            lblModel.Show();
            lblMiktar.Show();
            lblMaliyet.Show();
            lblSatisFiyati.Show();
            lblUrunAciklama.Show();
            txtMarka.Show();
            txtModel.Show();
            txtMiktar.Show();
            txtMaliyet.Show();
            txtSatisFiyati.Show();
            txtUrunAciklama.Show();
            btnUrunuEkle.Show();
        }

       public Market market;

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            GizlileriGoster();
        }

        private void btnUrunuEkle_Click(object sender, EventArgs e)
        {
            Urun yeniUrun = new Urun();
            yeniUrun.marka = txtMarka.Text;
            yeniUrun.model = Convert.ToInt32(txtModel.Text);
            yeniUrun.miktar = Convert.ToInt32(txtMiktar.Text);
            yeniUrun.maliyet = Convert.ToInt32(txtMaliyet.Text);
            yeniUrun.satisFiyati = Convert.ToInt32(txtSatisFiyati.Text);
            yeniUrun.urunAciklamasi = txtUrunAciklama.Text;

            foreach (IkiliAramaAgaci kategori in market.kategoriListesi)
            {
                if(kategori.kategoriAdi == hangiKat)
                {
                    kategori.Ara(agactakiDugumNosu).urunler.Insert(yeniUrun);
                }
            }    

        }

        string hangiKat;

        private void KategoriBelirleme(string kategori)
        {
            switch (kategori)
            {
                case "Bilgisayar":
                    cmb_AltKatBilg.Show();
                    cmb_AltKatBEsya.Hide();
                    hangiKat = "Bilgisayar";
                    break;

                case "Beyaz Eşya":
                    cmb_AltKatBilg.Hide();
                    cmb_AltKatBEsya.Show();
                    hangiKat = "Beyaz Eşya";
                    break;

                default:
                    break;
            }
        }

        string hangiAltkat;
        private void cmbKategoriSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiAltkat = cmbKategoriSecim.SelectedItem.ToString();
            KategoriBelirleme(hangiAltkat);
        }

        string hangiAltKat;
        int agactakiDugumNosu;
        private void cmb_AltKatBilg_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiAltKat = cmb_AltKatBilg.SelectedItem.ToString();

            switch (hangiAltkat)
            {
                case "Dizüstü":
                    agactakiDugumNosu = 4;
                    break;

                case "Masaüstü":
                    agactakiDugumNosu = 6;
                    break;

                default:
                    break;
            }

        }

        private void cmb_AltKatBEsya_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiAltKat = cmb_AltKatBEsya.SelectedItem.ToString();

            switch (hangiAltKat)
            {
                case "Buzdolabı":
                    agactakiDugumNosu = 1;
                    break;

                default:
                    break;
            }
        }
    }
}
