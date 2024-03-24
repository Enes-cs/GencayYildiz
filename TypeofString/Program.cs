using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TypeofString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String
            //Referans tür olup programlama dilinde keyword ile karşılanan tek tiptir.

            #region Null-Empty Durumları, Farkları

            #region Null (Alan Tahsisi Yok)
            //Bir değişken/nullable/referans eğer ki null alıyorsa ilgili değişkenin herhangi bir alanı tahsis etmediği anlamına gelir.
            //Değer türlü değişkenlerin null alabilmesi için nullable olmaları gerekmektedir.
            int? a = null;
            string b = null;

            // Bellekte Yer Kaplamaz.
            // İşlem Yapılamaz Runtime hatası verir.
            #endregion

            #region Empty (Alan Tahsisi Var)
            // Bellekte Yer Kaplar.
            //Üzerinde işlem yapılabilir.

            //Bir değişken/nullable/referans eğer ki empty ise bu değişkenin alan tahsisi yaptığı ancak içinin boş olduğu anlamına gelir.
            //Tüm değerlere empty atanabilir.
            //Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumudur.

            int c; //c değişkeni empty'dir default değeri gelir o da 0'dır.
            bool d = false; //false bool için default'dur bu da empty sayılır.

            int[] x = new int[555];

            //empty dendiğinde akla string'e "" deperinin verilmesi gelsin yeterli.
            string e = "";
            e = string.Empty; //ikisi de aynı şey

            #endregion

            #endregion

            #region IsNullorEmpty

            //Elimizdeki string ifadelerin işleme tabi tutulmadan önce kesinlikle kontrol edilmesi gerekmektedir.
            if (e!="" && e is not null)
            {
                //ilgili operasyon
            }

            //IsNullorEmpty fonksiyonu; elimizdeki string ifadenin null yahut empty olup olmama durumları hakkında hızlı check yapar ve bool türünde sonuç döndürür.
            bool sonuc = string.IsNullOrWhiteSpace(e);
            Console.WriteLine("e null ya da empty mi? " + sonuc);

            if (!string.IsNullOrEmpty(e))
            {
                //e boş değilse yapılacak işlem.
            }

            #endregion

            #region IsNullorWhiteSpace

            string bos = "                     " ;

            bool boslukmu = string.IsNullOrWhiteSpace(bos);

            if (string.IsNullOrWhiteSpace(bos))
            {
                Console.WriteLine("BOŞ");
            }
            else
            {
                Console.WriteLine("Dolu");
            }

            #endregion

            #region String - Char Dizisi

            string metin = "sebepsiz boş yere ayrılacaksan...";

            //string ifadeler aslında bir char dizisidir.

            //Aslında bilgisayar için metin yoktur yan yana gelmiş char dizisidir.

            //string ifadeler char dizisi olduklarından dolayı her bir karakter baştan sona indexlenmektedir.
            //dolaysıyla string bir ifade üzerinde indexer operatörü kullanabiliriz.

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i]==' ')
                    Console.WriteLine(i);
            }

            //string özünde bir char dizisi olabilir ancak yapısal olarak yined

            int z = 0;


            do
            {
                if (metin[z] == 'e')
                    Console.WriteLine(z);
                    z++;
                
            } while (z<metin.Length);

            #endregion

            #region String ifadelerde + Operatörü

            //String ifadelerde + operatörü kullanılabilir. 
            //iki string ifade arasında birleştirme görevi görür

            string m= "Merhaba" , k = " Dünya";
            string birlesim = m + k;
            Console.WriteLine(birlesim);

            Console.WriteLine(m+k);

            //+ operatörü string bir  ifadeyle herhangi bir türdeki ifadeleri işleme tabi tutarken object + string davranışı gösterir. Geriye string döndürür.

            int m2 = 12;

            Console.WriteLine(m+m2);


            //String olmayan bir ifadeyi + operatörü ile boş string'i yani "" bununla toplarsak o tür stringe dönüşür fakat çok maliyetlidir kesinlikle dönüşüm için ToString öndeirlir.

            string m3= m2.ToString();
            Console.WriteLine(m3 is string);

            #endregion

            #region String Formatlama

            string isim = "Enes", soyisim = "ÖZBAY", tcNo = "627945614525";
            int yas = 29;
            bool medeniHal = true;

            Console.WriteLine("TC No: ........ olan .... .... şahsın bilgileri | Yaş: ... | Medeni Hâl: ... ");

            #region + Operatörü
            //Ternary operatörü kullanıyorsanız parantez içine almalısın.
            Console.WriteLine("TC No:" + tcNo + " olan " + isim +" "+ soyisim +" şahsının bilgileri | Yaş: " + yas + " | Medeni Hâl: " + (medeniHal? "Evli" : "Bekar"));
            //+ operatörü ile string formatlandırma operasyonu hem kod hem de performans açısından oldukça maliyetlidir o yüzden tercih etmemeliyiz.
            #endregion

            #region string.Format

            Console.WriteLine(string.Format("TC No: {0} olan {1} {2} şahsın bilgileri | Yaş: {3} | Medeni Hâl: {4} ",tcNo,isim,soyisim,yas,medeniHal?"Evli":"Bekar"));

            //string.Format fonksiyonu metinsel kalıbın içerisindeki indexel berlilenen noktalara sirasıyla değer göndermemizi sağlayan bir fonksiyondur.

            #endregion

            #region $(String Interpolation) (C# 6.0)

            //String interpolation string ifadenin içerisinde süslü parantez ile araya girerek programatik bir değişkenin değerini bırakmamızı/eklememizi sağlayan bir operatördür.
            Console.WriteLine($"TC No: {tcNo} olan {isim} {soyisim} şahsın bilgileri {{Deneme}}| Yaş: {yas} | Medeni Hâl: {(medeniHal ? "Evli" : "Bekar")}");
            //Aslında arka planda string.Format kullanır.
            //ternary vs kullanılıyorsa parantez içine alınmalı.
            // Metinsel { kullanılması gerekiyorsa o da { içine alınmalı

            #endregion

            #endregion

            #region String Kaçış Karakterleri

            /*
             * \o Null sonlandırma karakteri. Genel olarak dosya veya veri kanalının bitişini belirtmek için kullanılır.
             * \a Bip sesini çıkaran karakter
             * \b düzenli ifade kullanarak bir kelimenin başını ve sonunu belirlemek için kullanılır.
             * \t Tab
             * \r Satır Başı
             * \n Bir alt satıra iner
             * \v Dikey Tab
             * \f Sayfa ilerleme
             * \" Çift tırnak
             * \' Tek tırnak
             * \  Backslash
              
             String içerisinde kaçıl karakteri olarak \ (Backward Slah) kullanılır.
            String içerisinde özel karakterleri ezmemizi sağlar.
             Tab, Enter, Satır sonu gibi doğrudan klanvye tarafından girilen bazı tuşları girmek için kullanılır.
             * 
            */

            Console.WriteLine("\"Bugün Hava Çok Güzel\"");
            Console.WriteLine($"\\Bugün {isim} için Hava Çok Güzel\\");
            Console.Write("\a");
            Console.WriteLine("isim\tSoyisim");
            Console.WriteLine("isim\nSoyisim");




            #endregion

            #region @(Verbatim Strings) Operatörü - Kelimesi Kelimesine Operatörü
            #region 1.Kullanım
            int @void = 5;
            int @class = 5;
            int @namespace = 5;

            #endregion
            #region 2.Kullanım
            string metin2 = @"Hava Çok ""Güzel""";
            // Escape karakterlerinin kullanılması gereken durumlarda  
            #endregion
            #region 3.Kullanım
            //Satırlı metinler için kullanılır.

            string ifade = @"Aşağıdakilerden Hangisi 1 ile 10 Arasındadır.
    A-10    B-8    C-11
         D-20  E-30
                    ";
            Console.WriteLine(ifade);
            #endregion
            #endregion

            #region String interpolation ile verbatim strings birlikteliği (C# 8.0)

            string mailMessage = @$"Ad: {isim} 
Soyad: {soyisim}
Tc No: {tcNo}
Yaş:  {yas} 
olmak üzere kaydedilmiştir.

"; //@ $'dan önce yazılmalı
            Console.WriteLine(mailMessage);
            #endregion

            #region String Fonksiyonları
            string soz = "Lay Lay Lom Galiba Sana Göre Sevmeler";

            #region Contains

            //Metinin içinde bir kelimenin olup olmadığını kontrol edip bool döndürür.


            bool varMi = soz.Contains("galiba")^soz.Contains("Galiba");
            Console.WriteLine(varMi ? @"

Var

" : @"
Yok

");


            #endregion

            #region StartsWith
            //Metinin ne ile başladığını kontrol ediyoruz.
            Console.WriteLine(soz.StartsWith("Lay")?"Lay ile Başlıyor":"Lay ile başlamıyor");
            #endregion

            #region EndsWith
            Console.WriteLine(soz.EndsWith("er")?"er ile bitiyor":"er ile bitmiyor");
            #endregion

            #region Equals

            //Elimizdeki ifadenin değersel olarak eşit olup olmadığını check eder.
            Console.WriteLine(soz.Equals("Lay Lay Lom Galiba Sana Göre Sevmeler"));

            #endregion

            #region Compare

            //Sonuç integer döner
            //Metinsel ifadeleri karşılaştırmamızı sağlar.
            /*
             *  0 her iki değer eşit
             *  1 Soldaki sağdakinden Alfanumerik olarak büyük
             * -1 Soldaki sağdakinden Alfanumerik olarak küçük
             */

            Console.WriteLine(string.Compare(soz, "A"));
            Console.WriteLine(string.Compare(soz, soz));
            Console.WriteLine(string.Compare(metin,9,metin,8,5));
            #endregion

            #region CompareTo

            //compare'de fark değer üzerinden yola çıkılır.
            int kac= soz.CompareTo(soz);

            #endregion

            #region IndexOf
            //ilk eşleşen indexin değerini döndürür.

            int bosluk =metin.IndexOf(" "); //kaçıncı index olduğunu integer döndürür. eşleşme yok ise -1 değeri döndürür.

            Console.WriteLine(bosluk);

            #endregion

            #region Insert
            //metinsel ifadeye değer eklememizi sağlar
            string sozekli = soz.Insert(0, "Metin: ");
            Console.WriteLine(sozekli);
            Console.WriteLine(soz);

            //soz2'ye o anlık ekledi orjinal değişmedi.

            #endregion

            #region Remove

            //Metinsel ifadede indexl olarak verilen değer aralığını siler.

            Console.WriteLine(soz.Remove(5,15));

            #endregion

            #region Replace

            //Belirtilen değerlerin, belirtilen değerlerle değiştirilmesi.

            Console.WriteLine(soz.Replace(' ','-'));
            Console.WriteLine(soz.Replace("La", "o"));

            #endregion

            #region Split

            //Elimizdeki string ifadeyi ayraç olarak kullanıp parçalar.

            //string dizisi döner.

            string split = "SPLİTİN KESİNLİKLE BİLİNMES GEREKİR";
            string[] dizi = split.Split(' ', 'i');
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);
            }
            #endregion

            #region Substring Fonksiyonu

            //Elindeki ifadenin belirli bir aralığını elde etmemizi sağlar. String değer döndürür.
            string substring = "Substring'i Kesin Bileceksin.";
            substring.Substring(5);//5. indexten sonrasını getir.
            Console.WriteLine(substring.Substring(5)); //5. indexten sonrasını getir.
            Console.WriteLine(substring.Substring(6,10)); //6. indexten 10 karakter getirecek
            #endregion

            #region ToLower

            Console.WriteLine(soz.ToLower());

            #endregion

            #region ToUpper
            Console.WriteLine(soz.ToUpper());
            #endregion

            #region Trim Fonksiyonu

            //Metinsel ifadelerin var ise sağındaki solundaki boşluk karakterlerini temizleyen fonksiyondur.

            Console.WriteLine("              Ad Soyad                  ".Trim());
            Console.WriteLine("Ad Soyad");

            #endregion

            #region TrimEnd
            Console.WriteLine("      Ad Soyad       ".TrimEnd());
            #endregion

            #region TrimStart
            Console.Write("      Ad Soyad       ".TrimStart());
            Console.Write("Sondaki Kaldı");
            #endregion
            #endregion

            #region String Fonksiyonları Örnekleri
            Console.WriteLine();
            #region 1.Örnek
            //Adının ilkten 3. Soyadın sondan 5. karakterini getirelim.

            string adSoyad = "Enes ÖZBAY";

            Console.WriteLine(@$"Adının İlkten 3. Harfi: {adSoyad[2]} 
Soyadın sondan 5. Harfi {adSoyad[adSoyad.Length-5]}");

            string aralik = adSoyad[2..^4];

            Console.WriteLine(aralik[0]);
            Console.WriteLine(aralik[aralik.Length-1]);
            #endregion
            #region 2. Örnek
            //Girilen metinde kaç adet a harfi geçtiğini hesaplayalım.
            Console.Write("Metin Giriniz: ");string enter = Console.ReadLine();
            int aSayisi = 0;
            for (int i = 0; i < enter.Length; i++)
            {
                if (enter[i] == 'A' | enter[i] =='a')
                {
                    aSayisi++;
                }
            }

            Console.WriteLine($"Girilen ifadede {aSayisi} adet A harfi vardır.");
            #endregion
            #region 3.Örnek
            //Girilen metindeki kelime sayısını hesapla
            Console.Write("Metin Giriniz."); enter = Console.ReadLine();
            int kelimeSayisi = 1;
            #region Çözüm 1
            for (int i = 0; i < enter.Length; i++)
            {
                if (enter[i] == ' ')
                {
                    kelimeSayisi++;
                }
            }

            Console.WriteLine($"Girilen Metindeki Kelime Sayısı : {kelimeSayisi}");

            #endregion
            #region Çözüm 2

            string[] kelimeler = enter.Split(' ');
            Console.WriteLine($"Girilen Metindeki Kelime Sayısı : {kelimeler.Length}");
            #endregion

            #region Çözüm 3
            int adet = 1;
            while (true)
            {
                int index = enter.IndexOf(' ');
                if (index == -1)
                    break;
                    adet++;
                
                enter = enter.Substring(index+1);
                    
            }
            Console.WriteLine($"Girilen Metindeki Kelime Sayısı : {adet}");

            #endregion


            #endregion
            #endregion

            #endregion
        }
    }
}
