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

        public IkiliAramaAgaci()
        {

        }

        public IkiliAramaAgaci(IkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }

        public void Ekle(int deger)
        {
            //Yeni eklenecek düğümün parent'ı
            IkiliAramaAgacDugumu tempParent = new IkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            IkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (deger == (int)tempSearch.veri)
                    return;
                else if (deger < (int)tempSearch.veri)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            IkiliAramaAgacDugumu eklenecek = new IkiliAramaAgacDugumu(deger);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (deger < (int)tempParent.veri)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }

    }
}
