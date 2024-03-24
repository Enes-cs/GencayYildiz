namespace Metotlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Parametrenin değereini metodun içerisinde herhangi bir yerde çağırıp kullanabiliriz.
            //2. metot içerisinde üretilen herhangi bir değeri tutacak değişken oluşturmak yerine parametre üzerinde değer tutabiliriz.
            #region In Parameters
            //In komutu sayesinde parametreye verilen değer sabit tutulabilir.
            //In komutu metodun parametresini readonly(sadece okunabilir) hale getirir.
            //Eğer ki metot içerisinde değer atamayı denerseniz, derleyici engeller
            X(5,4,3); //=> Metotun kendisine git ve parametrelerine bak. 
            #endregion

            #region Local Functions
            /*
           *Metot içinde tanımlanan metotlardır.
           *Struct, abstract class, interface ve record yapılarında da metot tanımlanabilir. Ancak bunların dışında KESNLİKLE bir yerde tanımlanamazlar.
           *C# 7.0'da gelmiştir.
           *Main fonk. üzerinde tanımlayalım.
           *Erişim belirleyicisi yoktur.

             
                TANIMLAMA KURALLARI
            1- Erişim belirleyicisi yazılmaz.
            2- Local function olarak tanımlanan fonksiyon adı, tanımlandığı fonksiyonunun adından farklı olmalıdır. Derleyici hatası vermez. Ancak sorun yaşatır.
            Metotdun içinde kendisini çağırma yöntemleri vardır. burada karışıklık ortaya çıkarır.

                KULLANIM KURALLARI
            1- Bir local funtion sade ve sadece tanımlandığı metodun içerisinde kullanılır.
            2- Tanımlandığı metodun içerisinde her yerden erişilebilir.Öncesi Sonrası Farketmez.
                
                AMACI
            1- Local function, sadece tek bir metotta tekrarlı bir şekilde kullanılacak bir algoritmayı/kod parçacığını o metoda özel bir şekilde tek seferlik tanımlamamızı ve kullanmamızı sağlar.

             */

            B();

            
            void B()
            {
                A();
                void A()
                {
                    C(3);
                    void C(int x)
                    {
                        Console.WriteLine("Nanik");
                    }
                }
            }




            #endregion

            #region static Local Function

            void Y(int x)
            {
                int y = 0;

                Z(x, y);

                static void Z(int x, int y) //static keyword'ü ile işaretlediğimiz anda x ve y değişkenlerine erişilemez.Bu erişim çok maliyetli olduğu için kaldırmak isteyebiliriz.Parametre ile erişim sağlanabilir.
                {
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                }
            }

            #endregion

            #region Method OverLoading (Çoklu Yükleme)

            Matematik classınaBak = new Matematik();
            //Aynı isimde birden fazla metot normalde tanımlanamaz.
            //Ancak belirli kurallar çerçevesinde tanımlanabilir.Buna da Overloading denir.
            classınaBak.Topla(54,5,62,3,4);
            classınaBak.Topla(3,2);
            
            #endregion

            #region OverLoading Kuralları
            //Metotların parametreleri arasında fark olmalı. Türleri ya da sayıları farklı olmalı.
            #endregion
        }
        static void X(in int a,int b,in int c)
        {
            b = a + 1;
         // c = b + 1; c in keywordü ile işaretli olduğu için hata verir.
        }
 
    }

    class Matematik
    {
        public int Topla(int s1,int s2)
        {
            return s1+s2;
        }
        public int Topla(double s1, double s2)
        {
            
            return (int)(s1+s2);
        }

        public double Topla(params double[] toplanan)
        {
                        
            return toplanan.Sum();
        }
    }
}
