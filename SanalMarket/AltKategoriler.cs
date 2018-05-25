using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class AltKategoriler
    {
        public string adi;
        public int dugumNumarasi;

        public int AgacSiralamasiIcinNo(string urunAdi)
        {
            int urunAnahtari = 0;
            for (int i = 0; i < urunAdi.Length; i++)
            {
                urunAnahtari += Convert.ToInt32(urunAdi[i]);
            }

            return urunAnahtari;
        }
    }
}
