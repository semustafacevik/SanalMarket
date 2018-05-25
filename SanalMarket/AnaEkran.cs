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

namespace SanalMarket
{
    public partial class frm_AnaEkran : Form
    {
        ArrayList dizustu = new ArrayList();
        ArrayList masaustu = new ArrayList();
        ArrayList oyun = new ArrayList();
        ArrayList buzdolabi = new ArrayList();
        ArrayList camasir = new ArrayList();
        ArrayList gomlek = new ArrayList();
        ArrayList pantolon = new ArrayList();

        HashMap ana_hashTablosu = new HashMap();

        public frm_AnaEkran()
        {
            InitializeComponent();
            VerilerinEklenmesi();
            StartPosition = FormStartPosition.CenterScreen;
        }

        IkiliAramaAgaci bilgisayarAgaci;
        IkiliAramaAgaci beyazEsyaAgaci;
        IkiliAramaAgaci giyimAgaci;

        Market ana_market = new Market();

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            frm_PersonelGirisi personelGirisformu = new frm_PersonelGirisi();
            personelGirisformu.StartPosition = FormStartPosition.CenterParent;
            personelGirisformu.market = this.ana_market;
            personelGirisformu.hashTablosu = this.ana_hashTablosu;
            personelGirisformu.ShowDialog();
        }



        private void VerilerinEklenmesi()
        {
            AltKategoriler altk1 = new AltKategoriler();
            altk1.adi = "Dizüstü";
            altk1.dugumNumarasi = altk1.AgacSiralamasiIcinNo(altk1.adi);


            AltKategoriler altk2 = new AltKategoriler();
            altk2.adi = "Masaüstü";
            altk2.dugumNumarasi = altk2.AgacSiralamasiIcinNo(altk2.adi);

            AltKategoriler altk3 = new AltKategoriler();
            altk3.adi = "Oyun";
            altk3.dugumNumarasi = altk3.AgacSiralamasiIcinNo(altk3.adi);

            AltKategoriler altk4 = new AltKategoriler();
            altk4.adi = "Buzdolabı";
            altk4.dugumNumarasi = altk4.AgacSiralamasiIcinNo(altk4.adi);


            AltKategoriler altk5 = new AltKategoriler();
            altk5.adi = "Çamaşır Makinesi";
            altk5.dugumNumarasi = altk5.AgacSiralamasiIcinNo(altk5.adi);


            AltKategoriler altk6 = new AltKategoriler();
            altk6.adi = "Gömlek";
            altk6.dugumNumarasi = altk6.AgacSiralamasiIcinNo(altk6.adi);


            AltKategoriler altk7 = new AltKategoriler();
            altk7.adi = "Pantolon";
            altk7.dugumNumarasi = altk7.AgacSiralamasiIcinNo(altk7.adi);


            Urun urun1 = new Urun
            {
                marka = "Samsung",
                model = "L4",
                miktar = 10,
                maliyet = 1500,
                satisFiyati = 2000,
                urunAciklamasi = "Samsung PC",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Dizüstü"
            };

            Urun urun2 = new Urun
            {
                marka = "Toshiba",
                model = "T350",
                miktar = 30,
                maliyet = 1600,
                satisFiyati = 2100,
                urunAciklamasi = "Toshiba PC",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Masaüstü"
            };

            Urun urun3 = new Urun
            {
                marka = "Asus",
                model = "LL66",
                miktar = 4,
                maliyet = 2600,
                satisFiyati = 2900,
                urunAciklamasi = "Asus PC",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Masaüstü"
            };

            Urun urun4 = new Urun
            {
                marka = "Xiaomi",
                model = "XL8",
                miktar = 8,
                maliyet = 1300,
                satisFiyati = 1800,
                urunAciklamasi = "Xiaomi PC",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Masaüstü"
            };

            Urun urun5 = new Urun
            {
                marka = "Monster",
                model = "MX826",
                miktar = 18,
                maliyet = 6400,
                satisFiyati = 7200,
                urunAciklamasi = "Monster PC",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Oyun"
            };

            Urun urun6 = new Urun
            {
                marka = "Msi",
                model = "ML7462",
                miktar = 24,
                maliyet = 5240,
                satisFiyati = 6250,
                urunAciklamasi = "Msi PC",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Oyun"
            };

            Urun urun7 = new Urun
            {
                marka = "Bosch",
                model = "NF845",
                miktar = 32,
                maliyet = 3860,
                satisFiyati = 4500,
                urunAciklamasi = "Bosch BE",
                hangiKategoride = "Beyaz Eşya",
                hangiAltkategoride = "Buzdolabı"
            };

            Urun urun8 = new Urun
            {
                marka = "Vestel",
                model = "V89",
                miktar = 34,
                maliyet = 3840,
                satisFiyati = 4300,
                urunAciklamasi = "Vestel BE",
                hangiKategoride = "Beyaz Eşya",
                hangiAltkategoride = "Çamaşır Makinesi"
            };

            Urun urun9 = new Urun
            {
                marka = "Tudors",
                model = "SF12",
                miktar = 53,
                maliyet = 200,
                satisFiyati = 300,
                urunAciklamasi = "Tudors G",
                hangiKategoride = "Giyim",
                hangiAltkategoride = "Gömlek"
            };

            Urun urun10 = new Urun
            {
                marka = "Mavi",
                model = "MA38",
                miktar = 42,
                maliyet = 160,
                satisFiyati = 220,
                urunAciklamasi = "Mavi G",
                hangiKategoride = "Giyim",
                hangiAltkategoride = "Pantolon"
            };

            dizustu.Add(urun1);
            masaustu.Add(urun2);
            masaustu.Add(urun3);
            masaustu.Add(urun4);
            oyun.Add(urun5);
            oyun.Add(urun6);
            buzdolabi.Add(urun7);
            camasir.Add(urun8);
            gomlek.Add(urun9);
            pantolon.Add(urun10);

            bilgisayarAgaci = new IkiliAramaAgaci();
            bilgisayarAgaci.kategoriAdi = "Bilgisayar";
            bilgisayarAgaci.AltKategoriEkle(altk1, dizustu);
            bilgisayarAgaci.AltKategoriEkle(altk2, masaustu);
            bilgisayarAgaci.AltKategoriEkle(altk3, oyun);


            beyazEsyaAgaci = new IkiliAramaAgaci();
            beyazEsyaAgaci.kategoriAdi = "Beyaz Eşya";
            beyazEsyaAgaci.AltKategoriEkle(altk4, buzdolabi);
            beyazEsyaAgaci.AltKategoriEkle(altk5, camasir);


            giyimAgaci = new IkiliAramaAgaci();
            giyimAgaci.kategoriAdi = "Giyim";
            giyimAgaci.AltKategoriEkle(altk6, gomlek);
            giyimAgaci.AltKategoriEkle(altk7, pantolon);


            ana_market.AgacEkle(bilgisayarAgaci);
            ana_market.AgacEkle(beyazEsyaAgaci);
            ana_market.AgacEkle(giyimAgaci);

            ana_hashTablosu.UrunEkleme(urun1.model, urun1);
            ana_hashTablosu.UrunEkleme(urun2.model, urun2);
            ana_hashTablosu.UrunEkleme(urun3.model, urun3);
            ana_hashTablosu.UrunEkleme(urun4.model, urun4);
            ana_hashTablosu.UrunEkleme(urun5.model, urun5);
            ana_hashTablosu.UrunEkleme(urun6.model, urun6);
            ana_hashTablosu.UrunEkleme(urun7.model, urun7);
            ana_hashTablosu.UrunEkleme(urun8.model, urun8);
            ana_hashTablosu.UrunEkleme(urun9.model, urun9);
            ana_hashTablosu.UrunEkleme(urun10.model, urun10);
        }


        string aranacakUrun;
        Urun bulunanUrun;

        private void btn_UrunBul_Click(object sender, EventArgs e)
        {
            aranacakUrun = txt_UrunBul.Text;

            bulunanUrun = ana_hashTablosu.UrunBulma(aranacakUrun);

            MessageBox.Show(bulunanUrun.urunAciklamasi + "bulundu" + bulunanUrun.miktar);

            txtMarka.Text = bulunanUrun.marka;
            txtModel.Text = bulunanUrun.model;
            txtMiktar.Text = (bulunanUrun.miktar).ToString();
            txtMaliyet.Text = (bulunanUrun.maliyet).ToString();
            txtSatisFiyati.Text = (bulunanUrun.satisFiyati).ToString();
            txtUrunAciklama.Text = (bulunanUrun.urunAciklamasi).ToString();

        }

        private void btn_SatinAl_Click(object sender, EventArgs e)
        {
            bulunanUrun.miktar--;

            MessageBox.Show(bulunanUrun.urunAciklamasi + "satın alındı" + bulunanUrun.miktar );

            ana_market.satilanUrunsayisi++;
            ana_market.toplamKar += (bulunanUrun.satisFiyati - bulunanUrun.maliyet);

            txtMiktar.Text = bulunanUrun.miktar.ToString();
        }
    }
}
