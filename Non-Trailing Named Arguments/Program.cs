namespace Non_Trailing_Named_Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            X(3, 5, "abc"); // => Değerleri sıra ile yerleştirmem gerekiyor normalde
            //Sıralamayı Bozmak İstiyorsak Bu Özelliği Kullanırız.

            X(c: "Enes", a: 2, b: 3);

            //Görece çok parametreli fonksiyonlarda bu şekilde göndermek daha rahattır.
           

        }

        static void X(int a, int b, string c)
        {

        }
    }
}
