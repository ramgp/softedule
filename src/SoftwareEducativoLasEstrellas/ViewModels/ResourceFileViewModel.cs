using SoftwareEducativoLasEstrellas.Core;
using SoftwareEducativoLasEstrellas.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace SoftwareEducativoLasEstrellas.ViewModels
{
    public class ResourceFileViewModel : ViewModelBase
    {
        private ObservableCollection<ResourceFile> files;
        private FilesService filesService;
        private ResourceFile selectedFile;
        private string category;

        public ResourceFileViewModel(FilesService filesService)
        {
            this.filesService = filesService;
            files = new ObservableCollection<ResourceFile>(filesService.ResourceFiles());

            if (files.Count > 0) selectedFile = files.First();
        }

        public ObservableCollection<ResourceFile> MediaFiles
        {
            get { return files; }
        }

        public ResourceFile SelectedFile
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
