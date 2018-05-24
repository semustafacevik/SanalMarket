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

        public HashMap()
        {
            hashTable = new HashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                hashTable[i] = null;
        }
        public void UrunEkleme(int urunAnahtari, Urun yeniUrun)
        {
            int hash = (urunAnahtari % TABLE_SIZE);
            while (hashTable[hash] != null && hashTable[hash].UrunKodu != urunAnahtari)
                hash = (hash + 1) % TABLE_SIZE;
            hashTable[hash] = new HashEntry(urunAnahtari, yeniUrun);
        }
        public Urun UrunBulma(int urunAnahtari)
        {
            int hash = (urunAnahtari % TABLE_SIZE);
            while (hashTable[hash] != null && hashTable[hash].UrunKodu != urunAnahtari)
                hash = (hash + 1) % TABLE_SIZE;
            if (hashTable[hash] == null)
                return null;
            else
                return (Urun)hashTable[hash].UrunBilgileri;
        }
    }
}
