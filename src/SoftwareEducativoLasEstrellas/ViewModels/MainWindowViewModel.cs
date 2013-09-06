using SoftwareEducativoLasEstrellas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            filesService = new FilesService(@"d:\devdoc\others");
            ShowMediaViewCommand = new RelayCommand(action => ShowMediaView(category));
            ShowDocumentViewCommand = new RelayCommand(action => ShowDocumentView(category));

            ShowDocumentViewCommand.Execute(this);
        }

        private void ShowDocumentView(string category)
        {
            CurrentView = new MediaViewModel(filesService) { Category = category };
        }

        private void ShowMediaView(string category)
        {
            CurrentView = new DocumentViewModel(filesService) { Category = category };
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

        public ICommand ShowMediaViewCommand { get; set; }
        public ICommand ShowDocumentViewCommand { get; set; }

    }
}
