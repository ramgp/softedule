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

        public IEnumerable<ResourceFile> ResourceFiles()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(resourcesDirectory);

                var files = from file in dirInfo.GetFilesByExtensions(ResourceFile.AllowableResourceTypes)
                            select new ResourceFile(file.Name, TypeFrom(file.Extension), file.FullName);

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
            return (extension == ".pdf") ? "Document" : "Media";
        }
    }
}
