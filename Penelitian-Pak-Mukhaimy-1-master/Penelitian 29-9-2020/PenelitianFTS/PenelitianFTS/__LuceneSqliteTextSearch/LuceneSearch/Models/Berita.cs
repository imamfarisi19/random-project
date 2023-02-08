using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneSearch.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/BeritaDataSet.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/BeritaDataSet.xsd", IsNullable = false)]
    public partial class BeritaDataSet
    {

        private BeritaDataSetBerita[] beritaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Berita")]
        public BeritaDataSetBerita[] Berita
        {
            get
            {
                return this.beritaField;
            }
            set
            {
                this.beritaField = value;
            }
        }

        public static BeritaDataSet FromFile(string filename)
        {
            // Now we can read the serialized book ...  
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(BeritaDataSet));
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            BeritaDataSet hsl = (BeritaDataSet)reader.Deserialize(file);
            file.Close();
            return hsl;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/BeritaDataSet.xsd")]
    public partial class BeritaDataSetBerita
    {

        private string idField;

        private string titleField;

        private string linkField;

        private string pubDateField;

        private string contentField;

        private string contentSourceField;

        /// <remarks/>
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        public string PubDate
        {
            get
            {
                return this.pubDateField;
            }
            set
            {
                this.pubDateField = value;
            }
        }

        /// <remarks/>
        public string Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        public string ContentSource
        {
            get
            {
                return this.contentSourceField;
            }
            set
            {
                this.contentSourceField = value;
            }
        }

        public string BeritaContent() => 
            Title + Environment.NewLine +
            Link + Environment.NewLine +
            PubDate + Environment.NewLine +
            Content + Environment.NewLine +
            ContentSource;
    }


}
