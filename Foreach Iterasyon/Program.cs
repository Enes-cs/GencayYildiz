using System.Collections;

namespace Foreach_Iterasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Iterasyon

            // Matematikte ve Dilbiliminde görülür.
            // itere etmek: Devamını getirmek sürekliliği sağlamak.

            // Mantıksal açıdan her tahminin altında bir iterasyon mantığı yatar.
            // 1 3 5 verilince 7 nin akla gelmesi.
            //içerisinde tekrar eden kelimeler var ise onlar iterasyonel kelimelerdir.
            //örneğin baba - mermer.  

            #endregion

            #region Iterasyon ve Döngü Arasındaki Fark

            // Foreach (İterasyon) Bir Döngü Değildir.

            int[] sayilar = { 3, 213, 423, 42, 34, 234, 324, 564 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i}. Index = {sayilar[i]}");
            }
            #endregion

            #region Foreach Iterasyonu

            ArrayList sayilar2 = new ArrayList { 123, 623, 325, 2, 534, 5, 365, 452, "Enes" };

            foreach (object item in sayilar2)
            {
                //Veri kümseindeki eleman sayısı değişecekse döngü kullanılmalı.
                Console.Write($"{item}, ");
            }

            #endregion
        }
    }
}
