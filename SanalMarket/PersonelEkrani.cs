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
            cmb_KategoriSecim.Hide();
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
            cmb_AltKatGym.Hide();
        }
        public void GizlileriGoster()
        {
            cmb_KategoriSecim.Show();
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
            yeniUrun.model = txtModel.Text;
            yeniUrun.miktar = Convert.ToInt32(txtMiktar.Text);
            yeniUrun.maliyet = Convert.ToInt32(txtMaliyet.Text);
            yeniUrun.satisFiyati = Convert.ToInt32(txtSatisFiyati.Text);
            yeniUrun.urunAciklamasi = txtUrunAciklama.Text;

            foreach (IkiliAramaAgaci kategori in market.kategoriListesi)
            {
                if(kategori.kategoriAdi == hangiKategori)
                {
                    kategori.Ara(agactakiDugumNosu).urunler.Insert(yeniUrun);
                }
            }    

        }

        string hangiKategori;

        private void KategoriBelirleme(string kategori)
        {
            switch (kategori)
            {
                case "Bilgisayar":
                    cmb_AltKatBilg.Show();
                    cmb_AltKatBEsya.Hide();
                    cmb_AltKatGym.Hide();
                    break;

                case "Beyaz Eşya":
                    cmb_AltKatBEsya.Show();
                    cmb_AltKatBilg.Hide();
                    cmb_AltKatGym.Hide();
                    break;

                default:
                    cmb_AltKatGym.Show();
                    cmb_AltKatBilg.Hide();
                    cmb_AltKatBEsya.Hide();
                    break;
            }
        }

        private void cmbKategoriSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiKategori = cmb_KategoriSecim.SelectedItem.ToString();
            KategoriBelirleme(hangiKategori);
        }

        string hangiAltKategori;
        int agactakiDugumNosu;
        private void cmb_AltKatBilg_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiAltKategori = cmb_AltKatBilg.SelectedItem.ToString();

            switch (hangiAltKategori)
            {
                case "Dizüstü":
                    agactakiDugumNosu = 4;
                    break;

                case "Masaüstü":
                    agactakiDugumNosu = 6;
                    break;

                default:
                    agactakiDugumNosu = 2;
                    break;
            }

        }

        private void cmb_AltKatBEsya_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiAltKategori = cmb_AltKatBEsya.SelectedItem.ToString();

            switch (hangiAltKategori)
            {
                case "Buzdolabı":
                    agactakiDugumNosu = 1;
                    break;

                default:
                    agactakiDugumNosu = 3;
                    break;
            }
        }

        private void cmb_AltKatGym_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiAltKategori = cmb_AltKatGym.SelectedItem.ToString();

            switch (hangiAltKategori)
            {
                case "Gömlek":
                    agactakiDugumNosu = 8;
                    break;

                default:
                    agactakiDugumNosu = 11;
                    break;
            }

        }

        private void btn_UrunSil_Click(object sender, EventArgs e)
        {
            frm_UrunSil silmeFormu = new frm_UrunSil();
            silmeFormu.market = this.market;
            silmeFormu.StartPosition = FormStartPosition.CenterParent;
            silmeFormu.ShowDialog();
        }
    }
}
