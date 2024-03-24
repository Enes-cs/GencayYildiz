using System.Collections.Generic;
using System.IO;

namespace RecursiveMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BesKTopl();

            static void BesKTopl()
            {
                Console.Write("İlk Sayı: ");
                int basla = int.Parse(Console.ReadLine());
                Console.Write("İkinci Sayı: ");
                int bitir = int.Parse(Console.ReadLine());
                int sonuc = 0;
                int kalan = (basla + 5) % 5;
                int besK = basla - kalan;

                int Topla(int basla, int bitir)
                {

                    if (besK != bitir + 5)
                    {
                        sonuc += besK;
                        besK += 5;
                        Topla(basla, bitir);
                    }
                    return sonuc;
                }
                int netice = Topla(basla, bitir);
                Console.WriteLine($"{basla} ve {bitir} arasındaki 5'in Katları Olan Sayıların Toplam Sonucu = {netice}");


            }

            //Dosyalaribul();

            static void Dosyalaribul()
            {
                List<FileInfo> files = DosyaYazdir("C:\\Riot Games\\VALORANT\\live".Replace("\\", "/"));
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.FullName);
                }



                List<FileInfo> DosyaYazdir(string path)
                {
                    List<FileInfo> fileInfos = new();
                    DirectoryInfo directoryInfo = new(path);
                    DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
                    if (directoryInfos.Any())
                        foreach (DirectoryInfo directory in directoryInfos)
                            fileInfos.AddRange(DosyaYazdir(directory.FullName));
                    else
                        fileInfos.AddRange(directoryInfo.GetFiles());
                    return fileInfos;
                }
            }




            List<FileInfo> listele = DosyaBul("C:\\Program Files (x86)".Replace("\\", "/"));

            foreach (var item in listele)
            {
                Console.WriteLine(item);
            }


            List<FileInfo> DosyaBul(string path)
            {
                List<FileInfo> dosyaListesi = new List<FileInfo>();

                DirectoryInfo klasor = new DirectoryInfo(path);
                DirectoryInfo[] klasorler = klasor.GetDirectories();
                if (klasorler.Any())
                {
                    foreach (DirectoryInfo klasorAdi in klasorler)
                    {
                        dosyaListesi.AddRange(DosyaBul(klasorAdi.FullName));
                    }
                }
                else
                {
                    dosyaListesi.AddRange(klasor.GetFiles());
                }


                return dosyaListesi;
            }

        }
    }
}
