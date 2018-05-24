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
            pc_altk1.adi = "Dizüstü Bilgisayar";
            pc_altk1.urunSayisi = 0;

            AltKategoriler pc_altk2 = new AltKategoriler();
            pc_altk2.adi = "Masaüstü Bilgisayar";
            pc_altk2.urunSayisi = 0;

            AltKategoriler be_altk1 = new AltKategoriler();
            be_altk1.adi = "Buzdolabı";
            be_altk1.urunSayisi = 0;

            Urun urun1 = new Urun();
            urun1.urunKodu = 0;
            urun1.marka = "Samsung";
            urun1.model = 2000;
            urun1.miktar = 10;
            urun1.maliyet = 1500;
            urun1.satisFiyati = 2000;
            urun1.urunAciklamasi = "Temiz, doktordan...";
            urun1.hangiKategoride = "Bilgisayar";
            urun1.hangiAltkatta = "Dizüstü";
            pc_altk1.urunSayisi++;

            Urun urun2 = new Urun();
            urun2.urunKodu = 1;
            urun2.marka = "Toshiba";
            urun2.model = 2005;
            urun2.miktar = 30;
            urun2.maliyet = 1600;
            urun2.satisFiyati = 2100;
            urun2.urunAciklamasi = "Temiz, avukattan...";
            urun2.hangiKategoride = "Bilgisayar";
            urun2.hangiAltkatta = "Masaüstü";
            pc_altk2.urunSayisi++;

            Urun urun3 = new Urun();
            urun3.urunKodu = 2;
            urun3.marka = "Asus";
            urun3.model = 2015;
            urun3.miktar = 4;
            urun3.maliyet = 2600;
            urun3.satisFiyati = 2900;
            urun3.urunAciklamasi = "Temiz, bakkaldan...";
            urun3.hangiKategoride = "Bilgisayar";
            urun3.hangiAltkatta = "Masaüstü";
            pc_altk2.urunSayisi++;

            Urun urun4 = new Urun();
            urun4.urunKodu = 3;
            urun4.marka = "Xiaomi";
            urun4.model = 2017;
            urun4.miktar = 8;
            urun4.maliyet = 1300;
            urun4.satisFiyati = 1800;
            urun4.urunAciklamasi = "Çinden, tertemiz...";
            urun4.hangiKategoride = "Bilgisayar";
            urun4.hangiAltkatta = "Masaüstü";
            pc_altk2.urunSayisi++;

            Urun urun5 = new Urun();
            urun5.urunKodu = 4;
            urun5.marka = "Bosch";
            urun5.model = 2017;
            urun5.miktar = 81;
            urun5.maliyet = 1350;
            urun5.satisFiyati = 1900;
            urun5.urunAciklamasi = "temiz...";
            urun5.hangiKategoride = "Beyaz Eşya";
            urun5.hangiAltkatta = "Buzdolabı";
            be_altk1.urunSayisi++;


            dizustu.Insert(urun1);
            masaustu.Insert(urun2);
            masaustu.Insert(urun3);
            masaustu.Insert(urun4);

            bilgisayarAgaci = new IkiliAramaAgaci();
            bilgisayarAgaci.AltKategoriEkle(pc_altk1,dizustu);
            bilgisayarAgaci.AltKategoriEkle(pc_altk2, masaustu);

            buzdolabi.Insert(urun5);

            beyazEsyaAgaci = new IkiliAramaAgaci();
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
            frm.ShowDialog();
            this.Hide();

        }
    }
}
