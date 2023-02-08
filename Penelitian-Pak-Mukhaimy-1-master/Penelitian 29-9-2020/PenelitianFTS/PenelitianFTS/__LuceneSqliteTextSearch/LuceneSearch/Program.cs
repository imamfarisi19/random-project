using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneSearch
{
    class Program
    {
        static string luceneDir = "C:/lucene_index/";

        static void AddAll2Index()
        {
            
            string beritaDir = "C:\\Work2020\\Penelitian Ringan\\RssBpost\\RssBpost\\bin\\Debug\\";
            DirectoryInfo d = new DirectoryInfo(beritaDir);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files

            LuceneOperation.TestLuceneDirectory(luceneDir);
            foreach (FileInfo file in Files)
            {
                Console.WriteLine( file.Name);
                string filepath = beritaDir + file.Name;
                var beritaDataSet = Models.BeritaDataSet.FromFile(filepath);
                LuceneOperation.AddFromBerita(luceneDir, beritaDataSet.Berita.ToList());
            }

            //string folder1 = @"C:\Work2020\Penelitian Ringan\RssBpost\RssBpost\bin\Debug\";
            //string filename = "bpost_140303_0450.xml";

        }

        static void TestCari()
        {
            string[] cari = new string[] { "tala", "olivia", "liburan", "iwan fals", "hiburan" };
            foreach (var item in cari)
            {
                Console.WriteLine("Kata dicari:  " + item);
                List<Models.LuceneSearchResult> hsl = LuceneOperation.Search(luceneDir, item);
                foreach (Models.LuceneSearchResult itemHsl in hsl)
                {
                    Console.WriteLine(itemHsl.Judul + " >>>   " + itemHsl.IsiRingkas);
                }
                Console.WriteLine("  _______________________");
            }
            
        }

        static void Main(string[] args)
        {
            // AddAll2Index();
            TestCari();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  --- FINISH");
            Console.ReadKey();
        }
    }
}
