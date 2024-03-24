using System.Collections;
using System.Globalization;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            /*
             * İlk oluşturulan koleksiyondur.
             * 
             * 
             * 
             */

            #region ArrayList Koleksiyonu Tanımlama

            //Diziler tanımlanırken kaç eleman tutacakları belirtilmek zorundadır.
            //ArrayListte bu sınırlılık yoktur.

            int[] yaslar = new int[17];

            ArrayList _yaslar = new ArrayList();

            #endregion

            #region Tanımlanmış Koleksiyona Değer Atama

            yaslar[3] = 1;  //sırayı yazmak zorundasın
            _yaslar.Add(13); //sırayla yerleştirir

            for (int i = 0; i < 17; i++)
            {
                yaslar[i] = i + 10;  //sırayı yazmak zorundasın
                _yaslar.Add(i + 10);
            }

            #endregion

            #region Tanımlanmış Koleksiyondan Değer Okuma

            for (int i = 0; i < yaslar.Length; i++)
            {
                Console.WriteLine($"Dizi= {yaslar[i]}");
                Console.WriteLine($"Koleksiyon= {_yaslar[i]}");
            }

            #endregion

            #region ArrayList Kullanırken Boxing-Unboxing

            //ArrayList object türünde veri alır. Veriler üzerinde işlem yapmak için unboxing işlemi yapılmak zorundadır.
            int toplam = 0;
            for (int i = 0; i < _yaslar.Count; i++) //Length => Dizilerde , Count => Koleksiyonlar
            {
                if (_yaslar[i] is int)
                {
                    toplam += (int)_yaslar[i];
                }
                
            }
            Console.WriteLine($"Toplam: {toplam}");

            #endregion

            #region ArrayList Koleksiyonunun Sınırlılıkları ve Diğer Koleksiyon Yapılarının Çıkış Nedenleri
            //ArrayList object türünde veri alır. Veriler üzerinde işlem yapmak için unboxing işlemi yapılmak zorundadır.
            #endregion

            #region ArrayList Collection Initializers (Koleksiyon İlklendirici) ile Değer Ekleme

            ArrayList arrayList = new ArrayList()
            {
                "Ahmet", "Enes", 23, '2', 32.4, true, true, true, true, true, false, true, true, true, true,
            };   

            #endregion

            #region Örnek

            #endregion
            #endregion

        }
    }
}
