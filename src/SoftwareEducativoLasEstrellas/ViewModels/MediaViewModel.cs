using SoftwareEducativoLasEstrellas.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SoftwareEducativoLasEstrellas.ViewModels
{
    public class MediaViewModel : ViewModelBase
    {
        private ObservableCollection<MediaFile> files;
        private FilesService filesService;
        private MediaFile selectedFile;
        private string category;

        public MediaViewModel(FilesService filesService)
        {
            this.filesService = filesService;
            files = new ObservableCollection<MediaFile>(filesService.MediaFiles());

            if (files.Count > 0) selectedFile = files.First();
        }

        public ObservableCollection<MediaFile> MediaFiles
        {
            get { return files; }
        }

        public MediaFile SelectedFile
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
