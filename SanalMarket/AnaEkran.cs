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
        Market ana_market = new Market();

        ArrayList dizustu = new ArrayList();
        ArrayList masaustu = new ArrayList();
        ArrayList oyun = new ArrayList();
        ArrayList buzdolabi = new ArrayList();
        ArrayList camasir = new ArrayList();
        ArrayList gomlek = new ArrayList();
        ArrayList pantolon = new ArrayList();

        HashMap ana_hashTablosu = new HashMap();

        Heap minHeapDiz = new Heap(50);
        Heap minHeapMas = new Heap(50);
        Heap minHeapOyu = new Heap(50);
        Heap minHeapBuz = new Heap(50);
        Heap minHeapCam = new Heap(50);
        Heap minHeapGom = new Heap(50);
        Heap minHeapPan = new Heap(50);

        public frm_AnaEkran()
        {
            InitializeComponent();
            VerilerinEklenmesi();
            StartPosition = FormStartPosition.CenterScreen;
        }

        IkiliAramaAgaci bilgisayarAgaci;
        IkiliAramaAgaci beyazEsyaAgaci;
        IkiliAramaAgaci giyimAgaci;



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

            minHeapDiz.Insert(urun1);
            minHeapMas.Insert(urun2);
            minHeapMas.Insert(urun3);
            minHeapMas.Insert(urun4);
            minHeapOyu.Insert(urun5);
            minHeapOyu.Insert(urun6);
            minHeapBuz.Insert(urun7);
            minHeapCam.Insert(urun8);
            minHeapGom.Insert(urun9);
            minHeapPan.Insert(urun10);


            bilgisayarAgaci = new IkiliAramaAgaci();
            bilgisayarAgaci.kategoriAdi = "Bilgisayar";
            bilgisayarAgaci.AltKategoriEkle(altk1, dizustu, minHeapDiz);
            bilgisayarAgaci.AltKategoriEkle(altk2, masaustu, minHeapMas);
            bilgisayarAgaci.AltKategoriEkle(altk3, oyun, minHeapOyu);
            bilgisayarAgaci.list_urunler.Add(urun1);
            bilgisayarAgaci.list_urunler.Add(urun2);
            bilgisayarAgaci.list_urunler.Add(urun3);
            bilgisayarAgaci.list_urunler.Add(urun4);
            bilgisayarAgaci.list_urunler.Add(urun5);
            bilgisayarAgaci.list_urunler.Add(urun6);


            beyazEsyaAgaci = new IkiliAramaAgaci();
            beyazEsyaAgaci.kategoriAdi = "Beyaz Eşya";
            beyazEsyaAgaci.AltKategoriEkle(altk4, buzdolabi, minHeapBuz);
            beyazEsyaAgaci.AltKategoriEkle(altk5, camasir, minHeapCam);
            beyazEsyaAgaci.list_urunler.Add(urun7);
            beyazEsyaAgaci.list_urunler.Add(urun8);

            giyimAgaci = new IkiliAramaAgaci();
            giyimAgaci.kategoriAdi = "Giyim";
            giyimAgaci.AltKategoriEkle(altk6, gomlek, minHeapGom);
            giyimAgaci.AltKategoriEkle(altk7, pantolon, minHeapPan);
            giyimAgaci.list_urunler.Add(urun9);
            giyimAgaci.list_urunler.Add(urun10);


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

            MessageBox.Show(bulunanUrun.urunAciklamasi + "satın alındı" + bulunanUrun.miktar);

            ana_market.satilanUrunsayisi++;
            ana_market.toplamKar += (bulunanUrun.satisFiyati - bulunanUrun.maliyet);

            txtMiktar.Text = bulunanUrun.miktar.ToString();
        }

        private void btn_AralikBul_Click(object sender, EventArgs e)
        {
            int minDeger = Convert.ToInt32(txt_min.Text);
            int maxDeger = Convert.ToInt32(txt_max.Text);

            foreach (Urun urun in ana_hashTablosu.urunler)
            {
                if (urun.satisFiyati > minDeger && urun.satisFiyati < maxDeger)
                {
                    MessageBox.Show(urun.urunAciklamasi + Environment.NewLine + urun.satisFiyati);
                }
            }
        }

        private void btn_KatYaz_Click(object sender, EventArgs e)
        {
            if (cmb_Kategori.SelectedIndex == 0)
            {
                switch (cmb_Gezinme.SelectedIndex)
                {
                    case 0:
                        bilgisayarAgaci.PreOrder();
                        break;
                    case 1:
                        bilgisayarAgaci.InOrder();
                        break;
                    case 2:
                        bilgisayarAgaci.PostOrder();
                        break;
                    default:
                        break;
                }
                txt_Yazdir.Text = bilgisayarAgaci.DugumleriYazdir();
            }

            else if (cmb_Kategori.SelectedIndex == 1)
            {
                switch (cmb_Gezinme.SelectedIndex)
                {
                    case 0:
                        beyazEsyaAgaci.PreOrder();
                        break;
                    case 1:
                        beyazEsyaAgaci.InOrder();
                        break;
                    case 2:
                        beyazEsyaAgaci.PostOrder();
                        break;
                    default:
                        break;
                }
                txt_Yazdir.Text = beyazEsyaAgaci.DugumleriYazdir();
            }

            else
            {
                switch (cmb_Gezinme.SelectedIndex)
                {
                    case 0:
                        giyimAgaci.PreOrder();
                        break;
                    case 1:
                        giyimAgaci.InOrder();
                        break;
                    case 2:
                        giyimAgaci.PostOrder();
                        break;
                    default:
                        break;
                }
                txt_Yazdir.Text = giyimAgaci.DugumleriYazdir();
            }
        }

        private void btn_EnUcuzSA_Click(object sender, EventArgs e)
        {
            int kacKere = Convert.ToInt32(txt_KacTane.Text);
            HeapDugumu urun;
            ana_market.satilanUrunsayisi += kacKere;


            switch (cmb_EnUcuzKat.SelectedIndex)
            {
                case 0:
                    {
                        for (int i = 0; i < kacKere; i++)
                        {
                            urun = minHeapDiz.RemoveMin();
                            MessageBox.Show(urun.Deger.urunAciklamasi);
                            ana_hashTablosu.UrunSilme(urun.Deger.model);
                            ana_market.toplamKar += (urun.Deger.satisFiyati - urun.Deger.maliyet);

                        }
                    }
                    break;

                case 1:
                    {
                        for (int i = 0; i < kacKere; i++)
                        {
                            urun = minHeapMas.RemoveMin();
                            MessageBox.Show(urun.Deger.urunAciklamasi);
                            ana_hashTablosu.UrunSilme(urun.Deger.model);
                            ana_market.toplamKar += (urun.Deger.satisFiyati - urun.Deger.maliyet);

                        }
                    }
                    break;
                case 2:
                    {
                        for (int i = 0; i < kacKere; i++)
                        {
                            urun = minHeapOyu.RemoveMin();
                            MessageBox.Show(urun.Deger.urunAciklamasi);
                            ana_hashTablosu.UrunSilme(urun.Deger.model);
                            ana_market.toplamKar += (urun.Deger.satisFiyati - urun.Deger.maliyet);

                        }
                    }
                    break;
                case 3:
                    {
                        for (int i = 0; i < kacKere; i++)
                        {
                            urun = minHeapBuz.RemoveMin();
                            MessageBox.Show(urun.Deger.urunAciklamasi);
                            ana_hashTablosu.UrunSilme(urun.Deger.model);
                            ana_market.toplamKar += (urun.Deger.satisFiyati - urun.Deger.maliyet);

                        }
                    }
                    break;
                case 4:
                    {
                        for (int i = 0; i < kacKere; i++)
                        {
                            urun = minHeapCam.RemoveMin();
                            MessageBox.Show(urun.Deger.urunAciklamasi);
                            ana_hashTablosu.UrunSilme(urun.Deger.model);
                            ana_market.toplamKar += (urun.Deger.satisFiyati - urun.Deger.maliyet);

                        }
                    }
                    break;
                case 5:
                    {
                        for (int i = 0; i < kacKere; i++)
                        {
                            urun = minHeapGom.RemoveMin();
                            MessageBox.Show(urun.Deger.urunAciklamasi);
                            ana_hashTablosu.UrunSilme(urun.Deger.model);
                            ana_market.toplamKar += (urun.Deger.satisFiyati - urun.Deger.maliyet);

                        }
                    }
                    break;
                case 6:
                    {
                        for (int i = 0; i < kacKere; i++)
                        {
                            urun = minHeapPan.RemoveMin();
                            MessageBox.Show(urun.Deger.urunAciklamasi);
                            ana_hashTablosu.UrunSilme(urun.Deger.model);
                            ana_market.toplamKar += (urun.Deger.satisFiyati - urun.Deger.maliyet);

                        }
                    }
                    break;

                default:
                    break;
            }

        }
    }
}

