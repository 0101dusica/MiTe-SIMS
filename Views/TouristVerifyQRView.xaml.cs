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
using MiTe.Storage;
using MiTe.ViewModels;

namespace MiTe.Views
{
    /// <summary>
    /// Interaction logic for TouristVerifyQRView.xaml
    /// </summary>
    public partial class TouristVerifyQRView : Window
    {
        public TouristVerifyQRView(MainStorage mainStorage)
        {
            InitializeComponent();
            DataContext = new TouristVerifyQRViewModel(mainStorage, this);
        }
    }
}
