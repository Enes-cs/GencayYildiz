using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace AkışKontrolMekanizmaları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Notlar
            /* Akış kontrol mekanizmaları kodun akış sürecinde belirli şarta göre yönlendirilmesini sağlar.
             * if-else
             * switch
             * if else ve switch case aynı işi farklı şekilde yapmamızı sağlayan farklı yapılanmalardır.
             * Kullanım açısından fark yoktur.
             * 
             */

            #endregion

            #region Switch Case
            #region Notlar


            //Kodun akışında belirli bir şarta göre yönlendirme yapmamızı (farklı operasyon, farklı algoritma gerçekleştirmemizi tetiklememizi sağlar.
            //Sadece eşitlik durumuna göre kullanılır. >,< gibi operatörler kullanacaksan if kullanman gerek.
            // Switch-case yapılanmasında kontrol edilen değer ile eşitlik sağlayan case varsa diğer caselere bakılmaksızın bloktan çıkılacaktır.            

            //switch (Eşitlik durumu kontrol edilecek olan değer buraya yazılır.)
            //{                                                 
            //    case value1:    // case value bittikten sonra : kullanılır.

            //        break;      //case ile break arasına yazılan kodlar ilgili case'in doğrulanmasını sürecinde işlenecek kodlardır.
            //                        
            //    case value2:

            //        break;
            // 
            //          default:
            //                      //hiçbircase eşitlik durumunu sağlamıyorsa default break arasındaki kod çalışacaktır.
            //                                      Zorunlu değildir.
            //          break;
            #endregion
            #region Sadece Switch Case
            string adi = "Süleyman";
            switch (adi) //Kontrol edilen değerin türü ne ise case bloklarında da aynı tür olmalı.
            {                           //switch parantezinde bir değişken,sabit,statik olabilirken
                case "Ahmet":           //case bloklarındaki değerler statik olmak zorundadır. değişkenlerden alınamaz
                    Console.WriteLine("Adı Ahmet");
                    break;

                case "Mehmet":      //Değişken olamaz
                    Console.WriteLine("Adı Mehmet");
                    break;

                case "Ayşe":        //Değişken olamaz
                    Console.WriteLine("Adı Ayşe");
                    break;
                //caselerin sıralaması önemli değildir. default'u istersen en başa koy farketmez
                default:   //case bloklarından hiçbiri eşleştirmeye uymuyorsa eğer var ise default bloğu tetiklenir.
                    Console.WriteLine("Bulamadık");
                    break;
            }

            //Kontrol esnasında farklı şartları da değerlendirmek istiyorsak when keyword'ü kullanılır.

            #endregion
            #region When Keywordü
            switch (adi)
            {
                case "Süleyman" when (3 == 5):
                    Console.WriteLine("Adı Süleymna");
                    break;
                case "Süleyman" when (5 < 4):            //Bool sonuç döndürmek zorunda.
                    Console.WriteLine("Adı Süleyman");
                    break;
                case "Süleyman" when (4 < 5):
                    Console.WriteLine("Adı Sülüman");
                    break;

            }
            #endregion
            #region goto keywordü
            // Sadece eşitlik durumu incelendiği için mantıksal işlem gerçekleştirilememektedir.
            //Bazen farklı değerlere eşit olma durumunda aynı operasyonu kullanacağımız senaryolarla karşılaşabiliriz.

            /* switch(value)
              {
                case "a":
                    A işlemini uygula
                        break;
                case "b":
                    B işlemini uygula
                        break;
                case "c":
                    A işlemini uygula           Bunu demek yerine goto keywordü ile direk case "a": 'yı uygula diyebiliyoruz.
                        break;                  Yani caseler arasında zıplayabiliyoruz.
               }
            */

            int i = 10;
            switch (i)
            {
                case 5:
                    Console.WriteLine(i * 10);
                    break;
                case 6:
                    Console.WriteLine(i / 5);
                    break;
                case 7:
                    goto case 5;              //Console.WriteLine(i * 10);     //go to kullanacağız, break zaten case 5'in içinde olduğu için sildik.
                case 10:
                    goto case 5;              //Console.WriteLine(i * 10);     //go to kullanacağız, break zaten case 5'in içinde olduğu için sildik.
                                              // goto kullanıldığında case'in değerine bakmaksızın içindeki kodu çalıştırır
            }

            switch (i)
            {
                case 5:
                    Console.WriteLine(i * 10);
                    break;
                case 6:
                    Console.WriteLine(i / 5);
                    break;
                case 7:                     //Birden fazla aynı case'e yönlendirme var ise bu şekilde kullanılır.
                case 10:
                    goto case 5;

            }




            #endregion
            #region Switch Expressions


            //Bunun Yerine
            string mesaj = "Ne yazarsan yaz";
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    mesaj = "Bu gün Pazar";
                    break;
                case DayOfWeek.Monday:
                    mesaj = "Bu gün Pazartesi";
                    break;
                case DayOfWeek.Tuesday:
                    mesaj = "Bu gün Salı";
                    break;
                case DayOfWeek.Wednesday:
                    mesaj = "Bu gün Çarşamba";
                    break;
                case DayOfWeek.Thursday:
                    mesaj = "Bu gün Perşembe";
                    break;
                case DayOfWeek.Friday:
                    mesaj = "Bu gün Cuma";
                    break;
                case DayOfWeek.Saturday:
                    mesaj = "Bu gün Cumartesi";
                    break;
            }
            Console.WriteLine(mesaj);

            //Bu kullanılabilir.
            string mesaj2 = DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Monday => "Bu gün Pazartesi",
                DayOfWeek.Tuesday => "Bu gün Salı",
                DayOfWeek.Wednesday => "Bu gün Çarşamba",
                DayOfWeek.Thursday => "Bu gün Perşembe",
                DayOfWeek.Friday => "Bu gün Cuma",
                DayOfWeek.Saturday => "Bu gün Cumartesi",
                DayOfWeek.Sunday => "Bu gün Pazar"
            };
            Console.WriteLine(mesaj2);

            string isim = "";
            int @int = 10;
            switch (@int)
            {
                case 5:
                    isim = "Hilmi";
                    break;
                case 7:
                    isim = "Rıfkı";
                    break;
                case 10:
                    isim = "Gencay";
                    break;
                default:
                    break;


            }
            Console.WriteLine(isim);
            string ad = @int switch
            {
                5 => "Hilmi",
                7 => "Rıfkı",
                10 => "Enes",
            };
            Console.WriteLine(ad);

            //Switch When Expression
            Console.WriteLine(isim);
            string ad2 = @int switch
            {
                5 when 3 == 3 => "Hilmi",
                var ax when ax == 7 && ax % 2 == 1 => "Rıfkı", //Mantıksal operatörler de kullanılabiliyor. var ya da i yi karşılabiliyen bir tür de tanımlanabilir.
                10 => "Enes",
                var ax => "Hiçbiri" //default değer tanımlaması
            };
            Console.WriteLine(ad2);
            #endregion
            #region Tupple Patterns

            int s1 = 10;
            int s2 = 20;
            string mesaj3 = "";
            switch (s1, s2)
            {
                case (5, 10):
                    mesaj3 = "5 ile 10 Değerleri";
                    break;
                case (10, 20):
                    mesaj3 = "10 ile 20 değerleri";
                    break;
                default:
                    break;
            }
            Console.WriteLine(mesaj3);
            string mesaj4 = (s1, s2) switch
            {
                (5, 10) when (true) => "5 ile 10 Değerleri",
                var xt when xt.s1 % 2 == 1 || xt.s2 == 1 => "10 ile 20 Değerleri",
                _ => "Eşleşme yok"
            };
            Console.WriteLine(mesaj4);
            #endregion
            #region Positional Patterns
            //Deconstruct özelliği olan nesneleri kıyaslamak yahut değersel karşılaştırmak için kullanılır.
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = "Enes";
            ogrenci.Soyadi = "ÖZBAY";
            ogrenci.Meslek = "ARFF";

            var adSoad = ogrenci switch
            {
                ("Ahmet", "Yıldırım", "Memur") => "Ahmet YILDIRIM Memur",
                ("Ahmet", "YILMAZ", "Memur") => "Ahmet YILDIRIM Memur",
                ("Ahmet", "YILDIRAN", "Memur") => "Ahmet YILDIRIM Memur",
                ("Enes", "ÖZBAY", "ARFF") => "Enes ÖZBAY ARFF Memuru",
                (_, _, _) => "Hiçbiri",
                _ => "Hiçbiri"
            };
            Console.WriteLine(adSoad);

            var adSoyad = ogrenci switch
            {
                ("Ahmet", "Yıldırım", "Memur") => "Ahmet YILDIRIM Memur",
                var l when l.Adi == "Ahmet" && l.Soyadi == "YILDIRIM" => "Ahmet YILDIRIM Memur",
                ("Ahmet", "YILDIRAN", "Memur") when 3 == 5 => "Ahmet YILDIRIM Memur",
                ("Enes", "ÖZBAY", _) => "Enes ÖZBAY Default-ARFF Memuru",
                (_, _, _) => "Hiçbiri",
                _ => "Hiçbiri"
            };
            Console.WriteLine(adSoyad);


            #endregion
            #region Property Patterns
            //Nesnenin proplarına girerek berlirli durumları hızlı bir şekilde kontrol etmemizi sağlar.
            //Aynı zamanda bunu birden fazla kez tekrarlı bir şekilde yapmamıza da olanak sağlar.
            double maas = 0;

            switch (ogrenci.Meslek)
            {
                case "ARFF":
                    maas = 54000;
                    break;
                case "ATC":
                    maas = 100000;
                    break;
                case "ATSEP":
                    maas = 95000;
                    break;
                case "Apron":
                    maas = 55000;
                    break;
                case "AIM":
                    maas = 96000;
                    break;
                default:
                    break;
            }


            maas = ogrenci switch
            {
                { Meslek: "ARFF" } => 54500,
                { Meslek: "ATC" } => 105000,
                { Meslek: "ATSEP" } => 95500,
                { Meslek: "APRON" } => 55500,
                { Meslek: "AIM" } => 97000,
                { } => 0
            };
            maas = ogrenci switch
            {
                { Meslek: "ARFF" } => 54500,
                var z when z.Meslek == "ATC" => 105000,
                { Meslek: "ATSEP" } when !true => 95500,
                var z when z.Meslek == "APRON" => 55500,
                { Meslek: "AIM" } => 97000,
                { } => 0 // ya da var x => 0 ya da _=>0
            };
            Console.WriteLine(ogrenci.Meslek + " " + maas);
            #endregion
            #endregion

            #region if Yapısı

            //Switch Case ile farkları
            //Switch Case Elimizdeki bir değerin sadece eşitlik durumunu kontrol eden bi kontrol akış mekanizmasıyken
            //İf Yapılanması elimizdeki bir değerin eşitlik durumu da dahil tüm karşılaştırmaları yapar.

            int ebule = 10;
            if (ebule == 10)
            {
                Console.WriteLine("i sayısı 10");
                // Console.WriteLine("Merhaba");
            }
            //Console.WriteLine( "Merhaba" ); Don't Repeat Yourself yani tekrar etme
            //her iki durumda da ortak olan kodları if bloğunun dışına yaz 
            else
            {
                Console.WriteLine("i 10 değil");
                // Console.WriteLine("Merhaba");
            }

            Console.WriteLine("Merhaba");
            #region if Else if Yapısı
            // Birden fazla şartı kontrol etmemizi sağlayan yapıdır.
            //şu ise şunu yap-değilse bunu yap => if else
            //şu ise şunu bu ise bunu o ise onu =>if-else if
            //if yapılanmalarında eğer şart gerçekleşirse diğer else if'ler kontrol edilmez.

            int sayı = 30;
            if (sayı > 5 && sayı <= 10)
            {
                Console.WriteLine(sayı * 5);
            }
            /*else*/
            if (sayı > 10 && sayı <= 20)
            {
                Console.WriteLine(sayı * 10);
            }
            /*else*/
            if (sayı > 10 && sayı <= 30)
            {
                Console.WriteLine(sayı * 20);
            }
            //Eğer ortak kesişen bir şartımız varsa örneğin 10'dan büyükse hem 10la çarpmak hem 20yle çarpmak istiyorsam ayrı bir if yazmam gerekir
            //İf blokları birbirinden bağımsızdır.



            #endregion
            #region if - else if - ... - else

            int e = 100;
            if (e < 100)
            {
                Console.WriteLine("100'den küçük");
            }
            else if (e > 100)
            {
                Console.WriteLine("100'den büyük");
            }
            else
            {
                Console.WriteLine("100'e eşit");
            }

            #endregion
            #region Scopesuz if Yapısı
            if (true)

                Console.WriteLine();//if yapılanması ile tek satırlık (konseptlik) bir işlem gerçekleştirilecekse
                                    //bunu scope içine yazmak zorunda değiliz.
            if (true)
            {
                Console.WriteLine("A");  // Böyle 1den fazla konsept varsa scope içine
                Console.WriteLine("B");  // almak zorundayız.
            }
            #endregion

            #region Senaryo 1
            // Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200'den fazla
            //ise 2. üründen %25 indirim yaparak ödenecek tutarı gösterelim.

            Console.Write("İlk Ürünün Fiyatını Giriniz:  "); //WriteLine yazar satır atlar Write sadece yazar
            int urun1 = 45; //int.Parse(Console.ReadLine());
            Console.Write("İkinci Ürünün Fiyatını Giriniz: ");
            int urun2 = 36; //int.Parse(Console.ReadLine());

            if (urun1 + urun2 >= 200)
            {
                if (urun1 >= urun2)
                {

                    Console.WriteLine("!!!! 2.Ürüne İNDİRİM YAPILDI !!!!!Sepet Toplamınız: " + (((urun2 * 75) / 100) + urun1));
                }
                else if (urun2 > urun1)
                {
                    Console.WriteLine("!!!! 1.Ürüne İNDİRİM YAPILDI !!!!!Sepet Toplamınız: " + (((urun1 * 75) / 100) + urun2));
                }

            }
            else
            {
                Console.WriteLine("Sepet Toplamınız: " + (urun1 + urun2));
            }















            #endregion
            #region Senaryo 2
            // Kullanıcı adı ve şifre girildiğinde giriş başarılı veya giriş bilgileri hatalı mesajı veren consol uygulaması yazalım
            //Console.Write("Kullanıcı Adı: ");
            //string kullaniciAdi = Console.ReadLine();
            //Console.Write("Şifre: ");
            //string sifre = Console.ReadLine();


            //switch (kullaniciAdi,sifre)
            //{
            //    case ("gncy","12345"):
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    case ("gncy", _):
            //        Console.WriteLine("Şifre Hatalı");
            //        break;
            //    case (_,"12345"):
            //        Console.WriteLine("Kullanıcı Adı Hatalı");
            //        break;
            //    default:
            //        Console.WriteLine("Kullanıcı Adı ve Şifre Hatalı");
            //        break;
            //}


            //if (kullaniciAdi=="Enes4359" && sifre == "147852")
            //{
            //    Console.WriteLine("Giriş Başarılı");
            //}
            //else if(kullaniciAdi!="Enes4359" && sifre == "147852")
            //{
            //    Console.WriteLine("Kullanıcı Adı Yanlış.");
            //}
            //else if ((kullaniciAdi=="Enes4359" && sifre != "147852"))
            //{
            //    Console.WriteLine("Şifre Yanlış.");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı Adı ve Şifre Yanlış.");
            //}


            #endregion
            #region Senaryo 3
            for (int t = 0; t < 99; t++)
            {
                //Matematik();
            }
            static void Matematik()
            {



                Console.WriteLine("1. Sayıyı girip yapmak istediğiniz işleme göre + - * / yazıp 2. sayıyı yazınız. Arada boşluk bırakınız");
                string giris = Console.ReadLine();
                string[] bol = giris.Split(' ');
                int sayi1 = int.Parse(bol[0]);
                char islem = char.Parse(bol[1]);
                int sayi2 = int.Parse(bol[2]);
                //-----------------------switch pattern
                int sonuc = islem switch
                {
                    '+' => sayi2 + sayi1,
                    '-' => sayi1 - sayi2,
                    '*' => sayi1 * sayi2,
                    '/' => sayi1 / sayi2,
                    _ => 0

                };
                Console.WriteLine("Sonuç = " + sonuc);
                //------------------------if else if
                //if (islem == '+')
                //{
                //    Console.WriteLine("Toplam= " + (sayi1 + sayi2));
                //}
                //else if (islem == '-')
                //{
                //    if (sayi1 > sayi2)
                //    {
                //        Console.WriteLine("Fark= " + (sayi1 - sayi2));
                //    }
                //    else
                //        Console.WriteLine("Fark= -" + (sayi2 - sayi1));

                //}
                //else if (islem == '*')
                //{
                //    Console.WriteLine("Çarpım= " + (sayi1 * sayi2));
                //}
                //else if (islem == '/')
                //{

                //    Console.WriteLine("Bölüm= " + (sayi1 / sayi2) + " Kalan: " + (sayi1 % sayi2));
                //}


            }




            #endregion
            #region Senaryo 4
            //Girilen sayının negati ya da pozitif olduğunu gösteren uygulama

            int tespit = int.Parse(Console.ReadLine());
            //Console.WriteLine(tespit>0?"Pozitif":(tespit==0?"0'a Eşit":"Negatif"));
            string sonuc = "";
            if (tespit > 0)
            {
                sonuc = "Pozitif";
            }
            else if (tespit < 0)                    ///içerideki negatif pozitif değeri ne ise dışarda kullanmak için
            {
                sonuc = "Negatif";
            }
            else
            {
                sonuc = "Nötr";
            }

            #endregion


            #endregion

            #region Pattern Matching
            #region Type Pattern

            //Object içerisindeki bir tipin belirlenmesinde kullanılan is operatörünün desenleştirilmiş halidir.

            Object x = "1234";
            if (x is string)
            {
                string _x = (string)x;
                Console.WriteLine($"{_x} Değişkeni String Tipindedir.");
            }
            else if( x is int)
            {
                int _x = (int)x;
                Console.WriteLine($"{_x} Değişkeni int Tipindedir. ");
            }
            
            Object y = 1234;
            if (y is string _sy)
                Console.WriteLine($"{_sy} Değişkeni String Tipindedir.");
            else if (y is int _iy)
                Console.WriteLine($"{_iy} Değişkeni int Tipindedir. ");

            //Console.WriteLine(_sy + _iy); _sy'nin ve _iy'nin boş gelme ihtimalinden dolayı dışarıda kullanamazsın

            #endregion
            #region Constant Pattern
            //Elimizdeki veriyi sabit bir değer ile karşılaştırmamızı sağlar Tür karşılaştırması constant pattern değildir.
            // is operatörü bir değişkenin türünü ya da değerini sormamızı sağlar.
            //illa referans türünde olmak zorunda değildir. Hatta primitive türlerde bile kullanıalbilir
            object ilk = 123;
            int yuzOn = 110;
            Console.WriteLine(yuzOn is int);
            if (x is 123)
            {

            }
            if (x is int)
            {

            }
            #endregion
            #region Var Pattern
            //normalde var türünde bir değer derleme zamanında kendi türüne bürünecektir.
            //var pattern'de ise derlemede değil RunTime'da türünü berlirleyecektir.
            //dynamic keywordü de runtime'da tür belirlerdi hatırlayalım ancak burada kullanılamaz.
            object tur = "Türkiye";
            if (tur is var turkiyeCumhuriyeti) //var'ın türü runtime 'da belirlenecek
            {
                Console.WriteLine(turkiyeCumhuriyeti);
            }
            #endregion
            #region Recursive Pattern
            //switch-case yapılanması üzerindedir. tür kontrolü yapar referans türleri de kontrol eder ve type pattern'i kapsar.
            //recursive pattern case null komutu ile türün veya referansın null olup olmamasını kontrol etmesinden dolayı Constant Pattern'i de kapsamaktadır.
            #endregion
            #region Type-Var Pattern Kritik
            object ben = "Enes";
            bool trueMu=ben is string _ben; //Type Pattern           //hem kontrol yaptım hem de _ben adındaki değişkene değerini atadım.
            bool trueMu2 = ben is var _ben2; //Var Pattern           //hem kontrol yaptım hem de _ben2 adındaki var türündeki değişkene değerini atadım.
            //Console.WriteLine(_ben); //null olma ihtimali var yine kullanılamaz hata verir. if içerisinde kullanmak daha iyidir.
            Console.WriteLine(_ben2); //Null gelme ihtimali yoktur. o yüzden kullanılabilir.

            #endregion
            #region Pattern Matching Enhancements C# 9.0
            #region Simple Type Pattern

            object obj = new Ogrenci();
            switch (obj)
            {
                case Ogrenci o:     //o örneklemesi yapmamıza artık gerek yok

                    break;
            }

            switch (obj)
            {
                case Ogrenci:     //Böyle kullanabiliyoruz. obj öğrenci ise şunu yap
                    break;
            }

            //164.video



            #endregion
            #region Relational Patterns
            //Desenlerde <,>,<=,>= operatörleri kullanmamızı sağlar.
            int number = 111;
            string result = number switch  //Artık switch'te 9.0'dan sonra diğer kıyaslamaları da yapabilmekteyiz.
            {
                < 50 => "50'den küçük",
                > 50 => "50'den büyük",
                _=> "Hiçbiri"
            };
            #endregion
            #region Logical Patterns
            //167.video  and,or ve not keywordleri de kullanabiliyoruz.
            #endregion
            #region Not Patterns
            //168.video not keywordü
            #endregion



            #endregion
            #endregion
        }


        public class Ogrenci
        {
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public string Meslek { get; set; }
            public void Deconstruct(out string adi, out string soyadi, out string meslek)
            {
                adi = Adi;
                soyadi = Soyadi;
                meslek = Meslek;
            }
        }
    }
}
