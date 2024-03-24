namespace HataKontrolMekanizmaları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notlar();

            static void Notlar()
            {
                List<string> notlar = new List<string>{
            "**************Syntax Error(Söz Dizimi(Derleme) Hatası)**************",
            "Derlemeye göndermeden VS hataları direk sunar.",
            "Hatanın bulunduğu satır VS tarafından sunulur.",
            "Fark edilmesi en kolay hatalardır, çözülmesi de bi o kadar kolaydır.",
            "-------------------------------------------",
            "**************Run-Time Error /Çalışma Zamanı Hatası**************",
            "Kodun semantiğinde bir hata yoksa ve çalıştırınca hata veriyorsa bu Run-Time Errordur",
            "İşletim sistemi direk hatalı programı sonlandırır. ve bir mesaj ile bunu belirtir.",
            "Son kullanıcı karmaşık hata mesajları görmemeli",
            "Hataların önceden programcı tarafından tespit edilip anlaşılabilir şekilde düzenlenmesidir.",
            "Hataları ön görmek ve raporlamak testerların işidir.",
            "Tespit edilen runtime hataları manipüle edilmeli ki son kullanıcı bunu programın patlaması olarak değil programın bir mesajı olarak görmesi gerek.",
            "TRY-CATCH Hata Kontrol Mekanizmasının kendisidir",
            "Olmayan bir dosyayı açmaya çalışmak, olmayan bir değerle çalışmaya çalışmak, veritabanı bağlantısının kopması gibi durumlar.",
            };

                foreach (string s in notlar) { Console.WriteLine(s); }
            }

            //_Try_Catch_Yapılanmasi();

            static void _Try_Catch_Yapılanmasi()
            {
                //Örnek 1
                //TRY-CATCH YAPILANMASI
                //Çalışma zamanında alınması olası hataları manupüle etmemizi sağlayan yöntemdir.
                //Try-catch yapılanması uygulama sürecinde yaşanan olası hatayı kullanıcıya olağan bir mesaj gibi göstermemizi sağlayan
                //hataya dair log kayıtları oluşturmamızı sağlayan bir programatik yapılanmadır.

                //AMAÇ =>
                // 1. Kullanıcıya alınan hatayı hissettirmemek.
                // 2. Kullanıcıyı bilgilendirmek.
                // 3. Uygulamanın sona ermesini önlemek. (İşletim sistemleri aykırı durum yaşandığında uygulamayı sonlandırmak ister.)


                //PROTOTIP

                try
                {
                    //Olası Çalışma Zamanı Hatalarını verebilecek kodlar
                }
                catch (Exception)
                {
                    //Try içerisinde olası hata söz konusuysa kodun akışı orada kesilecek ve akış catch bloğundan devam edecektir.
                    //Eğer Try'da patlama olmaz ise catch bloğu çalışmayacak

                    throw;
                }

                //Örnek 1
                Console.Write("Sayı 1 = ");

                try
                {

                    int sayi1 = int.Parse(Console.ReadLine());
                    Console.Write("Sayı 2 = ");
                    int sayi2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("İlk Sayı İkinci Sayının %" + ((sayi1 * 100) / sayi2));
                    Console.WriteLine("İkinci Sayı İlk Sayının %" + ((sayi2 * 100) / sayi1));

                }
                catch
                {
                    Console.WriteLine("Lütfen Sayısal Bir İfade Giriniz!.");

                }

                //Try-Catch Maliyetlidir. Lüzumsuz yere oraya kod verilmemelidir.
            }

            //HataParametreleri();

            static void HataParametreleri()
            {
                //Hata Parametreleri
                //Çalışma zamanında alınan hataya dair bizlere bilgi veren parametrelerdir.

                //int s1=0, s2=10;
                //int sonuc = s2 / s1;
                //RunTime'da hata alındığında bunu editör üzerinde görüyoruz. Burada görülen hata türü: DivideByZeroException'dır

                //Alınan hatanın yapısına göre, türüne göre hata fırlatıalacaktır.

                //object x = null;
                //x.ToString();
                //Null reference exception hatası fırlatır

                //int.Parse("asdasdsda");
                //Format Exception hatası fırlatır


                try
                {
                    int s1 = 0, s2 = 10;
                    int sonuc = s2 / s1;
                }
                catch (Exception ex) //=> Exception bizlere fırlatılan hataların baseClass'ıdır.
                                     //Exception catch bloğuna parametre olarak yazılmak zorunda değildir ancak yazılırsa hataya dair bilgi verir.
                {
                    Console.WriteLine("Hata : " + ex.Message);
                }
            }

            //RunTimeHataTurleriVeCokluCatchBlogu();

            static void RunTimeHataTurleriVeCokluCatchBlogu()
            {
                //RunTime Hata Türleri
                /*
                 * EXCEPTION CLASS
                 * ArgumentException
                 * ArgumentNullException
                 * ArgumentOutOfRangeException
                 * FileNotFoundException
                 * FormatException
                 * IndexOutOfRangeException
                 * InvalidOperationException
                 * KeyNotFoundException
                 * NotSupportedException
                 * NullReferenceException
                 * OverflowException
                 * OutOfMemoryException
                 * StackOverflowException
                 * TimeoutException
                 */

                //Exception Dışında Farklı bir Tür ile Hata Yakalama
                try
                {
                    int s1 = 0, s2 = 10;
                    int sonuc = s2 / s1;
                    int.Parse("alşdjaskdljaskld");
                }
                catch (FormatException ex)  //Catch parametre tanımlanmazsa tüm hataları karşılar. Eğer bir parametre varsa ve bu parametrenin türü exception ise yine tüm hatalar karşılanır. Ancak parametre exception değil özelleştirilmiş bir hataya indirgenmiş ise böyle bir durumda sadece ilgili türe ait hataları yakalayabilecek, karşılayabilecektir.
                {
                    //Burada DivideByZero hatası verecektir biz ise onu yakalyamayız çünkü biz formatexception türünde hata yakala dedik
                    Console.WriteLine("Mesaj: " + ex.Message);

                }//Birden fazla cath bloğu ile parametreleri kontrol etmek çözüm olabilir.
                catch (DivideByZeroException div)
                {
                    Console.WriteLine("Mesaj: " + div.Message);
                }
                catch (Exception ex) //Özelleştirilmiş türler başa Exception sona yazılır
                {
                    Console.WriteLine("Mesaj: " + ex.Message);
                }


                //Finally Bloğu

                try
                {
                    //Hata Alabilecek Kodlar
                }
                catch (Exception)
                {

                    //Hata alındığında çalışacak kodlar
                }
                finally
                {
                    //hata alınsa da alınmasa da her iki durumda da tetiklenmesi gereken kodları yazdığımız bloktur.
                }


                //When Yapısı ile hata filtreleme
                string x = "a";
                try
                {
                    int s3 = 0, s4 = 10;
                    int sonuc = s3 / s4;

                }
                catch (DivideByZeroException ex) when (x == "a")
                {

                    Console.WriteLine("Mesaj: " + ex.Message);

                }
                catch (DivideByZeroException ex) when (x != "a")
                {

                    Console.WriteLine("Mesaj: " + ex.Message);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //MantıksalHatalar();

            static void MantıksalHatalar()
            {
                //Logical Error (Mantıksal Hatalar

                //Runtime ve Syntax hatası olmamasına rağmen yanlış varsa mantıksal hata vardır.
                //Test süreci ya da Müşteri kullanımında bulunaibliyorlar.
                //BUG Logical Error'dur.
                //Hata türleri arasında en tehlikeli olandır farkedilmez.
                //Bazen Tek Çözüm DeBug'dır.

                //Örnek 1
                //2 ile 5'in çarpımını hesapla.
                Console.WriteLine(2 * 6); //=> mantıksal hata oluştu.

                bool medeniHâl = true;
                Console.WriteLine(medeniHâl ? "Hediye sadece evlilere gönderilir." : "Evlilik Hediyesi Gönderildi."); //=> Yanlışlıkla bekara evlilik hediyesi gönderdik 
            }

        }
    }
}
