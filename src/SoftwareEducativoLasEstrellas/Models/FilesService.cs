using SoftwareEducativoLasEstrellas.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;

namespace SoftwareEducativoLasEstrellas.Models
{
    public class FilesService
    {
        private string resourcesDirectory;

        public FilesService(string resourcesDirectory)
        {
            this.resourcesDirectory = resourcesDirectory;
        }

        public IEnumerable<DocumentFile> DocumentFiles()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(resourcesDirectory);
                var files = from file in dirInfo.GetFilesByExtensions(DocumentFile.allowableDocuments)
                            select new DocumentFile(file.Name, TypeFrom(file.Extension), file.FullName);

                return files;

            }
            catch (UnauthorizedAccessException UAEx)
            {
                throw UAEx;
            }
            catch (PathTooLongException PathEx)
            {
                throw PathEx;
            }
        }

        public IEnumerable<MediaFile> MediaFiles()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(resourcesDirectory);

                var files = from file in dirInfo.GetFilesByExtensions(MediaFile.allowableMediaTypes)
                            select new MediaFile(file.Name, TypeFrom(file.Extension), file.FullName);

                return files;
            }
            catch (UnauthorizedAccessException UAEx)
            {
                throw UAEx;
            }
            catch (PathTooLongException PathEx)
            {
                throw PathEx;
            }
        }

        public IEnumerable<string> Categories()
        {
            try
            {
                return Directory.EnumerateDirectories(resourcesDirectory);
            }
            catch (UnauthorizedAccessException UAEx)
            {
                throw UAEx;
            }
            catch (PathTooLongException PathEx)
            {
                throw PathEx;
            }
        }
        
        private string TypeFrom(string extension)
        {
            return (MediaFile.allowableMediaTypes.Contains(extension)) ? "Media" : "Document";
        }
    }
}
