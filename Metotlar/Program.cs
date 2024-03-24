namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Notlar
            /*

            Bir yazılım içerisinde iş-işlem-operasyon gerçekleştirmeye yarayan en küçük kod parçacığıdır.
            Kod içinde tekrarları ortadan kaldırır.
            İçerisine yazılan kodun, tekrarlı bir şekilde kullanılmasını sağlarlar.
            Kaynak kodun tekrar etmesini engelleyerek ideal kodlamaya erişim sağlarlar.
            
            Prensip olarak Bir Metot 1 İş Yapmalıdır.

            Main Metodunun içerisinde kullanabilmek için ***********static*********** olması gerekir

            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = new Random().Next(7,44);
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i}.Eleman = {sayilar[i]}");
            }
           ******************************************************************************************************************************************************
           *|-------------------------------------------------------------------------------------------------------------------------------------------------- *                                                                                          |
           *|                                                                                                                                                 | *
           *|  Erişim Belirleyicileri : Access Modifier yapılarıdır. Oluşturulmuş olan bir yapının dışarıdan erişilip erişilmeyeceğini belirleyen komutlardır.| *
           *|  Public: Erişilsin                                                                                                                              | *
           *|  Private: Erişilmesin/Gizli Default Değerdir.                                                                                                   | *
           *|                                                                                                                                                 | *
           *|  Geri Dönüş Değeri : Metotlar yaptıkları operasyonlar neticesinde geriye değer dönebilmektedir.                                                 | *
           *|  Bu değer kodun içerisinde yakalanabilir ve programatik olarak işleme tabii tutabilirler.                                                       | *
           *|  Geri dönüş değeri ekran çıktısıyla karıştırılmamalı.                                                                                           | *
           *|                                                                                                                                                 | *
           *|  Metot Adı: Programatik kurallar geçerlidir.                                                                                                    | *
           *|                                                                                                                                                 | *
           *|  Parametre parantezi: Dış dünyadan parametreleri almamızı sağlar. İllaki almak zorunda değildir. Ancak alacaksa                                 | *
           *|  tür belirtmek zorunludur. (int sayi1) ya da (int sayi1, int sayi2)                                                                             | *
           *|                                                                                                                                                 | *
           *|  {}: Scope operasyonların yazıldığı yerdir.                                                                                                     | *
           *|                                                                                                                                                 | *
           *|  (    M    E    T    O    D    '    U     N       İ    M    Z    A    S   I )                                                                   | *
           *|  [Erişim Belirleyicisi] [Geri Dönüş Değeri] [Metot Adı] (Metodun Parametresi)                                                                   | *
           *|     Public - Private            void            Main             ()                                                                             | *
           *|  { SCOPE AÇ                                                                                                                                     | *
           *|                                                      |------------------------------------------------------------------------------------------| *
           *|  METODUN GÖVDESİ                                     |*********************************************************************************************
           *|                                                      |*
           *|  } SCOPE KAPAT                                       |*
           *|                                                      |*
           *|                                                      |*
           *|                                                      |*
           *|   4 Farklı Şekilde Metot oluşturulabilir.            |*
           *|                                                      |*
           *|   1. Geriye Değer Döndürmeyen, Parametre Almayan     |*
           *|   2. Geriye Değer Döndürmeyen, Parametre Alan        |*
           *|   3. Geriye Değer Döndüren, Parametre Almayan        |*
           *|   4. Geriye Değer Döndüren, Parametre Alan           |*
           *|                                                      |*
           * ------------------------------------------------------|*
           **********************************************************
           */
            #endregion


            #region Tanımlanmış Metodun Kullanımı
            //Tetikleme - Çağırma - Kullanım

            // İsminin çağrılması yeterlidir.
            //Main static bir metot olduğu için içerisinde çağrılan metodun da static olması gerekir.


            Metot();

            #endregion
            #region Tanımlandığı Sınıf İçerisinde Kullanımı
            Ornek ornek=new Ornek();
            ornek.A(); //Ornek Class'ı içerisinde örneklendirilmiştir.

            #endregion
            #region Başka Sınıflarda Kullanımı

            Matematik matematik = new Matematik();
            matematik.Topla(3, 5);
            

            #region Referans ve Nesne konularına temas
            /*
            Class: Yeryüzündeki herhangi bir olguyu modellememizi sağlayan yapılanma. 
            İçerisinde olguya dair verisel alanları (field) barındıran ve bu alanlar üzerinde işlem yapmamızı sağlayacak olan
            metotları barındıran bir yapıdır.
            Class class = new Class(); => Sol taraf Referanstır. Sağ Taraf Nesnedir. =(Referans etme operatörü)
            Nesne: Class'tan üretilen değer/veri.
            Referans: Nesneyi kullanmamızı sağlayan yapı.
             */


            #endregion
            #endregion

        }
        static void Metot() { }
        /*
          ( M    E    T    O    D    '    U     N       İ    M    Z    A    S   I ) 
         [Erişim Belirleyicisi] [Geri Dönüş Değeri] [Metot Adı] (Metodun Parametresi)
        {
            METOT GÖVDESİ
        }
        
        Tanımlama Parametrede yapılıyorsa "Parametre" denir.
        Tanımlama Class'da yapılıyorsa "Field" denir.
        Tanımlama bunlar dışında yapılıyorsa genellikle "Değişken" denir.
         
         */


        #region Geriye Değer Döndürmeyen, Parametre Almayan

        //Bir metot geriye değer döndürmüyorsa bunu void ile bildiriyoruz.
        //Parantezi boş bırakarak parametre almadığını bildiriyoruz.
        private void Metot1()
        {
            Console.WriteLine("Geriye Değer Döndürmeyen Parametre Almayan Metot Oluşturuldu.");
        }

        #endregion

        #region Geriye Değer Döndürmeyen, Parametre Alan

        private void Metot2(int sayi)
        {
            int sonuc = sayi * 10;
            Console.WriteLine($"Girilen Sayının 10 Katı: {sonuc}");
        }

        private void Metot3(int sayi, bool b)
        {
            //Parametredeki değerler içeride kullanılabilir.
        }

        private void Metot4(int sayi, bool b, char c)
        {

        }

        #endregion

        #region Geriye Değer Döndüren, Parametre Almayan
        // Eğer bir metotun geriye değer döndüreceğini bildiriyorsak. Mutlaka geriye değer döndürmelidir. Aksi takdirde hata verir.
        //return keywordu bildirilen türde değer döndürmemizi sağlar.
        //return metodu sonlandırır.
        //Koşul içinde return kullanıyorsan dışında da kullanmak zorundasın.
        private string Metot5()
        {
            return "GeriyeDönenDeğer";
        }

        private int Metot6()
        {
            if (DateTime.UtcNow.Second > 10)
            {
                return 5;
            }
            return 10;
        }


        #endregion

        #region Geriye Değer Döndüren, Parametre Alan

        public bool Metot7(int x)
        {

            x = 0;

            return true || false;
        }

        public int Metot8(int x)
        {

            x = 0;

            return DateTime.Now.Minute > 30 ? 1 : 0;
        }

        #endregion

        
    }

    class Ornek
    {
        public void A()
        {
            B();
        }

        private void B()
        {
            C(5);
        }

        private int C(int a)
        {
            return a;
        }
    }

    class Matematik
    {
        public int Topla(int s1,int s2) 
        {
            return s1+s2;
        }
        public int Cıkar(int s1, int s2)
        {
            return s1 - s2;
        }
        public int Carp(int s1, int s2)
        {
            return s1 * s2;
        }
        public double Bol(int s1, int s2)
        {
            return s1 / s2;
        }

    }
}