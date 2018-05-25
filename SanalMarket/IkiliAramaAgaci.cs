using System;
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

        public void AltKategoriEkle(AltKategoriler altKategori, Heap urunler)
        {
            //Yeni eklenecek düğümün parent'ı
            IkiliAramaAgacDugumu tempParent = new IkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            IkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (altKategori.urunSayisi == tempSearch.veri.urunSayisi)
                    return;
                else if (altKategori.urunSayisi < tempSearch.veri.urunSayisi)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }

            IkiliAramaAgacDugumu eklenecek = new IkiliAramaAgacDugumu(altKategori,urunler);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;

            else if (altKategori.urunSayisi < tempParent.veri.urunSayisi)
                tempParent.sol = eklenecek;

            else
                tempParent.sag = eklenecek;
        }

        public IkiliAramaAgacDugumu Ara(int anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private IkiliAramaAgacDugumu AraInt(IkiliAramaAgacDugumu dugum,int anahtar)
        {
            if (dugum == null)
                return null;
            else if ((int)dugum.veri.dugumNo == anahtar)
                return dugum;
            else if ((int)dugum.veri.dugumNo > anahtar)
                return (AraInt(dugum.sol, anahtar));
            else
                return (AraInt(dugum.sag, anahtar));
        }



    }
}
