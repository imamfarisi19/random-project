using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneSearch.Models
{
    public class Berita
    {
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Link { get; set; }
		public DateTime PubDate { get; set; }
		public string Content { get; set; }
		public string ContentSource { get; set; }
	}

	public class BeritaDataSet
	{
		public List<Berita> Beritas { get; set; }
		public string Xmlns { get; set; }

		public static BeritaDataSet FromFile(string filepath)
		{
			// Now we can read the serialized book ...  
			System.Xml.Serialization.XmlSerializer reader =
				new System.Xml.Serialization.XmlSerializer(typeof(BeritaDataSet));
			System.IO.StreamReader file = new System.IO.StreamReader(filepath);
			BeritaDataSet hsl = (BeritaDataSet)reader.Deserialize(file);
			file.Close();
			return hsl;
		}
	}
}
