using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PenelitianFTS.SqliteRun
{
    [Table("BagianBuku_index")]
    public class BagianBuku_index
    {
        public Guid Id { get; set; }
        
        public string Isi { get; set; }

    }
}
