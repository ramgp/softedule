using SoftwareEducativoLasEstrellas.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SoftwareEducativoLasEstrellas.ViewModels
{
    public class DocumentViewModel : ViewModelBase
    {
        private ObservableCollection<DocumentFile> files;
        private FilesService filesService;
        private DocumentFile selectedFile;
        private string category;

        public DocumentViewModel(FilesService filesService)
        {
            this.filesService = filesService;
            files = new ObservableCollection<DocumentFile>(filesService.DocumentFiles());

            if (files.Count > 0) selectedFile = files.First();
        }

        public ObservableCollection<DocumentFile> MediaFiles
        {
            get { return files; }
        }

        public DocumentFile SelectedFile
        {
            get { return selectedFile; }
            set 
            {
                if (value != selectedFile)
                { 
                    selectedFile = value;
                    RaisePropertyChanged("SelectedFile");
                }

            }
        }        

        public string Category
        {
            get { return category; }
            set 
            {
                if (value != category)
                {
                    category = value;
                    RaisePropertyChanged("Category");
                }

            }
        }
    }
}
