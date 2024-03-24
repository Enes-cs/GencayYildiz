

using System.Threading.Channels;

namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //+, -, *, /, % Artimetik Operatörlerdir.
            //Karşılaştırma,Aritmatik,Mantıksal,Arttırma azaltma,Metinsel ifade,Ternary,? Nullable operatörleri kesinlikle bilinmeli.
            #region Artimatik Operatörler Geriye Dönüş Değeri
            //Aritmatik operatörler, iki sayısal değer üzerinde işlem yapan operatörler oldukları için
            // işlem neticesinde geriye "Uygun Türkde" sonuç dönerler.

            int sonuc = 3 + 5;
            int x = 3, y = 5;
            int sonuc2 = x + y; //operatörü kullanırken mousela üstüne gel ne döndürdüğünü gör
            double s1 = 123;
            double s2 = 321;
            double sonuc3 = s1 + s2; //aynı türde sayısal değerler üzerinde işlem yaparken sonuç türü aynı olacaktır.
            #endregion
            #region(int) * (double) = ?
            //İki farkılı türde sayısal değerler üzerinde yapılan işlem neticesinde sonuç büyük olan türde döner.
            int sa1 = 10;
            double sa2 = 5;
            //Artimatik operatörler küçük olan türü büyük olan türe otomatik bilinçsiz dönüştürür.
            double son = sa1 + sa2;
            #endregion
            #region (byte) * (int) = ?
            int say1 = 3;
            byte say2 = 5;
            sonuc2 = say1 + say2;
            #endregion
            #region (byte) * (byte) = ? (İstisnai Mülakat!!!)
            byte son1 = 10;
            byte son2 = 5;
            //byte dene = son1 + son2; // Hata verecek Çünkü
            int sonucc = son1 + son2; //2 Bayt arasında yapılacak olan aritmatik işlem int sonuç döner.
            #endregion
            #region Matematiksel İşlemler (Öncelik Sırası)

            #endregion
            #region Karşılaştırma Operatörleri

            //Karşılaştırma Operatörlerinin Geriye Dönüş Değerleri
            //Her Daim Bool türde değer döndürür.
            // < Küçük, > Büyük, <= küçük veya eşit, >= büyük veya eşit, == eşitlik
            int i1 = 123;
            int i2 = 253;
            bool sonuc123 = i1 > i2;


            #endregion
            #region Mantıksal Operatörler
            // && ve (Tüm Şartların yerine getirilmiş olmasını ister.)
            // || veya (En az 1 şartın yerine getirilmiş olmasını ister. 2 Şart'da yerine getirilebilir.)
            // ^ ya da ( Şartlardan kesinlikle(En Fazla) bir tanesinin yerine getirilmesini ister.)

            // Kullanılan Değerler kesinlikle mantıksal olmalıdır.

            bool patates = true, kofte = false;
            bool sonucB = patates && kofte; // (1 ve 1=1) (1 ve 0 =0) (0 ve 1 =0) (0 ve 0 =0)
            bool sonucC = patates || kofte; // (1 veya 1=1) (1 veya 0 =1) (0 veya 1 =1) (0 veya 0 =0)
            bool sonucD = patates ^ kofte; // (1 yada 1 = 0) (1 yada 0 =1) (0 yada 1=1) (0 veya 0 =0)
            Console.WriteLine(sonucB);
            Console.WriteLine(sonucC);
            Console.WriteLine(sonucD);

            //ve
            Console.WriteLine(((true && true) || false && ((true ^ false) && false) || true));

            #endregion
            #region Arttırma ve Azaltma Operatörleri *-*-************************

            // ++ Artırma, -- Azaltma

            int i = 5;
            //i++; //bu i+1'in karşılığıdır. İşlem neticesinde değişkenin değerini döner.
            //Console.WriteLine(i); //6
            //++i;
            //Console.WriteLine(i); //6

            //++i; //arttırma ya da azaltma operatörlerinin sağda yada solda olmasının arasındaki farkı
            // şudur
            //++i Öncelikle i değeri 1 artırılır ardından i değerini döndürür.
            //i++ öncelikle i değerini döndürür sonra değerini 1 artırır.
            //Console.WriteLine(i++); // Çıktı 5 | Bellek 6
            //Console.WriteLine(++i); // Çıktı 7 | Bellek 7

            //Örnek 2
            //int a = 5;
            //int b = a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //örnek 3
            int l1 = 5; //l1=5
            int l2 = ++l1; //l2 = 6
            int l3 = l1; //l3 = 6
            int l4 = l2++; //l4=6

            Console.WriteLine(l1); //6
            Console.WriteLine(l2); //7
            Console.WriteLine(l3); //6
            Console.WriteLine(l4); //6

            #endregion
            #region Üzerine Yığma Operatörleri
            // += i=i+3 => i+=3
            // -= i=i-5 => i-=5
            // *= i=i*2 => i*=2
            // /= i=i/5 => i/=5
            // %= i=i%3 => i%=3



            #endregion
            #region + Operatörü
            //+ Operatörü ile metinsel ifadeler birleştirilebilir.
            // Metinsel olmayan bir ifade metinsel bir ifadeyle toplanırsa birleştirilir.
            int a43 = 43;
            string il = " Kütahya";
            Console.WriteLine(a43 + il);
            //Tür dönüşümlerinde herhangi bir değeri string'e dönüştürebilmek için .ToString fonksiyonu kullanıyorduk
            //Ayrıca ilgili türü string'e dönüştürmek için string bir ifade ile + operatörüne tutarak da yapılır.
            #endregion
            #region += Operatörü
            string amca = "Ahmet";
            string amca2 = " Mehmet";
            amca += amca2;
            Console.WriteLine(amca);
            #endregion
            #region == ve != Operatörü
            // Eşitlik kıyasıdır.
            bool acaba = amca == amca2;
            Console.WriteLine(acaba);
            bool degilSe = amca != amca2;
            Console.WriteLine(degilSe);
            #endregion
            #region ! Operatörü
            // Mantıksal yapılarda olumsuzluk ifade eder örnek !false=True
            // != Eşit Değillik

            //Console.WriteLine(!true);
            int g = 3;
            int g2 = 5;
            Console.WriteLine(g != g2);
            Console.WriteLine(!(g == g2));
            //!= bu operatörün dışında mantıksal değerlerin yanında kullanılabilir.
            #endregion
            #region Ternary Operatörü ?:
            //Bir değişkene, metoda, property'e değer atarken, eğer ki bu değer şarta göre fark edecekse
            //tek satırda bu şart kontrolü yapılır. 

            bool medeniHal = true;
            string mesaj = medeniHal ? "Evlilere Kampanya" : "Bekarlara Kampanya";
            //           =  Şart     ?       TRUE          :        FALSE        ;

            Console.WriteLine(mesaj);
            //Dönecek değerler aynı olmalı

            //Birden Fazla Condition Uygulamak

            int yas = 25;
            //Yaşı 25'den küçükse A, 25 ise B, Büyükse C

            string birdenFazla = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
            #region Ternary Örnek

            //Sayı < 3 ise                                          5 ile çarp
            //Sayı > 3 ve sayı < 9 ise                              3 ile çarp
            //sayı >=9 ve sayının 2'ye bölümünden kalan 0 ise      10 ile çarp
            //Sayının 2'ye bölümünden kalan 1 ise                   sayıyı ver
            //Hiç biri değilse -1 döndür
            Console.WriteLine("Bir Sayı Girin");
            //int number = int.Parse(Console.ReadLine()); //Kullanıcının Girdiği değeri string olarak verir.
            //int _sayi = int.Parse(number);

            //int soyle = number < 3 ? number * 5 : 
            //(number > 3 && number < 9 ? number * 3 : 
            //(number >= 9 && number % 2 == 0) ? number * 10 : 
            //(number % 2 == 1 ? number :-1));

            //Console.WriteLine("Sonuç: "+soyle);
            #endregion
            #region Ternary Örnek 2
            //Yağmulu => Şemsiye Almalısın
            //Güneşli => Bol Bol D vitamini Alman dileyğiyle
            //Kapalı => Yağmur Yağabilir.
            Console.WriteLine("Yağmurlu, Güneşli, Ya da Kapalı Yazınız.");
            string durum = Console.ReadLine();

            string tavsiye = durum == "Yağmurlu" ? "Şemsiye Almalısın" : (durum == "Güneşli" ? "Bol Bol D Vitamini Alman Dileğiyle" : (durum == "Kapalı" ? "Yağmur Yağabilir." : "Geçerli Bir Durum Girmediniz."));
            Console.WriteLine("Tavsiyemiz: " + tavsiye);
            #endregion
            #endregion
            #region Atama(Assign) Operatörü

            int a = 5;

            //   ____________  =  __________;
            //     kendisi     =     değeri;
            //      int a      =        5;
            //Referans türlerde referans etme operatörüne dönüşür.

            #endregion
            #region .(Member Access - Üye Erişim) Operatörü
            int ibrahim = 5;
            Console.WriteLine(i.CompareTo(ibrahim));
            //Elimizdeki bir değerin türüne uygun elemanlarını /fonsksiyonlarını/proplarını/field larına erişmemize çalıştırmamıza yarar.
            #endregion
            #region Cast Operatörü
            //Genelllikle tür dönüşümlerinde kullanılan bir operatördür.
            // Cast => () 
            // (type)value
            //1. Boxing -> Unboxing
            object dene = 123;
            int _dene = (int)dene;
            //2. Bilinçli tür dönüşümü
            int bes = 5;
            short ayı = (short)bes;
            //3. Char -> int | int -> Char (ASCII)
            int ascii = 93;
            char asciii = (char)ascii;
            // Polimorfizm durumunda base class referansıyla işaretlenen bir nesneyi kendi türünde elde etmemizi sağlar
            #endregion
            #region sizeOf Operatörü (Türlerin Ne kadar Yer kapladığını Byte Cinsinden Verir)
            //Verilen türün bellekte kaç byte'lık değer kapladığını int olarak döndürür.
            Console.WriteLine(sizeof(ulong));

            #endregion
            #region typeOf Operatörü (Bir türün detaylarını söyler)
            //verilen türün/değerin type'ını türünü verir
            Type t = typeof(int);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Assembly);
            Console.WriteLine(t.IsPrimitive);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsValueType);
            #endregion
            #region default Operatörü
            //Belirtilen türün default değerini döndüren operatördür.
            //Default değerler, her tür için yazılım tarafında tanımlanmış varsayılan değerdir.
            // Sayısal=0 bool=false string=null char=\0 referans=null

            Console.WriteLine(default(decimal));
            Console.WriteLine(default(Program));//değersiz olduğu için boş yazar consola
            int a1 = default;
            bool deneme = default;
            #endregion
            #region is Operatörü
            //boxinge tabi tutulmuş değerin öz türünü öğrenmek için kullanılır.
            //is operatörü denetleme neticesinde durumu bool olarak döndürür
            object beta = true;
            Console.WriteLine(beta is bool);
            Console.WriteLine(beta is int);
            Console.WriteLine(beta is Program);
            #endregion
            #region is null operatörü
            //Bir değişkenin değerinin null olup olmamasını kontrol eder bool döndürür.
            //Sadece null olabilen türlerde kullanılır.
            //Sadece referans değerler null olabilir.
            string bos= default;
            Console.WriteLine(bos is null);
            #endregion
            #region is not null operatörü
            //Elimizdeki değerin null olup olmadığına göre bool sonuç döndürüyor.
            //Sadece null olabilen türlerde kullanılır.
            //Sadece referans değerler null olabilir.
            #endregion
            #region as operatörü
            // Cast operatörünün UnBoxing işlemine alternatif olarak üretilmiştir.
            //Cast işlemi türüne uygun yapılmalı yoksa hata verir
            //ancak as operatöründe null değeri döndürür.
            //Bu yüzden sadece referans değerlerle çalışabilir.
            //programatik olarak yazılımın sonlanmadan akışta kontrol edilmesine müsade edecek
            // x as Type şeklinde kullanılır.

            object nesne = "Enes";
            string _nesne = nesne as string;

            Program _n3sne=nesne as Program;
            Console.WriteLine("Nedir? " + _n3sne);
            Console.WriteLine();
            #endregion
            #region Nullable Operatörü (?)
            // C# prog. dilinde değer tür. değişkenler null değer alamazlar.
            //Bir değer türlü değişkenin null değer alabilmesi için 
            //? operatörünün kullanılması gerekir.

            int? ana = null; //artık nullable oldu
            bool? baba = null;

            Console.WriteLine(ana is null);
            Console.WriteLine(ana is not null);

            object numara = 13;
            int? _numara=numara as int?;

            #endregion
            #region ?? Null-Coalescing Operatörü
            //Elimizdeki değerin null olma durumuna istinaden farklı bir değer göndermemizi sağlayan operatörüdür.

            // değişken null ise bir değer yazdırıyoruz null değilse kendi değerini yazdır.
            string deli =default;
            Console.WriteLine(deli??"Delinin içi boş");
            // her iki taraf da aynı türde olmalıdır.
            #endregion
            #region ??= Null-Coalescing Assignment Operatörü 
            string nca = null;
            Console.WriteLine(nca ??= "Nca null ise benim değerimi nca'ya ata demektir ??=");
            Console.WriteLine(nca);
            #endregion



        }

    }
}
