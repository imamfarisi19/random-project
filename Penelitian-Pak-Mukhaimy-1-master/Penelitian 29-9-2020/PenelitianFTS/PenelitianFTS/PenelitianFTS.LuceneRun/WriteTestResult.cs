using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenelitianFTS.LuceneRun
{
    public class WriteTestResult
    {
        // public int Nomor { get; set; }
        
        public string NamaFolder { get; set; }

        public int JumlahFile { get; set; }

        public TimeSpan LamaKerja { get; set; }

        public override string ToString()
        {
            return string.Format($"{NamaFolder}\t{JumlahFile}\t{LamaKerja}");
        }
    }
}
