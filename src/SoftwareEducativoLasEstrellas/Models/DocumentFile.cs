using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareEducativoLasEstrellas.Models
{
    public class DocumentFile : Showable
    {
        private string type;
        private string path;
        public static string[] allowableDocuments = 
                                { 
                                    ".pdf"
                                };

        public DocumentFile(string fileName, string type, string path)
        {
            FileName = fileName;
            this.type = type;
            this.path = path;
        }

        public string Type
        {
            get { return type; }
        }

        public string Path
        {
            get { return path; }
        }

        public bool ShowIn(Medium medium)
        {
            throw new NotImplementedException();
        }

        public string Category { get; set; }
        public string FileName { get; set; }
    }
}
