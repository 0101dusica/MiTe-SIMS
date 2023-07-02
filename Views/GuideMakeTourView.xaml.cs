using MiTe.Storage;
using MiTe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MiTe.Views
{
    /// <summary>
    /// Interaction logic for GuideMakeTourView.xaml
    /// </summary>
    public partial class GuideMakeTourView : Window
    {
        public GuideMakeTourView(MainStorage mainStorage)
        {
            InitializeComponent();
            DataContext = new GuideMakeTourViewModel(mainStorage, this);
        }
    }
}
