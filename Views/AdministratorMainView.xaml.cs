
using MiTe.Storage;
using MiTe.ViewModels;
using System.Windows;

namespace MiTe.Views
{
    /// <summary>
    /// Interaction logic for AdministratorMainView.xaml
    /// </summary>
    public partial class AdministratorMainView : Window
    {
        public AdministratorMainView(MainStorage mainStorage)
        {
            InitializeComponent();
            DataContext = new AdministratorMainViewModel(mainStorage, this);
        }
    }
}
