namespace Recursive__Tekrarlamalı_Özyinelemeli__Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Recursive Fonksiyon : Kendi içerisinde kendisini çağıran fonksiyonlardır.
            * Recursive Fonksiyon Bir Yaklaşımdır!
            
            Hangi Amaçla Kullanılır?
            * Ön Görülemeyen, derinliği tahmin edilemeyen durumlarda.
            * Sonu bilinmeyen durumlarda tercih edilebilir.
            
            */

            X();
            //Derinliğe inersin sonra geri gelirsin. Thread'de Dünya 3 defa bekleyip sonda art arda patladı.
            void X(int a = 1)
            {
                Console.WriteLine("Merhaba");
                if (a < 3)
                {
                    X(++a);
                }

                Console.WriteLine("Dünya");
            }
            #region Örnek 1
            //Döngülerin kullanıldığı her yerde recursive kullanılır. ancak recursive kulanılan her yerde döngü kullanılamaz. Döngü tahmin edilebilir. Recursive derinliğe iner öngörülemez.
            // Belirli değer aralığındaki 5in katı olan tüm sayıları toplayan recursive fonksiyonu yazalım.
            Console.WriteLine(Topla(100,200));

            int Topla(int basla, int bitir)
            {
                if (basla!=bitir)
                {
                    
                    basla += 5;
                    Topla(basla, bitir);

                }
                return basla; 
            }
            #endregion

        }
    }
}
