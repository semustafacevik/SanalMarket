using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class HashEntry
    {
        private int tablodakiUrunkodu;

        private Urun tablodakiUrun;

        public Urun UrunBilgileri
        {
            get { return tablodakiUrun; }
            set { tablodakiUrun = value; }
        }
        public int UrunKodu
        {
            get { return tablodakiUrunkodu; }
            set { tablodakiUrunkodu = value; }
        }
        public HashEntry(int anahtar, Urun deger)
        {
            this.UrunKodu = anahtar;
            this.UrunBilgileri = deger;
        }

    }
}
