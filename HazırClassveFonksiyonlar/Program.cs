using System.Collections;
using System.Text.RegularExpressions;

namespace HazırClassveFonksiyonlar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region MathSınıfı
            #region Abs (Absolute Value - Mutlak Değer İşlemi Yapar)
            Console.WriteLine($" -7 'nin Mutlak Değeri = {Math.Abs(-7)}");
            #endregion
            #region Ceiling (Yukarı Yuvarlama işlemi yapar)
            Console.WriteLine($"Yukarı Yuvarla 3.14'ü = {Math.Ceiling(3.14)}"); //Yukarı Yuvarlar
            #endregion
            #region Floor (Aşağı Yuvarlama işlemi yapar)
            Console.WriteLine($"Aşağı Yuvarla 3.14'ü = {Math.Floor(3.14)}");
            #endregion
            #region Round (Tam Sayıya Yakınlığa göre Yuvarlama İşlemi Yapar)
            //.5 Yukarı yuvarlanır.
            Console.WriteLine($"Yuvarla 3.5'i = {Math.Round(3.5)}");
            Console.WriteLine($"Yuvarla 3.6'yı = {Math.Round(3.6)}");
            Console.WriteLine($"Yuvarla 3.4'ü = {Math.Round(3.4)}");
            #endregion
            #region Pow (Kuvvet)
            Console.WriteLine($"2 üssü 8 = {Math.Pow(2, 8)}"); //y kuvvet, x taban
            #endregion
            #region Sqrt (Karekök)
            Console.WriteLine($"64 ün karekökü = {Math.Sqrt(64)}");
            #endregion
            #region Truncate (Yuvarlama yapmadan tamsayıyı alır.)
            Console.WriteLine($"Tamsayısını al 3.14'ün = {Math.Truncate(3.14)}");
            #endregion
            #endregion

            #region DateTime Struct'ı
            #region Now (şuan)
            Console.WriteLine(DateTime.Now);
            #endregion
            #region Today (Now'dan farkı saat getirmez.)
            Console.WriteLine(DateTime.Today);
            #endregion
            #region Compare (ilk tarih ikinci tarih arasında fark eşitse 0, küçükse -1, büyükse 1 değeri verir)
            DateTime dogum = new DateTime(1995, 11, 14);
            DateTime tarih = new DateTime(1996, 11, 14);
            Console.WriteLine(DateTime.Compare(dogum, tarih));

            #endregion

            //Şu kadar zaman eklersek ne olur?
            #region AddDays
            Console.WriteLine($"5 Gün Sonra Tarih: {DateTime.Now.AddDays(5)}"); //5 Gün Sonra
            #endregion
            #region AddHours
            Console.WriteLine($"5 Saat Sonra Tarih: {DateTime.Now.AddHours(5)}"); //5 Saat Sonra
            #endregion
            #region AddMonths
            Console.WriteLine($"5 Ay Sonra Tarih: {DateTime.Now.AddMonths(5)}");

            #endregion
            #region AddYears
            Console.WriteLine($"5 Yıl Sonra Tarih: {DateTime.Now.AddYears(5)}");
            #endregion
            #region AddMilliseconds
            Console.WriteLine($"95 Milisaniye Sonra Tarih: {DateTime.Now.AddMilliseconds(5)}");
            #endregion
            #endregion

            #region TimeSpan Struct'ı (İki DateTime arasındaki farkı karşılayan tür)

            DateTime t1 = DateTime.Now;
            DateTime t2 = new DateTime(2000,1,1);
            TimeSpan sonuc = t1 - t2;
            Console.WriteLine($"{t1} ve {t2} arasında {sonuc.Days} gün var");
            Console.WriteLine($"{t1} ve {t2} arasında {sonuc.Minutes} dakika var");
            #endregion

            #region Random Sınıfı

            Random rastgele = new Random();

            #region Next Fonksiyonu
            //Max değer hiç bir zaman heseba katılmaz.
            Console.WriteLine(rastgele.Next());//0'dan büyük int değer aralığında bir değer üretir.
            Console.WriteLine(rastgele.Next(100)); //0 ile 100 aralığında bir değer üretir. 0 olur ama 100 olamaz.
            Console.WriteLine(rastgele.Next(50,100)); //50 ile 100 aralığında bir değer üretir. 50 olur ama 100 olamaz.
            #endregion
            #region NextDouble Fonksiyonu
            //0 ile 1 arasında bir değer üretir.
            double val = rastgele.NextDouble();
            Console.WriteLine(val);
            Console.WriteLine(Math.Round(val));
            #endregion
            #region Next ve Count Fonksiyonu ile Kura

            ArrayList a = new ArrayList { "Ahmet", "Mehmet", "Mustafa", "Süleyman", "İlker" };
            int kura = rastgele.Next(a.Count);
            Console.WriteLine($"Kazanan Kişi: {a[kura]}");

            #endregion
            #endregion
        }
    }
}
