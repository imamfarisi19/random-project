using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PenelitianFTS.SqliteRun
{
    [Table("BagianBuku")]
    public class BagianBuku
    {
        public Guid Id { get; set; }

        public string Judul { get; set; }

        public int NomorBagian { get; set; }        

        public string Isi { get; set; }

    }
}
