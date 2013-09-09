using SoftwareEducativoLasEstrellas.Core;
using SoftwareEducativoLasEstrellas.Models;
using System.Windows.Input;
using System.Configuration;

namespace SoftwareEducativoLasEstrellas.ViewModels
{    
    public class MainWindowViewModel : ViewModelBase
    {
        private object currentView;
        private string category;
        private readonly FilesService filesService;

        public MainWindowViewModel()
        {
            category = "Cuentos";
            filesService = new FilesService(@ConfigurationManager.AppSettings["Path"]);
            ShowResourceFileViewCommand = new RelayCommand(action => ShowResourceFileView(category));
        }

        private void ShowResourceFileView(string category)
        {
            CurrentView = new ResourceFileViewModel(filesService) { Category = category };
        }

        public object CurrentView
        {
            get { return currentView; }
            set 
            { 
                currentView = value;
                RaisePropertyChanged("CurrentView");
            }
        }

        public ICommand ShowResourceFileViewCommand { get; set; }
    }
}
