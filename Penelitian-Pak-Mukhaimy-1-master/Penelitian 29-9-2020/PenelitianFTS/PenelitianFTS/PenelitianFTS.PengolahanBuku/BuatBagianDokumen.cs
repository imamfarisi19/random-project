using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PenelitianFTS.PengolahanBuku
{
    public class BuatBagianDokumen
    {
        //private string _filetext;

        //public BuatBagianDokumen(string _filetext)
        //{

        //}

        public static void BuatBagian(string filetext, string outputFolder)
        {
            if (!File.Exists(filetext))
            {
                Console.WriteLine("Filetext tidak ada");
                return;
            }
                

            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);

            int idx = 1;
            string isiFile = "";
            int maxtext = 2000;
            string endGut = "End of the Project Gutenberg EBook";
            endGut = endGut.ToLower();

            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(filetext);
            while ((line = file.ReadLine()) != null)
            {
                line = line.Trim();
                
                if (line.ToLower().Contains(endGut)) break;

                isiFile += line + Environment.NewLine;
                if(string.IsNullOrEmpty(line) && isiFile.Length > maxtext)
                {
                    string outputFileText = outputFolder + "\\" + idx++.ToString("0000") + ".txt";
                    File.WriteAllText(outputFileText, isiFile);
                    isiFile = "";
                }                
            }
            if (isiFile.Length > 100)
            {
                string outputFileText = outputFolder + "\\" + idx.ToString("0000") + ".txt";
                File.WriteAllText(outputFileText, isiFile);
                isiFile = "";
            }

            file.Close();
            System.Console.WriteLine($"There were {idx} part.");
        }
    }
}
