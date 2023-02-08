using System;
using System.Collections.Generic;
using System.Text;

namespace PenelitianFTS.SqliteRun
{
    public class MatchTestResult
    {
        public string KataKunci { get; set; }

        public int JumlahHit { get; set; }

        public string PertamaJudulBuku { get; set; }

        public int PertamaNomorPart { get; set; }

        public TimeSpan LamaKerja { get; set; }

        public override string ToString()
        {
            return string.Format($"{KataKunci}\t{JumlahHit}\t{LamaKerja}");
        }
    }
}
