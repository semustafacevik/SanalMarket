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
        static Heap dizustu = new Heap(50);
        static Heap masaustu = new Heap(50);
        static Heap oyun = new Heap(50);
        static Heap buzdolabi = new Heap(50);
        static Heap camasir = new Heap(50);
        static Heap gomlek = new Heap(50);
        static Heap pantolon = new Heap(50);

        HashMap hashTablosu = new HashMap();

        public frm_AnaEkran()
        {
            InitializeComponent();
            VerilerinEklenmesi();
        }

        IkiliAramaAgaci bilgisayarAgaci;
        IkiliAramaAgaci beyazEsyaAgaci;
        IkiliAramaAgaci giyimAgaci;

        Market ana_market = new Market();

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            frm_PersonelGirisi frm = new frm_PersonelGirisi();
            frm.market = this.ana_market;
            frm.ShowDialog();
            this.Hide();

        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            txt_Goster.Text = hashTablosu.UrunBulma(Convert.ToInt32(txt_Bul.Text)).marka;
        }

        private void VerilerinEklenmesi()
        {
            AltKategoriler altk1 = new AltKategoriler();
            altk1.adi = "Dizüstü";
            altk1.dugumNo = 4;

            AltKategoriler altk2 = new AltKategoriler();
            altk2.adi = "Masaüstü";
            altk2.dugumNo = 6;

            AltKategoriler altk3 = new AltKategoriler();
            altk3.adi = "Oyun";
            altk3.dugumNo = 2;

            AltKategoriler altk4 = new AltKategoriler();
            altk4.adi = "Buzdolabı";
            altk4.dugumNo = 5;

            AltKategoriler altk5 = new AltKategoriler();
            altk5.adi = "Çamaşır Makinesi";
            altk5.dugumNo = 3;

            AltKategoriler altk6 = new AltKategoriler();
            altk6.adi = "Gömlek";
            altk6.dugumNo = 8;

            AltKategoriler altk7 = new AltKategoriler();
            altk7.adi = "Pantolon";
            altk7.dugumNo = 11;

            Urun urun1 = new Urun
            {
                urunKodu = 0,
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
                urunKodu = 1,
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
                urunKodu = 4,
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
                urunKodu = 7,
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
                urunKodu = 51,
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
                urunKodu = 84,
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
                urunKodu = 16,
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
                urunKodu = 45,
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
                urunKodu = 210,
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
                urunKodu = 44,
                marka = "Mavi",
                model = "MA38",
                miktar = 42,
                maliyet = 160,
                satisFiyati = 220,
                urunAciklamasi = "Mavi G",
                hangiKategoride = "Giyim",
                hangiAltkategoride = "Pantolon"
            };

            dizustu.Insert(urun1);
            masaustu.Insert(urun2);
            masaustu.Insert(urun3);
            masaustu.Insert(urun4);
            oyun.Insert(urun5);
            oyun.Insert(urun6);
            buzdolabi.Insert(urun7);
            camasir.Insert(urun8);
            gomlek.Insert(urun9);
            pantolon.Insert(urun10);

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

            hashTablosu.UrunEkleme(urun1.urunKodu, urun1);
            hashTablosu.UrunEkleme(urun2.urunKodu, urun2);
            hashTablosu.UrunEkleme(urun3.urunKodu, urun3);
            hashTablosu.UrunEkleme(urun4.urunKodu, urun4);
            hashTablosu.UrunEkleme(urun5.urunKodu, urun5);
            hashTablosu.UrunEkleme(urun6.urunKodu, urun6);
            hashTablosu.UrunEkleme(urun7.urunKodu, urun7);
            hashTablosu.UrunEkleme(urun8.urunKodu, urun8);
            hashTablosu.UrunEkleme(urun9.urunKodu, urun9);
            hashTablosu.UrunEkleme(urun10.urunKodu, urun10);
        }
    }
}
