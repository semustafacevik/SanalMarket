using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class IkiliAramaAgacDugumu
    {
        public AltKategoriler veri;
        public Heap urunler;
        public IkiliAramaAgacDugumu sol;
        public IkiliAramaAgacDugumu sag;


        public IkiliAramaAgacDugumu()
        {
        }

        public IkiliAramaAgacDugumu(AltKategoriler altkategori, Heap urun)
        {
            veri = altkategori;
            urunler = urun;
            sol = null;
            sag = null;
        }
    }
}
