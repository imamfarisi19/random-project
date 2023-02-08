using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneSearch
{
    public class LuceneOperation
    {

        public static Document MyStandartDoc(Guid guidId,
            string source, string judul, string isi, string analyzedData)
        {

            Document doc = new Document();

            doc.Add(new Field("GuidId", guidId.ToString(), Field.Store.YES, Field.Index.ANALYZED_NO_NORMS));
            doc.Add(new Field("Source", source, Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("Judul", judul, Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("Isi", isi, Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("AnalyzedData", analyzedData, Field.Store.NO, Field.Index.ANALYZED));

            return doc;
        }

        public static void TestLuceneDirectory(string lucenePath)
        {
            Directory directory = FSDirectory.Open(lucenePath);
            if (!IndexReader.IndexExists(directory))
            {
                Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
                IndexWriter writer = new IndexWriter(directory, analyzer, true, IndexWriter.MaxFieldLength.UNLIMITED);

                Document doc = new Document();

                doc.Add(new Field("GuidId", Guid.NewGuid().ToString(), Field.Store.YES, Field.Index.ANALYZED_NO_NORMS));
                doc.Add(new Field("Source", "TEST", Field.Store.YES, Field.Index.NOT_ANALYZED));
                doc.Add(new Field("Judul", "ONLY", Field.Store.YES, Field.Index.NOT_ANALYZED));
                doc.Add(new Field("Isi", "TEST ONLY", Field.Store.YES, Field.Index.NOT_ANALYZED));
                doc.Add(new Field("AnalyzedData", "TEST ONLY", Field.Store.NO, Field.Index.ANALYZED));

                writer.AddDocument(doc);
                writer.Optimize();
                writer.Dispose();
            }
        }

        public static void AddFromBerita(string lucenePath, List<Models.BeritaDataSetBerita> beritas)
        {
            Directory directory = FSDirectory.Open(lucenePath);
            Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            IndexWriter writer = new IndexWriter(directory, analyzer, false, IndexWriter.MaxFieldLength.UNLIMITED);
            foreach (Models.BeritaDataSetBerita item in beritas)
            {
                Console.WriteLine(" -->  " + item.Title);
                Document doc = MyStandartDoc(Guid.Parse(item.id), "Berita", item.Title,
                    item.Content, item.BeritaContent());
                writer.AddDocument(doc);
            }
            
            writer.Optimize();
            writer.Dispose();
        }

        public static void WriteStandartDoc(string lucenePath, Document doc)
        {
            Directory directory = FSDirectory.Open(lucenePath);
            Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            IndexWriter writer = new IndexWriter(directory, analyzer, false, IndexWriter.MaxFieldLength.UNLIMITED);

            writer.AddDocument(doc);
            writer.Optimize();
            writer.Dispose();
        }

        public static void UpdateStandartDoc(string lucenePath, Document doc, Guid guidId)
        {
            Directory directory = FSDirectory.Open(lucenePath);
            Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            IndexWriter writer = new IndexWriter(directory, analyzer, false, IndexWriter.MaxFieldLength.UNLIMITED);

            // writer.AddDocument(doc);
            writer.UpdateDocument(new Term("GuidId", guidId.ToString()), doc);
            writer.Optimize();
            writer.Dispose();
        }

        public static void DeleteStandartDoc(string lucenePath, Guid guidId)
        {
            Directory directory = FSDirectory.Open(lucenePath);
            Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            IndexWriter writer = new IndexWriter(directory, analyzer, false, IndexWriter.MaxFieldLength.UNLIMITED);

            writer.DeleteDocuments(new Term("GuidId", guidId.ToString()));
            writer.Optimize();
            writer.Dispose();
        }

        
        public static string StripTagsCharArray(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                    return "";

                char[] array = new char[source.Length];
                int arrayIndex = 0;
                bool inside = false;

                for (int i = 0; i < source.Length; i++)
                {
                    char let = source[i];
                    if (let == '<')
                    {
                        inside = true;
                        continue;
                    }
                    if (let == '>')
                    {
                        inside = false;
                        continue;
                    }
                    if (!inside)
                    {
                        array[arrayIndex] = let;
                        arrayIndex++;
                    }
                }
                return new string(array, 0, arrayIndex);
            }
            catch (Exception)
            {
                return source;
            }            
        }

        public static List<Models.LuceneSearchResult> Search(string dataPath, string kataDicari, string kategori = null)
        {
            List<Models.LuceneSearchResult> hsl = new List<Models.LuceneSearchResult>();            
            int hitsLimit = 400;
            Directory lucDirectory = FSDirectory.Open(new System.IO.DirectoryInfo(dataPath));
            Analyzer lucAnalyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            QueryParser lucParser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "AnalyzedData", lucAnalyzer);
            Searcher lucSearcher = new IndexSearcher(Lucene.Net.Index.IndexReader.Open(lucDirectory, true));

            Query query = lucParser.Parse(kataDicari);
            TopScoreDocCollector collector = TopScoreDocCollector.Create(hitsLimit, true);
            lucSearcher.Search(query, collector);
            ScoreDoc[] hits = collector.TopDocs().ScoreDocs;

            
            for (int i = 0; i < hits.Length; i++)
            {
                int docId = hits[i].Doc;
                float score = hits[i].Score;

                Document doc = lucSearcher.Doc(docId);
                Models.LuceneSearchResult r1 = Models.LuceneSearchResult.Doc2LuceneSearchResult(doc, i + 1, score);
                if (string.IsNullOrEmpty(kategori))
                {
                    hsl.Add(r1);
                }
                else
                {
                    if (r1.Source == kategori)
                        hsl.Add(r1);
                }                  
            }
            
            return hsl;
        }
    }
}
