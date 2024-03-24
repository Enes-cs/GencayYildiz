using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Regular Expressions Operators
            //^ Operatörü : Satır başının istenilen ifade ile başlamasını sağlayan bir operatördür.

            // ^9 : Yazı 9 ile başlamak zorunda demektedir.

            //RegularExpressionsOperators();
            static void RegularExpressionsOperators()
            {
                string text = "29skldfjslkdfjlskdf123123";

                Regex regex = new Regex("^29");

                Match match = regex.Match(text);

                Console.WriteLine(match.Success);
            }
            #endregion

            #region \ Operatörü

            /*
             *      \: Belirli karakter gruplarını içermesini istiyorsak.
             *      
             *      \D : Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması
             *      \d : ilgili yerde 0-9 arasında tek bir sayı
             *      
             *      \W : İlgili yerde alfanümerik olmayan (Özel Karakter) karakterin olması. A-z 0-9
             *      \w : ilgili yerde alfanümerik olan karakter olması.
             *      
             *      \S : İlgili yerde boşluk dışında herhangi bir karakterin olacağı
             *      \s : İlgili yerde sadece boşluk olacağı. 
             */

            // 9 ile başlayan ikinci karakteri herhangi bir sayı olan ve üçüncü karakteri boşluk olmayan ifade oluştur.

            //^9\d\S

            //IlkOperator();
            static void IlkOperator()
            {
                string text2 = Console.ReadLine();

                Regex regex1 = new Regex(@"^9\d\S");

                Match match2 = regex1.Match(text2);

                Console.WriteLine(match2.Success ? "İfade Geçerli" : "İfade Geçersiz");
            }
            #endregion

            #region + Operatörü

            //Belirtilen gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanırız.
            // 9 ile başlayan arada herhangi bir karakteri herhangi bir sayı olan ve son karakteri boşluk olmayan ifade oluştur.

            //PlusOperator();

            static void PlusOperator()
            {
                string text3 = Console.ReadLine();

                Regex regex2 = new Regex(@"^9\d+\S");
                Match match3 = regex2.Match(text3);
                Console.WriteLine(match3.Success);
            }



            #endregion

            #region | Operatörü

            //Birden fazla karakter grubundan bir ya da birkaçının ilgili yerde olabileceğini belirtmek istiyorsak mantıksal veya operatörü kullanılır.

            //Baş harfi a ya da b ya da c olan metinsel ifadeyi girelim.
            //a|b|c

            //YadaOperatörü();

            static void YadaOperatörü()
            {
                string text = Console.ReadLine();

                Regex regex = new Regex(@"a|b|c");

                Match match = regex.Match(text);

                Console.WriteLine(match.Success ? "Doğru" : "Yanlış");
            }


            #endregion

            #region {n} Operatörü (Format Belirleme)

            //Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli.
            //507-7514592 bu formatta 3 rakam - 7 rakam

            //FormatBelirleme();

            static void FormatBelirleme()
            {
                string text = Console.ReadLine();
                Regex regex = new Regex(@"\d{3}-\d{7}");
                Match match = regex.Match(text);

                Console.WriteLine(match.Success ? "Format Doğru" : "Yanlış");
            }


            #endregion

            #region ? Operatörü
            //Bu karakterin önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir.
            // \d{3}B?A --> 234BA, 543A --> ilk 3 karakter sayı rakam sonraki karakter en az 0 tane en çok 1 tane B olacak sonra da A gelecek

            //SoruIsaretiOperatoru();

            static void SoruIsaretiOperatoru()
            {
                string text = Console.ReadLine();

                Regex regex = new Regex(@"\d{3}B?A");

                Match match = regex.Match(text);

                Console.WriteLine(match.Success);
            }


            #endregion

            #region . Operatörü

            //ilgili yerde \n harici herhangi bir karakterin kullanılabilir anlamına gelir
            //\d{3}.A => ilk 3 karakter sayı sonra herhangi bir karakter sonra A
            //NoktaOperatoru();

            static void NoktaOperatoru()
            {
                string text = new string(Console.ReadLine());
                Regex regex = new Regex(@"\d{3}.{7}A");
                Match match = regex.Match(text);
                Console.WriteLine(match.Success ? "Doğru" : "Yanlış");
            }

            #endregion

            #region \b ve \B Operatörleri

            // \B : Kelimenin başında ya da sonunda olmaması gereken karakterler bildirilir.
            // \b : Kelimenin belirtilen karakter dizisi ile sonlanmasını sağlar.
            // ilk 3 karakteri rakam olsun sonra başında ve sonunda "dır" olmasın

            //IfadeOlsunOlmasın();

            static void IfadeOlsunOlmasın()
            {
                string text = Console.ReadLine();

                Regex regex = new Regex(@"\d{3}dır\B");
                Match match = regex.Match(text);
                Console.WriteLine(match.Success);
            }


            #endregion

            #region [n] Operatörü
            // [n] : Karakter aralığı belirtebilir. Ayrıca Özel karakterlerin yerinde yazılmasını ifade eder.
            // 3 sayısal ifade ardından Büyük A ile Büyük E arasındaki harfler olsun.  \d{3}[A-E]
            // (507) 751 45 92 Formatı: [(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}

            //AralıkyaDaOzelKarakter();

            static void AralıkyaDaOzelKarakter()
            {
                string text = Console.ReadLine();
                Regex regex = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
                Match match = regex.Match(text);
                Console.WriteLine(match.Success);
            }

            #endregion


            #region Match Propları
            string text = Console.ReadLine();
            Regex regex = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
            Match match = regex.Match(text);
            Console.WriteLine(match.Success);

            Console.WriteLine($"Success: {match.Success}"); //Doğruluk
            Console.WriteLine($"Value: {match.Value}"); //Doğrulanan Veri
            Console.WriteLine($"Index: {match.Index}"); //Doğrulamanın başladığı index
            Console.WriteLine($"Length: {match.Length}"); //Doğrulanan Karakter Sayısı


            #endregion


        }
    }
}
