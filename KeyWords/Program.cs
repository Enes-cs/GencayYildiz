using System;

namespace KeyWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Notlar
            //Compiler için derleyici tarafından önceden tanımlanmış anahtar kelimelerdir.
            //Keyword: Programlama dilinin en atomik parçalarıdır.
            //Nerelerde kullanılacağı sınırlıdır. örneğin fonksiyon içinde class tanımlanamaz.
            //Keywordlerin operatörlerle farkı şudur operatörler belirli bir eylemi üstlenir keyword daha geniş kavramdır.
            //operatörler esasında bir keyworddür ancak her keyword operatör değildir.
            #endregion

            /////////////////   Yardımcı Manevratik Komutlar    /////////////////

            //Yapamayacağımız şeyleri yapmayı sağlayan komutlar değil yapabileceğimiz komutları daha efektif yapmamızı sağlar.

            // break;
            // continue;
            // return;
            // goto;

            Break();

            static void Break()
            {
                /*
                 * Break;
                 * switch-case ve döngülerde kullanılabilir. + Foreach'de de kullanılabilir. Döngü içindeki if yapılanması içerisinde de kullanılır.
                 * Kullanıldığı yapıdan çıkış yapılmasını sonlandırmaya yarayan keyworddur. 
                 */
                return;
                while (true)
                {
                    Console.WriteLine(DateTime.Now);
                    if (DateTime.Now.Second == 43)
                    {
                        Console.WriteLine("Saniye 43 Döngüden Çık");
                        break;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        if (j == 1)
                            break;
                        Console.WriteLine(i + " ve " + j);
                    }

                }



                int toplam = 0;
                while (true)
                {
                    Console.Write("Toplanacak Sayı Gir Bitince t yaz: ");
                    string deger = Console.ReadLine();
                    if (deger == "t")
                    {
                        Console.WriteLine("Toplam: " + toplam);
                        break;
                    }
                    else
                    {
                        toplam += int.Parse(deger);
                    }
                }

                //kullanıcıdan sayı al uygulamayı 37 yazana kadar sürdür. yani 37 yazana kadar sayı almaya devam et

                while (true)
                {
                    Console.WriteLine("Lütfen Sayı Giriniz");
                    int girilen = int.Parse(Console.ReadLine());
                    if (girilen % 37 == 0)
                    {
                        Console.WriteLine("Afeerin");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("37'nin Katını Girersen Döngü Sonlanır, Girdiğin Sayı: " + girilen % 37);
                    }

                }

            }

            Continue();

            static void Continue()
            {
                //Continue KOmutu
                //Sade ve Sadece döngülerden erişilebilen ve döngülerde kullanılabilen keyworddur.
                //Amaç: döngüde bir sonraki tura geçilmesini sağlar. Bir sonraki periyoda geçiş yaptırır.
                return;
                // t-çift sayıları yazdır.
                for (int i = 0; i < 20; i++)
                {
                    if (i == 13) continue;
                    Console.WriteLine(i);
                }

                //Girilen sayılardan pozitif olanları çarpan t yazıldığında sonuç veren uygulama yaz.

                int sonuc = 1;
                while (true)
                {
                    Console.WriteLine("Sayı gir:");
                    string gir = Console.ReadLine();

                    if (gir != "s")
                    {
                        if (Convert.ToInt32(gir) < 0)
                            continue;

                        sonuc *= Convert.ToInt32(gir);
                    }
                    else
                    {
                        Console.WriteLine(sonuc);
                        break;

                    }
                }

                // 1 ile 1000 arasında 7 nin katı olmayan sayıları ekrana yazdırlaım

                for (int i = 1; i <= 1000; i++)
                {
                    if (i % 7 == 0)
                        continue;

                    Console.WriteLine(i);
                }

                return;
            }

            Return();

            static void Return()
            {
                //Return Komutu

                //Method içerisinde her yerde kullanılabilir.
                // 2 işlev görmektedir.
                // 1- Nerede çağrılırsa çağrılsın bulunulan methodu sonlandırır.
                // 2- Geriye Değer döndürme sorumluluğundadır.
                return;
                while (true)
                {
                    if (Console.ReadKey().KeyChar == 'c') //readkey entera basmadan okur
                    {
                        Console.WriteLine("Uygulama Bitti.");
                        return;
                    }
                    Console.WriteLine("Aktif");
                }
            }

            Goto();

            static void Goto()
            {
                return;

                //1'den 100'e kadar say

                int l = 1;
                c: l++;
                Console.WriteLine(l);
                if (l!=100) 
                goto c;

            k:
                for (int i = 0; i < 190; i++)
                {
                    Console.WriteLine(i);
                    goto k;
                }

                
                //goto
                /* Kodun senkronizasyonunu bozup akışı ters istikamete almamızı sağlar.
                 * Davranışsal olarak döngülere benzer.
                 * switch case yapılanmasında dahili olarak kullanılan bu komut method içerisinde her yerde kullanılabilir.
                 * Performans düşüren bir keyworddur. Maliyetlidir.
                 */
                int a = 3;
                switch (a)
                {
                    case 0:
                        Console.WriteLine("0");
                        break;
                    case 1:
                        Console.WriteLine("1");
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    default: goto case 0;
                }

            a:
                Console.WriteLine("Sonsuz Döngü kullanmak daha iyidir. Goto keywordu kullanmaktan kaçın");
                goto a;
            }

        


        }


    }
}
