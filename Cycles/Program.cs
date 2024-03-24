using System.Numerics;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Döngüler Nedir?

            /*
             * For
             * While                Hangi Döngü Daha Çok Yakışır.
             * Do While
             */


            //ForLoop();

            static void ForLoop()
            {
                //FOR  => Genellikle ardışık işlemlerde kullanılır.

                for (int i = 0; i < 10; i += 1)
                //  Tanımlama; Şart ; aritmatik
                {
                    Console.WriteLine("Enes ÖZBAY");
                    //Şart Sağlandıkça Bu blok tetiklenecektir.
                }

                //Hilmi Değerini 10 kere ekrana yazdır.
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hilmi");
                }
                //1den 10'a kadar olan sayıları alt alta yazdır.

                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                }

                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(i);
                }
                //Karmaşık kod profesyonellik değil amatörlüktür.
                for (int i = 50; i < 60; i++)
                {
                    Console.WriteLine(i - 49);
                }
                //1 ile 40 (Dahil) arasındaki çift sayıları toplayarak sonucu yazdıralım.
                int sonuc = 0;
                for (int i = 1; i <= 40; i++)
                {
                    if (i % 2 == 0)
                    {
                        sonuc += i;
                        if (i == 40)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(i + "+");
                        }
                    }

                }
                Console.WriteLine("=" + sonuc);

                //Klavyeden girilen sayının faktöriyelini hesapla
                int sayi = int.Parse(Console.ReadLine());
                int faktoriyel = 1;
                string say = default;


                for (int i = sayi; i > 0; i--)
                {
                    faktoriyel *= i;
                    say += (i == 1 ? i + " = " : i + " X ");
                }
                Console.WriteLine(sayi + "! = " + say + faktoriyel);
            }

            //ForVaryasyonları();

            static void ForVaryasyonları()
            {

                for (int i = 0; i < 10; i++)
                {

                }
                ////////////////////////////////

                int a = 0;
                for (; a < 10; a++)
                {

                }
                ////////////////////////////////

                int b = 0;
                for (b = 0; b < 10; b++) //=> tekrar içeride tanımlanırsa değer verilmeli
                {

                }
                ////////////////////////////////

                int c = 0;
                for (; c < 10;)
                {
                    c++;
                }
                //////////////////////////////////

                int say = 10;
                for (int i = 0; say != i * 2; i++)
                {
                    Console.WriteLine("Enes");
                }
                /////////////////////////////////

                for (; ; ) //Sonsuz
                {
                    Console.WriteLine("Enes");
                }
                ////////////////////////////////

                for (int i = 0; ; i++)
                {
                    Console.WriteLine("Sonsuz Döngü");
                }
                ///////////////////////////////

                for (int i = 0, i2 = 0; i < 10 && i2 < 10; i++, i2++)
                {

                }

            }

            //////////////////////////////////////////////////////////////////////

            //WhileLoop();

            static async void WhileLoop()
            {
                //while (true/*ŞART*/)
                //{
                /*ŞART DOĞRULANDIKÇA BURASI TETİKLENİR*/
                //}

                //Programlanma Dillerinde ilk tasarlanan döngüdür.
                //Genellikle sonsuz döngülerde ya da süreci bilinmeyen durumlarda kullanılan bir döngüdür. Amma velakin istenilen yerde kullanılabilir.

                //While ile For Kıyası
                //While döngüsünde kombinasyonu kendimiz oluşturuyoruz.

                //WhileAsal();

                static void WhileAsal()
                {
                    int gir = int.Parse(Console.ReadLine());
                    int asal = 2;
                    bool asalMi = true;
                    while (asal <= Math.Sqrt(gir))
                    {
                        if (gir % asal == 0)
                        {
                            asalMi = false;
                            break;
                        }

                        asal++;

                    }
                    Console.WriteLine(asalMi ? "Asal" : "Asal Değil");
                }

                //IstenilenSayıKadarYazdır();

                //sıfırYuzArasıTekToplam();

                //GirilenSayıyıSıfıraKadarGöster();

                //FaktoriyelHesapla();

                static void sıfırYuzArasıTekToplam()
                {
                    int yuz = 99, toplam = 0;
                    while (yuz > 0)
                    {

                        toplam += yuz;
                        yuz -= 2;
                    }
                    Console.WriteLine("Toplam: " + toplam);
                }

                static void GirilenSayıyıSıfıraKadarGöster()
                {
                    int girilenSayı = int.Parse(Console.ReadLine());

                    while (girilenSayı >= 0)
                    {
                        Console.WriteLine(girilenSayı);
                        girilenSayı--;
                    }
                }

                static void IstenilenSayıKadarYazdır()
                {
                    int _i = 5;

                    while (_i < 10)
                    {
                        _i++;
                        Console.WriteLine("Enes");
                    }

                    int merhaba = 1;
                    while (merhaba <= 10)
                    {
                        Console.WriteLine("Hello World");
                        merhaba++;
                    }
                }

                static void FaktoriyelHesapla()
                {

                    BigInteger sayi = BigInteger.Parse(Console.ReadLine());
                    BigInteger sonuc = BigInteger.Pow(2, 256) - 1;
                    sonuc = 1;
                    try
                    {
                        while (sayi > 0)
                        {
                            Console.Write(sayi == 1 ? sayi + " = " : sayi + " X ");
                            sonuc *= sayi--;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata Alındı: " + ex.Message);
                    }
                    Console.WriteLine(sonuc);
                }



                while (true)
                {
                    if ((DateTime.Now.Second % 5 == 0))
                    {
                        Console.WriteLine(" => Tarih: " + DateTime.Now);
                    }
                }

            }

            //////////////////////////////////////////////////////////////////

            //DoWhileDongusu();

            static void DoWhileDongusu()
            {
                // DO - WHİLE DÖNGÜSÜ

                //While Şarta bakar sonra kodu çalıştırır.
                //Do-While önce kodu çalıştırır sonra şarta bakar.
                //While ile yapılan kontrolde şart false olursa hiç tetiklenmez.
                //Do-While şart false da olsa 1 kere tetiklenir.

                while (false)
                {
                    Console.WriteLine("While Döngüsü");
                }

                do
                {
                    Console.WriteLine("Do while döngüsü");
                } while (false);
            }

            //////////////////////////////////////////////////////////////////

            ScopesuzDonguler();

            static void ScopesuzDonguler()
            {
                for (int i = 0; i < 10; i++)
                    Console.WriteLine("Gençay Yıldız");


                while (true)
                    Console.WriteLine("Gençay Yıldız");


                do Console.WriteLine("Gençay Yıldız");
                while (false);
            }

            //////////////////////////////////////////////////////////////////

            SonsuzDongu();

            static void SonsuzDongu()
            {
                //Sonsuz Döngü - For
                bool dongu = true;
                for (; dongu;)  //integer sınırlarını aşınca patlar bu yüzden siliyoruz.
                {
                    if (true) //Sonsuz döngüden çıkmak için içeride bir şarta bağlıyoruz.
                    {
                        dongu = !dongu;
                    }

                }

                //Sonsuz Döngü - While

                while (dongu)  //bu döngü açılışta sonsuzdur :)
                {


                    if (true)
                    {
                        //Sonsuzdan çıkmak için bir şata bağlıyoruz.
                        dongu = !dongu;
                    }
                }

                //Sonsuz Döngü - Do While

                bool durum = true;

                do
                {
                    if (true)
                    {
                        durum = !durum;
                    }

                } while (durum);
            }

            //////////////////////////////////////////////////////////////////

            IcIceDongu();

            static void IcIceDongu()
            {
                for (int i = 0; i < 10; i++) //Maliyeti 10
                {
                    for (int j = 0; j < 5; j++) //Maliyeti 5      =>Toplam Maliyet 150
                    {
                        for (int k = 0; k < 3; k++) //Maliyeti 3
                        {
                            int p = 0;
                            while (p < 4)         //Maliyeti 4   => Artık Maliyet 600
                            {
                                p++;
                            }
                        }
                    }
                }
            }

            /////////////////////////////////////////////////////////////////

            /*
             * foreach bir döngü değildir!!!! Bir iterasyondur.
             * Döngü bir şarta bağlı kombinasyon eşliğinde periyodik işlemler yapar.
             * İterasyon bir şarta bağlı değildir. İtere edebileceği bir sonraki veriyi getirebileceği yapılardır.
             * */

            //Döngülerde boş scope yerine noktalı virgül operatörü ile temiz kod yazımı

            //amaç sadece sonsuz döngüye girmek ise asenkron programlamada ihtiyaç olacaktır.
            while(true);
            for (;;);
            do;
            while(true);

        }
    }
}
