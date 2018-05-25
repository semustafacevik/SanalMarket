using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class IkiliAramaAgaci
    {

        private IkiliAramaAgacDugumu kok;
        private string dugumler;
        public string kategoriAdi;
        public List<Urun> list_urunler = new List<Urun>();

        public IkiliAramaAgaci()
        {

        }

        public IkiliAramaAgaci(IkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }

        public void AltKategoriEkle(AltKategoriler altKategori, ArrayList urunler, Heap siraliUrunler)
        {
            //Yeni eklenecek düğümün parent'ı
            IkiliAramaAgacDugumu tempParent = new IkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            IkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (altKategori.dugumNumarasi == tempSearch.veri.dugumNumarasi)
                    return;
                else if (altKategori.dugumNumarasi < tempSearch.veri.dugumNumarasi)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }

            IkiliAramaAgacDugumu eklenecek = new IkiliAramaAgacDugumu(altKategori,urunler,siraliUrunler);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;

            else if (altKategori.dugumNumarasi < tempParent.veri.dugumNumarasi)
                tempParent.sol = eklenecek;

            else
                tempParent.sag = eklenecek;
        }

        public IkiliAramaAgacDugumu Ara(string urunAdi)
        {
            return Arama(kok, urunAdi);
        }
        private IkiliAramaAgacDugumu Arama(IkiliAramaAgacDugumu dugum, string urunAdi)
        {
            int urunAnahtari = 0;
            for (int i = 0; i < urunAdi.Length; i++)
            {
                urunAnahtari += Convert.ToInt32(urunAdi[i]);
            }

            if (dugum == null)
                return null;
            else if ((int)dugum.veri.dugumNumarasi == urunAnahtari)
                return dugum;
            else if ((int)dugum.veri.dugumNumarasi > urunAnahtari)
                return (Arama(dugum.sol, urunAdi));
            else
                return (Arama(dugum.sag, urunAdi));
        }

        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(IkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(IkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }


        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(IkiliAramaAgacDugumu dugum)
        {
            int dugumSayisi = 0;

            foreach (Urun urun in dugum.urunler)
            {
                dugumSayisi++;
                dugumler += urun.urunAciklamasi + "   ";
            }
            dugumler += "// " + dugum.veri.adi + "  alt kategorisi -->  " + dugumSayisi + " düğüme sahiptir." + Environment.NewLine;
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }


    }
}
