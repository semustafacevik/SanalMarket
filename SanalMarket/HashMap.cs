using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class HashMap
    {
        int TABLE_SIZE = 50;
        HashEntry[] hashTable;
        public bool bulunduMu;

        public HashMap()
        {
            hashTable = new HashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                hashTable[i] = null;
        }
        public void UrunEkleme(string urunAdi, Urun yeniUrun)
        {
            int urunAnahtari = 0;
            for (int i = 0; i < urunAdi.Length; i++)
            {
                urunAnahtari += Convert.ToInt32(urunAdi[i]);
            }

            int hash = (urunAnahtari % TABLE_SIZE);
            while (hashTable[hash] != null && hashTable[hash].UrunKodu != urunAnahtari)
                hash = (hash + 1) % TABLE_SIZE;
            hashTable[hash] = new HashEntry(urunAnahtari, yeniUrun);
        }
        public Urun UrunBulma(string urunAdi)
        {
            int urunAnahtari = 0;
            for (int i = 0; i < urunAdi.Length; i++)
            {
                urunAnahtari += Convert.ToInt32(urunAdi[i]);
            }

            int hash = (urunAnahtari % TABLE_SIZE);
            while (hashTable[hash] != null && hashTable[hash].UrunKodu != urunAnahtari)
                hash = (hash + 1) % TABLE_SIZE;
            if (hashTable[hash] == null)
                return null;
            else
            {
                bulunduMu = true;
                return (Urun)hashTable[hash].UrunBilgileri;
                
            }
        }

        public void UrunSilme(string urunAdi)
        {
            // Urun bulunan = UrunBulma(urunAdi);

            int urunAnahtari = 0;
            for (int i = 0; i < urunAdi.Length; i++)
            {
                urunAnahtari += Convert.ToInt32(urunAdi[i]);
            }

            int hash = (urunAnahtari % TABLE_SIZE);
            while (hashTable[hash] != null && hashTable[hash].UrunKodu != urunAnahtari)
                hash = (hash + 1) % TABLE_SIZE;

            hashTable[hash] = null;
        }



        // hashTable[10].
    }
}

