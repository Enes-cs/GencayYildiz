namespace TürDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metinsel İfadelerin Dönüşümü
            //Tür Dönüşümlerinde dikkat edilecek tek husus dönüşüm yapılacak veririnin türüne uygun hedef bir tür belirlenmelidir.
            #endregion

            #region Parse Fonksiyonu
            //Parse methodu sadece string dataları hedef türe dönüştürürken kullanılır.
            //string x = "123";
            //int x2 = int.Parse(x);
            //Console.WriteLine(x2 * 2);

            //string medeniHal = "True";
            //bool medenihal2 = bool.Parse(medeniHal);
            //Console.WriteLine(medenihal2);

            //string x3 = "ab";
            //char x4 = char.Parse(x3); //Runtime'da hata verecek çünkü char 2 karakter tutamaz.
            #endregion

            #region Convert Fonksiyonu
            //string a = "25";
            //int a2 = Convert.ToInt32(a); //Parse fonksiyonundaki herşey bunda da geçerli

            //string b = "3,14";
            //double b2 = Convert.ToDouble(b);
            //Console.WriteLine(b2 * 500);

            #endregion

            #region Diğer İfadelerin Metinsel İfadelere Dönüştürülmesi
            #region Convert Fonksiyonu
            //bool medeniHal = true;
            //string medeniH4l = Convert.ToString(medeniHal);
            //Console.WriteLine(medeniH4l);
            //#endregion

            //#region ToString Fonksiyonu
            //float f = 35;
            //string f2 = f.ToString();

            #endregion
            //Bool dönüşümlerde sadece 0 false'dur geri kalan tüm sayılar True'dur
            #endregion

            #region ASCII to int
            char x = 'E';
            int _x=(int)x; //Cast İşlemi
            Console.WriteLine(_x);

            int oascii = 111;
            int Oascii = 79;
            char _oascii=(char)oascii; //Cast işlemi
            char _Oascii=(char)Oascii;
            Console.WriteLine(_Oascii);
            Console.WriteLine(_oascii);
            #endregion
        }
    }
}
