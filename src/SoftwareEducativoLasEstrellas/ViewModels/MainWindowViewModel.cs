using SoftwareEducativoLasEstrellas.Core;
using SoftwareEducativoLasEstrellas.Models;
using System.Windows.Input;

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
            // TODO: change this to use a dynamic configurable path
            filesService = new FilesService(@"X:\softedule");
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
