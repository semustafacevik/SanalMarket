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
        static Heap buzdolabi = new Heap(50);

        HashMap hashTablosu = new HashMap();

        public frm_AnaEkran()
        {
            InitializeComponent();
        }

        IkiliAramaAgaci bilgisayarAgaci;
        IkiliAramaAgaci beyazEsyaAgaci;

        Market market = new Market();

        private void btn_Olustur_Click(object sender, EventArgs e)
        {
            AltKategoriler pc_altk1 = new AltKategoriler();
            pc_altk1.adi = "Dizüstü";
            pc_altk1.dugumNo = 4;

            AltKategoriler pc_altk2 = new AltKategoriler();
            pc_altk2.adi = "Masaüstü";
            pc_altk2.dugumNo = 6;

            AltKategoriler be_altk1 = new AltKategoriler();
            be_altk1.adi = "Buzdolabı";
            be_altk1.dugumNo = 1;

            Urun urun1 = new Urun
            {
                urunKodu = 0,
                marka = "Samsung",
                model = 2000,
                miktar = 10,
                maliyet = 1500,
                satisFiyati = 2000,
                urunAciklamasi = "Temiz, doktordan...",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Dizüstü"
            };
            pc_altk1.urunSayisi++;

            Urun urun2 = new Urun
            {
                urunKodu = 1,
                marka = "Toshiba",
                model = 2005,
                miktar = 30,
                maliyet = 1600,
                satisFiyati = 2100,
                urunAciklamasi = "Temiz, avukattan...",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Masaüstü"
            };
            pc_altk2.urunSayisi++;

            Urun urun3 = new Urun
            {
                urunKodu = 2,
                marka = "Asus",
                model = 2015,
                miktar = 4,
                maliyet = 2600,
                satisFiyati = 2900,
                urunAciklamasi = "Temiz, bakkaldan...",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Masaüstü"
            };
            pc_altk2.urunSayisi++;

            Urun urun4 = new Urun
            {
                urunKodu = 3,
                marka = "Xiaomi",
                model = 2017,
                miktar = 8,
                maliyet = 1300,
                satisFiyati = 1800,
                urunAciklamasi = "Çinden, tertemiz...",
                hangiKategoride = "Bilgisayar",
                hangiAltkategoride = "Masaüstü"
            };
            pc_altk2.urunSayisi++;

            Urun urun5 = new Urun
            {
                urunKodu = 51,
                marka = "Bosch",
                model = 2017,
                miktar = 81,
                maliyet = 1350,
                satisFiyati = 1900,
                urunAciklamasi = "temiz...",
                hangiKategoride = "Beyaz Eşya",
                hangiAltkategoride = "Buzdolabı"
            };
            be_altk1.urunSayisi++;


            dizustu.Insert(urun1);
            masaustu.Insert(urun2);
            masaustu.Insert(urun3);
            masaustu.Insert(urun4);

            bilgisayarAgaci = new IkiliAramaAgaci();
            bilgisayarAgaci.kategoriAdi = "Bilgisayar";
            bilgisayarAgaci.AltKategoriEkle(pc_altk1,dizustu);
            bilgisayarAgaci.AltKategoriEkle(pc_altk2, masaustu);

            buzdolabi.Insert(urun5);

            beyazEsyaAgaci = new IkiliAramaAgaci();
            beyazEsyaAgaci.kategoriAdi = "Beyaz Eşya";
            beyazEsyaAgaci.AltKategoriEkle(be_altk1, buzdolabi);

            market.AgacEkle(bilgisayarAgaci);
            market.AgacEkle(beyazEsyaAgaci);

            hashTablosu.UrunEkleme(urun1.urunKodu, urun1);
            hashTablosu.UrunEkleme(urun2.urunKodu, urun2);
            hashTablosu.UrunEkleme(urun3.urunKodu, urun3);
            hashTablosu.UrunEkleme(urun4.urunKodu, urun4);
            hashTablosu.UrunEkleme(urun5.urunKodu, urun5);



            //hashTablosu.GetUrun(urun1.miktar);
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string kategori = cmb_Kategori.SelectedItem.ToString();

            Urun yeniUrun = new Urun();
            yeniUrun.marka = txt_Marka.Text;
            yeniUrun.model = Convert.ToInt32(txt_Model.Text);
            yeniUrun.miktar = Convert.ToInt32(txt_Miktar.Text);
            yeniUrun.maliyet = Convert.ToInt32(txt_Maliyet.Text);
            yeniUrun.satisFiyati = Convert.ToInt32(txt_SatisFiyati.Text);
            yeniUrun.urunAciklamasi = txt_Aciklama.Text;
            yeniUrun.hangiKategoride = kategori;

            //bilgisayarAgaci.Ekle(yeniUrun);

            market.AgacEkle(bilgisayarAgaci);

        }

        private void frm_AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            frm_PersonelGirisi frm = new frm_PersonelGirisi();
            frm.market = this.market;
            frm.ShowDialog();
            this.Hide();

        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            txt_Goster.Text = hashTablosu.UrunBulma(Convert.ToInt32(txt_Bul.Text)).marka;
        }
    }
}
