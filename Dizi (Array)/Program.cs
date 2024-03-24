using System.Collections;

namespace Dizi__Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tek bir değişken altında birden fazla "aynı türde" değeri tanımlamamızı sağlayan veri kümeleri dizidir.
            //Prosedurel programlamanın temel veri kümeleridir. Yani yazılımsal boyutta yazılım adına RAM'de birden fazla değeri tek bir değişken altında bir veri kümesi halinde tutabilirler.
            //Diziler, veri kümeleri oldukları için, içlerinde birden fazla veri üzerinde kümesel işlemler yapmamızı sağlarlar.
            //prosedurel programlamanın temel yapıları oldukları için daha gelişmiş yapılar olan koleksiyonlarında temelini teşkil etmektedirler.

            //Diziler "REFERANS TÜRDÜR" Yani nesnel yapılardır, özünde classtır.
            //Diziler index kavramını programlamaya getirmiştir. Bunlar RAM'e sıralı depolanacaktır. İndex ismini verdiğimiz numaralar ile ardışık bir şekilde numaralandırılır.
            //index 0'dan başlar n-1'E kadar gider. n elemanlı bir dizide.

            //PROTOTIP
            //int[] ogrenci;
            // type[] name = new type[Eleman Sayısı] => Dizi   [] = indexer operatörü bir türün yanına gelirse o türde bir dizi değişkeni olacaktır.

            DizilerGiris();

            static void DizilerGiris()
            {
                return;
                int[] yaslar = new int[70]; //Eleman sayısı kesinlikle belirtilmelidir. 0 verilebilir. Bu bir sınırlılıktır.
                                            //Bir dizi tanımlaması yapıldığı an bellekte o dizi kullanılsa da kullanılmasa da verilen eleman sayısı kadar alan tahsisinde bulunulur.
                                            // dizilerde alan tahsisi yapıldığında default değeri verecektir.
                                            //dizilere değer atarken index numaraları kullanılır. Her bir elemana karşılık gelen unique değerlerdir.
                                            //dizinin içerisindeki elemanlara değer atarken değişken davranışı gösterir.
                                            //Dizilerde değer atama ve okuma işlemlerinde sınır aşılmamalı. 


                yaslar[20] = 627910;
                yaslar[5] = 123;
                yaslar[12] = 57;
                yaslar[33] = yaslar[5];
                yaslar[5] = 43;


                Console.WriteLine(yaslar[5] + " " + yaslar[33]);

                //Dizi İçerisinde Döngü ile Dönme

                string[] personeller = new string[10];
                personeller[0] = "Fırat";
                personeller[1] = "Recep";
                personeller[2] = "Kemal";
                personeller[3] = "İsmail";
                personeller[4] = "Tevfik";
                personeller[5] = "Nejdet";
                personeller[6] = "Osman";
                personeller[7] = "Can";
                personeller[8] = "İlker";
                personeller[9] = "Mert";

                for (int i = 0; i < personeller.Length; i++)
                {
                    Console.WriteLine(personeller[i]);
                }
                Console.WriteLine("--------------------");
                int j = 0;
                do
                {
                    Console.WriteLine(personeller[j++]);
                } while (j < personeller.Length);

                Console.WriteLine("--------------------");

                int k = 0;
                while (k < personeller.Length)
                {
                    Console.WriteLine(personeller[k++]);
                }

                Console.WriteLine("-----------");


            }

            Varyasyonlar();

            static void Varyasyonlar()
            {
                //Tanımlama varyasyonları
                return;
                int[] enesler = new int[2];
                enesler[0] = 1;
                enesler[1] = 2;

                Console.WriteLine("------1. Varyasyon----------");
                int[] enesler2 = { 1, 2, 3, 4, 5, 6, }; //Eleman sayısını bu tanımlama ile yazar.

                Console.WriteLine("----2. Varyasyon----------");
                int[] enesler3 = new int[] { 1, 2, 3, 4, 5, 6, };

                Console.WriteLine("---3.Varyasyon-----------");
                int[] enesler4 = new int[3] { 1, 2, 3 };  //Eleman sayısı verirsen mecbur verdiğin sayı kadar girmelisin

                Console.WriteLine("------Hindistan Varyasyon--------");
                var enesler5 = new[] { 1, 2, 3 }; //Hindistan Tarzı.
            }

            #region Array Sınıfı

            //Dizi olarak tanımlanan değişkenler Array sınıfından türetilmektedirler.
            //Array sınıfından gelen belirli metot ve özellikler mevcuttur.

            Array yaslar = new Array[] { };
            Array maaslar = new Array[5];

            int[] enesler = new int[5];     //indexer operatörü kullanılabilir - Genellikle Algoritmalarda tercih edilir.

            Array enesler2 = new int[5];    //indexer operatörü kullanılamaz - Genellikle elimizdeki dizin hakkında bilgi almak için

            //Değer Atama 1.Yöntem

            int[] _dizi = new int[3];
            _dizi[0] = 1;
            _dizi[1] = 2;
            _dizi[2] = 3;

            Array dizi = new int[3];

            dizi = _dizi;

            Array dizi3 = _dizi;


            //2.Yöntem

            Array array = new int[] { 3, 5, 7 };
            Array array2 = new int[3] { 3, 5, 7 };
            Array array3 = new[] { 3, 5, 7 };

            //3.Yöntem
            Array __dizi = new int[3];
            __dizi.SetValue(30, 0); // => SetValue(değer,index) değer verme
            object value = __dizi.GetValue(0);
            Console.WriteLine(value);
            int tut = (int)value;
            Console.WriteLine("unboxing ettik: " + tut);
            #endregion

            //Metodlar
            #region Clear Metodu

            //Dizinin elemanlarına uygun default değerleri atar.

            Array isimler = new[] { "Fırat", "Recep", "Kemal" };
            foreach (var i in isimler)
            {
                Console.WriteLine(i); //For ile dönmek için getvalue'yi kullan
            }
            Array.Clear(isimler, 0, 2); // isimler dizisinin 0. elemanından 2. elemanına kadar default yap Clear(arrayName,index to, index)
            Console.WriteLine("--------------");
            foreach (var i in isimler)
            {
                Console.WriteLine(i);

            }
            #endregion
            #region Copy Metodu Bütün özellikleri ile çoğaltmak klonlamaktır. Başka diziye vermek kopyalamaktır.

            Array kaynak = new string[10] { "Fırat", "Recep", "Kemal", "İsmail", "Tevfik", "Nejdet", "Osman", "Can", "İlker", "Mert" };

            Array hedef = new string[10];

            Array.Copy(kaynak, hedef, kaynak.Length); //Copy(kaynak dizi, hedef dizi, index sayısı)
            foreach (var i in hedef) { Console.WriteLine(i); }
            Console.WriteLine("----------");
            Array.Copy(kaynak, 2, hedef, 0, 4); //Copy(kaynak dizi, kaçıncı indexten itibaren kopyalanacak, hedef dizi, kaçıncı indexten itibaren yapıştırılacak,index sayısı)


            foreach (var i in hedef) { Console.WriteLine(i); }
            #endregion
            #region IndexOf Metodu => Arama metodu

            Console.WriteLine(Array.IndexOf(kaynak, "Enes")); //=> Kaynak dizisinde Enes varsa index numarasını döndürür. yoksa -1 döndürür.

            Array.IndexOf(kaynak, "Fırat", 0, 2); // kaynak dizisinde fırat değerini 0. indexten 2.index'e kadar ara
            #endregion
            #region Reverse Metodu => Elimizdeki dizinin elemanlarını tersine sıralar
            Console.WriteLine("---------------");
            Array.Reverse(kaynak); //Direkt terse çevirir
            foreach (var i in kaynak)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------");
            Array.Reverse(kaynak, 0, 4);//şurdan şurayı çevir
            foreach (var i in kaynak)
            {
                Console.WriteLine(i);
            }
            #endregion
            #region Sort Metodu => Sıralama yapar 
            Console.WriteLine("--------------");
            for (int i = 0; i < kaynak.Length; i++)
            {
                Console.WriteLine(kaynak.GetValue(i));
            }

            Array.Sort(kaynak); //Alfabetik Sıraladık

            Console.WriteLine("--------------");
            for (int i = 0; i < kaynak.Length; i++)
            {
                Console.WriteLine(kaynak.GetValue(i));
            }
            #endregion
            #region CreateInstance Metodu ile Dizi Tanımlama ve Çok Boyutlu Dizi Tanımlama

            int[] uc = new int[3]; //Bu dizi tanımlaması aşağıdaki kodu çalıştırır.
            Array _uc = Array.CreateInstance(typeof(int), 3); //Tipi ve Kaç elemanlı olacağını parametre olarak giriyoruz.


            Array cokBoyut = Array.CreateInstance(typeof(int), 3, 4, 5, 7); //Çok Boyutlu
            #endregion

            //Proplar
            #region IsReadOnly

            Console.WriteLine("ReadOnly Mi " + kaynak.IsReadOnly);

            #endregion
            #region IsFixedSize
            Console.WriteLine("FixedSize mı? Eleman Sayısı Sabit mi : " + kaynak.IsFixedSize);
            #endregion
            #region Length
            Console.WriteLine("Uzunluğu: " + kaynak.Length);
            #endregion
            #region Rank
            int[,,] x = new int[3, 4, 5];
            Console.WriteLine("Rank: Dizinin Derecesi: " + x.Rank);
            Console.WriteLine("Rank: Dizinin Derecesi: " + kaynak.Rank);
            #endregion


            //C# 8.0 Rages and Indices (System.Index - System.Range - .. - ^ )

            #region System.Index
            //System.Index Dizi ve koleksiyon yapılarındaki index kavramını tip olarak belirlenmiş halidir.
            //Temelde index değerini bir tür ile tutmakla beraber ^ operatörüyle birlikte daha fazla anlam
            //ifade etmekte ve dizinin index değerlerini tersine ifade edecek şekilde bir sorumluluk yüklenmiştir.
            //Index türü soldan sağa 0'dan başlar ^ bununla beraber sağdan sola 1'den başlar.

            string[] ad = { "Enes", "İlker", "Sülo" };
            Index index = 1; //Soldan sağa 0-1 ilker
            Console.WriteLine(ad[index]);
            Index index2 = ^2; //Sağdan sola 1-2 ilker
            Console.WriteLine(ad[index2]);
            #endregion
            #region System.Range
            //Dizi üzerinde hangi değer aralığı ile çalışmak istediğimizi index üzerinden bildirmemizi sağlar.
            // operatörü ile çalışır.
            //Range range = 3..7 => 3 index numarasıdır. 7 Sıra numarasıdır bu aralıktaki veriler bir diziymiş gibi getirilir. eğer ^7 kullanılırsa bir sonrakine geçer.
            //indexer operatörü içerisinde range kullanılaiblir [range]


            #endregion
            #region Ranges and Indices
            ////////sıra      1  2  3  4  5  6  7    8   9    10    11   12  13
            int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
            ////////index     0  1  2  3  4  5  6    7    8    9    10   11  12

            //2 ile 5643 arasını getir.

            Range besileon = 5..10; //veya ^8..^3 
            var sayilar2 = sayilar[besileon];
            Console.Write("SystemRange    ");
            foreach (int i in sayilar2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            /////KENDİ YAPTIĞIM RANGE

            int[] bes = new int[5];
            int k = 0;
            for (int i = 5; i < 10; i++)
            {

                bes[k++] = sayilar[i];

            }
            Console.Write("MyRange        ");
            foreach (var i in bes)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            /////KENDİ YAPTIĞIM RANGE



            //tumdiziyi getir
            Console.WriteLine();
            Index i1 = 1, i2 = 5;
            Range tumdizi = ..;
            Range indexerKullan = i1..i2;  //index türü de kullanabiliriz.
            int[] sayilar3 = sayilar[tumdizi];

            foreach (int i in sayilar3)
            {
                Console.Write(i + " ");
            }

            #endregion
            #region ^ Operatörü

            //Dizinin sonuncu elemanına rahatça ulaşmak için kullanıyoruz.
            //Bu operatörü sadece index ve range türünde kullanabiliyoruz.

            #endregion


            //Çok Boyutlu/Biçimli/Dereceli Diziler

            // CokBoyutluDiziler();

            static void CokBoyutluDiziler()
            {
                //Tek boyutlu dizi x doğrusu olarak düşünülebilir.
                //İki Boyutlu Diziler x ve y doğrusu olarak düşünülebilir.
                //Üç boyutlu Diziler x, y ve z doğrusu olarak düşünülebilir.
                //Genellikle oyun programlamada, yüksek istatistik çalışmalarda kullanılır.

                int[,] ikiboyut = new int[1, 2];
                int[,,,] cokboyut = new int[13, 16, 17, 18]; //4 Boyutlu DİZİ

                int[,] bsayilar = new int[3, 4];
                bsayilar[1, 2] = 5; //1. Satır , 2. Sütun 
                bsayilar[2, 0] = 15; //2.Satır, 0. Sütun

                int[,,,] say4lar = new int[2, 3, 4, 5]; //2*3*4*5 = Eleman sayısı tüm boyutların eleman sayılarının çarpımına eşittir.

                say4lar[0, 0, 0, 0] = 15;
                say4lar[0, 0, 0, 1] = 16;
                say4lar[0, 0, 0, 2] = 17;
                say4lar[0, 0, 0, 3] = 18;
                say4lar[0, 0, 0, 4] = 19;
                say4lar[1, 0, 0, 0] = 20;
                Console.WriteLine();
                Console.WriteLine("Say4lar Uzunluğu = " + say4lar.Length);
                Console.WriteLine("4. Derecenin Eleman Sayısı= " + say4lar.GetLength(3));

                for (int i = 0; i < say4lar.GetLength(0); i++)
                {
                    for (int j = 0; j < say4lar.GetLength(1); j++)
                    {
                        for (int h = 0; h < say4lar.GetLength(2); h++)
                        {
                            for (int l = 0; l < say4lar.GetLength(3); l++)
                            {
                                Console.Write(say4lar[i, j, h, l] + "    ");
                            }
                            Console.WriteLine(" ");
                        }

                    }
                }

                int[,,] say3lar = new int[2, 3, 4];
                say3lar[0, 0, 1] = 15; //3 Boyutlu bir küp düşünerek z düzleminin 1.indexine değer verdik 
                say3lar[1, 2, 3] = 5; //X Düzleminin 1. Y Düzleminin 2. Z Düzleminin 3.  indexine değer verdik.

                int[,] cift =
                {
                {3,5,7 }, //Burası 3 kolon olduğu için sonrası 'da 3 kolon olmak zorunda
                {4,5,9 },
                {43,54,95 },
                {41,522,93 }
            };

                Console.WriteLine(cift[0, 0]);
                Console.WriteLine(cift[0, 1]);
                Console.WriteLine(cift[0, 2]);
                Console.WriteLine(cift[1, 0]);
                Console.WriteLine(cift[1, 1]);
                Console.WriteLine(cift[1, 2]);
                Console.WriteLine(cift[2, 0]);
                Console.WriteLine(cift[2, 1]);
                Console.WriteLine(cift[3, 2]);
                Console.WriteLine(cift[3, 0]);
                Console.WriteLine(cift[3, 1]);
                Console.WriteLine(cift[3, 2]);
                Console.WriteLine("-------------------");
                Console.WriteLine(cift.Rank);

                int[,,,] dort = // Böyle kullanım var ama 4 dereceli dizi  kullanmak zor iş
                {
                {
                    {
                        {0,1,2 }
                    }
                },
                {
                    {
                        {0,10,20 }
                    }
                },
                {
                    {
                        {0,21,32 }
                    }
                }
            };
            }

            DuzensizDiziler();

            static void DuzensizDiziler()
            {
                //Düzensiz Diziler
                // Her bir elemanı kendi içerisinde farklı bir dizi barındıran dizilerdir.
                //Çok boyutlu dizilerde Sütun sayısı sabittir. Ancak Dizi içerisinde dizi tanımlama operasyonlarında sütun sayısı sabit olmak zorunda değildir.

                int[][] duzensiz = new int[3][]; //int dizisi türünden dizi tanımladık

                //duzensiz[0][0] = 1;
                //duzensiz[0][1] = 2;
                //duzensiz[0][2] = 3;
                //duzensiz[0][3] = 4;
                //duzensiz[1][0] = 5;
                //duzensiz[1][1] = 6;
                //duzensiz[1][2] = 7;
                //duzensiz[1][3] = 8;
                //duzensiz[1][4] = 9;
                //duzensiz[1][5] = 10;
                //duzensiz[1][6] = 11;
                //duzensiz[1][7] = 12;
                //duzensiz[2][0] = 13;
                //duzensiz[2][1] = 14;
                //duzensiz[2][2] = 15;
                //duzensiz[2][3] = 16;
                //duzensiz[2][4] = 17;
                //duzensiz[2][5] = 18;
                //duzensiz[2][6] = 19;
                //duzensiz[2][7] = 20;
                //duzensiz[2][8] = 21;
                //duzensiz[2][9] = 22;
                //duzensiz[2][10] = 23;

                duzensiz[0] = new int[3] { 3, 5, 7 };
                duzensiz[1] = new int[5] { 546, 784, 8754, 123, 1243 };
                duzensiz[2] = new int[10] { 2, 5, 9, 88, 54, 2, 554, 31, 54, 545 };

                Console.WriteLine(duzensiz[0][2]);
                Console.WriteLine(duzensiz.Length); //Düzensiz dizinin eleman sayısını getirir. Bu bize total eleman sayısını vermez. Çok boyutlu dizilerde olduğu gibi düzensiz
                                                    //diziler başlı başına farklı bir dizi yapısı değildir. Normal dizi yapılmasıdır. Lakin içerisinde dizi barındıran bir dizidir. Eleman sayısını döndürür.
                                                    //İçteki dizilerin eleman sayılarını totalde elde edebilmek için herbirini toplamamız gerekmektedir. örneğin 18 tane'dir 3+5+10

                int toplam = duzensiz[0].Length + duzensiz[1].Length + duzensiz[2].Length;
                Console.WriteLine(toplam);

                for (int i = 0; i < duzensiz.Length; i++)
                {
                    for (int j = 0; j < duzensiz[i].Length; j++)
                    {
                        Console.Write(duzensiz[i][j] + "   -   ");
                    }
                    Console.WriteLine("");
                }
            }
        }


    }
}
