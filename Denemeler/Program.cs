using System.Security.Cryptography;

namespace Denemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //IlkUygulamam();

            //int[] deneme = new int[101];

            //for (int i = 55; i <= 100; i++)
            //{
            //    deneme[i] = i;
            //    Console.WriteLine(deneme[i]);
            //    deneme[i] = i;
            //    Console.WriteLine(deneme[i]);
            //    break;
            //}
            //switch (deneme[55])
            //{
            //    case 43:
            //        Console.WriteLine("Çalıştı");
            //        break;
            //    default:
            //        break;
            //    case 55:
            //    case 45:
            //        goto case 43;
            //}

            //for (int i = 0; i < 10; i++) { SwitchCaseWhenExpressionAsal(i); }

            //Math sınıfı matematik işlemleri yaptırır.

            //int number1 = 2;
            //int number2 = 2;
            //var son = Math.Pow(number1, number2) + Math.Pow(number1, number2);
            //var trigo=Math.Log10((double)10);
            //Console.WriteLine(trigo);
            double birdenOnaKupToplam = 0;
            for (int i = 0; i < 11; i++)
            {
                birdenOnaKupToplam+=Math.Pow(i, 3);
            }

            static void IlkUygulamam()
            {
                Console.WriteLine("1- Asal Sayı Hesaplama");
                Console.WriteLine("2- Uyduruktan Tavsiyeler");
                Console.WriteLine("1 yada 2 yaz ve Enter'a bas");
                int select = int.Parse(Console.ReadLine());


                if (select == 1)
                {
                    Console.WriteLine("10 Tane Sayı Sorgulama Hakkın var");
                    for (int i = 0; i <= 10; i++)
                    {
                        Asal();
                    }

                    Console.ReadLine();
                }

                else if (select == 2)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        Tavsiye();
                    }
                }
                else
                {
                    Console.WriteLine("Sana seçenek sunduk değil mi? Şansını kaybettin.");
                }


                Console.ReadLine();
                static void Asal()
                {
                    Console.WriteLine("Bir Sayı Girin");
                    int sayi = int.Parse(Console.ReadLine());
                    bool asal = true;

                    for (int i = 2; i <= sayi - 1; i++)
                    {
                        if (sayi % i == 0)
                        {
                            asal = false;
                            break;
                        }
                        else
                        {
                            asal = true;
                        }
                    }
                    Console.WriteLine(asal ? sayi + " Sayısı ASALDIR" : sayi + " SAYISI ASAL FALAN DEĞİL DELİRME!");
                }
                static void Tavsiye()
                {
                    Console.WriteLine("Tavsiye İstersen 1,2 ya da 3 Yaz");
                    int yorum = int.Parse(Console.ReadLine());

                    Console.WriteLine(yorum == 1 ? "Bugün 8 Saat Çalış" : (yorum == 2 ? "Bugün 6 Saat Çalış" : (yorum == 3 ? "Bugün 7 Saat Çalış" : "Geçerli Bir Sayı Gir Dostum")));
                }
            }

            static void SwitchCaseWhenExpressionAsal(int sayi)
            {
                bool sonuc = false;
                int sayı = int.Parse(Console.ReadLine());

                for (int i = 2; i < sayı; i++)
                {
                    sonuc = sayı switch
                    {
                        var x when sayı % i == 0 => false,
                        var x when sayı % i != 0 => true
                    };
                }
                Console.WriteLine(sonuc == false ? sayı + " Sayısı Asaldır." : sayı + " Sayısı Asal Değildir.");
                Console.ReadLine();

               
            }
            
            int s = 0; 
            while (s<10)
            {
                Console.WriteLine("Enes");
                s++;
            }
        }
    }
}
