using SoftwareEducativoLasEstrellas.Models;
using SoftwareEducativoLasEstrellas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SoftwareEducativoLasEstrellas.Views
{
    /// <summary>
    /// Interaction logic for MediaView.xaml
    /// </summary>
    public partial class MediaView : UserControl
    {
        public MediaView()
        {
            InitializeComponent();

            FilesService fileService = new FilesService(@"d:\devdoc\others");
            DataContext = new MediaViewModel(fileService);
        }
    }
}
