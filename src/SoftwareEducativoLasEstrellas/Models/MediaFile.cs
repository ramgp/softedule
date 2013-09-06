using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareEducativoLasEstrellas.Models
{
    public class MediaFile : Showable
    {
        private string type;
        private string path;
        public static string[] allowableMediaTypes = 
                                { 
                                    ".mpg", ".mpeg", ".m1v", ".mp2", ".mpa", 
                                    ".mpe", ".avi",".wmv", ".mp3", ".mp4"
                                };

        public MediaFile(string fileName, string type, string file)
        {
            FileName = fileName;
            this.type = type;
            this.path = file;
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
