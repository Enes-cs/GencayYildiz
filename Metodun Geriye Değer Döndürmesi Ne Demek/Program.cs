namespace Metodun_Geriye_Değer_Döndürmesi_Ne_Demek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Bir metodun geriye değer döndürmesi demek,içeride yapılan işlem neticesinde üretilen sonuçların ekrana yazılması demek değildir.

            Programatik olarak yakalanıp algoritmaın ikışında
            farklı yönlendirmelere sebebiyet verebilen değerdir. 

            Metodun geriye döndürdüğü değer algoritmanın akışında kullanılabilen
            değerdir.
             
             */



            //int carp = 10 * Topla(2, 2);

            Console.Write("Ad Soyad Giriniz: ");
            string adSoyad = Console.ReadLine();
            Console.Write("Yaş Giriniz: ");
            int yas =int.Parse(Console.ReadLine());
            Console.WriteLine(DbEkle(adSoyad, yas) ? "Veri Tabanına Eklendi" : "Veri Tabanına Eklenemedi");


        }

        static public int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine($"{sayi1} + {sayi2} = {sonuc}");
            return sonuc;
        }
        static public bool DbEkle(string AdSoyad, int yas)
        {
            bool sonuc;

            if (yas >= 20)
            {
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }

            return sonuc;
        }

    }
}
