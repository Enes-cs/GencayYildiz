using Microsoft.Extensions.Primitives;
using System.Text;
namespace Dizilerde_Verisel_Performans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Performanslı çalışmak için ArraySegment ve StringSegment Türleri Geliştirilmiştir.

            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] sayilar2 = sayilar[2..5];
            sayilar2[0] = 32;
            #region ArraySegment Nedir?
            //Bir dizinin bütününden ziyade bir kısmını kopyalamak yerine bağımsız bir referans ile erişmemini sağlayan yapıdır.

            ArraySegment<int> segment = new ArraySegment<int>(sayilar);
            ArraySegment<int> segment1 = new ArraySegment<int>(sayilar, 2, 5);
            segment1[0] = 31;
            segment[3] = 41;

            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region ArraySegment Slicing (Dilimleme)
            
            //Bir dizi üzerinde birden fazla parçada çalışıalacaksa eğer her bir parçayı ayrı bir ArraySegment olarak tanımlayabiliriz.
            //Bu tanımlamaların dışında diziyi tek bir Array segment ile referans edip ilgili parçaları o segment üzerinden talep edebiliriz.
            //Kodun gelişimi açısından efektiflik kazandırır.
            ArraySegment<int> ne = new ArraySegment<int>(sayilar[^5..]);
            ArraySegment<int> dilimli = ne.Slice(0, 3);
            foreach (int i in ne)
                Console.WriteLine(i);



            #endregion

            #region StringSegment Nedir?
            //Kullanabilmek için Microsoft.Extensions.Primitives paketinin yüklenmesi gerek.
            //ArraySegment'in String değerler nezdindeki bir muadilidir.
            //Metinsel değerlerdeki bir çok analitik operasyondan bizi kurtarır substring vs. gibi fonksiyonlar yerine hedef kesit üzerinde işlem yapmamızı sağlayan bir türdür.
            string text = "Ölüme gidelim dedin de mazot yok mu dedik.";
            Console.WriteLine(text.Substring(14, 5));

            StringSegment strSegment = new StringSegment(text);
            StringSegment strSegment2 = new StringSegment(text,14,5);
            strSegment2=text.Replace("dedin", "DEDİN");
            Console.WriteLine(strSegment2);
            Console.WriteLine(text);



            #endregion

            #region StringBuilder Sınıfı

            string isim = "İbrahim Enes";
            string soyisim = "ÖZBAY";
            //+ operatörüne nazaran yüksek maliyeti absorbe edebilmek için string segment algoritmasını kullanan ve bu algoritma ile bizlere ilgili değerleri 
            //olabilecek en az maliyetle birleştirip döndüren bir sınıftır.

            StringBuilder builder = new StringBuilder();
            builder.Append(isim);
            builder.Append(" ");
            builder.Append(soyisim);
            Console.WriteLine(builder);



            #endregion

            #region Span Türü

            Span<int> span = new Span<int>(sayilar);
            Span<int> span2 = sayilar;
            Span<int> span3 = new Span<int>(sayilar,3,5);
            Span<int> span4 = sayilar.AsSpan();
            Span<int> span5 = sayilar.AsSpan(3, 5);

            #endregion
        }
    }
}
