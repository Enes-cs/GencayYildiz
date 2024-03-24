namespace Ref_OutKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ref Keywordü
            /*
                Referansın kısaltmasından gelir.
                Referans, OOP kavramıdır.
                OOP'de nesneler(object)'ler RAM'de heap bölgesinde tutulur.
                OOP'de referanslar = operatörü ile 
                Değer türlü değişkenlerde, referans operasyonları yapmamızı sağlar.
                ref keywordu, değer türlü değişkenlerin referansını çağırmamızı sağlar.
                Değer türlü değişkenlerde shallow copy yapmamızı sağlar.
             */

            int a = 5;
            ref int b = ref a;
            a = 7;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("-----------------------");
            int c = 10;
            X(ref c);
            Console.WriteLine(c);
            

            void X(ref int x)
            {
                x = 25;

            }

            #endregion

            #region Ref Returns
            /*
             Sadece metotlarda kullanılır. Referans geri döndürmeyi sağlar.
             Metotlar geriye değer döndürebilen yapılardır. Ayrıca Nesne de döndüreibliyoruz
             Ref Returns ile değer türlü değişkenlerin referanslarını da geriye döndürebiliriz.
             
             */
            int s1 = 5;
            int s2 = SayıDondur(ref s1);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            ref int SayıDondur(ref int d)
            {
                d = 25;
                return ref d;
            }

            Console.WriteLine("----------");
            int s3 = 5;
            int s4 = SayıDondur2(s3);

            Console.WriteLine(s3);
            Console.WriteLine(s4);

             int SayıDondur2(int d)
            {
                d = 25;
                return d;
            }

            #endregion

            #region out keyword 
            //Metodların parametreleri üzerinden dışarıya değer göndermemizi sağlarlar.
            //Bir metodun parametreleri varsayılan INPUT'tur.
            //Eğer ki bir metodun parametresi dışarıya değer çıkaracak ise out ile işaretlenmeli.
            //Bir metot out parametre barındırıyorsa o parametrelere kendi içinde değer atanmak zorundadır.
            //Output parametre barındıran bir metodu kullanırken, out parametrelerden gelecek olan değerleri karşılayacak değerler tanımlanmalı.
            //out parametreleri karşılayacak olan değişken verilirken başına out ile işaret konmalı. yoksa input algılanır
            #region Kullanım 1
            int _b;
            string _d;
            int say1 = Say(out _b, 123, out _d);
            #endregion
            #region Kullanım 2
            int say2 = Say(out int _j, 123, out string _l);
            #endregion
            Console.WriteLine(_b);
            Console.WriteLine(_d);
            Console.WriteLine(_j);
            Console.WriteLine(_l);
            int Say(out int b,int c, out string d)
            {
                b = 29;
                d = "Enes";
                return 0;
            }

            #endregion

            #region TryParse

            string text = "123";
            //int r = int.Parse(text);
            bool donduMu = int.TryParse(text,out int cevir);
            if (donduMu)
            {
                Console.WriteLine($"Tür Dönüştürüldü = {cevir}");
            }
            else { Console.WriteLine("ilgili tür uygun değil"); }
            

            #endregion

        }
    }
}
