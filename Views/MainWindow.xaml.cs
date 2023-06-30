using System.Windows;
using MiTe.ViewModels;
using MiTe.Storage;

namespace MiTe.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainStorage mainStorage = new MainStorage();
            mainStorage.loadAllData();
            DataContext = new LoginViewModel(mainStorage, this);
        }
    }
}
