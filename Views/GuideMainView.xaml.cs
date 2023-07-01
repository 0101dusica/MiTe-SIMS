using MiTe.Storage;
using MiTe.ViewModels;
using System.Windows;

namespace MiTe.Views
{
    /// <summary>
    /// Interaction logic for GuideMainView.xaml
    /// </summary>
    public partial class GuideMainView : Window
    {
        public GuideMainView(MainStorage mainStorage)
        {
            InitializeComponent();
            DataContext = new GuideMainViewModel(mainStorage, this);
        }
    }
}
