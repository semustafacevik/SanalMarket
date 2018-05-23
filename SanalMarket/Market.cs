using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class Market
    {
        ArrayList kategoriListesi = new ArrayList();

        public void AgacEkle(IkiliAramaAgaci yeniAgac)
        {
            kategoriListesi.Add(yeniAgac);
        }

    }
     
}
