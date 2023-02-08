using System;
using System.IO;

namespace PenelitianFTS.PengolahanBuku
{
    class Program
    {
        static void T01()
        {
            string folder1 = "G:\\Work2020\\Devel\\04\\PenelitianFTS\\buku_lama\\";
            string[] filePaths = Directory.GetFiles(folder1, "*.txt");
            foreach (var item in filePaths)
            {
                Console.WriteLine(item);
                BuatBagianDokumen.BuatBagian(item, item + "___dir");
                Console.WriteLine("-____________________________-");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            T01();
            Console.WriteLine("  -- FINISH");
        }
    }
}
