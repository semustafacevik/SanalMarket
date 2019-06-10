# SanalMarket
*Bu SanalMarket adlı uygulama Data Structures (Veri Yapıları) dersi için binary search tree (ikili arama ağacı), heap ve hash data structers (hash veri yapıları) kulanılarak geliştirilmiştir.*

### AÇIKLAMA
#### Gerçekleştirilen Platform
Microsoft Visual Studio Community 2017 - Version 15.7.1 - C#
#### Projenin Tanımı
Gerçekleştirilen bir sanal market kapsamında ürün bilgilerinin kategori ağacında tutulması, verilerin hazırlanması, market personelinin kullanacağı modülün hazırlanması ve gelen bir müşterinin kullanacağı modülün geliştirildiği proje.
#### Veri Yapısı Kataloğu
#### Kullanılan Veri Yapıları
<ul>
  <li>İkili arama ağacı</li>
  <li>Heap</li>
  <li>Hash</li>
</ul>

#### Sınıflar ve Metotlar
<ul>
  <li>AltKategoriler.cs</li>
  <ul>
    <li>AgacSiralamasiIcinNo() : Ağaçta ilgili sıraya koymak için numara üretme.</li>
  </ul>
  <li>HashEntry.cs</li>
  <li>HashMap.cs</li>
  <ul>
    <li>UrunEkleme() : Hash tablosunun uygun yerine ürün ekleme.</li>
    <li>UrunBulma() : Hash tablosundan aranan ürünü bulma.</li>
    <li>UrunSilme() : Hash tablosunun uygun yerinden ürün silme.</li>
  </ul>
  <li>Heap.cs</li>
  <ul>
    <li>Insert():</li>
    <li>RemoveMin():</li>
  </ul>
  <li>HeapDugumu.cs</li>
  <li>IkiliAramaAgaci.cs</li>
  <ul>
    <li>AltKategoriEkle(): Ağacın ilgili düğümüne alt kategori ekleme.</li>
    <li>Arama(): Ağaçtan ilgili veriyi arama.</li>
  </ul>
  <li>IkiliAramaAgacDugumu.cs</li>
  <li>Market.cs</li>
  <ul>
    <li>AgacEkle(): Kategori ağacı ekleme.</li>
  </ul>
  <li>Urun.cs</li>
