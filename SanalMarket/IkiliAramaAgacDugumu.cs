using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class IkiliAramaAgacDugumu
    {
        public string dugumAdi;
        public AltKategoriler veri;
        public ArrayList urunler;
        public IkiliAramaAgacDugumu sol;
        public IkiliAramaAgacDugumu sag;


        public IkiliAramaAgacDugumu()
        {
        }

        public IkiliAramaAgacDugumu(AltKategoriler altkategori, ArrayList urun)
        {
            veri = altkategori;
            urunler = urun;
            sol = null;
            sag = null;
        }
    }
}
