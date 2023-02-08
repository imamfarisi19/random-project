using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PenelitianFTS.LuceneRun
{
    public class LuceneSearchResult
    {
        public enum EnumLuceneDocCategory
        {
            Blog, GaleryFoto, Konsultasi, ThePage
        }

        private const int maxIsiRingkas = 240;

        public Guid Id { get; set; }
        public int NomorUrut { get; set; }
        public string Judul { get; set; }
        public int NomorBagian { get; set; }
        public string Isi { get; set; }
        public string IsiRingkas { get; set; }
        public float Score { get; set; }
        public string Link { get; set; }

        public static LuceneSearchResult Doc2LuceneSearchResult(Document doc, int nomorUrut1, float score1)
        {
            LuceneSearchResult result1 = new LuceneSearchResult()
            {
                Id = Guid.Parse(doc.Get("Id")),                
                Judul = doc.Get("Judul"),
                NomorBagian = int.Parse(doc.Get("NomorBagian")),
                Isi = doc.Get("Isi"),
                NomorUrut = nomorUrut1,
                Score = score1
            };
            result1.IsiRingkas = Regex.Replace(result1.Isi, @"\s+", " ");
            if (result1.IsiRingkas.Length > maxIsiRingkas)
            {

                string[] words = result1.IsiRingkas.Split(' ');
                //initialize return variable 
                string paragraphToReturn = string.Empty;
                //construct the return word 
                foreach (string word in words)
                {
                    //check if adding 3 to current length and next word is more than maximum length. 
                    if ((paragraphToReturn.Length + word.Length + 3) > maxIsiRingkas)
                    {
                        paragraphToReturn = paragraphToReturn.Trim() + "...";
                        break;
                    }
                    paragraphToReturn += word + " ";
                }
                result1.IsiRingkas = paragraphToReturn;
            }

            return result1;
        }

    }
}