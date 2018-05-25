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

        public IkiliAramaAgaci()
        {

        }

        public IkiliAramaAgaci(IkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }

        public void AltKategoriEkle(AltKategoriler altKategori, ArrayList urunler)
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

            IkiliAramaAgacDugumu eklenecek = new IkiliAramaAgacDugumu(altKategori,urunler);
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



    }
}
