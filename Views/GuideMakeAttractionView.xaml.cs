using MiTe.Storage;
using MiTe.ViewModels;
using System.Windows;

namespace MiTe.Views
{
    /// <summary>
    /// Interaction logic for GuideMakeAttractionView.xaml
    /// </summary>
    public partial class GuideMakeAttractionView : Window
    {
        public GuideMakeAttractionView(MainStorage mainStorage)
        {
            InitializeComponent();
            DataContext = new GuideMakeAttractionViewModel(mainStorage, this);
        }
    }
}
