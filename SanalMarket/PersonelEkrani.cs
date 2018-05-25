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
            grb_Kategori.Hide();
        }
        private void GerekliGizlemeler()
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
            btn_UrunEkle.Hide();
            btn_UrunSil.Hide();
            btn_UrunGuncelle.Hide();
            cmb_AltKatBilg.Hide();
            cmb_AltKatBEsya.Hide();
            cmb_AltKatGym.Hide();
            txt_UrunAra.Hide();
            btn_UrunAra.Hide();
            grb_Kategori.Hide();
        }
        private void GizlileriGoster()
        {
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
        }

        public Market market;
        public HashMap hashTablosu;
        Urun bulunanUrun;
        string arananUrun;

        private void AnaMenudekiUrunEklemeyeTiklama(object sender, EventArgs e)
        {
            GerekliGizlemeler();
            GizlileriGoster();
            cmb_KategoriSecim.Show();
            btn_UrunEkle.Show();
        }

        private void AnaMenudekiUrunSilmeyeTiklama(object sender, EventArgs e)
        {
            GerekliGizlemeler();
            GizlileriGoster();

            btn_UrunSil.Show();
            txt_UrunAra.Show();
            btn_UrunAra.Show();
        }

        private void AnaMenudekiUrunGuncelleyeTiklama(object sender, EventArgs e)
        {
            GerekliGizlemeler();
            GizlileriGoster();

            btn_UrunGuncelle.Show();
            txt_UrunAra.Show();
            btn_UrunAra.Show();
        }



        private void UrunEklemeyeTiklama(object sender, EventArgs e)
        {
            Urun yeniUrun = new Urun();
            yeniUrun.marka = txtMarka.Text;
            yeniUrun.model = txtModel.Text;
            yeniUrun.miktar = Convert.ToInt32(txtMiktar.Text);
            yeniUrun.maliyet = Convert.ToInt32(txtMaliyet.Text);
            yeniUrun.satisFiyati = Convert.ToInt32(txtSatisFiyati.Text);
            yeniUrun.urunAciklamasi = txtUrunAciklama.Text;
            yeniUrun.hangiKategoride = hangiKategori;
            yeniUrun.hangiAltkategoride = hangiAltKategori;

            foreach (IkiliAramaAgaci kategori in market.kategoriListesi)
            {
                if (kategori.kategoriAdi == hangiKategori)
                {
                    kategori.Ara(hangiAltKategori).urunler.Add(yeniUrun);

                    hashTablosu.UrunEkleme(yeniUrun.model, yeniUrun);
                }
            }

        }

        private void UrunSileTiklama(object sender, EventArgs e)
        {
            arananUrun = txt_UrunAra.Text;

            if (hashTablosu.bulunduMu)
            {
                if (bulunanUrun != null)
                {
                    foreach (IkiliAramaAgaci kategori in market.kategoriListesi)
                    {
                        if (kategori.kategoriAdi == bulunanUrun.hangiKategoride)
                        {
                            kategori.Ara(bulunanUrun.hangiAltkategoride).urunler.Remove(bulunanUrun);

                            hashTablosu.UrunSilme(bulunanUrun.model);
                            MessageBox.Show(bulunanUrun.urunAciklamasi + " silindi.");
                        }
                    }
                }
                else
                    MessageBox.Show("Ürün bulunamadi");
            }
            else
                MessageBox.Show("Ürün bulunamadi");

        }

        private void UrunArayaTiklama(object sender, EventArgs e)
        {
            arananUrun = txt_UrunAra.Text;

            bulunanUrun = hashTablosu.UrunBulma(arananUrun);

            if (hashTablosu.bulunduMu)
            {
                if (bulunanUrun != null)
                {
                    MessageBox.Show(bulunanUrun.urunAciklamasi + " bulundu.");

                    txtMarka.Text = bulunanUrun.marka;
                    txtModel.Text = bulunanUrun.model;
                    txtMiktar.Text = (bulunanUrun.miktar).ToString();
                    txtMaliyet.Text = (bulunanUrun.maliyet).ToString();
                    txtSatisFiyati.Text = (bulunanUrun.satisFiyati).ToString();
                    txtUrunAciklama.Text = (bulunanUrun.urunAciklamasi).ToString();
                }
                else
                    MessageBox.Show("Ürün bulunamadı.");
            }

            else
                MessageBox.Show("Ürün bulunamadı.");
        }

        private void UrunGuncelleyeTiklama(object sender, EventArgs e)
        {
            if (hashTablosu.bulunduMu)
            {
                if (bulunanUrun != null)
                {
                    foreach (IkiliAramaAgaci kategori in market.kategoriListesi)
                    {
                        if (kategori.kategoriAdi == bulunanUrun.hangiKategoride)
                        {
                            Urun yeniUrun = new Urun();
                            yeniUrun.marka = txtMarka.Text;
                            yeniUrun.model = txtModel.Text;
                            yeniUrun.miktar = Convert.ToInt32(txtMiktar.Text);
                            yeniUrun.maliyet = Convert.ToInt32(txtMaliyet.Text);
                            yeniUrun.satisFiyati = Convert.ToInt32(txtSatisFiyati.Text);
                            yeniUrun.urunAciklamasi = txtUrunAciklama.Text;
                            yeniUrun.hangiKategoride = bulunanUrun.hangiKategoride;
                            yeniUrun.hangiAltkategoride = bulunanUrun.hangiAltkategoride;

                            kategori.Ara(bulunanUrun.hangiAltkategoride).urunler.Remove(bulunanUrun);

                            kategori.Ara(bulunanUrun.hangiAltkategoride).urunler.Add(yeniUrun);

                            hashTablosu.UrunSilme(bulunanUrun.model);

                            hashTablosu.UrunEkleme(yeniUrun.model, yeniUrun);

                            MessageBox.Show(yeniUrun.urunAciklamasi + " güncellendi");
                        }

                    }
                }
                else
                    MessageBox.Show("Ürün bulunamadi");
            }
            else
                MessageBox.Show("Ürün bulunamadi");
        }


        string hangiKategori;
        private void cmb_KategoriSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiKategori = cmb_KategoriSecim.SelectedItem.ToString();
            KategoriBelirleme(hangiKategori);
        }
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

        string hangiAltKategori;
        private void cmb_AltKatBilg_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiAltKategori = cmb_AltKatBilg.SelectedItem.ToString();
        }
        private void cmb_AltKatBEsya_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiAltKategori = cmb_AltKatBEsya.SelectedItem.ToString();
        }
        private void cmb_AltKatGym_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangiAltKategori = cmb_AltKatGym.SelectedItem.ToString();
        }



        private void MaliRaporaTiklama(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam satılan ürün sayısı :  " + market.satilanUrunsayisi +
                             Environment.NewLine + "Toplam kar :  " + market.toplamKar);
        }

        private void KategoriEkleyeTiklama(object sender, EventArgs e)
        {
            GerekliGizlemeler();
            grb_Kategori.Show();           
        }

        private void btn_KatEkle_Click(object sender, EventArgs e)
        {
            IkiliAramaAgaci yeniAgac = new IkiliAramaAgaci();
            yeniAgac.kategoriAdi = txt_Kategori.Text;

            AltKategoriler yeniAltKat = new AltKategoriler();
            yeniAltKat.adi = txt_AltKat.Text;
            yeniAltKat.dugumNumarasi = yeniAltKat.AgacSiralamasiIcinNo(yeniAltKat.adi);
            yeniAgac.AltKategoriEkle(yeniAltKat, null, null);

            market.AgacEkle(yeniAgac);

            grb_Kategori.Hide();
            MessageBox.Show(yeniAgac.kategoriAdi + " kategorisi eklendi");
        }
    }
}

