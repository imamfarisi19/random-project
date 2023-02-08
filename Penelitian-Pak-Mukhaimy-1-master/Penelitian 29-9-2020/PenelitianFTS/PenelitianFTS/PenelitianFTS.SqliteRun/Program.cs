using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PenelitianFTS.SqliteRun
{
    class Program
    {        
        static readonly string strTextFolder = "textFolder.conf.txt";

        static void T01()
        {
            string textFolder = File.ReadAllText(strTextFolder);
            string[] subdirectoryEntries = Directory.GetDirectories(textFolder, "*_dir");

            // delete all index
            if (File.Exists("FullTextSearch.db"))
                File.Delete("FullTextSearch.db");

            // Loop through them to see if they have any other subdirectories
            TimeSpan t1 = new TimeSpan(0, 0, 0);
            string runStats = "";
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo d = new DirectoryInfo(subdirectory);
                string dirName = d.Name;
                string dirNameShort = dirName.Remove(dirName.Length - 5);
                Console.WriteLine(dirNameShort);
                WriteTestResult writeTestResult = WriteTest(subdirectory);
                runStats += writeTestResult.ToString() + Environment.NewLine;
                t1 = t1 + writeTestResult.LamaKerja;
            }
            runStats += Environment.NewLine;
            runStats += Environment.NewLine;
            runStats += "------------------------------------------------";
            runStats += Environment.NewLine;
            runStats += string.Format($"TOTAL EXECUTION TIME: {t1.TotalSeconds} seconds");


            File.WriteAllText("SqliteRep_" + DateTime.Now.ToString("yyMMdd_hhmm") + ".txt", runStats);
        }

        static WriteTestResult WriteTest(string textFolder)
        {
            WriteTestResult run1 = new WriteTestResult();
            DirectoryInfo d = new DirectoryInfo(textFolder);
            string[] fileEntries = Directory.GetFiles(textFolder, "*.txt");

            string dirName = d.Name;
            string dirNameShort = dirName.Remove(dirName.Length - 5);

            run1.NamaFolder = dirNameShort;
            run1.JumlahFile = fileEntries.Count();

            DateTime t1 = DateTime.Now;


            SqliteFtsOperation op1 = new SqliteFtsOperation();
            foreach (string file in fileEntries)
            {

                string nomor = Path.GetFileName(file).Replace(".txt", "");
                Console.Write(nomor);
                Console.Write("  ");
                BagianBuku bagianBuku1 = new BagianBuku()
                {
                    Id = Guid.NewGuid(),
                    Isi = File.ReadAllText(file),
                    Judul = dirNameShort,
                    NomorBagian = int.Parse(nomor)
                };
                op1.OAdd(bagianBuku1);
            }
            Console.WriteLine();

            TimeSpan ts = DateTime.Now - t1;

            // Console.WriteLine($"TOTAL: {op1.Count()} :: {op1.CountIndex()}");
            run1.LamaKerja = ts;
            return run1;
        }

        static void M01()
        {
            // SqliteFtsOperation op1 = new SqliteFtsOperation();
            // var m = op1.MatchExact("london ship");
            SqliteFtsOperation op1 = new SqliteFtsOperation();
            DateTime t0 = DateTime.Now;
            string[] keys = new string[] { "london", "ship", "london AND ship", "london OR ship", "emma",
                "Treasure Island", "Flint", "Dyak", "Dyaks", "Borneo", "banjar", "Kalamantan", "Kalimantan",
                "\"Sherlock Holmes\"", "Sherlock OR Holmes",
                "Canadian", "Canada",  "\"Air Force\"", "Indonesia", "Malaysia", "Opium", "french" };

            int nloop = 1;
            for (int i = 0; i < nloop; i++)
            {
                Console.WriteLine($"LOOP# {i}");
                foreach (var key in keys)
                {
                    // var m = LuceneOperation.Search(lucenePath, key);
                    var m = op1.MatchExact(key);
                    Console.WriteLine($"{key} \t --> Hit: {m.Count}");
                }
                Console.WriteLine("  ################################################");
            }

            TimeSpan ts = DateTime.Now - t0;
            string runStats = "";
            runStats += "------------------------------------------------";
            runStats += Environment.NewLine;
            runStats += string.Format($"TOTAL EXECUTION TIME: {ts.TotalSeconds} seconds");
            Console.WriteLine(runStats);
        }


        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            M01();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" -- FINISH");
            Console.ReadKey();
        }
    }
}
