using Lucene.Net.Documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace PenelitianFTS.LuceneRun
{

    public class BagianBuku
    {
        public Guid Id { get; set; }

        public string Judul { get; set; }

        public int NomorBagian { get; set; }

        public string Isi { get; set; }

        public Lucene.Net.Documents.Document ToLuceneDocument()
        {
            Lucene.Net.Documents.Document doc = new Lucene.Net.Documents.Document();

            doc.Add(new Field("Id", Id.ToString(), Field.Store.YES, Field.Index.ANALYZED_NO_NORMS));
            doc.Add(new Field("Judul", Judul, Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("NomorBagian", NomorBagian.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("Isi", Isi, Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("AnalyzedData", Isi, Field.Store.NO, Field.Index.ANALYZED));

            return doc;
        }
    }
}
